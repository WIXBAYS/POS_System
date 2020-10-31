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
            // TODO: This line of code loads data into the 'pOSDataSetVendorList.Vender_Details' table. You can move, or remove it, as needed.
            this.vender_DetailsTableAdapter.Fill(this.pOSDataSetVendorList.Vender_Details);

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
                        UnitPrice = sdrsec.GetDecimal(5);
                        Decimal DiscountAmount = sdrsec.GetDecimal(8);
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
                            DiscountAmnt1 = (sdrsec.GetDecimal(5) * DiscountAmount / 100);
                        }
                    }
                    dataGridViewAll.Rows.Add("N/A", CategoryName, Unit, UnitPrice, DiscountCol, DiscountAmnt1.ToString(),textBoxQuantity.Text, ((UnitPrice-DiscountAmnt1) * decimal.Parse(textBoxQuantity.Text)).ToString());
                }
                    catch { }
               

                decimal sum = 0;
                decimal sumoriginal = 0;
                decimal netdiscountp = 0;
                decimal netdiscountline = 0;
                for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[7].Value);
                    netdiscountp += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value);
                    netdiscountline += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                    sumoriginal += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                }
                textBoxTotal.Text = sum.ToString();
                textBoxNetDiscountP.Text = Math.Round((netdiscountp / sum), 2).ToString();
                textBoxtTlLineDiscountP.Text = Math.Round((netdiscountline * 100 / sumoriginal), 2).ToString();
                textBoxtTlLineDiscount.Text = Math.Round((netdiscountline), 2).ToString();


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

                    }
                }
                else { MessageBox.Show(" Stock Balance Error"); }

            }
            z = stock.InsertIvoice(Invoce_No, decimal.Parse(textBoxTotal.Text), 0, 0, DateTime.Now);
            if (x > 0 && y > 0 && z > 0)
            {
                MessageBox.Show(" Successfully Added");
                dataGridViewAll.ClearSelection();
                textBoxQuantity.Clear();
                dataGridViewAll.Text = "";
                textBoxSelling.Clear();
                comboBoxCatID.Text = "";
            }
        }

        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x = dataGridViewAll.CurrentRow.Index;
                dataGridViewAll.Rows.Remove(dataGridViewAll.Rows[x]);
                decimal sumoriginal = 0;
                decimal sum = 0;
                decimal netdiscountp = 0;
                decimal netdiscountline = 0;
                for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[7].Value);
                    netdiscountp += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value);
                    netdiscountline += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                    sumoriginal += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                }
                
                textBoxTotal.Text = sum.ToString();
                textBoxNetDiscountP.Text = Math.Round((netdiscountp / sumoriginal), 2).ToString();
                textBoxtTlLineDiscountP.Text = Math.Round((netdiscountline * 100 / sum), 2).ToString();
                textBoxtTlLineDiscount.Text = Math.Round((netdiscountline), 2).ToString();
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
                    decimal sumoriginal = 0;
                    decimal sum = 0;
                    decimal netdiscountp = 0;
                    decimal netdiscountline = 0;
                    for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
                    {
                        sum += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[7].Value);
                        netdiscountp += Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value);
                        netdiscountline += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                        sumoriginal += (Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[6].Value));
                    }
                    textBoxTotal.Text = sum.ToString();
                    textBoxNetDiscountP.Text = Math.Round((netdiscountp / sum), 2).ToString();
                    textBoxtTlLineDiscountP.Text = Math.Round((netdiscountline*100 / sumoriginal), 2).ToString();
                    textBoxtTlLineDiscount.Text = Math.Round((netdiscountline), 2).ToString();
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
                DataGridViewImageCell celCancel = (DataGridViewImageCell)dataGridViewAll.Rows[currentcell.Y].Cells[8];
                
                celCancel.Value= Image.FromFile(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "CancelBtn.png"));

                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");
                System.Windows.Forms.SendKeys.Send("{TAB}");

                string BarCode = Convert.ToString(dataGridViewAll.Rows[currentcell.Y].Cells[0].Value);


                SqlDataReader sdrsec = new Item().GetCatagoryDetailsByBarcode(BarCode);
                if (sdrsec != null)
                {
                    try
                    {
                        String DiscountCol = "";
                        Decimal DiscountAmnt1 = 0;
                        sdrsec.Read();
                        celCN.Value = sdrsec.GetString(1);
                        celU.Value = sdrsec.GetString(3);
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
                        celDA.Value = DiscountAmnt1.ToString();
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


        

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
    
}
