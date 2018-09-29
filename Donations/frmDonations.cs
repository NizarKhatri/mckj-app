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
    public partial class frmDonations : Form
    {
        public frmDonations()
        {
            InitializeComponent();
        }
        int id = 0;
        int mode = 0;
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 11;
        string Header = "Donations";


        private int next()
        {
            int nextt = 0;
            object value;
            SqlConnection con = new SqlConnection(DBLayer.CON_string);
            SqlCommand cmd = new SqlCommand("Select Max(Cast(ReceiptNo as int)) From tblDonations", con);

            con.Open();
            value = cmd.ExecuteScalar();
            if (value == DBNull.Value)
            {
                value = 0;
            }
            nextt = Convert.ToInt32(value) + 1;

            return nextt;

        }
        private bool CheckFields()
        {
            string check = "";
            
            if (txtReceiptNo.Text == ""  || Convert.ToDecimal(txtTotal.Text) <= 0 || (txtReceivedFrom.Text == "" && txtFCardNo.Text == ""))
            {
                MessageBox.Show("Please fill the required fields \n eg: \n either Received From or Family Card\n Any Donation", "Fields cannot be emptied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
                return true;
        }

        private int TransactionID(int receiptNo)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            SqlCommand cmd = new SqlCommand("Select ID from tblTransactions WHERE Voucher = 'DON' AND DocumentNo = " + receiptNo, con);

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

        private string FName(string FCardNo,string Name)
        {
            string fname = "";
            try
            {
               
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                SqlCommand cmd = new SqlCommand("Select FatherName from tblFamilyMember WHERE FCardNo = '" + FCardNo + "' AND MemberName = '" + Name + "'", con);

                con.Open();

                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    Reader.Read();
                    fname = Reader.GetValue(0).ToString();
                }
                Reader.Close();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("AnUnknown error occured!!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fname;
        }

        private void Gayab(bool A)
        {
            btnAdd.Visible = A;
            btnDelete.Visible = A;
            btnEdit.Visible = A;
            dgvDonation.Visible = A;
            //btnClose.Visible = A;
            btnView.Visible = A;
            txtFilter.Enabled = A;
            btnSearch.Enabled = A;
            btnPrint.Visible = A;
        }

        private void EmptyFields()
        {
           
            dtpDate.Text = null;
            txtFCardNo.Text = "";
            txtHead.Text = "";
            txtChqE.Text = "";
            txtChqG.Text = "";
            txtChqGe.Text = "";
            txtChqZ.Text = "";
            txtChqZa.Text = "";
            txtFName.Text = "";
            txtOrakh.Text = "";
            txtCardNo.Text = "";
            rdbCashE.Checked = true;
            rdbCashGe.Checked = true;
            rdbCashZa.Checked = true;
            txtForBth.Text = "";
            txtForCrtf.Text = "";
            txtForDth.Text = "";
            txtLagFor.Text = "";
            txtLateBirth.Text = "0.00";
            txtLateDeath.Text = "0.00";
            txtCrtfAmt.Text = "0.00";
            txtEducationFund.Text = "0.00";
            txtGeneralFund.Text = "0.00";
            txtLaagaEng.Text = "0.00";
            txtLaagaMrg.Text = "0.00";
            txtNewCard.Text = "0.00";
            txtLateBirth.Text = "0.00";
            txtPoorFund.Text = "0.00";
            txtQabristanFund.Text = "0.00";            
            txtReceivedFrom.Text = "";
            txtTameratiFund.Text = "0.00";
            txtTotal.Text = "0.00";
            txtZakatFund.Text = "0.00";
            cmbCrtfType.SelectedIndex = 0;
        }

        private void ReadOnly(bool A)
        {
            txtEducationFund.ReadOnly = A;
            txtEducationFund.ReadOnly = A;
            txtGeneralFund.ReadOnly = A;
            txtLaagaEng.ReadOnly = A;
            txtLaagaMrg.ReadOnly = A;
            txtNewCard.ReadOnly = A;
            txtLateBirth.ReadOnly = A;
            txtPoorFund.ReadOnly = A;
            txtQabristanFund.ReadOnly = A;
            txtReceiptNo.ReadOnly = A;
            txtReceivedFrom.ReadOnly = A;
            txtTameratiFund.ReadOnly = A;
            txtTotal.ReadOnly = A;
            txtZakatFund.ReadOnly = A;
            //dtpDate.Enabled = !A;
            //grbLink.Enabled = !A;
            txtFCardNo.ReadOnly = A;

        }

        private void Calculate()
        {
            if (txtLaagaEng.Text == "") { txtLaagaEng.Text = "0.00"; }
            if (txtLaagaMrg.Text == "") { txtLaagaMrg.Text = "0.00"; }
            if (txtPoorFund.Text == "") { txtPoorFund.Text = "0.00"; }
            if (txtZakatFund.Text == "") { txtZakatFund.Text = "0.00"; }
            if (txtQabristanFund.Text == "") { txtQabristanFund.Text = "0.00"; }
            if (txtGeneralFund.Text == "") { txtGeneralFund.Text = "0.00"; }
            if (txtEducationFund.Text == "") { txtEducationFund.Text = "0.00"; }
            if (txtTameratiFund.Text == "") { txtTameratiFund.Text = "0.00"; }
            if (txtNewCard.Text == "") { txtNewCard.Text = "0.00"; }
            if (txtLateBirth.Text == "") { txtLateBirth.Text = "0.00"; }            
            if (txtCrtfAmt.Text == "") { txtCrtfAmt.Text = "0.00"; }
            if (txtLateDeath.Text == "") { txtLateDeath.Text = "0.00"; }

            try
            {
                decimal LaagaEng = Convert.ToDecimal(txtLaagaEng.Text);
                decimal LaagaMrg = Convert.ToDecimal(txtLaagaMrg.Text);
                decimal Poor = Convert.ToDecimal(txtPoorFund.Text);
                decimal Zakat = Convert.ToDecimal(txtZakatFund.Text);
                decimal Qabristan = Convert.ToDecimal(txtQabristanFund.Text);
                decimal General = Convert.ToDecimal(txtGeneralFund.Text);
                decimal Education = Convert.ToDecimal(txtEducationFund.Text);
                decimal Tamerati = Convert.ToDecimal(txtTameratiFund.Text);
                decimal NewCard = Convert.ToDecimal(txtNewCard.Text);
                decimal Others = Convert.ToDecimal(txtLateBirth.Text);
                decimal CrtfAmt = Convert.ToDecimal(txtCrtfAmt.Text);                
                decimal LateDeath = Convert.ToDecimal(txtLateDeath.Text);
                decimal Total = 0;
                Total = LaagaEng + LaagaMrg + Poor + Zakat + Qabristan + General + Education + Tamerati + NewCard + Others + CrtfAmt + LateDeath;
                txtTotal.Text = Total.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill valid values in respective fields!", "Error", MessageBoxButtons.OK);
            }
        }

        private void fillAmt()
        {
            txtLaagaEng.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[6].Value).ToString("N2");
            txtLaagaMrg.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[7].Value).ToString("N2");
            txtPoorFund.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[8].Value).ToString("N2");
            txtZakatFund.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[9].Value).ToString("N2");
            txtQabristanFund.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[10].Value).ToString("N2");
            txtGeneralFund.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[11].Value).ToString("N2");
            txtEducationFund.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[12].Value).ToString("N2");
            txtTameratiFund.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[13].Value).ToString("N2");
            txtNewCard.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[14].Value).ToString("N2");
            txtLateBirth.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[15].Value).ToString("N2");
            txtLateDeath.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[16].Value).ToString("N2");            
            txtCrtfAmt.Text = Convert.ToDecimal(dgvDonation.CurrentRow.Cells[17].Value).ToString("N2");

            dtpDate.Value =Convert.ToDateTime( dgvDonation.CurrentRow.Cells[2].Value);
        }

        private bool AccountRelation()
        {
            bool result = false;
            if (rdbYes.Checked)
                result = true;
            else
                result = false;
            return result;
        }

        private bool Type_Edu()
        {
            bool result = false;
            if (rdbCashE.Checked)
                result = true;
            else
                result = false;
            return result;
        }

        private bool Type_Grnl()
        {
            bool result = false;
            if (rdbCashGe.Checked)
                result = true;
            else
                result = false;
            return result;
        }

        private bool Type_Zkt()
        {
            bool result = false;
            if (rdbCashZa.Checked)
                result = true;
            else
                result = false;
            return result;
        }


        private void txtFCardNo_Leave(object sender, EventArgs e)
        {
            //if (txtFCardNo.Text.Length != 5)
            //{
            //    txtFCardNo.Text = txtFCardNo.Text.PadLeft(5, '0');
            //}
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
            if (txtFCardNo.Text != "")
            {
                if (result)
                {

                    usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, txtFCardNo.Text);
                    txtFName.Text = FName(txtFCardNo.Text, txtHead.Text);
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
        }

        private void frmDonations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_Donation' table. You can move, or remove it, as needed.
            this.usp_SEL_DonationTableAdapter.Fill(comDataSet.usp_SEL_Donation);
            // TODO: This line of code loads data into the 'dataset3.tblDonAcc' table. You can move, or remove it, as needed.
            this.tblDonAccTableAdapter.Fill(this.dataset3.tblDonAcc);
            // TODO: This line of code loads data into the 'comDataSet.tblTransactions' table. You can move, or remove it, as needed.
            this.tblTransactionsTableAdapter.Fill(this.comDataSet.tblTransactions);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_Donation' table. You can move, or remove it, as needed.
            this.usp_SEL_DonationTableAdapter.Fill(this.comDataSet.usp_SEL_Donation);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_FAMILY' table. You can move, or remove it, as needed.           
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
            AcceptButton = btnAdd;

            dgvDonation.BringToFront();
            txtChqZa.Text = string.Empty;
        }

        private void txtLaagaEng_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtLaagaMrg_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtPoorFund_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtZakatFund_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtQabristanFund_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtGeneralFund_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtEducationFund_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtTameratiFund_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtNewCard_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtOthers_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Text = Header + " >> New Donation";
            Gayab(false);
            mode = 1;           
            txtReceiptNo.Focus();
            this.AcceptButton = btnSave;
            txtReceiptNo.Text = next().ToString("00000");
            for (int x = tabControl1.TabPages.Count; x > -1; x--)
            {
                tabControl1.SelectedIndex = x;
            }
            EmptyFields();
            txtChqZa.Text = string.Empty;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDonation.RowCount != 0)
            {
                Text = Header + " >> Modifing Donation";
                if (!rdbCashE.Checked)
                    rdbChqE.Checked = true;
                if (!rdbCashGe.Checked)
                    rdbChqGe.Checked = true;
                if (!rdbCashZa.Checked)
                    rdbChqZa.Checked = true;

                if (rdbYes.Checked == false)
                {
                    rdbNo.Checked = true;
                }
                mode = 0;
                txtFCardNo_Leave(sender, e);
                id = Convert.ToInt32(dgvDonation.CurrentRow.Cells[0].Value.ToString());
                fillAmt();
                Gayab(false);
                txtReceiptNo.Focus();
                this.AcceptButton = btnSave;
                btnReset.Hide();
                
            }
            else
                MessageBox.Show("No record to modify!","No record",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //bool result = DBLayer.CHK_ReceiptNo(txtReceiptNo.Text);
            try
            {
                decimal LaagaEng = Convert.ToDecimal(txtLaagaEng.Text);
                decimal LaagaMrg = Convert.ToDecimal(txtLaagaMrg.Text);
                decimal Poor = Convert.ToDecimal(txtPoorFund.Text);
                decimal Zakat = Convert.ToDecimal(txtZakatFund.Text);
                decimal Qabristan = Convert.ToDecimal(txtQabristanFund.Text);
                decimal General = Convert.ToDecimal(txtGeneralFund.Text);
                decimal Education = Convert.ToDecimal(txtEducationFund.Text);
                decimal Tamerati = Convert.ToDecimal(txtTameratiFund.Text);
                decimal NewCard = Convert.ToDecimal(txtNewCard.Text);
                decimal Others = Convert.ToDecimal(txtLateBirth.Text);
                decimal Total = Convert.ToDecimal(txtTotal.Text);
                string FCardNo = txtFCardNo.Text;
                string Mobile = txtMobile.Text;
                string ReceivedFrom = txtReceivedFrom.Text;
                int ReceiptNo =Convert.ToInt32(txtReceiptNo.Text);
                bool accountRelation = AccountRelation();
                DateTime Date = Convert.ToDateTime(dtpDate.Text);
                string Chq_Edu = txtChqE.Text;
                string Chq_Zkt = txtChqZa.Text;
                string chq_Gnrl = txtChqGe.Text;
                string Orakh = txtOrakh.Text;
                string FName = txtFName.Text;
                int LagaAcc=0, CardAcc=0, EduAcc=0, GenAcc=0, OtherAcc=0, PoorAcc=0, QabAcc = 0, TamAcc = 0, ZakAcc = 0;
                if (cmbAccLaga.SelectedValue != null)
                {
                    LagaAcc = Convert.ToInt32(cmbAccLaga.SelectedValue);
                }
                if (cmbCardAcc.SelectedValue != null)
                {
                    CardAcc = Convert.ToInt32(cmbCardAcc.SelectedValue);
                }
                if (cmbEduAcc.SelectedValue != null)
                {
                    EduAcc = Convert.ToInt32(cmbEduAcc.SelectedValue);
                }
                if (cmbGenAcc.SelectedValue != null)
                {
                    GenAcc = Convert.ToInt32(cmbGenAcc.SelectedValue);
                }
                if (cmbOtherAcc.SelectedValue != null)
                {
                    OtherAcc = Convert.ToInt32(cmbOtherAcc.SelectedValue);
                }
                if (cmbPoorAcc.SelectedValue != null)
                {
                    PoorAcc = Convert.ToInt32(cmbPoorAcc.SelectedValue);
                }
                if (cmbQabAcc.SelectedValue != null)
                {
                    QabAcc = Convert.ToInt32(cmbQabAcc.SelectedValue);
                }
                if (cmbTamAcc.SelectedValue != null)
                {
                    TamAcc = Convert.ToInt32(cmbTamAcc.SelectedValue);
                }
                if (cmbZakAcc.SelectedValue != null)
                {
                    ZakAcc = Convert.ToInt32(cmbZakAcc.SelectedValue);
                }
                string ForLaaga = txtLagFor.Text;
                decimal LateDeath = Convert.ToDecimal(txtLateDeath.Text);
                decimal CrtfAmt = Convert.ToDecimal(txtCrtfAmt.Text);
                string CrtfType = cmbCrtfType.Text;
                string CrtfFor = txtForCrtf.Text;
                int AccCrtf = Convert.ToInt32(cmbAccCrtf.SelectedValue);
                //decimal AdvAmt = Convert.ToDecimal(txtAdvance.Text);
                //string AdvType = txtAdvType.Text;
                //int AccAdv = Convert.ToInt32(cmbAdvAcc.SelectedValue);
                string ForDeath = txtForDth.Text;
                string ForBirht = txtForBth.Text;
                string CardNo = "";
                if (txtCardNo.Text != "")
                    CardNo = Convert.ToInt32(txtCardNo.Text).ToString("00000");

                int gsAccount, pfAccount, EduAccount;
                gsAccount = 115;
                pfAccount = 117;
                EduAcc = 118;
               
                if (CheckFields())
                {
                    if (mode == 1)
                    {
                        if (/*result*/ 1 != 1) 
                        {
                            MessageBox.Show("Receipt Number Already exist!!!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            usp_SEL_DonationTableAdapter.ADD(/*ReceiptNo.ToString("00000")*/next().ToString("00000"), Date, ReceivedFrom, LaagaEng, LaagaMrg, Poor, Zakat, Qabristan, General, Education, Tamerati, NewCard, Others, AccountRelation(), FCardNo, Total, Orakh, FName, Type_Zkt(), Type_Grnl(), Type_Edu(), Chq_Zkt, chq_Gnrl, Chq_Edu, LagaAcc, PoorAcc, EduAcc, QabAcc, TamAcc, ZakAcc, CardAcc, GenAcc, OtherAcc, ForLaaga, LateDeath, CrtfAmt, CrtfType, AccCrtf, ForBirht, ForDeath, CrtfFor, CardNo, Mobile);
                            MessageBox.Show("Saved Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                            
                            usp_SEL_DonationTableAdapter.Fill(comDataSet.usp_SEL_Donation);


                            /*tblTransactionsTableAdapter.InsertTransaction(MCKJ.frmHallBoking.HRD("Donation"), "DON", ReceiptNo, Date, 0, Total, "Receipt = " + ReceiptNo, "", "");*/
                            tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, LaagaEng + LaagaMrg, 0, "For Laaga ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(pfAccount, "DON", ReceiptNo, Date, Poor, 0, "For Poor Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, Qabristan, 0, "For Qabristan Fund ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, General, 0, "For General Donation ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(pfAccount, "DON", ReceiptNo, Date, Zakat, 0, "For Zakat Fund ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, Others + Convert.ToDecimal(txtLateDeath.Text), 0, "For Others Donations ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, Tamerati, 0, "For Tamerati Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(EduAcc, "DON", ReceiptNo, Date, Education, 0, "For Education Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, NewCard, 0, "For New Card, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                            tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, CrtfAmt, 0, "For Certificate Issue, Receipt = " + ReceiptNo.ToString("00000"), "", "");                                                          

                            mode = 0;
                            Gayab(true);
                            txtFilter.Focus();
                            this.AcceptButton = btnAdd;
                            EmptyFields();
                        }
                    }
                    else if (mode == 0)
                    {
                        int transID = TransactionID(ReceiptNo);
                        tblTransactionsTableAdapter.DeleteTransactions("DON", ReceiptNo);

                        usp_SEL_DonationTableAdapter.UPDATE(ReceiptNo.ToString("00000"), Date, ReceivedFrom, LaagaEng, LaagaMrg, Poor, Zakat, Qabristan, General, Education, Tamerati, NewCard, Others, AccountRelation(), FCardNo, Total, Orakh, FName, Type_Zkt(), Type_Grnl(), Type_Edu(), Chq_Zkt, chq_Gnrl, Chq_Edu, LagaAcc, PoorAcc, EduAcc, QabAcc, TamAcc, ZakAcc, CardAcc, GenAcc, OtherAcc, ForLaaga, LateDeath, CrtfAmt, CrtfType, AccCrtf, ForBirht, ForDeath, CrtfFor, CardNo, Mobile, id);
                        MessageBox.Show("Saved Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, LaagaEng + LaagaMrg, 0, "For Laaga ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(pfAccount, "DON", ReceiptNo, Date, Poor, 0, "For Poor Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, Qabristan, 0, "For Qabristan Fund ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, General, 0, "For General Donation ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(pfAccount, "DON", ReceiptNo, Date, Zakat, 0, "For Zakat Fund ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, Others + Convert.ToDecimal(txtLateDeath.Text), 0, "For Others Donations ,Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, Tamerati, 0, "For Tamerati Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(EduAcc, "DON", ReceiptNo, Date, Education, 0, "For Education Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, NewCard, 0, "For New Card, Receipt = " + ReceiptNo.ToString("00000"), "", "");
                        tblTransactionsTableAdapter.InsertTransaction(gsAccount, "DON", ReceiptNo, Date, CrtfAmt, 0, "For Certificate Issue, Receipt = " + ReceiptNo.ToString("00000"), "", ""); 


                        /*tblTransactionsTableAdapter.UpdateTransaction(MCKJ.frmHallBoking.HRD("Donation"), "DON", ReceiptNo, Date, 0, Total, "Receipt = " + ReceiptNo, "", "",transID);
                        tblTransactionsTableAdapter.UpdateTransaction(LagaAcc, "DON", ReceiptNo, Date, LaagaEng + LaagaMrg, 0, "For Laaga ,Receipt = " + ReceiptNo.ToString("00000"), "", "",transID + 1);
                        tblTransactionsTableAdapter.UpdateTransaction(PoorAcc, "DON", ReceiptNo, Date, Poor, 0, "For Poor Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "", transID + 2);
                        tblTransactionsTableAdapter.UpdateTransaction(QabAcc, "DON", ReceiptNo, Date, Qabristan, 0, "For Qabristan Fund ,Receipt = " + ReceiptNo.ToString("00000"), "", "", transID + 3);
                        tblTransactionsTableAdapter.UpdateTransaction(GenAcc, "DON", ReceiptNo, Date, General, 0, "For General Donation ,Receipt = " + ReceiptNo.ToString("00000"), "", "", transID + 4);
                        tblTransactionsTableAdapter.UpdateTransaction(ZakAcc, "DON", ReceiptNo, Date, Zakat, 0, "For Zakat Fund ,Receipt = " + ReceiptNo.ToString("00000"), "", "", transID + 5);
                        tblTransactionsTableAdapter.UpdateTransaction(OtherAcc, "DON", ReceiptNo, Date, Others, 0, "For Others Donations ,Receipt = " + ReceiptNo.ToString("00000"), "", "", transID + 6);
                        tblTransactionsTableAdapter.UpdateTransaction(TamAcc, "DON", ReceiptNo, Date, Tamerati, 0, "For Tamerati Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "", transID + 7);
                        tblTransactionsTableAdapter.UpdateTransaction(EduAcc, "DON", ReceiptNo, Date, Education, 0, "For Education Fund, Receipt = " + ReceiptNo.ToString("00000"), "", "",transID + 8);
                        tblTransactionsTableAdapter.UpdateTransaction(CardAcc, "DON", ReceiptNo, Date, NewCard, 0, "For New Card, Receipt = " + ReceiptNo.ToString("00000"), "", "", transID + 9);                        
                        tblTransactionsTableAdapter.UpdateTransaction(AccCrtf, "DON", ReceiptNo, Date, CrtfAmt, 0, "For Certificate Issue, Receipt = " + ReceiptNo.ToString("00000"), "", "",transID + 11);
                        usp_SEL_DonationTableAdapter.Fill(comDataSet.usp_SEL_Donation);*/
                        Gayab(true);
                        txtFilter.Focus();
                        this.AcceptButton = btnAdd;
                        btnReset.Show();
                        EmptyFields();
                    }
                    Text = Header;
                    btnPrint_Click(null, null);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill valid values in respective fields!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (mode == 3)
            {
                ReadOnly(false);
                Gayab(true);
                btnSave.Show();
                btnCancel.Show();
                btnReset.Show();
                btnClose.Show();
                mode = 0;
            }
            else
                this.Close();

            Text = Header;
        }

        private void txtReceiptNo_Leave(object sender, EventArgs e)
        {
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
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int DocumentNo =Convert.ToInt32(dgvDonation.CurrentRow.Cells[1].Value.ToString());
            if (dgvDonation.RowCount != 0)
            {
                Text = Header + " >> Deleting";
                DialogResult result = MessageBox.Show("Are you sure???", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dgvDonation.CurrentRow.Cells[0].Value.ToString());
                    usp_SEL_DonationTableAdapter.DELETE(ID);
                    tblTransactionsTableAdapter.DeleteTransactions("DON", DocumentNo);
                    MessageBox.Show("Deleted Succesfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    usp_SEL_DonationTableAdapter.Fill(comDataSet.usp_SEL_Donation);
                    Text = Header;
                }
                else
                    Text = Header;
            }

            else
                MessageBox.Show("No Record for Deleting!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure???", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Gayab(true);
                usp_SEL_DonationTableAdapter.Fill(comDataSet.usp_SEL_Donation);
                mode = 0;
                txtFilter.Focus();
                this.AcceptButton = btnAdd;
                btnReset.Show();               
                Text = Header;
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (rdbYes.Checked == false)
            {
                rdbNo.Checked = true;
            }
            txtFCardNo_Leave(sender, e);
            ReadOnly(true);
            Gayab(false);
            btnSave.Hide();
            btnCancel.Hide();
            btnReset.Hide();
            btnClose.Show();
            mode = 3;
            Text = Header + " >> Preivew";
            if (!rdbCashE.Checked)
                rdbChqE.Checked = true;
            if (!rdbCashG.Checked)
                rdbChqG.Checked = true;
            if (!rdbCashZ.Checked)
                rdbChqZ.Checked = true;
        }       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtFilter_Leave(sender, e);
            try
            {
                
                uspSELDonationBindingSource.Filter = "ReceiptNo='" + txtFilter.Text + "'";
                AcceptButton = btnEdit;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill valid values in respetive fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;
            if (txtFilter.Text == "")
            {
                uspSELDonationBindingSource.Filter = "";
                AcceptButton = btnAdd;
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text != "")
                {
                    int fcardno = Convert.ToInt32(txtFilter.Text);
                    int x = 5 - txtFilter.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    txtFilter.Text = zeros + txtFilter.Text;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to print this report?", "Donation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (dgvDonation.Rows.Count != 0)
                {
                    int id = Convert.ToInt32(dgvDonation.CurrentRow.Cells[0].Value.ToString());
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    con.Open();
                    string query = "";

                    if (dgvDonation.CurrentRow.Cells[3].Value.ToString() == "")
                        query = "Select * , Cast(0 AS varchar(50)) MemberName From tblDonations WHERE ID =" + id;
                    else
                        query = "Select *,tblFamily.FamilyLeader AS MemberName from tblDonations INNER JOIN tblFamily ON tblDonations.FCardNo = tblFamily.FCardNo WHERE ID =" + id;

                    SqlCommand cmd = new SqlCommand(query, con);

                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;

                    da.Fill(dt);
                    Reports.Donation.frmViewer frm = new MCKJ.Reports.Donation.frmViewer();
                    Reports.Donation.rptDonation rpt = new MCKJ.Reports.Donation.rptDonation();

                    frm.crystalReportViewer1.ReportSource = rpt;

                    rpt.SetDataSource(dt);
                    frm.Show();
                    con.Close();
                }
                else
                    MessageBox.Show("No record to print!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbCashE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCashE.Checked)
                txtChqE.Enabled = false;
            else
                txtChqE.Enabled = true;
        }

        private void rdbCashZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCashZa.Checked)
                txtChqZa.Enabled = false;
            else
                txtChqZa.Enabled = true;
        }

        private void rdbCashG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCashGe.Checked)
                txtChqGe.Enabled = false;
            else
                txtChqGe.Enabled = true;
        }

        private void txtCrtfAmt_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtLateDeath_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    } 
}