using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Community;

namespace MCKJ.Utitilites
{
    public partial class frmFCardRenewalLateFee : Form
    {
        DataTable dt = new DataTable();
        DBLayer dbLayer = new DBLayer();
        Boolean result = false;
        public frmFCardRenewalLateFee()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //DBLayer dbLayer = new DBLayer();
            //dt = dbLayer.GetFamilyCardRenewalFee();
            Enable(true);
        }

        private void frmFCardRenewalAmt_Load(object sender, EventArgs e)
        {
            //Set AutoGenerateColumns False
            //dgvFCardRenewal.AutoGenerateColumns = false;

            //Set Columns Count
            //dgvFCardRenewal.ColumnCount = 3;
            dt = dbLayer.GetFamilyCardRenewalLateFee(); 
            //String.Format("F2", dt.Columns["CardRenewalFee"]);
            dgvFCardRenewal.DataSource = dt;
        }
        private void Enable(Boolean yn)
        {
            txtFromYear.Enabled = yn;
            txtToYear.Enabled = yn;
            dtpBegDate.Enabled = yn;
            dtpEndDate.Enabled = yn;
            btnSave.Enabled = yn;
            btnCancel.Enabled = yn;
            dgvFCardRenewal.Enabled = !yn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            result = dbLayer.AddFamilyCardRenewalLateFee(txtFromYear.Text, txtToYear.Text, DateTime.Parse(dtpBegDate.Text), DateTime.Parse(dtpEndDate.Text));
            if (result)
                MessageBox.Show("Record inserted successfully", "Success");
            else
                MessageBox.Show("Error inserting record", "Error");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Enable(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}