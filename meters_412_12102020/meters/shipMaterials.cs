using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using DevExpress.XtraEditors;
using DevExpress.ReportServer;

namespace meters
{
    public partial class shipMaterials : Form
    {
        public shipMaterials()
        {
            InitializeComponent();
        }

        private void shipMaterials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.ViewMonterMaterials' table. You can move, or remove it, as needed.
          this.viewMonterMaterialsTableAdapter.Fill(this.mMSDataSet.ViewMonterMaterials, Globals.id_slujbi, Globals.date1, Globals.date2);
          //  this.viewMonterMaterialsTableAdapter.FillBymater(this.mMSDataSet.ViewMonterMaterials, Globals.date1, Globals.date2);


            this.reportViewer1.RefreshReport();
        }
    }
}
