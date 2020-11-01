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
    public partial class Discount_Type2 : Form
    {
        public Discount_Type2()
        {
            InitializeComponent();
            LoadDiscounts();
        }
        public void LoadDiscounts()
        {
            SqlDataReader sdr = new Discount().GetDiscountForTotal();
            if(sdr!=null)
            {
                Decimal AmountFrom = 0.0m;
                Decimal AmountTo = 0.0m;
                Boolean DiscountPrdcly = false;
                Decimal DiscountAmount = 0.0m;
                String DiscountType = "";
                DateTime DiscountFrom = DateTime.Parse("1900-01-01");
                DateTime DiscountTo = DateTime.Parse("1900-01-01");
                while (sdr.Read())
                {
                    String DiscountFromCol = "";
                    String DiscountToCol = "";
                    String DiscountCol = "";
                    AmountFrom = sdr.GetDecimal(0);
                    AmountTo = sdr.GetDecimal(1);
                    DiscountPrdcly = sdr.GetBoolean(2);
                    DiscountAmount = sdr.GetDecimal(3);
                    DiscountType = sdr.GetString(4);
                    DiscountFrom = sdr.GetDateTime(5);
                    DiscountTo = sdr.GetDateTime(6);
                    int DiscountID = sdr.GetInt32(7);

                    if (DiscountType.Equals("AMNT"))
                    {
                        DiscountCol = DiscountAmount + "/=";
                    }
                    if (DiscountType.Equals("PR"))
                    {
                        DiscountCol = DiscountAmount + "%";
                    }

                    if (DiscountFrom != DateTime.Parse("1900-01-01") && DiscountPrdcly) DiscountFromCol = DiscountFrom.ToShortDateString();
                    if (DiscountTo != DateTime.Parse("1900-01-01") && DiscountPrdcly) DiscountToCol = DiscountTo.ToShortDateString();
                    dataGridViewAll.Rows.Add(DiscountID,AmountFrom, AmountTo, DiscountPrdcly, DiscountAmount, DiscountType,  DiscountFromCol, DiscountToCol);
                }

            }
        }

        private void dataGridViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    int x = dataGridViewAll.CurrentRow.Index;
                    dataGridViewAll.Rows.Remove(dataGridViewAll.Rows[x]);
                }
            }
            catch { }
            }

        private void button_add_Click(object sender, EventArgs e)
        {
            String DiscountFromCol = "";
            String DiscountToCol = "";
            String DiscountCol = "";
            Decimal AmountFrom = decimal.Parse(textBoxAmntFrom.Text);
            Decimal AmountTo = decimal.Parse(textBoxAmntTo.Text);
            Boolean DiscountPrdcly = checkBoxPeriodically.Checked;
            Decimal DiscountAmount = decimal.Parse(textBoxDiscount.Text);
            String DiscountType = comboBoxDiscountType.Text;
            DateTime DiscountFrom = dateTimePickerDiscountFrom.Value;
            DateTime DiscountTo = dateTimePickerDiscountTo.Value;
            

            if (DiscountType.Equals("AMNT"))
            {
                DiscountCol = DiscountAmount + "/=";
            }
            if (DiscountType.Equals("PR"))
            {
                DiscountCol = DiscountAmount + "%";
            }

            if (DiscountFrom != DateTime.Parse("1900-01-01") && DiscountPrdcly) DiscountFromCol = DiscountFrom.ToShortDateString();
            if (DiscountTo != DateTime.Parse("1900-01-01") && DiscountPrdcly) DiscountToCol = DiscountTo.ToShortDateString();
            dataGridViewAll.Rows.Add(0, AmountFrom, AmountTo, DiscountPrdcly, DiscountAmount, DiscountType, DiscountFromCol, DiscountToCol);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Discount dis=new Discount();
            dis.DeleteDiscountForTotal();
            for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
            {
                Decimal AmountFrom = Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[1].Value);
                Decimal AmountTo = Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[2].Value);
                Boolean DiscountPrdcly = Convert.ToBoolean(dataGridViewAll.Rows[i].Cells[3].Value);
                Decimal DiscountAmount = Convert.ToDecimal(dataGridViewAll.Rows[i].Cells[4].Value);
                String DiscountType = Convert.ToString(dataGridViewAll.Rows[i].Cells[5].Value);
                DateTime DiscountFrom = DateTime.Parse("1900-01-01");
                DateTime DiscountTo = DateTime.Parse("1900-01-01");
                try
                {
                    DiscountFrom = Convert.ToDateTime(dataGridViewAll.Rows[i].Cells[6].Value);
                    DiscountTo = Convert.ToDateTime(dataGridViewAll.Rows[i].Cells[7].Value);
                }
                catch
                {
                    DiscountFrom = DateTime.Parse("1900-01-01");
                    DiscountTo = DateTime.Parse("1900-01-01");
                }
                int x=dis.InsertDiscountForTotal(AmountFrom, AmountTo, DiscountAmount, DiscountType, DiscountPrdcly, DiscountFrom, DiscountTo);
                
            }
             MessageBox.Show("Successfully Saved", "Info");
        }
    }
}
