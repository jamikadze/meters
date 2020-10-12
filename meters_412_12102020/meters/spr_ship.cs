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
    public partial class spr_ship : Form
    {
        public spr_ship()
        {
            InitializeComponent();
        }

        private void spr_ship_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.big_sprShipments' table. You can move, or remove it, as needed.
            this.big_sprShipmentsTableAdapter.Fill(this.mMSDataSet.big_sprShipments);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            this.big_sprShipmentsTableAdapter.Fill(this.mMSDataSet.big_sprShipments);
        }
    }
}
