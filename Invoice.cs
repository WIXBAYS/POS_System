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
using PrinterUtility;

namespace POS
{
    public partial class Invoice : Form
    {
        bool executionenable = true;
        public static string InvoiceNumber;
        public static string TotalAmount;
        public static string DiscountAmount;
        public static string LineDiscountAmount;
        public static string DateTimeInvoice;
        public static string PaidAmount;
        public static string Balance;

        public Invoice()
        {
            InitializeComponent();
            timer1.Start();
            Hiddenlabel1.Text = Properties.Settings.Default.username;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetItemCataagory.Item_Catagory' table. You can move, or remove it, as needed.
            this.item_CatagoryTableAdapter.Fill(this.pOSDataSetItemCataagory.Item_Catagory);
            buttonBill_Print.Enabled = false;
        }


        private void ClearTextForm()
        {
            textBoxQuantity.Clear();
            textBoxSelling.Clear();
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




        private void button_update_Click(object sender, EventArgs e)
        {
            Decimal Cost = 0.0m;

                string CatID = comboBoxCatID.SelectedValue.ToString().Trim();
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
                    dataGridViewAll.Rows.Add("N/A", CategoryName, Unit, UnitPrice, DiscountCol, DiscountAmnt1.ToString(),textBoxQuantity.Text, ((UnitPrice-DiscountAmnt1) * decimal.Parse(textBoxQuantity.Text)).ToString(), CatID);
                }
                    catch { }


                SetSummery();


                textBoxQuantity.Clear();
                //textBoxSelling.Clear();
                //textBoxbuy.Clear();
                comboBoxCatID.Text = "";
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


            return valid;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            int CategoryID = checkstockbalance();
            if (CategoryID == 0)
            {
                StockUpdate("Credit");
            }
            else
            {
                SqlDataReader sdr = new Item().GetItemCatagoryDetails(CategoryID.ToString());
                if(sdr!=null)
                {
                    sdr.Read();
                    MessageBox.Show(" Stock Balance Error -"+ sdr.GetString(1).Trim()); 

                }
            }
        }

        private void buttoncash_Click(object sender, EventArgs e)
        {
            StockUpdate("Cash");
        }

        public int checkstockbalance()
        {
            int CategoryID = 0;
            Stock stock = new Stock();
            Decimal Current_Stock_Balance = 0.0m;
            for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
            {
                SqlDataReader sdr1 = stock.GetStockBalance(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[8].Value));
                try
                {
                    sdr1.Read();
                    Current_Stock_Balance = sdr1.GetDecimal(0);
                    sdr1.Close();
                }
                catch { }

                decimal Quantity = Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value);


                if (Current_Stock_Balance < Quantity)
                {

                    CategoryID = Convert.ToInt32(dataGridViewAll.Rows[i].Cells[8].Value);
                    return CategoryID;
                }

            }
            return CategoryID;
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
            InvoiceNumber = Invoce_No.ToString();

            for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
            {
                decimal sum = Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[7].Value);
                decimal netdiscountline = (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                decimal sumoriginal = (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                SqlDataReader sdr1 = stock.GetStockBalance(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[8].Value));
                try
                {
                    sdr1.Read();
                    Current_Stock_Balance = sdr1.GetDecimal(0);
                    sdr1.Close();
                    decimal Quantity = Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value);
                    x = stock.InsertTransaction(Invoce_No, Convert.ToInt32(dataGridViewAll.Rows[i].Cells[8].Value), Quantity, "Customer_Invoice", 0, sumoriginal, netdiscountline, sum, Current_Stock_Balance, (Current_Stock_Balance - Quantity), Properties.Settings.Default.username, DateTime.Parse("1900-01-01"), "0");
                    if (x > 0)
                    {
                        y = stock.UpdateStockBalance(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[8].Value), Quantity * -1);
                    }
                }
                catch { }

            }
            z = stock.InsertIvoice(Invoce_No, decimal.Parse(textBoxTotal.Text), decimal.Parse(textBoxNetDiscount.Text), decimal.Parse(textBoxtTlLineDiscount.Text),0.0m, DateTime.Now,decimal.Parse(textBoxPaidAmount.Text), decimal.Parse(textBoxVoucherAmount.Text), decimal.Parse(textBoxBalanceAmount.Text));
            
            TotalAmount = textBoxTotal.Text;
            DiscountAmount = textBoxNetDiscount.Text;
            LineDiscountAmount = textBoxtTlLineDiscount.Text;
            DateTimeInvoice =  DateTime.Now.ToString();
            PaidAmount = textBoxPaidAmount.Text;
            Balance = textBoxBalanceAmount.Text;

            if(z>0)
            {
                Voucher voucher = new Voucher();
                for (int i = 0; i < dataGridViewVoucher.Rows.Count; ++i)
                {
                    voucher.updateVoucher(Convert.ToInt32(dataGridViewVoucher.Rows[i].Cells[0].Value), Invoce_No);
                }
            }
            if (x > 0 && y > 0 && z > 0)
            {
                BillPrint bp = new BillPrint();
                bp.Show();

                //MessageBox.Show(" Successfully Added");
                dataGridViewAll.Rows.Clear(); ;
                textBoxQuantity.Clear();
                dataGridViewAll.Text = "";
                textBoxSelling.Clear();
                comboBoxCatID.Text = "";
                textBoxTotal.Clear();
                textBoxNetDiscountP.Clear();
                textBoxNetDiscount.Clear();
                textBoxtTlLineDiscountP.Clear();
                textBoxtTlLineDiscount.Clear();
                textBoxDueAmount.Clear();
                textBoxInvoice.Clear();
                textBoxPaidAmount.Clear();
                textBoxBalanceAmount.Clear();
                textBoxVoucherAmount.Clear();
                textBoxBarCode.Clear();
                textBoxVoucherNo.Clear();
                dataGridViewVoucher.Rows.Clear();       
                if (labelVoucherVisible.Text!="1")button21_Click(null, null);


            }
        }

        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x = dataGridViewAll.CurrentRow.Index;
                dataGridViewAll.Rows.Remove(dataGridViewAll.Rows[x]);
                SetSummery();
            }
            catch { }
        }

        public void SetSummery()
        {
            try
            {
                decimal sumoriginal = 0;
                decimal sum = 0;
                decimal netdiscountp = 0;
                decimal netdiscount = 0;
                decimal netdiscountline = 0;
                for (       int i = 0; i < dataGridViewAll.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[7].Value);
                    netdiscountp += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value);
                    netdiscountline += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                    sumoriginal += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                }
                netdiscount = GetTotalBillDiscount(sum);
                netdiscountp = netdiscount / sum * 100;
                textBoxTotal.Text = Math.Round(sumoriginal, 2).ToString();
                textBoxNetDiscountP.Text = Math.Round(netdiscountp, 2).ToString();
                textBoxNetDiscount.Text = Math.Round((netdiscount), 2).ToString();
                textBoxtTlLineDiscountP.Text = Math.Round((netdiscountline * 100 / sumoriginal), 2).ToString();
                textBoxtTlLineDiscount.Text = Math.Round((netdiscountline), 2).ToString();
                textBoxDueAmount.Text = Math.Round((netdiscount + netdiscountline), 2).ToString();
                textBoxInvoice.Text = Math.Round((sumoriginal - netdiscount - netdiscountline), 2).ToString();
            }
            catch { }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var currentcellVal = dataGridViewAll.CurrentCellAddress;
            labelD.Text = currentcellVal.X.ToString();
            labelCurrenty.Text = currentcellVal.Y.ToString();
            labelInGrid.Text = "yes";
            int currecty = currentcellVal.Y;
            if (e.ColumnIndex == 7)
            {
                var currentcell = dataGridViewAll.CurrentCellAddress;
                Double UnitPrice = Convert.ToDouble(dataGridViewAll.Rows[currentcell.Y].Cells[3].Value);
                Double DiscountAmount = Convert.ToDouble(dataGridViewAll.Rows[currentcell.Y].Cells[5].Value);
                Double Quantity = Convert.ToDouble(dataGridViewAll.Rows[currentcell.Y].Cells[6].Value);
                if (Quantity != 0)
                {
                    Double Total = (UnitPrice - DiscountAmount) * Quantity;
                    

                    DataGridViewTextBoxCell celTTL = (DataGridViewTextBoxCell)dataGridViewAll.Rows[currentcell.Y].Cells[7];
                    celTTL.Value = Total.ToString();
                    SetSummery();
                    System.Windows.Forms.SendKeys.Send("{TAB}");
                    System.Windows.Forms.SendKeys.Send("{TAB}");
                }
                else
                {
                    MessageBox.Show("Invalid Quantity", "Error");
                }
            }
            if (e.ColumnIndex == 1)
            {
                var currentcell = dataGridViewAll.CurrentCellAddress;

                //var sendingCB = sender as DataGridViewComboBoxEditingControl;
                DataGridViewTextBoxCell celUP = (DataGridViewTextBoxCell)dataGridViewAll.Rows[currentcell.Y].Cells[3];
                DataGridViewTextBoxCell celU = (DataGridViewTextBoxCell)dataGridViewAll.Rows[currentcell.Y].Cells[2];
                DataGridViewTextBoxCell celCN = (DataGridViewTextBoxCell)dataGridViewAll.Rows[currentcell.Y].Cells[1];
                DataGridViewTextBoxCell celD = (DataGridViewTextBoxCell)dataGridViewAll.Rows[currentcell.Y].Cells[4];
                DataGridViewTextBoxCell celDA = (DataGridViewTextBoxCell)dataGridViewAll.Rows[currentcell.Y].Cells[5];
                DataGridViewImageCell celCancel = (DataGridViewImageCell)dataGridViewAll.Rows[currentcell.Y].Cells[9];
                DataGridViewTextBoxCell celCI = (DataGridViewTextBoxCell)dataGridViewAll.Rows[currentcell.Y].Cells[8];

                celCancel.Value= Image.FromFile(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "CancelBtn.png"));

                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");

                string BarCode = Convert.ToString(dataGridViewAll.Rows[currentcell.Y].Cells[0].Value);


                SqlDataReader sdrsec = new Item().GetCategoryDetailsByBarcode(BarCode);
                if (sdrsec != null)
                {
                    try
                    {
                        String DiscountCol = "";
                        Decimal DiscountAmnt1 = 0;
                        sdrsec.Read();
                        celCN.Value = sdrsec.GetString(1);
                        celU.Value = sdrsec.GetString(3);
                        celCI.Value = sdrsec.GetInt32(2).ToString().Trim();
                        celUP.Value = sdrsec.GetDecimal(5).ToString().Trim();
                        Decimal DiscountAmount = sdrsec.GetDecimal(7);
                        String DiscountType = sdrsec.GetString(8).ToString().Trim();
                        Boolean DiscountPeriodically = sdrsec.GetBoolean(12);
                        DateTime DiscountFrom= sdrsec.GetDateTime(10);
                        DateTime DiscountTo = sdrsec.GetDateTime(11);
                        if (!DiscountPeriodically||(DiscountPeriodically && (DateTime.Now.Date >= DiscountFrom && DateTime.Now.Date <= DiscountTo)))
                        { 
                            if (DiscountType.Equals("AMNT"))
                            {
                                DiscountCol = DiscountAmount + "/=";
                                DiscountAmnt1 = DiscountAmount;
                            }
                            if (DiscountType.Equals("PR"))
                            {
                                DiscountCol = DiscountAmount + "%";
                                DiscountAmnt1 = (sdrsec.GetDecimal(5) * DiscountAmount / 100);
                            }
                        }

                        celD.Value = DiscountCol;
                        celDA.Value = Math.Round((DiscountAmnt1), 2).ToString(); 
                        sdrsec.Dispose();
                        sdrsec.Close();
                    }
                    catch
                    {

                        MessageBox.Show("Item Not Registered", "Error");

                        dataGridViewAll.Rows[currentcell.Y].Cells[0].Value = "";

                    }
                }
                else
                {

                }
            }
        }

        private decimal GetTotalBillDiscount(Decimal BillAmount)
        {
            Decimal DiscountAmount = 0.0m;
            SqlDataReader sdr =new Discount().GetDiscountForTotal(BillAmount);
            if (sdr != null)
            {
                sdr.Read();
                Boolean DiscountPeriodically = sdr.GetBoolean(0);
                Decimal Discount = sdr.GetDecimal(1);
                String DiscountType = sdr.GetString(2);
                DateTime DiscountFrom = sdr.GetDateTime(3);
                DateTime DiscountTo = sdr.GetDateTime(4);
                if(!DiscountPeriodically || (DiscountPeriodically && (DateTime.Now.Date >= DiscountFrom && DateTime.Now.Date <= DiscountTo)))
                {
                    if (DiscountType.Equals("AMNT"))
                    {
                        DiscountAmount = Discount;
                    }
                    if (DiscountType.Equals("PR"))
                    {
                        DiscountAmount = (BillAmount * Discount / 100);
                    }
                }
            }
            return DiscountAmount;
            
        }
        private void textBoxtextBoxBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Printing()
        {
            //PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
            //var Byteversion = 
            //Byteversion = 
            //PrinterUtility.PrintExtensions.Print(Byteversion, POS.Properties.Settings.Default.);
        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                //if (Hiddenlabel.Text.Equals("textBoxBC"))
                //{
                //    textBoxBC.Text += "8";
                //}
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "8";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "8";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "8";
                }
                catch { }
            }

        }

        private void textBox7_TextChanged(object sender, MouseEventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxPW";
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxPW";
        }



        private void textBox7_TabIndexChanged(object sender, EventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxPW";
        }

        private void buttonNP7_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                //if (Hiddenlabel.Text.Equals("textBoxBC"))
                //{
                //    textBoxBC.Text += "7";
                //}
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "7";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "7";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "7";
                }
                catch { }
            }

        }



        private void textBoxBC_TabIndexChanged(object sender, EventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxBC";
        }

        private void buttonNP9_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                //if (Hiddenlabel.Text.Equals("textBoxBC"))
                //{
                //    textBoxBC.Text += "9";
                //}
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "9";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "9";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "9";
                }
                catch { }
            }
        }

        private void buttonNP4_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                //if (Hiddenlabel.Text.Equals("textBoxBC"))
                //{
                //    textBoxBC.Text += "4";
                //}
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "4";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "4";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "4";
                }
                catch { }
            }
        }

        private void buttonNP5_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "5";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "5";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "5";
                }
                catch { }
            }
        }

        private void buttonNP6_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "6";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "6";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "6";
                }
                catch { }
            }
        }

        private void buttonNP1_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {

                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "1";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "1";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "1";
                }
                catch { }
            }
        }

        private void buttonNP2_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {

                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "2";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "2";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "2";
                }
                catch { }
            }
        }

        private void buttonNP3_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "3";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "3";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "3";
                }
                catch { }
            }
        }

        private void buttonNP0_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "0";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "0";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "0";
                }
                catch { }
            }
        }

        private void buttonNPDot_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += ".";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += ".";
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + ".";
                }
                catch { }
            }

        }

        private void buttonNP00_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "00";
                }
                else if (Hiddenlabel.Text.Equals("textBoxQntty"))

                    textBoxQuantity.Text += "00";
            }
            else
            {
                try
                {

                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "00";
                }
                catch { }
        }

        }

        private void buttonNPStar_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "*";
                }
                
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "*";
                }
                catch { }
            }
        }

        private void buttonNPMinus_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    TxtPassword.Text += "-";
                }
               
                    
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                    }
                    catch { }
                    celcrnt.Value = crnt + "-";
                }
                catch { }
            }
        }

        private void buttonNPBack_Click(object sender, EventArgs e)
        {
            if (labelInGrid.Text.Equals("no"))
            {
                
                if (Hiddenlabel.Text.Equals("textBoxPW"))
                {
                    try
                    {
                        TxtPassword.Text = TxtPassword.Text.Remove(TxtPassword.Text.Length - 1, 1);
                    }
                    catch { }
                }
                else if(Hiddenlabel.Text.Equals("textBoxQntty"))
                    try
                    {
                        textBoxQuantity.Text = textBoxQuantity.Text.Remove(textBoxQuantity.Text.Length - 1, 1);
                    }
                    catch { }
            }
            else
            {
                try
                {
                    DataGridViewTextBoxCell celcrnt = (DataGridViewTextBoxCell)dataGridViewAll.Rows[int.Parse(labelCurrenty.Text)].Cells[int.Parse(labelD.Text)];
                    string crnt = "";
                    try
                    {
                        crnt = celcrnt.Value.ToString();
                        celcrnt.Value = crnt.Remove(crnt.Length - 1, 1);
                    }
                    catch { }
                }
                catch { }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlDataReader sdr = new User().CheckLogin(TxtUserName.Text, Encript(TxtPassword.Text));
                String UserName = "";
                if (sdr != null)
                {
                    sdr.Read();
                    UserName = sdr.GetString(0);
                    sdr.Close();
                }
                if (!UserName.Equals(""))
                {
                    Properties.Settings.Default.username = TxtUserName.Text;
                    Hiddenlabel1.Text=TxtUserName.Text;
                    MessageBox.Show("Login Changed!");
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string Encript(string password)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider objCript = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(password);
            bs = objCript.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            password = s.ToString();
            return password;
        }

        private void timer_tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss");
        }

        private void textBoxQntty_TextChanged(object sender, EventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxQntty";
        }

        private void textBoxQntty_TextChanged(object sender, MouseEventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxQntty";
        }

        private void textBoxUN_TextChanged(object sender, EventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxUN";
        }

        private void textBoxUN_TextChanged(object sender, MouseEventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxUN";
        }

        private void textBoxCAT_TextChanged(object sender, EventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxCAT";
        }

        private void textBoxCAT_TextChanged(object sender, MouseEventArgs e)
        {
            labelInGrid.Text = "no";
            Hiddenlabel.Text = "textBoxCAT";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            new CustomerData().Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(labelVoucherVisible.Text.Equals("1"))
            {

                labelBarCodeVoucher.Visible = true;
                labelVoucherNo.Visible = true;
                textBoxBarCode.Visible = true;
                textBoxVoucherNo.Visible = true;
                buttonAddVoucher.Visible = true;
                dataGridViewVoucher.Visible = true;
                labelVoucherVisible.Text = "0";
            }
            else if (labelVoucherVisible.Text.Equals("0"))
            {

                labelBarCodeVoucher.Visible = false;
                labelVoucherNo.Visible = false;
                textBoxBarCode.Visible = false;
                textBoxVoucherNo.Visible = false;
                buttonAddVoucher.Visible = false;
                dataGridViewVoucher.Visible = false;
                labelVoucherVisible.Text = "1";
            }
        }

        private void textBoxLoadByVoucherNo(object sender, EventArgs e)
        {
            SqlDataReader sdr = new Voucher().getVoucherbyVoucher_No(textBoxVoucherNo.Text);
            if (sdr != null)
            {
                sdr.Read();
                labelVoucherID.Text= sdr.GetInt32(0).ToString();
                String BarCode = sdr.GetString(1);
                Decimal Amount = sdr.GetDecimal(2);
                Boolean Status = sdr.GetBoolean(3);
                if (!Status)
                {
                    textBoxBarCode.Text = BarCode.Trim();
                    
                }
                else
                {
                    MessageBox.Show("Voucher Already Issued");
                    textBoxBarCode.Clear();
                    textBoxVoucherNo.Clear();

                }
                sdr.Close();
            }
            else
            {
                MessageBox.Show("Invalid Voucher Details");
                textBoxBarCode.Clear();
                textBoxVoucherNo.Clear();

            }
        }

        private void textBoxLoadByBarCode(object sender, EventArgs e)
        {
            SqlDataReader sdr = new Voucher().getVoucherbyBrCode(textBoxBarCode.Text);
            if (sdr != null)
            {
                sdr.Read();
                labelVoucherID.Text = sdr.GetInt32(0).ToString();
                String Voucher_No = sdr.GetString(1);
                Decimal Amount = sdr.GetDecimal(2);
                Boolean Status = sdr.GetBoolean(3);
                if (!Status)
                {
                    textBoxVoucherNo.Text = Voucher_No.Trim();
                }
                else
                {
                    MessageBox.Show("Voucher Already Issued");
                    textBoxVoucherNo.Clear();
                    textBoxBarCode.Clear();
                }
                sdr.Close();
            }
            else
            {
                MessageBox.Show("Invalid Voucher Details");
                textBoxVoucherNo.Clear();
                textBoxBarCode.Clear();
            }

        }

        private void checkBoxCardPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCardPayment.Checked)
            {

                labelPaidAmount.Visible = true;
                labelBalance.Visible = true;
                textBoxPaidAmount.Visible = true;
                textBoxBalanceAmount.Visible = true;
                

            }
            else
            {
                labelPaidAmount.Visible = false;
                labelBalance.Visible = false;
                textBoxPaidAmount.Visible = false;
                textBoxBalanceAmount.Visible = false;
            }

        }

        private void textBoxPaidAmount_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if(decimal.Parse(textBoxPaidAmount.Text) + decimal.Parse(textBoxVoucherAmount.Text) - decimal.Parse(textBoxInvoice.Text)>0)
                textBoxBalanceAmount.Text = (decimal.Parse(textBoxPaidAmount.Text) + decimal.Parse(textBoxVoucherAmount.Text) - decimal.Parse(textBoxInvoice.Text)).ToString();
            else MessageBox.Show("Invalid Paying Amount!");
            }
            catch
            {
                MessageBox.Show("Invalid Amounts!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal Amount = 0.0m;
            int exist = 0;
            SqlDataReader sdr = new Voucher().getVoucherbyVoucher_No(textBoxVoucherNo.Text);
            if (sdr != null)
            {
                sdr.Read();
                Amount= sdr.GetDecimal(2);
                sdr.Close();
            }
            for (int i = 0; i < dataGridViewVoucher.Rows.Count; ++i)
            {
                if (textBoxVoucherNo.Text.Trim().Equals(Convert.ToString(dataGridViewVoucher.Rows[i].Cells[1].Value).Trim())) exist = 1;
            }
            if (exist == 0)
            {
                dataGridViewVoucher.Rows.Add(labelVoucherID.Text, textBoxVoucherNo.Text, Amount);
                SetVoucherSummery();
            }
            else
            {
                MessageBox.Show("Voucher Already Inserted!");
                textBoxVoucherNo.Clear();
                labelVoucherID.Text = "0" ;
                textBoxBarCode.Clear();
            }
        }

        private void dataGridViewVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    int x = dataGridViewVoucher.CurrentRow.Index;
                    dataGridViewVoucher.Rows.Remove(dataGridViewVoucher.Rows[x]);
                    SetVoucherSummery();
                }
               
            }
            catch { }
            
        }

        public void SetVoucherSummery()
        {
            Decimal Sum = 0.0m;
            for (int i = 0; i < dataGridViewVoucher.Rows.Count; ++i)
            {
                Sum += (Convert.ToDecimal(dataGridViewVoucher.Rows[i].Cells[2].Value));
            }
            textBoxVoucherAmount.Text = Sum.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
    
}
