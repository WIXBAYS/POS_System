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
    public partial class Item_Return : Form
    {
        public Item_Return()
        {
            InitializeComponent();
        }

        private void Item_Return_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetItemCataagory.Item_Catagory' table. You can move, or remove it, as needed.
            this.item_CatagoryTableAdapter.Fill(this.pOSDataSetItemCataagory.Item_Catagory);
            // TODO: This line of code loads data into the 'pOSDataSet3.Invoice_Data' table. You can move, or remove it, as needed.
            this.invoice_DataTableAdapter.Fill(this.pOSDataSet3.Invoice_Data);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewAll.Rows.Clear();
            Stock stock = new Stock();
            SqlDataReader sdr = stock.GetInvoiceDetails(comboBoxInvoiceNo.SelectedValue.ToString());
            if (sdr != null)
            {
                while (sdr.Read())
                {
                    int TransactionID = sdr.GetInt32(0);
                    string Barcode = sdr.GetString(1);
                    string CategoryName = sdr.GetString(2);
                    string Unit = sdr.GetString(3);
                    Decimal UnitPrice = sdr.GetDecimal(4);
                    Decimal DiscountAmount = sdr.GetDecimal(5);
                    Decimal CatQuantity = sdr.GetDecimal(6);
                    Decimal NetAmount = sdr.GetDecimal(7);
                    int CategoryID = sdr.GetInt32(8);
                    dataGridViewAll.Rows.Add(TransactionID, Barcode, CategoryName, Unit, UnitPrice, DiscountAmount, CatQuantity, NetAmount, CategoryID);
                }
                sdr.Close();
                SetSummery();
            }
        }

        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Stock stock = new Stock();
            var currentcellVal = dataGridViewAll.CurrentCellAddress;
            if (e.ColumnIndex == 9)
            {
                int TransactionID = Convert.ToInt32(dataGridViewAll.Rows[currentcellVal.Y].Cells[0].Value);
                stock.RecallItem(false, TransactionID);
                int y = stock.UpdateStockBalance(Convert.ToInt32(dataGridViewAll.Rows[currentcellVal.Y].Cells[8].Value), Convert.ToInt32(dataGridViewAll.Rows[currentcellVal.Y].Cells[6].Value));
                int x = dataGridViewAll.CurrentRow.Index;
                dataGridViewAll.Rows.Remove(dataGridViewAll.Rows[x]);
                SetSummery();
            }
        }
        public void SetSummery()
        {
            Stock stock = new Stock();
            Decimal TotalAmount = 0.0m;
            Decimal ReturnedAmount = 0.0m;
            try
            {
                
                SqlDataReader sdr = stock.GetRecallInvoiceDetails(comboBoxInvoiceNo.SelectedValue.ToString());
                if (sdr != null)
                {

                    while (sdr.Read())
                    {
                         ReturnedAmount = sdr.GetDecimal(0);
                    }
                    sdr.Close();
                }
                textBoxReturnedAmount.Text = ReturnedAmount.ToString();
            }
            catch { }
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
               
                try
                {
                    TotalAmount += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                }
                catch { }
                textBoxExchangedAmount.Text = TotalAmount.ToString();
            }
            textBoxBalanceAmount.Text= (TotalAmount- ReturnedAmount).ToString();

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            try
            {
                string BARCODE = "";
                if (textBoxBarCode.Text != "")
                {
                    BARCODE = textBoxBarCode.Text.Trim();

                    SqlDataReader sqd = item.GetCategoryDetailsByBarcodeAll(BARCODE);

                    if (sqd != null)
                    {
                        while (sqd.Read())
                        {
                            comboBoxName.SelectedIndex = comboBoxName.FindString(sqd.GetString(1));
                        }
                        sqd.Close();
                    }
                }
            }
            catch { }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Decimal Cost = 0.0m;

            string CatID = comboBoxName.SelectedValue.ToString().Trim();
            SqlDataReader sdrsec = new Item().GetItemCatagoryDetails(CatID);
            if (sdrsec != null)
            {
                try
                {
                    String DiscountCol = "";
                    String CategoryName = "";
                    String Unit = "";
                    Decimal UnitPrice = 0.0m;
                    Decimal DiscountAmnt1 = 0.0m;
                    sdrsec.Read();
                    CategoryName = sdrsec.GetString(1).Trim();
                    Unit = sdrsec.GetString(3).Trim();
                    UnitPrice = Math.Round(sdrsec.GetDecimal(5), 2);
                    Decimal DiscountAmount = Math.Round(sdrsec.GetDecimal(8), 2);
                    String DiscountType = sdrsec.GetString(9).ToString().Trim();
                    Boolean DiscountPeriodically = sdrsec.GetBoolean(14);
                    DateTime DiscountFrom = sdrsec.GetDateTime(12);
                    DateTime DiscountTo = sdrsec.GetDateTime(13);
                    if (!DiscountPeriodically || (DiscountPeriodically && (DateTime.Now.Date >= DiscountFrom && DateTime.Now.Date <= DiscountTo)))
                    {
                        if (DiscountType.Equals("AMNT"))
                        {
                            DiscountCol = DiscountAmount + "/=";
                            DiscountAmnt1 = DiscountAmount;
                        }
                        if (DiscountType.Equals("PR"))
                        {
                            DiscountCol = DiscountAmount + "%";
                            DiscountAmnt1 = Math.Round((sdrsec.GetDecimal(5) * DiscountAmount / 100), 2);
                        }
                    }
                    dataGridView1.Rows.Add(CategoryName, UnitPrice, textBoxQuantity.Text, ((UnitPrice) * decimal.Parse(textBoxQuantity.Text)).ToString(), ((DiscountAmnt1) * decimal.Parse(textBoxQuantity.Text)).ToString(),  ((UnitPrice - DiscountAmnt1) * decimal.Parse(textBoxQuantity.Text)).ToString(), CatID);
                }
                catch { }


                SetSummery();


                textBoxQuantity.Clear();
                //textBoxSelling.Clear();
                //textBoxbuy.Clear();
                comboBoxName.Text = "";
            }
        }

        private void textBoxReturnedAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentcellVal = dataGridView1.CurrentCellAddress;
            if (e.ColumnIndex == 7)
            {
                int x = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Remove(dataGridView1.Rows[x]);
                SetSummery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            int Current_Exchange_No = 0;
            decimal Current_Stock_Balance = 0.0m;
            SqlDataReader sdr = stock.GetMaxExchangeNo();
            Decimal TotalAmount = 0.0m;
            Decimal Quantity = 0.0m;
            Decimal UnitPrice = 0.0m;
            Decimal Discount = 0.0m;
            try
            {
                sdr.Read();
                Current_Exchange_No = sdr.GetInt32(0);
                sdr.Close();
            }
            catch { }

            int y = 0;
            int x = 0;
            int z = 0;
            int Invoce_No = Current_Exchange_No + 1;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                try
                {
                    TotalAmount = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    Quantity = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    UnitPrice = Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value);
                    Discount = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                    SqlDataReader sdr1 = stock.GetStockBalance(Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value));
                    try
                    {
                        sdr1.Read();
                        Current_Stock_Balance = sdr1.GetDecimal(0);
                        sdr1.Close();
                        if (Current_Stock_Balance < Quantity)
                        {
                            MessageBox.Show("Not Enough items in the stock", "Error");
                        }
                        else
                        {
                            x = stock.InsertTransaction(Invoce_No, Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value), Quantity, "Exchange", 0, (Quantity * UnitPrice), Discount, TotalAmount, Current_Stock_Balance, (Current_Stock_Balance - Quantity), Properties.Settings.Default.username, DateTime.Parse("1900-01-01"), "0", int.Parse(comboBoxInvoiceNo.SelectedValue.ToString()));
                            if (x > 0)
                            {
                                y = stock.UpdateStockBalance(Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value), Quantity * -1);
                            }
                        }

                    }
                    catch { }
                }
                catch { }
                textBoxExchangedAmount.Text = TotalAmount.ToString();
            }
            dataGridViewAll.Rows.Clear();
            dataGridView1.Rows.Clear();
            textBoxReturnedAmount.Text = "";
            textBoxExchangedAmount.Text = "";
            textBoxBalanceAmount.Text = ""; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
