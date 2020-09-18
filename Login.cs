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
    public partial class Login : Form
    {
        public string connString = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.POSCS"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            if (TxtUserName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection

                //SqlCommand cmd = new SqlCommand("SELECT     [User].UserName, RoleAssign.RoleID FROM [User] INNER JOIN RoleAssign ON [User].UserID = RoleAssign.UserID WHERE     ([User].UserName = @username) AND ([User].Password = @password) AND (RoleAssign.RoleID = '00001')", con);
                SqlCommand cmd = new SqlCommand("SELECT [USER_NAME]  FROM [User_Details]  WHERE   [USER_NAME] = @username AND  [PASSWORD] = @password", con);
                cmd.Parameters.AddWithValue("@username", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@password", Encript(TxtPassword.Text));
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    Properties.Settings.Default.username = TxtUserName.Text;
                    this.Hide();
                    Home fm = new Home();
                    fm.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
        private void TxtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click_1(null, null);
        }
    }
}
