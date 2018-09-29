using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ
{
    public partial class chk : Form
    {
        public chk()
        {
            InitializeComponent();
        }
        public string eng_mrg_SerialNo = "";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmEngagement frm = new frmEngagement();
            usp_SEL_EngagementTableAdapter.Cancel(eng_mrg_SerialNo, false, txtReason.Text);
            usp_SEL_MarriageTableAdapter.Cancel(eng_mrg_SerialNo, false, txtReason.Text);
            MessageBox.Show("Successfully Done!!!!", "Success");                                   
            this.usp_SEL_EngagementTableAdapter.Fill(comDataSet.usp_SEL_Engagement);
            this.usp_SEL_MarriageTableAdapter.Fill(comDataSet.usp_SEL_Marriage, eng_mrg_SerialNo);
            this.Close();
            frm.Focus();            
        }

        private void chk_Load(object sender, EventArgs e)
        {
            txtReason.Focus();
            AcceptButton = btnSave;
        }
       
    }
}