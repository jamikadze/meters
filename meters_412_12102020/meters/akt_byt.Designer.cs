namespace meters

{
    partial class akt_byt
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
            this.spr_Reg_Billing_for_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet1 = new meters.MMSDataSet1();
            this.spr_Reg_Billing_for_reportTableAdapter = new meters.MMSDataSet1TableAdapters.spr_Reg_Billing_for_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Reg_Billing_for_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spr_Reg_Billing_for_reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.Akt_byt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1032, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // spr_Reg_Billing_for_reportBindingSource
            // 
            this.spr_Reg_Billing_for_reportBindingSource.DataMember = "spr_Reg_Billing_for_report";
            this.spr_Reg_Billing_for_reportBindingSource.DataSource = this.MMSDataSet1;
            // 
            // MMSDataSet1
            // 
            this.MMSDataSet1.DataSetName = "MMSDataSet1";
            this.MMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spr_Reg_Billing_for_reportTableAdapter
            // 
            this.spr_Reg_Billing_for_reportTableAdapter.ClearBeforeFill = true;
            // 
            // akt_byt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 565);
            this.Controls.Add(this.reportViewer1);
            this.Name = "akt_byt";
            this.Text = "akt_byt";
            this.Load += new System.EventHandler(this.akt_byt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr_Reg_Billing_for_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spr_Reg_Billing_for_reportBindingSource;
        private MMSDataSet1 MMSDataSet1;
        private MMSDataSet1TableAdapters.spr_Reg_Billing_for_reportTableAdapter spr_Reg_Billing_for_reportTableAdapter;
    }
}