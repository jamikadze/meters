namespace meters
{
    partial class reportN3
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
            this.nakladnoi_metersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet = new meters.MMSDataSet();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nakladnoi_metersTableAdapter = new meters.MMSDataSetTableAdapters.nakladnoi_metersTableAdapter();
            this.inform_schetTableAdapter1 = new meters.MMSDataSetTableAdapters.inform_schetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnoi_metersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).BeginInit();
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
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nakladnoi_metersBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "meters.Report2.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(745, 599);
            this.reportViewer3.TabIndex = 0;
            // 
            // nakladnoi_metersTableAdapter
            // 
            this.nakladnoi_metersTableAdapter.ClearBeforeFill = true;
            // 
            // inform_schetTableAdapter1
            // 
            this.inform_schetTableAdapter1.ClearBeforeFill = true;
            // 
            // reportN3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 599);
            this.Controls.Add(this.reportViewer3);
            this.Name = "reportN3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладной для выдачи Счетчиков";
            this.Load += new System.EventHandler(this.reportN3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nakladnoi_metersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource nakladnoi_metersBindingSource;
        private MMSDataSet MMSDataSet;
        private MMSDataSetTableAdapters.nakladnoi_metersTableAdapter nakladnoi_metersTableAdapter;
        private MMSDataSetTableAdapters.inform_schetTableAdapter inform_schetTableAdapter1;
    }
}