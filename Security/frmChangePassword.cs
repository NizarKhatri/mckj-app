using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MCKJ.Security
{
    public partial class frmChangePassword : Form
    {      

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }               
        public bool validatePassword(string password)
        {
            try
            {
                string valid = "0123456789abcdefghijklmnopqrstuvwxyz";

                bool isValid = true;

                for (int i = 0; i < password.Length; i++)
                {
                    if (valid.IndexOf(password[i]) == -1)
                    {
                        isValid = false;
                        break;
                    }
                }

                return isValid;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string con_String = "Data Source=FASNATICS-1;Failover Partner=FASNATICS-1;Initial Catalog=Community;Persist Security Info=True;User ID=FNY;Password=arbani4u";
            SqlConnection conn = new SqlConnection(con_String);

            try
            {
                if (txtExistingPassword.Text == "")
                {
                    MessageBox.Show("Please provide your existing Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string password = txtExistingPassword.Text;

                    conn.Open();

                    SqlCommand command = new SqlCommand("Select * From tblSecurity Where Password='" + password + "' And UserID =" + Community.Login.user_ID , conn);

                    SqlDataReader i = command.ExecuteReader();

                    if (i.HasRows)
                    {                        
                        i.Close();

                        if (!validatePassword(txtNewPassword.Text) || txtNewPassword.Text.Length < 3)
                        {
                            MessageBox.Show("Please enter valid password containing only alphanumeric characters and in range 3-50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (txtNewPassword.Text != txtConfirmPassword.Text)
                        {
                            MessageBox.Show("Please confirm your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to change your password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                command.CommandText = "Update tblSecurity SET Password = '" + txtNewPassword.Text + "' WHERE UserID ="+ Community.Login.user_ID;

                                int x = command.ExecuteNonQuery();

                                if (x > 0)
                                {
                                    MessageBox.Show("Password change Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Unable to save password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Existing Password you provided is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        i.Close();

                        txtExistingPassword.Text = "";

                    }

                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An occured while trying to communicate with SQL Server. Please consult Fasnatics.\n\nSQL Server Said: \"" + ex.Message + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occured.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if(conn.State== ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

      
    }
}