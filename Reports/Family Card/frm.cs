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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
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

                    SqlCommand cmd = new SqlCommand("Select * from tblFamily WHERE TypeWork = '" + X + "'Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Family_Card.frmViewer frm = new frmViewer();
                    Reports.Family_Card.rptFamilyCard rpt = new rptFamilyCard();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", "Nukh '" + X + "' Family Cards");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_Nukh()
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

                    SqlCommand cmd = new SqlCommand("Select * from tblFamily WHERE Nukh = '" + X + "'Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Family_Card.frmViewer frm = new frmViewer();
                    Reports.Family_Card.rptFamilyCard rpt = new rptFamilyCard();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", "Nukh '" + X + "' Family Cards");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_Orakh()
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

                    SqlCommand cmd = new SqlCommand("Select * from tblFamily WHERE Sign = '" + X + "'Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Family_Card.frmViewer frm = new frmViewer();
                    Reports.Family_Card.rptFamilyCard rpt = new rptFamilyCard();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", "Orakh '" + X + "' Family Cards");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_Origin()
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

                    SqlCommand cmd = new SqlCommand("Select * from tblFamily WHERE Village = '" + X + "'Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Family_Card.frmViewer frm = new frmViewer();
                    Reports.Family_Card.rptFamilyCard rpt = new rptFamilyCard();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", "Origin '" + X + "' Family Cards");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_City()
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

                    SqlCommand cmd = new SqlCommand("Select * from tblFamily WHERE City = '" + X + "'Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Family_Card.frmViewer frm = new frmViewer();
                    Reports.Family_Card.rptFamilyCard rpt = new rptFamilyCard();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", "Family Cards of City '" + X + "'");
                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_Area()
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

                    SqlCommand cmd = new SqlCommand("Select * from tblFamily WHERE Area = '" + X + "'Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Family_Card.frmViewer frm = new frmViewer();
                    Reports.Family_Card.rptFamilyCard rpt = new rptFamilyCard();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", "Family Cards of Area '" + X + "'");

                    frm.Show();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("AN unknown error occured \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rpt_Country()
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

                    SqlCommand cmd = new SqlCommand("Select * from tblFamily WHERE Country = '" + X + "'Order By tblFamily.FCardNo asc", conn);


                    DataTable dt = new DataTable();

                    cmd.CommandType = CommandType.Text;

                    //SqlParameter paraID = cmd.Parameters.Add("@FCardNo",SqlDbType.VarChar , 50);

                    //paraID.Value = X;

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(dt);


                    Reports.Family_Card.frmViewer frm = new frmViewer();
                    Reports.Family_Card.rptFamilyCard rpt = new rptFamilyCard();

                    frm.crystalReportViewer1.ReportSource = rpt;


                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("Filter", "Family Cards of Country '" + X + "'");
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
            if (label1.Text == "Nukh:")
            {
                rpt_Nukh();
            }
            if (label1.Text == "Orakh:")
            {
                rpt_Orakh();
            }

            //if (label1.Text == "Work Type:")
            //{
            //    rpt_WorkType();   
            //}
            if (label1.Text == "Origin:")
            {
                rpt_Origin();
            }
            if (label1.Text == "City:")
            {
                rpt_City();
            }
            if (label1.Text == "Area:")
            {
                rpt_Area();
            }
            if (label1.Text == "Country:")
            {
                rpt_Country();
            }
            if (label1.Text == "Status:")
            {
                GetReportByStatus();
            }
        }

        private void GetReportByStatus()
        {
            if (cmbSearch.Text.Length <= 0)
            {
                MessageBox.Show("Please select status.");
                return;
            }
            Community.DBLayer DBLayer = new Community.DBLayer();
            try
            {

                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("usp_SEL_Family", conn);

                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_SEL_FAMILY_ByStatus";
                SqlDataAdapter da = new SqlDataAdapter();
                if (cmbSearch.Text != "Both")
                {
                    cmd.Parameters.AddWithValue("@status", (cmbSearch.Text == "Active" ? true : false));
                }
                
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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