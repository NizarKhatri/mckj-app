namespace MCKJ
{
    partial class frmVouchers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVouchers));
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVouchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MCKJ.ComDataSet();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblVoucherType = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.tblVouchersTableAdapter = new MCKJ.ComDataSetTableAdapters.tblVouchersTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVouchersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.AllowUserToDeleteRows = false;
            this.dgvVouchers.AutoGenerateColumns = false;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.voucherDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.dgvVouchers.DataSource = this.tblVouchersBindingSource;
            this.dgvVouchers.Location = new System.Drawing.Point(12, 36);
            this.dgvVouchers.MultiSelect = false;
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(384, 119);
            this.dgvVouchers.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // voucherDataGridViewTextBoxColumn
            // 
            this.voucherDataGridViewTextBoxColumn.DataPropertyName = "Voucher";
            this.voucherDataGridViewTextBoxColumn.HeaderText = "Voucher";
            this.voucherDataGridViewTextBoxColumn.Name = "voucherDataGridViewTextBoxColumn";
            this.voucherDataGridViewTextBoxColumn.ReadOnly = true;
            this.voucherDataGridViewTextBoxColumn.Width = 80;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 160;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblVouchersBindingSource
            // 
            this.tblVouchersBindingSource.DataMember = "tblVouchers";
            this.tblVouchersBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Location = new System.Drawing.Point(236, 161);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 22);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(155, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 22);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(319, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 22);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(319, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 22);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(141, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(17, 97);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(75, 14);
            this.lblCreationDate.TabIndex = 47;
            this.lblCreationDate.Text = "Creation Date:";
            // 
            // txtVoucher
            // 
            this.txtVoucher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVouchersBindingSource, "Voucher", true));
            this.txtVoucher.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(141, 42);
            this.txtVoucher.MaxLength = 35;
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(96, 20);
            this.txtVoucher.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(17, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 14);
            this.lblDescription.TabIndex = 37;
            this.lblDescription.Text = "Description:";
            // 
            // lblVoucherType
            // 
            this.lblVoucherType.AutoSize = true;
            this.lblVoucherType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherType.Location = new System.Drawing.Point(17, 45);
            this.lblVoucherType.Name = "lblVoucherType";
            this.lblVoucherType.Size = new System.Drawing.Size(49, 14);
            this.lblVoucherType.TabIndex = 35;
            this.lblVoucherType.Text = "Voucher";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVouchersBindingSource, "Description", true));
            this.txtDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(141, 68);
            this.txtDescription.MaxLength = 35;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVouchersBindingSource, "DateCreated", true));
            this.txtCreationDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreationDate.Location = new System.Drawing.Point(141, 94);
            this.txtCreationDate.MaxLength = 35;
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(96, 20);
            this.txtCreationDate.TabIndex = 3;
            // 
            // tblVouchersTableAdapter
            // 
            this.tblVouchersTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Voucher Entry Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVouchers
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(408, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreationDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.txtVoucher);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVoucherType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvVouchers);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVouchers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frmVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVouchersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accHeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblVoucherType;
        private System.Windows.Forms.TextBox txtDescription;
        private ComDataSet dataSet;
        private System.Windows.Forms.BindingSource tblVouchersBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblVouchersTableAdapter tblVouchersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCreationDate;
        private System.Windows.Forms.Label label2;
    }
}

