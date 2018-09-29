namespace MCKJ.Reports.Staff_NIC
{
    partial class frmStaffNIC
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
            this.crvStaffNIC = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnShowBack = new System.Windows.Forms.Button();
            this.btnShowFront = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvStaffNIC
            // 
            this.crvStaffNIC.ActiveViewIndex = -1;
            this.crvStaffNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvStaffNIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvStaffNIC.Location = new System.Drawing.Point(0, 0);
            this.crvStaffNIC.Name = "crvStaffNIC";
            this.crvStaffNIC.SelectionFormula = "";
            this.crvStaffNIC.Size = new System.Drawing.Size(478, 388);
            this.crvStaffNIC.TabIndex = 0;
            this.crvStaffNIC.ViewTimeSelectionFormula = "";
            // 
            // btnShowBack
            // 
            this.btnShowBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowBack.Location = new System.Drawing.Point(400, 4);
            this.btnShowBack.Name = "btnShowBack";
            this.btnShowBack.Size = new System.Drawing.Size(75, 23);
            this.btnShowBack.TabIndex = 1;
            this.btnShowBack.Text = "Show Back";
            this.btnShowBack.UseVisualStyleBackColor = true;
            this.btnShowBack.Click += new System.EventHandler(this.btnShowBack_Click);
            // 
            // btnShowFront
            // 
            this.btnShowFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowFront.Location = new System.Drawing.Point(322, 4);
            this.btnShowFront.Name = "btnShowFront";
            this.btnShowFront.Size = new System.Drawing.Size(75, 23);
            this.btnShowFront.TabIndex = 2;
            this.btnShowFront.Text = "Show Front";
            this.btnShowFront.UseVisualStyleBackColor = true;
            this.btnShowFront.Click += new System.EventHandler(this.btnShowFront_Click);
            // 
            // frmStaffNIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 388);
            this.Controls.Add(this.btnShowFront);
            this.Controls.Add(this.btnShowBack);
            this.Controls.Add(this.crvStaffNIC);
            this.Name = "frmStaffNIC";
            this.Text = "frmStaffNIC";
            this.Load += new System.EventHandler(this.frmStaffNIC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvStaffNIC;
        private System.Windows.Forms.Button btnShowBack;
        private System.Windows.Forms.Button btnShowFront;

    }
}