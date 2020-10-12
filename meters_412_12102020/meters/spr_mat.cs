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
    public partial class spr_mat : DevExpress.XtraEditors.XtraForm
    {
        public spr_mat()
        {
            InitializeComponent();
        }

        private void spr_mat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Materials2' table. You can move, or remove it, as needed.
            this.spr_Materials2TableAdapter.Fill(this.mMSDataSet.spr_Materials2);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Materials' table. You can move, or remove it, as needed.


            if (Globals.id_access != 1)
            {
                simpleButton6.Visible = false;

            }
               }

     
        private void spr_MaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spr_Materials2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                var rowHandle = gridView1.FocusedRowHandle;

                if (gridView1.GetRowCellValue(rowHandle, "MaterialSort").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "Unit").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "cena").ToString() == "")
                {
                    MessageBox.Show("Введите все поля!!!");
                }
                else
                {
                    int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                    string ed = (string)gridView1.GetRowCellValue(rowHandle, "Unit");
                    decimal cena = (decimal)gridView1.GetRowCellValue(rowHandle, "cena");
                    string mat = (string)gridView1.GetRowCellValue(rowHandle, "MaterialSort");
                  
                    if (id < 0)
                    {
                        //MessageBox.Show("insert");
                        queriesTableAdapter1.insert_spr_mat(mat,ed,cena);
                    }
                    else
                    {
                        queriesTableAdapter1.update_spr_mat(id,mat,ed, cena);
                    }

                    //DateTime date1 = Convert.ToDateTime("01.01." + comboBox1.Text);
                    //DateTime date2 = Convert.ToDateTime("31.12." + comboBox1.Text);


                }


                int ii = spr_Materials2BindingSource.Position;
                MessageBox.Show("Данные успешно сохранены");

                this.spr_Materials2TableAdapter.Fill(this.mMSDataSet.spr_Materials2);
                spr_Materials2BindingSource.Position = ii;
                Globals.add = "update";
            }
            catch { }
        }
    }
}
