namespace MCKJ
{
    partial class chk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chk));
            this.label1 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comDataSet = new MCKJ.ComDataSet();
            this.uspSELEngagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_EngagementTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_EngagementTableAdapter();
            this.uspSELMarriageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_MarriageTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_MarriageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELEngagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELMarriageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(103, 12);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(121, 20);
            this.txtReason.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(139, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspSELEngagementBindingSource
            // 
            this.uspSELEngagementBindingSource.DataMember = "usp_SEL_Engagement";
            this.uspSELEngagementBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_EngagementTableAdapter
            // 
            this.usp_SEL_EngagementTableAdapter.ClearBeforeFill = true;
            // 
            // uspSELMarriageBindingSource
            // 
            this.uspSELMarriageBindingSource.DataMember = "usp_SEL_Marriage";
            this.uspSELMarriageBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_MarriageTableAdapter
            // 
            this.usp_SEL_MarriageTableAdapter.ClearBeforeFill = true;
            // 
            // chk
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(273, 74);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reason";
            this.Load += new System.EventHandler(this.chk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELEngagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELMarriageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource uspSELEngagementBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_EngagementTableAdapter usp_SEL_EngagementTableAdapter;
        private System.Windows.Forms.BindingSource uspSELMarriageBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_MarriageTableAdapter usp_SEL_MarriageTableAdapter;

    }
}