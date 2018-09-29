using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmTypeWork : Form
    {
        public frmTypeWork()
        {
            InitializeComponent();
        }
        int mode = 0;
        string Old = "";
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 15;
        private void frmCity_Load(object sender, EventArgs e)
        {
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

            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblWorkType' table. You can move, or remove it, as needed.
            this.usp_SEL_tblWorkTypeTableAdapter.Fill(this.comDataSet.usp_SEL_tblWorkType);
            AcceptButton = btnNew;
            uspSELtblWorkTypeBindingSource.Filter = "WorkType <> ''";
        }
      
        private bool CheckField()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name field could not be left blank!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;

        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Result = DBLayer.CHK_Type(txtName.Text);
            if (CheckField())

            {
                try
                {
                    if (mode == 1)
                    {
                        if (Result)
                        {
                            MessageBox.Show(txtName.Text + " Already Exist!", "Error");
                        }
                        else
                        {
                            usp_SEL_tblWorkTypeTableAdapter.Insert1(txtName.Text);
                            usp_SEL_tblWorkTypeTableAdapter.Fill(comDataSet.usp_SEL_tblWorkType);
                            MessageBox.Show("Saved Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            mode = 0;
                            DGType.Enabled = true;
                        }
                    }
                    else if (mode == 0)
                    {
                        if (txtName.Text == Old)
                        {
                            usp_SEL_tblWorkTypeTableAdapter.Update1(txtName.Text, Old);
                            usp_SEL_tblWorkTypeTableAdapter.Fill(comDataSet.usp_SEL_tblWorkType);
                            MessageBox.Show("Modified Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            mode = 0;
                            DGType.Enabled = true;
                        }
                        else
                        {
                            if (Result)
                            {
                                MessageBox.Show(txtName.Text + " Already Exist!","Error");
                            }
                            else
                            {
                                usp_SEL_tblWorkTypeTableAdapter.Update1(txtName.Text, Old);
                                usp_SEL_tblWorkTypeTableAdapter.Fill(comDataSet.usp_SEL_tblWorkType);
                                MessageBox.Show("Modified Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                btnCancel.Enabled = false;
                                btnNew.Enabled = true;
                                btnSave.Enabled = false;
                                btnDelete.Enabled = true;
                                btnEdit.Enabled = true;
                                txtName.ReadOnly = true;
                                mode = 0;
                                DGType.Enabled = true;
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
      
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtName.Text = "";
            txtID.Text = "<Auto Number>";
            txtName.ReadOnly = false;
            DGType.Enabled = false;
            mode = 1;
            AcceptButton = btnSave;
        }
      
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtName.ReadOnly = false;
            mode = 0;
            DGType.Enabled = false;
            Old = txtName.Text;
            AcceptButton = btnSave;
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }
    
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool CHK2 = DBLayer.CHK_B4_DEL_Type1(txtName.Text);
            bool CHK = DBLayer.CHK_B4_DEL_Type(txtName.Text);
            if (CHK == true || CHK2 == true)
            {
                MessageBox.Show("Cannot Delete! Already in use", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usp_SEL_tblWorkTypeTableAdapter.Delete1(Convert.ToInt32(txtID.Text));
                    usp_SEL_tblWorkTypeTableAdapter.Fill(comDataSet.usp_SEL_tblWorkType);
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
            txtName.ReadOnly = true;
            usp_SEL_tblWorkTypeTableAdapter.Fill(comDataSet.usp_SEL_tblWorkType);
            mode = 0;
            DGType.Enabled = true;
            AcceptButton = btnNew;

        }
    }
}