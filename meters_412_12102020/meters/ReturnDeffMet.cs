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
    public partial class ReturnDeffMet : Form
    {
        public ReturnDeffMet()
        {
            InitializeComponent();
        }

        private void ReturnDeffMet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            this.shipmentsTableAdapter.FillByDeffectNO(this.mMSDataSet.Shipments);
            // TODO: This line of code loads data into the 'mMSDataSet.ReturnMeterReason' table. You can move, or remove it, as needed.
            this.returnMeterReasonTableAdapter.Fill(this.mMSDataSet.ReturnMeterReason);
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            // TODO: This line of code loads data into the 'mMSDataSet.ReturnDeffectMeters' table. You can move, or remove it, as needed.
            this.returnDeffectMetersTableAdapter.Fill(this.mMSDataSet.ReturnDeffectMeters);

        }
    }
}
