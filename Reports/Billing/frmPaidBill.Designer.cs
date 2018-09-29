namespace MCKJ.Reports.Billing
{
    partial class frmPaidBill
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbUnPaid = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(91, 65);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(172, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(12, 7);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(67, 17);
            this.rbPaid.TabIndex = 2;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Paid Bills";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // rbUnPaid
            // 
            this.rbUnPaid.AutoSize = true;
            this.rbUnPaid.Location = new System.Drawing.Point(12, 30);
            this.rbUnPaid.Name = "rbUnPaid";
            this.rbUnPaid.Size = new System.Drawing.Size(80, 17);
            this.rbUnPaid.TabIndex = 3;
            this.rbUnPaid.TabStop = true;
            this.rbUnPaid.Text = "Unpaid Bills";
            this.rbUnPaid.UseVisualStyleBackColor = true;
            // 
            // frmPaidBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 100);
            this.Controls.Add(this.rbUnPaid);
            this.Controls.Add(this.rbPaid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPaidBill";
            this.Text = "OUTSTANDING REPORT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbUnPaid;
    }
}