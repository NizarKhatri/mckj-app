namespace MCKJ.Billing
{
    partial class BillingItemOptions
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemOptionId = new System.Windows.Forms.TextBox();
            this.lblBillingType = new System.Windows.Forms.Label();
            this.grpBoxBilling = new System.Windows.Forms.GroupBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBillItem = new System.Windows.Forms.TextBox();
            this.txtBillType = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBillItemOption = new System.Windows.Forms.Label();
            this.lblBillType = new System.Windows.Forms.Label();
            this.dgvItemOptions = new System.Windows.Forms.DataGridView();
            this.ItemOptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFormCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grpBoxBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemOptions)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtItemOptionId);
            this.panel1.Controls.Add(this.lblBillingType);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 49);
            this.panel1.TabIndex = 0;
            // 
            // txtItemOptionId
            // 
            this.txtItemOptionId.Location = new System.Drawing.Point(279, 11);
            this.txtItemOptionId.Name = "txtItemOptionId";
            this.txtItemOptionId.Size = new System.Drawing.Size(100, 20);
            this.txtItemOptionId.TabIndex = 1;
            this.txtItemOptionId.Visible = false;
            // 
            // lblBillingType
            // 
            this.lblBillingType.AutoSize = true;
            this.lblBillingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingType.Location = new System.Drawing.Point(10, 11);
            this.lblBillingType.Name = "lblBillingType";
            this.lblBillingType.Size = new System.Drawing.Size(76, 25);
            this.lblBillingType.TabIndex = 0;
            this.lblBillingType.Text = "label1";
            // 
            // grpBoxBilling
            // 
            this.grpBoxBilling.Controls.Add(this.txtItemCode);
            this.grpBoxBilling.Controls.Add(this.lblItemCode);
            this.grpBoxBilling.Controls.Add(this.btnCancel);
            this.grpBoxBilling.Controls.Add(this.txtPrice);
            this.grpBoxBilling.Controls.Add(this.btnSave);
            this.grpBoxBilling.Controls.Add(this.txtBillItem);
            this.grpBoxBilling.Controls.Add(this.txtBillType);
            this.grpBoxBilling.Controls.Add(this.lblPrice);
            this.grpBoxBilling.Controls.Add(this.lblBillItemOption);
            this.grpBoxBilling.Controls.Add(this.lblBillType);
            this.grpBoxBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxBilling.Location = new System.Drawing.Point(12, 56);
            this.grpBoxBilling.Name = "grpBoxBilling";
            this.grpBoxBilling.Size = new System.Drawing.Size(423, 194);
            this.grpBoxBilling.TabIndex = 1;
            this.grpBoxBilling.TabStop = false;
            this.grpBoxBilling.Text = "Information";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(109, 62);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(286, 22);
            this.txtItemCode.TabIndex = 1;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(11, 67);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(55, 13);
            this.lblItemCode.TabIndex = 7;
            this.lblItemCode.Text = "Item Code";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(109, 127);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(286, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(260, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBillItem
            // 
            this.txtBillItem.Location = new System.Drawing.Point(109, 94);
            this.txtBillItem.Name = "txtBillItem";
            this.txtBillItem.Size = new System.Drawing.Size(286, 22);
            this.txtBillItem.TabIndex = 2;
            // 
            // txtBillType
            // 
            this.txtBillType.Enabled = false;
            this.txtBillType.Location = new System.Drawing.Point(109, 30);
            this.txtBillType.Name = "txtBillType";
            this.txtBillType.Size = new System.Drawing.Size(286, 22);
            this.txtBillType.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(11, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price per Piece";
            // 
            // lblBillItemOption
            // 
            this.lblBillItemOption.AutoSize = true;
            this.lblBillItemOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillItemOption.Location = new System.Drawing.Point(11, 99);
            this.lblBillItemOption.Name = "lblBillItemOption";
            this.lblBillItemOption.Size = new System.Drawing.Size(70, 13);
            this.lblBillItemOption.TabIndex = 1;
            this.lblBillItemOption.Text = "Bill Type Item";
            // 
            // lblBillType
            // 
            this.lblBillType.AutoSize = true;
            this.lblBillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillType.Location = new System.Drawing.Point(11, 35);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(47, 13);
            this.lblBillType.TabIndex = 0;
            this.lblBillType.Text = "Bill Type";
            // 
            // dgvItemOptions
            // 
            this.dgvItemOptions.AllowUserToAddRows = false;
            this.dgvItemOptions.AllowUserToDeleteRows = false;
            this.dgvItemOptions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvItemOptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItemOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemOptionId,
            this.ItemCode,
            this.Category,
            this.OptionText,
            this.PricePerPiece});
            this.dgvItemOptions.Location = new System.Drawing.Point(12, 58);
            this.dgvItemOptions.MultiSelect = false;
            this.dgvItemOptions.Name = "dgvItemOptions";
            this.dgvItemOptions.ReadOnly = true;
            this.dgvItemOptions.RowHeadersVisible = false;
            this.dgvItemOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemOptions.Size = new System.Drawing.Size(423, 190);
            this.dgvItemOptions.TabIndex = 7;
            this.dgvItemOptions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemOptions_CellClick);
            // 
            // ItemOptionId
            // 
            this.ItemOptionId.DataPropertyName = "ID";
            this.ItemOptionId.HeaderText = "Item Option";
            this.ItemOptionId.Name = "ItemOptionId";
            this.ItemOptionId.ReadOnly = true;
            this.ItemOptionId.Visible = false;
            this.ItemOptionId.Width = 85;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "Item Code";
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 85;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 85;
            // 
            // OptionText
            // 
            this.OptionText.DataPropertyName = "Name";
            this.OptionText.HeaderText = "Name";
            this.OptionText.Name = "OptionText";
            this.OptionText.ReadOnly = true;
            this.OptionText.Width = 150;
            // 
            // PricePerPiece
            // 
            this.PricePerPiece.DataPropertyName = "Price";
            this.PricePerPiece.HeaderText = "Price";
            this.PricePerPiece.Name = "PricePerPiece";
            this.PricePerPiece.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnFormCancel);
            this.panel2.Location = new System.Drawing.Point(3, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(198, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(117, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Show All";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(279, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFormCancel
            // 
            this.btnFormCancel.Location = new System.Drawing.Point(360, 10);
            this.btnFormCancel.Name = "btnFormCancel";
            this.btnFormCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFormCancel.TabIndex = 0;
            this.btnFormCancel.Text = "Cancel";
            this.btnFormCancel.UseVisualStyleBackColor = true;
            this.btnFormCancel.Click += new System.EventHandler(this.btnFormCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BillingItemOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 298);
            this.Controls.Add(this.dgvItemOptions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBoxBilling);
            this.Name = "BillingItemOptions";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.BillingItemOptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBoxBilling.ResumeLayout(false);
            this.grpBoxBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemOptions)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxBilling;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBillItemOption;
        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBillItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFormCancel;
        public System.Windows.Forms.Label lblBillingType;
        public System.Windows.Forms.TextBox txtBillType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvItemOptions;
        private System.Windows.Forms.TextBox txtItemOptionId;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemOptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerPiece;
    }
}