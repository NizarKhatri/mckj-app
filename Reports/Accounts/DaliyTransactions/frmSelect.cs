using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Reports.Accounts.DailyTransactions
{
    public partial class frmSelect : Form
    {
        Community.DBLayer DBLayer = new Community.DBLayer();

        public frmSelect()
        {
            InitializeComponent();
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {            
           
        }
      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AcceptButton = btnShow;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                SqlCommand cmd = new SqlCommand("usp_rpt_DailyTransactions", conn);

                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Date", SqlDbType.DateTime);

                para.Value = Convert.ToDateTime(dateTimePicker1.Text);

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

               

                MCKJ.Reports.Accounts.DailyTransactions.frmReport frm = new frmReport();

                MCKJ.Reports.Accounts.DaliyTransactions.rptDailyTransactions rpt = new MCKJ.Reports.Accounts.DaliyTransactions.rptDailyTransactions();
                frm.crystalReportViewer1.ReportSource = rpt;

                rpt.SetDataSource(dt);
                rpt.SetParameterValue("Date", Convert.ToDateTime(dateTimePicker1.Text));

                frm.Show();

                frm.Text = "Daily Transactions";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occured:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}