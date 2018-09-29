namespace MCKJ
{
    partial class frmBakup
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
            this.cmbSyName = new System.Windows.Forms.ComboBox();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSyName
            // 
            this.cmbSyName.FormattingEnabled = true;
            this.cmbSyName.Location = new System.Drawing.Point(46, 58);
            this.cmbSyName.Name = "cmbSyName";
            this.cmbSyName.Size = new System.Drawing.Size(191, 21);
            this.cmbSyName.TabIndex = 0;
            //this.cmbSyName.SelectedIndexChanged += new System.EventHandler(this.cmbSyName_SelectedIndexChanged);
            // 
            // cmbServices
            // 
            this.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(46, 31);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(191, 21);
            this.cmbServices.Sorted = true;
            this.cmbServices.TabIndex = 1;
            //this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(46, 85);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(191, 20);
            this.txtStatus.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(243, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBakup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 181);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.cmbSyName);
            this.Name = "frmBakup";
            this.Text = "frmBakup";
            this.Load += new System.EventHandler(this.frmBakup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSyName;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}