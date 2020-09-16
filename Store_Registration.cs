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
    public partial class Store_Registration : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.POSCS"].ConnectionString;

        public Store_Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {    
            if(TextVAlidation())
            {
                SqlConnection con = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Store_Data]([STORE_NAME],[ADDRES_LINE_1],[ADDRES_LINE_2],[ADDRES_LINE_3],[TELEPHONE_1],[TELEPHONE_2],[BUISSNESS_REG])VALUES(@textBoxName,@textBoxLine1,@textBoxLine2,@textBoxLine3,@textBoxtel,@textBoxMob,@textBoxBusReg)", con);
                cmd.Parameters.AddWithValue("@textBoxName", textBoxName.Text);
                cmd.Parameters.AddWithValue("@textBoxLine1", textBoxLine1.Text);
                cmd.Parameters.AddWithValue("@textBoxLine2", textBoxLine2.Text);
                cmd.Parameters.AddWithValue("@textBoxLine3", textBoxLine3.Text);
                cmd.Parameters.AddWithValue("@textBoxtel", textBoxtel.Text);
                cmd.Parameters.AddWithValue("@textBoxMob", textBoxMob.Text);
                cmd.Parameters.AddWithValue("@textBoxBusReg", textBoxBusReg.Text);
   
                SqlCommand Logincmd = new SqlCommand("INSERT INTO [dbo].[User_Details]([USER_NAME],[PASSWORD],[NIC],[STATUS],[USER_TYPE],[FIRST_NAME],[LAST_NAME],[CONTACT_NO],[ADDRESS_NO],[STREET],[CITY],[DISTRICT],[STORE_ID])VALUES('Admin','934b535800b1cba8f96a5d72f72f1611','100000000V',1,'Admin','Admin','Admin','0000000000','N/A','N/A','N/A','N/A','1')", con);
                try
                {
                    con.Open();
                    cmd.ExecuteReader();       
                    con.Close();
                    con.Open();
                    Logincmd.ExecuteReader();
                    con.Close();
                    Login lg = new Login();
                    lg.Show();
                    this.Dispose();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                    MessageBox.Show("Error Creating Store");
                    con.Close();
                }

                
            }
        }

        private bool TextVAlidation()
        {
            bool valid = true;

            if (textBoxName.Text.Trim() == String.Empty)
            {
                textBoxName.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxName.BackColor = Color.White;

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
    }
}
