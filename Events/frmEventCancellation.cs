using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MCKJ.ComDataSetTableAdapters;
namespace MCKJ.Events
{
    public partial class frmEventCancellation : Form
    {
        usp_SEL_CancelledEventsTableAdapter objAdapter = new usp_SEL_CancelledEventsTableAdapter();
        public frmEventCancellation()
        {
            InitializeComponent();
        }

        private void frmEventCancellation_Load(object sender, EventArgs e)
        {
            this.PopulateData(SelectedEvent);
        }

        private void PopulateData(DataGridViewRow row)
        {
            try
            {
                txtEventName.Text = Convert.ToString(row.Cells["Event"].FormattedValue);

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name.StartsWith("Hall"))
                    {
                        if(Convert.ToBoolean(cell.Value))
                        chkBxListHallNo.Items.Add(cell.OwningColumn.Name);
                    }
                }
                
                dtpEventDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataGridViewRow SelectedEvent;

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure, you want to cancel Booking for selected Hall(s)?",
                    "Confirm booking cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int eventId = Convert.ToInt32( SelectedEvent.Cells["ID"].Value);
                    foreach (object item in chkBxListHallNo.CheckedItems)
                    {
                        objAdapter.Insert(eventId, dtpEventDate.Value, dtpCancellationDate.Value, item.ToString(), txtComments.Text, BookingId);
                    }

                    MessageBox.Show("Hall(s) booking has been cancelled.");
                    this.Close();
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Public Variables
        public int? BookingId;

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}