namespace POS
{
    partial class Vendor_Management
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBusReg = new System.Windows.Forms.TextBox();
            this.textBoxMob = new System.Windows.Forms.TextBox();
            this.textBoxtel = new System.Windows.Forms.TextBox();
            this.textBoxLine3 = new System.Windows.Forms.TextBox();
            this.textBoxLine1 = new System.Windows.Forms.TextBox();
            this.textBoxLine2 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.checkBox_new = new System.Windows.Forms.CheckBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.venderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetVendorList = new POS.POSDataSetVendorList();
            this.vender_DetailsTableAdapter = new POS.POSDataSetVendorListTableAdapters.Vender_DetailsTableAdapter();
            this.textBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetVendorList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 52);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(374, 448);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(88, 52);
            this.buttonCreate.TabIndex = 24;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 403);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tax Registration No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mobile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telephone ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address Line 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address Line 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Address Line 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vendor Name";
            // 
            // textBoxBusReg
            // 
            this.textBoxBusReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusReg.Location = new System.Drawing.Point(178, 395);
            this.textBoxBusReg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBusReg.Name = "textBoxBusReg";
            this.textBoxBusReg.Size = new System.Drawing.Size(284, 22);
            this.textBoxBusReg.TabIndex = 23;
            // 
            // textBoxMob
            // 
            this.textBoxMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMob.Location = new System.Drawing.Point(178, 348);
            this.textBoxMob.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMob.Name = "textBoxMob";
            this.textBoxMob.Size = new System.Drawing.Size(284, 22);
            this.textBoxMob.TabIndex = 22;
            // 
            // textBoxtel
            // 
            this.textBoxtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtel.Location = new System.Drawing.Point(178, 304);
            this.textBoxtel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.Size = new System.Drawing.Size(284, 22);
            this.textBoxtel.TabIndex = 21;
            // 
            // textBoxLine3
            // 
            this.textBoxLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLine3.Location = new System.Drawing.Point(178, 259);
            this.textBoxLine3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLine3.Name = "textBoxLine3";
            this.textBoxLine3.Size = new System.Drawing.Size(284, 22);
            this.textBoxLine3.TabIndex = 20;
            // 
            // textBoxLine1
            // 
            this.textBoxLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLine1.Location = new System.Drawing.Point(178, 167);
            this.textBoxLine1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLine1.Name = "textBoxLine1";
            this.textBoxLine1.Size = new System.Drawing.Size(284, 22);
            this.textBoxLine1.TabIndex = 18;
            // 
            // textBoxLine2
            // 
            this.textBoxLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLine2.Location = new System.Drawing.Point(178, 211);
            this.textBoxLine2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLine2.Name = "textBoxLine2";
            this.textBoxLine2.Size = new System.Drawing.Size(284, 22);
            this.textBoxLine2.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(178, 92);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(284, 22);
            this.textBoxName.TabIndex = 17;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(374, 448);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 52);
            this.button_update.TabIndex = 26;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // checkBox_new
            // 
            this.checkBox_new.AutoSize = true;
            this.checkBox_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_new.Location = new System.Drawing.Point(169, 52);
            this.checkBox_new.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_new.Name = "checkBox_new";
            this.checkBox_new.Size = new System.Drawing.Size(54, 20);
            this.checkBox_new.TabIndex = 27;
            this.checkBox_new.Text = "New";
            this.checkBox_new.UseVisualStyleBackColor = true;
            this.checkBox_new.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.DataSource = this.venderDetailsBindingSource;
            this.comboBoxName.DisplayMember = "VENDER_NAME";
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(178, 91);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(284, 23);
            this.comboBoxName.TabIndex = 28;
            this.comboBoxName.ValueMember = "VENDER_ID";
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // venderDetailsBindingSource
            // 
            this.venderDetailsBindingSource.DataMember = "Vender_Details";
            this.venderDetailsBindingSource.DataSource = this.pOSDataSetVendorList;
            // 
            // pOSDataSetVendorList
            // 
            this.pOSDataSetVendorList.DataSetName = "POSDataSetVendorList";
            this.pOSDataSetVendorList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vender_DetailsTableAdapter
            // 
            this.vender_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxNameUpdate
            // 
            this.textBoxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameUpdate.Location = new System.Drawing.Point(178, 129);
            this.textBoxNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameUpdate.Name = "textBoxNameUpdate";
            this.textBoxNameUpdate.Size = new System.Drawing.Size(284, 22);
            this.textBoxNameUpdate.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(134, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Manage Vender Details";
            // 
            // Vendor_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 517);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNameUpdate);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.checkBox_new);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBusReg);
            this.Controls.Add(this.textBoxMob);
            this.Controls.Add(this.textBoxtel);
            this.Controls.Add(this.textBoxLine3);
            this.Controls.Add(this.textBoxLine1);
            this.Controls.Add(this.textBoxLine2);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vendor_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Vendor_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetVendorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBusReg;
        private System.Windows.Forms.TextBox textBoxMob;
        private System.Windows.Forms.TextBox textBoxtel;
        private System.Windows.Forms.TextBox textBoxLine3;
        private System.Windows.Forms.TextBox textBoxLine1;
        private System.Windows.Forms.TextBox textBoxLine2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.CheckBox checkBox_new;
        private System.Windows.Forms.ComboBox comboBoxName;
        private POSDataSetVendorList pOSDataSetVendorList;
        private System.Windows.Forms.BindingSource venderDetailsBindingSource;
        private POSDataSetVendorListTableAdapters.Vender_DetailsTableAdapter vender_DetailsTableAdapter;
        private System.Windows.Forms.TextBox textBoxNameUpdate;
        private System.Windows.Forms.Label label8;
    }
}