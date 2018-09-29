namespace MCKJ.FamilyCard
{
    partial class frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRestricted = new System.Windows.Forms.RadioButton();
            this.rdbCancel = new System.Windows.Forms.RadioButton();
            this.comDataSet = new MCKJ.ComDataSet();
            this.uspSELFAMILYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_FAMILYTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_FAMILYTableAdapter();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELFAMILYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reason";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(62, 91);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(163, 20);
            this.txtReason.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRestricted);
            this.groupBox1.Controls.Add(this.rdbCancel);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rdbRestricted
            // 
            this.rdbRestricted.AutoSize = true;
            this.rdbRestricted.Location = new System.Drawing.Point(122, 19);
            this.rdbRestricted.Name = "rdbRestricted";
            this.rdbRestricted.Size = new System.Drawing.Size(73, 17);
            this.rdbRestricted.TabIndex = 1;
            this.rdbRestricted.TabStop = true;
            this.rdbRestricted.Text = "Restricted";
            this.rdbRestricted.UseVisualStyleBackColor = true;
            // 
            // rdbCancel
            // 
            this.rdbCancel.AutoSize = true;
            this.rdbCancel.Location = new System.Drawing.Point(21, 19);
            this.rdbCancel.Name = "rdbCancel";
            this.rdbCancel.Size = new System.Drawing.Size(58, 17);
            this.rdbCancel.TabIndex = 0;
            this.rdbCancel.TabStop = true;
            this.rdbCancel.Text = "Cancel";
            this.rdbCancel.UseVisualStyleBackColor = true;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspSELFAMILYBindingSource
            // 
            this.uspSELFAMILYBindingSource.DataMember = "usp_SEL_FAMILY";
            this.uspSELFAMILYBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_FAMILYTableAdapter
            // 
            this.usp_SEL_FAMILYTableAdapter.ClearBeforeFill = true;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(-1, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(277, 19);
            this.lbl.TabIndex = 384;
            this.lbl.Text = "Family Cards>>Cancellation";
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 151);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musalman Cutchi Khatri Jamat";
            this.Load += new System.EventHandler(this.frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELFAMILYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRestricted;
        private System.Windows.Forms.RadioButton rdbCancel;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource uspSELFAMILYBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_FAMILYTableAdapter usp_SEL_FAMILYTableAdapter;
        private System.Windows.Forms.Label lbl;
    }
}