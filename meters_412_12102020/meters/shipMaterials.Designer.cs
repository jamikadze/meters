namespace meters
{
    partial class shipMaterials
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
            this.ViewMonterMaterialsbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.viewMonterMaterialsTableAdapter = new meters.MMSDataSetTableAdapters.ViewMonterMaterialsTableAdapter();
            this.ViewMonterMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonterMaterialsbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonterMaterialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewMonterMaterialsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.counterMaterials.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(661, 438);
            this.reportViewer1.TabIndex = 0;
            // 
            // ViewMonterMaterialsbindingSource1
            // 
            this.ViewMonterMaterialsbindingSource1.DataMember = "ViewMonterMaterials";
            this.ViewMonterMaterialsbindingSource1.DataSource = this.mMSDataSet;
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
            // ViewMonterMaterialsBindingSource
            // 
            this.ViewMonterMaterialsBindingSource.DataMember = "ViewMonterMaterials";
            this.ViewMonterMaterialsBindingSource.DataSource = this.mMSDataSet;
            // 
            // shipMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 438);
            this.Controls.Add(this.reportViewer1);
            this.Name = "shipMaterials";
            this.Text = "shipMaterials";
            this.Load += new System.EventHandler(this.shipMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonterMaterialsbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonterMaterialsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewMonterMaterialsbindingSource1;
        private MMSDataSet mMSDataSet;
        private MMSDataSetTableAdapters.ViewMonterMaterialsTableAdapter viewMonterMaterialsTableAdapter;
        private System.Windows.Forms.BindingSource ViewMonterMaterialsBindingSource;
    }
}