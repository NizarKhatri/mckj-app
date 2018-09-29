namespace MCKJ.Reports.Family_Card
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.comDataSet = new MCKJ.ComDataSet();
            this.uspSELtblNukhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSELtblVillageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSELtblOrakhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSELtblCityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspSELtblAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_tblNukhTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblNukhTableAdapter();
            this.usp_SEL_tblVillageTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblVillageTableAdapter();
            this.usp_SEL_tblOrakhTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblOrakhTableAdapter();
            this.usp_SEL_tblCityTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblCityTableAdapter();
            this.usp_SEL_tblAreaTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblAreaTableAdapter();
            this.uspSELtblWorkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_SEL_tblWorkTypeTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblWorkTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblNukhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblVillageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblCityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblAreaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblWorkTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(165, 39);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(84, 39);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report By:";
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(95, 12);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(145, 21);
            this.cmbSearch.TabIndex = 0;
            this.cmbSearch.Leave += new System.EventHandler(this.cmbSearch_Leave);
            this.cmbSearch.TextChanged += new System.EventHandler(this.cmbSearch_TextChanged);
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspSELtblNukhBindingSource
            // 
            this.uspSELtblNukhBindingSource.DataMember = "usp_SEL_tblNukh";
            this.uspSELtblNukhBindingSource.DataSource = this.comDataSet;
            // 
            // uspSELtblVillageBindingSource
            // 
            this.uspSELtblVillageBindingSource.DataMember = "usp_SEL_tblVillage";
            this.uspSELtblVillageBindingSource.DataSource = this.comDataSet;
            // 
            // uspSELtblOrakhBindingSource
            // 
            this.uspSELtblOrakhBindingSource.DataMember = "usp_SEL_tblOrakh";
            this.uspSELtblOrakhBindingSource.DataSource = this.comDataSet;
            // 
            // uspSELtblCityBindingSource
            // 
            this.uspSELtblCityBindingSource.DataMember = "usp_SEL_tblCity";
            this.uspSELtblCityBindingSource.DataSource = this.comDataSet;
            // 
            // uspSELtblAreaBindingSource
            // 
            this.uspSELtblAreaBindingSource.DataMember = "usp_SEL_tblArea";
            this.uspSELtblAreaBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_tblNukhTableAdapter
            // 
            this.usp_SEL_tblNukhTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_tblVillageTableAdapter
            // 
            this.usp_SEL_tblVillageTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_tblOrakhTableAdapter
            // 
            this.usp_SEL_tblOrakhTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_tblCityTableAdapter
            // 
            this.usp_SEL_tblCityTableAdapter.ClearBeforeFill = true;
            // 
            // usp_SEL_tblAreaTableAdapter
            // 
            this.usp_SEL_tblAreaTableAdapter.ClearBeforeFill = true;
            // 
            // uspSELtblWorkTypeBindingSource
            // 
            this.uspSELtblWorkTypeBindingSource.DataMember = "usp_SEL_tblWorkType";
            this.uspSELtblWorkTypeBindingSource.DataSource = this.comDataSet;
            // 
            // usp_SEL_tblWorkTypeTableAdapter
            // 
            this.usp_SEL_tblWorkTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 70);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Cards";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblNukhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblVillageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblOrakhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblCityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblAreaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblWorkTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbSearch;
        public ComDataSet comDataSet;
        public System.Windows.Forms.BindingSource uspSELtblNukhBindingSource;
        public System.Windows.Forms.BindingSource uspSELtblVillageBindingSource;
        public System.Windows.Forms.BindingSource uspSELtblOrakhBindingSource;
        public System.Windows.Forms.BindingSource uspSELtblCityBindingSource;
        public System.Windows.Forms.BindingSource uspSELtblAreaBindingSource;
        public MCKJ.ComDataSetTableAdapters.usp_SEL_tblNukhTableAdapter usp_SEL_tblNukhTableAdapter;
        public MCKJ.ComDataSetTableAdapters.usp_SEL_tblVillageTableAdapter usp_SEL_tblVillageTableAdapter;
        public MCKJ.ComDataSetTableAdapters.usp_SEL_tblOrakhTableAdapter usp_SEL_tblOrakhTableAdapter;
        public MCKJ.ComDataSetTableAdapters.usp_SEL_tblCityTableAdapter usp_SEL_tblCityTableAdapter;
        public MCKJ.ComDataSetTableAdapters.usp_SEL_tblAreaTableAdapter usp_SEL_tblAreaTableAdapter;
        public System.Windows.Forms.BindingSource uspSELtblWorkTypeBindingSource;
        public MCKJ.ComDataSetTableAdapters.usp_SEL_tblWorkTypeTableAdapter usp_SEL_tblWorkTypeTableAdapter;
    }
}