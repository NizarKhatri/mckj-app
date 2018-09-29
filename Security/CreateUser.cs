using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Community
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        DBLayer DBLayer = new DBLayer();
        int mode = 0;
        int SecurityLevelID = 1;
        int UserID = DBLayer.ID;


        private int ID_User(string U_ID)
        {
            int u_ID = 0;
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                SqlCommand cmd = new SqlCommand("SELECT UserID FROM tblSecurity WHERE UserName = '" + U_ID + "'", con);
                con.Open();

                u_ID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("An unknown error occured!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return u_ID;
        }

        private bool User_Right(int userID, int securtityLevelID, string Right)
        {
            bool chk_Right = false;
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("Select [" + Right + "] from tblPermission  Where UserID =" + userID + " And SecurityLevelID= " + securtityLevelID + " And [" + Right + "] = 1", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    chk_Right = true;
                else
                    chk_Right = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return chk_Right;
            }

        private void btn_Hide(bool Hide)
        {
            btnNew.Enabled = Hide;
            btnEditUser.Enabled = Hide;
            btnSave.Enabled = !Hide;
            btnCancel.Enabled = !Hide;
            btnDeleteUser.Enabled = Hide;
            dataGridView1.Visible = Hide;
            txtPassword.ReadOnly = Hide;
            txtUserName.ReadOnly = Hide;
            chkInactive_FL.Enabled = !Hide;
            btnView.Enabled = Hide;
            cmbGroup.Enabled = !Hide;

        }
        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
               
                string UserName = this.txtUserName.Text;
                string Password = this.txtPassword.Text;
                int GroupID = Convert.ToInt32(cmbGroup.SelectedValue.ToString());
                bool Active = false;
                DateTime Date = DateTime.Today;
                if (chkInactive_FL.Checked)
                    Active = true;
                else
                    Active = false;
                if (UserName != String.Empty && Password != String.Empty)
                {
                    if (mode == 1)
                    {
                        tblSecurityTableAdapter.AddUser(UserName, Password, Date, Active,GroupID);
                        MessageBox.Show("Succesfully Saved!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //tblUserGroupTableAdapter.Fill(comDataSet.tblUserGroup);
                        tblSecurityTableAdapter.FillAll(comDataSet.tblSecurity);                        
                        btn_Hide(true);
                        mode = 0;
                        txtPassword.PasswordChar = Convert.ToChar("*");
                        lbl.Text = "User Account";

                    }
                    else if (mode == 0)
                    {
                        int UserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        tblSecurityTableAdapter.UpdateUser(UserName, Password, Active, GroupID,UserID);
                        //tblUserGroupTableAdapter.Fill(comDataSet.tblUserGroup);
                        MessageBox.Show("Succesfully Updated!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tblSecurityTableAdapter.FillAll(comDataSet.tblSecurity);
                        btn_Hide(true);
                        mode = 0;
                        txtPassword.PasswordChar = Convert.ToChar("*");
                        dataGridView1.Show();
                        lbl.Text = "User Account";
                    }

                }
                else
                {
                    MessageBox.Show("Please inert User Name and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please insert valid values in respective fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tblSecurityTableAdapter.FillAll(comDataSet.tblSecurity);
                btn_Hide(true);
                mode = 0;
                passwordDataGridViewTextBoxColumn.Visible = false;
                txtPassword.PasswordChar = Convert.ToChar("*");
                lbl.Text = "User Account";
            }
           
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            if (DBLayer.User_Right(UserID,SecurityLevelID,"[Write]"))
                btnNew.Enabled =true;
            else
                btnNew.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
                btnEditUser.Enabled = true;
            else
                btnEditUser.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                btnDeleteUser.Enabled = true;
            else
                btnDeleteUser.Enabled = false;
            // TODO: This line of code loads data into the 'comDataSet.tblSecurity' table. You can move, or remove it, as needed.
            this.tblSecurityTableAdapter.Fill(this.comDataSet.tblSecurity);
            tblUserGroupTableAdapter.Fill(comDataSet.tblUserGroup);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lbl.Text = lbl.Text + ">>Add User";
            btn_Hide(false);
            mode = 1;
            txtPassword.Text = "";
            txtUserName.Text = "";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtPassword.PasswordChar = Convert.ToChar(TextDataFormat.Text);
            txtUserName.Focus();     
        }
            

        private void btnView_Click(object sender, EventArgs e)
        {
            passwordDataGridViewTextBoxColumn.Visible = true;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1.Rows.Count != 0)
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() != "Admin")
                {
                    lbl.Text = lbl.Text + ">>Modify User";
                    btn_Hide(false);
                    mode = 0;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    txtPassword.PasswordChar = Convert.ToChar(TextDataFormat.Text);
                }
                else
                {
                    MessageBox.Show("You cannot modify user ADMIN!!", "Cannot be modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
                MessageBox.Show("No record for Modify!!", "Cannot be modified", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           
          
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
            if (User_Right(UserID,SecurityLevelID,"Delete"))
            {
            if (dataGridView1.Rows.Count != 0)
            {
                string userName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                if (userName != "Admin")
                {
                    if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != Login.user_ID.ToString())
                    {
                        lbl.Text = lbl.Text + ">>Delete User";
                        DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        int userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        if (result == DialogResult.Yes)
                        {
                            tblSecurityTableAdapter.DeleteUser(userid);
                            MessageBox.Show("Successfully Deleted!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            // tblUserGroupTableAdapter.Fill(comDataSet.tblUserGroup);
                            tblSecurityTableAdapter.FillAll(comDataSet.tblSecurity);
                            lbl.Text = "User Account";

                        }
                        else
                            lbl.Text = "User Account";
                    }
                    else
                        MessageBox.Show("You cannot delete yourself!!", "Cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("You cannot delete the user ADMIN!!", "Cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
            }
            else
                MessageBox.Show("No record for deleting!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("You have not enough Rights for Deleting User!!","Access is Denied",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            
        }
    }
}