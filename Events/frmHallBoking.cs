using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MCKJ.Events;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using MCKJ.Common;
using Community;

namespace MCKJ
{
    public partial class frmHallBoking : Form
    {
        Community.DBLayer dbLayer = new Community.DBLayer();
        
        DbHelper dbHelper = new DbHelper();
        SQLCache sql = null;
        static DataTable dtSearch;
        int mode = 0;
        int currRowIndex = 0;
        int initialTop = 86;
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 7;
        Community.DBLayer DBLayer = new Community.DBLayer();
        string Header = "Hall Booking";
        string message = "";
        string hall = "";
        string messageForEvent = "";
        Boolean IsHallBooked = false;
        //DBLayer dbLayer = new DBLayer();
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

                SqlCommand Command = new SqlCommand("Select Max(SerialNo) From tblHallBooking", Conn);

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
            bool result = false;
            for (int i = 1; i <= 5; i++)
            {
                if (Convert.ToBoolean(Convert.ToInt32(dgvHallBooking.Rows[rowIndex].Cells["Hall" + i.ToString()].Value)))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private bool validateFields()
        {
            bool result = true;

            //Check Header First!

            if (chkTemp.Checked == false)
            {
                if (txtSerialNo.Text == "" || txtMr.Text == "")
                {
                    MessageBox.Show("Please fill in the Required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    result = false;
                }
            }
            if (dgvHallBooking.Rows.Count == 1)
            {
                for (int x = 0; x < dgvHallBooking.Rows.Count; x++)
                {
                    if (dgvHallBooking.Rows[x].Cells["Event"].Value == null || dgvHallBooking.Rows[x].Cells["Date"].Value == null || dgvHallBooking.Rows[x].Cells["Day"].Value == null || dgvHallBooking.Rows[x].Cells["Ftime"].Value == null || dgvHallBooking.Rows[x].Cells["To"].Value == null || !validateHall(x))
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
                    for (int y = 1; y <= 5; y++)
                    {
                        if (dgvHallBooking.Rows[x].Cells[y].Value == null)
                        {
                            dgvHallBooking.Rows[x].Cells[y].Value = "0";
                        }
                    }
                    if (dgvHallBooking.Rows[x].Cells["Event"].Value == null || dgvHallBooking.Rows[x].Cells["Date"].Value == null || dgvHallBooking.Rows[x].Cells["Day"].Value == null || dgvHallBooking.Rows[x].Cells["FTime"].Value == null || dgvHallBooking.Rows[x].Cells["To"].Value == null || !validateHall(x))
                    {
                        MessageBox.Show("Row cannot have empty cells!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        result = false;
                        break;
                    }
                    else
                    {
                        DateTime Dated = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells["Date"].Value);
                        int id = 0;
                        if (dgvHallBooking.Rows[x].Cells["ID"].Value != null)
                        {
                            id = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["ID"].Value);
                        }
                        SqlConnection con = new SqlConnection(dbLayer.CON_string);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT Dated FROM tblHallBooking WHERE Dated = '" + Dated.ToString("yyyy-MM-dd") + "' AND Id <> " + id,con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                                                
                        if (rdr.HasRows)
                        {
                            //MessageBox.Show("Event already booked on selected date on Row " + x + 1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //result = false;
                            //break;
                        }

                    }
                }
            }

            if (!CheckFamilyCard(txtFCardNo.Text))
            {
                result = false;
            }

            return result;
        }

        private bool CheckFamilyCard(string fCard)
        {

            if (chkNM.Checked)
            {
                return true;
            }

            if (!string.IsNullOrEmpty(fCard.Trim()))
            {
                SqlConnection con = new SqlConnection(dbLayer.CON_string);
                string query = "SELECT top 1 * from tblFamily where FcardNo = '" + fCard + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr == null || rdr.HasRows == false)
                {
                    MessageBox.Show("Invalid Family Card Number");
                    con.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Family Card Number");
                return false;
            }
            return true;
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

        private void Fill_Grid()
        {
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            string query = richTextBox3.Text;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
            dtSearch = new DataTable();
            sqlDataAdap.Fill(dtSearch);
            dgvHallBook.DataSource = dtSearch;

        }
        private void Fill_Search()
        {

            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            string query = richTextBox2.Text;
            query = query.Replace("@From", dtpSearchDate.Value.ToString("yyyy-MM-dd"));
            query = query.Replace("@To", dtpSearchDateTo.Value.ToString("yyyy-MM-dd"));
            if (rbtAll.Checked)
            {
                query = query.Replace("<AR>", "OR");
            }
            else
            {
                query = query.Replace("<AR>", "AND");
            }
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

                dataGridView1.Rows[z].Cells["Hall_1"].Value
                            = Convert.ToBoolean(Reader["Hall1"]);

                dataGridView1.Rows[z].Cells["Hall_2"].Value
                                = Convert.ToBoolean(Reader["Hall2"]);

                dataGridView1.Rows[z].Cells["Hall_3"].Value
                                = Convert.ToBoolean(Reader["Hall3"]);

                dataGridView1.Rows[z].Cells["Hall_4"].Value
                                = Convert.ToBoolean(Reader["Hall4"]);

                dataGridView1.Rows[z].Cells["Hall_5"].Value
                                = Convert.ToBoolean(Reader["Hall5"]);

                dataGridView1.Rows[z].Cells["From"].Value
                         = Convert.ToDateTime(Reader["FromTime"]).ToString("hh:mmtt");
                dataGridView1.Rows[z].Cells["To_"].Value
                    = Convert.ToDateTime(Reader["ToTime"]).ToString("hh:mmtt");

                dataGridView1.Rows[z].Cells["SerialNo"].Value = Convert.ToInt32(Reader["SerialNo"]).ToString("00000");

                dataGridView1.Rows[z].Cells["Dated"].Value = Convert.ToDateTime(Reader["Date"]).ToShortDateString();
                dataGridView1.Rows[z].Cells["EventDay"].Value = Convert.ToString(Reader["EventDay"]);


                if (CheckIfHallBooked(z))
                {
                    dataGridView1.Rows[z].Cells["BookedBy"].Value = Convert.ToString(Reader["BookedBy"]);
                    dataGridView1.Rows[z].Cells["Events"].Value = Convert.ToString(Reader["Events"]);
                }
                //else
                //{
                //    try
                //    {
                //        ArrayList Params = new ArrayList();
                //        SQLCache sql = null;
                //        string strQuery = string.Empty;

                //        Params.Add(Convert.ToInt32(Reader["SerialNo"]).ToString("00000"));

                //        sql = new SQLCache(Params);
                //        query = sql.GetSQL("Update_HallBooking");

                //        DbHelper dbHelper = new DbHelper();
                //        int status = dbHelper.ExecuteNonQuery(strQuery);
                //    }
                //    catch (Exception ex)
                //    {
                //    }
                //}

            }
        }

        private bool CheckIfHallBooked(int z)
        {
            if (Convert.ToBoolean(dataGridView1.Rows[z].Cells["Hall_1"].Value) == true)
            {
                return true;
            }
            else if (Convert.ToBoolean(dataGridView1.Rows[z].Cells["Hall_2"].Value) == true)
            {
                return true;
            }
            else if (Convert.ToBoolean(dataGridView1.Rows[z].Cells["Hall_3"].Value) == true)
            {
                return true;
            }
            else if (Convert.ToBoolean(dataGridView1.Rows[z].Cells["Hall_4"].Value) == true)
            {
                return true;
            }
            else if (Convert.ToBoolean(dataGridView1.Rows[z].Cells["Hall_5"].Value) == true)
            {
                return true;
            }
            return false;
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
            SqlCommand cmd = new SqlCommand("Select ID from tblTransactions WHERE Voucher = 'HBK' AND DocumentNo = " + serialno, con);

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
                    dgvHallBooking.AllowUserToAddRows = true;
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
        private void CheckHallBooking()
        {
            //*******************Check for hall booking*******************
            for (int x = 0; x < dgvHallBooking.Rows.Count - 1; x++)
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();
                string query = rtbCheckHallForBooking.Text;
                query = query.Replace("@dated", DateTime.Parse(dgvHallBooking.Rows[x].Cells["Date"].Value.ToString()).ToString("yyyy-MM-dd"));
                //query = query.Replace("@fromTime", dtpSearchDate.Value.ToString("yyyy-MM-dd"));
                //query = query.Replace("@toTime", dtpSearchDateTo.Value.ToString("yyyy-MM-dd"));
                //query = query.Replace("@fromTime", dgvHallBooking.CurrentRow.Cells["FTime"].Value.ToString());
                query = query.Replace("@fromTime", dgvHallBooking.Rows[x].Cells["FTime"].Value.ToString());
                //query = query.Replace("@toTime", dgvHallBooking.CurrentRow.Cells["To"].Value.ToString()) + "'";
                //query+= " and";
                //query = query.Replace("@toTime", dgvHallBooking.CurrentRow.Cells["To"].Value.ToString("hh-tt"));

                //check and then make query for hall booking
                if (dgvHallBooking.Rows[x].Cells["Hall1"].Value == "1" || dgvHallBooking.Rows[x].Cells["Hall2"].Value == "1" || dgvHallBooking.Rows[x].Cells["Hall3"].Value == "1" || dgvHallBooking.Rows[x].Cells["Hall4"].Value == "1" || dgvHallBooking.Rows[x].Cells["Hall5"].Value == "1")
                {
                    query += " and (";
                    if (dgvHallBooking.Rows[x].Cells["Hall1"].Value != null && dgvHallBooking.Rows[x].Cells["Hall1"].Value != "0")
                    {
                        query += " ISNULL(hall1,0)=1";
                        //if (dgvHallBooking.CurrentRow.Cells["Hall1"].Value.ToString() != "0")
                        //{
                        //    //query = query.Replace("@hall1", dgvHallBooking.CurrentRow.Cells["Hall1"].Value.ToString());
                        //    query += " (ISNULL(hall1,0)=1";
                        //}
                        //else
                        //    query = query.Replace("@hall1", "0");
                    }
                    //else
                    //    query = query.Replace("@hall1", "0");
                    if (dgvHallBooking.Rows[x].Cells["Hall2"].Value != null && dgvHallBooking.Rows[x].Cells["Hall2"].Value != "0")
                        //query = query.Replace("@hall2", dgvHallBooking.CurrentRow.Cells["Hall2"].Value.ToString());
                        if (query.Substring(query.Length - 1, 1) == "(")
                            query += "ISNULL(hall2,0)=1";
                        else
                            query += " or ISNULL(hall2,0)=1";
                    //else
                    //    query = query.Replace("@hall2", "0");
                    if (dgvHallBooking.Rows[x].Cells["Hall3"].Value != null && dgvHallBooking.Rows[x].Cells["Hall3"].Value != "0")
                        if (query.Substring(query.Length - 1, 1) == "(")
                            query += "ISNULL(hall3,0)=1";
                        else
                            query += " or ISNULL(hall3,0)=1";
                    //query = query.Replace("@hall3", dgvHallBooking.CurrentRow.Cells["Hall3"].Value.ToString());
                    //else
                    //    query = query.Replace("@hall3", "0");
                    if (dgvHallBooking.Rows[x].Cells["Hall4"].Value != null && dgvHallBooking.Rows[x].Cells["Hall4"].Value != "0")
                        if (query.Substring(query.Length - 1, 1) == "(")
                            query += "ISNULL(hall4,0)=1";
                        else
                            query += "or ISNULL(hall4,0)=1";
                    //query = query.Replace("@hall4", dgvHallBooking.CurrentRow.Cells["Hall4"].Value.ToString());
                    //else
                    //    query = query.Replace("@hall4", "0");
                    if (dgvHallBooking.Rows[x].Cells["Hall5"].Value != null && dgvHallBooking.Rows[x].Cells["Hall5"].Value != "0")
                        if (query.Substring(query.Length - 1, 1) == "(")
                            query += "ISNULL(hall5,0)=1";
                        else
                            query += " or ISNULL(hall5,0)=1";
                    //query = query.Replace("@hall5", dgvHallBooking.CurrentRow.Cells["Hall5"].Value.ToString());
                    //else
                    //    query = query.Replace("@hall5", "0");
                    query += ")";
                }
                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(dt);
                //check for hall and then generate message for hall booking 
                if (dt.Rows.Count > 0)
                {
                    for (int a = 0; a < dt.Rows.Count; a++)
                    {
                        //dt.DefaultView.RowFilter = "dated='"+DateTime.Parse(dgvHallBooking.Rows[x].Cells[6].Value.ToString()).ToString("yyyy-MM-dd")+"' and (Hall1=1 or Hall2=1 or Hall3=1 or Hall4=1 or Hall5=1)";
                        //message = dt.Rows[0]["Dated"].ToString();
                        if (dgvHallBooking.Rows[x].Cells["Hall1"].Value.ToString() == "1" && dt.Rows[a]["Hall1"].ToString() == "True")
                            hall = "1";
                        //MessageBox.Show("Hall1 is already booked for date "+DateTime.Parse(message).ToString("dd-MMM-yyyy"), "Hall is booked");
                        if (dgvHallBooking.Rows[x].Cells["Hall2"].Value.ToString() == "1" && dt.Rows[a]["Hall2"].ToString() == "True")
                            hall += ",2";
                        //MessageBox.Show("Hall2 is already booked for date " + DateTime.Parse(message).ToString("dd-MMM-yyyy"), "Hall is booked");
                        if (dgvHallBooking.Rows[x].Cells["Hall3"].Value.ToString() == "1" && dt.Rows[a]["Hall3"].ToString() == "True")
                            hall += ",3";
                        //MessageBox.Show("Hall3 is already booked for date " + DateTime.Parse(message).ToString("dd-MMM-yyyy"), "Hall is booked");
                        if (dgvHallBooking.Rows[x].Cells["Hall4"].Value.ToString() == "1" && dt.Rows[a]["Hall4"].ToString() == "True")
                            hall += ",4";
                        //MessageBox.Show("Hall4 is already booked for date " + DateTime.Parse(message).ToString("dd-MMM-yyyy"), "Hall is booked");
                        if (dgvHallBooking.Rows[x].Cells["Hall5"].Value.ToString() == "1" && dt.Rows[a]["Hall5"].ToString() == "True")
                            hall += ",5";
                        //MessageBox.Show("Hall5 is already booked for date " + DateTime.Parse(message).ToString("dd-MMM-yyyy"), "Hall is booked");
                        if (hall.Substring(0, 1) == ",")
                            hall = hall.Remove(0, 1);
                        //return;
                        
                        //If selected event is Engagement and hall is also booked for Engagement
                        //If selected event is Nikah and hall is also booked for Niakh
                        if ((dgvHallBooking.Rows[x].Cells[0].Value.ToString() == "5" && dt.Rows[a]["Event"].ToString() == "5") || (dgvHallBooking.Rows[x].Cells[0].Value.ToString() == "9" && dt.Rows[a]["Event"].ToString() == "9"))
                        {
                            if (dt.Rows[a]["Event"].ToString() == "5")
                            {
                                messageForEvent += "Hall " + hall + " is already booked by " + dt.Rows[a]["Mr"].ToString() + " " + dt.Rows[a]["FName"].ToString() + " " + dt.Rows[a]["Orakh"] + " for ENGAGEMENT on date and time:" + DateTime.Parse(dt.Rows[0]["Dated"].ToString()).ToString("dd-MMM-yyyy") + "\n";
                                hall = "";
                            }
                            else if (dt.Rows[a]["Event"].ToString() == "9")
                            {
                                messageForEvent += "Hall " + hall + " is already booked by " + dt.Rows[a]["Mr"].ToString() + " " + dt.Rows[a]["FName"].ToString() + " " + dt.Rows[a]["Orakh"] + " for NIKAH on date and time:" + DateTime.Parse(dt.Rows[0]["Dated"].ToString()).ToString("dd-MMM-yyyy") + "\n";
                                hall = "";

                            }
                        }
                        else
                        {
                            message += "Hall " + hall + " is already booked for date " + DateTime.Parse(dt.Rows[0]["Dated"].ToString()).ToString("dd-MMM-yyyy") + "\n";
                            hall = "";
                        }

                    }
                }
                else
                {
                    //bool result = false;
                    ////bool result = dbLayer.AddHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Hall5, Dated, Dated, FromTime, ToTime, Remarks, FName, Orakh, Amount, "", Account, ContactNo, FCardNo.ToString("00000"), Temp);
                    //if (result)
                    //{
                    //    rSuccess++;
                    //}
                }
                //int i = dgvHallBooking.CurrentRow.Index;
                //string cell = dgvHallBooking.CurrentRow.Cells["Date"].Value.ToString();
                //DateTime day = Convert.ToDateTime(cell);
                //string Day = day.DayOfWeek.ToString();
                //dgvHallBooking.CurrentRow.Cells["Day"].Value = Day;

                //***************************************************************************
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            message = "";
            hall = "";
            try
            {
                if (validateFields())
                {
                    button2_Click(sender, e);
                    int SerialNo = 0;
                    if (mode == 0)
                    {
                        SerialNo = getNextSerialNo();
                    }
                    else
                    {
                        SerialNo = Convert.ToInt32(txtSerialNo.Text);
                    }
                    //int SerialNo = getNextSerialNo();//
                    string Mr = txtMr.Text;
                    DateTime Date = Convert.ToDateTime(dtpDate.Text);
                    string FName = txtFName.Text;
                    string Orakh = cmbOrakh.Text;
                    decimal Amount = Convert.ToDecimal(txtAmount.Text);
                    int Account = 0;
                    if (cmbAccount.SelectedValue != null)
                    {
                        Int32.TryParse(cmbAccount.SelectedValue.ToString(), out Account);
                    }
                    string ContactNo = txtContactNo.Text;
                    int FCardNo;
                    if (!(Int32.TryParse(txtFCardNo.Text, out FCardNo)))
                    {
                        FCardNo = 0;
                    }
                    bool Temp = false;
                    if (chkTemp.Checked)
                        Temp = true;
                    else
                        Temp = false;


                    int rSuccess = 0;
                    int rAdded = 0;

                    if (mode == 0)
                    {
                        if (!checkSerialNo(SerialNo))
                        {
                            int countt = 0;

                            if (dgvHallBooking.Rows.Count == 6)
                            {
                                countt = 6;
                            }
                            else
                                countt = dgvHallBooking.Rows.Count - 1;
                            CheckHallBooking();
                            //if hall is already booked
                            if (message != "")
                            {
                                MessageBox.Show(message, "Hall is booked");
                                message = "";
                                messageForEvent = "";
                                return;
                            }
                            //if hall is already booked for engagement or nikah
                            if (messageForEvent != "")
                            {
                                if (MessageBox.Show(messageForEvent, "Engagement/Nikah", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                                {
                                    message = "";
                                    messageForEvent = "";
                                    return;
                                }
                            }
                            

                            //save grid data to database row by row
                            for (int x = 0; x < countt; x++)
                            {
                                int Event = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Event"].Value.ToString());

                                for (int y = 1; y <= 5; y++)
                                {
                                    if (dgvHallBooking.Rows[x].Cells[y].Value == null)
                                    {
                                        dgvHallBooking.Rows[x].Cells[y].Value = "0";
                                    }
                                }

                                if (dgvHallBooking.Rows[x].Cells["Remarks"].Value == null)
                                {
                                    dgvHallBooking.Rows[x].Cells["Remarks"].Value = "";
                                }

                                int Hall1 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall1"].Value.ToString());
                                int Hall2 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall2"].Value.ToString());
                                int Hall3 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall3"].Value.ToString());
                                int Hall4 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall4"].Value.ToString());
                                int Hall5 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall5"].Value.ToString());

                                DateTime Dated = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells["Date"].Value.ToString());
                                string datedd = Dated.ToString("dd/MM/yyyy") + " ";
                                string ft = dgvHallBooking.Rows[x].Cells["FTime"].Value.ToString();
                                string[] fti = ft.Split(Convert.ToChar(":"));
                                int ftime = Convert.ToInt32(fti[0]);
                                DateTime FromTime = Convert.ToDateTime(datedd + ftime.ToString() + ":00:" + fti[1].ToString());

                                string tt = dgvHallBooking.Rows[x].Cells["To"].Value.ToString();
                                string[] tti = tt.Split(Convert.ToChar(":"));
                                int ttime = Convert.ToInt32(tti[0]);
                                DateTime ToTime = Convert.ToDateTime(datedd + ttime.ToString() + ":00:" + tti[1].ToString());

                                string Remarks = "";
                                if (dgvHallBooking.Rows[x].Cells["Remarks"].Value != null)
                                {
                                    Remarks = dgvHallBooking.Rows[x].Cells["Remarks"].Value.ToString();
                                }

                                /*****************Check Hall Booking**************
                                 **************************************************/

                                //bool result = false;
                                bool result = dbLayer.AddHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Hall5, Dated, Dated, FromTime, ToTime, Remarks, FName, Orakh, Amount, "", Account, ContactNo, FCardNo.ToString("00000"), Temp,DBLayer.GetUserID());
                                if (result)
                                {
                                    rSuccess++;
                                }

                            }
                            
                            //else
                            //{
                                tblTransactionsTableAdapter.InsertTransaction(HRD("Hall Booking"), "HBK", Convert.ToInt32(SerialNo), Date, 0, Amount, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking");
                                tblTransactionsTableAdapter.InsertTransaction(Account, "HBK", Convert.ToInt32(SerialNo), Date, Amount, 0, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking");
                                MessageBox.Show(rSuccess.ToString() + " Out Of " + Convert.ToString(dgvHallBooking.RowCount - 1) + " Row(s) Added Successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (MessageBox.Show("Do you want to Print?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    btnPrint_Click(sender, e);
                                }
                                btnReset_Click(sender, e);
                            //}
                        }
                        else
                        {
                            MessageBox.Show("That serial no already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (mode == 1)
                    {
                        int countt = 0;

                        if (dgvHallBooking.Rows.Count == 6)
                        {
                            countt = 6;
                        }
                        else if (dgvHallBooking.Rows.Count == 1)
                            countt = 1;
                        else
                            countt = dgvHallBooking.Rows.Count;
                        for (int x = 0; x < countt; x++)
                        {

                            int Event = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Event"].Value.ToString());

                            for (int y = 1; y <= 5; y++)
                            {
                                if (dgvHallBooking.Rows[x].Cells[y].Value == null)
                                {
                                    dgvHallBooking.Rows[x].Cells[y].Value = "0";
                                }
                            }

                            if (dgvHallBooking.Rows[x].Cells["ID"].Value == null)
                            {
                                dgvHallBooking.Rows[x].Cells["ID"].Value = "";
                            }

                            int Hall1 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall1"].Value);
                            int Hall2 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall2"].Value);
                            int Hall3 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall3"].Value);
                            int Hall4 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall4"].Value);
                            int Hall5 = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall5"].Value);

                            DateTime Dated = Convert.ToDateTime(dgvHallBooking.Rows[x].Cells["Date"].Value.ToString());
                            string datedd = Dated.ToString("dd/MM/yyyy") + " ";
                            string ft = dgvHallBooking.Rows[x].Cells["Ftime"].Value.ToString();
                            string[] fti = ft.Split(Convert.ToChar(":"));
                            int ftime = Convert.ToInt32(fti[0]);
                            DateTime FromTime = Convert.ToDateTime(datedd + ftime.ToString() + ":00:" + fti[1].ToString());

                            string tt = dgvHallBooking.Rows[x].Cells["To"].Value.ToString();
                            string[] tti = tt.Split(Convert.ToChar(":"));
                            int ttime = Convert.ToInt32(tti[0]);
                            DateTime ToTime = Convert.ToDateTime(datedd + ttime.ToString() + ":00:" + tti[1].ToString());


                            string Remarks = "";
                            if (dgvHallBooking.Rows[x].Cells["Remarks"].Value != null)
                            {
                                Remarks = dgvHallBooking.Rows[x].Cells["Remarks"].Value.ToString();
                            }

                            bool result = false;


                            bool added = false;

                            if (dgvHallBooking.Rows[x].Cells["ID"].Value != null && dgvHallBooking.Rows[x].Cells["ID"].Value != "")
                            {
                                int rID = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["ID"].Value.ToString());
                                result = dbLayer.UpdateHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Hall5, Dated, Dated, FromTime, ToTime, Remarks, rID, FName, Orakh, Amount, "", Account, ContactNo, FCardNo.ToString("00000"), Temp,DBLayer.GetUserID());
                                added = false;
                            }
                            else
                            {
                                result = dbLayer.AddHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Hall5, Dated, Dated, FromTime, ToTime, Remarks, FName, Orakh, Amount, "", Account, ContactNo, FCardNo.ToString("00000"), Temp,DBLayer.GetUserID());
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
                        tblTransactionsTableAdapter.UpdateTransaction(58, "HBK", Convert.ToInt32(SerialNo), Date, 0, Amount, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking", TransactionID(Convert.ToInt32(SerialNo)));
                        tblTransactionsTableAdapter.UpdateTransaction(Account, "HBK", Convert.ToInt32(SerialNo), Date, Amount, 0, Mr + " " + FName + " " + Orakh + " ", "", "Hall Booking", TransactionID(Convert.ToInt32(SerialNo))+1);
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
                    if (dgvHallBooking.CurrentRow.Cells["Date"].Value != null)
                    {
                        int i = dgvHallBooking.CurrentRow.Index;
                        string cell = dgvHallBooking.CurrentRow.Cells["Date"].Value.ToString();
                        DateTime day = Convert.ToDateTime(cell);
                        string Day = day.DayOfWeek.ToString();
                        dgvHallBooking.CurrentRow.Cells["Day"].Value = Day;
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


                    if (dgvHallBooking.Rows[e.RowIndex].Cells["Event"].Value != null)
                    {
                        comboBox1.Text = dgvHallBooking.Rows[e.RowIndex].Cells["Event"].Value.ToString();
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
                        dgvHallBooking.Rows[currRowIndex].Cells["Event"].Value = comboBox1.Text;
                    }

                    dgvHallBooking.CurrentCell = dgvHallBooking.Rows[currRowIndex].Cells["Hall1"];

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

            if (dgvHallBooking.Rows[currRowIndex].Cells["Event"].Value != null)
            {
                if (dgvHallBooking.Rows[currRowIndex].Cells["Event"].Value.ToString() != "")
                {
                    comboBox1.Text = dgvHallBooking.Rows[currRowIndex].Cells["Event"].Value.ToString();
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
                        dgvHallBooking.Rows[currRowIndex].Cells["Event"].Value = comboBox1.Items[iIndex].ToString();
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
            // TODO: This line of code loads data into the 'communityDataSet.usp_GetHallBooking' table. You can move, or remove it, as needed.
            //this.usp_GetHallBookingTableAdapter.Fill(this.communityDataSet.usp_GetHallBooking);
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
            //DataTable dt = new DataTable();
            //ArrayList Params = new ArrayList();
            //sql = new SQLCache(Params);
            //dt = dbHelper.ExecuteDataTable(sql.GetSQL("GetHallBooking"));
            //dgvHallBooking.DataSource = dt;
            Fill_Grid();
            grbSearch.Visible = false;
            txtSerialNo.Focus();
            //Fill Search Criteria combo box
            foreach (DataColumn dc in dtSearch.Columns)
            {
                cmbCriteria.Items.Add(dc.ToString());
            }


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
        MCKJ.ComDataSetTableAdapters.usp_SEL_CancelledEventsTableAdapter objCancellationAdptr = new MCKJ.ComDataSetTableAdapters.usp_SEL_CancelledEventsTableAdapter();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            int serialNo = Convert.ToInt32(txtSerialNo.Text);
            txtSerialNo.Text = serialNo.ToString("00000");
            dgvHallBooking.AllowUserToAddRows = false;
            if (checkSerialNo(serialNo))
            {
                //mode = 2;

                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("SELECT SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4,Hall5, Dated, Day, FromTime, ToTime, Remarks,ReasonCancel, tblHallBooking.ID,FName,Orakh,Amount,ContactNo,Account,FCardNo,Temp FROM tblHallBooking Where SerialNo=" + serialNo.ToString(), Conn);

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
                        btnCancelEvent.Visible = true;
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

                        MCKJ.ComDataSet.usp_SEL_CancelledEventsDataTable dtCancelled = objCancellationAdptr.GetData(serialNo);
                        DataView dvCancelled = dtCancelled.DefaultView;
                        while (Reader.Read())
                        {
                            dtpDate.Text = Reader["Date"].ToString();
                            txtMr.Text = Reader["Mr"].ToString();
                            txtFName.Text = Reader["FName"].ToString();
                            txtAmount.Text = Convert.ToDecimal(Reader["Amount"].ToString()).ToString("F");
                            cmbOrakh.Text = Reader["Orakh"].ToString();
                            txtContactNo.Text = Reader["ContactNo"].ToString();
                            cmbAccount.SelectedValue = Reader["Account"];
                            txtFCardNo.Text = Reader["FCardNo"].ToString();
                            if (Convert.ToBoolean(Reader["Temp"]) == true)
                                chkTemp.Checked = true;
                            else
                                chkTemp.Checked = false;

                            int z = dgvHallBooking.Rows.Add();
                            for (int i = 1; i <= 5; i++)
                            {
                                string hallName = "Hall" + i.ToString();
                                dvCancelled.RowFilter = "HallNo = '" + hallName + "' AND EventId=" + Convert.ToString(Reader["ID"]);
                                if (dvCancelled.Count > 0)
                                {
                                    dgvHallBooking.Rows[z].Cells[hallName].Style.BackColor = Color.Pink;
                                }
                                dvCancelled.RowFilter = "";
                            }



                            dgvHallBooking.Rows[z].Cells["Day"].Value =
                                Convert.ToDateTime(Reader["Day"].ToString()).DayOfWeek.ToString();

                            dgvHallBooking.Rows[z].Cells["Ftime"].Value
                                     = Convert.ToDateTime(Reader["FromTime"]).ToString("hh:mmtt");
                            dgvHallBooking.Rows[z].Cells["To"].Value
                                = Convert.ToDateTime(Reader["ToTime"]).ToString("hh:mmtt");


                            dgvHallBooking.Rows[z].Cells["ID"].Value = Convert.ToInt32(Reader["ID"]);
                            dgvHallBooking.Rows[z].Cells["Event"].Value = Convert.ToInt32(Reader["Event"]);
                            dgvHallBooking.Rows[z].Cells["Date"].Value
                                        = Convert.ToDateTime(Reader["Dated"]).ToShortDateString();

                            dgvHallBooking.Rows[z].Cells["Hall1"].Value
                                = Convert.ToBoolean(Reader["Hall1"]);

                            dgvHallBooking.Rows[z].Cells["Hall2"].Value
                                            = Convert.ToBoolean(Reader["Hall2"]);

                            dgvHallBooking.Rows[z].Cells["Hall3"].Value
                                            = Convert.ToBoolean(Reader["Hall3"]);

                            dgvHallBooking.Rows[z].Cells["Hall4"].Value
                                            = Convert.ToBoolean(Reader["Hall4"]);

                            dgvHallBooking.Rows[z].Cells["Hall5"].Value
                                            = Convert.ToBoolean(Reader["Hall5"]);

                        }

                    }

                    comboBox1.SendToBack();

                    //dgvHallBooking.Rows.Add(row);

                    Reader.Close();
                    dgvHallBooking.Rows[dgvHallBooking.Rows.Count - 1].Cells["Event"].Selected = true;
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
            txtFCardNo.Enabled = true;
            btnGetName.Enabled = true;
            btnDelete.Visible = false;
            btnPrint.Visible = false;
            lblHeader.Text = Header;
            txtFCardNo.Text = "";
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
                if (e.Row.Cells["ID"].Value != null && mode == 1)
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
                            bool result2 = dbLayer.DeleteHallBooking(Convert.ToInt32(e.Row.Cells["ID"].Value.ToString()));
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
            MCKJ.ComDataSet.usp_SEL_CancelledEventsDataTable dtCancelled = objCancellationAdptr.GetHallCancelledHistoryByDate(Convert.ToDateTime(dtpSearchDate.Text));

            if (dtCancelled.Rows.Count > 0)
            {
                CancelledEventHistory objCanclledEvents = new CancelledEventHistory();
                objCanclledEvents.CancelledEvents = dtCancelled;
                objCanclledEvents.Show();
            }
            Fill_Search();
            if (dataGridView1.Rows.Count != 0)
            {
                grbSearch.BringToFront();
                grbSearch.Visible = true;
                button1.BringToFront();
                lblHeader.Text = Header + " >> Hall Booked on " + Convert.ToDateTime(dtpSearchDate.Text).ToString("dd/MM/yyyy");


            }
            else
                MessageBox.Show("There is no Hall Available for Booking on the date provided", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //From Time
            if (e.ColumnIndex == 8)
            {
                try
                {
                    if (dgvHallBooking.CurrentRow.Cells["FTime"].Value != null)
                    {
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid Date format..\ni.e dd//MM//YYYY", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            


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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(dbLayer.CON_string);
                SqlCommand cmd = new SqlCommand("Select H1,H2,H3,H4,H5 From tblHallAmt", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                decimal H1 = 0;
                decimal H2 = 0;
                decimal H3 = 0;
                decimal H4 = 0;
                decimal H5 = 0;
                decimal c1 = 0;
                decimal c2 = 0;
                decimal c3 = 0;
                decimal c4 = 0;
                decimal c5 = 0;
                decimal totalamt = 0;
                if (reader.HasRows)
                {
                    reader.Read();
                    H1 = Convert.ToDecimal(reader["H1"]);
                    H2 = Convert.ToDecimal(reader["H2"]);
                    H3 = Convert.ToDecimal(reader["H3"]);
                    H4 = Convert.ToDecimal(reader["H4"]);
                    H5 = Convert.ToDecimal(reader["H5"]);
                }
                int countt = 0;

                if (dgvHallBooking.Rows.Count == 6)
                {
                    countt = 6;
                }
                //else if (dgvHallBooking.Rows.Count == 1)
                //    countt = 1;
                else
                    countt = dgvHallBooking.Rows.Count - 1;

                for (int x = 0; x <= countt; x++)
                {
                    for (int y = 1; y <= 5; y++)
                    {
                        if (dgvHallBooking.Rows[x].Cells[y].Value == null)
                        {
                            dgvHallBooking.Rows[x].Cells[y].Value = "0";
                        }
                    }

                    if (Convert.ToString(dgvHallBooking.Rows[x].Cells["Event"].FormattedValue) == "Rukhsati O/C")
                    {
                        if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall1"].Value) == 1)
                        {
                            totalamt = totalamt + 5000;
                        }
                        else if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall2"].Value) == 1)
                        {
                            totalamt = totalamt + 5000;
                        }
                        else if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall3"].Value) == 1)
                        {
                            totalamt = totalamt + 5000;
                        }
                        else if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall4"].Value) == 1)
                        {
                            totalamt = totalamt + 5000;
                        }
                        else if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall5"].Value) == 1)
                        {
                            totalamt = totalamt + 5000;
                        }
                    }


                    if (Convert.ToString(dgvHallBooking.Rows[x].Cells["Event"].FormattedValue) != "Rukhsati" && 
                        Convert.ToString(dgvHallBooking.Rows[x].Cells["Event"].FormattedValue) != "Rukhsati O/C" &&
                        Convert.ToString(dgvHallBooking.Rows[x].Cells["Event"].FormattedValue) != "Nikah")
                    {
                        if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall1"].Value) == 1)
                        {
                            c1 += 1;
                        }
                        if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall2"].Value) == 1)
                        {
                            c2 += 1;
                        }
                        if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall3"].Value) == 1)
                        {
                            c3 += 1;
                        }
                        if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall4"].Value) == 1)
                        {
                            c4 += 1;
                        }
                        if (Convert.ToInt32(dgvHallBooking.Rows[x].Cells["Hall5"].Value) == 1)
                        {
                            c5 += 1;
                        }
                    }

                }
                totalamt += c1 * H1 + c2 * H2 + c3 * H3 + c4 * H4 + c5 * H5;

                txtAmount.Text = totalamt.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvHallBooking.CurrentRow;
                row.Cells["Date"].Value = dtpDefaultEventDate.Value.ToString("dd/MM/yyyy");
                row.Cells["Day"].Value = dtpDefaultEventDate.Value.DayOfWeek;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Events.frmEventCancellation frmCancel = new Events.frmEventCancellation();
                frmCancel.SelectedEvent = dgvHallBooking.CurrentRow;
                frmCancel.BookingId = Convert.ToInt32(txtSerialNo.Text);
                frmCancel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrintRpt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();

                ReportDocument cryRpt = new ReportDocument();
                //cryRpt.Load("E:\\MCKJ\\SourceCode-Hall5Updated\\Mckj Software - SourceCode\\KCommunity\\Reports\\Hall Booking\\rptHallBookingInfo.rpt");
                //cryRpt.Load(Application.StartupPath + "rptHallBookingInfo.rpt");
                //cryRpt.SetParameterValue("StartDate", dtpSearchDate.Text);
                //cryRpt.SetParameterValue("EndDate", dtpSearchDateTo.Text);

                Reports.Hall_Booking.frmViewer frm = new MCKJ.Reports.Hall_Booking.frmViewer();
                Reports.Hall_Booking.rptHallBookingInfo rpt = new MCKJ.Reports.Hall_Booking.rptHallBookingInfo();
                rpt.SetDatabaseLogon("sa", "sql_pwd_SA", "MCKJ-SERVER", "Community");

                frm.crystalReportViewer1.ReportSource = rpt;
                rpt.SetParameterValue("StartDate", dtpSearchDate.Text);
                rpt.SetParameterValue("EndDate", dtpSearchDateTo.Text);
                frm.Refresh();

                frm.Show();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvHallBook.Visible = false;
            gbSearch.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dgvHallBook.Visible = true;
            gbSearch.Visible = true;
            btnCloseView_Click(sender, e);
        }

        private void btnSearchCriteria_Click(object sender, EventArgs e)
        {
            //SerialNo is selected in cmbCriteria
            if (cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[0].ToString())
            {
                if (txtSearch.Text == "")
                    MessageBox.Show("Please enter criteria of search", "Criteria cannot be blank");
                else
                    dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + "=" + txtSearch.Text;
            }
            //Date is selected in cmbCriteria
            else if (cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[3].ToString())
            {
                dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + "='" + DateTime.Parse(txtSearch.Text) + "'";
            }
            //Date is selected in cmbCriteria
            else if (cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[5].ToString() || cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[6].ToString() || cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[7].ToString() || cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[8].ToString() || cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[9].ToString())
            {
                dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + "=" + txtSearch.Text;
            }
            else
            {
                dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";
                dgvHallBook.DataSource = dtSearch.DefaultView;
            }
        }
    }
}

