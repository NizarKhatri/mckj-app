namespace MCKJ
{
    partial class frmDeathRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeathRegistration));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.uspSELDeathBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataset3 = new MCKJ.dataset3();
            this.txtReasonOfDeath = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.cmbRelation = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrakh = new System.Windows.Forms.TextBox();
            this.txtNukh = new System.Windows.Forms.TextBox();
            this.txtGFName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtFCardNo = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbAgeGroup = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeath = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nukhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orakhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPrinted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRCNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspSELDeathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.dtpDOD = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.ComboBox();
            this.uspSELtblFamilyMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpDtime = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.usp_SEL_DeathTableAdapter1 = new MCKJ.dataset3TableAdapters.usp_SEL_DeathTableAdapter();
            this.txtNameEdit = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsPrinted = new System.Windows.Forms.CheckBox();
            this.cmbApplicantRelation = new System.Windows.Forms.ComboBox();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.txtApplicantCNIC = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDRCN = new System.Windows.Forms.TextBox();
            this.lblDRCN = new System.Windows.Forms.Label();
            this.usp_SEL_DeathTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_DeathTableAdapter();
            this.usp_SEL_FAMILYTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_FAMILYTableAdapter();
            this.uspSELFAMILYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_tblFamilyMemberTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblFamilyMemberTableAdapter();
            this.uspSELTSFtblFamilyMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_TSF_tblFamilyMemberTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_TSF_tblFamilyMemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELDeathBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELDeathBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblFamilyMemberBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELFAMILYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELTSFtblFamilyMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Res. Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Reason";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Date Of Death";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "RAddress", true));
            this.txtAddress.Location = new System.Drawing.Point(112, 364);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 57);
            this.txtAddress.TabIndex = 75;
            this.txtAddress.TabStop = false;
            // 
            // uspSELDeathBindingSource1
            // 
            this.uspSELDeathBindingSource1.DataMember = "usp_SEL_Death";
            this.uspSELDeathBindingSource1.DataSource = this.dataset3;
            // 
            // dataset3
            // 
            this.dataset3.DataSetName = "dataset3";
            this.dataset3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtReasonOfDeath
            // 
            this.txtReasonOfDeath.BackColor = System.Drawing.SystemColors.Info;
            this.txtReasonOfDeath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Reason", true));
            this.txtReasonOfDeath.Location = new System.Drawing.Point(112, 322);
            this.txtReasonOfDeath.Name = "txtReasonOfDeath";
            this.txtReasonOfDeath.Size = new System.Drawing.Size(142, 20);
            this.txtReasonOfDeath.TabIndex = 11;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(247, 498);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(328, 498);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(409, 497);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(400, 435);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(409, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(14, 497);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 23);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnview_Click);
            // 
            // cmbRelation
            // 
            this.cmbRelation.BackColor = System.Drawing.Color.White;
            this.cmbRelation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Relation", true));
            this.cmbRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelation.ForeColor = System.Drawing.Color.Black;
            this.cmbRelation.FormattingEnabled = true;
            this.cmbRelation.Items.AddRange(new object[] {
            "",
            "Aunty",
            "Brother",
            "Brother_in_Law",
            "Cousin",
            "Daughter",
            "Daughter_in_Law",
            "Father",
            "Father_in_Law",
            "Grand_Daughter",
            "Grand_Father",
            "Grand_Mother",
            "Grand_Son",
            "Head of Family",
            "Husband",
            "Mother",
            "Mother_in_Law",
            "Nephew",
            "Niece",
            "Sister",
            "Sister_in_Law",
            "Son",
            "Son_in_Law",
            "Uncle",
            "Wife"});
            this.cmbRelation.Location = new System.Drawing.Point(334, 226);
            this.cmbRelation.Name = "cmbRelation";
            this.cmbRelation.Size = new System.Drawing.Size(142, 21);
            this.cmbRelation.Sorted = true;
            this.cmbRelation.TabIndex = 68;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "EntryDate", true));
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntryDate.Location = new System.Drawing.Point(334, 63);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(81, 20);
            this.dtpEntryDate.TabIndex = 6;
            // 
            // txtOrakh
            // 
            this.txtOrakh.BackColor = System.Drawing.Color.White;
            this.txtOrakh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Orakh", true));
            this.txtOrakh.Location = new System.Drawing.Point(334, 390);
            this.txtOrakh.Name = "txtOrakh";
            this.txtOrakh.ReadOnly = true;
            this.txtOrakh.Size = new System.Drawing.Size(142, 20);
            this.txtOrakh.TabIndex = 70;
            this.txtOrakh.TabStop = false;
            // 
            // txtNukh
            // 
            this.txtNukh.BackColor = System.Drawing.Color.White;
            this.txtNukh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Nukh", true));
            this.txtNukh.Location = new System.Drawing.Point(334, 364);
            this.txtNukh.Name = "txtNukh";
            this.txtNukh.ReadOnly = true;
            this.txtNukh.Size = new System.Drawing.Size(142, 20);
            this.txtNukh.TabIndex = 71;
            this.txtNukh.TabStop = false;
            // 
            // txtGFName
            // 
            this.txtGFName.BackColor = System.Drawing.Color.White;
            this.txtGFName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "GFName", true));
            this.txtGFName.Location = new System.Drawing.Point(112, 226);
            this.txtGFName.Name = "txtGFName";
            this.txtGFName.Size = new System.Drawing.Size(142, 20);
            this.txtGFName.TabIndex = 10;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.White;
            this.txtFName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "FName", true));
            this.txtFName.Location = new System.Drawing.Point(334, 200);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(142, 20);
            this.txtFName.TabIndex = 66;
            // 
            // txtFCardNo
            // 
            this.txtFCardNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtFCardNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "FCardNo", true));
            this.txtFCardNo.Location = new System.Drawing.Point(112, 90);
            this.txtFCardNo.Name = "txtFCardNo";
            this.txtFCardNo.Size = new System.Drawing.Size(100, 20);
            this.txtFCardNo.TabIndex = 7;
            this.txtFCardNo.Leave += new System.EventHandler(this.txtFCardNo_Leave);
            // 
            // txtRegNo
            // 
            this.txtRegNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtRegNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "RegNo", true));
            this.txtRegNo.Location = new System.Drawing.Point(112, 64);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegNo.TabIndex = 5;
            this.txtRegNo.Leave += new System.EventHandler(this.txtRegNo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Entry Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Relation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Orakh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Nukh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Husband Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(260, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Father Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Family Card No.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Registrarion No.";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Gender", true));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(112, 253);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(142, 21);
            this.cmbGender.TabIndex = 73;
            // 
            // cmbAgeGroup
            // 
            this.cmbAgeGroup.BackColor = System.Drawing.Color.White;
            this.cmbAgeGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "AgeGroup", true));
            this.cmbAgeGroup.FormattingEnabled = true;
            this.cmbAgeGroup.Items.AddRange(new object[] {
            "Minor",
            "Adult"});
            this.cmbAgeGroup.Location = new System.Drawing.Point(334, 253);
            this.cmbAgeGroup.Name = "cmbAgeGroup";
            this.cmbAgeGroup.Size = new System.Drawing.Size(142, 21);
            this.cmbAgeGroup.TabIndex = 74;
            this.cmbAgeGroup.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Age Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Gender";
            // 
            // dgvDeath
            // 
            this.dgvDeath.AllowUserToAddRows = false;
            this.dgvDeath.AllowUserToDeleteRows = false;
            this.dgvDeath.AutoGenerateColumns = false;
            this.dgvDeath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.regNoDataGridViewTextBoxColumn,
            this.fCardNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.gFNameDataGridViewTextBoxColumn,
            this.nukhDataGridViewTextBoxColumn,
            this.orakhDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.deathDateDataGridViewTextBoxColumn,
            this.relationDataGridViewTextBoxColumn,
            this.ageGroupDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.rAddressDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.deathTimeDataGridViewTextBoxColumn,
            this.IsPrinted,
            this.AppName,
            this.AppCNIC,
            this.AppRelation,
            this.DRCNumber});
            this.dgvDeath.DataSource = this.uspSELDeathBindingSource;
            this.dgvDeath.Location = new System.Drawing.Point(14, 61);
            this.dgvDeath.Name = "dgvDeath";
            this.dgvDeath.ReadOnly = true;
            this.dgvDeath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeath.Size = new System.Drawing.Size(470, 428);
            this.dgvDeath.TabIndex = 77;
            this.dgvDeath.TabStop = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "Reg No";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            this.regNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fCardNoDataGridViewTextBoxColumn
            // 
            this.fCardNoDataGridViewTextBoxColumn.DataPropertyName = "FCardNo";
            this.fCardNoDataGridViewTextBoxColumn.HeaderText = "Card No";
            this.fCardNoDataGridViewTextBoxColumn.Name = "fCardNoDataGridViewTextBoxColumn";
            this.fCardNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "Father";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gFNameDataGridViewTextBoxColumn
            // 
            this.gFNameDataGridViewTextBoxColumn.DataPropertyName = "GFName";
            this.gFNameDataGridViewTextBoxColumn.HeaderText = "Husband";
            this.gFNameDataGridViewTextBoxColumn.Name = "gFNameDataGridViewTextBoxColumn";
            this.gFNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nukhDataGridViewTextBoxColumn
            // 
            this.nukhDataGridViewTextBoxColumn.DataPropertyName = "Nukh";
            this.nukhDataGridViewTextBoxColumn.HeaderText = "Nukh";
            this.nukhDataGridViewTextBoxColumn.Name = "nukhDataGridViewTextBoxColumn";
            this.nukhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orakhDataGridViewTextBoxColumn
            // 
            this.orakhDataGridViewTextBoxColumn.DataPropertyName = "Orakh";
            this.orakhDataGridViewTextBoxColumn.HeaderText = "Orakh";
            this.orakhDataGridViewTextBoxColumn.Name = "orakhDataGridViewTextBoxColumn";
            this.orakhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deathDateDataGridViewTextBoxColumn
            // 
            this.deathDateDataGridViewTextBoxColumn.DataPropertyName = "DeathDate";
            this.deathDateDataGridViewTextBoxColumn.HeaderText = "DeathDate";
            this.deathDateDataGridViewTextBoxColumn.Name = "deathDateDataGridViewTextBoxColumn";
            this.deathDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationDataGridViewTextBoxColumn
            // 
            this.relationDataGridViewTextBoxColumn.DataPropertyName = "Relation";
            this.relationDataGridViewTextBoxColumn.HeaderText = "Relation";
            this.relationDataGridViewTextBoxColumn.Name = "relationDataGridViewTextBoxColumn";
            this.relationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageGroupDataGridViewTextBoxColumn
            // 
            this.ageGroupDataGridViewTextBoxColumn.DataPropertyName = "AgeGroup";
            this.ageGroupDataGridViewTextBoxColumn.HeaderText = "AgeGroup";
            this.ageGroupDataGridViewTextBoxColumn.Name = "ageGroupDataGridViewTextBoxColumn";
            this.ageGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAddressDataGridViewTextBoxColumn
            // 
            this.rAddressDataGridViewTextBoxColumn.DataPropertyName = "RAddress";
            this.rAddressDataGridViewTextBoxColumn.HeaderText = "RAddress";
            this.rAddressDataGridViewTextBoxColumn.Name = "rAddressDataGridViewTextBoxColumn";
            this.rAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deathTimeDataGridViewTextBoxColumn
            // 
            this.deathTimeDataGridViewTextBoxColumn.DataPropertyName = "DeathTime";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.deathTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.deathTimeDataGridViewTextBoxColumn.HeaderText = "DeathTime";
            this.deathTimeDataGridViewTextBoxColumn.Name = "deathTimeDataGridViewTextBoxColumn";
            this.deathTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsPrinted
            // 
            this.IsPrinted.DataPropertyName = "IsPrinted";
            this.IsPrinted.HeaderText = "IsPrinted";
            this.IsPrinted.Name = "IsPrinted";
            this.IsPrinted.ReadOnly = true;
            // 
            // AppName
            // 
            this.AppName.DataPropertyName = "AppName";
            this.AppName.HeaderText = "AppName";
            this.AppName.Name = "AppName";
            this.AppName.ReadOnly = true;
            // 
            // AppCNIC
            // 
            this.AppCNIC.DataPropertyName = "AppCNIC";
            this.AppCNIC.HeaderText = "AppCNIC";
            this.AppCNIC.Name = "AppCNIC";
            this.AppCNIC.ReadOnly = true;
            // 
            // AppRelation
            // 
            this.AppRelation.DataPropertyName = "AppRelation";
            this.AppRelation.HeaderText = "AppRelation";
            this.AppRelation.Name = "AppRelation";
            this.AppRelation.ReadOnly = true;
            // 
            // DRCNumber
            // 
            this.DRCNumber.DataPropertyName = "DRCNumber";
            this.DRCNumber.HeaderText = "DRCNumber";
            this.DRCNumber.Name = "DRCNumber";
            this.DRCNumber.ReadOnly = true;
            // 
            // uspSELDeathBindingSource
            // 
            this.uspSELDeathBindingSource.DataMember = "usp_SEL_Death";
            this.uspSELDeathBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDOD
            // 
            this.dtpDOD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "DeathDate", true));
            this.dtpDOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOD.Location = new System.Drawing.Point(112, 292);
            this.dtpDOD.Name = "dtpDOD";
            this.dtpDOD.Size = new System.Drawing.Size(86, 20);
            this.dtpDOD.TabIndex = 9;
            this.dtpDOD.Leave += new System.EventHandler(this.dtpDOD_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(206, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Sea&rch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(100, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Registrarion No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(-10, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "*";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Name", true));
            this.txtName.DataSource = this.uspSELtblFamilyMemberBindingSource;
            this.txtName.DisplayMember = "MemberName";
            this.txtName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtName.FormattingEnabled = true;
            this.txtName.Location = new System.Drawing.Point(112, 200);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 8;
            this.txtName.ValueMember = "FamilyMemberID";
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // uspSELtblFamilyMemberBindingSource
            // 
            this.uspSELtblFamilyMemberBindingSource.DataMember = "usp_SEL_tblFamilyMember";
            this.uspSELtblFamilyMemberBindingSource.DataSource = this.comDataSet;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(22, 465);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(462, 2);
            this.label23.TabIndex = 90;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(0, -2);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(498, 20);
            this.lbl.TabIndex = 385;
            this.lbl.Text = "Death Registration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 386;
            this.label9.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Age", true));
            this.txtAge.Location = new System.Drawing.Point(236, 293);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(68, 20);
            this.txtAge.TabIndex = 387;
            // 
            // cmbPlace
            // 
            this.cmbPlace.BackColor = System.Drawing.Color.White;
            this.cmbPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "Place", true));
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Items.AddRange(new object[] {
            "At Home",
            "At Hospital"});
            this.cmbPlace.Location = new System.Drawing.Point(347, 322);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(129, 21);
            this.cmbPlace.TabIndex = 12;
            this.cmbPlace.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 388;
            this.label13.Text = "Place of Death:";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(14, 191);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(462, 2);
            this.label19.TabIndex = 390;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(14, 283);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(462, 2);
            this.label20.TabIndex = 391;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(310, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 392;
            this.label21.Text = "Time of Death";
            // 
            // dtpDtime
            // 
            this.dtpDtime.CustomFormat = "hh:mm tt";
            this.dtpDtime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELDeathBindingSource1, "DeathTime", true));
            this.dtpDtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDtime.Location = new System.Drawing.Point(390, 293);
            this.dtpDtime.Name = "dtpDtime";
            this.dtpDtime.Size = new System.Drawing.Size(86, 20);
            this.dtpDtime.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(14, 354);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(462, 2);
            this.label22.TabIndex = 394;
            // 
            // usp_SEL_DeathTableAdapter1
            // 
            this.usp_SEL_DeathTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Location = new System.Drawing.Point(112, 200);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(142, 20);
            this.txtNameEdit.TabIndex = 395;
            this.txtNameEdit.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(14, 525);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 24);
            this.btnPrint.TabIndex = 396;
            this.btnPrint.Text = "&Print Certificate";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsPrinted);
            this.groupBox1.Controls.Add(this.cmbApplicantRelation);
            this.groupBox1.Controls.Add(this.txtApplicantName);
            this.groupBox1.Controls.Add(this.txtApplicantCNIC);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(13, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 78);
            this.groupBox1.TabIndex = 397;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Applicant Information";
            // 
            // chkIsPrinted
            // 
            this.chkIsPrinted.AutoSize = true;
            this.chkIsPrinted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsPrinted.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.uspSELDeathBindingSource, "IsPrinted", true));
            this.chkIsPrinted.Location = new System.Drawing.Point(276, 19);
            this.chkIsPrinted.Name = "chkIsPrinted";
            this.chkIsPrinted.Size = new System.Drawing.Size(59, 17);
            this.chkIsPrinted.TabIndex = 403;
            this.chkIsPrinted.Text = "Printed\r\n";
            this.chkIsPrinted.UseVisualStyleBackColor = true;
            // 
            // cmbApplicantRelation
            // 
            this.cmbApplicantRelation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbApplicantRelation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbApplicantRelation.FormattingEnabled = true;
            this.cmbApplicantRelation.Items.AddRange(new object[] {
            "",
            "Aunty",
            "Brother",
            "Brother_in_Law",
            "Cousin",
            "Daughter",
            "Daughter_in_Law",
            "Father",
            "Father_in_Law",
            "Grand_Daughter",
            "Grand_Father",
            "Grand_Mother",
            "Grand_Son",
            "Head of Family",
            "Husband",
            "Mother",
            "Mother_in_Law",
            "Nephew",
            "Niece",
            "Sister",
            "Sister_in_Law",
            "Son",
            "Son_in_Law",
            "Uncle",
            "Wife"});
            this.cmbApplicantRelation.Location = new System.Drawing.Point(321, 49);
            this.cmbApplicantRelation.Name = "cmbApplicantRelation";
            this.cmbApplicantRelation.Size = new System.Drawing.Size(141, 21);
            this.cmbApplicantRelation.TabIndex = 402;
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(99, 20);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.Size = new System.Drawing.Size(142, 20);
            this.txtApplicantName.TabIndex = 401;
            // 
            // txtApplicantCNIC
            // 
            this.txtApplicantCNIC.Location = new System.Drawing.Point(99, 49);
            this.txtApplicantCNIC.Name = "txtApplicantCNIC";
            this.txtApplicantCNIC.Size = new System.Drawing.Size(142, 20);
            this.txtApplicantCNIC.TabIndex = 400;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(247, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 13);
            this.label26.TabIndex = 398;
            this.label26.Text = "Relation";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 399;
            this.label25.Text = "CNIC";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 398;
            this.label24.Text = "Name";
            // 
            // txtDRCN
            // 
            this.txtDRCN.Enabled = false;
            this.txtDRCN.Location = new System.Drawing.Point(366, 29);
            this.txtDRCN.Name = "txtDRCN";
            this.txtDRCN.Size = new System.Drawing.Size(118, 20);
            this.txtDRCN.TabIndex = 398;
            // 
            // lblDRCN
            // 
            this.lblDRCN.AutoSize = true;
            this.lblDRCN.Location = new System.Drawing.Point(316, 32);
            this.lblDRCN.Name = "lblDRCN";
            this.lblDRCN.Size = new System.Drawing.Size(37, 13);
            this.lblDRCN.TabIndex = 399;
            this.lblDRCN.Text = "DCN#";
            // 
            // usp_SEL_DeathTableAdapter
            // 
            this.usp_SEL_DeathTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_FAMILYTableAdapter
            // 
            this.usp_SEL_FAMILYTableAdapter.ClearBeforeFill = true;
            // 
            // uspSELFAMILYBindingSource
            // 
            this.uspSELFAMILYBindingSource.DataMember = "usp_SEL_FAMILY";
            this.uspSELFAMILYBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_tblFamilyMemberTableAdapter
            // 
            this.usp_SEL_tblFamilyMemberTableAdapter.ClearBeforeFill = true;
            // 
            // uspSELTSFtblFamilyMemberBindingSource
            // 
            this.uspSELTSFtblFamilyMemberBindingSource.DataMember = "usp_SEL_TSF_tblFamilyMember";
            this.uspSELTSFtblFamilyMemberBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_TSF_tblFamilyMemberTableAdapter
            // 
            this.usp_SEL_TSF_tblFamilyMemberTableAdapter.ClearBeforeFill = true;
            // 
            // frmDeathRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(497, 556);
            this.Controls.Add(this.lblDRCN);
            this.Controls.Add(this.txtDRCN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtNameEdit);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtpDtime);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDOD);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbAgeGroup);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRelation);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.txtOrakh);
            this.Controls.Add(this.txtNukh);
            this.Controls.Add(this.txtGFName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtFCardNo);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtReasonOfDeath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvDeath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeathRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmDeathRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspSELDeathBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELDeathBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblFamilyMemberBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELFAMILYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELTSFtblFamilyMemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtReasonOfDeath;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbRelation;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.TextBox txtOrakh;
        private System.Windows.Forms.TextBox txtNukh;
        private System.Windows.Forms.TextBox txtGFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtFCardNo;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbAgeGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDeath;
        private System.Windows.Forms.DateTimePicker dtpDOD;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource uspSELDeathBindingSource;
        private ComDataSetTableAdapters.usp_SEL_DeathTableAdapter usp_SEL_DeathTableAdapter;
        private ComDataSetTableAdapters.usp_SEL_FAMILYTableAdapter usp_SEL_FAMILYTableAdapter;
        private System.Windows.Forms.BindingSource uspSELFAMILYBindingSource;
        private System.Windows.Forms.BindingSource uspSELtblFamilyMemberBindingSource;
        private ComDataSetTableAdapters.usp_SEL_tblFamilyMemberTableAdapter usp_SEL_tblFamilyMemberTableAdapter;
        private System.Windows.Forms.BindingSource uspSELTSFtblFamilyMemberBindingSource;
        private ComDataSetTableAdapters.usp_SEL_TSF_tblFamilyMemberTableAdapter usp_SEL_TSF_tblFamilyMemberTableAdapter;
        private System.Windows.Forms.ComboBox txtName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpDtime;
        private System.Windows.Forms.Label label22;
        private dataset3 dataset3;
        private System.Windows.Forms.BindingSource uspSELDeathBindingSource1;
        private MCKJ.dataset3TableAdapters.usp_SEL_DeathTableAdapter usp_SEL_DeathTableAdapter1;
        private System.Windows.Forms.TextBox txtNameEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtApplicantCNIC;
        private System.Windows.Forms.ComboBox cmbApplicantRelation;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.TextBox txtDRCN;
        private System.Windows.Forms.Label lblDRCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nukhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orakhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPrinted;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRCNumber;
        private System.Windows.Forms.CheckBox chkIsPrinted;
    }
}