namespace MCKJ.Members
{
    partial class frmNIC_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNIC_2));
            this.txtCMIC1 = new System.Windows.Forms.MaskedTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtCMIC2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMIC3 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMIC4 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtCMIC1
            // 
            this.txtCMIC1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCMIC1.Location = new System.Drawing.Point(119, 18);
            this.txtCMIC1.Mask = "00000";
            this.txtCMIC1.Name = "txtCMIC1";
            this.txtCMIC1.Size = new System.Drawing.Size(41, 20);
            this.txtCMIC1.TabIndex = 0;
            this.txtCMIC1.Enter += new System.EventHandler(this.txtCMIC1_Enter);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(12, 21);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 14);
            this.label46.TabIndex = 319;
            this.label46.Text = "Community ID Card#";
            // 
            // txtCMIC2
            // 
            this.txtCMIC2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCMIC2.Location = new System.Drawing.Point(119, 44);
            this.txtCMIC2.Mask = "00000";
            this.txtCMIC2.Name = "txtCMIC2";
            this.txtCMIC2.Size = new System.Drawing.Size(41, 20);
            this.txtCMIC2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 321;
            this.label1.Text = "Community ID Card#";
            // 
            // txtCMIC3
            // 
            this.txtCMIC3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCMIC3.Location = new System.Drawing.Point(119, 70);
            this.txtCMIC3.Mask = "00000";
            this.txtCMIC3.Name = "txtCMIC3";
            this.txtCMIC3.Size = new System.Drawing.Size(41, 20);
            this.txtCMIC3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 323;
            this.label2.Text = "Community ID Card#";
            // 
            // txtCMIC4
            // 
            this.txtCMIC4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCMIC4.Location = new System.Drawing.Point(119, 96);
            this.txtCMIC4.Mask = "00000";
            this.txtCMIC4.Name = "txtCMIC4";
            this.txtCMIC4.Size = new System.Drawing.Size(41, 20);
            this.txtCMIC4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 14);
            this.label3.TabIndex = 325;
            this.label3.Text = "Community ID Card#";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(4, 122);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&Preview";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(85, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 352;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // frmNIC_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 157);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCMIC4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCMIC3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCMIC2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCMIC1);
            this.Controls.Add(this.label46);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNIC_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select NIC No.s";
            this.Load += new System.EventHandler(this.frmNIC_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCMIC1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.MaskedTextBox txtCMIC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCMIC3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCMIC4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}