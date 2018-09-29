using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;


namespace MCKJ
{
    public partial class frmVillage : Form
    {
        public frmVillage()
        {
            InitializeComponent();
        }        
        int mode = 0;
        string Old = "";
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 15;
        private void frmVillage_Load(object sender, EventArgs e)
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

            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblVillage' table. You can move, or remove it, as needed.
            this.usp_SEL_tblVillageTableAdapter.Fill(this.comDataSet.usp_SEL_tblVillage);
            AcceptButton = btnNew;           

            //It should skin Groupbox and panel manually for dotnet projects , because AppFace can not identify them automatically
           // AppFace.SkinWindowSet(DGVillage.Handle, AppFace.SKIN_CLASS_GROUPBOX);

           
            
            

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
     
        private void btnClose_Click(object sender, EventArgs e)
        {           
                this.Close();           
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
            DGVillage.Enabled = false;
            mode = 1;
            btnClose.Hide();
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
            Old = txtName.Text;
            btnClose.Hide();
            DGVillage.Enabled = false;
            AcceptButton = btnSave;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            bool CHK = DBLayer.CHK_B4_DEL_ORIGIN(txtName.Text);
            if (CHK)
            {
                MessageBox.Show("Cannot Delete! Already in use", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usp_SEL_tblVillageTableAdapter.Delete1(Convert.ToInt32(txtID.Text));
                    usp_SEL_tblVillageTableAdapter.Fill(comDataSet.usp_SEL_tblVillage);
                    MessageBox.Show("Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnClose.Show();
            usp_SEL_tblVillageTableAdapter.Fill(comDataSet.usp_SEL_tblVillage);
            mode = 0;
            DGVillage.Enabled = true;
            AcceptButton = btnNew;
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Result = DBLayer.CHK_Origin(txtName.Text);
            if (CheckField())
            {
                try
                {
                    if (mode == 1)
                    {
                        if (Result)
                             MessageBox.Show(txtName.Text + " Already Exist!", "Duplicate",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        else
                        {
                            usp_SEL_tblVillageTableAdapter.Insert1(txtName.Text);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            usp_SEL_tblVillageTableAdapter.Fill(comDataSet.usp_SEL_tblVillage);
                            mode = 0;
                            DGVillage.Enabled = true;
                            btnClose.Show();
                           MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 0)
                    {
                        if (Old == txtName.Text)
                        {
                            usp_SEL_tblVillageTableAdapter.Update1(txtName.Text, Old);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            usp_SEL_tblVillageTableAdapter.Fill(comDataSet.usp_SEL_tblVillage);
                            mode = 0;
                            DGVillage.Enabled = true;
                            btnClose.Show();
                            MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (Result)
                                 MessageBox.Show(txtName.Text + " Already Exist!", "Duplicate",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                            else
                            {
                                usp_SEL_tblVillageTableAdapter.Update1(txtName.Text, Old);
                                btnCancel.Enabled = false;
                                btnNew.Enabled = true;
                                btnSave.Enabled = false;
                                btnDelete.Enabled = true;
                                btnEdit.Enabled = true;
                                txtName.ReadOnly = true;
                                usp_SEL_tblVillageTableAdapter.Fill(comDataSet.usp_SEL_tblVillage);
                                mode = 0;
                                DGVillage.Enabled = true;
                                btnClose.Show();
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