﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Invoice : Form
    {
        bool executionenable = true;

        public Invoice()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetItemCataagory.Item_Catagory' table. You can move, or remove it, as needed.
            this.item_CatagoryTableAdapter.Fill(this.pOSDataSetItemCataagory.Item_Catagory);
            // TODO: This line of code loads data into the 'pOSDataSetVendorList.Vender_Details' table. You can move, or remove it, as needed.
            this.vender_DetailsTableAdapter.Fill(this.pOSDataSetVendorList.Vender_Details);

        }

        private void comboBoxCatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (executionenable)
            {
                lockExecution();

                if (comboBoxCatID.SelectedValue != null)
                {
                    comboBoxunits.Items.Clear();
                    comboBoxunits.Text = "";

                    String catID = comboBoxCatID.SelectedValue.ToString();
                    String Unit;
                    SqlDataReader sdr = new Item().GetItemCatagoryDetails(catID);

                    if (sdr != null)
                    {
                        sdr.Read();

                        Unit = sdr.GetString(3);
                        textBoxBarcode.Text = sdr.GetString(0);
                        textBoxSelling.Text = sdr.GetDouble(5).ToString();

                        sdr.Close();
                        if (Unit.Equals("L"))
                        {
                            comboBoxunits.Items.Add("L");
                            comboBoxunits.Items.Add("ml");
                        }
                        else if (Unit.Equals("Kg"))
                        {
                            comboBoxunits.Items.Add("Kg");
                            comboBoxunits.Items.Add("g");
                            comboBoxunits.Items.Add("mg");
                        }
                        else
                        {
                            comboBoxunits.Items.Add("Units");
                        }
                    }
                    else
                    {
                        ClearTextForm();
                    }
                }

                ReleaseExecution();
            }
        }

        private void ClearTextForm()
        {
            textBoxQuantity.Clear();
            textBoxSelling.Clear();
            comboBoxunits.Items.Clear();
            comboBoxunits.Text = "";
            comboBoxCatID.Text = "";
        }

        private void lockExecution()
        {
            executionenable = false;
        }

        private void ReleaseExecution()
        {
            executionenable = true;
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {

            if (executionenable)
            {
                lockExecution();
                comboBoxunits.Items.Clear();
                comboBoxunits.Text = "";
                String Barcode = textBoxBarcode.Text.Trim();
                String Unit;
                SqlDataReader sdr = new Item().GetCatagoryDetailsByBarcode(Barcode);
                if (sdr != null)
                {
                    sdr.Read();
                    Unit = sdr.GetString(3);

                    textBoxSelling.Text = sdr.GetDouble(5).ToString();
                    textBoxbuy.Text = sdr.GetDouble(4).ToString();
                    comboBoxCatID.SelectedValue = sdr.GetInt32(2).ToString();
                    comboBoxCatID.Text = sdr.GetString(1).ToString();

                    sdr.Close();
                    if (Unit.Equals("L"))
                    {
                        comboBoxunits.Items.Add("L");
                        comboBoxunits.Items.Add("ml");
                    }
                    else if (Unit.Equals("Kg"))
                    {
                        comboBoxunits.Items.Add("Kg");
                        comboBoxunits.Items.Add("g");
                        comboBoxunits.Items.Add("mg");
                    }
                    else
                    {
                        comboBoxunits.Items.Add("Units");
                    }
                }
                else
                {
                    ClearTextForm();
                }

                ReleaseExecution();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Decimal Cost = 0.0m;
            if (TextVAlidation())
            {

                if (comboBoxunits.Text.Equals("L") || comboBoxunits.Text.Equals("Kg") || comboBoxunits.Text.Equals("Units")) Cost = decimal.Parse(textBoxQuantity.Text) * decimal.Parse(textBoxSelling.Text);
                else if (comboBoxunits.Text.Equals("ml") || comboBoxunits.Text.Equals("g")) Cost = decimal.Parse(textBoxQuantity.Text) * decimal.Parse(textBoxSelling.Text) / 1000;
                else if (comboBoxunits.Text.Equals("mg")) Cost = decimal.Parse(textBoxQuantity.Text) * decimal.Parse(textBoxSelling.Text) / 1000000;
                dataGridViewAll.Rows.Add(comboBoxCatID.SelectedValue.ToString().Trim(), comboBoxCatID.Text.Trim(), textBoxQuantity.Text.Trim(), comboBoxunits.Text, Cost);

                decimal sum = 0;
                for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[4].Value);
                }
                textBoxTotal.Text = sum.ToString();

                textBoxQuantity.Clear();
                textBoxBarcode.Clear();
                textBoxSelling.Clear();
                textBoxbuy.Clear();
                comboBoxCatID.Text = "";
                comboBoxunits.Items.Clear();
                comboBoxunits.Text = "";
            }
        }

        private bool TextVAlidation()
        {
            bool valid = true;

            if (textBoxQuantity.Text.Trim() == String.Empty)
            {
                textBoxQuantity.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxQuantity.BackColor = Color.White;

            if (comboBoxunits.Text.Trim() == String.Empty)
            {
                comboBoxunits.BackColor = Color.LightPink;
                valid = false;
            }
            else
                comboBoxunits.BackColor = Color.White;
            return valid;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            StockUpdate("Credit");
        }

        private void buttoncash_Click(object sender, EventArgs e)
        {
            StockUpdate("Cash");
        }


        private void StockUpdate(String PaymentType)
        {
            Stock stock = new Stock();
            int Current_Invoice_No = 0;
            decimal Current_Stock_Balance = 0.0m;
            SqlDataReader sdr = stock.GetMaxInvoiceNo();
            try
            {
                sdr.Read();
                Current_Invoice_No = sdr.GetInt32(0);
                sdr.Close();
            }
            catch { }

            int y = 0;
            int x = 0;
            int z = 0;
            int Invoce_No = Current_Invoice_No + 1;

            for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
            {
                SqlDataReader sdr1 = stock.GetStockBalance(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[0].Value));
                try
                {
                    sdr1.Read();
                    Current_Stock_Balance = sdr1.GetDecimal(0);
                    sdr1.Close();
                }
                catch { }
   
                decimal Quantity = Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[2].Value);
                string Units = dataGridViewAll.Rows[i].Cells[3].Value.ToString().Trim();
                if (Units.Equals("g") || Units.Equals("ml")) Quantity = Quantity / 1000;
                else if (Units.Equals("mg")) Quantity = Quantity / 1000000;

                if (Current_Stock_Balance >= Quantity)
                {

                    x = stock.InsertTransaction(Invoce_No, Convert.ToInt32(dataGridViewAll.Rows[i].Cells[0].Value), Quantity, "Customer_Invoice", Quantity, 0, Current_Stock_Balance, (Current_Stock_Balance - Quantity), Properties.Settings.Default.username, DateTime.Parse("1900-01-01"), "0");
                    if (x > 0)
                    { 
                        y = stock.UpdateStockBalance(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[0].Value), Quantity * -1);
                        z = stock.InsertIvoice(Invoce_No,decimal.Parse(textBoxTotal.Text),0,0,DateTime.Now);
                    }
                }
                else { MessageBox.Show(" Stock Balance Error"); }
            }
            if (x > 0 && y > 0 && z > 0)
            {
                MessageBox.Show(" Successfully Added");
                dataGridViewAll.ClearSelection();
                textBoxQuantity.Clear();
                textBoxBarcode.Clear();
                dataGridViewAll.Text = "";
                textBoxSelling.Clear();
                comboBoxunits.Items.Clear();
                comboBoxCatID.Text = "";
                textBox1.Clear();
            }
        }

        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x = dataGridViewAll.CurrentRow.Index;
                dataGridViewAll.Rows.Remove(dataGridViewAll.Rows[x]);
                decimal sum = 0;
                for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[4].Value);
                }
                textBoxTotal.Text = sum.ToString();
            }
            catch { }
        }
    }
}
