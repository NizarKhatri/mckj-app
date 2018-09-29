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
using CrystalDecisions.CrystalReports.Engine;
using Community;

namespace MCKJ.Billing
{
    public partial class frmGenerateBill : Form
    {
        DbHelper dbHelper = new DbHelper();
        SQLCache sql = null;
        ArrayList Params = null;
        Enums.Mode mode;
        static DataTable dtSearch;
        private int counter = 0;
        private int row = 0;
        public string BillType;
        private bool nonNumberEntered;
        private int totalItems = 0;
        private double totalQuantity = 0;
        private double grandTotal = 0;
        private int counterUpdate = 0;
        private int totalItemsUpdate = 0;
        private double totalQuantityUpdate = 0;
        private double grandTotalUpdate = 0;
        private bool isBillEdit = false;
        private int EventsID = 0;
        DataTable dt = new DataTable();
        public frmGenerateBill()
        {
            InitializeComponent();


        }
        //Variables--------------------------------------------------------
        //-----------------------------------------------------------------                                                      
     
        int Exit = 0;
        string chk_active = "";
        int SecurityLevelID = 18;
        int UserID = Community.DBLayer.ID;
        bool rNew = false;
        bool rEdit = false;
        bool rDelete = false;
        Community.DBLayer DBLayer = new Community.DBLayer();
        string Header = "Family Cards";

        private void User_Right()
        {
            Community.DBLayer DBLayer = new Community.DBLayer();
            SqlConnection con = new SqlConnection(Community.DBLayer.con_String);

            try
            {
                SqlCommand cmd = new SqlCommand("Select Write,Modify,[Delete] from tblPermission  Where UserID =" + UserID + " And SecurityLevelID= " + SecurityLevelID, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    rNew = Convert.ToBoolean(reader.GetValue(0));
                    rEdit = Convert.ToBoolean(reader.GetValue(1));
                    rDelete = Convert.ToBoolean(reader.GetValue(2));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            //return chk_Right;
        }

        private void GenerateBill_Load(object sender, EventArgs e)
        {

            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
            {
                btnEdit.Enabled = true;
            }
            else
                btnEdit.Enabled = false;
            if (DBLayer.User_Right(UserID, SecurityLevelID, "[Write]"))
                btnNew.Enabled = true;
            else
                btnNew.Enabled = false;
            // TODO: This line of code loads data into the 'dataset2.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataset2.tblEvents);
            // TODO: This line of code loads data into the 'dataset2.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataset2.tblEvents);
            //this.AutoScrollPosition = new Point(1200,1200);
            //Generate transaction number
            GenerateTransactionId();

            //Fill Grid on Load
            FillDataGrid();

            //Load Group Box
            LoadBillerInformation();

            //Populate Items
            PopulateItemOptions();

            //Populate Search Criteria 
            foreach (DataColumn dc in dtSearch.Columns)
            {
                cmbCriteria.Items.Add(dc.ToString());
            }

        }

        private void FillDataGrid()
        {
            Params = new ArrayList();
            Params.Add(SelectItemId());
            sql = new SQLCache(Params);
            //DataTable dt = dbHelper.ExecuteDataTable(sql.GetSQL("GetBillDetail"));
            dtSearch = dbHelper.ExecuteDataTable(sql.GetSQL("GetBillDetail"));
            //dgBillSummary.DataSource = dt;
            dgBillSummary.DataSource = dtSearch;
            //mode = Enums.Mode.Edit;
            dgBillSummary.Focus();
            dgBillSummary.ClearSelection();

        }

        private void GenerateTransactionId()
        {
            Params = new ArrayList();
            Params.Add(SelectItemId());
            sql = new SQLCache(Params);
            string transID = dbHelper.ExecuteScalar(sql.GetSQL("GetTransactionIdByBillType"));

            int counter = 0;

            if (string.IsNullOrEmpty(transID))
            {
                transID = GetCode(BillType) + DateTime.Now.Year + "-" + "0001";
            }
            else
            {
                if (Convert.ToInt32(transID.Substring(9, 4)) == DateTime.Now.Year)
                {
                    counter = Convert.ToInt32(transID.Substring(14)) + 1;
                    transID = transID.Substring(0, 9) + DateTime.Now.Year + "-" + counter.ToString().PadLeft(4, '0');
                }
                else
                {
                    transID = GetCode(BillType) + DateTime.Now.Year + "-" + "0001";
                }
            }

            txtTransaction.Text = transID;
        }

        private void PopulateItemOptions()
        {
            Params = new ArrayList();
            Params.Add(SelectItemId());
            sql = new SQLCache(Params);

            DataTable dt = dbHelper.ExecuteDataTable(sql.GetSQL("GetBillItemOptions"));

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.NewRow();
                row["Name"] = "Please select Item Option";
                dt.Rows.InsertAt(row, 0);

                cmbItemName.DisplayMember = "Name";
                cmbItemName.ValueMember = "ID";
                cmbItemName.DataSource = dt;
            }

        }

        private int SelectItemId()
        {
            switch (BillType)
            {
                case "Coffin":
                    return 1;
                case "Decoration":
                    return 2;
                case "Bus":
                    return 3;
                default:
                    return 0;
            }
        }

        private string GenerateCounter(int counter)
        {
            int length = Convert.ToInt32(Convert.ToString(counter).Length);
            string value = string.Empty;

            if (length == 1)
            {
                value = "00" + counter;
            }
            else if (length == 2)
            {
                value = "0" + counter;
            }
            else
            {
                value = counter.ToString();
            }

            return value;
        }

        private string GetCode(string type)
        {
            switch (BillType)
            {
                case "Coffin":
                    return "MCKJ-CFN-";
                case "Decoration":
                    return "MCKJ-DCR-";
                case "Bus":
                    return "MCKJ-BUS-";
                default:
                    return "";
            }
        }

        private void txtCardNo_Leave(object sender, EventArgs e)
        {
            BindBillerInformation();
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BindBillerInformation();
            }
        }

        private void BindBillerInformation()
        {
            if (string.IsNullOrEmpty(txtCardNo.Text))
            {
                errorProvider.SetError(txtCardNo, "Please enter family card number");
                return;
            }

            errorProvider.SetError(txtCardNo, String.Empty);
            errorProvider.Clear();
            Params = new ArrayList();
            Params.Add(txtCardNo.Text);

            sql = new SQLCache(Params);
            SqlDataReader rdr = dbHelper.ExecuteReader(sql.GetSQL("GetMemberInfo"));

            if (rdr != null)
            {
                rdr.Read();

                if (!rdr["MemberName"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["MemberName"].ToString()))
                {
                    txtName.Text = rdr["MemberName"].ToString();
                }

                if (!rdr["FatherName"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["FatherName"].ToString()))
                {
                    txtFatherName.Text = rdr["FatherName"].ToString();
                }

                if (!rdr["Mobile"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["Mobile"].ToString()))
                {
                    txtCellNo.Text = rdr["Mobile"].ToString();
                }

                if (!rdr["Sign"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["Sign"].ToString()))
                {
                    txtOrakh.Text = rdr["Sign"].ToString();
                }

                if (!rdr["ResidentAddress"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["ResidentAddress"].ToString()))
                {
                    txtAddress.Text = rdr["ResidentAddress"].ToString();
                }
            }
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItemName.SelectedIndex <= 0)
            {
                txtItemCode.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtPriceTotal.Text = string.Empty;
            }
            else
            {
                BindItemInformation();
            }
        }

        private void BindItemInformation()
        {
            int ItemID = Convert.ToInt32(cmbItemName.SelectedValue.ToString());

            Params = new ArrayList();
            Params.Add(ItemID);
            sql = new SQLCache(Params);

            SqlDataReader rdr = dbHelper.ExecuteReader(sql.GetSQL("GetItemOptionsByOptionId"));
            
            if (rdr != null)
            {
                rdr.Read();

                if (!rdr["ItemCode"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["ItemCode"].ToString()))
                {
                    txtItemCode.Text = rdr["ItemCode"].ToString();
                }

                if (!rdr["PricePerPiece"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["PricePerPiece"].ToString()))
                {
                    txtPrice.Text = rdr["PricePerPiece"].ToString();
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtQuantity.Text) && Convert.ToDouble(txtQuantity.Text) > 0)
                {
                    if (mode == Enums.Mode.Edit)
                    {
                        this.dgvItemOptions.Rows.RemoveAt(row - 1);
                        totalQuantity = totalQuantity - totalQuantityUpdate;
                        grandTotal = grandTotal - grandTotalUpdate;

                        txtTotalQuantity.Text = totalQuantity.ToString();
                        txtGrandTotal.Text = grandTotal.ToString();

                        mode = Enums.Mode.Add;

                        totalQuantity = totalQuantity + Convert.ToDouble(txtQuantity.Text);
                        grandTotal = grandTotal + Convert.ToDouble(txtPriceTotal.Text);

                        this.dgvItemOptions.Rows.Add(row.ToString(), txtItemCode.Text, cmbItemName.Text, txtQuantity.Text, txtPrice.Text, txtPriceTotal.Text, Properties.Resources.DeleteRed);
                        txtTotalItems.Text = totalItems.ToString();
                        txtTotalQuantity.Text = totalQuantity.ToString();
                        txtGrandTotal.Text = grandTotal.ToString();
                        this.dgvItemOptions.Sort(this.dgvItemOptions.Columns["SerialNo"], ListSortDirection.Ascending);
                        ResetValues();
                    }
                    else
                    {
                        counter = counter + 1;
                        totalItems = totalItems + 1;
                        totalQuantity = totalQuantity + Convert.ToDouble(txtQuantity.Text);
                        grandTotal = grandTotal + Convert.ToDouble(txtPriceTotal.Text);

                        this.dgvItemOptions.Rows.Add(counter.ToString(), txtItemCode.Text, cmbItemName.Text, txtQuantity.Text, txtPrice.Text, txtPriceTotal.Text, Properties.Resources.DeleteRed);
                        txtTotalItems.Text = totalItems.ToString();
                        txtTotalQuantity.Text = totalQuantity.ToString();
                        txtGrandTotal.Text = grandTotal.ToString();
                        this.dgvItemOptions.CurrentCell = this.dgvItemOptions[0, this.dgvItemOptions.Rows.Count - 1];
                        ResetValues();
                    }
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && Convert.ToDouble(txtQuantity.Text) >= 0 && Convert.ToDouble(txtPrice.Text) > 0) 
            {
                double totalPrice = Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtPrice.Text);
                txtPriceTotal.Text = totalPrice.ToString();
            }
            else
            {
                txtQuantity.Text = string.Empty;
                txtPriceTotal.Text = string.Empty;   
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9 || e.KeyCode == Keys.Decimal)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9 || e.KeyCode == Keys.Decimal)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
        }

        private void ResetValues()
        {
            dgvItemOptions.ClearSelection();
            cmbItemName.Focus();
            txtQuantity.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRegNo_Leave(object sender, EventArgs e)
        {
            if (BillType == Enums.BillType.Decoration.ToString())
            {
                BindBillerInformationByRegNo();     
            }
        }

        private void BindBillerInformationByRegNo()
        {
            //if (string.IsNullOrEmpty(txtRegNo.Text))
            //{
            //    errorProvider.SetError(txtRegNo, "Please enter registration number");
            //    return;
            //}

            //errorProvider.SetError(txtRegNo, String.Empty);
            //errorProvider.Clear();
            Params = new ArrayList();
            Params.Add(txtRegNo.Text);

            sql = new SQLCache(Params);
            SqlDataReader rdr = dbHelper.ExecuteReader(sql.GetSQL("GetMemberInfoByRegNo"));

            if (rdr != null)
            {
                rdr.Read();

                if (!rdr["MemberName"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["MemberName"].ToString()))
                {
                    txtName.Text = rdr["MemberName"].ToString();
                }

                if (!rdr["FatherName"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["FatherName"].ToString()))
                {
                    txtFatherName.Text = rdr["FatherName"].ToString();
                }

                if (!rdr["Mobile"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["Mobile"].ToString()))
                {
                    txtCellNo.Text = rdr["Mobile"].ToString();
                }

                if (!rdr["Sign"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["Sign"].ToString()))
                {
                    txtOrakh.Text = rdr["Sign"].ToString();
                }

                if (!rdr["ResidentAddress"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["ResidentAddress"].ToString()))
                {
                    txtAddress.Text = rdr["ResidentAddress"].ToString();
                }

                if (!rdr["CardNo"].Equals(DBNull.Value) && !string.IsNullOrEmpty(rdr["CardNo"].ToString()))
                {
                    txtCardNo.Text = rdr["CardNo"].ToString();
                }
            }
        }

        private void LoadBillerInformation()
        {
            if (BillType == Enums.BillType.Decoration.ToString())
            {
                txtRegNo.Visible = true;
                lblRegNo.Visible = true;
                gbBiller.Visible = true;
                lblEvent.Visible = true;
                cmbEvent.Visible = true;
                gbCoffin.Visible = false;
                //DisableControls(true);
                
            }
            else if (BillType == Enums.BillType.Bus.ToString())
            {
                txtRegNo.Visible = false;
                lblRegNo.Visible = false;
                gbBiller.Visible = true;
                gbCoffin.Visible = false;
                lblEvent.Visible = false;
                cmbEvent.Visible = false;
                gbAdvance.Visible = true;
                gbAdvance.Visible = false;
                //DisableControls(false);
            }
            else if (BillType == Enums.BillType.Coffin.ToString())
            {
                txtRegNo.Visible = false;
                lblRegNo.Visible = false;
                gbBiller.Visible = false;
                gbCoffin.Visible = true;
                lblEvent.Visible = false;
                cmbEvent.Visible = false;
                gbAdvance.Visible = false;
            }
            btnEdit.Enabled = false;
        }

        private void DisableControls(bool value)
        {
            txtCardNo.ReadOnly = value;
            txtName.ReadOnly = value;
            txtFatherName.ReadOnly = value;
            txtOrakh.ReadOnly = value;
            txtAddress.ReadOnly = value;
            txtCellNo.ReadOnly = value;
        }

        private void dgvItemOptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemOptions.Rows[e.RowIndex].Cells["OptionText"].Value != null)
            {
                cmbItemName.Text = dgvItemOptions.Rows[e.RowIndex].Cells["OptionText"].Value.ToString();
            }

            if (dgvItemOptions.Rows[e.RowIndex].Cells["Quantity"].Value != null)
            {
                txtQuantity.Text = dgvItemOptions.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }

            if (dgvItemOptions.Rows[e.RowIndex].Cells["SerialNo"].Value != null)
            {
                row = Convert.ToInt32(dgvItemOptions.Rows[e.RowIndex].Cells["SerialNo"].Value.ToString());
            }
            
            totalQuantityUpdate = Convert.ToDouble(txtQuantity.Text);
            grandTotalUpdate = Convert.ToDouble(txtPriceTotal.Text);
            mode = Enums.Mode.Edit;
        }

        private void dgvItemOptions_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (mode != Enums.Mode.Edit)
            {
                for (int i = 0; i <= dgvItemOptions.Rows.Count - 1; i++)
                {
                    dgvItemOptions.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkLease.Checked == false)
                {
                    DialogResult dr = MessageBox.Show("Would you like to apply Lease Renewal Fund on this bill ? ", "Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        return;
                    }
                }
                Params = new ArrayList();
                string query = string.Empty;

                Params.Add(SelectItemId());
                Params.Add(txtTransaction.Text);
                Params.Add(txtRegNo.Text);
                Params.Add(Convert.ToDateTime(dtpDate.Value.ToString("dd/MM/yyyy"))); 
                Params.Add(txtTotalItems.Text);
                Params.Add(txtTotalQuantity.Text);
                Params.Add(txtGrandTotal.Text);
                if(chkIsPaid.Checked == true)
                    Params.Add(1);
                else
                    Params.Add(0);
                if (BillType == Enums.BillType.Coffin.ToString())
                {
                    Params.Add(txtCardNo.Text);
                    Params.Add(txtDeceasedName.Text);
                    Params.Add(txtRelName.Text);
                    Params.Add(txtDeceasedOrakh.Text);
                    Params.Add(txtApplicantPhone.Text);
                    Params.Add(txtDeceasedAge.Text);
                    Params.Add(txtReasonOfDeath.Text);
                    Params.Add(dtpTimeOfDeath.Text);
                    Params.Add(txtApplicantName.Text);
                    

                    sql = new SQLCache(Params);
                    query = sql.GetSQL("Insert_tblBill_Coffin");
                }
                else
                {
                    Params.Add(txtCardNo.Text);
                    Params.Add(txtName.Text);
                    Params.Add(txtFatherName.Text);
                    Params.Add(txtOrakh.Text);
                    Params.Add(txtCellNo.Text);
                    Params.Add(txtAddress.Text);
                    Params.Add(string.IsNullOrEmpty(txtAdvAmount.Text) ? "0" : txtAdvAmount.Text);
                    Params.Add(string.IsNullOrEmpty(txtSlipNo.Text) ? "0" : txtSlipNo.Text);
                    Params.Add(txtAdvDated.Text);
                    if(cmbEvent.SelectedValue == null)
                        Params.Add(0);
                    else
                        Params.Add(Int32.Parse(cmbEvent.SelectedValue.ToString()));

                    if (isBillEdit)
                    {
                        Params.Add(hdnBillId.Text);
                        Params.Add(string.IsNullOrEmpty(txtLease.Text) ? "0" : txtLease.Text);
                        sql = new SQLCache(Params);
                        query = sql.GetSQL("Update_tblBill");
                        query = query + sql.GetSQL("Update_tblBillDetail");
                    }
                    else
                    {
                        Params.Add(string.IsNullOrEmpty(txtLease.Text) ? "0" : txtLease.Text);
                        sql = new SQLCache(Params);
                        query = sql.GetSQL("Insert_tblBill");
                    }
                }

                foreach (DataGridViewRow row in dgvItemOptions.Rows)
                {
                    Params = new ArrayList();
                    Params.Add(row.Cells["ItemCode"].Value);
                    Params.Add(row.Cells["OptionText"].Value);
                    Params.Add(row.Cells["Quantity"].Value);
                    Params.Add(row.Cells["PricePerPiece"].Value);
                    Params.Add(row.Cells["Total"].Value);


                    if (isBillEdit)
                    {
                        Params.Add(hdnBillId.Text);
                    }

                    sql = new SQLCache(Params);
                    query = query + sql.GetSQL("Insert_tblBillDetail");
                }
                query = query + sql.GetSQL("Insert_tblBillDetailEndRegion");

                int status = dbHelper.ExecuteNonQuery(query);

                if (status > 0)
                {
                    MessageBox.Show("Record updated successfully", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAfterSubmission();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetAfterSubmission()
        {
            txtRegNo.Text = string.Empty;
            dtpDate.Text = DateTime.Now.ToLongDateString();

            //CFN
            txtDeceasedName.Text = string.Empty;
            txtRelName.Text = string.Empty;
            txtDeceasedOrakh.Text = string.Empty;
            txtDeceasedAge.Text = string.Empty;
            txtReasonOfDeath.Text = string.Empty;
            dtpTimeOfDeath.Text = DateTime.Now.ToShortTimeString();
            txtApplicantName.Text = string.Empty;
            txtApplicantPhone.Text = string.Empty;

            //DCR & BUS
            txtCardNo.Text = string.Empty;
            txtName.Text = string.Empty;
            txtFatherName.Text = string.Empty;
            txtOrakh.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCellNo.Text = string.Empty;

            //------------

            txtItemCode.Text = string.Empty;
            cmbItemName.SelectedIndex = 0;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtPriceTotal.Text = string.Empty;

            //----------------------

            txtTotalItems.Text = string.Empty;
            txtTotalQuantity.Text = string.Empty;
            txtGrandTotal.Text = string.Empty;
            hdnBillId.Text = string.Empty;

            //--------------------------------

            dgvItemOptions.DataSource = null;
            dgvItemOptions.Rows.Clear();


            counter = 0;
            row = 0;

            isBillEdit = false;
            totalItems = 0;
            totalQuantity = 0;
            grandTotal = 0;
            counterUpdate = 0;
            totalItemsUpdate = 0;
            totalQuantityUpdate = 0;
            grandTotalUpdate = 0;

            //---------------------------
            chkLease.Checked = false;
            txtLease.Text = "0";
            txtAdvAmount.Text = string.Empty;
            txtAdvDated.Text = string.Empty;
            txtSlipNo.Text = string.Empty;
            txtNetAmount.Text = string.Empty;

            GenerateTransactionId();

        }

        private void dgBillSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DBLayer.User_Right(UserID, SecurityLevelID, "[Modify]"))
                {
                    btnEdit.Enabled = true;
                }
                else
                    btnEdit.Enabled = false;

                Params = new ArrayList();
                Params.Add(SelectItemId());
                Params.Add(dgBillSummary.Rows[dgBillSummary.CurrentCell.RowIndex].Cells[1].Value.ToString());
                sql = new SQLCache(Params);
                SqlDataReader rdr = dbHelper.ExecuteReader(sql.GetSQL("GetBillForBinding"));
                int BillId = 0;

                if (rdr != null)
                {
                    rdr.Read();

                    txtTransaction.Text = rdr["TransactionNo"].ToString();
                    txtRegNo.Text = rdr["RegNo"].ToString();
                    dtpDate.Text = rdr["EntryDate"].ToString();
                    txtTotalItems.Text = rdr["TotalItems"].ToString();
                    txtTotalQuantity.Text = rdr["TotalQuantity"].ToString();
                    txtGrandTotal.Text = rdr["GrandTotal"].ToString();
                    txtCardNo.Text = rdr["CardNo"].ToString();
                    BillId = Convert.ToInt32(rdr["BillId"].ToString());
                    hdnBillId.Text = rdr["BillId"].ToString();
                    txtAdvAmount.Text = rdr["AdvanceAmount"].ToString();
					txtSlipNo.Text = rdr["AdvSlipNo"].ToString();
                    txtAdvDated.Text = rdr["AdvanceDate"].ToString();
                    cmbEvent.SelectedValue = rdr["EventID"].ToString();
                    chkIsPaid.Checked = Convert.ToBoolean(rdr["IsPaid"].ToString());

                    if (!string.IsNullOrEmpty(txtAdvAmount.Text) && Convert.ToDouble(txtAdvAmount.Text) > 0)
                    {
                        txtNetAmount.Text = Convert.ToString(Convert.ToDouble(txtGrandTotal.Text) + (Convert.ToDouble(txtLease.Text)) - Convert.ToDouble(txtAdvAmount.Text));
                    }
                    else
                    {
                        txtNetAmount.Text = Convert.ToString(Convert.ToDouble(txtGrandTotal.Text)+ Convert.ToDouble(txtLease.Text));
                    }

                    if (rdr["LeaseRenewalFund"] != DBNull.Value && !string.IsNullOrEmpty(rdr["LeaseRenewalFund"].ToString()))
                    {
                        txtLease.Text = Convert.ToString(Convert.ToDouble(rdr["LeaseRenewalFund"].ToString()));
                    }
                    else
                    {
                        txtLease.Text = "0";
                    }

                    if (!string.IsNullOrEmpty(txtLease.Text) && Convert.ToDouble(txtLease.Text) > 0 && !chkLease.Checked)
                    {
                        chkLease.Checked = true;
                    }
                    else
                    {
                        chkLease.Checked = false;
                    }

                    if (BillType == Enums.BillType.Coffin.ToString())
                    {
                        txtDeceasedName.Text = rdr["Name"].ToString();
                        txtRelName.Text = rdr["RelativeName"].ToString();
                        txtDeceasedOrakh.Text = rdr["Orakh"].ToString();
                        txtDeceasedAge.Text = rdr["Age"].ToString();
                        txtReasonOfDeath.Text = rdr["ReasonOfDeath"].ToString();
                        dtpTimeOfDeath.Text = rdr["TimeOfDeath"].ToString();
                        txtApplicantName.Text = rdr["ApplicantName"].ToString();
                        txtApplicantPhone.Text = rdr["CellNo"].ToString();
                    }
                    else
                    {
                        txtName.Text = rdr["Name"].ToString();
                        txtFatherName.Text = rdr["RelativeName"].ToString();
                        txtOrakh.Text = rdr["Orakh"].ToString();
                        txtCellNo.Text = rdr["CellNo"].ToString();
                        txtAddress.Text = rdr["RAddress"].ToString();
                    }

                    rdr.Close();
                    Params = new ArrayList();
                    Params.Add(BillId);
                    sql = new SQLCache(Params);
                    DataTable dt = dbHelper.ExecuteDataTable(sql.GetSQL("GetBillDetailForBinding"));
                    //dgvItemOptions.DataSource = dt;
                    int counter = 0;

                    this.dgvItemOptions.Rows.Clear();
                    foreach (DataRow row in dt.Rows) 
                    {
                        string itemCode = row["ItemCode"].ToString();
                        string description = row["Description"].ToString();
                        double quantity = Convert.ToDouble(row["Quantity"].ToString());
                        double price = Convert.ToDouble(row["Price"].ToString());
                        double totalPrice = Convert.ToDouble(Convert.ToDouble(row["Price"].ToString()) * Convert.ToDouble(row["Quantity"].ToString()));
                        counter = counter + 1;

                        this.dgvItemOptions.Rows.Add(counter.ToString(), itemCode, description, quantity, price, totalPrice, Properties.Resources.DeleteRed);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgBillSummary.Hide();
            isBillEdit = true;
            //EventsID = 
            counter = dgvItemOptions.Rows.Count;
            totalItems = Convert.ToInt32(txtTotalItems.Text);
            totalQuantity = Convert.ToDouble(txtTotalQuantity.Text);
            grandTotal = Convert.ToDouble(txtGrandTotal.Text);
            btnEdit.Enabled = false;
            btnPrint.Enabled = false;
            btnSave.Enabled = true;
            gbSearch.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetAfterSubmission();
            dgBillSummary.Hide();
            txtRegNo.Focus();
            mode = Enums.Mode.Add;
            btnPrint.Enabled = false;
            isBillEdit = false;
            btnSave.Enabled = true;
            gbSearch.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GenerateBill_Load(null, null);
            dgBillSummary.Show();
            isBillEdit = false;
            btnPrint.Enabled = true;
            btnSave.Enabled = false;
            gbSearch.Visible = true;
        }

        private void txtSlipNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAdvDated.Text = string.Empty;
                txtAdvAmount.Text = string.Empty;
                txtNetAmount.Text = string.Empty;
                try
                {
                    Params = new ArrayList();
                    Params.Add(txtSlipNo.Text);
                    Params.Add(txtCardNo.Text);
                    sql = new SQLCache(Params);
                    SqlDataReader rdr = dbHelper.ExecuteReader(sql.GetSQL("GetAdvanceAmountForHallBooking"));

                    if (rdr != null)
                    {
                        rdr.Read();

                        txtAdvAmount.Text = Convert.ToDouble(rdr["Amount"]).ToString("0.00");

                        txtAdvDated.Text = Convert.ToDateTime(rdr["Date"]).ToString("dd/MM/yyyy");


                        if (Convert.ToDouble(txtGrandTotal.Text) > 0 && Convert.ToDouble(txtAdvAmount.Text) > 0)
                        {
                            txtNetAmount.Text = Convert.ToString(Convert.ToDouble(txtGrandTotal.Text) + (Convert.ToDouble(txtLease.Text)) - Convert.ToDouble(txtAdvAmount.Text));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Slip No or Family Card No", "Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvItemOptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                if (dgvItemOptions.Columns[e.ColumnIndex].Name == "Remove" && string.IsNullOrEmpty(dgvItemOptions.Columns[e.ColumnIndex].HeaderText))
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete this item ?", "Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        mode = Enums.Mode.Delete;

                        if (this.dgvItemOptions.SelectedRows.Count > 0)
                        {
                            row = dgvItemOptions.Rows.Count - 1;
                            counter = counter - 1;
                            totalQuantity = Convert.ToDouble(txtTotalQuantity.Text) - Convert.ToDouble(dgvItemOptions.Rows[e.RowIndex].Cells["Quantity"].Value);
                            grandTotal = Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(dgvItemOptions.Rows[e.RowIndex].Cells["Total"].Value);
                            totalItems = Convert.ToInt32(txtTotalItems.Text) - 1;

                            txtTotalQuantity.Text = totalQuantity.ToString();
                            txtGrandTotal.Text = grandTotal.ToString();
                            txtTotalItems.Text = totalItems.ToString();

                            dgvItemOptions.Rows.RemoveAt(this.dgvItemOptions.SelectedRows[0].Index);
                        }
                    }
                }
            }
        
        private void dgvItemOptions_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgBillSummary.SelectedRows.Count > 0)
                {
                    SqlConnection con = new SqlConnection(Community.DBLayer.con_String);
                    Reports.Billing.MainReportBilling rpt = new MCKJ.Reports.Billing.MainReportBilling();
                    
                    rpt.SetDatabaseLogon("sa", "sql_pwd_SA", "MCKJ-SERVER", "Community");
                    con.Open();


                    ReportDocument cryRpt = new ReportDocument();

                    Reports.Billing.frmReportBilling frm = new MCKJ.Reports.Billing.frmReportBilling();
                    
                    frm.WindowState = FormWindowState.Maximized;
                    frm.crvBilling.ReportSource = rpt;
                    rpt.SetParameterValue("TransactionNo", dgBillSummary.Rows[dgBillSummary.CurrentCell.RowIndex].Cells["TransactionNo"].Value.ToString());
                    if (BillType == Enums.BillType.Coffin.ToString())
                    {
                        rpt.SetParameterValue("BillType", "COFFIN BILL INVOICE");
                    }
                    else if (BillType == Enums.BillType.Decoration.ToString())
                    {
                        rpt.SetParameterValue("BillType", "DECORATION BILL INVOICE");
                    }
                    //rpt.SetParameterValue("TransactionNo", dgBillSummary.Rows[dgBillSummary.CurrentCell.RowIndex].Cells["TransactionNo"].Value.ToString());

                    frm.Refresh();

                    frm.Show();
                    con.Close();

                }
            }
            catch(Exception ex)
            {
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SerialNo is selected in cmbCriteria
            if (cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[0].ToString())
            {
                dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + "=" + txtSearch.Text;
            }
            //Net Amount is selected in cmbCriteria
            if (cmbCriteria.SelectedItem.ToString() == dtSearch.Columns[0].ToString())
            {
                dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + "=" + txtSearch.Text;
            }

            dtSearch.DefaultView.RowFilter = cmbCriteria.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";
            dgBillSummary.DataSource = dtSearch.DefaultView;
        }

        private void txtCardNo_Leave_1(object sender, EventArgs e)
        {
            dt = new DBLayer().GetFamilyByFamilyCardNo(txtCardNo.Text);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["MemberName"].ToString();
                txtFatherName.Text = dt.Rows[0]["FatherName"].ToString();
                txtOrakh.Text = dt.Rows[0]["Sign"].ToString();
                txtCellNo.Text = dt.Rows[0]["Mobile"].ToString();
                txtAddress.Text = dt.Rows[0]["ResidentAddress"].ToString();
            }
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkLease_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLease.Checked == false)
            {
                txtNetAmount.Text = Convert.ToString(Convert.ToDouble(txtNetAmount.Text) - Convert.ToDouble(txtLease.Text));
                txtLease.Text = "0";
            }
            else
            {
                if (!string.IsNullOrEmpty(txtGrandTotal.Text) && Convert.ToDouble(txtGrandTotal.Text) > 0)
                {
                    double leaseAmount = Convert.ToDouble(txtGrandTotal.Text) * 0.2;
                    txtLease.Text = leaseAmount.ToString("0.00");
                    txtNetAmount.Text = Convert.ToString(Convert.ToDouble(txtNetAmount.Text) + Convert.ToDouble(txtLease.Text));
                }
            }
        }
    }
}