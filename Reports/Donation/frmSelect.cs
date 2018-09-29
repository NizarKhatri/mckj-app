using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Reports.Donation
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
                int from = Convert.ToInt32(txtFrom.Text);
                int to = Convert.ToInt32(txtTo.Text);
                string quer = "ReceiptNo = '";
                if (to > from)
                {
                    for (int x = from; x <= to; x++)
                    {
                        
                        if (x == to)
                            quer += x.ToString("00000") + "'";
                        else
                            quer += x.ToString("00000") + "' OR ReceiptNo = '";
                    }                    
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select *,tblFamily.FamilyLeader AS MemberName from tblDonations INNER JOIN tblFamily ON tblDonations.FCardNo = tblFamily.FCardNo WHERE " + quer, con);

                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;

                    da.Fill(dt);
                    Reports.Donation.frmViewer frm = new MCKJ.Reports.Donation.frmViewer();
                    Reports.Donation.rptDonation rpt = new MCKJ.Reports.Donation.rptDonation();

                    frm.crystalReportViewer1.ReportSource = rpt;

                    rpt.SetDataSource(dt);
                    frm.Show();
                    con.Close();
                }
                else
                    MessageBox.Show("Please select right combination in From and To boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}