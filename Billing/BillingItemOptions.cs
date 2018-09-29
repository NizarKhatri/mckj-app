using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MCKJ.Common;
using MCKJ.Common.Enums;
using System.Data.SqlClient;

namespace MCKJ.Billing
{
    public partial class BillingItemOptions : Form
    {
        DbHelper dbHelper = new DbHelper();
        SQLCache sql = null;
        ArrayList Params = null;
        Enums.Mode mode;

        public BillingItemOptions()
        {
            InitializeComponent();
        }

        private void BillingItemOptions_Load(object sender, EventArgs e)
        {
            grpBoxBilling.Visible = false;
            dgvItemOptions.Visible = true;
            btnBack.Enabled = false;
            btnEdit.Enabled = false;
            GetItemCode();
            Params = new ArrayList();
            Params.Add(SelectItemId());
            sql = new SQLCache(Params);
            DataTable dt = dbHelper.ExecuteDataTable(sql.GetSQL("GetBillItemOptions"));
            dgvItemOptions.DataSource = dt;
        }

        private void GetItemCode()
        {
            try
            {
                Params = new ArrayList();
                Params.Add(SelectItemId());
                sql = new SQLCache(Params);
                Object value = dbHelper.ExecuteScalar(sql.GetSQL("GetItemCode"));

                if (value != null)
                {
                    if (value != null && !string.IsNullOrEmpty(value.ToString()))
                    {
                        string ItemCode = value.ToString();
                        int Code = Convert.ToInt32(ItemCode.Substring(ItemCode.Length - 3));
                        Code += 1;
                        txtItemCode.Text = ItemCode.Substring(0, 4) + Code.ToString().PadLeft(3, '0');
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidated())
                {
                    return;
                }

                int status = 0;
                Params = new ArrayList();
                if (mode == Enums.Mode.Add)
                {
                    Params.Add(SelectItemId());
                }
                else if (mode == Enums.Mode.Edit)
                {
                    Params.Add(txtItemOptionId.Text);
                }
                Params.Add(txtItemCode.Text);
                Params.Add(txtBillItem.Text);
                Params.Add(txtPrice.Text);

                sql = new SQLCache(Params);

                if (mode == Enums.Mode.Edit)
                {
                    status = dbHelper.ExecuteNonQuery(sql.GetSQL("Update_BillItemOption"));
                }
                else if (mode == Enums.Mode.Add)
                {
                    status = dbHelper.ExecuteNonQuery(sql.GetSQL("Add_BillItemOption"));
                }

                if (status > 0)
                {
                    ResetValues();
                    MessageBox.Show("Record updated successfully", "Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetValues()
        {
            txtBillItem.Text = string.Empty;
            txtPrice.Text = string.Empty;
            GetItemCode();
        }

        private bool IsValidated()
        {
            if (string.IsNullOrEmpty(txtBillItem.Text))
            {
                errorProvider.SetError(txtBillItem, "This is a required field");
                return false;
            }

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider.SetError(txtPrice, "This is a required field");
                return false;
            }

            return true;
        }

        private int SelectItemId()
        {
            switch (txtBillType.Text)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpBoxBilling.Visible = false;
            dgvItemOptions.Visible = true;
        }

        private void btnFormCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvItemOptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            if (e.RowIndex != -1)
            {
                if (dgvItemOptions.Rows[e.RowIndex].Cells["OptionText"].Value != null)
                {
                    txtBillItem.Text = dgvItemOptions.Rows[e.RowIndex].Cells["OptionText"].Value.ToString();
                }

                if (dgvItemOptions.Rows[e.RowIndex].Cells["PricePerPiece"].Value != null)
                {
                    txtPrice.Text = dgvItemOptions.Rows[e.RowIndex].Cells["PricePerPiece"].Value.ToString();
                }

                if (dgvItemOptions.Rows[e.RowIndex].Cells["ItemOptionId"].Value != null)
                {
                    txtItemOptionId.Text = dgvItemOptions.Rows[e.RowIndex].Cells["ItemOptionId"].Value.ToString();
                }

                if (dgvItemOptions.Rows[e.RowIndex].Cells["ItemCode"].Value != null)
                {
                    txtItemCode.Text = dgvItemOptions.Rows[e.RowIndex].Cells["ItemCode"].Value.ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = Enums.Mode.Edit;
            dgvItemOptions.Visible = false;
            grpBoxBilling.Visible = true;
            btnBack.Enabled = true;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            mode = Enums.Mode.Add;
            txtBillItem.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtItemOptionId.Text = string.Empty;
            btnEdit.Enabled = false;
            dgvItemOptions.Visible = false;
            grpBoxBilling.Visible = true;
            btnBack.Enabled = true;
            GetItemCode();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BillingItemOptions_Load(null, null);
            //grpBoxBilling.Visible = false;
            //dgvItemOptions.Visible = true;
            btnBack.Enabled = false;
        }
    }
}