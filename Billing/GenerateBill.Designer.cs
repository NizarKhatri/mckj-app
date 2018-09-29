namespace MCKJ.Billing
{
    partial class frmGenerateBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateBill));
            this.gbBiller = new System.Windows.Forms.GroupBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.lblCellNo = new System.Windows.Forms.Label();
            this.txtOrakh = new System.Windows.Forms.TextBox();
            this.lblOrakh = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.gbCoffin = new System.Windows.Forms.GroupBox();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.dtpTimeOfDeath = new System.Windows.Forms.DateTimePicker();
            this.lblTimeOfDeath = new System.Windows.Forms.Label();
            this.txtDeceasedAge = new System.Windows.Forms.TextBox();
            this.lblDeceasedAge = new System.Windows.Forms.Label();
            this.txtReasonOfDeath = new System.Windows.Forms.TextBox();
            this.lblReasonOfDeath = new System.Windows.Forms.Label();
            this.txtApplicantPhone = new System.Windows.Forms.TextBox();
            this.lblApplicantPhone = new System.Windows.Forms.Label();
            this.txtRelName = new System.Windows.Forms.TextBox();
            this.txtDeceasedOrakh = new System.Windows.Forms.TextBox();
            this.lblRelName = new System.Windows.Forms.Label();
            this.lblDeceasedOrakh = new System.Windows.Forms.Label();
            this.txtDeceasedName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.txtTransaction = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvItemOptions = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.hdnBillId = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.dgBillSummary = new System.Windows.Forms.DataGridView();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.txtSlipNo = new System.Windows.Forms.TextBox();
            this.lblSlipNo = new System.Windows.Forms.Label();
            this.lblAdvDate = new System.Windows.Forms.Label();
            this.txtAdvDated = new System.Windows.Forms.TextBox();
            this.lblAdvAmount = new System.Windows.Forms.Label();
            this.txtAdvAmount = new System.Windows.Forms.TextBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.dataset3 = new MCKJ.dataset3();
            this.dataset2 = new MCKJ.dataset2();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEventsTableAdapter = new MCKJ.dataset2TableAdapters.tblEventsTableAdapter();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtPriceTotal = new System.Windows.Forms.TextBox();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbAdvance = new System.Windows.Forms.GroupBox();
            this.chkLease = new System.Windows.Forms.CheckBox();
            this.txtLease = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbBiller.SuspendLayout();
            this.gbCoffin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBillSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2BindingSource)).BeginInit();
            this.gbItem.SuspendLayout();
            this.gbAdvance.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBiller
            // 
            this.gbBiller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBiller.Controls.Add(this.txtCardNo);
            this.gbBiller.Controls.Add(this.lblName);
            this.gbBiller.Controls.Add(this.txtFatherName);
            this.gbBiller.Controls.Add(this.lblFatherName);
            this.gbBiller.Controls.Add(this.txtAddress);
            this.gbBiller.Controls.Add(this.lblAddress);
            this.gbBiller.Controls.Add(this.txtCellNo);
            this.gbBiller.Controls.Add(this.lblCellNo);
            this.gbBiller.Controls.Add(this.txtOrakh);
            this.gbBiller.Controls.Add(this.lblOrakh);
            this.gbBiller.Controls.Add(this.txtName);
            this.gbBiller.Controls.Add(this.lblCardNo);
            this.gbBiller.Location = new System.Drawing.Point(12, 196);
            this.gbBiller.Name = "gbBiller";
            this.gbBiller.Size = new System.Drawing.Size(240, 88);
            this.gbBiller.TabIndex = 1;
            this.gbBiller.TabStop = false;
            this.gbBiller.Text = "Biller Information";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(64, 26);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(100, 20);
            this.txtCardNo.TabIndex = 2;
            this.txtCardNo.Leave += new System.EventHandler(this.txtCardNo_Leave_1);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(183, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(597, 26);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(215, 20);
            this.txtFatherName.TabIndex = 4;
            // 
            // lblFatherName
            // 
            this.lblFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(521, 29);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(68, 13);
            this.lblFatherName.TabIndex = 11;
            this.lblFatherName.Text = "Father Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(423, 56);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(389, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(372, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // txtCellNo
            // 
            this.txtCellNo.Location = new System.Drawing.Point(232, 56);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(128, 20);
            this.txtCellNo.TabIndex = 6;
            // 
            // lblCellNo
            // 
            this.lblCellNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCellNo.AutoSize = true;
            this.lblCellNo.Location = new System.Drawing.Point(183, 60);
            this.lblCellNo.Name = "lblCellNo";
            this.lblCellNo.Size = new System.Drawing.Size(41, 13);
            this.lblCellNo.TabIndex = 8;
            this.lblCellNo.Text = "Cell No";
            // 
            // txtOrakh
            // 
            this.txtOrakh.Location = new System.Drawing.Point(64, 60);
            this.txtOrakh.Name = "txtOrakh";
            this.txtOrakh.Size = new System.Drawing.Size(100, 20);
            this.txtOrakh.TabIndex = 5;
            // 
            // lblOrakh
            // 
            this.lblOrakh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrakh.AutoSize = true;
            this.lblOrakh.Location = new System.Drawing.Point(13, 63);
            this.lblOrakh.Name = "lblOrakh";
            this.lblOrakh.Size = new System.Drawing.Size(36, 13);
            this.lblOrakh.TabIndex = 4;
            this.lblOrakh.Text = "Orakh";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(13, 29);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(46, 13);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "Card No";
            // 
            // gbCoffin
            // 
            this.gbCoffin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCoffin.Controls.Add(this.txtApplicantName);
            this.gbCoffin.Controls.Add(this.lblApplicantName);
            this.gbCoffin.Controls.Add(this.dtpTimeOfDeath);
            this.gbCoffin.Controls.Add(this.lblTimeOfDeath);
            this.gbCoffin.Controls.Add(this.txtDeceasedAge);
            this.gbCoffin.Controls.Add(this.lblDeceasedAge);
            this.gbCoffin.Controls.Add(this.txtReasonOfDeath);
            this.gbCoffin.Controls.Add(this.lblReasonOfDeath);
            this.gbCoffin.Controls.Add(this.txtApplicantPhone);
            this.gbCoffin.Controls.Add(this.lblApplicantPhone);
            this.gbCoffin.Controls.Add(this.txtRelName);
            this.gbCoffin.Controls.Add(this.txtDeceasedOrakh);
            this.gbCoffin.Controls.Add(this.lblRelName);
            this.gbCoffin.Controls.Add(this.lblDeceasedOrakh);
            this.gbCoffin.Controls.Add(this.txtDeceasedName);
            this.gbCoffin.Controls.Add(this.label5);
            this.gbCoffin.Location = new System.Drawing.Point(12, 196);
            this.gbCoffin.Name = "gbCoffin";
            this.gbCoffin.Size = new System.Drawing.Size(240, 100);
            this.gbCoffin.TabIndex = 2;
            this.gbCoffin.TabStop = false;
            this.gbCoffin.Text = "Biller Information";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(105, 71);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.Size = new System.Drawing.Size(511, 20);
            this.txtApplicantName.TabIndex = 8;
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Location = new System.Drawing.Point(17, 75);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(82, 13);
            this.lblApplicantName.TabIndex = 15;
            this.lblApplicantName.Text = "Applicant Name";
            // 
            // dtpTimeOfDeath
            // 
            this.dtpTimeOfDeath.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeOfDeath.Location = new System.Drawing.Point(673, 43);
            this.dtpTimeOfDeath.Name = "dtpTimeOfDeath";
            this.dtpTimeOfDeath.Size = new System.Drawing.Size(135, 20);
            this.dtpTimeOfDeath.TabIndex = 7;
            // 
            // lblTimeOfDeath
            // 
            this.lblTimeOfDeath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOfDeath.AutoSize = true;
            this.lblTimeOfDeath.Location = new System.Drawing.Point(595, 47);
            this.lblTimeOfDeath.Name = "lblTimeOfDeath";
            this.lblTimeOfDeath.Size = new System.Drawing.Size(74, 13);
            this.lblTimeOfDeath.TabIndex = 13;
            this.lblTimeOfDeath.Text = "Time of Death";
            // 
            // txtDeceasedAge
            // 
            this.txtDeceasedAge.Location = new System.Drawing.Point(62, 44);
            this.txtDeceasedAge.Name = "txtDeceasedAge";
            this.txtDeceasedAge.Size = new System.Drawing.Size(51, 20);
            this.txtDeceasedAge.TabIndex = 5;
            // 
            // lblDeceasedAge
            // 
            this.lblDeceasedAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeceasedAge.AutoSize = true;
            this.lblDeceasedAge.Location = new System.Drawing.Point(17, 47);
            this.lblDeceasedAge.Name = "lblDeceasedAge";
            this.lblDeceasedAge.Size = new System.Drawing.Size(26, 13);
            this.lblDeceasedAge.TabIndex = 12;
            this.lblDeceasedAge.Text = "Age";
            // 
            // txtReasonOfDeath
            // 
            this.txtReasonOfDeath.Location = new System.Drawing.Point(217, 43);
            this.txtReasonOfDeath.Name = "txtReasonOfDeath";
            this.txtReasonOfDeath.Size = new System.Drawing.Size(372, 20);
            this.txtReasonOfDeath.TabIndex = 6;
            // 
            // lblReasonOfDeath
            // 
            this.lblReasonOfDeath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReasonOfDeath.AutoSize = true;
            this.lblReasonOfDeath.Location = new System.Drawing.Point(123, 47);
            this.lblReasonOfDeath.Name = "lblReasonOfDeath";
            this.lblReasonOfDeath.Size = new System.Drawing.Size(88, 13);
            this.lblReasonOfDeath.TabIndex = 10;
            this.lblReasonOfDeath.Text = "Reason of Death";
            // 
            // txtApplicantPhone
            // 
            this.txtApplicantPhone.Location = new System.Drawing.Point(685, 71);
            this.txtApplicantPhone.Name = "txtApplicantPhone";
            this.txtApplicantPhone.Size = new System.Drawing.Size(128, 20);
            this.txtApplicantPhone.TabIndex = 9;
            // 
            // lblApplicantPhone
            // 
            this.lblApplicantPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicantPhone.AutoSize = true;
            this.lblApplicantPhone.Location = new System.Drawing.Point(636, 75);
            this.lblApplicantPhone.Name = "lblApplicantPhone";
            this.lblApplicantPhone.Size = new System.Drawing.Size(41, 13);
            this.lblApplicantPhone.TabIndex = 8;
            this.lblApplicantPhone.Text = "Cell No";
            // 
            // txtRelName
            // 
            this.txtRelName.Location = new System.Drawing.Point(439, 16);
            this.txtRelName.Name = "txtRelName";
            this.txtRelName.Size = new System.Drawing.Size(191, 20);
            this.txtRelName.TabIndex = 3;
            // 
            // txtDeceasedOrakh
            // 
            this.txtDeceasedOrakh.Location = new System.Drawing.Point(673, 15);
            this.txtDeceasedOrakh.Name = "txtDeceasedOrakh";
            this.txtDeceasedOrakh.Size = new System.Drawing.Size(137, 20);
            this.txtDeceasedOrakh.TabIndex = 4;
            // 
            // lblRelName
            // 
            this.lblRelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelName.AutoSize = true;
            this.lblRelName.Location = new System.Drawing.Point(349, 19);
            this.lblRelName.Name = "lblRelName";
            this.lblRelName.Size = new System.Drawing.Size(90, 13);
            this.lblRelName.TabIndex = 6;
            this.lblRelName.Text = "S/O - W/O - D/O";
            // 
            // lblDeceasedOrakh
            // 
            this.lblDeceasedOrakh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeceasedOrakh.AutoSize = true;
            this.lblDeceasedOrakh.Location = new System.Drawing.Point(633, 19);
            this.lblDeceasedOrakh.Name = "lblDeceasedOrakh";
            this.lblDeceasedOrakh.Size = new System.Drawing.Size(36, 13);
            this.lblDeceasedOrakh.TabIndex = 4;
            this.lblDeceasedOrakh.Text = "Orakh";
            // 
            // txtDeceasedName
            // 
            this.txtDeceasedName.Location = new System.Drawing.Point(107, 16);
            this.txtDeceasedName.Name = "txtDeceasedName";
            this.txtDeceasedName.Size = new System.Drawing.Size(237, 20);
            this.txtDeceasedName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Deceased Name";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSubHeading);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 85);
            this.panel1.TabIndex = 1;
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.Location = new System.Drawing.Point(4, 43);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(805, 23);
            this.lblSubHeading.TabIndex = 1;
            this.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(117, 6);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(584, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Musalman Cutchi Khatri Jamat Karachi";
            // 
            // lblTransaction
            // 
            this.lblTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(16, 162);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(80, 13);
            this.lblTransaction.TabIndex = 8;
            this.lblTransaction.Text = "Transaction No";
            // 
            // txtTransaction
            // 
            this.txtTransaction.Location = new System.Drawing.Point(102, 159);
            this.txtTransaction.Name = "txtTransaction";
            this.txtTransaction.ReadOnly = true;
            this.txtTransaction.Size = new System.Drawing.Size(151, 20);
            this.txtTransaction.TabIndex = 0;
            this.txtTransaction.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(588, 162);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(624, 159);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // dgvItemOptions
            // 
            this.dgvItemOptions.AllowUserToAddRows = false;
            this.dgvItemOptions.ColumnHeadersHeight = 28;
            this.dgvItemOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.ItemCode,
            this.OptionText,
            this.Quantity,
            this.PricePerPiece,
            this.Total,
            this.Remove});
            this.dgvItemOptions.Location = new System.Drawing.Point(10, 363);
            this.dgvItemOptions.Name = "dgvItemOptions";
            this.dgvItemOptions.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemOptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemOptions.RowHeadersVisible = false;
            this.dgvItemOptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItemOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemOptions.Size = new System.Drawing.Size(817, 323);
            this.dgvItemOptions.TabIndex = 11;
            this.dgvItemOptions.TabStop = false;
            this.dgvItemOptions.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvItemOptions_SortCompare);
            this.dgvItemOptions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemOptions_CellDoubleClick);
            this.dgvItemOptions.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvItemOptions_RowsRemoved);
            this.dgvItemOptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemOptions_CellContentClick);
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "Serial No";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 63;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // OptionText
            // 
            this.OptionText.HeaderText = "Item Description";
            this.OptionText.Name = "OptionText";
            this.OptionText.ReadOnly = true;
            this.OptionText.Width = 260;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PricePerPiece
            // 
            this.PricePerPiece.HeaderText = "Price";
            this.PricePerPiece.Name = "PricePerPiece";
            this.PricePerPiece.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 113;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Width = 60;
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItems.Location = new System.Drawing.Point(330, 692);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(100, 22);
            this.txtTotalItems.TabIndex = 12;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(248, 695);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(83, 16);
            this.lblTotalItems.TabIndex = 13;
            this.lblTotalItems.Text = "No of Item(s)";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQuantity.Location = new System.Drawing.Point(536, 692);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtTotalQuantity.TabIndex = 14;
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(442, 695);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(90, 16);
            this.lblTotalQuantity.TabIndex = 15;
            this.lblTotalQuantity.Text = "Total Quantity";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(725, 692);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(100, 22);
            this.txtGrandTotal.TabIndex = 16;
            this.txtGrandTotal.TextChanged += new System.EventHandler(this.txtGrandTotal_TextChanged);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(644, 695);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(79, 16);
            this.lblGrandTotal.TabIndex = 17;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.hdnBillId);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(-2, 785);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 36);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // hdnBillId
            // 
            this.hdnBillId.Location = new System.Drawing.Point(362, 9);
            this.hdnBillId.Name = "hdnBillId";
            this.hdnBillId.Size = new System.Drawing.Size(36, 20);
            this.hdnBillId.TabIndex = 6;
            this.hdnBillId.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(496, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(577, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(87, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(658, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(739, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(323, 159);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(78, 20);
            this.txtRegNo.TabIndex = 9999;
            this.txtRegNo.TabStop = false;
            this.txtRegNo.Leave += new System.EventHandler(this.txtRegNo_Leave);
            // 
            // lblRegNo
            // 
            this.lblRegNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(271, 162);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(44, 13);
            this.lblRegNo.TabIndex = 20;
            this.lblRegNo.Text = "Reg No";
            // 
            // dgBillSummary
            // 
            this.dgBillSummary.AllowUserToAddRows = false;
            this.dgBillSummary.AllowUserToDeleteRows = false;
            this.dgBillSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBillSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBillSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId,
            this.TransactionNo,
            this.CardNo,
            this.MemberName,
            this.RelativeName,
            this.Orakh,
            this.CellNo,
            this.NetAmount});
            this.dgBillSummary.Location = new System.Drawing.Point(9, 159);
            this.dgBillSummary.Name = "dgBillSummary";
            this.dgBillSummary.ReadOnly = true;
            this.dgBillSummary.RowHeadersVisible = false;
            this.dgBillSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBillSummary.Size = new System.Drawing.Size(588, 618);
            this.dgBillSummary.TabIndex = 21;
            this.dgBillSummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBillSummary_CellClick);
            // 
            // BillId
            // 
            this.BillId.DataPropertyName = "BillId";
            this.BillId.HeaderText = "Serial No";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            this.BillId.Width = 73;
            // 
            // TransactionNo
            // 
            this.TransactionNo.DataPropertyName = "TransactionNo";
            this.TransactionNo.HeaderText = "Transaction No";
            this.TransactionNo.Name = "TransactionNo";
            this.TransactionNo.ReadOnly = true;
            this.TransactionNo.Width = 130;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "FCard No";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.DataPropertyName = "MemberName";
            this.MemberName.HeaderText = "Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.Width = 215;
            // 
            // RelativeName
            // 
            this.RelativeName.DataPropertyName = "RelativeName";
            this.RelativeName.HeaderText = "Relative Name";
            this.RelativeName.Name = "RelativeName";
            this.RelativeName.ReadOnly = true;
            // 
            // Orakh
            // 
            this.Orakh.DataPropertyName = "Orakh";
            this.Orakh.HeaderText = "Orakh";
            this.Orakh.Name = "Orakh";
            this.Orakh.ReadOnly = true;
            // 
            // CellNo
            // 
            this.CellNo.DataPropertyName = "CellNo";
            this.CellNo.HeaderText = "Cell No";
            this.CellNo.Name = "CellNo";
            this.CellNo.ReadOnly = true;
            // 
            // NetAmount
            // 
            this.NetAmount.DataPropertyName = "NetAmount";
            this.NetAmount.HeaderText = "Net Amount";
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.ReadOnly = true;
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.Location = new System.Drawing.Point(9, 16);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(140, 16);
            this.lblAdvance.TabIndex = 10000;
            this.lblAdvance.Text = "Advance Received";
            // 
            // txtSlipNo
            // 
            this.txtSlipNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlipNo.Location = new System.Drawing.Point(270, 14);
            this.txtSlipNo.Name = "txtSlipNo";
            this.txtSlipNo.Size = new System.Drawing.Size(100, 22);
            this.txtSlipNo.TabIndex = 10001;
            this.txtSlipNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlipNo_KeyPress);
            // 
            // lblSlipNo
            // 
            this.lblSlipNo.AutoSize = true;
            this.lblSlipNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlipNo.Location = new System.Drawing.Point(212, 17);
            this.lblSlipNo.Name = "lblSlipNo";
            this.lblSlipNo.Size = new System.Drawing.Size(59, 16);
            this.lblSlipNo.TabIndex = 10002;
            this.lblSlipNo.Text = "Slip No";
            // 
            // lblAdvDate
            // 
            this.lblAdvDate.AutoSize = true;
            this.lblAdvDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvDate.Location = new System.Drawing.Point(424, 17);
            this.lblAdvDate.Name = "lblAdvDate";
            this.lblAdvDate.Size = new System.Drawing.Size(54, 16);
            this.lblAdvDate.TabIndex = 10003;
            this.lblAdvDate.Text = "Dated:";
            // 
            // txtAdvDated
            // 
            this.txtAdvDated.Enabled = false;
            this.txtAdvDated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvDated.Location = new System.Drawing.Point(476, 14);
            this.txtAdvDated.Name = "txtAdvDated";
            this.txtAdvDated.Size = new System.Drawing.Size(100, 22);
            this.txtAdvDated.TabIndex = 10004;
            // 
            // lblAdvAmount
            // 
            this.lblAdvAmount.AutoSize = true;
            this.lblAdvAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvAmount.Location = new System.Drawing.Point(603, 17);
            this.lblAdvAmount.Name = "lblAdvAmount";
            this.lblAdvAmount.Size = new System.Drawing.Size(59, 16);
            this.lblAdvAmount.TabIndex = 10005;
            this.lblAdvAmount.Text = "Amount";
            // 
            // txtAdvAmount
            // 
            this.txtAdvAmount.Enabled = false;
            this.txtAdvAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvAmount.Location = new System.Drawing.Point(665, 14);
            this.txtAdvAmount.Name = "txtAdvAmount";
            this.txtAdvAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAdvAmount.TabIndex = 10006;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.Location = new System.Drawing.Point(574, 48);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(87, 16);
            this.lblNetAmount.TabIndex = 10007;
            this.lblNetAmount.Text = "Net Amount";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Enabled = false;
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.Location = new System.Drawing.Point(665, 43);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(100, 22);
            this.txtNetAmount.TabIndex = 10008;
            // 
            // dataset3
            // 
            this.dataset3.DataSetName = "dataset3";
            this.dataset3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataset2
            // 
            this.dataset2.DataSetName = "dataset2";
            this.dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEventsBindingSource
            // 
            this.tblEventsBindingSource.DataMember = "tblEvents";
            this.tblEventsBindingSource.DataSource = this.dataset2BindingSource;
            // 
            // dataset2BindingSource
            // 
            this.dataset2BindingSource.DataSource = this.dataset2;
            this.dataset2BindingSource.Position = 0;
            // 
            // tblEventsTableAdapter
            // 
            this.tblEventsTableAdapter.ClearBeforeFill = true;
            // 
            // lblEvent
            // 
            this.lblEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(421, 162);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(35, 13);
            this.lblEvent.TabIndex = 10010;
            this.lblEvent.Text = "Event";
            // 
            // cmbEvent
            // 
            this.cmbEvent.DataSource = this.tblEventsBindingSource;
            this.cmbEvent.DisplayMember = "Events";
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(461, 159);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(121, 21);
            this.cmbEvent.TabIndex = 10011;
            this.cmbEvent.ValueMember = "ID";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(141, 25);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(68, 15);
            this.lblItemName.TabIndex = 8;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(5, 26);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(63, 15);
            this.lblItemCode.TabIndex = 7;
            this.lblItemCode.Text = "Item Code";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(609, 26);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(71, 24);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(68, 23);
            this.txtItemCode.TabIndex = 7;
            this.txtItemCode.TabStop = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(508, 26);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbItemName
            // 
            this.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(211, 23);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(293, 23);
            this.cmbItemName.TabIndex = 10;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(648, 23);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(50, 23);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(562, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(44, 23);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(700, 26);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(34, 15);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = "Total";
            // 
            // txtPriceTotal
            // 
            this.txtPriceTotal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceTotal.Location = new System.Drawing.Point(736, 23);
            this.txtPriceTotal.Name = "txtPriceTotal";
            this.txtPriceTotal.ReadOnly = true;
            this.txtPriceTotal.Size = new System.Drawing.Size(76, 23);
            this.txtPriceTotal.TabIndex = 11;
            this.txtPriceTotal.TabStop = false;
            // 
            // gbItem
            // 
            this.gbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbItem.Controls.Add(this.txtPriceTotal);
            this.gbItem.Controls.Add(this.lblTotalPrice);
            this.gbItem.Controls.Add(this.txtQuantity);
            this.gbItem.Controls.Add(this.txtPrice);
            this.gbItem.Controls.Add(this.cmbItemName);
            this.gbItem.Controls.Add(this.lblQuantity);
            this.gbItem.Controls.Add(this.txtItemCode);
            this.gbItem.Controls.Add(this.lblPrice);
            this.gbItem.Controls.Add(this.lblItemCode);
            this.gbItem.Controls.Add(this.lblItemName);
            this.gbItem.Location = new System.Drawing.Point(12, 297);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(240, 60);
            this.gbItem.TabIndex = 6;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Item Information";
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkIsPaid.Location = new System.Drawing.Point(161, 694);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(75, 20);
            this.chkIsPaid.TabIndex = 10012;
            this.chkIsPaid.Text = "Is Paid";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10013;
            this.label1.Text = "Search Criteria";
            // 
            // cmbCriteria
            // 
            this.cmbCriteria.FormattingEnabled = true;
            this.cmbCriteria.Location = new System.Drawing.Point(79, 24);
            this.cmbCriteria.Name = "cmbCriteria";
            this.cmbCriteria.Size = new System.Drawing.Size(121, 21);
            this.cmbCriteria.TabIndex = 10014;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10015;
            this.label2.Text = "Search Text";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(275, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 20);
            this.txtSearch.TabIndex = 10016;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(595, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 34);
            this.btnSearch.TabIndex = 10017;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbAdvance
            // 
            this.gbAdvance.Controls.Add(this.chkLease);
            this.gbAdvance.Controls.Add(this.txtLease);
            this.gbAdvance.Controls.Add(this.lblAdvance);
            this.gbAdvance.Controls.Add(this.txtSlipNo);
            this.gbAdvance.Controls.Add(this.lblSlipNo);
            this.gbAdvance.Controls.Add(this.lblAdvDate);
            this.gbAdvance.Controls.Add(this.txtAdvDated);
            this.gbAdvance.Controls.Add(this.lblAdvAmount);
            this.gbAdvance.Controls.Add(this.txtAdvAmount);
            this.gbAdvance.Controls.Add(this.lblNetAmount);
            this.gbAdvance.Controls.Add(this.txtNetAmount);
            this.gbAdvance.Location = new System.Drawing.Point(61, 713);
            this.gbAdvance.Name = "gbAdvance";
            this.gbAdvance.Size = new System.Drawing.Size(773, 70);
            this.gbAdvance.TabIndex = 10018;
            this.gbAdvance.TabStop = false;
            // 
            // chkLease
            // 
            this.chkLease.AutoSize = true;
            this.chkLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLease.Location = new System.Drawing.Point(274, 46);
            this.chkLease.Name = "chkLease";
            this.chkLease.Size = new System.Drawing.Size(195, 20);
            this.chkLease.TabIndex = 10011;
            this.chkLease.Text = "Apply Lease Fund (20%)";
            this.chkLease.UseVisualStyleBackColor = true;
            this.chkLease.CheckedChanged += new System.EventHandler(this.chkLease_CheckedChanged);
            // 
            // txtLease
            // 
            this.txtLease.Enabled = false;
            this.txtLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLease.Location = new System.Drawing.Point(475, 44);
            this.txtLease.Name = "txtLease";
            this.txtLease.Size = new System.Drawing.Size(100, 22);
            this.txtLease.TabIndex = 10009;
            this.txtLease.Text = "0";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cmbCriteria);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Location = new System.Drawing.Point(10, 93);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(633, 59);
            this.gbSearch.TabIndex = 10019;
            this.gbSearch.TabStop = false;
            // 
            // frmGenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(854, 592);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgBillSummary);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvItemOptions);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtTransaction);
            this.Controls.Add(this.gbCoffin);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.txtTotalQuantity);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.chkIsPaid);
            this.Controls.Add(this.gbBiller);
            this.Controls.Add(this.gbAdvance);
            this.Location = new System.Drawing.Point(130, 0);
            this.Name = "frmGenerateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generate Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GenerateBill_Load);
            this.gbBiller.ResumeLayout(false);
            this.gbBiller.PerformLayout();
            this.gbCoffin.ResumeLayout(false);
            this.gbCoffin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBillSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2BindingSource)).EndInit();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.gbAdvance.ResumeLayout(false);
            this.gbAdvance.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBiller;
        private System.Windows.Forms.TextBox txtOrakh;
        private System.Windows.Forms.Label lblOrakh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.TextBox txtTransaction;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.Label lblCellNo;
        private System.Windows.Forms.DataGridView dgvItemOptions;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        public System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.GroupBox gbCoffin;
        private System.Windows.Forms.TextBox txtReasonOfDeath;
        private System.Windows.Forms.Label lblReasonOfDeath;
        private System.Windows.Forms.TextBox txtApplicantPhone;
        private System.Windows.Forms.Label lblApplicantPhone;
        private System.Windows.Forms.TextBox txtRelName;
        private System.Windows.Forms.TextBox txtDeceasedOrakh;
        private System.Windows.Forms.Label lblRelName;
        private System.Windows.Forms.Label lblDeceasedOrakh;
        private System.Windows.Forms.TextBox txtDeceasedName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDeceasedAge;
        private System.Windows.Forms.Label lblDeceasedAge;
        private System.Windows.Forms.Label lblTimeOfDeath;
        private System.Windows.Forms.DateTimePicker dtpTimeOfDeath;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.DataGridView dgBillSummary;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAdvDated;
        private System.Windows.Forms.Label lblAdvDate;
        private System.Windows.Forms.Label lblSlipNo;
        private System.Windows.Forms.TextBox txtSlipNo;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtAdvAmount;
        private System.Windows.Forms.Label lblAdvAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox hdnBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private dataset2 dataset2;
        private dataset3 dataset3;
        private System.Windows.Forms.BindingSource dataset2BindingSource;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private MCKJ.dataset2TableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.TextBox txtPriceTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.CheckBox chkIsPaid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmount;
        private System.Windows.Forms.GroupBox gbAdvance;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtLease;
        private System.Windows.Forms.CheckBox chkLease;
    }
}