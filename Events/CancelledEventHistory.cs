using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MCKJ.Events
{
    public partial class CancelledEventHistory : Form
    {
        public CancelledEventHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelledEventHistory_Load(object sender, EventArgs e)
        {
            dgvCancelledEvents.DataSource = CancelledEvents;
            dgvCancelledEvents.Columns["BookingId"].DisplayIndex = 0;
            dgvCancelledEvents.Columns["EventId"].Visible = false;
            dgvCancelledEvents.Columns["EventCancellationId"].Visible = false;
            dgvCancelledEvents.Columns["IsActive"].Visible = false;
        }

        public DataTable CancelledEvents;
    }
}