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
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

namespace meters
{
    public partial class r_NotInstall : DevExpress.XtraEditors.XtraForm
    {
        string manuf = "%" ,part="";
        public r_NotInstall()
        {
            InitializeComponent();
        }
        private void GetDgv()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql;
                if (Globals.id_slujbi != 1)
                {
                    sql = "SELECT sp.Manufacturer, sl.name_slujba, sp.SerialNo" +
                    " FROM   MeterMOLdocs AS m1 INNER JOIN  MeterMOLdocs2 AS m2 ON m1.id = m2.id_MeterMOLdocs INNER JOIN " +
                    "spr_Executor AS exe ON m1.id_Executor_Importer = exe.id INNER JOIN " +
                    "Shipments AS sp ON m2.id_Shipments = sp.id INNER JOIN " +
                    "spr_Slujba AS sl ON exe.id_Slujba = sl.id " +
                    "WHERE  (m1.MeterMOLdocsCancel is null) and (m1.MeterMOLdocsType<>1) and (sp.Manufacturer LIKE @manuf)"+
                    "AND (sp.id_MeterStatus IN (3)) AND (exe.id_Slujba = @idslujba) " + part +
                    "ORDER BY sp.Manufacturer, sl.name_slujba, sp.SerialNo";
                    using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()))
                    {
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            var ManufParam = new SqlParameter("manuf", SqlDbType.NVarChar);
                            var idSlujbaParam = new SqlParameter("idslujba", SqlDbType.Int);
                            ManufParam.Value = manuf;
                            idSlujbaParam.Value = Globals.id_slujbi;
                            command.Parameters.Add(ManufParam);
                            command.Parameters.Add(idSlujbaParam);
                            connection.Open();
                            dt.Load(command.ExecuteReader());
                            connection.Close();
                        }
                    }
                }
                else {sql = "SELECT sp.Manufacturer, sl.name_slujba, sp.SerialNo" +
                    " FROM   MeterMOLdocs AS m1 INNER JOIN  MeterMOLdocs2 AS m2 ON m1.id = m2.id_MeterMOLdocs INNER JOIN " +
                    "spr_Executor AS exe ON m1.id_Executor_Importer = exe.id INNER JOIN " +
                    "Shipments AS sp ON m2.id_Shipments = sp.id INNER JOIN " +
                    "spr_Slujba AS sl ON exe.id_Slujba = sl.id " +
                    "WHERE   (m1.MeterMOLdocsCancel is null) and (m1.MeterMOLdocsType<>1) and  (sp.Manufacturer LIKE @manuf) AND (sp.id_MeterStatus IN (3)) " + part +
                    "ORDER BY sp.Manufacturer, sl.name_slujba, sp.SerialNo";

                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        var ManufParam = new SqlParameter("manuf", SqlDbType.NVarChar);
                        ManufParam.Value = manuf;
                        command.Parameters.Add(ManufParam);
                        connection.Open();
                        dt.Load(command.ExecuteReader());
                        connection.Close();
                    }}
                    }
                        if (dt.Rows.Count > 0)
                        {
                          
                            //toolStripStatusLabel1.Text += dt1.Rows.Count;
                            gridControl1.DataSource = dt;
                            dgv.Columns[0].Caption = "Производитель";
                            dgv.Columns[1].Caption = "Регион";
                            dgv.Columns[2].Caption = "№ счетчика";
                            dgv.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                            
                            dgv.Columns[0].Width = 100;
                            dgv.Columns[1].Width = 150;
                            dgv.Columns[2].Width = 100;

                        }
                        else
                        {
                            // for (int i = 1; i < 17;i++ ) dgv.Columns[i].Dispose();
                            gridControl1.DataSource = null;
                           
                        }
                   
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex); }
        }
        private void cbManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbManuf.SelectedIndex == 0)
                manuf = "%";
            else manuf = cbManuf.Text;
            GetDgv();
        }

        private void r_NotInstall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.partno' table. You can move, or remove it, as needed.
            this.partnoTableAdapter.Fill(this.mMSDataSet.partno);
            cbManuf.SelectedIndex = 0;
        }
    
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!gridControl1.IsPrintingAvailable )
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }


            // Open the Preview window.
            gridControl1.ShowPrintPreview();
        }

        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

            int i = 0;
            foreach (CheckedListBoxItem item in checkedComboBoxEdit1.Properties.Items)
            {

                if (item.CheckState == CheckState.Checked)
                {
                    if (i == 0)
                    {
                        part += " and (part=" + item.Value.ToString();
                    }

                    else
                    {
                        part += " or part=" + item.Value.ToString();
                    }
                    i++;
                }
                if (i == 0)
                { part = ""; }
                else if (checkedComboBoxEdit1.Properties.Items.IndexOf(item) == checkedComboBoxEdit1.Properties.Items.Count - 1)
                { part += ") "; }


            }
            GetDgv();
        }
    }
}