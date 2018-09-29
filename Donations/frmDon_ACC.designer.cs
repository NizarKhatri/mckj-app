namespace MCKJ
{
    partial class frmDon_ACC
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
            this.tblAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblAccountsTableAdapter = new MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter();
            this.dataset3 = new MCKJ.dataset3();
            this.tblDonAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDonAccTableAdapter = new MCKJ.dataset3TableAdapters.tblDonAccTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPettyAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDonAccBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPettyAcc
            // 
            this.dgvPettyAcc.AllowUserToAddRows = false;
            this.dgvPettyAcc.AllowUserToDeleteRows = false;
            this.dgvPettyAcc.AutoGenerateColumns = false;
            this.dgvPettyAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPettyAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvPettyAcc.DataSource = this.tblDonAccBindingSource;
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
            this.cmbPettyAcc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDonAccBindingSource, "DonAcc", true));
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
            // tblAccountsTableAdapter
            // 
            this.tblAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // dataset3
            // 
            this.dataset3.DataSetName = "dataset3";
            this.dataset3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDonAccBindingSource
            // 
            this.tblDonAccBindingSource.DataMember = "tblDonAcc";
            this.tblDonAccBindingSource.DataSource = this.dataset3;
            // 
            // tblDonAccTableAdapter
            // 
            this.tblDonAccTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AccID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonAcc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Donation Account";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // frmDon_ACC
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
            this.Name = "frmDon_ACC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donation Account";
            this.Load += new System.EventHandler(this.frmPettyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPettyAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDonAccBindingSource)).EndInit();
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
        private MCKJ.ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource tblAccountsBindingSource;
        private MCKJ.ComDataSetTableAdapters.tblAccountsTableAdapter tblAccountsTableAdapter;              
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donAccDataGridViewTextBoxColumn;
        private dataset3 dataset3;
        private System.Windows.Forms.BindingSource tblDonAccBindingSource;
        private MCKJ.dataset3TableAdapters.tblDonAccTableAdapter tblDonAccTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}