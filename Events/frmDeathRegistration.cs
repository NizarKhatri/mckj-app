using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace MCKJ
{
    public partial class frmDeathRegistration : Form
    {
        DataTable dt = new DataTable();
        public frmDeathRegistration()
        {
            InitializeComponent();
        }

        int mode = 0;
        int id = 0;
        int exit = 0;
        int MemberID = 0;
        Community.DBLayer DBLayer = new Community.DBLayer();
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 10;
        string Header = "Death Registration";
        string DOB = "";
        string MemberName = "";

        private int next()
        {
            int nextt = 0;
            SqlConnection con = new SqlConnection(DBLayer.CON_string);
            SqlCommand cmd = new SqlCommand("Select ISNULL(Max(Cast(RegNo as int)),0)+1 From tblDeath", con);

            con.Open();

            nextt = Convert.ToInt32(cmd.ExecuteScalar());

            return nextt;

        }
        

        private bool CheckField()
        {
            if (txtFCardNo.Text == "" || txtName.Text == "" || txtReasonOfDeath.Text == "" || txtRegNo.Text == "" || dtpEntryDate.Text == "" || dtpDOD.Text == "")
            {
                MessageBox.Show("Please provide all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void EmptyFields()
        {
            txtRegNo.Text = "";
            txtName.Text = "";
            txtFCardNo.Text = "";
            txtFName.Text = "";
            txtGFName.Text = "";
            txtNukh.Text = "";
            txtOrakh.Text = "";
            txtReasonOfDeath.Text = "";
            cmbAgeGroup.Text = null;
            cmbGender.Text = null;
            cmbRelation.Text = null;
            txtAddress.Text = "";
            dtpEntryDate.Text = null;
            dtpDOD.Text = null;

        }

        private void Gayab(bool A)
        {
            dgvDeath.Visible = A;
            btnNew.Enabled = A;
            btnEdit.Enabled = A;
            btnDelete.Enabled = A;
           // btnClose.Visible = A;
            txtFilter.Enabled = A;
            btnSearch.Enabled = A;
            label2.Enabled = A;
            btnView.Enabled = A;
        }

        private void Read_Only(bool B)
        {
            txtFilter.ReadOnly = B;
            txtFCardNo.ReadOnly = B;
            txtAddress.ReadOnly = B;
            txtFName.ReadOnly = B;
            txtGFName.ReadOnly = B;
            txtNukh.ReadOnly = B;
            txtOrakh.ReadOnly = B;
            txtReasonOfDeath.ReadOnly = B;
            txtRegNo.ReadOnly = B;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EmptyFields();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (exit == 1)
            {
                Read_Only(false);
                Gayab(true);
                btnView.Visible = true;
                btnNew.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnClose.Visible = true;
                btnReset.Show();
                exit = 0;
                btnCancel.Show();
                btnSave.Hide();
                AcceptButton = btnNew;
                txtFilter.Focus();
                lbl.Text = Header;
            }
            else
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            //if (dgvDeath.Rows.Count != 0)
            //{
            //    usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, txtFCardNo.Text, txtName.Text);
            //    MemberID = Convert.ToInt32(comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[0].ToString());
            //}
            txtDRCN.Text = GenerateDRCN();
            txtDRCN.Visible = true;
            lblDRCN.Visible = true;

            EmptyFields();
            mode = 1;
            AcceptButton = btnSave;
            Gayab(false);
            txtRegNo.Text = next().ToString("00000");
            btnReset.Hide();
            lbl.Text = Header + ">>Adding";


        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (dgvDeath.Rows.Count != 0)
            {
                //txtNameEdit.Text = dgvDeath.CurrentRow.Cells[3].Value.ToString();
                txtFCardNo_Leave(sender, e);
                txtName.Text = dgvDeath.CurrentRow.Cells[3].Value.ToString();
                Read_Only(true);
                Gayab(false);
                btnView.Visible = false;
                btnNew.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnClose.Visible = true;
                exit = 1;
                btnSave.Hide();
                btnCancel.Hide();
                AcceptButton = btnClose;
                btnReset.Hide();
                lbl.Text = Header + ">>Preview";
            }
            else
                MessageBox.Show("No Record for Preview", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
      
        private void frmDeathRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset3.usp_SEL_Death' table. You can move, or remove it, as needed.
            this.usp_SEL_DeathTableAdapter.Fill(this.comDataSet.usp_SEL_Death);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_Death' table. You can move, or remove it, as needed.
            //this.usp_SEL_DeathTableAdapter.Fill(this.dataset3.usp_SEL_Death);

            txtDRCN.Visible = false;
            lblDRCN.Visible = false;

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
            AcceptButton = btnNew;
            dgvDeath.BringToFront();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                //usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, txtFCardNo.Text, txtName.Text);
                //MemberID = Convert.ToInt32(comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[0].ToString());
                MemberID = Convert.ToInt32(usp_SEL_TSF_tblFamilyMemberTableAdapter.ScalarQuery(txtFCardNo.Text, txtName.Text));
            }
           
            bool CHK = DBLayer.CHK_RegNo_Death(txtRegNo.Text);
            try
            {
                string RegNo = txtRegNo.Text;
                string Name = txtName.Text;
                string FName = txtFName.Text;
                string GFName = txtGFName.Text;
                string FCardNo = txtFCardNo.Text;
                string Orakh = txtOrakh.Text;
                string Nukh = txtNukh.Text;
                string Gender = cmbGender.Text;
                string AgeGroup = cmbAgeGroup.Text;
                string Relation = cmbRelation.Text;
                DateTime DOD = Convert.ToDateTime(dtpDOD.Text);
                DateTime EntryDate = Convert.ToDateTime(dtpEntryDate.Text);
                string Reason = txtReasonOfDeath.Text;
                string Address = txtAddress.Text;
                string Age = txtAge.Text;
                string Place = cmbPlace.Text;
                string AppName = txtApplicantName.Text;
                string AppCNIC = txtApplicantCNIC.Text;
                string AppRelation = cmbApplicantRelation.Text;
                DateTime DTime = Convert.ToDateTime(dtpDtime.Text);
                string DRCNumber = txtDRCN.Text;
                bool isPrinted = chkIsPrinted.Checked;

                if (CheckField())
                {
                    if (mode == 1)
                    {
                        if (CHK)
                        {
                            MessageBox.Show("Registration Number Already Exists!!!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            usp_SEL_DeathTableAdapter.InsertDeath(RegNo, FCardNo, Name, FName, GFName, Nukh, Orakh, Gender, DOD, Relation, AgeGroup, Reason, Address, EntryDate, Age, Place, DTime, MemberID, AppName, AppCNIC, AppRelation, DRCNumber, false); 
                            Gayab(true);
                            mode = 0;                                                  
                            usp_SEL_tblFamilyMemberTableAdapter.Update_Death(FCardNo, false, "Death", DOD, MemberID);
                            MessageBox.Show("Succesfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            usp_SEL_DeathTableAdapter.Fill(this.comDataSet.usp_SEL_Death);    
                        }

                    }
                    else if (mode == 0)
                    {
                        usp_SEL_DeathTableAdapter.UpdateDeath(id, RegNo, FCardNo, Name, FName, GFName, Nukh, Orakh, Gender, DOD, Relation, AgeGroup, Reason, Address, EntryDate, Age, Place, DTime, MemberID, AppName, AppCNIC, AppRelation, DRCNumber, isPrinted);                                             
                        Gayab(true);
                        mode = 0;
                        btnReset.Show();
                        usp_SEL_DeathTableAdapter.Fill(this.comDataSet.usp_SEL_Death);
                        usp_SEL_tblFamilyMemberTableAdapter.Update_Death(FCardNo, false, "Death", EntryDate,MemberID);
                        MessageBox.Show("Succesfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                AcceptButton = btnNew;
                txtFilter.Focus();
                lbl.Text = Header;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please insert valid values in respective fields!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvDeath.Rows.Count != 0)
            {
                lbl.Text = Header + ">>Modifing";
                id = Convert.ToInt32(dgvDeath.CurrentRow.Cells[0].Value.ToString());
                MapFields();
                //txtNameEdit.Text = dgvDeath.CurrentRow.Cells[3].Value.ToString();
                btnReset.Hide();
                mode = 0;
                Gayab(false);
                txtRegNo.ReadOnly = true;
                txtName.Visible = true;
                if (txtFCardNo.Text != "")
                {
                    txtFCardNo.Text = dgvDeath.CurrentRow.Cells[2].Value.ToString();
                    txtFCardNo_Leave(sender, e);
                    txtName.Text = dgvDeath.CurrentRow.Cells[3].Value.ToString();
                }
                else
                {
                    txtFCardNo.Text = dgvDeath.CurrentRow.Cells[2].Value.ToString();
                    txtFCardNo_Leave(sender, e);
                    txtName.Text = dgvDeath.CurrentRow.Cells[3].Value.ToString();
                }
            }
            else
                MessageBox.Show("No Record for Edit", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MapFields()
        {
            txtRegNo.Text = dgvDeath.CurrentRow.Cells[1].Value.ToString();
            txtApplicantName.Text = dgvDeath.CurrentRow.Cells["AppName"].Value.ToString();
            txtApplicantCNIC.Text = dgvDeath.CurrentRow.Cells["AppCNIC"].Value.ToString();
            cmbApplicantRelation.Text = dgvDeath.CurrentRow.Cells["AppRelation"].Value.ToString();
            dtpDOD.Text = dgvDeath.CurrentRow.Cells[9].Value.ToString();
            dtpDtime.Text = dgvDeath.CurrentRow.Cells[17].Value.ToString();
            txtReasonOfDeath.Text = dgvDeath.CurrentRow.Cells[12].Value.ToString();
            cmbPlace.Text = dgvDeath.CurrentRow.Cells[16].Value.ToString();
            dtpEntryDate.Text = dgvDeath.CurrentRow.Cells[14].Value.ToString();
            txtAge.Text = dgvDeath.CurrentRow.Cells[15].Value.ToString();
            txtDRCN.Text = dgvDeath.CurrentRow.Cells["DRCNumber"].Value.ToString();
            txtName.Text = dgvDeath.CurrentRow.Cells[3].Value.ToString();
            txtFName.Text = dgvDeath.CurrentRow.Cells[4].Value.ToString();
            txtGFName.Text = dgvDeath.CurrentRow.Cells[5].Value.ToString();
            cmbGender.Text = dgvDeath.CurrentRow.Cells[8].Value.ToString();
            cmbRelation.Text = dgvDeath.CurrentRow.Cells[10].Value.ToString();
            cmbAgeGroup.Text = dgvDeath.CurrentRow.Cells[11].Value.ToString();
            //dtpDOD_Leave(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDeath.Rows.Count != 0)
            {
                lbl.Text = Header + ">>Deleting";
                DialogResult result = MessageBox.Show("Are you sure you want to delete??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dgvDeath.CurrentRow.Cells[0].Value.ToString());
                    usp_SEL_DeathTableAdapter.DeleteDeath(id);
                    MessageBox.Show("Sucessfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usp_SEL_DeathTableAdapter.Fill(this.comDataSet.usp_SEL_Death);
                    lbl.Text = Header;
                }
                else
                    lbl.Text = Header;
            }
            else
                MessageBox.Show("No Record for Deleting", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Gayab(true);
                btnReset.Show();
                txtDRCN.Visible = false;
                lblDRCN.Visible = false;
                mode = 0;
                usp_SEL_DeathTableAdapter.Fill(this.comDataSet.usp_SEL_Death);
                AcceptButton = btnNew;
                txtFilter.Focus();
                lbl.Text = Header;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                usp_SEL_DeathTableAdapter.Fill(comDataSet.usp_SEL_Death);
            AcceptButton = btnSearch;
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (txtFilter.Text != "")
                //{
                //    int fcardno = Convert.ToInt32(txtFilter.Text);
                //    int x = 5 - txtFilter.Text.Length;
                //    string zeros = "";
                //    for (int i = 0; i < x; i++)
                //    {
                //        zeros += "0";
                //    }
                //    txtFilter.Text = zeros + txtFilter.Text;
                //}
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtFilter_Leave(sender, e);
            try
            {
                if (txtFilter.Text != "")
                {
                    uspSELDeathBindingSource.Filter = "RegNo='" + txtFilter.Text + "'";
                    AcceptButton = btnEdit;
                }
                else
                    MessageBox.Show("Please insert regestration number!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill valid values in respetive fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    bool Result = DBLayer.CheckFamily(txtFCardNo.Text);
                    if (Result)
                    {
                        usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, txtFCardNo.Text);
                        txtOrakh.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[17].ToString();
                        txtNukh.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[18].ToString();
                        dt = usp_SEL_DeathTableAdapter.GetDataByFCardNo(txtFCardNo.Text);
                        if (dt.Rows.Count > 0)
                        {
                            txtAddress.Text = dt.Rows[0]["RAddress"].ToString();
                        }
                        else
                        {
                            txtAddress.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[6].ToString();
                        }
                        usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
                        if (txtName.Text == "")
                        {
                            MessageBox.Show("No Member Found!", "Unable to Find", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Card Does Not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Text = "";                        
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Errors");

            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Community.DBLayer DBLayer = new Community.DBLayer();
            string ID = txtFCardNo.Text;
            string Name = txtName.Text;
            bool result = DBLayer.TRANSFER(ID, Name);
            if (txtName.Text == "" || txtFCardNo.Text == "00000")
            {
               // MessageBox.Show("Please fill the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {             
                if (result)
                {
                    try
                    {
                        string valuee = txtName.SelectedValue.ToString();
                        SqlConnection con = new SqlConnection(DBLayer.CON_string);
                        SqlCommand cmd = new SqlCommand("Select FatherName,HusbandName,Gender,LeaderRelation,DOB,AgeGroup FROM tblFamilyMember WHERE FamilyMemberID = " + valuee, con);
                        con.Open();
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                             reader.Read();
                             txtFName.Text = reader.GetValue(0).ToString();
                             cmbGender.Text = reader.GetValue(2).ToString();
                             cmbRelation.Text = reader.GetValue(3).ToString();
                             cmbAgeGroup.Text = reader.GetValue(5).ToString();
                             DOB = reader.GetValue(4).ToString();
                             txtGFName.Text = reader.GetValue(1).ToString();
                        }
                        
                        
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Member Not Found!!!", "Unable to Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void txtRegNo_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (txtRegNo.Text != "")
                //{
                //    int fcardno = Convert.ToInt32(txtRegNo.Text);
                //    int x = 5 - txtRegNo.Text.Length;
                //    string zeros = "";
                //    for (int i = 0; i < x; i++)
                //    {
                //        zeros += "0";
                //    }
                //    txtRegNo.Text = zeros + txtRegNo.Text;                   

                //}
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");

            }
        }

        private void dtpDOD_Leave(object sender, EventArgs e)
        {
            if (mode != 0)
            {
                if (DOB.Length == 4)
                {
                    int yr = Convert.ToDateTime(dtpDOD.Text).Year;
                    int age = yr - Convert.ToInt32(DOB);
                    txtAge.Text = age.ToString();
                }
                else
                {
                    DateTime dob = Convert.ToDateTime(DOB);
                    int years = Convert.ToDateTime(dtpDOD.Text).Year - dob.Year;
                    if (Convert.ToDateTime(dtpDOD.Text).Month < dob.Month || (Convert.ToDateTime(dtpDOD.Text).Month == dob.Month && Convert.ToDateTime(dtpDOD.Text).Day < dob.Day))
                        years--;

                    txtAge.Text = years.ToString() + " years";
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string MemberName = dgvDeath.CurrentRow.Cells[3].Value.ToString();
                bool isPrinted = Convert.ToBoolean(dgvDeath.CurrentRow.Cells["IsPrinted"].Value.ToString());
                string FCardNo = dgvDeath.CurrentRow.Cells[2].Value.ToString();
                string RegNo = dgvDeath.CurrentRow.Cells[1].Value.ToString();
                int FamilyMemberID = Convert.ToInt32(usp_SEL_TSF_tblFamilyMemberTableAdapter.ScalarQuery(FCardNo, MemberName));

                DialogResult dr;

                if (isPrinted)
                {
                    dr = MessageBox.Show("Death Certificate for this member is already Printed.\r\n Do you want to print duplicate report ? ", "Death Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    dr = MessageBox.Show("Do you want to print report ? ", "Death Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 }

                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    con.Open();

                    ReportDocument cryRpt = new ReportDocument();
                    //cryRpt.Load("E:\\MCKJ\\SourceCode-Hall5Updated\\Mckj Software - SourceCode\\KCommunity\\Reports\\Hall Booking\\rptHallBookingInfo.rpt");
                    //cryRpt.Load(Application.StartupPath + "rptHallBookingInfo.rpt");
                    //cryRpt.SetParameterValue("StartDate", dtpSearchDate.Text);
                    //cryRpt.SetParameterValue("EndDate", dtpSearchDateTo.Text);

                    Reports.BirthDeath.frmViewer frm = new MCKJ.Reports.BirthDeath.frmViewer();
                    Reports.BirthDeath.rptDeathCertificate rpt = new MCKJ.Reports.BirthDeath.rptDeathCertificate();
                    rpt.SetDatabaseLogon("sa", "sql_pwd_SA", "MCKJ-SERVER", "Community");

                    frm.crystalReportViewer1.ReportSource = rpt;
                    rpt.SetParameterValue("FamilyMemberID", FamilyMemberID);

                    frm.Refresh();
                    frm.Show();
                    con.Close();

                    //UpdatePrinted(FamilyMemberID, RegNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePrinted(int FamilyMemberId, string RegNo)
        {
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update tblDeath set IsPrinted = 1 where FamilyMemberID = '" + FamilyMemberId + "' AND RegNo = '" + RegNo + "'";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private string GenerateDRCN()
        {
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select ISNULL(Max(DRCNumber),'') from tbldeath";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            string number = cmd.ExecuteScalar().ToString();
            int counter = 0;

            if (string.IsNullOrEmpty(number))
            {
                number = "MCKJ-DC-" + DateTime.Now.Year + "-" + "001";
            }
            else
            {
                if (Convert.ToInt32(number.Substring(8, 4)) == DateTime.Now.Year)
                {
                    counter = Convert.ToInt32(number.Substring(13)) + 1;
                    number = number.Substring(0,8) + DateTime.Now.Year + "-" + GenerateCounter(counter);
                }
                else
                {
                    number = "MCKJ-DC-" + DateTime.Now.Year + "-" + "001";
                }
            }
            return number;
        }

        private string GenerateCounter(int counter)
        {
            int length = Convert.ToInt32(Convert.ToString(counter).Length);
            string value = string.Empty;

            if (length == 1)
            {
                value = "00" + counter;
            }
            else if (length == 2)
            {
                value = "0" + counter;
            }
            else
            {
                value = counter.ToString();
            }

            return value;
        }
       
    }
}