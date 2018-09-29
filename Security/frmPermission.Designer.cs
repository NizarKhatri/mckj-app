namespace MCKJ
{
    partial class frmPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermission));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.DGPermission = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityLevelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.writeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modifyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inactiveFLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspSELtblPermissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.uspSELDDLUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSecutrityLevelID = new System.Windows.Forms.ComboBox();
            this.tblSecurityLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.chkWrite = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermissionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usp_SEL_tblPermissionTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblPermissionTableAdapter();
            this.usp_SEL_DDL_USERTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_DDL_USERTableAdapter();
            this.tblSecurityLevelTableAdapter = new MCKJ.ComDataSetTableAdapters.tblSecurityLevelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblPermissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELDDLUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityLevelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(413, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 19);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 20);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(337, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 20);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 20);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(337, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 20);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(259, 190);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 20);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // DGPermission
            // 
            this.DGPermission.AllowUserToAddRows = false;
            this.DGPermission.AllowUserToDeleteRows = false;
            this.DGPermission.AutoGenerateColumns = false;
            this.DGPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.securityLevelIDDataGridViewTextBoxColumn,
            this.readDataGridViewCheckBoxColumn,
            this.writeDataGridViewCheckBoxColumn,
            this.modifyDataGridViewCheckBoxColumn,
            this.deleteDataGridViewCheckBoxColumn,
            this.inactiveFLDataGridViewTextBoxColumn});
            this.DGPermission.DataSource = this.uspSELtblPermissionBindingSource;
            this.DGPermission.Location = new System.Drawing.Point(39, 25);
            this.DGPermission.Name = "DGPermission";
            this.DGPermission.ReadOnly = true;
            this.DGPermission.Size = new System.Drawing.Size(444, 159);
            this.DGPermission.TabIndex = 33;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // securityLevelIDDataGridViewTextBoxColumn
            // 
            this.securityLevelIDDataGridViewTextBoxColumn.DataPropertyName = "SecurityLevelID";
            this.securityLevelIDDataGridViewTextBoxColumn.HeaderText = "SecurityLevelID";
            this.securityLevelIDDataGridViewTextBoxColumn.Name = "securityLevelIDDataGridViewTextBoxColumn";
            this.securityLevelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readDataGridViewCheckBoxColumn
            // 
            this.readDataGridViewCheckBoxColumn.DataPropertyName = "Read";
            this.readDataGridViewCheckBoxColumn.HeaderText = "Read";
            this.readDataGridViewCheckBoxColumn.Name = "readDataGridViewCheckBoxColumn";
            this.readDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // writeDataGridViewCheckBoxColumn
            // 
            this.writeDataGridViewCheckBoxColumn.DataPropertyName = "Write";
            this.writeDataGridViewCheckBoxColumn.HeaderText = "Write";
            this.writeDataGridViewCheckBoxColumn.Name = "writeDataGridViewCheckBoxColumn";
            this.writeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // modifyDataGridViewCheckBoxColumn
            // 
            this.modifyDataGridViewCheckBoxColumn.DataPropertyName = "Modify";
            this.modifyDataGridViewCheckBoxColumn.HeaderText = "Modify";
            this.modifyDataGridViewCheckBoxColumn.Name = "modifyDataGridViewCheckBoxColumn";
            this.modifyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // deleteDataGridViewCheckBoxColumn
            // 
            this.deleteDataGridViewCheckBoxColumn.DataPropertyName = "Delete";
            this.deleteDataGridViewCheckBoxColumn.HeaderText = "Delete";
            this.deleteDataGridViewCheckBoxColumn.Name = "deleteDataGridViewCheckBoxColumn";
            this.deleteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // inactiveFLDataGridViewTextBoxColumn
            // 
            this.inactiveFLDataGridViewTextBoxColumn.DataPropertyName = "Inactive_FL";
            this.inactiveFLDataGridViewTextBoxColumn.HeaderText = "Inactive_FL";
            this.inactiveFLDataGridViewTextBoxColumn.Name = "inactiveFLDataGridViewTextBoxColumn";
            this.inactiveFLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uspSELtblPermissionBindingSource
            // 
            this.uspSELtblPermissionBindingSource.DataMember = "usp_SEL_tblPermission";
            this.uspSELtblPermissionBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbUserID
            // 
            this.cmbUserID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uspSELDDLUSERBindingSource, "UserID", true));
            this.cmbUserID.DataSource = this.uspSELDDLUSERBindingSource;
            this.cmbUserID.DisplayMember = "UserName";
            this.cmbUserID.Enabled = false;
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(148, 237);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(105, 21);
            this.cmbUserID.TabIndex = 32;
            this.cmbUserID.ValueMember = "UserID";
            // 
            // uspSELDDLUSERBindingSource
            // 
            this.uspSELDDLUSERBindingSource.DataMember = "usp_SEL_DDL_USER";
            this.uspSELDDLUSERBindingSource.DataSource = this.comDataSet;
            // 
            // cmbSecutrityLevelID
            // 
            this.cmbSecutrityLevelID.DataSource = this.tblSecurityLevelBindingSource;
            this.cmbSecutrityLevelID.DisplayMember = "SecurityName";
            this.cmbSecutrityLevelID.Enabled = false;
            this.cmbSecutrityLevelID.FormattingEnabled = true;
            this.cmbSecutrityLevelID.Location = new System.Drawing.Point(148, 263);
            this.cmbSecutrityLevelID.Name = "cmbSecutrityLevelID";
            this.cmbSecutrityLevelID.Size = new System.Drawing.Size(105, 21);
            this.cmbSecutrityLevelID.TabIndex = 31;
            this.cmbSecutrityLevelID.ValueMember = "SecurityLevel_ID";
            // 
            // tblSecurityLevelBindingSource
            // 
            this.tblSecurityLevelBindingSource.DataMember = "tblSecurityLevel";
            this.tblSecurityLevelBindingSource.DataSource = this.comDataSet;
            // 
            // chkRead
            // 
            this.chkRead.AutoSize = true;
            this.chkRead.Enabled = false;
            this.chkRead.Location = new System.Drawing.Point(48, 293);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(52, 17);
            this.chkRead.TabIndex = 30;
            this.chkRead.Text = "Read";
            this.chkRead.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Enabled = false;
            this.chkActive.Location = new System.Drawing.Point(197, 293);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 29;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Enabled = false;
            this.chkDelete.Location = new System.Drawing.Point(121, 316);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 28;
            this.chkDelete.Text = "Delete";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Enabled = false;
            this.chkEdit.Location = new System.Drawing.Point(48, 316);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(57, 17);
            this.chkEdit.TabIndex = 27;
            this.chkEdit.Text = "Modify";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // chkWrite
            // 
            this.chkWrite.AutoSize = true;
            this.chkWrite.Enabled = false;
            this.chkWrite.Location = new System.Drawing.Point(121, 293);
            this.chkWrite.Name = "chkWrite";
            this.chkWrite.Size = new System.Drawing.Size(51, 17);
            this.chkWrite.TabIndex = 26;
            this.chkWrite.Text = "Write";
            this.chkWrite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(45, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "SecurityLevel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(45, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Name";
            // 
            // txtPermissionID
            // 
            this.txtPermissionID.Enabled = false;
            this.txtPermissionID.Location = new System.Drawing.Point(96, 343);
            this.txtPermissionID.Name = "txtPermissionID";
            this.txtPermissionID.Size = new System.Drawing.Size(104, 20);
            this.txtPermissionID.TabIndex = 23;
            this.txtPermissionID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(93, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Permission ID";
            this.label1.Visible = false;
            // 
            // usp_SEL_tblPermissionTableAdapter
            // 
            this.usp_SEL_tblPermissionTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_DDL_USERTableAdapter
            // 
            this.usp_SEL_DDL_USERTableAdapter.ClearBeforeFill = true;
            // 
            // tblSecurityLevelTableAdapter
            // 
            this.tblSecurityLevelTableAdapter.ClearBeforeFill = true;
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.DGPermission);
            this.Controls.Add(this.cmbUserID);
            this.Controls.Add(this.cmbSecutrityLevelID);
            this.Controls.Add(this.chkRead);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.chkWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPermissionID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermission";
            this.Text = "frmPermission";
            this.Load += new System.EventHandler(this.frmPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblPermissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELDDLUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityLevelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView DGPermission;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.ComboBox cmbSecutrityLevelID;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.CheckBox chkWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPermissionID;
        private System.Windows.Forms.Label label1;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource uspSELtblPermissionBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblPermissionTableAdapter usp_SEL_tblPermissionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityLevelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn readDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn writeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modifyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inactiveFLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uspSELDDLUSERBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_DDL_USERTableAdapter usp_SEL_DDL_USERTableAdapter;
        private System.Windows.Forms.BindingSource tblSecurityLevelBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblSecurityLevelTableAdapter tblSecurityLevelTableAdapter;
    }
}