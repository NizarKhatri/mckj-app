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
    public partial class frmFamily : Form
    {
        public frmFamily()
        {
            InitializeComponent();
        }                       
      
        //Variables--------------------------------------------------------
        //-----------------------------------------------------------------                                                      
     
        int mode = 0;
        int Exit = 0;
        string chk_active = "";
        int SecurityLevelID = 3;
        int UserID = Community.DBLayer.ID;
        bool rNew = false;
        bool rEdit = false;
        bool rDelete = false;
        Community.DBLayer DBLayer = new Community.DBLayer();
        string Header = "Family Cards";

        //Functions--------------------------------------------------------
        //-----------------------------------------------------------------

        

        private void User_Right()
        {
            Community.DBLayer DBLayer = new Community.DBLayer();           
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("Select Write,Modify,[Delete] from tblPermission  Where UserID =" + UserID + " And SecurityLevelID= " + SecurityLevelID, con);
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
                reader.Close();
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

        private string Year()
        {
            string Year = "";

            if (txtDOBYear.Text != "")
                Year = txtDOBYear.Text;
            else
            {
                DateTime chk =Convert.ToDateTime(dpDOB.Text);
                Year = chk.Day.ToString("00") + "/" + chk.Month.ToString("00") + "/" + chk.Year;
            }
            return Year;
        }

        private void Disable_Btn(bool disable)
        {
            btnAdd.Enabled = disable;
            btnAll.Enabled = disable;
            btnDelete.Enabled = disable;
            btnEdit.Enabled = disable;
            btnSearch.Enabled = disable;
            btnView.Enabled = disable;
            DGFamily.Visible = disable;
            btnActive.Enabled = disable;
            lblgo.Enabled = disable;
            textBox1.Enabled = disable;
        }
        private void ReadOnly(bool ReadOnly)
        {
            txtBAddress.ReadOnly = ReadOnly;
            txtBName.ReadOnly = ReadOnly;
            txtBPhone.ReadOnly = ReadOnly;
            txtDesignation.ReadOnly = ReadOnly;
            txtEmail.ReadOnly = ReadOnly;
            txtFamilyLeader.ReadOnly = ReadOnly;
            txtFax.ReadOnly = ReadOnly;
            txtFCardNo.ReadOnly = ReadOnly;
            txtMobile.ReadOnly = ReadOnly;
            txtWebsite.ReadOnly = ReadOnly;
            txtAddress.ReadOnly = ReadOnly;
            txtFamilyName.ReadOnly = ReadOnly;
            txtCountry.ReadOnly = ReadOnly;
            txtDOBYear.ReadOnly = ReadOnly;
        }
        
        private void Disable(bool Disable)
        {
            cmbArea.Enabled = Disable;
            cmbCity.Enabled = Disable;
            cmbArea.Enabled = Disable;
            cmbGender.Enabled = Disable;
            cmbNukh.Enabled = Disable;
            cmbSign.Enabled = Disable;
            cmbVillage.Enabled = Disable;
            dpDOB.Enabled = Disable;
            cmbType.Enabled = Disable;
            dpIssueDate.Enabled = Disable;
            dpDOB.Visible = Disable;
        }
        
        private void EmptyFields()
        {
            cmbGender.Text = "";
            txtAddress.Text = "";
            cmbArea.Text = null;
            txtBAddress.Text = "";
            txtBName.Text = "";
            txtBPhone.Text = "";
            cmbCity.Text = null;
            txtCountry.Text = "Pakistan";
            txtDesignation.Text = "";
            txtEmail.Text = "";
            txtFamilyLeader.Text = "";
            txtFamilyName.Text = "";
            txtFax.Text = "";
            txtMobile.Text = "";
            cmbNukh.Text = null;
            txtPhone.Text = "";
            cmbSign.Text = null;
            cmbType.Text = null;
            cmbVillage.Text = null;
            txtWebsite.Text = "";
            txtFCardNo.Text = "";
            dpDOB.Text = null;
            txtDOBYear.Text = "";
           // dpIssueDate.Text = null;
        }

        private bool CheckFields()
        {
            if (txtFCardNo.Text == "" || txtFamilyName.Text == "" || txtFamilyLeader.Text == "" || cmbNukh.Text == "" || cmbSign.Text == "" || cmbGender.Text == "") //|| txtParentFCardNo.Text == "" || txtRenewalDueFrom.Text == "")
            {
                MessageBox.Show("Required Fields cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
                return true;

        }

        //WorkStation------------------------------------------------------
        //-----------------------------------------------------------------      
        
        private void frmFamily_Load(object sender, EventArgs e)
        {
            DGFamily.BringToFront();
            this.Top = 48;
            if (DBLayer.User_Right(UserID,SecurityLevelID,"[Modify]"))
            {
                btnEdit.Enabled = true;
                btnActive.Enabled = true;
            }            

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Delete]"))
                btnDelete.Enabled = true;
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnAdd.Enabled = true;
            
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblWorkType' table. You can move, or remove it, as needed.
            this.usp_SEL_tblWorkTypeTableAdapter.Fill(this.comDataSet.usp_SEL_tblWorkType);
            
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblArea' table. You can move, or remove it, as needed.
            this.usp_SEL_tblAreaTableAdapter.Fill(this.comDataSet.usp_SEL_tblArea);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblCity' table. You can move, or remove it, as needed.
            this.usp_SEL_tblCityTableAdapter.Fill(this.comDataSet.usp_SEL_tblCity);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblOrakh' table. You can move, or remove it, as needed.
            this.usp_SEL_tblOrakhTableAdapter.Fill(this.comDataSet.usp_SEL_tblOrakh);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblVillage' table. You can move, or remove it, as needed.
            this.usp_SEL_tblVillageTableAdapter.Fill(this.comDataSet.usp_SEL_tblVillage);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_tblNukh' table. You can move, or remove it, as needed.
            this.usp_SEL_tblNukhTableAdapter.Fill(this.comDataSet.usp_SEL_tblNukh);
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_FAMILY' table. You can move, or remove it, as needed.
               this.usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
            btnAdd.Focus();
            this.AcceptButton = btnAdd;
            dpIssueDate.Text = DateTime.Now.ToString();
        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dpDOB.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
           // Hide(true);
            EmptyFields();
            txtFCardNo.Enabled = true;                      
            grbSearch.Hide();           
            mode = 1;
            grb1.Show();
            Disable_Btn(false);
            txtFCardNo.ReadOnly = false;
            //btnClose.Visible = false;
            this.AcceptButton = btnSubmit;
            txtFCardNo.Focus();
            lbl.Text = Header + ">>Add Card";
        }            
      
        private void btnReset_Click(object sender, EventArgs e)
        {
            EmptyFields();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DGFamily.Rows.Count != 0)
            {
                chk_active = DGFamily.CurrentRow.Cells[14].Value.ToString();
                txtParentFCardNo.Text = DGFamily.CurrentRow.Cells[15].Value.ToString();
                txtRenewalDueFrom.Text = DGFamily.CurrentRow.Cells[18].Value.ToString();
                if (txtDOBYear.Text.Length != 4)
                {
                    txtDOBYear.Text = "";
                }
                else
                    dpDOB.Enabled = false;
                btnActive.Hide();
                grbSearch.Hide();                
                btnReset.Enabled = false;
                txtFCardNo.ReadOnly = true;
                Disable_Btn(false);
                //btnClose.Visible = false;
                //DGFamily.Visible = false;
                //btnEdit.Visible = false;
                //btnDelete.Visible = false;
                //// Hide(true);
                //btnAdd.Visible = false;
                this.AcceptButton = btnSubmit;
                lbl.Text = Header + ">>Modify Card";
            }
            else
                MessageBox.Show("No Record to Modify", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Cancel", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                mode = 0;
              //  Hide(false);
               
                grb1.Hide();
                btnActive.Show();
                grbSearch.Show();
                Disable_Btn(true);
                usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
                this.AcceptButton = btnAdd;
                lbl.Text = Header;
                btnReset.Enabled = true;
            }
    
        }
                     
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Community.DBLayer dblayer = new Community.DBLayer();
            if (CheckFields())
            {
                try
                {                   
                    string Gender = cmbGender.Text;
                    DateTime IssueDate = Convert.ToDateTime(dpIssueDate.Text);
                    string DOB = Year();
                    string Address = txtAddress.Text;
                    string Area = cmbArea.Text;
                    string BAddress = txtBAddress.Text;
                    string BName = txtBName.Text;
                    string BPhone = txtBPhone.Text;
                    string City = cmbCity.Text;
                    string Country = txtCountry.Text;
                    string Designattion = txtDesignation.Text;
                    string Email = txtEmail.Text;
                    string Leader = txtFamilyLeader.Text;
                    string FamilyName = txtFamilyName.Text;
                    string Fax = txtFax.Text;
                    string FCardNo =txtFCardNo.Text;
                    string Mobile = txtMobile.Text;
                    string Nukh = cmbNukh.Text;
                    string Phone = txtPhone.Text;
                    string Sign = cmbSign.Text;
                    string TypeWork = cmbType.Text;
                    string Village = cmbVillage.Text;
                    string Website = txtWebsite.Text;
                    string ParentFCardNo = txtParentFCardNo.Text.PadLeft(5,'0');
                    string RenewalDueFrom = txtRenewalDueFrom.Text;
                         DialogResult Result = MessageBox.Show("Are you sure??", "Confirmation",MessageBoxButtons.YesNo);
                         if (Result == DialogResult.Yes)
                         {
                             if (mode == 1)
                             {
                                 bool result = dblayer.CheckFamily(txtFCardNo.Text);
                                 if (result)
                                 {
                                     MessageBox.Show("Family Card No already exist! Please insert new Card No", "Invalid Card No", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                     txtFCardNo.Focus();
                                 }
                                 else
                                 {
                                     usp_SEL_FAMILYTableAdapter.Insert1(FCardNo, IssueDate, FamilyName, Leader, Gender, DOB, Country, City, Nukh, Sign, Village, Area, Address, Phone, Mobile, BName, TypeWork, Designattion, BAddress, BPhone, Fax, Email, Website, true, ParentFCardNo, RenewalDueFrom,DBLayer.GetUserID());
                                     //usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
                                     MessageBox.Show("Saved Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                                    
                                     EmptyFields();
                                     txtFCardNo.Focus();
                                 }
                                 lbl.Text = Header;
                             }

                             else if (mode == 0)
                             {
                                 if (chk_active == "True")
                                 {
                                     usp_SEL_FAMILYTableAdapter.Update1(FCardNo, IssueDate, FamilyName, Leader, Gender, DOB, Country, City, Nukh, Sign, Village, Area, Address, Phone, Mobile, BName, TypeWork, Designattion, BAddress, BPhone, Fax, Email, Website, true, ParentFCardNo, RenewalDueFrom, DBLayer.GetUserID());
                                 }
                                 else
                                     usp_SEL_FAMILYTableAdapter.Update1(FCardNo, IssueDate, FamilyName, Leader, Gender, DOB, Country, City, Nukh, Sign, Village, Area, Address, Phone, Mobile, BName, TypeWork, Designattion, BAddress, BPhone, Fax, Email, Website, false, ParentFCardNo, RenewalDueFrom, DBLayer.GetUserID());

                                 //usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
                                 MessageBox.Show("Updated Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 txtFCardNo.Enabled = true;                                                                                                                            
                                 grb1.Hide();
                                 Disable_Btn(true);
                                 grbSearch.Show();                                 
                                 lbl.Text = Header;

                             }
                         }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.AcceptButton = btnAdd;  
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbl.Text = Header + ">>Deleting Card";
            Community.DBLayer DBLayer = new Community.DBLayer();
            bool DELETE = DBLayer.CHK_B4_DELETE(txtFCardNo.Text);
            if (DELETE)
            {
                MessageBox.Show("Cannot be Deleted! 'Already in use'", "Unable to Delete", MessageBoxButtons.OK);
                lbl.Text = Header;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string FCardNo = txtFCardNo.Text;
                        usp_SEL_FAMILYTableAdapter.Delete1(FCardNo);
                        usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
                        MessageBox.Show("Deleted Succesfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl.Text = Header;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                    lbl.Text = Header;
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Exit == 1)
            {
                DGFamily.Show();
                ReadOnly(false);
                btnView.Show();
                btnAdd.Show();
                btnActive.Show();
                btnCancel.Show();
                btnDelete.Show();
                btnEdit.Show();
                btnReset.Show();
                btnSubmit.Show();
                Exit = 0;
                Disable(true);
                this.AcceptButton = btnAdd;
                btnAll.Show();
                btnActive.Show();
                grbSearch.Show();
                lblgo.Enabled = true;
            }
            else    
              this.Close();            
        }
      
        private void btnView_Click(object sender, EventArgs e)
        {
            Disable(false);
            Exit = 1;
            ReadOnly(true);
           // Hide(true);
            btnAdd.Hide();           
            btnView.Hide();
            btnActive.Hide();
            btnDelete.Hide();            
            btnEdit.Hide();
            DGFamily.Hide();        
            btnCancel.Hide();
            btnSubmit.Hide();
            btnReset.Hide();
            btnClose.Focus();
            btnActive.Hide();
            grbSearch.Hide();
            btnAll.Hide();
            lblgo.Enabled = false;
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
                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");

            }
        }

        private void txtDOBYear_TextChanged(object sender, EventArgs e)
        {
            if (txtDOBYear.Text != "")
                dpDOB.Enabled = false;
            else
                dpDOB.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string cardno = DGFamily.CurrentRow.Cells[0].Value.ToString();
            MCKJ.FamilyCard.frm frm = new MCKJ.FamilyCard.frm();

            if (DGFamily.CurrentRow.Cells[14].Value.ToString() == "True")
            {
                DialogResult resilt = MessageBox.Show("Are you sure you want to Deactivate this card??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resilt == DialogResult.Yes)
                {
                    this.Hide();
                    frm.FCard_Cancel = cardno;
                    frm.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Activate this card??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usp_SEL_FAMILYTableAdapter.Cancel_Active(true, "", "", cardno);
                    MessageBox.Show("Succesfully Activated!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
                }
            }
          
         
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnAll.Text == "&All Cards")
            {
                usp_SEL_FAMILYTableAdapter.FillAll(comDataSet.usp_SEL_FAMILY);
                btnAll.Text = "&Active Card";
            }
             else                
            {
                usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
                btnAll.Text = "&All Cards";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                textBox1_Leave(sender, e);
                usp_SEL_FAMILYTableAdapter.Leader(comDataSet.usp_SEL_FAMILY, textBox1.Text);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            try
            {
                if (textBox1.Text != "")
                {
                    int fcardno = Convert.ToInt32(textBox1.Text);
                    int x = 5 - textBox1.Text.Length;
                    string zeros = "";
                    for (int i = 0; i < x; i++)
                    {
                        zeros += "0";
                    }
                    textBox1.Text = zeros + textBox1.Text;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Only numbers are allowed!", "Only Numbers");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
        }

        private void chk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width + " " + this.Height);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            MCKJ.frmFamily_Member frm = new frmFamily_Member();
            frm.Show();
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            cmbNukh.Text = null;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            cmbVillage.Text = null;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            cmbSign.Text = null;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            cmbCity.Text = null;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            cmbArea.Text = null;
        }

        private void DGFamily_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label33_Click(object sender, EventArgs e)
        {
            cmbType.Text = null;
        }

        private void DGFamily_Sorted(object sender, EventArgs e)
        {
          
        }

        //private void DGFamily_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (DGFamily.CurrentRow.Cells[14].Value.ToString() == "True")
        //        btnActive.Text = "Inactive";
        //    else
        //        btnActive.Text = "Active";
        //}

       
      
       
      
       
               
        //END--------------------------------------------------------------
        //-----------------------------------------------------------------      
    }
}
   