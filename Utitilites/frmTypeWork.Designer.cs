namespace MCKJ
{
    partial class frmTypeWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypeWork));
            this.txtID = new System.Windows.Forms.TextBox();
            this.uspSELtblWorkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comDataSet = new MCKJ.ComDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.DGType = new System.Windows.Forms.DataGridView();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usp_SEL_tblWorkTypeTableAdapter = new MCKJ.ComDataSetTableAdapters.usp_SEL_tblWorkTypeTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblWorkTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELtblWorkTypeBindingSource, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(87, 190);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 0;
            // 
            // uspSELtblWorkTypeBindingSource
            // 
            this.uspSELtblWorkTypeBindingSource.DataMember = "usp_SEL_tblWorkType";
            this.uspSELtblWorkTypeBindingSource.DataSource = this.comDataSet;
            // 
            // comDataSet
            // 
            this.comDataSet.DataSetName = "ComDataSet";
            this.comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(244, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 23);
            this.btnSave.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "NewDocumentHS.BMP");
            this.imageList1.Images.SetKeyName(1, "saveHS.bmp");
            this.imageList1.Images.SetKeyName(2, "DeleteHS.png");
            this.imageList1.Images.SetKeyName(3, "EditInformationHS.BMP");
            this.imageList1.Images.SetKeyName(4, "Edit_UndoHS.png");
            this.imageList1.Images.SetKeyName(5, "RestartHS.png");
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageIndex = 4;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(244, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(28, 23);
            this.btnCancel.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(244, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 23);
            this.btnDelete.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageIndex = 3;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(244, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 23);
            this.btnEdit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DGType
            // 
            this.DGType.AllowUserToAddRows = false;
            this.DGType.AllowUserToDeleteRows = false;
            this.DGType.AutoGenerateColumns = false;
            this.DGType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workTypeDataGridViewTextBoxColumn});
            this.DGType.DataSource = this.uspSELtblWorkTypeBindingSource;
            this.DGType.Location = new System.Drawing.Point(12, 12);
            this.DGType.Name = "DGType";
            this.DGType.ReadOnly = true;
            this.DGType.RowHeadersWidth = 25;
            this.DGType.Size = new System.Drawing.Size(229, 166);
            this.DGType.TabIndex = 7;
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            this.workTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.workTypeDataGridViewTextBoxColumn.Width = 185;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageIndex = 5;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(244, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageIndex = 0;
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(244, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 23);
            this.btnNew.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspSELtblWorkTypeBindingSource, "WorkType", true));
            this.txtName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(87, 190);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Type of Work";
            // 
            // usp_SEL_tblWorkTypeTableAdapter
            // 
            this.usp_SEL_tblWorkTypeTableAdapter.ClearBeforeFill = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // frmTypeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 225);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.DGType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTypeWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type of Work";
            this.Load += new System.EventHandler(this.frmCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspSELtblWorkTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView DGType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private ComDataSet comDataSet;
        private System.Windows.Forms.BindingSource uspSELtblWorkTypeBindingSource;
        private MCKJ.ComDataSetTableAdapters.usp_SEL_tblWorkTypeTableAdapter usp_SEL_tblWorkTypeTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
    }
}