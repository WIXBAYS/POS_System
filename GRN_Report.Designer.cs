namespace POS
{
    partial class GRN_Report
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
            this.GRN_TempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POSDataSetTemp_GRN_Data = new POS.POSDataSetTemp_GRN_Data();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GRN_TempTableAdapter = new POS.POSDataSetTemp_GNR_DataTableAdapters.GNR_TempTableAdapter();
            this.comboBox_GRN = new System.Windows.Forms.ComboBox();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetGRN_ID_List = new POS.POSDataSetGRN_ID_List();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionTableAdapter = new POS.POSDataSetGRN_ID_ListTableAdapters.TransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GRN_TempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSetTemp_GRN_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetGRN_ID_List)).BeginInit();
            this.SuspendLayout();
            // 
            // GNR_TempBindingSource
            // 
            this.GRN_TempBindingSource.DataMember = "GNR_Temp";
            this.GRN_TempBindingSource.DataSource = this.POSDataSetTemp_GRN_Data;
            // 
            // POSDataSetTemp_GNR_Data
            // 
            this.POSDataSetTemp_GRN_Data.DataSetName = "POSDataSetTemp_GNR_Data";
            this.POSDataSetTemp_GRN_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_GNR_TEMP";
            reportDataSource1.Value = this.GRN_TempBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.GRN_Report_GRN_Form.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(955, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // GNR_TempTableAdapter
            // 
            this.GRN_TempTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_GRN
            // 
            this.comboBox_GRN.DataSource = this.transactionBindingSource;
            this.comboBox_GRN.DisplayMember = "Combine";
            this.comboBox_GRN.FormattingEnabled = true;
            this.comboBox_GRN.Location = new System.Drawing.Point(98, 12);
            this.comboBox_GRN.Name = "comboBox_GRN";
            this.comboBox_GRN.Size = new System.Drawing.Size(212, 21);
            this.comboBox_GRN.TabIndex = 1;
            this.comboBox_GRN.ValueMember = "INVOICE_NO";
            this.comboBox_GRN.SelectedIndexChanged += new System.EventHandler(this.comboBox_GRN_SelectedIndexChanged);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.pOSDataSetGRN_ID_List;
            // 
            // pOSDataSetGRN_ID_List
            // 
            this.pOSDataSetGRN_ID_List.DataSetName = "POSDataSetGRN_ID_List";
            this.pOSDataSetGRN_ID_List.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRN Report ID";
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // GRN_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_GRN);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GRN_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRN Report";
            this.Load += new System.EventHandler(this.GNR_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRN_TempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSetTemp_GRN_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetGRN_ID_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GRN_TempBindingSource;
        private POSDataSetTemp_GRN_Data POSDataSetTemp_GRN_Data;
        private POSDataSetTemp_GNR_DataTableAdapters.GNR_TempTableAdapter GRN_TempTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_GRN;
        private System.Windows.Forms.Label label1;
        private POSDataSetGRN_ID_List pOSDataSetGRN_ID_List;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private POSDataSetGRN_ID_ListTableAdapters.TransactionTableAdapter transactionTableAdapter;
    }
}