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
    public partial class frmAid : Form
    {
        Community.DBLayer dbLayer = new Community.DBLayer();

        int mode = 0;
        int currRowIndex = 0;
        int initialTop = 86;
        int UserID = Community.DBLayer.ID;
        string SerialNo = "";
        int SecurityLevelID = 17;
        Community.DBLayer DBLayer = new Community.DBLayer();
        string FName = "";
        string Orakh = "";
        string Head = "";
        string Header = "Families Aid";
        string FamilyCardNo = string.Empty;

        #region Functions

        private bool HallChecking(string Hall, DateTime Dated, string fromTime, string ToTime)
        {
            bool Result = false;
            SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from tblHallBooking WHERE " + Hall + " = 1 AND Dated = '" + Dated + "' AND FromTime >= '" + fromTime + "' And FromTime <='" + ToTime + "' AND ToTime >= '" + fromTime + "' And ToTime <='" + ToTime + "'", Conn);
                cmd.CommandType = CommandType.Text;
                Conn.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                    Result = true;
                else
                    Result = false;


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

            return Result;
        }

        private int getNextSerialNo()
        {
            int next = 1;

            SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

            try
            {
                Conn.Open();

                SqlCommand Command = new SqlCommand("Select SerialNo From tblHelp Order By SerialNo DESC", Conn);

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.Read();

                    next = Convert.ToInt32(Reader.GetValue(0).ToString()) + 1;
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

            return next;
        }

        private bool checkSerialNo(string SerialNo)
        {
            if (SerialNo == "0")
            {
                return false;
            }
            else
            {
                bool result = false;

                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                try
                {
                    Conn.Open();

                    //SqlCommand Command = new SqlCommand("Select SerialNo From tblHelp Where SerialNo=" + SerialNo.ToString(), Conn);
                    SqlCommand Command = new SqlCommand();
                    if (mode == 1)
                    {
                        Command.CommandText = "Select SerialNo From tblHelp Where FCardNo='" + SerialNo.ToString() + "'";
                    }
                    else
                    {
                        Command.CommandText = "Select SerialNo From tblHelp Where SerialNo='" + SerialNo.ToString() + "'";
                    }
                    Command.CommandType = CommandType.Text;
                    Command.Connection = Conn;

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
        }

        private bool validateHall(int rowIndex)
        {
            bool result = true;

            if (dgvHallBooking.Rows[rowIndex].Cells[1].Value.ToString() == "1")
            {
                result = true;
            }
            else
            {
                if (dgvHallBooking.Rows[rowIndex].Cells[2].Value.ToString() == "1")
                {
                    result = true;
                }
                else
                {
                    if (dgvHallBooking.Rows[rowIndex].Cells[3].Value.ToString() == "1")
                    {
                        result = true;
                    }
                    else
                    {
                        if (dgvHallBooking.Rows[rowIndex].Cells[4].Value.ToString() == "1")
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

            //Check Header First!

            if (txtSerialNo.Text == "" || txtFCardNo.Text == "")
            {
                MessageBox.Show("Required filed could not left blank!\nRequired field have yellow back color.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                result = false;
            }
            else if (dgvHallBooking.Rows.Count == 1)
            {
                for (int x = 0; x < dgvHallBooking.Rows.Count; x++)
                {
                    if (dgvHallBooking.Rows[x].Cells[0].Value == null || dgvHallBooking.Rows[x].Cells[1].Value == null || dgvHallBooking.Rows[x].Cells[2].Value == null || dgvHallBooking.Rows[x].Cells[4].Value == null)
                    {
                        MessageBox.Show("Required filed could not left blank!\nRequired field have yellow back color.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        result = false;
                        break;
                    }
                }
            }
            else
            {
                for (int x = 0; x < dgvHallBooking.Rows.Count - 1; x++)
                {
                    if (dgvHallBooking.Rows[x].Cells[0].Value == null || dgvHallBooking.Rows[x].Cells[1].Value == null || dgvHallBooking.Rows[x].Cells[2].Value == null || dgvHallBooking.Rows[x].Cells[4].Value == null)
                    {
                        MessageBox.Show("Required filed could not left blank!\nRequired field have yellow back color.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private int getSerialByDate(DateTime eventDate)
        {
            int next = 0;

            SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

            try
            {
                Conn.Open();

                SqlCommand Command = new SqlCommand("Select SerialNo From tblHallBooking Where Dated='" + eventDate.ToString("M/d/yyyy") + "'", Conn);

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.Read();

                    next = Convert.ToInt32(Reader.GetValue(0).ToString());
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

            return next;
        }

        #endregion

        public frmAid()
        {
            InitializeComponent();
        }

        private void Fill(string FCardNo)
        {

            try
            {

                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                SqlCommand cmd = new SqlCommand("Select FamilyLeader ,[Sign], tblFamilyMember.FatherName from tblFamily INNER JOIN tblFamilyMember ON tblFamily.FCardNo = tblFamilyMember.FCardNo WHERE tblFamily.FCardNo = '" + FCardNo + "' AND tblFamilyMember.MemberName = tblFamily.FamilyLeader", con);

                con.Open();

                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    Reader.Read();
                    Head = Reader.GetValue(0).ToString();
                    Orakh = Reader.GetValue(1).ToString();
                    FName = Reader.GetValue(2).ToString();
                }
                Reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AnUnknown error occured!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int TransactionID(int serialno)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            SqlCommand cmd = new SqlCommand("Select ID from tblTransactions WHERE DocumentNo = " + serialno, con);

            con.Open();

            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                id = Convert.ToInt32(Reader.GetValue(0).ToString());
            }
            Reader.Close();
            con.Close();
            return id;
        }

        private void dgvHallBooking_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //string[] events = { "Majlis / Soyem", "Engagement", "Mayon / Mefil", "Aameen/ Rasm-e-Ter", "Birthday / Anniversary", "Khatna", "Aqiqa", "Other" };

            //int eIndex = e.Row.Index;
            //int eIndex2 = eIndex-1;

            //if (eIndex2 >= events.Length)
            //{
            //    eIndex2 = events.Length - 1;
            //}           

            //dgvHallBooking.Rows[eIndex].Cells[0].Value = events[eIndex2];

            //if (dgvHallBooking.Rows.Count == 10)
            //{
            //    dgvHallBooking.AllowUserToAddRows = false;
            //}

        }

        private void dgvHallBooking_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //dgvHallBooking.AllowUserToAddRows = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHallBooking.Rows.Count != 0)
                {
                    mode = 0;
                    txtSerialNo.Text = getNextSerialNo().ToString("00000");
                    txtFCardNo.Text = "";
                    txtFName.Text = "";
                    txtOrakh.Text = "";
                    dgvHallBooking.Rows.Clear();
                    txtHead.Text = "";
                    dgvHallBooking.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    lbl.Text = Header;
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
                    string SerialNo = txtSerialNo.Text;
                    string fCardNo = txtFCardNo.Text;
                    string fName = txtFName.Text;
                    string orakh = txtOrakh.Text;
                    string head = txtHead.Text;


                    int rSuccess = 0;
                    int rAdded = 0;

                    if (mode == 0)
                    {
                        if (!checkSerialNo(SerialNo))
                        {
                            for (int x = 0; x < dgvHallBooking.RowCount - 1; x++)
                            {
                                if (dgvHallBooking.Rows[x].Cells[4].Value != null && dgvHallBooking.Rows[x].Cells[4].Value.ToString() == "Done")
                                {
                                    if (dgvHallBooking.Rows[x].Cells[8].Value == null || dgvHallBooking.Rows[x].Cells[8].Value == string.Empty)
                                    {
                                        MessageBox.Show("Please select Aid From when status is done");
                                        return;
                                    }
                                }
                                int helptype = 0;
                                if (dgvHallBooking.Rows[x].Cells[1].Value != null)
                                    helptype = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[1].Value.ToString());

                                int Name = 0;
                                if (dgvHallBooking.Rows[x].Cells[0].Value != null)
                                    Name = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[0].Value.ToString());

                                DateTime ReceiveDate = System.DateTime.Today;
                                if (dgvHallBooking.Rows[x].Cells[2].Value != null)
                                    ReceiveDate = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[2].Value.ToString());

                                string Remarks = "";
                                if (dgvHallBooking.Rows[x].Cells[3].Value != null)
                                    Remarks = dgvHallBooking.Rows[x].Cells[3].Value.ToString();
                                else
                                    Remarks = "";

                                string Status = "";
                                if (dgvHallBooking.Rows[x].Cells[4].Value != null)
                                    Status = dgvHallBooking.Rows[x].Cells[4].Value.ToString();
                                else
                                    Status = "";
                                decimal Amount = 0;
                                if (dgvHallBooking.Rows[x].Cells[5].Value != null)
                                    Amount = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[5].Value.ToString());
                                else
                                    Amount = 0;
                                DateTime temp;
                                DateTime? CompleteDate = null;
                                if (DateTime.TryParse(Convert.ToString(dgvHallBooking.Rows[x].Cells["CompletedOn"].Value), out temp))
                                {
                                    CompleteDate = temp;
                                }

                                if (dgvHallBooking.Rows[x].Cells[6].Value != null)
                                    CompleteDate = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[6].Value.ToString());

                                string AidFrom = string.Empty;
                                if (dgvHallBooking.Rows[x].Cells[8].Value != null)
                                    AidFrom = dgvHallBooking.Rows[x].Cells["AidFrom"].Value.ToString();

                                int result = tblHelpTableAdapter.AddHelp(fCardNo, head, fName, orakh, Name, helptype, ReceiveDate, Status, Amount, CompleteDate, SerialNo, Remarks, AidFrom);
                                if (result > 0)
                                {

                                    rSuccess++;
                                }
                            }

                            //tblTransactionsTableAdapter.InsertTransaction(2, "HBK", Convert.ToInt32(SerialNo), Date, Amount, 0, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking");
                            MessageBox.Show(rSuccess.ToString() + " Out Of " + Convert.ToString(dgvHallBooking.RowCount - 1) + " Row(s) Added Successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnReset_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("That serial no already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 1)
                    {
                        for (int x = 0; x < dgvHallBooking.RowCount - 1; x++)
                        {
                            if (dgvHallBooking.Rows[x].Cells[4].Value != null && dgvHallBooking.Rows[x].Cells[4].Value.ToString() == "Done")
                            {
                                if (dgvHallBooking.Rows[x].Cells[8].Value == null || dgvHallBooking.Rows[x].Cells[8].Value == string.Empty)
                                {
                                    MessageBox.Show("Please select Aid From when status is done");
                                    return;
                                }
                            }
                            int helptype = 0;
                            if (dgvHallBooking.Rows[x].Cells[1].Value != null)
                                helptype = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[1].Value.ToString());

                            int Name = 0;
                            if (dgvHallBooking.Rows[x].Cells[0].Value != null)
                                Name = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[0].Value.ToString());

                            DateTime ReceiveDate = System.DateTime.Today;
                            if (dgvHallBooking.Rows[x].Cells[2].Value != null)
                                ReceiveDate = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[2].Value.ToString());

                            string Remarks = "";
                            if (dgvHallBooking.Rows[x].Cells[3].Value != null)
                                Remarks = dgvHallBooking.Rows[x].Cells[3].Value.ToString();
                            else
                                Remarks = "";

                            string Status = "";
                            if (dgvHallBooking.Rows[x].Cells[4].Value != null)
                                Status = dgvHallBooking.Rows[x].Cells[4].Value.ToString();
                            else
                                Status = "";
                            decimal Amount = 0;
                            if (dgvHallBooking.Rows[x].Cells[5].Value != null)
                                Amount = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[5].Value.ToString());
                            else
                                Amount = 0;
                            DateTime temp;
                            DateTime? CompleteDate = null;
                            if (DateTime.TryParse(Convert.ToString(dgvHallBooking.Rows[x].Cells["CompletedOn"].Value), out temp))
                            {
                                CompleteDate = temp;
                            }
                            //if (dgvHallBooking.Rows[x].Cells[6].Value != null)
                            //    CompleteDate = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[6].Value.ToString());
                            string AidFrom = string.Empty;
                            if (dgvHallBooking.Rows[x].Cells[8].Value != null)
                                AidFrom = dgvHallBooking.Rows[x].Cells["AidFrom"].Value.ToString();

                            int result = 0;


                            bool added = false;

                            if (dgvHallBooking.Rows[x].Cells[7].Value != null)
                            {
                                int rID = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[7].Value.ToString());
                                result = tblHelpTableAdapter.UpdateHelp(fCardNo, head, fName, orakh, Name, helptype, ReceiveDate, Status, Amount, CompleteDate, SerialNo, Remarks, AidFrom, rID);
                                added = false;
                            }
                            else
                            {
                                result = tblHelpTableAdapter.AddHelp(fCardNo, head, fName, orakh, Name, helptype, ReceiveDate, Status, Amount, CompleteDate, SerialNo, Remarks, AidFrom);
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
                        string msg = rSuccess.ToString() + " Out Of " + Convert.ToString(dgvHallBooking.RowCount - 1 - rAdded) + " Record(s) Updated Successfully!";

                        if (rAdded != 0)
                        {
                            msg += "\n\n" + rAdded.ToString() + " new Records added!";
                        }
                        // tblTransactionsTableAdapter.UpdateTransaction(2, "HBK", Convert.ToInt32(SerialNo), Date, Amount, 0, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking", TransactionID(Convert.ToInt32(SerialNo)));
                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //txtSerialNo.ReadOnly = false;
                        //btnReset_Click(sender, e);
                        frmHallBoking_Load(null, null);
                        mode = 0;
                        btnCloseView.Visible = true;
                        btnLoad.Visible = false;
                        btnSave.Enabled = false;
                        btnReset.Enabled = false;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnNew.Enabled = true;

                        this.AcceptButton = btnEdit;

                        //dgvHallBooking.ReadOnly = true;
                        dgvHallBooking.AllowUserToDeleteRows = false;


                        txtFCardNo.ReadOnly = true;
                        dgvFAid.Show();
                    }
                }

            }
            catch (FormatException ex)
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

        private void frmHallBoking_Load(object sender, EventArgs e)
        {
            dgvFAid.BringToFront();
            // TODO: This line of code loads data into the 'dataset2.tblAids' table. You can move, or remove it, as needed.
            this.tblAidsTableAdapter.Fill(this.dataset2.tblAids);
            // TODO: This line of code loads data into the 'comDataSet.tblHelp' table. You can move, or remove it, as needed.
            this.tblHelpTableAdapter.Fill(this.comDataSet.tblHelp);

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

            // TODO: This line of code loads data into the 'comDataSet.tblTransactions' table. You can move, or remove it, as needed.
            this.tblTransactionsTableAdapter.Fill(this.comDataSet.tblTransactions);

            btnReset_Click(sender, e);



        }

        private void txtSerialNo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSerialNo.Text != "")
                {
                    int fcardno = Convert.ToInt32(txtSerialNo.Text);
                    int x = 5 - txtSerialNo.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    txtSerialNo.Text = zeros + txtSerialNo.Text;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");
            }
            if (txtSerialNo.Text != "")
            {
                try
                {
                    string serial = txtSerialNo.Text;


                    if (checkSerialNo(serial))
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

                    txtSerialNo.Focus();
                }
            }
            else
            {
                txtSerialNo.Text = getNextSerialNo().ToString("00000");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbl.Text = Header + ">>Loading";
            string serialNo = txtSerialNo.Text;
            string fCardno = txtFCardNo.Text;

            if (checkSerialNo(fCardno))
            {
                //mode = 2;

                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                try
                {
                    Conn.Open();

                    //SqlCommand Command = new SqlCommand("SELECT  FCardNo,HeadofFamily,FName,Orakh,Name,HelpType,ReceiveDate,Remarks,Status,Amount,CompleteDate,ID,SerialNo FROM tblHelp Where SerialNo=" + SerialNo.ToString(), Conn);

                    SqlCommand Command = new SqlCommand("SELECT FCardNo,HeadofFamily,FName,Orakh,Name,HelpType,ReceiveDate,Remarks,Status,Amount,CompleteDate,ID,AidFrom FROM tblHelp Where FCardNo='" + fCardno.ToString() + "'", Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        txtSerialNo.ReadOnly = true;

                        if (dgvHallBooking.RowCount != 0)
                        {
                            dgvHallBooking.Rows.Clear();
                        }

                        btnLoad.Visible = false;
                        btnCloseView.Enabled = true;
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        btnPrint.Enabled = true;
                        btnNew.Enabled = false;


                        //dgvHallBooking.ReadOnly = true;
                        dgvHallBooking.AllowUserToDeleteRows = false;
                        dgvHallBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                        txtFCardNo.ReadOnly = true;
                        //int rIndex = 0;

                        while (Reader.Read())
                        {

                            txtFCardNo.Text = Reader.GetValue(0).ToString();
                            txtHead.Text = Reader.GetValue(1).ToString();
                            txtFName.Text = Reader.GetValue(2).ToString();
                            txtOrakh.Text = Reader.GetValue(3).ToString();
                            //txtSerialNo.Text = Reader.GetValue(12).ToString();
                            int z = dgvHallBooking.Rows.Add();

                            for (int x = 4; x < Reader.FieldCount; x++)
                            {

                                string vartype = Reader.GetFieldType(x).ToString();
                                string value = "";
                                if (x == 9)
                                {
                                    value = Convert.ToDecimal(Reader.GetValue(x)).ToString("N2");
                                }
                                else
                                    value = Reader.GetValue(x).ToString();

                                if (vartype == "System.DateTime")
                                {
                                    if (!string.IsNullOrEmpty(value))
                                        dgvHallBooking.Rows[z].Cells[x - 4].Value = Convert.ToDateTime(value).ToShortDateString();
                                }
                                else if (vartype == "System.Int32")
                                {
                                    if (x == 4)
                                    {
                                        usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
                                        dgvHallBooking.Rows[z].Cells[x - 4].Value = Convert.ToInt64(value);
                                    }
                                    else if (x == 5)
                                        dgvHallBooking.Rows[z].Cells[x - 4].Value = Convert.ToInt32(value);
                                    else
                                        dgvHallBooking.Rows[z].Cells[x - 4].Value = Convert.ToInt32(value);
                                }
                                else
                                {
                                    dgvHallBooking.Rows[z].Cells[x - 4].Value = value;
                                }


                            }

                            //if (!string.IsNullOrEmpty(Convert.ToString(dgvHallBooking.Rows[z].Cells["Date"].Value)))
                            //{
                            //    dgvHallBooking.Rows[z].Cells["Date"].Value = Convert.ToDateTime(dgvHallBooking.Rows[z].Cells["Date"].Value).ToShortDateString();
                            //}
                            //if (!string.IsNullOrEmpty(Convert.ToString(dgvHallBooking.Rows[z].Cells["CompletedOn"].Value)))
                            //{
                            //    dgvHallBooking.Rows[z].Cells["CompletedOn"].Value = Convert.ToDateTime(dgvHallBooking.Rows[z].Cells["CompletedOn"].Value).ToShortDateString();
                            //}
                            //dgvHallBooking.Rows.Add(row);
                        }


                    }

                    Reader.Close();
                    lbl.Text = Header;
                    txtSerialNo.Text = Convert.ToDecimal(serialNo).ToString("00000");
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

        private void txtSerialNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string serial = txtSerialNo.Text;

                if (checkSerialNo(serial))
                {
                    btnLoad.Visible = true;
                    this.AcceptButton = btnLoad;
                }
                else
                {
                    btnLoad.Visible = false;
                    this.AcceptButton = btnSave;
                }
            }
            catch (FormatException)
            {

            }
        }

        private void btnCloseView_Click(object sender, EventArgs e)
        {
            lbl.Text = Header;
            txtSerialNo.ReadOnly = false;
            btnReset_Click(sender, e);
            mode = 0;
            btnCloseView.Enabled = false;
            btnReset.Enabled = false;
            btnEdit.Enabled = true;
            this.AcceptButton = btnSave;
            dgvHallBooking.ReadOnly = false;
            dgvHallBooking.AllowUserToDeleteRows = true;
            btnSave.Enabled = false;
            txtFCardNo.ReadOnly = false;
            btnDelete.Enabled = true;
            btnPrint.Enabled = true;
            btnClose.Show();
            btnNew.Enabled = true;
            dgvFAid.Show();
            tblHelpTableAdapter.Fill(comDataSet.tblHelp);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            SerialNo = dgvFAid.CurrentRow.Cells["serialNoDataGridViewTextBoxColumn"].Value.ToString();
            FamilyCardNo = dgvFAid.CurrentRow.Cells["fCardNoDataGridViewTextBoxColumn"].Value.ToString();
            dtpAppReceivedOn.Text = dgvFAid.CurrentRow.Cells["receiveDateDataGridViewTextBoxColumn"].Value.ToString();
            dtpCompletedOn.Text = dgvFAid.CurrentRow.Cells["completeDateDataGridViewTextBoxColumn"].Value.ToString();
            lbl.Text = Header + ">>Modifing Aid";
            btnEdit.Enabled = false;
            mode = 1;
            dgvHallBooking.ReadOnly = false;
            dgvHallBooking.AllowUserToDeleteRows = true;
            btnSave.Enabled = true;
            txtFCardNo.ReadOnly = false;
            txtFCardNo.Text = FamilyCardNo;
            txtSerialNo.Text = SerialNo;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            dgvHallBooking.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            btnLoad_Click(sender, e);
            //txtSerialNo.Text = SerialNo;
            dgvFAid.Hide();
            btnCloseView.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbl.Text = Header + ">>Delete Aid";
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?\n\nThis will remove all records in current booking!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string serial = dgvFAid.CurrentRow.Cells[1].Value.ToString();
                if (result == DialogResult.Yes)
                {
                    tblHelpTableAdapter.Delete_Serial(serial);
                    MessageBox.Show("Successfully deleted!");
                    btnCloseView_Click(sender, e);
                    lbl.Text = Header;
                    tblHelpTableAdapter.Fill(comDataSet.tblHelp);
                }
                else
                    lbl.Text = Header;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvHallBooking_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (e.Row.Cells[10].Value != null && mode == 1)
                {
                    if (dgvHallBooking.Rows.Count == 2)
                    {
                        e.Cancel = true;
                        btnDelete_Click(sender, e);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            bool result2 = dbLayer.DeleteHallBooking(Convert.ToInt32(e.Row.Cells[10].Value.ToString()));
                            if (result2)
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }






        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(txtSerialNo.Text);
        //    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Select * from tblHallBooking WHERE SerialNo =" + id, con);

        //    DataTable dt = new DataTable();

        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;

        //    da.Fill(dt);
        //    Reports.Hall_Booking.frmViewer frm = new MCKJ.Reports.Hall_Booking.frmViewer();
        //    Reports.Hall_Booking.rptHallBooking rpt = new MCKJ.Reports.Hall_Booking.rptHallBooking();

        //    frm.crystalReportViewer1.ReportSource = rpt;        
        //    rpt.SetDataSource(dt);
        //    rpt.SetParameterValue("SerialNo", id.ToString("00000"));
        //    rpt.SetParameterValue("SerialNo", id.ToString("00000"), rpt.Subreports[0].Name.ToString());




        //    frm.Show();
        //    con.Close();
        //}

        private void txtFCardNo_Leave(object sender, EventArgs e)
        {

            try
            {
                if (txtFCardNo.Text != "")
                {
                    int fcardno = Convert.ToInt32(txtFCardNo.Text);
                    int x = 5 - txtFCardNo.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    txtFCardNo.Text = zeros + txtFCardNo.Text;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");
            }
            string y = txtFCardNo.Text;

            Community.DBLayer DBLayer = new Community.DBLayer();
            bool result = DBLayer.CheckFamily(txtFCardNo.Text);

            for (int x = 0; x < dgvHallBooking.Rows.Count - 1; x++)
            {
                dgvHallBooking.Rows[x].Cells[0].Value = null;
            }
            if (txtFCardNo.Text != "")
            {
                if (result)
                {

                    Fill(txtFCardNo.Text);
                    txtFName.Text = FName;
                    txtHead.Text = Head;
                    txtOrakh.Text = Orakh;


                    if (txtFCardNo.Text == "")
                    {
                        txtFCardNo.Text = y;

                    }
                }
                else
                {
                    MessageBox.Show("Family CardNo doesnot exist! Please enter a Valid CardNo.", "Invalid CardNo.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtHead.Text = "";
                }
            }
            usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
        }

        private void dgvHallBooking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int x = 0; x < dgvHallBooking.Rows.Count - 1; x++)
            {
                if (dgvHallBooking.Rows[x].Cells[5].Value != null)
                {
                    dgvHallBooking.Rows[x].Cells[5].Value = Convert.ToDouble(dgvHallBooking.Rows[x].Cells[5].Value.ToString()).ToString("N2");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvFAid.Hide();
            mode = 0;
            txtSerialNo.Focus();
            txtSerialNo.Text = getNextSerialNo().ToString("00000");
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCloseView.Show();
            btnSave.Enabled = true;
            btnReset.Enabled = true;
            btnCloseView.Enabled = true;
        }

        private void btnSetAppRcvdOn_Click(object sender, EventArgs e)
        {
            Point p = dgvHallBooking.CurrentCellAddress;
            if (p.Y >= 0)
            {
                dgvHallBooking["Date", p.Y].Value = dtpAppReceivedOn.Value.ToString("dd/MM/yyyy");
            }
        }

        private void btnSetCompltdOnDate_Click(object sender, EventArgs e)
        {
            Point p = dgvHallBooking.CurrentCellAddress;
            if (p.Y >= 0)
            {
                dgvHallBooking["CompletedOn", p.Y].Value = dtpCompletedOn.Value.ToString("dd/MM/yyyy");
            }
        }

        private void dgvHallBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAid_Load(object sender, EventArgs e)
        {

        }
    }
}

