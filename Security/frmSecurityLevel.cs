using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmSecurityLevel : Form
    {
        public frmSecurityLevel()
        {
            InitializeComponent();
        }

        private void frmSecurityLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblSecurityLevel' table. You can move, or remove it, as needed.
            this.tblSecurityLevelTableAdapter.FillAll(this.comDataSet.tblSecurityLevel);
           
        }
        int mode = 0;
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtSecurityName.Text = "";
            txtSecurityName.Enabled = true;
            dgvSecurityLevel.Enabled = false;
            mode = 1;
            chkInactive_FL.Enabled = true;

            
            
            
        }
        private bool CheckField()
        {
            if (txtSecurityName.Text == "")
            {
                MessageBox.Show("Fields cannot be empty");
                return false;
            }
            else
                return true;
            

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckField())
            {
                try
                {
                    string SecurityName = txtSecurityName.Text;
                    bool Active = false;
                    DateTime Date = DateTime.Today;
                    if (chkInactive_FL.Checked)
                        Active = true;
                    else
                        Active = false;
                    if (mode == 1)
                    {
                        tblSecurityLevelTableAdapter.AddLevel(SecurityName,Active,Date);
                        btnCancel.Enabled = false;
                        btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        txtSecurityName.Enabled = false;
                        tblSecurityLevelTableAdapter.FillAll(comDataSet.tblSecurityLevel);
                        mode = 0;
                        dgvSecurityLevel.Enabled = true;
                        MessageBox.Show("Level Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (mode == 0)
                    {
                        int ID = Convert.ToInt32(dgvSecurityLevel.CurrentRow.Cells[0].Value.ToString());
                        tblSecurityLevelTableAdapter.UpdateLevel(SecurityName, Active, ID);
                        chkInactive_FL.Enabled = false;
                        tblSecurityLevelTableAdapter.Fill(comDataSet.tblSecurityLevel);
                        MessageBox.Show("Updated Succesfulluy", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvSecurityLevel.Enabled = true;
                        btnCancel.Enabled = false;
                        btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        txtSecurityName.Enabled = false;
                        tblSecurityLevelTableAdapter.FillAll(comDataSet.tblSecurityLevel);
                        mode = 0;
                      

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }
            
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnNew.Visible = true;
            btnSave.Visible = false;
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            txtSecurityName.Enabled = false;
            tblSecurityLevelTableAdapter.FillAll(comDataSet.tblSecurityLevel);
            mode = 0;
            dgvSecurityLevel.Enabled = true;
            chkInactive_FL.Visible = false;
            
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSecurityLevel.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dgvSecurityLevel.CurrentRow.Cells[0].Value.ToString());
                    tblSecurityLevelTableAdapter.DeleteLevel(ID);
                    tblSecurityLevelTableAdapter.FillAll(comDataSet.tblSecurityLevel);
                    MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("No rows for Deleting!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSecurityLevel.Rows.Count != 0)
            {
                btnCancel.Enabled = true;
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                dgvSecurityLevel.Enabled = false;
                chkInactive_FL.Visible = true;
                txtSecurityName.Enabled = true;
                mode = 0;
            }
            else
                MessageBox.Show("No rows for Modify!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}