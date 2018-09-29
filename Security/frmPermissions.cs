using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Security
{
    public partial class frmPermissions : Form
    {
        public frmPermissions()
        {
            InitializeComponent();
        }
        Community.DBLayer DBLayer = new Community.DBLayer();
        int mode = 0;
        int SecurityLevelID = 2;
        int UserID = Community.DBLayer.ID;
        string Header = "Permissions";

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

        private void frmPermissions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblUserGroup' table. You can move, or remove it, as needed.
            this.tblUserGroupTableAdapter.Fill_Permissions(this.comDataSet.tblUserGroup);
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnNew.Enabled = true;
            else
                btnNew.Enabled = false;           

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;
            // TODO: This line of code loads data into the 'comDataSet.tblSecurity' table. You can move, or remove it, as needed.
            this.tblSecurityTableAdapter.Fill(this.comDataSet.tblSecurity);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblPermission' table. You can move, or remove it, as needed.
            this.usp_SEL_tblPermissionTableAdapter.Fill(this.comDataSet.usp_SEL_tblPermission);
            // TODO: This line of code loads data into the 'comDataSet.tblSecurityLevel' table. You can move, or remove it, as needed.
            this.tblSecurityLevelTableAdapter.Fill(this.comDataSet.tblSecurityLevel);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_DDL_USER' table. You can move, or remove it, as needed.           
            cmbUser.Text = null;

        }


        private bool validateRights(int rowIndex)
        {
            bool result = true;

            if (dgvRights.Rows[rowIndex].Cells[1].Value == "1")
            {
                result = true;
            }
            else
            {
                if (dgvRights.Rows[rowIndex].Cells[2].Value == "1")
                {
                    result = true;
                }
                else
                {
                    if (dgvRights.Rows[rowIndex].Cells[3].Value == "1")
                    {
                        result = true;
                    }
                    else
                    {
                        if (dgvRights.Rows[rowIndex].Cells[4].Value == "1")
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }

            return result;
        }

        private bool validateFields()
        {
            bool result = true;
            
            for (int x = 0; x < dgvRights.Rows.Count - 1; x++)
            {
                if (dgvRights.Rows[x].Cells[0].Value == null  || !validateRights(x))
                {
                    MessageBox.Show("Row cannot have empty cells!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    result = false;
                    break;
                }
            }

            return result;
        }

        private bool validatePermissions()
        {
            bool result = true;
            int y = 0;
            int yy = 0;        
            for (int x = 0; x < dgvRights.Rows.Count - 1; x++)
            {
                if (dgvRights.Rows[x].Cells[0].Value != null)
                {
                    y = Convert.ToInt32(dgvRights.Rows[x].Cells[0].Value.ToString());
                }
                for (int z = 0; z < dgvRights.Rows.Count - 1; z++)
                {
                    if (dgvRights.Rows[z].Cells[0].Value != null)
                    {
                        yy = Convert.ToInt32(dgvRights.Rows[z].Cells[0].Value.ToString());
                        if (z != x && y == yy)
                        {
                            MessageBox.Show("You cannot permit more than once!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;

                        }
                        else
                        {
                            result = true;                           
                        }
                    }
                
              
                }                
            }

            return result;
        }

        private bool checkUser(int ID)
        {
          
                bool result = false;

                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("Select UserID From tblPermission Where UserID=" + cmbUser.SelectedValue.ToString(), Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Reader.Read();

                        result = true;
                    }

                    Reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (Conn.State != ConnectionState.Closed || Conn.State != ConnectionState.Broken)
                    {
                        Conn.Close();
                    }

                }

                return result;
            
        }     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dgvRights.Rows.Count != 0)
            {
                dgvRights.Rows.Clear();
                dgvRights.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                lbl.Text = Header;
                cmbUser.Text = null;                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields() && validatePermissions())
                {
                    int userid = Convert.ToInt32(cmbUser.SelectedValue.ToString());
                    int rSuccess = 0;
                    int rAdded = 0;

                    if (mode == 0)
                    {
                        if (!checkUser(userid))
                        {
                            for (int x = 0; x < dgvRights.RowCount - 1; x++)
                            {
                                int Permission_ID = Convert.ToInt32(dgvRights.Rows[x].Cells[0].Value.ToString());

                                for (int y = 1; y <= 5; y++)
                                {
                                    if (dgvRights.Rows[x].Cells[y].Value == null)
                                    {
                                        dgvRights.Rows[x].Cells[y].Value = "0";
                                    }
                                }
                               

                                int Read = Convert.ToInt32(dgvRights.Rows[x].Cells[1].Value.ToString());
                                int Write = Convert.ToInt32(dgvRights.Rows[x].Cells[2].Value.ToString());
                                int Modify = Convert.ToInt32(dgvRights.Rows[x].Cells[3].Value.ToString());
                                int Delete = Convert.ToInt32(dgvRights.Rows[x].Cells[4].Value.ToString());
                                int Active_FL = Convert.ToInt32(dgvRights.Rows[x].Cells[5].Value.ToString());
                                
                                int result = usp_SEL_tblPermissionTableAdapter.InsertPermissions(userid, Permission_ID, Read, Write, Modify, Delete, Active_FL);                                
                                if (result == 1)
                                {
                                    rSuccess++;
                                }
                            }                           
                            MessageBox.Show(rSuccess.ToString() + " Out Of " + Convert.ToString(dgvRights.RowCount - 1) + " Row(s) Added Successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnReset_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Rights Already Assigned for the Selected User!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 1)
                    {
                        for (int x = 0; x < dgvRights.RowCount - 1; x++)
                        {

                            int Permission_ID = Convert.ToInt32(dgvRights.Rows[x].Cells[0].Value.ToString());

                            for (int y = 1; y <= 5 ; y++)
                            {
                                if (dgvRights.Rows[x].Cells[y].Value == null)
                                {
                                    dgvRights.Rows[x].Cells[y].Value = "0";
                                }
                            }                          

                            int Read = Convert.ToInt32(dgvRights.Rows[x].Cells[1].Value.ToString());
                            int Write = Convert.ToInt32(dgvRights.Rows[x].Cells[2].Value.ToString());
                            int Modify = Convert.ToInt32(dgvRights.Rows[x].Cells[3].Value.ToString());
                            int Delete = Convert.ToInt32(dgvRights.Rows[x].Cells[4].Value.ToString());
                            int Active_FL = Convert.ToInt32(dgvRights.Rows[x].Cells[5].Value.ToString());


                            int result = 0;


                            bool added = false;

                            if (dgvRights.Rows[x].Cells[6].Value != null)
                            {
                                int pID = Convert.ToInt32(dgvRights.Rows[x].Cells[6].Value.ToString());
                                result = usp_SEL_tblPermissionTableAdapter.UpdatePermissions(userid, Permission_ID, Read, Write, Modify, Delete, Active_FL,pID);
                                added = false;
                            }
                            else
                            {
                                result = usp_SEL_tblPermissionTableAdapter.InsertPermissions(userid, Permission_ID, Read, Write, Modify, Delete, Active_FL);
                                added = true;
                            }

                            if (result == 1)
                            {
                                if (!added)
                                {
                                    rSuccess++;
                                }
                                else
                                {
                                    rAdded++;
                                }
                            }
                        }
                        string msg = rSuccess.ToString() + " Out Of " + Convert.ToString(dgvRights.RowCount - 1 - rAdded) + " Record(s) Updated Successfully!";

                        if (rAdded != 0)
                        {
                            msg += "\n\n" + rAdded.ToString() + " new Records added!";
                        }
                        
                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        mode = 0;
                        
                        btnLoad.Visible = true;
                        btnSave.Enabled = false;
                        btnReset.Enabled = false;                       
                        btnNew.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        btnNew.Show();
                        cmbUser.Enabled = true;

                        this.AcceptButton = btnEdit;

                        dgvRights.ReadOnly = true;
                        dgvRights.AllowUserToDeleteRows = false;
                        lbl.Text = Header;

                                               

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values in their respective format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbUser.Text != "")
            {
                int userID = Convert.ToInt32(cmbUser.SelectedValue.ToString());

                if (checkUser(userID))
                {
                    //mode = 2;

                    SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                    try
                    {
                        Conn.Open();

                        SqlCommand Command = new SqlCommand("Select UserID,SecurityLevelID,[Read],Write,Modify,[Delete],Inactive_FL,PermissionID from tblPermission WHERE UserID = " + userID, Conn);

                        SqlDataReader Reader = Command.ExecuteReader();

                        if (Reader.HasRows)
                        {
                            if (dgvRights.RowCount != 0)
                            {
                                dgvRights.Rows.Clear();
                            }

                            btnLoad.Visible = false;
                            btnNew.Hide();
                            btnSave.Enabled = false;
                            btnReset.Enabled = false;
                            btnEdit.Visible = true;

                            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
                                btnEdit.Enabled = true;
                            else
                                btnEdit.Enabled = false;

                            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                                btnDelete.Enabled = true;
                            else
                                btnDelete.Enabled = false;

                            dgvRights.ReadOnly = true;
                            dgvRights.AllowUserToDeleteRows = false;
                            dgvRights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                            while (Reader.Read())
                            {

                                int z = dgvRights.Rows.Add();

                                for (int x = 1; x < Reader.FieldCount; x++)
                                {
                                    string value = Reader.GetValue(x).ToString();
                                    string vartype = Reader.GetFieldType(x).ToString();

                                    vartype = vartype.Replace("System.", "");


                                    if (x == 2 || x == 3 || x == 4 || x == 5 || x == 6)
                                    {
                                        if (value == "True")
                                        {
                                            value = "1";
                                        }
                                        else
                                        {
                                            value = "0";
                                        }
                                    }
                                    if (vartype == "Int32")
                                    {
                                        dgvRights.Rows[z].Cells[x - 1].Value = Convert.ToInt32(value);
                                    }
                                    else
                                    {
                                        dgvRights.Rows[z].Cells[x - 1].Value = value;
                                    }
                                }

                                //dgvRights.Rows.Add(row);
                            }
                        }

                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        if (Conn.State != ConnectionState.Closed || Conn.State != ConnectionState.Broken)
                        {
                            Conn.Close();
                        }

                    }
                }
            }
            else
                MessageBox.Show("Please select Group first!!", "Select Group", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (User_Right(UserID, SecurityLevelID, "Write"))
            {
                lbl.Text = Header + ">>Assign Permissions";
                mode = 0;
                cmbUser.Enabled = false;
                btnSave.Enabled = true;
                btnReset.Enabled = true;
                btnDelete.Enabled = false;
                btnLoad.Hide();
                btnNew.Enabled = false;
                cmbUser.Enabled = false;
                dgvRights.Rows.Clear();
                dgvRights.ReadOnly = false;
            }
            else
                MessageBox.Show("You have not enoungh Rights to assign User Rights!!", "Access is Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (User_Right(UserID, SecurityLevelID, "Modify"))
            {
                dgvRights.ReadOnly = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                mode = 1;
                cmbUser.Enabled = false;
                lbl.Text = Header + ">>Modify Assigned Permissions";
            }
            else
                MessageBox.Show("You have not enoungh Rights to assign User Rights!!","Access is Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);           
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbUser.Text != "")
            {
                lbl.Text = Header + ">>Delete Permissions";
                if (User_Right(UserID, SecurityLevelID, "Delete"))
                {
                    int id = Convert.ToInt32(cmbUser.SelectedValue);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        usp_SEL_tblPermissionTableAdapter.DeletePermission(id);
                        MessageBox.Show("Successfully Deleted!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvRights.Rows.Clear();
                        lbl.Text = Header;
                    }
                    else
                        lbl.Text = Header;
                }
                else
                    MessageBox.Show("You have not enoungh Rights to Delete User Rights!!", "Access is Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                MessageBox.Show("Please select Group first!!", "Select Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            mode = 0;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnNew.Enabled = true;
            else
                btnNew.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;

            btnLoad.Visible = true;
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
                btnEdit.Enabled = true;
            else
                btnEdit.Enabled = false;
            btnNew.Show();
            cmbUser.Enabled = true;

            this.AcceptButton = btnEdit;

            dgvRights.ReadOnly = true;
            dgvRights.AllowUserToDeleteRows = false;
            lbl.Text = Header;
            btnReset_Click(sender, e);
        }
       
    }
}