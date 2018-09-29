using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Security
{
    public partial class frmGroup : Form
    {
        public frmGroup()
        {
            InitializeComponent();
        }

        int mode = 0;
        int ID = 0;
        string Header = "User Groups";
        private void Hide_(bool btn)
        {
            dgvGroup.Visible = btn;
            btnAdd.Enabled = btn;
            btnEdit.Enabled = btn;
            btnDelete.Enabled = btn;
            txtName.Enabled = !btn;
            chkStatus.Enabled = !btn;
        }
        private void frmGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblUserGroup' table. You can move, or remove it, as needed.
            this.tblUserGroupTableAdapter.Fill(this.comDataSet.tblUserGroup);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = 0;
            Hide_(false);
            txtName.Text = "";
            chkStatus.Checked = true;
            lbl.Text = Header + ">>Add Group";

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGroup.Rows.Count != 0)
            {
                if (dgvGroup.CurrentRow.Cells[1].Value.ToString() != "Administrator")
                {
                    ID = Convert.ToInt32(dgvGroup.CurrentRow.Cells[0].Value.ToString());
                    mode = 1;
                    Hide_(false);
                    lbl.Text = Header + ">>Edit Group";
                }
                else
                    MessageBox.Show("You cannot modify Administrator Group!!", "Cannot be modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No record to modify!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbl.Text = Header + ">>Delete Group";
            if (dgvGroup.Rows.Count != 0)
            {
                if (dgvGroup.CurrentRow.Cells[1].Value.ToString() != "Administrator")
                {
                    ID = Convert.ToInt32(dgvGroup.CurrentRow.Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        tblUserGroupTableAdapter.DeleteGroup(ID);
                        MessageBox.Show("Successfully Deleted!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tblUserGroupTableAdapter.Fill(comDataSet.tblUserGroup);
                        lbl.Text = Header;
                    }
                    else
                        lbl.Text = Header;                                          
                }
                else                   
                    MessageBox.Show("You cannot delete Administrator Group!!", "Cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


               
               
            }
            else
                MessageBox.Show("No Record for Deleting", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide_(true);
                mode = 0;
                tblUserGroupTableAdapter.Fill(comDataSet.tblUserGroup);
                lbl.Text = Header;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Status = false;
                string Name = txtName.Text;
                if (chkStatus.Checked)
                    Status = true;
                else
                    Status = false;
                if (mode == 0)
                {
                    tblUserGroupTableAdapter.AddGroup(Name, Status);
                    DialogResult result = MessageBox.Show("Successfully Saved!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Hide_(true);
                    mode = 0;
                    lbl.Text = Header;
                }
                else if (mode == 1)
                {
                    tblUserGroupTableAdapter.UpdateGroup(Name, Status, ID);
                    DialogResult result = MessageBox.Show("Successfully Saved!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Hide_(true);
                    mode = 0;
                    lbl.Text = Header;
                }
            }
            catch (FormatException)
            {
                DialogResult result = MessageBox.Show("Please fill valid values in respective fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}