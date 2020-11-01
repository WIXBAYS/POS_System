namespace POS
{
    partial class Discount_Type2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount_Type2));
            this.label6 = new System.Windows.Forms.Label();
            this.labelDiscountTo = new System.Windows.Forms.Label();
            this.dateTimePickerDiscountTo = new System.Windows.Forms.DateTimePicker();
            this.labelDiscountFrom = new System.Windows.Forms.Label();
            this.dateTimePickerDiscountFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPeriodically = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDiscountType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmntFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmntTo = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmountFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmountTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeriodically = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscountTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCancel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(245, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Discount For the Total Invoice Amount";
            // 
            // labelDiscountTo
            // 
            this.labelDiscountTo.AutoSize = true;
            this.labelDiscountTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountTo.Location = new System.Drawing.Point(424, 137);
            this.labelDiscountTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountTo.Name = "labelDiscountTo";
            this.labelDiscountTo.Size = new System.Drawing.Size(80, 16);
            this.labelDiscountTo.TabIndex = 102;
            this.labelDiscountTo.Text = "Discount To";
            // 
            // dateTimePickerDiscountTo
            // 
            this.dateTimePickerDiscountTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiscountTo.Location = new System.Drawing.Point(543, 133);
            this.dateTimePickerDiscountTo.Name = "dateTimePickerDiscountTo";
            this.dateTimePickerDiscountTo.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDiscountTo.TabIndex = 101;
            // 
            // labelDiscountFrom
            // 
            this.labelDiscountFrom.AutoSize = true;
            this.labelDiscountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountFrom.Location = new System.Drawing.Point(424, 102);
            this.labelDiscountFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountFrom.Name = "labelDiscountFrom";
            this.labelDiscountFrom.Size = new System.Drawing.Size(94, 16);
            this.labelDiscountFrom.TabIndex = 100;
            this.labelDiscountFrom.Text = "Discount From";
            // 
            // dateTimePickerDiscountFrom
            // 
            this.dateTimePickerDiscountFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiscountFrom.Location = new System.Drawing.Point(543, 98);
            this.dateTimePickerDiscountFrom.Name = "dateTimePickerDiscountFrom";
            this.dateTimePickerDiscountFrom.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDiscountFrom.TabIndex = 99;
            // 
            // checkBoxPeriodically
            // 
            this.checkBoxPeriodically.AutoSize = true;
            this.checkBoxPeriodically.Checked = true;
            this.checkBoxPeriodically.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPeriodically.Location = new System.Drawing.Point(543, 68);
            this.checkBoxPeriodically.Name = "checkBoxPeriodically";
            this.checkBoxPeriodically.Size = new System.Drawing.Size(79, 17);
            this.checkBoxPeriodically.TabIndex = 98;
            this.checkBoxPeriodically.Text = "Periodically";
            this.checkBoxPeriodically.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(154, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 97;
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
            this.comboBoxDiscountType.Location = new System.Drawing.Point(260, 99);
            this.comboBoxDiscountType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscountType.Name = "comboBoxDiscountType";
            this.comboBoxDiscountType.Size = new System.Drawing.Size(108, 23);
            this.comboBoxDiscountType.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "Discount";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(260, 68);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(108, 22);
            this.textBoxDiscount.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Amount From";
            // 
            // textBoxAmntFrom
            // 
            this.textBoxAmntFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmntFrom.Location = new System.Drawing.Point(260, 134);
            this.textBoxAmntFrom.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmntFrom.Name = "textBoxAmntFrom";
            this.textBoxAmntFrom.Size = new System.Drawing.Size(108, 22);
            this.textBoxAmntFrom.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "Amount To";
            // 
            // textBoxAmntTo
            // 
            this.textBoxAmntTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmntTo.Location = new System.Drawing.Point(260, 167);
            this.textBoxAmntTo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmntTo.Name = "textBoxAmntTo";
            this.textBoxAmntTo.Size = new System.Drawing.Size(108, 22);
            this.textBoxAmntTo.TabIndex = 105;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(543, 160);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 29);
            this.button_add.TabIndex = 107;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnAmountFrom,
            this.ColumnAmountTo,
            this.ColumnPeriodically,
            this.ColumnDiscount,
            this.ColumnDiscountType,
            this.ColumnDiscountFrom,
            this.ColumnDiscountTo,
            this.ColumnCancel});
            this.dataGridViewAll.Location = new System.Drawing.Point(66, 212);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(666, 150);
            this.dataGridViewAll.TabIndex = 108;
            this.dataGridViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAll_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(544, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 109;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // ColumnAmountFrom
            // 
            this.ColumnAmountFrom.HeaderText = "Amount From";
            this.ColumnAmountFrom.Name = "ColumnAmountFrom";
            this.ColumnAmountFrom.ReadOnly = true;
            // 
            // ColumnAmountTo
            // 
            this.ColumnAmountTo.HeaderText = "Amount To";
            this.ColumnAmountTo.Name = "ColumnAmountTo";
            this.ColumnAmountTo.ReadOnly = true;
            // 
            // ColumnPeriodically
            // 
            this.ColumnPeriodically.HeaderText = "Periodically";
            this.ColumnPeriodically.Name = "ColumnPeriodically";
            this.ColumnPeriodically.Visible = false;
            // 
            // ColumnDiscount
            // 
            this.ColumnDiscount.HeaderText = "Discount";
            this.ColumnDiscount.Name = "ColumnDiscount";
            this.ColumnDiscount.ReadOnly = true;
            this.ColumnDiscount.Width = 70;
            // 
            // ColumnDiscountType
            // 
            this.ColumnDiscountType.HeaderText = "Discount Type";
            this.ColumnDiscountType.Name = "ColumnDiscountType";
            // 
            // ColumnDiscountFrom
            // 
            this.ColumnDiscountFrom.HeaderText = "Discount From";
            this.ColumnDiscountFrom.Name = "ColumnDiscountFrom";
            this.ColumnDiscountFrom.ReadOnly = true;
            // 
            // ColumnDiscountTo
            // 
            this.ColumnDiscountTo.HeaderText = "Discount To";
            this.ColumnDiscountTo.Name = "ColumnDiscountTo";
            this.ColumnDiscountTo.ReadOnly = true;
            // 
            // ColumnCancel
            // 
            this.ColumnCancel.HeaderText = "Cancel";
            this.ColumnCancel.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCancel.Image")));
            this.ColumnCancel.Name = "ColumnCancel";
            this.ColumnCancel.Width = 50;
            // 
            // Discount_Type2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmntTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmntFrom);
            this.Controls.Add(this.labelDiscountTo);
            this.Controls.Add(this.dateTimePickerDiscountTo);
            this.Controls.Add(this.labelDiscountFrom);
            this.Controls.Add(this.dateTimePickerDiscountFrom);
            this.Controls.Add(this.checkBoxPeriodically);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxDiscountType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.label6);
            this.Name = "Discount_Type2";
            this.Text = "Discount_Type2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDiscountTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscountTo;
        private System.Windows.Forms.Label labelDiscountFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscountFrom;
        private System.Windows.Forms.CheckBox checkBoxPeriodically;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDiscountType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmntFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmntTo;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmountFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmountTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPeriodically;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscountTo;
        private System.Windows.Forms.DataGridViewImageColumn ColumnCancel;
    }
}