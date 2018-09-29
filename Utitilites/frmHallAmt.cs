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
    public partial class frmHallAmt : Form
    {
        public frmHallAmt()
        {
            InitializeComponent();
        }


        private int id()
        {
            int id = 0;
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
            SqlCommand cmd = new SqlCommand("Select ID from tblHallAmt", con);
            con.Open();
            id = Convert.ToInt32(cmd.ExecuteScalar());
            return id; 

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmHallAmt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset3.tblHallAmt' table. You can move, or remove it, as needed.
            this.tblHallAmtTableAdapter.Fill(this.dataset3.tblHallAmt);

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (btnUpd.Text == "&Edit")
            {
                txtH1.Enabled = true;
                txtH2.Enabled = true;
                txtH3.Enabled = true;
                txtH4.Enabled = true;
                txtH5.Enabled = true;
                btnUpd.Text = "&Save";
            }
            else
            {
                txtH1.Enabled = false;
                txtH2.Enabled = false;
                txtH3.Enabled = false;
                txtH4.Enabled = false;
                txtH5.Enabled = false;
                btnUpd.Text = "&Edit";
                
                decimal h1 = Convert.ToDecimal(txtH1.Text);
                decimal h2 = Convert.ToDecimal(txtH2.Text);
                decimal h3 = Convert.ToDecimal(txtH3.Text);
                decimal h4 = Convert.ToDecimal(txtH4.Text);
                decimal h5 = Convert.ToDecimal(txtH5.Text);
                tblHallAmtTableAdapter.upd(h1, h2, h3, h4, h5, id());
                MessageBox.Show("Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}