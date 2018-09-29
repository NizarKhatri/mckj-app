using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.FamilyCard
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        public string FCard_Cancel = "";
        public string Type()
        {
            string type = "";
            if (rdbCancel.Checked == true)
                type = rdbCancel.Text;
            else
                type = rdbRestricted.Text;
            return type;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            usp_SEL_FAMILYTableAdapter.Cancel_Active(false,Type(),txtReason.Text,FCard_Cancel);
            MessageBox.Show("Succesfully Cancelled!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            usp_SEL_FAMILYTableAdapter.Fill(comDataSet.usp_SEL_FAMILY);
            frmFamily frm = new frmFamily();
            this.Close();
            frm.Show();

        }

        private void frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comDataSet.usp_SEL_FAMILY' table. You can move, or remove it, as needed.
            this.usp_SEL_FAMILYTableAdapter.Fill(this.comDataSet.usp_SEL_FAMILY);

        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmFamily frm = new frmFamily();
            this.Close();
            frm.Show();
        }
       
       
    }
}