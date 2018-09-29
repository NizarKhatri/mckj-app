using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Reports.Members
{
    public partial class frmCustom : Form
    {
        public frmCustom()
        {
            InitializeComponent();
        }
        Community.DBLayer DBLayer = new Community.DBLayer();
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
                grbFilter.Enabled = false;
            else
                grbFilter.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int chk_Query = 0;
            string Filter = "";
            string Query = "Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country, tblNIC.ISNICPrinted from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo LEFT JOIN tblNIC ON tblFamilyMember.FamilyMemberID = tblnic.MemberID ";
            if (chkAll.Checked != true)
            {
                if (chkName.Checked)
                {
                    int length = txtName.Text.Length;
                    if (chk_Query == 0)
                    {                       
                        Query = Query + "Where Left(tblFamilyMember.MemberName," + length +") ='" + txtName.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Name = " + txtName.Text;
                    }
                    else
                    {
                        Query = Query + "AND Left(tblFamilyMember.MemberName," + length + ") ='" + txtName.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Name = " + txtName.Text;
                    }
                }
                if (chkCMIC.Checked)
                {
                    int length = txtCMIC.Text.Length;
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where RIGHT(tblFamilyMember.NIC," + length + ") ='" + txtCMIC.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By CommCard = " + txtCMIC.Text;
                    }
                    else
                    {
                        Query = Query + "AND RIGHT(tblFamilyMember.NIC," + length + ") ='" + txtCMIC.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; CommCard = " + txtCMIC.Text;
                    }
                }
                if (chkStatus.Checked)
                {
                    int BOOL = 0;
                    if (cmbStatus.Text == "Active")
                        BOOL = 1;
                    else
                        BOOL = 0;
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.Active =" + BOOL;
                        chk_Query = chk_Query + 1;
                        if (BOOL == 1)
                            Filter = "Filter By Status = Active";
                        else
                            Filter = "Filter By Status = In-Active";
                        
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.Active =" + BOOL;
                        chk_Query = chk_Query + 1;
                        if (BOOL == 1)
                            Filter = Filter + "; Status = Active";
                        else
                            Filter = Filter + "; Status = In-Active";
                    }
                }
                if (chkAgeGroup.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.AgeGroup ='" + cmbAdult.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Age-Group = " + cmbAdult.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.AgeGroup ='" + cmbAdult.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Age-Group = " + cmbAdult.Text;
                    }
                }

                if (chkArea.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamily.Area ='" + cmbArea.Text + "' "; ;
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Area = " + cmbArea.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamily.Area ='" + cmbArea.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Area = " + cmbArea.Text;
                    }
                }

                if (chkBloodGroup.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.BloodGroup ='" + cmbBGroup.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Blood Group = " + cmbBGroup.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.BloodGroup ='" + cmbBGroup.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Blood Group = " + cmbBGroup.Text;
                    }
                }

                if (chkCity.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamily.City ='" + cmbCity.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By City = " + cmbCity.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamily.City ='" + cmbCity.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; City = " + cmbCity.Text;
                    }
                }

                if (chkFCard.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.FCardNo ='" + txtFCardNo.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By CardNo = " + txtFCardNo.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.FCardNo ='" + txtFCardNo.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; CardNo = " + txtFCardNo.Text;
                    }
                }

                if (chkGender.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "WHERE tblFamilyMember.Gender ='" + cmbGender.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Gender = " + cmbGender.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.Gender ='" + cmbGender.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Gender = " + cmbGender.Text;
                    }
                }


                if (chkMaritalStatus.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.MaritalStatus ='" + cmbMaritalStatus.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Marital Status = " + cmbMaritalStatus.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.MaritalStatus ='" + cmbMaritalStatus.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Marital Status = " + cmbMaritalStatus.Text;
                    }
                }

                if (chkNukh.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamily.Nukh ='" + cmbNukh.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Nukh = " + cmbNukh.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamily.Nukh ='" + cmbNukh.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Nukh = " + cmbNukh.Text;
                    }
                }

                if (chkOrakh.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamily.Sign ='" + cmbSign.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Orakh = " + cmbSign.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamily.Sign ='" + cmbSign.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Orakh = " + cmbSign.Text;
                    }
                }

                if (chkOutOf.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.Outof ='" + cmbOutof.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Out-OF = " + cmbOutof.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.Outof ='" + cmbOutof.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Out-OF = " + cmbOutof.Text;
                    }
                }

                if (chkRelation.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.LeaderRelation ='" + cmbRelation.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Relation = " + cmbRelation.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.LeaderRelation ='" + cmbRelation.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Relation = " + cmbRelation.Text;
                    }
                }

                if (chkVillage.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "tblFamily.Village ='" + cmbVillage.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Origin = " + cmbVillage.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamily.Village ='" + cmbVillage.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; Origin = " + cmbVillage.Text; 
                    }
                }

                if (chkWorkType.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.WorkType ='" + cmbTypeWork.Text + "'";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By Work Type = " + cmbTypeWork.Text;
                    }
                    else
                    {

                        Query = Query + "AND tblFamilyMember.WorkType ='" + cmbTypeWork.Text + "'";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + ";Work Type = " + cmbTypeWork.Text; 
                    }
                }

                if (chkCNIC.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.CNIC ='" + txtCNIC.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By CNIC = " + txtCNIC.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.CNIC ='" + txtCNIC.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; CNIC = " + txtCNIC.Text;
                    }
                }

                if (chkDOB.Checked)
                {
                    if (chk_Query == 0)
                    {
                        Query = Query + "Where tblFamilyMember.DOB ='" + dtpDOB.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = "Filter By DOB = " + dtpDOB.Text;
                    }
                    else
                    {
                        Query = Query + "AND tblFamilyMember.DOB ='" + dtpDOB.Text + "' ";
                        chk_Query = chk_Query + 1;
                        Filter = Filter + "; DOB = " + dtpDOB.Text;
                    }
                }

            }                           

            Query = Query + "Order by tblFamily.FCardNo asc";


            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand(Query, conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptCustom rpt = new MCKJ.Reports.Members.rptCustom();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);
                rpt.SetParameterValue(0, Filter);

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chkFCard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFCard.Checked)
                txtFCardNo.Enabled = true;
            else
                txtFCardNo.Enabled = false;
        }

        private void chkAgeGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgeGroup.Checked)
                cmbAdult.Enabled = true;
            else
                cmbAdult.Enabled = false;
        }

        private void chkGender_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGender.Checked)
                cmbGender.Enabled = true;
            else
                cmbGender.Enabled = false;
        }

        private void chkMaritalStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaritalStatus.Checked)
                cmbMaritalStatus.Enabled = true;
            else
                cmbMaritalStatus.Enabled = false;
        }

        private void chkOutOf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutOf.Checked)
                cmbOutof.Enabled = true;
            else
                cmbOutof.Enabled = false;
        }

        private void chkNukh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNukh.Checked)
                cmbNukh.Enabled = true;
            else
                cmbNukh.Enabled = false;            
        }

        private void chkVillage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVillage.Checked)
                cmbVillage.Enabled = true;
            else
                cmbVillage.Enabled = false;
        }

        private void chkArea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArea.Checked)
                cmbArea.Enabled = true;
            else
                cmbArea.Enabled = false;
        }

        private void chkRelation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRelation.Checked)
                cmbRelation.Enabled = true;
            else
                cmbRelation.Enabled = false;
        }

        private void chkBloodGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBloodGroup.Checked)
                cmbBGroup.Enabled = true;
            else
                cmbBGroup.Enabled = false;
        }

        private void chkWorkType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWorkType.Checked)
                cmbTypeWork.Enabled = true;
            else
                cmbTypeWork.Enabled = false;
        }

        private void chkOrakh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrakh.Checked)
                cmbSign.Enabled = true;
            else
                cmbSign.Enabled = false;
        }

        private void chkCity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCity.Checked)
                cmbCity.Enabled = true;
            else
                cmbCity.Enabled = false;
        }

        private void frmCustom_Load(object sender, EventArgs e)
        {
            usp_SEL_tblAreaTableAdapter.Fill(comDataSet.usp_SEL_tblArea);
            usp_SEL_tblBloodGroupTableAdapter.Fill(comDataSet.usp_SEL_tblBloodGroup);
            usp_SEL_tblCityTableAdapter.Fill(comDataSet.usp_SEL_tblCity);
            usp_SEL_tblNukhTableAdapter.Fill(comDataSet.usp_SEL_tblNukh);
            usp_SEL_tblOrakhTableAdapter.Fill(comDataSet.usp_SEL_tblOrakh);
            usp_SEL_tblVillageTableAdapter.Fill(comDataSet.usp_SEL_tblVillage);
            usp_SEL_tblWorkTypeTableAdapter.Fill(comDataSet.usp_SEL_tblWorkType);
            AcceptButton = btnShow;
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
                MessageBox.Show("Only numbers are allowed!!!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }

        private void cmbMaritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaritalStatus.Text != "Married")
            {
                chkOutOf.Checked = false;
                chkOutOf.Enabled = false;
            }
            else
            {              
                chkOutOf.Enabled = true;
            }
        }

        private void cmbNukh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkName.Checked)
                txtName.Enabled = true;
            else
                txtName.Enabled = true;
        }

        private void chkCMIC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCMIC.Checked)
                txtCMIC.Enabled = true;
            else
                txtCMIC.Enabled = false;
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.Checked)
                cmbStatus.Enabled = true;
            else
                cmbStatus.Enabled = false;
        }

        private void chkCNIC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCNIC.Checked)
                txtCNIC.Enabled = true;
            else
                txtCNIC.Enabled = false;
        }

        private void chkDOB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDOB.Checked)
                dtpDOB.Enabled = true;
            else
                dtpDOB.Enabled = false;
        }
       
    }
}