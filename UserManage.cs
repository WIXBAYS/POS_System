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
                comboBoxNIC.Visible = false;
                ResetAll();
            }
            else
            {
                textBoxNIC.Visible = false;
                comboBoxNIC.Visible = true;
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
            int StoreID = int.Parse(comboBoxStore.SelectedValue.ToString());
            String UserName = textBoxUserName.Text;
            String UserType = comboBoxUserType.Text;
            int success = 0;
            User usr = new User();
            if (checkBoxNew.Checked)
            {
                NIC = textBoxNIC.Text;
                if (UserName!="" && UserType!="")
                    success =usr.insertUser(UserName, "934b535800b1cba8f96a5d72f72f1611", NIC, UserType, FirstName, LastName, ContactNo, AddressNo, Street, City, District, StoreID);
                
                else
                {
                    MessageBox.Show("Please provide UserName and UserType");
                    return;
                }
            }
            else
            {
                NIC = comboBoxNIC.SelectedValue.ToString();
                success = usr.updatetUser(NIC, checkBoxActive.Checked, FirstName, LastName, ContactNo, AddressNo, Street, City, District, StoreID);
            }

            if (success > 0)
            {
                MessageBox.Show("Successfully Saved");
                ResetAll();
            }
            else MessageBox.Show("Error In Save");



        }
        public void ResetAll()
        {
            textBoxUserName.Text = "";
            checkBoxActive.Checked = true;
            comboBoxUserType.Text = "";
            textBoxFristName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
            textBoxaddressNo.Text = "";
            textBoxStreet.Text = "";
            textBoxCity.Text = "";
            textBoxDistrict.Text = "";
            comboBoxStore.SelectedItem = "";
        }

        private void comboBoxNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String NIC = comboBoxNIC.Text.ToString();

                User usr = new User();
                SqlDataReader sdrusr = usr.GetUserDetails(NIC);
                if (sdrusr != null)
                {
                    while (sdrusr.Read())

                    {
                        textBoxUserName.Text = sdrusr.GetString(0);
                        checkBoxActive.Checked = sdrusr.GetBoolean(1);
                        comboBoxUserType.SelectedItem = sdrusr.GetString(2);
                        textBoxFristName.Text = sdrusr.GetString(3);
                        textBoxLastName.Text = sdrusr.GetString(4);
                        textBoxContactNo.Text = sdrusr.GetString(5);
                        textBoxaddressNo.Text = sdrusr.GetString(6);
                        textBoxStreet.Text = sdrusr.GetString(7);
                        textBoxCity.Text = sdrusr.GetString(8);
                        textBoxDistrict.Text = sdrusr.GetString(9);
                        comboBoxStore.SelectedItem = sdrusr.GetInt32(10);

                    }
                    sdrusr.Close();
                }
            }
            catch { }
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
        private void button1_Click(object sender, EventArgs e)
        {
            String UserName = textBoxUserName.Text;
            String UserType = comboBoxUserType.Text.ToString();
            String NewPassword = textBoxNewPassword.Text;
            String ReNewPassword = textBoxReNewPassword.Text;

            if (NewPassword != "" && NewPassword == ReNewPassword)
            {
                User usr = new User();
                int success = usr.updatetPassword(Encript(NewPassword), UserName.Trim(), UserType);
                if (success > 0)
                {
                    MessageBox.Show("Successfully Saved");
                    comboBoxUserType.Text = "";
                    textBoxNewPassword.Text = "";
                    textBoxReNewPassword.Text = "";
                }
                else MessageBox.Show("Error In Save");
            }
            else
            {
                MessageBox.Show("Invalid fields. Please check");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
