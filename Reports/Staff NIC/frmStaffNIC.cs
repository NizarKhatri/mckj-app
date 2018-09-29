using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MCKJ.Common;
using System.Collections;
using MCKJ.Common.Enums;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace MCKJ.Reports.Staff_NIC
{
    public partial class frmStaffNIC : Form
    {
        private int Id;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
	
        public frmStaffNIC()
        {
            InitializeComponent();
        }

        private void btnShowFront_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();


                ReportDocument cryRpt = new ReportDocument();

                Reports.Staff_NIC.rptNICStaff_Front rpt = new MCKJ.Reports.Staff_NIC.rptNICStaff_Front();
                this.WindowState = FormWindowState.Maximized;
                rpt.SetDatabaseLogon("sa", "sql_pwd_SA", "MCKJ-SERVER", "Community");
                this.crvStaffNIC.ReportSource = rpt;
                rpt.SetParameterValue("Id", Id);
                rpt.SetParameterValue("IdToPrint", GetFormatId(Id.ToString()));
                //rpt.SetParameterValue("TransactionNo", dgBillSummary.Rows[dgBillSummary.CurrentCell.RowIndex].Cells["TransactionNo"].Value.ToString());

                this.Refresh();

                this.Show();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFormatId(string Id)
        {
            if (Id.Length == 1)
            {
                return "000" + Id;
            }
            else if (Id.Length == 2)
            {
                return "00" + Id;
            }
            else if (Id.Length == 3)
            {
                return "0" + Id;
            }
            return string.Empty;
        }

        private void btnShowBack_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                con.Open();


                ReportDocument cryRpt = new ReportDocument();

                Reports.Staff_NIC.rptNICStaff_Back rpt = new MCKJ.Reports.Staff_NIC.rptNICStaff_Back();
                this.WindowState = FormWindowState.Maximized;
                rpt.SetDatabaseLogon("sa", "sql_pwd_SA", "MCKJ-SERVER", "Community");
                this.crvStaffNIC.ReportSource = rpt;
                rpt.SetParameterValue("Id", Id);
                //rpt.SetParameterValue("TransactionNo", dgBillSummary.Rows[dgBillSummary.CurrentCell.RowIndex].Cells["TransactionNo"].Value.ToString());

                this.Refresh();

                this.Show();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStaffNIC_Load(object sender, EventArgs e)
        {

        }
    }
}