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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Community.DBLayer DBLayer = new DBLayer();
        public static int user_ID = 0;
        public static int R_ID = 0;
        public static int Chk_Login = 0;

        private int userID(string Name)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select UserID,Password from tblSecurity WHERE UserName='" + Name + "'", con);
                cmd.CommandType = CommandType.Text;

                //SqlParameter paraUserID = cmd.Parameters.Add("@UserID", SqlDbType.Int);
                //paraUserID.Value = UserID;


                //SqlParameter paraPassword = cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50);
                //paraPassword.Value = Password;
                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();                
                if (DR.HasRows)
                {
                    DR.Read();
                    id = Convert.ToInt32(DR.GetValue(0).ToString());
                }
                else
                {
                    id = 0;
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return id;
        }

        private int GroupID(int UserID)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select GroupID from tblSecurity WHERE UserID=" + UserID, con);
                cmd.CommandType = CommandType.Text;

                //SqlParameter paraUserID = cmd.Parameters.Add("@UserID", SqlDbType.Int);
                //paraUserID.Value = UserID;


                //SqlParameter paraPassword = cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50);
                //paraPassword.Value = Password;
                con.Open();

                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    DR.Read();
                    id = Convert.ToInt32(DR.GetValue(0).ToString());
                }
                else
                {
                    id = 0;
                }
            }
            catch (Exception ex)
            {
                string justChecking = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return id;
        }
      
        public int Loging_ID(int UserID,DateTime LoginTime)
        {
            int ID = 0;
            DBLayer dbLayer = new DBLayer();
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select ID from tblLoging WHERE UserID = " + UserID + " AND LoginTime = '" + LoginTime +"' ORDER BY ID DESC", con);
                cmd.CommandType = CommandType.Text; 

                con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DR.Read();
                if (DR.HasRows)
                {
                    ID = Convert.ToInt32(DR.GetValue(0).ToString());
                }
                else
                {
                    ID = 0;
                }
            }
            catch (Exception ex)
            {
                string chking = ex.Message;
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return ID;
        }

        public int Next_R_ID()
        {
            int ID = 0;
            DBLayer dbLayer = new DBLayer();
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select MAX(R_ID) from tblLoging", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DR.Read();
                if (DR.HasRows)
                {
                    ID = Convert.ToInt32(DR.GetValue(0).ToString()) + 1;
                }
                else
                {
                    ID = 0;
                }
            }
            catch (Exception ex)
            {
                string chking = ex.Message;
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return ID;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int UserID = 0;
        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblLoging' table. You can move, or remove it, as needed.
            //this.tblLogingTableAdapter.Fill(this.comDataSet.tblLoging);
            // TODO: This line of code loads data into the 'comDataSet.tblLoging' table. You can move, or remove it, as needed.
            this.tblLogingTableAdapter.Fill(this.comDataSet.tblLoging);
            // TODO: This line of code loads data into the 'comDataSet.tblSecurity' table. You can move, or remove it, as needed.
            this.tblSecurityTableAdapter.Fill(this.comDataSet.tblSecurity);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_DDL_USER' table. You can move, or remove it, as needed.
        
            cmbUserName.SelectedItem = null;
            AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                int user_id = DBLayer.ID;
                if (txtPassword.Text != "" && cmbUserName.Text != "")
                {
                    UserID = userID(cmbUserName.Text);
                    string Password = this.txtPassword.Text;
                    bool result = DBLayer.CHKUSER(UserID, Password);
                    DBLayer.SetUserID(UserID);
                    if (result)
                    {
                        if (Chk_Login == 0)
                        {
                            user_ID = UserID;
                            DBLayer.ID = GroupID(UserID);
                            R_ID = Next_R_ID();
                            txtPassword.Text = "";
                            //MessageBox.Show("You are now logged in! \nPress OK to Proceed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                            
                            Main frm = new Main();                            
                            tblLogingTableAdapter.AddLoginTime(UserID, DateTime.Now,R_ID);
                            frm.Show();
                            frm.BringToFront();
                            this.Hide();
                            Chk_Login = 1;
                        }
                        else
                        {
                            Main frm = new Main();
                            tblLogingTableAdapter.AddLogoffTime(user_id, DateTime.Now, frm.Loging_ID(user_id, R_ID));
                            DBLayer.ID = UserID;
                            tblLogingTableAdapter.AddLoginTime(UserID, DateTime.Now,Next_R_ID());
                            frm.Chk_Rights();
                            this.Hide();
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Invalid UserName or Password!!";
                        lblMessage.ForeColor = Color.OrangeRed;
                    }
                }
                else
                {
                    if (cmbUserName.Text == "" && txtPassword.Text != "")
                        lblMessage.Text = "Please provide User Name to SignIn!!";
                    else if (txtPassword.Text == "" && cmbUserName.Text != "")
                        lblMessage.Text = "Please provide Password to SignIn!!";
                    else
                        lblMessage.Text = "Please provide User Name or\nPassword to SignIn!!";

                    lblMessage.ForeColor = Color.OrangeRed;
                }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btnLogin;
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you forgot your Password??\nPlease Contact your Administrator!!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

        
    }
}