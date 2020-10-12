using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace meters
{
    public partial class part_meter_add : Form
    {
        public part_meter_add()
        {
            InitializeComponent();
        }

        private void partMeterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partMeterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void part_meter_add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.HistoryMeterSim' table. You can move, or remove it, as needed.
            this.historyMeterSimTableAdapter.Fill(this.mMSDataSet.HistoryMeterSim);
            // TODO: This line of code loads data into the 'mMSDataSet.HistoryMeterSim' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'mMSDataSet.HistoryMeterSim' table. You can move, or remove it, as needed.
                       // TODO: This line of code loads data into the 'mMSDataSet.PartMeter' table. You can move, or remove it, as needed.
            this.partMeterTableAdapter.FillByNe_Vydan(this.mMSDataSet.PartMeter); 
         //this.historyMeterSimTableAdapter.Fill(this.mMSDataSet.HistoryMeterSim,);


        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            for (int i = 0; i <= gridView1.RowCount; i++)
            {
                var chek = gridView1.GetRowCellValue(i, "chek");
                int id =(int) gridView1.GetRowCellValue(i, "id");
                if (Convert.ToString(chek) != "")
                {
                    if (Convert.ToBoolean(chek) == true)
                    {

                        try
                        {

                            this.queriesTableAdapter1.insert_MeterMOLdocs2(Globals.id_doc_meter_mol_docs, id);
                        }
                        catch (SqlException se)
                        {
                            MessageBox.Show("Этот счетчик уже выдан" + se.ToString());
                        }
                        Globals.id_doc_meter_for_main = Globals.id_doc_meter_mol_docs;
                        Globals.en_delegate_cmol();
                        Close();
                        
                    }
                }
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            for (int i = 0; i <= gridView1.RowCount; i++)
            {
                var chek = gridView1.GetRowCellValue(i, "chek");
                int? id = (int) gridView1.GetRowCellValue(i, "id");
                if (Convert.ToString(chek) != "")
                {
                    if (Convert.ToBoolean(chek) == true)
                    {

                        try
                        {

                            this.queriesTableAdapter1.insert_MeterMOLdocs2(Globals.id_doc_meter_mol_docs, id);
                        }
                        catch (SqlException se)
                        {
                            MessageBox.Show("Этот счетчик уже выдан" + se.ToString());
                        }
                        Globals.id_doc_meter_for_main = Globals.id_doc_meter_mol_docs;
                        Globals.en_delegate_cmol();
                        Close();

                    }
                }
            }
        }


        }
}
