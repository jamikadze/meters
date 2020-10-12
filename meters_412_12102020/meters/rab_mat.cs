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
    public partial class rab_mat : DevExpress.XtraEditors.XtraForm
    {
        public rab_mat()
        {
            InitializeComponent();
        }

        private void rab_aktBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rab_aktBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

      

      
        private void rab_mat_Load(object sender, EventArgs e)
        {                    //this.spr_matTableAdapter.Fill(this.mMSDataSet.spr_mat);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_rab' table. You can move, or remove it, as needed.

            this.Text = Globals.sm_name;
            this.spr_rabTableAdapter.Fill(this.mMSDataSet.spr_rab);
          //  this.mat_rabTableAdapter.Fill(this.mMSDataSet.mat_rab,);
            
this.rab_aktTableAdapter.Fill(this.mMSDataSet.rab_akt,Globals.id_akt);
this.mat_importTableAdapter.Fill(this.mMSDataSet.mat_import, Globals.id_akt);
            
            //    this.mat_aktTableAdapter.Fill(this.mMSDataSet.mat_akt,Globals.id_akt);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_mat' table. You can move, or remove it, as needed.
this.ostatok_matTableAdapter.Fill(this.mMSDataSet.ostatok_mat,Globals.id_slujbi);

        }

        private void repositoryItemLookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                object kod = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("kod");
                object ed = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ed");
                object tr_zatr = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("tr_zatr");
                object koef = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("koef");
                advBandedGridView1.SetFocusedRowCellValue("kod", kod);
                advBandedGridView1.SetFocusedRowCellValue("ed", ed);
                advBandedGridView1.SetFocusedRowCellValue("tr_zatr", tr_zatr);
                advBandedGridView1.SetFocusedRowCellValue("koef", koef);
                advBandedGridView1.FocusedColumn = advBandedGridView1.Columns["kol"];

            }
        }

        private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            simpleButton2_Click(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
                try
                {
                    var rowHandle = advBandedGridView1.FocusedRowHandle;

                    if (advBandedGridView1.GetRowCellValue(rowHandle, "kod").ToString() == "" || advBandedGridView1.GetRowCellValue(rowHandle, "kol").ToString() == "")
                    {
                        MessageBox.Show("Введите все поля!!!");
                    }
                    else
                    {
                        int id_rb = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id_rb");
                        rab_akt_id_rabTableAdapter.Fill_id_rab(this.mMSDataSet.rab_akt_id_rab, Globals.id_akt, id_rb);
                        if (rab_akt_id_rabBindingSource.Count > 0)
                        {
                            MessageBox.Show("Такая работа в акте есть!!!");

                            this.rab_aktTableAdapter.Fill(this.mMSDataSet.rab_akt, Globals.id_akt);

                        }
                        else
                        {
                            int id = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                            string ed = (string)advBandedGridView1.GetRowCellValue(rowHandle, "ed");
                            double tr_zatr = (double)advBandedGridView1.GetRowCellValue(rowHandle, "tr_zatr");
                            string kod = (string)advBandedGridView1.GetRowCellValue(rowHandle, "kod");
                            double kol = (double)advBandedGridView1.GetRowCellValue(rowHandle, "kol");
                            double koef = (double)advBandedGridView1.GetRowCellValue(rowHandle, "koef");
                            double sum = (kol * tr_zatr * koef);

                            //////////////////////////////////////////////////// продолжить здесь 


                            if (id < 0)
                            {
                                //MessageBox.Show("insert");
                                queriesTableAdapter1.insert_rab_akt(ed, tr_zatr, kod, kol, koef, sum, id_rb, Globals.id_akt, Globals.id_slujbi);


                                /////////////////////////////////////////////добавление   материал

                                this.mat_rabTableAdapter.Fill(this.mMSDataSet.mat_rab, id_rb);



                                if (mat_rabBindingSource.Count > 0)
                                {
                                    mat_rabBindingSource.MoveFirst();
                                    for (int j = 0; j < mat_rabBindingSource.Count; j++)
                                    {
                                        mat_rabBindingSource.Position = j;
                                        int id_mat1 = Convert.ToInt32(((DataRowView)mat_rabBindingSource.Current).Row["mat"].ToString());
                                        ostatok_id_matTableAdapter.Fill_id_mat(this.mMSDataSet.ostatok_id_mat, id_mat1, Globals.id_slujbi);
                                        if (ostatok_id_matBindingSource.Count > 0)
                                        {
                                            int id1 = Convert.ToInt32(((DataRowView)mat_rabBindingSource.Current).Row["id"].ToString());
                                            string ed1 = Convert.ToString(((DataRowView)mat_rabBindingSource.Current).Row["ed"].ToString());
                                            decimal cena1 = Convert.ToDecimal(((DataRowView)mat_rabBindingSource.Current).Row["cena"].ToString());
                                            double kol1 = 0;
                                            string rab1 = kod;
                                            decimal sum1 = ((decimal)kol1 * cena1);
                                            queriesTableAdapter1.insert_mat_akt(ed1, kol1, cena1, sum1, rab1, id_mat1, Globals.id_akt, Globals.id_slujbi);


                                        }


                                    }
                                }

                                this.mat_aktTableAdapter.Fill(this.mMSDataSet.mat_akt, Globals.id_akt);
                                /////////////////////////////////////////////добавление  транспорт

                                Globals.add2 = "update";

                            }
                            else
                            {
                                // global.id = (int)gridView1.GetRowCellValue(rowHandle, "id");

                                queriesTableAdapter1.update_rab_akt(ed, tr_zatr, kod, kol, koef, sum, id_rb, Globals.id_akt, Globals.id_slujbi, id);
                            }
                            int ii = rab_aktBindingSource.Position;
                            MessageBox.Show("Данные успешно сохранены");

                            this.rab_aktTableAdapter.Fill(this.mMSDataSet.rab_akt, Globals.id_akt);
                            rab_aktBindingSource.Position = ii;
                        }
                    } 
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
       

       
        }

     
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить работу? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var rowHandle = advBandedGridView1.FocusedRowHandle;
                    int id_rb = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                    string kod = (string)advBandedGridView1.GetRowCellValue(rowHandle, "kod");
                    queriesTableAdapter1.del_rab_akt(id_rb, Globals.id_akt, kod);
                    this.rab_aktTableAdapter.Fill(this.mMSDataSet.rab_akt, Globals.id_akt);
                    this.mat_aktTableAdapter.Fill(this.mMSDataSet.mat_akt, Globals.id_akt);
                  
                }
       
                return;

            }
            catch { }
        }

        private void repositoryItemLookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            //{
            //    object ed = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ed");
            //    object cena = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("cena");

            //    advBandedGridView2.SetFocusedRowCellValue("ed", ed);
            //    advBandedGridView2.SetFocusedRowCellValue("cena", cena);
            //    advBandedGridView2.FocusedColumn = advBandedGridView2.Columns["kol"];

            //}
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var rowHandle = advBandedGridView2.FocusedRowHandle;

                if (advBandedGridView2.GetRowCellValue(rowHandle, "id_mat").ToString() == "" || advBandedGridView2.GetRowCellValue(rowHandle, "kol").ToString() == "")
                {
                    MessageBox.Show("Введите все поля!!!");
                }
                else
                {int id_mat = (int)advBandedGridView2.GetRowCellValue(rowHandle, "id_mat");
                    double kol = (double)advBandedGridView2.GetRowCellValue(rowHandle, "kol");
                    this.ostatok_id_matTableAdapter.Fill_id_mat(this.mMSDataSet.ostatok_id_mat, Globals.id_slujbi,id_mat);
                    Globals.kol_akt = Convert.ToDouble(((DataRowView)ostatok_id_matBindingSource.Current).Row["kol_ostatok"]);

                    if (kol > Globals.kol_akt)
                    {
                        MessageBox.Show("Остаток данного материала равен "+ Globals.kol_akt);
                        this.mat_aktTableAdapter.Fill(this.mMSDataSet.mat_akt, Globals.id_akt);
                    }
                    else
                    {

                        int id = (int)advBandedGridView2.GetRowCellValue(rowHandle, "id");
                        string ed = (string)advBandedGridView2.GetRowCellValue(rowHandle, "ed");
                        decimal cena = (decimal)advBandedGridView2.GetRowCellValue(rowHandle, "cena");


                        //DateTime data_akt = Convert.ToDateTime(((DataRowView)aktBindingSource.Current).Row["date"].ToString());
                        

                        string rab = "";
                        string ddd = advBandedGridView2.GetRowCellValue(rowHandle, "rab").ToString();
                        if (ddd.Trim().Length == 0)
                        //if ((string)gridView3.GetRowCellValue(rowHandle, "rab")=="")
                        {
                            rab = "";
                        }
                        else
                        {
                            rab = (string)advBandedGridView2.GetRowCellValue(rowHandle, "rab");
                        }




                        decimal sum = ((decimal)kol * cena);

                        if (id < 0)
                        {
                            //MessageBox.Show("insert");
                            queriesTableAdapter1.insert_mat_akt(ed, kol, cena, sum, rab, id_mat, Globals.id_akt, Globals.id_slujbi);
                        }
                        else
                        {
                            queriesTableAdapter1.update_mat_akt(ed, kol, cena, sum, rab, id_mat, Globals.id_akt, Globals.id_slujbi, id);
                        }

                        //DateTime date1 = Convert.ToDateTime("01.01." + comboBox1.Text);
                        //DateTime date2 = Convert.ToDateTime("31.12." + comboBox1.Text);


                    


                    int ii = mat_aktBindingSource.Position;
                    MessageBox.Show("Данные успешно сохранены");

                    this.mat_aktTableAdapter.Fill(this.mMSDataSet.mat_akt, Globals.id_akt);
                    mat_aktBindingSource.Position = ii;
                    Globals.add = "update";
                }
                    
                }
            }
            catch { }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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


                        var rowHandle = advBandedGridView2.FocusedRowHandle;
                        int id = (int)advBandedGridView2.GetRowCellValue(rowHandle, "id");
                        queriesTableAdapter1.del_mat_akt(id);
                    }
                    this.mat_aktTableAdapter.Fill(this.mMSDataSet.mat_akt, Globals.id_akt);






                    return;
                }







                catch { }

            }
        }

        private void repositoryItemLookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                object ed = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ed");
                object cena = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("cena");

                advBandedGridView2.SetFocusedRowCellValue("ed", ed);
                advBandedGridView2.SetFocusedRowCellValue("сena", cena);
                advBandedGridView2.FocusedColumn = advBandedGridView2.Columns["kol"];

            }
        }

        private void repositoryItemLookUpEdit2_Closed_1(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                object ed = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ed");
                object cena = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("cena");
                object kol_ostatok = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("kol_ostatok");
                advBandedGridView2.SetFocusedRowCellValue("ed", ed);
                advBandedGridView2.SetFocusedRowCellValue("cena", cena);
Globals.kol_akt = (double)kol_ostatok;
                advBandedGridView2.FocusedColumn = advBandedGridView2.Columns["kol"];
                

            }
        }

       

       

           

        
    }
}
