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
    public partial class frmNICAmt : Form
    {
        public frmNICAmt()
        {
            InitializeComponent();
        }
        int mode = 0;
        int ID = 0;
       
        private void disble(bool ch)
        {
            btnNew.Enabled = ch;
            btnDelete.Enabled = ch;
            btnUpd.Enabled = ch;
            dgvFoamAmt.Enabled = ch;
            btnSave.Enabled = !ch;
            btnCancel.Enabled = !ch;
            txtAmount.Enabled = !ch;
            txtStatus.Enabled = !ch;
        }
    

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNICAmt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset3.tblCardType' table. You can move, or remove it, as needed.
            this.tblCardTypeTableAdapter.Fill(this.dataset3.tblCardType);
           

        }

        private void dgvFoamAmt_SelectionChanged(object sender, EventArgs e)
        {
            try
            {                
                txtStatus.Text = dgvFoamAmt.CurrentRow.Cells[1].Value.ToString();
                txtAmount.Text = Convert.ToDecimal(dgvFoamAmt.CurrentRow.Cells[2].Value).ToString("N2");
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            disble(false);
            mode = 0;
            txtAmount.Text = "0.00";
            txtStatus.Text = "";
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (dgvFoamAmt.Rows.Count != 0)
            {
                disble(false);
                mode = 1;
                ID = Convert.ToInt32(dgvFoamAmt.CurrentRow.Cells[0].Value);
            }
            else
                MessageBox.Show("No record to modify!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoamAmt.Rows.Count != 0)
            {
                ID = Convert.ToInt32(dgvFoamAmt.CurrentRow.Cells[0].Value);
                tblCardTypeTableAdapter.Del(ID);
                MessageBox.Show("Deleted successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tblCardTypeTableAdapter.Fill(dataset3.tblCardType);
            }
            else
                MessageBox.Show("No record to delete!", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            disble(true);
            tblCardTypeTableAdapter.Fill(dataset3.tblCardType);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Status = txtStatus.Text;
                decimal Amount = Convert.ToDecimal(txtAmount.Text);

                if (mode == 0)
                {
                    tblCardTypeTableAdapter.Add(Status, Amount);
                   
                    tblCardTypeTableAdapter.Fill(dataset3.tblCardType);
                    disble(true);
                }
                else
                {
                    tblCardTypeTableAdapter.Upd(Status, Amount, ID);
                    disble(true);
                    tblCardTypeTableAdapter.Fill(dataset3.tblCardType);
                }
                MessageBox.Show("Saved successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}