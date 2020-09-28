namespace POS
{
    partial class GNR_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.POSDataSetTemp_GNR_Data = new POS.POSDataSetTemp_GNR_Data();
            this.GNR_TempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GNR_TempTableAdapter = new POS.POSDataSetTemp_GNR_DataTableAdapters.GNR_TempTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSetTemp_GNR_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNR_TempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_GNR_TEMP";
            reportDataSource1.Value = this.GNR_TempBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.GNR_Report_GNR_Form.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // POSDataSetTemp_GNR_Data
            // 
            this.POSDataSetTemp_GNR_Data.DataSetName = "POSDataSetTemp_GNR_Data";
            this.POSDataSetTemp_GNR_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GNR_TempBindingSource
            // 
            this.GNR_TempBindingSource.DataMember = "GNR_Temp";
            this.GNR_TempBindingSource.DataSource = this.POSDataSetTemp_GNR_Data;
            // 
            // GNR_TempTableAdapter
            // 
            this.GNR_TempTableAdapter.ClearBeforeFill = true;
            // 
            // GNR_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GNR_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GNR Report";
            this.Load += new System.EventHandler(this.GNR_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSetTemp_GNR_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNR_TempBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GNR_TempBindingSource;
        private POSDataSetTemp_GNR_Data POSDataSetTemp_GNR_Data;
        private POSDataSetTemp_GNR_DataTableAdapters.GNR_TempTableAdapter GNR_TempTableAdapter;
    }
}