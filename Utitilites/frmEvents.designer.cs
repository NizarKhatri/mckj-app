namespace MCKJ
{
    partial class frmEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvents));
            this.txtID = new System.Windows.Forms.TextBox();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset2 = new MCKJ.dataset2();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.DGArea = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblEventsTableAdapter = new MCKJ.dataset2TableAdapters.tblEventsTableAdapter();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGArea)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEventsBindingSource, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(40, 202);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 28;
            // 
            // tblEventsBindingSource
            // 
            this.tblEventsBindingSource.DataMember = "tblEvents";
            this.tblEventsBindingSource.DataSource = this.dataset2;
            // 
            // dataset2
            // 
            this.dataset2.DataSetName = "dataset2";
            this.dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(240, 111);
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
            this.btnCancel.Location = new System.Drawing.Point(240, 142);
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
            this.btnDelete.Location = new System.Drawing.Point(240, 80);
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
            this.btnEdit.Location = new System.Drawing.Point(240, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 23);
            this.btnEdit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DGArea
            // 
            this.DGArea.AllowUserToAddRows = false;
            this.DGArea.AllowUserToDeleteRows = false;
            this.DGArea.AutoGenerateColumns = false;
            this.DGArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.eventsDataGridViewTextBoxColumn});
            this.DGArea.DataSource = this.tblEventsBindingSource;
            this.DGArea.Location = new System.Drawing.Point(3, 18);
            this.DGArea.Name = "DGArea";
            this.DGArea.ReadOnly = true;
            this.DGArea.RowHeadersWidth = 25;
            this.DGArea.Size = new System.Drawing.Size(229, 178);
            this.DGArea.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eventsDataGridViewTextBoxColumn
            // 
            this.eventsDataGridViewTextBoxColumn.DataPropertyName = "Events";
            this.eventsDataGridViewTextBoxColumn.HeaderText = "Events";
            this.eventsDataGridViewTextBoxColumn.Name = "eventsDataGridViewTextBoxColumn";
            this.eventsDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventsDataGridViewTextBoxColumn.Width = 200;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageIndex = 5;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(240, 171);
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
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageKey = "NewDocumentHS.BMP";
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(239, 18);
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
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEventsBindingSource, "Events", true));
            this.txtName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(40, 202);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Event";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // tblEventsTableAdapter
            // 
            this.tblEventsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(-1, -1);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(287, 19);
            this.lbl.TabIndex = 385;
            this.lbl.Text = "Event";
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 245);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DGArea);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.frmArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView DGArea;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private dataset2 dataset2;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private MCKJ.dataset2TableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl;
    }
}