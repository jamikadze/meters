namespace meters
{
    partial class CRPUreports
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
            this.View_METER_MOLCRPUreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet = new meters.MMSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_METER_MOLCRPUreportTableAdapter = new meters.MMSDataSetTableAdapters.View_METER_MOLCRPUreportTableAdapter();
            this.BS_ReportCRPU = new System.Windows.Forms.BindingSource(this.components);
            this.view_reportCRPUTableAdapter = new meters.MMSDataSetTableAdapters.View_reportCRPUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_METER_MOLCRPUreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ReportCRPU)).BeginInit();
            this.SuspendLayout();
            // 
            // View_METER_MOLCRPUreportBindingSource
            // 
            this.View_METER_MOLCRPUreportBindingSource.DataMember = "View_METER_MOLCRPUreport";
            this.View_METER_MOLCRPUreportBindingSource.DataSource = this.MMSDataSet;
            // 
            // MMSDataSet
            // 
            this.MMSDataSet.DataSetName = "MMSDataSet";
            this.MMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCRPU";
            reportDataSource1.Value = this.View_METER_MOLCRPUreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.r_All_ImportCRPU.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(796, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_METER_MOLCRPUreportTableAdapter
            // 
            this.View_METER_MOLCRPUreportTableAdapter.ClearBeforeFill = true;
            // 
            // BS_ReportCRPU
            // 
            this.BS_ReportCRPU.DataMember = "View_reportCRPU";
            this.BS_ReportCRPU.DataSource = this.MMSDataSet;
            // 
            // view_reportCRPUTableAdapter
            // 
            this.view_reportCRPUTableAdapter.ClearBeforeFill = true;
            // 
            // CRPUreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CRPUreports";
            this.Text = "CRPUreports";
            this.Load += new System.EventHandler(this.CRPUreports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_METER_MOLCRPUreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ReportCRPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_METER_MOLCRPUreportBindingSource;
        private MMSDataSet MMSDataSet;
        private MMSDataSetTableAdapters.View_METER_MOLCRPUreportTableAdapter View_METER_MOLCRPUreportTableAdapter;
        private System.Windows.Forms.BindingSource BS_ReportCRPU;
        private MMSDataSetTableAdapters.View_reportCRPUTableAdapter view_reportCRPUTableAdapter;
    }
}