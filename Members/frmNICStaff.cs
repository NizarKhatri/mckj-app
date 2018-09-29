using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MCKJ.Common;
using System.Collections;
using MCKJ.Common.Enums;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace MCKJ.Members
{
    public partial class frmNICStaff : Form
    {
        DbHelper dbHelper = new DbHelper();
        SQLCache sql = null;
        ArrayList Params = null;
        Enums.Mode mode;

        public frmNICStaff()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Params = new ArrayList();
                Params.Add(txtName.Text);
                Params.Add(txtFName.Text);
                Params.Add(Convert.ToDateTime(dtpDOB.Text));
                Params.Add(txtCellNo.Text);
                Params.Add(txtDesignation.Text);
                Params.Add(txtCNIC.Text);
                Params.Add(txtAddress.Text);

                MemoryStream stream = new MemoryStream();
                pbImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] pic = stream.ToArray();
                Params.Add(pic);
                Params.Add(true);
                int status = 0;

                if (mode == Enums.Mode.Edit)
                {
                    Params.Add(Convert.ToInt32(dgvStaffMembers.Rows[dgvStaffMembers.CurrentCell.RowIndex].Cells["Id"].Value));
                    status = dbHelper.ExecuteNonQueryForImage(sql.GetSQL("Update_StaffNIC"), Params);
                }
                else
                {
                    status = dbHelper.ExecuteNonQueryForImage(sql.GetSQL("Insert_StaffNIC"), Params);
                }

                if (status > 0)
                {
                    MessageBox.Show("Record inserted successfully", "Staff NIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Staff NIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetValues()
        {
            txtName.Text = string.Empty; 
            txtFName.Text = string.Empty; 
            txtCellNo.Text = string.Empty; 
            txtDesignation.Text = string.Empty;
            txtCNIC.Text = string.Empty; 
            txtAddress.Text = string.Empty;
            dtpDOB.Text = DateTime.Now.ToString("dd/MM/yyyy");
            pbImage.Image = Properties.Resources.person;

        }

        private byte[] ReadFile(string sPath)
        {
            FileStream fs = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] image = br.ReadBytes((int)fs.Length);


            br.Close();
            fs.Close();

            return image;
            
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofd.FileName);
            } 
        }

        private void frmNICStaff_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            //btnViewAll.Enabled = false;
            btnViewAll.Text = "Print";
            FillDataGrid();
            btnViewAll.Enabled = false;
        }

        private void FillDataGrid()
        {
            Params = new ArrayList();
            
            sql = new SQLCache(Params);
            DataTable dt = dbHelper.ExecuteDataTable(sql.GetSQL("GetStaffMembers"));
            dgvStaffMembers.DataSource = dt;
            dgvStaffMembers.Visible = true;
            dgvStaffMembers.ClearSelection();
        }

        private void dgvStaffMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStaffMembers.Columns[e.ColumnIndex].Name == "Remove" && string.IsNullOrEmpty(dgvStaffMembers.Columns[e.ColumnIndex].HeaderText))
                {
                    return;
                }
                btnEdit.Enabled = true;
                btnViewAll.Enabled = true;
                Params = new ArrayList();
                Params.Add(dgvStaffMembers.Rows[dgvStaffMembers.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                sql = new SQLCache(Params);
                SqlDataReader rdr = dbHelper.ExecuteReader(sql.GetSQL("GetStaffMemberInformation"));

                if (rdr != null)
                {
                    rdr.Read();
                    byte[] byteImg = new byte[0];
                    txtName.Text = rdr["Name"].ToString();
                    txtFName.Text = rdr["FatherName"].ToString();
                    dtpDOB.Text = rdr["DOB"].ToString();
                    txtDesignation.Text = rdr["Designation"].ToString();
                    txtCellNo.Text = rdr["ContactNo"].ToString();
                    txtCNIC.Text = rdr["CNIC"].ToString();
                    txtAddress.Text = rdr["Address"].ToString();
                    //pbImage = Convert.ToInt32(rdr["BillId"].ToString());
                    byteImg = (byte[])rdr["Image"];
                    
                    MemoryStream stream = new MemoryStream(byteImg);
                    pbImage.Image = Image.FromStream(stream);
                    rdr.Close();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Staff NIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = Enums.Mode.Edit;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnViewAll.Enabled = true;
            dgvStaffMembers.Visible = false;
            btnViewAll.Text = "View All";
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (btnViewAll.Text == "Print")
            {
                try
                {
                    if (this.dgvStaffMembers.SelectedRows.Count > 0)
                    {
                        SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                        con.Open();


                        ReportDocument cryRpt = new ReportDocument();

                        Reports.Staff_NIC.frmStaffNIC frm = new MCKJ.Reports.Staff_NIC.frmStaffNIC();
                        frm.ID = Convert.ToInt32(dgvStaffMembers.Rows[dgvStaffMembers.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                        Reports.Staff_NIC.rptNICStaff_Front rpt = new MCKJ.Reports.Staff_NIC.rptNICStaff_Front();
                        frm.WindowState = FormWindowState.Maximized;
                        rpt.SetDatabaseLogon("sa", "sql_pwd_SA", "MCKJ-SERVER", "Community");
                        frm.crvStaffNIC.ReportSource = rpt;
                        rpt.SetParameterValue("Id", dgvStaffMembers.Rows[dgvStaffMembers.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                        rpt.SetParameterValue("IdToPrint", GetFormatId(dgvStaffMembers.Rows[dgvStaffMembers.CurrentCell.RowIndex].Cells["Id"].Value.ToString()));
                        //rpt.SetParameterValue("TransactionNo", dgBillSummary.Rows[dgBillSummary.CurrentCell.RowIndex].Cells["TransactionNo"].Value.ToString());

                        frm.Refresh();

                        frm.Show();
                        con.Close();

                    }
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                frmNICStaff_Load(null, null);
            }
        }

        private string GetFormatId(string Id)
        {
            if (Id.Length == 1)
            {
                return "000" + Id;
            }
            else if (Id.Length == 2)
            {
                return "00" + Id;
            }
            else if (Id.Length == 3)
            {
                return "0" + Id;
            }
            return string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mode = Enums.Mode.Add;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnViewAll.Enabled = true;
            dgvStaffMembers.Visible = false;
            btnViewAll.Text = "View All";
        }

        private void dgvStaffMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStaffMembers.Columns[e.ColumnIndex].Name == "Remove" && string.IsNullOrEmpty(dgvStaffMembers.Columns[e.ColumnIndex].HeaderText))
                {
                    DialogResult dr = MessageBox.Show("Do you really want to delete?", "Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Params = new ArrayList();
                        Params.Add(dgvStaffMembers.Rows[dgvStaffMembers.CurrentCell.RowIndex].Cells["Id"].Value.ToString());

                        sql = new SQLCache(Params);
                        int status = dbHelper.ExecuteNonQuery(sql.GetSQL("Delete_Staff"));

                        if (status > 0)
                        {
                            MessageBox.Show("Staff removed successfully", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillDataGrid();
                            ResetValues();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Staff NIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
    }
}