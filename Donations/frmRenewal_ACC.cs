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
    public partial class frmRenewal_ACC : Form
    {
        public frmRenewal_ACC()
        {
            InitializeComponent();
        }

        
        private void frmPettyAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset3.tblRenAcc' table. You can move, or remove it, as needed.
            this.tblRenAccTableAdapter.Fill(this.dataset3.tblRenAcc);
            // TODO: This line of code loads data into the 'comDataSet.tblAccounts' table. You can move, or remove it, as needed.
            this.tblAccountsTableAdapter.Fill(this.comDataSet.tblAccounts);
            // TODO: This line of code loads data into the 'dataset2.tblHallAcc' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataset.tblAccounts' table. You can move, or remove it, as needed.            

        }

        private bool check_petty(int id)
        {
            bool result = true;
            try
            {
                SqlConnection con = new SqlConnection(Community.DBLayer.con_String);

                SqlCommand cmd = new SqlCommand("SELECT RenewalAcc FROM tblRenAcc WHERE AccID = " + id, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    result =  true;
                else
                    result =  false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result =  true;
            }
            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPettyAcc.Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dgvPettyAcc.CurrentRow.Cells[0].Value.ToString());
                    tblRenAccTableAdapter.Del(ID);
                    tblRenAccTableAdapter.Fill(dataset3.tblRenAcc);
                }
            }
            else
                MessageBox.Show("No record to remove!!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int AccID = Convert.ToInt32(cmbPettyAcc.SelectedValue);
            string PettyAcc = cmbPettyAcc.Text;
            if (!check_petty(AccID))
            {
                tblRenAccTableAdapter.Add(AccID, PettyAcc);
                MessageBox.Show("Succesfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tblRenAccTableAdapter.Fill(dataset3.tblRenAcc);
            }
            else
                MessageBox.Show("Account Already added in Petty Account","Duplicate",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}