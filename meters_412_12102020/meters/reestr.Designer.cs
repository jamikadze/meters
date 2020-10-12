namespace meters
{
    partial class reestr
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
            this.view_for_reestrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet = new meters.MMSDataSet();
            this.view_for_reestrTableAdapter = new meters.MMSDataSetTableAdapters.view_for_reestrTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view_for_reestrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_for_reestrBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.reestr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(937, 458);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_for_reestrBindingSource
            // 
            this.view_for_reestrBindingSource.DataMember = "view_for_reestr";
            this.view_for_reestrBindingSource.DataSource = this.MMSDataSet;
            // 
            // MMSDataSet
            // 
            this.MMSDataSet.DataSetName = "MMSDataSet";
            this.MMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_for_reestrTableAdapter
            // 
            this.view_for_reestrTableAdapter.ClearBeforeFill = true;
            // 
            // reestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 458);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reestr";
            this.Text = "reestr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reestr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_for_reestrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_for_reestrBindingSource;
        private MMSDataSet MMSDataSet;
        private MMSDataSetTableAdapters.view_for_reestrTableAdapter view_for_reestrTableAdapter;
    }
}