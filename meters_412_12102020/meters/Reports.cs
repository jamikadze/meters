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
using Microsoft.Reporting.WinForms;

namespace meters
{
    public partial class Reports : DevExpress.XtraEditors.XtraForm
    {
        public Reports()
        {
            InitializeComponent();
            this.nakladnoiTableAdapter.Fill(this.MMSDataSet.nakladnoi, Globals.id_doc_materials);
            ReportParameter Parameter1 = new ReportParameter("Parameter1", Globals.id_doc_materials.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Parameter1 });
            this.reportViewer1.RefreshReport();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MMSDataSet.nakladnoi' table. You can move, or remove it, as needed.
            this.nakladnoiTableAdapter.Fill(this.MMSDataSet.nakladnoi,Globals.id_doc_materials);
            ReportParameter Parameter1 = new ReportParameter("Parameter1", Globals.id_doc_materials.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Parameter1 });
            this.reportViewer1.RefreshReport();
        }
    }
}