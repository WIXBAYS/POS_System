using Microsoft.Reporting.WinForms;
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
    public partial class BillPrint : Form
    {
        public BillPrint()
        {
            InitializeComponent();
        }

        private void BillPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            ReportParameter[] parms = new ReportParameter[1];
            parms[0] = new ReportParameter("InvoiceNo", Invoice.InvoiceNumber);
            
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();
        }
    }
}
