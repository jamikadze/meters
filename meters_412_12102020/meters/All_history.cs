using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace meters
{
    public partial class All_history : UserControl
    {
        public All_history()
        {
            InitializeComponent();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void All_history_Load(object sender, EventArgs e)
        {
            this.shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
            this.spr_MeterTypeTableAdapter.Fill(this.mMSDataSet.spr_MeterType);
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            this.simTableAdapter.Fill(this.mMSDataSet.Sim);
            this.partMeterTableAdapter.Fill(this.mMSDataSet.PartMeter,Globals.name_user);
            this.spr_MeterStatusTableAdapter.Fill(this.mMSDataSet.spr_MeterStatus);
        }

        private void shipmentsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_Shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                Globals.id_Shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                this.historyMeterSimTableAdapter.FillByIdShipments(mMSDataSet.HistoryMeterSim, Globals.id_Shipments);
            }
            catch { }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
        }
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("Не найдена библиотека 'DevExpress.XtraPrinting", "Ошибка");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl2);
        }

       
    }
}
