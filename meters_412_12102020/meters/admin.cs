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
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;


namespace meters
{
    public partial class admin : Form
    {
        int k = 0;
        int kk = 0,kkk=0;
        string nregion2="0";
        int? idMeter=0;
        int idSoldPU = 0;
        MMSDataSetTableAdapters.MetersForSaleTableAdapter mfs = new MMSDataSetTableAdapters.MetersForSaleTableAdapter();
        MMSDataSet.MetersForSaleDataTable mfsta = new MMSDataSet.MetersForSaleDataTable();
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterType' table. You can move, or remove it, as needed.
            this.spr_MeterTypeTableAdapter.FillByUmnye(this.mMSDataSet.spr_MeterType);
            // TODO: This line of code loads data into the 'mMSDataSet.MetersForSale' table. You can move, or remove it, as needed.
            this.metersForSaleTableAdapter.Fill(this.mMSDataSet.MetersForSale);
            // TODO: This line of code loads data into the 'mMSDataSet.IsntalledMeters_2' table. You can move, or remove it, as needed.
            this.isntalledMeters_2TableAdapter.Fill(this.mMSDataSet.IsntalledMeters_2);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
            
            // TODO: This line of code loads data into the 'mMSDataSet.InstalledMeters2' table. You can move, or remove it, as needed.
            this.installedMeters2TableAdapter.Fill(this.mMSDataSet.InstalledMeters2);
            // TODO: This line of code loads data into the 'mMSDataSet.Import_San_Plat' table. You can move, or remove it, as needed.
            // this.import_San_PlatTableAdapter.Fill(this.mMSDataSet.Import_San_Plat);
            // this.import_San_PlatTableAdapter.Fill(this.mMSDataSet.Import_San_Plat);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //this.import_San_PlatTableAdapter.Adapter.SelectCommand.CommandTimeout = 300;

            // this.import_San_PlatTableAdapter.Fill_amiisNull(this.mMSDataSet.Import_San_Plat);
            this.import_San_PlatTableAdapter.Fill(this.mMSDataSet.Import_San_Plat);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //int count1= bandedGridView1.RowCount;

            if (bandedGridView1.RowCount == 0)
            {
                MessageBox.Show("Нет данных!");
                return;
            }
            else
            {
                try
                {
                    this.import_San_PlatTableAdapter.Fill_amiisNull(this.mMSDataSet.Import_San_Plat);

                    string text = "", id_service = "", tp_no = "", cust_code = "";

                    foreach (DataRow dr in this.mMSDataSet.Import_San_Plat.Rows)
                    {
                        switch (dr[18].ToString().Length)
                        {
                            case 0:
                                id_service = "00";
                                break;
                            case 1:
                                id_service = "0" + dr[18].ToString();
                                break;
                            case 2:
                                id_service = dr[18].ToString();
                                break;
                        }
                        switch (dr[1].ToString().Length)
                        {
                            case 0:
                                tp_no = "000000";
                                break;
                            case 1:
                                tp_no = "00000" + dr[1].ToString();
                                break;
                            case 2:
                                tp_no = "0000" + dr[1].ToString();
                                break;
                            case 3:
                                tp_no = "000" + dr[1].ToString();
                                break;
                            case 4:
                                tp_no = "00" + dr[1].ToString();
                                break;
                            case 5:
                                tp_no = "0" + dr[1].ToString();
                                break;
                            case 6:
                                tp_no = dr[1].ToString();
                                break;
                        }
                        switch (dr[3].ToString().Length)
                        {
                            case 0:
                                cust_code = "00000000000";
                                break;
                            case 1:
                                cust_code = "0000000000" + dr[3].ToString();
                                break;
                            case 2:
                                cust_code = "000000000" + dr[3].ToString();
                                break;
                            case 3:
                                cust_code = "00000000" + dr[3].ToString();
                                break;
                            case 4:
                                cust_code = "0000000" + dr[3].ToString();
                                break;
                            case 5:
                                cust_code = "000000" + dr[3].ToString();
                                break;
                            case 6:
                                cust_code = "00000" + dr[3].ToString();
                                break;
                            case 7:
                                cust_code = "0000" + dr[3].ToString();
                                break;
                            case 8:
                                cust_code = "000" + dr[3].ToString();
                                break;
                            case 9:
                                cust_code = "00" + dr[3].ToString();
                                break;
                            case 10:
                                cust_code = "0" + dr[3].ToString();
                                break;
                            case 11:
                                cust_code = dr[3].ToString();
                                break;
                        }
                        string cust_type = dr[2].ToString();
                        string cust_t = "";
                        if (cust_type == "быт")
                        {
                            cust_t = "1";
                        }

                        else
                        {
                            cust_t = "0";
                        }

                        string address = dr[7].ToString() + ';' + dr[5].ToString() + ';' + dr[6].ToString();

                        string meterNoo = "";
                        string cust_codd = "";
                        string cspot = "";
                        this.shipmentsTableAdapter.FillBySERIALNO(this.mMSDataSet.Shipments, dr[12].ToString());

                        if (this.mMSDataSet.Shipments.Rows.Count != 0)
                        {

                            foreach (DataRow tr in mMSDataSet.Shipments.Rows)
                            {
                                //  if ((tr[2].ToString().Equals("714") || tr[2].ToString().Equals("715") ))
                                if ((tr[4].ToString().Equals("Sanxing") || tr[4].ToString().Equals("SanxingIntegra") || tr[4].ToString().Equals("SanxingTnr")))
                                {
                                    text = "SNX" + id_service + tp_no + cust_t + cust_code;
                                    meterNoo = dr[12].ToString();
                                    break;
                                }
                                if ((tr[2].ToString().Equals("718") || tr[2].ToString().Equals("719")))
                                {
                                    text = "HEX" + id_service + tp_no + cust_t + cust_code;
                                    meterNoo = "0000" + dr[12].ToString();
                                    break;
                                }
                            }
                        }

                        //string hexmeter=dr[12].ToString().Substring(0,2);
                        //  string meterNoo="";
                        //  string cust_codd = "";
                        //  string cspot="";
                        //  if (hexmeter == "20" || hexmeter == "25")
                        //{
                        //    text="HEX"+id_service + tp_no + cust_t + cust_code;
                        //    meterNoo="0000"+dr[12].ToString();
                        //}
                        //if (hexmeter == "25")
                        //{
                        //    text = "HEX" + id_service + tp_no + cust_t + cust_code;
                        //    meterNoo = "0000" + dr[12].ToString();
                        //}
                        //if (hexmeter == "30" || hexmeter == "35")
                        //{
                        //    text = "SNX" + id_service + tp_no + cust_t + cust_code;
                        //    meterNoo=dr[12].ToString();
                        //}
                        cust_codd = dr[3].ToString();
                        cspot = dr[18].ToString();
                        if (dr[3].ToString().Length > 9)
                        {
                            if (dr[18].ToString().Length == 1)
                            {
                                cspot = "0" + dr[18].ToString();
                            }
                            cust_codd = cspot + dr[3].ToString();
                        }

                        this.pOC_SNTableAdapter.InsertPocFile(text, address, meterNoo, cust_codd, dr[4].ToString(),
                            cust_t, dr[13].ToString(), dr[14].ToString(), dr[16].ToString(), dr[15].ToString(), dr[9].ToString(),
                            Convert.ToDateTime(dr[10]), dr[11].ToString(), dr[0].ToString(), dr[17].ToString(), dr[1].ToString(), dr[18].ToString(),
                            DateTime.Now);
                        this.installedMeters2TableAdapter.UpdateImport_Ami(dr[3].ToString());
                        text = ""; id_service = ""; tp_no = ""; cust_code = ""; cust_t = ""; cust_codd = ""; cspot = "";
                        ++k;
                    }

                }

                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
                MessageBox.Show("Кол-во импортированных абонентов: " + k);
            }
        }

        private void importExcel_Click(object sender, EventArgs e)
        {
           
            
            if (this.gvPOC.DataRowCount > 0)
            {
                SaveExcel("customer");
                SaveExcel("meters_part-hex- CT");
                SaveExcel("meters_part-hex");
                SaveExcel("meters_part-snxdc");
                SaveExcel("meters_part-snxCT");
                SaveExcel("meters_part-san - 17DC");
                SaveExcel("meters_part-san - 17СТ");
                SaveExcel("meters_part-san - 18");
                SaveExcel("poc_hex"); 
                SaveExcel("poc_snx");
                SaveExcel("sim_part_beeline");
                SaveExcel("sim_part_megacom");
                SaveExcel("sim_part_o");
                MessageBox.Show(@"Poc файлы находятся тут-> \\server\ASU\poc\\");
            }
            else MessageBox.Show("Пусто!");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl2);
        }
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }

        private void btNEW_SN_Click(object sender, EventArgs e)
        { try
                {
            if (bandedGridView1.RowCount == 0)
            {
                MessageBox.Show("Нет данных в метерсе для импорта в санплат!");
               // return;
            }
            else 
            {
                 #region shipments
                SqlConnection conC = new SqlConnection(@"Data Source = 192.168.19.5; Initial Catalog = Meters; User Id= cc; Password=cc[].");
                    conC.Open();
                    this.import_San_PlatTableAdapter.Fill_amiisNull(this.mMSDataSet.Import_San_Plat);

                    string text = "", id_service = "", tp_no = "", cust_code = "";

                    foreach (DataRow dr in this.mMSDataSet.Import_San_Plat.Rows)
                    {


                        SqlDataAdapter adapt = new SqlDataAdapter(@"SELECT 
      cspot
      ,cspot2
      ,address1
      ,address2      
      ,ccounter
      ,ccounter20
      ,cstation
      ,nregion
      ,ccounter2           
      ,namitype          
      ,nregion2      
  FROM  Meters.dbo.All_call_spots  where ccounter = '" + dr[12].ToString().Trim() + "'and cspot='" + dr[3].ToString().Trim() + "'",
conC);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapt.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            nregion2 = Convert.ToString(dt.Rows[dt.Rows.Count - 1][10]);
                            //this.isntalledMeters_2TableAdapter.UpdateImportAmi3(dr[12].ToString().Trim());
                            // this.isntalledMeters_2TableAdapter.UpdateImportAMI(dr[12].ToString().Trim());

                        }
                        else
                        {
                            this.shipmentsTableAdapter.FillBySERIALNO(this.mMSDataSet.Shipments, dr[12].ToString());

                            if (this.mMSDataSet.Shipments.Rows.Count != 0)
                            {
                                nregion2 = "90";
                                foreach (DataRow tr in mMSDataSet.Shipments.Rows)

                                    // this.isntalledMeters_2TableAdapter.UpdateImportAMI(dr[12].ToString().Trim());
                                    idMeter = Convert.ToInt32(tr[0]);


                                this.installedMeters2TableAdapter.UpdateImportAMI2(dr[3].ToString().Trim(), idMeter);
                                ++kk;
                                idMeter = 0;
                            }

                        }


                        string cust_type = dr[2].ToString();
                        string cust_t = "";
                        if (cust_type == "быт")
                        {
                            cust_t = "1";
                        }

                        else
                        {
                            cust_t = "0";
                        }

                        string address = dr[7].ToString() + ';' + dr[5].ToString() + ';' + dr[6].ToString();

                        string meterNoo = "";
                        string cust_codd = "";
                        string cspot = "";
                        this.shipmentsTableAdapter.FillBySERIALNO(this.mMSDataSet.Shipments, dr[12].ToString());

                        if (this.mMSDataSet.Shipments.Rows.Count != 0)
                        {

                            foreach (DataRow tr in mMSDataSet.Shipments.Rows)
                            {
                                //  if ((tr[2].ToString().Equals("714") || tr[2].ToString().Equals("715") ))
                                if ((tr[4].ToString().Equals("Sanxing") || tr[4].ToString().Equals("SanxingIntegra") || tr[4].ToString().Equals("SanxingTnr") || tr[4].ToString().Equals("Sanxing2")))
                                {
                                    text = "SNX" + dr[12].ToString().Trim();
                                    meterNoo = dr[12].ToString().Trim();
                                    break;
                                }
                                if ((tr[2].ToString().Equals("718") || tr[2].ToString().Equals("719")))
                                {
                                    meterNoo = "0000" + dr[12].ToString().Trim();
                                    text = "HEX" + meterNoo;
                                    break;
                                }
                            }
                        }


                        cust_codd = dr[3].ToString();
                        cspot = dr[18].ToString();
                        if (dr[3].ToString().Length > 9)
                        {
                            if (dr[18].ToString().Length == 1)
                            {
                                cspot = "0" + dr[18].ToString();
                            }
                            cust_codd = cspot + dr[3].ToString();
                        }

                        this.pOC_SNTableAdapter.InsertNEW_POC(text, address, meterNoo, cust_codd, dr[4].ToString(),
                            cust_t, dr[13].ToString(), dr[14].ToString(), dr[16].ToString(), dr[15].ToString(), dr[9].ToString(),
                            Convert.ToDateTime(dr[10]), dr[11].ToString(), dr[0].ToString(), dr[17].ToString(), dr[1].ToString(), dr[18].ToString(),
                            DateTime.Now, nregion2);
                        this.installedMeters2TableAdapter.UpdateImport_Ami(dr[3].ToString());
                        text = ""; id_service = ""; tp_no = ""; cust_code = ""; cust_t = ""; cust_codd = ""; cspot = "";
                        nregion2 = "0";
                        ++k;


                      
                    } conC.Close();
                  
            } 
                 #endregion
           

                    SqlConnection conC2 = new SqlConnection(@"Data Source = 192.168.19.5; Initial Catalog = Meters; User Id= cc; Password=cc[].");
                    conC2.Open();
                
                   

                    

                    mfs.FillByNotImport(mfsta); 
            if(mfsta.Rows.Count>0)
            {
                  string  text = "",  tp_no = "", cust_code = "";

                    foreach (DataRow dr in mfsta.Rows)
                    {


                        SqlDataAdapter adapt = new SqlDataAdapter(@"SELECT 
      cspot
      ,cspot2
      ,address1
      ,address2      
      ,ccounter
      ,ccounter20
      ,cstation
      ,nregion
      ,ccounter2           
      ,namitype          
      ,nregion2      
,(Case when len(cspot)>9 then '1' else '0' end ) TypeCust
,name_slujba
  FROM  Meters.dbo.All_call_spots a  inner join meters.dbo.spr_slujba sl
  on a.nregion=sl.id where  namitype in (2,3,4) and ccounter = '" + dr[0].ToString().Trim() + "'",
conC2);
                       
                        string cust_t,
                            adres1,
                            adres2,
                            res,
                            typeM,
                            codeTypeM,
                            nameCust = "";
                        string address;
                        int nregion,namyType=0;

                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapt.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {                      
                            cust_code = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                            nameCust = Convert.ToString(dt.Rows[dt.Rows.Count - 1][1]);
                            adres1=Convert.ToString(dt.Rows[dt.Rows.Count - 1][2]);
                            adres2=Convert.ToString(dt.Rows[dt.Rows.Count - 1][3]);
                            codeTypeM=Convert.ToString(dt.Rows[dt.Rows.Count - 1][5]);
                            tp_no = Convert.ToString(dt.Rows[dt.Rows.Count - 1][6]);                            
                            nregion=Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][7]);
                            typeM=Convert.ToString(dt.Rows[dt.Rows.Count - 1][8]);
                            namyType=Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][9]);
                            nregion2 = Convert.ToString(dt.Rows[dt.Rows.Count - 1][10]);
                            cust_t = Convert.ToString(dt.Rows[dt.Rows.Count - 1][11]);
                            res=Convert.ToString(dt.Rows[dt.Rows.Count - 1][12]);
                            address = res + ';' + adres1+ ';' + adres2;
                            //this.isntalledMeters_2TableAdapter.UpdateImportAmi3(dr[12].ToString().Trim());
                            // this.isntalledMeters_2TableAdapter.UpdateImportAMI(dr[12].ToString().Trim());
                            string meterNoo = "";                           
                            

                           
                               
                                    //  if ((tr[2].ToString().Equals("714") || tr[2].ToString().Equals("715") ))
                            if (namyType==2)
                                    {
                                        text = "SNX" + dr[0].ToString().Trim();
                                        meterNoo = dr[0].ToString().Trim();                                       
                                    }
                           else if (namyType==4)
                                    {
                                        meterNoo = "0000" + dr[0].ToString().Trim();
                                        text = "HEX" + meterNoo;                                        
                                    }




                            this.pOC_SNTableAdapter.InsertNEW_POC(text, address, meterNoo, cust_code, nameCust,
                                cust_t, dr[3].ToString(), dr[10].ToString(), dr[12].ToString(), dr[11].ToString(), null,
                               DateTime.Now, null, null, "0", tp_no, nregion.ToString(),
                                DateTime.Now, nregion2);
                           mfs.UpdateForSale(dr[0].ToString());
                           ++kkk;
                            text = "";  tp_no = ""; cust_code = ""; cust_t = "";
                            nregion2 = "0";
                           
                        }
                       

                        
                    }conC2.Close();
            }
            }   
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
             mfs.FillByNotImport(mfsta); 
                MessageBox.Show("Кол-во импортированных абонентов: " + k +"\nКол-во абонентов, у которых нет Nregion2 : "+kk
                    + "\nКол-во купленных ПУ : " + kkk + "\nКол-во не найденных ПУ : " +mfsta.Rows.Count);
            
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                var date = dtpDate.Value;
                var time = dtpTime.Text;
                DateTime myTime = Convert.ToDateTime(dtpDate.Value.ToString("yyyy-MM-dd") + " " + time);
                switch (this.xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0: break;
                    case 1:  this.pOC_SNTableAdapter.Fill_data(this.mMSDataSet.POC_SN,myTime);break;
                }
               
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex); }
        }
        private void SaveExcel(string nameoffile)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app;
                Microsoft.Office.Interop.Excel.Workbook workbook;
                Microsoft.Office.Interop.Excel.Worksheet worksheet;
                app = new Microsoft.Office.Interop.Excel.Application();
                workbook = app.Workbooks.Add(Type.Missing);

                worksheet = null;
                app.EnableEvents = false;
                
                app.DisplayAlerts = false;
                worksheet = workbook.Sheets["Лист1"];
                worksheet.Activate();

                //worksheet = workbook.ActiveSheet;
                if (nameoffile == "customer")
                {
                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "CUSTOMER_ID";
                    worksheet.Cells[1, 2] = "CUSTOMER_NAME";
                    worksheet.Cells[1, 3] = "FIRSTNAME";
                    worksheet.Cells[1, 4] = "LASTNAME";
                    worksheet.Cells[1, 5] = "GENDER";
                    worksheet.Cells[1, 6] = "TEL";
                    worksheet.Cells[1, 7] = "MOBILE";
                    worksheet.Cells[1, 8] = "EMAIL";
                    worksheet.Cells[1, 9] = "ADDRESS";
                    worksheet.Cells[1, 10] = "POSTCODE";

                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        worksheet.Cells[(index1 + 2), 1].EntireColumn.NumberFormat = "@";
                        worksheet.Cells[(index1 + 2), 1] = gvPOC.GetRowCellValue(index1, "customer_code").ToString(); ;
                        worksheet.Cells[(index1 + 2), 2] = gvPOC.GetRowCellValue(index1, "cust_name").ToString();
                        worksheet.Cells[(index1 + 2), 9] = gvPOC.GetRowCellValue(index1, "address").ToString();

                    }
                    worksheet.get_Range(("A1".ToString()), ("j" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "meters_part-hex- CT")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "MSNO";
                    worksheet.Cells[1, 2] = "SIMNO";
                    worksheet.Cells[1, 3] = "DESCR";
                    int i = 2;// for excel
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {

                        if (gvPOC.GetRowCellValue(index1, "meters_no").ToString().Substring(0, 4) == "0000" && gvPOC.GetRowCellValue(index1, "meters_no").ToString().Substring(5, 1) == "5")
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("c" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "meters_part-hex")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "MSNO";
                    worksheet.Cells[1, 2] = "SIMNO";
                    worksheet.Cells[1, 3] = "DESCR";
                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (gvPOC.GetRowCellValue(index1, "meters_no").ToString().Substring(0, 4) == "0000" && gvPOC.GetRowCellValue(index1, "meters_no").ToString().Substring(5, 1) != "5")
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("c" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "meters_part-snxdc")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "MSNO";
                    worksheet.Cells[1, 2] = "SIMNO";
                    worksheet.Cells[1, 3] = "DESCR";
                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 3) == "007" 
                            || gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 3) == "009" 
                            || gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 2) == "30" 
                                && Int32.Parse(gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 4)) < 3004)
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("c" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "meters_part-snxCT")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "MSNO";
                    worksheet.Cells[1, 2] = "SIMNO";
                    worksheet.Cells[1, 3] = "DESCR";
                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 3) == "008" 
                            || gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 2) == "35"
                            && Int32.Parse(gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 5)) <= 35000)
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("c" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "meters_part-san - 17DC")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "MSNO";
                    worksheet.Cells[1, 2] = "SIMNO";
                    worksheet.Cells[1, 3] = "DESCR";
                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (Int32.Parse(gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 4)) >= 
                            3004 && Int32.Parse(gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 4)) < 3006)
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("c" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "meters_part-san - 17СТ")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "MSNO";
                    worksheet.Cells[1, 2] = "SIMNO";
                    worksheet.Cells[1, 3] = "DESCR";
                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (Int32.Parse(gvPOC.GetRowCellValue(index1,"meters_no").ToString().Substring(0, 5)) > 35000)
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("c" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "meters_part-san - 18")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "MSNO";
                    worksheet.Cells[1, 2] = "SIMNO";
                    worksheet.Cells[1, 3] = "DESCR";
                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (Int32.Parse(gvPOC.GetRowCellValue(index1, "meters_no").ToString().Substring(0, 4)) >=
                            3006 && Int32.Parse(gvPOC.GetRowCellValue(index1, "meters_no").ToString().Substring(0, 4)) < 3007)
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1, "meters_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1, "sim_no").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("c" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "poc_hex")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "POC_SN";
                    worksheet.Cells[1, 2] = "POC_LAT";
                    worksheet.Cells[1, 3] = "POC_LNG";
                    worksheet.Cells[1, 4] = "POC_ADDRESS";
                    worksheet.Cells[1, 5] = "METER_NO";
                    worksheet.Cells[1, 6] = "CUSTOMER_ID";
                    worksheet.Cells[1, 7] = "TP_ID";
                    worksheet.Cells[1, 8] = "POWERGRID_ID";




                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (gvPOC.GetRowCellValue(index1,"code_name").ToString().Substring(0, 3) == "HEX")
                        {
                            worksheet.Cells[i, 5].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 6].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"code_name").ToString();
                            worksheet.Cells[i, 4] = gvPOC.GetRowCellValue(index1,"address").ToString();
                            worksheet.Cells[i, 5] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 6] = gvPOC.GetRowCellValue(index1,"customer_code").ToString();
                            worksheet.Cells[i, 7] = gvPOC.GetRowCellValue(index1,"tp").ToString();
                            worksheet.Cells[i, 8] = gvPOC.GetRowCellValue(index1,"nregion2").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("h" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "poc_snx")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "POC_SN";
                    worksheet.Cells[1, 2] = "POC_LAT";
                    worksheet.Cells[1, 3] = "POC_LNG";
                    worksheet.Cells[1, 4] = "POC_ADDRESS";
                    worksheet.Cells[1, 5] = "METER_NO";
                    worksheet.Cells[1, 6] = "CUSTOMER_ID";
                    worksheet.Cells[1, 7] = "TP_ID";
                    worksheet.Cells[1, 8] = "POWERGRID_ID";



                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (gvPOC.GetRowCellValue(index1,"code_name").ToString().Substring(0, 3) == "SNX")
                        {
                            worksheet.Cells[i, 5].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 6].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"code_name").ToString();
                            worksheet.Cells[i, 4] = gvPOC.GetRowCellValue(index1,"address").ToString();
                            worksheet.Cells[i, 5] = gvPOC.GetRowCellValue(index1,"meters_no").ToString();
                            worksheet.Cells[i, 6] = gvPOC.GetRowCellValue(index1,"customer_code").ToString();
                            worksheet.Cells[i, 7] = gvPOC.GetRowCellValue(index1,"tp").ToString();
                            worksheet.Cells[i, 8] = gvPOC.GetRowCellValue(index1,"nregion2").ToString();
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("h" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "sim_part_beeline")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "SIMNO";
                    worksheet.Cells[1, 2] = "SIMICCID";
                    worksheet.Cells[1, 3] = "SIMIP";
                    worksheet.Cells[1, 4] = "SIMPORT";
                    worksheet.Cells[1, 5] = "SIMAPN";

                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                       
                        if (gvPOC.GetRowCellValue(index1,"sim_no")!=DBNull.Value&&gvPOC.GetRowCellValue(index1, "sim_no").ToString()!=""&& gvPOC.GetRowCellValue(index1,"sim_no").ToString().Substring(0, 2) == "77")
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 2].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_icc").ToString();
                            worksheet.Cells[i, 3] = gvPOC.GetRowCellValue(index1,"sim_ip").ToString();
                            worksheet.Cells[i, 4] = "20094";
                            worksheet.Cells[i, 5] = "severelectro.internet";
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("e" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "sim_part_megacom")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "SIMNO";
                    worksheet.Cells[1, 2] = "SIMICCID";
                    worksheet.Cells[1, 3] = "SIMIP";
                    worksheet.Cells[1, 4] = "SIMPORT";
                    worksheet.Cells[1, 5] = "SIMAPN";

                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                       // string temp = gvPOC.GetRowCellValue(index1, "sim_no").ToString();
                        if (gvPOC.GetRowCellValue(index1,"sim_no")!=DBNull.Value&&gvPOC.GetRowCellValue(index1, "sim_no").ToString()!=""&& gvPOC.GetRowCellValue(index1,"sim_no").ToString().Substring(0, 2) == "55")
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 2].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_icc").ToString();
                            worksheet.Cells[i, 3] = gvPOC.GetRowCellValue(index1,"sim_ip").ToString();
                            worksheet.Cells[i, 4] = "20094";
                            worksheet.Cells[i, 5] = "sever";
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("e" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                else if (nameoffile == "sim_part_o")
                {

                    worksheet.Name = nameoffile;
                    var _with1 = worksheet.PageSetup;
                    _with1.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    _with1.LeftMargin = app.InchesToPoints(0.2);
                    _with1.RightMargin = app.InchesToPoints(0.2);
                    _with1.TopMargin = app.InchesToPoints(0.2);
                    _with1.BottomMargin = app.InchesToPoints(0.2);
                    _with1.HeaderMargin = app.InchesToPoints(0.0);
                    _with1.FooterMargin = app.InchesToPoints(0.0);
                    _with1.Zoom = 65;

                    worksheet.Cells[1, 1] = "SIMNO";
                    worksheet.Cells[1, 2] = "SIMICCID";
                    worksheet.Cells[1, 3] = "SIMIP";
                    worksheet.Cells[1, 4] = "SIMPORT";
                    worksheet.Cells[1, 5] = "SIMAPN";

                    int i = 2;
                    for (int index1 = 0; index1 < gvPOC.DataRowCount; index1++)
                    {
                        if (gvPOC.GetRowCellValue(index1,"sim_no")!=DBNull.Value&&gvPOC.GetRowCellValue(index1, "sim_no").ToString()!=""&& gvPOC.GetRowCellValue(index1,"sim_no").ToString().Substring(0, 2) == "70")
                        {
                            worksheet.Cells[i, 1].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 2].EntireColumn.NumberFormat = "@";
                            worksheet.Cells[i, 1] = gvPOC.GetRowCellValue(index1,"sim_no").ToString();
                            worksheet.Cells[i, 2] = gvPOC.GetRowCellValue(index1,"sim_icc").ToString();
                            worksheet.Cells[i, 3] = gvPOC.GetRowCellValue(index1,"sim_ip").ToString();
                            worksheet.Cells[i, 4] = "20094";
                            worksheet.Cells[i, 5] = "sever";
                            i++;
                        }
                    }
                    worksheet.get_Range(("A1".ToString()), ("e" + (gvPOC.DataRowCount + 1).ToString())).Borders.LineStyle = DataGridLineStyle.Solid;
                }
                worksheet.Columns.AutoFit();                
                workbook.SaveAs(@"\\server\ASU\poc\" + worksheet.Name + ".xlsx", Type.Missing, Type.Missing,
   Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
   Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            var date = dtpDate.Value;
            var time = dtpTime.Text;
            
            DateTime myTime = Convert.ToDateTime(dtpDate.Value.ToString("yyyy-MM-dd") + " " + time);
            
            this.pOC_SNTableAdapter.Fill_data(this.mMSDataSet.POC_SN, myTime);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbMeterno.Text.Trim().Length != 0 && tbCRPU.Text.Trim().Length != 0 && tbModem.Text.Trim().Length != 0)
            {
                switch (XtraMessageBox.Show("Сохранить данные?",
               "Купленные ПУ",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        try
                        {
                            if (idSoldPU == 0)
                            {
                                mfs.InsertMetersFS(tbMeterno.Text, (int)cbType.SelectedValue, cbType.Text, tbSim.Text, tbCRPU.Text, tbModem.Text, cbManuf.SelectedItem.ToString(), tbNote.Text, DateTime.Now);
                            }
                            else
                            {
                                mfs.UpdateMetersFS(tbMeterno.Text, (int)(cbType.SelectedValue), cbType.Text, tbSim.Text, tbCRPU.Text, tbModem.Text, cbManuf.SelectedItem.ToString(), tbNote.Text, DateTime.Now, idSoldPU);
                            }
                            this.metersForSaleTableAdapter.Fill(this.mMSDataSet.MetersForSale);
                        }
                        catch (Exception ex)
                        { MessageBox.Show("" + ex); }
                        break;

                    case DialogResult.No:
                        //this.Close();
                        Cleartb();
                        break;

                    case DialogResult.Cancel:
                        // "Cancel" processing
                        break;
                }
            }
            else { MessageBox.Show("Поля не должны быть пустыми!"); }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                Cleartb();
               idSoldPU= (int)gvForSale.GetFocusedDataRow()["id"];
               tbMeterno.Text = gvForSale.GetFocusedDataRow()["MeterNo"].ToString();
                cbType.SelectedValue = gvForSale.GetFocusedDataRow()["id_Type"].ToString();
                cbManuf.SelectedItem = gvForSale.GetFocusedDataRow()["Manufacturer"].ToString();
                tbSim.Text = gvForSale.GetFocusedDataRow()["simNumber"].ToString();
                tbCRPU.Text=gvForSale.GetFocusedDataRow()["CRPU"].ToString();
                tbModem.Text=gvForSale.GetFocusedDataRow()["Modem"].ToString();
                tbNote.Text=gvForSale.GetFocusedDataRow()["Note"].ToString();               
            }
            catch(Exception ex)
            { MessageBox.Show("" + ex); }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cleartb();
        }
        private void Cleartb()
        {
            foreach (Control c in xtraTabControl1.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    c.Text = "";
                }
               
            }
            idSoldPU = 0;
            cbManuf.SelectedText = "";
            cbType.SelectedText = "";

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
             switch (XtraMessageBox.Show("Сохранить данные?",
               "Купленные ПУ",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        mfs.DeleteMetersFS((int)gvForSale.GetFocusedDataRow()["id"]);
                        MessageBox.Show("Удалено!");
                        this.metersForSaleTableAdapter.Fill(this.mMSDataSet.MetersForSale);
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex); }
            break;

                case DialogResult.No:
            //this.Close();
            Cleartb();
            break;

                case DialogResult.Cancel:
            // "Cancel" processing
            break;
            }
        }

        private void tbMeterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               (e.KeyChar != '0') &&
               (e.KeyChar != '1') &&
               (e.KeyChar != '2') &&
               (e.KeyChar != '3') &&
               (e.KeyChar != '4') &&
               (e.KeyChar != '5') &&
               (e.KeyChar != '6') &&
               (e.KeyChar != '7') &&
               (e.KeyChar != '8') &&
                (e.KeyChar != '9')
                //&&(e.KeyChar != '.')
               )
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }


    }
}