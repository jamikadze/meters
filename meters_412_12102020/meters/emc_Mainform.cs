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
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace meters
{
    public partial class emc_Mainform : DevExpress.XtraEditors.XtraForm
    {
        //string simno = "";
        public emc_Mainform()
        {
            InitializeComponent();
        }

        private void emc_Mainform_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Seals' table. You can move, or remove it, as needed.
            this.spr_SealsTableAdapter.Fill(this.mMSDataSet.spr_Seals);
            
            // TODO: This line of code loads data into the 'mMSDataSet.notes' table. You can move, or remove it, as needed.
            this.notesTableAdapter.Fill(this.mMSDataSet.notes);
            // TODO: This line of code loads data into the 'mMSDataSet.Sim' table. You can move, or remove it, as needed.
            this.simTableAdapter.Fill(this.mMSDataSet.Sim);
           

        }

        
        public static System.Data.DataTable ConvertExcelToDataTable(string FileName)
        {
            System.Data.DataTable dtResult = null;
            int totalSheet = 0; //No of sheets on excel file  
            using (OleDbConnection objConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';"))
            {
                objConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                System.Data.DataTable dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = string.Empty;
                if (dt != null)
                {
                    var tempDataTable = (from dataRow in dt.AsEnumerable()
                                         where !dataRow["TABLE_NAME"].ToString().Contains("FilterDatabase")
                                         select dataRow).CopyToDataTable();
                    dt = tempDataTable;
                    totalSheet = dt.Rows.Count;
                    sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
                }
                cmd.Connection = objConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *  FROM [" + sheetName + "]";
                oleda = new OleDbDataAdapter(cmd);
                oleda.Fill(ds, "excelData");
                dtResult = ds.Tables["excelData"];
                objConn.Close();
                return dtResult; //Returning Dattable  
            }
        }
        private void SqlDb(string str, SqlConnection con)
        {
            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandType = CommandType.Text;
                    command.CommandText = str;
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex); }
            finally
            {
                con.Close();
            }
        }  
        private void btnBrowseNewOff_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файл Excel|*.XLSX;*.XLS";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                DataTable dt =  ConvertExcelToDataTable(path);
                SqlDb(@"IF NOT EXISTS( SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'rawdatamonth') CREATE TABLE [dbo].rawdatamonth([msno] [nvarchar](50) NULL);",
                   new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()));

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()))
                {
                    bulkCopy.DestinationTableName =
                        "dbo.rawdatamonth";
                    try
                    {
                        // Write from the source to the destination.
                        bulkCopy.WriteToServer(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    MessageBox.Show("Загружена!");                    
                }
            } 
        }
        

        private void gvAllList_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                //var rowHandle = gvAllList.FocusedRowHandle;
                object v = gvAllList.GetRowCellValue(gvAllList.FocusedRowHandle, "status");
                string note = gvAllList.GetRowCellValue(gvAllList.FocusedRowHandle, "note").ToString();  
                MMSDataSetTableAdapters.QueriesTableAdapter qta = new MMSDataSetTableAdapters.QueriesTableAdapter();
               
               // MessageBox.Show(note);
                qta.emc_update(gvAllList.GetFocusedDataRow()["serialno"].ToString(), gvAllList.GetFocusedDataRow()["SimNo"].ToString(), Int32.Parse(gvAllList.GetFocusedDataRow()["sold"].ToString()),
                    gvAllList.GetFocusedDataRow()["plomba"].ToString(), repositoryItemComboBox1.Items.IndexOf(v),  note,
                    gvAllList.GetFocusedDataRow()["note2"].ToString(), Globals.userId4SCM, (DateTime)gvAllList.GetFocusedDataRow()["dateimport"]);
                if ((note == "Замена сим" || note == "Замена модема и сим") )//нужно сравнить со старой симкартой
                    qta.setHistory(4, gvAllList.GetFocusedDataRow()["serialno"].ToString(), null, "996"+gvAllList.GetFocusedDataRow()["SimNo"].ToString(), 2, Int32.Parse(gvAllList.GetFocusedDataRow()["nregion"].ToString()), Globals.userId4SCM);

                MessageBox.Show("Сохранено!");
                this.emc_shipmentsTableAdapter.Fill(this.mMSDataSet.emc_shipments);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            //if (gpusimno.Length > 0 && gpusimno != lu_simgpu.Text)//снять сим, установить новый сим
            //{ queries.setHistory(4, tbCcounter.Text, null, gpusimno, 3, Int32.Parse(queries.GetRegion(cbRegion.Text).ToString()), Int32.Parse(queries.GetExecutor(cbUser.Text).ToString())); }
            //queries.setHistory(4, tbCcounter.Text, null, lu_simgpu.Text, 2, Int32.Parse(queries.GetRegion(cbRegion.Text).ToString()), Int32.Parse(queries.GetExecutor(cbUser.Text).ToString()));
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.emc_temp' table. You can move, or remove it, as needed.
            this.emc_tempTableAdapter.Fill(this.mMSDataSet.emc_temp);
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.emc_shipments' table. You can move, or remove it, as needed.
            this.emc_shipmentsTableAdapter.FillNL(this.mMSDataSet.emc_shipments);

        }

        private void rbOld_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNew.Checked)
            {// TODO: This line of code loads data into the 'mMSDataSet.emc_NewOfflineList' table. You can move, or remove it, as needed.
                this.emc_NewOfflineListTableAdapter.Fill(this.mMSDataSet.emc_NewOfflineList,1);
            }
            else if (rbOld.Checked)
            {// TODO: This line of code loads data into the 'mMSDataSet.emc_NewOfflineList' table. You can move, or remove it, as needed.
                this.emc_NewOfflineListTableAdapter.Fill(this.mMSDataSet.emc_NewOfflineList,0);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MMSDataSetTableAdapters.QueriesTableAdapter qta = new MMSDataSetTableAdapters.QueriesTableAdapter();
            try
            {
                qta.emc_insert(gridView1.GetFocusedDataRow()["SerialNo"].ToString(), gridView1.GetFocusedDataRow()["SimNo"].ToString(), Int32.Parse(gridView1.GetFocusedDataRow()["sold"].ToString()),
                     DateTime.Now);

                MessageBox.Show("Сохранено!");
                rbOld_CheckedChanged(null, null);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            rbNew.Checked = true;
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (backstageViewControl1.SelectedTabIndex == 0)
            {
                if (!gridControl1.IsPrintingAvailable)
                {
                    MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }


                // Open the Preview window.
                gridControl1.ShowPrintPreview();
            }
            else if (backstageViewControl1.SelectedTabIndex == 1)
            {
                if (!gridControl2.IsPrintingAvailable)
                {
                    MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }


                // Open the Preview window.
                gridControl2.ShowPrintPreview();
 
            }
            
        }
       

        private void cmsCheckCon_Click(object sender, EventArgs e)
        {
            emcLogin log = new emcLogin(); emcConnect concl;
            if (gvAllList.GetFocusedDataRow()["Manufacturer"].ToString()=="Hexing")
            {
             concl = new emcConnect("0000"+gvAllList.GetFocusedDataRow()["serialno"].ToString());}
            else{ concl = new emcConnect(gvAllList.GetFocusedDataRow()["serialno"].ToString());}
           MessageBox.Show(concl.conMethod());
        }

        
        private void repositoryItemLookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
               // object note = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("note");
                //if(simno!= gvAllList.GetFocusedDataRow()["SimNo"].ToString())
                gvAllList.SetFocusedRowCellValue("note", "Замена сим");
                gvAllList.SetFocusedRowCellValue("status", "На связи");
               // gvAllList.SetFocusedRowCellValue("dateimport", DateTime.Now);
            }
        }

        private void gvAllList_DoubleClick(object sender, EventArgs e)
        {
            gvAllList.SetFocusedRowCellValue("dateimport", DateTime.Now);
            //simno = gvAllList.GetFocusedDataRow()["SimNo"].ToString();
        }

        private void btnWithDate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.emc_temp' table. You can move, or remove it, as needed.
            this.emc_tempTableAdapter.FillByDate(this.mMSDataSet.emc_temp,dtp1.Value,dtp2.Value);
        }

        private void backstageViewClientControl3_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
                ps.Landscape = true;
                ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
                ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
                rv.SetPageSettings(ps);
                MMSDataSetTableAdapters.emc_reportAllTableAdapter allta = new MMSDataSetTableAdapters.emc_reportAllTableAdapter();
                MMSDataSetTableAdapters.emc_reportProviderTableAdapter pta = new MMSDataSetTableAdapters.emc_reportProviderTableAdapter();
                if (cb.SelectedIndex <= 3)
                {
                    this.rv.LocalReport.DataSources.Clear();
                    pta.Fill(this.mMSDataSet.emc_reportProvider, cb.SelectedIndex);
                    ReportDataSource reportDataSourceValue = new ReportDataSource("dsProvider", (DataTable)(this.mMSDataSet.emc_reportProvider));

                    this.rv.LocalReport.DataSources.Add(reportDataSourceValue);


                    this.rv.LocalReport.ReportEmbeddedResource = "meters.emc_ReportProvider.rdlc";
                    ReportParameter title = new ReportParameter("ReportTitle", cb.Text);
                    //ReportParameter fromdate = new ReportParameter("fromdate", dtp1.Value.ToString("dd.MM.yyyy г."));

                    rv.LocalReport.SetParameters(new ReportParameter[] { title });
                    //rv.LocalReport.SetParameters(new ReportParameter[] { fromdate });


                    this.rv.RefreshReport();                    
                }
                else 
                {
                    this.rv.LocalReport.DataSources.Clear();
                    allta.Fill(this.mMSDataSet.emc_reportAll);
                    ReportDataSource reportDataSourceValue = new ReportDataSource("dsAll", (DataTable)(this.mMSDataSet.emc_reportAll));

                    this.rv.LocalReport.DataSources.Add(reportDataSourceValue);


                    this.rv.LocalReport.ReportEmbeddedResource = "meters.emc_ReportAll.rdlc";
                    //ReportParameter todate = new ReportParameter("todate", dtp2.Value.ToString("dd.MM.yyyy г."));
                    //ReportParameter fromdate = new ReportParameter("fromdate", dtp1.Value.ToString("dd.MM.yyyy г."));

                    //rv.LocalReport.SetParameters(new ReportParameter[] { todate });
                    //rv.LocalReport.SetParameters(new ReportParameter[] { fromdate });


                    this.rv.RefreshReport();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }



       
    }
}