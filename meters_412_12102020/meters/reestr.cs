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
    public partial class reestr : DevExpress.XtraEditors.XtraForm
    {
        public reestr()
        {
            InitializeComponent();
           
        }

        private void reestr_Load(object sender, EventArgs e)
        {
           
            
           // TODO: This line of code loads data into the 'MMSDataSet.view_for_reestr' table. You can move, or remove it, as needed.
            this.view_for_reestrTableAdapter.Fill(this.MMSDataSet.view_for_reestr,Globals.id_slujbi,Globals.tp_name);
            int i =view_for_reestrBindingSource.Count;
            ReportParameter ReportParameter1 = new ReportParameter("ReportParameter1", Globals.name_slujbi);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ReportParameter1 });
            ReportParameter ReportParameter2 = new ReportParameter("ReportParameter2", Globals.master_vpu);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ReportParameter2 });
            this.reportViewer1.RefreshReport();
        }
    }
}