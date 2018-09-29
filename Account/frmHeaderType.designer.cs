namespace MCKJ
{
    partial class frmHeaderType
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtHeaderType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHeader = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvHeaderType = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataset2 = new MCKJ.dataset2();
            this.tblHeaderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHeaderTypeTableAdapter = new MCKJ.dataset2TableAdapters.tblHeaderTypeTableAdapter();
            this.tblHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHeaderTableAdapter = new MCKJ.dataset2TableAdapters.tblHeaderTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MCKJ.ComDataSet();
            this.tblAccountsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHeaderTypeBindingSource, "Code", true));
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(116, 65);
            this.txtCode.MaxLength = 2;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(39, 20);
            this.txtCode.TabIndex = 4;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // txtHeaderType
            // 
            this.txtHeaderType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHeaderTypeBindingSource, "HeaderType", true));
            this.txtHeaderType.Enabled = false;
            this.txtHeaderType.Location = new System.Drawing.Point(116, 91);
            this.txtHeaderType.Name = "txtHeaderType";
            this.txtHeaderType.Size = new System.Drawing.Size(100, 20);
            this.txtHeaderType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Header:";
            // 
            // cmbHeader
            // 
            this.cmbHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHeaderTypeBindingSource, "Header", true));
            this.cmbHeader.DataSource = this.tblHeaderBindingSource;
            this.cmbHeader.DisplayMember = "Header";
            this.cmbHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeader.Enabled = false;
            this.cmbHeader.FormattingEnabled = true;
            this.cmbHeader.Location = new System.Drawing.Point(116, 38);
            this.cmbHeader.Name = "cmbHeader";
            this.cmbHeader.Size = new System.Drawing.Size(100, 21);
            this.cmbHeader.TabIndex = 3;
            this.cmbHeader.ValueMember = "ID";
            this.cmbHeader.Leave += new System.EventHandler(this.txtCode_Leave);
            this.cmbHeader.SelectedIndexChanged += new System.EventHandler(this.cmbHeader_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(305, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(141, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Location = new System.Drawing.Point(222, 161);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(305, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(143, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(60, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvHeaderType
            // 
            this.dgvHeaderType.AllowUserToAddRows = false;
            this.dgvHeaderType.AllowUserToDeleteRows = false;
            this.dgvHeaderType.AutoGenerateColumns = false;
            this.dgvHeaderType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeaderType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.headerDataGridViewTextBoxColumn,
            this.headerTypeDataGridViewTextBoxColumn});
            this.dgvHeaderType.DataSource = this.tblHeaderTypeBindingSource;
            this.dgvHeaderType.Location = new System.Drawing.Point(12, 18);
            this.dgvHeaderType.Name = "dgvHeaderType";
            this.dgvHeaderType.ReadOnly = true;
            this.dgvHeaderType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeaderType.Size = new System.Drawing.Size(370, 137);
            this.dgvHeaderType.TabIndex = 74;
            this.dgvHeaderType.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(161, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Enter Code from 01-99";
            // 
            // dataset2
            // 
            this.dataset2.DataSetName = "dataset2";
            this.dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHeaderTypeBindingSource
            // 
            this.tblHeaderTypeBindingSource.DataMember = "tblHeaderType";
            this.tblHeaderTypeBindingSource.DataSource = this.dataset2;
            // 
            // tblHeaderTypeTableAdapter
            // 
            this.tblHeaderTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tblHeaderBindingSource
            // 
            this.tblHeaderBindingSource.DataMember = "tblHeader";
            this.tblHeaderBindingSource.DataSource = this.dataset2;
            // 
            // tblHeaderTableAdapter
            // 
            this.tblHeaderTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headerDataGridViewTextBoxColumn
            // 
            this.headerDataGridViewTextBoxColumn.DataPropertyName = "Header";
            this.headerDataGridViewTextBoxColumn.HeaderText = "Header";
            this.headerDataGridViewTextBoxColumn.Name = "headerDataGridViewTextBoxColumn";
            this.headerDataGridViewTextBoxColumn.ReadOnly = true;
            this.headerDataGridViewTextBoxColumn.Width = 70;
            // 
            // headerTypeDataGridViewTextBoxColumn
            // 
            this.headerTypeDataGridViewTextBoxColumn.DataPropertyName = "HeaderType";
            this.headerTypeDataGridViewTextBoxColumn.HeaderText = "Header Type";
            this.headerTypeDataGridViewTextBoxColumn.Name = "headerTypeDataGridViewTextBoxColumn";
            this.headerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.headerTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblAccountsBindingSource
            // 
            this.tblAccountsBindingSource.DataMember = "tblAccounts";
            this.tblAccountsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAccountsTableAdapter
            // 
            this.tblAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // frmHeaderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 218);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeaderType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHeaderType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHeaderType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Header Type";
            this.Load += new System.EventHandler(this.frmHeaderType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtHeaderType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvHeaderType;
        private System.Windows.Forms.Label label4;
        private dataset2 dataset2;
        private System.Windows.Forms.BindingSource tblHeaderTypeBindingSource;
        private MCKJ.dataset2TableAdapters.tblHeaderTypeTableAdapter tblHeaderTypeTableAdapter;
        private System.Windows.Forms.BindingSource tblHeaderBindingSource;
        private MCKJ.dataset2TableAdapters.tblHeaderTableAdapter tblHeaderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private ComDataSet dataSet;
        private MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter tblAccountsTableAdapter;
    }
}