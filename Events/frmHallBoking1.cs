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
    public partial class frmHallBoking1 : Form
    {
        Community.DBLayer dbLayer = new Community.DBLayer();

        int mode = 0;
        int currRowIndex = 0;
        int initialTop = 86;

        #region Functions   
     
            private int getNextSerialNo()
            {
                int next = 1;

                SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                try
                {
                    Conn.Open();

                    SqlCommand Command = new SqlCommand("Select SerialNo From tblHallBooking Order By ID DESC",Conn);

                    SqlDataReader Reader = Command.ExecuteReader();

                    if(Reader.HasRows)
                    {
                        Reader.Read();

                        next = Convert.ToInt32(Reader.GetValue(0).ToString())+1;
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
            
            private bool checkSerialNo(int SerialNo)
            {            
                if(SerialNo == 0)
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

            private bool validateHall(int rowIndex)
            {

                bool result = true;

                if(dgvHallBooking.Rows[rowIndex].Cells[1].Value == "1")
                {
                    result = true;
                }
                else
                {
                    if(dgvHallBooking.Rows[rowIndex].Cells[2].Value == "1")
                    {
                        result = true;
                    }
                    else
                    {
                        if(dgvHallBooking.Rows[rowIndex].Cells[3].Value == "1")
                        {
                            result = true;
                        }
                        else
                        {
                            if(dgvHallBooking.Rows[rowIndex].Cells[4].Value == "1")
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
                    MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    result = false;
                }

                for (int x = 0; x < dgvHallBooking.Rows.Count-1; x++)
                {
                    if (dgvHallBooking.Rows[x].Cells[0].Value == null || dgvHallBooking.Rows[x].Cells[5].Value == null || dgvHallBooking.Rows[x].Cells[6].Value == null || dgvHallBooking.Rows[x].Cells[7].Value == null || dgvHallBooking.Rows[x].Cells[8].Value == null)
                    {
                        MessageBox.Show("Row cannot have empty cells!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        result = false;
                        break;
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

        public frmHallBoking1()
        {
            InitializeComponent();
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
                    //txtSerialNo.Text = getNextSerialNo().ToString("00000");
                    txtMr.Text = "";
                    dgvHallBooking.Rows.Clear();
                    dgvHallBooking.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                    txtDeduction.Text = "0.00";
                    txtAmount.Text = "0.00";
                    txtFName.Text = "";
                    cmbOrakh.Text = "";
                    btnSave.Enabled = false;
                    dtpDate.Text = "";                    
                    AcceptButton = btnSearch;
                    txtSerialNo.ReadOnly = false;

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
                    //string FName = txtFName.Text;
                    //string Orakh = cmbOrakh.Text;
                    int Account = 0;
                    if (cmbAccount.SelectedValue != null)
                    {
                        Account = Convert.ToInt32(cmbAccount.SelectedValue.ToString());
                    }
                    string ContactNo = txtContactNo.Text;
                    int FCardNo=0;
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
                            for (int x = 0; x < dgvHallBooking.RowCount - 1; x++)
                            {
                                int Event = Convert.ToInt32(dgvHallBooking.Rows[x].Cells[0].Value.ToString());

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

                                string ft = dgvHallBooking.Rows[x].Cells["FTime"].Value.ToString();
                                string[] fti = ft.Split(Convert.ToChar("-"));
                                int ftime = Convert.ToInt32(fti[0]);
                                DateTime FromTime = Convert.ToDateTime("01/01/2010 " + ftime.ToString() + ":00:00 " + fti[1].ToString());

                                string tt = dgvHallBooking.Rows[x].Cells["To"].Value.ToString();
                                string[] tti = tt.Split(Convert.ToChar("-"));
                                int ttime = Convert.ToInt32(tti[0]);
                                DateTime ToTime = Convert.ToDateTime("01/01/2010 " + ttime.ToString() + ":00:00 " + tti[1].ToString());

                                string Remarks = dgvHallBooking.Rows[x].Cells["Remarks"].Value.ToString();
                                string Reason = dgvHallBooking.Rows[x].Cells["ReasonCancel"].Value.ToString();
                                //string FName = txtFName.Text;
                                //string Orakh = cmbOrakh.Text;
                                //decimal Amount = Convert.ToDecimal(txtAmount.Text);

                                bool result = dbLayer.AddHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4,Hall5, Dated, Dated, FromTime, ToTime, Remarks, FName, Orakh, Amount, Reason, Account, ContactNo, FCardNo.ToString("00000"),Temp);

                                if (result)
                                {
                                    rSuccess++;
                                }
                            }

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
                        for (int x = 0; x < dgvHallBooking.RowCount; x++)
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

                            string ft = dgvHallBooking.Rows[x].Cells["Ftime"].Value.ToString();
                            string[] fti = ft.Split(Convert.ToChar("-"));
                            int ftime = Convert.ToInt32(fti[0]);
                            DateTime FromTime = Convert.ToDateTime("01/01/2010 " + ftime.ToString() + ":00:00 " + fti[1].ToString());

                            string tt = dgvHallBooking.Rows[x].Cells["To"].Value.ToString();
                            string[] tti = tt.Split(Convert.ToChar("-"));
                            int ttime = Convert.ToInt32(tti[0]);
                            DateTime ToTime = Convert.ToDateTime("01/01/2010 " + ttime.ToString() + ":00:00 " + tti[1].ToString());

                            string Remarks = dgvHallBooking.Rows[x].Cells["Remarks"].Value.ToString();
                            
                            string Reason = dgvHallBooking.Rows[x].Cells["ReasonCancel"].Value.ToString();

                            bool result = false;
                            
                            
                            bool added = false;

                            if (dgvHallBooking.Rows[x].Cells["ID"].Value != null)
                            {
                                int rID = Convert.ToInt32(dgvHallBooking.Rows[x].Cells["ID"].Value.ToString());
                                result = dbLayer.UpdateHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4,Hall5, Dated, Dated, FromTime, ToTime, Remarks, rID, FName, Orakh, Amount, Reason, Account, ContactNo, FCardNo.ToString("00000"),Temp);
                                added = false;
                            }
                            else
                            {
                                result = dbLayer.AddHallBooking(SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4,Hall5, Dated, Dated, FromTime, ToTime, Remarks, FName, Orakh, Amount, Reason, Account, ContactNo, FCardNo.ToString("00000"),Temp);
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
                        string msg = rSuccess.ToString() + " Out Of " + Convert.ToString(dgvHallBooking.RowCount - rAdded) + " Record(s) Updated Successfully!";
                        
                        if (rAdded != 0)
                        {
                            msg += "\n\n" + rAdded.ToString() + " new Records added!";
                        }
                        tblTransactionsTableAdapter.InsertTransaction(2, "HBK", Convert.ToInt32(SerialNo), DateTime.Today,Convert.ToDecimal(txtDeduction.Text),0, Mr + " " + FName + " " + Orakh + "", "", "Serial No = " + SerialNo.ToString("00000"));
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

                        //dtpDate.Enabled = false;

                        txtMr.ReadOnly = true;
                        btnCloseView_Click(sender, e);
                        txtSerialNo.ReadOnly = false;
                        txtSerialNo.Focus();                       
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
            if (e.ColumnIndex == 0)
            {
                comboBox1.Top = initialTop + ((comboBox1.Height+1) * e.RowIndex);

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
            // TODO: This line of code loads data into the 'dataset.tblHallBooking' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataset2.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataset2.tblEvents);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblOrakh' table. You can move, or remove it, as needed.           
            txtSerialNo.Focus();
            grbSearch.Visible = false;
            tblAccountsTableAdapter.Fill(comDataSet.tblAccounts);
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
            //else
            //{
            //    txtSerialNo.Text = getNextSerialNo().ToString("00000");
            //}

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtSerialNo.Text != "")
            {
                int serialNo = Convert.ToInt32(txtSerialNo.Text);

                if (checkSerialNo(serialNo))
                {
                    //mode = 2;

                    SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);

                    try
                    {
                        Conn.Open();

                        SqlCommand Command = new SqlCommand("SELECT SerialNo, Date, Mr, Event, Hall1, Hall2, Hall3, Hall4, Dated, Day, FromTime, ToTime, Remarks,ReasonCancel, ID,FName,Amount,Orakh,ContactNo,Account,FCardNo FROM tblHallBooking Where SerialNo=" + serialNo.ToString(), Conn);

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
                            //btnSave.Enabled = false;
                            //btnReset.Enabled = false;
                            //btnEdit.Visible = true;
                            //btnDelete.Visible = true;
                            //dgvHallBooking.ReadOnly = true;
                            dgvHallBooking.AllowUserToDeleteRows = false;
                            //dgvHallBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                            //dtpDate.Enabled = false;
                            txtMr.ReadOnly = true;
                            //int rIndex = 0;

                            while (Reader.Read())
                            {
                                dtpDate.Text = Reader.GetValue(1).ToString();
                                txtMr.Text = Reader.GetValue(2).ToString();
                                txtFName.Text = Reader.GetValue(15).ToString();
                                txtAmount.Text = Convert.ToDecimal(Reader.GetValue(16).ToString()).ToString("0.00");
                                cmbOrakh.Text = Reader.GetValue(17).ToString();
                                txtContactNo.Text = Reader.GetValue(18).ToString();
                                cmbAccount.SelectedValue = Reader.GetValue(19);
                                txtFCardNo.Text = Reader.GetValue(20).ToString();
                                int z = dgvHallBooking.Rows.Add();

                                for (int x = 3; x < Reader.FieldCount-6; x++)
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

                        for (int y = 0; y < dgvHallBooking.Rows.Count; y++)
                        {

                            for (int z = 1; z < 5; z++)
                            {
                                int a = Convert.ToInt32(dgvHallBooking.Rows[y].Cells[z].Value.ToString());
                                if (a == 0)
                                    dgvHallBooking.Rows[y].Cells[z].ReadOnly = true;
                            }


                        }

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
        }
        
        private void btnCloseView_Click(object sender, EventArgs e)
        {
            txtSerialNo.ReadOnly = false;
            btnReset_Click(sender, e);
            mode = 0;
            btnCloseView.Visible = false;
            btnSave.Enabled = true;
            btnReset.Enabled = true;
            btnEdit.Visible = false;
            this.AcceptButton = btnSave;
            dgvHallBooking.ReadOnly = false;
            dgvHallBooking.AllowUserToDeleteRows = true;
            //dtpDate.Enabled = true;
            txtMr.ReadOnly = false;
            btnDelete.Visible = false;
            txtSerialNo.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            mode = 1;
            dgvHallBooking.ReadOnly = false;
            dgvHallBooking.AllowUserToDeleteRows = true;
            btnSave.Enabled = true;
            //dtpDate.Enabled = true;
            //txtMr.ReadOnly = false;
            btnDelete.Visible = false;
            dgvHallBooking.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?\n\nThis will remove all records in current booking!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool result2 = dbLayer.DeleteHallBookingAll(Convert.ToInt32(txtSerialNo.Text));
                    if(result2)
                    {
                        MessageBox.Show("Successfully deleted!");
                        btnCloseView_Click(sender,e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void dgvHallBooking_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (e.Row.Cells[10].Value != null && mode == 1)
                {
                    if (dgvHallBooking.Rows.Count== 2)
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
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSerialNo_Leave(sender, e);
            if (txtSerialNo.Text != "")
            {
                int No = Convert.ToInt32(txtSerialNo.Text);

                if (checkSerialNo(No))
                {
                    grbSearch.BringToFront();
                    grbSearch.Visible = true;
                    btnSave.Enabled = true;
                    mode = 1;
                    btnLoad_Click(sender, e);
                    AcceptButton = btnSave;
                }
                else
                {
                    MessageBox.Show("No record found of that serial number!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                              
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
            else
                MessageBox.Show("Please provide serial Number!!", "Serial No Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbSearch.Visible = false;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text == "") { txtAmount.Text = "0.00"; }
                if (txtDeduction.Text == "") { txtDeduction.Text = "0.00"; }
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal deduction = Convert.ToDecimal(txtDeduction.Text);
                if (amount < deduction)
                    MessageBox.Show("Deduction cannot be greater than Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    decimal net = amount - deduction;
                    txtNetAmount.Text = net.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please put valid values in respective fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtDeduction_TextChanged(object sender, EventArgs e)
        {
            txtAmount_TextChanged(sender, e);
        }
      
    }
}   
    
