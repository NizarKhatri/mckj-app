namespace MCKJ.Reports.Billing
{
    partial class frmReportBilling
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
            this.crvBilling = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBilling
            // 
            this.crvBilling.ActiveViewIndex = -1;
            this.crvBilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBilling.Location = new System.Drawing.Point(0, 0);
            this.crvBilling.Name = "crvBilling";
            this.crvBilling.SelectionFormula = "";
            this.crvBilling.Size = new System.Drawing.Size(704, 634);
            this.crvBilling.TabIndex = 0;
            this.crvBilling.ViewTimeSelectionFormula = "";
            // 
            // frmReportBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 634);
            this.Controls.Add(this.crvBilling);
            this.Name = "frmReportBilling";
            this.Text = "frmReportBilling";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvBilling;

    }
}