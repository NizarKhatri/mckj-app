using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Reports.Members
{
    public partial class frmViewer : Form
    {
        public bool _nicbackbuttonvisible = false;
        public MCKJ.Reports.Members.rptNIC_back _rptNICback = null;
        public MCKJ.Reports.Members.rptNIC _rptNICfront = null;
        public frmViewer()
        {
            InitializeComponent();
        }

        private void btnNICback_Click(object sender, EventArgs e)
        {
            if (_rptNICback != null)
            {
                this.crystalReportViewer1.ReportSource = _rptNICback;
                
            }
        }

        private void frmViewer_Load(object sender, EventArgs e)
        {
            btnNICback.Visible = this._nicbackbuttonvisible;
           // crystalReportViewer1.Dock = this._nicbackbuttonvisible ? DockStyle.Fill : DockStyle.None;
        }

        private void btnShowNicFront_Click(object sender, EventArgs e)
        {
            if (_rptNICfront != null)
            {
                this.crystalReportViewer1.ReportSource = _rptNICfront;
            }
        }

       
    }
}