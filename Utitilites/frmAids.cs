using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmAids : Form
    {
        int mode = 0;
        string Old = "";
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 15;
        int ID = 0;
        public frmAids()
        {
            InitializeComponent();
        }
        private void frmNukh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset2.tblAids' table. You can move, or remove it, as needed.
            this.tblAidsTableAdapter.Fill(this.dataset2.tblAids);
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
                btnEdit.Enabled = true;
            else
                btnEdit.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnNew.Enabled = true;
            else
                btnNew.Enabled = false;

            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblNukh' table. You can move, or remove it, as needed.
            AcceptButton = btnNew;
        }
    
        private bool CheckField()
        {
            if (txtAid.Text == "")
            {
                MessageBox.Show("Name field could not be left blank!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Focus();
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtAid.Text = "";
            txtID.Text = "<Auto Number>";
            txtAid.ReadOnly = false;
            dgvAid.Enabled = false;
            mode = 1;
            btnClose.Hide();
            AcceptButton = btnSave;
        }
      
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Focus();
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtAid.ReadOnly = false;
            mode = 0;
            btnClose.Hide();
            Old = txtAid.Text;
            dgvAid.Enabled = false;
            AcceptButton = btnSave;
            ID =Convert.ToInt32(dgvAid.CurrentRow.Cells[0].Value.ToString());

        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            bool CHK = DBLayer.CHK_B4_DEL_NUKH(txtAid.Text);
            if (CHK)
            {
                MessageBox.Show("Cannot Delete! Already in use", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dgvAid.CurrentRow.Cells[0].Value);
                    tblAidsTableAdapter.DeleteAid(ID);
                    tblAidsTableAdapter.Fill(dataset2.tblAids);
                    MessageBox.Show("Deleted Succesfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            txtAid.ReadOnly = true;
            tblAidsTableAdapter.Fill(dataset2.tblAids);
            mode = 0;
            btnClose.Show();
            dgvAid.Enabled = true;
            AcceptButton = btnNew;                        
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Result = DBLayer.CHK_Nukh(txtAid.Text);
            if (CheckField())
            {
                try
                {
                    if (mode == 1)
                    {
                        if (Result)
                             MessageBox.Show(txtAid.Text + " Already Exist!", "Duplicate",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        else
                        {
                            tblAidsTableAdapter.NewAid(txtAid.Text);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtAid.ReadOnly = true;
                            tblAidsTableAdapter.Fill(dataset2.tblAids);
                            mode = 0;
                            dgvAid.Enabled = true;
                            btnClose.Show();
                            MessageBox.Show("Saved Succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 0)
                    {
                        if (Old == txtAid.Text)
                        {
                            tblAidsTableAdapter.UpdateAid(txtAid.Text,ID);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtAid.ReadOnly = true;
                            tblAidsTableAdapter.Fill(dataset2.tblAids);
                            mode = 0;
                            btnClose.Show();
                            dgvAid.Enabled = true;
                            MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (Result)
                                MessageBox.Show(txtAid.Text + " Already Exist!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            else
                            {
                                tblAidsTableAdapter.UpdateAid(txtAid.Text, ID);
                                btnCancel.Enabled = false;
                                btnNew.Enabled = true;
                                btnSave.Enabled = false;
                                btnDelete.Enabled = true;
                                btnEdit.Enabled = true;
                                txtAid.ReadOnly = true;
                                tblAidsTableAdapter.Fill(dataset2.tblAids);
                                mode = 0;
                                btnClose.Show();
                                dgvAid.Enabled = true;
                                MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AcceptButton = btnNew;
            }
        }

   }
}