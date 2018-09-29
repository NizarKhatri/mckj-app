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
    public partial class frmVouchers : Form
    {
        int rIndex = 0;
        int mode = 0;
        string PCode = "";
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 15;
        private bool exists(string code, string not)
        {
            try
            {
                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                Conn.Open();

                string Query = "";

                Query = "SELECT Voucher FROM tblVouchers WHERE Voucher <> '%PC2%' AND Voucher = '%PC1%'";

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

        public frmVouchers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFields()
        {
            txtVoucher.Text = "";
            txtDescription.Text = "";
            txtCreationDate.Text = DateTime.Now.ToShortDateString();
        }

        private void makeReadOnly(bool character)
        {
            txtVoucher.ReadOnly = character;
            txtDescription.ReadOnly = character;
        }

        private bool checkFields()
        {

            if (txtVoucher.Text == "" || txtDescription.Text == "")
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

                dgvVouchers.Visible = false;

                txtVoucher.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                rIndex = dgvVouchers.SelectedRows[0].Index;
                PCode = dgvVouchers.Rows[rIndex].Cells[1].Value.ToString();

                mode = 1;                
                makeReadOnly(false);
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                this.AcceptButton = btnSave;
                dgvVouchers.Visible = false;
            }
            catch (Exception exceptionparameter)
            {
                MessageBox.Show(exceptionparameter.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((mode != 1 && !exists(txtVoucher.Text, "")) || (mode == 1 && !exists(txtVoucher.Text, PCode)))
                {
                    if (checkFields())
                    {
                        string Voucher = txtVoucher.Text;
                        string Description = txtDescription.Text;
                        DateTime creationDate = Convert.ToDateTime(txtCreationDate.Text);

                        switch (mode)
                        {
                            case 0:
                                {
                                    int result;

                                    result = tblVouchersTableAdapter.InsertVoucher(Voucher, Description, creationDate);

                                    if (result!=0)
                                    {
                                        MessageBox.Show("Record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.AcceptButton = btnAdd;
                                        btnAdd.Focus();
                                        makeReadOnly(true);                                        
                                        PCode = "";
                                        dgvVouchers.Visible = true;

                                        btnAdd.Enabled = true;
                                        btnEdit.Enabled = true;
                                        btnDelete.Enabled = true;

                                        tblVouchersTableAdapter.Fill(dataSet.tblVouchers);
                                    }
                                    else
                                        MessageBox.Show("Unable to add record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    break;

                                }
                            case 1:
                                {
                                    int ID = Convert.ToInt32(dgvVouchers.Rows[rIndex].Cells[0].Value.ToString());

                                    int result;

                                    result = tblVouchersTableAdapter.UpdateVoucher(Voucher, Description,creationDate ,ID);

                                    if (result!=0)
                                    {
                                        MessageBox.Show("Record Updated! added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.AcceptButton = btnAdd;
                                        btnAdd.Focus();
                                        makeReadOnly(true);                                        
                                        PCode = "";
                                        dgvVouchers.Visible = true;

                                        btnAdd.Enabled = true;
                                        btnEdit.Enabled = true;
                                        btnDelete.Enabled = true;

                                        tblVouchersTableAdapter.Fill(dataSet.tblVouchers);
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
                    MessageBox.Show("Voucher already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                int ID = Convert.ToInt32(dgvVouchers.SelectedRows[0].Cells[0].Value.ToString());

                if (ID != 0)
                {

                    DialogResult Answer = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion Of Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (Answer == DialogResult.Yes)
                    {
                        int result = tblVouchersTableAdapter.DeleteVoucher(ID);

                        if (result!=0)
                        {
                            MessageBox.Show("Record deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Unable to Delete Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        tblVouchersTableAdapter.Fill(dataSet.tblVouchers);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete record!\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmVouchers_Load(object sender, EventArgs e)
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
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            tblVouchersTableAdapter.Fill(dataSet.tblVouchers);
            dgvVouchers.BringToFront();
            tblVouchersBindingSource.Filter = "Voucher <> 'HBK' AND Voucher <> 'RWL' AND Voucher <> 'DON' AND Voucher <> 'ADV' AND Voucher <> 'NIC'";
        }

    }
}