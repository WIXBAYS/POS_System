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
    public partial class Daily_Sales : Form
    {
        public Daily_Sales()
        {
            InitializeComponent();
             
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void chart1_DataLoad()
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Transactions"].Points.Clear();
            DateTime Date_DailySales = dateTimePickerSalesDate.Value;
            SqlDataReader sdr = new Stock().GetDailySales(DateTime.Parse(Date_DailySales.ToShortDateString()));
            while (sdr.Read())
            {
                
                this.chart1.Series["Transactions"].Points.AddXY(sdr.GetString(0), sdr.GetDecimal(1));
            }
            sdr.Close();
        }
    }
}
