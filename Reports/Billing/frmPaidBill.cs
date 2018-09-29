using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Reports.Billing
{
    public partial class frmPaidBill : Form
    {
        public frmPaidBill()
        {
            InitializeComponent();
            //Open form in center of screend
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query="";
            try
            {
                SqlConnection conn = new SqlConnection(Community.DBLayer.con_String);

                conn.Open();

                if(rbPaid.Checked)
                    query = "select TransactionNo, Name, Orakh, (GrandTotal + LeaseRenewalFund) - AdvanceAmount NetAmount, CellNo, EntryDate,CardNo from tblbill where IsPaid=1 Order by EntryDate desc";
                else
                    query = "select TransactionNo, Name, Orakh, (GrandTotal + LeaseRenewalFund) - AdvanceAmount NetAmount, CellNo, EntryDate,CardNo from tblbill where IsPaid=0 Order by EntryDate desc";
                SqlCommand Command = new SqlCommand(query, conn);
                Command.CommandType = CommandType.Text;
                //SqlDataReader cReader = Command.ExecuteReader(); ;
                //if (cReader.HasRows)
                //{
                //    cReader.Read();
                //    OpeningBalance = Convert.ToDouble(cReader.GetValue(2));
                //}
                //else
                //{
                //    OpeningBalance = 0;
                //}
                //cReader.Close();
                //
                //SqlCommand cmd = new SqlCommand("usp_RPT_Ledger", conn);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection = conn;

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable aaa = new DataTable();

                sda.Fill(aaa);


                MCKJ.Reports.Billing.frmViewer frm = new MCKJ.Reports.Billing.frmViewer();
                Reports.Billing.rpPaidBill rpt = new MCKJ.Reports.Billing.rpPaidBill();

                rpt.SetDataSource(aaa);

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
    }
}