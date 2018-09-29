namespace MCKJ
{
    partial class frmAids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAids));
            this.btnClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAid = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAid = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset2 = new MCKJ.dataset2();
            this.tblAidsTableAdapter = new MCKJ.dataset2TableAdapters.tblAidsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageKey = "RestartHS.png";
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(246, 153);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageIndex = 0;
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(246, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 23);
            this.btnNew.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aid";
            // 
            // dgvAid
            // 
            this.dgvAid.AllowUserToAddRows = false;
            this.dgvAid.AllowUserToDeleteRows = false;
            this.dgvAid.AutoGenerateColumns = false;
            this.dgvAid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aidDataGridViewTextBoxColumn});
            this.dgvAid.DataSource = this.tblAidsBindingSource;
            this.dgvAid.Location = new System.Drawing.Point(12, 13);
            this.dgvAid.Name = "dgvAid";
            this.dgvAid.ReadOnly = true;
            this.dgvAid.RowHeadersWidth = 25;
            this.dgvAid.Size = new System.Drawing.Size(234, 163);
            this.dgvAid.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageIndex = 3;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(246, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 23);
            this.btnEdit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageKey = "DeleteHS.png";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(246, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 23);
            this.btnDelete.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageKey = "Edit_UndoHS.png";
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(246, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(28, 23);
            this.btnCancel.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageKey = "saveHS.bmp";
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(246, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 23);
            this.btnSave.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(76, 187);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(52, 20);
            this.txtID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nukh ID";
            this.label1.Visible = false;
            // 
            // txtAid
            // 
            this.txtAid.BackColor = System.Drawing.Color.White;
            this.txtAid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAidsBindingSource, "Aid", true));
            this.txtAid.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAid.Location = new System.Drawing.Point(47, 187);
            this.txtAid.Name = "txtAid";
            this.txtAid.Size = new System.Drawing.Size(194, 20);
            this.txtAid.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "Aid";
            this.aidDataGridViewTextBoxColumn.HeaderText = "Family Aid Types";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            this.aidDataGridViewTextBoxColumn.Width = 200;
            // 
            // tblAidsBindingSource
            // 
            this.tblAidsBindingSource.DataMember = "tblAids";
            this.tblAidsBindingSource.DataSource = this.dataset2;
            // 
            // dataset2
            // 
            this.dataset2.DataSetName = "dataset2";
            this.dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAidsTableAdapter
            // 
            this.tblAidsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 225);
            this.Controls.Add(this.dgvAid);
            this.Controls.Add(this.txtAid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAids";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAMILY AIDS";
            this.Load += new System.EventHandler(this.frmNukh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAid;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAid;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private dataset2 dataset2;
        private System.Windows.Forms.BindingSource tblAidsBindingSource;
        private MCKJ.dataset2TableAdapters.tblAidsTableAdapter tblAidsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
    }
}