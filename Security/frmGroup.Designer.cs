namespace MCKJ.Security
{
    partial class frmGroup
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
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblUserGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.tblUserGroupTableAdapter = new MCKJ.ComDataSetTableAdapters.tblUserGroupTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.AllowUserToDeleteRows = false;
            this.dgvGroup.AutoGenerateColumns = false;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dgvGroup.DataSource = this.tblUserGroupBindingSource;
            this.dgvGroup.Location = new System.Drawing.Point(14, 31);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.ReadOnly = true;
            this.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroup.Size = new System.Drawing.Size(294, 108);
            this.dgvGroup.TabIndex = 0;
            this.dgvGroup.TabStop = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // tblUserGroupTableAdapter
            // 
            this.tblUserGroupTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(152, 145);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(233, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblUserGroupBindingSource, "Active", true));
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(87, 59);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 4;
            this.chkStatus.Text = "Active";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserGroupBindingSource, "GroupName", true));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(87, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Group Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(233, 174);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(326, 19);
            this.lbl.TabIndex = 385;
            this.lbl.Text = "User Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 386;
            this.label2.Text = "Status:";
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 209);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroup;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource tblUserGroupBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblUserGroupTableAdapter tblUserGroupTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
    }
}