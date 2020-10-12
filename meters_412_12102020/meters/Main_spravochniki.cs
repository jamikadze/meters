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
    public partial class Main_spravochniki : DevExpress.XtraEditors.XtraForm
    {
        int id_slujba;
        string add;
        public Main_spravochniki()
        {
            InitializeComponent();
        }

        private void Main_spravochniki_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'mMSDataSet.Sim' table. You can move, or remove it, as needed.
            this.simTableAdapter.Fill(this.mMSDataSet.Sim);
// TODO: This line of code loads data into the 'mMSDataSet.spr_Xenon' table. You can move, or remove it, as needed.
            this.spr_fioTableAdapter.Fill(this.mMSDataSet.spr_fio,Globals.id_slujbi);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Billing' table. You can move, or remove it, as needed.
            //this.spr_BillingTableAdapter.Fill(this.mMSDataSet.spr_Billing);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_SimStatus' table. You can move, or remove it, as needed.
            this.spr_SimStatusTableAdapter.Fill(this.mMSDataSet.spr_SimStatus);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_ReturnReason' table. You can move, or remove it, as needed.
            this.spr_ReturnReasonTableAdapter.Fill(this.mMSDataSet.spr_ReturnReason);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterType' table. You can move, or remove it, as needed.
            this.spr_MeterTypeTableAdapter.Fill(this.mMSDataSet.spr_MeterType);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterStatus' table. You can move, or remove it, as needed.
            this.spr_MeterStatusTableAdapter.Fill(this.mMSDataSet.spr_MeterStatus);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Materials' table. You can move, or remove it, as needed.
            this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Slujba' table. You can move, or remove it, as needed.
            this.spr_SlujbaTableAdapter.Fill(this.mMSDataSet.spr_Slujba);
            //this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Executor' table. You can move, or remove it, as needed.
            this.spr_ExecutorTableAdapter.FillByAll(this.mMSDataSet.spr_Executor);

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sprExecutorBindingSource.AddNew();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.spr_ExecutorTableAdapter.FillByAll(this.mMSDataSet.spr_Executor);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            try
            {
                var rowHandle = gridView1.FocusedRowHandle;

                if (gridView1.GetRowCellValue(rowHandle, "NameExecutor").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "Position").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "id_Slujba").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "Hired_Date").ToString() == "")
                {
                    MessageBox.Show("Введите все поля!!!");
                }
                else
                {
                    string NameExecutor=(string)(gridView1.GetRowCellValue(rowHandle, "NameExecutor"));
                    string Position = (string)(gridView1.GetRowCellValue(rowHandle, "Position"));
                    DateTime Hired_Date = (DateTime)(gridView1.GetRowCellValue(rowHandle, "Hired_Date"));
                    this.spr_ExecutorTableAdapter.Insert1(NameExecutor, Position, id_slujba, Hired_Date);
                    spr_ExecutorTableAdapter.FillByAll(mMSDataSet.spr_Executor);
                    sprExecutorBindingSource.MoveLast();
                    MessageBox.Show("Сохранено успешно!!!");

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void repositoryItemLookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                add = "open";
                id_slujba = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int ii = sprExecutorBindingSource.Position;
            var rowHandle = gridView1.FocusedRowHandle;
            try
            {
                int id_slujbi;
                 DateTime? Fired_Date;
                string NameExecutor = (string)(gridView1.GetRowCellValue(rowHandle, "NameExecutor"));
                string Position = (string)(gridView1.GetRowCellValue(rowHandle, "Position"));
                DateTime Hired_Date = (DateTime)(gridView1.GetRowCellValue(rowHandle, "Hired_Date"));
                if((gridView1.GetRowCellValue(rowHandle, "Fired_Date")) is DBNull)
                { Fired_Date = null; }
                else { 
                 Fired_Date = (DateTime)(gridView1.GetRowCellValue(rowHandle, "Fired_Date"));}
                int id = (int)(gridView1.GetRowCellValue(rowHandle, "id"));
                if (add == "open")
                { id_slujbi = id_slujba; }
                else { id_slujbi = (int)(gridView1.GetRowCellValue(rowHandle, "id_Slujba")); }
                spr_ExecutorTableAdapter.Update1(Fired_Date, id);
                spr_ExecutorTableAdapter.FillByAll(mMSDataSet.spr_Executor);
                sprExecutorBindingSource.Position = ii;

            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            sprMaterialsBindingSource.AddNew();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            spr_MaterialsTableAdapter.Fill(mMSDataSet.spr_Materials);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var rowHandle = gridView2.FocusedRowHandle;

                if (gridView2.GetRowCellValue(rowHandle, "MaterialSort").ToString() == "" || gridView2.GetRowCellValue(rowHandle, "CodeMaterialSort").ToString() == "" || gridView2.GetRowCellValue(rowHandle, "Unit").ToString() == "" )
                {
                    MessageBox.Show("Введите все поля!!!");
                }
                else
                {
                    string MaterialSort = (string)(gridView2.GetRowCellValue(rowHandle, "MaterialSort"));
                    int CodeMaterialSort = (int)(gridView2.GetRowCellValue(rowHandle, "CodeMaterialSort"));
                    string Unit= (string)(gridView2.GetRowCellValue(rowHandle, "Unit"));
                    this.spr_MaterialsTableAdapter.InsertQuery(MaterialSort, CodeMaterialSort, Unit);
                    this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
                    sprMaterialsBindingSource.MoveLast();
                    MessageBox.Show("Сохранено успешно!!!");

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            sprMeterTypeBindingSource.AddNew();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            spr_MeterTypeTableAdapter.Fill(mMSDataSet.spr_MeterType);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
           
        }

       
        private void simpleButton12_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  try
            {
                var rowHandle = gridView9.FocusedRowHandle;

                if (gridView9.GetRowCellValue(rowHandle, "fio").ToString() == "" || gridView9.GetRowCellValue(rowHandle, "dolj").ToString() == "" )

                {
                    MessageBox.Show("Введите все поля!!!");
                }
                else
                {
                    int? id = (int)gridView9.GetRowCellValue(rowHandle, "id");
                    string fioo = (string)gridView9.GetRowCellValue(rowHandle, "fio");
                    string dolj = (string)gridView9.GetRowCellValue(rowHandle, "dolj");
                   
                  
                    if (id < 0)
                    {
                        //MessageBox.Show("insert");
                        queriesTableAdapter1.insert_spr_fio(fioo, dolj, Globals.id_slujbi);
                    }
                    else
                    {
                        queriesTableAdapter1.update_spr_fio(id, fioo, dolj, Globals.id_slujbi);
                    }

                }

      this.spr_fioTableAdapter.Fill(this.mMSDataSet.spr_fio,Globals.id_slujbi);
                int ii = spr_fioBindingSource.Position;
                MessageBox.Show("Данные успешно сохранены");

                spr_fioTableAdapter.Fill(this.mMSDataSet.spr_fio,Globals.id_slujbi);
                spr_fioBindingSource.Position = ii;
                //Globals.add = "update";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            spr_fioBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            int? id1 = (int)gridView1.GetRowCellValue(rowHandle, "id");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var rowHandle = gridView9.FocusedRowHandle;

                    int? id = (int)gridView9.GetRowCellValue(rowHandle, "id");
                    queriesTableAdapter1.del_fio(id);
                    MessageBox.Show("ФИО удален!!!");

        }
        }

        
    }
