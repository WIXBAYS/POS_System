namespace POS
{
    partial class Catagory_Management
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.itemCatagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagory = new POS.POSDataSetItemCataagory();
            this.checkBox_new = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLineDiscription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBuying = new System.Windows.Forms.TextBox();
            this.textBoxSelling = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonsave = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxItemList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxunits = new System.Windows.Forms.ComboBox();
            this.item_CatagoryTableAdapter = new POS.POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(13, 421);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(88, 52);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBoxNameUpdate
            // 
            this.textBoxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameUpdate.Location = new System.Drawing.Point(122, 178);
            this.textBoxNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameUpdate.Name = "textBoxNameUpdate";
            this.textBoxNameUpdate.Size = new System.Drawing.Size(284, 22);
            this.textBoxNameUpdate.TabIndex = 4;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DataSource = this.itemCatagoryBindingSource;
            this.comboBoxName.DisplayMember = "CATAGORY_NAME";
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(122, 139);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(284, 23);
            this.comboBoxName.TabIndex = 2;
            this.comboBoxName.ValueMember = "ITEMCAT_ID";
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // itemCatagoryBindingSource
            // 
            this.itemCatagoryBindingSource.DataMember = "Item_Catagory";
            this.itemCatagoryBindingSource.DataSource = this.pOSDataSetItemCataagoryBindingSource;
            // 
            // pOSDataSetItemCataagoryBindingSource
            // 
            this.pOSDataSetItemCataagoryBindingSource.DataSource = this.pOSDataSetItemCataagory;
            this.pOSDataSetItemCataagoryBindingSource.Position = 0;
            // 
            // pOSDataSetItemCataagory
            // 
            this.pOSDataSetItemCataagory.DataSetName = "POSDataSetItemCataagory";
            this.pOSDataSetItemCataagory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox_new
            // 
            this.checkBox_new.AutoSize = true;
            this.checkBox_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_new.Location = new System.Drawing.Point(122, 68);
            this.checkBox_new.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_new.Name = "checkBox_new";
            this.checkBox_new.Size = new System.Drawing.Size(54, 20);
            this.checkBox_new.TabIndex = 46;
            this.checkBox_new.Text = "New";
            this.checkBox_new.UseVisualStyleBackColor = true;
            this.checkBox_new.CheckedChanged += new System.EventHandler(this.checkBox_new_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Catagory Name";
            // 
            // textBoxLineDiscription
            // 
            this.textBoxLineDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLineDiscription.Location = new System.Drawing.Point(445, 125);
            this.textBoxLineDiscription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLineDiscription.Multiline = true;
            this.textBoxLineDiscription.Name = "textBoxLineDiscription";
            this.textBoxLineDiscription.Size = new System.Drawing.Size(364, 134);
            this.textBoxLineDiscription.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(122, 139);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(284, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxBuying
            // 
            this.textBoxBuying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuying.Location = new System.Drawing.Point(122, 296);
            this.textBoxBuying.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuying.Name = "textBoxBuying";
            this.textBoxBuying.Size = new System.Drawing.Size(108, 22);
            this.textBoxBuying.TabIndex = 7;
            this.textBoxBuying.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuying_KeyPress);
            // 
            // textBoxSelling
            // 
            this.textBoxSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelling.Location = new System.Drawing.Point(122, 333);
            this.textBoxSelling.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSelling.Name = "textBoxSelling";
            this.textBoxSelling.Size = new System.Drawing.Size(108, 22);
            this.textBoxSelling.TabIndex = 8;
            this.textBoxSelling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSelling_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Selling Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Buying Cost";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Checked = true;
            this.checkBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(122, 376);
            this.checkBoxActive.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActive.TabIndex = 9;
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Active";
            // 
            // buttonsave
            // 
            this.buttonsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsave.Location = new System.Drawing.Point(721, 431);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(88, 52);
            this.buttonsave.TabIndex = 11;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(721, 431);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 52);
            this.button_update.TabIndex = 56;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(122, 217);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(284, 22);
            this.textBoxBarcode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(285, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Manage Catagory Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 61;
            // 
            // comboBoxItemList
            // 
            this.comboBoxItemList.DataSource = this.itemCatagoryBindingSource;
            this.comboBoxItemList.DisplayMember = "CATAGORY_NAME";
            this.comboBoxItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemList.FormattingEnabled = true;
            this.comboBoxItemList.Location = new System.Drawing.Point(122, 102);
            this.comboBoxItemList.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxItemList.Name = "comboBoxItemList";
            this.comboBoxItemList.Size = new System.Drawing.Size(284, 23);
            this.comboBoxItemList.TabIndex = 1;
            this.comboBoxItemList.ValueMember = "ITEMCAT_ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Item Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Barcode No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 263);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "Unit";
            // 
            // comboBoxunits
            // 
            this.comboBoxunits.DisplayMember = "VENDER_NAME";
            this.comboBoxunits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxunits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxunits.FormattingEnabled = true;
            this.comboBoxunits.Items.AddRange(new object[] {
            "Kg",
            "L",
            "Units"});
            this.comboBoxunits.Location = new System.Drawing.Point(122, 256);
            this.comboBoxunits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxunits.Name = "comboBoxunits";
            this.comboBoxunits.Size = new System.Drawing.Size(108, 23);
            this.comboBoxunits.TabIndex = 6;
            this.comboBoxunits.ValueMember = "VENDER_ID";
            // 
            // item_CatagoryTableAdapter
            // 
            this.item_CatagoryTableAdapter.ClearBeforeFill = true;
            // 
            // Catagory_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 498);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxunits);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxItemList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSelling);
            this.Controls.Add(this.textBoxBuying);
            this.Controls.Add(this.textBoxNameUpdate);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.checkBox_new);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLineDiscription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button_cancel);
            this.Name = "Catagory_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Catagory_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBoxNameUpdate;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.CheckBox checkBox_new;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLineDiscription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBuying;
        private System.Windows.Forms.TextBox textBoxSelling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxItemList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxunits;
        private System.Windows.Forms.BindingSource pOSDataSetItemCataagoryBindingSource;
        private POSDataSetItemCataagory pOSDataSetItemCataagory;
        private System.Windows.Forms.BindingSource itemCatagoryBindingSource;
        private POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter item_CatagoryTableAdapter;
    }
}