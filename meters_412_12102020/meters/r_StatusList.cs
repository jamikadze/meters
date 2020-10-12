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
    public partial class r_StatusList : DevExpress.XtraEditors.XtraForm
    {
        string manuf = "%",status="%",part="";
        public r_StatusList()
        {
            InitializeComponent();
        }

        private void r_StatusList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.partno' table. You can move, or remove it, as needed.
            this.partnoTableAdapter.Fill(this.mMSDataSet.partno);
            cbManuf.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            GetDgv();
        }

        private void cbManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbManuf.SelectedIndex == 0)
                manuf = "%";
            else manuf = cbManuf.Text;            
        }
        private void GetDgv()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT distinct [Manufacturer],[MeterStatusru],[SerialNo] ,[Type_Customer],[CustomerCode],[CustomerName],[Address],[Dom_kv] FROM [MMS].[dbo].[Shipments] sp "+
  "left outer join InstalledMeters2 ins2 on id_NewMeter=sp.id  inner join meterstatusru ru on sp.id_MeterStatus=ru.id "+
  "where MeterStatusru like @meterstatus and Manufacturer like @manuf "+part+" order by [MeterStatusru],SerialNo";
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["meters.Properties.Settings.MMSConnectionString"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        var ManufParam = new SqlParameter("manuf", SqlDbType.NVarChar);
                        var MeterStatusParam = new SqlParameter("meterstatus", SqlDbType.NVarChar);
                        ManufParam.Value = manuf;
                        MeterStatusParam.Value = status;
                        command.Parameters.Add(ManufParam);
                        command.Parameters.Add(MeterStatusParam);
                        connection.Open();
                        dt.Load(command.ExecuteReader());
                        connection.Close();
                        if (dt.Rows.Count > 0)
                        {
                            
                            gridControl1.DataSource = dt;
                            dgv.Columns[0].Caption = "Производитель";
                            dgv.Columns[1].Caption = "Статус";
                            dgv.Columns[2].Caption = "№ счетчика";
                            dgv.Columns[3].Caption = "Тип абонента";
                            dgv.Columns[4].Caption = "Лиц./счет";
                            dgv.Columns[5].Caption = "Ф.И.О.";
                            dgv.Columns[6].Caption = "Адрес";
                            dgv.Columns[7].Caption = "Дом/кв";
                            dgv.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;

                            dgv.Columns[0].Width = 100;
                            dgv.Columns[1].Width = 160;
                            dgv.Columns[2].Width = 100;
                            dgv.Columns[3].Width = 100;
                            dgv.Columns[4].Width = 150;
                            dgv.Columns[5].Width = 150;
                            dgv.Columns[6].Width = 170;
                            dgv.Columns[7].Width = 100;

                        }
                        else
                        {
                            
                            gridControl1.DataSource = dt;
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex); }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 0)
                status = "%";
            else status = cbStatus.Text;            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GetDgv();
        }
       
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!gridControl1.IsPrintingAvailable)
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
                { part += ")"; }


            } 
             GetDgv();
        }
    }
}