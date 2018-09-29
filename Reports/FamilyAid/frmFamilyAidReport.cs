using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MCKJ.ComDataSetTableAdapters;
namespace MCKJ.Reports.FamilyAid
{
    public partial class frmFamilyAidReport : Form
    {
        public frmFamilyAidReport()
        {
            InitializeComponent();
        }

        private void chkByFamilyCard_CheckedChanged(object sender, EventArgs e)
        {
            txtFamilyCardNo.Enabled = chkByFamilyCard.Checked;
        }

        private void chkByAidType_CheckedChanged(object sender, EventArgs e)
        {
            cmbAidType.Enabled = chkByAidType.Checked;
        }

        private void chkByStatus_CheckedChanged(object sender, EventArgs e)
        {
            cmbStatus.Enabled = chkByStatus.Checked;
        }

        private void chkByOrakh_CheckedChanged(object sender, EventArgs e)
        {
            cmbOrakh.Enabled = chkByOrakh.Checked;
        }

        private void InitializeControls()
        {
            cmbStatus.Enabled = cmbOrakh.Enabled = cmbAidType.Enabled = txtFamilyCardNo.Enabled = cmbAidFrom.Enabled = false;
            this.BindCmbAidType();
            this.BindCmbOrakh();

        }


        private void BindCmbOrakh()
        {
            try
            {
                usp_SEL_tblOrakhTableAdapter objOrakh = new usp_SEL_tblOrakhTableAdapter();
                cmbOrakh.DataSource = objOrakh.GetData();
                cmbOrakh.DisplayMember = "OrakhName";
                cmbOrakh.ValueMember = "ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void BindCmbAidType()
        {
            try
            {
                tblAidsTableAdapter objAidType = new tblAidsTableAdapter();
                cmbAidType.DataSource = objAidType.GetData();
                cmbAidType.DisplayMember = "Aid";
                cmbAidType.ValueMember = "ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmFamilyAidReport_Load(object sender, EventArgs e)
        {
            this.InitializeControls();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                StringBuilder filter = new StringBuilder();

                query.Append(@"SELECT     tblHelp.ID, tblHelp.FCardNo, tblHelp.HeadofFamily, tblHelp.FName, tblHelp.Orakh, tblHelp.ReceiveDate, tblHelp.Status, tblHelp.Amount, 
                      tblHelp.CompleteDate, tblHelp.SerialNo, tblHelp.Remarks, tblAids.Aid, tblFamilyMember.MemberName, tblHelp.AidFrom
FROM         tblHelp INNER JOIN
                      tblAids ON tblHelp.HelpType = tblAids.ID INNER JOIN
                      tblFamilyMember ON tblHelp.Name = tblFamilyMember.FamilyMemberID ");
                bool isWhereIncluded = false;
                if (chkByAidType.Checked)
                {
                    query.Append("where HelpType =" + cmbAidType.SelectedValue);
                    isWhereIncluded = true;
                    filter.Append("Aid Type=" + cmbAidType.Text+",");
                }
                if (chkByFamilyCard.Checked)
                {
                    if (!isWhereIncluded) { query.Append(" where "); isWhereIncluded = true; } else query.Append(" AND ");
                    query.Append(" tblHelp.FCardNo='" + txtFamilyCardNo.Text.PadLeft(5,'0') + "'");
                    filter.Append("Family Card=" + txtFamilyCardNo.Text.PadLeft(5, '0') + ",");
                }
                if (chkByOrakh.Checked)
                {
                    if (!isWhereIncluded) { query.Append(" where "); isWhereIncluded = true; } else query.Append(" AND ");
                    query.Append(" tblHelp.Orakh='" + cmbOrakh.Text + "'");
                    filter.Append("Orakh=" + cmbOrakh.Text + ",");
                }
                if (chkByStatus.Checked)
                {
                    if (!isWhereIncluded) { query.Append(" where "); isWhereIncluded = true; } else query.Append(" AND ");
                    query.Append(" tblHelp.Status='" + cmbStatus.Text + "'");
                    filter.Append("Status=" + cmbStatus.Text + ",");
                }
                if (chkAidFrom.Checked)
                {
                    query.Append("where AidFrom ='" + cmbAidFrom.Text + "'");
                    isWhereIncluded = true;
                    filter.Append("Aid From=" + cmbAidFrom.Text + ",");
                }
                query.Append(" ORDER BY tblHelp.FCardNo Asc");
                Community.DBLayer DBLayer = new Community.DBLayer();
                DataTable dt = DBLayer.GetDataByQuery(query.ToString());
                MCKJ.ComDataSet dsCom = new ComDataSet();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dsCom.tblHelp.NewRow();
                    int index = dsCom.tblHelp.Rows.Count - 1;
                    for (int j = 0; j < dsCom.tblHelp.Columns.Count; j++)
                    {
                        dr[dsCom.tblHelp.Columns[j].ColumnName] = dt.Rows[i][dsCom.tblHelp.Columns[j].ColumnName];
                    }
                    dsCom.tblHelp.Rows.Add(dr);
                }
                
                MCKJ.Reports.FamilyAid.rptFamilyAid rptAidRpt = new rptFamilyAid();
                MCKJ.Reports.FamilyAid.frmViewer frmViewer = new frmViewer();
                rptAidRpt.SetDataSource(dsCom);
                frmViewer.crystalReportViewer1.ReportSource = rptAidRpt;
                string filterSettings = filter.ToString();
                rptAidRpt.SetParameterValue("Filter", "");
                if (filterSettings.Length > 0)
                {
                    rptAidRpt.SetParameterValue("Filter", filterSettings.Substring(0, filterSettings.Length - 1));
                }
                
                frmViewer.Show();
              
               
                //if (chkByAidType.Checked == false && chkByFamilyCard.Checked == false && chkByOrakh.Checked == false && chkByStatus.Checked == false)
                //{
                   
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkAidFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAidFrom.Checked)
            {
                cmbAidFrom.Enabled = true;
            }
            else
            {
                cmbAidFrom.Enabled = false;
            }
        }
    }
}