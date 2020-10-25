namespace POS
{
    partial class BrandRegistration
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
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.checkBox_new = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLineDiscription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.pOSDataSetBrandData = new POS.POSDataSetBrandData();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new POS.POSDataSetBrandDataTableAdapters.BrandTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetBrandData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(144, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Brand Management";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(170, 322);
            this.checkBoxActive.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(12, 11);
            this.checkBoxActive.TabIndex = 50;
            this.checkBoxActive.UseVisualStyleBackColor = true;

            // 
            // buttonsave
            // 
            this.buttonsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsave.Location = new System.Drawing.Point(366, 370);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(88, 52);
            this.buttonsave.TabIndex = 51;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(366, 370);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 52);
            this.button_update.TabIndex = 57;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBoxNameUpdate
            // 
            this.textBoxNameUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameUpdate.Location = new System.Drawing.Point(170, 148);
            this.textBoxNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameUpdate.Name = "textBoxNameUpdate";
            this.textBoxNameUpdate.Size = new System.Drawing.Size(284, 15);
            this.textBoxNameUpdate.TabIndex = 48;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DataSource = this.brandBindingSource;
            this.comboBoxName.DisplayMember = "BRAND_NAME";
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(170, 110);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(284, 23);
            this.comboBoxName.TabIndex = 47;
            this.comboBoxName.ValueMember = "BRAND_ID";
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // checkBox_new
            // 
            this.checkBox_new.AutoSize = true;
            this.checkBox_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_new.Location = new System.Drawing.Point(170, 70);
            this.checkBox_new.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_new.Name = "checkBox_new";
            this.checkBox_new.Size = new System.Drawing.Size(51, 20);
            this.checkBox_new.TabIndex = 46;
            this.checkBox_new.Text = "New";
            this.checkBox_new.UseVisualStyleBackColor = true;
            this.checkBox_new.CheckedChanged += new System.EventHandler(this.checkBox_new_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Brand Name";
            // 
            // textBoxLineDiscription
            // 
            this.textBoxLineDiscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLineDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLineDiscription.Location = new System.Drawing.Point(170, 186);
            this.textBoxLineDiscription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLineDiscription.Multiline = true;
            this.textBoxLineDiscription.Name = "textBoxLineDiscription";
            this.textBoxLineDiscription.Size = new System.Drawing.Size(284, 109);
            this.textBoxLineDiscription.TabIndex = 49;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(170, 111);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(284, 22);
            this.textBoxName.TabIndex = 56;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(24, 370);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(88, 52);
            this.button_cancel.TabIndex = 52;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // pOSDataSetBrandData
            // 
            this.pOSDataSetBrandData.DataSetName = "POSDataSetBrandData";
            this.pOSDataSetBrandData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.pOSDataSetBrandData;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // BrandRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBoxNameUpdate);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.checkBox_new);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLineDiscription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrandRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandRegistration";
            this.Load += new System.EventHandler(this.BrandRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetBrandData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBoxNameUpdate;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.CheckBox checkBox_new;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLineDiscription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button_cancel;
        private POSDataSetBrandData pOSDataSetBrandData;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private POSDataSetBrandDataTableAdapters.BrandTableAdapter brandTableAdapter;
    }
}