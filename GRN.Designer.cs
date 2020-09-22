namespace POS
{
    partial class GNR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GNR));
            this.itemCatagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagory = new POS.POSDataSetItemCataagory();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonsave = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.item_CatagoryTableAdapter = new POS.POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuying = new System.Windows.Forms.TextBox();
            this.textBoxSelling = new System.Windows.Forms.TextBox();
            this.labelSellingCost = new System.Windows.Forms.Label();
            this.labelBuyingCost = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxunits = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVender = new System.Windows.Forms.ComboBox();
            this.venderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet1 = new POS.POSDataSet1();
            this.vender_DetailsTableAdapter = new POS.POSDataSet1TableAdapters.Vender_DetailsTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCatID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridViewAll
            // 
            this.dataGridViewAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Catagory_Name,
            this.Quantity,
            this.Unit,
            this.BuyingCost,
            this.ColumnDelete});
            this.dataGridViewAll.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewAll.Location = new System.Drawing.Point(439, 83);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(409, 249);
            this.dataGridViewAll.TabIndex = 83;
            this.dataGridViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAll_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Catagory_Name
            // 
            this.Catagory_Name.HeaderText = "Category Name";
            this.Catagory_Name.Name = "Catagory_Name";
            this.Catagory_Name.Width = 130;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 40;
            // 
            // BuyingCost
            // 
            this.BuyingCost.HeaderText = "Buying Cost";
            this.BuyingCost.Name = "BuyingCost";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Cancel";
            this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.Width = 45;
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsave.Location = new System.Drawing.Point(760, 385);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(88, 52);
            this.buttonsave.TabIndex = 86;
            this.buttonsave.Text = "Finalize";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(13, 385);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(88, 52);
            this.button_cancel.TabIndex = 84;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // item_CatagoryTableAdapter
            // 
            this.item_CatagoryTableAdapter.ClearBeforeFill = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotal.Location = new System.Drawing.Point(539, 346);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 16);
            this.labelTotal.TabIndex = 89;
            this.labelTotal.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.Red;
            this.textBoxTotal.Location = new System.Drawing.Point(591, 343);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(159, 22);
            this.textBoxTotal.TabIndex = 90;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCatName.Location = new System.Drawing.Point(126, 126);
            this.textBoxCatName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.ReadOnly = true;
            this.textBoxCatName.Size = new System.Drawing.Size(284, 17);
            this.textBoxCatName.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Catagory Name";
            // 
            // textBoxBuying
            // 
            this.textBoxBuying.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuying.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxBuying.Location = new System.Drawing.Point(126, 240);
            this.textBoxBuying.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuying.Name = "textBoxBuying";
            this.textBoxBuying.Size = new System.Drawing.Size(108, 17);
            this.textBoxBuying.TabIndex = 73;
            // 
            // textBoxSelling
            // 
            this.textBoxSelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSelling.Location = new System.Drawing.Point(126, 278);
            this.textBoxSelling.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSelling.Name = "textBoxSelling";
            this.textBoxSelling.Size = new System.Drawing.Size(108, 17);
            this.textBoxSelling.TabIndex = 74;
            // 
            // labelSellingCost
            // 
            this.labelSellingCost.AutoSize = true;
            this.labelSellingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellingCost.Location = new System.Drawing.Point(22, 280);
            this.labelSellingCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellingCost.Name = "labelSellingCost";
            this.labelSellingCost.Size = new System.Drawing.Size(79, 16);
            this.labelSellingCost.TabIndex = 75;
            this.labelSellingCost.Text = "Selling Cost";
            // 
            // labelBuyingCost
            // 
            this.labelBuyingCost.AutoSize = true;
            this.labelBuyingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyingCost.Location = new System.Drawing.Point(22, 240);
            this.labelBuyingCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuyingCost.Name = "labelBuyingCost";
            this.labelBuyingCost.Size = new System.Drawing.Size(79, 16);
            this.labelBuyingCost.TabIndex = 76;
            this.labelBuyingCost.Text = "Buying Cost";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxBarcode.Location = new System.Drawing.Point(126, 161);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(284, 17);
            this.textBoxBarcode.TabIndex = 77;
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "Barcode No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 258);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 81;
            // 
            // comboBoxunits
            // 
            this.comboBoxunits.DisplayMember = "VENDER_NAME";
            this.comboBoxunits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxunits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxunits.FormattingEnabled = true;
            this.comboBoxunits.Location = new System.Drawing.Point(311, 201);
            this.comboBoxunits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxunits.Name = "comboBoxunits";
            this.comboBoxunits.Size = new System.Drawing.Size(99, 21);
            this.comboBoxunits.TabIndex = 82;
            this.comboBoxunits.ValueMember = "VENDER_ID";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(322, 243);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 52);
            this.button_update.TabIndex = 85;
            this.button_update.Text = "Add To Stock";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxQuantity.Location = new System.Drawing.Point(126, 202);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(90, 17);
            this.textBoxQuantity.TabIndex = 87;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(20, 203);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 16);
            this.labelQuantity.TabIndex = 88;
            this.labelQuantity.Text = "Quantiy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "Vender";
            // 
            // comboBoxVender
            // 
            this.comboBoxVender.DataSource = this.venderDetailsBindingSource;
            this.comboBoxVender.DisplayMember = "VENDER_NAME";
            this.comboBoxVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxVender.FormattingEnabled = true;
            this.comboBoxVender.Location = new System.Drawing.Point(126, 83);
            this.comboBoxVender.Name = "comboBoxVender";
            this.comboBoxVender.Size = new System.Drawing.Size(284, 21);
            this.comboBoxVender.TabIndex = 92;
            this.comboBoxVender.ValueMember = "VENDER_ID";
            // 
            // venderDetailsBindingSource
            // 
            this.venderDetailsBindingSource.DataMember = "Vender_Details";
            this.venderDetailsBindingSource.DataSource = this.pOSDataSet1;
            // 
            // pOSDataSet1
            // 
            this.pOSDataSet1.DataSetName = "POSDataSet1";
            this.pOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vender_DetailsTableAdapter
            // 
            this.vender_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(328, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 93;
            this.label8.Text = "Goods Receipt Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(247, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Unit";
            // 
            // textBoxCatID
            // 
            this.textBoxCatID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCatID.Enabled = false;
            this.textBoxCatID.Location = new System.Drawing.Point(126, 128);
            this.textBoxCatID.Name = "textBoxCatID";
            this.textBoxCatID.ReadOnly = true;
            this.textBoxCatID.Size = new System.Drawing.Size(246, 13);
            this.textBoxCatID.TabIndex = 95;
            this.textBoxCatID.Visible = false;
            // 
            // GNR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxCatID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxVender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.comboBoxunits);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.labelBuyingCost);
            this.Controls.Add(this.labelSellingCost);
            this.Controls.Add(this.textBoxSelling);
            this.Controls.Add(this.textBoxBuying);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCatName);
            this.Name = "GNR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.BindingSource pOSDataSetItemCataagoryBindingSource;
        private POSDataSetItemCataagory pOSDataSetItemCataagory;
        private System.Windows.Forms.BindingSource itemCatagoryBindingSource;
        private POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter item_CatagoryTableAdapter;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxCatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuying;
        private System.Windows.Forms.TextBox textBoxSelling;
        private System.Windows.Forms.Label labelSellingCost;
        private System.Windows.Forms.Label labelBuyingCost;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxunits;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVender;
        private POSDataSet1 pOSDataSet1;
        private System.Windows.Forms.BindingSource venderDetailsBindingSource;
        private POSDataSet1TableAdapters.Vender_DetailsTableAdapter vender_DetailsTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingCost;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.TextBox textBoxCatID;
    }
}