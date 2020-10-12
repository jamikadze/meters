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
using DevExpress.XtraGrid;

namespace meters
{
    public partial class All_installed_meters : DevExpress.XtraEditors.XtraForm
    {
        public All_installed_meters()
        {
            InitializeComponent();
        }

        private void All_installed_meters_Load(object sender, EventArgs e)
        {    
            this.all_installed_metersTableAdapter.Fill(this.mMSDataSet.all_installed_meters);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Slujba' table. You can move, or remove it, as needed.
            this.spr_SlujbaTableAdapter.FillByRES(this.mMSDataSet.spr_Slujba);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterType' table. You can move, or remove it, as needed.
            this.spr_MeterTypeTableAdapter.Fill(this.mMSDataSet.spr_MeterType);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Executor' table. You can move, or remove it, as needed.
            this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            // TODO: This line of code loads data into the 'mMSDataSet.all_installed_meters' table. You can move, or remove it, as needed.
        
            spr_masterTableAdapter.FillByAll(mMSDataSet.spr_master);
            spr_master2TableAdapter.FillByAll(mMSDataSet.spr_master2);
            spr_installer2TableAdapter.FillByAll(mMSDataSet.spr_installer2);
            spr_MetrologTableAdapter.FillByAll(mMSDataSet.spr_Metrolog);
            //GridGroupSummaryItem item = new GridGroupSummaryItem();
            //item.FieldName = "id_Installer";
            //item.SummaryType = DevExpress.Data.SummaryItemType.Count;
            //advBandedGridView1.GroupSummary.Add(item);
            //// Create and setup the second summary item.
            //GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            //item1.FieldName = "id_Installer";
            //item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //item1.DisplayFormat = "Total {0:c2}";
            //item1.ShowInGroupColumnFooter = advBandedGridView1.Columns["UnitPrice"];
            //gridView1.GroupSummary.Add(item1);

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(all_installed_metersGridControl);
        }
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit6.Text);
            DateTime d = Convert.ToDateTime(dateEdit5.Text);
            this.all_installed_metersTableAdapter.FillByDate(mMSDataSet.all_installed_meters, s, d);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            this.all_installed_metersTableAdapter.Fill(this.mMSDataSet.all_installed_meters);
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}