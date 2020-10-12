using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meters
{
    public partial class historyMeter : Form
    {
        public historyMeter()
        {
            InitializeComponent();
        }

        private void historyMeter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterStatus' table. You can move, or remove it, as needed.
            this.spr_MeterStatusTableAdapter.Fill(this.mMSDataSet.spr_MeterStatus);
            // TODO: This line of code loads data into the 'mMSDataSet.Sim' table. You can move, or remove it, as needed.
            this.simTableAdapter.Fill(this.mMSDataSet.Sim);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
            // TODO: This line of code loads data into the 'mMSDataSet.HistoryMeter' table. You can move, or remove it, as needed.
            this.historyMeterTableAdapter.Fill(this.mMSDataSet.HistoryMeter);

        }

        private void ПросмотристорииtoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
