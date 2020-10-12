using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meters
{
    public partial class Import2Billing : Form
    {
        string path = "",address2="";
        DataTable dt = new DataTable();
        Boolean  prombyt=false;
        public Import2Billing()
        {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файл Excel|*.XLSX;*.XLS";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                dt = ConvertExcelToDataTable(path,prombyt);
                
                SqlDb(@"IF NOT EXISTS( SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tempregionbilling') CREATE TABLE [dbo].[tempregionbilling](	[cspot] [nvarchar](100) NULL,	[cspot2] [nvarchar](100) NULL,	[cabonent] [nvarchar](100) NULL,	
[cconsumer] [nvarchar](100) NULL,[address1] [nvarchar](255) NULL,	[address2] [nvarchar](100) NULL,
	[ccounter] [nvarchar](50) not NULL,	[counter_type] [nvarchar](50) NULL,	[cstation] [int] NULL,	[nfeader] [int] NULL,	
	[feader] [nvarchar](100) NULL,	[nsubstation] [int] NULL,	[substation] [nvarchar](255) NULL,[MCB_CT] [nvarchar](255) NULL,	[transformer_ratio] decimal(10,2) NULL,	
	[pm] decimal(10,2) NULL,	[nregion] [int] NULL,	[ccounter20] [int] NULL,[customer_type] [int] NULL,		[dateImport] [datetime] NULL,[userid] [int] NULL) ;",
                   new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()));
         
                
                    try
                    {
                        // Write from the source to the destination.
                       // string str = "";
                        
                        /*for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            this.tempregionbillingTableAdapter.InsertQuery(dt.Rows[i]["cspot"].ToString(), dt.Rows[i]["cspot2"].ToString(),dt.Rows[i]["cabonent"].ToString(),
                                dt.Rows[i]["cconsumer"].ToString(), dt.Rows[i]["address1"].ToString(), dt.Rows[i]["address2"].ToString(), dt.Rows[i]["ccounter"].ToString(),
                                dt.Rows[i]["counter_type"].ToString(), (Int32)dt.Rows[i]["cstation"], (Int32)dt.Rows[i]["nfeader"],
                                dt.Rows[i]["feader"].ToString(), (Int32)dt.Rows[i]["nsubstation"], dt.Rows[i]["substation"].ToString(),
                               (Int32)dt.Rows[i]["transformer_ratio"], (Double)dt.Rows[i]["pm"], 0,
                               (Int32)dt.Rows[i]["nregion"], (Int32)dt.Rows[i]["ccounter20"], (DateTime)dt.Rows[i]["dateImport"], Globals.id_user);
                            }                        
                        */
                        if (prombyt)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()))
                                {
                                    address2= dt.Rows[i][3].ToString();

                                    if (dt.Rows[i][4].ToString() != "" && dt.Rows[i][4].ToString() != null)
                                        address2 += "/" + dt.Rows[i][4].ToString();

                                    if (dt.Rows[i][5].ToString() != "" && dt.Rows[i][5].ToString() != null)
                                        address2 += "-" + dt.Rows[i][5].ToString();
                                    
                                    if (dt.Rows[i][6].ToString() != "" && dt.Rows[i][6].ToString() != null)
                                        address2 += "/" + dt.Rows[i][6].ToString();

                                    string sql = "INSERT INTO [tempregionbilling] ([cspot], [cspot2],  [address1], [address2], [ccounter]," +
                                     " [counter_type], [cstation], [nfeader], [feader], [nsubstation], [substation],[MCB_CT], [transformer_ratio], [pm],  [nregion], [ccounter20],[customer_type], [dateImport], [userid]) VALUES ('" +
                                     dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "', '" + address2 + "', '" + dt.Rows[i][7].ToString() + "', '" + dt.Rows[i][8].ToString() + "', @cstation, @nfeader,'" +
                                     dt.Rows[i][11].ToString() + "', @nsubstation, '" + dt.Rows[i][13].ToString() + "','" + dt.Rows[i][14].ToString() + "', @transformer_ratio, @pm,  @nregion, @ccounter20,@customer_type, @dateImport, @userid)";
                                   

                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand(sql, connection))
                                    {
                                        if (dt.Rows[i][7].ToString() == "Б/СЧ" && (dt.Rows[i][18] == null || dt.Rows[i][18].ToString() == ""))
                                        {
                                            var ccounter20 = new SqlParameter("@ccounter20", SqlDbType.Int);
                                            ccounter20.Value = 3000;
                                            command.Parameters.Add(ccounter20);
                                        }
                                        else
                                        {
                                            var ccounter20 = new SqlParameter("@ccounter20", SqlDbType.Int);
                                            ccounter20.Value = dt.Rows[i][18];
                                            command.Parameters.Add(ccounter20); 
                                        }
                                        var cstation = new SqlParameter("@cstation", SqlDbType.Int);
                                        cstation.Value = dt.Rows[i][9];
                                        command.Parameters.Add(cstation);
                                        var nfeader = new SqlParameter("@nfeader", SqlDbType.Int);
                                        nfeader.Value = dt.Rows[i][10];
                                        command.Parameters.Add(nfeader);
                                        var nsubstation = new SqlParameter("@nsubstation", SqlDbType.Int);
                                        nsubstation.Value = dt.Rows[i][12];
                                        command.Parameters.Add(nsubstation);
                                        var transformer_ratio = new SqlParameter("@transformer_ratio", SqlDbType.Int);
                                        transformer_ratio.Value = dt.Rows[i][15];
                                        command.Parameters.Add(transformer_ratio);
                                        var pm = new SqlParameter("@pm", SqlDbType.Decimal);
                                        if (dt.Rows[i][16].ToString() == "" || dt.Rows[i][16].ToString() == null)
                                            pm.Value = 0.0;
                                        else pm.Value = Decimal.Parse(dt.Rows[i][16].ToString());

                                        command.Parameters.Add(pm);
                                        var nregion = new SqlParameter("@nregion", SqlDbType.Int);
                                        nregion.Value = Globals.id_slujbi;
                                        command.Parameters.Add(nregion);
                                        
                                        var dateImport = new SqlParameter("@dateImport", SqlDbType.DateTime);
                                        dateImport.Value = DateTime.Now;
                                        command.Parameters.Add(dateImport);
                                        var userid = new SqlParameter("@userid", SqlDbType.Int);
                                        userid.Value = Globals.id_user;
                                        command.Parameters.Add(userid);
                                        var customer_type = new SqlParameter("@customer_type", SqlDbType.Int);
                                        customer_type.Value = 1;
                                        command.Parameters.Add(customer_type);
                                        var results = command.ExecuteNonQuery();
                                        connection.Close();
                                    }
                                }
                            }
                        }
                        else 
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()))
                                {
                                    address2 = dt.Rows[i][5].ToString();

                                    if (dt.Rows[i][6].ToString() != "" && dt.Rows[i][6].ToString() != null)
                                        address2 += "/" + dt.Rows[i][6].ToString();
                                    
                                    string sql = "INSERT INTO [tempregionbilling] ([cspot], [cspot2], [cabonent],[cconsumer] , [address1], [address2], [ccounter]," +
                                     " [counter_type], [cstation], [nfeader], [feader], [nsubstation], [substation],[MCB_CT], [transformer_ratio], [pm],  [nregion], [ccounter20],[customer_type], [dateImport], [userid]) VALUES ('" +
                                     dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "', '" + dt.Rows[i][3].ToString() + "', '" + dt.Rows[i][4].ToString() + "', '" + address2 + "', '" + dt.Rows[i][7].ToString() + "', '" + dt.Rows[i][8].ToString() + "', @cstation, @nfeader,'" +
                                     dt.Rows[i][11].ToString() + "', @nsubstation, '" + dt.Rows[i][13].ToString() + "','"+dt.Rows[i][14].ToString()+"', @transformer_ratio, @pm,  @nregion, @ccounter20,@customer_type, @dateImport, @userid)";
                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand(sql, connection))
                                    {
                                        if (dt.Rows[i][7].ToString() == "Б/СЧ" && (dt.Rows[i][18] == null || dt.Rows[i][18].ToString() == ""))
                                        {
                                            var ccounter20 = new SqlParameter("@ccounter20", SqlDbType.Int);
                                            ccounter20.Value = 3000;
                                            command.Parameters.Add(ccounter20);
                                        }
                                        else
                                        {
                                            var ccounter20 = new SqlParameter("@ccounter20", SqlDbType.Int);
                                            ccounter20.Value = dt.Rows[i][18];
                                            command.Parameters.Add(ccounter20);
                                        }
                                        var cstation = new SqlParameter("@cstation", SqlDbType.Int);
                                        cstation.Value = dt.Rows[i][9];
                                        command.Parameters.Add(cstation);
                                        var nfeader = new SqlParameter("@nfeader", SqlDbType.Int);
                                        nfeader.Value = dt.Rows[i][10];
                                        command.Parameters.Add(nfeader);
                                        var nsubstation = new SqlParameter("@nsubstation", SqlDbType.Int);
                                        nsubstation.Value = dt.Rows[i][12];
                                        command.Parameters.Add(nsubstation);
                                        var transformer_ratio = new SqlParameter("@transformer_ratio", SqlDbType.Int);
                                        transformer_ratio.Value = dt.Rows[i][15];
                                        command.Parameters.Add(transformer_ratio);
                                        var pm = new SqlParameter("@pm", SqlDbType.Decimal);
                                        if (dt.Rows[i][16].ToString() == "" || dt.Rows[i][16].ToString() == null)
                                            pm.Value = 0.0;
                                        else pm.Value = Decimal.Parse(dt.Rows[i][16].ToString());

                                        command.Parameters.Add(pm);
                                        var nregion = new SqlParameter("@nregion", SqlDbType.Int);
                                        nregion.Value = Globals.id_slujbi;
                                        command.Parameters.Add(nregion);
                                        
                                        var dateImport = new SqlParameter("@dateImport", SqlDbType.DateTime);
                                        dateImport.Value = DateTime.Now;
                                        command.Parameters.Add(dateImport);
                                        var userid = new SqlParameter("@userid", SqlDbType.Int);
                                        userid.Value = Globals.id_user;
                                        command.Parameters.Add(userid);
                                        var customer_type = new SqlParameter("@customer_type", SqlDbType.Int);
                                        customer_type.Value = 0;
                                        command.Parameters.Add(customer_type);
                                        var results = command.ExecuteNonQuery();
                                        connection.Close();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error "+ex);
                    }
                    btnImport.Enabled = true;
                    // TODO: This line of code loads data into the 'mMSDataSet.tempregionbilling' table. You can move, or remove it, as needed.
                    this.tempregionbillingTableAdapter.Fill(this.mMSDataSet.tempregionbilling);
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
        public static System.Data.DataTable ConvertExcelToDataTable(string FileName, Boolean prombyt)
        {
            try
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
            catch (Exception ex)
            { MessageBox.Show("" + ex); return null; }
                   
        }

      

        private void Import2Billing_Load(object sender, EventArgs e)
        {
            rbProm.Checked = true;
            this.regionBillingViewTableAdapter.Fill(this.mMSDataSet.RegionBillingView, Globals.id_slujbi,0);
            
        }

        private void rbProm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByt.Checked)
            { prombyt = true; this.regionBillingViewTableAdapter.Fill(this.mMSDataSet.RegionBillingView, Globals.id_slujbi, 1); }
            else if (rbProm.Checked)
            { prombyt = false; this.regionBillingViewTableAdapter.Fill(this.mMSDataSet.RegionBillingView, Globals.id_slujbi, 0); }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DataTable dttemp = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT t.[cspot],t.[cspot2],t.[cabonent],t.[cconsumer],t.[address1],t.[address2],t.[ccounter],t.[counter_type],t.[cstation]"+
"      ,t.[nfeader],t.[feader],t.[nsubstation],t.[substation],t.[MCB_CT],t.[transformer_ratio],t.[pm],t.[nregion],t.[ccounter20]"+
"      ,t.[customer_type],t.[dateImport],t.[userid] FROM [MMS].[dbo].[tempregionbilling] t left outer join [MMS].[dbo].spr_RegionBilling s "+
"  on t.cspot=s.cspot and t.nregion=s.nregion and t.customer_type=s.customer_type where s.cspot is null", new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()));
            da.Fill(dttemp);
            if (dt.Rows.Count > dttemp.Rows.Count && dt.Rows.Count > 0)
            {
                if (prombyt)
                {
                    string upd = "UPDATE a   SET a.[cspot] = b.[cspot]" +         
          ",a.[cspot2] = b.[cspot2]" +
          ",a.[address1] = b.[address1]" +
          ",a.[address2] = b.[address2]" +
          ",a.[ccounter] = b.[ccounter]" +
          ",a.[ccounter_type] = b.[counter_type]" +
          ",a.[cstation] = b.[cstation]" +
          ",a.[nfeader] = b.[nfeader]" +
          ",a.[feader] = b.[feader]" +
          ",a.[nsubstation] = b.[nsubstation]" +
          ",a.[substation] = b.[substation]" +
          ",a.[MCB_CT] = b.[MCB_CT]" +
          ",a.[transformer_ratio] = b.[transformer_ratio]" +
          ",a.[PM] = b.[PM]" +
          ",a.[nregion] = b.[nregion]" +          
          ",a.[ccounter20] = b.[ccounter20]" +
          ",a.[DateImport] = b.[DateImport]" +
          ",a.[user_id] =b.[userid]" +
          "from [MMS].[dbo].[spr_RegionBilling] as a inner join [MMS].[dbo].tempregionbilling as b" +
          " on a.cspot=b.cspot and a.ccounter=b.ccounter";
                    SqlDb(@upd,
                          new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()));
                }
                else
                {
                    string upd = "UPDATE a   SET a.[cspot] = b.[cspot]" +
                        ",a.[cabonent10] = b.[cabonent]" +
                        ",a.[cconsumer10] =b.[cconsumer]" +
                        ",a.[cspot2] = b.[cspot2]" +
                        ",a.[address1] = b.[address1]" +
                        ",a.[address2] = b.[address2]" +
                        ",a.[ccounter] = b.[ccounter]" +
                        ",a.[ccounter_type] = b.[counter_type]" +
                        ",a.[cstation] = b.[cstation]" +
                        ",a.[nfeader] = b.[nfeader]" +
                        ",a.[feader] = b.[feader]" +
                        ",a.[nsubstation] = b.[nsubstation]" +
                        ",a.[substation] = b.[substation]" +
                        ",a.[MCB_CT] = b.[MCB_CT]" +
                        ",a.[transformer_ratio] = b.[transformer_ratio]" +
                        ",a.[PM] = b.[PM]" +
                        ",a.[nregion] = b.[nregion]" +                       
                        ",a.[ccounter20] = b.[ccounter20]" +
                        ",a.[DateImport] = b.[DateImport]" +
                        ",a.[user_id] =b.[userid]" +
                        "from [MMS].[dbo].[spr_RegionBilling] as a inner join [MMS].[dbo].tempregionbilling as b" +
                        " on a.cspot=b.cspot and a.ccounter=b.ccounter";
                    SqlDb(@upd,
                          new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()));
                
                }
               
            }
            if (dttemp.Rows.Count > 0)
            {
                string str = "INSERT INTO [MMS].[dbo].[spr_RegionBilling] " +
    "([cspot] ,[cspot2],[cabonent10],[cconsumer10],[address1],[address2],[ccounter],[ccounter_type]" +
    ",[cstation],[nfeader],[feader],[nsubstation],[substation],[MCB_CT],[transformer_ratio],[PM],[nregion],[ccounter20]," +
    "[customer_type],[DateImport],[user_id])" +
    "SELECT t.[cspot],t.[cspot2],t.[cabonent],t.[cconsumer],t.[address1],t.[address2],t.[ccounter],t.[counter_type],t.[cstation]" +
    "      ,t.[nfeader],t.[feader],t.[nsubstation],t.[substation],t.[MCB_CT],t.[transformer_ratio],t.[pm],t.[nregion],t.[ccounter20]" +
    "      ,t.[customer_type],t.[dateImport],t.[userid] FROM [MMS].[dbo].[tempregionbilling] t left outer join [MMS].[dbo].spr_RegionBilling s " +
    "  on t.cspot=s.cspot and t.nregion=s.nregion and t.customer_type=s.customer_type where s.cspot is null";
                SqlDb(@str,
                      new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()));
                
            }
            MessageBox.Show("Добавлено " + dttemp.Rows.Count + " новых абонентов. \nОбновлено "+(dt.Rows.Count- dttemp.Rows.Count)+" абонентов.");
            if (prombyt)
            { this.regionBillingViewTableAdapter.Fill(this.mMSDataSet.RegionBillingView, Globals.id_slujbi, 1); }
            else { this.regionBillingViewTableAdapter.Fill(this.mMSDataSet.RegionBillingView, Globals.id_slujbi, 0); }
        }

        private void Import2Billing_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDb(@"delete from tempregionbilling where [nregion]=" + Globals.id_slujbi + ";",
                 new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()));
        }

       
    }
}
