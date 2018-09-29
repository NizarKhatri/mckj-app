namespace MCKJ
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MCKJ.ComDataSet();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.tblHeaderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset2 = new MCKJ.dataset2();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbAccountStatus = new System.Windows.Forms.ComboBox();
            this.cmbAccHeader = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbIndexBook = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSTN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNTN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone3 = new System.Windows.Forms.TextBox();
            this.lblPhone3 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblAccountsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tblHeaderTypeTableAdapter = new MCKJ.dataset2TableAdapters.tblHeaderTypeTableAdapter();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAccountsBindingSource
            // 
            this.tblAccountsBindingSource.DataMember = "tblAccounts";
            this.tblAccountsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Location = new System.Drawing.Point(558, 498);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 22);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(477, 498);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 22);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(641, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 22);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(641, 498);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 22);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Email", true));
            this.txtEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(141, 189);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 14);
            this.label16.TabIndex = 68;
            this.label16.Text = "Email:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Email", true));
            this.txtWebsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(360, 190);
            this.txtWebsite.MaxLength = 255;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(179, 20);
            this.txtWebsite.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(304, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 14);
            this.label17.TabIndex = 66;
            this.label17.Text = "Website:";
            // 
            // txtMobile
            // 
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Mobile", true));
            this.txtMobile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(360, 164);
            this.txtMobile.MaxLength = 12;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(83, 20);
            this.txtMobile.TabIndex = 8;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(304, 167);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(40, 14);
            this.lblMobile.TabIndex = 64;
            this.lblMobile.Text = "Mobile:";
            // 
            // cmbAccType
            // 
            this.cmbAccType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "HeaderType", true));
            this.cmbAccType.DataSource = this.tblHeaderTypeBindingSource;
            this.cmbAccType.DisplayMember = "HeaderType";
            this.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Location = new System.Drawing.Point(141, 355);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(137, 22);
            this.cmbAccType.TabIndex = 16;
            this.cmbAccType.ValueMember = "ID";
            // 
            // tblHeaderTypeBindingSource
            // 
            this.tblHeaderTypeBindingSource.DataMember = "tblHeaderType";
            this.tblHeaderTypeBindingSource.DataSource = this.dataset2;
            // 
            // dataset2
            // 
            this.dataset2.DataSetName = "dataset2";
            this.dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 14);
            this.label14.TabIndex = 62;
            this.label14.Text = "Account Type:";
            // 
            // cmbAccountStatus
            // 
            this.cmbAccountStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "AccStatus", true));
            this.cmbAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountStatus.FormattingEnabled = true;
            this.cmbAccountStatus.Items.AddRange(new object[] {
            "Inactive",
            "Active"});
            this.cmbAccountStatus.Location = new System.Drawing.Point(141, 386);
            this.cmbAccountStatus.Name = "cmbAccountStatus";
            this.cmbAccountStatus.Size = new System.Drawing.Size(114, 22);
            this.cmbAccountStatus.TabIndex = 17;
            // 
            // cmbAccHeader
            // 
            this.cmbAccHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Header", true));
            this.cmbAccHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccHeader.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccHeader.FormattingEnabled = true;
            this.cmbAccHeader.Items.AddRange(new object[] {
            "Assets",
            "Liabilities",
            "Capital",
            "Expense",
            "Income"});
            this.cmbAccHeader.Location = new System.Drawing.Point(155, 530);
            this.cmbAccHeader.Name = "cmbAccHeader";
            this.cmbAccHeader.Size = new System.Drawing.Size(100, 22);
            this.cmbAccHeader.TabIndex = 15;
            this.cmbAccHeader.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(141, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 22);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbIndexBook
            // 
            this.cmbIndexBook.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "IndexBook", true));
            this.cmbIndexBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIndexBook.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIndexBook.FormattingEnabled = true;
            this.cmbIndexBook.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbIndexBook.Location = new System.Drawing.Point(141, 415);
            this.cmbIndexBook.Name = "cmbIndexBook";
            this.cmbIndexBook.Size = new System.Drawing.Size(59, 22);
            this.cmbIndexBook.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 14);
            this.label13.TabIndex = 52;
            this.label13.Text = "Define In Index Book:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 14);
            this.label12.TabIndex = 60;
            this.label12.Text = "Account Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 14);
            this.label11.TabIndex = 59;
            this.label11.Text = "Account Header:";
            this.label11.Visible = false;
            // 
            // txtSTN
            // 
            this.txtSTN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "STN", true));
            this.txtSTN.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTN.Location = new System.Drawing.Point(360, 329);
            this.txtSTN.MaxLength = 17;
            this.txtSTN.Name = "txtSTN";
            this.txtSTN.Size = new System.Drawing.Size(137, 20);
            this.txtSTN.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 14);
            this.label9.TabIndex = 58;
            this.label9.Text = "STN:";
            // 
            // txtNTN
            // 
            this.txtNTN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "NTN", true));
            this.txtNTN.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTN.Location = new System.Drawing.Point(141, 329);
            this.txtNTN.MaxLength = 14;
            this.txtNTN.Name = "txtNTN";
            this.txtNTN.Size = new System.Drawing.Size(133, 20);
            this.txtNTN.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 14);
            this.label10.TabIndex = 57;
            this.label10.Text = "NTN:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Address", true));
            this.txtAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(141, 243);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(356, 66);
            this.txtAddress.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 14);
            this.label8.TabIndex = 56;
            this.label8.Text = "Address:";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Fax", true));
            this.txtFax.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(141, 137);
            this.txtFax.MaxLength = 12;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(83, 20);
            this.txtFax.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 55;
            this.label7.Text = "Fax:";
            // 
            // txtPhone3
            // 
            this.txtPhone3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Phone3", true));
            this.txtPhone3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone3.Location = new System.Drawing.Point(545, 111);
            this.txtPhone3.MaxLength = 12;
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(83, 20);
            this.txtPhone3.TabIndex = 5;
            // 
            // lblPhone3
            // 
            this.lblPhone3.AutoSize = true;
            this.lblPhone3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone3.Location = new System.Drawing.Point(489, 114);
            this.lblPhone3.Name = "lblPhone3";
            this.lblPhone3.Size = new System.Drawing.Size(49, 14);
            this.lblPhone3.TabIndex = 53;
            this.lblPhone3.Text = "Phone 3:";
            // 
            // txtPhone2
            // 
            this.txtPhone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Phone2", true));
            this.txtPhone2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(360, 111);
            this.txtPhone2.MaxLength = 12;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(83, 20);
            this.txtPhone2.TabIndex = 4;
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone2.Location = new System.Drawing.Point(304, 114);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(49, 14);
            this.lblPhone2.TabIndex = 49;
            this.lblPhone2.Text = "Phone 2:";
            // 
            // txtPhone1
            // 
            this.txtPhone1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "Phone1", true));
            this.txtPhone1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone1.Location = new System.Drawing.Point(141, 111);
            this.txtPhone1.MaxLength = 12;
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(83, 20);
            this.txtPhone1.TabIndex = 3;
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone1.Location = new System.Drawing.Point(17, 114);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(49, 14);
            this.lblPhone1.TabIndex = 47;
            this.lblPhone1.Text = "Phone 1:";
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "City", true));
            this.txtCity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(141, 215);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 44;
            this.label3.Text = "City:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "AccountName", true));
            this.txtAccountName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(141, 73);
            this.txtAccountName.MaxLength = 35;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(193, 20);
            this.txtAccountName.TabIndex = 2;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(17, 76);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(81, 14);
            this.lblAccountName.TabIndex = 37;
            this.lblAccountName.Text = "Account Name:";
            // 
            // lblAccountCode
            // 
            this.lblAccountCode.AutoSize = true;
            this.lblAccountCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountCode.Location = new System.Drawing.Point(17, 49);
            this.lblAccountCode.Name = "lblAccountCode";
            this.lblAccountCode.Size = new System.Drawing.Size(79, 14);
            this.lblAccountCode.TabIndex = 35;
            this.lblAccountCode.Text = "Account Code:";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "ContactPerson", true));
            this.txtContactPerson.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(141, 163);
            this.txtContactPerson.MaxLength = 50;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(133, 20);
            this.txtContactPerson.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 70;
            this.label1.Text = "Contact Person:";
            // 
            // tblAccountsTableAdapter
            // 
            this.tblAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(224, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 22);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl
            // 
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(734, 21);
            this.lbl.TabIndex = 72;
            this.lbl.Text = "Account Profile";
            // 
            // tblHeaderTypeTableAdapter
            // 
            this.tblHeaderTypeTableAdapter.ClearBeforeFill = true;
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAccountsBindingSource, "AccountCode", true));
            this.txtAccountCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountCode.Location = new System.Drawing.Point(141, 46);
            this.txtAccountCode.MaxLength = 35;
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(83, 20);
            this.txtAccountCode.TabIndex = 73;
            this.txtAccountCode.Leave += new System.EventHandler(this.txtAccountCode_Leave);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AutoGenerateColumns = false;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.accountCodeDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.mobileDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.emailDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.headerDataGridViewTextBoxColumn,
            this.headerTypeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvAccounts.DataSource = this.tblAccountsBindingSource;
            this.dgvAccounts.Location = new System.Drawing.Point(12, 35);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(706, 457);
            this.dgvAccounts.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            this.accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            this.accountCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Phone1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Phone1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone3";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fax";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            this.websiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NTN";
            this.dataGridViewTextBoxColumn7.HeaderText = "NTN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "STN";
            this.dataGridViewTextBoxColumn8.HeaderText = "STN";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // headerDataGridViewTextBoxColumn
            // 
            this.headerDataGridViewTextBoxColumn.DataPropertyName = "Header";
            this.headerDataGridViewTextBoxColumn.HeaderText = "Header";
            this.headerDataGridViewTextBoxColumn.Name = "headerDataGridViewTextBoxColumn";
            this.headerDataGridViewTextBoxColumn.ReadOnly = true;
            this.headerDataGridViewTextBoxColumn.Visible = false;
            // 
            // headerTypeDataGridViewTextBoxColumn
            // 
            this.headerTypeDataGridViewTextBoxColumn.DataPropertyName = "HeaderType";
            this.headerTypeDataGridViewTextBoxColumn.HeaderText = "HeaderType";
            this.headerTypeDataGridViewTextBoxColumn.Name = "headerTypeDataGridViewTextBoxColumn";
            this.headerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AccStatus";
            this.dataGridViewTextBoxColumn10.HeaderText = "AccStatus";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IndexBook";
            this.dataGridViewTextBoxColumn11.HeaderText = "IndexBook";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 556);
            this.Controls.Add(this.txtAccountCode);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.cmbAccType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbAccountStatus);
            this.Controls.Add(this.cmbAccHeader);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbIndexBook);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNTN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone3);
            this.Controls.Add(this.lblPhone3);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.lblPhone2);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.lblAccountCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAccounts);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmParty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accHeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbAccountStatus;
        private System.Windows.Forms.ComboBox cmbAccHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbIndexBook;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone3;
        private System.Windows.Forms.Label lblPhone3;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAccountCode;
        private MCKJ.ComDataSet dataSet;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter tblAccountsTableAdapter;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label lbl;
        private dataset2 dataset2;
        private System.Windows.Forms.BindingSource tblHeaderTypeBindingSource;
        private MCKJ.dataset2TableAdapters.tblHeaderTypeTableAdapter tblHeaderTypeTableAdapter;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}

