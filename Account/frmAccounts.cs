using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmAccounts : Form
    {
        int rIndex = 0;
        int mode = 0;
        string PCode = "";
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 8;
        string Header = "Account Profile";
        string AccHeader_Code = "";
        string AccHType_Code = "";

        private bool exists(string code, string not)
        {
            try
            {
                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                Conn.Open();

                string Query = "";

                Query = "SELECT AccountCode FROM tblAccounts WHERE AccountCode <> '%PC2%' AND AccountCode = '%PC1%'";

                Query = Query.Replace("%PC1%", code);
                Query = Query.Replace("%PC2%", not);

                SqlCommand command = new SqlCommand(Query, Conn);

                SqlDataReader commReader;

                commReader = command.ExecuteReader();

                if (commReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
            }
        }

        public static bool check_Other(string[] table, string[] fields, string value)
        {
            string con_String = "Data Source=FASNATICS-1;Failover Partner=FASNATICS-1;Initial Catalog=Community;Persist Security Info=True;User ID=FNY;Password=arbani4u;Connect Timeout=60;Packet Size=32768";
            bool result = false;
            try
            {
                SqlConnection Conn = new SqlConnection(con_String);

                Conn.Close();
                Conn.Open();

                string Query = "";


                for (int x = 0; x < table.Length; x++)
                {
                    Query = "SELECT  field FROM table WHERE field = value";
                    Query = Query.Replace("table", table[x]);
                    Query = Query.Replace("field", fields[x]);
                    Query = Query.Replace("value", value);

                    SqlCommand command = new SqlCommand(Query, Conn);

                    SqlDataReader commReader;

                    commReader = command.ExecuteReader();


                    if (commReader.HasRows)
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        result = false;

                    }
                    commReader.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                result = true;
            }
            return result;
        }

        public frmAccounts()
        {
            InitializeComponent();
        }


        private int Acc_Header(string AccType)
        {
            int acc_Header = 0;
            try
            {
                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                Conn.Open();

                string Query = "";

                Query = "SELECT tblSubHeader.Header,tblSubHeader.Code, tblHeader.Code FROM tblSubHeader INNER JOIN tblHeader ON tblSubHeader.Header = tblHeader.ID WHERE tblSubHeader.HeaderType = '%PC2%'";

                Query = Query.Replace("%PC2%", AccType);

                SqlCommand command = new SqlCommand(Query, Conn);

                SqlDataReader commReader;

                commReader = command.ExecuteReader();

                if (commReader.HasRows)
                {
                    commReader.Read();
                    acc_Header = Convert.ToInt32(commReader.GetValue(0));
                    AccHType_Code = commReader.GetValue(1).ToString();
                    AccHeader_Code = commReader.GetValue(2).ToString();
                }
                else
                {
                    acc_Header = 0;
                }
                commReader.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            return acc_Header;
 
        }
        private void frmParty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset2.tblHeaderType' table. You can move, or remove it, as needed.
            this.tblHeaderTypeTableAdapter.Fill(this.dataset2.tblHeaderType);
            // TODO: This line of code loads data into the 'dataSet.tblAccounts' table. You can move, or remove it, as needed.
            this.tblAccountsTableAdapter.Fill_All(this.dataSet.tblAccounts);
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
                btnEdit.Enabled = true;
            else
                btnEdit.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
            dgvAccounts.BringToFront();
            AcceptButton = btnAdd;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFields()
        {
            txtAccountCode.Text = "";            
            txtAccountName.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtPhone3.Text = "";
            txtMobile.Text = "";            
            txtFax.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            txtNTN.Text = "";
            txtSTN.Text = "";                       
        }

        private void makeReadOnly(bool character)
        {
            txtAccountCode.ReadOnly = character;
            txtAccountName.ReadOnly = character;            
            txtPhone1.ReadOnly = character;
            txtPhone2.ReadOnly = character;
            txtPhone3.ReadOnly = character;
            txtFax.ReadOnly = character;
            txtContactPerson.ReadOnly = character;
            txtMobile.ReadOnly = character;
            txtEmail.ReadOnly = character;
            txtWebsite.ReadOnly = character;
            txtCity.ReadOnly = character;
            txtAddress.ReadOnly = character;
            txtNTN.ReadOnly = character;
            txtSTN.ReadOnly = character;            
            //cmbAccountStatus.ReadOnly = character;
            //cmbAccHeader.ReadOnly = character;
            //cmbAccType.ReadOnly = character;
            //cmbIndexBook.ReadOnly = character;

        }

        private bool checkFields()
        {

            if (txtAccountCode.Text == "" || txtAccountName.Text == "" || cmbAccType.Text == "" || cmbIndexBook.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                mode = 0;
                clearFields();
                makeReadOnly(false);
                
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                
                this.AcceptButton = btnSave;
                txtAccountCode.MaxLength = 5;
                dgvAccounts.Visible = false;
                lbl.Text = Header + ">>Adding Account";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.Rows.Count != 0)
            {

                try
                {
                    string ch = dgvAccounts.CurrentRow.Cells[15].Value.ToString();
                    if (ch != "")
                    {
                        rIndex = dgvAccounts.SelectedRows[0].Index;
                        PCode = dgvAccounts.Rows[rIndex].Cells[1].Value.ToString();
                        lbl.Text = Header + ">>Modifing Account";
                        mode = 1;
                        makeReadOnly(false);
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        this.AcceptButton = btnSave;
                        dgvAccounts.Visible = false;
                        txtAccountCode.Enabled = false;
                    }
                    else
                        MessageBox.Show("You cannot modify this account!!", "Cannot be modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exceptionparameter)
                {
                    MessageBox.Show(exceptionparameter.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("No Record for Modifing", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string AccountCode = "";
            int AccHeader = Acc_Header(cmbAccType.Text);
            string[] acc = txtAccountCode.Text.Split(Convert.ToChar("-"));
            if (mode == 0)
            {
               AccountCode = AccHeader_Code + "-" + AccHType_Code + "-" + txtAccountCode.Text;
            }
            else
            {
                AccountCode = AccHeader_Code + "-" + AccHType_Code + "-" + acc[2];
            }
         
            
            try
            {
                if ((mode != 1 && !exists(AccountCode, "")) || (mode == 1 && !exists(AccountCode, PCode)))
                {
                    if (checkFields())
                    {

                        string AccountName = txtAccountName.Text;
                        
                        string Phone1 = txtPhone1.Text;
                        string Phone2 = txtPhone2.Text;
                        string Phone3 = txtPhone3.Text;
                        string ContactPerson = txtContactPerson.Text;
                        string Mobile = txtMobile.Text;
                        string Fax = txtFax.Text;
                        string Email = txtEmail.Text;
                        string Website = txtWebsite.Text;
                        string City = txtCity.Text;
                        string Address = txtAddress.Text;
                        
                        string NTN = txtNTN.Text;
                        string STN = txtSTN.Text;

                        int AccType = Convert.ToInt32(cmbAccType.SelectedValue.ToString());
                        string IndexBook = cmbIndexBook.Text;
                        string AccStatus = cmbAccountStatus.Text;

                        switch (mode)
                        {
                            case 0:
                                {
                                    int result;

                                    result = tblAccountsTableAdapter.InsertAccount(AccountCode, AccountName, Phone1, Phone2, Phone3, Mobile, Fax, Email, Website, City, Address, NTN, STN,AccHeader,AccType, AccStatus, IndexBook,ContactPerson);

                                    if (result!=0)
                                    {
                                        MessageBox.Show("Record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.AcceptButton = btnAdd;
                                        btnAdd.Focus();
                                        makeReadOnly(true);                                        
                                        PCode = "";
                                        dgvAccounts.Visible = true;
                                        lbl.Text = Header;
                                        btnAdd.Enabled = true;
                                        btnEdit.Enabled = true;
                                        btnDelete.Enabled = true;

                                        tblAccountsTableAdapter.Fill_All(dataSet.tblAccounts);
                                    }
                                    else
                                        MessageBox.Show("Unable to add record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    break;

                                }
                            case 1:
                                {
                                    int ID = Convert.ToInt32(dgvAccounts.Rows[rIndex].Cells[0].Value.ToString());

                                    int result;

                                    result = tblAccountsTableAdapter.UpdateAccount(AccountCode, AccountName, Phone1, Phone2, Phone3, Mobile, Fax, Email, Website, City, Address, NTN, STN, AccHeader, AccType, AccStatus, IndexBook, ContactPerson, ID);

                                    if (result!=0)
                                    {
                                        MessageBox.Show("Record Updated! added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.AcceptButton = btnAdd;
                                        btnAdd.Focus();
                                        makeReadOnly(true);                                        
                                        PCode = "";
                                        dgvAccounts.Visible = true;
                                        lbl.Text = Header;
                                        btnAdd.Enabled = true;
                                        btnEdit.Enabled = true;
                                        btnDelete.Enabled = true;
                                        txtAccountCode.Enabled = true;
                                        txtAccountCode.MaxLength = 25;
                                        tblAccountsTableAdapter.Fill_All(dataSet.tblAccounts);
                                    }
                                    else
                                        MessageBox.Show("Unable to add record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    break;

                                }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Account Code already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values in respective fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exceptionparameter)
            {
                MessageBox.Show(exceptionparameter.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(dgvAccounts.SelectedRows[0].Cells[0].Value.ToString());
                string[] table = { "tblTransactions", "tblHallBooking","tblRenewal" };
                string[] fields = { "AccountCode", "Account","Account"};
                string value = ID.ToString();
                string ch = dgvAccounts.CurrentRow.Cells[15].Value.ToString();
                if (ch != "")
                {
                    if (!check_Other(table, fields, value))
                    {
                        if (ID != 0)
                        {

                            DialogResult Answer = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion Of Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (Answer == DialogResult.Yes)
                            {
                                int result = tblAccountsTableAdapter.DeleteAccount(ID);

                                if (result != 0)
                                {
                                    MessageBox.Show("Record deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Unable to Delete Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }

                                tblAccountsTableAdapter.Fill_All(dataSet.tblAccounts);
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Account Already in use!!", "Cannot be delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("You cannot delete this account!!", "Cannot be delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete record!\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnAdd;
            btnAdd.Focus();
            makeReadOnly(true);
            PCode = "";
            dgvAccounts.Visible = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            lbl.Text = Header;
            txtAccountCode.Enabled = true;
            txtAccountCode.MaxLength = 25;
        }

        private void txtAccountCode_Leave(object sender, EventArgs e)
        {
            if (txtAccountCode.Text != "")
                 txtAccountCode.Text = Convert.ToInt32(txtAccountCode.Text).ToString("00000");
        }

    }
}