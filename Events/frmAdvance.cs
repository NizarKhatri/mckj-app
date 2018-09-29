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
    public partial class frmHallBoking : Form
    {
        Community.DBLayer dbLayer = new Community.DBLayer();

        int mode = 0;
        int currRowIndex = 0;
        int initialTop = 86;
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 7;
        Community.DBLayer DBLayer = new Community.DBLayer();
        string Header = "Hall Booking";



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

                SqlCommand Command = new SqlCommand("Select SerialNo From tblHallBooking Order By ID DESC", Conn);

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

        private bool checkSerialNo(int SerialNo)
        {
            if (SerialNo == 0)
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

                    SqlCommand Command = new SqlCommand("Select SerialNo From tblHallBooking Where SerialNo=" + SerialNo.ToString(), Conn);

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

            if (txtSerialNo.Text == "" || txtMr.Text == "")
            {
                MessageBox.Show("Please fill in the Required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                result = false;
            }
            if (dgvHallBooking.Rows.Count == 1)
            {
                for (int x = 0; x < dgvHallBooking.Rows.Count; x++)
                {
                    if (dgvHallBooking.Rows[x].Cells[0].Value == null || dgvHallBooking.Rows[x].Cells[5].Value == null || dgvHallBooking.Rows[x].Cells[6].Value == null || dgvHallBooking.Rows[x].Cells[7].Value == null || dgvHallBooking.Rows[x].Cells[8].Value == null || !validateHall(x))
                    {
                        MessageBox.Show("Row cannot have empty cells!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        result = false;
                        break;
                    }
                }
            }
            else
            {
                for (int x = 0; x < dgvHallBooking.Rows.Count - 1; x++)
                {
                    for (int y = 1; y <= 4; y++)
                    {
                        if (dgvHallBooking.Rows[x].Cells[y].Value == null)
                        {
                            dgvHallBooking.Rows[x].Cells[y].Value = "0";
                        }
                    }
                    if (dgvHallBooking.Rows[x].Cells[0].Value == null || dgvHallBooking.Rows[x].Cells[5].Value == null || dgvHallBooking.Rows[x].Cells[6].Value == null || dgvHallBooking.Rows[x].Cells[7].Value == null || dgvHallBooking.Rows[x].Cells[8].Value == null || !validateHall(x))
                    {
                        MessageBox.Show("Row cannot have empty cells!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        public frmHallBoking()
        {
            InitializeComponent();
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

        private void Fill_Search()
        {

            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            string query = richTextBox2.Text;
            query = query.Replace("@Dated", dtpSearchDate.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader Reader = cmd.ExecuteReader();


            if (dataGridView1.RowCount != 0)
            {
                dataGridView1.Rows.Clear();
            }
            while (Reader.Read())
            {
                int z = dataGridView1.Rows.Add();
                for (int x = 0; x < Reader.FieldCount; x++)
                {

                    string value = Reader.GetValue(x).ToString();
                    string vartype = Reader.GetFieldType(x).ToString();


                    if (x == 4 || x == 5 || x == 6 || x == 7)
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

                    if (x == 8 || x == 9)
                    {
                        int hour = Convert.ToDateTime(value).TimeOfDay.Hours;
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
                        dataGridView1.Rows[z].Cells[x].Value = Time;


                    }
                    else
                    {
                        if (x == 0)
                            dataGridView1.Rows[z].Cells[x].Value = Convert.ToInt32(value).ToString("00000");
                        else if (x == 1)
                        {
                            dataGridView1.Rows[z].Cells[x].Value = Convert.ToDateTime(value).ToShortDateString();
                        }
                        else
                        {
                            dataGridView1.Rows[z].Cells[x].Value = value;
                        }
                    }
                }
            }
        }

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
                    txtSerialNo.Text = getNextSerialNo().ToString("00000");
                    txtMr.Text = "";
                    txtFName.Text = "";
                    cmbOrakh.Text = null;
                    txtAmount.Text = "0.00";
                    cmbAccount.Text = null;
                    txtContactNo.Text = "";
                    dgvHallBooking.Rows.Clear();
                    dgvHallBooking.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    txtSerialNo.Focus();

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
                    int SerialNo = Convert.ToInt32(txtSerialNo.Text);
                    string Mr = txtMr.Text;
                    DateTime Date = Convert.ToDateTime(dtpDate.Text);
                    string FName = txtFName.Text;
                    string Orakh = cmbOrakh.Text;
                    decimal Amount = Convert.ToDecimal(txtAmount.Text);
                    int Account = Convert.ToInt32(cmbAccount.SelectedValue.ToString());
                    string ContactNo = txtContactNo.Text;
                    int FCardNo = Convert.ToInt32(txtFCardNo.Text);


                    int rSuccess = 0;
                    int rAdded = 0;

                    if (mode == 0)
                    {
                        if (!checkSerialNo(SerialNo))
                        {
                            for (int x = 0; x < dgvHallBooking.RowCount - 1; x++)
                            {
                                int Event = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[0].Value.ToString());

                                for (int y = 1; y <= 4; y++)
                                {
                                    if (dgvHallBooking.Rows[x].Cells[y].Value == null)
                                    {
                                        dgvHallBooking.Rows[x].Cells[y].Value = "0";
                                    }
                                }

                                if (dgvHallBooking.Rows[x].Cells[9].Value == null)
                                {
                                    dgvHallBooking.Rows[x].Cells[9].Value = "";
                                }

                                int Hall1 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[1].Value.ToString());
                                int Hall2 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[2].Value.ToString());
                                int Hall3 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[3].Value.ToString());
                                int Hall4 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[4].Value.ToString());

                                DateTime Dated = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[5].Value.ToString());
                                string datedd = Dated.ToString("dd/MM/yyyy") + " ";
                                string ft = dgvHallBooking.Rows[x].Cells[7].Value.ToString();
                                string[] fti = ft.Split(Convert.ToChar("-"));
                                int ftime = Convert.ToInt32(fti[0]);
                                DateTime FromTime = Convert.ToDateTime(datedd + ftime.ToString() + ":00:00 " + fti[1].ToString());

                                string tt = dgvHallBooking.Rows[x].Cells[8].Value.ToString();
                                string[] tti = tt.Split(Convert.ToChar("-"));
                                int ttime = Convert.ToInt32(tti[0]);
                                DateTime ToTime = Convert.ToDateTime(datedd + ttime.ToString() + ":00:00 " + tti[1].ToString());

                                string Remarks = "";
                                if (dgvHallBooking.Rows[x].Cells[9].Value != null)
                                {
                                    Remarks = dgvHallBooking.Rows[x].Cells[9].Value.ToString();
                                }

                                bool result = dbLayer.AddHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Dated, Dated, FromTime, ToTime, Remarks, FName, Orakh, Amount, "", Account, ContactNo, FCardNo.ToString("00000"));
                                if (result)
                                {

                                    rSuccess++;
                                }

                            }

                            tblTransactionsTableAdapter.InsertTransaction(HRD("Hall Booking"), "HBK", Convert.ToInt32(SerialNo), Date, 0, Amount, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking");
                            tblTransactionsTableAdapter.InsertTransaction(Account, "HBK", Convert.ToInt32(SerialNo), Date, Amount, 0, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking");
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

                            int Event = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[0].Value.ToString());

                            for (int y = 1; y <= 4; y++)
                            {
                                if (dgvHallBooking.Rows[x].Cells[y].Value == null)
                                {
                                    dgvHallBooking.Rows[x].Cells[y].Value = "0";
                                }
                            }

                            if (dgvHallBooking.Rows[x].Cells[11].Value == null)
                            {
                                dgvHallBooking.Rows[x].Cells[11].Value = "";
                            }

                            int Hall1 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[1].Value.ToString());
                            int Hall2 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[2].Value.ToString());
                            int Hall3 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[3].Value.ToString());
                            int Hall4 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[4].Value.ToString());

                            DateTime Dated = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[5].Value.ToString());
                            string datedd = Dated.ToString("dd/MM/yyyy") + " ";
                            string ft = dgvHallBooking.Rows[x].Cells[7].Value.ToString();
                            string[] fti = ft.Split(Convert.ToChar("-"));
                            int ftime = Convert.ToInt32(fti[0]);
                            DateTime FromTime = Convert.ToDateTime(datedd + ftime.ToString() + ":00:00 " + fti[1].ToString());

                            string tt = dgvHallBooking.Rows[x].Cells[8].Value.ToString();
                            string[] tti = tt.Split(Convert.ToChar("-"));
                            int ttime = Convert.ToInt32(tti[0]);
                            DateTime ToTime = Convert.ToDateTime(datedd + ttime.ToString() + ":00:00 " + tti[1].ToString());

                           
                            string Remarks = "";
                            if (dgvHallBooking.Rows[x].Cells[9].Value != null)
                            {
                                Remarks = dgvHallBooking.Rows[x].Cells[9].Value.ToString();
                            }

                            bool result = false;


                            bool added = false;

                            if (dgvHallBooking.Rows[x].Cells[11].Value != null && dgvHallBooking.Rows[x].Cells[11].Value != "")
                            {
                                int rID = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[11].Value.ToString());
                                result = dbLayer.UpdateHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Dated, Dated, FromTime, ToTime, Remarks, rID, FName, Orakh, Amount, "", Account, ContactNo, FCardNo.ToString("00000"));
                                added = false;
                            }
                            else
                            {
                                result = dbLayer.AddHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Dated, Dated, FromTime, ToTime, Remarks, FName, Orakh, Amount, "", Account, ContactNo, FCardNo.ToString("00000"));
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
                        string msg = rSuccess.ToString() + " Out Of " + Convert.ToString(dgvHallBooking.RowCount - 1 - rAdded) + " Record(s) Updated Successfully!";

                        if (rAdded != 0)
                        {
                            msg += "\n\n" + rAdded.ToString() + " new Records added!";
                        }
                        tblTransactionsTableAdapter.UpdateTransaction(2, "HBK", Convert.ToInt32(SerialNo), Date, 0, Amount, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking", TransactionID(Convert.ToInt32(SerialNo)));
                        tblTransactionsTableAdapter.UpdateTransaction(Account, "HBK", Convert.ToInt32(SerialNo), Date, Amount, 0, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking", TransactionID(Convert.ToInt32(SerialNo)));
                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //txtSerialNo.ReadOnly = false;
                        //btnReset_Click(sender, e);
                        mode = 0;
                        btnCloseView.Visible = true;
                        btnLoad.Visible = false;
                        btnSave.Enabled = false;
                        btnReset.Enabled = false;
                        btnEdit.Visible = true;
                        btnDelete.Visible = true;

                        this.AcceptButton = btnEdit;

                        dgvHallBooking.ReadOnly = true;
                        dgvHallBooking.AllowUserToDeleteRows = false;
                        btnCloseView_Click(sender, e);
                        dtpDate.Enabled = false;

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
            if (e.ColumnIndex == 6)
            {
                try
                {
                    if (dgvHallBooking.CurrentRow.Cells[5].Value != null)
                    {
                        int i = dgvHallBooking.CurrentRow.Index;
                        string cell = dgvHallBooking.CurrentRow.Cells[5].Value.ToString();
                        DateTime day = Convert.ToDateTime(cell);
                        string Day = day.DayOfWeek.ToString();
                        dgvHallBooking.CurrentRow.Cells[6].Value = Day;
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid Date format..\ni.e dd//MM//YYYY", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (e.ColumnIndex == 0)
            {
                comboBox1.Top = initialTop + ((comboBox1.Height + 1) * e.RowIndex);

                if (dgvHallBooking.ReadOnly == false)
                {
                    comboBox1.BringToFront();

                    comboBox1.Focus();


                    if (dgvHallBooking.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        comboBox1.Text = dgvHallBooking.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }
                }

            }

            currRowIndex = e.RowIndex;
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
            // TODO: This line of code loads data into the 'dataset2.tblHallAcc' table. You can move, or remove it, as needed.
            this.tblHallAccTableAdapter.Fill(this.dataset2.tblHallAcc);
            // TODO: This line of code loads data into the 'dataset2.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataset2.tblEvents);
            // TODO: This line of code loads data into the 'comDataSet.tblAccounts' table. You can move, or remove it, as needed.
            this.tblAccountsTableAdapter.Fill(this.comDataSet.tblAccounts);
            grbSearch.SendToBack();
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
            // TODO: This line of code loads data into the 'comDataSet.tblTransactions' table. You can move, or remove it, as needed.
            this.tblTransactionsTableAdapter.Fill(this.comDataSet.tblTransactions);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblOrakh' table. You can move, or remove it, as needed.
            this.usp_SEL_tblOrakhTableAdapter.Fill(this.comDataSet.usp_SEL_tblOrakh);
            btnReset_Click(sender, e);

            grbSearch.Visible = false;
            txtSerialNo.Focus();

        }

        private void txtSerialNo_Leave(object sender, EventArgs e)
        {
            if (txtSerialNo.Text != "")
            {
                try
                {
                    int serial = Convert.ToInt32(txtSerialNo.Text);
                    txtSerialNo.Text = serial.ToString("00000");

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
            int serialNo = Convert.ToInt32(txtSerialNo.Text);
            txtSerialNo.Text = serialNo.ToString("00000");

            if (checkSerialNo(serialNo))
            {
                //mode = 2;

                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("SELECT SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Dated, Day, FromTime, ToTime, Remarks,ReasonCancel, tblHallBooking.ID,FName,Orakh,Amount,ContactNo,Account,FCardNo FROM tblHallBooking Where SerialNo=" + serialNo.ToString(), Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        txtSerialNo.ReadOnly = true;

                        if (dgvHallBooking.RowCount != 0)
                        {
                            dgvHallBooking.Rows.Clear();
                        }

                        btnLoad.Visible = false;
                        btnCloseView.Visible = true;
                        btnSave.Enabled = false;
                        btnReset.Enabled = false;
                        btnEdit.Visible = true;
                        btnDelete.Visible = true;
                        btnPrint.Visible = true;
                        if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
                            btnEdit.Enabled = true;
                        else
                            btnEdit.Enabled = false;

                        if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                            btnDelete.Enabled = true;
                        else
                            btnDelete.Enabled = false;

                        dgvHallBooking.ReadOnly = true;
                        dgvHallBooking.AllowUserToDeleteRows = false;
                        dgvHallBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        dtpDate.Enabled = false;
                        txtMr.Enabled = false;
                        txtAmount.Enabled = false;
                        txtContactNo.Enabled = false;
                        txtFName.Enabled = false;
                        cmbAccount.Enabled = false;
                        cmbOrakh.Enabled = false;
                        txtFCardNo.Enabled = false;
                        btnGetName.Enabled = false;
                        //int rIndex = 0;

                        while (Reader.Read())
                        {
                            dtpDate.Text = Reader.GetValue(1).ToString();
                            txtMr.Text = Reader.GetValue(2).ToString();
                            txtFName.Text = Reader.GetValue(15).ToString();
                            txtAmount.Text = Convert.ToDecimal(Reader.GetValue(17).ToString()).ToString("0.00");
                            cmbOrakh.Text = Reader.GetValue(16).ToString();
                            txtContactNo.Text = Reader.GetValue(18).ToString();
                            cmbAccount.SelectedValue = Reader.GetValue(19);
                            txtFCardNo.Text = Reader.GetValue(20).ToString();

                            int z = dgvHallBooking.Rows.Add();

                            for (int x = 3; x < Reader.FieldCount - 6; x++)
                            {
                                string value = Reader.GetValue(x).ToString();
                                string vartype = Reader.GetFieldType(x).ToString();


                                if (x == 4 || x == 5 || x == 6 || x == 7)
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
                                if (x == 9)
                                {
                                    dgvHallBooking.Rows[z].Cells[x - 3].Value = Convert.ToDateTime(value).DayOfWeek.ToString();
                                }
                                else if (x == 10 || x == 11)
                                {
                                    int hour = Convert.ToDateTime(value).TimeOfDay.Hours;
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
                                    dgvHallBooking.Rows[z].Cells[x - 3].Value = Time;


                                }
                                else
                                {
                                    if (vartype == "System.Int32")
                                    {
                                        dgvHallBooking.Rows[z].Cells[x - 3].Value = Convert.ToInt32(value);
                                    }
                                    else
                                    {
                                        if (x == 8)
                                        {
                                            dgvHallBooking.Rows[z].Cells[x - 3].Value = Convert.ToDateTime(value).ToShortDateString();
                                        }
                                        else
                                        {
                                            dgvHallBooking.Rows[z].Cells[x - 3].Value = value;
                                        }
                                    }
                                }
                            }

                            comboBox1.SendToBack();

                            //dgvHallBooking.Rows.Add(row);
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

        private void txtSerialNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int serial = Convert.ToInt32(txtSerialNo.Text);

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
            txtSerialNo.ReadOnly = false;
            btnReset_Click(sender, e);
            mode = 0;
            btnCloseView.Visible = false;
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
            btnReset.Enabled = true;
            btnEdit.Visible = false;
            this.AcceptButton = btnSave;
            dgvHallBooking.ReadOnly = false;
            dgvHallBooking.AllowUserToDeleteRows = true;
            dtpDate.Enabled = true;
            txtMr.Enabled = true;
            txtAmount.Enabled = true;
            txtContactNo.Enabled = true;
            txtFName.Enabled = true;
            cmbAccount.Enabled = true;
            cmbOrakh.Enabled = true;
            btnDelete.Visible = false;
            btnPrint.Visible = false;
            lblHeader.Text = Header;
            txtSerialNo.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            mode = 1;
            dgvHallBooking.ReadOnly = false;
            dgvHallBooking.AllowUserToDeleteRows = true;
            btnSave.Enabled = true;
            dtpDate.Enabled = true;
            txtMr.Enabled = true;
            txtAmount.Enabled = true;
            txtContactNo.Enabled = true;
            txtFName.Enabled = true;
            cmbAccount.Enabled = true;
            cmbOrakh.Enabled = true;
            btnDelete.Visible = false;
            btnGetName.Enabled = true;
            txtFCardNo.Enabled = true;
            dgvHallBooking.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            lblHeader.Text = Header + " >> Modifing Booking";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?\n\nThis will remove all records in current booking!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                lblHeader.Text = Header + " >> Deleting Booking";
                if (result == DialogResult.Yes)
                {
                    bool result2 = dbLayer.DeleteHallBookingAll(Convert.ToInt32(txtSerialNo.Text));
                    if (result2)
                    {
                        lblHeader.Text = Header;
                        tblTransactionsTableAdapter.DeleteTransactions("HBK", Convert.ToInt32(txtSerialNo.Text));

                        MessageBox.Show("Successfully deleted!");
                        btnCloseView_Click(sender, e);
                    }
                    else
                        lblHeader.Text = Header;
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(dtpSearchDate.Text);

            Fill_Search();
            if (dataGridView1.Rows.Count != 0)
            {
                grbSearch.BringToFront();
                grbSearch.Visible = true;
                button1.BringToFront();
                lblHeader.Text = Header + " >> Hall Booked on " + Convert.ToDateTime(dtpSearchDate.Text).ToString("dd/MM/yyyy");
            }
            else
                MessageBox.Show("There is no Hall Booking on the date provided", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //int serial =getSerialByDate(Convert.ToDateTime(dtpSearchDate.Text));

            //if (serial != 0)
            //{
            //    btnCloseView_Click(sender,e);

            //    txtSerialNo.Text = serial.ToString("00000");

            //    btnLoad_Click(sender, e);

            //    for (int x = 0; x < dgvHallBooking.RowCount; x++)
            //    {
            //        if (dgvHallBooking.Rows[x].Cells[6].Value != null)
            //        {
            //            string tmpDate = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells[5].Value.ToString()).ToShortDateString();

            //            if (tmpDate == dtpSearchDate.Text)
            //            {
            //                dgvHallBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //                dgvHallBooking.Rows[x].Selected = true;
            //                break;
            //            }
            //        }
            //    }                
            //    AcceptButton = btnCloseView;
            //}

            //else
            //{
            //    MessageBox.Show("No Hall has been booked on the date provided.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSerialNo.Text);
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            con.Open();
            string sql = richTextBox1.Text;
            sql = sql.Replace("@SerialNo", id.ToString());
            SqlCommand cmd = new SqlCommand(sql, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt);
            Reports.Hall_Booking.frmViewer frm = new MCKJ.Reports.Hall_Booking.frmViewer();
            Reports.Hall_Booking.rptHallBooking rpt = new MCKJ.Reports.Hall_Booking.rptHallBooking();

            frm.crystalReportViewer1.ReportSource = rpt;
            rpt.SetDataSource(dt);
            rpt.SetParameterValue("SerialNo", id.ToString("00000"));
            rpt.SetParameterValue(1, From_To(id));
            //rpt.SetParameterValue("SerialNo", id.ToString("00000"), rpt.Subreports[0].Name.ToString());
            //rpt.SetParameterValue(rpt.ParameterFields[1].Name, From_To(id), rpt.Subreports[0].Name.ToString());        


            frm.Show();
            con.Close();
        }

        private void dgvHallBooking_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
                txtAmount.Text = Convert.ToDecimal(txtAmount.Text).ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.SendToBack();
            grbSearch.Hide();
            lblHeader.Text = Header;
        }

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
                        txtMr.Text = reader.GetValue(0).ToString();
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
            if (dgvHallBooking.Rows.Count == 7)
            {
                dgvHallBooking.AllowUserToAddRows = false;
            }
            else
                dgvHallBooking.AllowUserToAddRows = true;
        }
    }
}
    
