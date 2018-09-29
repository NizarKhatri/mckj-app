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
    public partial class frmEngagement : Form
    {
        public frmEngagement()
        {
            InitializeComponent();
        }

        // Variables-------------------------------------------
        // ---------------------------------------------------

        int mode = 0;
        int exit = 0;
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 6;
        string odSerial = "";


        // Functions -----------------------------------------
        // ---------------------------------------------------

        private int next()
        {
            object value;
            int nextt = 0;
            SqlConnection con = new SqlConnection(DBLayer.CON_string);
            SqlCommand cmd = new SqlCommand("Select Max(Cast(SerialNo as int)) From tblEngagement", con);

            con.Open();
            value = cmd.ExecuteScalar();
            if (value == DBNull.Value)
            {
                value = 0;
            }
            nextt = Convert.ToInt32(value) + 1;

            return nextt;

        }

        private void updateMrgSerial(string oldS, string newS)
        {
            SqlConnection con = new SqlConnection(DBLayer.CON_string);
            con.Open();

            SqlCommand cmd = new SqlCommand("Update tblMarriage Set SerialNo = '" + newS + "' Where SerialNo = '" + oldS + "'", con);
            cmd.ExecuteNonQuery();

        }

        private bool ChkAvtiveEngagement()
        {
            bool Cancel = false;
            if (chkCancel.Checked)
                Cancel = true;
            else
                Cancel = false;
            return Cancel;
        }

        private bool ChkAvtiveMarriage()
        {
            bool Cancel = false;
            if (chkMarried.Checked)
                Cancel = true;
            else
                Cancel = false;
            return Cancel;
        }

        private bool ChkMarriage()
        {
            bool Cancel = false;
            if (txtChk.Text == "True")
                Cancel = true;
            else
                Cancel = false;
            return Cancel;
        }

        private void EmptyField()
        {
            txtDobF.Text = "";
            txtDobM.Text = "";
            txtFCardNoF.Text = "";
            txtFCardNoM.Text = "";
            txtFNameF.Text = "";
            txtFNameM.Text = "";
            txtName.Text = "MUTUAL CONSENT";
            txtNukhF.Text = "";
            txtNukhM.Text = "";
            txtOrakhF.Text = "";
            txtOrakhM.Text = "";
            txtSerialNo.Text = "";
            dpDate.Text = "";
            txtMMeritalStatus.Text = "";
            txtMOutOf.Text = "";
            txtFMeritalStatus.Text = "";
            txtFOutOf.Text = "";
            //cmbDay.Text = "";
            //cmbMonth.Text = "";
            //cmbYear.Text = "";
            dtpEngDate.Text = null;
            cmbNameF.Text = null;
            cmbNameM.Text = null;
            dtpEngDate.Text = DateTime.Now.ToShortDateString();
            dpMarriage.Text = DateTime.Now.ToShortDateString();
            txtGFNameF.Text = "";
            txtGFNameM.Text = "";
            dtpDOBF.Text = DateTime.Now.ToString();
            dtpDOBM.Text = DateTime.Now.ToString();
            txtAgeF.Text = "";
            txtAgeM.Text = "";

        }

        private void Hide(bool A)
        {
            dgEngagement.Visible = A;
            btnAdd.Enabled = A;
            btnEdit.Enabled = A;
            btnView.Enabled = A;
            btnDelete.Enabled = A;
            btnMarriage.Enabled = A;
            grb1.Enabled = A;
            btnCEngagement.Enabled = A;
            cmbFilter.Enabled = A;
            //btnClose.Enabled = A;
            btnPrint.Enabled = A;
        }

        private void Readonly(bool B)
        {
            // txtDateAction.ReadOnly = B;           
            txtFCardNoF.Enabled = B;
            txtFCardNoM.Enabled = B;
            txtName.Enabled = B;
            txtSerialNo.Enabled = B;
        }

        private void Enabled1(bool C)
        {
            //cmbDay.Visible = C;
            //cmbMonth.Visible = C;
            cmbNameF.Enabled = C;
            cmbNameM.Enabled = C;
            //cmbYear.Visible = C;
            //lbl2.Visible = C;
            //lbl3.Visible = C;
            //lbl4.Visible = C;



        }

        private void OnView(bool D)
        {
            dgEngagement.Visible = D;
            cmbFilter.Enabled = D;
            btnSaveMarriage.Visible = D;
            btnEditMarriage.Visible = D;
            btnMarriageView.Visible = D;
            btnCMarriage.Visible = D;
            //lbl2.Visible = D;
            //lbl3.Visible = D;
            //lbl4.Visible = D;
            //cmbDay.Visible = D;
            //cmbMonth.Visible = D;
            //cmbYear.Visible = D;            
            cmbNameF.Enabled = D;
            cmbNameM.Enabled = D;



        }

        private bool CheckField()
        {
            if (chkMaleOutsideKarachi.Checked == true || chkFemaleOutsideKarachi.Checked == true)
                return true;
            else
            {
                if (txtSerialNo.Text == "" || txtFCardNoM.Text == "" || txtFCardNoF.Text == "")
                {
                    //txtDateAction.Hide();
                    MessageBox.Show("Required field could be not left Blank", "Error");
                    return false;

                }
                else
                    return true;
            }
        }

        // Work Station---------------------------------------------
        // --------------------------------------------------------

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (exit == 1)
            {
                grbMarriage.Text = "MARRIAGE DATE";
                lbl8.Show();
                lbl9.Show();
                dpMarriage.Show();
                dpEntryDate.Show();
                OnView(true);
                exit = 0;
                btnCMarriage.Show();
                chkMarried.Show();
                btnClose2.Text = "Hide";
                btnSubmit.Enabled = true;
                btnReset.Enabled = true;
                btnCancel.Enabled = true;
                grbMarriage.Enabled = false;

            }
            else
                this.Close();

            grbMarriage.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = 1;
            EmptyField();
            Hide(false);
            grb1.Show();
            btnReset.Show();
            Readonly(true);
            txtSerialNo.Focus();
            this.AcceptButton = btnSubmit;
            lbl.Text = "Engagement>>Adding";
            txtSerialNo.Text = next().ToString("00000");


        }

        private void frmEngagement_Load(object sender, EventArgs e)
        {
            dgEngagement.BringToFront();
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
            {
                btnEdit.Enabled = true;
                btnSaveMarriage.Enabled = true;
                btnCEngagement.Enabled = true;
                btnCMarriage.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnSaveMarriage.Enabled = false;
                btnCEngagement.Enabled = false;
                btnCMarriage.Enabled = false;
            }
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
            {
                btnAdd.Enabled = true;
                btnMarriage.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnMarriage.Enabled = false;
            }

            cmbFilter.Text = "All";

            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_Engagement' table. You can move, or remove it, as needed.
            this.usp_SEL_EngagementTableAdapter.Fill(this.comDataSet.usp_SEL_Engagement);

            // TODO: This line of code loads data into the 'comDataSet1.usp_SEL_Marriage' table. You can move, or remove it, as needed.            
            this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);

            if (dgEngagement.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnView.Enabled = false;
                btnDelete.Enabled = false;
                btnMarriage.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnView.Enabled = true;
                btnDelete.Enabled = true;
                btnMarriage.Enabled = true;
            }
            btnAdd.Focus();
            this.AcceptButton = btnAdd;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgEngagement.Rows.Count != 0)
            {

                //txtDateAction.Show();
                btnReset.Hide();
                Hide(false);
                grb1.Show();
                odSerial = dgEngagement.CurrentRow.Cells[0].Value.ToString();
                //txtSerialNo.ReadOnly = true;
                //string[] Day = txtDateAction.Text.Split(Convert.ToChar(" "));
                //cmbDay.Text = Day[0].ToString();
                //cmbMonth.Text = Day[1].ToString();
                //cmbYear.Text = Day[2].ToString();
                //txtDateAction.Hide();               
                this.AcceptButton = btnSubmit;
                //txtFCardNoM.Focus();                               
                lbl.Text = "Engagement>>Modifing";
                string fcm = dgEngagement.CurrentRow.Cells[7].Value.ToString();
                usp_Male_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_Male_tblFamilyMember, fcm, "Male");
                string fcf = dgEngagement.CurrentRow.Cells[8].Value.ToString();
                usp_Female_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_Female_tblFamilyMember, fcf, "Female");

                cmbNameM.Text = dgEngagement.CurrentRow.Cells[1].Value.ToString();
                cmbNameF.Text = dgEngagement.CurrentRow.Cells[3].Value.ToString();
                txtSerialNo.Focus();

            }
            else
                MessageBox.Show("No Records for Modify!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //txtDateAction.Show();
            try
            {
                string Serial = txtSerialNo.Text;
                DateTime Date = Convert.ToDateTime(dpDate.Text);
                string FCardM = txtFCardNoM.Text;
                string FCardF = txtFCardNoF.Text;
                string NukhM = txtNukhM.Text;
                string NukhF = txtNukhF.Text;
                string OrakhM = txtOrakhM.Text;
                string OrakhF = txtOrakhF.Text;
                string FNameF = txtFNameF.Text;
                string FNameM = txtFNameM.Text;
                string AgeM = txtAgeM.Text;
                string AgeF = txtAgeF.Text;
                string ArrangeBy = txtName.Text;
                DateTime Action = Convert.ToDateTime(dtpEngDate.Text);
                string NameM = cmbNameM.Text;
                string NameF = cmbNameF.Text;
                bool Active = ChkAvtiveEngagement();
                bool Marriage = ChkMarriage();
                string GFNameM = txtGFNameM.Text;
                string GFNameF = txtGFNameF.Text;


                bool Result = DBLayer.CHK_Serial(txtSerialNo.Text);
                if (CheckField())
                {
                    //txtDateAction.Show();
                    if (mode == 1)
                    {
                        if (Result)
                            MessageBox.Show("Serial Already exist!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            usp_SEL_EngagementTableAdapter.Insert1(Serial, Date, FCardM, NukhM, OrakhM, NameM, FNameM, GFNameM, AgeM, FCardF, NukhF, OrakhF, NameF, FNameF, GFNameF, AgeF, ArrangeBy, Action, Marriage, true);
                            //txtDateAction.Hide();                                                    
                            MessageBox.Show("Saved Successfully!", "Success");
                            Hide(true);
                            mode = 0;
                            grb1.Hide();
                            this.usp_SEL_EngagementTableAdapter.Fill(this.comDataSet.usp_SEL_Engagement);
                            this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, Serial);
                        }
                    }

                    else if (mode == 0)
                    {

                        if (odSerial == Serial || Result == false)
                        {
                            usp_SEL_EngagementTableAdapter.Update1(Serial, Date, FCardM, NukhM, OrakhM, NameM, FNameM, GFNameM, AgeM, FCardF, NukhF, OrakhF, NameF, FNameF, GFNameF, AgeF, ArrangeBy, Action, Marriage, Active, odSerial);
                            updateMrgSerial(odSerial, Serial);
                            MessageBox.Show("Modified Successfully!", "Success");
                            Hide(true);
                            btnReset.Show();
                            txtSerialNo.ReadOnly = false;
                            grb1.Hide();
                            this.usp_SEL_EngagementTableAdapter.Fill(this.comDataSet.usp_SEL_Engagement);
                            this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, Serial);
                        }
                        else
                            MessageBox.Show("Serial Already exist!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnAdd.Focus();
            this.AcceptButton = btnAdd;
            lbl.Text = "Engagement";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);
                this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
                Hide(true);
                txtSerialNo.ReadOnly = false;
                grb1.Hide();
                mode = 0;
                btnAdd.Focus();
                this.AcceptButton = btnAdd;
                lbl.Text = "Engagement";

            }
        }

        private void txtFCardNoM_Leave(object sender, EventArgs e)
        {

            try
            {
                if (txtFCardNoM.Text != "")
                {

                    int fcardno = Convert.ToInt32(txtFCardNoM.Text);
                    int x = 5 - txtFCardNoM.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    txtFCardNoM.Text = zeros + txtFCardNoM.Text;
                    bool result = DBLayer.CheckFamily(txtFCardNoM.Text);
                    if (result)
                    {
                        if (cmbNameM.Focus())
                            cmbNameM.DropDownStyle = ComboBoxStyle.DropDownList;

                        usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, txtFCardNoM.Text);
                        string name = cmbNameM.Text;
                        usp_Male_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_Male_tblFamilyMember, txtFCardNoM.Text, "Male");
                        cmbNameM.Text = name;
                        this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
                        txtNukhM.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[18].ToString();
                        txtOrakhM.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[17].ToString();
                        cmbNameM_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Card does not exist! Please enter other card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFCardNoM.Focus();
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only Numbers are allowed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFCardNoM.Focus();

            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkMaleOutsideKarachi.Checked = false;
            chkMaleOutsideKarachi_CheckedChanged(sender, e);
            chkFemaleOutsideKarachi.Checked = false;
            chkFemaleOutsideKarachi_CheckedChanged(sender, e);

            EmptyField();
        }

        private void txtFCardNoF_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtFCardNoF.Text != "")
                {
                    int fcardno = Convert.ToInt32(txtFCardNoF.Text);
                    int x = 5 - txtFCardNoF.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    txtFCardNoF.Text = zeros + txtFCardNoF.Text;
                    bool result = DBLayer.CheckFamily(txtFCardNoF.Text);
                    if (result)
                    {
                        if (cmbNameF.Focus())
                            cmbNameF.DropDownStyle = ComboBoxStyle.DropDownList;

                        usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, txtFCardNoF.Text);
                        string name = cmbNameF.Text;
                        usp_Female_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_Female_tblFamilyMember, txtFCardNoF.Text, "Female");
                        this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
                        cmbNameF.Text = name;
                        txtNukhF.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[18].ToString();
                        txtOrakhF.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[17].ToString();
                        cmbNameF_SelectedIndexChanged(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Card does not exist! Please enter other card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFCardNoF.Focus();
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only Numbers are allowed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFCardNoF.Focus();

            }
        }

        private void cmbNameM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SET AGE IN YEAR AND MONTH
            if (cmbNameM.Items.Count != 0)
            {
                string A = txtDobM.Text.Length.ToString();
                if (txtDobM.Text != "")
                {
                    if (Convert.ToInt32(A) == 4)
                    {
                        int Year = DateTime.Now.Year;
                        string DOBYear = txtDobM.Text.ToString();
                        int AgeYear = Year - Convert.ToInt32(DOBYear);
                        txtAgeM.Text = AgeYear.ToString();
                    }
                    else
                    {
                        DateTime DOB = Convert.ToDateTime(txtDobM.Text);

                        int year = DateTime.Now.Year - DOB.Year;
                        int month = DateTime.Now.Month - DOB.Month;

                        if (month < 0)
                        {
                            year = year - 1;
                            month = month + 12;
                        }

                        txtAgeM.Text = year.ToString() + " yr and " + month.ToString() + " months";
                    }
                }
            }
            //cmbNameM.DropDownStyle = ComboBoxStyle.Simple;
            //txtFCardNoF.Focus();

            if (cmbNameM.Items.Count != 0)
            {
                if (cmbNameM.SelectedIndex != -1)
                {
                    txtFNameM.Text = comDataSet.usp_Male_tblFamilyMember.Rows[cmbNameM.SelectedIndex].ItemArray[4].ToString();
                    txtDobM.Text = comDataSet.usp_Male_tblFamilyMember.Rows[cmbNameM.SelectedIndex].ItemArray[26].ToString();
                    txtMMeritalStatus.Text = comDataSet.usp_Male_tblFamilyMember.Rows[cmbNameM.SelectedIndex].ItemArray[23].ToString();
                    txtMOutOf.Text = comDataSet.usp_Male_tblFamilyMember.Rows[cmbNameM.SelectedIndex].ItemArray[24].ToString();
                    usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, txtFCardNoM.Text, txtFNameM.Text);

                    if (comDataSet.usp_SEL_TSF_tblFamilyMember.Rows.Count != 0)
                    {
                        txtGFNameM.Text = comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[4].ToString();
                    }
                    else
                    {
                        txtGFNameM.Text = "";
                    }
                }
            }
            else
                MessageBox.Show("There is no member in current card please enter other card!", "No member");
        }

        private void cmbNameF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameF.Items.Count != 0)
            {
                string A = txtDobF.Text.Length.ToString();
                if (txtDobF.Text != "")
                {
                    if (Convert.ToInt32(A) == 4)
                    {
                        int Year = DateTime.Now.Year;
                        string DOBYear = txtDobF.Text.ToString();
                        int AgeYear = Year - Convert.ToInt32(DOBYear);
                        txtAgeF.Text = AgeYear.ToString();
                    }
                    else
                    {
                        DateTime DOB = Convert.ToDateTime(txtDobF.Text);

                        int year = DateTime.Now.Year - DOB.Year;
                        int month = DateTime.Now.Month - DOB.Month;

                        if (month < 0)
                        {
                            year = year - 1;
                            month = month + 12;
                        }

                        txtAgeF.Text = year.ToString() + " yr and " + month.ToString() + " months";
                    }
                }
            }
            //dtpEngDate.Focus();
            //cmbNameF.DropDownStyle = ComboBoxStyle.Simple;
            if (cmbNameF.Items.Count != 0)
            {
                if (cmbNameF.SelectedIndex != -1)
                {
                    txtFNameF.Text = comDataSet.usp_Female_tblFamilyMember.Rows[cmbNameF.SelectedIndex].ItemArray[4].ToString();
                    txtDobF.Text = comDataSet.usp_Female_tblFamilyMember.Rows[cmbNameF.SelectedIndex].ItemArray[6].ToString();
                    usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, txtFCardNoF.Text, txtFNameF.Text);
                    if (comDataSet.usp_SEL_TSF_tblFamilyMember.Rows.Count != 0)
                    {
                        txtGFNameF.Text = comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[4].ToString();
                    }
                    else
                    {
                        txtGFNameF.Text = "";
                    }
                }
            }
            else
                MessageBox.Show("There is no member in current card please enter other card!", "No member");
        }

        //private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtDateAction.Text = cmbDay.Text + " " + cmbMonth.Text + " " + cmbYear.Text;
        //}

        //private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtDateAction.Text = cmbDay.Text + " " + cmbMonth.Text + " " + cmbYear.Text;
        //}

        //private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtDateAction.Text = cmbDay.Text + " " + cmbMonth.Text + " " + cmbYear.Text;
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgEngagement.Rows.Count != 0)
            {
                lbl.Text = "Engagement>>Deleting";
                DialogResult Result = MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    usp_SEL_EngagementTableAdapter.Delete1(txtSerialNo.Text);
                    usp_SEL_MarriageTableAdapter.Delete1(txtSerialNo.Text);
                    MessageBox.Show("Succesfully Deleted!", "Success");
                    usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);
                    this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
                    lbl.Text = "Engagement";
                }
                else
                    lbl.Text = "Engagement";


            }
            else
                MessageBox.Show("No record for delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMarriage_Click(object sender, EventArgs e)
        {
            if (txtChk.Text == "False")
            {
                btnEditMarriage.Enabled = false;
                tip1.Show("Not Married Yet", grbMarriage);
            }
            else
                btnEditMarriage.Enabled = true;

            grbMarriage.Enabled = true;
            odSerial = dgEngagement.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            if (exit == 1)
            {
                grbMarriage.Text = "MARRIAGE DATE";
                lbl8.Show();
                lbl9.Show();
                dpMarriage.Show();
                dpEntryDate.Show();
                OnView(true);
                exit = 0;
                btnCMarriage.Show();
                chkMarried.Show();
                btnClose2.Text = "Hide";



            }
            grbMarriage.Enabled = false;
        }

        private void btnSaveMarriage_Click(object sender, EventArgs e)
        {
            try
            {
                //txtDateAction.Show();
                string Serial = txtSerialNo.Text;
                DateTime Date1 = Convert.ToDateTime(dpDate.Text);
                DateTime Date = Convert.ToDateTime(dpMarriage.Text);
                //TimeSpan
                DateTime EntryDate = Convert.ToDateTime(dpEntryDate.Text);
                string FCardM = txtFCardNoM.Text;
                string FCardF = txtFCardNoF.Text;
                string NukhM = txtNukhM.Text;
                string NukhF = txtNukhF.Text;
                string OrakhM = txtOrakhM.Text;
                string OrakhF = txtOrakhF.Text;
                string FNameF = txtFNameF.Text;
                string FNameM = txtFNameM.Text;
                string GFNameM = txtGFNameM.Text;
                string GFNameF = txtGFNameF.Text;
                string AgeM = txtAgeM.Text;
                string AgeF = txtAgeF.Text;
                DateTime Action = Convert.ToDateTime(dtpEngDate.Text);
                string NameM = cmbNameM.Text;
                string NameF = cmbNameF.Text;
                bool Marriage = true;
                string ArrangeBy = txtName.Text;
                bool Active = ChkAvtiveEngagement();
                string atTime = cmbAt.Text;


                bool result = DBLayer.CHK_Serial_Marriage(txtSerialNo.Text);
                if (result)
                {
                    MessageBox.Show("Already Married!", "Error");
                    btnClose2_Click(sender, e);
                }
                else
                {
                    usp_SEL_MarriageTableAdapter.Insert1(Serial, Date, EntryDate, FCardM, NukhM, OrakhM, NameM, FNameM, GFNameM, AgeM, FCardF, NukhF, OrakhF, NameF, FNameF, GFNameF, AgeF, Action, true, atTime);
                    usp_SEL_EngagementTableAdapter.Update1(Serial, Date1, FCardM, NukhM, OrakhM, NameM, FNameM, GFNameM, AgeM, FCardF, NukhF, OrakhF, NameF, FNameF, GFNameF, AgeF, ArrangeBy, Action, Marriage, Active, odSerial);
                    updateMrgSerial(odSerial, Serial);
                    //txtDateAction.Hide();
                    MessageBox.Show("Succesfully Saved!", "Success");
                    this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
                    this.usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);
                    btnClose2_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtSerialNo_Leave(object sender, EventArgs e)
        {
            if (txtSerialNo.Text != "")
            {
                try
                {
                    int SerialNo = Convert.ToInt32(txtSerialNo.Text);
                    int y = 5 - txtSerialNo.TextLength;
                    string zeros = "";
                    for (int i = 0; i < y; i++)
                    {
                        zeros += "0";
                    }
                    txtSerialNo.Text = zeros + txtSerialNo.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Only Numbers are allowed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSerialNo.Focus();
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            btnClose2.Focus();
            if (txtChk.Text == "False")
            {
                grbMarriage.Text = "NOT MARRIED YET";
                lbl8.Hide();
                lbl9.Hide();
                dpMarriage.Hide();
                dpEntryDate.Hide();
                btnCMarriage.Hide();
                chkMarried.Hide();
                Hide(true);
                btnSubmit.Enabled = false;
                btnReset.Enabled = false;
                btnCancel.Enabled = false;


            }
            else
            {
                grbMarriage.Text = "MARRIAGE INFORMATION";

            }
            OnView(false);
            //txtDateAction.Show();
            exit = 1;
            //lbl1.Show();
            grbMarriage.Enabled = true;
            Readonly(false);
            btnClose2.Text = "Close";
            Hide(true);
            dgEngagement.Hide();


        }

        private void cmbNameM_Leave(object sender, EventArgs e)
        {
            if (cmbNameM.Items.Count != 0)
            {
                string A = txtDobM.Text.Length.ToString();
                if (txtDobM.Text != "")
                {
                    if (Convert.ToInt32(A) == 4)
                    {
                        int Year = DateTime.Now.Year;
                        string DOBYear = txtDobM.Text.ToString();
                        int AgeYear = Year - Convert.ToInt32(DOBYear);
                        txtAgeM.Text = AgeYear.ToString();
                    }
                    else
                    {
                        DateTime DOB = Convert.ToDateTime(txtDobM.Text);

                        int year = DateTime.Now.Year - DOB.Year;
                        int month = DateTime.Now.Month - DOB.Month;

                        if (month < 0)
                        {
                            year = year - 1;
                            month = month + 12;
                        }

                        txtAgeM.Text = year.ToString() + " yr and " + month.ToString() + " months";
                    }
                }
            }
            //cmbNameM.DropDownStyle = ComboBoxStyle.Simple;
            //txtFCardNoF.Focus();
        }

        private void cmbNameF_Leave(object sender, EventArgs e)
        {
            if (cmbNameF.Items.Count != 0)
            {
                string A = txtDobF.Text.Length.ToString();
                if (txtDobF.Text != "")
                {
                    if (Convert.ToInt32(A) == 4)
                    {
                        int Year = DateTime.Now.Year;
                        string DOBYear = txtDobF.Text.ToString();
                        int AgeYear = Year - Convert.ToInt32(DOBYear);
                        txtAgeF.Text = AgeYear.ToString();
                    }
                    else
                    {
                        DateTime DOB = Convert.ToDateTime(txtDobF.Text);

                        int year = DateTime.Now.Year - DOB.Year;
                        int month = DateTime.Now.Month - DOB.Month;

                        if (month < 0)
                        {
                            year = year - 1;
                            month = month + 12;
                        }

                        txtAgeF.Text = year.ToString() + " yr and " + month.ToString() + " months";
                    }
                }
            }
            //dtpEngDate.Focus();
            //cmbNameF.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void dpMarriage_ValueChanged(object sender, EventArgs e)
        {
            btnSaveMarriage.Enabled = true;
        }

        private void dgEngagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "Engaged")
            {
                usp_SEL_EngagementTableAdapter.FillOnlyEngagement(comDataSet.usp_SEL_Engagement);
            }
            else if (cmbFilter.Text == "Married")
            {
                usp_SEL_EngagementTableAdapter.Marriage(comDataSet.usp_SEL_Engagement, DateTime.Today);
            }
            else if (cmbFilter.Text == "All")
            {
                usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);
            }
            else if (cmbFilter.Text == "Cancelled")
            {
                usp_SEL_EngagementTableAdapter.Cancelled(comDataSet.usp_SEL_Engagement);
            }
            else
            {
                usp_SEL_EngagementTableAdapter.FillOnlyMarried(comDataSet.usp_SEL_Engagement, DateTime.Today);
            }
            //if (dgEngagement.Rows.Count == 0)
            //{
            //    btnEdit.Enabled = false;
            //    btnView.Enabled = false;
            //    btnDelete.Enabled = false;
            //    btnMarriage.Enabled = false;
            //}
            //else
            //{
            //    btnEdit.Enabled = true;
            //    btnView.Enabled = true;
            //    btnDelete.Enabled = true;
            //    btnMarriage.Enabled = true;
            //}
        }

        private void btnMarriageView_Click(object sender, EventArgs e)
        {
            btnClose2.Focus();
            if (btnMarriageView.Text == "Cancel")
            {
                btnEditMarriage.Text = "Modify";
                mode = 2;
                btnMarriageView.Text = "View";
                btnClose2.Show();
                btnSaveMarriage.Show();
                lbl9.Show();
                dpEntryDate.Show();
                dgEngagement.Show();
                usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);
                btnClose2.Text = "Close";

            }
            else
                btnView_Click(sender, e);

        }

        private void btnEditMarriage_Click(object sender, EventArgs e)
        {

            try
            {
                //dpDate.Text = comDataSet.usp_SEL_Marriage.Rows[0].ItemArray[1].ToString();
                string Serial = txtSerialNo.Text;
                DateTime Date = Convert.ToDateTime(dpMarriage.Text);
                DateTime EntryDate = Convert.ToDateTime(dpDate.Text);
                string FCardM = txtFCardNoM.Text;
                string FCardF = txtFCardNoF.Text;
                string NukhM = txtNukhM.Text;
                string NukhF = txtNukhF.Text;
                string OrakhM = txtOrakhM.Text;
                string OrakhF = txtOrakhF.Text;
                string FNameF = txtFNameF.Text;
                string FNameM = txtFNameM.Text;
                string GFNameM = txtGFNameM.Text;
                string GFNameF = txtGFNameF.Text;
                string AgeM = txtAgeM.Text;
                string AgeF = txtAgeF.Text;
                DateTime Action = Convert.ToDateTime(dtpEngDate.Text);
                string NameM = cmbNameM.Text;
                string NameF = cmbNameF.Text;
                bool Active = ChkAvtiveMarriage();
                string atTime = cmbAt.Text;


                if (btnEditMarriage.Text == "Save")
                {
                    if (mode == 2)
                    {
                        usp_SEL_MarriageTableAdapter.Update1(Serial, Date, EntryDate, FCardM, NukhM, OrakhM, NameM, FNameM, GFNameM, AgeM, FCardF, NukhF, OrakhF, NameF, FNameF, GFNameF, AgeF, Action, Active, atTime);
                        MessageBox.Show("Succesfully Modifid!", "Success");
                        mode = 0;
                        btnEditMarriage.Text = "Modify";
                        btnSaveMarriage.Show();
                        btnMarriageView.Show();
                        dgEngagement.Show();
                        dpEntryDate.Show();
                        btnClose2.Show();
                        btnMarriageView_Click(sender, e);
                    }
                }
                else
                {
                    btnEditMarriage.Text = "Save";
                    mode = 2;
                    btnMarriageView.Text = "Cancel";
                    btnClose2.Hide();
                    btnSaveMarriage.Hide();
                    lbl9.Hide();
                    dpEntryDate.Hide();
                    dgEngagement.Hide();
                    odSerial = dgEngagement.CurrentRow.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCEngagement_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Are you sure??", "Confirmation", MessageBoxButtons.YesNo);
            if (Confirm == DialogResult.Yes)
            {
                if (chkCancel.Checked)
                {
                    //if (Confirm == DialogResult.Yes)
                    //{
                    //    usp_SEL_EngagementTableAdapter.Cancel(txtSerialNo.Text, false);
                    //    usp_SEL_MarriageTableAdapter.Cancel(txtSerialNo.Text, false);
                    //    MessageBox.Show("Successfully Done!!!!", "Success");
                    //}

                    chk frm = new chk();
                    frm.Show();
                    frm.eng_mrg_SerialNo = txtSerialNo.Text;
                }
                else
                {

                    usp_SEL_EngagementTableAdapter.Cancel(txtSerialNo.Text, true, "");
                    usp_SEL_MarriageTableAdapter.Cancel(txtSerialNo.Text, true, "");
                    MessageBox.Show("Successfully Done!!!!", "Success");
                    this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
                    this.usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);

                }
            }
            cmbFilter.Text = "All";
        }

        private void btnCMarriage_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Are you sure??", "Confirmation", MessageBoxButtons.YesNo);
            if (Confirm == DialogResult.Yes)
            {
                if (chkMarried.Checked)
                {
                    //if (Confirm == DialogResult.Yes)
                    //{
                    //    usp_SEL_EngagementTableAdapter.Cancel(txtSerialNo.Text, false);
                    //    usp_SEL_MarriageTableAdapter.Cancel(txtSerialNo.Text, false);
                    //    MessageBox.Show("Successfully Done!!!!", "Success");

                    //}

                    chk frm = new chk();
                    frm.Show();
                    frm.eng_mrg_SerialNo = txtSerialNo.Text;
                }
                else
                {

                    usp_SEL_EngagementTableAdapter.Cancel(txtSerialNo.Text, true, "");
                    usp_SEL_MarriageTableAdapter.Cancel(txtSerialNo.Text, true, "");
                    MessageBox.Show("Successfully Done!!!!", "Success");
                    this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, txtSerialNo.Text);
                    this.usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);

                }
            }
            cmbFilter.Text = "All";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            string id = dgEngagement.CurrentRow.Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT tblEngagement.SerialNo,tblEngagement.Date,tblEngagement.FCardNoM,tblEngagement.NukhM,tblEngagement.OrakhM,tblEngagement.NameM,tblEngagement.FNameM,tblEngagement.GFNameM,tblEngagement.AgeM,tblEngagement.FCardNoF,tblEngagement.NukhF,tblEngagement.OrakhF,tblEngagement.NameF,tblEngagement.FNameF,tblEngagement.GFNameF,tblEngagement.AgeF,tblEngagement.ArrangedBy,tblEngagement.DateofAction,tblEngagement.Marriage,tblEngagement.Active,tblEngagement.ReasonCancel,tblMarriage.SerialNo,tblMarriage.MarriageDate,tblMarriage.EntryDate,tblMarriage.FCardNoM,tblMarriage.NukhM,tblMarriage.OrakhM,tblMarriage.NameM,tblMarriage.FNameM,tblMarriage.AgeM,tblMarriage.FCardNoF,tblMarriage.NukhF,tblMarriage.OrakhF,tblMarriage.NameF,tblMarriage.FNameF,tblMarriage.AgeF,	tblMarriage.DateofEngagement,tblMarriage.GFNameM,tblMarriage.GFNameF FROM tblEngagement INNER Join tblMarriage on tblEngagement.SerialNo = tblMarriage.SerialNo WHERE tblMarriage.SerialNo ='" + id + "' and tblEngagement.SerialNo = '" + id + "'", con);
            SqlCommand cmd = new SqlCommand("SELECT tblEngagement.SerialNo,tblEngagement.Date,tblEngagement.FCardNoM,tblEngagement.NukhM,tblEngagement.OrakhM,tblEngagement.NameM,tblEngagement.FNameM,tblEngagement.GFNameM,tblEngagement.AgeM,tblEngagement.FCardNoF,tblEngagement.NukhF,tblEngagement.OrakhF,tblEngagement.NameF,tblEngagement.FNameF,tblEngagement.GFNameF,tblEngagement.AgeF,tblEngagement.ArrangedBy,tblEngagement.DateofAction,tblEngagement.Marriage,tblEngagement.Active,tblEngagement.ReasonCancel FROM tblEngagement WHERE SerialNo ='" + id + "'", con);
            SqlCommand cmd2 = new SqlCommand("Select tblMarriage.SerialNo,tblMarriage.MarriageDate,tblMarriage.EntryDate,tblMarriage.FCardNoM,tblMarriage.NukhM,tblMarriage.OrakhM,tblMarriage.NameM,tblMarriage.FNameM,tblMarriage.AgeM,tblMarriage.FCardNoF,tblMarriage.NukhF,tblMarriage.OrakhF,tblMarriage.NameF,tblMarriage.FNameF,tblMarriage.AgeF,	tblMarriage.DateofEngagement,tblMarriage.GFNameM,tblMarriage.GFNameF,atTime FROM tblMarriage WHERE SerialNo ='" + id + "'", con);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd2;

            da.Fill(dt);
            da2.Fill(dt2);

            Reports.Engagement.frmViewer frm = new MCKJ.Reports.Engagement.frmViewer();
            Reports.Engagement.rptEngagement rpt = new MCKJ.Reports.Engagement.rptEngagement();
            Reports.Engagement.rptMarriage rpt2 = new MCKJ.Reports.Engagement.rptMarriage();
            Reports.Engagement.rptBoth rpt3 = new MCKJ.Reports.Engagement.rptBoth();
            Reports.Engagement.rptEg rpt4 = new MCKJ.Reports.Engagement.rptEg();


            rpt.Subreports[0].SetDataSource(dt2);
            rpt.SetDataSource(dt);
            rpt3.SetDataSource(dt2);
            rpt4.SetDataSource(dt);

            frm.Show();
            if (rbtEngagement.Checked)
            {
                frm.crystalReportViewer1.ReportSource = rpt4;

            }
            else if (rbtMarriage.Checked)
            {
                frm.crystalReportViewer1.ReportSource = rpt3;
            }
            else
            {
                frm.crystalReportViewer1.ReportSource = rpt;
            }
            con.Close();
        }

        private void chkMaleOutsideKarachi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaleOutsideKarachi.Checked)
            {
                txtNukhM.ReadOnly = false;
                txtOrakhM.ReadOnly = false;
                txtGFNameM.ReadOnly = false;
                txtMMeritalStatus.ReadOnly = false;
                txtMOutOf.ReadOnly = false;
                lblMDOB.Visible = true;
                dtpDOBM.Visible = true;
                txtFNameM.ReadOnly = false;
                cmbNameM.DropDownStyle = ComboBoxStyle.Simple;

            }
            else
            {
                txtNukhM.ReadOnly = true;
                txtOrakhM.ReadOnly = true;
                txtGFNameM.ReadOnly = true;
                txtMMeritalStatus.ReadOnly = true;
                txtMOutOf.ReadOnly = true;
                dtpDOBM.Visible = false;
                lblMDOB.Visible = false;
                dtpDOBM.Visible = false;
                txtFNameM.ReadOnly = true;
                cmbNameM.DropDownStyle = ComboBoxStyle.DropDown;

            }
        }

        private void chkFemaleOutsideKarachi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemaleOutsideKarachi.Checked)
            {
                txtNukhF.ReadOnly = false;
                txtOrakhF.ReadOnly = false;
                txtGFNameF.ReadOnly = false;
                txtFMeritalStatus.ReadOnly = false;
                txtFOutOf.ReadOnly = false;
                lblFDOB.Visible = true;
                dtpDOBF.Visible = true;
                txtFNameF.ReadOnly = false;
                cmbNameF.DropDownStyle = ComboBoxStyle.Simple;

            }
            else
            {
                txtNukhF.ReadOnly = true;
                txtOrakhF.ReadOnly = true;
                txtGFNameF.ReadOnly = true;
                txtFMeritalStatus.ReadOnly = true;
                txtFOutOf.ReadOnly = true;
                lblFDOB.Visible = false;
                dtpDOBF.Visible = false;
                txtFNameF.ReadOnly = true;
                cmbNameF.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void dtpDOBF_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDOBF.Text != "")
            {
                DateTime DOB = Convert.ToDateTime(dtpDOBF.Text);

                int year = DateTime.Now.Year - DOB.Year;
                int month = DateTime.Now.Month - DOB.Month;

                if (month < 0)
                {
                    year = year - 1;
                    month = month + 12;
                }

                txtAgeF.Text = year.ToString() + " yr and " + month.ToString() + " months";
            }
        }

        private void dtpDOBM_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDOBM.Text != "")
            {
                DateTime DOB = Convert.ToDateTime(dtpDOBM.Text);

                int year = DateTime.Now.Year - DOB.Year;
                int month = DateTime.Now.Month - DOB.Month;

                if (month < 0)
                {
                    year = year - 1;
                    month = month + 12;
                }

                txtAgeM.Text = year.ToString() + " yr and " + month.ToString() + " months";

            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}      
  // END -------------------------------------------------------------------
        //--------------------------------------------------------------------
    