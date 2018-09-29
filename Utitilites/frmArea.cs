using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }
     
        int mode = 0;
        string Old = "";       
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 15;
        string header = "Area";

        private void frmArea_Load(object sender, EventArgs e)
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

            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblArea' table. You can move, or remove it, as needed.
            this.usp_SEL_tblAreaTableAdapter.Fill(comDataSet.usp_SEL_tblArea);
            AcceptButton = btnNew;
        }
     
        private bool CheckField()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name field could not be left blank!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
     
        private void btnNew_Click(object sender, EventArgs e)
        {
            
            txtName.Focus();
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtName.Text = "";
            txtID.Text = "<Auto Number>";
            txtName.ReadOnly = false;
            DGArea.Enabled = false;
            mode = 1;
            btnClose.Hide();
            lbl.Text = header + " >> New Area";
            AcceptButton = btnSave;
        }
      
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtName.ReadOnly = false;
            mode = 0;
            Old = txtName.Text;
            DGArea.Enabled = false;
            btnClose.Hide();
            lbl.Text = header + " >> Modify Area";
            AcceptButton = btnSave;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            bool CHK = DBLayer.CHK_B4_DEL_AREA(txtName.Text);
            if (CHK)
            {
                MessageBox.Show("Cannot Delete! Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbl.Text = header + " >> Delete Area";
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    usp_SEL_tblAreaTableAdapter.Delete1(Convert.ToInt32(txtID.Text));
                    usp_SEL_tblAreaTableAdapter.Fill(comDataSet.usp_SEL_tblArea);
                    MessageBox.Show("Deleted Succesfully!", "Suucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                lbl.Text = header;
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
            usp_SEL_tblAreaTableAdapter.Fill(comDataSet.usp_SEL_tblArea);
            mode = 0;
            btnClose.Show();
            DGArea.Enabled = true;
            AcceptButton = btnSave;
            btnSave.Focus();
            lbl.Text = header;
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Result = DBLayer.CHK_Area(txtName.Text);
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
                            usp_SEL_tblAreaTableAdapter.Insert1(txtName.Text);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            usp_SEL_tblAreaTableAdapter.Fill(comDataSet.usp_SEL_tblArea);
                            mode = 0;
                            btnClose.Show();
                            lbl.Text = header;
                            DGArea.Enabled = true;
                            MessageBox.Show("Saved Successfully!", "Success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 0)
                    {
                        if (Old == txtName.Text)
                        {
                            usp_SEL_tblAreaTableAdapter.Update1(txtName.Text, Old);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            usp_SEL_tblAreaTableAdapter.Fill(comDataSet.usp_SEL_tblArea);
                            mode = 0;
                            lbl.Text = header;
                            btnClose.Show();
                            DGArea.Enabled = true;
                            MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (Result)
                                MessageBox.Show(txtName.Text + " Already Exist!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            else
                            {
                                usp_SEL_tblAreaTableAdapter.Update1(txtName.Text, Old);
                                btnCancel.Enabled = false;
                                btnNew.Enabled = true;
                                btnSave.Enabled = false;
                                btnDelete.Enabled = true;
                                btnEdit.Enabled = true;
                                txtName.ReadOnly = true;
                                lbl.Text = header;
                                usp_SEL_tblAreaTableAdapter.Fill(comDataSet.usp_SEL_tblArea);
                                mode = 0;
                                btnClose.Show();
                                DGArea.Enabled = true;
                                MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AcceptButton = btnSave;
            }
        }
       

       
       
    }
}