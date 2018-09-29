using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Reports.Family_Card
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Extra(string FCardNo)
        {
          
            Community.DBLayer DBLayer = new Community.DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

            SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Active,tblFamily.FCardNo,tblFamily.FamilyLeader FROM tblHelp INNER  JOIN tblFamiy ON tblHelp.FCardNo = tblFamily.FCardNo WHERE tblHelp.FCardNo = '" + FCardNo + "'", conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);               

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
            string Status = "";
            string RenewalYear = "";
            string FCardNo = textBox1.Text;
            string Head = "";
            string Orakh = "";
            string FName = "";
           
            Community.DBLayer DBLayer = new Community.DBLayer();
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT tblHelp.ID, tblHelp.FCardNo, tblHelp.HeadofFamily, tblHelp.FName, tblHelp.Orakh, tblHelp.ReceiveDate, tblHelp.Status, tblHelp.Amount,tblHelp.CompleteDate, tblHelp.SerialNo, tblHelp.Remarks, tblAids.Aid, tblFamilyMember.MemberName FROM tblHelp INNER JOIN tblAids ON tblHelp.HelpType = tblAids.ID INNER JOIN tblFamilyMember ON tblHelp.Name = tblFamilyMember.FamilyMemberID WHERE tblHelp.FCardNo = '" + FCardNo + "'", conn);


                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                SqlCommand Command1 = new SqlCommand("Select tblFamily.Active,tblFamily.FCardNo,tblFamily.FamilyLeader,tblFamily.Sign FROM tblFamily WHERE tblFamily.FCardNo = '" + FCardNo + "'", conn);
                Command1.CommandType = CommandType.Text;
                SqlDataReader cReader;

                cReader = Command1.ExecuteReader();

                cReader.Read();
                if (cReader.HasRows)
                {
                    bool chk = false;
                    if (cReader.GetValue(0) != DBNull.Value)
                    {
                        chk = Convert.ToBoolean(cReader.GetValue(0));
                        if (chk == true)
                            Status = "Active";
                        else
                            Status = "Inactive";
                    }
                    else
                        Status = "";
                    if (cReader.GetValue(2) != DBNull.Value)
                        Head = cReader.GetValue(2).ToString();
                    else
                        Head = "";
                    if (cReader.GetValue(3) != DBNull.Value)
                        Orakh = cReader.GetValue(3).ToString();
                    else
                        Orakh = "";
                }
                else
                {                    
                    Status = "Inactive";
                    Orakh = "";
                    Head = "";
                }
                cReader.Close();


                SqlCommand Command2 = new SqlCommand("Select RenewalYear FROM tblRenewal WHERE tblRenewal.FCardNo = '" + FCardNo + "' ORDER By ID desc", conn);
                Command2.CommandType = CommandType.Text;
                SqlDataReader cReader1;

                cReader1 = Command2.ExecuteReader();

                cReader1.Read();
                if (cReader1.HasRows)
                {
                    bool chk = false;
                    if (cReader1.GetValue(0) != DBNull.Value)
                        RenewalYear = cReader1.GetValue(0).ToString();
                    else
                        RenewalYear = "";
                }
                else
                {
                    RenewalYear = "";
                }
                cReader1.Close();

                SqlCommand Command3 = new SqlCommand("Select FatherName FROM tblFamilyMember WHERE tblFamilyMember.FCardNo = '" + FCardNo + "' AND MemberName = '" + Head + "'", conn);
                Command3.CommandType = CommandType.Text;
                SqlDataReader cReader2;

                cReader2 = Command3.ExecuteReader();

                cReader2.Read();
                if (cReader2.HasRows)
                {
                    bool chk = false;
                    if (cReader2.GetValue(0) != DBNull.Value)
                        FName = cReader2.GetValue(0).ToString();
                    else
                        FName = "";
                }
                else
                {
                    FName = "";
                }
                cReader2.Close();


                da.Fill(dt);


                MCKJ.Reports.Family_Card.frmViewer frm = new frmViewer();
                MCKJ.Reports.Family_Card.rptStatus rpt = new rptStatus();

                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(dt);

                rpt.SetParameterValue(0, RenewalYear);
                rpt.SetParameterValue(1, Status);
                rpt.SetParameterValue(2, FCardNo);
                rpt.SetParameterValue(3, Head);
                rpt.SetParameterValue(4, Orakh);
                rpt.SetParameterValue(5, FName);

                frm.Show();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //string FCardNo = textBox1.Text;
            //Community.DBLayer DBLayer = new Community.DBLayer();
            //try
            //{
            //    SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

            //    conn.Open();

            //    SqlCommand cmd = new SqlCommand("Select *,tblFamily.Sign,tblFamily.Active,tblFamily.FCardNo,tblFamily.FamilyLeader FROM tblHelp INNER  JOIN tblFamiy ON tblHelp.FCardNo = tblFamily.FCardNo WHERE tblHelp.FCardNo = '"+ FCardNo + "'", conn);


            //    DataTable dt = new DataTable();

            //    cmd.CommandType = CommandType.Text;

            //    SqlDataAdapter da = new SqlDataAdapter();

            //    da.SelectCommand = cmd;

            //    da.Fill(dt);


            //    MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
            //    MCKJ.Reports.Members.rptMembers rpt = new MCKJ.Reports.Members.rptMembers();

            //    frm.crystalReportViewer1.ReportSource = rpt;


            //    rpt.SetDataSource(dt);

            //    rpt.SetParameterValue("Filter", "Male Members");

            //    frm.Show();

            //    conn.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
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
            AcceptButton = btnShow;
        }

        
    }
}