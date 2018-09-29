namespace MCKJ.Account
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRestricted = new System.Windows.Forms.RadioButton();
            this.rdbCancel = new System.Windows.Forms.RadioButton();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comDataSet = new MCKJ.ComDataSet();
            this.uspSELFAMILYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_FAMILYTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_FAMILYTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELFAMILYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRestricted);
            this.groupBox1.Controls.Add(this.rdbCancel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rdbRestricted
            // 
            this.rdbRestricted.AutoSize = true;
            this.rdbRestricted.Location = new System.Drawing.Point(70, 23);
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
            this.rdbCancel.Location = new System.Drawing.Point(6, 23);
            this.rdbCancel.Name = "rdbCancel";
            this.rdbCancel.Size = new System.Drawing.Size(58, 17);
            this.rdbCancel.TabIndex = 0;
            this.rdbCancel.TabStop = true;
            this.rdbCancel.Text = "Cancel";
            this.rdbCancel.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(57, 67);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(100, 20);
            this.txtReason.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reason";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(95, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
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
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELFAMILYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRestricted;
        private System.Windows.Forms.RadioButton rdbCancel;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource uspSELFAMILYBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_FAMILYTableAdapter usp_SEL_FAMILYTableAdapter;
    }
}