using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }
     
        int mode = 0;
        string Old = "";       
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 15;
        string header = "Event";
        private void frmArea_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset2.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataset2.tblEvents);
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
            lbl.Text = header + " >> New Event";
            mode = 1;
            btnClose.Hide();
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
            lbl.Text  = header + " >> Modify Event";
            Old = txtName.Text;
            DGArea.Enabled = false;
            btnClose.Hide();
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
                MessageBox.Show("Cannot Delete! Already in use", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                lbl.Text  = header + " >> Delete Event";
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                if (result == DialogResult.Yes)
                {
                    tblEventsTableAdapter.DeleteEvent(Convert.ToInt32(txtID.Text));
                    tblEventsTableAdapter.Fill(dataset2.tblEvents);
                    MessageBox.Show("Deleted Succesfully!", "Suucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            lbl.Text  = header;
        }
      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            txtName.ReadOnly = true;
            tblEventsTableAdapter.Fill(dataset2.tblEvents);
            mode = 0;
            btnClose.Show();
            DGArea.Enabled = true;
            lbl.Text = header;
            AcceptButton = btnSave;
            btnSave.Focus();
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
                        tblEventsTableAdapter.AddEvent(txtName.Text);
                        btnCancel.Enabled = false;
                        btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        txtName.ReadOnly = true;
                        tblEventsTableAdapter.Fill(dataset2.tblEvents);
                        mode = 0;
                        btnClose.Show();
                        DGArea.Enabled = true;
                        MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (mode == 0)
                    {
                        tblEventsTableAdapter.UpdateEvent(txtName.Text, Convert.ToInt32(txtID.Text));
                        btnCancel.Enabled = false;
                        btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        txtName.ReadOnly = true;
                        tblEventsTableAdapter.Fill(dataset2.tblEvents);
                        mode = 0;
                        btnClose.Show();
                        DGArea.Enabled = true;
                        MessageBox.Show("Modified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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