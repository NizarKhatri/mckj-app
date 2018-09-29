namespace MCKJ.Members
{
    partial class frmNIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNIC));
            this.lbl = new System.Windows.Forms.Label();
            this.dtpValidUpto = new System.Windows.Forms.DateTimePicker();
            this.tblNICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new MCKJ.dataset();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtMPath = new System.Windows.Forms.TextBox();
            this.txtOrakh = new System.Windows.Forms.TextBox();
            this.txtNukh = new System.Windows.Forms.TextBox();
            this.txtFCardNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMemberName = new System.Windows.Forms.ComboBox();
            this.uspSELtblFamilyMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnMBrowse = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbBGroup = new System.Windows.Forms.ComboBox();
            this.uspSELtblBloodGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMSPath = new System.Windows.Forms.TextBox();
            this.btnSBrowser = new System.Windows.Forms.Button();
            this.btnGSBrowser = new System.Windows.Forms.Button();
            this.txtGPath = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtCMIC = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvNIC = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNicPrinted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.pbMember = new System.Windows.Forms.Label();
            this.pbMemberSign = new System.Windows.Forms.Label();
            this.pbGsSign = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeWork = new System.Windows.Forms.ComboBox();
            this.uspSELtblWorkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.chkDuplicate = new System.Windows.Forms.CheckBox();
            this.txtFName = new System.Windows.Forms.Label();
            this.txtGFName = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.txtDuplicate = new System.Windows.Forms.TextBox();
            this.cmbDuplicate = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.usp_SEL_tblBloodGroupTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblBloodGroupTableAdapter();
            this.usp_SEL_tblFamilyMemberTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblFamilyMemberTableAdapter();
            this.usp_SEL_tblWorkTypeTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblWorkTypeTableAdapter();
            this.picBoxMemberSign = new System.Windows.Forms.PictureBox();
            this.picMemberBox = new System.Windows.Forms.PictureBox();
            this.picBoxGeneralSec = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNicSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.tblNICTableAdapter = new MCKJ.datasetTableAdapters.tblNICTableAdapter();
            this.chkIsNicPrinted = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblNICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblFamilyMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblBloodGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblWorkTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMemberSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGeneralSec)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(0, -2);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(481, 19);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Community ID Card";
            // 
            // dtpValidUpto
            // 
            this.dtpValidUpto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "ValidDate", true));
            this.dtpValidUpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidUpto.Location = new System.Drawing.Point(370, 60);
            this.dtpValidUpto.Name = "dtpValidUpto";
            this.dtpValidUpto.Size = new System.Drawing.Size(80, 20);
            this.dtpValidUpto.TabIndex = 4;
            // 
            // tblNICBindingSource
            // 
            this.tblNICBindingSource.DataMember = "tblNIC";
            this.tblNICBindingSource.DataSource = this.dataset;
            this.tblNICBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.tblNICBindingSource_BindingComplete);
            // 
            // dataset
            // 
            this.dataset.DataSetName = "dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "IssueDate", true));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(101, 60);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(80, 20);
            this.dtpIssueDate.TabIndex = 3;
            // 
            // txtMPath
            // 
            this.txtMPath.BackColor = System.Drawing.SystemColors.Info;
            this.txtMPath.Location = new System.Drawing.Point(268, 220);
            this.txtMPath.Name = "txtMPath";
            this.txtMPath.Size = new System.Drawing.Size(177, 20);
            this.txtMPath.TabIndex = 30;
            this.txtMPath.TabStop = false;
            // 
            // txtOrakh
            // 
            this.txtOrakh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "Orakh", true));
            this.txtOrakh.Location = new System.Drawing.Point(347, 86);
            this.txtOrakh.Name = "txtOrakh";
            this.txtOrakh.Size = new System.Drawing.Size(103, 20);
            this.txtOrakh.TabIndex = 11;
            this.txtOrakh.TabStop = false;
            // 
            // txtNukh
            // 
            this.txtNukh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "Nukh", true));
            this.txtNukh.Location = new System.Drawing.Point(196, 86);
            this.txtNukh.Name = "txtNukh";
            this.txtNukh.Size = new System.Drawing.Size(103, 20);
            this.txtNukh.TabIndex = 12;
            this.txtNukh.TabStop = false;
            // 
            // txtFCardNo
            // 
            this.txtFCardNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtFCardNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "FCardNo", true));
            this.txtFCardNo.Location = new System.Drawing.Point(101, 86);
            this.txtFCardNo.MaxLength = 5;
            this.txtFCardNo.Name = "txtFCardNo";
            this.txtFCardNo.Size = new System.Drawing.Size(47, 20);
            this.txtFCardNo.TabIndex = 5;
            this.txtFCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFCardNo.Leave += new System.EventHandler(this.txtFCardNo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Family Card No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Member Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Grand Father Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Father Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Orakh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nukh:";
            // 
            // cmbMemberName
            // 
            this.cmbMemberName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbMemberName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "MemberName", true));
            this.cmbMemberName.DataSource = this.uspSELtblFamilyMemberBindingSource;
            this.cmbMemberName.DisplayMember = "MemberName";
            this.cmbMemberName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberName.FormattingEnabled = true;
            this.cmbMemberName.Location = new System.Drawing.Point(129, 121);
            this.cmbMemberName.Name = "cmbMemberName";
            this.cmbMemberName.Size = new System.Drawing.Size(127, 21);
            this.cmbMemberName.TabIndex = 6;
            this.cmbMemberName.ValueMember = "FamilyMemberID";
            this.cmbMemberName.Leave += new System.EventHandler(this.cmbMemberName_Leave);
            // 
            // uspSELtblFamilyMemberBindingSource
            // 
            this.uspSELtblFamilyMemberBindingSource.DataMember = "usp_SEL_tblFamilyMember";
            this.uspSELtblFamilyMemberBindingSource.DataSource = this.comDataSet;
            this.uspSELtblFamilyMemberBindingSource.CurrentChanged += new System.EventHandler(this.uspSELtblFamilyMemberBindingSource_CurrentChanged);
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDOB
            // 
            this.dtpDOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "DOB", true));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(302, 41);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(78, 20);
            this.dtpDOB.TabIndex = 16;
            this.dtpDOB.TabStop = false;
            this.dtpDOB.Visible = false;
            // 
            // btnMBrowse
            // 
            this.btnMBrowse.Location = new System.Drawing.Point(370, 194);
            this.btnMBrowse.Name = "btnMBrowse";
            this.btnMBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMBrowse.TabIndex = 7;
            this.btnMBrowse.Text = "Browse";
            this.btnMBrowse.UseVisualStyleBackColor = true;
            this.btnMBrowse.Click += new System.EventHandler(this.btnMBrowse_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(17, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(441, 1);
            this.label10.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Issue Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Valid Upto:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(260, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 328);
            this.label13.TabIndex = 30;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(22, 223);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(70, 14);
            this.label35.TabIndex = 313;
            this.label35.Text = "Blood Group:";
            // 
            // cmbBGroup
            // 
            this.cmbBGroup.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "BloodGroup", true));
            this.cmbBGroup.DataSource = this.uspSELtblBloodGroupBindingSource;
            this.cmbBGroup.DisplayMember = "BloodGroup";
            this.cmbBGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbBGroup.FormattingEnabled = true;
            this.cmbBGroup.Location = new System.Drawing.Point(129, 222);
            this.cmbBGroup.Name = "cmbBGroup";
            this.cmbBGroup.Size = new System.Drawing.Size(127, 21);
            this.cmbBGroup.TabIndex = 8;
            this.cmbBGroup.ValueMember = "ID";
            // 
            // uspSELtblBloodGroupBindingSource
            // 
            this.uspSELtblBloodGroupBindingSource.DataMember = "usp_SEL_tblBloodGroup";
            this.uspSELtblBloodGroupBindingSource.DataSource = this.comDataSet;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(19, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(2, 328);
            this.label14.TabIndex = 314;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(456, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1, 329);
            this.label15.TabIndex = 315;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 14);
            this.label16.TabIndex = 316;
            this.label16.Text = "Phone No:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 298);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 14);
            this.label17.TabIndex = 320;
            this.label17.Text = "Address:";
            // 
            // txtMSPath
            // 
            this.txtMSPath.BackColor = System.Drawing.SystemColors.Info;
            this.txtMSPath.Location = new System.Drawing.Point(268, 294);
            this.txtMSPath.Name = "txtMSPath";
            this.txtMSPath.Size = new System.Drawing.Size(177, 20);
            this.txtMSPath.TabIndex = 322;
            this.txtMSPath.TabStop = false;
            // 
            // btnSBrowser
            // 
            this.btnSBrowser.Location = new System.Drawing.Point(370, 267);
            this.btnSBrowser.Name = "btnSBrowser";
            this.btnSBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnSBrowser.TabIndex = 9;
            this.btnSBrowser.TabStop = false;
            this.btnSBrowser.Text = "Browse";
            this.btnSBrowser.UseVisualStyleBackColor = true;
            this.btnSBrowser.Click += new System.EventHandler(this.btnSBrowser_Click);
            // 
            // btnGSBrowser
            // 
            this.btnGSBrowser.Location = new System.Drawing.Point(370, 342);
            this.btnGSBrowser.Name = "btnGSBrowser";
            this.btnGSBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnGSBrowser.TabIndex = 11;
            this.btnGSBrowser.Text = "Browse";
            this.btnGSBrowser.UseVisualStyleBackColor = true;
            this.btnGSBrowser.Click += new System.EventHandler(this.btnGSBrowser_Click);
            // 
            // txtGPath
            // 
            this.txtGPath.BackColor = System.Drawing.Color.White;
            this.txtGPath.Location = new System.Drawing.Point(268, 371);
            this.txtGPath.Name = "txtGPath";
            this.txtGPath.Size = new System.Drawing.Size(177, 20);
            this.txtGPath.TabIndex = 325;
            this.txtGPath.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 14);
            this.label20.TabIndex = 327;
            this.label20.Text = "CNIC:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(22, 394);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 14);
            this.label21.TabIndex = 328;
            this.label21.Text = "Community ID Card:";
            // 
            // txtCNIC
            // 
            this.txtCNIC.BackColor = System.Drawing.SystemColors.Window;
            this.txtCNIC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "CNIC", true));
            this.txtCNIC.Location = new System.Drawing.Point(129, 366);
            this.txtCNIC.Mask = "00000-0000000-0";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(92, 20);
            this.txtCNIC.TabIndex = 12;
            // 
            // txtCMIC
            // 
            this.txtCMIC.BackColor = System.Drawing.SystemColors.Info;
            this.txtCMIC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "NIC", true));
            this.txtCMIC.Location = new System.Drawing.Point(129, 391);
            this.txtCMIC.Mask = "0000-000-00000";
            this.txtCMIC.Name = "txtCMIC";
            this.txtCMIC.Size = new System.Drawing.Size(92, 20);
            this.txtCMIC.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(19, 440);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(439, 2);
            this.label22.TabIndex = 331;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(383, 496);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(302, 467);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Modify";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(19, 467);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 336;
            this.btnView.TabStop = false;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(101, 467);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 337;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "&Print CNIC";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(293, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvNIC
            // 
            this.dgvNIC.AllowUserToAddRows = false;
            this.dgvNIC.AllowUserToDeleteRows = false;
            this.dgvNIC.AutoGenerateColumns = false;
            this.dgvNIC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNIC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNIC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNIC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.nICDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.validDateDataGridViewTextBoxColumn,
            this.IsNicPrinted,
            this.SNo});
            this.dgvNIC.DataSource = this.tblNICBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNIC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNIC.Location = new System.Drawing.Point(12, 60);
            this.dgvNIC.Name = "dgvNIC";
            this.dgvNIC.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNIC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNIC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNIC.Size = new System.Drawing.Size(504, 401);
            this.dgvNIC.TabIndex = 338;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Visible = false;
            this.memberIDDataGridViewTextBoxColumn.Width = 81;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberNameDataGridViewTextBoxColumn.Width = 98;
            // 
            // nICDataGridViewTextBoxColumn
            // 
            this.nICDataGridViewTextBoxColumn.DataPropertyName = "NIC";
            this.nICDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nICDataGridViewTextBoxColumn.Name = "nICDataGridViewTextBoxColumn";
            this.nICDataGridViewTextBoxColumn.ReadOnly = true;
            this.nICDataGridViewTextBoxColumn.Width = 50;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.issueDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // validDateDataGridViewTextBoxColumn
            // 
            this.validDateDataGridViewTextBoxColumn.DataPropertyName = "ValidDate";
            this.validDateDataGridViewTextBoxColumn.HeaderText = "ValidDate";
            this.validDateDataGridViewTextBoxColumn.Name = "validDateDataGridViewTextBoxColumn";
            this.validDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.validDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // IsNicPrinted
            // 
            this.IsNicPrinted.DataPropertyName = "IsNicPrinted";
            this.IsNicPrinted.HeaderText = "Nic Printed";
            this.IsNicPrinted.Name = "IsNicPrinted";
            this.IsNicPrinted.ReadOnly = true;
            this.IsNicPrinted.Width = 65;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "Count";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 60;
            // 
            // dlg
            // 
            this.dlg.Filter = "ImageFiles (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*";
            // 
            // pbMember
            // 
            this.pbMember.BackColor = System.Drawing.Color.Transparent;
            this.pbMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMember.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblNICBindingSource, "Image", true));
            this.pbMember.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pbMember.Location = new System.Drawing.Point(268, 121);
            this.pbMember.Name = "pbMember";
            this.pbMember.Size = new System.Drawing.Size(96, 96);
            this.pbMember.TabIndex = 348;
            this.pbMember.Text = "Member Snap";
            this.pbMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMemberSign
            // 
            this.pbMemberSign.BackColor = System.Drawing.Color.Transparent;
            this.pbMemberSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMemberSign.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblNICBindingSource, "MemberSign", true));
            this.pbMemberSign.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pbMemberSign.Location = new System.Drawing.Point(268, 243);
            this.pbMemberSign.Name = "pbMemberSign";
            this.pbMemberSign.Size = new System.Drawing.Size(96, 48);
            this.pbMemberSign.TabIndex = 349;
            this.pbMemberSign.Text = "Member Sign";
            this.pbMemberSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGsSign
            // 
            this.pbGsSign.BackColor = System.Drawing.Color.Transparent;
            this.pbGsSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGsSign.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblNICBindingSource, "SecretarySign", true));
            this.pbGsSign.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pbGsSign.Location = new System.Drawing.Point(268, 317);
            this.pbGsSign.Name = "pbGsSign";
            this.pbGsSign.Size = new System.Drawing.Size(96, 48);
            this.pbGsSign.TabIndex = 350;
            this.pbGsSign.Text = "General Secratary Sign";
            this.pbGsSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 503);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 351;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 404;
            this.label1.Text = "(Refresh)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTypeWork
            // 
            this.cmbTypeWork.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTypeWork.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELtblFamilyMemberBindingSource, "WorkType", true));
            this.cmbTypeWork.DataSource = this.uspSELtblWorkTypeBindingSource;
            this.cmbTypeWork.DisplayMember = "WorkType";
            this.cmbTypeWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeWork.FormattingEnabled = true;
            this.cmbTypeWork.Location = new System.Drawing.Point(129, 273);
            this.cmbTypeWork.Name = "cmbTypeWork";
            this.cmbTypeWork.Size = new System.Drawing.Size(76, 21);
            this.cmbTypeWork.TabIndex = 10;
            this.cmbTypeWork.ValueMember = "ID";
            // 
            // uspSELtblWorkTypeBindingSource
            // 
            this.uspSELtblWorkTypeBindingSource.DataMember = "usp_SEL_tblWorkType";
            this.uspSELtblWorkTypeBindingSource.DataSource = this.comDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 403;
            this.label7.Text = "Work Type:";
            // 
            // chkDuplicate
            // 
            this.chkDuplicate.AutoSize = true;
            this.chkDuplicate.Location = new System.Drawing.Point(157, 500);
            this.chkDuplicate.Name = "chkDuplicate";
            this.chkDuplicate.Size = new System.Drawing.Size(71, 17);
            this.chkDuplicate.TabIndex = 14;
            this.chkDuplicate.Text = "Duplicate";
            this.chkDuplicate.UseVisualStyleBackColor = true;
            this.chkDuplicate.Visible = false;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.White;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtFName.Location = new System.Drawing.Point(129, 147);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(127, 20);
            this.txtFName.TabIndex = 406;
            // 
            // txtGFName
            // 
            this.txtGFName.BackColor = System.Drawing.Color.White;
            this.txtGFName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGFName.Location = new System.Drawing.Point(129, 172);
            this.txtGFName.Name = "txtGFName";
            this.txtGFName.Size = new System.Drawing.Size(127, 20);
            this.txtGFName.TabIndex = 407;
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.Color.White;
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDOB.Location = new System.Drawing.Point(129, 197);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(127, 20);
            this.txtDOB.TabIndex = 408;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(129, 248);
            this.txtPhoneNo.Mask = "0000-0000000";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(125, 20);
            this.txtPhoneNo.TabIndex = 9;
            // 
            // txtDuplicate
            // 
            this.txtDuplicate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNICBindingSource, "Duplicate", true));
            this.txtDuplicate.Location = new System.Drawing.Point(219, 516);
            this.txtDuplicate.Name = "txtDuplicate";
            this.txtDuplicate.Size = new System.Drawing.Size(76, 20);
            this.txtDuplicate.TabIndex = 410;
            this.txtDuplicate.TabStop = false;
            this.txtDuplicate.Visible = false;
            this.txtDuplicate.TextChanged += new System.EventHandler(this.txtDuplicate_TextChanged);
            // 
            // cmbDuplicate
            // 
            this.cmbDuplicate.FormattingEnabled = true;
            this.cmbDuplicate.Items.AddRange(new object[] {
            "",
            "Duplicate",
            "Triplicate",
            "Quadicate"});
            this.cmbDuplicate.Location = new System.Drawing.Point(129, 414);
            this.cmbDuplicate.Name = "cmbDuplicate";
            this.cmbDuplicate.Size = new System.Drawing.Size(92, 21);
            this.cmbDuplicate.TabIndex = 411;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 417);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 14);
            this.label18.TabIndex = 412;
            this.label18.Text = "CNIC:";
            // 
            // usp_SEL_tblBloodGroupTableAdapter
            // 
            this.usp_SEL_tblBloodGroupTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_tblFamilyMemberTableAdapter
            // 
            this.usp_SEL_tblFamilyMemberTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_tblWorkTypeTableAdapter
            // 
            this.usp_SEL_tblWorkTypeTableAdapter.ClearBeforeFill = true;
            // 
            // picBoxMemberSign
            // 
            this.picBoxMemberSign.Location = new System.Drawing.Point(268, 243);
            this.picBoxMemberSign.Name = "picBoxMemberSign";
            this.picBoxMemberSign.Size = new System.Drawing.Size(100, 48);
            this.picBoxMemberSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMemberSign.TabIndex = 414;
            this.picBoxMemberSign.TabStop = false;
            // 
            // picMemberBox
            // 
            this.picMemberBox.Location = new System.Drawing.Point(267, 121);
            this.picMemberBox.Name = "picMemberBox";
            this.picMemberBox.Size = new System.Drawing.Size(100, 96);
            this.picMemberBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMemberBox.TabIndex = 415;
            this.picMemberBox.TabStop = false;
            // 
            // picBoxGeneralSec
            // 
            this.picBoxGeneralSec.Location = new System.Drawing.Point(268, 317);
            this.picBoxGeneralSec.Name = "picBoxGeneralSec";
            this.picBoxGeneralSec.Size = new System.Drawing.Size(100, 50);
            this.picBoxGeneralSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxGeneralSec.TabIndex = 416;
            this.picBoxGeneralSec.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(129, 301);
            this.txtAddress.MaxLength = 89;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(125, 59);
            this.txtAddress.TabIndex = 417;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(107, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 418;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNicSearch
            // 
            this.txtNicSearch.Location = new System.Drawing.Point(12, 34);
            this.txtNicSearch.Name = "txtNicSearch";
            this.txtNicSearch.Size = new System.Drawing.Size(89, 20);
            this.txtNicSearch.TabIndex = 419;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(186, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 418;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Location = new System.Drawing.Point(10, 18);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(80, 13);
            this.lblSearchLabel.TabIndex = 420;
            this.lblSearchLabel.Text = "Search By NIC:";
            // 
            // tblNICTableAdapter
            // 
            this.tblNICTableAdapter.ClearBeforeFill = true;
            // 
            // chkIsNicPrinted
            // 
            this.chkIsNicPrinted.AutoSize = true;
            this.chkIsNicPrinted.Location = new System.Drawing.Point(271, 395);
            this.chkIsNicPrinted.Name = "chkIsNicPrinted";
            this.chkIsNicPrinted.Size = new System.Drawing.Size(89, 17);
            this.chkIsNicPrinted.TabIndex = 421;
            this.chkIsNicPrinted.Text = "Is Nic Printed";
            this.chkIsNicPrinted.UseVisualStyleBackColor = true;
            // 
            // frmNIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 526);
            this.Controls.Add(this.chkIsNicPrinted);
            this.Controls.Add(this.lblSearchLabel);
            this.Controls.Add(this.txtNicSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.picBoxGeneralSec);
            this.Controls.Add(this.picMemberBox);
            this.Controls.Add(this.picBoxMemberSign);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbDuplicate);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtGFName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTypeWork);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbGsSign);
            this.Controls.Add(this.pbMemberSign);
            this.Controls.Add(this.pbMember);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtCMIC);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnGSBrowser);
            this.Controls.Add(this.txtGPath);
            this.Controls.Add(this.btnSBrowser);
            this.Controls.Add(this.txtMSPath);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.cmbBGroup);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMBrowse);
            this.Controls.Add(this.cmbMemberName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtFCardNo);
            this.Controls.Add(this.txtNukh);
            this.Controls.Add(this.txtOrakh);
            this.Controls.Add(this.txtMPath);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.dtpValidUpto);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtDuplicate);
            this.Controls.Add(this.chkDuplicate);
            this.Controls.Add(this.dgvNIC);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNIC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmNIC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblFamilyMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblBloodGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblWorkTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMemberSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGeneralSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpValidUpto;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.TextBox txtMPath;
        private System.Windows.Forms.TextBox txtOrakh;
        private System.Windows.Forms.TextBox txtNukh;
        private System.Windows.Forms.TextBox txtFCardNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMemberName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnMBrowse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.BindingSource uspSELtblBloodGroupBindingSource;
        private System.Windows.Forms.ComboBox cmbBGroup;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblBloodGroupTableAdapter usp_SEL_tblBloodGroupTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMSPath;
        private System.Windows.Forms.Button btnSBrowser;
        private System.Windows.Forms.Button btnGSBrowser;
        private System.Windows.Forms.TextBox txtGPath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
        private System.Windows.Forms.MaskedTextBox txtCMIC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvNIC;
        private dataset dataset;
        private System.Windows.Forms.BindingSource tblNICBindingSource;
        private MCKJ.datasetTableAdapters.tblNICTableAdapter tblNICTableAdapter;
        private ComDataSet comDataSet;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.Label pbMember;
        private System.Windows.Forms.Label pbMemberSign;
        private System.Windows.Forms.Label pbGsSign;
        private System.Windows.Forms.BindingSource uspSELtblFamilyMemberBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblFamilyMemberTableAdapter usp_SEL_tblFamilyMemberTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblWorkTypeTableAdapter usp_SEL_tblWorkTypeTableAdapter;
        private System.Windows.Forms.BindingSource uspSELtblWorkTypeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeWork;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDuplicate;
        private System.Windows.Forms.Label txtFName;
        private System.Windows.Forms.Label txtGFName;
        private System.Windows.Forms.Label txtDOB;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtDuplicate;
        private System.Windows.Forms.ComboBox cmbDuplicate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox picBoxMemberSign;
        private System.Windows.Forms.PictureBox picMemberBox;
        private System.Windows.Forms.PictureBox picBoxGeneralSec;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNicSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.CheckBox chkIsNicPrinted;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNicPrinted;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
    }
}