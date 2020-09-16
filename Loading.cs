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
    public partial class Loading : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.POSCS"].ConnectionString;

        public Loading()
        {
            InitializeComponent();
            this.timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBarLoading.Increment(2);

            if (progressBarLoading.Value > 99)
            {
                SqlConnection con = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("SELECT [STORE_ID] FROM [dbo].[Store_Data]", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    this.Hide();
                    Login fm = new Login();
                    fm.Show();
                 
                }
                else
                {
                    this.Hide();
                    Store_Registration fm = new Store_Registration();
                    fm.Show();
                }

                this.timer1.Stop();
            }
        }
    }
}
