namespace meters
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.nakladnoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet = new meters.MMSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nakladnoiTableAdapter = new meters.MMSDataSetTableAdapters.nakladnoiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nakladnoiBindingSource
            // 
            this.nakladnoiBindingSource.DataMember = "nakladnoi";
            this.nakladnoiBindingSource.DataSource = this.MMSDataSet;
            // 
            // MMSDataSet
            // 
            this.MMSDataSet.DataSetName = "MMSDataSet";
            this.MMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nakladnoiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(716, 548);
            this.reportViewer1.TabIndex = 0;
            // 
            // nakladnoiTableAdapter
            // 
            this.nakladnoiTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 548);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "Накладная на материалы";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nakladnoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nakladnoiBindingSource;
        private MMSDataSet MMSDataSet;
        private MMSDataSetTableAdapters.nakladnoiTableAdapter nakladnoiTableAdapter;
    }
}