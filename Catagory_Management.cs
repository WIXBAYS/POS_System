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
    public partial class Catagory_Management : Form
    {

        Item item = new Item();
        public Catagory_Management()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Catagory_ID = "";
                if (comboBoxName.Text != "")
                    Catagory_ID = comboBoxName.SelectedValue.ToString();

                SqlDataReader sqd = item.GetItemCatagoryDetails(Catagory_ID);

                if (sqd != null)
                {
                    while (sqd.Read())
                    {
                        textBoxNameUpdate.Text = sqd.GetString(1).ToString();
                        textBoxBarcode.Text = sqd.GetString(0).ToString();
                        textBoxLineDiscription.Text = sqd.GetString(2);
                        comboBoxunits.SelectedIndex = comboBoxunits.FindString(sqd.GetString(3));
                        textBoxBuying.Text= sqd.GetDecimal(4).ToString();
                        textBoxSelling.Text = sqd.GetDecimal(5).ToString();
                        checkBoxActive.Checked = sqd.GetBoolean(6);
                        comboBoxItemList.SelectedIndex = comboBoxItemList.FindString(sqd.GetString(7).Trim());


                        textBoxDiscount.Text = sqd.GetDecimal(8).ToString();
                        comboBoxDiscountType.SelectedIndex = comboBoxDiscountType.FindString(sqd.GetString(9).Trim());
                        comboBoxBrand.SelectedIndex = comboBoxBrand.FindString(sqd.GetString(10).Trim());
                        comboBoxName.Refresh();
                    }
                    sqd.Close();

                    comboBoxItemList.Enabled = true;
                    comboBoxBrand.Enabled = true;
                    comboBoxunits.Enabled = true;
                    comboBoxDiscountType.Enabled = true;
                }
            }
            catch(Exception g)
            {
                return;
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {
                DataInsertManager DIM = new DataInsertManager();

                String TextcatName = textBoxName.Text;
                String BrandID = comboBoxBrand.SelectedValue.ToString();
                String Barcode = textBoxBarcode.Text;       
                String Unit = comboBoxunits.SelectedItem.ToString();
                Decimal Selling = decimal.Parse(textBoxSelling.Text);
                Decimal buying = decimal.Parse(textBoxBuying.Text);
                bool CheckedStatus = checkBoxActive.Checked;
                String Discription = textBoxLineDiscription.Text;
                Decimal Discount = decimal.Parse(textBoxDiscount.Text);
                String DiscountType = comboBoxDiscountType.SelectedItem.ToString();
                String ItemID = comboBoxItemList.SelectedValue.ToString();

                SqlDataReader sdr = item.GetMaxCatID();
                int cat_id = 0;
                if (sdr != null)
                {
                    while (sdr.Read())
                    {
                        try
                        {
                            cat_id = sdr.GetInt32(0);
                        }
                        catch
                        {
                            cat_id = 1;
                        }
                    }
                }

                int x = item.insertItemCatagory(TextcatName, BrandID, Barcode,Unit,buying,Selling,Discription,CheckedStatus, Discount, DiscountType, ItemID);
                int y = item.insertStockBalanceDefault(cat_id+1 ,0);

                if (x > 0 &&  y>0)
                {
                    MessageBox.Show("Item Catagory " + textBoxName.Text + " Successfully Created");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonsave.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();
                    comboBoxItemList.Enabled = false;
                    comboBoxBrand.Enabled = false;
                    comboBoxunits.Enabled = false;
                    comboBoxDiscountType.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Item Catagory " + textBoxName.Text + " Creating Error");
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {
                String TextcatName = textBoxNameUpdate.Text;
                String BrandID = comboBoxBrand.SelectedValue.ToString();
                String ItemID = comboBoxItemList.SelectedValue.ToString();
                String Barcode = textBoxBarcode.Text;
                String Unit = comboBoxunits.SelectedItem.ToString();
                Decimal Selling = decimal.Parse(textBoxSelling.Text);
                Decimal buying = decimal.Parse(textBoxBuying.Text);
                String Discription = textBoxLineDiscription.Text;
                bool CheckedStatus = checkBoxActive.Checked;
                Decimal Discount = decimal.Parse(textBoxDiscount.Text);
                String DiscountType = comboBoxDiscountType.SelectedItem.ToString();

                String Catagory_ID = comboBoxName.SelectedValue.ToString();


                Item item = new Item();
                int x = item.updateItemCatagory(TextcatName, BrandID, Barcode,Unit,buying,Selling,Discription,CheckedStatus,Catagory_ID, Discount, DiscountType, ItemID);

                if (x > 0)
                {
                    MessageBox.Show("Item Catagory" + textBoxName.Text + " Successfully Updated");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonsave.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();
                    comboBoxItemList.Enabled = false;
                    comboBoxBrand.Enabled = false;
                    comboBoxunits.Enabled = false;
                    comboBoxDiscountType.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Item Catagory" + textBoxName.Text + " Updating Error");
                }
            }
        }

        private void Catagory_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetBrand.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.pOSDataSetBrand.Brand);
            // TODO: This line of code loads data into the 'pOSDataSetItemCataagory.Item_Catagory' table. You can move, or remove it, as needed.
            this.item_CatagoryTableAdapter.Fill(this.pOSDataSetItemCataagory.Item_Catagory);

            buttonsave.Hide();
            button_update.Show();
            textBoxName.Hide();
            comboBoxName.Show();
            textBoxNameUpdate.Show();
            comboBoxItemList.Enabled = false;
            comboBoxBrand.Enabled = false;
            comboBoxunits.Enabled = false;
            comboBoxDiscountType.Enabled = false;

            SqlDataReader sqd = item.GetItemList();
            var Items = new Dictionary<string, string>();

            if (sqd != null)
            {
                while (sqd.Read())
                {
                    Items[sqd["ITEM_ID"].ToString()] = sqd["ITEM_NAME"].ToString();
                }
            }
            comboBoxItemList.DataSource = new BindingSource(Items, null);
            comboBoxItemList.DisplayMember = "Value";
            comboBoxItemList.ValueMember = "Key";
        }

        private void checkBox_new_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_new.Checked == true)
            {
                textBoxName.Show();
                comboBoxName.Hide();
                button_update.Hide();
                buttonsave.Show();
                textBoxNameUpdate.Hide();
                TextClear();
                checkBoxActive.Checked = true;
                comboBoxItemList.Enabled = true;
                comboBoxBrand.Enabled = true;
                comboBoxunits.Enabled = true;
                comboBoxDiscountType.Enabled = true;

            }
            else
            {
                buttonsave.Hide();
                button_update.Show();
                textBoxName.Hide();
                comboBoxName.Show();
                textBoxNameUpdate.Show();
                TextClear();
                comboBoxItemList.Enabled = false;
                comboBoxBrand.Enabled = false;
                comboBoxunits.Enabled = false;
                comboBoxDiscountType.Enabled = false;
            }
        }

        private void TextClear()
        {
            textBoxName.Clear();
            textBoxLineDiscription.Clear();
            textBoxNameUpdate.Clear();
            textBoxBuying.Clear();
            textBoxBarcode.Clear();
            textBoxSelling.Clear();
            textBoxDiscount.Clear();
            checkBoxActive.Checked = false;
        }


        private bool TextVAlidation()
        {
            bool valid = true;

            if (checkBox_new.Checked == true)
            {
                if (textBoxName.Text.Trim() == String.Empty)
                {
                    textBoxName.BackColor = Color.LightPink;
                    valid = false;
                }
                else
                    textBoxName.BackColor = Color.White;
            }
            else
            {
                if (textBoxNameUpdate.Text.Trim() == String.Empty)
                {
                    textBoxNameUpdate.BackColor = Color.LightPink;
                    valid = false;
                }
                else
                    textBoxNameUpdate.BackColor = Color.White;
            }

            if (textBoxLineDiscription.Text.Trim() == String.Empty)
            {
                textBoxLineDiscription.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxLineDiscription.BackColor = Color.White;

            if (textBoxBarcode.Text.Trim() == String.Empty)
            {
                textBoxBarcode.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxBarcode.BackColor = Color.White;

            if (textBoxBuying.Text.Trim() == String.Empty)
            {
                textBoxBuying.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxBuying.BackColor = Color.White;

            if (textBoxSelling.Text.Trim() == String.Empty)
            {
                textBoxSelling.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxSelling.BackColor = Color.White;

            if (comboBoxunits.Text.Trim() == String.Empty)
            {
                comboBoxunits.BackColor = Color.LightPink;
                valid = false;
            }
            else
                comboBoxunits.BackColor = Color.White;

            return valid;
        }

        private void textBoxBuying_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)|| (e.KeyChar == '.')))
                e.Handled = true;
        }

        private void textBoxSelling_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
                e.Handled = true;
        }

        
        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string BARCODE = "";
                if (textBoxBarcode.Text != "")
                {
                    BARCODE = textBoxBarcode.Text.Trim();

                    SqlDataReader sqd = item.GetCatagoryDetailsByBarcodeAll(BARCODE);

                    if (sqd != null)
                    {
                        while (sqd.Read())
                        {
                            textBoxNameUpdate.Text = sqd.GetString(1).ToString();
                            textBoxBarcode.Text = sqd.GetString(0).ToString();
                            textBoxLineDiscription.Text = sqd.GetString(2);
                            comboBoxunits.SelectedIndex = comboBoxunits.FindString(sqd.GetString(3));
                            textBoxBuying.Text = sqd.GetDecimal(4).ToString();
                            textBoxSelling.Text = sqd.GetDecimal(5).ToString();
                            checkBoxActive.Checked = sqd.GetBoolean(6);
                            comboBoxItemList.SelectedIndex = comboBoxItemList.FindString(sqd.GetString(7));
                            comboBoxName.SelectedIndex = comboBoxName.FindString(sqd.GetString(1));

                            textBoxDiscount.Text = sqd.GetDecimal(8).ToString();
                            comboBoxDiscountType.SelectedIndex = comboBoxDiscountType.FindString(sqd.GetString(9).Trim());
                            comboBoxBrand.SelectedIndex = comboBoxBrand.FindString(sqd.GetString(10).Trim());
                            comboBoxName.Refresh();
                        }
                        sqd.Close();

                        comboBoxItemList.Enabled = true;
                        comboBoxBrand.Enabled = true;
                        comboBoxunits.Enabled = true;
                        comboBoxDiscountType.Enabled = true;

                    }
                }
            }
            catch (Exception g)
            {
                return;
            }
        }

        //private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    String BrandID = comboBoxBrand.SelectedValue.ToString();
        //    String ItemID = comboBoxItemList.SelectedValue.ToString();
        //    List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
        //    SqlDataReader sdr = new Item().GetItemCatagoryDetails_Combobox(ItemID, BrandID);
        //    if (sdr != null)
        //    {
        //        while (sdr.Read())
        //        {
        //            var Items = new Dictionary<string, string>();

        //            if (sdr != null)
        //            {
        //                {
        //                    data.Add(new KeyValuePair<string, string>(sdr.GetInt32(0).ToString().Trim(), sdr.GetString(1).Trim()));
        //                }
        //                sdr.Dispose(); sdr.Close();
        //            }
        //            comboBoxItemList.DataSource = new BindingSource(Items, null);
        //            comboBoxItemList.DisplayMember = "Value";
        //            comboBoxItemList.ValueMember = "Key";
        //        }
        //    }
        //}
    }
}
