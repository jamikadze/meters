using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace meters
{
    public partial class akt_byt : DevExpress.XtraEditors.XtraForm
    {
        public akt_byt()
        {
            InitializeComponent();
        }

        private void akt_byt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MMSDataSet1.spr_Reg_Billing_for_report' table. You can move, or remove it, as needed.
            this.spr_Reg_Billing_for_reportTableAdapter.Fill_byt(this.MMSDataSet1.spr_Reg_Billing_for_report, Globals.id_slujbi, Globals.tp_name);

            this.reportViewer1.RefreshReport();
        }
    }
}