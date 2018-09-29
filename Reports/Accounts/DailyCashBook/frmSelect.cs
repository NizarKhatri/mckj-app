using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Reports.Accounts.DailyCashBook
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

                SqlCommand cmd = new SqlCommand("usp_DailyTransactions_Report", conn);

                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                SqlParameter paraToDate = cmd.Parameters.Add("@ToDate", SqlDbType.DateTime);

                para.Value = Convert.ToDateTime(dateTimePicker1.Text);
                paraToDate.Value = Convert.ToDateTime(dtpToDate.Text);

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);


                MCKJ.ComDataSet.tblDailyTransactionsDataTable dtDaily = new ComDataSet.tblDailyTransactionsDataTable();

                MCKJ.ComDataSet ds = new ComDataSet();
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ds.tblDailyTransactions.Rows.Add();
                    for (int x = 0; x< dt.Columns.Count; x++)
                    {
                        ds.tblDailyTransactions.Rows[i][x] = dt.Rows[i][x];
                    }
                }

                MCKJ.Reports.Accounts.DailyCashBook.frmViewer frm = new MCKJ.Reports.Accounts.DailyCashBook.frmViewer();

                MCKJ.Reports.Accounts.DailyCashBook.rptCashBook rpt = new MCKJ.Reports.Accounts.DailyCashBook.rptCashBook();
                frm.crystalReportViewer1.ReportSource = rpt;


                rpt.SetDataSource(ds);
                rpt.SetParameterValue("Date", Convert.ToDateTime(dateTimePicker1.Text));
                rpt.SetParameterValue("ToDate", Convert.ToDateTime(dtpToDate.Text));
                frm.Show();

                //frm.Text = "Daily Transactions";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occured:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}