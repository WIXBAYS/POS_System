using System;
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
    public partial class GNR : Form
    {
        public GNR()
        {
            InitializeComponent();
            textBoxBarcode.Select();
        }

        int GRN_No_For_Reort = 0;

        private void buttonsave_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            int Current_GRN_No = 0;
            decimal Current_Stock_Balance = 0.0m;
            SqlDataReader sdr= stock.GetMaxGRNNo();
            try
            {
                sdr.Read();
                Current_GRN_No = sdr.GetInt32(0);
                sdr.Close();
            }
            catch { }

            int y = 0;
            int x = 0;
            int GRN_No = Current_GRN_No + 1;
            for (int i = 0; i < dataGridViewAll.Rows.Count - 1; ++i)
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
                
                
                x = stock.InsertTransaction(GRN_No, Convert.ToInt32(dataGridViewAll.Rows[i].Cells[0].Value), Quantity, "STOCK_ADD", Quantity, 0,0,0, Current_Stock_Balance, (Quantity + Current_Stock_Balance), Properties.Settings.Default.username, DateTime.Parse("1900-01-01"), comboBoxVender.SelectedValue.ToString().Trim());
                if (x > 0)
                {
                    y = stock.UpdateStockBalance(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[0].Value), Quantity);
                    GRN_No_For_Reort = GRN_No;
                }
                
            }
            if (x > 0 && y > 0)
            {
                MessageBox.Show(" Successfully Added");
                dataGridViewAll.Rows.Clear();
                textBoxQuantity.Text = "";
                textBoxBarcode.Text = "";
                textBoxBuying.Text = "";
                textBoxSelling.Text = "";
                textBoxUnit.Text = "";
                comboBoxCatID.Text = "";
                comboBoxVender.Text = "";
                buttonGNReport.Visible = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Decimal Cost = 0.0m;
            if (TextVAlidation())
            { 
                Cost = decimal.Parse(textBoxQuantity.Text) * decimal.Parse(textBoxBuying.Text);
                dataGridViewAll.Rows.Add(comboBoxCatID.SelectedValue.ToString().Trim(), comboBoxCatID.Text.Trim(), textBoxQuantity.Text.Trim(), textBoxUnit.Text, Cost);
                Stock stock = new Stock();

                decimal sum = 0;
                for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[4].Value);
                }
                textBoxTotal.Text = sum.ToString();
            }

            textBoxQuantity.Text = "";
            textBoxBarcode.Text = "";
            textBoxBuying.Text = "";
            textBoxSelling.Text = "";
            textBoxUnit.Text = "";
            comboBoxCatID.Text = "";
        }

        private void GRN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetVenderDetails.Vender_Details' table. You can move, or remove it, as needed.
            this.vender_DetailsTableAdapter1.Fill(this.pOSDataSetVenderDetails.Vender_Details);
            // TODO: This line of code loads data into the 'pOSDataSet1.Vender_Details' table. You can move, or remove it, as needed.
            this.vender_DetailsTableAdapter.Fill(this.pOSDataSet1.Vender_Details);
            // TODO: This line of code loads data into the 'pOSDataSetItemCataagory.Item_Catagory' table. You can move, or remove it, as needed.
            this.item_CatagoryTableAdapter.Fill(this.pOSDataSetItemCataagory.Item_Catagory);

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

                if (textBoxUnit.Text.Trim() == String.Empty)
                {
                    textBoxUnit.BackColor = Color.LightPink;
                    valid = false;
                }
                else
                    textBoxUnit.BackColor = Color.White;

                if (comboBoxVender.Text.Trim() == String.Empty)
                {
                    comboBoxVender.BackColor = Color.LightPink;
                    valid = false;
                }
                else
                    comboBoxVender.BackColor = Color.White;

            return valid;

        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            textBoxUnit.Text = "";
            String Barcode = textBoxBarcode.Text.Trim();
            String Unit;
            SqlDataReader sdr = new Item().GetCategoryDetailsByBarcode(Barcode);
            if (sdr != null)
            {
                sdr.Read();
                textBoxUnit.Text = sdr.GetString(3);

                textBoxBuying.Text = sdr.GetDecimal(4).ToString();
                textBoxSelling.Text = sdr.GetDecimal(5).ToString();
                comboBoxCatID.SelectedValue= sdr.GetInt32(2).ToString();
                comboBoxCatID.Text = sdr.GetString(1).ToString();
                sdr.Close();
                

                buttonGNReport.Visible = false;
            }
            else
            {
                textBoxQuantity.Clear();
                textBoxBuying.Clear();
                textBoxSelling.Clear();
                textBoxUnit.Text = "";
                comboBoxCatID.Text = "";
            }
        }

        private void comboBoxCatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxUnit.Text = "";
            textBoxBarcode.Text = "";
            String CatID = comboBoxCatID.SelectedValue.ToString().Trim();
            String Unit;
            SqlDataReader sdr = new Item().GetItemCatagoryDetails(CatID);
            if (sdr != null)
            {
                sdr.Read();
                textBoxUnit.Text= sdr.GetString(3);
                textBoxBarcode.Text = sdr.GetString(0);
                textBoxBuying.Text = sdr.GetDecimal(4).ToString();
                textBoxSelling.Text = sdr.GetDecimal(5).ToString();
                
                sdr.Close();
                

                buttonGNReport.Visible = false;
            }
            else
            {
                textBoxQuantity.Clear();
                textBoxBuying.Clear();
                textBoxSelling.Clear();
                textBoxUnit.Text = "";
                comboBoxCatID.Text = "";
            }

        }

        private void buttonGNReport_Click(object sender, EventArgs e)
        {
            if (GRN_No_For_Reort > 0)
            {
                GRN_Report GRNREP = new GRN_Report(GRN_No_For_Reort);
                GRNREP.Show();
            }
        }
    }
}
