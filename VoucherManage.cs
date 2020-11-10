using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    public partial class VoucherManage : Form
    {
        public VoucherManage()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            
            int ID = 0;
            String Voucher_No = textBoxVoucherNo.Text.Trim();
            String BarCode = textBoxBarCode.Text.Trim();
            SqlDataReader sdr=voucher.getVoucherbyVoucher_No(Voucher_No);
            if(sdr!=null)
            {
                sdr.Read();
                ID = sdr.GetInt32(0);
                sdr.Close();
            }

            
            SqlDataReader sdr1 = voucher.getVoucherbyBrCode(BarCode);
            if (sdr1 != null)
            {
                sdr1.Read();
                ID = sdr1.GetInt32(0);
                sdr1.Close();
            }
            if (ID != 0)
            {
                MessageBox.Show("Voucher Already Exist");
            }

            else
            {
                Decimal Amount = decimal.Parse(textBoxAmount.Text.Trim());
                int x = voucher.insertVoucher(Voucher_No, BarCode, Amount);
                if (x > 0)
                {
                    MessageBox.Show(" Successfully Added");
                    textBoxVoucherNo.Clear();
                    textBoxBarCode.Clear();
                    textBoxAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Error in Save");
                }
            }
        }
    }
}
