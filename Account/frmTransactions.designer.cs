namespace MCKJ
{
    partial class frmTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.lblDocumentNo = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.AccountCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.Narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCloseView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.tblVouchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.voucherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdits = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tblTransactionsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblTransactionsTableAdapter();
            this.tblAccountsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter();
            this.tblVouchersTableAdapter = new MCKJ.ComDataSetTableAdapters.tblVouchersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblVouchersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(85, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(82, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Dated";
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(152, 43);
            this.txtDocumentNo.MaxLength = 5;
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Size = new System.Drawing.Size(54, 20);
            this.txtDocumentNo.TabIndex = 1;
            this.txtDocumentNo.Leave += new System.EventHandler(this.txtSerialNo_Leave);
            // 
            // lblDocumentNo
            // 
            this.lblDocumentNo.AutoSize = true;
            this.lblDocumentNo.Location = new System.Drawing.Point(12, 46);
            this.lblDocumentNo.Name = "lblDocumentNo";
            this.lblDocumentNo.Size = new System.Drawing.Size(67, 13);
            this.lblDocumentNo.TabIndex = 4;
            this.lblDocumentNo.Text = "Voucher No:";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountCode,
            this.Narration,
            this.ChequeNo,
            this.Refrence,
            this.Debit,
            this.Credit,
            this.ID});
            this.dgvTransactions.Location = new System.Drawing.Point(15, 95);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 25;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(702, 264);
            this.dgvTransactions.TabIndex = 3;
            this.dgvTransactions.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvHallBooking_UserDeletingRow);
            this.dgvTransactions.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellLeave);
            // 
            // AccountCode
            // 
            this.AccountCode.DataSource = this.tblAccountsBindingSource;
            this.AccountCode.DisplayMember = "AccountName";
            this.AccountCode.HeaderText = "Account Name";
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AccountCode.ValueMember = "ID";
            this.AccountCode.Width = 150;
            // 
            // tblAccountsBindingSource
            // 
            this.tblAccountsBindingSource.DataMember = "tblAccounts";
            this.tblAccountsBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Narration
            // 
            this.Narration.HeaderText = "Narration";
            this.Narration.Name = "Narration";
            this.Narration.Width = 150;
            // 
            // ChequeNo
            // 
            this.ChequeNo.HeaderText = "Cheque No";
            this.ChequeNo.Name = "ChequeNo";
            this.ChequeNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChequeNo.Width = 75;
            // 
            // Refrence
            // 
            this.Refrence.HeaderText = "Refrence";
            this.Refrence.Name = "Refrence";
            // 
            // Debit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Debit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            // 
            // Credit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.Credit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
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
            this.btnClose.Location = new System.Drawing.Point(644, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(642, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(15, 393);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCloseView
            // 
            this.btnCloseView.Location = new System.Drawing.Point(15, 393);
            this.btnCloseView.Name = "btnCloseView";
            this.btnCloseView.Size = new System.Drawing.Size(75, 23);
            this.btnCloseView.TabIndex = 7;
            this.btnCloseView.Text = "&Back";
            this.btnCloseView.UseVisualStyleBackColor = true;
            this.btnCloseView.Visible = false;
            this.btnCloseView.Click += new System.EventHandler(this.btnCloseView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 393);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpSearchDate);
            this.groupBox1.Location = new System.Drawing.Point(517, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Transaction";
            this.groupBox1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(119, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
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
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.DataSource = this.tblVouchersBindingSource;
            this.cmbVoucherType.DisplayMember = "Voucher";
            this.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Location = new System.Drawing.Point(85, 42);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(61, 21);
            this.cmbVoucherType.TabIndex = 0;
            this.cmbVoucherType.SelectedIndexChanged += new System.EventHandler(this.cmbVoucherType_SelectedIndexChanged);
            // 
            // tblVouchersBindingSource
            // 
            this.tblVouchersBindingSource.DataMember = "tblVouchers";
            this.tblVouchersBindingSource.DataSource = this.comDataSet;
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.AllowUserToDeleteRows = false;
            this.dgvVouchers.AutoGenerateColumns = false;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucherDataGridViewTextBoxColumn,
            this.documentNoDataGridViewTextBoxColumn,
            this.Voucher,
            this.accountNameDataGridViewTextBoxColumn,
            this.datedDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.chequeNoDataGridViewTextBoxColumn,
            this.referenceNoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.iDDataGridViewTextBoxColumn});
            this.dgvVouchers.DataSource = this.tblTransactionsBindingSource;
            this.dgvVouchers.Location = new System.Drawing.Point(15, 42);
            this.dgvVouchers.MultiSelect = false;
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersWidth = 25;
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(702, 376);
            this.dgvVouchers.StandardTab = true;
            this.dgvVouchers.TabIndex = 17;
            this.dgvVouchers.Visible = false;
            this.dgvVouchers.Sorted += new System.EventHandler(this.dgvVouchers_Sorted);
            // 
            // voucherDataGridViewTextBoxColumn
            // 
            this.voucherDataGridViewTextBoxColumn.DataPropertyName = "Voucher";
            this.voucherDataGridViewTextBoxColumn.HeaderText = "Voucher";
            this.voucherDataGridViewTextBoxColumn.Name = "voucherDataGridViewTextBoxColumn";
            this.voucherDataGridViewTextBoxColumn.ReadOnly = true;
            this.voucherDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentNoDataGridViewTextBoxColumn
            // 
            this.documentNoDataGridViewTextBoxColumn.DataPropertyName = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.HeaderText = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.Name = "documentNoDataGridViewTextBoxColumn";
            this.documentNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // Voucher
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Voucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.Voucher.HeaderText = "Voucher No";
            this.Voucher.Name = "Voucher";
            this.Voucher.ReadOnly = true;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // datedDataGridViewTextBoxColumn
            // 
            this.datedDataGridViewTextBoxColumn.DataPropertyName = "Dated";
            this.datedDataGridViewTextBoxColumn.HeaderText = "Dated";
            this.datedDataGridViewTextBoxColumn.Name = "datedDataGridViewTextBoxColumn";
            this.datedDataGridViewTextBoxColumn.ReadOnly = true;
            this.datedDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Narration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "ChequeNo";
            this.chequeNoDataGridViewTextBoxColumn.HeaderText = "Cheque";
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            this.chequeNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.chequeNoDataGridViewTextBoxColumn.Width = 70;
            // 
            // referenceNoDataGridViewTextBoxColumn
            // 
            this.referenceNoDataGridViewTextBoxColumn.DataPropertyName = "ReferenceNo";
            this.referenceNoDataGridViewTextBoxColumn.HeaderText = "ReferenceNo";
            this.referenceNoDataGridViewTextBoxColumn.Name = "referenceNoDataGridViewTextBoxColumn";
            this.referenceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Debit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Credit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblTransactionsBindingSource
            // 
            this.tblTransactionsBindingSource.DataMember = "tblTransactions";
            this.tblTransactionsBindingSource.DataSource = this.comDataSet;
            // 
            // btnEdits
            // 
            this.btnEdits.Location = new System.Drawing.Point(96, 424);
            this.btnEdits.Name = "btnEdits";
            this.btnEdits.Size = new System.Drawing.Size(75, 23);
            this.btnEdits.TabIndex = 10;
            this.btnEdits.Text = "&Modify";
            this.btnEdits.UseVisualStyleBackColor = true;
            this.btnEdits.Click += new System.EventHandler(this.btnSearchLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 424);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnSearchClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Voucher No:";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Info;
            this.txtFilter.Location = new System.Drawing.Point(85, 9);
            this.txtFilter.MaxLength = 5;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 19;
            this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(369, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total Debit:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(546, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Credit:";
            this.label3.Visible = false;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(617, 363);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 20);
            this.txtCredit.TabIndex = 22;
            this.txtCredit.Text = "0.00";
            this.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCredit.Visible = false;
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(440, 363);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(100, 20);
            this.txtDebit.TabIndex = 23;
            this.txtDebit.Text = "0.00";
            this.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDebit.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVouchersBindingSource, "Description", true));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(212, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 18);
            this.textBox1.TabIndex = 24;
            this.textBox1.TabStop = false;
            // 
            // tblTransactionsTableAdapter
            // 
            this.tblTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tblAccountsTableAdapter
            // 
            this.tblAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // tblVouchersTableAdapter
            // 
            this.tblVouchersTableAdapter.ClearBeforeFill = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 459);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDebit);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdits);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDocumentNo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.cmbVoucherType);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.btnCloseView);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvVouchers);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muslaman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmHallBoking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblVouchersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Label lblDocumentNo;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCloseView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.Button btnEdits;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.TextBox textBox1;
        private MCKJ.ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource tblTransactionsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblTransactionsTableAdapter tblTransactionsTableAdapter;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter tblAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Narration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.BindingSource tblVouchersBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblVouchersTableAdapter tblVouchersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}