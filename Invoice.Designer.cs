namespace POS
{
    partial class Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.comboBoxCatID = new System.Windows.Forms.ComboBox();
            this.itemCatagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagory = new POS.POSDataSetItemCataagory();
            this.venderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetVendorList = new POS.POSDataSetVendorList();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttoncard = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.labelSellingCost = new System.Windows.Forms.Label();
            this.textBoxSelling = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vender_DetailsTableAdapter = new POS.POSDataSetVendorListTableAdapters.Vender_DetailsTableAdapter();
            this.item_CatagoryTableAdapter = new POS.POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter();
            this.textBoxbuy = new System.Windows.Forms.TextBox();
            this.comboBoxunits = new System.Windows.Forms.ComboBox();
            this.buttoncash = new System.Windows.Forms.Button();
            this.textBoxVendorName = new System.Windows.Forms.TextBox();
            this.textBoxBC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetVendorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCatID
            // 
            this.comboBoxCatID.DataSource = this.itemCatagoryBindingSource;
            this.comboBoxCatID.DisplayMember = "CATAGORY_NAME";
            this.comboBoxCatID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCatID.FormattingEnabled = true;
            this.comboBoxCatID.Location = new System.Drawing.Point(184, 83);
            this.comboBoxCatID.Name = "comboBoxCatID";
            this.comboBoxCatID.Size = new System.Drawing.Size(284, 21);
            this.comboBoxCatID.TabIndex = 117;
            this.comboBoxCatID.TabStop = false;
            this.comboBoxCatID.ValueMember = "ITEMCAT_ID";
            this.comboBoxCatID.SelectedIndexChanged += new System.EventHandler(this.comboBoxCatID_SelectedIndexChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(564, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 39);
            this.label8.TabIndex = 115;
            this.label8.Text = "Invoice";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.Red;
            this.textBoxTotal.Location = new System.Drawing.Point(128, 408);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(159, 15);
            this.textBoxTotal.TabIndex = 112;
            this.textBoxTotal.TabStop = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotal.Location = new System.Drawing.Point(38, 407);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 16);
            this.labelTotal.TabIndex = 111;
            this.labelTotal.Text = "Total";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(37, 163);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 16);
            this.labelQuantity.TabIndex = 110;
            this.labelQuantity.Text = "Quantiy";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxQuantity.Location = new System.Drawing.Point(184, 165);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(123, 17);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // buttoncard
            // 
            this.buttoncard.BackColor = System.Drawing.Color.LimeGreen;
            this.buttoncard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncard.Location = new System.Drawing.Point(391, 452);
            this.buttoncard.Margin = new System.Windows.Forms.Padding(4);
            this.buttoncard.Name = "buttoncard";
            this.buttoncard.Size = new System.Drawing.Size(88, 52);
            this.buttoncard.TabIndex = 109;
            this.buttoncard.TabStop = false;
            this.buttoncard.Text = "Card";
            this.buttoncard.UseVisualStyleBackColor = false;
            this.buttoncard.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(391, 217);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 52);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Bill";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(13, 452);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(88, 52);
            this.button_cancel.TabIndex = 108;
            this.button_cancel.TabStop = false;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AllowUserToAddRows = false;
            this.dataGridViewAll.AllowUserToDeleteRows = false;
            this.dataGridViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Catagory_Name,
            this.Quantity,
            this.Unit,
            this.BuyingCost,
            this.Grid_Discount,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAll.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAll.Location = new System.Drawing.Point(501, 86);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewAll.Size = new System.Drawing.Size(726, 418);
            this.dataGridViewAll.TabIndex = 107;
            this.dataGridViewAll.TabStop = false;
            this.dataGridViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAll_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Catagory_Name
            // 
            this.Catagory_Name.HeaderText = "Category Name";
            this.Catagory_Name.Name = "Catagory_Name";
            this.Catagory_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // BuyingCost
            // 
            this.BuyingCost.HeaderText = "Sub Total";
            this.BuyingCost.Name = "BuyingCost";
            this.BuyingCost.ReadOnly = true;
            // 
            // Grid_Discount
            // 
            this.Grid_Discount.HeaderText = "Discount";
            this.Grid_Discount.Name = "Grid_Discount";
            this.Grid_Discount.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Remove";
            this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "Barcode No";
            // 
            // labelSellingCost
            // 
            this.labelSellingCost.AutoSize = true;
            this.labelSellingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellingCost.Location = new System.Drawing.Point(37, 202);
            this.labelSellingCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellingCost.Name = "labelSellingCost";
            this.labelSellingCost.Size = new System.Drawing.Size(79, 16);
            this.labelSellingCost.TabIndex = 104;
            this.labelSellingCost.Text = "Selling Cost";
            // 
            // textBoxSelling
            // 
            this.textBoxSelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSelling.Enabled = false;
            this.textBoxSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSelling.Location = new System.Drawing.Point(184, 205);
            this.textBoxSelling.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSelling.Name = "textBoxSelling";
            this.textBoxSelling.Size = new System.Drawing.Size(123, 17);
            this.textBoxSelling.TabIndex = 103;
            this.textBoxSelling.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Catagory Name";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Cancel";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.ForeColor = System.Drawing.Color.Red;
            this.textBoxDiscount.Location = new System.Drawing.Point(128, 326);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(159, 15);
            this.textBoxDiscount.TabIndex = 120;
            this.textBoxDiscount.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(38, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 119;
            this.label2.Text = "Discount";
            // 
            // textBoxTax
            // 
            this.textBoxTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTax.ForeColor = System.Drawing.Color.Red;
            this.textBoxTax.Location = new System.Drawing.Point(128, 370);
            this.textBoxTax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(159, 15);
            this.textBoxTax.TabIndex = 122;
            this.textBoxTax.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(38, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 121;
            this.label3.Text = "Tax";
            // 
            // vender_DetailsTableAdapter
            // 
            this.vender_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // item_CatagoryTableAdapter
            // 
            this.item_CatagoryTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxbuy
            // 
            this.textBoxbuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxbuy.Enabled = false;
            this.textBoxbuy.Location = new System.Drawing.Point(40, 238);
            this.textBoxbuy.Name = "textBoxbuy";
            this.textBoxbuy.Size = new System.Drawing.Size(123, 13);
            this.textBoxbuy.TabIndex = 123;
            // 
            // comboBoxunits
            // 
            this.comboBoxunits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxunits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxunits.FormattingEnabled = true;
            this.comboBoxunits.Location = new System.Drawing.Point(315, 163);
            this.comboBoxunits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxunits.Name = "comboBoxunits";
            this.comboBoxunits.Size = new System.Drawing.Size(99, 21);
            this.comboBoxunits.TabIndex = 2;
            // 
            // buttoncash
            // 
            this.buttoncash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttoncash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncash.Location = new System.Drawing.Point(295, 452);
            this.buttoncash.Margin = new System.Windows.Forms.Padding(4);
            this.buttoncash.Name = "buttoncash";
            this.buttoncash.Size = new System.Drawing.Size(88, 52);
            this.buttoncash.TabIndex = 125;
            this.buttoncash.TabStop = false;
            this.buttoncash.Text = "Cash";
            this.buttoncash.UseVisualStyleBackColor = false;
            this.buttoncash.Click += new System.EventHandler(this.buttoncash_Click);
            // 
            // textBoxVendorName
            // 
            this.textBoxVendorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVendorName.Enabled = false;
            this.textBoxVendorName.Location = new System.Drawing.Point(184, 238);
            this.textBoxVendorName.Name = "textBoxVendorName";
            this.textBoxVendorName.Size = new System.Drawing.Size(123, 13);
            this.textBoxVendorName.TabIndex = 126;
            this.textBoxVendorName.Visible = false;
            // 
            // textBoxBC
            // 
            this.textBoxBC.Location = new System.Drawing.Point(184, 123);
            this.textBoxBC.Name = "textBoxBC";
            this.textBoxBC.Size = new System.Drawing.Size(284, 20);
            this.textBoxBC.TabIndex = 127;
            this.textBoxBC.TextChanged += new System.EventHandler(this.textBoxBC_TextChanged_1);
            // 
            // Invoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1239, 517);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxBC);
            this.Controls.Add(this.textBoxVendorName);
            this.Controls.Add(this.buttoncash);
            this.Controls.Add(this.comboBoxunits);
            this.Controls.Add(this.textBoxbuy);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCatID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttoncard);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelSellingCost);
            this.Controls.Add(this.textBoxSelling);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetVendorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCatID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttoncard;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSellingCost;
        private System.Windows.Forms.TextBox textBoxSelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label label3;
        private POSDataSetVendorList pOSDataSetVendorList;
        private System.Windows.Forms.BindingSource venderDetailsBindingSource;
        private POSDataSetVendorListTableAdapters.Vender_DetailsTableAdapter vender_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource pOSDataSetItemCataagoryBindingSource;
        private POSDataSetItemCataagory pOSDataSetItemCataagory;
        private System.Windows.Forms.BindingSource itemCatagoryBindingSource;
        private POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter item_CatagoryTableAdapter;
        private System.Windows.Forms.TextBox textBoxbuy;
        private System.Windows.Forms.ComboBox comboBoxunits;
        private System.Windows.Forms.Button buttoncash;
        private System.Windows.Forms.TextBox textBoxVendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Discount;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.TextBox textBoxBC;
    }
}