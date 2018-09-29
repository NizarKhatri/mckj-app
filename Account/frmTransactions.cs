using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ
{
    public partial class frmTransactions : Form
    {
        int mode = 0;
        int currRowIndex = 0;
        int initialTop = 86;
        string m_Voucher = "";

        string con_String = "Data Source=FASNATICS-1;Failover Partner=FASNATICS-1;Initial Catalog=Community;Persist Security Info=True;User ID=FNY;Password=arbani4u";
        
        #region Functions   

            private void fillGrid(DateTime date)
            {

                SqlConnection Conn = new SqlConnection(con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("SELECT Distinct Voucher, DocumentNo, Dated FROM tblTransactions WHERE Voucher <> 'SV' and Voucher <> 'PV' and Dated = #" + date.ToString("MM/dd/yyyy") + "# Order By DocumentNo DESC", Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        if (dgvVouchers.RowCount != 0)
                        {
                            dgvVouchers.Rows.Clear();
                        }

                        while (Reader.Read())
                        {
                            int z = dgvVouchers.Rows.Add();
                            int docNum = Convert.ToInt32(Reader.GetValue(1).ToString());

                            string voucher = Reader.GetValue(0).ToString() + "-" + docNum.ToString("0000");
                            
                            DateTime dated = Convert.ToDateTime(Reader.GetValue(2).ToString());

                            dgvVouchers.Rows[z].Cells[0].Value = voucher;
                            dgvVouchers.Rows[z].Cells[1].Value = dated.ToShortDateString();

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
            
            private int getNextSerialNo()
            {
                int next = 1;

                SqlConnection Conn = new SqlConnection(con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("Select Max(DocumentNo) From tblTransactions WHERE Voucher = '" + cmbVoucherType.Text + "'", Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if(Reader.HasRows)
                    {
                        Reader.Read();
                        if (Reader.GetValue(0) == null || Reader.GetValue(0).ToString() == "")
                        {
                            next = 1;
                        }
                        else
                        {
                            next = Convert.ToInt32(Reader.GetValue(0).ToString()) + 1;
                        }
                    }

                    Reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error" , MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (Conn.State != ConnectionState.Closed || Conn.State != ConnectionState.Broken)
                    {
                        Conn.Close();
                    }

                }

                return next;
            }        
            
            private bool checkDocumentNo(int DocumentNo, string Voucher)
            {
                if (DocumentNo == 0 || Voucher == "")
                {
                    return false;
                }
                else
                {
                    bool result = false;
                    
                    SqlConnection Conn = new SqlConnection(con_String);

                    try
                    {
                        Conn.Open();

                        SqlCommand Command = new SqlCommand("Select DocumentNo From tblTransactions Where Voucher='" + Voucher + "' AND DocumentNo=" + DocumentNo.ToString(), Conn);

                        SqlDataReader Reader = Command.ExecuteReader();

                        if(Reader.HasRows)
                        {
                            Reader.Read();

                            result = true;
                        }

                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error" , MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
            }

            private bool validateAmount()
            {
                bool result = true;

                try
                {
                if(dgvTransactions.RowCount==0)
                {
                    result = false;
                }
                else if (dgvTransactions.RowCount < 3)
                {
                    result = false;
                    MessageBox.Show("Please enter atleast 2 transactions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    decimal Debit = 0;
                    decimal Credit = 0;

                    for (int x = 0; x < dgvTransactions.RowCount - 1; x++)
                    {
                        if (dgvTransactions.Rows[x].Cells[4].Value != null)
                        {
                            Debit += Convert.ToDecimal(dgvTransactions.Rows[x].Cells[4].Value.ToString());
                        }
                        else
                        {
                            if (dgvTransactions.Rows[x].Cells[5].Value == null)
                            {
                                result = false;
                                break;
                            }                            
                        }

                        if (dgvTransactions.Rows[x].Cells[5].Value != null)
                        {
                            Credit += Convert.ToDecimal(dgvTransactions.Rows[x].Cells[5].Value.ToString());
                        }
                        else
                        {
                            if (dgvTransactions.Rows[x].Cells[4].Value == null)
                            {
                                result = false;
                                break;
                            }
                        }
                    }

                    if (Debit == 0 && Credit == 0)
                    {
                        result = false;
                    }

                    if (Debit != Credit)
                    {
                        result = false;
                                                
                    }

                    if (!result)
                    {
                        MessageBox.Show("Debit and Credit must be equal and non-zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values!", "Error" , MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    result = false;
                }

                return result;
            }
            
            private bool validateFields()
            {
                bool result = true;

                //Check Header First!

                if (txtDocumentNo.Text == "")
                {
                    MessageBox.Show("Please enter Document No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }

                for (int x = 0; x < dgvTransactions.RowCount-1; x++)
                {
                    if (dgvTransactions.Rows[x].Cells[0].Value == null)
                    {
                        result = false;

                        int y = x+1;
                        
                        MessageBox.Show("Please select Account for Row " + y, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        

                        return false;
                        
                    }
                }                             

                return validateAmount();
            }

            private string[] getVoucherByDate(DateTime Date)
            {
                string[] voucher = new string[2];

                SqlConnection Conn = new SqlConnection(con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("Select Voucher,DocumentNo From tblTransactions Where Voucher<>'PV' and Voucher<>'SV' and Dated=#" + Date.ToString("M/d/yyyy") + "#", Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Reader.Read();

                        voucher[0] = Reader.GetValue(0).ToString();
                        voucher[1] = Reader.GetValue(1).ToString();
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

                return voucher;
            }        

        #endregion

        public frmTransactions()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransactions.Rows.Count != 0)
                {
                    mode = 0;
                    txtDocumentNo.Text = getNextSerialNo().ToString("00000");
                    dgvTransactions.Rows.Clear();
                    dgvTransactions.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    dtpDate.Text = DateTime.Now.ToShortDateString(); ;
                }
                else
                {
                    MessageBox.Show("No row(s) to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    string Voucher = cmbVoucherType.Text;
                    int DocumentNo = Convert.ToInt32(txtDocumentNo.Text);

                    DateTime Date = Convert.ToDateTime(dtpDate.Text);

                    int rSuccess = 0;
                    int rAdded = 0;

                    if (mode == 0)
                    {
                        if (!checkDocumentNo(DocumentNo, Voucher))
                        {
                            for (int x = 0; x < dgvTransactions.RowCount - 1; x++)
                            {
                                int AccountCode = Convert.ToInt32(dgvTransactions.Rows[x].Cells[0].Value.ToString());

                                string Narration = "";
                                if (dgvTransactions.Rows[x].Cells[1].Value != null)
                                {
                                    Narration = dgvTransactions.Rows[x].Cells[1].Value.ToString();
                                }

                                string cheque = "";

                                if (dgvTransactions.Rows[x].Cells[2].Value != null)
                                {
                                    cheque = dgvTransactions.Rows[x].Cells[2].Value.ToString();
                                }

                                string Refrence = "";
                                if (dgvTransactions.Rows[x].Cells[3].Value != null)
                                {
                                    Refrence = dgvTransactions.Rows[x].Cells[3].Value.ToString();
                                }

                                decimal Debit = 0;
                                if (dgvTransactions.Rows[x].Cells[4].Value != null)
                                {
                                    Debit = Convert.ToDecimal(dgvTransactions.Rows[x].Cells[4].Value.ToString());                                   
                                }

                                decimal Credit = 0;
                                if (dgvTransactions.Rows[x].Cells[5].Value != null)
                                {
                                    Credit = Convert.ToDecimal(dgvTransactions.Rows[x].Cells[5].Value.ToString());
                                }

                                int result = result = tblTransactionsTableAdapter.InsertTransaction(AccountCode, Voucher, DocumentNo, Date, Debit, Credit, Narration, cheque, Refrence);

                                if (result > 0)
                                {
                                    rSuccess++;
                                }
                            }

                            MessageBox.Show("Added Successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnReset_Click(sender, e);
                            tblTransactionsTableAdapter.Fill(comDataSet.tblTransactions);
                            btnCloseView_Click(sender, e);
                            btnCloseView.Visible = true;
                            btnDelete.Visible = false;
                            btnNew.Visible = false;
                            btnEdits.Visible = false;
                            txtFilter.Enabled = false;
                            dgvVouchers.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("That Voucher already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 1)
                    {
                        for (int x = 0; x < dgvTransactions.RowCount - 1; x++)
                        {
                            int AccountCode = Convert.ToInt32(dgvTransactions.Rows[x].Cells[0].Value.ToString());

                            string Narration = "";
                            if (dgvTransactions.Rows[x].Cells[1].Value != null)
                            {
                                Narration = dgvTransactions.Rows[x].Cells[1].Value.ToString();
                            }

                            string cheque = "";

                            if (dgvTransactions.Rows[x].Cells[2].Value != null)
                            {
                                cheque = dgvTransactions.Rows[x].Cells[2].Value.ToString();
                            }

                            string Refrence = "";
                            if (dgvTransactions.Rows[x].Cells[3].Value != null)
                            {
                                Refrence = dgvTransactions.Rows[x].Cells[3].Value.ToString();
                            }

                            decimal Debit = 0;
                            if (dgvTransactions.Rows[x].Cells[4].Value != null)
                            {
                                Debit = Convert.ToDecimal(dgvTransactions.Rows[x].Cells[4].Value.ToString());
                            }

                            decimal Credit = 0;
                            if (dgvTransactions.Rows[x].Cells[5].Value != null)
                            {
                                Credit = Convert.ToDecimal(dgvTransactions.Rows[x].Cells[5].Value.ToString());
                            }

                            int result = 0;

                            bool added = false;

                            if (dgvTransactions.Rows[x].Cells[6].Value != null)
                            {
                                int rID = Convert.ToInt32(dgvTransactions.Rows[x].Cells[6].Value.ToString());
                                result = tblTransactionsTableAdapter.UpdateTransaction(AccountCode, Voucher, DocumentNo, Date, Debit,Credit,Narration,cheque,Refrence, rID);
                                added = false;
                            }
                            else
                            {
                                result = tblTransactionsTableAdapter.InsertTransaction(AccountCode, Voucher, DocumentNo, Date, Debit, Credit, Narration, cheque,Refrence);
                                added = true;
                            }

                            if (result > 0)
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
                        string msg = " Record(s) Updated Successfully!";

                        if (rAdded != 0)
                        {
                            msg += "\n\n" + rAdded.ToString() + " new Records added!";
                        }

                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mode = 0;
                        btnCloseView.Visible = true;
                        btnLoad.Visible = false;
                        btnSave.Enabled = false;
                        btnReset.Enabled = false;
                        btnEdit.Visible = true;
                        btnDelete.Visible = true;

                        this.AcceptButton = btnEdit;

                        dgvTransactions.ReadOnly = true;
                        dgvTransactions.AllowUserToDeleteRows = false;

                        dtpDate.Enabled = false;
                        cmbVoucherType.Enabled = false;
                        tblTransactionsTableAdapter.Fill(comDataSet.tblTransactions);
                        btnCloseView_Click(sender, e);
                        btnDelete.Show();
                        txtFilter.Enabled = true;
                        
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fill_Grid()
        {
            this.tblTransactionsTableAdapter.Fill_Trans(this.comDataSet.tblTransactions);

            int rows = dgvVouchers.Rows.Count;
            string docNo = "";

            for (int x = 0; x < rows; x++)
            {
                string voucher = dgvVouchers.Rows[x].Cells[0].Value.ToString() + "-";
                docNo = voucher + Convert.ToDecimal(dgvVouchers.Rows[x].Cells[1].Value.ToString()).ToString("00000");
                dgvVouchers.Rows[x].Cells[2].Value = docNo;
            }
                
            
        }

        private void frmHallBoking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblVouchers' table. You can move, or remove it, as needed.
            this.tblVouchersTableAdapter.Fill(this.comDataSet.tblVouchers);
            // TODO: This line of code loads data into the 'comDataSet.tblAccounts' table. You can move, or remove it, as needed.
            this.tblAccountsTableAdapter.Fill(this.comDataSet.tblAccounts);
            // TODO: This line of code loads data into the 'comDataSet.tblTransactions' table. You can move, or remove it, as needed.
            this.tblTransactionsTableAdapter.Fill_Trans(this.comDataSet.tblTransactions);
            // TODO: This line of code loads data into the 'dataSet.tblCurrency' table. You can move, or remove it, as needed.            
            Fill_Grid();
            // TODO: This line of code loads data into the 'dataSet.tblVouchers' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataSet.tblAccounts' table. You can move, or remove it, as needed.
            
            
            //btnReset_Click(sender, e);

            //fillGrid();
            dgvVouchers.Visible = true;
            dgvVouchers.BringToFront();
        }

        private void txtSerialNo_Leave(object sender, EventArgs e)
        {
            if (txtDocumentNo.Text != "")
            {
                try
                {
                    int serial = Convert.ToInt32(txtDocumentNo.Text);
                    txtDocumentNo.Text = serial.ToString("00000");

                    if (checkDocumentNo(serial,cmbVoucherType.SelectedValue.ToString()))
                    {
                        btnLoad.Visible = true;
                    }
                    else
                    {
                        btnLoad.Visible = false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtDocumentNo.Focus();
                }                
            }
            else
            {
                txtDocumentNo.Text = getNextSerialNo().ToString("00000");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int DocumentNo = Convert.ToInt32(txtDocumentNo.Text);
            
            if (checkDocumentNo(DocumentNo,m_Voucher))
            {
                //mode = 2;

                SqlConnection Conn = new SqlConnection(con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("SELECT Voucher, DocumentNo, Dated,AccountCode,  Narration,ChequeNo, ReferenceNo ,Debit, Credit,ID FROM tblTransactions Where Voucher='" + m_Voucher + "' and DocumentNo=" + DocumentNo.ToString(), Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        txtDocumentNo.ReadOnly = true;

                        if (dgvTransactions.RowCount != 0)
                        {
                            dgvTransactions.Rows.Clear();
                        }

                        btnLoad.Visible = false;
                        btnCloseView.Visible = true;
                        btnSave.Enabled = false;
                        btnReset.Enabled = false;
                        btnEdit.Visible = true;
                        btnDelete.Visible = true;
                        dgvTransactions.ReadOnly = true;
                        dgvTransactions.AllowUserToDeleteRows = false;
                        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        dtpDate.Enabled = true;
                        cmbVoucherType.Enabled = false;

                        while (Reader.Read())
                        {
                            txtDocumentNo.Text = Convert.ToInt32(Reader.GetValue(1).ToString()).ToString("00000");
                            cmbVoucherType.Text = Reader.GetValue(0).ToString();
                            dtpDate.Text = Reader.GetValue(2).ToString();

                            int z = dgvTransactions.Rows.Add();

                            for (int x = 3; x < Reader.FieldCount; x++)
                            {
                                string varType = Reader.GetFieldType(x).ToString();
                                
                                varType = varType.Replace("System.", "");
                                
                                string value = Reader.GetValue(x).ToString();

                                if (varType == "Int32")
                                {
                                    if (value == "0")
                                    {
                                        dgvTransactions.Rows[z].Cells[x - 3].Value = null;
                                    }
                                    else
                                    {
                                        dgvTransactions.Rows[z].Cells[x - 3].Value = Convert.ToInt32(value);
                                    }
                                }
                                else
                                {
                                    dgvTransactions.Rows[z].Cells[x - 3].Value = value;
                                }
                            }

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

        //private void txtSerialNo_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int serial = Convert.ToInt32(txtDocumentNo.Text);

        //        if (cmbVoucherType.SelectedValue != null)
        //        {
        //            if (checkDocumentNo(serial, cmbVoucherType.SelectedValue.ToString()))
        //            {
        //                btnLoad.Visible = true;
        //                this.AcceptButton = btnLoad;
        //            }
        //            else
        //            {
        //                btnLoad.Visible = false;
        //                this.AcceptButton = btnSave;
        //            }
        //        }
        //    }
        //    catch (FormatException)
        //    {
                                
        //    }
        //}

        private void btnCloseView_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtFilter.Visible = true;
            btnDelete.Show();
            txtDocumentNo.ReadOnly = false;
           // btnReset_Click(sender, e);
            mode = 0;
            btnCloseView.Visible = false;
            btnSave.Enabled = true;
            btnReset.Enabled = true;
            btnEdit.Visible = false;
            this.AcceptButton = btnSave;
            dgvTransactions.ReadOnly = false;
            dgvTransactions.AllowUserToDeleteRows = true;
            dtpDate.Enabled = true;
            cmbVoucherType.Enabled = true;
            btnDelete.Show();
            dgvVouchers.Show();
            btnNew.Show();
            btnEdits.Show();
            txtFilter.Enabled = true;
            Fill_Grid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            mode = 1;
            dgvTransactions.ReadOnly = false;
            dgvTransactions.AllowUserToDeleteRows = true;
            btnSave.Enabled = true;
            dtpDate.Enabled = true;
            cmbVoucherType.Enabled = false;
            btnDelete.Visible = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVouchers.Rows.Count != 0)
            {
                int DocumentNo = Convert.ToInt32(dgvVouchers.CurrentRow.Cells[1].Value.ToString());
                string voucher = dgvVouchers.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?\n\nThis will remove all records in current voucher!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int result2 = tblTransactionsTableAdapter.DeleteTransactions(voucher, DocumentNo);
                        if (result2 > 0)
                        {
                            MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            btnCloseView_Click(sender, e);
                            Fill_Grid();
                            btnDelete.Show();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("No Record for Delete", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvHallBooking_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (e.Row.Cells[6].Value != null && mode == 1)
                {
                    if (dgvTransactions.Rows.Count== 2)
                    {
                        e.Cancel = true;
                        btnDelete_Click(sender, e);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            int result2 = tblTransactionsTableAdapter.DeleteTransaction(Convert.ToInt32(e.Row.Cells[6].Value.ToString()));
                            if (result2>0)
                            {
                                MessageBox.Show("Successfully deleted!");

                                //dgvHallBooking.Rows.Add(1);

                            }
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string[] serial = getVoucherByDate(Convert.ToDateTime(dtpSearchDate.Text));
            
            fillGrid(Convert.ToDateTime(dtpSearchDate.Text));

            if (dgvVouchers.RowCount > 0)
            {
                btnCloseView_Click(sender,e);

                dgvVouchers.Visible = true;

                btnEdits.Visible = true;
                btnNew.Visible = true;

                dgvVouchers.BringToFront();
            }            
            else
            {
                MessageBox.Show("No Transaction Found on the date provided.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSearchClose_Click(object sender, EventArgs e)
        {
            btnDelete.Hide();           
            dgvVouchers.Visible = false;          
            btnNew.Visible = false;
            btnEdits.Visible = false;
            txtFilter.Visible= false;
            label1.Visible = false;
             btnCloseView.Show();
             dgvTransactions.Rows.Clear();
             dgvTransactions.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
             cmbVoucherType.Text = "CV";
             dtpDate.Text = DateTime.Now.ToString();
             cmbVoucherType_SelectedIndexChanged(sender, e);
            //btnReset_Click(sender, e);
           // txtDocumentNo.Text = getNextSerialNo().ToString("00000");
        }

        private void btnSearchLoad_Click(object sender, EventArgs e)
        {            
            if(dgvVouchers.SelectedRows.Count != 0)
            {
                string DoctNo = dgvVouchers.CurrentRow.Cells[1].Value.ToString(); ;
                m_Voucher = dgvVouchers.CurrentRow.Cells[0].Value.ToString();
                txtDocumentNo.Text = Convert.ToDecimal(DoctNo).ToString("00000");
                btnDelete.Hide();
                dgvVouchers.Visible = false;
                btnNew.Visible = false;
                btnEdits.Visible = false;
                txtFilter.Visible = false;
                label1.Visible = false;
                btnCloseView.Show();
                dgvTransactions.Rows.Clear();
                dgvTransactions.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                btnLoad_Click(sender, e);
                btnEdit_Click(sender, e);
                txtFilter.Visible = false;
                label1.Visible = false;
                
            }
            else
            {
                MessageBox.Show("No Record for Edit!!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVoucherType.Text != "" && cmbVoucherType.Text != null)
            {
                txtDocumentNo.Text = getNextSerialNo().ToString("00000");
            }
           // txtSerialNo_TextChanged(sender, e);
        }
    
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {          
            if (txtFilter.Text != "")
                tblTransactionsBindingSource.Filter = "DocumentNo = " + txtFilter.Text;
            else
                tblTransactionsBindingSource.Filter = "";
            Fill_Grid();
        }

        private void dgvVouchers_Sorted(object sender, EventArgs e)
        {
            int rows = dgvVouchers.Rows.Count;
            string docNo = "";

            for (int x = 0; x < rows; x++)
            {
                string voucher = dgvVouchers.Rows[x].Cells[0].Value.ToString() + "-";
                docNo = voucher + Convert.ToDecimal(dgvVouchers.Rows[x].Cells[1].Value.ToString()).ToString("00000");
                dgvVouchers.Rows[x].Cells[2].Value = docNo;
            }
        }

        private void dgvTransactions_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //private void dgvTransactions_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    if (dgvTransactions.CurrentRow.Cells[3].Value.ToString() != "")
        //    {
        //        dgvTransactions.CurrentRow.Cells[4].ReadOnly = true;
        //    }
        //    if (dgvTransactions.CurrentRow.Cells[4].Value.ToString() != "")
        //    {
        //        dgvTransactions.CurrentRow.Cells[3].ReadOnly = true;
        //    }
        //}

       
    }
}   
    
