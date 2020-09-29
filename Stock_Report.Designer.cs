namespace POS
{
    partial class Stock_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerStock_report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Stock_BalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POSDataSetStockBlance = new POS.POSDataSetStockBlance();
            this.Stock_BalanceTableAdapter = new POS.POSDataSetStockBlanceTableAdapters.Stock_BalanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_BalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSetStockBlance)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerStock_report
            // 
            this.reportViewerStock_report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetStockBalance";
            reportDataSource2.Value = this.Stock_BalanceBindingSource;
            this.reportViewerStock_report.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerStock_report.LocalReport.ReportEmbeddedResource = "POS.ReportStockBalance.rdlc";
            this.reportViewerStock_report.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStock_report.Name = "reportViewerStock_report";
            this.reportViewerStock_report.ServerReport.BearerToken = null;
            this.reportViewerStock_report.Size = new System.Drawing.Size(740, 450);
            this.reportViewerStock_report.TabIndex = 0;
            // 
            // Stock_BalanceBindingSource
            // 
            this.Stock_BalanceBindingSource.DataMember = "Stock_Balance";
            this.Stock_BalanceBindingSource.DataSource = this.POSDataSetStockBlance;
            // 
            // POSDataSetStockBlance
            // 
            this.POSDataSetStockBlance.DataSetName = "POSDataSetStockBlance";
            this.POSDataSetStockBlance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Stock_BalanceTableAdapter
            // 
            this.Stock_BalanceTableAdapter.ClearBeforeFill = true;
            // 
            // Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.reportViewerStock_report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stock_BalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSetStockBlance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStock_report;
        private System.Windows.Forms.BindingSource Stock_BalanceBindingSource;
        private POSDataSetStockBlance POSDataSetStockBlance;
        private POSDataSetStockBlanceTableAdapters.Stock_BalanceTableAdapter Stock_BalanceTableAdapter;
    }
}