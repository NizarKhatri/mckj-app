using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Reports.BirthDeath
{
    public partial class frmSelect : Form
    {


        public frmSelect()
        {
            InitializeComponent();
        }
        Community.DBLayer DBLayer = new Community.DBLayer();

        private void rptBirth()
        {
            try
            {

                SqlConnection conn = new SqlConnection(DBLayer.CON_string);
                SqlCommand cmd = new SqlCommand(richTextBox1.Text);

                cmd.Connection = conn;

                cmd.CommandType = CommandType.Text;

                SqlParameter paraStartDate = cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                paraStartDate.Value = Convert.ToDateTime(dtpFromDate.Text);

                SqlParameter paraEndDate = cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                paraEndDate.Value = Convert.ToDateTime(dtpToDate.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable aaa = new DataTable();

                sda.Fill(aaa);

                MCKJ.Reports.BirthDeath.frmViewer frm = new MCKJ.Reports.BirthDeath.frmViewer();
                Reports.BirthDeath.rptBirthReg rpt = new rptBirthReg();

                rpt.SetDataSource(aaa);

                rpt.SetParameterValue("fromDate", Convert.ToDateTime(dtpFromDate.Text));
                rpt.SetParameterValue("toDate", Convert.ToDateTime(dtpToDate.Text));


                frm.crystalReportViewer1.ReportSource = rpt;

                //frm.Text = "Purchase Bill";

                frm.Show();

                conn.Close();


            }
            catch (Exception exceptionparamter)
            {
                MessageBox.Show("Unable to view report!\n\n" + exceptionparamter.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rptDeath()
        {
            try
            {

                SqlConnection conn = new SqlConnection(DBLayer.CON_string);
                SqlCommand cmd = new SqlCommand(richTextBox2.Text);

                cmd.Connection = conn;

                cmd.CommandType = CommandType.Text;

                SqlParameter paraStartDate = cmd.Parameters.Add("@FromDate", SqlDbType.DateTime);
                paraStartDate.Value = Convert.ToDateTime(dtpFromDate.Text);

                SqlParameter paraEndDate = cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);
                paraEndDate.Value = Convert.ToDateTime(dtpToDate.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable aaa = new DataTable();

                sda.Fill(aaa);

                MCKJ.Reports.Donation.frmViewer frm = new MCKJ.Reports.Donation.frmViewer();
                Reports.BirthDeath.rptDeath rpt = new rptDeath();

                rpt.SetDataSource(aaa);

                rpt.SetParameterValue("fromDate", Convert.ToDateTime(dtpFromDate.Text));
                rpt.SetParameterValue("toDate", Convert.ToDateTime(dtpToDate.Text));


                frm.crystalReportViewer1.ReportSource = rpt;

                //frm.Text = "Purchase Bill";

                frm.Show();

                conn.Close();


            }
            catch (Exception exceptionparamter)
            {
                MessageBox.Show("Unable to view report!\n\n" + exceptionparamter.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
      
        private void frmSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.tblAccounts' table. You can move, or remove it, as needed.
            this.tblAccountsTableAdapter.Fill(this.comDataSet.tblAccounts);
            // TODO: This line of code loads data into the 'dataSet.tblParty' table. You can move, or remove it, as needed.
            tblAccountsTableAdapter.FillAll(comDataSet.tblAccounts);
            dateTimePicker1.Focus();
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (Text == "Birth Registration")
                rptBirth();
            else
                rptDeath();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptButton = btnShow1;
        }
    }
}