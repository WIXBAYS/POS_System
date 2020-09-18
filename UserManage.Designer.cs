namespace POS
{
    partial class UserManage
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
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNICTxt = new System.Windows.Forms.Label();
            this.comboBoxNIC = new System.Windows.Forms.ComboBox();
            this.userDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new POS.POSDataSet();
            this.user_DetailsTableAdapter = new POS.POSDataSetTableAdapters.User_DetailsTableAdapter();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFristName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.textBoxContactNo = new System.Windows.Forms.TextBox();
            this.labelAddressNo = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.textBoxaddressNo = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.label1Store = new System.Windows.Forms.Label();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.storeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSetSTORE = new POS.POSDataSetSTORE();
            this.store_DataTableAdapter = new POS.POSDataSetSTORETableAdapters.Store_DataTableAdapter();
            this.labelActive = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxReNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelReNewPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetSTORE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.AutoSize = true;
            this.checkBoxNew.Location = new System.Drawing.Point(54, 19);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(54, 21);
            this.checkBoxNew.TabIndex = 0;
            this.checkBoxNew.Text = "New";
            this.checkBoxNew.UseVisualStyleBackColor = true;
            this.checkBoxNew.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIC.Location = new System.Drawing.Point(190, 35);
            this.textBoxNIC.MaxLength = 12;
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(121, 22);
            this.textBoxNIC.TabIndex = 1;
            this.textBoxNIC.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage User Details";
            // 
            // labelNICTxt
            // 
            this.labelNICTxt.AutoSize = true;
            this.labelNICTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNICTxt.Location = new System.Drawing.Point(51, 45);
            this.labelNICTxt.Name = "labelNICTxt";
            this.labelNICTxt.Size = new System.Drawing.Size(30, 16);
            this.labelNICTxt.TabIndex = 3;
            this.labelNICTxt.Text = "NIC";
            // 
            // comboBoxNIC
            // 
            this.comboBoxNIC.DataSource = this.userDetailsBindingSource;
            this.comboBoxNIC.DisplayMember = "NIC";
            this.comboBoxNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNIC.FormattingEnabled = true;
            this.comboBoxNIC.Location = new System.Drawing.Point(190, 34);
            this.comboBoxNIC.MaxLength = 12;
            this.comboBoxNIC.Name = "comboBoxNIC";
            this.comboBoxNIC.Size = new System.Drawing.Size(121, 23);
            this.comboBoxNIC.TabIndex = 5;
            this.comboBoxNIC.ValueMember = "NIC";
            this.comboBoxNIC.SelectedIndexChanged += new System.EventHandler(this.comboBoxNIC_SelectedIndexChanged);
            // 
            // userDetailsBindingSource
            // 
            this.userDetailsBindingSource.DataMember = "User_Details";
            this.userDetailsBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_DetailsTableAdapter
            // 
            this.user_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(51, 78);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(73, 16);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFristName
            // 
            this.textBoxFristName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFristName.Location = new System.Drawing.Point(190, 71);
            this.textBoxFristName.MaxLength = 100;
            this.textBoxFristName.Name = "textBoxFristName";
            this.textBoxFristName.Size = new System.Drawing.Size(121, 22);
            this.textBoxFristName.TabIndex = 7;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(51, 110);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 16);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(190, 107);
            this.textBoxLastName.MaxLength = 100;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(121, 22);
            this.textBoxLastName.TabIndex = 9;
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactNo.Location = new System.Drawing.Point(51, 148);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(74, 16);
            this.labelContactNo.TabIndex = 10;
            this.labelContactNo.Text = "Contact No";
            // 
            // textBoxContactNo
            // 
            this.textBoxContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactNo.Location = new System.Drawing.Point(190, 141);
            this.textBoxContactNo.MaxLength = 10;
            this.textBoxContactNo.Name = "textBoxContactNo";
            this.textBoxContactNo.Size = new System.Drawing.Size(121, 22);
            this.textBoxContactNo.TabIndex = 11;
            // 
            // labelAddressNo
            // 
            this.labelAddressNo.AutoSize = true;
            this.labelAddressNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddressNo.Location = new System.Drawing.Point(51, 181);
            this.labelAddressNo.Name = "labelAddressNo";
            this.labelAddressNo.Size = new System.Drawing.Size(80, 16);
            this.labelAddressNo.TabIndex = 12;
            this.labelAddressNo.Text = "Address No";
            this.labelAddressNo.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(51, 213);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(43, 16);
            this.labelStreet.TabIndex = 13;
            this.labelStreet.Text = "Street";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(51, 249);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(30, 16);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City";
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistrict.Location = new System.Drawing.Point(51, 286);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(48, 16);
            this.labelDistrict.TabIndex = 15;
            this.labelDistrict.Text = "District";
            // 
            // textBoxaddressNo
            // 
            this.textBoxaddressNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxaddressNo.Location = new System.Drawing.Point(190, 174);
            this.textBoxaddressNo.MaxLength = 50;
            this.textBoxaddressNo.Name = "textBoxaddressNo";
            this.textBoxaddressNo.Size = new System.Drawing.Size(121, 22);
            this.textBoxaddressNo.TabIndex = 16;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreet.Location = new System.Drawing.Point(190, 206);
            this.textBoxStreet.MaxLength = 100;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(121, 22);
            this.textBoxStreet.TabIndex = 17;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(190, 242);
            this.textBoxCity.MaxLength = 100;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(121, 22);
            this.textBoxCity.TabIndex = 18;
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistrict.Location = new System.Drawing.Point(190, 279);
            this.textBoxDistrict.MaxLength = 100;
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(121, 22);
            this.textBoxDistrict.TabIndex = 19;
            // 
            // label1Store
            // 
            this.label1Store.AutoSize = true;
            this.label1Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Store.Location = new System.Drawing.Point(51, 322);
            this.label1Store.Name = "label1Store";
            this.label1Store.Size = new System.Drawing.Size(40, 16);
            this.label1Store.TabIndex = 20;
            this.label1Store.Text = "Store";
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DataSource = this.storeDataBindingSource;
            this.comboBoxStore.DisplayMember = "STORE_NAME";
            this.comboBoxStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(190, 313);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStore.TabIndex = 21;
            this.comboBoxStore.ValueMember = "STORE_ID";
            // 
            // storeDataBindingSource
            // 
            this.storeDataBindingSource.DataMember = "Store_Data";
            this.storeDataBindingSource.DataSource = this.pOSDataSetSTORE;
            // 
            // pOSDataSetSTORE
            // 
            this.pOSDataSetSTORE.DataSetName = "POSDataSetSTORE";
            this.pOSDataSetSTORE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // store_DataTableAdapter
            // 
            this.store_DataTableAdapter.ClearBeforeFill = true;
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActive.Location = new System.Drawing.Point(55, 359);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(45, 16);
            this.labelActive.TabIndex = 22;
            this.labelActive.Text = "Active";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(194, 355);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActive.TabIndex = 23;
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkBoxNew);
            this.groupBox1.Controls.Add(this.checkBoxActive);
            this.groupBox1.Controls.Add(this.textBoxNIC);
            this.groupBox1.Controls.Add(this.labelActive);
            this.groupBox1.Controls.Add(this.labelNICTxt);
            this.groupBox1.Controls.Add(this.comboBoxStore);
            this.groupBox1.Controls.Add(this.label1Store);
            this.groupBox1.Controls.Add(this.comboBoxNIC);
            this.groupBox1.Controls.Add(this.textBoxDistrict);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.textBoxFristName);
            this.groupBox1.Controls.Add(this.textBoxStreet);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxaddressNo);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.labelDistrict);
            this.groupBox1.Controls.Add(this.labelContactNo);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Controls.Add(this.textBoxContactNo);
            this.groupBox1.Controls.Add(this.labelStreet);
            this.groupBox1.Controls.Add(this.labelAddressNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 448);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Details";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(194, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 54);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxUserType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxUserName);
            this.groupBox2.Controls.Add(this.labelUserName);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxReNewPassword);
            this.groupBox2.Controls.Add(this.textBoxNewPassword);
            this.groupBox2.Controls.Add(this.labelReNewPassword);
            this.groupBox2.Controls.Add(this.labelNewPassword);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(468, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 228);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Cashier"});
            this.comboBoxUserType.Location = new System.Drawing.Point(140, 74);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUserType.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "UserType";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(140, 38);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(121, 22);
            this.textBoxUserName.TabIndex = 28;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(6, 45);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(74, 16);
            this.labelUserName.TabIndex = 27;
            this.labelUserName.Text = "UserName";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxReNewPassword
            // 
            this.textBoxReNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReNewPassword.Location = new System.Drawing.Point(142, 150);
            this.textBoxReNewPassword.MaxLength = 20;
            this.textBoxReNewPassword.Name = "textBoxReNewPassword";
            this.textBoxReNewPassword.Size = new System.Drawing.Size(121, 22);
            this.textBoxReNewPassword.TabIndex = 25;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(140, 112);
            this.textBoxNewPassword.MaxLength = 20;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(121, 22);
            this.textBoxNewPassword.TabIndex = 24;
            // 
            // labelReNewPassword
            // 
            this.labelReNewPassword.AutoSize = true;
            this.labelReNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReNewPassword.Location = new System.Drawing.Point(6, 150);
            this.labelReNewPassword.Name = "labelReNewPassword";
            this.labelReNewPassword.Size = new System.Drawing.Size(120, 16);
            this.labelReNewPassword.TabIndex = 5;
            this.labelReNewPassword.Text = "Re-New Password";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(6, 119);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(98, 16);
            this.labelNewPassword.TabIndex = 4;
            this.labelNewPassword.Text = "New Password";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(728, 454);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 52);
            this.button3.TabIndex = 26;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 520);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSetSTORE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxNew;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNICTxt;
        private System.Windows.Forms.ComboBox comboBoxNIC;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource userDetailsBindingSource;
        private POSDataSetTableAdapters.User_DetailsTableAdapter user_DetailsTableAdapter;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFristName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.TextBox textBoxContactNo;
        private System.Windows.Forms.Label labelAddressNo;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TextBox textBoxaddressNo;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.Label label1Store;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private POSDataSetSTORE pOSDataSetSTORE;
        private System.Windows.Forms.BindingSource storeDataBindingSource;
        private POSDataSetSTORETableAdapters.Store_DataTableAdapter store_DataTableAdapter;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxReNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelReNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button button3;
    }
}