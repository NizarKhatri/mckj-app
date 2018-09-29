using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Reports.Accounts.DailySummaryReport
{
    public partial class frmSelect : Form
    {
        Community.DBLayer DBLayer = new Community.DBLayer();
        DataTable dt = new DataTable();
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
                dt = DBLayer.GetDailySummaryReport(DateTime.Parse(dtpDate.Text));
                MCKJ.Reports.Accounts.DailySummaryReport.frmViewer frmViewer = new MCKJ.Reports.Accounts.DailySummaryReport.frmViewer();
                rptDailySummaryReport rpt = new rptDailySummaryReport();
                rpt.SetDataSource(dt);
                frmViewer.crystalReportViewer1.ReportSource = rpt;
                frmViewer.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occured:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}