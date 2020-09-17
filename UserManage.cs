using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UserManage : Form
    {
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
    }
}
