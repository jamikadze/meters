namespace meters
{
    partial class for_Marat
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
            this.plan_grafikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MMSDataSet = new meters.MMSDataSet();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton18 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit5 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit6 = new DevExpress.XtraEditors.DateEdit();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.plan_grafikTableAdapter = new meters.MMSDataSetTableAdapters.plan_grafikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.plan_grafikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // plan_grafikBindingSource
            // 
            this.plan_grafikBindingSource.DataMember = "plan_grafik";
            this.plan_grafikBindingSource.DataSource = this.MMSDataSet;
            // 
            // MMSDataSet
            // 
            this.MMSDataSet.DataSetName = "MMSDataSet";
            this.MMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton17
            // 
            this.simpleButton17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton17.Location = new System.Drawing.Point(804, 41);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(75, 23);
            this.simpleButton17.TabIndex = 47;
            this.simpleButton17.Text = "Сброс";
            // 
            // simpleButton18
            // 
            this.simpleButton18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton18.Location = new System.Drawing.Point(804, 12);
            this.simpleButton18.Name = "simpleButton18";
            this.simpleButton18.Size = new System.Drawing.Size(75, 23);
            this.simpleButton18.TabIndex = 46;
            this.simpleButton18.Text = "Поиск";
            this.simpleButton18.Click += new System.EventHandler(this.simpleButton18_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(628, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(16, 13);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "по:";
            // 
            // dateEdit5
            // 
            this.dateEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit5.EditValue = null;
            this.dateEdit5.Location = new System.Drawing.Point(650, 42);
            this.dateEdit5.Name = "dateEdit5";
            this.dateEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit5.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit5.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit5.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit5.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit5.Size = new System.Drawing.Size(147, 20);
            this.dateEdit5.TabIndex = 44;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(635, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(9, 13);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "c:";
            // 
            // dateEdit6
            // 
            this.dateEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit6.EditValue = null;
            this.dateEdit6.Location = new System.Drawing.Point(650, 15);
            this.dateEdit6.Name = "dateEdit6";
            this.dateEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit6.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit6.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit6.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit6.Size = new System.Drawing.Size(147, 20);
            this.dateEdit6.TabIndex = 42;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.plan_grafikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "meters.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(888, 475);
            this.reportViewer1.TabIndex = 48;
            // 
            // plan_grafikTableAdapter
            // 
            this.plan_grafikTableAdapter.ClearBeforeFill = true;
            // 
            // for_Marat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 556);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.simpleButton17);
            this.Controls.Add(this.simpleButton18);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dateEdit5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dateEdit6);
            this.Name = "for_Marat";
            this.Text = "Отчет по выносу";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.for_Marat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plan_grafikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton17;
        private DevExpress.XtraEditors.SimpleButton simpleButton18;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEdit6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource plan_grafikBindingSource;
        private MMSDataSet MMSDataSet;
        private MMSDataSetTableAdapters.plan_grafikTableAdapter plan_grafikTableAdapter;

    }
}