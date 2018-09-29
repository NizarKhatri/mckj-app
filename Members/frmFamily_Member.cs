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

    public partial class frmFamily_Member : Form
    {
        public frmFamily_Member()
        {
            InitializeComponent();
        }

        //Variables--------------------------------------------------------
        //-----------------------------------------------------------------                                                      

        int mode = 0;
        int Exit = 0;
        int Chk = 0;
        int UserID = Community.DBLayer.ID;
        Community.DBLayer DBLayer = new Community.DBLayer();
        int SecurityLevelID = 4;
        bool rNew = false;
        bool rEdit = false;
        bool rDelete = false;
        string Header = "Family Members";

        //Functions--------------------------------------------------------
        //-----------------------------------------------------------------                                                      

        private void User_Right()
        {
            Community.DBLayer DBLayer = new Community.DBLayer();
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("Select Write,Modify,[Delete] from tblPermission  Where UserID =" + UserID + " And SecurityLevelID= " + 4, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    rNew = Convert.ToBoolean(reader.GetValue(0));
                    rEdit = Convert.ToBoolean(reader.GetValue(1));
                    rDelete = Convert.ToBoolean(reader.GetValue(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            //return chk_Right;
        }

        private void ReadOnly(bool ReadOnly)
        {
            txtAcdemicEdu.ReadOnly = ReadOnly;
            txtBAddress.ReadOnly = ReadOnly;
            txtBName.ReadOnly = ReadOnly;
            txtBPhone.ReadOnly = ReadOnly;
            txtCMIC.ReadOnly = ReadOnly;
            txtCNIC.ReadOnly = ReadOnly;
            txtDesignation.ReadOnly = ReadOnly;
            txtEmail.ReadOnly = ReadOnly;
            txtFamilyLeader.ReadOnly = ReadOnly;
            txtFax.ReadOnly = ReadOnly;
            txtFCardNo.ReadOnly = ReadOnly;
            txtFName.ReadOnly = ReadOnly;
            txtHName.ReadOnly = ReadOnly;
            txtMobile.ReadOnly = ReadOnly;
            txtName.ReadOnly = ReadOnly;
            txtOrakh.ReadOnly = ReadOnly;
            txtProfessionalEdu.ReadOnly = ReadOnly;
            txtTechnicalEdu.ReadOnly = ReadOnly;
            txtWebsite.ReadOnly = ReadOnly;
            txtDOBYear.ReadOnly = ReadOnly;

        }

        private string Year()
        {
            string Year = "";

            if (txtDOBYear.Text != "")
                Year = "01-" + "01-" + txtDOBYear.Text;
            else
            {
                DateTime chk = Convert.ToDateTime(dpDOB.Text);
                Year = chk.ToString("dd-MM-yyyy");
                //Year = chk.Day + "/" + chk.Month + "/" + chk.Year;
            }
            return Year;
        }

        private void Disable(bool disable)
        {
            btnAdd.Enabled = disable;
            btnAllMembers.Enabled = disable;
            btnDelete.Enabled = disable;
            btnEdit.Enabled = disable;
            btnFCardNo.Enabled = disable;
            btnView.Enabled = disable;
            DGFamily.Visible = disable;
            txtFCardNo.Enabled = disable;
            grbMain.Enabled = !disable;
        }

        private void EmptyFields()
        {
            txtDOBYear.Text = "";
            cmbBGroup.Text = null;
            dpDOB.Text = null;
            txtHName.Text = "";
            cmbAdult.Text = "";
            cmbGender.Text = null;
            txtAcdemicEdu.Text = "";
            txtBAddress.Text = "";
            cmbBGroup.Text = "";
            txtBName.Text = "";
            txtBPhone.Text = "";
            txtCMIC.Text = "";
            txtCNIC.Text = "";
            txtDesignation.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
            txtProfessionalEdu.Text = "";
            txtTechnicalEdu.Text = "";
            cmbTypeWork.Text = null;
            txtWebsite.Text = "";
            cmbRelation.Text = "";
            cmbRelation.Text = "";
            txtFName.Text = "";
            cmbMaritalStatus.Text = "";
            cmbOutof.Text = "";
            //dpIncident.Text = null;

        }

        private bool CheckFields()
        {
            if (txtName.Text == "" || cmbRelation.Text == "" || cmbGender.Text == "" || cmbAdult.Text == "")
            {
                MessageBox.Show("Fields cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
                return true;

        }

        private void Hidden(bool Hidden)
        {
            btnAllMembers.Visible = Hidden;
            btnFCardNo.Visible = Hidden;
            dpDOB.Visible = Hidden;
            btnEdit.Visible = Hidden;
            btnDelete.Visible = Hidden;
            btnReset.Visible = Hidden;
            btnSubmit.Visible = Hidden;
            btnCancel.Visible = Hidden;
            btnView.Visible = Hidden;
            DGFamily.Visible = Hidden;
            btnAdd.Visible = Hidden;
        }

        //WorkStation-------------------------------------------------------
        //-----------------------------------------------------------------                                                      
        private void FillGrid(string FCardNo)
        {

            usp_SEL_tblFamilyMemberTableAdapter.FillActive(comDataSet.usp_SEL_tblFamilyMember, FCardNo);
            int rows = DGFamily.Rows.Count;
            for (int x = 0; x < rows; x++)
            {

                string SNo = Convert.ToDecimal(x + 1).ToString("000");
                DGFamily.Rows[x].Cells[1].Value = SNo;
                DGFamily.RefreshEdit();

            }


        }

        private void FillGrid_All(string FCardNo)
        {

            usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, FCardNo);
            int rows = DGFamily.Rows.Count;
            for (int x = 0; x < rows; x++)
            {

                string SNo = Convert.ToDecimal(x + 1).ToString("000");
                DGFamily.Rows[x].Cells[1].Value = SNo;
                DGFamily.RefreshEdit();
            }


        }

        private void frmFamily_Member_Load(object sender, EventArgs e)
        {
            btnActiveMembers.Enabled = false;
            btnNonActiveMembers.Enabled = false;
            DGFamily.BringToFront();

            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblWorkType' table. You can move, or remove it, as needed.
            this.usp_SEL_tblWorkTypeTableAdapter.Fill(this.comDataSet.usp_SEL_tblWorkType);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblWorkType' table. You can move, or remove it, as needed.
            this.usp_SEL_tblWorkTypeTableAdapter.Fill(this.comDataSet.usp_SEL_tblWorkType);
            btnFCardNo.Focus();
            this.usp_SEL_tblBloodGroupTableAdapter.Fill(this.comDataSet.usp_SEL_tblBloodGroup);

            btnFCardNo.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Exit == 1)
            {
                cmbAdult.Enabled = true;
                cmbBGroup.Enabled = true;
                cmbGender.Enabled = true;
                cmbRelation.Enabled = true;
                cmbOutof.Enabled = true;
                cmbMaritalStatus.Enabled = true;
                txtFCardNo.ReadOnly = false;
                Hidden(true);
                grBox4.Hide();
                grbMain.Enabled = true;
                Exit = 0;
                this.AcceptButton = btnAdd;
                cmbTypeWork.Enabled = true;

            }
            else if (Exit == 0)
            {
                this.Close();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EmptyFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = 1;
            Disable(false);
            ReadOnly(false);
            txtMemberID.Visible = true;
            EmptyFields();
            btnReset.Enabled = true;
            chkActive.Checked = true;
            txtName.Focus();
            this.AcceptButton = btnSubmit;
            dpEntryDate.Text = DateTime.Today.ToShortDateString();
            lbl.Text = Header + ">>Adding Member";


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (txtChk.Text == "True")
            //{
                //usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, txtFCardNo.Text, txtName.Text);
                //cmbGender.Text = comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[8].ToString();

                if (txtDOBYear.Text.Length != 4)
                {
                    txtDOBYear.Text = "";
                }
                else
                    dpDOB.Enabled = false;

                ReadOnly(false);
                txtMemberID.Visible = true;
                Disable(false);
                this.AcceptButton = btnSubmit;
                chkActive.Enabled = false;
                lbl.Text = Header + ">>Modifing Member";
                btnReset.Enabled = false;
                txtName.Focus();

            //}
            //else
            //{
            //    MessageBox.Show("You cannot modify this Member! 'InActive'");

            //}
            if (txtReason.Text == "")
            {
                label19.Hide();
                label20.Hide();
                txtReason.Hide();
                dpAction.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (DGFamily.RowCount != 0)
            {
                btnEdit.Enabled = true;
                btnView.Enabled = true;
            }
            string x = txtFCardNo.Text;
            DialogResult result = MessageBox.Show("Are You Sure You Want to Cancel", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FillGrid(txtFCardNo.Text);
                mode = 0;
                Disable(true);
                txtMemberID.Visible = true;
                lbl.Text = Header;
                if (txtFCardNo.Text == "")
                {
                    txtFCardNo.Text = x;
                }
            }
            this.AcceptButton = btnAdd;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (CheckFields())
            {
                try
                {
                    string FCardNo = txtFCardNo.Text;
                    string Academic = txtAcdemicEdu.Text;
                    string BAddress = txtBAddress.Text;
                    string Bgroup = cmbBGroup.Text;
                    string BName = txtBName.Text;
                    string BPhone = txtBPhone.Text;
                    string Gender = cmbGender.Text;
                    string AgeGroup = cmbAdult.Text;
                    string CMIC = txtCMIC.Text;
                    string CNIC = txtCNIC.Text;
                    string Designation = txtDesignation.Text;
                    string Email = txtEmail.Text;
                    string Fax = txtFax.Text;
                    string Mobile = txtMobile.Text;
                    string Name = txtName.Text;
                    string Professional = txtProfessionalEdu.Text;
                    string Technical = txtTechnicalEdu.Text;
                    string Type = cmbTypeWork.Text;
                    string Website = txtWebsite.Text;
                    string DOB = Year();
                    string LRelation = cmbRelation.Text;
                    string FName = txtFName.Text;
                    string HName = txtHName.Text;
                    bool Active = Convert.ToBoolean(chkActive.CheckState);
                    string Reason = txtReason.Text;
                    string Status = cmbMaritalStatus.Text;
                    string OutOf = cmbOutof.Text;
                    DateTime EntryDate = Convert.ToDateTime(dpEntryDate.Text);
                    string FromCard = txtFromCard.Text;
                    string ToCard = txtToCard.Text;
                    string TempDOB = Convert.ToDateTime(DOB).ToString("dd-MM-yyyy"); ;



                    DialogResult Result = MessageBox.Show("Are you sure??", "Confirmation", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        if (mode == 1)
                        {

                            usp_SEL_tblFamilyMemberTableAdapter.Insert1(FCardNo, Name, LRelation, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, null, null, Status, OutOf, EntryDate, FromCard, ToCard, Convert.ToDateTime(TempDOB),txtNameU.Text,txtFNameU.Text,txtHusbandNameU.Text,DBLayer.GetUserID());
                            //   txtFCardNo.Enabled = true;
                            MessageBox.Show("Saved Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EmptyFields();
                            txtName.Focus();
                            lbl.Text = Header;

                        }

                        else if (mode == 0)
                        {
                            if (chkActive.Checked)
                            {
                                usp_SEL_tblFamilyMemberTableAdapter.Update1(Convert.ToInt64(txtMemberID.Text), FCardNo, Name, LRelation, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, null, null, Status, OutOf, EntryDate, FromCard, ToCard, Convert.ToDateTime(TempDOB).Date, txtNameU.Text, txtFNameU.Text, txtHusbandNameU.Text, DBLayer.GetUserID());
                                MessageBox.Show("Modified Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillGrid(txtFCardNo.Text);
                                lbl.Text = Header;
                                Disable(true);
                            }
                            else
                            {
                                DateTime Action = Convert.ToDateTime(dpAction.Text);
                                usp_SEL_tblFamilyMemberTableAdapter.Update1(Convert.ToInt64(txtMemberID.Text), FCardNo, Name, LRelation, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, Reason, Action, Status, OutOf, EntryDate, FromCard, ToCard, Convert.ToDateTime(TempDOB).Date, txtNameU.Text, txtFNameU.Text, txtHusbandNameU.Text, DBLayer.GetUserID());
                                MessageBox.Show("Record has been Modified", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillGrid(FCardNo);
                                Disable(true);
                                lbl.Text = Header;
                                btnFCardNo.Enabled = true;
                            }
                        }
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                label26.Hide();
                label28.Hide();
                //btnAllMembers.Show();
                txtFCardNo.Visible = true;
                btnClose.Visible = true;
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
                if (Chk == 0)
                {
                    bool result = dblayer.CheckFamily(txtFCardNo.Text);
                    if (result)
                    {
                        usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, txtFCardNo.Text);

                        FillGrid(txtFCardNo.Text);
                        //FillGrid(txtFCardNo.Text);
                        btnView.Enabled = true;
                        //User_Right();
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

                        Chk = 0;
                        if (DGFamily.RowCount == 0)
                        {
                            DGFamily.Enabled = false;
                            btnEdit.Enabled = false;
                            btnDelete.Enabled = false;
                            btnView.Enabled = false;

                        }
                        else
                        {
                            DGFamily.Enabled = true;
                        }

                        if (txtFCardNo.Text == "")
                        {
                            txtFCardNo.Text = x;
                        }
                        this.AcceptButton = btnAdd;
                    }
                    else
                    {
                        MessageBox.Show("Family CardNo doesnot exist! Please enter a Valid CardNo.", "Invalid CardNo.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        btnDelete.Enabled = false;
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        DGFamily.Enabled = false;
                        btnView.Enabled = false;
                        txtOrakh.Text = "";
                        txtFamilyLeader.Text = "";
                    }

                }


            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            ReadOnly(true);
            Hidden(false);
            grbMain.Show();
            grBox4.Show();
            cmbAdult.Enabled = false;
            cmbBGroup.Enabled = false;
            cmbGender.Enabled = false;
            cmbRelation.Enabled = false;
            cmbOutof.Enabled = false;
            cmbTypeWork.Enabled = false;
            dpEntryDate.Enabled = false;
            cmbMaritalStatus.Enabled = false;
            if (txtReason.Text == "")
            {
                label19.Enabled = false;
                label20.Enabled = false;
                txtReason.Enabled = false;
                dpAction.Enabled = false;
                // label34.Hide();
            }
            else
            {
                label19.Enabled = true;
                label20.Enabled = true;
                txtReason.Enabled = true;
                //dpAction.Enabled = true;
                // label34.Show();
            }
            Exit = 1;
        }

        private void btnAllMembers_Click(object sender, EventArgs e)
        {
            Community.DBLayer dblayer = new Community.DBLayer();
            btnNonActiveMembers.Enabled = true;
            btnActiveMembers.Enabled = true;
            string x = txtFCardNo.Text;

            if (txtFCardNo.Text == "")
            {
                MessageBox.Show("Please Insert Family Card Number", "Family Card Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                bool result = dblayer.CheckFamily(txtFCardNo.Text);
                if (result)
                {
                    btnView.Enabled = true;
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

                    FillGrid_All(txtFCardNo.Text);
                    //FillFamilyGrid("usp_SEL_tblAllFamilyMembers");
                    if (DGFamily.RowCount == 0)
                    {
                        DGFamily.Enabled = false;
                    }
                    else
                    {
                        DGFamily.Enabled = true;
                    }
                    //btnDelete.Enabled = true;
                    if (txtFCardNo.Text == "")
                    {
                        txtFCardNo.Text = x;
                    }
                }
                else
                {
                    MessageBox.Show("Family CardNo doesnot exist! Please try Again.", "Invalid CardNo.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    DGFamily.Enabled = false;
                    btnView.Enabled = false;
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbl.Text = Header + ">>Deleting Member";
            string x = txtFCardNo.Text;
            int memeberId = Convert.ToInt32(DGFamily.CurrentRow.Cells[0].Value.ToString());
            if (txtMemberID.Text != "")
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    usp_SEL_tblFamilyMemberTableAdapter.Delete1(memeberId);
                    MessageBox.Show("Record has Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGrid(txtFCardNo.Text);
                    lbl.Text = Header;
                }
                else
                    lbl.Text = Header;
                if (txtFCardNo.Text == "")
                {
                    txtFCardNo.Text = x;
                }
            }
            else
            {
                lbl.Text = Header;
                MessageBox.Show("No Member Selected", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Chk = 0;
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
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");
                Chk = 1;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnView.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void cmbMaritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaritalStatus.Text == "Married")
            {
                cmbOutof.Enabled = true;
            }
            else
            {
                cmbOutof.Text = "";
                cmbOutof.Enabled = false;
            }
        }

        private void cmbRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRelation.Text == "Head of Family" && txtName.Text == txtFamilyLeader.Text)
            {
                cmbGender.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[21].ToString();
                if (comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[22].ToString().Length == 4)
                    txtDOBYear.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[22].ToString();
                else
                    dpDOB.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[22].ToString();
                txtEmail.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[15].ToString();
                txtWebsite.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[16].ToString();
                txtBPhone.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[13].ToString();
                txtBAddress.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[12].ToString();
                txtBName.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[9].ToString();
                cmbTypeWork.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[10].ToString();
                txtDesignation.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[11].ToString();
                txtFax.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[14].ToString();
                txtMobile.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[8].ToString();
            }
            if (txtFName.Text == "")
            {
                if (cmbRelation.Text == "Son" || cmbRelation.Text == "Daughter")
                    txtFName.Text = txtFamilyLeader.Text;
                else
                    txtFName.Text = "";
            }
            if (txtHName.Text == "")
            {

                if (cmbRelation.Text == "Wife")
                    txtHName.Text = txtFamilyLeader.Text;
                else
                    txtHName.Text = "";
            }
        }

        private void txtDOBYear_TextChanged(object sender, EventArgs e)
        {
            if (txtDOBYear.Text != "")
                dpDOB.Enabled = false;
            else
                dpDOB.Enabled = true;
        }

        private void DGFamily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGFamily.CurrentRow.Selected = false;
        }

        private void txtFCardNo_TextChanged(object sender, EventArgs e)
        {

            if (txtFCardNo.Text == "")
            {
                btnFCardNo.Enabled = false;
            }
            else
            {
                btnFCardNo.Enabled = true;
                this.AcceptButton = btnFCardNo;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            cmbBGroup.Text = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cmbTypeWork.Text = null;
        }

        private void DGFamily_Sorted(object sender, EventArgs e)
        {
            int rows = DGFamily.Rows.Count;
            for (int x = 0; x < rows; x++)
            {
                string SNo = Convert.ToDecimal(x + 1).ToString("000");
                DGFamily.Rows[x].Cells[1].Value = SNo;
                DGFamily.RefreshEdit();

            }
        }

        private void dpDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;

            int days = dt.Day - dpDOB.Value.Day;
            if (days < 0)
            {
                dt = dt.AddMonths(-1);
                days += DateTime.DaysInMonth(dt.Year, dt.Month);
            }

            int months = dt.Month - dpDOB.Value.Month;
            if (months < 0)
            {
                dt = dt.AddYears(-1);
                months += 12;
            }

            int years = dt.Year - dpDOB.Value.Year;

            //string abc = string.Format("{0} year{1}, {2} month{3} and {4} day{5}",
            //                     years, (years == 1) ? "" : "s",
            //                     months, (months == 1) ? "" : "s",
            //                     days, (days == 1) ? "" : "s");

            if (years >= 18)
            {
                cmbAdult.Text = "Adult";
            }
            else
            {
                cmbAdult.Text = "Minor";
            }
        }

        private void btnActiveMembers_Click(object sender, EventArgs e)
        {
            DGFamily.CurrentRow.Selected = false;
            btnNonActiveMembers.Enabled = false;
            btnActiveMembers.Enabled = false;
            for (int i = 0; i < DGFamily.Rows.Count; i++)
            {
                DataGridViewRow row = DGFamily.Rows[i];

                row.Visible = Convert.ToBoolean(row.Cells["Active"].Value);
            }
            /*Community.DBLayer dblayer = new Community.DBLayer();
            string x = txtFCardNo.Text;
            string spName = "usp_SEL_tblFamilyMember";

            if (txtFCardNo.Text == "")
            {
                MessageBox.Show("Please Insert Family Card Number", "Family Card Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                bool result = dblayer.CheckFamily(txtFCardNo.Text);
                if (result)
                {
                    btnView.Enabled = true;
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

                    FillFamilyGrid(spName);
                }
            }*/

        }

        private void FillFamilyGrid(string spName)
        {
            Community.DBLayer dblayer = new Community.DBLayer();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(dblayer.CON_string);
            cmd.Connection = conn;
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FCardNo", txtFCardNo.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (DGFamily.DataSource != null)
            {
                DGFamily.DataSource = null;
            }
            DGFamily.DataSource = dt;

            int rows = DGFamily.Rows.Count;
            for (int count = 0; count < rows; count++)
            {

                string SNo = Convert.ToDecimal(count + 1).ToString("000");
                DGFamily.Rows[count].Cells[1].Value = SNo;
                DGFamily.RefreshEdit();
            }

            if (DGFamily.RowCount == 0)
            {
                DGFamily.Enabled = false;
            }
            else
            {
                DGFamily.Enabled = true;
            }
        }

        private void btnNonActiveMembers_Click(object sender, EventArgs e)
        {
            DGFamily.CurrentRow.Selected = false;
            btnActiveMembers.Enabled = false;
            btnNonActiveMembers.Enabled = false;
            //DGFamily.SelectedRows[0].Selected = false;


            for (int i = 0; i < DGFamily.Rows.Count; i++)
            {
                DataGridViewRow row = DGFamily.Rows[i];
                if (!Convert.ToBoolean(row.Cells["Active"].Value))
                {
                    row.Selected = true;
                    row.Visible = true;
                    DGFamily.ClearSelection();
                }
                else
                {
                    CurrencyManager c = (CurrencyManager)BindingContext[DGFamily.DataSource];
                    c.SuspendBinding();
                    row.Visible = false;
                    c.ResumeBinding();
                    DGFamily.ClearSelection();
                }

            }


            /*Community.DBLayer dblayer = new Community.DBLayer();
            SqlConnection conn = new SqlConnection(dblayer.CON_string);
            string x = txtFCardNo.Text;
            string spName = "usp_SEL_NonActive_tblFamilyMembers";

            if (txtFCardNo.Text == "")
            {
                MessageBox.Show("Please Insert Family Card Number", "Family Card Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                bool result = dblayer.CheckFamily(txtFCardNo.Text);
                if (result)
                {
                    btnView.Enabled = true;
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

                    FillFamilyGrid(spName);
                }
            }*/
        }

        //END--------------------------------------------------------------
        //-----------------------------------------------------------------                                                                                                                                   
    }
}

