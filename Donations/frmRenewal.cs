using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MCKJ.Common;
using System.Globalization;
using Community;

namespace MCKJ
{
    public partial class frmRenewal : Form
    {
        public frmRenewal()
        {
            InitializeComponent();
        }
        int mode = 0;
        string RDate = "";
        string ToYr = "";
        int ID = 0;
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 5;
        int calc = 0;
        Decimal LateFeeYears = 0;
        DataTable dt = new DataTable();
        DataTable dtRenewal = new DataTable();
        //bool rNew = false;
        //bool rEdit = false;
        //bool rDelete = false;
        //private void User_Right()
        //{
        //    Community.DBLayer DBLayer = new Community.DBLayer();
        //    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);

        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("Select Write,Modify,[Delete] from tblPermission  Where UserID =" + UserID + " And SecurityLevelID= " + 5, con);
        //        cmd.CommandType = CommandType.Text;
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        reader.Read();

        //        if (reader.HasRows)
        //        {
        //            rNew = Convert.ToBoolean(reader.GetValue(0));
        //            rEdit = Convert.ToBoolean(reader.GetValue(1));
        //            rDelete = Convert.ToBoolean(reader.GetValue(2));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //    }
        //    //return chk_Right;
        //}


        private int next()
        {
           
            int nextt = 0;
            SqlConnection con = new SqlConnection(DBLayer.CON_string);
            SqlCommand cmd = new SqlCommand("Select ISNULL(Max(Cast(ReceiptNo as int)),0) From tblRenewal",con);

            con.Open();

            nextt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            return nextt;

        }
    
        private void frmRenewal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset3.tblDonAcc' table. You can move, or remove it, as needed.
            this.tblDonAccTableAdapter.Fill(this.dataset3.tblDonAcc);
            // TODO: This line of code loads data into the 'dataset3.tblRenAcc' table. You can move, or remove it, as needed.
            this.tblRenAccTableAdapter.Fill(this.dataset3.tblRenAcc);
          
            // TODO: This line of code loads data into the 'comDataSet.tblTransactions' table. You can move, or remove it, as needed.
            this.tblTransactionsTableAdapter.Fill(this.comDataSet.tblTransactions);
            txtFCardNo.Focus();
            this.tblAccountsTableAdapter.Fill_All(this.comDataSet.tblAccounts);
            DGRenewal.BringToFront();
            cmbAccount.SelectedItem = 0;
            Height = 328;
        }

        private bool CheckReceiptNo(string receiptNo)
        {
            bool result = false;
            if (txtReceiptNo.Text != "")
            {
               
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                SqlCommand cmd = new SqlCommand("Select ReceiptNo from tblRenewal Where ReceiptNo = " + receiptNo, con);
                con.Open();
                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                    result = true;
                else
                    result = false;
                con.Close();
            }
            return result;
        }
      
        private int[] TransactionID(int receiptNo)
        {
            int[] id = new int[3];
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            SqlCommand cmd = new SqlCommand("Select ID from tblTransactions WHERE DocumentNo = " + receiptNo + " AND Voucher = 'RWL'",con);
            con.Close();
            con.Open();

            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                int x = 0;
                while (Reader.Read())
                {
                    id[x] = Convert.ToInt32(Reader.GetValue(0).ToString());
                    x++;
                }
            }
            Reader.Close();
            con.Close();
            txtCardFee.Text = "50.00";
            return id;
        }
    
        private bool AccountLink()
        {
            bool result = false;
            if (rdbYes.Checked == true)
                result = true;
            else
                result = false;

            return result;
        }

        private void CalculateAge()
        {
            try
            {
                int a = DGInfo.Rows.Count;

                for (int i = 0; i < a; i++)
                {

                    string A = DGInfo.Rows[i].Cells[3].Value.ToString();

                    if (A.Length == 4)
                    {
                        int Year = DateTime.Now.Year;
                        string DOBYear = DGInfo.Rows[i].Cells[3].Value.ToString();
                        int AgeYear = Year - Convert.ToInt32(DOBYear);
                        DGInfo.Rows[i].Cells[2].Value = AgeYear.ToString() + " Yrs ";
                    }
                    else
                    {
                        int YearNow = Convert.ToInt32(DateTime.Now.Year);
                        int MonthNow = Convert.ToInt32(DateTime.Now.Month);
                        int DateNow = Convert.ToInt32(DateTime.Now.Day);
                        string[] DOB = Convert.ToString(DGInfo.Rows[i].Cells[3].Value.ToString()).Split(Convert.ToChar("-"));
                        int D = Convert.ToInt32(DOB[1]);

                        int Month = MonthNow - D;

                        int E = Convert.ToInt32(DOB[0]);
                        int Date = DateNow - E;
                        int F = Convert.ToInt32(DOB[2]);
                        int Year = YearNow - F;
                        if (Month < 0)
                        {
                            Year = Year - 1;
                            Month = Month + 12;
                        }
                        if (Date < 0)
                        {
                            Date = Date + DateTime.DaysInMonth(YearNow, MonthNow);
                        }


                        //DateTime CDate = DateTime.Today;
                        //TimeSpan time1 = CDate.Subtract(DOB);
                        //time1.TotalDays.ToString();
                        //int CalculatedAge = time1.Days / 365;
                        DGInfo.Rows[i].Cells[2].Value = Year.ToString() + " Yrs " + Month.ToString() + " Months " + Date.ToString() + " Days";


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknow error occure..\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EmptyFields()
        {            
            txtRenewlFee.Text = "0.00";
            txtPoorFund.Text = "0.00";
            txtLateFee.Text = "0.00";

            txtDonationFund.Text = "0.00";
            txtEduFund.Text = "0.00";
            txtZakatFund.Text = "0.00";
            txtTamiratiFund.Text = "0.00";
            txtKabrFund.Text = "0.00";
            
            
            txtTotal.Text = "0.00";
            txtReceiptNo.Text = "";           
            cmbRenewalYear.Text = DateTime.Now.Year.ToString();
            cmbYearTo.Text = null;
        }

        private bool CheckFields()
        {
            if (cmbRenewalYear.SelectedItem == null && string.IsNullOrEmpty(cmbRenewalYear.Text))
            {
                MessageBox.Show("Please Fill the Required fields!", "Fields cannot be Empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
                return true;
        }

        private void DoCalculate()
        {
            if (txtRenewlFee.Text == "")
            {
                txtRenewlFee.Text = "0.00";
            }
            if (txtCardFee.Text == "")
            {
                txtCardFee.Text = "0.00";
            }
            if (txtLateFee.Text == "")
            {
                txtLateFee.Text = "0.00";
            }
            if (txtPoorFund.Text == "")
            {
                txtPoorFund.Text = "0.00";
            }

            if (txtEduFund.Text == "")
            {
                txtEduFund.Text = "0.00";
            }
            if (txtKabrFund.Text == "")
            {
                txtKabrFund.Text = "0.00";
            }
            if (txtZakatFund.Text == "")
            {
                txtZakatFund.Text = "0.00";
            }
            if (txtDonationFund.Text == "")
            {
                txtDonationFund.Text = "0.00";
            }
            if (txtTamiratiFund.Text == "")
            {
                txtTamiratiFund.Text = "0.00";
            }
            try
            {
                decimal EducationFund = Convert.ToDecimal(txtEduFund.Text);
                decimal KabristanFund = Convert.ToDecimal(txtKabrFund.Text);
                decimal ZakatFund = Convert.ToDecimal(txtZakatFund.Text);
                decimal DonationFund = Convert.ToDecimal(txtDonationFund.Text);
                decimal TamiratiFund = Convert.ToDecimal(txtTamiratiFund.Text);

                decimal LateFee = Convert.ToDecimal(txtLateFee.Text);
                decimal PoorFund = Convert.ToDecimal(txtPoorFund.Text);
                decimal PerMemberFee = Convert.ToDecimal(txtPerMemberFee.Text);
                decimal CardFee = Convert.ToDecimal(txtCardFee.Text);
                decimal Adults = Convert.ToDecimal(txtAdult.Text);
                decimal MembersFee = PerMemberFee * Adults;
                decimal Total = 0;
                decimal renFee = Convert.ToDecimal(txtRenewlFee.Text);
                if (calc == 0)
                {
                    txtRenewlFee.Text = MembersFee.ToString("0.00");
                    Total = MembersFee + CardFee + LateFee + PoorFund
                            + EducationFund + KabristanFund + ZakatFund + DonationFund + TamiratiFund;
                }
                else
                {
                    Total = CardFee + LateFee + PoorFund + renFee
                     + EducationFund + KabristanFund + ZakatFund + DonationFund + TamiratiFund;
                }

                txtTotal.Text = Total.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                    
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbYearTo.Items.Clear();
            cmbYearTo.Items.Add(DateTime.Now.ToString("yyyy"));
            cmbYearTo.Items.Add(Int16.Parse(DateTime.Now.ToString("yyyy")) + 1);
            
            txtReceiptNo.Focus();
            rdbYes.Checked = true;
            EmptyFields();
            btnReset.Enabled = true;
            txtFCardNo.ReadOnly = true;
            DGRenewal.Hide();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnFCardNo.Enabled = false;
            btnPrint.Enabled = false;
            DGRenewal.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            mode = 1;
            cmbAccount.SelectedIndex = 0;
            cmbPoorAcc.SelectedIndex = 0;
            this.AcceptButton = btnSubmit;
            txtReceiptNo.Text = next().ToString("00000");
            dpRenewalDate.Value = DateTime.Now;
            //Get CardRenewalFee Data 
            dt = DBLayer.GetFamilyCardRenewalFeeEnhanceDate();
            //SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            //SQLCache sqlCache = new SQLCache();
            //string query = sqlCache.GetSQL("GetCardRenewalFee");
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //con.Close();
            //da.Dispose();

            txtCardFee.Text = Decimal.Parse(dt.Rows[0]["CardRenewalFee"].ToString()).ToString("F").ToString();
            txtPerMemberFee.Text = Decimal.Parse(dt.Rows[0]["MemberFee"].ToString()).ToString("F").ToString();
            //txtLateFee.Text = Decimal.Parse(dt.Rows[0]["LateFee"].ToString()).ToString("F").ToString();

            dt = DBLayer.GetRenewalByFCardNo(txtFCardNo.Text);
            if (dt.Rows.Count > 0)
            {
                cmbRenewalYear.Text = "";
                cmbRenewalYear.SelectedText = dt.Rows[0]["RenewalTo"].ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EmptyFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cmbYearTo.Items.Clear();
            cmbYearTo.Items.Add(DateTime.Now.ToString("yyyy"));
            cmbYearTo.Items.Add(Int16.Parse(DateTime.Now.ToString("yyyy")) + 1);
            
            if (DGRenewal.Rows.Count != 0)
             {
                if (rdbYes.Checked == false)
                {
                    rdbNo.Checked = true;
                }
                txtFCardNo.ReadOnly = true;
                btnReset.Enabled = false;
                DGRenewal.Hide();
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnFCardNo.Enabled = false;
                btnDelete.Enabled = false;
                RDate = cmbRenewalYear.Text;
                ToYr = cmbYearTo.Text;
                DGRenewal.Enabled = false;
                cmbRenewalYear.Focus();
                txtReceiptNo.Enabled = false;
                this.AcceptButton = btnSubmit;
                btnPrint.Enabled = false;
                mode = 0;
                ID = Convert.ToInt32(DGRenewal.CurrentRow.Cells[0].Value.ToString());
            }
            else
                MessageBox.Show("No record to modify!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you Sure! You Want to Cancel", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                usp_SEL_RenewalTableAdapter.Fill(comDataSet.usp_SEL_Renewal, txtFCardNo.Text);
                txtFCardNo.ReadOnly = false;              
                DGRenewal.Show();
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;             
                btnFCardNo.Enabled = true;
                btnReset.Enabled = true;
                DGRenewal.Enabled = true;
                btnAdd.Enabled = true;
                txtReceiptNo.Enabled = true;
                btnDelete.Enabled = true;
                btnPrint.Enabled = true;
                this.AcceptButton = btnAdd;                
                mode = 0;
                calc = 0;
                lblRenewalYears.Text = "";

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
           
            if (CheckFields())
            {               
               

                bool Result = DBLayer.CHK_RWL(txtFCardNo.Text,cmbRenewalYear.Text,cmbYearTo.Text);
               
                    
                    try
                    {
                       
                        string  FCardNo = txtFCardNo.Text;
                        string Year = cmbRenewalYear.Text;
                        DateTime Date = Convert.ToDateTime(dpRenewalDate.Text);
                        decimal Fee = Convert.ToDecimal(txtRenewlFee.Text);
                        decimal LateFee = Convert.ToDecimal(txtLateFee.Text);
                        decimal PoorFund = Convert.ToDecimal(txtPoorFund.Text);
                        decimal Total = Convert.ToDecimal(txtTotal.Text); 
                        decimal EducationFund = Convert.ToDecimal(txtEduFund.Text);
                        decimal KabristanFund = Convert.ToDecimal(txtKabrFund.Text);
                        decimal ZakatFund = Convert.ToDecimal(txtZakatFund.Text);
                        decimal DonationFund = Convert.ToDecimal(txtDonationFund.Text);
                        decimal TamiratiFund = Convert.ToDecimal(txtTamiratiFund.Text);
                       // bool Link = Convert.ToBoolean(rdbYes.Checked); 
                        decimal CardFee = Convert.ToDecimal(txtCardFee.Text);
                        string TotalMembers = txtTotalMembers.Text;
                        string AdultMemebers = txtAdult.Text;
                        bool Link = AccountLink();
                        string ReceiptNo = txtReceiptNo.Text;
                        //int Account =Convert.ToInt32(cmbAccount.SelectedValue.ToString());
                        //int PoorAcc = Convert.ToInt32(cmbPoorAcc.SelectedValue.ToString());
                        string RenewalTo = cmbYearTo.Text ;

                        if (mode == 1)
                        {
                            if (/*Result*/1 != 1)
                                MessageBox.Show("Already Renewed for range of Year!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            else
                            {

                                usp_SEL_RenewalTableAdapter.Insert1(FCardNo, Date, Year, Fee, PoorFund, LateFee, Total, Link, CardFee, AdultMemebers, TotalMembers, /*ReceiptNo*/next().ToString("00000"), 115, 118, RenewalTo, EducationFund,KabristanFund,ZakatFund,DonationFund,TamiratiFund,new DBLayer().GetUserID());
                                tblTransactionsTableAdapter.InsertTransaction(MCKJ.frmHallBoking.HRD("Card Renewal Charges"), "RWL", Convert.ToInt32(ReceiptNo), Date, 0, Total, "Year = " + Year + " CardNo = " + FCardNo, "", "");
                                //tblTransactionsTableAdapter.InsertTransaction(115, "RWL", Convert.ToInt32(ReceiptNo), Date, Total - PoorFund, 0, "Year = " + Year + " CardNo = " + FCardNo, "", "");
                                tblTransactionsTableAdapter.InsertTransaction(117, "RWL", Convert.ToInt32(ReceiptNo), Date, PoorFund, 0, "Year = " + Year + " CardNo = " + FCardNo, "", "");
                                UpdateFamilyTable(RenewalTo);
                                MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                usp_SEL_RenewalTableAdapter.Fill(comDataSet.usp_SEL_Renewal, FCardNo);
                                mode = 0;
                                btnReset.Show();
                                DGRenewal.Show();
                                btnAdd.Show();
                                btnEdit.Show();
                                //  btnDelete.Show();
                                btnPrint.Show();
                                btnClose.Show();
                                btnFCardNo.Show();
                                btnReset.Hide();
                                DGRenewal.Enabled = true;
                                txtFCardNo.ReadOnly = false;
                                btnAdd.Enabled = true;
                                btnEdit.Enabled = true;
                                btnPrint.Enabled = true;
                                btnDelete.Enabled = true;
                                btnFCardNo.Enabled = true;
                            }
                        }
                        else if (mode == 0)
                        {
                            int[] idz = TransactionID(Convert.ToInt32(ReceiptNo));
                            if (RDate == cmbRenewalYear.Text && ToYr == cmbYearTo.Text)
                            {

                                usp_SEL_RenewalTableAdapter.Update1(ID, FCardNo, Date, Year, Fee, PoorFund, LateFee, Total, Link, CardFee, AdultMemebers, TotalMembers, ReceiptNo, 115, 118, RenewalTo, EducationFund, KabristanFund, ZakatFund, DonationFund, TamiratiFund, new DBLayer().GetUserID());

                                tblTransactionsTableAdapter.UpdateTransaction(MCKJ.frmHallBoking.HRD("Card Renewal Charges"), "RWL", Convert.ToInt32(ReceiptNo), Date, 0, Total, "Year = " + Year + " CardNo = " + FCardNo, "", "", idz[0]);
                                tblTransactionsTableAdapter.UpdateTransaction(115, "RWL", Convert.ToInt32(ReceiptNo), Date, Total - PoorFund, 0, "Year = " + Year + " CardNo = " + FCardNo, "", "", idz[1]);
                                tblTransactionsTableAdapter.UpdateTransaction(118, "RWL", Convert.ToInt32(ReceiptNo), Date, PoorFund, 0, "Year = " + Year + " CardNo = " + FCardNo, "", "", idz[2]);

                                UpdateFamilyTable(RenewalTo);
                                MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                usp_SEL_RenewalTableAdapter.Fill(comDataSet.usp_SEL_Renewal, FCardNo);
                                btnReset.Show();
                                DGRenewal.Show();
                                btnAdd.Show();
                                btnEdit.Show();
                                //  btnDelete.Show();
                                btnPrint.Show();
                                btnClose.Show();
                                btnFCardNo.Show();
                                btnReset.Hide();
                                DGRenewal.Enabled = true;
                                txtFCardNo.ReadOnly = false;
                                txtReceiptNo.Enabled = true;
                                btnAdd.Enabled = true;
                                btnEdit.Enabled = true;
                                btnPrint.Enabled = true;
                                btnDelete.Enabled = true;
                                btnFCardNo.Enabled = true;
                            }
                            else
                            {
                                if (Result)
                                    MessageBox.Show("Already Renewed for range of Year!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                {

                                    usp_SEL_RenewalTableAdapter.Update1(ID, FCardNo, Date, Year, Fee, PoorFund, LateFee, Total, Link, CardFee, AdultMemebers, TotalMembers, ReceiptNo, 115, 118, RenewalTo, EducationFund, KabristanFund, ZakatFund, DonationFund, TamiratiFund, new DBLayer().GetUserID());
                                    tblTransactionsTableAdapter.UpdateTransaction(MCKJ.frmHallBoking.HRD("Card Renewal Charges"), "RWL", Convert.ToInt32(ReceiptNo), Date, 0, Total, "Year = " + Year + " CardNo = " + FCardNo, "", "", idz[0]);
                                    tblTransactionsTableAdapter.UpdateTransaction(115, "RWL", Convert.ToInt32(ReceiptNo), Date, Total - PoorFund, 0, "Year = " + Year + " CardNo = " + FCardNo, "", "", idz[1]);
                                    tblTransactionsTableAdapter.UpdateTransaction(118, "RWL", Convert.ToInt32(ReceiptNo), Date, PoorFund, 0, "Year = " + Year + " CardNo = " + FCardNo, "", "", idz[2]);
                                    MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    usp_SEL_RenewalTableAdapter.Fill(comDataSet.usp_SEL_Renewal, FCardNo);
                                    btnReset.Show();
                                    DGRenewal.Show();
                                    btnAdd.Show();
                                    btnEdit.Show();
                                    //  btnDelete.Show();
                                    btnPrint.Show();
                                    btnClose.Show();
                                    btnFCardNo.Show();
                                    btnReset.Hide();
                                    DGRenewal.Enabled = true;
                                    txtFCardNo.ReadOnly = false;
                                    txtReceiptNo.Enabled = true;
                                    btnAdd.Enabled = true;
                                    btnEdit.Enabled = true;
                                    btnPrint.Enabled = true;
                                    btnDelete.Enabled = true;
                                    btnFCardNo.Enabled = true;
                                }
                            }
                           
                        }

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txtFCardNo.Focus();
                    this.AcceptButton = btnAdd;
                    calc = 0;
                    lblRenewalYears.Text = "";
                    
                }
            
        }

        private void UpdateFamilyTable(string renewalTo)
        {
            SqlConnection Conn = new SqlConnection(Community.DBLayer.con_String);
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "Update tblFamily SET CardRenewalTo = '" + renewalTo + "' WHERE FcardNo = " + txtFCardNo.Text;
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void btnFCardNo_Click(object sender, EventArgs e)
      {
          
             txtFCardNo_Leave(sender, e);         
            string x = txtFCardNo.Text;
            
            Community.DBLayer dblayer = new Community.DBLayer();
            if (txtFCardNo.Text == "")
            {
                MessageBox.Show("Please Insert Family Card Number", "Family Card Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                bool result = dblayer.CheckFamily(txtFCardNo.Text);
                if (result)
                {                                      
                    usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, txtFCardNo.Text);
                    //if (DGRenewal.Rows.Count == 0)
                    //{
                    //    btnEdit.Enabled = false;
                    //    btnPrint.Enabled = false;
                    //}
                    //else
                    //{
                    //    btnEdit.Enabled = false;
                    //    btnPrint.Enabled = false;
                    //}
                    if (txtFCardNo.Text == "")
                    {
                        txtFCardNo.Text = x;
                    }
                    btnViewInfo_Click(sender, e);
                   
                   
                    usp_SEL_tblFamilyMemberTableAdapter.FillActive(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);                    
                    txtTotalMembers.Text = comDataSet.usp_SEL_tblFamilyMember.Rows.Count.ToString();

                    GetFemaleInformation(txtFCardNo.Text);

                    usp_Male_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_Male_tblFamilyMember, txtFCardNo.Text, "Male");
                    int Male = DGInfo.Rows.Count;

                    CalculateAge();

                    usp_SEL_tblFamilyMemberTableAdapter.FillAdult(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
                    int Adults = comDataSet.usp_SEL_tblFamilyMember.Rows.Count;
                    txtAdult.Text = Adults.ToString();

                    int Minor = Male - Adults;
                    txtMinor.Text = Minor.ToString();
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
                    //Get Selected Family Card Renewal Info
                    usp_SEL_RenewalTableAdapter.Fill(comDataSet.usp_SEL_Renewal, txtFCardNo.Text);
                    btnViewInfo.Enabled = true;
                    this.AcceptButton = btnAdd;
                    btnPrint.Enabled = true;
                    //btnDelete.Enabled = true;
                    if (txtFCardNo.Text == "")
                        txtFCardNo.Text = x;
                    //if()
                }
                else
                {
                    MessageBox.Show("Family CardNo doesnot exist! Please enter a Valid CardNo.", "Invalid CardNo.", MessageBoxButtons.OK, MessageBoxIcon.Stop);                   
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    DGRenewal.Enabled = false;
                    btnViewInfo.Enabled = false;
                    btnPrint.Enabled = false;
                }
            }
        }

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
                    btnFCardNo.Enabled = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!");
            }
        }

        private void txtRenewlFee_TextChanged(object sender, EventArgs e)
        {
            DoCalculate();
        }

        private void txtPoorFund_TextChanged(object sender, EventArgs e)
        {
            DoCalculate();
        }

        private void txtLateFee_TextChanged(object sender, EventArgs e)
        {
            DoCalculate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGRenewal.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int receipt = Convert.ToInt32(DGRenewal.CurrentRow.Cells[1].Value.ToString());
                    int ID = Convert.ToInt32(DGRenewal.CurrentRow.Cells[0].Value.ToString());
                    usp_SEL_RenewalTableAdapter.Delete1(ID);
                    tblTransactionsTableAdapter.DeleteTransactions("RWL", receipt);
                    MessageBox.Show("Deleted Succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    usp_SEL_RenewalTableAdapter.Fill(comDataSet.usp_SEL_Renewal, txtFCardNo.Text);
                }
            }
            else
                MessageBox.Show("No record to Delete!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }            

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {

            Height = 328;
            DGInfo.Hide();
            btnCloseInfo.Hide();
            btnUpdAgeGroup.Hide();          
            
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {          
            this.Width = 662;
            this.Height =468;
            DGInfo.Show();
            btnCloseInfo.Show();
            btnUpdAgeGroup.Show();
        }

        private void txtPerMemberFee_TextChanged(object sender, EventArgs e)
        {
            DoCalculate();
        }

        private void txtCardFee_TextChanged(object sender, EventArgs e)
        {
            DoCalculate();
        }

        private void txtFCardNo_TextChanged(object sender, EventArgs e)
        
        {
            this.AcceptButton = btnFCardNo;
           
        }

        private void btnUpdGender_Click(object sender, EventArgs e)
        {            
            long ID = Convert.ToInt64(DGInfo.CurrentRow.Cells[4].Value.ToString());
            string FCardNo = txtFCardNo.Text;            
            DialogResult OK = MessageBox.Show("Are you sure you want to update member", "Confirmation",MessageBoxButtons.YesNo);
            if (OK == DialogResult.Yes)
            {
                if (DGInfo.CurrentRow.Cells[1].Value.ToString() == "Minor")
                {
                    usp_SEL_tblFamilyMemberTableAdapter.updAgeGroup(ID, FCardNo, "Adult");
                }
                else
                    usp_SEL_tblFamilyMemberTableAdapter.updAgeGroup(ID, FCardNo, "Minor");

                usp_SEL_tblFamilyMemberTableAdapter.FillActive(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
                txtTotalMembers.Text = comDataSet.usp_SEL_tblFamilyMember.Rows.Count.ToString();

                usp_Male_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_Male_tblFamilyMember, txtFCardNo.Text, "Male");
                int Male = DGInfo.Rows.Count;
                CalculateAge();

                usp_SEL_tblFamilyMemberTableAdapter.FillAdult(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
                int Adults = comDataSet.usp_SEL_tblFamilyMember.Rows.Count;
                txtAdult.Text = Adults.ToString();

                int Minor = Male - Adults;
                txtMinor.Text = Minor.ToString();
                DoCalculate();               
            }
        }

        private void cmbRenewalYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoCalculate();
        }

        private void txtTotalMembers_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReceiptNo_Leave(object sender, EventArgs e)
        {
           bool result = CheckReceiptNo(txtReceiptNo.Text);
           if (result == true)
           {
               MessageBox.Show("Receipt Number already exist!!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtReceiptNo.Focus();
           }
            try
            {
                if (txtReceiptNo.Text != "")
                {
                    int fcardno = Convert.ToInt32(txtReceiptNo.Text);
                    int x = 5 - txtReceiptNo.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    txtReceiptNo.Text = zeros + txtReceiptNo.Text;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtReceiptNo.Focus();
            }
        }

        private void DGInfo_Sorted(object sender, EventArgs e)
        {
            btnFCardNo_Click(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (DGRenewal.Rows.Count != 0)
            {
                try
                {
                    string receipt = DGRenewal.CurrentRow.Cells[1].Value.ToString();
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    con.Open();
                    string query = richTextBox1.Text;
                    query = query.Replace("@ReceiptNo", "'" + receipt + "'");
                    query = query.Replace("@FCardNO", "'" + txtFCardNo.Text+ "'");
                    SqlCommand cmd = new SqlCommand(query, con);
                    
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;

                    da.Fill(dt);
                    Reports.Renwal.frmViewer frm = new MCKJ.Reports.Renwal.frmViewer();
                    Reports.Renwal.rptRenewalNew rpt = new MCKJ.Reports.Renwal.rptRenewalNew();

                    frm.crystalReportViewer1.ReportSource = rpt;

                    rpt.SetDataSource(dt);
                    frm.Show();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("No Record for Print!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtRenewlFee_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal LateFee = Convert.ToDecimal(txtLateFee.Text);
            //    decimal PoorFund = Convert.ToDecimal(txtPoorFund.Text);
                
            //    decimal CardFee = Convert.ToDecimal(txtCardFee.Text);

            //    decimal RenFee = Convert.ToDecimal(txtRenewlFee.Text);

            //    decimal Total = RenFee + CardFee + LateFee + PoorFund;

            //    txtTotal.Text = Total.ToString("0.00");

            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Please enter valid values in respective fields!", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void txtRenewlFee_Enter(object sender, EventArgs e)
        {
            calc = 1;
        }

        private void GetFemaleInformation(string FCardNo)
        {
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            con.Open();
            string query = txtFemaleQuery.Text;
            query = query.Replace("@FCardNo", "'" + FCardNo + "'");
            SqlCommand cmd = new SqlCommand(query, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                    if (dtRow[0] != null && dtRow[0].ToString() != string.Empty && dtRow[0].ToString().ToLower().Equals("adult"))
                    {
                        txtFemaleAdult.Text = dtRow["AgeGroup"].ToString();
                    }

                    if (dtRow[0] != null && dtRow[0].ToString() != string.Empty && dtRow[0].ToString().ToLower().Equals("minor"))
                    {
                        txtFemaleMinor.Text = dtRow["AgeGroup"].ToString();
                    }
                }
            }
        }

        private void cmbYearTo_Leave(object sender, EventArgs e)
        {
            txtCardFee.Text = "50.00";
            txtPerMemberFee.Text = "50.00";
            if (cmbYearTo.Text != "")
            {
                dt = DBLayer.GetFamilyCardRenewalFeeLateCurrent();
                dtRenewal = DBLayer.GetRenewalByFCardNo(txtFCardNo.Text);
                lblRenewalYears.Text = (Int32.Parse(cmbYearTo.Text.ToString()) - Int32.Parse(cmbRenewalYear.Text.ToString())).ToString();

                if (dtRenewal.Rows.Count > 0)
                {
                    if (Convert.ToInt16(dt.Rows[0]["FromYear"].ToString()) == Convert.ToInt16(dtRenewal.Rows[0]["RenewalTo"].ToString()))
                    {
                        //Family card is already renewed
                        dt = DBLayer.GetFamilyCardRenewalLateFeeDueDate();

                        //Check that today date is between begdate and enddate
                        if ((DateTime.Parse(DateTime.Parse(dt.Rows[0]["BegDate"].ToString()).ToString("yyyy-MM-dd")) <= DateTime.Parse(DateTime.Today.ToString("yyyy-MM-dd")) && DateTime.Parse(DateTime.Parse(dt.Rows[0]["EndDate"].ToString()).ToString("yyyy-MM-dd")) >= DateTime.Parse(DateTime.Today.ToString("yyyy-MM-dd"))))
                        {
                            return;
                        }
                        //Check that today date is not less than begdate
                        else if (DateTime.Parse(DateTime.Parse(dt.Rows[0]["BegDate"].ToString()).ToString("yyyy-MM-dd")) > DateTime.Parse(DateTime.Today.ToString("yyyy-MM-dd")))
                        {
                            MessageBox.Show("Card is already renewed");
                            return;
                        }
                        else
                        {
                            txtLateFee.Text = Convert.ToDecimal(dt.Rows[0]["LateFee"].ToString()).ToString("F");
                            txtPerMemberFee.Text = (Decimal.Parse(Decimal.Parse(txtPerMemberFee.Text).ToString("F")) * Decimal.Parse(Decimal.Parse(lblRenewalYears.Text).ToString("F"))).ToString("F");
                            txtCardFee.Text = (Decimal.Parse(Decimal.Parse(txtCardFee.Text).ToString("F")) * Decimal.Parse(Decimal.Parse(lblRenewalYears.Text).ToString("F"))).ToString("F");

                        }
                    }
                    else if (Convert.ToInt16(dt.Rows[0]["FromYear"].ToString()) <= Convert.ToInt16(dtRenewal.Rows[0]["RenewalTo"].ToString()))
                    {
                        MessageBox.Show("Card is already renewed for the year "+dtRenewal.Rows[0]["RenewalYear"].ToString()+" - "+dtRenewal.Rows[0]["RenewalTo"].ToString()  );
                        cmbYearTo.Text = "";
                        return;
                    }
                    else
                    {

                        //Family card is not renewed then calculate late fee
                        LateFeeYears = Convert.ToDecimal(dt.Rows[0]["FromYear"].ToString()) - Convert.ToDecimal(dtRenewal.Rows[0]["RenewalTo"].ToString());
                        dt = DBLayer.GetFamilyCardRenewalLateFeeDueDate();
                        txtLateFee.Text = (LateFeeYears * Convert.ToDecimal(Convert.ToDecimal(dt.Rows[0]["LateFee"].ToString()).ToString("F"))).ToString();
                        txtPerMemberFee.Text = (Decimal.Parse(Decimal.Parse(txtPerMemberFee.Text).ToString("F")) * Decimal.Parse(Decimal.Parse(lblRenewalYears.Text).ToString("F"))).ToString("F");
                        txtCardFee.Text = (Decimal.Parse(Decimal.Parse(txtCardFee.Text).ToString("F")) * Decimal.Parse(Decimal.Parse(lblRenewalYears.Text).ToString("F"))).ToString("F");

                    }
                }
                //If tblRenewal not have any entry of this fCardNo then calculate LateFeeYears and late fee from FromYear and ToYear combobox
                else
                {
                    Decimal LateFee = 0;

                    Decimal ToYear = 0;
                    dt = DBLayer.GetFamilyCardRenewalLateFeeDueDate();
                    //LateFeeYears = Int32.Parse(cmbYearTo.Text.ToString()) - Int32.Parse(cmbRenewalYear.Text.ToString());
                    ToYear = Convert.ToDecimal(dt.Rows[0]["ToYear"].ToString());
                    LateFee = Convert.ToDecimal(Convert.ToDecimal(dt.Rows[0]["LateFee"].ToString()).ToString("F"));
                    //if (dt.Rows[0]["ToYear"].ToString() == cmbYearTo.Text.ToString())
                    //{
                    //    LateFeeYears -= 1;
                    //    txtLateFee.Text = (LateFeeYears * Convert.ToDecimal(Convert.ToDecimal(dt.Rows[0]["LateFee"].ToString()).ToString("F"))).ToString();
                    //}
                    //else
                    dt = DBLayer.GetFamilyByFCardNo(txtFCardNo.Text);
                    decimal RenewalToYear = Convert.ToDecimal(cmbYearTo.Text);
                    //if (dt.Rows[0]["CardRenewedTo"] != "")
                    //{
                    //    ToYear = Convert.ToDecimal(dt.Rows[0]["CardRenewedTo"].ToString());
                    //    //LateFee = Convert.ToDecimal(Convert.ToDecimal(dt.Rows[0]["RenewalDueFrom"].ToString()).ToString("F"));
                    //}
                    if (ToYear > 0)
                    {
                        LateFeeYears = ToYear - Convert.ToDecimal(cmbRenewalYear.Text.ToString());
                    }
                    else
                    {
                        LateFeeYears = RenewalToYear - Convert.ToDecimal(cmbRenewalYear.Text.ToString());
                    }
                    txtLateFee.Text = (LateFeeYears * LateFee).ToString();
                    txtPerMemberFee.Text = (Decimal.Parse(Decimal.Parse(txtPerMemberFee.Text).ToString("F")) * Decimal.Parse(Decimal.Parse(lblRenewalYears.Text).ToString("F"))).ToString("F");
                    txtCardFee.Text = (Decimal.Parse(Decimal.Parse(txtCardFee.Text).ToString("F")) * Decimal.Parse(Decimal.Parse(lblRenewalYears.Text).ToString("F"))).ToString("F");

                }
            }
        }

        private void cmbYearTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
     
    }
}