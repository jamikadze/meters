namespace meters
{
    partial class Reports2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports2));
            this.nakladnoi_metersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet = new meters.MMSDataSet();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nakladnoi_metersTableAdapter = new meters.MMSDataSetTableAdapters.nakladnoi_metersTableAdapter();
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
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nakladnoi_metersBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "meters.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(683, 500);
            this.reportViewer2.TabIndex = 0;
            // 
            // nakladnoi_metersTableAdapter
            // 
            this.nakladnoi_metersTableAdapter.ClearBeforeFill = true;
            // 
            // Reports2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 500);
            this.Controls.Add(this.reportViewer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports2";
            this.Text = "Накладная на счетчики";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nakladnoi_metersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource nakladnoi_metersBindingSource;
        private MMSDataSet MMSDataSet;
        private MMSDataSetTableAdapters.nakladnoi_metersTableAdapter nakladnoi_metersTableAdapter;
    }
}