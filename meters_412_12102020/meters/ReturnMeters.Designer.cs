namespace meters
{
    partial class ReturnMeters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nakladnoi_metersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet = new meters.MMSDataSet();
            this.nakladnoi_metersTableAdapter = new meters.MMSDataSetTableAdapters.nakladnoi_metersTableAdapter();
            this.BS_View_METER_MOLCRPU = new System.Windows.Forms.BindingSource(this.components);
            this.view_METER_MOLCRPUTableAdapter = new meters.MMSDataSetTableAdapters.View_METER_MOLCRPUTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_METER_MOLCRPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nakladnoi_metersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_View_METER_MOLCRPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_METER_MOLCRPUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nakladnoi_metersBindingSource
            // 
            this.nakladnoi_metersBindingSource.DataMember = "nakladnoi_meters";
            this.nakladnoi_metersBindingSource.DataSource = this.MMSDataSet;
            // 
            // MMSDataSet
            // 
            this.MMSDataSet.DataSetName = "MMSDataSet";
            this.MMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nakladnoi_metersTableAdapter
            // 
            this.nakladnoi_metersTableAdapter.ClearBeforeFill = true;
            // 
            // BS_View_METER_MOLCRPU
            // 
            this.BS_View_METER_MOLCRPU.DataMember = "View_METER_MOLCRPU";
            this.BS_View_METER_MOLCRPU.DataSource = this.MMSDataSet;
            // 
            // view_METER_MOLCRPUTableAdapter
            // 
            this.view_METER_MOLCRPUTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BS_View_METER_MOLCRPU;
            reportDataSource2.Name = "DataSet2";
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "meters.DefMetCRPU.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(838, 391);
            this.reportViewer2.TabIndex = 0;
            // 
            // View_METER_MOLCRPUBindingSource
            // 
            this.View_METER_MOLCRPUBindingSource.DataMember = "View_METER_MOLCRPU";
            this.View_METER_MOLCRPUBindingSource.DataSource = this.MMSDataSet;
            // 
            // ReturnMeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 391);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReturnMeters";
            this.Text = "ReturnMeters";
            this.Load += new System.EventHandler(this.ReturnMeters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nakladnoi_metersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_View_METER_MOLCRPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_METER_MOLCRPUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nakladnoi_metersBindingSource;
        private MMSDataSet MMSDataSet;
        private MMSDataSetTableAdapters.nakladnoi_metersTableAdapter nakladnoi_metersTableAdapter;
        private System.Windows.Forms.BindingSource BS_View_METER_MOLCRPU;
        private MMSDataSetTableAdapters.View_METER_MOLCRPUTableAdapter view_METER_MOLCRPUTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource View_METER_MOLCRPUBindingSource;
    }
}