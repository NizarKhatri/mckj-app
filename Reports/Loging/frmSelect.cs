using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Reports.Loging
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Community.DBLayer dbLayer = new Community.DBLayer();
            try
            {


                DateTime startdate = Convert.ToDateTime(dtpFrom.Text);
                string time = startdate.TimeOfDay.ToString();               
                DateTime enddate = Convert.ToDateTime(dtpTo.Text);
                enddate = enddate.AddDays(1);
                
              
               


                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select tblSecurity.UserName,LoginTime,LogoffTime FROM tblLoging INNER JOIN tblSecurity ON tblLoging.UserID = tblSecurity.UserID WHERE LoginTime >='" + startdate + "' AND LoginTime <= '" + enddate + "'",con);

                DataTable dt = new DataTable();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                MCKJ.Reports.Loging.frmViewer frm = new frmViewer();
                MCKJ.Reports.Loging.rptLoging rpt = new rptLoging();

                rpt.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Show();
                con.Close();


                
            }             
            catch(FormatException)
            {
                MessageBox.Show("Only Numbers are allowed!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}