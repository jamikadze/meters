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
    public partial class for_Marat : DevExpress.XtraEditors.XtraForm
    {
        public for_Marat()
        {
            InitializeComponent();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit6.Text);
            DateTime d = Convert.ToDateTime(dateEdit5.Text);
            this.plan_grafikTableAdapter.Fill(this.MMSDataSet.plan_grafik, s, d);
            ReportParameter ReportParameter1 = new ReportParameter("ReportParameter1", s.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ReportParameter1 });
            ReportParameter ReportParameter2 = new ReportParameter("ReportParameter2", d.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ReportParameter2 });
            this.reportViewer1.RefreshReport();
        }

        private void for_Marat_Load(object sender, EventArgs e)
        {
           
        }
    }
}