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
            ReportParameter[] parms = new ReportParameter[7];
            parms[0] = new ReportParameter("InvoiceNo", Invoice.InvoiceNumber);
            parms[1] = new ReportParameter("TotalAmount", Invoice.TotalAmount);
            parms[2] = new ReportParameter("DiscountAmount", Invoice.DiscountAmount);
            parms[3] = new ReportParameter("LineDiscountAmount", Invoice.LineDiscountAmount);
            parms[4] = new ReportParameter("DateTimeInvoice", Invoice.DateTimeInvoice);
            parms[5] = new ReportParameter("PaidAmount", Invoice.PaidAmount);
            parms[6] = new ReportParameter("Balance", Invoice.Balance);

            this.reportViewer1.LocalReport.SetParameters(parms);

            this.TransactionTableAdapter.Fill(this.POSDataSetBillItems.Transaction, int.Parse(Invoice.InvoiceNumber));
            this.reportViewer1.RefreshReport();

        }
    }
}
