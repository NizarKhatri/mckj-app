using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }
        int mode = 0;
        string Old = "";
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 15;
        string header = "City";
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

            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblCity' table. You can move, or remove it, as needed.
            this.usp_SEL_tblCityTableAdapter.Fill(this.comDataSet.usp_SEL_tblCity);
            AcceptButton = btnNew;
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
            bool Result = DBLayer.CHK_City(txtName.Text);
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
                            usp_SEL_tblCityTableAdapter.Insert1(txtName.Text);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            usp_SEL_tblCityTableAdapter.Fill(comDataSet.usp_SEL_tblCity);
                            mode = 0;
                            DGCity.Enabled = true;
                            btnClose.Show();
                            MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 0)
                    {
                        if (Old == txtName.Text)
                        {
                            usp_SEL_tblCityTableAdapter.Update1(txtName.Text, Old);
                            btnCancel.Enabled = false;
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            txtName.ReadOnly = true;
                            usp_SEL_tblCityTableAdapter.Fill(comDataSet.usp_SEL_tblCity);
                            mode = 0;
                            DGCity.Enabled = true;
                            btnClose.Show();
                            MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            if (Result)
                                 MessageBox.Show(txtName.Text + " Already Exist!", "Duplicate",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                            else
                            {
                                usp_SEL_tblCityTableAdapter.Update1(txtName.Text, Old);
                                btnCancel.Enabled = false;
                                btnNew.Enabled = true;
                                btnSave.Enabled = false;
                                btnDelete.Enabled = true;
                                btnEdit.Enabled = true;
                                txtName.ReadOnly = true;
                                usp_SEL_tblCityTableAdapter.Fill(comDataSet.usp_SEL_tblCity);
                                mode = 0;
                                DGCity.Enabled = true;
                                btnClose.Show();
                                MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtName.Focus();
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtName.Text = "";
            txtID.Text = "<Auto Number>";
            txtName.ReadOnly = false;
            DGCity.Enabled = false;
            mode = 1;
            lbl.Text = header + ">> New City";
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
            txtName.ReadOnly = false;
            mode = 0;
            btnClose.Show();
            lbl.Text = header + ">> Modify City";
            Old = txtName.Text;
            DGCity.Enabled = false;
            AcceptButton = btnSave;
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            bool CHK = DBLayer.CHK_B4_DEL_CITY(txtName.Text);
            if (CHK)
            {
                MessageBox.Show("Cannot Delete! Already in use", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                lbl.Text = header + ">> Delete City";
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usp_SEL_tblCityTableAdapter.Delete1(Convert.ToInt32(txtID.Text));
                    usp_SEL_tblCityTableAdapter.Fill(comDataSet.usp_SEL_tblCity);
                    MessageBox.Show("Deleted Succesfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            lbl.Text = header;
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            txtName.ReadOnly = true;
            usp_SEL_tblCityTableAdapter.Fill(comDataSet.usp_SEL_tblCity);
            mode = 0;
            btnClose.Show();
            DGCity.Enabled = true;
            AcceptButton = btnSave;

        }
    }
}