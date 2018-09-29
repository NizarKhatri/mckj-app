namespace MCKJ
{
    partial class frmHallBoking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHallBoking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtMr = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblMr = new System.Windows.Forms.Label();
            this.dgvHallBooking = new System.Windows.Forms.DataGridView();
            this.Event = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset2 = new MCKJ.dataset2();
            this.Hall1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCloseView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintRpt = new System.Windows.Forms.Button();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.rbtEmpty = new System.Windows.Forms.RadioButton();
            this.dtpSearchDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancelEvent = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.rtbCheckHallForBooking = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Events = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall_3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall_4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall_5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHallBook = new System.Windows.Forms.DataGridView();
            this.btnGetName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFCardNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uspHallBookingSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_HallBooking_SearchTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_HallBooking_SearchTableAdapter();
            this.uspSELtblOrakhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_tblOrakhTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblOrakhTableAdapter();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tblTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblTransactionsTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblAccountsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.tblHallAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblEventsTableAdapter = new MCKJ.dataset2TableAdapters.tblEventsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrakh = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tblHallAccTableAdapter = new MCKJ.dataset2TableAdapters.tblHallAccTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.chkTemp = new System.Windows.Forms.CheckBox();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.dtpDefaultEventDate = new System.Windows.Forms.DateTimePicker();
            this.chkNM = new System.Windows.Forms.CheckBox();
            this.uspGetHallBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communityDataSet = new MCKJ.CommunityDataSet();
            this.usp_GetHallBookingTableAdapter = new MCKJ.CommunityDataSetTableAdapters.usp_GetHallBookingTableAdapter();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchCriteria = new System.Windows.Forms.Button();
            this.cmbCriteria = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspHallBookingSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetHallBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityDataSet)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(239, 89);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(82, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(197, 93);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Dated";
            // 
            // txtMr
            // 
            this.txtMr.Location = new System.Drawing.Point(71, 116);
            this.txtMr.Name = "txtMr";
            this.txtMr.Size = new System.Drawing.Size(113, 20);
            this.txtMr.TabIndex = 4;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(71, 90);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(100, 20);
            this.txtSerialNo.TabIndex = 0;
            this.txtSerialNo.TextChanged += new System.EventHandler(this.txtSerialNo_TextChanged);
            this.txtSerialNo.Leave += new System.EventHandler(this.txtSerialNo_Leave);
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(12, 93);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(53, 13);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "Serial No.";
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.Location = new System.Drawing.Point(12, 119);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(27, 13);
            this.lblMr.TabIndex = 5;
            this.lblMr.Text = "MR.";
            // 
            // dgvHallBooking
            // 
            this.dgvHallBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHallBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event,
            this.Hall1,
            this.Hall2,
            this.Hall3,
            this.Hall4,
            this.Hall5,
            this.Date,
            this.Day,
            this.FTime,
            this.To,
            this.Remarks,
            this.ReasonCancel,
            this.ID});
            this.dgvHallBooking.Location = new System.Drawing.Point(15, 168);
            this.dgvHallBooking.MultiSelect = false;
            this.dgvHallBooking.Name = "dgvHallBooking";
            this.dgvHallBooking.RowHeadersWidth = 25;
            this.dgvHallBooking.Size = new System.Drawing.Size(944, 269);
            this.dgvHallBooking.TabIndex = 8;
            this.dgvHallBooking.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvHallBooking_UserDeletingRow);
            this.dgvHallBooking.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallBooking_CellLeave);
            this.dgvHallBooking.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvHallBooking_UserAddedRow);
            this.dgvHallBooking.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvHallBooking_UserDeletedRow);
            this.dgvHallBooking.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallBooking_CellEnter);
            // 
            // Event
            // 
            this.Event.DataSource = this.tblEventsBindingSource;
            this.Event.DisplayMember = "Events";
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Event.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Event.ValueMember = "ID";
            this.Event.Width = 125;
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
            // Hall1
            // 
            this.Hall1.FalseValue = "0";
            this.Hall1.HeaderText = "Hall # 1";
            this.Hall1.Name = "Hall1";
            this.Hall1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hall1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hall1.TrueValue = "1";
            this.Hall1.Width = 70;
            // 
            // Hall2
            // 
            this.Hall2.FalseValue = "0";
            this.Hall2.HeaderText = "Hall # 2";
            this.Hall2.Name = "Hall2";
            this.Hall2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hall2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hall2.TrueValue = "1";
            this.Hall2.Width = 70;
            // 
            // Hall3
            // 
            this.Hall3.FalseValue = "0";
            this.Hall3.HeaderText = "Hall # 3";
            this.Hall3.Name = "Hall3";
            this.Hall3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hall3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hall3.TrueValue = "1";
            this.Hall3.Width = 70;
            // 
            // Hall4
            // 
            this.Hall4.FalseValue = "0";
            this.Hall4.HeaderText = "Hall # 4";
            this.Hall4.Name = "Hall4";
            this.Hall4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hall4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hall4.TrueValue = "1";
            this.Hall4.Width = 70;
            // 
            // Hall5
            // 
            this.Hall5.FalseValue = "0";
            this.Hall5.HeaderText = "Hall # 5";
            this.Hall5.Name = "Hall5";
            this.Hall5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hall5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hall5.TrueValue = "1";
            // 
            // Date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Dated";
            this.Date.Name = "Date";
            this.Date.Width = 75;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.Width = 70;
            // 
            // FTime
            // 
            this.FTime.HeaderText = "From";
            this.FTime.Items.AddRange(new object[] {
            "10:00AM",
            "11:00AM",
            "12:00PM",
            "01:00PM",
            "02:00PM",
            "03:00PM",
            "04:00PM",
            "05:00PM",
            "06:00PM",
            "07:00PM",
            "08:00PM",
            "09:00PM",
            "10:00PM",
            "11:00PM",
            "12:00AM"});
            this.FTime.Name = "FTime";
            this.FTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FTime.Width = 70;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.Items.AddRange(new object[] {
            "10:00AM",
            "11:00AM",
            "12:00PM",
            "01:00PM",
            "02:00PM",
            "03:00PM",
            "04:00PM",
            "05:00PM",
            "06:00PM",
            "07:00PM",
            "08:00PM",
            "09:00PM",
            "10:00PM",
            "11:00PM",
            "12:00AM"});
            this.To.Name = "To";
            this.To.Width = 70;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 140;
            // 
            // ReasonCancel
            // 
            this.ReasonCancel.HeaderText = "Status";
            this.ReasonCancel.Name = "ReasonCancel";
            this.ReasonCancel.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(887, 466);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(887, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(806, 437);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(96, 466);
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
            this.comboBox1.Location = new System.Drawing.Point(41, 155);
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
            this.btnCloseView.Location = new System.Drawing.Point(96, 466);
            this.btnCloseView.Name = "btnCloseView";
            this.btnCloseView.Size = new System.Drawing.Size(75, 23);
            this.btnCloseView.TabIndex = 17;
            this.btnCloseView.Text = "&Close";
            this.btnCloseView.UseVisualStyleBackColor = true;
            this.btnCloseView.Visible = false;
            this.btnCloseView.Click += new System.EventHandler(this.btnCloseView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(688, 541);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrintRpt);
            this.groupBox1.Controls.Add(this.rbtAll);
            this.groupBox1.Controls.Add(this.rbtEmpty);
            this.groupBox1.Controls.Add(this.dtpSearchDateTo);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpSearchDate);
            this.groupBox1.Location = new System.Drawing.Point(723, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 78);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Event";
            // 
            // btnPrintRpt
            // 
            this.btnPrintRpt.Location = new System.Drawing.Point(179, 46);
            this.btnPrintRpt.Name = "btnPrintRpt";
            this.btnPrintRpt.Size = new System.Drawing.Size(59, 23);
            this.btnPrintRpt.TabIndex = 5;
            this.btnPrintRpt.Text = "Print";
            this.btnPrintRpt.UseVisualStyleBackColor = true;
            this.btnPrintRpt.Click += new System.EventHandler(this.btnPrintRpt_Click);
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Checked = true;
            this.rbtAll.Location = new System.Drawing.Point(103, 46);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(75, 17);
            this.rbtAll.TabIndex = 4;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "Any Empty";
            this.rbtAll.UseVisualStyleBackColor = true;
            // 
            // rbtEmpty
            // 
            this.rbtEmpty.AutoSize = true;
            this.rbtEmpty.Location = new System.Drawing.Point(103, 20);
            this.rbtEmpty.Name = "rbtEmpty";
            this.rbtEmpty.Size = new System.Drawing.Size(68, 17);
            this.rbtEmpty.TabIndex = 3;
            this.rbtEmpty.Text = "All Empty";
            this.rbtEmpty.UseVisualStyleBackColor = true;
            // 
            // dtpSearchDateTo
            // 
            this.dtpSearchDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchDateTo.Location = new System.Drawing.Point(10, 45);
            this.dtpSearchDateTo.Name = "dtpSearchDateTo";
            this.dtpSearchDateTo.Size = new System.Drawing.Size(87, 20);
            this.dtpSearchDateTo.TabIndex = 2;
            this.dtpSearchDateTo.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(179, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Searc&h";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchDate.Location = new System.Drawing.Point(10, 19);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(87, 20);
            this.dtpSearchDate.TabIndex = 0;
            this.dtpSearchDate.TabStop = false;
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // btnCancelEvent
            // 
            this.btnCancelEvent.Location = new System.Drawing.Point(849, 512);
            this.btnCancelEvent.Name = "btnCancelEvent";
            this.btnCancelEvent.Size = new System.Drawing.Size(121, 23);
            this.btnCancelEvent.TabIndex = 18;
            this.btnCancelEvent.Text = "Cancel Event";
            this.btnCancelEvent.UseVisualStyleBackColor = true;
            this.btnCancelEvent.Visible = false;
            this.btnCancelEvent.Click += new System.EventHandler(this.btnCancelEvent_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.rtbCheckHallForBooking);
            this.grbSearch.Controls.Add(this.richTextBox3);
            this.grbSearch.Controls.Add(this.dataGridView1);
            this.grbSearch.Location = new System.Drawing.Point(12, 153);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(957, 284);
            this.grbSearch.TabIndex = 123;
            this.grbSearch.TabStop = false;
            this.grbSearch.Visible = false;
            // 
            // rtbCheckHallForBooking
            // 
            this.rtbCheckHallForBooking.Location = new System.Drawing.Point(113, 85);
            this.rtbCheckHallForBooking.Name = "rtbCheckHallForBooking";
            this.rtbCheckHallForBooking.Size = new System.Drawing.Size(310, 96);
            this.rtbCheckHallForBooking.TabIndex = 126;
            this.rtbCheckHallForBooking.Text = resources.GetString("rtbCheckHallForBooking.Text");
            this.rtbCheckHallForBooking.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(730, 85);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(310, 96);
            this.richTextBox3.TabIndex = 133;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            this.richTextBox3.Visible = false;
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.Dated,
            this.EventDay,
            this.BookedBy,
            this.Events,
            this.Hall_1,
            this.Hall_2,
            this.Hall_3,
            this.Hall_4,
            this.Hall_5,
            this.From,
            this.To_});
            this.dataGridView1.Location = new System.Drawing.Point(6, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(941, 266);
            this.dataGridView1.TabIndex = 17;
            // 
            // SerialNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SerialNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.SerialNo.HeaderText = "SerialNo";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 55;
            // 
            // Dated
            // 
            this.Dated.HeaderText = "Event Date";
            this.Dated.Name = "Dated";
            this.Dated.ReadOnly = true;
            this.Dated.Width = 80;
            // 
            // EventDay
            // 
            this.EventDay.HeaderText = "Day";
            this.EventDay.Name = "EventDay";
            this.EventDay.ReadOnly = true;
            this.EventDay.Width = 75;
            // 
            // BookedBy
            // 
            this.BookedBy.HeaderText = "Booked By";
            this.BookedBy.Name = "BookedBy";
            this.BookedBy.ReadOnly = true;
            this.BookedBy.Width = 225;
            // 
            // Events
            // 
            this.Events.HeaderText = "Event";
            this.Events.Name = "Events";
            this.Events.ReadOnly = true;
            // 
            // Hall_1
            // 
            this.Hall_1.FalseValue = "0";
            this.Hall_1.HeaderText = "Hall#1";
            this.Hall_1.Name = "Hall_1";
            this.Hall_1.ReadOnly = true;
            this.Hall_1.TrueValue = "1";
            this.Hall_1.Width = 70;
            // 
            // Hall_2
            // 
            this.Hall_2.FalseValue = "0";
            this.Hall_2.HeaderText = "Hall#2";
            this.Hall_2.Name = "Hall_2";
            this.Hall_2.ReadOnly = true;
            this.Hall_2.TrueValue = "1";
            this.Hall_2.Width = 70;
            // 
            // Hall_3
            // 
            this.Hall_3.FalseValue = "0";
            this.Hall_3.HeaderText = "Hall#3";
            this.Hall_3.Name = "Hall_3";
            this.Hall_3.ReadOnly = true;
            this.Hall_3.TrueValue = "1";
            this.Hall_3.Width = 70;
            // 
            // Hall_4
            // 
            this.Hall_4.FalseValue = "0";
            this.Hall_4.HeaderText = "Hall#4";
            this.Hall_4.Name = "Hall_4";
            this.Hall_4.ReadOnly = true;
            this.Hall_4.TrueValue = "1";
            this.Hall_4.Width = 70;
            // 
            // Hall_5
            // 
            this.Hall_5.FalseValue = "0";
            this.Hall_5.HeaderText = "Hall#5";
            this.Hall_5.Name = "Hall_5";
            this.Hall_5.ReadOnly = true;
            this.Hall_5.TrueValue = "1";
            this.Hall_5.Width = 70;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Width = 70;
            // 
            // To_
            // 
            this.To_.HeaderText = "To";
            this.To_.Name = "To_";
            this.To_.ReadOnly = true;
            this.To_.Width = 70;
            // 
            // dgvHallBook
            // 
            this.dgvHallBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHallBook.Location = new System.Drawing.Point(7, 80);
            this.dgvHallBook.Name = "dgvHallBook";
            this.dgvHallBook.Size = new System.Drawing.Size(963, 455);
            this.dgvHallBook.TabIndex = 18;
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(448, 87);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(75, 23);
            this.btnGetName.TabIndex = 3;
            this.btnGetName.Text = "Get Name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Card No.";
            // 
            // txtFCardNo
            // 
            this.txtFCardNo.Location = new System.Drawing.Point(384, 89);
            this.txtFCardNo.Name = "txtFCardNo";
            this.txtFCardNo.Size = new System.Drawing.Size(58, 20);
            this.txtFCardNo.TabIndex = 2;
            this.txtFCardNo.Leave += new System.EventHandler(this.txtFCardNo_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uspHallBookingSearchBindingSource
            // 
            this.uspHallBookingSearchBindingSource.DataMember = "usp_HallBooking_Search";
            this.uspHallBookingSearchBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(63, 437);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(108, 20);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
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
            this.btnPrint.Location = new System.Drawing.Point(177, 466);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(981, 20);
            this.lblHeader.TabIndex = 23;
            this.lblHeader.Text = "Hall Booking";
            // 
            // tblAccountsTableAdapter
            // 
            this.tblAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAccount
            // 
            this.cmbAccount.DataSource = this.tblHallAccBindingSource;
            this.cmbAccount.DisplayMember = "HallBookingAcc";
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(336, 437);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(151, 21);
            this.cmbAccount.TabIndex = 10;
            this.cmbAccount.ValueMember = "AccID";
            // 
            // tblHallAccBindingSource
            // 
            this.tblHallAccBindingSource.DataMember = "tblHallAcc";
            this.tblHallAccBindingSource.DataSource = this.dataset2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount";
            // 
            // tblEventsTableAdapter
            // 
            this.tblEventsTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Contact No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Father Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(265, 118);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(113, 20);
            this.txtFName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Orakh:";
            // 
            // cmbOrakh
            // 
            this.cmbOrakh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrakh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrakh.DataSource = this.uspSELtblOrakhBindingSource;
            this.cmbOrakh.DisplayMember = "OrakhName";
            this.cmbOrakh.FormattingEnabled = true;
            this.cmbOrakh.Location = new System.Drawing.Point(426, 118);
            this.cmbOrakh.Name = "cmbOrakh";
            this.cmbOrakh.Size = new System.Drawing.Size(98, 21);
            this.cmbOrakh.TabIndex = 6;
            this.cmbOrakh.ValueMember = "ID";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(387, 468);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 125;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(441, 238);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(310, 96);
            this.richTextBox2.TabIndex = 126;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.Visible = false;
            // 
            // tblHallAccTableAdapter
            // 
            this.tblHallAccTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 129;
            this.button2.Text = "&Ca&l Amount";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkTemp
            // 
            this.chkTemp.AutoSize = true;
            this.chkTemp.Location = new System.Drawing.Point(493, 439);
            this.chkTemp.Name = "chkTemp";
            this.chkTemp.Size = new System.Drawing.Size(118, 17);
            this.chkTemp.TabIndex = 131;
            this.chkTemp.Text = "Temporary Booking";
            this.chkTemp.UseVisualStyleBackColor = true;
            // 
            // btnSetDate
            // 
            this.btnSetDate.Location = new System.Drawing.Point(638, 87);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(75, 23);
            this.btnSetDate.TabIndex = 3;
            this.btnSetDate.TabStop = false;
            this.btnSetDate.Text = "Set Date";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // dtpDefaultEventDate
            // 
            this.dtpDefaultEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDefaultEventDate.Location = new System.Drawing.Point(529, 88);
            this.dtpDefaultEventDate.Name = "dtpDefaultEventDate";
            this.dtpDefaultEventDate.Size = new System.Drawing.Size(103, 20);
            this.dtpDefaultEventDate.TabIndex = 2;
            this.dtpDefaultEventDate.TabStop = false;
            // 
            // chkNM
            // 
            this.chkNM.AutoSize = true;
            this.chkNM.Location = new System.Drawing.Point(71, 141);
            this.chkNM.Name = "chkNM";
            this.chkNM.Size = new System.Drawing.Size(117, 17);
            this.chkNM.TabIndex = 132;
            this.chkNM.Text = "Non Card Members";
            this.chkNM.UseVisualStyleBackColor = true;
            // 
            // uspGetHallBookingBindingSource
            // 
            this.uspGetHallBookingBindingSource.DataMember = "usp_GetHallBooking";
            this.uspGetHallBookingBindingSource.DataSource = this.communityDataSet;
            // 
            // communityDataSet
            // 
            this.communityDataSet.DataSetName = "CommunityDataSet";
            this.communityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_GetHallBookingTableAdapter
            // 
            this.usp_GetHallBookingTableAdapter.ClearBeforeFill = true;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(600, 118);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(113, 20);
            this.txtContactNo.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(607, 541);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 133;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(526, 541);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 133;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.label7);
            this.gbSearch.Controls.Add(this.btnSearchCriteria);
            this.gbSearch.Controls.Add(this.cmbCriteria);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.label8);
            this.gbSearch.Location = new System.Drawing.Point(8, 21);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(633, 59);
            this.gbSearch.TabIndex = 10020;
            this.gbSearch.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10013;
            this.label7.Text = "Search Criteria";
            // 
            // btnSearchCriteria
            // 
            this.btnSearchCriteria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchCriteria.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCriteria.Image")));
            this.btnSearchCriteria.Location = new System.Drawing.Point(595, 16);
            this.btnSearchCriteria.Name = "btnSearchCriteria";
            this.btnSearchCriteria.Size = new System.Drawing.Size(36, 34);
            this.btnSearchCriteria.TabIndex = 10017;
            this.btnSearchCriteria.UseVisualStyleBackColor = false;
            this.btnSearchCriteria.Click += new System.EventHandler(this.btnSearchCriteria_Click);
            // 
            // cmbCriteria
            // 
            this.cmbCriteria.FormattingEnabled = true;
            this.cmbCriteria.Location = new System.Drawing.Point(79, 24);
            this.cmbCriteria.Name = "cmbCriteria";
            this.cmbCriteria.Size = new System.Drawing.Size(121, 21);
            this.cmbCriteria.TabIndex = 10014;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(275, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 20);
            this.txtSearch.TabIndex = 10016;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 10015;
            this.label8.Text = "Search Text";
            // 
            // frmHallBoking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 570);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgvHallBook);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancelEvent);
            this.Controls.Add(this.chkTemp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.btnCloseView);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvHallBooking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkNM);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.dtpDefaultEventDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetName);
            this.Controls.Add(this.txtFCardNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrakh);
            this.Controls.Add(this.lblMr);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.txtMr);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblSerialNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHallBoking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmHallBoking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspHallBookingSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetHallBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityDataSet)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtMr;
        private System.Windows.Forms.TextBox txtSerialNo;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource uspHallBookingSearchBindingSource;
        private ComDataSet comDataSet;
        private MCKJ.ComDataSetTableAdapters.usp_HallBooking_SearchTableAdapter usp_HallBooking_SearchTableAdapter;
        private System.Windows.Forms.BindingSource uspSELtblOrakhBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblOrakhTableAdapter usp_SEL_tblOrakhTableAdapter;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.BindingSource tblTransactionsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblTransactionsTableAdapter tblTransactionsTableAdapter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter tblAccountsTableAdapter;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private dataset2 dataset2;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private MCKJ.dataset2TableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkTemp;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.DateTimePicker dtpDefaultEventDate;
        private System.Windows.Forms.Button btnCancelEvent;
        private System.Windows.Forms.DateTimePicker dtpSearchDateTo;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.RadioButton rbtEmpty;
        private System.Windows.Forms.Button btnPrintRpt;
        private System.Windows.Forms.CheckBox chkNM;
        private CommunityDataSet communityDataSet;
        private System.Windows.Forms.BindingSource uspGetHallBookingBindingSource;
        private MCKJ.CommunityDataSetTableAdapters.usp_GetHallBookingTableAdapter usp_GetHallBookingTableAdapter;
        private System.Windows.Forms.DataGridView dgvHallBook;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchCriteria;
        private System.Windows.Forms.ComboBox cmbCriteria;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dated;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Events;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_;
        private System.Windows.Forms.RichTextBox rtbCheckHallForBooking;
        private System.Windows.Forms.DataGridViewComboBoxColumn Event;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewComboBoxColumn FTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        // private System.Windows.Forms.DataGridViewTextBoxColumn Day;
    }
}