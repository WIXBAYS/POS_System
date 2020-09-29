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
    public partial class GNR_Report : Form
    {
        public GNR_Report()
        {
            InitializeComponent();
        }

        private void GNR_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POSDataSetTemp_GNR_Data.GNR_Temp' table. You can move, or remove it, as needed.
            this.GNR_TempTableAdapter.Fill(this.POSDataSetTemp_GNR_Data.GNR_Temp);

            this.reportViewer1.RefreshReport();
        }
    }
}
