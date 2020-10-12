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
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;
using Microsoft.Reporting.WinForms;

namespace meters
{
    public partial class r_CountStatus : Form
    {

        public r_CountStatus()
        {
            InitializeComponent();

           
        }

        private void r_CountStatus_Load(object sender, EventArgs e)
        {
            cb.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            // Check whether the GridControl can be previewed.
            if (!gridControl1.IsPrintingAvailable || !gridControl2.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            

            // Open the Preview window.
            gridControl1.ShowPrintPreview();
            // Open the Preview window.
            gridControl2.ShowPrintPreview();
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_byRegionTableAdapter.Fill(this.mMSDataSet.r_byRegion, cb.SelectedIndex+1 );
            r_byStockTableAdapter.Fill(this.mMSDataSet.r_byStock, cb.SelectedIndex + 1);            
        }
      
    }
}