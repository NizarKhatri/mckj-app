using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Reports.Accounts.BalanceSummary
{
    public partial class frmSelector : Form
    {
        Community.DBLayer DBLayer = new Community.DBLayer();
        public frmSelector()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime UpToDate = Convert.ToDateTime(dateTimePicker1.Text);
                MCKJ.Reports.Accounts.BalanceSummary.frmReportViewer frm = new frmReportViewer();

                MCKJ.Reports.Accounts.BalanceSummary.rptBalanceSummary rpt = new MCKJ.Reports.Accounts.BalanceSummary.rptBalanceSummary();

                DataTable dt = DBLayer.getTrialBalance(UpToDate);

                for (int i = dt.Rows.Count; i > 0; i--)
                {
                    double balance = Convert.ToDouble(dt.Rows[i - 1].ItemArray.GetValue(4).ToString());
                    if (balance == 0)
                    {
                        dt.Rows.RemoveAt(i - 1);
                    }
                }

                rpt.SetDataSource(dt);

                frm.crystalReportViewer1.ReportSource = rpt;

                rpt.SetParameterValue(0, UpToDate);

                frm.Show();

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occured!\n\nError Description: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelector_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnShow;
            dateTimePicker1.Focus();
        }

        private void cmbAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptButton = btnShow;
        }
    }
}