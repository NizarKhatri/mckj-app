using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Community;

namespace MCKJ
{
    public partial class frmTransfer : Form
    {        
        public frmTransfer()
        {
            InitializeComponent();
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
            
            txtFax.ReadOnly = ReadOnly;
            txtFCardNo.ReadOnly = ReadOnly;
            txtFName.ReadOnly = ReadOnly;
            txtHName.ReadOnly = ReadOnly;
            txtMobile.ReadOnly = ReadOnly;
            txtName.ReadOnly = ReadOnly;
            
            txtProfessionalEdu.ReadOnly = ReadOnly;
            txtTechnicalEdu.ReadOnly = ReadOnly;
            txtTypeWork.ReadOnly = ReadOnly;
            txtWebsite.ReadOnly = ReadOnly;
        }       
        int mode = 0;
        int exit = 0;
     
        private bool CheckFields()
        {
            if (txtFCardNoT.Text == "" || txtHName.Text == "" || txtRelation.Text == "")
            {

                MessageBox.Show("Fields cannot be empty", "Information", MessageBoxButtons.OK);
                return false;
            }
            else
                return true;
        }
     
        private void btnFCardNo_Click(object sender, EventArgs e)
        {
            rbDeath.Enabled = true;
            rbMarriage.Enabled = true;
            rbMarriageOutside.Enabled = true;
            rbNewCard.Enabled = true;
            rbDivorce.Enabled = true;

            Community.DBLayer DBLayer = new Community.DBLayer();
            string  ID = txtFCardNo.Text;
            string Name = this.txtMemberName.Text;
            bool result = DBLayer.TRANSFER(ID, Name);
            if (txtMemberName.Text == "" || txtFCardNo.Text == "00000")
            {
                MessageBox.Show("Please fill the field!", "Error");
            }
            else
            {
                    if (result)
                    {
                        this.Width = 628;
                        this.Height = 358;
                        this.CenterToScreen();
                      
                        txtMemberName.Enabled=false;
                        btnFCardNo.Enabled = false;
                        //label19.Hide();
                        grbMain.Show();
                        ReadOnly(true);
                        grBox1.Show();
                        grBox1.Enabled = true;
                        rbDivorce.Enabled = true;
                        txtFCardNo.ReadOnly = true;
                        if (rbActive.Checked)
                            dpIncident.Text = DateTime.Today.ToShortDateString();

                        usp_SEL_TSF_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_TSF_tblFamilyMember, ID, Name);                      
                       // usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, ID);
                    }
                    else
                    {
                        MessageBox.Show("Member Not Found! May be Inactive or not Exist in " + "'" + txtFCardNo.Text + "'" + " .", "Unable to Search");
                    }
                    if (rbActive.Checked == false)
                        rbInActive.Checked = true;
            }   
        }        
       
        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActive.Checked)
            {
                grBox2.Enabled = false;
                grBox3.Enabled = false;

                if (txtGender.Text == "Male")
                {
                    
                    rbDeath.Enabled = true;
                    rbMarriage.Enabled = false;
                    rbMarriageOutside.Checked = false;
                    rbDivorce.Enabled = false;
                }

            }

        }
       
        private void rbInActive_CheckedChanged(object sender, EventArgs e)
     
        {
            if (cmbMaritalStatus.Text == "Single" || cmbMaritalStatus.Text == "Widow")
            {
                rbDivorce.Enabled = false;
            }
            if (cmbMaritalStatus.Text == "Married")
            {
                rbMarriage.Enabled = false;
                rbMarriageOutside.Enabled = false;
            }
            if (rbInActive.Checked)
            {
                if (txtGender.Text == "Male")
                {
                    btnSubmit.Show();
                    btnCancel.Show();
                    grBox2.Enabled = true;
                    grBox3.Enabled = true;
                    rbDeath.Checked = true;
                    rbMarriage.Enabled = false;
                    rbMarriageOutside.Enabled = false;
                    rbDivorce.Enabled = false;
                }
                else
                {
                    grBox2.Enabled = true;
                    grBox3.Enabled = true;
                }
            }
        }
        
        private void rbMarriage_CheckedChanged(object sender, EventArgs e)
        {            
            if (rbMarriage.Checked)
            {

                //if (cmbMaritalStatus.Text == "Married")
                //{
                //    MessageBox.Show("Already Married", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);                    
                //    rbMarriage.Checked = false;
                //    rbDivorce.Enabled = true;
                //    boxTransfer.Hide();
                //}
                //else
                //{
                //    mode = 1;
                //    boxTransfer.Show();
                //    btnSubmit.Hide();
                //    btnCancel.Hide();
                //}
                txtHNameT.Enabled = true;
                boxTransfer.Enabled = true;
                btnSubmit.Visible = false;
                btnCancel.Visible = false;
                mode = 1;
            }
            else
            {
                txtHName.Text = txtHNameT.Text;
                boxTransfer.Enabled = true;
                btnSubmit.Visible = false;
                btnCancel.Visible = false;
                mode = 1;
            }
            
        }

        private void rbDeath_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeath.Checked)
            {
                btnSubmit.Show();
                btnCancel.Show();
                boxTransfer.Enabled = false;
                grBox2.Enabled = true;
                grBox3.Enabled = true;
                
            }
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void rbDivorce_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDivorce.Checked)
            {

                if (txtReason.Text == "Divorced")
                {
                    MessageBox.Show("Already Divorced", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    rbActive.Checked = true;
                    rbDivorce.Checked = false;
                    boxTransfer.Enabled = false;
                }
                else
                {
                    txtHNameT.Enabled = false;
                    mode = 2;
                    boxTransfer.Enabled = true;
                    btnSubmit.Hide();
                    btnCancel.Hide();
                }
            }
            else
            {

                boxTransfer.Enabled = true;
                btnSubmit.Visible = false;
                btnCancel.Visible = false;

            }
        }
     
        private string Reason1()
        {
            string reason = "";

            if (rbDeath.Checked)
            {
                reason = rbDeath.Text;
            }
            else if (rbDivorce.Checked)
            {
                reason = rbDivorce.Text;
            }
            else if (rbMarriage.Checked)
            {
                reason = rbMarriage.Text;
            }
            else if (rbNewCard.Checked)
            {
                reason = rbNewCard.Text;
            }
            else if (rbMarriageOutside.Checked)
            {
                reason = rbMarriageOutside.Text;
            }
            return reason;
        }
      
        private void txtFCardNo_TextChanged(object sender, EventArgs e)
        {
            
            if (txtFCardNo.Text == "")
            {
                btnFCardNo.Enabled = false;
                txtMemberName.Enabled = false;
            }
            else
            {
                btnFCardNo.Enabled = true;
                this.AcceptButton = btnFCardNo;
                txtMemberName.Enabled = true;
            }
        }
     
        private void btnSubmit_Click(object sender, EventArgs e)
        {                        
                try
                {
                    int ID = Convert.ToInt32(txtMemberID.Text);
                    string FCardNo =txtFCardNo.Text;                    
                    string Academic = txtAcdemicEdu.Text;
                    string BAddress = txtBAddress.Text;
                    string Bgroup = txtBGroup.Text;
                    string BName = txtBName.Text;
                    string BPhone = txtBPhone.Text;
                    string Gender = txtGender.Text;
                    string AgeGroup = txtAdult.Text;
                    string CMIC = txtCMIC.Text;
                    string CNIC = txtCNIC.Text;
                    string Designation = txtDesignation.Text;
                    string Email = txtEmail.Text;
                    string Fax = txtFax.Text;
                    string Mobile = txtMobile.Text;
                    string Name = txtName.Text;
                    string Professional = txtProfessionalEdu.Text;
                    string Technical = txtTechnicalEdu.Text;
                    string Type = txtTypeWork.Text;
                    string Website = txtWebsite.Text;
                    string DOB = txtDOBYear.Text;
                    string LRealation = txtRelation.Text;                   
                    string FName = txtFName.Text;                   
                    bool Active = rbActive.Checked;                    
                    string Reason = Reason1();
                    string Status = cmbMaritalStatus.Text;
                    string OutOf = cmbOutof.SelectedText;
                    DateTime Incident = Convert.ToDateTime(dpIncident.Text);
                    DateTime EntryDate = Convert.ToDateTime(dpEntryDate.Text);
                    string FromCard = txtFromCard.Text;
                    string ToCard = txtToCard.Text;
                    string TempDOB = Convert.ToDateTime(DOB).ToString("dd-MM-yyyy");
                    string HusbandName = txtHName.Text;


                    //btnCancel.Visible = false;
                    //btnSubmit.Visible = false;
                    txtFCardNo.Enabled = true;
                    boxTransfer.Visible = false;
                    if (rbActive.Checked)
                    {
                        usp_SEL_tblFamilyMemberTableAdapter.Update1(ID, FCardNo, Name, LRealation, FName, HusbandName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, "", Incident, Status, OutOf, EntryDate, FromCard, ToCard, Convert.ToDateTime(TempDOB), "", "", "", new DBLayer().GetUserID());
                    }
                    else
                    {
                        usp_SEL_tblFamilyMemberTableAdapter.Update1(ID, FCardNo, Name, LRealation, FName, HusbandName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, Reason, Incident, Status, OutOf, EntryDate, FromCard, ToCard, Convert.ToDateTime(TempDOB), "", "", "", new DBLayer().GetUserID());
                    }
                    MessageBox.Show("Updated Successfully!", "Success");
                    exit = 1;
                    btnCancel_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
        }
           

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (exit == 1)
            {
                txtHNameT.Enabled = true;
                txtFCardNo.ReadOnly = false;
                txtMemberName.Show();
                btnFCardNo.Show();
                label19.Show();
                grbMain.Hide();
                grbMain.Enabled = true;
                grBox1.Show();
                grBox1.Enabled = false;
                rbDivorce.Enabled = false;
                txtFCardNo.Enabled = true;
                //txtFCardNo.Text = "00000";
                txtMemberName.Text = null;
                grBox2.Show();
                grBox3.Show();              
                //this.Width = 304;
                //this.Height = 139;
                boxTransfer.Show();
                boxTransfer.Enabled = false;
                CenterToScreen();
                btnSubmit.Show();
                btnCancel.Show();
                // this.Top = 250;
                exit = 0;
                usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, "00000");
            }
            else
            {
                DialogResult Result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    txtFCardNo.ReadOnly = false;
                    txtMemberName.Show();
                    btnFCardNo.Show();
                    label19.Show();
                    grbMain.Hide();
                    grbMain.Enabled = true;
                    //grBox1.Hide();
                    grBox1.Enabled = true;
                    rbDivorce.Enabled = true;
                    txtFCardNo.Enabled = true;
                    txtFCardNo.Text = "";
                    txtMemberName.Text = null;
                    grBox2.Enabled = true;
                    grBox3.Enabled = true;
                    //this.Width = 304;
                    //this.Height = 139;
                    CenterToScreen();
                    // this.Top = 250;
                    
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
                MessageBox.Show("Only numbers are allowed!","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
       
        private void txtMemberName_Enter(object sender, EventArgs e)
        {
            Community.DBLayer dbLayer = new Community.DBLayer();

            bool Result = dbLayer.CheckFamily(txtFCardNo.Text);
            if (Result)
            {
                usp_SEL_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_SEL_tblFamilyMember, txtFCardNo.Text);
                if (txtMemberName.Text == "")
                {
                    MessageBox.Show("No Member Found!","Unable to Find");
                    btnFCardNo.Enabled = false;
                }
                else
                    btnFCardNo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Card Does Not Exist!");
                txtMemberName.Text= "";
                btnFCardNo.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Community.DBLayer Chk = new Community.DBLayer();
            Community.DBLayer dblayer = new Community.DBLayer();
            txtHName.Text = txtHNameT.Text;
           
                try
                {

                    int ID = Convert.ToInt32(txtMemberID.Text);
                    string FCardNo = txtFCardNo.Text;
                    string FCardNoT = txtFCardNoT.Text;
                    string Academic = txtAcdemicEdu.Text;
                    string BAddress = txtBAddress.Text;
                    string Bgroup = txtBGroup.Text;
                    string BName = txtBName.Text;
                    string BPhone = txtBPhone.Text;
                    string Gender = txtGender.Text;
                    string AgeGroup = txtAdult.Text;
                    string CMIC = txtCMIC.Text;
                    string CNIC = txtCNIC.Text;
                    string Designation = txtDesignation.Text;
                    string Email = txtEmail.Text;
                    string Fax = txtFax.Text;
                    string Mobile = txtMobile.Text;
                    string Name = txtName.Text;
                    string Professional = txtProfessionalEdu.Text;
                    string Technical = txtTechnicalEdu.Text;
                    string Type = txtTypeWork.Text;
                    string Website = txtWebsite.Text;
                    string DOB = txtDOBYear.Text;
                    string LRealation = txtRelation.Text;
                    string LRelationT = cmbRelationT.Text;
                    string FName = txtFName.Text;
                    string HName = txtHNameT.Text;
                    bool Active = rbActive.Checked;
                    bool ActiveT = rbActiveT.Checked;
                    string Reason = Reason1();
                    DateTime Incident = Convert.ToDateTime(dpIncident.Text);
                    string Status = cmbMaritalStatus.Text;
                    string OutOf = cmbOutof.SelectedText;
                    DateTime EntryDate = Convert.ToDateTime(dpEntryDate.Text);
                    string FromCard = "";
                    if (txtFromCard.Text != "")
                    {
                        FromCard = txtFromCard.Text + " , " + txtFCardNoT.Text;
                    }
                    else
                    {
                        FromCard = txtFCardNo.Text;
                    }
                    string ToCard = "";
                    if (txtToCard.Text != "")
                    {
                        ToCard = txtToCard + " , " + txtFCardNoT.Text; 
                    }
                    else
                    {
                        ToCard = txtFCardNoT.Text;
                    }
                    string TempDOB = Convert.ToDateTime(DOB).ToString("dd-MM-yyyy");
                    DialogResult Confirm = MessageBox.Show("Are you sure??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //    bool Result1 = Chk.CHK_DVC(FCardNoT, LRelationT, HName);
                    bool Result2 = dblayer.CheckFamily(FCardNoT);
                    if (Result2 == false)
                    {
                        MessageBox.Show("Family Card No Does Not Exist! Please Insert Valid Card Number", "Error");
                    }
                    else
                    {

                        if (mode == 1 || mode == 2)
                        {
                            if (CheckFields())
                            {

                                if (Confirm == DialogResult.Yes)
                                {
                                    btnCancel.Visible = false;
                                    btnSubmit.Visible = false;
                                    txtFCardNo.Enabled = true;
                                    boxTransfer.Visible = false;
                                    usp_SEL_tblFamilyMemberTableAdapter.Update1(ID, FCardNo, Name, LRealation, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, Reason, Incident, Status, OutOf, EntryDate, txtFromCard.Text, ToCard, Convert.ToDateTime(TempDOB), "", "", "", new DBLayer().GetUserID());
                                    usp_SEL_tblFamilyMemberTableAdapter.Insert1(FCardNoT, Name, LRelationT, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, ActiveT, Reason, Incident, Status, OutOf, EntryDate, FromCard, txtToCard.Text, Convert.ToDateTime(TempDOB), "", "", "", new DBLayer().GetUserID());
                                    MessageBox.Show("Transferred Succesfully!", "Success");
                                    exit = 1;
                                    btnCancel_Click(sender, e);
                                }
                            }
                        }
                        else if (mode == 3)
                        {
                            if (txtFCardNoT.Text != "" && cmbRelationT.Text != "")
                            {
                                if (Confirm == DialogResult.Yes)
                                {
                                    btnCancel.Visible = false;
                                    btnSubmit.Visible = false;
                                    txtFCardNo.Enabled = true;
                                    boxTransfer.Visible = false;
                                    usp_SEL_tblFamilyMemberTableAdapter.Update1(ID, FCardNo, Name, LRealation, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, Reason, Incident, Status, OutOf, EntryDate, FromCard, ToCard, Convert.ToDateTime(TempDOB), "", "", "", new DBLayer().GetUserID());
                                    usp_SEL_tblFamilyMemberTableAdapter.Insert1(FCardNoT, Name, LRelationT, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, ActiveT, Reason, Incident, Status, OutOf, EntryDate, FromCard, ToCard, Convert.ToDateTime(TempDOB), "", "", "", new DBLayer().GetUserID());
                                    MessageBox.Show("Transferred Succesfully!", "Success");
                                    exit = 1;
                                    btnCancel_Click(sender, e);
                                }
                            }
                            else
                                MessageBox.Show("Fields could not be left Blank!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                            
                        
                        //else if (mode == 2)
                        //{
                        //    if (Confirm = DialogResult.Yes)
                        //{
                        //    btnCancel.Visible = false;
                        //    btnSubmit.Visible = false;
                        //    txtFCardNo.Enabled = true;
                        //    boxTransfer.Visible = false;
                        //    usp_SEL_tblFamilyMemberTableAdapter.Update1(ID, FCardNo, Name, LRealation, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, Active, Reason, Incident, Status, OutOf, EntryDate);
                        //    usp_SEL_tblFamilyMemberTableAdapter.Insert1(FCardNoT, Name, LRelationT, FName, HName, DOB, Bgroup, Gender, AgeGroup, Mobile, CNIC, CMIC, Academic, Technical, Professional, BName, Type, Designation, BAddress, BPhone, Email, Website, Fax, ActiveT, Reason, Incident, Status, OutOf, EntryDate);
                        //    MessageBox.Show("Transferred Succesfully!", "Success");
                        //    exit = 1;
                        //    btnCancel_Click(sender, e);
                        //}

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
        }

        private void btnCancelT_Click(object sender, EventArgs e)
        {
            rbMarriage.Checked = false;
            rbMarriageOutside.Checked = false;
            rbDivorce.Checked = false;
            btnCancel.Hide();
            btnSubmit.Hide();
            rbActive.Checked = true;
            boxTransfer.Hide();
            txtFCardNoT.Text = "00000";
        }

        private void txtFCardNoT_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtFCardNoT.Text != "")
                {
                    int fcardno = Convert.ToInt32(txtFCardNoT.Text);
                    int x = 5 - txtFCardNoT.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    txtFCardNoT.Text = zeros + txtFCardNoT.Text;
                    btnFCardNo.Enabled = true;
                    if (txtGender.Text == "Female")
                    {
                        usp_Male_tblFamilyMemberTableAdapter.Fill(comDataSet.usp_Male_tblFamilyMember, txtFCardNoT.Text, "Male");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!");
            }
        }

        private void rbNewCard_CheckedChanged(object sender, EventArgs e)
        {          
                boxTransfer.Visible = true;
                boxTransfer.Enabled = true;
                btnSubmit.Visible = false;
                btnCancel.Visible = false;
                txtHNameT.Enabled = false;
                mode = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Top.ToString() + "  " + this.Left.ToString());
        }

        private void rbMarriageOutside_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMarriageOutside.Checked)
            {

                //if (cmbMaritalStatus.Text == "Married")
                //{
                //    MessageBox.Show("Already Married", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);                    
                //    rbMarriage.Checked = false;
                //    rbDivorce.Enabled = true;
                //    boxTransfer.Hide();
                //}
                //else
                //{
                //    mode = 1;
                //    boxTransfer.Show();
                //    btnSubmit.Hide();
                //    btnCancel.Hide();
                //}
                txtHNameT.Enabled = true;
                boxTransfer.Enabled = true;
                btnSubmit.Visible = false;
                btnCancel.Visible = false;
                mode = 1;
            }
            else
            {
                txtHName.Text = txtHNameT.Text;
                boxTransfer.Enabled = true;
                btnSubmit.Visible = false;
                btnCancel.Visible = false;
                mode = 1;
            }
        }
       
        
       

                             
    }
}