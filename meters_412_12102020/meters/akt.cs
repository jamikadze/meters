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
    public partial class akt : DevExpress.XtraEditors.XtraForm
    {
        public akt()
        {
            InitializeComponent();
        }

        private void aktBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aktBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }



        private void akt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.InstalledMeters2' table. You can move, or remove it, as needed.
            this.spr_MetrologTableAdapter.Fill(this.mMSDataSet.spr_Metrolog, Globals.id_slujbi);
            this.spr_master2TableAdapter.Fill(this.mMSDataSet.spr_master2, Globals.id_slujbi);
            // TODO: This line of code loads data into the 'mMSDataSet.InstalledMeters2' table. You can move, or remove it, as needed.
            // this.installedMeters2TableAdapter.Fill(this.mMSDataSet.InstalledMeters2);
            this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
            this.spr_fioTableAdapter.Fill(this.mMSDataSet.spr_fio, Globals.id_slujbi);
            this.schetchikiTableAdapter.Fill_forakt(this.mMSDataSet.schetchiki, Globals.id_slujbi,Convert.ToDecimal(Globals.year_index), Globals.mes_index, Globals.id_master);
            // TODO: This line of code loads data into the 'mMSDataSet.inform_schet' table. You can move, or remove it, as needed.
            //  this.inform_schetTableAdapter.Fill_inform_schet(this.mMSDataSet.inform_schet);
            this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);
            if (Globals.id_access!=1)
            {
            
            simpleButton7.Visible = false;

            }
            if (Globals.id_access == 6)
            {

                simpleButton7.Visible = false;
                simpleButton6.Visible = false;
                simpleButton3.Visible = false;
                simpleButton2.Visible = false;
                simpleButton1.Visible = false;

            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
                     
            var rowHandle = advBandedGridView1.FocusedRowHandle;
            int idakt = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
            this.akt1TableAdapter.Fill_akt_dostup(this.mMSDataSet.akt1, idakt);
                       
            if (this.akt1bindingSource.Count > 0)
            {
                    MessageBox.Show("АКТ: " + Globals.nameAKT + " закрыт\nвы не можете заново сохранить");
                    this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
                    return;
            }

                       
            if (advBandedGridView1.GetRowCellValue(rowHandle, "sm").ToString() == "" || advBandedGridView1.GetRowCellValue(rowHandle, "prim").ToString() == "" ||
                advBandedGridView1.GetRowCellValue(rowHandle, "name").ToString() == "" || advBandedGridView1.GetRowCellValue(rowHandle, "date").ToString() == "" ||
                advBandedGridView1.GetRowCellValue(rowHandle, "god").ToString() == "" || advBandedGridView1.GetRowCellValue(rowHandle, "mes").ToString() == "")
            {
                MessageBox.Show("Выберите все данные!!!");
            }
            else
            {
                string sm = advBandedGridView1.GetRowCellValue(rowHandle, "sm").ToString();
                string name = advBandedGridView1.GetRowCellValue(rowHandle, "name").ToString();
                string prim = advBandedGridView1.GetRowCellValue(rowHandle, "prim").ToString();
                DateTime date = (DateTime)advBandedGridView1.GetRowCellValue(rowHandle, "date");
                string mes = advBandedGridView1.GetRowCellValue(rowHandle, "mes").ToString();
                int god = (int)advBandedGridView1.GetRowCellValue(rowHandle, "god");
                int fio1 = (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio1");
                int fio2 = (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio2");
                int fio3 = (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio3");
                int fio4 = (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio4");
                int fio5 = (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio5");
                int fio6 = (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio6");
                int fio7 = 1; // (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio7");
                int fio8 = 1;// (int)advBandedGridView1.GetRowCellValue(rowHandle, "fio8");

                if (mes == "Январь")
                {
                    Globals.mes_index = 01;
                }
                if (mes == "Февраль")
                {
                    Globals.mes_index = 02;
                }
                if (mes == "Март")
                {
                    Globals.mes_index = 03;
                }
                if (mes == "Апрель")
                {
                    Globals.mes_index = 04;
                }
                if (mes == "Май")
                {
                    Globals.mes_index = 05;
                }
                if (mes == "Июнь")
                {
                    Globals.mes_index = 06;
                }
                if (mes == "Июль")
                {
                    Globals.mes_index = 07;
                }
                if (mes == "Август")
                {
                    Globals.mes_index = 08;
                }
                if (mes == "Сентябрь")
                {
                    Globals.mes_index = 09;
                }
                if (mes == "Октябрь")
                {
                    Globals.mes_index = 10;
                }
                if (mes == "Ноябрь")
                {
                    Globals.mes_index = 11;
                }
                if (mes == "Декабрь")
                {
                    Globals.mes_index = 12;
                }

               
                int id = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                if (id < 0)
                {
                    aktBindingSource.AddNew();
                    queriesTableAdapter1.insert_akt(god, mes, sm, date, name, prim, Globals.id_slujbi, fio1, fio2, fio3, fio4, fio5, fio6, fio7, fio8);

                }
                else
                {
                    aktTableAdapter.Update_akt(god, mes, sm, date, name, prim, Globals.id_slujbi, fio1, fio2, fio3, fio4, fio5, fio6, fio7, fio8, id);
                    this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
                }
                int ii = aktBindingSource.Position;
                MessageBox.Show("Данные успешно сохранены");

                this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
                aktBindingSource.Position = ii;
                Globals.add2 = "update";


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
            var rowHandle = advBandedGridView1.FocusedRowHandle;
            int idakt = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
           

                this.akt1TableAdapter.Fill_akt_dostup(this.mMSDataSet.akt1, idakt);
                if (this.akt1bindingSource.Count > 0)
                {

                    MessageBox.Show("АКТ: " + Globals.nameAKT + "  закрыт\nвы не можете удалить");
                    this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
                    return;
                }

            
                DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить данный АКТ? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   
                    //int id = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                    queriesTableAdapter1.del_akt(idakt);
                    this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);

                }
                return;
            }
            catch { }

        }

        private void aktBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {


                if (aktBindingSource.Count > 0)
                {
                    //     this.spr_master2TableAdapter.Fill(this.mMSDataSet.spr_master2, Globals.id_slujbi);
                    Globals.id_akt = Convert.ToInt32(((DataRowView)aktBindingSource.Current).Row["id"].ToString());
                    Globals.id_master = Convert.ToInt32(((DataRowView)aktBindingSource.Current).Row["fio3"].ToString());
                    Globals.sm_name = ((DataRowView)aktBindingSource.Current).Row["sm"].ToString() + " " + ((DataRowView)aktBindingSource.Current).Row["name"].ToString();
                    string mes = ((DataRowView)aktBindingSource.Current).Row["mes"].ToString();
                    Globals.nameAKT = ((DataRowView)aktBindingSource.Current).Row["name"].ToString() + " " + ((DataRowView)aktBindingSource.Current).Row["prim"].ToString();

                    if (mes == "Январь")
                    {
                        Globals.mes_index = 01;
                    }
                    if (mes == "Февраль")
                    {
                        Globals.mes_index = 02;
                    }
                    if (mes == "Март")
                    {
                        Globals.mes_index = 03;
                    }
                    if (mes == "Апрель")
                    {
                        Globals.mes_index = 04;
                    }
                    if (mes == "Май")
                    {
                        Globals.mes_index = 05;
                    }
                    if (mes == "Июнь")
                    {
                        Globals.mes_index = 06;
                    }
                    if (mes == "Июль")
                    {
                        Globals.mes_index = 07;
                    }
                    if (mes == "Август")
                    {
                        Globals.mes_index = 08;
                    }
                    if (mes == "Сентябрь")
                    {
                        Globals.mes_index = 09;
                    }
                    if (mes == "Октябрь")
                    {
                        Globals.mes_index = 10;
                    }
                    if (mes == "Ноябрь")
                    {
                        Globals.mes_index = 11;
                    }
                    if (mes == "Декабрь")
                    {
                        Globals.mes_index = 12;
                    }

                   // DateTime thisyears = DateTime.Today.Year;
                    Globals.year_index = Convert.ToInt32(DateTime.Now.Year);
                    //Convert.ToInt32(thisyears);

                    this.schetchikiTableAdapter.Fill_forakt(this.mMSDataSet.schetchiki, Globals.id_slujbi,Globals.year_index, Globals.mes_index, Globals.id_master);

                    this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);
                }

            }
            catch { }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            Form rab_mat = new rab_mat();
            rab_mat.Show();
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form spr_mat = new spr_mat();
            spr_mat.Show();
        }

        private void работыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form spr_rab = new spr_rab();
            spr_rab.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Globals.y = 1;
            Form otchet = new otchet();
            otchet.Show();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Globals.y = 2;
            Form otchet = new otchet();
            otchet.Show();
        }



        private void repositoryItemLookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                object doc_name = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("doc_name");
                object meterType = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("MeterType");
                gridView1.SetFocusedRowCellValue("num_doc", doc_name);
                gridView1.SetFocusedRowCellValue("type_schet", meterType);


            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (gridView1.GetRowCellValue(rowHandle, "id_schet").ToString() == "")
            {
                MessageBox.Show("Выберите счетчик!!!");
            }
            else
            {



                int id_schet = (int)gridView1.GetRowCellValue(rowHandle, "id_schet");
                string num_doc = gridView1.GetRowCellValue(rowHandle, "num_doc").ToString();
                string type_schet = gridView1.GetRowCellValue(rowHandle, "type_schet").ToString();
                int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                if (id < 0)
                {
                    akt_schetBindingSource.AddNew();
                    queriesTableAdapter1.insert_schet_akt(id_schet, num_doc, Globals.id_akt, type_schet);

                }
                else
                {
                    queriesTableAdapter1.update_akt_schet(id_schet, num_doc, Globals.id_akt, type_schet, id);
                }
                int ii = akt_schetBindingSource.Position;
                MessageBox.Show("Данные успешно сохранены");

                this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);
                akt_schetBindingSource.Position = ii;
                Globals.add2 = "update";


            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить смету? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var rowHandle = gridView1.FocusedRowHandle;
                    int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                    queriesTableAdapter1.del_akt_schet(id);
                    this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);

                }
                return;
            }
            catch { }
        }



        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить смету? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var rowHandle = gridView1.FocusedRowHandle;
                    int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                    queriesTableAdapter1.del_akt_schet(id);
                    this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);

                }
                return;
            }
            catch { }

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (gridView1.GetRowCellValue(rowHandle, "id_schet").ToString() == "")
            {
                MessageBox.Show("Выберите счетчик!!!");
            }
            else
            {

                int id_schet = (int)gridView1.GetRowCellValue(rowHandle, "id_schet");
                this.akt_schet_countTableAdapter.Fill(this.mMSDataSet.akt_schet_count, id_schet);
                if (this.akt_schet_countBindingSource.Count > 0)
                {
                    MessageBox.Show("На этот счетчик акт есть!!!");
                    this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);
                }
                else
                {
                    string num_doc = gridView1.GetRowCellValue(rowHandle, "num_doc").ToString();
                    string type_schet = gridView1.GetRowCellValue(rowHandle, "type_schet").ToString();
                    int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                    if (id < 0)
                    {
                        akt_schetBindingSource.AddNew();
                        queriesTableAdapter1.insert_schet_akt(id_schet, num_doc, Globals.id_akt, type_schet);

                    }
                    else
                    {
                        queriesTableAdapter1.update_akt_schet(id_schet, num_doc, Globals.id_akt, type_schet, id);
                    }
                    int ii = akt_schetBindingSource.Position;
                    MessageBox.Show("Данные успешно сохранены");

                    this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);
                    akt_schetBindingSource.Position = ii;
                    Globals.add2 = "update";
                }



            }
        }

        private void repositoryItemComboBox1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            const int index = 1;
            object val = repositoryItemComboBox1.Items[index];
            if (Convert.ToString(val) == "Январь")
            {
                Globals.mes_index = 01;
            }
            if (Convert.ToString(val) == "Февраль")
            {
                Globals.mes_index = 02;
            }
            if (Convert.ToString(val) == "Март")
            {
                Globals.mes_index = 03;
            }
            if (Convert.ToString(val) == "Апрель")
            {
                Globals.mes_index = 04;
            }
            if (Convert.ToString(val) == "Май")
            {
                Globals.mes_index = 05;
            }
            if (Convert.ToString(val) == "Июнь")
            {
                Globals.mes_index = 06;
            }
            if (Convert.ToString(val) == "Июль")
            {
                Globals.mes_index = 07;
            }
            if (Convert.ToString(val) == "Август")
            {
                Globals.mes_index = 08;
            }
            if (Convert.ToString(val) == "Сентябрь")
            {
                Globals.mes_index = 09;
            }
            if (Convert.ToString(val) == "Октябрь")
            {
                Globals.mes_index = 10;
            }
            if (Convert.ToString(val) == "Ноябрь")
            {
                Globals.mes_index = 11;
            }
            if (Convert.ToString(val) == "Декабрь")
            {
                Globals.mes_index = 12;
            }
            Globals.year_index = Convert.ToInt32(DateTime.Now.Year);
            
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            var rowHandle = advBandedGridView1.FocusedRowHandle;
            int idakt = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
            this.akt1TableAdapter.Fill_akt_dostup(this.mMSDataSet.akt1, idakt);

            if (this.akt1bindingSource.Count > 0)
            {
                    MessageBox.Show("АКТ: " + Globals.nameAKT + "  закрыт\nвы не можете заново группировать Счетчики\nсоздайте новый АКТ");
                    this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
                    return;
            }

            if (Globals.id_akt < 0)
            {
                MessageBox.Show("Нажмите кнопку Сохранить!");
                return;
            }
            else
            {


                //Globals.year_index = Convert.ToInt32(DateTime.Now.Year);
                this.schetchikiTableAdapter.Fill_forakt(this.mMSDataSet.schetchiki, Globals.id_slujbi,Convert.ToDecimal(Globals.year_index), Globals.mes_index, Globals.id_master);
                if (schetchikiBindingSource.Count > 0)
                {
                    schetchikiBindingSource.MoveFirst();
                    for (int i = 0; i < schetchikiBindingSource.Count; i++)
                    {
                        schetchikiBindingSource.Position = i;



                        int id_schet = Convert.ToInt32(((DataRowView)schetchikiBindingSource.Current).Row["id_NewMeter"].ToString());

                        this.akt_schet_countTableAdapter.Fill(this.mMSDataSet.akt_schet_count, id_schet);
                        if (this.akt_schet_countBindingSource.Count == 0)
                        {

                            string num_doc = ((DataRowView)schetchikiBindingSource.Current).Row["doc_name"].ToString();
                            string type_schet = ((DataRowView)schetchikiBindingSource.Current).Row["MeterType"].ToString();

                            queriesTableAdapter1.insert_schet_akt(id_schet, num_doc, Globals.id_akt, type_schet);
                        }
                        else
                        {
                            //    MessageBox.Show("На счетчик " + Convert.ToString(id_schet) + " акт есть!");

                        }
                    }

                    MessageBox.Show("Данные успешно сохранены");

                    this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);

                    Globals.add2 = "update";

                }
            }
            Globals.id_akt = -1;
        }

        private void сводныйСписаниеМатериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Globals.y = 3;
            Form parametr = new parametr();
            parametr.Show();
        }

        private void repositoryItemLookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            this.akt_schetTableAdapter.Fill(this.mMSDataSet.akt_schet, Globals.id_akt);

            if (akt_schetBindingSource.Count > 0)
            {
                MessageBox.Show("В данном акте Уже есть счетчики!\nЕсли хотите изменить Мастера ВПУ, то создайте новый АКТ!");
                return;
            }






        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            
            
            try
            {

                var rowHandle = advBandedGridView1.FocusedRowHandle;
                int idakt = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                this.akt1TableAdapter.Fill_akt_dostup(this.mMSDataSet.akt1, idakt);

                if (this.akt1bindingSource.Count > 0)
                {
                    MessageBox.Show("АКТ: " + Globals.nameAKT + " уже  закрыт!");
                    this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
                    return;
                }
                if (Globals.id_akt > 0)
                {
                    DialogResult result = MessageBox.Show("Вы действительно \nхотите закрыть АКТ: " + Globals.nameAKT + "? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                     
                        int id = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                       queriesTableAdapter1.update_closedAKT(id);
                        this.aktTableAdapter.Fill(this.mMSDataSet.akt, Globals.id_slujbi);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите АКТ для закрытия!");
                    return;
                }
            }
            catch { }
        }

        private void repositoryItemComboBox2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            const int indexx = 1;
            object val = repositoryItemComboBox1.Items[indexx];
            Globals.godd = Convert.ToInt32(val);
        }
    }
}