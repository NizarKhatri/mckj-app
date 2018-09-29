using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Community;

namespace MCKJ
{
    public partial class frmBirthRegistration : Form
    {
        public frmBirthRegistration()
        {
            InitializeComponent();
        }
        int mode = 0;
        int id = 0;
        int exit = 0;
        int MemberID = 0;
        string Mstatus = "";
        int UserID = Community.DBLayer.ID;
        int SecurityLevelID = 9;
        Community.DBLayer DBLayer = new Community.DBLayer();
        string Header = "Birth Registration";


        private int next()
        {
            int nextt = 0;
            SqlConnection con = new SqlConnection(DBLayer.CON_string);
            SqlCommand cmd = new SqlCommand("Select Max(Cast(RegNo as int)) From tblBirth", con);

            con.Open();

            nextt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            return nextt;

        }
        private void Fillcmb(string FCard)
        {
            try
            {
                cmbGFName.Items.Clear();
                cmbFName.Items.Clear();
                cmbMName.Items.Clear();


                SqlConnection con = new SqlConnection(DBLayer.CON_string);
                SqlCommand cmd = new SqlCommand("SELECT MemberName,Gender FROM tblFamilyMember WHERE FCardNo = '" + FCard + "' ORDER BY MemberName asc", con);

                cmd.CommandType = CommandType.Text;
                con.Close();
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gender = reader.GetValue(1).ToString();
                    if (gender == "Male")
                    {
                        cmbGFName.Items.Add(reader.GetValue(0));
                        cmbFName.Items.Add(reader.GetValue(0));
                    }
                    else
                        cmbMName.Items.Add(reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private void frmBirthRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_Birth' table. You can move, or remove it, as needed.
            this.usp_SEL_BirthTableAdapter.Fill(this.comDataSet.usp_SEL_Birth);
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
            dgvBirth.BringToFront();


        }

        private bool CheckField()
        {
            if (txtRegNo.Text == "" || txtName.Text == "" || cmbFName.Text == "" || cmbMName.Text == "" || txtFCardNo.Text == "" || cmbGender.Text == "" || cmbRelation.Text == "")
            {
                MessageBox.Show("Please fill required fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
            else
                return true;
        }

        private void EmptyFields()
        {
            txtAddress.Text = "";
            txtBirthPlace.Text = "";
            txtFCardNo.Text = "";
            txtOrakh.Text = "";
            txtNukh.Text = "";
            txtRegNo.Text = "";
            txtName.Text = "";
            cmbFName.Text = "";
            cmbGFName.Text = "";
            cmbMName.Text = "";
            txtNadraRegNo.Text = "";
            cmbAgeGroup.Text = "Minor";
            cmbGender.Text = null;
            cmbRelation.Text = null;
            dtpDOB.Text = null;
            dtpEntryDate.Text = null;
        }

        private void Gayab(bool A)
        {
            dgvBirth.Visible = A;
            btnNew.Enabled = A;
            btnEdit.Enabled = A;
            btnDelete.Enabled = A;
            btnView.Enabled = A;
           // btnClose.Visible = A;
            txtFilter.Enabled = A;
            btnSearch.Enabled = A;
            label16.Visible = A;
        }

        private void Read_Only(bool B)
        {

            txtAddress.ReadOnly = B;
            txtBirthPlace.ReadOnly = B;
            txtFCardNo.ReadOnly = B;
            txtOrakh.ReadOnly = B;
            txtNukh.ReadOnly = B;
            txtRegNo.ReadOnly = B;
            txtName.ReadOnly = B;
            cmbFName.Enabled = !B;
            cmbGFName.Enabled = !B;
            cmbMName.Enabled = !B;
            //cmbAgeGroup.Enabled != B;
            //cmbGender.Enabled != B;
            //cmbRelation.Enabled != B;
            //dtpDOB.Enabled != B;
            //dtpEntryDate.Enabled != B;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmptyFields();
            mode = 1;          
            AcceptButton = btnSave;
            Gayab(false);
            txtRegNo.Text = next().ToString("00000");
            lbl.Text = Header + ">>Adding";
        }

        private int getMemberId(string FCardNo, string Name)
        {
            try
            {

                SqlConnection con = new SqlConnection(DBLayer.CON_string);
                con.Open();
                string sql = "select familymemberid from tblFamilyMember where fcardno = '" + FCardNo + "' and membername = '" + Name + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                return 0;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBirth.Rows.Count != 0)
            {
                usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, txtFCardNo.Text, txtName.Text);
                Mstatus = comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[27].ToString();
                MemberID = Convert.ToInt32(comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[0].ToString());
                MemberID = getMemberId(txtFCardNo.Text, txtName.Text);
                if (MemberID == 0)
                {
                    return;
                }
                if (dgvBirth.Rows.Count != 0)
                    id = Convert.ToInt32(dgvBirth.CurrentRow.Cells[0].Value.ToString());
                lbl.Text = Header + ">>Modifing";
                mode = 0;
                Gayab(false);
                btnReset.Hide();
                txtRegNo.ReadOnly = true;
                AcceptButton = btnSave;
            }
            else
                MessageBox.Show("No record for modifing", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           bool CHK =  DBLayer.CHK_RegNo(txtRegNo.Text);
            try
            {
                string RegNo = txtRegNo.Text;
                string Name = txtName.Text;
                string FName = cmbFName.Text;
                string MName = cmbMName.Text;
                string GFName = cmbGFName.Text;
                string FCardNo = txtFCardNo.Text;
                string Orakh = txtOrakh.Text;
                string Nukh = txtNukh.Text;
                string Gender = cmbGender.Text;
                string AgeGroup = cmbAgeGroup.Text;
                string Relation = cmbRelation.Text;
                DateTime DOB = Convert.ToDateTime(dtpDOB.Text);
                DateTime EntryDate = Convert.ToDateTime(dtpEntryDate.Text);
                string Place = txtBirthPlace.Text;
                string Address = txtAddress.Text;
                DateTime BTime = Convert.ToDateTime(dtpbTime.Text);
                string NadraRegNo = txtNadraRegNo.Text;
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
                            usp_SEL_BirthTableAdapter.InsertBirth(RegNo, FCardNo, Name, FName, MName, GFName, Nukh, Orakh, Gender, DOB, Relation, AgeGroup, Place, Address, EntryDate,BTime,NadraRegNo,new DBLayer().GetUserID());
                            usp_SEL_tblFamilyMemberTableAdapter.Insert1(FCardNo, Name, Relation, FName, "", DOB.ToString("dd/MM/yyyy"), "", Gender, AgeGroup, "", "", "", "", "", "", "", "", "", "", "", "", "", "", true, "", null, "Single", "", EntryDate, "", "", Convert.ToDateTime(DOB.ToString("dd-MM-yyyy")), "", "", "", DBLayer.GetUserID());
                            MessageBox.Show("Succesfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Gayab(true);
                            mode = 0;
                            usp_SEL_BirthTableAdapter.Fill(comDataSet.usp_SEL_Birth);
                        }
                        
                    }
                    else if (mode == 0)
                    {
                        usp_SEL_BirthTableAdapter.UpdateBirth(id, RegNo, FCardNo, Name, FName, MName, GFName, Nukh, Orakh, Gender, DOB, Relation, AgeGroup, Place, Address, EntryDate, BTime, NadraRegNo,new DBLayer().GetUserID());
                        usp_SEL_tblFamilyMemberTableAdapter.Update_Birth(FCardNo, Name, Relation, FName, DOB.ToString("dd/MM/yyyy"), Gender, AgeGroup, true, Mstatus, EntryDate,MemberID);
                        MessageBox.Show("Succesfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Gayab(true);
                        mode = 0;
                        btnReset.Show();
                        usp_SEL_BirthTableAdapter.Fill(comDataSet.usp_SEL_Birth);
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please insert valid values in respective fields!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AcceptButton = btnNew;
            txtFilter.Focus();
            lbl.Text = Header;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EmptyFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (exit == 1)
            {
                Read_Only(false);
                Gayab(true);
                btnSave.Show();
                btnCancel.Show();
                btnReset.Show();
                btnClose.Show();
                exit = 0;
                lbl.Text = Header;
            }
            else
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Read_Only(true);
            Gayab(false);
            btnSave.Hide();
            btnCancel.Hide();
            btnReset.Hide();
            btnClose.Show();
            exit = 1;
            AcceptButton = btnClose;
            lbl.Text = Header + ">>Preview";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Gayab(true);
                btnReset.Show();
                mode = 0;
                usp_SEL_BirthTableAdapter.Fill(comDataSet.usp_SEL_Birth);
                AcceptButton = btnNew;
                txtFilter.Focus();
                lbl.Text = Header;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            return;

            if (dgvBirth.Rows.Count != 0)
            {
                lbl.Text = Header + ">>Deleting";

                usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, txtFCardNo.Text, txtName.Text);
                DialogResult result = MessageBox.Show("Are you sure you want to delete??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    id = Convert.ToInt32(dgvBirth.CurrentRow.Cells[0].Value.ToString());
                    MemberID = Convert.ToInt32(comDataSet.usp_SEL_TSF_tblFamilyMember.Rows[0].ItemArray[0].ToString());
                    usp_SEL_tblFamilyMemberTableAdapter.Delete1(MemberID);
                    usp_SEL_BirthTableAdapter.DeleteBirth(id);
                    MessageBox.Show("Sucessfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usp_SEL_BirthTableAdapter.Fill(comDataSet.usp_SEL_Birth);
                    AcceptButton = btnNew;
                    txtFilter.Focus();
                    lbl.Text = Header;
                }
                else
                {
                    lbl.Text = Header;
                }

            }
            else
                MessageBox.Show("No Record for Deleting!!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
            if (txtFilter.Text == "")
                usp_SEL_BirthTableAdapter.Fill(comDataSet.usp_SEL_Birth);      
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                txtFilter_Leave(sender, e);
            try
            {
                
                uspSELBirthBindingSource.Filter = "RegNo='" + txtFilter.Text + "'";
                AcceptButton = btnEdit;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill valid values in respetive fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtRegNo_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (txtRegNo.Text != "")
                //{ds
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
                    usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, txtFCardNo.Text);
                    if (comDataSet.usp_SEL_FAMILY.Rows.Count != 0)
                    {
                        Fillcmb(txtFCardNo.Text);
                        txtOrakh.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[17].ToString();
                        txtNukh.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[18].ToString();
                        txtAddress.Text = comDataSet.usp_SEL_FAMILY.Rows[0].ItemArray[6].ToString();
                        //Dont show any text on these combo boxes
                        cmbFName.SelectedIndex = -1;
                        cmbMName.SelectedIndex = -1;
                        cmbGFName.SelectedIndex = -1;
                        //Clean text if selected in previous record
                        cmbFName.Text = "";
                        cmbMName.Text = "";
                        cmbGFName.Text = "";
        
                    }
                    else
                        MessageBox.Show("Family Card doesnot exist!", "Card not found", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dgvBirth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblgo_Click(object sender, EventArgs e)
        {
            MCKJ.frmFamily_Member frm = new frmFamily_Member();
            frm.Show();
            this.Close();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
            

        }
    }