namespace MCKJ
{
    partial class frmSecurityLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityLevel));
            this.dgvSecurityLevel = new System.Windows.Forms.DataGridView();
            this.txtSecurityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkInactive_FL = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblSecurityLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.securityLevelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inactiveFLDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblSecurityLevelTableAdapter = new MCKJ.ComDataSetTableAdapters.tblSecurityLevelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSecurityLevel
            // 
            this.dgvSecurityLevel.AllowUserToAddRows = false;
            this.dgvSecurityLevel.AllowUserToDeleteRows = false;
            this.dgvSecurityLevel.AutoGenerateColumns = false;
            this.dgvSecurityLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecurityLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.securityLevelIDDataGridViewTextBoxColumn,
            this.securityNameDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.inactiveFLDataGridViewCheckBoxColumn});
            this.dgvSecurityLevel.DataSource = this.tblSecurityLevelBindingSource;
            this.dgvSecurityLevel.Location = new System.Drawing.Point(13, 13);
            this.dgvSecurityLevel.Name = "dgvSecurityLevel";
            this.dgvSecurityLevel.ReadOnly = true;
            this.dgvSecurityLevel.Size = new System.Drawing.Size(343, 168);
            this.dgvSecurityLevel.TabIndex = 0;
            // 
            // txtSecurityName
            // 
            this.txtSecurityName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSecurityLevelBindingSource, "SecurityName", true));
            this.txtSecurityName.Enabled = false;
            this.txtSecurityName.Location = new System.Drawing.Point(95, 187);
            this.txtSecurityName.Name = "txtSecurityName";
            this.txtSecurityName.Size = new System.Drawing.Size(158, 20);
            this.txtSecurityName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Security Name";
            // 
            // btnNew
            // 
            this.btnNew.ImageIndex = 0;
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(362, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(27, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = " ";
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 3;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(362, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(27, 23);
            this.btnEdit.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(362, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 23);
            this.btnDelete.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageIndex = 4;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(362, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(27, 23);
            this.btnCancel.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(362, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(27, 23);
            this.btnSave.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkInactive_FL
            // 
            this.chkInactive_FL.AutoSize = true;
            this.chkInactive_FL.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblSecurityLevelBindingSource, "Inactive_FL", true));
            this.chkInactive_FL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInactive_FL.Location = new System.Drawing.Point(261, 185);
            this.chkInactive_FL.Name = "chkInactive_FL";
            this.chkInactive_FL.Size = new System.Drawing.Size(95, 20);
            this.chkInactive_FL.TabIndex = 8;
            this.chkInactive_FL.Text = "Inactive_FL";
            this.chkInactive_FL.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 5;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(362, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 23);
            this.btnClose.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "NewDocumentHS.BMP");
            this.imageList1.Images.SetKeyName(1, "saveHS.bmp");
            this.imageList1.Images.SetKeyName(2, "DeleteHS.png");
            this.imageList1.Images.SetKeyName(3, "EditInformationHS.BMP");
            this.imageList1.Images.SetKeyName(4, "Edit_UndoHS.png");
            this.imageList1.Images.SetKeyName(5, "RestartHS.png");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // tblSecurityLevelBindingSource
            // 
            this.tblSecurityLevelBindingSource.DataMember = "tblSecurityLevel";
            this.tblSecurityLevelBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securityLevelIDDataGridViewTextBoxColumn
            // 
            this.securityLevelIDDataGridViewTextBoxColumn.DataPropertyName = "SecurityLevel_ID";
            this.securityLevelIDDataGridViewTextBoxColumn.HeaderText = "SecurityLevel_ID";
            this.securityLevelIDDataGridViewTextBoxColumn.Name = "securityLevelIDDataGridViewTextBoxColumn";
            this.securityLevelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.securityLevelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // securityNameDataGridViewTextBoxColumn
            // 
            this.securityNameDataGridViewTextBoxColumn.DataPropertyName = "SecurityName";
            this.securityNameDataGridViewTextBoxColumn.HeaderText = "Security Name";
            this.securityNameDataGridViewTextBoxColumn.Name = "securityNameDataGridViewTextBoxColumn";
            this.securityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inactiveFLDataGridViewCheckBoxColumn
            // 
            this.inactiveFLDataGridViewCheckBoxColumn.DataPropertyName = "Inactive_FL";
            this.inactiveFLDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.inactiveFLDataGridViewCheckBoxColumn.Name = "inactiveFLDataGridViewCheckBoxColumn";
            this.inactiveFLDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tblSecurityLevelTableAdapter
            // 
            this.tblSecurityLevelTableAdapter.ClearBeforeFill = true;
            // 
            // frmSecurityLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 213);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkInactive_FL);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecurityName);
            this.Controls.Add(this.dgvSecurityLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSecurityLevel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Level";
            this.Load += new System.EventHandler(this.frmSecurityLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSecurityLevel;
        private System.Windows.Forms.TextBox txtSecurityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkInactive_FL;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource tblSecurityLevelBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblSecurityLevelTableAdapter tblSecurityLevelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityLevelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inactiveFLDataGridViewCheckBoxColumn;

    }
}