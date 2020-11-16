using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.comboBoxCatID = new System.Windows.Forms.ComboBox();
            this.itemCatagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemCataagory = new POS.POSDataSetItemCataagory();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.ColumnBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount_Amout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelSellingCost = new System.Windows.Forms.Label();
            this.textBoxSelling = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_CatagoryTableAdapter = new POS.POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter();
            this.textBoxbuy = new System.Windows.Forms.TextBox();
            this.textBoxVendorName = new System.Windows.Forms.TextBox();
            this.buttonNP8 = new System.Windows.Forms.Button();
            this.buttonNP9 = new System.Windows.Forms.Button();
            this.buttonNP6 = new System.Windows.Forms.Button();
            this.buttonNP5 = new System.Windows.Forms.Button();
            this.buttonNP4 = new System.Windows.Forms.Button();
            this.buttonNP3 = new System.Windows.Forms.Button();
            this.buttonNP2 = new System.Windows.Forms.Button();
            this.buttonNP1 = new System.Windows.Forms.Button();
            this.buttonNP0 = new System.Windows.Forms.Button();
            this.buttonNPDot = new System.Windows.Forms.Button();
            this.buttonNPEnter = new System.Windows.Forms.Button();
            this.buttonNP00 = new System.Windows.Forms.Button();
            this.buttonNPStar = new System.Windows.Forms.Button();
            this.buttonNPMinus = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.buttonNPBack = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.textBoxtTlLineDiscountP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNetDiscountP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtTlLineDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDueAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInvoice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonNP7 = new System.Windows.Forms.Button();
            this.labelCurrenty = new System.Windows.Forms.Label();
            this.labelInGrid = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.buttonChangeLogin = new System.Windows.Forms.Button();
            this.venderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.LblTime = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.Hiddenlabel = new System.Windows.Forms.Label();
            this.Hiddenlabel1 = new System.Windows.Forms.Label();
            this.textBoxNetDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBalanceAmount = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.checkBoxCardPayment = new System.Windows.Forms.CheckBox();
            this.textBoxVoucherAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.labelBarCodeVoucher = new System.Windows.Forms.Label();
            this.textBoxVoucherNo = new System.Windows.Forms.TextBox();
            this.labelVoucherNo = new System.Windows.Forms.Label();
            this.labelVoucherVisible = new System.Windows.Forms.Label();
            this.buttonAddVoucher = new System.Windows.Forms.Button();
            this.dataGridViewVoucher = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelVoucherID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCatID
            // 
            this.comboBoxCatID.DataSource = this.itemCatagoryBindingSource;
            this.comboBoxCatID.DisplayMember = "CATEGORY_NAME";
            this.comboBoxCatID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCatID.FormattingEnabled = true;
            this.comboBoxCatID.Location = new System.Drawing.Point(117, 32);
            this.comboBoxCatID.Name = "comboBoxCatID";
            this.comboBoxCatID.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCatID.TabIndex = 117;
            this.comboBoxCatID.TabStop = false;
            this.comboBoxCatID.ValueMember = "ITEMCAT_ID";
            this.comboBoxCatID.TabStopChanged += new System.EventHandler(this.textBoxCAT_TextChanged);
            this.comboBoxCatID.TextChanged += new System.EventHandler(this.textBoxCAT_TextChanged);
            this.comboBoxCatID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCAT_TextChanged);
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
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxTotal.Location = new System.Drawing.Point(737, 393);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(159, 15);
            this.textBoxTotal.TabIndex = 112;
            this.textBoxTotal.TabStop = false;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotal.Location = new System.Drawing.Point(549, 393);
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
            this.labelQuantity.Location = new System.Drawing.Point(7, 74);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 16);
            this.labelQuantity.TabIndex = 110;
            this.labelQuantity.Text = "Quantiy";
            // 
            // buttonComplete
            // 
            this.buttonComplete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonComplete.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComplete.Location = new System.Drawing.Point(729, 602);
            this.buttonComplete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(175, 36);
            this.buttonComplete.TabIndex = 13;
            this.buttonComplete.Text = "Process Payment";
            this.buttonComplete.UseVisualStyleBackColor = false;
            this.buttonComplete.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(184, 104);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 79);
            this.button_update.TabIndex = 3;
            this.button_update.TabStop = false;
            this.button_update.Text = "Add";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(906, 32);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(88, 86);
            this.button_cancel.TabIndex = 108;
            this.button_cancel.TabStop = false;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBarCode,
            this.Catagory_Name,
            this.ColumnUnit,
            this.Unit_Price,
            this.Grid_Discount,
            this.Discount_Amout,
            this.Quantity,
            this.BuyingCost,
            this.ColumnCategoryID,
            this.ColumnDelete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAll.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAll.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAll.Location = new System.Drawing.Point(16, 37);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(880, 212);
            this.dataGridViewAll.TabIndex = 107;
            this.dataGridViewAll.TabStop = false;
            this.dataGridViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAll_CellContentClick);
            this.dataGridViewAll.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ColumnBarCode
            // 
            this.ColumnBarCode.FillWeight = 117.2625F;
            this.ColumnBarCode.HeaderText = "BarCode";
            this.ColumnBarCode.Name = "ColumnBarCode";
            // 
            // Catagory_Name
            // 
            this.Catagory_Name.FillWeight = 106.4265F;
            this.Catagory_Name.HeaderText = "Category Name";
            this.Catagory_Name.Name = "Catagory_Name";
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.FillWeight = 115.9944F;
            this.ColumnUnit.HeaderText = "Unit";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.FillWeight = 97.49506F;
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // Grid_Discount
            // 
            this.Grid_Discount.FillWeight = 131.758F;
            this.Grid_Discount.HeaderText = "Discount";
            this.Grid_Discount.Name = "Grid_Discount";
            this.Grid_Discount.ReadOnly = true;
            // 
            // Discount_Amout
            // 
            this.Discount_Amout.FillWeight = 120.7522F;
            this.Discount_Amout.HeaderText = "Dis. Amount Per Unit";
            this.Discount_Amout.Name = "Discount_Amout";
            this.Discount_Amout.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 108.0643F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // BuyingCost
            // 
            this.BuyingCost.FillWeight = 99.30529F;
            this.BuyingCost.HeaderText = "Sub Total";
            this.BuyingCost.Name = "BuyingCost";
            // 
            // ColumnCategoryID
            // 
            this.ColumnCategoryID.HeaderText = "CategoryID";
            this.ColumnCategoryID.Name = "ColumnCategoryID";
            this.ColumnCategoryID.Visible = false;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnDelete.FillWeight = 2.941738F;
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 44;
            // 
            // labelSellingCost
            // 
            this.labelSellingCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSellingCost.AutoSize = true;
            this.labelSellingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellingCost.Location = new System.Drawing.Point(41, 173);
            this.labelSellingCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellingCost.Name = "labelSellingCost";
            this.labelSellingCost.Size = new System.Drawing.Size(79, 16);
            this.labelSellingCost.TabIndex = 104;
            this.labelSellingCost.Text = "Selling Cost";
            // 
            // textBoxSelling
            // 
            this.textBoxSelling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSelling.Enabled = false;
            this.textBoxSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSelling.Location = new System.Drawing.Point(188, 176);
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
            this.label1.Location = new System.Drawing.Point(7, 33);
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
            // item_CatagoryTableAdapter
            // 
            this.item_CatagoryTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxbuy
            // 
            this.textBoxbuy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxbuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxbuy.Enabled = false;
            this.textBoxbuy.Location = new System.Drawing.Point(44, 209);
            this.textBoxbuy.Name = "textBoxbuy";
            this.textBoxbuy.Size = new System.Drawing.Size(123, 13);
            this.textBoxbuy.TabIndex = 123;
            // 
            // textBoxVendorName
            // 
            this.textBoxVendorName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxVendorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVendorName.Enabled = false;
            this.textBoxVendorName.Location = new System.Drawing.Point(188, 209);
            this.textBoxVendorName.Name = "textBoxVendorName";
            this.textBoxVendorName.Size = new System.Drawing.Size(123, 13);
            this.textBoxVendorName.TabIndex = 126;
            this.textBoxVendorName.Visible = false;
            // 
            // buttonNP8
            // 
            this.buttonNP8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP8.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP8.ForeColor = System.Drawing.Color.Red;
            this.buttonNP8.Location = new System.Drawing.Point(1085, 240);
            this.buttonNP8.Name = "buttonNP8";
            this.buttonNP8.Size = new System.Drawing.Size(88, 79);
            this.buttonNP8.TabIndex = 129;
            this.buttonNP8.TabStop = false;
            this.buttonNP8.Text = "8";
            this.buttonNP8.UseVisualStyleBackColor = false;
            this.buttonNP8.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonNP9
            // 
            this.buttonNP9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP9.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP9.ForeColor = System.Drawing.Color.Red;
            this.buttonNP9.Location = new System.Drawing.Point(1174, 240);
            this.buttonNP9.Name = "buttonNP9";
            this.buttonNP9.Size = new System.Drawing.Size(88, 79);
            this.buttonNP9.TabIndex = 130;
            this.buttonNP9.TabStop = false;
            this.buttonNP9.Text = "9";
            this.buttonNP9.UseVisualStyleBackColor = false;
            this.buttonNP9.Click += new System.EventHandler(this.buttonNP9_Click);
            // 
            // buttonNP6
            // 
            this.buttonNP6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP6.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP6.ForeColor = System.Drawing.Color.Red;
            this.buttonNP6.Location = new System.Drawing.Point(1174, 323);
            this.buttonNP6.Name = "buttonNP6";
            this.buttonNP6.Size = new System.Drawing.Size(88, 79);
            this.buttonNP6.TabIndex = 133;
            this.buttonNP6.TabStop = false;
            this.buttonNP6.Text = "6";
            this.buttonNP6.UseVisualStyleBackColor = false;
            this.buttonNP6.Click += new System.EventHandler(this.buttonNP6_Click);
            // 
            // buttonNP5
            // 
            this.buttonNP5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP5.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP5.ForeColor = System.Drawing.Color.Red;
            this.buttonNP5.Location = new System.Drawing.Point(1085, 323);
            this.buttonNP5.Name = "buttonNP5";
            this.buttonNP5.Size = new System.Drawing.Size(88, 79);
            this.buttonNP5.TabIndex = 132;
            this.buttonNP5.TabStop = false;
            this.buttonNP5.Text = "5";
            this.buttonNP5.UseVisualStyleBackColor = false;
            this.buttonNP5.Click += new System.EventHandler(this.buttonNP5_Click);
            // 
            // buttonNP4
            // 
            this.buttonNP4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP4.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP4.ForeColor = System.Drawing.Color.Red;
            this.buttonNP4.Location = new System.Drawing.Point(996, 323);
            this.buttonNP4.Name = "buttonNP4";
            this.buttonNP4.Size = new System.Drawing.Size(88, 79);
            this.buttonNP4.TabIndex = 131;
            this.buttonNP4.TabStop = false;
            this.buttonNP4.Text = "4";
            this.buttonNP4.UseVisualStyleBackColor = false;
            this.buttonNP4.Click += new System.EventHandler(this.buttonNP4_Click);
            // 
            // buttonNP3
            // 
            this.buttonNP3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP3.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP3.ForeColor = System.Drawing.Color.Red;
            this.buttonNP3.Location = new System.Drawing.Point(1174, 406);
            this.buttonNP3.Name = "buttonNP3";
            this.buttonNP3.Size = new System.Drawing.Size(88, 79);
            this.buttonNP3.TabIndex = 136;
            this.buttonNP3.TabStop = false;
            this.buttonNP3.Text = "3";
            this.buttonNP3.UseVisualStyleBackColor = false;
            this.buttonNP3.Click += new System.EventHandler(this.buttonNP3_Click);
            // 
            // buttonNP2
            // 
            this.buttonNP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP2.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP2.ForeColor = System.Drawing.Color.Red;
            this.buttonNP2.Location = new System.Drawing.Point(1085, 406);
            this.buttonNP2.Name = "buttonNP2";
            this.buttonNP2.Size = new System.Drawing.Size(88, 79);
            this.buttonNP2.TabIndex = 135;
            this.buttonNP2.TabStop = false;
            this.buttonNP2.Text = "2";
            this.buttonNP2.UseVisualStyleBackColor = false;
            this.buttonNP2.Click += new System.EventHandler(this.buttonNP2_Click);
            // 
            // buttonNP1
            // 
            this.buttonNP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP1.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP1.ForeColor = System.Drawing.Color.Red;
            this.buttonNP1.Location = new System.Drawing.Point(996, 406);
            this.buttonNP1.Name = "buttonNP1";
            this.buttonNP1.Size = new System.Drawing.Size(88, 79);
            this.buttonNP1.TabIndex = 134;
            this.buttonNP1.TabStop = false;
            this.buttonNP1.Text = "1";
            this.buttonNP1.UseVisualStyleBackColor = false;
            this.buttonNP1.Click += new System.EventHandler(this.buttonNP1_Click);
            // 
            // buttonNP0
            // 
            this.buttonNP0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP0.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP0.ForeColor = System.Drawing.Color.Red;
            this.buttonNP0.Location = new System.Drawing.Point(996, 489);
            this.buttonNP0.Name = "buttonNP0";
            this.buttonNP0.Size = new System.Drawing.Size(88, 79);
            this.buttonNP0.TabIndex = 137;
            this.buttonNP0.TabStop = false;
            this.buttonNP0.Text = "0";
            this.buttonNP0.UseVisualStyleBackColor = false;
            this.buttonNP0.Click += new System.EventHandler(this.buttonNP0_Click);
            // 
            // buttonNPDot
            // 
            this.buttonNPDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNPDot.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNPDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNPDot.ForeColor = System.Drawing.Color.Red;
            this.buttonNPDot.Location = new System.Drawing.Point(1085, 489);
            this.buttonNPDot.Name = "buttonNPDot";
            this.buttonNPDot.Size = new System.Drawing.Size(88, 79);
            this.buttonNPDot.TabIndex = 138;
            this.buttonNPDot.TabStop = false;
            this.buttonNPDot.Text = ".";
            this.buttonNPDot.UseVisualStyleBackColor = false;
            this.buttonNPDot.Click += new System.EventHandler(this.buttonNPDot_Click);
            // 
            // buttonNPEnter
            // 
            this.buttonNPEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNPEnter.BackColor = System.Drawing.Color.LightCyan;
            this.buttonNPEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNPEnter.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonNPEnter.Location = new System.Drawing.Point(1174, 489);
            this.buttonNPEnter.Name = "buttonNPEnter";
            this.buttonNPEnter.Size = new System.Drawing.Size(88, 79);
            this.buttonNPEnter.TabIndex = 139;
            this.buttonNPEnter.TabStop = false;
            this.buttonNPEnter.Text = "Enter";
            this.buttonNPEnter.UseVisualStyleBackColor = false;
            // 
            // buttonNP00
            // 
            this.buttonNP00.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP00.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP00.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP00.ForeColor = System.Drawing.Color.Red;
            this.buttonNP00.Location = new System.Drawing.Point(905, 490);
            this.buttonNP00.Name = "buttonNP00";
            this.buttonNP00.Size = new System.Drawing.Size(88, 79);
            this.buttonNP00.TabIndex = 143;
            this.buttonNP00.TabStop = false;
            this.buttonNP00.Text = "00";
            this.buttonNP00.UseVisualStyleBackColor = false;
            this.buttonNP00.Click += new System.EventHandler(this.buttonNP00_Click);
            // 
            // buttonNPStar
            // 
            this.buttonNPStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNPStar.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNPStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNPStar.ForeColor = System.Drawing.Color.Red;
            this.buttonNPStar.Location = new System.Drawing.Point(905, 407);
            this.buttonNPStar.Name = "buttonNPStar";
            this.buttonNPStar.Size = new System.Drawing.Size(88, 79);
            this.buttonNPStar.TabIndex = 142;
            this.buttonNPStar.TabStop = false;
            this.buttonNPStar.Text = "*";
            this.buttonNPStar.UseVisualStyleBackColor = false;
            this.buttonNPStar.Click += new System.EventHandler(this.buttonNPStar_Click);
            // 
            // buttonNPMinus
            // 
            this.buttonNPMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNPMinus.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNPMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNPMinus.ForeColor = System.Drawing.Color.Red;
            this.buttonNPMinus.Location = new System.Drawing.Point(905, 324);
            this.buttonNPMinus.Name = "buttonNPMinus";
            this.buttonNPMinus.Size = new System.Drawing.Size(88, 79);
            this.buttonNPMinus.TabIndex = 141;
            this.buttonNPMinus.TabStop = false;
            this.buttonNPMinus.Text = "-";
            this.buttonNPMinus.UseVisualStyleBackColor = false;
            this.buttonNPMinus.Click += new System.EventHandler(this.buttonNPMinus_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.BackColor = System.Drawing.Color.LightCyan;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.DarkGreen;
            this.button16.Location = new System.Drawing.Point(996, 36);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(88, 79);
            this.button16.TabIndex = 140;
            this.button16.TabStop = false;
            this.button16.Text = "Clear";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.BackColor = System.Drawing.Color.DarkGray;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Red;
            this.button17.Location = new System.Drawing.Point(905, 118);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(88, 79);
            this.button17.TabIndex = 147;
            this.button17.TabStop = false;
            this.button17.Text = "Cancel";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.BackColor = System.Drawing.Color.DarkGray;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Location = new System.Drawing.Point(1174, 117);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(88, 79);
            this.button18.TabIndex = 146;
            this.button18.TabStop = false;
            this.button18.Text = "Open Drawer";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.BackColor = System.Drawing.Color.DarkGray;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(1085, 117);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(88, 79);
            this.button19.TabIndex = 145;
            this.button19.TabStop = false;
            this.button19.Text = "Print";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.BackColor = System.Drawing.Color.DarkGray;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Blue;
            this.button20.Location = new System.Drawing.Point(996, 117);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(88, 79);
            this.button20.TabIndex = 144;
            this.button20.TabStop = false;
            this.button20.Text = "Recall";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.BackColor = System.Drawing.Color.Gray;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(1174, 36);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(88, 79);
            this.button21.TabIndex = 151;
            this.button21.TabStop = false;
            this.button21.Text = "Voucher";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // buttonNPBack
            // 
            this.buttonNPBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNPBack.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNPBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNPBack.ForeColor = System.Drawing.Color.Red;
            this.buttonNPBack.Location = new System.Drawing.Point(906, 240);
            this.buttonNPBack.Name = "buttonNPBack";
            this.buttonNPBack.Size = new System.Drawing.Size(88, 79);
            this.buttonNPBack.TabIndex = 148;
            this.buttonNPBack.TabStop = false;
            this.buttonNPBack.Text = "Back";
            this.buttonNPBack.UseVisualStyleBackColor = false;
            this.buttonNPBack.Click += new System.EventHandler(this.buttonNPBack_Click);
            // 
            // button28
            // 
            this.button28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button28.BackColor = System.Drawing.Color.Gray;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(1085, 35);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(88, 79);
            this.button28.TabIndex = 152;
            this.button28.TabStop = false;
            this.button28.Text = "Customer";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // textBoxtTlLineDiscountP
            // 
            this.textBoxtTlLineDiscountP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxtTlLineDiscountP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxtTlLineDiscountP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtTlLineDiscountP.Enabled = false;
            this.textBoxtTlLineDiscountP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtTlLineDiscountP.ForeColor = System.Drawing.Color.Green;
            this.textBoxtTlLineDiscountP.Location = new System.Drawing.Point(739, 306);
            this.textBoxtTlLineDiscountP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtTlLineDiscountP.Name = "textBoxtTlLineDiscountP";
            this.textBoxtTlLineDiscountP.ReadOnly = true;
            this.textBoxtTlLineDiscountP.Size = new System.Drawing.Size(159, 15);
            this.textBoxtTlLineDiscountP.TabIndex = 160;
            this.textBoxtTlLineDiscountP.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(549, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 159;
            this.label4.Text = "Total Line Dis %";
            // 
            // textBoxNetDiscountP
            // 
            this.textBoxNetDiscountP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNetDiscountP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNetDiscountP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNetDiscountP.Enabled = false;
            this.textBoxNetDiscountP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetDiscountP.ForeColor = System.Drawing.Color.Green;
            this.textBoxNetDiscountP.Location = new System.Drawing.Point(739, 335);
            this.textBoxNetDiscountP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNetDiscountP.Name = "textBoxNetDiscountP";
            this.textBoxNetDiscountP.ReadOnly = true;
            this.textBoxNetDiscountP.Size = new System.Drawing.Size(159, 15);
            this.textBoxNetDiscountP.TabIndex = 158;
            this.textBoxNetDiscountP.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(549, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 157;
            this.label5.Text = "Total Bill Discount%";
            // 
            // textBoxtTlLineDiscount
            // 
            this.textBoxtTlLineDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxtTlLineDiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxtTlLineDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtTlLineDiscount.Enabled = false;
            this.textBoxtTlLineDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtTlLineDiscount.ForeColor = System.Drawing.Color.Green;
            this.textBoxtTlLineDiscount.Location = new System.Drawing.Point(738, 277);
            this.textBoxtTlLineDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtTlLineDiscount.Name = "textBoxtTlLineDiscount";
            this.textBoxtTlLineDiscount.ReadOnly = true;
            this.textBoxtTlLineDiscount.Size = new System.Drawing.Size(159, 15);
            this.textBoxtTlLineDiscount.TabIndex = 156;
            this.textBoxtTlLineDiscount.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(549, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 155;
            this.label6.Text = "Total Line Dis Amount";
            // 
            // textBoxDueAmount
            // 
            this.textBoxDueAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxDueAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDueAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDueAmount.Enabled = false;
            this.textBoxDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDueAmount.ForeColor = System.Drawing.Color.Green;
            this.textBoxDueAmount.Location = new System.Drawing.Point(739, 423);
            this.textBoxDueAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDueAmount.Name = "textBoxDueAmount";
            this.textBoxDueAmount.ReadOnly = true;
            this.textBoxDueAmount.Size = new System.Drawing.Size(159, 15);
            this.textBoxDueAmount.TabIndex = 164;
            this.textBoxDueAmount.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(549, 422);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 163;
            this.label7.Text = "Due Amount";
            // 
            // textBoxInvoice
            // 
            this.textBoxInvoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxInvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInvoice.Enabled = false;
            this.textBoxInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoice.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxInvoice.Location = new System.Drawing.Point(739, 453);
            this.textBoxInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInvoice.Name = "textBoxInvoice";
            this.textBoxInvoice.ReadOnly = true;
            this.textBoxInvoice.Size = new System.Drawing.Size(159, 15);
            this.textBoxInvoice.TabIndex = 166;
            this.textBoxInvoice.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(549, 452);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 165;
            this.label8.Text = "Invoice Amount";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPassword.Location = new System.Drawing.Point(137, 326);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(177, 20);
            this.TxtPassword.TabIndex = 170;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox7_TextChanged);
            this.TxtPassword.TabIndexChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 168;
            this.label9.Text = "Password";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 297);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 167;
            this.label11.Text = "User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.comboBoxCatID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.labelQuantity);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(19, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 191);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Items";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxQuantity.Location = new System.Drawing.Point(114, 70);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(170, 20);
            this.textBoxQuantity.TabIndex = 177;
            this.textBoxQuantity.TabStop = false;
            this.textBoxQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxQntty_TextChanged);
            this.textBoxQuantity.TabIndexChanged += new System.EventHandler(this.textBoxQntty_TextChanged);
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQntty_TextChanged);
            // 
            // buttonNP7
            // 
            this.buttonNP7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNP7.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNP7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNP7.ForeColor = System.Drawing.Color.Red;
            this.buttonNP7.Location = new System.Drawing.Point(996, 240);
            this.buttonNP7.Name = "buttonNP7";
            this.buttonNP7.Size = new System.Drawing.Size(88, 79);
            this.buttonNP7.TabIndex = 173;
            this.buttonNP7.TabStop = false;
            this.buttonNP7.Text = "7";
            this.buttonNP7.UseVisualStyleBackColor = false;
            this.buttonNP7.Click += new System.EventHandler(this.buttonNP7_Click);
            // 
            // labelCurrenty
            // 
            this.labelCurrenty.AutoSize = true;
            this.labelCurrenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrenty.Location = new System.Drawing.Point(445, 277);
            this.labelCurrenty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrenty.Name = "labelCurrenty";
            this.labelCurrenty.Size = new System.Drawing.Size(17, 16);
            this.labelCurrenty.TabIndex = 174;
            this.labelCurrenty.Text = "Y";
            this.labelCurrenty.Visible = false;
            // 
            // labelInGrid
            // 
            this.labelInGrid.AutoSize = true;
            this.labelInGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInGrid.Location = new System.Drawing.Point(461, 277);
            this.labelInGrid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInGrid.Name = "labelInGrid";
            this.labelInGrid.Size = new System.Drawing.Size(43, 16);
            this.labelInGrid.TabIndex = 176;
            this.labelInGrid.Text = "InGrid";
            this.labelInGrid.Visible = false;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtUserName.Location = new System.Drawing.Point(137, 297);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(177, 20);
            this.TxtUserName.TabIndex = 177;
            this.TxtUserName.TabStop = false;
            this.TxtUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUN_TextChanged);
            this.TxtUserName.TabIndexChanged += new System.EventHandler(this.textBoxUN_TextChanged);
            this.TxtUserName.TextChanged += new System.EventHandler(this.textBoxUN_TextChanged);
            // 
            // buttonChangeLogin
            // 
            this.buttonChangeLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonChangeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChangeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeLogin.Location = new System.Drawing.Point(203, 356);
            this.buttonChangeLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeLogin.Name = "buttonChangeLogin";
            this.buttonChangeLogin.Size = new System.Drawing.Size(111, 30);
            this.buttonChangeLogin.TabIndex = 178;
            this.buttonChangeLogin.TabStop = false;
            this.buttonChangeLogin.Text = "Change Login";
            this.buttonChangeLogin.UseVisualStyleBackColor = false;
            this.buttonChangeLogin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 179;
            this.label2.Text = "User";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_tick);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.Blue;
            this.LblTime.Location = new System.Drawing.Point(325, 9);
            this.LblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(57, 16);
            this.LblTime.TabIndex = 182;
            this.LblTime.Text = "LblTime";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(395, 278);
            this.labelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(48, 16);
            this.labelD.TabIndex = 183;
            this.labelD.Text = "labelD";
            this.labelD.Visible = false;
            // 
            // Hiddenlabel
            // 
            this.Hiddenlabel.AutoSize = true;
            this.Hiddenlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hiddenlabel.ForeColor = System.Drawing.Color.Blue;
            this.Hiddenlabel.Location = new System.Drawing.Point(351, 278);
            this.Hiddenlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hiddenlabel.Name = "Hiddenlabel";
            this.Hiddenlabel.Size = new System.Drawing.Size(45, 16);
            this.Hiddenlabel.TabIndex = 184;
            this.Hiddenlabel.Text = "label3";
            this.Hiddenlabel.Visible = false;
            // 
            // Hiddenlabel1
            // 
            this.Hiddenlabel1.AutoSize = true;
            this.Hiddenlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hiddenlabel1.ForeColor = System.Drawing.Color.Blue;
            this.Hiddenlabel1.Location = new System.Drawing.Point(221, 9);
            this.Hiddenlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hiddenlabel1.Name = "Hiddenlabel1";
            this.Hiddenlabel1.Size = new System.Drawing.Size(45, 16);
            this.Hiddenlabel1.TabIndex = 185;
            this.Hiddenlabel1.Text = "label3";
            // 
            // textBoxNetDiscount
            // 
            this.textBoxNetDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNetDiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNetDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNetDiscount.Enabled = false;
            this.textBoxNetDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetDiscount.ForeColor = System.Drawing.Color.Green;
            this.textBoxNetDiscount.Location = new System.Drawing.Point(738, 364);
            this.textBoxNetDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNetDiscount.Name = "textBoxNetDiscount";
            this.textBoxNetDiscount.ReadOnly = true;
            this.textBoxNetDiscount.Size = new System.Drawing.Size(159, 15);
            this.textBoxNetDiscount.TabIndex = 187;
            this.textBoxNetDiscount.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(549, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 186;
            this.label3.Text = "Total Bill Discount Amount";
            // 
            // textBoxBalanceAmount
            // 
            this.textBoxBalanceAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxBalanceAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxBalanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBalanceAmount.Enabled = false;
            this.textBoxBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalanceAmount.ForeColor = System.Drawing.Color.Blue;
            this.textBoxBalanceAmount.Location = new System.Drawing.Point(739, 568);
            this.textBoxBalanceAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBalanceAmount.Name = "textBoxBalanceAmount";
            this.textBoxBalanceAmount.ReadOnly = true;
            this.textBoxBalanceAmount.Size = new System.Drawing.Size(159, 15);
            this.textBoxBalanceAmount.TabIndex = 12;
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.Blue;
            this.labelBalance.Location = new System.Drawing.Point(549, 567);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(65, 16);
            this.labelBalance.TabIndex = 190;
            this.labelBalance.Text = "Balance";
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPaidAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaidAmount.ForeColor = System.Drawing.Color.Blue;
            this.textBoxPaidAmount.Location = new System.Drawing.Point(739, 539);
            this.textBoxPaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(159, 15);
            this.textBoxPaidAmount.TabIndex = 11;
            this.textBoxPaidAmount.Leave += new System.EventHandler(this.textBoxPaidAmount_MouseLeave);
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaidAmount.ForeColor = System.Drawing.Color.Blue;
            this.labelPaidAmount.Location = new System.Drawing.Point(549, 539);
            this.labelPaidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(95, 16);
            this.labelPaidAmount.TabIndex = 188;
            this.labelPaidAmount.Text = "Paid Amount";
            // 
            // checkBoxCardPayment
            // 
            this.checkBoxCardPayment.AutoSize = true;
            this.checkBoxCardPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCardPayment.Location = new System.Drawing.Point(594, 478);
            this.checkBoxCardPayment.Name = "checkBoxCardPayment";
            this.checkBoxCardPayment.Size = new System.Drawing.Size(100, 19);
            this.checkBoxCardPayment.TabIndex = 10;
            this.checkBoxCardPayment.Text = "CardPayment";
            this.checkBoxCardPayment.UseVisualStyleBackColor = true;
            this.checkBoxCardPayment.CheckedChanged += new System.EventHandler(this.checkBoxCardPayment_CheckedChanged);
            // 
            // textBoxVoucherAmount
            // 
            this.textBoxVoucherAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxVoucherAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxVoucherAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVoucherAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVoucherAmount.ForeColor = System.Drawing.Color.Blue;
            this.textBoxVoucherAmount.Location = new System.Drawing.Point(740, 513);
            this.textBoxVoucherAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVoucherAmount.Name = "textBoxVoucherAmount";
            this.textBoxVoucherAmount.Size = new System.Drawing.Size(159, 15);
            this.textBoxVoucherAmount.TabIndex = 191;
            this.textBoxVoucherAmount.TabStop = false;
            this.textBoxVoucherAmount.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(549, 513);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 192;
            this.label10.Text = "Voucher Amount";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBarCode.Location = new System.Drawing.Point(424, 397);
            this.textBoxBarCode.MaxLength = 10;
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(108, 20);
            this.textBoxBarCode.TabIndex = 75;
            this.textBoxBarCode.TabStop = false;
            this.textBoxBarCode.Visible = false;
            this.textBoxBarCode.Leave += new System.EventHandler(this.textBoxLoadByBarCode);
            // 
            // labelBarCodeVoucher
            // 
            this.labelBarCodeVoucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBarCodeVoucher.AutoSize = true;
            this.labelBarCodeVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarCodeVoucher.Location = new System.Drawing.Point(338, 399);
            this.labelBarCodeVoucher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBarCodeVoucher.Name = "labelBarCodeVoucher";
            this.labelBarCodeVoucher.Size = new System.Drawing.Size(62, 16);
            this.labelBarCodeVoucher.TabIndex = 212;
            this.labelBarCodeVoucher.Text = "BarCode";
            this.labelBarCodeVoucher.Visible = false;
            // 
            // textBoxVoucherNo
            // 
            this.textBoxVoucherNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxVoucherNo.Location = new System.Drawing.Point(424, 425);
            this.textBoxVoucherNo.MaxLength = 100;
            this.textBoxVoucherNo.Name = "textBoxVoucherNo";
            this.textBoxVoucherNo.Size = new System.Drawing.Size(107, 20);
            this.textBoxVoucherNo.TabIndex = 76;
            this.textBoxVoucherNo.Visible = false;
            this.textBoxVoucherNo.Leave += new System.EventHandler(this.textBoxLoadByVoucherNo);
            // 
            // labelVoucherNo
            // 
            this.labelVoucherNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVoucherNo.AutoSize = true;
            this.labelVoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoucherNo.Location = new System.Drawing.Point(338, 429);
            this.labelVoucherNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoucherNo.Name = "labelVoucherNo";
            this.labelVoucherNo.Size = new System.Drawing.Size(79, 16);
            this.labelVoucherNo.TabIndex = 211;
            this.labelVoucherNo.Text = "Voucher No";
            this.labelVoucherNo.Visible = false;
            // 
            // labelVoucherVisible
            // 
            this.labelVoucherVisible.AutoSize = true;
            this.labelVoucherVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoucherVisible.ForeColor = System.Drawing.Color.Blue;
            this.labelVoucherVisible.Location = new System.Drawing.Point(335, 278);
            this.labelVoucherVisible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoucherVisible.Name = "labelVoucherVisible";
            this.labelVoucherVisible.Size = new System.Drawing.Size(15, 16);
            this.labelVoucherVisible.TabIndex = 213;
            this.labelVoucherVisible.Text = "1";
            this.labelVoucherVisible.Visible = false;
            // 
            // buttonAddVoucher
            // 
            this.buttonAddVoucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVoucher.Location = new System.Drawing.Point(453, 452);
            this.buttonAddVoucher.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddVoucher.Name = "buttonAddVoucher";
            this.buttonAddVoucher.Size = new System.Drawing.Size(78, 24);
            this.buttonAddVoucher.TabIndex = 178;
            this.buttonAddVoucher.TabStop = false;
            this.buttonAddVoucher.Text = "Add";
            this.buttonAddVoucher.UseVisualStyleBackColor = false;
            this.buttonAddVoucher.Visible = false;
            this.buttonAddVoucher.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewVoucher
            // 
            this.dataGridViewVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnVoucherNo,
            this.ColumnAmount,
            this.ColumnCancel});
            this.dataGridViewVoucher.Location = new System.Drawing.Point(328, 489);
            this.dataGridViewVoucher.Name = "dataGridViewVoucher";
            this.dataGridViewVoucher.Size = new System.Drawing.Size(214, 94);
            this.dataGridViewVoucher.TabIndex = 214;
            this.dataGridViewVoucher.Visible = false;
            this.dataGridViewVoucher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVoucher_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // ColumnVoucherNo
            // 
            this.ColumnVoucherNo.HeaderText = "No";
            this.ColumnVoucherNo.Name = "ColumnVoucherNo";
            this.ColumnVoucherNo.Width = 50;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.Width = 80;
            // 
            // ColumnCancel
            // 
            this.ColumnCancel.HeaderText = "Cancel";
            this.ColumnCancel.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCancel.Image")));
            this.ColumnCancel.Name = "ColumnCancel";
            this.ColumnCancel.Width = 40;
            // 
            // labelVoucherID
            // 
            this.labelVoucherID.AutoSize = true;
            this.labelVoucherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoucherID.ForeColor = System.Drawing.Color.Blue;
            this.labelVoucherID.Location = new System.Drawing.Point(512, 278);
            this.labelVoucherID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoucherID.Name = "labelVoucherID";
            this.labelVoucherID.Size = new System.Drawing.Size(15, 16);
            this.labelVoucherID.TabIndex = 215;
            this.labelVoucherID.Text = "0";
            this.labelVoucherID.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 611);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 30);
            this.button2.TabIndex = 216;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Invoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1284, 663);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelVoucherID);
            this.Controls.Add(this.dataGridViewVoucher);
            this.Controls.Add(this.buttonAddVoucher);
            this.Controls.Add(this.labelVoucherVisible);
            this.Controls.Add(this.textBoxBarCode);
            this.Controls.Add(this.labelBarCodeVoucher);
            this.Controls.Add(this.textBoxVoucherNo);
            this.Controls.Add(this.labelVoucherNo);
            this.Controls.Add(this.textBoxVoucherAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxCardPayment);
            this.Controls.Add(this.textBoxBalanceAmount);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxPaidAmount);
            this.Controls.Add(this.labelPaidAmount);
            this.Controls.Add(this.textBoxNetDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hiddenlabel1);
            this.Controls.Add(this.Hiddenlabel);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChangeLogin);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.labelInGrid);
            this.Controls.Add(this.labelCurrenty);
            this.Controls.Add(this.buttonNP7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDueAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxtTlLineDiscountP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNetDiscountP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxtTlLineDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.buttonNPBack);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.buttonNP00);
            this.Controls.Add(this.buttonNPStar);
            this.Controls.Add(this.buttonNPMinus);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.buttonNPEnter);
            this.Controls.Add(this.buttonNPDot);
            this.Controls.Add(this.buttonNP0);
            this.Controls.Add(this.buttonNP3);
            this.Controls.Add(this.buttonNP2);
            this.Controls.Add(this.buttonNP1);
            this.Controls.Add(this.buttonNP6);
            this.Controls.Add(this.buttonNP5);
            this.Controls.Add(this.buttonNP4);
            this.Controls.Add(this.buttonNP9);
            this.Controls.Add(this.buttonNP8);
            this.Controls.Add(this.textBoxVendorName);
            this.Controls.Add(this.textBoxbuy);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.labelSellingCost);
            this.Controls.Add(this.textBoxSelling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemCatagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemCataagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCatID;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Label labelSellingCost;
        private System.Windows.Forms.TextBox textBoxSelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource venderDetailsBindingSource;
        private System.Windows.Forms.BindingSource pOSDataSetItemCataagoryBindingSource;
        private POSDataSetItemCataagory pOSDataSetItemCataagory;
        private System.Windows.Forms.BindingSource itemCatagoryBindingSource;
        private POSDataSetItemCataagoryTableAdapters.Item_CatagoryTableAdapter item_CatagoryTableAdapter;
        private System.Windows.Forms.TextBox textBoxbuy;
        private System.Windows.Forms.TextBox textBoxVendorName;
        private System.Windows.Forms.Button buttonNP8;
        private System.Windows.Forms.Button buttonNP9;
        private System.Windows.Forms.Button buttonNP6;
        private System.Windows.Forms.Button buttonNP5;
        private System.Windows.Forms.Button buttonNP4;
        private System.Windows.Forms.Button buttonNP3;
        private System.Windows.Forms.Button buttonNP2;
        private System.Windows.Forms.Button buttonNP1;
        private System.Windows.Forms.Button buttonNP0;
        private System.Windows.Forms.Button buttonNPDot;
        private System.Windows.Forms.Button buttonNPEnter;
        private System.Windows.Forms.Button buttonNP00;
        private System.Windows.Forms.Button buttonNPStar;
        private System.Windows.Forms.Button buttonNPMinus;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button buttonNPBack;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.TextBox textBoxtTlLineDiscountP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNetDiscountP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtTlLineDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDueAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNP7;
        private System.Windows.Forms.Label labelCurrenty;
        private System.Windows.Forms.Label labelInGrid;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button buttonChangeLogin;
        private System.Windows.Forms.Label label2;
        private System.Timers.Timer timer1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label Hiddenlabel;
        private System.Windows.Forms.Label Hiddenlabel1;
        private System.Windows.Forms.TextBox textBoxNetDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBalanceAmount;
        private System.Windows.Forms.Label labelBalance;
        public System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.CheckBox checkBoxCardPayment;
        public System.Windows.Forms.TextBox textBoxVoucherAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.Label labelBarCodeVoucher;
        private System.Windows.Forms.TextBox textBoxVoucherNo;
        private System.Windows.Forms.Label labelVoucherNo;
        private System.Windows.Forms.Label labelVoucherVisible;
        private System.Windows.Forms.DataGridView dataGridViewVoucher;
        private System.Windows.Forms.Button buttonAddVoucher;
        private System.Windows.Forms.Label labelVoucherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewImageColumn ColumnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount_Amout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoryID;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.Button button2;
    }
}