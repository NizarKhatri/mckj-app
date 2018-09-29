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
    public partial class frmAdvance : Form
    {
        Community.DBLayer dbLayer = new Community.DBLayer();

        int mode = 0;
        int currRowIndex = 0;
        int initialTop = 86;
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 7;
        Community.DBLayer DBLayer = new Community.DBLayer();
        string Header = "Advance Payments Receipt";
        string ReceiptNo = "";
        static DataTable dtSearch;

        #region Functions


        private void Garbage()
        {
            //if (Hall1 == 1)
            //{
            //    chk_Hall1 = HallChecking("Hall1", Dated, FromTime, ToTime);
            //    if (chk_Hall1)
            //    {
            //        MessageBox.Show("Hall No 1 already Booked on the Date and Time Provided!!", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //    }
            //}

            //if (Hall2 == 1)
            //{
            //    chk_Hall2 = HallChecking("Hall2", Dated, FromTime, ToTime);
            //    if (chk_Hall2)
            //    {
            //        MessageBox.Show("Hall No 2 already Booked on the Date and Time Provided!!", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //    }
            //}

            //if (Hall3 == 1)
            //{
            //    chk_Hall3 = HallChecking("Hall3", Dated, FromTime, ToTime);
            //    if (chk_Hall3)
            //    {
            //        MessageBox.Show("Hall No 3 already Booked on the Date and Time Provided!!", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //    }
            //}

            //if (Hall4 == 1)
            //{
            //    chk_Hall4 = HallChecking("Hall4", Dated, FromTime, ToTime);
            //    if (chk_Hall4)
            //    {
            //        MessageBox.Show("Hall No 4 already Booked on the Date and Time Provided!!", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //    }
            //}
            //int hour = FromTime.TimeOfDay.Hours;
            //string hr = "";

            //if (hour > 12)
            //{
            //    hour = (hour - 12);
            //    hr = hour.ToString();
            //}
            //else
            //{
            //    hr = hour.ToString();
            //}


            //string ftc = FromTime.ToString();
            //DateTime check = FromTime;

            //ftc = ftc.Replace(hr, fti[0]);

            //string from = dgvHallBooking.Rows[x].Cells[7].Value.ToString();
            ////string fromtime = DateTime.Now.Hour.ToString();

            ////DateTime Day = Convert.ToDateTime(_Day);
            ////Day = Convert.ToDateTime(day).ToString();

            ////FromTime.TimeOfDay = dgvHallBooking.Rows[x].Cells[7].Value.ToString();

            //string _Day = DateTime.Now.ToLongDateString();
            //string a = DateTime.Now.DayOfWeek.ToString();
            //string day = dgvHallBooking.Rows[x].Cells[6].Value.ToString();
            //_Day = _Day.Replace(a, day);

            //Day.Day = dgvHallBooking.Rows[x].Cells[6].Value.ToString();
            //string fromtime = DateTime.Now.Hour.ToString();                                                          
            //DateTime FromTime = DateTime.Now;
            ////string ft = FromTime.ToLongTimeString();
            //string a;
            //a = FromTime.ToString();
            //string ass1;
            //ass1 = a.Substring(0, 9);
            //string ass2;
            //ass2 = a.Substring(10, 3);
            //string ass3;
            //ass3 = a.Substring(13, 7);
            //string assfinal;
            //assfinal = ass1 + ass2 + ass3;

            //string assr;
            //assr = "10";
            //ass.Replace(ass.ToString(), assr);
        }
        private bool HallChecking(string Hall, DateTime Dated, DateTime fromTime, DateTime ToTime)
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

                SqlCommand Command = new SqlCommand("Select ReceiptNo From tblAdvance Order By  cast(ReceiptNo as INT) desc", Conn);

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

            bool result = false;

            SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

            try
            {
                Conn.Open();

                SqlCommand Command = new SqlCommand("Select ReceiptNo From tblAdvance Where ReceiptNo='" + SerialNo + "'", Conn);

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

            if (string.IsNullOrEmpty(txtFCardNo.Text))
            {
                MessageBox.Show("Please Enter Family card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            if (string.IsNullOrEmpty(txthbkReceipt.Text))
            {
                MessageBox.Show("Please Enter Hall Booking Reciept Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            if (dgvHallBooking.Rows.Count == 1)
            {
                for (int x = 0; x < dgvHallBooking.Rows.Count; x++)
                {
                    if (dgvHallBooking.Rows[x].Cells[0].Value == null || Convert.ToInt32(dgvHallBooking.Rows[x].Cells[3].Value) >= 0)
                    {
                        MessageBox.Show("Please select an event and amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                for (int x = 0; x < dgvHallBooking.Rows.Count - 1; x++)
                {

                    if (dgvHallBooking.Rows[x].Cells[0].Value == null || Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[3].Value) <= 0)
                    {
                        MessageBox.Show("Please select an event and amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public frmAdvance()
        {
            InitializeComponent();
        }

        private void disable(bool ch)
        {
            btnDelete.Enabled = ch;
            btnEdit.Enabled = ch;
            btnPrint.Enabled = ch;
            btnAdd.Enabled = ch;
            dataGridView1.Visible = ch;
        }
        
        public static int HRD(string Acc_Name)
        {
            int acc_name = 0;
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                SqlCommand cmd = new SqlCommand("SELECT ID FROM tblAccounts WHERE AccountName = '" + Acc_Name + "'", con);
                con.Open();

                acc_name = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("An unknown error occured!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return acc_name;
        }

        //private void Fill_Search()
        //{

        //    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
        //    string query = richTextBox2.Text;
        //    query = query.Replace("@Dated", dtpSearchDate.Text);
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();

        //    SqlDataReader Reader = cmd.ExecuteReader();


        //    if (dataGridView1.RowCount != 0)
        //    {
        //        dataGridView1.Rows.Clear();
        //    }
        //    while (Reader.Read())
        //    {
        //        int z = dataGridView1.Rows.Add();
        //        for (int x = 0; x < Reader.FieldCount; x++)
        //        {

        //            string value = Reader.GetValue(x).ToString();
        //            string vartype = Reader.GetFieldType(x).ToString();


        //            if (x == 4 || x == 5 || x == 6 || x == 7)
        //            {
        //                if (value == "True")
        //                {
        //                    value = "1";
        //                }
        //                else
        //                {
        //                    value = "0";
        //                }
        //            }

        //            if (x == 8 || x == 9)
        //            {
        //                int hour = Convert.ToDateTime(value).TimeOfDay.Hours;
        //                string Time = "";
        //                if (hour > 12)
        //                {
        //                    hour = hour - 12;
        //                    Time = hour.ToString("00") + "-PM";
        //                }
        //                else if (hour == 0)
        //                {
        //                    Time = "12-AM";
        //                }
        //                else
        //                {
        //                    Time = hour.ToString("00") + "-AM";
        //                }
        //                dataGridView1.Rows[z].Cells[x].Value = Time;


        //            }
        //            else
        //            {
        //                if (x == 0)
        //                    dataGridView1.Rows[z].Cells[x].Value = Convert.ToInt32(value).ToString("00000");
        //                else if (x == 1)
        //                {
        //                    dataGridView1.Rows[z].Cells[x].Value = Convert.ToDateTime(value).ToShortDateString();
        //                }
        //                else
        //                {
        //                    dataGridView1.Rows[z].Cells[x].Value = value;
        //                }
        //            }
        //        }
        //    }
        //}

        private string From_To(int Serial)
        {
            string ft = "";
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            SqlCommand cmd = new SqlCommand("Select FromTime , ToTime from tblHallBooking WHERE SerialNo = " + Serial, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            string from = "";
            string to = "";

            if (reader.HasRows)
            {
                reader.Read();
                for (int x = 0; x < reader.FieldCount; x++)
                {

                    int hour = Convert.ToDateTime(reader.GetValue(x)).TimeOfDay.Hours;
                    string Time = "";
                    if (hour > 12)
                    {
                        hour = hour - 12;
                        Time = hour.ToString("00") + "-PM";
                    }
                    else if (hour == 0)
                    {
                        Time = "12-AM";
                    }
                    else
                    {
                        Time = hour.ToString("00") + "-AM";
                    }
                    if (x == 0)
                        from = Time;
                    else if (x == 1)
                        to = Time;

                }
                ft = from + " To " + to;
            }
            return ft;

        }
     
        private int TransactionID(int serialno)
        {

            int id = 0;
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            SqlCommand cmd = new SqlCommand("Select ID from tblTransactions WHERE Voucher = 'ADV' AND DocumentNo = " + serialno, con);

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

        //private void dgvHallBooking_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    //string[] events = { "Majlis / Soyem", "Engagement", "Mayon / Mefil", "Aameen/ Rasm-e-Ter", "Birthday / Anniversary", "Khatna", "Aqiqa", "Other" };

        //    //int eIndex = e.Row.Index;
        //    //int eIndex2 = eIndex-1;

        //    //if (eIndex2 >= events.Length)
        //    //{
        //    //    eIndex2 = events.Length - 1;
        //    //}           

        //    //dgvHallBooking.Rows[eIndex].Cells[0].Value = events[eIndex2];

        //    //if (dgvHallBooking.Rows.Count == 10)
        //    //{
        //    //    dgvHallBooking.AllowUserToAddRows = false;
        //    //}

        //}

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
                    txtHead.Text = "";
                    txtFName.Text = "";
                    txtFCardNo.Text = string.Empty;
                    cmbOrakh.Text = null;                   
                    cmbAccount.SelectedItem = 0;
                    txtContactNo.Text = "";
                    txthbkReceipt.Text = "";
                    dgvHallBooking.Rows.Clear();
                    dgvHallBooking.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;                   
                    txtReceipt.Text = getNextSerialNo().ToString("00000");
                    dtpDate.Focus();
                    txtTotal.Text = "0.00";

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
                    int receipt = Convert.ToInt32(txtReceipt.Text);
                    string Head = txtHead.Text;
                    DateTime Date = Convert.ToDateTime(dtpDate.Text);
                    string FName = txtFName.Text;
                    string Orakh = cmbOrakh.Text;                    
                    int Account = Convert.ToInt32(cmbAccount.SelectedValue.ToString());
                    string ContactNo = txtContactNo.Text;
                    int FCardNo = 0;
                    if (!(Int32.TryParse(txtFCardNo.Text, out FCardNo)))
                    {
                        FCardNo = 0;
                    }
                    int hbkRec = 0;
                    if(!(Int32.TryParse(txthbkReceipt.Text,out hbkRec)))
                    {
                        hbkRec = 0;
                    }

                    int rSuccess = 0;
                    int rAdded = 0;

                    if (mode == 0)
                    {
                        decimal TotalAmount = 0;
                        int countt = 0;

                        if (dgvHallBooking.Rows.Count == 6)
                        {
                            countt = 6;
                        }
                        else
                            countt = dgvHallBooking.Rows.Count - 1;
                        for (int x = 0; x < countt; x++)
                        {
                            decimal PerPerson = 0;
                            decimal Persons = 0;
                            int Event = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[0].Value.ToString());
                            if (dgvHallBooking.Rows[x].Cells[1].Value != null)
                            {
                                Persons = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[1].Value.ToString());
                            }
                            if (dgvHallBooking.Rows[x].Cells[2].Value != null)
                                PerPerson = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[2].Value.ToString());
                            decimal Amount = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[3].Value.ToString());                                                      
                            TotalAmount += Amount;
                            bool result = Convert.ToBoolean(tblAdvanceTableAdapter.Add(receipt.ToString("00000"),Date,FCardNo.ToString("00000"),Head,FName,Orakh,Event,Persons,PerPerson,Amount,ContactNo,Account, hbkRec.ToString("00000")));
                            if (result)
                            {
                                rSuccess++;
                            }

                        }

                        tblTransactionsTableAdapter.InsertTransaction(HRD("Decoration Charges"), "ADV", receipt, Date, 0, TotalAmount, "Advance for Hall Booking", "", "");
                        //tblTransactionsTableAdapter.InsertTransaction(115, "ADV",receipt, Date, TotalAmount, 0, "Advance for Hall Booking", "", "");
                        MessageBox.Show(rSuccess.ToString() + " Out Of " + Convert.ToString(countt) + " Row(s) Added Successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        disable(true);
                        tblAdvanceTableAdapter.Fill(comDataSet.tblAdvance);
                        Text = Header;

                    }
                    else if (mode == 1)
                    {
                        decimal TotalAmount = 0;
                        decimal Persons = 0;
                        decimal PerPerson = 0;
                        int countt = 0;

                        if (dgvHallBooking.Rows.Count == 6)
                        {
                            countt = 6;
                        }
                        else
                            countt = dgvHallBooking.Rows.Count - 1;
                        for (int x = 0; x < countt; x++)
                        {

                            int Event = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[0].Value.ToString());

                            if (dgvHallBooking.Rows[x].Cells[1].Value != null)
                            {
                                Persons = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[1].Value);
                            }
                            if (dgvHallBooking.Rows[x].Cells[2].Value != null)
                            {
                                PerPerson = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[2].Value.ToString());
                            }
                            decimal Amount = Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[3].Value.ToString());
                            TotalAmount += Amount;
                            bool result = false;
                            bool added = false;
                            
                            if (dgvHallBooking.Rows[x].Cells[4].Value != null && dgvHallBooking.Rows[x].Cells[4].Value.ToString() != "")
                            {
                                int rID = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[4].Value.ToString());
                                result = Convert.ToBoolean(tblAdvanceTableAdapter.Upd(receipt.ToString("00000"), Date,FCardNo.ToString("00000"),Head,FName,Orakh,Event,Persons,PerPerson,Amount,ContactNo,Account,hbkRec.ToString("00000"),rID));
                                added = false;
                            }
                            else
                            {
                                result = Convert.ToBoolean(tblAdvanceTableAdapter.Add(receipt.ToString("00000"),Date,FCardNo.ToString("00000"),Head,FName,Orakh,Event,Persons,PerPerson,Amount,ContactNo,Account,hbkRec.ToString("00000")));
                                added = true;
                            }

                            if (result)
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
                        string msg = rSuccess.ToString() + " Out Of " + Convert.ToString(countt - rAdded) + " Record(s) Updated Successfully!";

                        if (rAdded != 0)
                        {
                            msg += "\n\n" + rAdded.ToString() + " new Records added!";
                        }
                        tblTransactionsTableAdapter.UpdateTransaction(HRD("Decoration Charges"), "ADV", Convert.ToInt32(receipt), Date, 0, TotalAmount, "Received as Advance", "", "", TransactionID(Convert.ToInt32(receipt)));
                        //tblTransactionsTableAdapter.UpdateTransaction(Account, "ADV", Convert.ToInt32(receipt), Date, TotalAmount, 0, "Received as Advance" , "", "", TransactionID(Convert.ToInt32(receipt)) + 1);
                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tblAdvanceTableAdapter.Fill(comDataSet.tblAdvance);
                        //txtSerialNo.ReadOnly = false;
                        //btnReset_Click(sender, e);
                        disable(true);
                        Text = Header;
                        btnReset.Enabled = true;
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

        private void dgvHallBooking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                try
                {
                    
                    /*decimal person = Convert.ToDecimal(dgvHallBooking.CurrentRow.Cells[1].Value);
                    decimal per = Convert.ToDecimal(dgvHallBooking.CurrentRow.Cells[2].Value);
                    decimal amount = person * per;
                    if (per != 0)
                    {
                        string amt = amount.ToString("N2");
                        dgvHallBooking.CurrentRow.Cells[3].Value = amt;
                    }
                    else
                        dgvHallBooking.CurrentRow.Cells[3].Value = "0.00";*/
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid Date format..\ni.e dd//MM//YYYY", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }            
                decimal Amt = 0;
                int countt = 0;

                if (dgvHallBooking.Rows.Count == 6)
                {
                    countt = 6;
                }
                else
                    countt = dgvHallBooking.Rows.Count - 1;
                for (int x = 0; x < countt ;x++)
                {
                    Amt += Convert.ToDecimal(dgvHallBooking.Rows[x].Cells[3].Value);
                }
                txtTotal.Text = Amt.ToString("N2");                     
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("\r"))
            {
                comboBox1.SendToBack();

                if (comboBox1.Text != "")
                {
                    if (currRowIndex != -1)
                    {
                        dgvHallBooking.Rows[currRowIndex].Cells[0].Value = comboBox1.Text;
                    }

                    dgvHallBooking.CurrentCell = dgvHallBooking.Rows[currRowIndex].Cells[1];

                    dgvHallBooking.Focus();

                    currRowIndex = 0;
                }
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            KeyPressEventArgs keys = new KeyPressEventArgs(Convert.ToChar("\r"));

            comboBox1_KeyPress(sender, keys);
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (currRowIndex >= dgvHallBooking.RowCount) { currRowIndex = dgvHallBooking.RowCount - 1; }

            if (dgvHallBooking.Rows[currRowIndex].Cells[0].Value != null)
            {
                if (dgvHallBooking.Rows[currRowIndex].Cells[0].Value.ToString() != "")
                {
                    comboBox1.Text = dgvHallBooking.Rows[currRowIndex].Cells[0].Value.ToString();
                }
            }
            else
            {
                if (comboBox1.Text != "")
                {
                    try
                    {
                        int iIndex = 1;
                        if (currRowIndex < comboBox1.Items.Count)
                        {
                            iIndex = currRowIndex + 1;
                        }
                        dgvHallBooking.Rows[currRowIndex].Cells[0].Value = comboBox1.Items[iIndex].ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHallBoking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblAdvance' table. You can move, or remove it, as needed.
            this.tblAdvanceTableAdapter.Fill(this.comDataSet.tblAdvance);
            dtSearch = this.comDataSet.tblAdvance;
            // TODO: This line of code loads data into the 'dataset3.tblAdvAcc' table. You can move, or remove it, as needed.
            this.tblAdvAccTableAdapter.Fill(this.dataset3.tblAdvAcc);
            // TODO: This line of code loads data into the 'dataset2.tblHallAcc' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataset2.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataset2.tblEvents);
            // TODO: This line of code loads data into the 'comDataSet.tblAccounts' table. You can move, or remove it, as needed.
            this.tblAccountsTableAdapter.Fill(this.comDataSet.tblAccounts);

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
            // TODO: This line of code loads data into the 'comDataSet.tblTransactions' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblOrakh' table. You can move, or remove it, as needed.
            this.usp_SEL_tblOrakhTableAdapter.Fill(this.comDataSet.usp_SEL_tblOrakh);

            dataGridView1.BringToFront();

            foreach (DataColumn dc in dtSearch.Columns)
            {
                cmbCriteria.Items.Add(dc.ToString());
            }

        }

        private void txtSerialNo_Leave(object sender, EventArgs e)
        {
            if (txtReceipt.Text != "")
            {
                try
                {
                    int serial = Convert.ToInt32(txtReceipt.Text);
                    txtReceipt.Text = serial.ToString("00000");
                   
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtReceipt.Focus();
                }
            }           

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {           
            if (checkSerialNo(ReceiptNo))
            {
                //mode = 2;

                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("SELECT ReceiptNo,Date, FCardNo, Head, Events, Persons, PerPerson, Amount, tblAdvance.ID,FName,Orakh,ContactNo,AdvAcc,hbkReceipt FROM tblAdvance Where ReceiptNo ='" + ReceiptNo + "'", Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {                       
                        if (dgvHallBooking.RowCount != 0)
                        {
                            dgvHallBooking.Rows.Clear();
                        }
                       
                       

                        dgvHallBooking.ReadOnly = false;
                        dgvHallBooking.AllowUserToDeleteRows = false;
                        dgvHallBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        

                        while (Reader.Read())
                        {
                            txtReceipt.Text = Reader.GetValue(0).ToString();
                            dtpDate.Text = Reader.GetValue(1).ToString();
                            txtHead.Text = Reader.GetValue(3).ToString();
                            txtFName.Text = Reader.GetValue(9).ToString();
                            txthbkReceipt.Text = Reader.GetValue(13).ToString();
                            cmbOrakh.Text = Reader.GetValue(10).ToString();
                            txtContactNo.Text = Reader.GetValue(11).ToString();
                            cmbAccount.SelectedValue = Reader.GetValue(12);
                            txtFCardNo.Text = Reader.GetValue(2).ToString();

                            int z = dgvHallBooking.Rows.Add();

                            for (int x = 4; x < Reader.FieldCount - 5; x++)
                            {
                                string value = Reader.GetValue(x).ToString();
                                string vartype = Reader.GetFieldType(x).ToString();

                                                              
                               
                                    if (vartype == "System.Int32")
                                    {
                                        dgvHallBooking.Rows[z].Cells[x - 4].Value = Convert.ToInt32(value);
                                    }
                                    else
                                    {                                        
                                        if (x == 5)
                                        {
                                            dgvHallBooking.Rows[z].Cells[x - 4].Value = Convert.ToDecimal(value).ToString("N0");
                                        }
                                        else
                                        {
                                            dgvHallBooking.Rows[z].Cells[x - 4].Value = Convert.ToDecimal(value).ToString("N2");
                                        }
                                    }
                                }                            
                            comboBox1.SendToBack();
                            
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
       
        private void btnCloseView_Click(object sender, EventArgs e)
        {            
            mode = 0;
            disable(true);
            tblAdvanceTableAdapter.Fill(comDataSet.tblAdvance);
            btnReset.Enabled = true;
            gbSearch.Visible = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                mode = 1;
                disable(false);
                ReceiptNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                btnLoad_Click(sender, e);
                btnReset.Enabled = false;
                lblHeader.Text = Header + " >> Modify Receipt";
                /*decimal person = Convert.ToDecimal(dgvHallBooking.CurrentRow.Cells[1].Value);
                decimal per = Convert.ToDecimal(dgvHallBooking.CurrentRow.Cells[2].Value);
                decimal amount = person * per;
                if (per != 0)
                {
                    string amt = amount.ToString("N2");
                    dgvHallBooking.CurrentRow.Cells[3].Value = amt;
                }
                else
                    dgvHallBooking.CurrentRow.Cells[3].Value = "0.00";*/

                if (dgvHallBooking.Rows.Count > 5)
                {
                    dgvHallBooking.AllowUserToAddRows = false;
                }
                else
                    dgvHallBooking.AllowUserToAddRows = true;
                foreach (DataGridViewRow dgvr in dgvHallBooking.Rows)
                {
                    if (dgvr.Index < dgvHallBooking.Rows.Count-1)
                        txtTotal.Text = (Convert.ToDecimal(dgvr.Cells[3].Value.ToString()) + Convert.ToDecimal(txtTotal.Text)).ToString("F");
                }
            }
            else
                MessageBox.Show("No record to Modify!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?\n\nThis will remove all records in current booking!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    lblHeader.Text = Header + " >> Deleting Record";
                    if (result == DialogResult.Yes)
                    {
                        string recipt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        bool result2 = Convert.ToBoolean(tblAdvanceTableAdapter.Del(recipt));
                        if (result2)
                        {
                            lblHeader.Text = Header;
                            tblTransactionsTableAdapter.DeleteTransactions("ADV", Convert.ToInt32(recipt));
                            MessageBox.Show("Successfully deleted!");
                            tblAdvanceTableAdapter.Fill(comDataSet.tblAdvance);
                        }
                        else
                            lblHeader.Text = Header;
                    }
                }
                else
                    MessageBox.Show("No record to delete!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            bool result2 = Convert.ToBoolean(tblAdvanceTableAdapter.Del_inv((Convert.ToInt32(e.Row.Cells[4].Value.ToString()))));
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

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    DateTime date = Convert.ToDateTime(dtpSearchDate.Text);

        //    Fill_Search();
        //    if (dataGridView1.Rows.Count != 0)
        //    {
        //        grbSearch.BringToFront();
        //        grbSearch.Visible = true;
        //        button1.BringToFront();
        //        lblHeader.Text = Header + " >> Hall Booked on " + Convert.ToDateTime(dtpSearchDate.Text).ToString("dd/MM/yyyy");
        //    }
        //    else
        //        MessageBox.Show("There is no Hall Booking on the date provided", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //int serial =getSerialByDate(Convert.ToDateTime(dtpSearchDate.Text));

        //    //if (serial != 0)
        //    //{
        //    //    btnCloseView_Click(sender,e);

        //    //    txtSerialNo.Text = serial.ToString("00000");

        //    //    btnLoad_Click(sender, e);

        //    //    for (int x = 0; x < dgvHallBooking.RowCount; x++)
        //    //    {
        //    //        if (dgvHallBooking.Rows[x].Cells[6].Value != null)
        //    //        {
        //    //            string tmpDate = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[5].Value.ToString()).ToShortDateString();

        //    //            if (tmpDate == dtpSearchDate.Text)
        //    //            {
        //    //                dgvHallBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    //                dgvHallBooking.Rows[x].Selected = true;
        //    //                break;
        //    //            }
        //    //        }
        //    //    }                
        //    //    AcceptButton = btnCloseView;
        //    //}

        //    //else
        //    //{
        //    //    MessageBox.Show("No Hall has been booked on the date provided.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //}

        //}

        //private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        //{
        //    AcceptButton = btnSearch;
        //}


        private void btnPrint_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            con.Open();
            string sql = richTextBox1.Text;
            sql = sql.Replace("@ReceiptNo", id);
            SqlCommand cmd = new SqlCommand(sql, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt);
            Reports.Hall_Booking.frmViewer frm = new MCKJ.Reports.Hall_Booking.frmViewer();
            Reports.Advance.rptAdvance rpt = new MCKJ.Reports.Advance.rptAdvance();

            frm.crystalReportViewer1.ReportSource = rpt;
            rpt.SetDataSource(dt);
            frm.Text = "Advance Receipt";
            //rpt.SetParameterValue("SerialNo", id.ToString("00000"), rpt.Subreports[0].Name.ToString());
            //rpt.SetParameterValue(rpt.ParameterFields[1].Name, From_To(id), rpt.Subreports[0].Name.ToString());        


            frm.Show();
            con.Close();
        }

        private void dgvHallBooking_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    button1.SendToBack();
        //    grbSearch.Hide();
        //    lblHeader.Text = Header;
        //}

        private void btnGetName_Click(object sender, EventArgs e)
        {
            if (txtFCardNo.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(dbLayer.CON_string);

                    SqlCommand cmd = new SqlCommand("SELECT MemberName,FatherName FROM tblFamilyMember WHERE FCardNo = '" + Convert.ToInt32(txtFCardNo.Text).ToString("00000") + "' AND LeaderRelation = 'Head of Family'", con);

                    con.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtHead.Text = reader.GetValue(0).ToString();
                        txtFName.Text = reader.GetValue(1).ToString();
                        reader.Close();
                    }
                    else
                        MessageBox.Show("Family card not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please enter Family Card Number", "Card no Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFCardNo_Leave(object sender, EventArgs e)
        {
            if (txtFCardNo.Text != "")
            {
                try
                {
                    string FCard = txtFCardNo.Text = Convert.ToInt32(txtFCardNo.Text).ToString("00000");

                    SqlConnection con = new SqlConnection(dbLayer.CON_string);


                    SqlCommand cmd = new SqlCommand("SELECT [Sign] FROM tblFamily WHERE FCardNo = '" + FCard + "'", con);

                    con.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        cmbOrakh.Text = reader.GetValue(0).ToString();
                        reader.Close();
                    }
                    else
                        MessageBox.Show("Family card not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvHallBooking_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int cou = dgvHallBooking.Rows.Count;
            if (dgvHallBooking.Rows.Count > 6)
            {
                dgvHallBooking.AllowUserToAddRows = false;
            }
            else
                dgvHallBooking.AllowUserToAddRows = true;
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
            disable(false);
            dgvHallBooking.AllowUserToAddRows = true;
            lblHeader.Text = Header + " >> New Receipt";
            txtReceipt.Text = getNextSerialNo().ToString("00000");
            gbSearch.Visible = false;
        }

        private void btnSearchCriteria_Click(object sender, EventArgs e)
        {
            //Date is selected in cmbCriteria
            if (cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[1].ToString())
            {
                txtSearch.Text = txtSearch.Text == "" ? "1900-01-01" : txtSearch.Text;
                dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + "='" + DateTime.Parse(txtSearch.Text) + "'";
            }
            else
            {
                dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";
            }
            dataGridView1.DataSource = dtSearch.DefaultView;
        }
       

       

       
    }
}
    
