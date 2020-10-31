namespace POS
{
    partial class Discount_Type1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetItems = new POS.POSDataSetItems();
            this.itemsTableAdapter = new POS.POSDataSetItemsTableAdapters.ItemsTableAdapter();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.pOSDataSetBrand = new POS.POSDataSetBrand();
            this.pOSDataSetBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new POS.POSDataSetBrandTableAdapters.BrandTableAdapter();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDiscountType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.checkBoxPeriodically = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDiscountFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDiscountFrom = new System.Windows.Forms.Label();
            this.labelDiscountTo = new System.Windows.Forms.Label();
            this.dateTimePickerDiscountTo = new System.Windows.Forms.DateTimePicker();
            this.button_update = new System.Windows.Forms.Button();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(311, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Brand wise Discount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 80;
            this.label13.Text = "Brand";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.pOSDataSetItemsBindingSource;
            // 
            // pOSDataSetItemsBindingSource
            // 
            this.pOSDataSetItemsBindingSource.DataSource = this.pOSDataSetItems;
            this.pOSDataSetItemsBindingSource.Position = 0;
            // 
            // pOSDataSetItems
            // 
            this.pOSDataSetItems.DataSetName = "POSDataSetItems";
            this.pOSDataSetItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelect,
            this.CategoryID,
            this.ColumnItemName,
            this.ColumnCategoryName,
            this.ColumnUnit,
            this.ColumnDiscount,
            this.ColumnDiscountFrom,
            this.ColumnDiscountTo});
            this.dataGridViewAll.Location = new System.Drawing.Point(27, 198);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(751, 150);
            this.dataGridViewAll.TabIndex = 81;
            // 
            // pOSDataSetBrand
            // 
            this.pOSDataSetBrand.DataSetName = "POSDataSetBrand";
            this.pOSDataSetBrand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOSDataSetBrandBindingSource
            // 
            this.pOSDataSetBrandBindingSource.DataSource = this.pOSDataSetBrand;
            this.pOSDataSetBrandBindingSource.Position = 0;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.pOSDataSetBrandBindingSource;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DataSource = this.brandBindingSource;
            this.comboBoxBrand.DisplayMember = "BRAND_NAME";
            this.comboBoxBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(278, 74);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(108, 23);
            this.comboBoxBrand.TabIndex = 82;
            this.comboBoxBrand.ValueMember = "BRAND_ID";
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(172, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 86;
            this.label12.Text = "Discount Type";
            // 
            // comboBoxDiscountType
            // 
            this.comboBoxDiscountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDiscountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDiscountType.FormattingEnabled = true;
            this.comboBoxDiscountType.Items.AddRange(new object[] {
            "PR",
            "AMNT"});
            this.comboBoxDiscountType.Location = new System.Drawing.Point(278, 138);
            this.comboBoxDiscountType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscountType.Name = "comboBoxDiscountType";
            this.comboBoxDiscountType.Size = new System.Drawing.Size(108, 23);
            this.comboBoxDiscountType.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 85;
            this.label7.Text = "Discount";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(278, 107);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(108, 22);
            this.textBoxDiscount.TabIndex = 83;
            // 
            // checkBoxPeriodically
            // 
            this.checkBoxPeriodically.AutoSize = true;
            this.checkBoxPeriodically.Checked = true;
            this.checkBoxPeriodically.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPeriodically.Location = new System.Drawing.Point(572, 76);
            this.checkBoxPeriodically.Name = "checkBoxPeriodically";
            this.checkBoxPeriodically.Size = new System.Drawing.Size(79, 17);
            this.checkBoxPeriodically.TabIndex = 87;
            this.checkBoxPeriodically.Text = "Periodically";
            this.checkBoxPeriodically.UseVisualStyleBackColor = true;
            this.checkBoxPeriodically.CheckedChanged += new System.EventHandler(this.checkBoxPeriodically_CheckedChanged);
            // 
            // dateTimePickerDiscountFrom
            // 
            this.dateTimePickerDiscountFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiscountFrom.Location = new System.Drawing.Point(572, 106);
            this.dateTimePickerDiscountFrom.Name = "dateTimePickerDiscountFrom";
            this.dateTimePickerDiscountFrom.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDiscountFrom.TabIndex = 88;
            // 
            // labelDiscountFrom
            // 
            this.labelDiscountFrom.AutoSize = true;
            this.labelDiscountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountFrom.Location = new System.Drawing.Point(453, 110);
            this.labelDiscountFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountFrom.Name = "labelDiscountFrom";
            this.labelDiscountFrom.Size = new System.Drawing.Size(94, 16);
            this.labelDiscountFrom.TabIndex = 89;
            this.labelDiscountFrom.Text = "Discount From";
            // 
            // labelDiscountTo
            // 
            this.labelDiscountTo.AutoSize = true;
            this.labelDiscountTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountTo.Location = new System.Drawing.Point(453, 145);
            this.labelDiscountTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountTo.Name = "labelDiscountTo";
            this.labelDiscountTo.Size = new System.Drawing.Size(80, 16);
            this.labelDiscountTo.TabIndex = 91;
            this.labelDiscountTo.Text = "Discount To";
            // 
            // dateTimePickerDiscountTo
            // 
            this.dateTimePickerDiscountTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiscountTo.Location = new System.Drawing.Point(572, 141);
            this.dateTimePickerDiscountTo.Name = "dateTimePickerDiscountTo";
            this.dateTimePickerDiscountTo.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDiscountTo.TabIndex = 90;
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(678, 358);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 29);
            this.button_update.TabIndex = 92;
            this.button_update.Text = "Apply";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.HeaderText = "Select";
            this.ColumnSelect.Name = "ColumnSelect";
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Visible = false;
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.HeaderText = "ItemName";
            this.ColumnItemName.Name = "ColumnItemName";
            // 
            // ColumnCategoryName
            // 
            this.ColumnCategoryName.HeaderText = "CategoryName";
            this.ColumnCategoryName.Name = "ColumnCategoryName";
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.HeaderText = "Unit";
            this.ColumnUnit.Name = "ColumnUnit";
            // 
            // ColumnDiscount
            // 
            this.ColumnDiscount.HeaderText = "Discount";
            this.ColumnDiscount.Name = "ColumnDiscount";
            // 
            // ColumnDiscountFrom
            // 
            this.ColumnDiscountFrom.HeaderText = "Discount From";
            this.ColumnDiscountFrom.Name = "ColumnDiscountFrom";
            // 
            // ColumnDiscountTo
            // 
            this.ColumnDiscountTo.HeaderText = "Discount To";
            this.ColumnDiscountTo.Name = "ColumnDiscountTo";
            // 
            // Discount_Type1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.labelDiscountTo);
            this.Controls.Add(this.dateTimePickerDiscountTo);
            this.Controls.Add(this.labelDiscountFrom);
            this.Controls.Add(this.dateTimePickerDiscountFrom);
            this.Controls.Add(this.checkBoxPeriodically);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxDiscountType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Name = "Discount_Type1";
            this.Text = "Discount_Type1";
            this.Load += new System.EventHandler(this.Discount_Type1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private POSDataSetItems pOSDataSetItems;
        private System.Windows.Forms.BindingSource pOSDataSetItemsBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private POSDataSetItemsTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.BindingSource pOSDataSetBrandBindingSource;
        private POSDataSetBrand pOSDataSetBrand;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private POSDataSetBrandTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDiscountType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.CheckBox checkBoxPeriodically;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscountFrom;
        private System.Windows.Forms.Label labelDiscountFrom;
        private System.Windows.Forms.Label labelDiscountTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscountTo;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountTo;
    }
}