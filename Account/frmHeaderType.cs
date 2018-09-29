using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ
{
    public partial class frmHeaderType : Form
    {
        int mode = 0;
        int ID = 0;
        string FHeader = "Header Type";
        string acc_headerCode = "";
        string check_code = "";
        string acc_header = "";
        public string con_String = Community.DBLayer.con_String;

        public frmHeaderType()
        {
            InitializeComponent();
        }

        private void frmHeaderType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset2.tblHeader' table. You can move, or remove it, as needed.
            this.tblHeaderTableAdapter.Fill(this.dataset2.tblHeader);
            // TODO: This line of code loads data into the 'dataset2.tblHeaderType' table. You can move, or remove it, as needed.
            this.tblHeaderTypeTableAdapter.Fill(this.dataset2.tblHeaderType);
            // TODO: This line of code loads data into the 'dataset.tblHeader' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataset.tblHeaderType' table. You can move, or remove it, as needed.
            dgvHeaderType.BringToFront();
        }


        private void header_code()
        {
            try
            {

                SqlConnection con = new SqlConnection(con_String);
                SqlCommand cmd = new SqlCommand("SELECT Code from tblheader where header = '" + cmbHeader.Text + "'", con);

                con.Open();

                acc_headerCode = Convert.ToInt32(cmd.ExecuteScalar()).ToString("00");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EnableDisable(bool character)
        {
            txtCode.Enabled = character;
            txtHeaderType.Enabled = character;
            cmbHeader.Enabled = character;
            btnAdd.Enabled = !character;
            btnEdit.Enabled = !character;
            btnDelete.Enabled = !character;
            dgvHeaderType.Visible = !character;
        }

        private int account_ID(string code)
        {
            int id = 0;

            try
            {
                SqlConnection con = new SqlConnection(con_String);
                SqlCommand cmd = new SqlCommand("Select ID from tblAccounts WHERE AccountCode = '" + code + "'", con);

                con.Open();

                id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;

        }

        private bool Check_code(string code,int Header)
        {
            bool result = false;
            SqlConnection Conn = null;
           
            try
            {
                if (acc_header != check_code)
                {
                    Conn = new SqlConnection(con_String);
                    Conn.Close();
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Code FROM tblSubHeader WHERE Code = '" + code + "' AND Header = " + Header, Conn);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Code already exist!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbHeader.Focus();
                        return true;
                    }
                    else
                        return false;


                    Conn.Close();
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }


        public void Clearfields()
        {
            txtCode.Text = "";
            txtHeaderType.Text = "";
            cmbHeader.Text = "";
        }

        public bool CheckField()
        {
            if (txtCode.Text == "" || txtHeaderType.Text == "" || cmbHeader.Text == "")
            {
                MessageBox.Show("Fields Cannot Left Blanks!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check_code = "";
            mode = 1;
            EnableDisable(true);
            Clearfields();
            cmbHeader_SelectedIndexChanged(sender, e);
            Text = FHeader + " >> Adding Header Type";            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = 0;
            if (dgvHeaderType.Rows.Count != 0)
            {
                ID = Convert.ToInt32(dgvHeaderType.CurrentRow.Cells[0].Value.ToString());
                EnableDisable(true);
                cmbHeader_SelectedIndexChanged(sender, e);
                txtCode.Enabled = false;
                check_code = acc_headerCode + "-" + txtCode.Text;
                cmbHeader.Enabled = false;
                Text = FHeader + " >> Updating Header Type";
            
            }
            else
            {
                MessageBox.Show("No record for Edit!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHeaderType.Rows.Count != 0)
            {
                ID = Convert.ToInt32(dgvHeaderType.CurrentRow.Cells[0].Value.ToString());
                string[] table = { "tblAccounts" };
                string[] field = { "AccType" };
                if (!frmAccounts.check_Other(table,field,ID.ToString()))
                {
                    Text = FHeader + " >> Deleting Header Type";
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Cofirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        header_code();
                        tblHeaderTypeTableAdapter.DeleteQuery(ID);
                        string acc_code = acc_headerCode + "-" + Convert.ToInt32(txtCode.Text).ToString("00");
                        tblAccountsTableAdapter.DeleteAccount(account_ID(acc_code));
                        MessageBox.Show("Deleted Succesfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tblHeaderTypeTableAdapter.Fill(dataset2.tblHeaderType);
                        Text = FHeader;

                    }
                    else
                        Text = FHeader;
                }
                else
                {
                    MessageBox.Show("Sub header already in use...\nCannot be deleted", "Cannot delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("No record for delete!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableDisable(false);          
            tblHeaderTypeTableAdapter.Fill(dataset2.tblHeaderType);
            Text = FHeader;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtCode.Text;
                int Header = Convert.ToInt32(cmbHeader.SelectedValue.ToString());
                acc_header = acc_headerCode + "-" + txtCode.Text;
                if (CheckField() && !Check_code(code, Header))
                {
                    string HeaderType = txtHeaderType.Text;

                    if (mode == 1)
                    {

                        tblHeaderTypeTableAdapter.InsertQuery(code, HeaderType, Header);
                        MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnableDisable(false);
                        tblHeaderTypeTableAdapter.Fill(dataset2.tblHeaderType);
                        tblAccountsTableAdapter.InsertAccount(acc_header, HeaderType, "", "", "", "", "", "", "", "", "", "", "", 0, 0, "Inactive", "No", "");
                        Text = FHeader;
                    }
                    else
                    {
                        tblHeaderTypeTableAdapter.UpdateQuery(code, HeaderType, Header, ID);
                        MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnableDisable(false);
                        tblHeaderTypeTableAdapter.Fill(dataset2.tblHeaderType);
                        Text = FHeader;
                        txtCode.Enabled = true;
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values in respective fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exceptionparameter)
            {
                MessageBox.Show(exceptionparameter.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text != "" && dgvHeaderType.Visible == false && mode != 0)
            {
                if (txtCode.Text == "0" || txtCode.Text == "00")
                {
                    string cod = txtCode.Text;
                    string msg = "You cannot enter Code '%00%'\nPlease enter from 01 to 99";
                    msg = msg.Replace("%00%", cod);
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Focus();
                }                
            }
        }

        private void cmbHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            header_code();   
        }
       
    }
}