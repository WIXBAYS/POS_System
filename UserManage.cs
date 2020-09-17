using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace POS
{
    public partial class UserManage : Form
    {
        public string connString = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.POSCS"].ConnectionString;
        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetSTORE.Store_Data' table. You can move, or remove it, as needed.
            this.store_DataTableAdapter.Fill(this.pOSDataSetSTORE.Store_Data);
            // TODO: This line of code loads data into the 'pOSDataSet.User_Details' table. You can move, or remove it, as needed.
            this.user_DetailsTableAdapter.Fill(this.pOSDataSet.User_Details);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNew.Checked)
            {
                textBoxNIC.Visible = true;
                labelNICTxt.Visible = true;
                comboBoxNIC.Visible = false;
                labelNICCombo.Visible = false;
            }
            else
            {
                textBoxNIC.Visible = false;
                labelNICTxt.Visible = false;
                comboBoxNIC.Visible = true;
                labelNICCombo.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String NIC = "";
            String FirstName = textBoxFristName.Text;
            String LastName = textBoxLastName.Text;
            String ContactNo = textBoxContactNo.Text;
            String AddressNo = textBoxaddressNo.Text;
            String Street = textBoxStreet.Text;
            String City = textBoxCity.Text;
            String District = textBoxDistrict.Text;
            String StireID = comboBoxStore.SelectedValue.ToString();
            if (checkBoxNew.Checked) NIC = textBoxNIC.Text;
            else NIC = comboBoxNIC.SelectedValue.ToString();

        }

        private void comboBoxNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            String NIC = comboBoxNIC.SelectedValue.ToString();

            User usr = new User();
            SqlDataReader sdrusr = usr.GetUserDetails(NIC);
            if (sdrusr != null)
            {
                while (sdrusr.Read())

                {
                    textBoxUserName.Text = sdrusr.GetString(0);

                }
                sdrusr.Close();
            }
        }
    }
}
