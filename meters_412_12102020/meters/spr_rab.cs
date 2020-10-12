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
    public partial class spr_rab : DevExpress.XtraEditors.XtraForm
    {
        public spr_rab()
        {
            InitializeComponent();
        }

        private void mat_rabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mat_rabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

   

        private void spr_rab_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Materials2' table. You can move, or remove it, as needed.
            this.spr_Materials2TableAdapter.Fill(this.mMSDataSet.spr_Materials2);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_rab' table. You can move, or remove it, as needed.
            this.spr_rabTableAdapter.Fill(this.mMSDataSet.spr_rab);

            this.mat_rabTableAdapter.Fill(this.mMSDataSet.mat_rab,Globals.id_rab);

            if (Globals.id_access != 1)
            {

                simpleButton2.Visible = false;

            }
        }

        private void repositoryItemLookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                object ed = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Unit");
                object cena = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("cena");
                advBandedGridView1.SetFocusedRowCellValue("ed", ed);
                advBandedGridView1.SetFocusedRowCellValue("cena", cena);
                advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["kol"]; 
                
           
            }
        }

        private void spr_rabBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {


                if (spr_rabBindingSource.Count > 0)
                {
                    Globals.id_rab = Convert.ToInt32(((DataRowView)spr_rabBindingSource.Current).Row["id"].ToString());
                    this.mat_rabTableAdapter.Fill(this.mMSDataSet.mat_rab, Globals.id_rab);

                }

            }
            catch { }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (gridView1.GetRowCellValue(rowHandle, "kod").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "rab").ToString() == "" ||
                gridView1.GetRowCellValue(rowHandle, "ed").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "tr_zatr").ToString() == "" ||
                gridView1.GetRowCellValue(rowHandle, "koef").ToString() == "")
            {
                MessageBox.Show("Выберите все данные!!!");
            }
            else
            {
                string rab = gridView1.GetRowCellValue(rowHandle, "rab").ToString();
                int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                string ed = (string)gridView1.GetRowCellValue(rowHandle, "ed");
                double tr_zatr = (double)gridView1.GetRowCellValue(rowHandle, "tr_zatr");
                string kod = (string)gridView1.GetRowCellValue(rowHandle, "kod");
                double koef = (double)gridView1.GetRowCellValue(rowHandle, "koef");

                             if (id < 0)
                {
                    spr_rabBindingSource.AddNew();
                    queriesTableAdapter1.Insert_spr_rab(kod,rab,ed,tr_zatr,koef);

                }
                else
                {
                    queriesTableAdapter1.update_spr_rab(id,kod, rab, ed, tr_zatr, koef);
                }
                int ii = spr_rabBindingSource.Position;
                MessageBox.Show("Данные успешно сохранены");

                this.spr_rabTableAdapter.Fill(this.mMSDataSet.spr_rab);
                spr_rabBindingSource.Position = ii;
                Globals.add2 = "update";


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var rowHandle = advBandedGridView1.FocusedRowHandle;

                if (advBandedGridView1.GetRowCellValue(rowHandle, "mat").ToString() == "" || advBandedGridView1.GetRowCellValue(rowHandle, "kol").ToString() == "")
                {
                    MessageBox.Show("Введите все поля!!!");
                }
                else
                {
                    int id = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                    string ed = (string)advBandedGridView1.GetRowCellValue(rowHandle, "ed");
                    decimal cena = (decimal)advBandedGridView1.GetRowCellValue(rowHandle, "cena");

                    double kol = (double)advBandedGridView1.GetRowCellValue(rowHandle, "kol");
                    //DateTime data_akt = Convert.ToDateTime(((DataRowView)aktBindingSource.Current).Row["date"].ToString());
                    int id_mat = (int)advBandedGridView1.GetRowCellValue(rowHandle, "mat");

                


                    if (id < 0)
                    {
                        //MessageBox.Show("insert");
                        queriesTableAdapter1.insert_mat_rab(id_mat,ed,cena, kol, Globals.id_rab);
                    }
                    else
                    {
                        queriesTableAdapter1.update_mat_rab(id,id_mat,ed,cena, kol, Globals.id_rab);
                    }

                    //DateTime date1 = Convert.ToDateTime("01.01." + comboBox1.Text);
                    //DateTime date2 = Convert.ToDateTime("31.12." + comboBox1.Text);


                }


                int ii = mat_rabBindingSource.Position;
                MessageBox.Show("Данные успешно сохранены");

                this.mat_rabTableAdapter.Fill(this.mMSDataSet.mat_rab, Globals.id_rab);
                mat_rabBindingSource.Position = ii;
                Globals.add = "update";
            }
            catch { }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (Globals.add == "insert")
            { MessageBox.Show("Сохраните предыдущую запись или отмените!"); }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить материал? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {


                        var rowHandle = advBandedGridView1.FocusedRowHandle;
                        int id = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                        queriesTableAdapter1.del_mat_rab(id);
                    }
                    this.mat_rabTableAdapter.Fill(this.mMSDataSet.mat_rab, Globals.id_rab);

                    return;
                }


                catch { }
            }
        }
    }
}
