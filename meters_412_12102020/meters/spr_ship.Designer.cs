namespace meters
{
    partial class spr_ship
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.big_sprShipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSerialNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colManufacturer = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSeal_GP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSeal_CRPU = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSeal_Modem = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colid_MeterStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProvider = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSimNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIp = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSimStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPartNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colstrih_box = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colstatus_kol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colusername = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSysDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHistoryType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCheckSklad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.big_sprShipmentsTableAdapter = new meters.MMSDataSetTableAdapters.big_sprShipmentsTableAdapter();
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_sprShipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.big_sprShipmentsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(978, 491);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // big_sprShipmentsBindingSource
            // 
            this.big_sprShipmentsBindingSource.DataMember = "big_sprShipments";
            this.big_sprShipmentsBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand4,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSerialNo,
            this.colManufacturer,
            this.colSeal_GP,
            this.colSeal_CRPU,
            this.colSeal_Modem,
            this.colid_MeterStatus,
            this.colSimNo,
            this.colIp,
            this.colProvider,
            this.colSimStatus,
            this.colSysDate,
            this.colusername,
            this.colHistoryType,
            this.colCheckSklad,
            this.colPartNo,
            this.colid,
            this.colstrih_box,
            this.colQuantity,
            this.colStatus,
            this.colstatus_kol});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsFind.AlwaysVisible = true;
            this.bandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Счетчики";
            this.gridBand1.Columns.Add(this.colSerialNo);
            this.gridBand1.Columns.Add(this.colManufacturer);
            this.gridBand1.Columns.Add(this.colSeal_GP);
            this.gridBand1.Columns.Add(this.colSeal_CRPU);
            this.gridBand1.Columns.Add(this.colSeal_Modem);
            this.gridBand1.Columns.Add(this.colid_MeterStatus);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 375;
            // 
            // colSerialNo
            // 
            this.colSerialNo.FieldName = "SerialNo";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colSerialNo.Visible = true;
            // 
            // colManufacturer
            // 
            this.colManufacturer.FieldName = "Manufacturer";
            this.colManufacturer.Name = "colManufacturer";
            // 
            // colSeal_GP
            // 
            this.colSeal_GP.Caption = "Пломба ГП";
            this.colSeal_GP.FieldName = "Seal_GP";
            this.colSeal_GP.Name = "colSeal_GP";
            this.colSeal_GP.Visible = true;
            // 
            // colSeal_CRPU
            // 
            this.colSeal_CRPU.Caption = "Пломба ЦРПУ";
            this.colSeal_CRPU.FieldName = "Seal_CRPU";
            this.colSeal_CRPU.Name = "colSeal_CRPU";
            this.colSeal_CRPU.Visible = true;
            // 
            // colSeal_Modem
            // 
            this.colSeal_Modem.Caption = "Пломба Модем";
            this.colSeal_Modem.FieldName = "Seal_Modem";
            this.colSeal_Modem.Name = "colSeal_Modem";
            this.colSeal_Modem.Visible = true;
            // 
            // colid_MeterStatus
            // 
            this.colid_MeterStatus.Caption = "Статус ПУ";
            this.colid_MeterStatus.FieldName = "id_MeterStatus";
            this.colid_MeterStatus.Name = "colid_MeterStatus";
            this.colid_MeterStatus.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Симки";
            this.gridBand4.Columns.Add(this.colProvider);
            this.gridBand4.Columns.Add(this.colSimNo);
            this.gridBand4.Columns.Add(this.colIp);
            this.gridBand4.Columns.Add(this.colSimStatus);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 300;
            // 
            // colProvider
            // 
            this.colProvider.FieldName = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.Visible = true;
            // 
            // colSimNo
            // 
            this.colSimNo.Caption = "№СИМ";
            this.colSimNo.FieldName = "SimNo";
            this.colSimNo.Name = "colSimNo";
            this.colSimNo.Visible = true;
            // 
            // colIp
            // 
            this.colIp.FieldName = "Ip";
            this.colIp.Name = "colIp";
            this.colIp.Visible = true;
            // 
            // colSimStatus
            // 
            this.colSimStatus.Caption = "СИМ Статус";
            this.colSimStatus.FieldName = "SimStatus";
            this.colSimStatus.Name = "colSimStatus";
            this.colSimStatus.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Партии";
            this.gridBand2.Columns.Add(this.colPartNo);
            this.gridBand2.Columns.Add(this.colstrih_box);
            this.gridBand2.Columns.Add(this.colQuantity);
            this.gridBand2.Columns.Add(this.colStatus);
            this.gridBand2.Columns.Add(this.colstatus_kol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 375;
            // 
            // colPartNo
            // 
            this.colPartNo.Caption = "Партия";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            // 
            // colstrih_box
            // 
            this.colstrih_box.Caption = "ШтрихКод партии";
            this.colstrih_box.FieldName = "strih_box";
            this.colstrih_box.Name = "colstrih_box";
            this.colstrih_box.Visible = true;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Статус партии";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            // 
            // colstatus_kol
            // 
            this.colstatus_kol.Caption = "статус Кол-во";
            this.colstatus_kol.FieldName = "status_kol";
            this.colstatus_kol.Name = "colstatus_kol";
            this.colstatus_kol.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Привязка";
            this.gridBand3.Columns.Add(this.colusername);
            this.gridBand3.Columns.Add(this.colSysDate);
            this.gridBand3.Columns.Add(this.colid);
            this.gridBand3.Columns.Add(this.colHistoryType);
            this.gridBand3.Columns.Add(this.colCheckSklad);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 398;
            // 
            // colusername
            // 
            this.colusername.Caption = "Пользватель";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            // 
            // colSysDate
            // 
            this.colSysDate.Caption = "Дата";
            this.colSysDate.FieldName = "SysDate";
            this.colSysDate.Name = "colSysDate";
            this.colSysDate.Visible = true;
            // 
            // colid
            // 
            this.colid.Caption = "№Партии";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            // 
            // colHistoryType
            // 
            this.colHistoryType.Caption = "Статус Привязки";
            this.colHistoryType.FieldName = "HistoryType";
            this.colHistoryType.Name = "colHistoryType";
            this.colHistoryType.Visible = true;
            // 
            // colCheckSklad
            // 
            this.colCheckSklad.Caption = "Проверка склада";
            this.colCheckSklad.FieldName = "CheckSklad";
            this.colCheckSklad.Name = "colCheckSklad";
            this.colCheckSklad.Visible = true;
            this.colCheckSklad.Width = 98;
            // 
            // big_sprShipmentsTableAdapter
            // 
            this.big_sprShipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessTableAdapter = null;
            this.tableAdapterManager.akt_schet_countTableAdapter = null;
            this.tableAdapterManager.akt_schet_dostupTableAdapter = null;
            this.tableAdapterManager.akt_schetTableAdapter = null;
            this.tableAdapterManager.aktTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DocScansTableAdapter = null;
            this.tableAdapterManager.HistoryMeterSimTableAdapter = null;
            this.tableAdapterManager.HistoryMeterTableAdapter = null;
            this.tableAdapterManager.InstalledMeters2TableAdapter = null;
            this.tableAdapterManager.InstalledMetersTableAdapter = null;
            this.tableAdapterManager.mat_aktTableAdapter = null;
            this.tableAdapterManager.mat_rabTableAdapter = null;
            this.tableAdapterManager.MaterialDocs2TableAdapter = null;
            this.tableAdapterManager.MaterialDocsTableAdapter = null;
            this.tableAdapterManager.PartMeter_poiskTableAdapter = null;
            this.tableAdapterManager.POC_SNTableAdapter = null;
            this.tableAdapterManager.rab_akt_id_rabTableAdapter = null;
            this.tableAdapterManager.rab_aktTableAdapter = null;
            this.tableAdapterManager.Shipments1TableAdapter = null;
            this.tableAdapterManager.ShipmentsTableAdapter = null;
            this.tableAdapterManager.Sim1_update_statusTableAdapter = null;
            this.tableAdapterManager.SimTableAdapter = null;
            this.tableAdapterManager.spentMAT2TableAdapter = null;
            this.tableAdapterManager.SpentMaterials_countTableAdapter = null;
            this.tableAdapterManager.SpentMaterialsTableAdapter = null;
            this.tableAdapterManager.spr_BillingTableAdapter = null;
            this.tableAdapterManager.spr_fioTableAdapter = null;
            this.tableAdapterManager.spr_Materials1TableAdapter = null;
            this.tableAdapterManager.spr_Materials2TableAdapter = null;
            this.tableAdapterManager.spr_MaterialsTableAdapter = null;
            this.tableAdapterManager.spr_matTableAdapter = null;
            this.tableAdapterManager.spr_MeterStatusTableAdapter = null;
            this.tableAdapterManager.spr_MeterTypeTableAdapter = null;
            this.tableAdapterManager.spr_MeterTypeTalasTableAdapter = null;
            this.tableAdapterManager.spr_PredefectsTableAdapter = null;
            this.tableAdapterManager.spr_rabTableAdapter = null;
            this.tableAdapterManager.spr_RegionBillingTableAdapter = null;
            this.tableAdapterManager.spr_ReturnReasonTableAdapter = null;
            this.tableAdapterManager.spr_SealsTableAdapter = null;
            this.tableAdapterManager.spr_SimStatusTableAdapter = null;
            this.tableAdapterManager.spr_SlujbaTableAdapter = null;
            this.tableAdapterManager.spr_vidTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = meters.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btrefresh
            // 
            this.btrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btrefresh.Location = new System.Drawing.Point(12, 497);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 1;
            this.btrefresh.Text = "Обновить";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClose.Location = new System.Drawing.Point(140, 500);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // spr_ship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 535);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.gridControl1);
            this.Name = "spr_ship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Shipments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.spr_ship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_sprShipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource big_sprShipmentsBindingSource;
        private MMSDataSetTableAdapters.big_sprShipmentsTableAdapter big_sprShipmentsTableAdapter;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSerialNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colManufacturer;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSeal_GP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSeal_CRPU;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSeal_Modem;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid_MeterStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProvider;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSimNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIp;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSimStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPartNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colstrih_box;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colstatus_kol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCheckSklad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSysDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colusername;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHistoryType;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btClose;
    }
}