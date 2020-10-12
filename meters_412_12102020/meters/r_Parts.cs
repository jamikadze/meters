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
    public partial class r_Parts : DevExpress.XtraEditors.XtraForm
    {
        public r_Parts()
        {
            InitializeComponent();
        }

        private void r_Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Hms_ship' table. You can move, or remove it, as needed.
            this.hms_shipTableAdapter.Fill(this.mMSDataSet.Hms_ship);
            // TODO: This line of code loads data into the 'mMSDataSet.Hms_ship' table. You can move, or remove it, as needed.
            this.hms_shipTableAdapter.Fill(this.mMSDataSet.Hms_ship);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.hms_shipTableAdapter.FillByDate(this.mMSDataSet.Hms_ship, dtp1.Value, dtp2.Value);
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

            grid.ShowPrintPreview();
        }
    }
}