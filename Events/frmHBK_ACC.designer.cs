namespace MCKJ
{
    partial class frmHBK_ACC
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
            this.dgvPettyAcc = new System.Windows.Forms.DataGridView();
            this.cmbPettyAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataset2 = new MCKJ.dataset2();
            this.tblHallAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallAccTableAdapter = new MCKJ.dataset2TableAdapters.tblHallAccTableAdapter();
            this.comDataSet = new MCKJ.ComDataSet();
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccountsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallBookingAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPettyAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPettyAcc
            // 
            this.dgvPettyAcc.AllowUserToAddRows = false;
            this.dgvPettyAcc.AllowUserToDeleteRows = false;
            this.dgvPettyAcc.AutoGenerateColumns = false;
            this.dgvPettyAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPettyAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.accIDDataGridViewTextBoxColumn,
            this.hallBookingAccDataGridViewTextBoxColumn});
            this.dgvPettyAcc.DataSource = this.tblHallAccBindingSource;
            this.dgvPettyAcc.Location = new System.Drawing.Point(12, 12);
            this.dgvPettyAcc.Name = "dgvPettyAcc";
            this.dgvPettyAcc.ReadOnly = true;
            this.dgvPettyAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPettyAcc.Size = new System.Drawing.Size(346, 150);
            this.dgvPettyAcc.TabIndex = 4;
            this.dgvPettyAcc.TabStop = false;
            // 
            // cmbPettyAcc
            // 
            this.cmbPettyAcc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHallAccBindingSource, "HallBookingAcc", true));
            this.cmbPettyAcc.DataSource = this.tblAccountsBindingSource;
            this.cmbPettyAcc.DisplayMember = "AccountName";
            this.cmbPettyAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPettyAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPettyAcc.FormattingEnabled = true;
            this.cmbPettyAcc.Location = new System.Drawing.Point(96, 168);
            this.cmbPettyAcc.Name = "cmbPettyAcc";
            this.cmbPettyAcc.Size = new System.Drawing.Size(181, 21);
            this.cmbPettyAcc.TabIndex = 0;
            this.cmbPettyAcc.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(202, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(283, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataset2
            // 
            this.dataset2.DataSetName = "dataset2";
            this.dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHallAccBindingSource
            // 
            this.tblHallAccBindingSource.DataMember = "tblHallAcc";
            this.tblHallAccBindingSource.DataSource = this.dataset2;
            // 
            // tblHallAccTableAdapter
            // 
            this.tblHallAccTableAdapter.ClearBeforeFill = true;
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
            // tblAccountsTableAdapter
            // 
            this.tblAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accIDDataGridViewTextBoxColumn
            // 
            this.accIDDataGridViewTextBoxColumn.DataPropertyName = "AccID";
            this.accIDDataGridViewTextBoxColumn.HeaderText = "AccID";
            this.accIDDataGridViewTextBoxColumn.Name = "accIDDataGridViewTextBoxColumn";
            this.accIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hallBookingAccDataGridViewTextBoxColumn
            // 
            this.hallBookingAccDataGridViewTextBoxColumn.DataPropertyName = "HallBookingAcc";
            this.hallBookingAccDataGridViewTextBoxColumn.HeaderText = "Hall Booking Accounts";
            this.hallBookingAccDataGridViewTextBoxColumn.Name = "hallBookingAccDataGridViewTextBoxColumn";
            this.hallBookingAccDataGridViewTextBoxColumn.ReadOnly = true;
            this.hallBookingAccDataGridViewTextBoxColumn.Width = 300;
            // 
            // frmPettyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 234);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPettyAcc);
            this.Controls.Add(this.dgvPettyAcc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPettyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall Booking Account";
            this.Load += new System.EventHandler(this.frmPettyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPettyAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPettyAcc;
        private System.Windows.Forms.ComboBox cmbPettyAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private MCKJ.dataset2 dataset2;
        private System.Windows.Forms.BindingSource tblHallAccBindingSource;
        private MCKJ.dataset2TableAdapters.tblHallAccTableAdapter tblHallAccTableAdapter;
        private MCKJ.ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter tblAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallBookingAccDataGridViewTextBoxColumn;
    }
}