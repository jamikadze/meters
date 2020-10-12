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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


namespace meters
{
    public partial class Main_MMOL : DevExpress.XtraEditors.XtraForm
    {       int? id_MMOL;
            int? id_MOL;
        public Main_MMOL()
        {
            InitializeComponent();
            

        }

        private void Main_MMOL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Slujba' table. You can move, or remove it, as needed.
            this.spr_SlujbaTableAdapter.Fill(this.mMSDataSet.spr_Slujba);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_metrologMol' table. You can move, or remove it, as needed.
            this.spr_metrologMolTableAdapter.Fill(this.mMSDataSet.spr_metrologMol,Globals.id_slujbi);
           
            this.materialDocsTableAdapter.Fill(this.mMSDataSet.MaterialDocs);
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users); 
            this.spr_MMOLTableAdapter.FillBy(this.mMSDataSet.spr_MMOL);
            this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
            // TODO: This line of code loads data into the 'mMSDataSet.MaterialDocs2' table. You can move, or remove it, as needed.
            this.materialDocs2TableAdapter.FillById_DOC(this.mMSDataSet.MaterialDocs2, Globals.id_doc_materials);
            // TODO: This line of code loads data into the 'mMSDataSet.MaterialDocs' table. You can move, or remove it, as needed.
            
            this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
            this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;  
            Delegate.RemoveAll(Globals.en_delegate, Globals.en_delegate);
            Globals.en_delegate = visible_main;
        }
        public void visible_main()
        {
          //  this.materialDocsTableAdapter.Fill(this.mMSDataSet.MaterialDocs);
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            this.spr_MMOLTableAdapter.FillBy(this.mMSDataSet.spr_MMOL);
            this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
            // TODO: This line of code loads data into the 'mMSDataSet.MaterialDocs2' table. You can move, or remove it, as needed.
            this.materialDocs2TableAdapter.FillById_DOC(this.mMSDataSet.MaterialDocs2, Globals.id_doc_materials_for_main);
            // TODO: This line of code loads data into the 'mMSDataSet.MaterialDocs' table. You can move, or remove it, as needed.

            this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
            this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MMOL= (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           

            try 
            {
                if(dateEdit1.Text!="" && lookUpEdit1.Text!="" && lookUpEdit2.Text!="")
                { 
                    DateTime? date=Convert.ToDateTime(dateEdit1.Text);
                  int? id_user = Globals.id_user;
                  int? id_current_doc = Globals.id_current_doc;
                queriesTableAdapter1.insert_MaterialDocs(date,id_user,id_MOL,id_MMOL, ref id_current_doc);
                this.materialDocsTableAdapter.Fill(this.mMSDataSet.MaterialDocs);
                materialDocsBindingSource.MoveLast();
                dateEdit1.Text="";
                lookUpEdit1.EditValue = null;
                lookUpEdit2.EditValue = null;
                Form d = new spr_materialy();
                d.Show();
                
               
                }
                else { MessageBox.Show("Не все поля заполнены"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MOL = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dateEdit1.Text = "";
            lookUpEdit1.EditValue = null;
            lookUpEdit2.EditValue = null;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
             bool status; 
            var rowHandle = gridView1.FocusedRowHandle;
            if (gridView1.GetRowCellValue(rowHandle, "doc_status") is DBNull)
            { status = false; }
            else {  status = (Boolean)gridView1.GetRowCellValue(rowHandle, "doc_status");}

         
            if (status == false) { 
            
            DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить дркумент \nУдалятся все материалы этого документа", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                queriesTableAdapter1.delete_from_MaterialDocs_and_MaterialDocs2(Globals.id_doc_materials);
                this.materialDocsTableAdapter.Fill(this.mMSDataSet.MaterialDocs);
            }
            }
            else
            {
                MessageBox.Show("Удалить не возможно документ закрыт!!!");
              

            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {   bool status; 
            var rowHandle = gridView1.FocusedRowHandle;
            if (gridView1.GetRowCellValue(rowHandle, "doc_status") is DBNull)
            { status = false; }
            else {  status = (Boolean)gridView1.GetRowCellValue(rowHandle, "doc_status");}

         
            if (status == false) { 
             DateTime? date = (DateTime)gridView1.GetRowCellValue(rowHandle, "Date");
             int? id_SMOL = (int)gridView1.GetRowCellValue(rowHandle, "id_Executor_Exporter");
             int? id_RMOL = (int)gridView1.GetRowCellValue(rowHandle, "id_Executor_Importer");
            queriesTableAdapter1.update_MaterialDocs(date,id_SMOL,id_RMOL,Globals.id_doc_materials);
            this.materialDocsTableAdapter.Fill(this.mMSDataSet.MaterialDocs);
            MessageBox.Show("Документ успешно отредактирован");
            }
            else { MessageBox.Show("Редактирование не возможно документ закрыт!!!");
            this.materialDocsTableAdapter.Fill(this.mMSDataSet.MaterialDocs);
           
            }
        }

        private void materialDocsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {

                Globals.id_doc_materials = Convert.ToInt32(((DataRowView)materialDocsBindingSource.Current).Row["id"]);
                Globals.date_mater = Convert.ToDateTime(((DataRowView)materialDocsBindingSource.Current).Row["Date"]);
                if( (((DataRowView)materialDocsBindingSource.Current).Row["doc_status"]) is DBNull )
                { Globals.doc_status = false; }
                else {
                    Globals.doc_status = Convert.ToBoolean(((DataRowView)materialDocsBindingSource.Current).Row["doc_status"]);
                }
                this.materialDocs2TableAdapter.FillById_DOC(this.mMSDataSet.MaterialDocs2, Globals.id_doc_materials);
              
               
            }
            catch { }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
           
         
            

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView2.FocusedRowHandle;
          
          if (Globals.doc_status == false)
            {
                for (int i = 0; i <= gridView2.RowCount; i++)
                {
                    var check = gridView2.GetRowCellValue(i, "check");
                    if (Convert.ToString(check) != "")
                    {
                        if (Convert.ToBoolean(check) == true)
                        {
                            int id = Convert.ToInt32(gridView2.GetRowCellValue(i, "id"));


                            queriesTableAdapter1.delete_from_MaterialDocs2(id);

                        }
                    }
                }
                this.materialDocs2TableAdapter.FillById_DOC(this.mMSDataSet.MaterialDocs2, Globals.id_doc_materials);
            }
          else { MessageBox.Show("Документ закрыт!!! Нельзя удалять материалы"); }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.materialDocs2TableAdapter.FillById_DOC(this.mMSDataSet.MaterialDocs2, Globals.id_doc_materials);

        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
           
                var rowHandle = gridView2.FocusedRowHandle;

                int? id_Materials = (int)gridView2.GetRowCellValue(rowHandle, "id_Materials");
                double? Unit = (double)gridView2.GetRowCellValue(rowHandle, "Unit");
                int? id_doc_materials2=Globals.id_doc_materials2;
                queriesTableAdapter1.update_MaterialDocs2(id_Materials, Unit, id_doc_materials2);
               
           
            
        }

        private void materialDocs2BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {


                Globals.id_doc_materials2 = Convert.ToInt32(((DataRowView)materialDocs2BindingSource.Current).Row["id"]);

            }
            catch { }

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {


               // Globals.id_doc_materials2 = Convert.ToInt32(((DataRowView)materialDocs2BindingSource.Current).Row["id"]);

            }
            catch { }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var rowHandle = gridView2.FocusedRowHandle;

            //    if (gridView2.GetRowCellValue(rowHandle, "id_Materials").ToString() == "" || gridView2.GetRowCellValue(rowHandle, "Unit").ToString() == "")
            //    {
            //        MessageBox.Show("Введите все поля!!!");
            //    }
            //    else
            //    {
            //        int? id_Materials = (int)gridView2.GetRowCellValue(rowHandle, "id_Materials");
            //        double? Unit = (double)gridView2.GetRowCellValue(rowHandle, "Unit");

            //        int? id_doc_materials = Globals.id_doc_materials;
            //        queriesTableAdapter1.insert_MaterialDocs2(Globals.id_doc_materials, id_Materials, Unit);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
  bool status; 
            var rowHandle = gridView1.FocusedRowHandle;
            if (gridView1.GetRowCellValue(rowHandle, "doc_status") is DBNull)
            { status = false; }
            else {  status = (Boolean)gridView1.GetRowCellValue(rowHandle, "doc_status");}

         
            if (status == false) { 
            Form d = new spr_materialy();
            d.Show();
            }
            else
            {
                MessageBox.Show("Добавление не возможно документ закрыт!!!");

            }

                
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Form nakl=new Reports();
            nakl.Show();
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            this.materialDocsTableAdapter.UpdateStatusDoc(Globals.id_doc_materials);
            this.materialDocsTableAdapter.Fill(this.mMSDataSet.MaterialDocs);
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string f;
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellValue(e.RowHandle, View.Columns["doc_status"])) is DBNull || (View.GetRowCellValue(e.RowHandle, View.Columns["doc_status"])).ToString() == "")
                { f = "1"; }
                else { f = "2"; }
                if (f == "2")
                {
                    e.Appearance.BackColor = Color.FromArgb(0xCC, 0xFF, 0xFF);
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.id_slujbi = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                this.spr_metrologMolTableAdapter.Fill(this.mMSDataSet.spr_metrologMol, Globals.id_slujbi);  //метролог Мол он же Мастер по ВПУ

            }
        }
        

     
    }
}