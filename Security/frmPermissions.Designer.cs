namespace MCKJ.Security
{
    partial class frmPermissions
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.tblUserGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.tblSecurityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRights = new System.Windows.Forms.DataGridView();
            this.Permissions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblSecurityLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Read = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Write = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblSecurityLevelTableAdapter = new MCKJ.ComDataSetTableAdapters.tblSecurityLevelTableAdapter();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.uspSELtblPermissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_tblPermissionTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblPermissionTableAdapter();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tblSecurityTableAdapter = new MCKJ.ComDataSetTableAdapters.tblSecurityTableAdapter();
            this.tblUserGroupTableAdapter = new MCKJ.ComDataSetTableAdapters.tblUserGroupTableAdapter();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblPermissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name:";
            // 
            // cmbUser
            // 
            this.cmbUser.DataSource = this.tblUserGroupBindingSource;
            this.cmbUser.DisplayMember = "GroupName";
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(80, 33);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 1;
            this.cmbUser.ValueMember = "ID";
            // 
            // tblUserGroupBindingSource
            // 
            this.tblUserGroupBindingSource.DataMember = "tblUserGroup";
            this.tblUserGroupBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSecurityBindingSource
            // 
            this.tblSecurityBindingSource.DataMember = "tblSecurity";
            this.tblSecurityBindingSource.DataSource = this.comDataSet;
            // 
            // dgvRights
            // 
            this.dgvRights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Permissions,
            this.Read,
            this.Write,
            this.Modify,
            this.Delete,
            this.Active,
            this.ID});
            this.dgvRights.Location = new System.Drawing.Point(12, 60);
            this.dgvRights.Name = "dgvRights";
            this.dgvRights.Size = new System.Drawing.Size(693, 276);
            this.dgvRights.TabIndex = 2;
            // 
            // Permissions
            // 
            this.Permissions.DataSource = this.tblSecurityLevelBindingSource;
            this.Permissions.DisplayMember = "SecurityName";
            this.Permissions.HeaderText = "Permissions";
            this.Permissions.Name = "Permissions";
            this.Permissions.ValueMember = "SecurityLevel_ID";
            this.Permissions.Width = 150;
            // 
            // tblSecurityLevelBindingSource
            // 
            this.tblSecurityLevelBindingSource.DataMember = "tblSecurityLevel";
            this.tblSecurityLevelBindingSource.DataSource = this.comDataSet;
            // 
            // Read
            // 
            this.Read.FalseValue = "0";
            this.Read.HeaderText = "Read";
            this.Read.Name = "Read";
            this.Read.TrueValue = "1";
            // 
            // Write
            // 
            this.Write.FalseValue = "0";
            this.Write.HeaderText = "Write";
            this.Write.Name = "Write";
            this.Write.TrueValue = "1";
            // 
            // Modify
            // 
            this.Modify.FalseValue = "0";
            this.Modify.HeaderText = "Modify";
            this.Modify.Name = "Modify";
            this.Modify.TrueValue = "1";
            // 
            // Delete
            // 
            this.Delete.FalseValue = "0";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.TrueValue = "1";
            // 
            // Active
            // 
            this.Active.FalseValue = "0";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.TrueValue = "1";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(630, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(630, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(549, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblSecurityLevelTableAdapter
            // 
            this.tblSecurityLevelTableAdapter.ClearBeforeFill = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 342);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(174, 342);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // uspSELtblPermissionBindingSource
            // 
            this.uspSELtblPermissionBindingSource.DataMember = "usp_SEL_tblPermission";
            this.uspSELtblPermissionBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_tblPermissionTableAdapter
            // 
            this.usp_SEL_tblPermissionTableAdapter.ClearBeforeFill = true;
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(174, 342);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 23);
            this.btnCanel.TabIndex = 8;
            this.btnCanel.Text = "Canc&el";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 342);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tblSecurityTableAdapter
            // 
            this.tblSecurityTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserGroupTableAdapter
            // 
            this.tblUserGroupTableAdapter.ClearBeforeFill = true;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(722, 19);
            this.lbl.TabIndex = 386;
            this.lbl.Text = "Permissions";
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 403);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvRights);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblPermissionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUser;
        private ComDataSet comDataSet;
        private System.Windows.Forms.DataGridView dgvRights;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource tblSecurityLevelBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblSecurityLevelTableAdapter tblSecurityLevelTableAdapter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource uspSELtblPermissionBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblPermissionTableAdapter usp_SEL_tblPermissionTableAdapter;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.BindingSource tblSecurityBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblSecurityTableAdapter tblSecurityTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Permissions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Read;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Write;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.BindingSource tblUserGroupBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblUserGroupTableAdapter tblUserGroupTableAdapter;
        private System.Windows.Forms.Label lbl;
    }
}