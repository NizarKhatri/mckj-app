namespace MCKJ.Members
{
    partial class frmNICStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNICStaff));
            this.pnlStaffNIC = new System.Windows.Forms.Panel();
            this.lblStaffNIC = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dgvStaffMembers = new System.Windows.Forms.DataGridView();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCellNo = new System.Windows.Forms.MaskedTextBox();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.pnlStaffNIC.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStaffNIC
            // 
            this.pnlStaffNIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStaffNIC.Controls.Add(this.lblStaffNIC);
            this.pnlStaffNIC.Location = new System.Drawing.Point(1, 0);
            this.pnlStaffNIC.Name = "pnlStaffNIC";
            this.pnlStaffNIC.Size = new System.Drawing.Size(458, 72);
            this.pnlStaffNIC.TabIndex = 0;
            // 
            // lblStaffNIC
            // 
            this.lblStaffNIC.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffNIC.Location = new System.Drawing.Point(3, 9);
            this.lblStaffNIC.Name = "lblStaffNIC";
            this.lblStaffNIC.Size = new System.Drawing.Size(452, 53);
            this.lblStaffNIC.TabIndex = 0;
            this.lblStaffNIC.Text = "MCKJ Staff Management";
            this.lblStaffNIC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dgvStaffMembers);
            this.gbInfo.Controls.Add(this.txtAddress);
            this.gbInfo.Controls.Add(this.dtpDOB);
            this.gbInfo.Controls.Add(this.txtDesignation);
            this.gbInfo.Controls.Add(this.textBox3);
            this.gbInfo.Controls.Add(this.txtFName);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.pbImage);
            this.gbInfo.Controls.Add(this.lblAddress);
            this.gbInfo.Controls.Add(this.lblContactNo);
            this.gbInfo.Controls.Add(this.lblCNIC);
            this.gbInfo.Controls.Add(this.lblDesignation);
            this.gbInfo.Controls.Add(this.lblDOB);
            this.gbInfo.Controls.Add(this.lblFatherName);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.txtCNIC);
            this.gbInfo.Controls.Add(this.txtCellNo);
            this.gbInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(1, 78);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(455, 224);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Staff Information";
            // 
            // dgvStaffMembers
            // 
            this.dgvStaffMembers.AllowUserToAddRows = false;
            this.dgvStaffMembers.AllowUserToDeleteRows = false;
            this.dgvStaffMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffName,
            this.FatherName,
            this.Designation,
            this.ContactNo,
            this.Id,
            this.Remove});
            this.dgvStaffMembers.Location = new System.Drawing.Point(5, 0);
            this.dgvStaffMembers.Name = "dgvStaffMembers";
            this.dgvStaffMembers.ReadOnly = true;
            this.dgvStaffMembers.RowHeadersVisible = false;
            this.dgvStaffMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffMembers.Size = new System.Drawing.Size(448, 218);
            this.dgvStaffMembers.TabIndex = 15;
            this.dgvStaffMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffMembers_CellClick);
            this.dgvStaffMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffMembers_CellContentClick);
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "Name";
            this.StaffName.HeaderText = "Name";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // FatherName
            // 
            this.FatherName.DataPropertyName = "FatherName";
            this.FatherName.HeaderText = "Father Name";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            this.FatherName.Width = 110;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // ContactNo
            // 
            this.ContactNo.DataPropertyName = "ContactNo";
            this.ContactNo.HeaderText = "Contact No";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Image = global::MCKJ.Properties.Resources.DeleteRed;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Width = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(99, 182);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(350, 23);
            this.txtAddress.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(99, 104);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(87, 23);
            this.dtpDOB.TabIndex = 12;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(99, 144);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(118, 23);
            this.txtDesignation.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 10;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(99, 64);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(234, 23);
            this.txtFName.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(99, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 23);
            this.txtName.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(339, 29);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(110, 98);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(11, 185);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 15);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address: ";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(190, 107);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(52, 15);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "Cell No: ";
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNIC.Location = new System.Drawing.Point(236, 151);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(54, 15);
            this.lblCNIC.TabIndex = 4;
            this.lblCNIC.Text = "CNIC No:";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(11, 147);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(78, 15);
            this.lblDesignation.TabIndex = 3;
            this.lblDesignation.Text = "Designation: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(11, 107);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(82, 15);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth: ";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.Location = new System.Drawing.Point(11, 67);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(82, 15);
            this.lblFatherName.TabIndex = 1;
            this.lblFatherName.Text = "Father Name: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnViewAll);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(1, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 36);
            this.panel1.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(133, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(3, 6);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(214, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(376, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCellNo
            // 
            this.txtCellNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellNo.Location = new System.Drawing.Point(244, 104);
            this.txtCellNo.Mask = "0000-0000000";
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(89, 23);
            this.txtCellNo.TabIndex = 3;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(294, 144);
            this.txtCNIC.Mask = "00000-0000000-0";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(152, 23);
            this.txtCNIC.TabIndex = 5;
            // 
            // frmNICStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.pnlStaffNIC);
            this.Name = "frmNICStaff";
            this.Text = "frmNICStaff";
            this.Load += new System.EventHandler(this.frmNICStaff_Load);
            this.pnlStaffNIC.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStaffNIC;
        private System.Windows.Forms.Label lblStaffNIC;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dgvStaffMembers;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.MaskedTextBox txtCellNo;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
    }
}