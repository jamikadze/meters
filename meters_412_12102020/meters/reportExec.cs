using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DevExpress.XtraEditors;

namespace meters
{
    public partial class reportExec : Form
    {
        public reportExec()
        {
            InitializeComponent();
        }

        private void reportExec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MMSDataSet.view_for_reestr' table. You can move, or remove it, as needed.
            this.viewMonterMaterialsTableAdapter.Fill(this.mMSDataSet.ViewMonterMaterials, Globals.id_slujbi,Globals.date1,Globals.date2);


            
           
            ReportParameter ReportParameter1 = new ReportParameter("ReportParameter1", Convert.ToString(Globals.date1));
            ReportParameter ReportParameter2 = new ReportParameter("ReportParameter1", Convert.ToString(Globals.date2));
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ReportParameter1 });
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ReportParameter2 });
            this.reportViewer1.RefreshReport();


        }
    }
}
