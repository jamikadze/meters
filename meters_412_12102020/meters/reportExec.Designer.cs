namespace meters
{
    partial class reportExec
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewMonterMaterialsBS = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.viewMonterMaterialsTableAdapter = new meters.MMSDataSetTableAdapters.ViewMonterMaterialsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonterMaterialsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewMonterMaterialsBS;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.repExec.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(706, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // ViewMonterMaterialsBS
            // 
            this.ViewMonterMaterialsBS.DataMember = "ViewMonterMaterials";
            this.ViewMonterMaterialsBS.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewMonterMaterialsTableAdapter
            // 
            this.viewMonterMaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // reportExec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 475);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportExec";
            this.Text = "reportExec";
            this.Load += new System.EventHandler(this.reportExec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonterMaterialsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewMonterMaterialsBS;
        private MMSDataSet mMSDataSet;
        private MMSDataSetTableAdapters.ViewMonterMaterialsTableAdapter viewMonterMaterialsTableAdapter;
    }
}