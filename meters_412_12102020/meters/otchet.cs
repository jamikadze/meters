using Microsoft.Reporting.WinForms;
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
    public partial class otchet : DevExpress.XtraEditors.XtraForm
    {
        public otchet()
        {
            InitializeComponent();
        }

        private void otchet_Load(object sender, EventArgs e)
        {
            try
            {
                if (Globals.y == 1)
                {
                    this.Text = "Отчет ОС-3";
                    this.os3TableAdapter.Fill(this.mMSDataSet.os3, Globals.id_akt);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.akt_report". При необходимости она может быть перемещена или удалена.
                    this.os3_aktTableAdapter.Fill(this.mMSDataSet.os3_akt, Globals.id_akt);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.smeta_report". При необходимости она может быть перемещена или удалена.
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    reportDataSource1.Name = "os3";
                    reportDataSource1.Value = this.mMSDataSet.os3;
                    reportDataSource2.Name = "os3_akt";
                    reportDataSource2.Value = this.mMSDataSet.os3_akt;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                    string sm = ((DataRowView)os3_aktBindingSource.Current).Row["sm"].ToString();



                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.oc3.rdlc";
                    this.reportViewer1.Location = new System.Drawing.Point(0, -1);
                    this.reportViewer1.Name = "reportViewer1";
                    this.reportViewer1.Size = new System.Drawing.Size(785, 715);
                    this.reportViewer1.TabIndex = 0;
                    ReportParameter parameter1 = new ReportParameter("sm", sm);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { parameter1 });
                    this.reportViewer1.RefreshReport();
                }

                if (Globals.y == 2)
                {
                    this.Text = "Списание материалов";
                    this.mat_importTableAdapter.Fill(this.mMSDataSet.mat_import, Globals.id_akt);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.akt_report". При необходимости она может быть перемещена или удалена.
                    this.os3_aktTableAdapter.Fill(this.mMSDataSet.os3_akt, Globals.id_akt);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.smeta_report". При необходимости она может быть перемещена или удалена.
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    reportDataSource1.Name = "mat_import";
                    reportDataSource1.Value = this.mMSDataSet.mat_import;
                    reportDataSource2.Name = "os3_akt";
                    reportDataSource2.Value = this.mMSDataSet.os3_akt;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                    //	this.reportViewer1.LocalReport.ReportEmbeddedResource = "ECounters.Forms.Report2.rdlc";
                    string sm = ((DataRowView)os3_aktBindingSource.Current).Row["sm"].ToString();
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.sp_mat.rdlc";
                    this.reportViewer1.Location = new System.Drawing.Point(0, -1);
                    this.reportViewer1.Name = "reportViewer1";
                    this.reportViewer1.Size = new System.Drawing.Size(785, 715);
                    this.reportViewer1.TabIndex = 0;
                    ReportParameter parameter1 = new ReportParameter("sm", sm);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { parameter1 });
                    this.reportViewer1.RefreshReport();
                }

                if (Globals.y == 3)
                {
                    this.Text = "Списание материалов по РЭС";
                    this.mat_importTableAdapter.FillBy(this.mMSDataSet.mat_import, Globals.Date_n,Globals.Date_k,Globals.id_slujbi);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.akt_report". При необходимости она может быть перемещена или удалена.
                    this.os3_aktTableAdapter.FillBy(this.mMSDataSet.os3_akt, Globals.Date_n, Globals.Date_k, Globals.id_slujbi);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.smeta_report". При необходимости она может быть перемещена или удалена.
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    reportDataSource1.Name = "mat_import";
                    reportDataSource1.Value = this.mMSDataSet.mat_import;
                    reportDataSource2.Name = "os3_akt";
                    reportDataSource2.Value = this.mMSDataSet.os3_akt;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                    //	this.reportViewer1.LocalReport.ReportEmbeddedResource = "ECounters.Forms.Report2.rdlc";
                    string sm = "";
                    if (os3_aktBindingSource.Count > 0)
                    {
                        os3_aktBindingSource.MoveFirst();
                        for (int i = 0; i < os3_aktBindingSource.Count; i++)
                        {
                            os3_aktBindingSource.Position = i;
                            sm += ((DataRowView)os3_aktBindingSource.Current).Row["sm"].ToString() + ";";
                            
                        }
                          
                    }


                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.sp_mat_all.rdlc";
                    this.reportViewer1.Location = new System.Drawing.Point(0, -1);
                    this.reportViewer1.Name = "reportViewer1";
                    this.reportViewer1.Size = new System.Drawing.Size(785, 715);
                    this.reportViewer1.TabIndex = 0;
                    ReportParameter parameter1 = new ReportParameter("sm", sm);
                    
                    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { parameter1 });
                   

                    this.reportViewer1.RefreshReport();
                }

                if (Globals.y == 4)
                {
                    this.Text = "Отчет ОС-3 по РЭС";
                    this.os3TableAdapter.FillBy(this.mMSDataSet.os3, Globals.Date_n, Globals.Date_k, Globals.id_slujbi);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.akt_report". При необходимости она может быть перемещена или удалена.
                    this.os3_aktTableAdapter.FillBy(this.mMSDataSet.os3_akt, Globals.Date_n, Globals.Date_k, Globals.id_slujbi);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDS.smeta_report". При необходимости она может быть перемещена или удалена.
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    reportDataSource1.Name = "os3";
                    reportDataSource1.Value = this.mMSDataSet.os3;
                    reportDataSource2.Name = "os3_akt";
                    reportDataSource2.Value = this.mMSDataSet.os3_akt;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                    string sm = "";
                    if (os3_aktBindingSource.Count > 0)
                    {
                        os3_aktBindingSource.MoveFirst();
                        for (int i = 0; i < os3_aktBindingSource.Count; i++)
                        {
                            os3_aktBindingSource.Position = i;
                            sm += ((DataRowView)os3_aktBindingSource.Current).Row["sm"].ToString() + ";";

                        }

                    }


                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.oc3_all.rdlc";
                    this.reportViewer1.Location = new System.Drawing.Point(0, -1);
                    this.reportViewer1.Name = "reportViewer1";
                    this.reportViewer1.Size = new System.Drawing.Size(785, 715);
                    this.reportViewer1.TabIndex = 0;
                    ReportParameter parameter1 = new ReportParameter("sm", sm);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { parameter1 });
                    this.reportViewer1.RefreshReport();
                }
            }
            catch { }
        }

     

     
      
    }
}
