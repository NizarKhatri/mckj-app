namespace MCKJ.Utitilites
{
    partial class frmFCardRenewalAmt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFCardRenewalAmt));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMemberFee = new System.Windows.Forms.TextBox();
            this.txtCardRenewalFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvFCardRenewal = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFCardRenewal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(359, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(207, 165);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(283, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtMemberFee
            // 
            this.txtMemberFee.Enabled = false;
            this.txtMemberFee.Location = new System.Drawing.Point(107, 194);
            this.txtMemberFee.Name = "txtMemberFee";
            this.txtMemberFee.Size = new System.Drawing.Size(88, 20);
            this.txtMemberFee.TabIndex = 16;
            this.txtMemberFee.Text = "0.00";
            this.txtMemberFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCardRenewalFee
            // 
            this.txtCardRenewalFee.Enabled = false;
            this.txtCardRenewalFee.Location = new System.Drawing.Point(107, 168);
            this.txtCardRenewalFee.Name = "txtCardRenewalFee";
            this.txtCardRenewalFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCardRenewalFee.Size = new System.Drawing.Size(88, 20);
            this.txtCardRenewalFee.TabIndex = 15;
            this.txtCardRenewalFee.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Card Renewal Fee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Member Fee";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(359, 194);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvFCardRenewal
            // 
            this.dgvFCardRenewal.AllowUserToAddRows = false;
            this.dgvFCardRenewal.AllowUserToDeleteRows = false;
            this.dgvFCardRenewal.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFCardRenewal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFCardRenewal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFCardRenewal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFCardRenewal.Location = new System.Drawing.Point(9, 12);
            this.dgvFCardRenewal.Name = "dgvFCardRenewal";
            this.dgvFCardRenewal.ReadOnly = true;
            this.dgvFCardRenewal.RowHeadersWidth = 10;
            this.dgvFCardRenewal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFCardRenewal.Size = new System.Drawing.Size(420, 148);
            this.dgvFCardRenewal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Late Fee";
            // 
            // txtLateFee
            // 
            this.txtLateFee.Enabled = false;
            this.txtLateFee.Location = new System.Drawing.Point(107, 220);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.Size = new System.Drawing.Size(88, 20);
            this.txtLateFee.TabIndex = 16;
            this.txtLateFee.Text = "0.00";
            this.txtLateFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmFCardRenewalAmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(438, 242);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.txtMemberFee);
            this.Controls.Add(this.txtCardRenewalFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFCardRenewal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFCardRenewalAmt";
            this.Text = "Family Card Renewal Fee";
            this.Load += new System.EventHandler(this.frmFCardRenewalAmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFCardRenewal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMemberFee;
        private System.Windows.Forms.TextBox txtCardRenewalFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvFCardRenewal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLateFee;
    }
}