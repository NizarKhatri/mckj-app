namespace MCKJ.Reports.Members
{
    partial class frmViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewer));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnNICback = new System.Windows.Forms.Button();
            this.btnShowNicFront = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(586, 349);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // btnNICback
            // 
            this.btnNICback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNICback.Location = new System.Drawing.Point(470, 2);
            this.btnNICback.Name = "btnNICback";
            this.btnNICback.Size = new System.Drawing.Size(104, 23);
            this.btnNICback.TabIndex = 1;
            this.btnNICback.Text = "Show NIC Back";
            this.btnNICback.UseVisualStyleBackColor = true;
            this.btnNICback.Click += new System.EventHandler(this.btnNICback_Click);
            // 
            // btnShowNicFront
            // 
            this.btnShowNicFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowNicFront.Location = new System.Drawing.Point(360, 2);
            this.btnShowNicFront.Name = "btnShowNicFront";
            this.btnShowNicFront.Size = new System.Drawing.Size(104, 23);
            this.btnShowNicFront.TabIndex = 2;
            this.btnShowNicFront.Text = "Show NIC Front";
            this.btnShowNicFront.UseVisualStyleBackColor = true;
            this.btnShowNicFront.Click += new System.EventHandler(this.btnShowNicFront_Click);
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 349);
            this.Controls.Add(this.btnShowNicFront);
            this.Controls.Add(this.btnNICback);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewer";
            this.Text = "Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnNICback;
        private System.Windows.Forms.Button btnShowNicFront;

    }
}