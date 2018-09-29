using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Account
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        public int ModeCancel = 0;
        private string Type()
        {
            string Type = "";
            if (rdbCancel.Checked)
                Type = rdbCancel.Text;
            else
                Type = rdbRestricted.Text;

            return Type;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {                                    
        }

        
    }
}