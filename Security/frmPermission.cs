using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmPermission : Form
    {
        public frmPermission()
        {
            InitializeComponent();
        }
      //  int mode = 0;
        private void frmPermission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblSecurityLevel' table. You can move, or remove it, as needed.
            this.tblSecurityLevelTableAdapter.Fill(this.comDataSet.tblSecurityLevel);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_DDL_USER' table. You can move, or remove it, as needed.
            this.usp_SEL_DDL_USERTableAdapter.Fill(this.comDataSet.usp_SEL_DDL_USER);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblPermission' table. You can move, or remove it, as needed.
            this.usp_SEL_tblPermissionTableAdapter.Fill(this.comDataSet.usp_SEL_tblPermission);

        }

        private bool CheckField()
        {
            if (cmbUserID.Text== "" || cmbSecutrityLevelID.Text == "")
            {
                MessageBox.Show("Fields cannot be empty");
                return false;
            }
            else
                return true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnNew.Visible = false;
            btnSave.Visible = true;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            cmbSecutrityLevelID.SelectedItem = null;
            cmbUserID.SelectedItem = null;
            cmbSecutrityLevelID.Enabled = true; ;
            cmbUserID.Enabled= true;
            DGPermission.Enabled = false;
          //  mode = 1;
            chkActive.Enabled = true;
            chkDelete.Enabled = true;
            chkEdit.Enabled = true;
            chkRead.Enabled = true;
            chkWrite.Enabled = true;
           
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnNew.Visible = false;
            btnSave.Visible = true;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            cmbSecutrityLevelID.Enabled = true; 
            cmbUserID.Enabled = true;
            DGPermission.Enabled = false;
            //mode = 1;
            chkActive.Enabled = true;
            chkDelete.Enabled = true;
            chkEdit.Enabled = true;
            chkRead.Enabled = true;
            chkWrite.Enabled = true;
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                usp_SEL_tblPermissionTableAdapter.DeletePermission(Convert.ToInt32(txtPermissionID.Text));
                usp_SEL_tblPermissionTableAdapter.Fill(comDataSet.usp_SEL_tblPermission);
                MessageBox.Show("Deleted Succesfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnNew.Visible = true;
            btnSave.Visible = false;
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            cmbSecutrityLevelID.Enabled = false;
            cmbUserID.Enabled = false;
            DGPermission.Enabled =true;
          //  mode = 0;
            chkActive.Enabled = false;
            chkDelete.Enabled = false;
            chkEdit.Enabled = false;
            chkRead.Enabled = false;
            chkWrite.Enabled = false;
            
        }
    }
}