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
    public partial class Stock_Report : Form
    {
        public Stock_Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POSDataSetStockBlance.Stock_Balance' table. You can move, or remove it, as needed.
            this.Stock_BalanceTableAdapter.Fill(this.POSDataSetStockBlance.Stock_Balance);

            this.reportViewerStock_report.RefreshReport();
        }
    }
}
