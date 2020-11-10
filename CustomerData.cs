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
    public partial class CustomerData : Form
    {
        public CustomerData()
        {
            InitializeComponent();
        }

        

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String CustomerName = textBoxName.Text.Trim();
            String Contact_No = textBoxContactNo.Text.Trim();
            int x = new User().insertCustomer(CustomerName, Contact_No);
            if (x > 0)
            {
                MessageBox.Show(" Successfully Added");
                textBoxName.Clear();
                textBoxContactNo.Clear();
            }
            else
            {
                MessageBox.Show("Contact No Already Exist");
            }
        }
    }
}
