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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void rpt_Card()
         {
            string Query = "";
            try
            {
                if (cmbSearch.Text == "")
                    MessageBox.Show("Please Fill in the Field!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    string X = cmbSearch.Text;


                    SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                    conn.Open();

                    //SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.FCardNo = '" + X + "' Order By tblFamily.FCardNo asc", conn);
                    //SqlCommand cmd = new SqlCommand("Select * from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.FCardNo = '" + X + "' Order By tblFamily.FCardNo asc", conn);
                    Query += "Select case when tblfamilymember.Gender='Male' then MemberName+' '+FatherName ";
                    Query += "when tblfamilymember.gender='Female' then ";
                    Query+="Case When tblfamilymember.Active=1 and (MaritalStatus='Married' or MaritalStatus='Widow') ";
                    Query += "		then MemberName+' '+HusbandName else  MemberName+' '+FatherName end ";
                    Query += "else ";
                    Query += "		Case when MaritalStatus='Married' then MemberName+' '+HusbandName when MaritalStatus='Single' then MemberName+' '+FatherName end ";
                    Query += "end ";
                    Query += "MemberName,CNIC,NIC,tblfamilyMember.Gender,AgeGroup,LeaderRelation,TempDOB as DOB,AcademicEducation,MaritalStatus,tblfamilymember.Reason,tblfamilymember.Active, ";
                    Query += "tblfamily.FamilyName,tblfamily.FamilyLeader,tblfamily.Nukh,tblfamily.Sign,tblfamily.Mobile,tblfamily.ResidentAddress,tblfamily.FCardNo,OutOf ";
                    Query += "from tblFamilyMember ";
                    Query += "INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo ";
                    Query += "WHERE tblFamilyMember.FCardNo ='" + X + "'  Order By tblFamily.FCardNo asc ";
                    SqlCommand cmd = new SqlCommand(Query, conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Members.frmViewer frm = new frmViewer();
                    Reports.Members.rptMembers_Card rpt = new rptMembers_Card();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);

                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void rpt_BGroup()
        {
            try
            {
                if (cmbSearch.Text == "")
                    MessageBox.Show("Please Fill in the Field!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    string X = cmbSearch.Text;


                    SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.BloodGroup = '" + X + "' Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Members.frmViewer frm = new frmViewer();
                    Reports.Members.rptType_Members rpt = new rptType_Members();

                    frm.crystalReportViewer1.ReportSource = rpt;
                  

                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", cmbSearch.Text + " Blood Group Members");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_WorkType()
        {
            try
            {
                if (cmbSearch.Text == "")
                    MessageBox.Show("Please Fill in the Field!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    string X = cmbSearch.Text;


                    SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.WorkType = '" + X + "' Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Members.frmViewer frm = new frmViewer();
                    Reports.Members.rptType_Members rpt = new rptType_Members();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", cmbSearch.Text + " in Community");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_Status()
        {
            try
            {
                if (cmbSearch.Text == "")
                    MessageBox.Show("Please Fill in the Field!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    string X = cmbSearch.Text;


                    SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.MaritalStatus = '" + X + "' Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Members.frmViewer frm = new frmViewer();
                    Reports.Members.rptType_Members rpt = new rptType_Members();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", cmbSearch.Text + " Members");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Community.DBLayer DBLayer = new Community.DBLayer();

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Card No:")
            {
                cmbSearch_Leave(sender, e);
                rpt_Card();
            }
            if (label1.Text == "Blood Group:")
            {
                rpt_BGroup();
                
            }

            if (label1.Text == "Work Type:")
            {
                rpt_WorkType();   
            }
            if (label1.Text == "Marital Status:")
            {
                rpt_Status();          
            }
        }

        private void frm_Load(object sender, EventArgs e)
        {          
           
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btnShow;
        }

        private void cmbSearch_Leave(object sender, EventArgs e)
        {
            if (label1.Text == "Card No:")
            {
                try
                {
                    if (cmbSearch.Text != "")
                    {
                        int fcardno = Convert.ToInt32(cmbSearch.Text);
                        int x = 5 - cmbSearch.Text.Length;
                        string zeros = "";
                        for (int i = 0; i < x; i++)
                        {
                            zeros += "0";
                        }
                        cmbSearch.Text = zeros + cmbSearch.Text;

                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Only Numbers are allowed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
    }
}