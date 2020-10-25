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
    public partial class BrandRegistration : Form
    {
        public BrandRegistration()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {

                DataInsertManager DIM = new DataInsertManager();

                String TextName = textBoxName.Text;
                String Discription = textBoxLineDiscription.Text;
                bool CheckedStatus = checkBoxActive.Checked;
                Brand brand = new Brand();

                int x = brand.insertBrand(TextName, Discription, CheckedStatus);

                if (x > 0)
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Successfully Created");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonsave.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();

                }
                else
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Creating Error");
                }
            }
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

            return valid;
        }


        private void TextClear()
        {
            textBoxName.Clear();
            textBoxLineDiscription.Clear();
            textBoxNameUpdate.Clear();
            checkBoxActive.Checked = false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void BrandRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetBrandData.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.pOSDataSetBrandData.Brand);
            buttonsave.Hide();
            button_update.Show();
            textBoxName.Hide();
            comboBoxName.Show();
            textBoxNameUpdate.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {

                String TextName = textBoxNameUpdate.Text;
                String Discription = textBoxLineDiscription.Text;
                bool CheckedStatus = checkBoxActive.Checked;
                String ComboName = comboBoxName.SelectedValue.ToString();

                Brand brand = new Brand();
                int x = brand.updateBrand(TextName, Discription, CheckedStatus, ComboName);

                if (x > 0)
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Successfully Updated");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonsave.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();
                }
                else
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Updating Error");
                }
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Item_ID = "";
                if (comboBoxName.Text != "")
                    Item_ID = comboBoxName.SelectedValue.ToString();

                Brand brand = new Brand();
                SqlDataReader sqd = brand.GetBrandDetailsbyID(Item_ID);

                if (sqd != null)
                {
                    while (sqd.Read())
                    {
                        textBoxNameUpdate.Text = sqd.GetString(0).ToString();
                        textBoxLineDiscription.Text = sqd.GetString(1);
                        checkBoxActive.Checked = sqd.GetBoolean(2);
                        comboBoxName.Refresh();
                    }
                    sqd.Close();
                }
            }
            catch
            {
                return;
            }
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
            }
            else
            {
                buttonsave.Hide();
                button_update.Show();
                textBoxName.Hide();
                comboBoxName.Show();
                textBoxNameUpdate.Show();
                TextClear();
            }
        }
    }
}
