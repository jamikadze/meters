namespace meters
{
    partial class r_Parts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(r_Parts));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hmsshipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSysDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrih_box = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIcc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSimStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSimNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeterStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeal_GP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeal_CRPU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeal_Modem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSend_Config = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ship = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_issue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameExecutor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_slujba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_slujba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_doc_issue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_MeterStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_MeterType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.hms_shipTableAdapter = new meters.MMSDataSetTableAdapters.Hms_shipTableAdapter();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmsshipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.hmsshipBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 75);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1378, 498);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hmsshipBindingSource
            // 
            this.hmsshipBindingSource.DataMember = "Hms_ship";
            this.hmsshipBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSysDate,
            this.colPartNo,
            this.colstrih_box,
            this.colProvider,
            this.colIcc,
            this.colSimStatus,
            this.colIp,
            this.colSimNo,
            this.colSerialNo,
            this.colMeterStatus,
            this.colManufacturer,
            this.colSeal_GP,
            this.colSeal_CRPU,
            this.colSeal_Modem,
            this.colSend_Config,
            this.colPart,
            this.colid_ship,
            this.colDate_issue,
            this.colNameExecutor,
            this.colname_slujba,
            this.colid_slujba,
            this.colid_doc_issue,
            this.colid_MeterStatus,
            this.colid_MeterType});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSysDate
            // 
            this.colSysDate.Caption = "Дата привязки";
            this.colSysDate.FieldName = "SysDate";
            this.colSysDate.Name = "colSysDate";
            this.colSysDate.Visible = true;
            this.colSysDate.VisibleIndex = 0;
            // 
            // colPartNo
            // 
            this.colPartNo.Caption = "№ партии";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 1;
            // 
            // colstrih_box
            // 
            this.colstrih_box.Caption = "Штрихкод коробки";
            this.colstrih_box.FieldName = "strih_box";
            this.colstrih_box.Name = "colstrih_box";
            this.colstrih_box.Visible = true;
            this.colstrih_box.VisibleIndex = 2;
            // 
            // colProvider
            // 
            this.colProvider.Caption = "Провайдер";
            this.colProvider.FieldName = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.Visible = true;
            this.colProvider.VisibleIndex = 3;
            // 
            // colIcc
            // 
            this.colIcc.FieldName = "Icc";
            this.colIcc.Name = "colIcc";
            this.colIcc.Visible = true;
            this.colIcc.VisibleIndex = 4;
            // 
            // colSimStatus
            // 
            this.colSimStatus.Caption = "Статус Сим";
            this.colSimStatus.FieldName = "SimStatus";
            this.colSimStatus.Name = "colSimStatus";
            this.colSimStatus.Visible = true;
            this.colSimStatus.VisibleIndex = 5;
            // 
            // colIp
            // 
            this.colIp.FieldName = "Ip";
            this.colIp.Name = "colIp";
            this.colIp.Visible = true;
            this.colIp.VisibleIndex = 6;
            // 
            // colSimNo
            // 
            this.colSimNo.Caption = "№ Сим";
            this.colSimNo.FieldName = "SimNo1";
            this.colSimNo.Name = "colSimNo";
            this.colSimNo.Visible = true;
            this.colSimNo.VisibleIndex = 7;
            // 
            // colSerialNo
            // 
            this.colSerialNo.Caption = "№ счетчика";
            this.colSerialNo.FieldName = "SerialNo";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colSerialNo.Visible = true;
            this.colSerialNo.VisibleIndex = 8;
            // 
            // colMeterStatus
            // 
            this.colMeterStatus.Caption = "Статус сч.";
            this.colMeterStatus.FieldName = "MeterStatus";
            this.colMeterStatus.Name = "colMeterStatus";
            this.colMeterStatus.Visible = true;
            this.colMeterStatus.VisibleIndex = 9;
            // 
            // colManufacturer
            // 
            this.colManufacturer.Caption = "Производитель";
            this.colManufacturer.FieldName = "Manufacturer";
            this.colManufacturer.Name = "colManufacturer";
            this.colManufacturer.Visible = true;
            this.colManufacturer.VisibleIndex = 10;
            // 
            // colSeal_GP
            // 
            this.colSeal_GP.Caption = "Пломба ГП";
            this.colSeal_GP.FieldName = "Seal_GP";
            this.colSeal_GP.Name = "colSeal_GP";
            this.colSeal_GP.Visible = true;
            this.colSeal_GP.VisibleIndex = 11;
            // 
            // colSeal_CRPU
            // 
            this.colSeal_CRPU.Caption = "Пломба СРПУ";
            this.colSeal_CRPU.FieldName = "Seal_CRPU";
            this.colSeal_CRPU.Name = "colSeal_CRPU";
            this.colSeal_CRPU.Visible = true;
            this.colSeal_CRPU.VisibleIndex = 12;
            // 
            // colSeal_Modem
            // 
            this.colSeal_Modem.Caption = "Модем";
            this.colSeal_Modem.FieldName = "Seal_Modem";
            this.colSeal_Modem.Name = "colSeal_Modem";
            this.colSeal_Modem.Visible = true;
            this.colSeal_Modem.VisibleIndex = 13;
            // 
            // colSend_Config
            // 
            this.colSend_Config.FieldName = "Send_Config";
            this.colSend_Config.Name = "colSend_Config";
            // 
            // colPart
            // 
            this.colPart.Caption = "№ партии";
            this.colPart.FieldName = "Part";
            this.colPart.Name = "colPart";
            this.colPart.Visible = true;
            this.colPart.VisibleIndex = 14;
            // 
            // colid_ship
            // 
            this.colid_ship.FieldName = "id_ship";
            this.colid_ship.Name = "colid_ship";
            // 
            // colDate_issue
            // 
            this.colDate_issue.Caption = "Дата";
            this.colDate_issue.FieldName = "Date_issue";
            this.colDate_issue.Name = "colDate_issue";
            this.colDate_issue.Visible = true;
            this.colDate_issue.VisibleIndex = 15;
            // 
            // colNameExecutor
            // 
            this.colNameExecutor.Caption = "Ф.И.О.";
            this.colNameExecutor.FieldName = "NameExecutor";
            this.colNameExecutor.Name = "colNameExecutor";
            this.colNameExecutor.Visible = true;
            this.colNameExecutor.VisibleIndex = 16;
            // 
            // colname_slujba
            // 
            this.colname_slujba.Caption = "Регион";
            this.colname_slujba.FieldName = "name_slujba";
            this.colname_slujba.Name = "colname_slujba";
            this.colname_slujba.Visible = true;
            this.colname_slujba.VisibleIndex = 17;
            // 
            // colid_slujba
            // 
            this.colid_slujba.Caption = "Код региона";
            this.colid_slujba.FieldName = "id_slujba1";
            this.colid_slujba.Name = "colid_slujba";
            this.colid_slujba.Visible = true;
            this.colid_slujba.VisibleIndex = 18;
            // 
            // colid_doc_issue
            // 
            this.colid_doc_issue.Caption = "№ документа";
            this.colid_doc_issue.FieldName = "id_doc_issue1";
            this.colid_doc_issue.Name = "colid_doc_issue";
            this.colid_doc_issue.Visible = true;
            this.colid_doc_issue.VisibleIndex = 19;
            // 
            // colid_MeterStatus
            // 
            this.colid_MeterStatus.FieldName = "id_MeterStatus";
            this.colid_MeterStatus.Name = "colid_MeterStatus";
            // 
            // colid_MeterType
            // 
            this.colid_MeterType.FieldName = "id_MeterType";
            this.colid_MeterType.Name = "colid_MeterType";
            // 
            // mMSDataSetBindingSource
            // 
            this.mMSDataSetBindingSource.DataSource = this.mMSDataSet;
            this.mMSDataSetBindingSource.Position = 0;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(33, 32);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 21);
            this.dtp1.TabIndex = 1;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(281, 32);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 21);
            this.dtp2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(5, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "с";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(252, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "по";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(487, 32);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // hms_shipTableAdapter
            // 
            this.hms_shipTableAdapter.ClearBeforeFill = true;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(537, 84);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(34, 33);
            this.pictureEdit1.TabIndex = 47;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // r_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 585);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.gridControl1);
            this.Name = "r_Parts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по статусам ПУ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.r_Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmsshipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource mMSDataSetBindingSource;
        private MMSDataSet mMSDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colSysDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colstrih_box;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colIcc;
        private DevExpress.XtraGrid.Columns.GridColumn colSimStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIp;
        private DevExpress.XtraGrid.Columns.GridColumn colSimNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_MeterType;
        private DevExpress.XtraGrid.Columns.GridColumn colid_MeterStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn colSeal_GP;
        private DevExpress.XtraGrid.Columns.GridColumn colSeal_CRPU;
        private DevExpress.XtraGrid.Columns.GridColumn colSeal_Modem;
        private DevExpress.XtraGrid.Columns.GridColumn colSend_Config;
        private DevExpress.XtraGrid.Columns.GridColumn colPart;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ship;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_issue;
        private DevExpress.XtraGrid.Columns.GridColumn colNameExecutor;
        private DevExpress.XtraGrid.Columns.GridColumn colname_slujba;
        private DevExpress.XtraGrid.Columns.GridColumn colid_slujba;
        private DevExpress.XtraGrid.Columns.GridColumn colid_doc_issue;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private System.Windows.Forms.BindingSource hmsshipBindingSource;
        private MMSDataSetTableAdapters.Hms_shipTableAdapter hms_shipTableAdapter;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}