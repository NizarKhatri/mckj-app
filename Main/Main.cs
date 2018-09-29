using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MCKJ;
using System.Data.SqlClient;
using System.IO;
using System.ServiceProcess;
using MCKJ.Common;
using MCKJ.Common.Enums;
using MCKJ.Reports.Billing;
using MCKJ.Utitilites;
using MCKJ.Reports.Renwal;

namespace Community
{
    public partial class Main : Form
    {
        DataTable dt = new DataTable();
        public Main()
        {

            InitializeComponent();

            //DateTime date1 = DateTime.Now.AddYears(10);
            //DateTime date2 = DateTime.Now;
            //TimeSpan Time = TimeSpan.FromDays(365 * 10);

            //DateTime date3 = date1.Subtract(Time);

            //MessageBox.Show(date3.ToString());
        }

        int back_restore = 0;
        string status = "";


        private void report_Active(string order)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();
                string query = "Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.Gender = 'Male' AND NIC != '    -   -     '" + status + " Order By " + order + " asc";

                SqlCommand cmd = new SqlCommand(query, conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptCard rpt = new MCKJ.Reports.Members.rptCard();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Male Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void report(string order)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();
                string query = "Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.Gender = 'Male' AND NIC != '    -   -     '" + status + " Order By " + order + " asc";

                SqlCommand cmd = new SqlCommand(query, conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptCard2 rpt = new MCKJ.Reports.Members.rptCard2();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Male Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void report_InActive(string order)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();
                string query = "Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.Gender = 'Male' AND NIC != '    -   -     '" + status + " Order By " + order + " asc";

                SqlCommand cmd = new SqlCommand(query, conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptCard1 rpt = new MCKJ.Reports.Members.rptCard1();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Male Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public int Loging_ID(int UserID, int R_ID)
        {
            int ID = 0;
            DBLayer dbLayer = new DBLayer();
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            try
            {
                SqlCommand cmd = new SqlCommand("Select ID from tblLoging WHERE UserID = " + UserID + " AND R_ID = " + R_ID, con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DR.Read();
                if (DR.HasRows)
                {
                    ID = Convert.ToInt32(DR.GetValue(0).ToString());
                }
                else
                {
                    ID = 0;
                }
            }
            catch (Exception ex)
            {
                string chking = ex.Message;
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return ID;
        }

        public void Chk_Rights()
        {
            int id = DBLayer.ID;
            Community.DBLayer dbLayer = new Community.DBLayer();
            if (dbLayer.Rights(id, 1))
                userToolStripMenuItem.Enabled = true;
            else
                userToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 2))
                permissionsToolStripMenuItem.Enabled = true;
            else
                permissionsToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 3))
                familyCardToolStripMenuItem2.Enabled = true;
            else
                familyCardToolStripMenuItem2.Enabled = false;

            if (dbLayer.User_Right(id, 4, "[Modify]"))
                transferMembersToolStripMenuItem.Enabled = true;
            else
                transferMembersToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 4))
                membersToolStripMenuItem1.Enabled = true;
            else
                membersToolStripMenuItem1.Enabled = false;

            //if (dbLayer.Rights(id, 4))
            //    createIDCardToolStripMenuItem.Enabled = true;
            //else
            //    createIDCardToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 5))
                renewalToolStripMenuItem.Enabled = true;
            else
                renewalToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 6))
                engagementToolStripMenuItem.Enabled = true;
            else
                engagementToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 7))
                bookingToolStripMenuItem.Enabled = true;
            else
                bookingToolStripMenuItem.Enabled = false;

            if (dbLayer.User_Right(id, 7, "[Modify]"))
                cancellationToolStripMenuItem.Enabled = true;
            else
                cancellationToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 8))
                accountProfileToolStripMenuItem.Enabled = true;
            else
                accountProfileToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 9))
                birthToolStripMenuItem.Enabled = true;
            else
                birthToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 10))
                deathToolStripMenuItem.Enabled = true;
            else
                deathToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 11))
                donationsToolStripMenuItem.Enabled = true;
            else
                donationsToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 12))
                transactionsToolStripMenuItem.Enabled = true;
            else
                transactionsToolStripMenuItem.Enabled = false;

            if (dbLayer.Rights(id, 13))
            {
                membersToolStripMenuItem.Enabled = true;
                familyCardToolStripMenuItem1.Enabled = true;

            }
            else
            {
                membersToolStripMenuItem.Enabled = false;
                familyCardToolStripMenuItem1.Enabled = false;
            }

            if (dbLayer.Rights(id, 14))
                accountsToolStripMenuItem1.Enabled = true;
            else
                accountsToolStripMenuItem1.Enabled = false;

            if (dbLayer.Rights(id, 15))
            {
                nukhToolStripMenuItem.Enabled = true;
                orakhToolStripMenuItem.Enabled = true;
                areaToolStripMenuItem.Enabled = true;
                villageToolStripMenuItem.Enabled = true;
                cityToolStripMenuItem.Enabled = true;
                workTypeToolStripMenuItem.Enabled = true;
                accountingToolStripMenuItem.Enabled = true;

            }
            else
            {
                nukhToolStripMenuItem.Enabled = false;
                orakhToolStripMenuItem.Enabled = false;
                areaToolStripMenuItem.Enabled = false;
                villageToolStripMenuItem.Enabled = false;
                cityToolStripMenuItem.Enabled = false;
                workTypeToolStripMenuItem.Enabled = false;
                accountingToolStripMenuItem.Enabled = false;
            }
            if (dbLayer.Rights(id, 16))
                userGroupToolStripMenuItem.Enabled = true;
            else
                userGroupToolStripMenuItem.Enabled = false;
            if (dbLayer.Rights(id, 17))
                familiesAIDToolStripMenuItem.Enabled = true;
            else
                familiesAIDToolStripMenuItem.Enabled = false;


        }

        public void Main_Load(object sender, EventArgs e)
        {
            Chk_Rights();

            RefreshAgeGroupForFamilyMember();
        }


        private void RefreshAgeGroupForFamilyMember()
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "usp_RefreshAgeGroup";
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                conn.Close();

                if (count > 0)
                {
                    MessageBox.Show(count + " " + "records updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Records to update");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Main", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void familyCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFamily frm = new frmFamily();
            frm.Show();
        }

        private void familyMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFamily_Member frm = new frmFamily_Member();
            frm.Show();

        }



        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSecurityLevel obSecurityLevel = new frmSecurityLevel();
            obSecurityLevel.MdiParent = this;
            obSecurityLevel.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MCKJ.Security.frmPermissions frm = new MCKJ.Security.frmPermissions();
            frm.Show();
        }

        private void nukhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNukh obNukh = new frmNukh();
            obNukh.Show();
        }

        private void orakhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrakh obOrakh = new frmOrakh();
            obOrakh.Show();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea obArea = new frmArea();
            obArea.Show();
        }

        private void villageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVillage obVillage = new frmVillage();
            obVillage.Show();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCity obCity = new frmCity();
            obCity.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer();
            frm.Show();

        }

        private void Renewal_Click(object sender, EventArgs e)
        {
            frmRenewal frm = new frmRenewal();
            frm.Show();

        }

        private void Engagement_Click(object sender, EventArgs e)
        {
            frmEngagement frm = new frmEngagement();
            frm.Show();
        }

        private void workTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTypeWork obType = new frmTypeWork();
            obType.Show();
        }

        private void donationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonations frm = new frmDonations();
            frm.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            frm.Show();

        }

        private void vouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVouchers frm = new frmVouchers();
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmBirthRegistration frm = new frmBirthRegistration();
            frm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmDeathRegistration frm = new frmDeathRegistration();
            frm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmHallBoking frm = new frmHallBoking();
            frm.Show();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //frmHallBoking1 frm = new frmHallBoking1();
            //frm.Show();

        }

        private void byFamilyCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Members.frm frm = new MCKJ.Reports.Members.frm();
            frm.label1.Text = "Card No:";
            frm.cmbSearch.DropDownStyle = ComboBoxStyle.Simple;
            frm.Show();
        }

        private void maleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.Gender = 'Male' Order By tblFamily.FCardNo asc", conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptMembers rpt = new MCKJ.Reports.Members.rptMembers();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Male Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void femaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.Gender = 'Female' Order By tblFamily.FCardNo asc", conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptMembers rpt = new MCKJ.Reports.Members.rptMembers();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Female Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void adultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.AgeGroup = 'Adult' Order By tblFamily.FCardNo asc", conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptAdultsMembers rpt = new MCKJ.Reports.Members.rptAdultsMembers();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Adult Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void minorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.AgeGroup = 'Minor' Order By tblFamily.FCardNo asc", conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptAdultsMembers rpt = new MCKJ.Reports.Members.rptAdultsMembers();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Minor Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void byBloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Members.frm frm = new MCKJ.Reports.Members.frm();
            frm.label1.Text = "Blood Group:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.Items.AddRange(new object[] {
            "A+ve",
            "A-ve",
            "B+ve",
            "B-ve",
            "AB+ve",
            "AB-ve",
            "O+ve",
            "O-ve"});
            frm.Show();

        }

        private void byWorkTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Members.frm frm = new MCKJ.Reports.Members.frm();
            frm.label1.Text = "Work Type:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.DataSource = frm.uspSELtblWorkTypeBindingSource;
            frm.cmbSearch.DisplayMember = "WorkType";
            frm.usp_SEL_tblWorkTypeTableAdapter.Fill(frm.comDataSet.usp_SEL_tblWorkType);
            frm.Show();
        }

        private void byMaritalStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Members.frm frm = new MCKJ.Reports.Members.frm();
            frm.cmbSearch.DataSource = null;
            frm.cmbSearch.Items.Clear();
            frm.label1.Text = "Marital Status:";
            frm.cmbSearch.Items.AddRange(new object[] {            
            "Single",
            "Married",
            "Divorced",
            "Widow",
            "Widower"});
            frm.Show();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Accounts.Ledger.frmSelect frm = new MCKJ.Reports.Accounts.Ledger.frmSelect();
            frm.Show();


        }

        private void balanceSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Accounts.BalanceSummary.frmSelector frm = new MCKJ.Reports.Accounts.BalanceSummary.frmSelector();
            frm.Show();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Members.frmCustom frm = new MCKJ.Reports.Members.frmCustom();
            frm.Show();
        }

        private void allCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {

                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("usp_SEL_Family", conn);

                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                MCKJ.Reports.Family_Card.frmViewer frm = new MCKJ.Reports.Family_Card.frmViewer();
                MCKJ.Reports.Family_Card.rptFamilyCard rpt = new MCKJ.Reports.Family_Card.rptFamilyCard();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);
                rpt.SetParameterValue("Filter", "Family Cards");
                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void byNukhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frm frm = new MCKJ.Reports.Family_Card.frm();
            frm.label1.Text = "Nukh:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.DataSource = frm.uspSELtblNukhBindingSource;
            frm.cmbSearch.DisplayMember = "NukhName";
            frm.usp_SEL_tblNukhTableAdapter.Fill(frm.comDataSet.usp_SEL_tblNukh);
            frm.Show();
        }

        private void byOrakhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frm frm = new MCKJ.Reports.Family_Card.frm();
            frm.label1.Text = "Orakh:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.DataSource = frm.uspSELtblOrakhBindingSource;
            frm.cmbSearch.DisplayMember = "OrakhName";
            frm.usp_SEL_tblOrakhTableAdapter.Fill(frm.comDataSet.usp_SEL_tblOrakh);
            frm.Show();
        }

        private void byOriginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frm frm = new MCKJ.Reports.Family_Card.frm();
            frm.label1.Text = "Origin:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.DataSource = frm.uspSELtblVillageBindingSource;
            frm.cmbSearch.DisplayMember = "Village";
            frm.usp_SEL_tblVillageTableAdapter.Fill(frm.comDataSet.usp_SEL_tblVillage);
            frm.Show();
        }

        private void byAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frm frm = new MCKJ.Reports.Family_Card.frm();
            frm.label1.Text = "Area:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.DataSource = frm.uspSELtblAreaBindingSource;
            frm.cmbSearch.DisplayMember = "Area";
            frm.usp_SEL_tblAreaTableAdapter.Fill(frm.comDataSet.usp_SEL_tblArea);
            frm.Show();
        }

        private void byCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frm frm = new MCKJ.Reports.Family_Card.frm();
            frm.label1.Text = "City:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.DataSource = frm.uspSELtblCityBindingSource;
            frm.cmbSearch.DisplayMember = "City";
            frm.usp_SEL_tblCityTableAdapter.Fill(frm.comDataSet.usp_SEL_tblCity);
            frm.Show();
        }

        private void byCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frm frm = new MCKJ.Reports.Family_Card.frm();
            frm.label1.Text = "Country:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.DropDownStyle = ComboBoxStyle.Simple;
            frm.cmbSearch.Text = "Pakistan";
            frm.Show();
        }

        private void dailyTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Accounts.DailyTransactions.frmSelect frm = new MCKJ.Reports.Accounts.DailyTransactions.frmSelect();
            frm.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (back_restore == 0)
            {
                tblLogingTableAdapter.AddLogoffTime(Login.user_ID, DateTime.Now, Loging_ID(Login.user_ID, Login.R_ID));
            }
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (back_restore == 0)
                {
                    tblLogingTableAdapter.AddLogoffTime(Login.user_ID, DateTime.Now, Loging_ID(Login.user_ID, Login.R_ID));
                }
                Application.Exit();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MCKJ v" + Application.ProductVersion.ToString() + "\n\nCopyright 2008. All Rights Reserved.\n\nCopy, Editing or Redistribution of this program is prohibited!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community.Login frm = new Login();
            frm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Security.frmChangePassword frm = new MCKJ.Security.frmChangePassword();
            frm.Show();
        }

        private void familyCardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmFamily frm = new frmFamily();
            frm.Show();
        }

        private void membersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFamily_Member frm = new frmFamily_Member();
            frm.Show();
        }

        private void transferMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer();
            frm.Show();
        }

        private void engagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEngagement frm = new frmEngagement();
            frm.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHallBoking frm = new frmHallBoking();
            frm.Show();
        }

        private void cancellationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmHallBoking1 frm = new frmHallBoking1();
            //frm.Show();
        }

        private void birthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBirthRegistration frm = new frmBirthRegistration();
            frm.Show();
        }

        private void deathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeathRegistration frm = new frmDeathRegistration();
            frm.Show();


        }

        private void renewalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewal frm = new frmRenewal();
            frm.Show();
        }

        private void accountProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.Show();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Loging.frmSelect frm = new MCKJ.Reports.Loging.frmSelect();
            frm.Show();
        }

        private void bakupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBakup frm = new frmBakup();
            frm.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            back_restore = 1;
            //SQLDMO._SQLServer srv = new SQLDMO.SQLServerClass();
            //srv.Connect("Fasnatics-1", "FNY", "arbani4u");            
            ServiceController x = new ServiceController("MSSQLSERVER");
            try
            {
                string dbPath = "";
                string dbPath1 = "";
                string exPath = "";
                string exPath1 = "";


                fbdBrowser.Description = "Please select a path where to export the database.";
                fbdBrowser.SelectedPath = "";
                fbdBrowser.ShowDialog(this);

                if (fbdBrowser.SelectedPath == "")
                {
                    dbPath = "";
                    dbPath1 = "";
                    exPath = "";
                    exPath1 = "";
                }
                else
                {
                    tblLogingTableAdapter.AddLogoffTime(Login.user_ID, DateTime.Now, Loging_ID(Login.user_ID, Login.R_ID));
                    x.Stop();
                    MessageBox.Show("System is Ready to Backup.....", "Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    dbPath = Application.StartupPath + @"\Database\Community.mdf";
                    dbPath1 = Application.StartupPath + @"\Database\Community_log.ldf";
                    exPath = fbdBrowser.SelectedPath + @"\Community.mdf";
                    exPath1 = fbdBrowser.SelectedPath + @"\Community_log.ldf";

                    bool overwrite = false;
                    bool copyFile = true;
                    bool overwrite1 = false;
                    bool copyFile1 = true;


                    if (File.Exists(exPath) || File.Exists(exPath1))
                    {
                        DialogResult result = MessageBox.Show("Overwrite existing file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            overwrite = true;
                            overwrite1 = true;
                        }
                        else
                        {
                            copyFile = false;
                            copyFile1 = false;
                        }
                    }

                    //for (int i = 0; i < DateTime.Now.TimeOfDay.Seconds + 30; i++)
                    //{                       
                    //    if (i == 0)
                    //    {
                    //        MessageBox.Show("Setup is ready to backup!!\nPlease click OK to Proceed.", "Ready", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);

                    //    }                        
                    //}                    
                    if (x.Status == ServiceControllerStatus.Stopped)
                    {
                        if (copyFile && copyFile1)
                        {
                            File.Copy(dbPath, exPath, overwrite);
                            File.Copy(dbPath1, exPath1, overwrite1);

                            MessageBox.Show("Successfully Backedup!!\nApplication will be Closed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            x.Start();
                            Application.Exit();

                        }
                    }
                    else
                    {
                        MessageBox.Show("An unknown error occured! System unable to backup plz try again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (x.Status == ServiceControllerStatus.ContinuePending || x.Status == ServiceControllerStatus.Paused || x.Status == ServiceControllerStatus.PausePending || x.Status == ServiceControllerStatus.StartPending || x.Status == ServiceControllerStatus.Stopped || x.Status == ServiceControllerStatus.StopPending)
                        {
                            back_restore = 0;
                            x.Start();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                if (x.Status == ServiceControllerStatus.ContinuePending || x.Status == ServiceControllerStatus.Paused || x.Status == ServiceControllerStatus.PausePending || x.Status == ServiceControllerStatus.StartPending || x.Status == ServiceControllerStatus.Stopped || x.Status == ServiceControllerStatus.StopPending)
                {
                    x.Start();
                    back_restore = 0;
                }
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            back_restore = 1;
            ServiceController x = new ServiceController("MSSQLSERVER");
            try
            {
                ofdSelect.Title = "Choose a file to import..";
                ofdSelect.FileName = "";
                ofdSelect.ShowDialog(this);

                if (ofdSelect.FileName == "")
                {

                }
                else
                {
                    tblLogingTableAdapter.AddLogoffTime(Login.user_ID, DateTime.Now, Loging_ID(Login.user_ID, Login.R_ID));
                    x.Stop();
                    string dbPath = Application.StartupPath + @"\Database\Community.mdf";
                    string dbPath1 = Application.StartupPath + @"\Database\Community_log.ldf";
                    string exPath = ofdSelect.FileName;
                    string[] exPath1 = ofdSelect.FileName.Split(Convert.ToChar("."));
                    string exPath_log = exPath.Replace("Community.mdf", "Community_log.ldf");
                    //

                    bool overwrite = false;
                    bool copyFile = true;
                    bool overwrite1 = false;
                    bool copyFile1 = true;

                    if (File.Exists(dbPath) || File.Exists(dbPath1))
                    {
                        DialogResult result = MessageBox.Show("Overwrite existing file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            overwrite = true;
                            overwrite1 = true;
                        }
                        else
                        {
                            copyFile = false;
                            copyFile1 = false;
                        }
                    }
                    MessageBox.Show("System is Ready to Restore", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //for (int i = 0; i < DateTime.Now.TimeOfDay.Seconds + 30; i++)
                    //{
                    //    if (i == 0)
                    //    {
                    //        MessageBox.Show("Setup is ready to restore!!\nPlease click OK to Proceed.", "Ready", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    //    }
                    //}


                    if (copyFile && copyFile1)
                    {
                        if (x.Status == ServiceControllerStatus.Stopped)
                        {
                            File.Copy(exPath, dbPath, overwrite);
                            File.Copy(exPath_log, dbPath1, overwrite1);

                            MessageBox.Show("Successfully Restored!!\nApplication will be Closed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            x.Start();
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("An unknown error occured! System unable to restore plz try again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (x.Status == ServiceControllerStatus.ContinuePending || x.Status == ServiceControllerStatus.Paused || x.Status == ServiceControllerStatus.PausePending || x.Status == ServiceControllerStatus.StartPending || x.Status == ServiceControllerStatus.Stopped || x.Status == ServiceControllerStatus.StopPending)
                            {
                                back_restore = 0;
                                x.Start();
                            }
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                if (x.Status == ServiceControllerStatus.ContinuePending || x.Status == ServiceControllerStatus.Paused || x.Status == ServiceControllerStatus.PausePending || x.Status == ServiceControllerStatus.StartPending || x.Status == ServiceControllerStatus.Stopped || x.Status == ServiceControllerStatus.StopPending)
                    x.Start();

                back_restore = 0;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUser obCreateUser = new CreateUser();
            obCreateUser.Show();
        }

        private void permissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Security.frmPermissions frm = new MCKJ.Security.frmPermissions();
            frm.Show();
        }

        private void familiesAIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.frmAid frm = new frmAid();
            frm.Show();
        }

        private void userGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Security.frmGroup frm = new MCKJ.Security.frmGroup();
            frm.Show();
        }


        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frmSelect frm = new MCKJ.Reports.Family_Card.frmSelect();
            frm.Show();
        }

        private void accountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVouchers frm = new frmVouchers();
            frm.Show();

        }

        private void dailyCashBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Accounts.DailyCashBook.frmSelect frm = new MCKJ.Reports.Accounts.DailyCashBook.frmSelect();
            frm.Show();
        }

        private void communityIDCardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvents frm = new frmEvents();
            frm.Show();
        }

        private void headerTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHeaderType frm = new frmHeaderType();
            frm.Show();
        }


        private void hallBookingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHBK_ACC frm = new frmHBK_ACC();
            frm.Show();
        }

        private void aidTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAids frm = new frmAids();
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status = " AND tblFamilyMember.Active = 'True'";
            report_Active("Right(NIC,5)");
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            status = " AND tblFamilyMember.Active  = 'False'";
            report_InActive("Right(NIC,5)");
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            status = "";
            report("Right(NIC,5)");

        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            status = " AND tblFamilyMember.Active  = 'True'";
            report_Active("tblFamily.FCardNo");
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            status = " AND tblFamilyMember.Active  = 'False'";
            report_InActive("tblFamily.FCardNo");
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            status = "";
            report("tblFamily.FCardNo");

        }

        private void donationsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDon_ACC frm = new frmDon_ACC();
            frm.Show();
        }

        private void renewalAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewal_ACC frm = new frmRenewal_ACC();
            frm.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community.DBLayer DBLayer = new DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();
                string query = "Select *,tblFamily.Sign,tblFamily.Nukh,tblFamily.City,tblFamily.Area,tblFamily.Country from tblFamilyMember INNER JOIN tblFamily ON tblFamilyMember.FCardNo = tblFamily.FCardNo WHERE tblFamilyMember.Gender = 'Male' AND NIC = '    -   -     ' AND tblFamilyMember.DOB != '----' ORDER BY tblFamilyMember.FCardNo asc";

                SqlCommand cmd = new SqlCommand(query, conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                int rows = dt.Rows.Count;
                for (int x = dt.Rows.Count; x > 0; x--)
                {
                    int age = 0;
                    string dob = dt.Rows[x - 1].ItemArray[6].ToString();
                    if (dob.Length == 4)
                    {
                        age = DateTime.Now.Year - Convert.ToInt32(dob);
                    }
                    else
                    {
                        DateTime date = Convert.ToDateTime(dob);
                        age = DateTime.Now.Year - date.Year;
                        if (DateTime.Now.Month < date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day))
                            age--;
                    }
                    if (age < 18)
                    {
                        dt.Rows.RemoveAt(x - 1);
                    }
                }

                MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                MCKJ.Reports.Members.rptCard3 rpt = new MCKJ.Reports.Members.rptCard3();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue("Filter", "Male Members");

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message + ex.Data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void birthRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.BirthDeath.frmSelect frm = new MCKJ.Reports.BirthDeath.frmSelect();
            frm.Show();
            frm.Text = "Birth Registration";
        }

        private void deathRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.BirthDeath.frmSelect frm = new MCKJ.Reports.BirthDeath.frmSelect();
            frm.Show();
            frm.Text = "Death Registration";
        }

        private void renewalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void donationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Donation.frmSelect frm = new MCKJ.Reports.Donation.frmSelect();
            frm.Show();
        }

        private void advancePaymentAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdvAcc frm = new frmAdvAcc();
            frm.Show();
        }

        private void advancePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdvance frm = new frmAdvance();
            frm.Show();
        }

        private void amountOfHallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHallAmt frm = new frmHallAmt();
            frm.Show();
        }

        private void nICStatusAMountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNICAmt frm = new frmNICAmt();
            frm.Show();
        }

        private void nICFoamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNICForm frm = new frmNICForm();
            frm.Show();
        }

        private void createIDCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Members.frmNIC frm = new MCKJ.Members.frmNIC();
            frm.Show();
        }

        private void familiesAidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.FamilyAid.frmFamilyAidReport frm = new MCKJ.Reports.FamilyAid.frmFamilyAidReport();
            frm.Show();
        }

        private void activeInactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Family_Card.frm frm = new MCKJ.Reports.Family_Card.frm();
            frm.label1.Text = "Status:";
            frm.cmbSearch.Items.Clear();
            frm.cmbSearch.Items.Add("Active");
            frm.cmbSearch.Items.Add("Inactive");
            frm.cmbSearch.Items.Add("Both");
            frm.Show();
        }

        private void coffinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void decorationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coffinOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Billing.BillingItemOptions frmBio = new MCKJ.Billing.BillingItemOptions();
            frmBio.lblBillingType.Text = "BILL TYPE: " + Enums.BillType.Coffin.ToString().ToUpper();
            frmBio.txtBillType.Text = Enums.BillType.Coffin.ToString();
            frmBio.Show();
        }

        private void decorationOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Billing.BillingItemOptions frmBio = new MCKJ.Billing.BillingItemOptions();
            frmBio.lblBillingType.Text = "BILL TYPE: " + Enums.BillType.Decoration.ToString().ToUpper();
            frmBio.txtBillType.Text = Enums.BillType.Decoration.ToString();
            frmBio.Show();
        }

        private void busOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Billing.BillingItemOptions frmBio = new MCKJ.Billing.BillingItemOptions();
            frmBio.lblBillingType.Text = "BILL TYPE: " + Enums.BillType.Bus.ToString().ToUpper();
            frmBio.txtBillType.Text = Enums.BillType.Bus.ToString();
            frmBio.Show();
        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Billing.frmGenerateBill frmBill = new MCKJ.Billing.frmGenerateBill();
            frmBill.BillType = "Coffin";
            frmBill.lblSubHeading.Text = "Burial Department";
            frmBill.Show();
        }

        private void generateBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MCKJ.Billing.frmGenerateBill frmBill = new MCKJ.Billing.frmGenerateBill();
            frmBill.BillType = "Decoration";
            frmBill.lblSubHeading.Text = "Decoration";
            frmBill.Show();
        }

        private void generateBillToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MCKJ.Billing.frmGenerateBill frmBill = new MCKJ.Billing.frmGenerateBill();
            frmBill.BillType = "Bus";
            frmBill.lblSubHeading.Text = "Bus";
            frmBill.Show();
        }

        private void staffNICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Members.frmNICStaff frmNICStaff = new MCKJ.Members.frmNICStaff();
            frmNICStaff.Show();
        }

        private void dECORATIONINVOICEOUTSTANDINGREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaidBill frmPaidBill = new frmPaidBill();
            frmPaidBill.Show();
        }

        private void familyCardRenewalFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFCardRenewalAmt frmFCardRenewalAmt = new frmFCardRenewalAmt();
            frmFCardRenewalAmt.Show();
        }

        private void familyCardRenewalLateFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFCardRenewalLateFee frmFCardRenewalLateFee = new frmFCardRenewalLateFee();
            frmFCardRenewalLateFee.Show();
        }

        private void pendingFamilyCardRenewalToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void renewalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Renwal.frmSelect frm = new MCKJ.Reports.Renwal.frmSelect();
            frm.Show();

        }

        private void expiredNICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Renwal.frmViewer frm = new MCKJ.Reports.Renwal.frmViewer();
            rptExpiredNIC rpt = new rptExpiredNIC();
            frm.crystalReportViewer1.ReportSource = rpt;
            rpt.SetDataSource(new DBLayer().GetExpiredNIC());
            frm.Show();

        }

        private void pendingFamilyCardRenewalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void dailySummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCKJ.Reports.Accounts.DailySummaryReport.frmSelect frmSelect = new MCKJ.Reports.Accounts.DailySummaryReport.frmSelect();
            frmSelect.Show();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new DBLayer().GetPendingFCardRenewal(0);
            MCKJ.Reports.Renwal.frmViewer frmViewer = new MCKJ.Reports.Renwal.frmViewer();
            CRPendingFCardRenewal rpt = new CRPendingFCardRenewal();
            rpt.SetDataSource(dt);
            frmViewer.crystalReportViewer1.ReportSource = rpt;
            frmViewer.Show();
        }

        private void oneYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new DBLayer().GetPendingFCardRenewal(1);
            MCKJ.Reports.Renwal.frmViewer frmViewer = new MCKJ.Reports.Renwal.frmViewer();
            CRPendingFCardRenewal rpt = new CRPendingFCardRenewal();
            rpt.SetDataSource(dt);
            frmViewer.crystalReportViewer1.ReportSource = rpt;
            frmViewer.Show();
        }

        private void twoYearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new DBLayer().GetPendingFCardRenewal(2);
            MCKJ.Reports.Renwal.frmViewer frmViewer = new MCKJ.Reports.Renwal.frmViewer();
            CRPendingFCardRenewal rpt = new CRPendingFCardRenewal();
            rpt.SetDataSource(dt);
            frmViewer.crystalReportViewer1.ReportSource = rpt;
            frmViewer.Show();
        }

        private void threeOrMoreYearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = new DBLayer().GetPendingFCardRenewal(3);
            MCKJ.Reports.Renwal.frmViewer frmViewer = new MCKJ.Reports.Renwal.frmViewer();
            CRPendingFCardRenewal rpt = new CRPendingFCardRenewal();
            rpt.SetDataSource(dt);
            frmViewer.crystalReportViewer1.ReportSource = rpt;
            frmViewer.Show();
        }
    }
}