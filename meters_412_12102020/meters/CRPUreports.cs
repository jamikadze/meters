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
    public partial class CRPUreports : Form
    {
        public CRPUreports()
        {
            InitializeComponent();
        }

        private void CRPUreports_Load(object sender, EventArgs e)
        {

            if (Globals.TypeRep == 2)
            {
                this.View_METER_MOLCRPUreportTableAdapter.Fill_listOf_CRPUoffice(this.MMSDataSet.View_METER_MOLCRPUreport);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.r_All_ImportCRPU.rdlc";
                this.reportViewer1.RefreshReport();
            }
            if (Globals.TypeRep == 3)
            {
                this.View_METER_MOLCRPUreportTableAdapter.Fill_ListOff_WriteOffMeters (this.MMSDataSet.View_METER_MOLCRPUreport);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.r_listWriteOFFmeters.rdlc";
                this.reportViewer1.RefreshReport();
            }
            if (Globals.TypeRep == 4)
            {
                this.View_METER_MOLCRPUreportTableAdapter.Fill_ListOf_ReadytoWriteOFF(this.MMSDataSet.View_METER_MOLCRPUreport);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.r_CRPU_deffectOffice.rdlc";
                this.reportViewer1.RefreshReport();
            }
            if (Globals.TypeRep == 5)
            {
                this.view_reportCRPUTableAdapter.Fill(this.MMSDataSet.View_reportCRPU);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.r_CRPU.rdlc";
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
