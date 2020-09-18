using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Vendor_Management : Form
    {

        string connString = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.POSCS"].ConnectionString;
        public Vendor_Management()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_new.Checked == true)
            {            
                textBoxName.Show();
                comboBoxName.Hide();
                button_update.Hide();
                buttonCreate.Show();
                textBoxNameUpdate.Hide();
                TextClear();
            }
            else
            {

                buttonCreate.Hide();
                button_update.Show();    
                textBoxName.Hide();
                comboBoxName.Show();
                textBoxNameUpdate.Show();
                TextClear();
            }
        }

        private void Vendor_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetVendorList.Vender_Details' table. You can move, or remove it, as needed.
            this.vender_DetailsTableAdapter.Fill(this.pOSDataSetVendorList.Vender_Details);
            buttonCreate.Hide();
            button_update.Show();
            textBoxName.Hide();
            comboBoxName.Show();
            textBoxNameUpdate.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {
                SqlConnection con = new SqlConnection(connString);
                Vender vn = new Vender();
                con.Open();
                bool success = vn.CreateVender(textBoxName.Text, textBoxLine1.Text, textBoxLine2.Text, textBoxLine3.Text, textBoxtel.Text, textBoxMob.Text, textBoxBusReg.Text, con);
                con.Close();
                if(success)
                {
                    MessageBox.Show("Vender " + textBoxName.Text + " Successfully Created");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonCreate.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();

                }
                else
                {
                    MessageBox.Show("Vender " + textBoxName.Text + " Creating Error");
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

            if (textBoxLine1.Text.Trim() == String.Empty)
            {
                textBoxLine1.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxLine1.BackColor = Color.White;

            if (textBoxLine2.Text.Trim() == String.Empty)
            {
                textBoxLine2.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxLine2.BackColor = Color.White;

            if (textBoxLine3.Text.Trim() == String.Empty)
            {
                textBoxLine3.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxLine3.BackColor = Color.White;

            if (textBoxtel.Text.Trim() == String.Empty)
            {
                textBoxtel.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxtel.BackColor = Color.White;

            if (textBoxMob.Text.Trim() == String.Empty)
            {
                textBoxMob.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxMob.BackColor = Color.White;

            if (textBoxBusReg.Text.Trim() == String.Empty)
            {
                textBoxBusReg.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxBusReg.BackColor = Color.White;

            return valid;
        }

        private void TextClear()
        {
            textBoxName.Clear();
            textBoxLine1.Clear();
            textBoxLine2.Clear();
            textBoxLine3.Clear();
            textBoxtel.Clear();
            textBoxMob.Clear();
            textBoxBusReg.Clear();
            textBoxNameUpdate.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {
                SqlConnection con = new SqlConnection(connString);
                Vender vn = new Vender();
                con.Open();
                bool success = vn.UpdateVender(comboBoxName.SelectedValue.ToString(), textBoxNameUpdate.Text, textBoxLine1.Text, textBoxLine2.Text, textBoxLine3.Text, textBoxtel.Text, textBoxMob.Text, textBoxBusReg.Text, con);
                con.Close();
                if (success)
                {
                    MessageBox.Show("Vender " + textBoxName.Text + " Successfully Updated");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonCreate.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();

                }
                else
                {
                    MessageBox.Show("Vender " + textBoxName.Text + " Updating Error");
                }
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {      
            try
            {
                string vendor_id = "";
                if (comboBoxName.Text !="")
                vendor_id=comboBoxName.SelectedValue.ToString();
                Vender vn = new Vender();
                SqlDataReader sqd = vn.GetVenderDetails(vendor_id);

                if (sqd != null)
                {
                    while (sqd.Read())

                    {
                        textBoxNameUpdate.Text = sqd.GetString(0).ToString();
                        textBoxLine1.Text = sqd.GetString(1);
                        textBoxLine2.Text = sqd.GetString(2);
                        textBoxLine3.Text = sqd.GetString(3);
                        textBoxtel.Text = sqd.GetString(4);
                        textBoxMob.Text = sqd.GetString(5);
                        textBoxBusReg.Text = sqd.GetString(6);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
