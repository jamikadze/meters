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
    public partial class montaj : Form
    {
        int newDocNumber;
        DateTime datetdoc;
        List<int> currentIdstuff = new List<int>();
        List<string> currentstuff = new List<string>();
        public montaj()
        {//SystemSounds.Beep.Play();
            //Console.Beep();
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
            dataGridView2.Columns.Add(colFileName);

            //if (Globals.tdocGlobal != null)
            //{
            //    button6.Visible = false;
            //    button5.Visible = false;
            //    button2.Visible = false;
            //    datetdoc = Globals.tdocGlobal.tDateDoc;
            //    datalabel.Text = datalabel.Text + Globals.tdocGlobal.tDateDoc.ToShortDateString();
            //    newDocNumber = Globals.tdocGlobal.tNomDoc;
            //    tdoclabel.Text = tdoclabel.Text + " " + Globals.tdocGlobal.tNomDoc;
            //    //namemasterlabel.Text = namemasterlabel.Text + " " + Globals.tdocGlobal.tNameMaster;
            //    namemasterlabel.Text = namemasterlabel.Text + " " + Globals.nameUser;
            //    label4.Visible = false;
            //    comboBox1.Visible = false;
            //    textBoxNametDoc.Text = Globals.tdocGlobal.tNameDoc;
            //    textBoxNametDoc.Enabled = false;
            //    //dataGridView2.Rows.Add(Globals.tdocGlobal.getStuffCount() - 31);
            //    currentIdstuff.Clear();
            //    currentstuff.Clear();
            //    for (int i = 0; i < Globals.tdocGlobal.getStuffCount() - 31; ++i)
            //    {
            //        currentIdstuff.Add(Convert.ToInt32(Globals.tdocGlobal.getStuffItem(i + 31)));
            //        int ii = currentIdstuff[currentIdstuff.Count - 1];
            //        //tdocTableAdapter1.FillByStuff(counters2DataSet.tdoc, ii);
            //        bookstuffTableAdapter.FillByStuff(counters2DataSet.bookstuff, ii);
            //        dataGridView2.Rows.Add(((DataRowView)bookstuffBindingSource.Current).Row["Наименования"]);
            //        //dataGridView2.Rows.Add(Globals.tdocGlobal.getStuffItem(i + 31));
            //        //dataGridView2.Rows.Add(((DataRowView)tdocbindingSource.Current).Row["stuff"].ToString());
            //    }
            //}
            //else
            //{
            //    datetdoc = DateTime.Now;
            //    datalabel.Text = datalabel.Text + datetdoc.Date.ToString().Substring(0, 10);
            //    newDocNumber = (this.queriesTableAdapter.getNewDoc()).GetValueOrDefault() + 1;
            //    tdoclabel.Text = tdoclabel.Text + " " + newDocNumber.ToString();
            //    namemasterlabel.Text = namemasterlabel.Text + " " + Globals.nameUser;
            //}
        }

        private void montaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.spr_RegionBilling' table. You can move, or remove it, as needed.
            this.spr_RegionBillingTableAdapter.Fill(this.mMSDataSet.spr_RegionBilling);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Materials' table. You can move, or remove it, as needed.
            this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);

        }
        private void addtemp()
        {
            int i = currentIdstuff.IndexOf((int)((DataRowView)bsregion.Current).Row["id"]);
            if (i < 0)
            {
                currentstuff.Add((string)((DataRowView)bsregion.Current).Row["cspot"]);
                currentIdstuff.Add((int)((DataRowView)bsregion.Current).Row["id"]);
                dataGridView2.Rows.Add(1);
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = (string)((DataRowView)bsregion.Current).Row["cspot"];
                dataGridView2.Update();
            }
            else
                MessageBox.Show("Такой материал\nуже есть в списке");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tDoc tdoc = new tDoc();
            //tdoc.ClearAll();
            ////tdocTableAdapter.Fill(counters2DataSet.tdoc);
            ////tdocTableAdapter.GetByNumbDoc(Convert.ToInt32(((DataRowView)tdocBindingSource.Current).Row["id"]));
            //b1 = (byte[])((DataRowView)tdoc1BindingSource.Current).Row["tcontent"];
            //MemoryStream ms1 = new MemoryStream(b1);
            //BinaryFormatter bf1 = new BinaryFormatter();
            //tdoc = (tDoc)bf1.Deserialize(ms1);
            Print();
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
            //app.Visible = true;
            app.DisplayAlerts = false;
            try
            {

                //worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Наряд на установку счетчиков";
                var _with1 = worksheet.PageSetup;
                _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                _with1.LeftMargin = app.InchesToPoints(0.2);
                _with1.RightMargin = app.InchesToPoints(0.2);
                _with1.TopMargin = app.InchesToPoints(0.1);
                _with1.BottomMargin = app.InchesToPoints(0.1);
                _with1.HeaderMargin = app.InchesToPoints(0.0);
                _with1.FooterMargin = app.InchesToPoints(0.0);
                worksheet.get_Range("b1", "e1").Merge();
                worksheet.get_Range("b1", "e1").Value = "№ док: "; //+Globals.iddoc;
                worksheet.get_Range("a1", "aj1").RowHeight = 22;
                worksheet.get_Range("f1", "k1").Merge();
                worksheet.get_Range("f1", "k1").Value = "ТП-    Ф-    ";
                worksheet.get_Range("l1", "s1").Merge();
                worksheet.get_Range("l1", "s1").Value = "Наряд на установку счетчиков";
                worksheet.get_Range("y1", "ag1").Merge();
                worksheet.get_Range("y1", "ag1").Value = "Мастер:_____________________ ";
                worksheet.get_Range("A1", "Aj3").Font.Bold = true;
                worksheet.get_Range("B4", "AE4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.get_Range("A1", "AA1").Borders.LineStyle = DataGridLineStyle.None;
                worksheet.get_Range("A2", "A4").Merge();
                worksheet.get_Range("A2", "A2").ColumnWidth = 2.43;
                worksheet.get_Range("A2", "A2").Value = "№";
                worksheet.get_Range("B2", "E2").Merge();
                worksheet.get_Range("B2", "B2").Value = "1 Л/счет";
                worksheet.get_Range("B4", "aj4").ColumnWidth = 3.34;
                worksheet.get_Range("f2", "k2").Merge();
                //worksheet.get_Range("e3", "g3").ColumnWidth = 5;
                worksheet.get_Range("f2", "f2").Value = "2 Ф.И.О.";
                worksheet.get_Range("l2", "q2").Merge();
                //worksheet.get_Range("h3", "j3").ColumnWidth = 2.3;
                worksheet.get_Range("l2", "l2").Value = "3 Улица";
                //worksheet.get_Range("O2", "P2").Merge();
                //worksheet.get_Range("l3", "m3").ColumnWidth = 2.8;
                worksheet.get_Range("r2", "s2").Merge();
                worksheet.get_Range("r2", "r2").Value = "4 Дом";
                worksheet.get_Range("t2", "u2").Merge();
                worksheet.get_Range("t2", "t2").Value = "5 кв.";
                //worksheet.get_Range("o3", "q3").ColumnWidth = 3.43;
                worksheet.get_Range("v2", "y2").Merge();
                //worksheet.get_Range("o3", "t3").ColumnWidth = 3.7;
                worksheet.get_Range("v2", "v2").Value = "6 № нового счетчика";
                worksheet.get_Range("z2", "ac2").Merge();
                worksheet.get_Range("z2", "z2").Value = "7 Тип нов.сч";
                //worksheet.get_Range("r3", "s3").ColumnWidth = 3.43;
                worksheet.get_Range("ad2", "aj2").Merge();
                worksheet.get_Range("ad2", "ad2").Value = "8 Метролог";
                worksheet.get_Range("b3", "c3").Merge();
                worksheet.get_Range("b3", "b3").Value = "9 Т/Т";
                worksheet.get_Range("d3", "e3").Merge();
                worksheet.get_Range("d3", "d3").Value = "10 ГП";
                //worksheet.get_Range("t3", "t3").ColumnWidth = 3.7;
                worksheet.get_Range("f3", "i3").Merge();
                //worksheet.get_Range("u3", "v3").ColumnWidth = 3.5;
                worksheet.get_Range("f3", "f3").Value = "11 ЦРПУ";
                worksheet.get_Range("j3", "m3").Merge();
                worksheet.get_Range("j3", "j3").Value = "12 Эн.сбыт";
                worksheet.get_Range("n3", "q3").Merge();
                worksheet.get_Range("n3", "n3").Value = "13 Кожух";
                worksheet.get_Range("r3", "s3").Merge();
                worksheet.get_Range("r3", "r3").Value = "14 пок Н.с";
                //worksheet.get_Range("w3", "x3").ColumnWidth = 4;
                worksheet.get_Range("t3", "w3").Merge();
                worksheet.get_Range("t3", "t3").Value = "15 № стар.счетч";
                worksheet.get_Range("x3", "aa3").Merge();
                worksheet.get_Range("x3", "x3").Value = "16 Тип ст.сч";

                //worksheet.get_Range("ac3", "ac3").ColumnWidth = 5;
                //worksheet.get_Range("ad3", "ae3").ColumnWidth = 3.43;
                worksheet.get_Range("ab3", "ad3").Merge();
                worksheet.get_Range("ab3", "ab3").Value = "17 Пок-е";
                //worksheet.get_Range("af3", "ag3").ColumnWidth = 6;
                worksheet.get_Range("ae3", "ah3").Merge();
                worksheet.get_Range("ae3", "ae3").Value = "18 Исполнитель";
                worksheet.get_Range("ai3", "aj3").Merge();
                worksheet.get_Range("ai3", "ai3").Value = "19 Дата";
                //worksheet.get_Range("a2", "ag4").Font.Size = 8;
                worksheet.get_Range("a4", "Ag5").Orientation = 90;
                worksheet.get_Range("a5", "a5").Value = "ед.изм";
                worksheet.get_Range("a5", "a5").Font.Size = 5;
                worksheet.get_Range("b4", "Aj5").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                worksheet.get_Range("A2", "Aj25").Borders.LineStyle = DataGridLineStyle.Solid;
                worksheet.get_Range("B2", "AJ3").Font.Size = 9;
                //worksheet.get_Range("b3", "Ag3").Orientation = 90;

                int tt = 0;
                //int tt1 = tdoc.getStuffCount();
                //for (int j = 2; j < tt1 - 29; j++)
                //{
                //  int r = tdoc.getStuffCount();
                //  string sss = tdoc.getStuffItem(j + 29);
                //  int sss1 = Convert.ToInt32(sss);
                //  //bookstuffTableAdapter1.FillByStuff(this.counters2DataSet.bookstuff, sss1);
                //  worksheet.Cells[4, j] = ((DataRowView)bookstuffBindingSource.Current).Row["Наименования"].ToString().Trim();
                //  worksheet.Cells[5, j] = ((DataRowView)bookstuffBindingSource.Current).Row["Ед_изм"].ToString().Trim();
                //}
                for (int i = 6; i < 24; i += 3)
                {
                    worksheet.get_Range("A" + i, "A" + (i + 2).ToString()).Merge();
                    worksheet.get_Range("A" + i, "AJ" + (i + 2).ToString()).RowHeight = 23;
                    worksheet.get_Range("B" + i, "AJ" + (i + 1).ToString()).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    worksheet.get_Range("A" + i, "A" + i).Value = ++tt;
                    worksheet.get_Range("A" + i, "A" + (i + 1).ToString()).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    worksheet.get_Range("B" + (i + 2).ToString(), "AJ" + (i + 2).ToString()).Interior.ColorIndex = 6;
                    worksheet.get_Range("B" + i, "E" + i).Merge();
                    worksheet.get_Range("B" + i, "B" + i).Value = "salam";
                    worksheet.get_Range("F" + i, "K" + i).Merge();
                    worksheet.get_Range("F" + i, "F" + i).Value = "privet";
                    worksheet.get_Range("L" + i, "Q" + i).Merge();
                    worksheet.get_Range("L" + i, "L" + i).Value = 3;
                    worksheet.get_Range("R" + i, "S" + i).Merge();
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
                    worksheet.get_Range("F" + (i + 1).ToString(), "I" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("F" + (i + 1).ToString(), "F" + (i + 1).ToString()).Value = 11;
                    worksheet.get_Range("J" + (i + 1).ToString(), "M" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("J" + (i + 1).ToString(), "J" + (i + 1).ToString()).Value = 12;
                    worksheet.get_Range("N" + (i + 1).ToString(), "Q" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("N" + (i + 1).ToString(), "N" + (i + 1).ToString()).Value = 13;
                    worksheet.get_Range("R" + (i + 1).ToString(), "S" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("R" + (i + 1).ToString(), "R" + (i + 1).ToString()).Value = 14;
                    worksheet.get_Range("T" + (i + 1).ToString(), "W" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("T" + (i + 1).ToString(), "T" + (i + 1).ToString()).Value = 15;
                    worksheet.get_Range("X" + (i + 1).ToString(), "AA" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("X" + (i + 1).ToString(), "X" + (i + 1).ToString()).Value = 16;
                    worksheet.get_Range("AB" + (i + 1).ToString(), "AD" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("AB" + (i + 1).ToString(), "AB" + (i + 1).ToString()).Value = 17;
                    worksheet.get_Range("AE" + (i + 1).ToString(), "AH" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("AE" + (i + 1).ToString(), "AE" + (i + 1).ToString()).Value = 18;
                    worksheet.get_Range("AI" + (i + 1).ToString(), "AJ" + (i + 1).ToString()).Merge();
                    worksheet.get_Range("AI" + (i + 1).ToString(), "AI" + (i + 1).ToString()).Value = 19;
                    worksheet.get_Range("B" + i, "AI" + (i + 1).ToString()).Font.Size = 5;
                }

                worksheet.get_Range("B4", "AJ5").Font.Size = 6;
                worksheet.get_Range("A1", "AJ3").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.get_Range("A24", "AJ25").Borders.LineStyle = DataGridLineStyle.None;
                worksheet.get_Range("B25", "I25").Merge();
                worksheet.get_Range("B25", "B25").Value = "Мастер: ________________________";
                worksheet.get_Range("L25", "T25").Merge();
                worksheet.get_Range("L25", "L25").Value = "Тех. метролог:__________________________";
                worksheet.get_Range("X25", "AG25").Merge();
                worksheet.get_Range("X25", "X25").Value = "Инспектор БЭС: ___________________________";
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
                app.Visible = true;





                //MessageBox.Show("Печать зaвершена");
                dataGridView1.Update();
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

        private void btpoisktp_Click(object sender, EventArgs e)
        {
            string ZZ = tbTP.Text + '%';
            this.spr_RegionBillingTableAdapter.FillLiketp(this.mMSDataSet.spr_RegionBilling, ZZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtemp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            currentIdstuff.RemoveAt(dataGridView2.CurrentRow.Index);
            currentstuff.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addtemp();
        }

    }
}
