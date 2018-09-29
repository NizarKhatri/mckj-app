using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Community;

namespace MCKJ.Reports.Renwal
{
    public partial class frmFCardRenewalPending : Form
    {
        DBLayer DbLayer = new DBLayer();
        DataTable dt = new DataTable();
        public frmFCardRenewalPending()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
        }
    }
}