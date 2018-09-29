using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCKJ.Members
{
    public partial class frmNIC_2 : Form
    {
        public frmNIC_2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Print_NIC()
        {
            try
            {
                string[] Query = { "", "", "", "" };
                if (txtCMIC1.Text == "" && txtCMIC2.Text == "" && txtCMIC3.Text == "" && txtCMIC4.Text == "")
                {
                    MessageBox.Show("Please enter atleast One Community ID Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtCMIC1.Text != "")
                    {
                        Query[0] = "RIGHT(tblNIC.NIC,5) = '" + txtCMIC1.Text + "'";
                    }
                    if (txtCMIC2.Text != "    -   -")
                    {
                        Query[1] = "RIGHT(tblNIC.NIC,5) = '" + txtCMIC2.Text + "'";
                    }
                    if (txtCMIC3.Text != "    -   -")
                    {
                        Query[2] = "RIGHT(tblNIC.NIC,5) = '" + txtCMIC3.Text + "'";
                    }
                    if (txtCMIC4.Text != "    -   -")
                    {
                        Query[3] = "RIGHT(tblNIC.NIC,5) = '" + txtCMIC4.Text + "'";
                    }


                    string QUERY = "";
                    for (int x = 0; x < 4; x++)
                    {

                        if (QUERY == "")
                        {
                            if (Query[x] != "")
                            {
                                QUERY += Query[x] + " ";
                            }
                        }
                        else
                        {
                            if (Query[x] != "")
                            {
                                QUERY += " OR " + Query[x];
                            }
                        }

                    }
                    int len = QUERY.Length;

                    Community.DBLayer dblayer = new Community.DBLayer();
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    string query = richTextBox1.Text;
                    query = query.Replace("NIC = @NIC", QUERY);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    DataTable dt = new DataTable();
                    
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        con.Close();
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        ada.Fill(dt);
                        MCKJ.Reports.Members.frmViewer frm = new MCKJ.Reports.Members.frmViewer();
                        MCKJ.Reports.Members.rptNIC rpt = new MCKJ.Reports.Members.rptNIC();
                        MCKJ.Reports.Members.rptNIC_back rptBack = new MCKJ.Reports.Members.rptNIC_back();
                        rpt.SetDataSource(dt);
                        rptBack.SetDataSource(dt);
                        frm.crystalReportViewer1.ReportSource = rpt;
                        frm._nicbackbuttonvisible = true;
                        frm._rptNICback = rptBack;
                        frm._rptNICfront = rpt;
                        frm.Show();                        
                    }
                    else
                    {
                        MessageBox.Show("No record to preview please enter other ID Card No.s", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print_NIC();
        }

        private void frmNIC_2_Load(object sender, EventArgs e)
        {
            txtCMIC1.Focus();
            AcceptButton = btnPrint;
        }

        private void txtCMIC1_Enter(object sender, EventArgs e)
        {
            txtCMIC1.Text.Normalize();
        }       
       
    }
}