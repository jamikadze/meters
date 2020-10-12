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

namespace meters
{
    public partial class Reports2 : DevExpress.XtraEditors.XtraForm
    {
        
        public Reports2()
        {
            
            InitializeComponent();  
         
                //this.nakladnoi_metersTableAdapter.FillById(this.MMSDataSet.nakladnoi_meters, id_mdoc);
                //this.reportViewer1.RefreshReport();
            //this.nakladnoi_metersTableAdapter.FillById(this.MMSDataSet.nakladnoi_meters, Globals.id_doc_meter_mol_docs);
            //this.reportViewer2.RefreshReport();
           
        }

        private void Reports2_Load(object sender, EventArgs e)
        {
            try
            {
                this.nakladnoi_metersTableAdapter.FillById(this.MMSDataSet.nakladnoi_meters, Globals.id_doc_meter_mol_docs);
                this.reportViewer2.RefreshReport();

            }
            catch
            {
            }
      
          
            // TODO: This line of code loads data into the 'MMSDataSet.nakladnoi_meters' table. You can move, or remove it, as needed.
         
        }
        }

       
}