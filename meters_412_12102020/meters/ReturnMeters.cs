using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace meters
{
    public partial class ReturnMeters : Form
    {
        public ReturnMeters()
        {
            InitializeComponent();
        }

        private void ReturnMeters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MMSDataSet.Users' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'MMSDataSet.View_METER_MOLCRPU' table. You can move, or remove it, as needed.
           // this.view_METER_MOLCRPUTableAdapter.Fill(this.MMSDataSet.View_METER_MOLCRPU);
            // TODO: This line of code loads data into the 'MMSDataSet.nakladnoi_meters' table. You can move, or remove it, as needed.
            //this.nakladnoi_metersTableAdapter.FillById(this.MMSDataSet.nakladnoi_meters);

           // this.reportViewer1.RefreshReport();
            try
            {
                
                    this.view_METER_MOLCRPUTableAdapter.Fill_IdDeff(MMSDataSet.View_METER_MOLCRPU, Globals.iddeffect);

                    MessageBox.Show(MMSDataSet.View_METER_MOLCRPU.Rows.Count.ToString());
                    this.reportViewer2.RefreshReport();
                 //this.nakladnoi_metersTableAdapter.FillById(this.MMSDataSet.nakladnoi_meters, Globals.id_doc_meter_mol_docs);
                //this.reportViewer1.RefreshReport();

            }
            catch
            {
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
