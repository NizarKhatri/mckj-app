namespace MCKJ
{
    partial class frmHallAmt
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
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH1 = new System.Windows.Forms.TextBox();
            this.tblHallAmtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset3 = new MCKJ.dataset3();
            this.txtH2 = new System.Windows.Forms.TextBox();
            this.txtH3 = new System.Windows.Forms.TextBox();
            this.txtH4 = new System.Windows.Forms.TextBox();
            this.tblHallAmtTableAdapter = new MCKJ.dataset3TableAdapters.tblHallAmtTableAdapter();
            this.txtH5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAmtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(161, 66);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 0;
            this.btnUpd.Text = "&Edit";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 97);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hall 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hall 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hall 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hall 4:";
            // 
            // txtH1
            // 
            this.txtH1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHallAmtBindingSource, "H1", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtH1.Enabled = false;
            this.txtH1.Location = new System.Drawing.Point(55, 21);
            this.txtH1.Name = "txtH1";
            this.txtH1.Size = new System.Drawing.Size(100, 20);
            this.txtH1.TabIndex = 6;
            this.txtH1.Text = "0.00";
            this.txtH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tblHallAmtBindingSource
            // 
            this.tblHallAmtBindingSource.DataMember = "tblHallAmt";
            this.tblHallAmtBindingSource.DataSource = this.dataset3;
            // 
            // dataset3
            // 
            this.dataset3.DataSetName = "dataset3";
            this.dataset3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtH2
            // 
            this.txtH2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHallAmtBindingSource, "H2", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtH2.Enabled = false;
            this.txtH2.Location = new System.Drawing.Point(55, 47);
            this.txtH2.Name = "txtH2";
            this.txtH2.Size = new System.Drawing.Size(100, 20);
            this.txtH2.TabIndex = 7;
            this.txtH2.Text = "0.00";
            this.txtH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtH3
            // 
            this.txtH3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHallAmtBindingSource, "H3", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtH3.Enabled = false;
            this.txtH3.Location = new System.Drawing.Point(55, 73);
            this.txtH3.Name = "txtH3";
            this.txtH3.Size = new System.Drawing.Size(100, 20);
            this.txtH3.TabIndex = 8;
            this.txtH3.Text = "0.00";
            this.txtH3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtH4
            // 
            this.txtH4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHallAmtBindingSource, "H4", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtH4.Enabled = false;
            this.txtH4.Location = new System.Drawing.Point(55, 99);
            this.txtH4.Name = "txtH4";
            this.txtH4.Size = new System.Drawing.Size(100, 20);
            this.txtH4.TabIndex = 9;
            this.txtH4.Text = "0.00";
            this.txtH4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tblHallAmtTableAdapter
            // 
            this.tblHallAmtTableAdapter.ClearBeforeFill = true;
            // 
            // txtH5
            // 
            this.txtH5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblHallAmtBindingSource, "H4", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtH5.Enabled = false;
            this.txtH5.Location = new System.Drawing.Point(55, 125);
            this.txtH5.Name = "txtH5";
            this.txtH5.Size = new System.Drawing.Size(100, 20);
            this.txtH5.TabIndex = 11;
            this.txtH5.Text = "0.00";
            this.txtH5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hall 5:";
            // 
            // frmHallAmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 155);
            this.Controls.Add(this.txtH5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtH4);
            this.Controls.Add(this.txtH3);
            this.Controls.Add(this.txtH2);
            this.Controls.Add(this.txtH1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHallAmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall Amount";
            this.Load += new System.EventHandler(this.frmHallAmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHallAmtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH1;
        private System.Windows.Forms.TextBox txtH2;
        private System.Windows.Forms.TextBox txtH3;
        private System.Windows.Forms.TextBox txtH4;
        private dataset3 dataset3;
        private System.Windows.Forms.BindingSource tblHallAmtBindingSource;
        private MCKJ.dataset3TableAdapters.tblHallAmtTableAdapter tblHallAmtTableAdapter;
        private System.Windows.Forms.TextBox txtH5;
        private System.Windows.Forms.Label label5;
    }
}