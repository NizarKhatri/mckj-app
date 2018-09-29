using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Reports.Accounts.Ledger
{
    public partial class frmSelect : Form
    {
        

        public frmSelect()
        {
            InitializeComponent();
        }
        Community.DBLayer DBLayer = new Community.DBLayer();
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
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                //
                string query = "SELECT SUM(tblTransactions.Debit) As Debit,SUM(tblTransactions.Credit) As Credit, IsNull(Sum(Debit-Credit),0) As Balance FROM tblTransactions WHERE tblTransactions.Dated < '" + Convert.ToDateTime(dateTimePicker1.Text).ToString("MM/dd/yyyy") + "' AND tblTransactions.AccountCode =" + comboBox1.SelectedValue.ToString();
                SqlCommand Command = new SqlCommand(query, conn);
                Command.CommandType = CommandType.Text;
                SqlDataReader cReader = Command.ExecuteReader();;                
                
                double OpeningBalance = 0;

                if (cReader.HasRows)
                {
                    cReader.Read();
                    OpeningBalance = Convert.ToDouble(cReader.GetValue(2));
                }
                else
                {
                    OpeningBalance = 0;
                }
                cReader.Close();
                //
                SqlCommand cmd = new SqlCommand("usp_RPT_Ledger", conn);

                cmd.Connection = conn;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraStartDate = cmd.Parameters.Add("@StartDate", SqlDbType.DateTime);
                paraStartDate.Value = Convert.ToDateTime(dateTimePicker1.Text);

                SqlParameter paraEndDate = cmd.Parameters.Add("@EndDate", SqlDbType.DateTime);
                paraEndDate.Value = Convert.ToDateTime(dateTimePicker2.Text);

                SqlParameter paraCode = cmd.Parameters.Add("@Code", SqlDbType.VarChar,100);
                paraCode.Value =comboBox1.SelectedValue.ToString();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable aaa = new DataTable();

                sda.Fill(aaa);


                MCKJ.Reports.Donation.frmViewer frm = new MCKJ.Reports.Donation.frmViewer();
                Reports.Accounts.Ledger.rptLedger rpt = new MCKJ.Reports.Accounts.Ledger.rptLedger();
                

                rpt.SetDataSource(aaa);


                rpt.SetParameterValue("OBalance", OpeningBalance);
                rpt.SetParameterValue("fromDate", Convert.ToDateTime(dateTimePicker1.Text));
                rpt.SetParameterValue("toDate", Convert.ToDateTime(dateTimePicker2.Text));
                rpt.SetParameterValue("AccountName", comboBox1.Text.ToString());                             

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptButton = btnShow;
        }
    }
}