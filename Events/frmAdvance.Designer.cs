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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHallBoking));
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Events = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall_3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hall_4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrakh = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tblHallAccTableAdapter = new MCKJ.dataset2TableAdapters.tblHallAccTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspHallBookingSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(239, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(82, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(197, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Dated";
            // 
            // txtMr
            // 
            this.txtMr.Location = new System.Drawing.Point(71, 59);
            this.txtMr.Name = "txtMr";
            this.txtMr.Size = new System.Drawing.Size(113, 20);
            this.txtMr.TabIndex = 2;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(71, 33);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(100, 20);
            this.txtSerialNo.TabIndex = 0;
            this.txtSerialNo.Leave += new System.EventHandler(this.txtSerialNo_Leave);
            this.txtSerialNo.TextChanged += new System.EventHandler(this.txtSerialNo_TextChanged);
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(12, 36);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(53, 13);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "Serial No.";
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.Location = new System.Drawing.Point(12, 62);
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
            this.Date,
            this.Day,
            this.FTime,
            this.To,
            this.Remarks,
            this.ReasonCancel,
            this.ID});
            this.dgvHallBooking.Location = new System.Drawing.Point(15, 85);
            this.dgvHallBooking.MultiSelect = false;
            this.dgvHallBooking.Name = "dgvHallBooking";
            this.dgvHallBooking.RowHeadersWidth = 25;
            this.dgvHallBooking.Size = new System.Drawing.Size(947, 289);
            this.dgvHallBooking.TabIndex = 6;
            this.dgvHallBooking.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvHallBooking_UserAddedRow);
            this.dgvHallBooking.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvHallBooking_UserDeletingRow);
            this.dgvHallBooking.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallBooking_CellLeave);
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
            "10-AM",
            "11-AM",
            "12-PM",
            "01-PM",
            "02-PM",
            "03-PM",
            "04-PM",
            "05-PM",
            "06-PM",
            "07-PM",
            "08-PM",
            "09-PM",
            "10-PM",
            "11-PM",
            "12-AM"});
            this.FTime.Name = "FTime";
            this.FTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FTime.Width = 60;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.Items.AddRange(new object[] {
            "10-AM",
            "11-AM",
            "12-PM",
            "01-PM",
            "02-PM",
            "03-PM",
            "04-PM",
            "05-PM",
            "06-PM",
            "07-PM",
            "08-PM",
            "09-PM",
            "10-PM",
            "11-PM",
            "12-AM"});
            this.To.Name = "To";
            this.To.Width = 60;
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
            this.btnClose.Location = new System.Drawing.Point(887, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(887, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(806, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(177, 409);
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
            this.comboBox1.Location = new System.Drawing.Point(41, 107);
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
            this.btnCloseView.Location = new System.Drawing.Point(177, 409);
            this.btnCloseView.Name = "btnCloseView";
            this.btnCloseView.Size = new System.Drawing.Size(75, 23);
            this.btnCloseView.TabIndex = 12;
            this.btnCloseView.Text = "&Close";
            this.btnCloseView.UseVisualStyleBackColor = true;
            this.btnCloseView.Visible = false;
            this.btnCloseView.Click += new System.EventHandler(this.btnCloseView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 409);
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
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpSearchDate);
            this.groupBox1.Location = new System.Drawing.Point(762, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Event";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(119, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
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
            this.dtpSearchDate.Size = new System.Drawing.Size(103, 20);
            this.dtpSearchDate.TabIndex = 0;
            this.dtpSearchDate.TabStop = false;
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.dataGridView1);
            this.grbSearch.Location = new System.Drawing.Point(12, 27);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(955, 376);
            this.grbSearch.TabIndex = 123;
            this.grbSearch.TabStop = false;
            this.grbSearch.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.Dated,
            this.BookedBy,
            this.Events,
            this.Hall_1,
            this.Hall_2,
            this.Hall_3,
            this.Hall_4,
            this.From,
            this.To_});
            this.dataGridView1.Location = new System.Drawing.Point(6, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(941, 354);
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
            this.SerialNo.Width = 70;
            // 
            // Dated
            // 
            this.Dated.HeaderText = "Entry Date";
            this.Dated.Name = "Dated";
            this.Dated.ReadOnly = true;
            this.Dated.Width = 80;
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
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(448, 30);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(75, 23);
            this.btnGetName.TabIndex = 128;
            this.btnGetName.Text = "Get Name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Card No.";
            // 
            // txtFCardNo
            // 
            this.txtFCardNo.Location = new System.Drawing.Point(384, 32);
            this.txtFCardNo.Name = "txtFCardNo";
            this.txtFCardNo.Size = new System.Drawing.Size(58, 20);
            this.txtFCardNo.TabIndex = 127;
            this.txtFCardNo.Leave += new System.EventHandler(this.txtFCardNo_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 409);
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
            this.txtAmount.Location = new System.Drawing.Point(89, 380);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(144, 20);
            this.txtAmount.TabIndex = 7;
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
            this.btnPrint.Location = new System.Drawing.Point(258, 409);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 22;
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
            this.cmbAccount.Location = new System.Drawing.Point(289, 380);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(151, 21);
            this.cmbAccount.TabIndex = 8;
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
            this.label5.Location = new System.Drawing.Point(236, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 383);
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
            this.label6.Location = new System.Drawing.Point(530, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Contact No:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(604, 61);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(113, 20);
            this.txtContactNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Father Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(265, 61);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(113, 20);
            this.txtFName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 64);
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
            this.cmbOrakh.Location = new System.Drawing.Point(426, 61);
            this.cmbOrakh.Name = "cmbOrakh";
            this.cmbOrakh.Size = new System.Drawing.Size(98, 21);
            this.cmbOrakh.TabIndex = 4;
            this.cmbOrakh.ValueMember = "ID";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(373, 389);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 125;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(441, 181);
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
            // frmHallBoking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetName);
            this.Controls.Add(this.btnCloseView);
            this.Controls.Add(this.txtFCardNo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrakh);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMr);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.txtMr);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvHallBooking);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
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
            this.grbSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspHallBookingSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrakh;
        private System.Windows.Forms.DataGridViewComboBoxColumn Event;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewComboBoxColumn FTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dated;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Events;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hall_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_;
        private System.Windows.Forms.BindingSource tblHallAccBindingSource;
        private MCKJ.dataset2TableAdapters.tblHallAccTableAdapter tblHallAccTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFCardNo;
        private System.Windows.Forms.Button btnGetName;
        // private System.Windows.Forms.DataGridViewTextBoxColumn Day;
    }
}