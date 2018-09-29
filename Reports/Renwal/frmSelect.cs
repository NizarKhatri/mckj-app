using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Reports.Renwal
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime from = Convert.ToDateTime(dtpFrom.Text);
                DateTime to = Convert.ToDateTime(dtpTo.Text);
                
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();
                string query = richTextBox1.Text;                
                SqlCommand cmd = new SqlCommand(query, con);

                SqlParameter paraFrom = cmd.Parameters.Add("@From", SqlDbType.DateTime);
                paraFrom.Value = from;

                SqlParameter paraTo = cmd.Parameters.Add("@To", SqlDbType.DateTime);
                paraTo.Value = to;

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(dt);
                Reports.Renwal.frmViewer frm = new MCKJ.Reports.Renwal.frmViewer();
                Reports.Renwal.rptRenwalByDate rpt = new rptRenwalByDate();
                frm.crystalReportViewer1.ReportSource = rpt;               
                rpt.SetDataSource(dt);
                rpt.SetParameterValue("From", from.Date.ToShortDateString());
                rpt.SetParameterValue("To", to.Date.ToShortDateString());
                frm.Show();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            AcceptButton = btnShow;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }
       
    }
}