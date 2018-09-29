namespace MCKJ.Reports.FamilyAid
{
    partial class frmFamilyAidReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAidFrom = new System.Windows.Forms.CheckBox();
            this.cmbAidFrom = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkByAidType = new System.Windows.Forms.CheckBox();
            this.chkByStatus = new System.Windows.Forms.CheckBox();
            this.chkByFamilyCard = new System.Windows.Forms.CheckBox();
            this.chkByOrakh = new System.Windows.Forms.CheckBox();
            this.txtFamilyCardNo = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbOrakh = new System.Windows.Forms.ComboBox();
            this.cmbAidType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAidFrom);
            this.groupBox1.Controls.Add(this.cmbAidFrom);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.chkByAidType);
            this.groupBox1.Controls.Add(this.chkByStatus);
            this.groupBox1.Controls.Add(this.chkByFamilyCard);
            this.groupBox1.Controls.Add(this.chkByOrakh);
            this.groupBox1.Controls.Add(this.txtFamilyCardNo);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbOrakh);
            this.groupBox1.Controls.Add(this.cmbAidType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // chkAidFrom
            // 
            this.chkAidFrom.AutoSize = true;
            this.chkAidFrom.Location = new System.Drawing.Point(464, 28);
            this.chkAidFrom.Name = "chkAidFrom";
            this.chkAidFrom.Size = new System.Drawing.Size(82, 17);
            this.chkAidFrom.TabIndex = 6;
            this.chkAidFrom.Text = "By Aid From";
            this.chkAidFrom.UseVisualStyleBackColor = true;
            this.chkAidFrom.CheckedChanged += new System.EventHandler(this.chkAidFrom_CheckedChanged);
            // 
            // cmbAidFrom
            // 
            this.cmbAidFrom.FormattingEnabled = true;
            this.cmbAidFrom.Items.AddRange(new object[] {
            "Zakat",
            "Poor Fund"});
            this.cmbAidFrom.Location = new System.Drawing.Point(553, 27);
            this.cmbAidFrom.Name = "cmbAidFrom";
            this.cmbAidFrom.Size = new System.Drawing.Size(107, 21);
            this.cmbAidFrom.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(553, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkByAidType
            // 
            this.chkByAidType.AutoSize = true;
            this.chkByAidType.Location = new System.Drawing.Point(18, 61);
            this.chkByAidType.Name = "chkByAidType";
            this.chkByAidType.Size = new System.Drawing.Size(83, 17);
            this.chkByAidType.TabIndex = 2;
            this.chkByAidType.Text = "By Aid Type";
            this.chkByAidType.UseVisualStyleBackColor = true;
            this.chkByAidType.CheckedChanged += new System.EventHandler(this.chkByAidType_CheckedChanged);
            // 
            // chkByStatus
            // 
            this.chkByStatus.AutoSize = true;
            this.chkByStatus.Location = new System.Drawing.Point(249, 60);
            this.chkByStatus.Name = "chkByStatus";
            this.chkByStatus.Size = new System.Drawing.Size(71, 17);
            this.chkByStatus.TabIndex = 2;
            this.chkByStatus.Text = "By Status";
            this.chkByStatus.UseVisualStyleBackColor = true;
            this.chkByStatus.CheckedChanged += new System.EventHandler(this.chkByStatus_CheckedChanged);
            // 
            // chkByFamilyCard
            // 
            this.chkByFamilyCard.AutoSize = true;
            this.chkByFamilyCard.Location = new System.Drawing.Point(18, 26);
            this.chkByFamilyCard.Name = "chkByFamilyCard";
            this.chkByFamilyCard.Size = new System.Drawing.Size(95, 17);
            this.chkByFamilyCard.TabIndex = 2;
            this.chkByFamilyCard.Text = "By Family Card";
            this.chkByFamilyCard.UseVisualStyleBackColor = true;
            this.chkByFamilyCard.CheckedChanged += new System.EventHandler(this.chkByFamilyCard_CheckedChanged);
            // 
            // chkByOrakh
            // 
            this.chkByOrakh.AutoSize = true;
            this.chkByOrakh.Location = new System.Drawing.Point(249, 25);
            this.chkByOrakh.Name = "chkByOrakh";
            this.chkByOrakh.Size = new System.Drawing.Size(70, 17);
            this.chkByOrakh.TabIndex = 2;
            this.chkByOrakh.Text = "By Orakh";
            this.chkByOrakh.UseVisualStyleBackColor = true;
            this.chkByOrakh.CheckedChanged += new System.EventHandler(this.chkByOrakh_CheckedChanged);
            // 
            // txtFamilyCardNo
            // 
            this.txtFamilyCardNo.Location = new System.Drawing.Point(113, 23);
            this.txtFamilyCardNo.Name = "txtFamilyCardNo";
            this.txtFamilyCardNo.Size = new System.Drawing.Size(100, 20);
            this.txtFamilyCardNo.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Work in Progress",
            "Pending",
            "Done",
            "Restricted",
            "Rejected"});
            this.cmbStatus.Location = new System.Drawing.Point(325, 61);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 3;
            // 
            // cmbOrakh
            // 
            this.cmbOrakh.FormattingEnabled = true;
            this.cmbOrakh.Location = new System.Drawing.Point(325, 24);
            this.cmbOrakh.Name = "cmbOrakh";
            this.cmbOrakh.Size = new System.Drawing.Size(121, 21);
            this.cmbOrakh.TabIndex = 1;
            // 
            // cmbAidType
            // 
            this.cmbAidType.FormattingEnabled = true;
            this.cmbAidType.Location = new System.Drawing.Point(113, 58);
            this.cmbAidType.Name = "cmbAidType";
            this.cmbAidType.Size = new System.Drawing.Size(121, 21);
            this.cmbAidType.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.crystalReportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 1);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
            this.groupBox2.Visible = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(669, 0);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frmFamilyAidReport
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 131);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmFamilyAidReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFamilyAidReport";
            this.Load += new System.EventHandler(this.frmFamilyAidReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFamilyCardNo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbOrakh;
        private System.Windows.Forms.ComboBox cmbAidType;
        private System.Windows.Forms.CheckBox chkByAidType;
        private System.Windows.Forms.CheckBox chkByStatus;
        private System.Windows.Forms.CheckBox chkByFamilyCard;
        private System.Windows.Forms.CheckBox chkByOrakh;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkAidFrom;
        private System.Windows.Forms.ComboBox cmbAidFrom;
    }
}