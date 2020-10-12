using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using Microsoft.Office.Interop.Excel;

namespace meters
{
    public partial class ust_list : DevExpress.XtraEditors.XtraForm
    {
        int pos = 0;
        int pos2 = 0;
        int ii = 0;
        int yy = 0;
        string masterr;
        string master2 = "";
        private int tt;//List<int> currentIdstuff = new List<int>();
        //List<string> currentstuff = new List<string>();
        public ust_list()
        {
            InitializeComponent();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colFileName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Материал",
                DataPropertyName = "Value" // Tell the column which property of FileName it should use
            };
            colFileName.Width = 150;
            
            spr_SlujbaTableAdapter1.Fill(mmsDataSet1.spr_Slujba);
           
        }
       
        private string GetSelectedNode(TreeList trvTreeList)
        {
           
            try
            {
                string fff = trvTreeList.FocusedNode[trvTreeList.Columns["id"]].ToString();
                string fff1 = trvTreeList.FocusedNode[trvTreeList.Columns["status"]].ToString();
                Globals.status = Convert.ToInt32(fff1);
                string str1 = "";
                foreach (char chr in fff)
                {
                    if (char.IsDigit(chr))
                        str1 += chr;

                }
                Globals.id_tp = Convert.ToInt32(str1);
                return fff;
            }
            catch { return ""; }

        }

        private void ust_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.spr_RegionBilling' table. You can move, or remove it, as needed.
          

            // TODO: This line of code loads data into the 'mMSDataSet.spr_RegionBilling' table. You can move, or remove it, as needed.
            //this.spr_RegionBillingTableAdapter.Fill(this.mMSDataSet.spr_RegionBilling);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_tp_ierarhiy' table. You can move, or remove it, as needed.
            this.spr_tp_ierarhiyTableAdapter.Fill(this.mMSDataSet.spr_tp_ierarhiy);
         //   this.spr_RegionBilling_filterTableAdapter.Fill_filter(this.mMSDataSet.spr_RegionBilling_filter, Globals.id_region, Globals.tp_name);
            this.spr_RegionBilling_filterTableAdapter.Fill_region(this.mMSDataSet.spr_RegionBilling_filter, Globals.id_slujbi);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_tp_ierarhiy' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'mMSDataSet.spr_master' table. You can move, or remove it, as needed.
            this.spr_masterTableAdapter.Fill(this.mMSDataSet.spr_master, Globals.id_slujbi);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Executor' table. You can move, or remove it, as needed.
            this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Materials' table. You can move, or remove it, as needed.
            this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_RegionBilling' table. You can move, or remove it, as needed.
             // this.spr_RegionBillingTableAdapter.Fill(this.mMSDataSet.spr_RegionBilling);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_vid' table. You can move, or remove it, as needed.
            this.spr_vidTableAdapter.Fill(this.mMSDataSet.spr_vid);
            //// TODO: This line of code loads data into the 'mMSDataSet.ust_list' table. You can move, or remove it, as needed.
            //   this.ust_listTableAdapter.Fill(this.mMSDataSet.ust_list);
            //   // TODO: This line of code loads data into the 'mMSDataSet.ust_list' table. You can move, or remove it, as needed.
            //   this.ust_listTableAdapter.Fill(this.mMSDataSet.ust_list);
            //   // TODO: This line of code loads data into the 'mMSDataSet.ust_list' table. You can move, or remove it, as needed.
            //   this.ust_listTableAdapter.Fill(this.mMSDataSet.ust_list);
            ////    TODO: This line of code loads data into the 'mMSDataSet.spr_Slujba' table. You can move, or remove it, as needed.
            //  this.ust_listTableAdapter1.Fill(mmsDataSet1.ust_list);

        }

        private void spr_SlujbaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }



        private void treeList1_AfterFocusNode(object sender, NodeEventArgs e)
        {
            //GetSelectedNode(treeList1);
            //if (Globals.status == 6)
            //{
            //    //   this.spr_RegionBillingTableAdapter.fill_idtp(this.mMSDataSet.spr_RegionBilling,  Convert.ToString(Globals.id_tp));
            //    ierarhiyTableAdapter.Fill(this.mMSDataSet.ierarhiy, Globals.id_tp);
            //    label2.Text = ((DataRowView)ierarhiyBindingSource.Current).Row["res"].ToString() + " ->  " + ((DataRowView)ierarhiyBindingSource.Current).Row["uch"].ToString() + " --> " + ((DataRowView)ierarhiyBindingSource.Current).Row["ps"].ToString() + " " + ((DataRowView)ierarhiyBindingSource.Current).Row["fid"].ToString() + "---> " + ((DataRowView)ierarhiyBindingSource.Current).Row["tp"].ToString();



            //}

        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btprint_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "")
            {
               Print();
            }
            else
            {
                MessageBox.Show("Выберите мастера\nСвоего РЭСа!");
            }
        }
        private void Print()
        {

            //Globals.iddoc = (int)((DataRowView)tdoc1BindingSource.Current).Row["id"];
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            app.EnableEvents = false;
            app.Visible = false;
           // app.Visible = true;
            app.DisplayAlerts = false;
            try
            {


                //worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Монтажный лист на установку ПУ";
                var _with1 = worksheet.PageSetup;
                _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                _with1.LeftMargin = app.InchesToPoints(0.2);
                _with1.RightMargin = app.InchesToPoints(0.2);
                _with1.TopMargin = app.InchesToPoints(0.1);
                _with1.BottomMargin = app.InchesToPoints(0.1);
                _with1.HeaderMargin = app.InchesToPoints(0.0);
                _with1.FooterMargin = app.InchesToPoints(0.0);

                tt = 0;

                //int tt1 = tdoc.getStuffCount();
                this.spr_regionbilling_tpTableAdapter.Fill_tp(this.mMSDataSet.spr_regionbilling_tp, Globals.id_slujbi, Convert.ToString(Globals.tp_name));
                int kol0 = this.spr_regionbilling_tpBindingSource.Count;
                for (int k = 0; k < kol0 + ii; k += tt)
                {
                    worksheet.get_Range("b" + (ii + 1).ToString(), "e" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("b" + (ii + 1).ToString(), "e" + (ii + 1).ToString()).Value = "№ док:   ";
                    //+Globals.iddoc;
                    worksheet.get_Range("a" + (ii + 1).ToString(), "aj" + (ii + 1).ToString()).RowHeight = 22;
                    
                    worksheet.get_Range("f" + (ii + 1).ToString(), "k" + (ii + 1).ToString()).Merge();
                    //string tp1 = ((DataRowView)ierarhiyBindingSource.Current).Row["tp"].ToString();
                    //string fid1=((DataRowView)ierarhiyBindingSource.Current).Row["fid"].ToString();
                    worksheet.get_Range("f" + (ii + 1).ToString(), "k" + (ii + 1).ToString()).Value = "ТП-" + Globals.tp_name + "; " + Globals.fider_name;
                    worksheet.get_Range("l" + (ii + 1).ToString(), "w" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("l" + (ii + 1).ToString(), "w" + (ii + 1).ToString()).Value = "Монтажный лист на установку счетчиков";
                    worksheet.get_Range("y" + (ii + 1).ToString(), "ag" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("y" + (ii + 1).ToString(), "ag" + (ii + 1).ToString()).Value = "Мастер: " + masterr;
                    worksheet.get_Range("A" + (ii + 1).ToString(), "Aj" + (4 + ii).ToString()).Font.Bold = true;
                    //worksheet.get_Range("B" + (ii + 4).ToString(), "AE" + (ii + 4).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    //worksheet.get_Range("B" + (ii + 4).ToString(), "AE" + (ii + 4).ToString()).HorizontalAlignment =Microsoft.Office.Interop.Excel.XlHAlign.
                    
                    worksheet.get_Range("A" + (ii + 1).ToString(), "AA" + (ii + 1).ToString()).Borders.LineStyle = DataGridLineStyle.None;
                    worksheet.get_Range("A" + (ii + 2).ToString(), "A" + (ii + 4).ToString()).Merge();
                    worksheet.get_Range("A" + (ii + 2).ToString(), "A" + (ii + 2).ToString()).ColumnWidth = 2.43;
                    worksheet.get_Range("A" + (ii + 2).ToString(), "A" + (ii + 2).ToString()).Value = "№";
                    worksheet.get_Range("B" + (ii + 2).ToString(), "E" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("B" + (ii + 2).ToString(), "B" + (ii + 2).ToString()).Value = "1 Л/счет";
                    worksheet.get_Range("B" + (ii + 4).ToString(), "aj" + (ii + 4).ToString()).ColumnWidth = 3.34;
                    worksheet.get_Range("f" + (ii + 2).ToString(), "k" + (ii + 2).ToString()).Merge();
                    //worksheet.get_Range("e3", "g3").ColumnWidth = 5;
                    worksheet.get_Range("f" + (ii + 2).ToString(), "f" + (ii + 2).ToString()).Value = "2 Ф.И.О.";
                    worksheet.get_Range("l" + (ii + 2).ToString(), "q" + (ii + 2).ToString()).Merge();
                    //worksheet.get_Range("h3", "j3").ColumnWidth = 2.3;
                    worksheet.get_Range("l" + (ii + 2).ToString(), "l" + (ii + 2).ToString()).Value = "3 Улица";
                    //worksheet.get_Range("O2", "P2").Merge();
                    //worksheet.get_Range("l3", "m3").ColumnWidth = 2.8;
                    worksheet.get_Range("r" + (ii + 2).ToString(), "s" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("r" + (ii + 2).ToString(), "r" + (ii + 2).ToString()).Value = "4 Дом";
                    worksheet.get_Range("t" + (ii + 2).ToString(), "u" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("t" + (ii + 2).ToString(), "t" + (ii + 2).ToString()).Value = "5 Кв.";
                    //worksheet.get_Range("o3", "q3").ColumnWidth = 3.43;
                    worksheet.get_Range("v" + (ii + 2).ToString(), "y" + (ii + 2).ToString()).Merge();
                    //worksheet.get_Range("o3", "t3").ColumnWidth = 3.7;
                    worksheet.get_Range("v" + (ii + 2).ToString(), "v" + (ii + 2).ToString()).Value = "6 № Нового ПУ";
                    worksheet.get_Range("z" + (ii + 2).ToString(), "ac" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("z" + (ii + 2).ToString(), "z" + (ii + 2).ToString()).Value = "7 Тип Нов.ПУ";
                    //worksheet.get_Range("r3", "s3").ColumnWidth = 3.43;
                    worksheet.get_Range("ad" + (ii + 2).ToString(), "aj" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("ad" + (ii + 2).ToString(), "ad" + (ii + 2).ToString()).Value = "8 Исполнитель";
                    worksheet.get_Range("b" + (ii + 3).ToString(), "c" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("b" + (ii + 3).ToString(), "b" + (ii + 3).ToString()).Value = "9 Т/Т";
                    worksheet.get_Range("d" + (ii + 3).ToString(), "e" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("d" + (ii + 3).ToString(), "d" + (ii + 3).ToString()).Value = "10 ГП";
                    //worksheet.get_Range("t3", "t3").ColumnWidth = 3.7;
                    worksheet.get_Range("f" + (ii + 3).ToString(), "h" + (ii + 3).ToString()).Merge();
                    //worksheet.get_Range("u3", "v3").ColumnWidth = 3.5;
                    worksheet.get_Range("f" + (ii + 3).ToString(), "f" + (ii + 3).ToString()).Value = "11 ЦРПУ";
                    worksheet.get_Range("i" + (ii + 3).ToString(), "k" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("i" + (ii + 3).ToString(), "i" + (ii + 3).ToString()).Value = "12 Щит";
                    worksheet.get_Range("l" + (ii + 3).ToString(), "n" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("l" + (ii + 3).ToString(), "l" + (ii + 3).ToString()).Value = "13 Клемник";
                    worksheet.get_Range("o" + (ii + 3).ToString(), "q" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("o" + (ii + 3).ToString(), "o" + (ii + 3).ToString()).Value = "14 Автм"; //
                    worksheet.get_Range("r" + (ii + 3).ToString(), "t" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("r" + (ii + 3).ToString(), "r" + (ii + 3).ToString()).Value = "15 Модем";
                    //worksheet.get_Range("w3", "x3").ColumnWidth = 4;
                    worksheet.get_Range("u" + (ii + 3).ToString(), "v" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("u" + (ii + 3).ToString(), "u" + (ii + 3).ToString()).Value = "16 Пок.Но";
                    worksheet.get_Range("w" + (ii + 3).ToString(), "z" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("w" + (ii + 3).ToString(), "w" + (ii + 3).ToString()).Value = "17 № Стар.ПУ";
                    worksheet.get_Range("aa" + (ii + 3).ToString(), "ad" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("aa" + (ii + 3).ToString(), "aa" + (ii + 3).ToString()).Value = "18 Тип ст.ПУ";

                    //worksheet.get_Range("ac3", "ac3").ColumnWidth = 5;
                    //worksheet.get_Range("ad3", "ae3").ColumnWidth = 3.43;
                    worksheet.get_Range("ae" + (ii + 3).ToString(), "ah" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("ae" + (ii + 3).ToString(), "ae" + (ii + 3).ToString()).Value = "19 Пок.Ст";
                    //worksheet.get_Range("af3", "ag3").ColumnWidth = 6;
                    worksheet.get_Range("ai" + (ii + 3).ToString(), "aj" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("ai" + (ii + 3).ToString(), "ai" + (ii + 3).ToString()).Value = "20 Дата";
                    //worksheet.get_Range("ai" + (ii+3.ToString(), "aj" + (ii+3).ToString()).Merge();
                    //worksheet.get_Range("ai" + (ii+3.ToString(), "ai" + (ii+3).ToString()).Value = "21 Дата";
                    //worksheet.get_Range("a2", "ag4").Font.Size = 8;
                    worksheet.get_Range("a" + (ii + 4).ToString(), "Ag" + (ii + 5).ToString()).Orientation = 90;
                    worksheet.get_Range("a" + (ii + 5).ToString(), "a" + (ii + 5).ToString()).Value = "ед.изм";
                    worksheet.get_Range("a" + (ii + 5).ToString(), "a" + (ii + 5).ToString()).Font.Size = 5;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;

                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignJustify;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).WrapText = false;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).Orientation = 90;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).AddIndent = false;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).IndentLevel = 0;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).ShrinkToFit = false;
                   // worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).ReadingOrder = xlLTR;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).MergeCells = false;


                    //worksheet.get_Range("A2", "Aj25").Borders.LineStyle = DataGridLineStyle.Solid;
                    worksheet.get_Range("B" + (ii + 2).ToString(), "AJ" + (ii + 4).ToString()).Font.Size = 7;
                    //worksheet.get_Range("b3", "Ag3").Orientation = 90;

                    int kol = this.BSspr_materials.Count;
                    this.BSspr_materials.Position = 0;
                    int j = 2;
                    for (j = 2; j < kol + 2; j++) //for (int j = 2; j <kol + 2 - 29; j++)
                    {
                        //  int r = tdoc.getStuffCount();
                        //  string sss = tdoc.getStuffItem(j + 29);
                        //  int sss1 = Convert.ToInt32(sss);
                        //  //bookstuffTableAdapter1.FillByStuff(this.counters2DataSet.bookstuff, sss1);
                        worksheet.Cells[4 + ii, j] =
                            ((DataRowView)BSspr_materials.Current).Row["MaterialSort"].ToString().Trim();
                        worksheet.Cells[5 + ii, j] =
                            ((DataRowView)BSspr_materials.Current).Row["Unit"].ToString().Trim();
                        //pos2=this.BSspr_materials.Position;
                        this.BSspr_materials.MoveNext();

                    }
                    int kol2 = this.spr_regionbilling_tpBindingSource.Count;
                    this.spr_regionbilling_tpBindingSource.Position = pos;

                    //ii = kol2 * 3 + 6;
                    for (int i = 6 + ii; i < 24 + ii; i += 3)
                    //for (int i = 6; i < kol2 * 3 + 6; i += 3)  //for (int i = 6; i < 24; i += 3)
                    {
                        if (tt == kol0)
                        {
                            ii = i;
                            worksheet.get_Range("A" + (ii - 1), "AJ" + ii).Borders.LineStyle = DataGridLineStyle.None;
                            worksheet.get_Range("B" + ii, "K" + ii).Merge();
                            worksheet.get_Range("B" + ii, "I" + ii).Font.Bold = true;
                            worksheet.get_Range("B" + ii, "B" + ii).Value = "Мастер: ________________________";
                            worksheet.get_Range("L" + ii, "AJ" + ii).Merge();
                            worksheet.get_Range("L" + ii, "W" + ii).Font.Bold = true;
                            worksheet.get_Range("L" + ii, "L" + ii).Value = "Тех. метролог:__________________________";
                            //worksheet.get_Range("B" + ii, "AJ" + ii).Merge();
                            worksheet.get_Range("A" + 2.ToString(), "Aj" + ii).Borders.LineStyle = DataGridLineStyle.Solid;

                            worksheet.get_Range("B" + ii + 4, "AJ" + ii + 5).Font.Size = 8;
                            worksheet.get_Range("A" + ii + 1, "AJ" + ii + 3).HorizontalAlignment =
                                Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            tt = 0;
                            ii = 0;

                            return;
                        }
                        worksheet.get_Range("A" + i, "A" + (i + 2).ToString()).Merge();
                        worksheet.get_Range("A" + i, "AJ" + (i + 2).ToString()).RowHeight = 23;
                        worksheet.get_Range("B" + i, "AJ" + (i + 1).ToString()).HorizontalAlignment =
                            Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        worksheet.get_Range("A" + i, "A" + i).Value = ++tt;
                        worksheet.get_Range("A" + i, "A" + (i + 1).ToString()).VerticalAlignment =
                            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        worksheet.get_Range("B" + (i + 2).ToString(), "AJ" + (i + 2).ToString()).Interior.ColorIndex
                            = 6;
                        worksheet.get_Range("B" + i, "E" + i).Merge();
                        worksheet.get_Range("B" + i, "B" + i).Font.Size = 8;
                        string value1 =
                            ((DataRowView)spr_regionbilling_tpBindingSource.Current).Row["cspot"].ToString().Trim();
                        //лицевой или абон номер
                        worksheet.get_Range("B" + i, "B" + i).Value = "1. " + value1;
                        worksheet.get_Range("F" + i, "K" + i).Merge();
                        worksheet.get_Range("F" + i, "F" + i).Font.Size = 8;
                        string value2 =
                            ((DataRowView)spr_regionbilling_tpBindingSource.Current).Row["cspot2"].ToString().Trim();
                        //инициалы Абона
                        worksheet.get_Range("F" + i, "F" + i).Value = "2. " + value2;
                        worksheet.get_Range("L" + i, "Q" + i).Merge();
                        worksheet.get_Range("L" + i, "L" + i).Font.Size = 8;
                        string value3 =
                            ((DataRowView)spr_regionbilling_tpBindingSource.Current).Row["address1"].ToString().Trim();
                        //улица
                        worksheet.get_Range("L" + i, "L" + i).Value = "3. " + value3;
                        worksheet.get_Range("R" + i, "S" + i).Merge();
                        worksheet.get_Range("R" + i, "R" + i).Font.Size = 8;
                        string value4 =
                            ((DataRowView)spr_regionbilling_tpBindingSource.Current).Row["address2"].ToString().Trim();
                        //дом.кв
                        worksheet.get_Range("R" + i, "R" + i).Value = "4. " + value4;
                        worksheet.get_Range("T" + i, "U" + i).Merge();
                        worksheet.get_Range("T" + i, "T" + i).Value = 5;
                        worksheet.get_Range("V" + i, "Y" + i).Merge();
                        worksheet.get_Range("V" + i, "V" + i).Value = 6;
                        worksheet.get_Range("Z" + i, "AC" + i).Merge();
                        worksheet.get_Range("Z" + i, "Z" + i).Value = 7;
                        worksheet.get_Range("AD" + i, "AJ" + i).Merge();
                        worksheet.get_Range("AD" + i, "AD" + i).Value = 8;
                        worksheet.get_Range("B" + (i + 1).ToString(), "C" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("B" + (i + 1).ToString(), "B" + (i + 1).ToString()).Value = 9;
                        worksheet.get_Range("D" + (i + 1).ToString(), "E" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("D" + (i + 1).ToString(), "D" + (i + 1).ToString()).Value = 10;
                        worksheet.get_Range("F" + (i + 1).ToString(), "H" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("F" + (i + 1).ToString(), "F" + (i + 1).ToString()).Value = 11;
                        worksheet.get_Range("I" + (i + 1).ToString(), "K" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("I" + (i + 1).ToString(), "I" + (i + 1).ToString()).Value = 12;
                        worksheet.get_Range("L" + (i + 1).ToString(), "N" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("L" + (i + 1).ToString(), "L" + (i + 1).ToString()).Value = 13;
                        worksheet.get_Range("O" + (i + 1).ToString(), "Q" + (i + 1).ToString()).Merge();
                        //worksheet.get_Range("R" + (i + 1).ToString(), "R" + (i + 1).ToString()).Font.Size = 8;
                        worksheet.get_Range("O" + (i + 1).ToString(), "O" + (i + 1).ToString()).Value = 14;
                        worksheet.get_Range("R" + (i + 1).ToString(), "T" + (i + 1).ToString()).Merge();
                        //worksheet.get_Range("T" + (i + 1).ToString(), "T" + (i + 1).ToString()).Font.Size = 8;

                        worksheet.get_Range("R" + (i + 1).ToString(), "R" + (i + 1).ToString()).Value = 15;
                        worksheet.get_Range("U" + (i + 1).ToString(), "V" + (i + 1).ToString()).Merge();

                        worksheet.get_Range("U" + (i + 1).ToString(), "U" + (i + 1).ToString()).Value = 16;
                        worksheet.get_Range("W" + (i + 1).ToString(), "Z" + (i + 1).ToString()).Merge();
                        string value17 =
                            ((DataRowView)spr_regionbilling_tpBindingSource.Current).Row["ccounter"].ToString().Trim();
                        //№ старого ПУ
                        worksheet.get_Range("W" + (i + 1).ToString(), "W" + (i + 1).ToString()).Value = "17. " +
                                                                                                        value17;
                        worksheet.get_Range("AA" + (i + 1).ToString(), "AD" + (i + 1).ToString()).Merge();
                        string value18 =
                            ((DataRowView)spr_regionbilling_tpBindingSource.Current).Row["ccounter_type"].ToString()
                                .Trim(); //ТИП старого ПУ
                        worksheet.get_Range("AA" + (i + 1).ToString(), "AA" + (i + 1).ToString()).Value = "18. " +
                                                                                                          value18;
                        worksheet.get_Range("AE" + (i + 1).ToString(), "AH" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("AE" + (i + 1).ToString(), "AE" + (i + 1).ToString()).Value = 19;
                        worksheet.get_Range("AI" + (i + 1).ToString(), "AJ" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("AI" + (i + 1).ToString(), "AI" + (i + 1).ToString()).Value = 20;
                        worksheet.get_Range("B" + i, "AI" + (i + 1).ToString()).Font.Size = 7;
                        this.spr_regionbilling_tpBindingSource.MoveNext();


                    }

                    pos = this.spr_regionbilling_tpBindingSource.Position;

                    ii = ii + 24;
                    worksheet.get_Range("A" + (ii - 1), "AJ" + ii).Borders.LineStyle = DataGridLineStyle.None;
                    worksheet.get_Range("B" + ii, "K" + ii).Merge();
                    worksheet.get_Range("B" + ii, "I" + ii).Font.Bold = true;
                    worksheet.get_Range("B" + ii, "B" + ii).Value = "Мастер: ________________________";
                    worksheet.get_Range("L" + ii, "AJ" + ii).Merge();
                    worksheet.get_Range("L" + ii, "W" + ii).Font.Bold = true;
                    worksheet.get_Range("L" + ii, "L" + ii).Value = "Тех. метролог:__________________________";


                    //worksheet.get_Range("B" + ii, "AJ" + ii).Merge();

                    //worksheet.get_Range("X" + ii, "X" + ii).Value = "Инспектор БЭС: ___________________________";

                    //worksheet.get_Range("b32", "v32").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    //worksheet.get_Range("r32", "ag32").Merge();
                    //worksheet.get_Range("r32", "r32").Value = "Принял Начальник энергосбыта:_________________________";
                    //worksheet.get_Range("r33", "ag33").Merge();
                    //worksheet.get_Range("r33", "r33").Value = "Объем проверил специалист ОРСиС:_________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //worksheet.get_Range("r34", "ag34").Merge();
                    //worksheet.get_Range("r34", "r34").Value = "метролог СМС ____________________________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //workbook.SaveAs(@"C:\work1.xls");
                    //workbook.PrintOutEx(Copies: pr);
                    //workbook.Close();
                    worksheet.get_Range("A" + 2.ToString(), "Aj" + ii).Borders.LineStyle = DataGridLineStyle.Solid;

                    worksheet.get_Range("B" + ii + 4, "AJ" + ii + 5).Font.Size = 8;
                    worksheet.get_Range("A" + ii + 1, "AJ" + ii + 3).HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // k = tt - 1;
                }

                app.Visible = true;




                //MessageBox.Show("Печать зaвершена");
                //dataGridView1.Update();
                //gridControl1.Update();
                //this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
                //this.spr_RegionBillingTableAdapter.Fill(this.mMSDataSet.spr_RegionBilling);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                pos = 0;
                tt = 0;
                ii = 0;
                this.BSspr_materials.Position = 0;

                this.spr_regionbilling_tpBindingSource.MoveFirst();
                this.BSspr_materials.MoveFirst();
                app.Visible = true;
            }
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                masterr = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("NameExecutor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "")
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                app.EnableEvents = false;
                app.Visible = false;
                //app.Visible = true;
                app.DisplayAlerts = false;
                app.Interactive = true;
                try
                {

                    //Microsoft.Office.Interop.Excel.Application app;
                    //Microsoft.Office.Interop.Excel.Workbook workbook;
                    //Microsoft.Office.Interop.Excel.Worksheet worksheet;
                    //app = new Microsoft.Office.Interop.Excel.Application();
                    

                    

                    
                    //worksheet = null;
                    //app.EnableEvents = false;
                    // app.Visible = true;
                    //app.Visible = true;
                    //app.DisplayAlerts = false;
                    // worksheet = workbook.Sheets["Лист3"];
                    //worksheet.Activate();
                    //worksheet = workbook.ActiveSheet;
                   



                    //worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Монтажный лист на установку ПУ";
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.1);
                    _with1.BottomMargin = app.InchesToPoints(0.1);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    worksheet.get_Range("b" + ii + 1.ToString(), "e" + ii + 1.ToString()).Merge();
                    worksheet.get_Range("b" + ii + 1.ToString(), "e" + ii + 1.ToString()).Value = "№ док:   ";
                    //+Globals.iddoc;
                    worksheet.get_Range("a" + ii + 1.ToString(), "aj" + ii + 1.ToString()).RowHeight = 22;
                    worksheet.get_Range("f" + ii + 1.ToString(), "m" + ii + 1.ToString()).Merge();
                    worksheet.get_Range("f" + ii + 1.ToString(), "m" + ii + 1.ToString()).Value = "ТП-        " + " Ф-   ";

                    worksheet.get_Range("n" + (ii + 1).ToString(), "y" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("n" + (ii + 1).ToString(), "y" + (ii + 1).ToString()).Value =
                        "Монтажный лист на установку счетчиков";
                    worksheet.get_Range("z" + (ii + 1).ToString(), "aj" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("z" + (ii + 1).ToString(), "aj" + (ii + 1).ToString()).Value = "Мастер: " +
                                                                                                       masterr;
                    worksheet.get_Range("A" + (ii + 1).ToString(), "Aj" + (4 + ii).ToString()).Font.Bold = true;
                    //worksheet.get_Range("B" + ii + 4.ToString(), "AE" + ii + 4.ToString()).HorizontalAlignment =
                       // Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    worksheet.get_Range("A" + ii + 1.ToString(), "AA" + ii + 1.ToString()).Borders.LineStyle =
                        DataGridLineStyle.None;
                    worksheet.get_Range("A" + ii + 2.ToString(), "A" + ii + 4.ToString()).Merge();
                    worksheet.get_Range("A" + ii + 2.ToString(), "A" + ii + 2.ToString()).ColumnWidth = 2.43;
                    worksheet.get_Range("A" + ii + 2.ToString(), "A" + ii + 2.ToString()).Value = "№";
                    worksheet.get_Range("B" + ii + 2.ToString(), "E" + ii + 2.ToString()).Merge();
                    worksheet.get_Range("B" + ii + 2.ToString(), "B" + ii + 2.ToString()).Value = "1 Л/счет";
                    worksheet.get_Range("B" + ii + 4.ToString(), "aj" + ii + 4.ToString()).ColumnWidth = 3.34;
                    worksheet.get_Range("f" + ii + 2.ToString(), "k" + ii + 2.ToString()).Merge();
                    //worksheet.get_Range("e3", "g3").ColumnWidth = 5;
                    worksheet.get_Range("f" + ii + 2.ToString(), "f" + ii + 2.ToString()).Value = "2 Ф.И.О.";
                    worksheet.get_Range("l" + ii + 2.ToString(), "q" + ii + 2.ToString()).Merge();
                    //worksheet.get_Range("h3", "j3").ColumnWidth = 2.3;
                    worksheet.get_Range("l" + ii + 2.ToString(), "l" + ii + 2.ToString()).Value = "3 Улица";
                    //worksheet.get_Range("O2", "P2").Merge();
                    //worksheet.get_Range("l3", "m3").ColumnWidth = 2.8;
                    worksheet.get_Range("r" + ii + 2.ToString(), "s" + ii + 2.ToString()).Merge();
                    worksheet.get_Range("r" + ii + 2.ToString(), "r" + ii + 2.ToString()).Value = "4 Дом";
                    worksheet.get_Range("t" + ii + 2.ToString(), "u" + ii + 2.ToString()).Merge();
                    worksheet.get_Range("t" + ii + 2.ToString(), "t" + ii + 2.ToString()).Value = "5 Кв.";
                    //worksheet.get_Range("o3", "q3").ColumnWidth = 3.43;
                    worksheet.get_Range("v" + ii + 2.ToString(), "y" + ii + 2.ToString()).Merge();
                    //worksheet.get_Range("o3", "t3").ColumnWidth = 3.7;
                    worksheet.get_Range("v" + ii + 2.ToString(), "v" + ii + 2.ToString()).Value = "6 № Нового ПУ";
                    worksheet.get_Range("z" + ii + 2.ToString(), "ac" + ii + 2.ToString()).Merge();
                    worksheet.get_Range("z" + ii + 2.ToString(), "z" + ii + 2.ToString()).Value = "7 Тип Нов.ПУ";
                    //worksheet.get_Range("r3", "s3").ColumnWidth = 3.43;
                    worksheet.get_Range("ad" + ii + 2.ToString(), "aj" + ii + 2.ToString()).Merge();
                    worksheet.get_Range("ad" + ii + 2.ToString(), "ad" + ii + 2.ToString()).Value = "8 Исполнитель";
                    worksheet.get_Range("b" + ii + 3.ToString(), "c" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("b" + ii + 3.ToString(), "b" + ii + 3.ToString()).Value = "9 Т/Т";
                    worksheet.get_Range("d" + ii + 3.ToString(), "e" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("d" + ii + 3.ToString(), "d" + ii + 3.ToString()).Value = "10 ГП";
                    //worksheet.get_Range("t3", "t3").ColumnWidth = 3.7;
                    worksheet.get_Range("f" + ii + 3.ToString(), "h" + ii + 3.ToString()).Merge();
                    //worksheet.get_Range("u3", "v3").ColumnWidth = 3.5;
                    worksheet.get_Range("f" + ii + 3.ToString(), "f" + ii + 3.ToString()).Value = "11 ЦРПУ";
                    worksheet.get_Range("i" + ii + 3.ToString(), "k" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("i" + ii + 3.ToString(), "i" + ii + 3.ToString()).Value = "12 Щит";
                    worksheet.get_Range("l" + ii + 3.ToString(), "n" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("l" + ii + 3.ToString(), "l" + ii + 3.ToString()).Value = "13 Клемник";
                    worksheet.get_Range("o" + ii + 3.ToString(), "q" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("o" + ii + 3.ToString(), "o" + ii + 3.ToString()).Value = "14 Автм"; //
                    worksheet.get_Range("r" + ii + 3.ToString(), "t" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("r" + ii + 3.ToString(), "r" + ii + 3.ToString()).Value = "15 Модем";
                    //worksheet.get_Range("w3", "x3").ColumnWidth = 4;
                    worksheet.get_Range("u" + ii + 3.ToString(), "v" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("u" + ii + 3.ToString(), "u" + ii + 3.ToString()).Value = "16 Пок.Но";
                    worksheet.get_Range("w" + ii + 3.ToString(), "z" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("w" + ii + 3.ToString(), "w" + ii + 3.ToString()).Value = "17 № Стар.ПУ";
                    worksheet.get_Range("aa" + ii + 3.ToString(), "ad" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("aa" + ii + 3.ToString(), "aa" + ii + 3.ToString()).Value = "18 Тип ст.ПУ";

                    //worksheet.get_Range("ac3", "ac3").ColumnWidth = 5;
                    //worksheet.get_Range("ad3", "ae3").ColumnWidth = 3.43;
                    worksheet.get_Range("ae" + ii + 3.ToString(), "ah" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("ae" + ii + 3.ToString(), "ae" + ii + 3.ToString()).Value = "19 Пок.Ст";
                    //worksheet.get_Range("af3", "ag3").ColumnWidth = 6;
                    worksheet.get_Range("ai" + ii + 3.ToString(), "aj" + ii + 3.ToString()).Merge();
                    worksheet.get_Range("ai" + ii + 3.ToString(), "ai" + ii + 3.ToString()).Value = "20 Дата";
                    //worksheet.get_Range("ai" + ii+3.ToString(), "aj" + ii+3.ToString()).Merge();
                    //worksheet.get_Range("ai" + ii+3.ToString(), "ai" + ii+3.ToString()).Value = "21 Дата";
                    //worksheet.get_Range("a2", "ag4").Font.Size = 8;
                    worksheet.get_Range("a" + ii + 4.ToString(), "Ag" + ii + 5.ToString()).Orientation = 90;
                    worksheet.get_Range("a" + ii + 5.ToString(), "a" + ii + 5.ToString()).Value = "ед.изм";
                    worksheet.get_Range("a" + ii + 5.ToString(), "a" + ii + 5.ToString()).Font.Size = 5;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).VerticalAlignment =
                       Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                    //worksheet.get_Range("b" + ii + 4.ToString(), "Aj" + ii + 5.ToString()).VerticalAlignment =Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    //worksheet.get_Range("A2", "Aj25").Borders.LineStyle = DataGridLineStyle.Solid;
                    worksheet.get_Range("B" + ii + 2.ToString(), "AJ" + ii + 4.ToString()).Font.Size = 7;
                    //worksheet.get_Range("b3", "Ag3").Orientation = 90;



                    int kol = this.BSspr_materials.Count;

                    for (int j = 2 + ii; j < kol + 2 + ii; j++) //for (int j = 2; j <kol + 2 - 29; j++)
                    {
                       
                        worksheet.Cells[4 + ii, j] =((DataRowView)BSspr_materials.Current).Row["MaterialSort"].ToString().Trim();
                        worksheet.Cells[5 + ii, j] =((DataRowView)BSspr_materials.Current).Row["Unit"].ToString().Trim();
                        this.BSspr_materials.MoveNext();
                    }

                    for (int i = 6; i < 24; i += 3)
                    {
                        worksheet.get_Range("A" + i, "A" + (i + 2).ToString()).Merge();
                        worksheet.get_Range("A" + i, "AJ" + (i + 2).ToString()).RowHeight = 23;
                        worksheet.get_Range("B" + i, "AJ" + (i + 1).ToString()).HorizontalAlignment =
                            Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        worksheet.get_Range("A" + i, "A" + i).Value = ++tt;
                        worksheet.get_Range("A" + i, "A" + (i + 1).ToString()).VerticalAlignment =
                            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        worksheet.get_Range("B" + (i + 2).ToString(), "AJ" + (i + 2).ToString()).Interior.ColorIndex = 6;
                        worksheet.get_Range("B" + i, "E" + i).Merge();
                        worksheet.get_Range("B" + i, "B" + i).Font.Size = 8;
                        worksheet.get_Range("B" + i, "B" + i).Value = 1;
                        worksheet.get_Range("F" + i, "K" + i).Merge();
                        worksheet.get_Range("F" + i, "F" + i).Font.Size = 8;
                        worksheet.get_Range("F" + i, "F" + i).Value = 2;
                        worksheet.get_Range("L" + i, "Q" + i).Merge();
                        worksheet.get_Range("L" + i, "L" + i).Font.Size = 8;
                        worksheet.get_Range("L" + i, "L" + i).Value = 3;
                        worksheet.get_Range("R" + i, "S" + i).Merge();
                        worksheet.get_Range("R" + i, "R" + i).Font.Size = 8;
                        worksheet.get_Range("R" + i, "R" + i).Value = 4;
                        worksheet.get_Range("T" + i, "U" + i).Merge();
                        worksheet.get_Range("T" + i, "T" + i).Value = 5;
                        worksheet.get_Range("V" + i, "Y" + i).Merge();
                        worksheet.get_Range("V" + i, "V" + i).Value = 6;
                        worksheet.get_Range("Z" + i, "AC" + i).Merge();
                        worksheet.get_Range("Z" + i, "Z" + i).Value = 7;
                        worksheet.get_Range("AD" + i, "AJ" + i).Merge();
                        worksheet.get_Range("AD" + i, "AD" + i).Value = 8;
                        worksheet.get_Range("B" + (i + 1).ToString(), "C" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("B" + (i + 1).ToString(), "B" + (i + 1).ToString()).Value = 9;
                        worksheet.get_Range("D" + (i + 1).ToString(), "E" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("D" + (i + 1).ToString(), "D" + (i + 1).ToString()).Value = 10;
                        worksheet.get_Range("F" + (i + 1).ToString(), "H" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("F" + (i + 1).ToString(), "F" + (i + 1).ToString()).Value = 11;
                        worksheet.get_Range("I" + (i + 1).ToString(), "K" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("I" + (i + 1).ToString(), "I" + (i + 1).ToString()).Value = 12;
                        worksheet.get_Range("L" + (i + 1).ToString(), "N" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("L" + (i + 1).ToString(), "L" + (i + 1).ToString()).Value = 13;
                        worksheet.get_Range("O" + (i + 1).ToString(), "Q" + (i + 1).ToString()).Merge();
                        //worksheet.get_Range("R" + (i + 1).ToString(), "R" + (i + 1).ToString()).Font.Size = 8;
                        worksheet.get_Range("O" + (i + 1).ToString(), "O" + (i + 1).ToString()).Value = 14;
                        worksheet.get_Range("R" + (i + 1).ToString(), "T" + (i + 1).ToString()).Merge();
                        //worksheet.get_Range("T" + (i + 1).ToString(), "T" + (i + 1).ToString()).Font.Size = 8;

                        worksheet.get_Range("R" + (i + 1).ToString(), "R" + (i + 1).ToString()).Value = 15;
                        worksheet.get_Range("U" + (i + 1).ToString(), "V" + (i + 1).ToString()).Merge();

                        worksheet.get_Range("U" + (i + 1).ToString(), "U" + (i + 1).ToString()).Value = 16;
                        worksheet.get_Range("W" + (i + 1).ToString(), "Z" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("W" + (i + 1).ToString(), "W" + (i + 1).ToString()).Value = 17;
                        worksheet.get_Range("AA" + (i + 1).ToString(), "AD" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("AA" + (i + 1).ToString(), "AA" + (i + 1).ToString()).Value = 18;
                        worksheet.get_Range("AE" + (i + 1).ToString(), "AH" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("AE" + (i + 1).ToString(), "AE" + (i + 1).ToString()).Value = 19;
                        worksheet.get_Range("AI" + (i + 1).ToString(), "AJ" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("AI" + (i + 1).ToString(), "AI" + (i + 1).ToString()).Value = 20;
                        worksheet.get_Range("B" + i, "AI" + (i + 1).ToString()).Font.Size = 8;
                    }

                    ii = ii + 24;
                    worksheet.get_Range("A" + (ii - 1), "AJ" + ii).Borders.LineStyle = DataGridLineStyle.None;
                    worksheet.get_Range("B" + ii, "K" + ii).Merge();
                    worksheet.get_Range("B" + ii, "I" + ii).Font.Bold = true;
                    worksheet.get_Range("B" + ii, "B" + ii).Value = "Мастер: ________________________";
                    worksheet.get_Range("L" + ii, "AJ" + ii).Merge();
                    worksheet.get_Range("L" + ii, "AJ" + ii).Font.Bold = true;
                    worksheet.get_Range("L" + ii, "L" + ii).Value = "Тех. метролог:__________________________";
                    //worksheet.get_Range("B" + ii, "AJ" + ii).Merge();
                    //worksheet.get_Range("X" + ii, "AG" + ii).Merge();

                    //worksheet.get_Range("X" + ii, "X" + ii).Value = "Инспектор БЭС: ___________________________";

                    //worksheet.get_Range("b32", "v32").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    //worksheet.get_Range("r32", "ag32").Merge();
                    //worksheet.get_Range("r32", "r32").Value = "Принял Начальник энергосбыта:_________________________";
                    //worksheet.get_Range("r33", "ag33").Merge();
                    //worksheet.get_Range("r33", "r33").Value = "Объем проверил специалист ОРСиС:_________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //worksheet.get_Range("r34", "ag34").Merge();
                    //worksheet.get_Range("r34", "r34").Value = "метролог СМС ____________________________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //workbook.SaveAs(@"C:\work1.xls");
                    //workbook.PrintOutEx(Copies: pr);
                    //workbook.Close();
                    worksheet.get_Range("A" + 2.ToString(), "Aj" + ii).Borders.LineStyle = DataGridLineStyle.Solid;

                    worksheet.get_Range("B" + ii + 4, "AJ" + ii + 5).Font.Size = 8;
                    worksheet.get_Range("A" + ii + 1, "AJ" + ii + 3).HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    //ii = ii + 24;

                    //worksheet.get_Range("X25", "X25").Value = "Инспектор БЭС: ___________________________";
                    //worksheet.get_Range("b32", "v32").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    //worksheet.get_Range("r32", "ag32").Merge();
                    //worksheet.get_Range("r32", "r32").Value = "Принял Начальник энергосбыта:_________________________";
                    //worksheet.get_Range("r33", "ag33").Merge();
                    //worksheet.get_Range("r33", "r33").Value = "Объем проверил специалист ОРСиС:_________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //worksheet.get_Range("r34", "ag34").Merge();
                    //worksheet.get_Range("r34", "r34").Value = "метролог СМС ____________________________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //workbook.SaveAs(@"C:\work1.xls");
                    //workbook.PrintOutEx(Copies: pr);
                    //workbook.Close();
                    //app.Visible = true;





                    //MessageBox.Show("Печать зaвершена");
                    //dataGridView1.Update();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
                finally
                {
                    app.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Выберите мастера\nСвоего РЭСа!");
            }
            this.BSspr_materials.Position=0;
            ii = 0;
        }

        private void treeList1_AfterFocusNode_1(object sender, NodeEventArgs e)
        {
            //GetSelectedNode(treeList1);
            //if (Globals.status == 6)
            //{
            //    this.spr_RegionBilling_filterTableAdapter.Fill_filter(this.mMSDataSet.spr_RegionBilling_filter, Globals.id_region, Globals.tp_name);

            //}
        }

        private void spr_tp_ierarhiyBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {


                if (spr_tp_ierarhiyBindingSource.Count > 0)
                {
                    Globals.id_region = Convert.ToInt32(((DataRowView)spr_tp_ierarhiyBindingSource.Current).Row["id_region"]);
                    //Globals.tp_name = Convert.ToInt32(((DataRowView)spr_tp_ierarhiyBindingSource.Current).Row["name_obor"]);
                    Globals.tp_name = ((DataRowView)spr_tp_ierarhiyBindingSource.Current).Row["name_obor"].ToString();Globals.fider_name = ((DataRowView)spr_tp_ierarhiyBindingSource.Current).Row["name_vl"].ToString();
                 //   this.spr_RegionBilling_filterTableAdapter.Fill_filter(this.mMSDataSet.spr_RegionBilling_filter, Globals.id_region, Globals.tp_name);
                }
            }
            catch { }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
               
            }

        private void spr_RegionBilling_filterBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {

                //if (spr_tp_ierarhiyBindingSource.Count > 0)
                    if (spr_RegionBilling_filterBindingSource.Count > 0)
                   
                {
                    Globals.tp_name = ((DataRowView)spr_RegionBilling_filterBindingSource.Current).Row["cstation"].ToString();
                    Globals.fider_name = ((DataRowView)spr_RegionBilling_filterBindingSource.Current).Row["nfeader"].ToString();
                    Globals.fider_n = ((DataRowView)spr_RegionBilling_filterBindingSource.Current).Row["feader"].ToString();
                        //Globals.tp_name = Convert.ToInt32(((DataRowView)spr_RegionBilling_filterBindingSource.Current).Row["cstation"].ToString();
                    // label3.Text = Convert.ToString(Globals.tp_name);
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new akt_byt();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new protokol_prom();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "")
            {


                //Globals.iddoc = (int)((DataRowView)tdoc1BindingSource.Current).Row["id"];
                //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                app.EnableEvents = false;
                app.Visible = false;
                // app.Visible = true;
                app.DisplayAlerts = false;
                try
                {


                    //worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Монтажный лист на установку ПУ";
                    var _with2 = worksheet.PageSetup;
                    _with2.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                    _with2.LeftMargin = app.InchesToPoints(0.2);
                    _with2.RightMargin = app.InchesToPoints(0.2);
                    _with2.TopMargin = app.InchesToPoints(0.1);
                    _with2.BottomMargin = app.InchesToPoints(0.1);
                    _with2.HeaderMargin = app.InchesToPoints(0.0);
                    _with2.FooterMargin = app.InchesToPoints(0.0);



                    _with2.PrintTitleRows = "$1:$5";
                    _with2.PrintTitleColumns = "";
                    _with2.PrintArea = "";
                    _with2.LeftHeader = "";
                    _with2.CenterHeader = "";
                    _with2.RightHeader = "&D &T";
                    _with2.LeftFooter = "Мастер по ВПУ___________________";
                    _with2.CenterFooter = "Метролог________________";
                    _with2.RightFooter = "&P из &N";
                    //_with1.LeftMargin = app.InchesToPoints(0.196850393700787);
                    //_with1.RightMargin = app.InchesToPoints(0.196850393700787);
                    //_with1.TopMargin = app.InchesToPoints(0.393700787401575);
                    //_with1.BottomMargin = app.InchesToPoints(0.393700787401575);
                    //_with1.HeaderMargin = app.InchesToPoints(0.31496062992126);
                    //_with1.FooterMargin = app.InchesToPoints(0.31496062992126);
                    _with2.PrintHeadings = false;
                    _with2.PrintGridlines = false;
                    _with2.PrintComments = XlPrintLocation.xlPrintNoComments;
                    _with2.PrintQuality = 600;
                    _with2.CenterHorizontally = false;
                    _with2.CenterVertically = false;
                    _with2.Draft = false;
                    //_with1.FirstPageNumber =  xlAutomatic;
                    _with2.Order = XlOrder.xlDownThenOver;
                    _with2.BlackAndWhite = false;
                    _with2.Zoom = 100;
                    _with2.PrintErrors = XlPrintErrors.xlPrintErrorsDisplayed;
                    _with2.OddAndEvenPagesHeaderFooter = false;
                    _with2.DifferentFirstPageHeaderFooter = false;
                    _with2.ScaleWithDocHeaderFooter = true;
                    _with2.AlignMarginsHeaderFooter = true;
                    _with2.EvenPage.LeftHeader.Text = "";
                    _with2.EvenPage.CenterHeader.Text = "";
                    _with2.EvenPage.RightHeader.Text = "";
                    _with2.EvenPage.LeftFooter.Text = "";
                    _with2.EvenPage.CenterFooter.Text = "";
                    _with2.EvenPage.RightFooter.Text = "";
                    _with2.FirstPage.LeftHeader.Text = "";
                    _with2.FirstPage.CenterHeader.Text = "";
                    _with2.FirstPage.RightHeader.Text = "";
                    _with2.FirstPage.LeftFooter.Text = "";
                    _with2.FirstPage.CenterFooter.Text = "";
                    _with2.FirstPage.RightFooter.Text = "";



                    tt = 0;

                    //int tt1 = tdoc.getStuffCount();
                    this.spr_regionbilling_tpTableAdapter.Fill_tp(this.mMSDataSet.spr_regionbilling_tp,Globals.id_slujbi, Convert.ToString(Globals.tp_name));

                    //this.spr_regionbilling_tpTableAdapter.fider(this.mMSDataSet.spr_regionbilling_tp, Globals.id_slujbi, Globals.fider_n);
                   // Globals.id_slujbi,)
                    //int kol0 = this.spr_regionbilling_tpBindingSource.Count;
                    //for (int k = 0; k < kol0 + ii; k += tt)
                    //{
                    worksheet.get_Range("b" + (ii + 1).ToString(), "e" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("b" + (ii + 1).ToString(), "e" + (ii + 1).ToString()).Value = "№ док:   ";
                    //+Globals.iddoc;
                    worksheet.get_Range("a" + (ii + 1).ToString(), "aj" + (ii + 1).ToString()).RowHeight = 22;

                    worksheet.get_Range("f" + (ii + 1).ToString(), "m" + (ii + 1).ToString()).Merge();
                    //string tp1 = ((DataRowView)ierarhiyBindingSource.Current).Row["tp"].ToString();
                    //string fid1=((DataRowView)ierarhiyBindingSource.Current).Row["fid"].ToString();
                  
                    worksheet.get_Range("f" + (ii + 1).ToString(), "m" + (ii + 1).ToString()).Value = "ТП-" + Globals.tp_name + "; " + Globals.fider_n;// +"; № " + Globals.fider_name;
                    worksheet.get_Range("n" + (ii + 1).ToString(), "y" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("n" + (ii + 1).ToString(), "y" + (ii + 1).ToString()).Value =
                        "Монтажный лист на установку счетчиков";
                    worksheet.get_Range("z" + (ii + 1).ToString(), "aj" + (ii + 1).ToString()).Merge();
                    worksheet.get_Range("z" + (ii + 1).ToString(), "aj" + (ii + 1).ToString()).Value = "Мастер: " +
                                                                                                      masterr;
                    worksheet.get_Range("A" + (ii + 1).ToString(), "Aj" + (4 + ii).ToString()).Font.Bold = true;
                    //worksheet.get_Range("B" + (ii + 4).ToString(), "AE" + (ii + 4).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    //worksheet.get_Range("B" + (ii + 4).ToString(), "AE" + (ii + 4).ToString()).HorizontalAlignment =Microsoft.Office.Interop.Excel.XlHAlign.
                    worksheet.get_Range("A" + (ii + 1).ToString(), "Aj" + (4 + ii).ToString()).Font.Bold = true;
                    worksheet.get_Range("A" + (ii + 1).ToString(), "AA" + (ii + 1).ToString()).Borders.LineStyle =
                        DataGridLineStyle.None;
                    worksheet.get_Range("A" + (ii + 2).ToString(), "A" + (ii + 4).ToString()).Merge();
                    worksheet.get_Range("A" + (ii + 2).ToString(), "A" + (ii + 2).ToString()).ColumnWidth = 2.43;
                    worksheet.get_Range("A" + (ii + 2).ToString(), "A" + (ii + 2).ToString()).Value = "№";
                    worksheet.get_Range("B" + (ii + 2).ToString(), "E" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("B" + (ii + 2).ToString(), "B" + (ii + 2).ToString()).Value = "1 Л/счет";
                    worksheet.get_Range("B" + (ii + 4).ToString(), "aj" + (ii + 4).ToString()).ColumnWidth = 3.34;
                    worksheet.get_Range("f" + (ii + 2).ToString(), "k" + (ii + 2).ToString()).Merge();
                    //worksheet.get_Range("e3", "g3").ColumnWidth = 5;
                    worksheet.get_Range("f" + (ii + 2).ToString(), "f" + (ii + 2).ToString()).Value = "2 Ф.И.О.";
                    worksheet.get_Range("l" + (ii + 2).ToString(), "q" + (ii + 2).ToString()).Merge();
                    //worksheet.get_Range("h3", "j3").ColumnWidth = 2.3;
                    worksheet.get_Range("l" + (ii + 2).ToString(), "l" + (ii + 2).ToString()).Value = "3 Улица";
                    //worksheet.get_Range("O2", "P2").Merge();
                    //worksheet.get_Range("l3", "m3").ColumnWidth = 2.8;
                    worksheet.get_Range("r" + (ii + 2).ToString(), "s" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("r" + (ii + 2).ToString(), "r" + (ii + 2).ToString()).Value = "4 Дом";
                    worksheet.get_Range("t" + (ii + 2).ToString(), "u" + (ii + 2).ToString()).Merge();
                    //worksheet.get_Range("t" + (ii + 2).ToString(), "t" + (ii + 2).ToString()).Value = "5 Кв.";

                    worksheet.get_Range("t" + (ii + 2).ToString(), "t" + (ii + 2).ToString()).Value = "5 ТП";
                    //worksheet.get_Range("o3", "q3").ColumnWidth = 3.43;
                    worksheet.get_Range("v" + (ii + 2).ToString(), "y" + (ii + 2).ToString()).Merge();
                    //worksheet.get_Range("o3", "t3").ColumnWidth = 3.7;
                    worksheet.get_Range("v" + (ii + 2).ToString(), "v" + (ii + 2).ToString()).Value =
                        "6 № Нового ПУ";
                    worksheet.get_Range("z" + (ii + 2).ToString(), "ac" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("z" + (ii + 2).ToString(), "z" + (ii + 2).ToString()).Value = "7 Тип Нов.ПУ";
                    //worksheet.get_Range("r3", "s3").ColumnWidth = 3.43;
                    worksheet.get_Range("ad" + (ii + 2).ToString(), "aj" + (ii + 2).ToString()).Merge();
                    worksheet.get_Range("ad" + (ii + 2).ToString(), "ad" + (ii + 2).ToString()).Value =
                        "8 Исполнитель";
                    worksheet.get_Range("b" + (ii + 3).ToString(), "c" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("b" + (ii + 3).ToString(), "b" + (ii + 3).ToString()).Value = "9 Т/Т";
                    worksheet.get_Range("d" + (ii + 3).ToString(), "e" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("d" + (ii + 3).ToString(), "d" + (ii + 3).ToString()).Value = "10 ГП";
                    //worksheet.get_Range("t3", "t3").ColumnWidth = 3.7;
                    worksheet.get_Range("f" + (ii + 3).ToString(), "h" + (ii + 3).ToString()).Merge();
                    //worksheet.get_Range("u3", "v3").ColumnWidth = 3.5;
                    worksheet.get_Range("f" + (ii + 3).ToString(), "f" + (ii + 3).ToString()).Value = "11 ЦРПУ";
                    worksheet.get_Range("i" + (ii + 3).ToString(), "k" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("i" + (ii + 3).ToString(), "i" + (ii + 3).ToString()).Value = "12 Щит";
                    worksheet.get_Range("l" + (ii + 3).ToString(), "n" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("l" + (ii + 3).ToString(), "l" + (ii + 3).ToString()).Value = "13 Клемник";
                    worksheet.get_Range("o" + (ii + 3).ToString(), "q" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("o" + (ii + 3).ToString(), "o" + (ii + 3).ToString()).Value = "14 Автм"; //
                    worksheet.get_Range("r" + (ii + 3).ToString(), "t" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("r" + (ii + 3).ToString(), "r" + (ii + 3).ToString()).Value = "15 Модем";
                    //worksheet.get_Range("w3", "x3").ColumnWidth = 4;
                    worksheet.get_Range("u" + (ii + 3).ToString(), "v" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("u" + (ii + 3).ToString(), "u" + (ii + 3).ToString()).Value = "16 Пок.Но";
                    worksheet.get_Range("w" + (ii + 3).ToString(), "z" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("w" + (ii + 3).ToString(), "w" + (ii + 3).ToString()).Value = "17 № Стар.ПУ";
                    worksheet.get_Range("aa" + (ii + 3).ToString(), "ad" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("aa" + (ii + 3).ToString(), "aa" + (ii + 3).ToString()).Value =
                        "18 Тип ст.ПУ";

                    //worksheet.get_Range("ac3", "ac3").ColumnWidth = 5;
                    //worksheet.get_Range("ad3", "ae3").ColumnWidth = 3.43;
                    worksheet.get_Range("ae" + (ii + 3).ToString(), "ah" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("ae" + (ii + 3).ToString(), "ae" + (ii + 3).ToString()).Value = "19 Пок.Ст";
                    //worksheet.get_Range("af3", "ag3").ColumnWidth = 6;
                    worksheet.get_Range("ai" + (ii + 3).ToString(), "aj" + (ii + 3).ToString()).Merge();
                    worksheet.get_Range("ai" + (ii + 3).ToString(), "ai" + (ii + 3).ToString()).Value = "20 Дата";
                    //worksheet.get_Range("ai" + (ii+3.ToString(), "aj" + (ii+3).ToString()).Merge();
                    //worksheet.get_Range("ai" + (ii+3.ToString(), "ai" + (ii+3).ToString()).Value = "21 Дата";
                    //worksheet.get_Range("a2", "ag4").Font.Size = 8;
                    worksheet.get_Range("a" + (ii + 4).ToString(), "Ag" + (ii + 5).ToString()).Orientation = 90;
                    worksheet.get_Range("a" + (ii + 5).ToString(), "a" + (ii + 5).ToString()).Value = "ед.изм";
                    worksheet.get_Range("a" + (ii + 5).ToString(), "a" + (ii + 5).ToString()).Font.Size = 5;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;

                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignJustify;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).VerticalAlignment =
                        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).WrapText = false;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).Orientation = 90;

                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).RowHeight = 80.25;
                    worksheet.get_Range("b" + (ii + 5).ToString(), "Aj" + (ii + 6).ToString()).RowHeight = 17.25;
    
 
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).AddIndent = false;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).IndentLevel = 0;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).ShrinkToFit = false;
                    // worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).ReadingOrder = xlLTR;
                    worksheet.get_Range("b" + (ii + 4).ToString(), "Aj" + (ii + 5).ToString()).MergeCells = false;


                    //worksheet.get_Range("A2", "Aj25").Borders.LineStyle = DataGridLineStyle.Solid;
                    worksheet.get_Range("B" + (ii + 2).ToString(), "AJ" + (ii + 4).ToString()).Font.Size = 7;
                    //worksheet.get_Range("b3", "Ag3").Orientation = 90;

                    int kol = this.BSspr_materials.Count;
                    this.BSspr_materials.Position = 0;
                    int j = 2;
                    for (j = 2; j < kol + 2; j++) //for (int j = 2; j <kol + 2 - 29; j++)
                    {
                        //  int r = tdoc.getStuffCount();
                        //  string sss = tdoc.getStuffItem(j + 29);
                        //  int sss1 = Convert.ToInt32(sss);
                        //  //bookstuffTableAdapter1.FillByStuff(this.counters2DataSet.bookstuff, sss1);
                        worksheet.Cells[4 + ii, j] =
                            ((DataRowView) BSspr_materials.Current).Row["MaterialSort"].ToString().Trim();
                        worksheet.Cells[5 + ii, j] =
                            ((DataRowView) BSspr_materials.Current).Row["Unit"].ToString().Trim();
                        //pos2=this.BSspr_materials.Position;
                        this.BSspr_materials.MoveNext();

                    }
                    int kol2 = this.spr_regionbilling_tpBindingSource.Count;

                    // int koln = this.spr_regionbilling_tpBindingSource.Count;
                    //for (int k = 0; k < koln + ii; k += tt)
                    //{
                    //this.spr_regionbilling_tpBindingSource.Position = pos;

                    //ii = kol2 * 3 + 6;
                    for (int i = 6; i < kol2*3 + 6; i += 3)
                        //for (int i = 6 + ii; i < 24 + ii; i += 3)
                        //for (int i = 6; i < kol2 * 3 + 6; i += 3)  //for (int i = 6; i < 24; i += 3)
                    {
                        if (tt == kol2)
                        {
                            //ii = i;
                            //worksheet.get_Range("A" + (ii - 1), "AJ" + ii).Borders.LineStyle = DataGridLineStyle.None;
                            //worksheet.get_Range("B" + ii, "K" + ii).Merge();
                            //worksheet.get_Range("B" + ii, "I" + ii).Font.Bold = true;
                            //worksheet.get_Range("B" + ii, "B" + ii).Value = "Мастер: ________________________";
                            //worksheet.get_Range("L" + ii, "AJ" + ii).Merge();
                            //worksheet.get_Range("L" + ii, "W" + ii).Font.Bold = true;
                            //worksheet.get_Range("L" + ii, "L" + ii).Value = "Тех. метролог:__________________________";
                            //worksheet.get_Range("B" + ii, "AJ" + ii).Merge();
                            //worksheet.get_Range("A" + 2.ToString(), "Aj" + ii).Borders.LineStyle = DataGridLineStyle.Solid;

                            //worksheet.get_Range("B" + ii + 4, "AJ" + ii + 5).Font.Size = 8;
                            //worksheet.get_Range("A" + ii + 1, "AJ" + ii + 3).HorizontalAlignment =Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            tt = 0;
                            ii = 0;

                            return;
                        }
                        worksheet.get_Range("A" + i, "A" + (i + 2).ToString()).Merge();
                        worksheet.get_Range("A" + i, "AJ" + (i + 2).ToString()).RowHeight = 23;
                        worksheet.get_Range("B" + i, "AJ" + (i + 1).ToString()).HorizontalAlignment =
                            Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        worksheet.get_Range("A" + i, "A" + i).Value = ++tt;
                        worksheet.get_Range("A" + i, "A" + (i + 1).ToString()).VerticalAlignment =
                            Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        worksheet.get_Range("B" + (i + 2).ToString(), "AJ" + (i + 2).ToString()).Interior.ColorIndex
                            = 6;
                        worksheet.get_Range("B" + i, "E" + i).Merge();
                        worksheet.get_Range("B" + i, "B" + i).Font.Size = 8;
                        string value1 =
                            ((DataRowView) spr_regionbilling_tpBindingSource.Current).Row["cspot"].ToString().Trim();
                        //лицевой или абон номер
                        worksheet.get_Range("B" + i, "B" + i).Value = "1. " + value1;
                        worksheet.get_Range("F" + i, "K" + i).Merge();
                        worksheet.get_Range("F" + i, "F" + i).Font.Size = 8;
                        string value2 =
                            ((DataRowView) spr_regionbilling_tpBindingSource.Current).Row["cspot2"].ToString()
                                .Trim();
                        //инициалы Абона
                        worksheet.get_Range("F" + i, "F" + i).Value = "2. " + value2;
                        worksheet.get_Range("L" + i, "Q" + i).Merge();
                        worksheet.get_Range("L" + i, "L" + i).Font.Size = 8;
                        string value3 =
                            ((DataRowView) spr_regionbilling_tpBindingSource.Current).Row["address1"].ToString()
                                .Trim();
                        //улица
                        worksheet.get_Range("L" + i, "L" + i).Value = "3. " + value3;
                        worksheet.get_Range("R" + i, "S" + i).Merge();
                        worksheet.get_Range("R" + i, "R" + i).Font.Size = 8;
                        string value4 =
                            ((DataRowView) spr_regionbilling_tpBindingSource.Current).Row["address2"].ToString()
                                .Trim();
                        //дом.кв
                        worksheet.get_Range("R" + i, "R" + i).Value = "4.-  " + value4;
                        worksheet.get_Range("T" + i, "U" + i).Merge();
                        
                        worksheet.get_Range("T" + i, "T" + i).Value = 5;
                         //worksheet.get_Range("T" + i, "T" + i).Value =((DataRowView) spr_regionbilling_tpBindingSource.Current).Row["cstation"].ToString().Trim();
                        worksheet.get_Range("V" + i, "Y" + i).Merge();
                        worksheet.get_Range("V" + i, "V" + i).Value = 6;
                        worksheet.get_Range("Z" + i, "AC" + i).Merge();
                        worksheet.get_Range("Z" + i, "Z" + i).Value = 7;
                        worksheet.get_Range("AD" + i, "AJ" + i).Merge();
                        worksheet.get_Range("AD" + i, "AD" + i).Value = 8;
                        worksheet.get_Range("B" + (i + 1).ToString(), "C" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("B" + (i + 1).ToString(), "B" + (i + 1).ToString()).Value = 9;
                        worksheet.get_Range("D" + (i + 1).ToString(), "E" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("D" + (i + 1).ToString(), "D" + (i + 1).ToString()).Value = 10;
                        worksheet.get_Range("F" + (i + 1).ToString(), "H" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("F" + (i + 1).ToString(), "F" + (i + 1).ToString()).Value = 11;
                        worksheet.get_Range("I" + (i + 1).ToString(), "K" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("I" + (i + 1).ToString(), "I" + (i + 1).ToString()).Value = 12;
                        worksheet.get_Range("L" + (i + 1).ToString(), "N" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("L" + (i + 1).ToString(), "L" + (i + 1).ToString()).Value = 13;
                        worksheet.get_Range("O" + (i + 1).ToString(), "Q" + (i + 1).ToString()).Merge();
                        //worksheet.get_Range("R" + (i + 1).ToString(), "R" + (i + 1).ToString()).Font.Size = 8;
                        worksheet.get_Range("O" + (i + 1).ToString(), "O" + (i + 1).ToString()).Value = 14;
                        worksheet.get_Range("R" + (i + 1).ToString(), "T" + (i + 1).ToString()).Merge();
                        //worksheet.get_Range("T" + (i + 1).ToString(), "T" + (i + 1).ToString()).Font.Size = 8;

                        worksheet.get_Range("R" + (i + 1).ToString(), "R" + (i + 1).ToString()).Value = 15;
                        worksheet.get_Range("U" + (i + 1).ToString(), "V" + (i + 1).ToString()).Merge();

                        worksheet.get_Range("U" + (i + 1).ToString(), "U" + (i + 1).ToString()).Value = 16;
                        worksheet.get_Range("W" + (i + 1).ToString(), "Z" + (i + 1).ToString()).Merge();
                        string value17 =
                            ((DataRowView) spr_regionbilling_tpBindingSource.Current).Row["ccounter"].ToString()
                                .Trim();
                        //№ старого ПУ
                        worksheet.get_Range("W" + (i + 1).ToString(), "W" + (i + 1).ToString()).Value = "17. " +
                                                                                                        value17;
                        worksheet.get_Range("AA" + (i + 1).ToString(), "AD" + (i + 1).ToString()).Merge();
                        string value18 =
                            ((DataRowView) spr_regionbilling_tpBindingSource.Current).Row["ccounter_type"].ToString()
                                .Trim(); //ТИП старого ПУ
                        worksheet.get_Range("AA" + (i + 1).ToString(), "AA" + (i + 1).ToString()).Value = "18. " +
                                                                                                          value18;
                        worksheet.get_Range("AE" + (i + 1).ToString(), "AH" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("AE" + (i + 1).ToString(), "AE" + (i + 1).ToString()).Value = 19;
                        worksheet.get_Range("AI" + (i + 1).ToString(), "AJ" + (i + 1).ToString()).Merge();
                        worksheet.get_Range("AI" + (i + 1).ToString(), "AI" + (i + 1).ToString()).Value = 20;
                        worksheet.get_Range("B" + i, "AI" + (i + 1).ToString()).Font.Size = 7;
                        this.spr_regionbilling_tpBindingSource.MoveNext();

                    }

                    pos = this.spr_regionbilling_tpBindingSource.Position;
                    ii = kol2*3 + 6;
                    worksheet.get_Range("A" + 2.ToString(), "Aj" + (ii - 1)).Borders.LineStyle =
                        DataGridLineStyle.Solid;

                    //}

                    //worksheet.get_Range("A" + (ii - 1), "AJ" + ii).Borders.LineStyle = DataGridLineStyle.None;
                    //worksheet.get_Range("B" + ii, "K" + ii).Merge();
                    //worksheet.get_Range("B" + ii, "I" + ii).Font.Bold = true;
                    //worksheet.get_Range("B" + ii, "B" + ii).Value = "Мастер: ________________________";
                    //worksheet.get_Range("L" + ii, "AJ" + ii).Merge();
                    //worksheet.get_Range("L" + ii, "W" + ii).Font.Bold = true;
                    //worksheet.get_Range("L" + ii, "L" + ii).Value = "Тех. метролог:__________________________";
                    //worksheet.get_Range("B" + ii, "AJ" + ii).Merge();

                    //worksheet.get_Range("X" + ii, "X" + ii).Value = "Инспектор БЭС: ___________________________";

                    //worksheet.get_Range("b32", "v32").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    //worksheet.get_Range("r32", "ag32").Merge();
                    //worksheet.get_Range("r32", "r32").Value = "Принял Начальник энергосбыта:_________________________";
                    //worksheet.get_Range("r33", "ag33").Merge();
                    //worksheet.get_Range("r33", "r33").Value = "Объем проверил специалист ОРСиС:_________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //worksheet.get_Range("r34", "ag34").Merge();
                    //worksheet.get_Range("r34", "r34").Value = "метролог СМС ____________________________________________";                //worksheet.get_Range("a" + (dataGridView1.Rows.Count + 3).ToString(), col + (dataGridView1.Rows.Count + 3).ToString()).Font.Bold = true;
                    //workbook.SaveAs(@"C:\work1.xls");
                    //workbook.PrintOutEx(Copies: pr);
                    //workbook.Close();

                    //worksheet.get_Range("A" + 2.ToString(), "Aj" + ii).Borders.LineStyle = DataGridLineStyle.Solid;
                    //worksheet.get_Range("B" + ii + 4, "AJ" + ii + 5).Font.Size = 8;
                    //worksheet.get_Range("A" + ii + 1, "AJ" + ii + 3).HorizontalAlignment =Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // k = tt - 1;


                    app.Visible = true;




                    //MessageBox.Show("Печать зaвершена");
                    //dataGridView1.Update();
                    //gridControl1.Update();
                    //this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
                    //this.spr_RegionBillingTableAdapter.Fill(this.mMSDataSet.spr_RegionBilling);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    pos = 0;
                    tt = 0;
                    ii = 0;
                    this.BSspr_materials.Position = 0;

                    this.spr_regionbilling_tpBindingSource.MoveFirst();
                    this.BSspr_materials.MoveFirst();
                    app.Visible = true;
                }


            }
            else
            {
                MessageBox.Show("Выберите мастера\nСвоего РЭСа!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "")
            {
                Globals.master_vpu = lookUpEdit1.Text;
                Form f = new reestr();
                f.Show();
            }
            else
            {
                MessageBox.Show("Выберите Мастера ВПУ");
            }
        }


            }
    

        }

