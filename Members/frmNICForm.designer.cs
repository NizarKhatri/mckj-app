namespace MCKJ
{
    partial class frmNICForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNICForm));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblMr = new System.Windows.Forms.Label();
            this.dgvHallBooking = new System.Windows.Forms.DataGridView();
            this.Event = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uspSELtblFamilyMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.NoPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerPerson = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblCardTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset3 = new MCKJ.dataset3();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset2 = new MCKJ.dataset2();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCloseView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFCardNo = new System.Windows.Forms.TextBox();
            this.uspHallBookingSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_HallBooking_SearchTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_HallBooking_SearchTableAdapter();
            this.uspSELtblOrakhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_tblOrakhTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblOrakhTableAdapter();
            this.tblTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblTransactionsTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblAccountsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.tblRenAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAdvAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tblEventsTableAdapter = new MCKJ.dataset2TableAdapters.tblEventsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrakh = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tblHallAccTableAdapter = new MCKJ.dataset2TableAdapters.tblHallAccTableAdapter();
            this.tblAdvAccTableAdapter = new MCKJ.dataset3TableAdapters.tblAdvAccTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txthbkReceipt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblAdvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAdvanceTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAdvanceTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tblCardTypeTableAdapter = new MCKJ.dataset3TableAdapters.tblCardTypeTableAdapter();
            this.usp_SEL_tblFamilyMemberTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblFamilyMemberTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receiptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orakhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNICFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNICFormTableAdapter = new MCKJ.ComDataSetTableAdapters.tblNICFormTableAdapter();
            this.tblRenAccTableAdapter = new MCKJ.dataset3TableAdapters.tblRenAccTableAdapter();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblFamilyMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCardTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspHallBookingSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRenAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdvAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdvanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNICFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(235, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(82, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(196, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Dated";
            // 
            // txtHead
            // 
            this.txtHead.Location = new System.Drawing.Point(85, 59);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(232, 20);
            this.txtHead.TabIndex = 7;
            this.txtHead.TabStop = false;
            // 
            // txtReceipt
            // 
            this.txtReceipt.BackColor = System.Drawing.SystemColors.Info;
            this.txtReceipt.Enabled = false;
            this.txtReceipt.Location = new System.Drawing.Point(85, 33);
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(100, 20);
            this.txtReceipt.TabIndex = 4;
            this.txtReceipt.TabStop = false;
            this.txtReceipt.TextChanged += new System.EventHandler(this.txtReceipt_TextChanged);
            this.txtReceipt.Leave += new System.EventHandler(this.txtSerialNo_Leave);
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(12, 36);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(64, 13);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "Receipt No:";
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.Location = new System.Drawing.Point(12, 62);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(68, 13);
            this.lblMr.TabIndex = 5;
            this.lblMr.Text = "Family Head:";
            // 
            // dgvHallBooking
            // 
            this.dgvHallBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHallBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event,
            this.NoPerson,
            this.PerPerson,
            this.Total,
            this.ID});
            this.dgvHallBooking.Location = new System.Drawing.Point(15, 141);
            this.dgvHallBooking.MultiSelect = false;
            this.dgvHallBooking.Name = "dgvHallBooking";
            this.dgvHallBooking.RowHeadersWidth = 25;
            this.dgvHallBooking.Size = new System.Drawing.Size(506, 156);
            this.dgvHallBooking.TabIndex = 10;
            this.dgvHallBooking.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvHallBooking_UserDeletingRow);
            this.dgvHallBooking.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallBooking_CellLeave);
            this.dgvHallBooking.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvHallBooking_UserAddedRow);
            this.dgvHallBooking.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvHallBooking_UserDeletedRow);
            this.dgvHallBooking.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallBooking_CellEnter);
            // 
            // Event
            // 
            this.Event.DataSource = this.uspSELtblFamilyMemberBindingSource;
            this.Event.DisplayMember = "MemberName";
            this.Event.HeaderText = "Member Name";
            this.Event.Name = "Event";
            this.Event.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Event.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Event.ValueMember = "FamilyMemberID";
            this.Event.Width = 150;
            // 
            // uspSELtblFamilyMemberBindingSource
            // 
            this.uspSELtblFamilyMemberBindingSource.DataMember = "usp_SEL_tblFamilyMember";
            this.uspSELtblFamilyMemberBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NoPerson
            // 
            this.NoPerson.HeaderText = "Age";
            this.NoPerson.Name = "NoPerson";
            this.NoPerson.Width = 120;
            // 
            // PerPerson
            // 
            this.PerPerson.DataSource = this.tblCardTypeBindingSource;
            this.PerPerson.DisplayMember = "CardType";
            this.PerPerson.HeaderText = "Card Status";
            this.PerPerson.Name = "PerPerson";
            this.PerPerson.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PerPerson.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PerPerson.ValueMember = "ID";
            // 
            // tblCardTypeBindingSource
            // 
            this.tblCardTypeBindingSource.DataMember = "tblCardType";
            this.tblCardTypeBindingSource.DataSource = this.dataset3;
            // 
            // dataset3
            // 
            this.dataset3.DataSetName = "dataset3";
            this.dataset3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Total
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Total.DefaultCellStyle = dataGridViewCellStyle1;
            this.Total.HeaderText = "Amount";
            this.Total.Name = "Total";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // tblEventsBindingSource
            // 
            this.tblEventsBindingSource.DataMember = "tblEvents";
            this.tblEventsBindingSource.DataSource = this.dataset2;
            // 
            // dataset2
            // 
            this.dataset2.DataSetName = "dataset2";
            this.dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(364, 303);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(137, 388);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Majlis / Soyem",
            "Engagement",
            "Mayon / Mefil",
            "Aameen/ Rasm-e-Ter",
            "Birthday / Anniversary",
            "Khatna",
            "Aqiqa",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(676, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Visible = false;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // btnCloseView
            // 
            this.btnCloseView.Location = new System.Drawing.Point(445, 303);
            this.btnCloseView.Name = "btnCloseView";
            this.btnCloseView.Size = new System.Drawing.Size(75, 23);
            this.btnCloseView.TabIndex = 13;
            this.btnCloseView.Text = "&Cancel";
            this.btnCloseView.UseVisualStyleBackColor = true;
            this.btnCloseView.Click += new System.EventHandler(this.btnCloseView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 332);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Modify";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(446, 30);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(75, 23);
            this.btnGetName.TabIndex = 6;
            this.btnGetName.Text = "Get Name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Card No.";
            // 
            // txtFCardNo
            // 
            this.txtFCardNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtFCardNo.Location = new System.Drawing.Point(393, 32);
            this.txtFCardNo.Name = "txtFCardNo";
            this.txtFCardNo.Size = new System.Drawing.Size(47, 20);
            this.txtFCardNo.TabIndex = 5;
            this.txtFCardNo.Leave += new System.EventHandler(this.txtFCardNo_Leave);
            // 
            // uspHallBookingSearchBindingSource
            // 
            this.uspHallBookingSearchBindingSource.DataMember = "usp_HallBooking_Search";
            this.uspHallBookingSearchBindingSource.DataSource = this.comDataSet;
            // 
            // tblAccountsBindingSource
            // 
            this.tblAccountsBindingSource.DataMember = "tblAccounts";
            this.tblAccountsBindingSource.DataSource = this.comDataSet;
            // 
            // usp_HallBooking_SearchTableAdapter
            // 
            this.usp_HallBooking_SearchTableAdapter.ClearBeforeFill = true;
            // 
            // uspSELtblOrakhBindingSource
            // 
            this.uspSELtblOrakhBindingSource.DataMember = "usp_SEL_tblOrakh";
            this.uspSELtblOrakhBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_tblOrakhTableAdapter
            // 
            this.usp_SEL_tblOrakhTableAdapter.ClearBeforeFill = true;
            // 
            // tblTransactionsBindingSource
            // 
            this.tblTransactionsBindingSource.DataMember = "tblTransactions";
            this.tblTransactionsBindingSource.DataSource = this.comDataSet;
            // 
            // tblTransactionsTableAdapter
            // 
            this.tblTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(258, 332);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(534, 20);
            this.lblHeader.TabIndex = 23;
            this.lblHeader.Text = "NIC Form";
            // 
            // tblAccountsTableAdapter
            // 
            this.tblAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAccount
            // 
            this.cmbAccount.DataSource = this.tblRenAccBindingSource;
            this.cmbAccount.DisplayMember = "RenewalAcc";
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(85, 112);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(169, 21);
            this.cmbAccount.TabIndex = 8;
            this.cmbAccount.ValueMember = "AccID";
            this.cmbAccount.SelectedIndexChanged += new System.EventHandler(this.cmbAccount_SelectedIndexChanged);
            // 
            // tblRenAccBindingSource
            // 
            this.tblRenAccBindingSource.DataMember = "tblRenAcc";
            this.tblRenAccBindingSource.DataSource = this.dataset3;
            // 
            // tblAdvAccBindingSource
            // 
            this.tblAdvAccBindingSource.DataMember = "tblAdvAcc";
            this.tblAdvAccBindingSource.DataSource = this.dataset3;
            // 
            // tblHallAccBindingSource
            // 
            this.tblHallAccBindingSource.DataMember = "tblHallAcc";
            this.tblHallAccBindingSource.DataSource = this.dataset2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Account";
            // 
            // tblEventsTableAdapter
            // 
            this.tblEventsTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Contact No:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(393, 85);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(128, 20);
            this.txtContactNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Father Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(85, 85);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(232, 20);
            this.txtFName.TabIndex = 3;
            this.txtFName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Orakh:";
            // 
            // cmbOrakh
            // 
            this.cmbOrakh.DataSource = this.uspSELtblOrakhBindingSource;
            this.cmbOrakh.DisplayMember = "OrakhName";
            this.cmbOrakh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrakh.FormattingEnabled = true;
            this.cmbOrakh.Location = new System.Drawing.Point(393, 59);
            this.cmbOrakh.Name = "cmbOrakh";
            this.cmbOrakh.Size = new System.Drawing.Size(128, 21);
            this.cmbOrakh.TabIndex = 8;
            this.cmbOrakh.TabStop = false;
            this.cmbOrakh.ValueMember = "ID";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 361);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 125;
            this.richTextBox1.Tag = "";
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(17, 369);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 126;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.Visible = false;
            // 
            // tblHallAccTableAdapter
            // 
            this.tblHallAccTableAdapter.ClearBeforeFill = true;
            // 
            // tblAdvAccTableAdapter
            // 
            this.tblAdvAccTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 129;
            this.label3.Text = "Hall Booking Receipt No:";
            this.label3.Visible = false;
            // 
            // txthbkReceipt
            // 
            this.txthbkReceipt.BackColor = System.Drawing.SystemColors.Info;
            this.txthbkReceipt.Location = new System.Drawing.Point(325, 360);
            this.txthbkReceipt.Name = "txthbkReceipt";
            this.txthbkReceipt.Size = new System.Drawing.Size(128, 20);
            this.txthbkReceipt.TabIndex = 9;
            this.txthbkReceipt.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // tblAdvanceBindingSource
            // 
            this.tblAdvanceBindingSource.DataMember = "tblAdvance";
            this.tblAdvanceBindingSource.DataSource = this.comDataSet;
            // 
            // tblAdvanceTableAdapter
            // 
            this.tblAdvanceTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(52, 303);
            this.txtTotal.MaxLength = 15;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(106, 20);
            this.txtTotal.TabIndex = 130;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // tblCardTypeTableAdapter
            // 
            this.tblCardTypeTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_tblFamilyMemberTableAdapter
            // 
            this.usp_SEL_tblFamilyMemberTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.fCardNoDataGridViewTextBoxColumn,
            this.headDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.orakhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNICFormBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(652, 296);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // receiptNoDataGridViewTextBoxColumn
            // 
            this.receiptNoDataGridViewTextBoxColumn.DataPropertyName = "ReceiptNo";
            this.receiptNoDataGridViewTextBoxColumn.HeaderText = "ReceiptNo";
            this.receiptNoDataGridViewTextBoxColumn.Name = "receiptNoDataGridViewTextBoxColumn";
            this.receiptNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fCardNoDataGridViewTextBoxColumn
            // 
            this.fCardNoDataGridViewTextBoxColumn.DataPropertyName = "FCardNo";
            this.fCardNoDataGridViewTextBoxColumn.HeaderText = "FCardNo";
            this.fCardNoDataGridViewTextBoxColumn.Name = "fCardNoDataGridViewTextBoxColumn";
            this.fCardNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headDataGridViewTextBoxColumn
            // 
            this.headDataGridViewTextBoxColumn.DataPropertyName = "Head";
            this.headDataGridViewTextBoxColumn.HeaderText = "Head";
            this.headDataGridViewTextBoxColumn.Name = "headDataGridViewTextBoxColumn";
            this.headDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orakhDataGridViewTextBoxColumn
            // 
            this.orakhDataGridViewTextBoxColumn.DataPropertyName = "Orakh";
            this.orakhDataGridViewTextBoxColumn.HeaderText = "Orakh";
            this.orakhDataGridViewTextBoxColumn.Name = "orakhDataGridViewTextBoxColumn";
            this.orakhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblNICFormBindingSource
            // 
            this.tblNICFormBindingSource.DataMember = "tblNICForm";
            this.tblNICFormBindingSource.DataSource = this.comDataSet;
            // 
            // tblNICFormTableAdapter
            // 
            this.tblNICFormTableAdapter.ClearBeforeFill = true;
            // 
            // tblRenAccTableAdapter
            // 
            this.tblRenAccTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(229, 361);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 96);
            this.richTextBox3.TabIndex = 125;
            this.richTextBox3.Tag = "";
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            this.richTextBox3.Visible = false;
            // 
            // frmNICForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 360);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txthbkReceipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetName);
            this.Controls.Add(this.btnCloseView);
            this.Controls.Add(this.txtFCardNo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrakh);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMr);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvHallBooking);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNICForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmHallBoking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblFamilyMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCardTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspHallBookingSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRenAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdvAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdvanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNICFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblMr;
        private System.Windows.Forms.DataGridView dgvHallBooking;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCloseView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource uspHallBookingSearchBindingSource;
        private ComDataSet comDataSet;
        private MCKJ.ComDataSetTableAdapters.usp_HallBooking_SearchTableAdapter usp_HallBooking_SearchTableAdapter;
        private System.Windows.Forms.BindingSource uspSELtblOrakhBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblOrakhTableAdapter usp_SEL_tblOrakhTableAdapter;
        private System.Windows.Forms.BindingSource tblTransactionsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblTransactionsTableAdapter tblTransactionsTableAdapter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter tblAccountsTableAdapter;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label label5;
        private dataset2 dataset2;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private MCKJ.dataset2TableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrakh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.BindingSource tblHallAccBindingSource;
        private MCKJ.dataset2TableAdapters.tblHallAccTableAdapter tblHallAccTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFCardNo;
        private System.Windows.Forms.Button btnGetName;
        private dataset3 dataset3;
        private System.Windows.Forms.BindingSource tblAdvAccBindingSource;
        private MCKJ.dataset3TableAdapters.tblAdvAccTableAdapter tblAdvAccTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthbkReceipt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource tblAdvanceBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblAdvanceTableAdapter tblAdvanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.BindingSource tblCardTypeBindingSource;
        private MCKJ.dataset3TableAdapters.tblCardTypeTableAdapter tblCardTypeTableAdapter;
        private System.Windows.Forms.BindingSource uspSELtblFamilyMemberBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblFamilyMemberTableAdapter usp_SEL_tblFamilyMemberTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblNICFormBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblNICFormTableAdapter tblNICFormTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPerson;
        private System.Windows.Forms.DataGridViewComboBoxColumn PerPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orakhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblRenAccBindingSource;
        private MCKJ.dataset3TableAdapters.tblRenAccTableAdapter tblRenAccTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox3;
        // private System.Windows.Forms.DataGridViewTextBoxColumn Day;
    }
}