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
    public partial class deffectedList : Form
    {
        public deffectedList()
        {
            InitializeComponent();
        }

        private void deffectedList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet1.METER_MOL_CRPU2' table. You can move, or remove it, as needed.
           // this.mETER_MOL_CRPU2TableAdapter.Fill(this.mMSDataSet1.METER_MOL_CRPU2);
            // TODO: This line of code loads data into the 'mMSDataSet.ReturnMeterReason' table. You can move, or remove it, as needed.
            this.returnMeterReasonTableAdapter.Fill_Mode(this.mMSDataSet.ReturnMeterReason, 2);

        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.statusDEff= (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");               
            }
        }

        private void BT_deff_return_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Вы уверены что хотите поменять \nстатус возврата в ЦРПУ?", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 this.mETER_MOL_CRPU2TableAdapter.UpdateID_additionalReason(Globals.statusDEff, Globals.idDeff2);            
             }
             Close();
        }
    }
}
