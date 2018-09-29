namespace MCKJ.Events
{
    partial class frmEventCancellation
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.chkBxListHallNo = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCancellationDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEventDate);
            this.groupBox1.Controls.Add(this.chkBxListHallNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEventName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpCancellationDate);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnApprove);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Cancellation Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event Date";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(68, 180);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(82, 20);
            this.dtpEventDate.TabIndex = 9;
            // 
            // chkBxListHallNo
            // 
            this.chkBxListHallNo.FormattingEnabled = true;
            this.chkBxListHallNo.Location = new System.Drawing.Point(68, 57);
            this.chkBxListHallNo.Name = "chkBxListHallNo";
            this.chkBxListHallNo.Size = new System.Drawing.Size(120, 94);
            this.chkBxListHallNo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(68, 29);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(185, 20);
            this.txtEventName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cancellation Date";
            // 
            // dtpCancellationDate
            // 
            this.dtpCancellationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCancellationDate.Location = new System.Drawing.Point(171, 180);
            this.dtpCancellationDate.Name = "dtpCancellationDate";
            this.dtpCancellationDate.Size = new System.Drawing.Size(82, 20);
            this.dtpCancellationDate.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(188, 321);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remarks";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(68, 217);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(185, 87);
            this.txtComments.TabIndex = 12;
            // 
            // frmEventCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 387);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmEventCancellation";
            this.Text = "frmEventCancellation";
            this.Load += new System.EventHandler(this.frmEventCancellation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCancellationDate;
        private System.Windows.Forms.CheckedListBox chkBxListHallNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label5;
    }
}