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
    public partial class reportN3 : Form
    {
        int iddoc;
        public reportN3(int id_mdoc)
        {

            InitializeComponent();
            int iddoc = id_mdoc;
            this.nakladnoi_metersTableAdapter.FillById(this.MMSDataSet.nakladnoi_meters, iddoc);
            this.reportViewer3.RefreshReport();
        }

        private void reportN3_Load(object sender, EventArgs e)
        {
            //this.nakladnoi_metersTableAdapter.FillById(this.MMSDataSet.nakladnoi_meters, iddoc);
            //this.reportViewer3.RefreshReport();

        }
    }
}
