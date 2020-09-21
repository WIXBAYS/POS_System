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
                        textBoxBuying.Text= sqd.GetDouble(4).ToString();
                        textBoxSelling.Text = sqd.GetDouble(5).ToString();
                        checkBoxActive.Checked = sqd.GetBoolean(6);
                        comboBoxItemList.SelectedIndex = comboBoxItemList.FindString(sqd.GetString(7));
                        comboBoxName.Refresh();
                    }
                    sqd.Close();

                    comboBoxItemList.Enabled = true;
                    comboBoxunits.Enabled = true;
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
                String ItemID = comboBoxItemList.SelectedValue.ToString();
                String Barcode = textBoxBarcode.Text;       
                String Unit = comboBoxunits.SelectedItem.ToString();
                float Selling = float.Parse(textBoxSelling.Text);
                float buying = float.Parse(textBoxBuying.Text);
                bool CheckedStatus = checkBoxActive.Checked;
                String Discription = textBoxLineDiscription.Text;

                int x = item.insertItemCatagory(TextcatName,ItemID,Barcode,Unit,buying,Selling,Discription,CheckedStatus);

                if (x > 0)
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
                    comboBoxunits.Enabled = false;

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
                String ItemID = comboBoxItemList.SelectedValue.ToString();
                String Barcode = textBoxBarcode.Text;
                String Unit = comboBoxunits.SelectedItem.ToString();
                float Selling = float.Parse(textBoxSelling.Text);
                float buying = float.Parse(textBoxBuying.Text);
                String Discription = textBoxLineDiscription.Text;
                bool CheckedStatus = checkBoxActive.Checked;

                String Catagory_ID = comboBoxName.SelectedValue.ToString();


                Item item = new Item();
                int x = item.updateItemCatagory(TextcatName,ItemID,Barcode,Unit,buying,Selling,Discription,CheckedStatus,Catagory_ID);

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
                    comboBoxunits.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Item Catagory" + textBoxName.Text + " Updating Error");
                }
            }
        }

        private void Catagory_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetItemCataagory.Item_Catagory' table. You can move, or remove it, as needed.
            this.item_CatagoryTableAdapter.Fill(this.pOSDataSetItemCataagory.Item_Catagory);

            buttonsave.Hide();
            button_update.Show();
            textBoxName.Hide();
            comboBoxName.Show();
            textBoxNameUpdate.Show();
            comboBoxItemList.Enabled = false;
            comboBoxunits.Enabled = false;

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
                comboBoxunits.Enabled = true;

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
                comboBoxunits.Enabled = false;
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
    }
}
