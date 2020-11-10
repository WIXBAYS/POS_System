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
    public partial class GRN_Report : Form
    {

        int GNR_Pass_ID = 0;
        public GRN_Report(int GNR_ID)
        {
            InitializeComponent();
            this.GNR_Pass_ID = GNR_ID;
        }

        private void GNR_Report_Load(object sender, EventArgs e)
        {
            if (GNR_Pass_ID > 0)
            {
                // TODO: This line of code loads data into the 'pOSDataSetGRN_ID_List.Transaction' table. You can move, or remove it, as needed.
                this.transactionTableAdapter.Fill(this.pOSDataSetGRN_ID_List.Transaction);
                // TODO: This line of code loads data into the 'POSDataSetTemp_GNR_Data.GNR_Temp' table. You can move, or remove it, as needed.
                this.GRN_TempTableAdapter.Fill(this.POSDataSetTemp_GRN_Data.GNR_Temp, GNR_Pass_ID);

                this.reportViewer1.RefreshReport();
            }

            this.transactionTableAdapter.Fill(this.pOSDataSetGRN_ID_List.Transaction);
        }

        private void comboBox_GRN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'POSDataSetTemp_GNR_Data.GNR_Temp' table. You can move, or remove it, as needed.
                this.GRN_TempTableAdapter.Fill(this.POSDataSetTemp_GRN_Data.GNR_Temp, int.Parse(comboBox_GRN.SelectedValue.ToString()));

                this.reportViewer1.RefreshReport();
            }
            catch { }
        }

        

    }
}
