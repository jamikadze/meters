namespace meters
{
    partial class historyMeter
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
            this.historyMeterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Shipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.shipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid_MeterStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spr_MeterStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSysDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Sim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.simBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyMeterTableAdapter = new meters.MMSDataSetTableAdapters.HistoryMeterTableAdapter();
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.shipmentsTableAdapter = new meters.MMSDataSetTableAdapters.ShipmentsTableAdapter();
            this.simTableAdapter = new meters.MMSDataSetTableAdapters.SimTableAdapter();
            this.spr_MeterStatusTableAdapter = new meters.MMSDataSetTableAdapters.spr_MeterStatusTableAdapter();
            this.usersTableAdapter = new meters.MMSDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyMeterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_MeterStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.historyMeterBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4});
            this.gridControl1.Size = new System.Drawing.Size(860, 497);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // historyMeterBindingSource
            // 
            this.historyMeterBindingSource.DataMember = "HistoryMeter";
            this.historyMeterBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_Shipments,
            this.colid_MeterStatus,
            this.colSysDate,
            this.colid_Sim,
            this.colid_user});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colid_Shipments
            // 
            this.colid_Shipments.Caption = "Счетчик";
            this.colid_Shipments.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colid_Shipments.FieldName = "id_Shipments";
            this.colid_Shipments.Name = "colid_Shipments";
            this.colid_Shipments.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colid_Shipments.Visible = true;
            this.colid_Shipments.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SerialNo", "Счетчик")});
            this.repositoryItemLookUpEdit1.DataSource = this.shipmentsBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "SerialNo";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "id";
            // 
            // shipmentsBindingSource
            // 
            this.shipmentsBindingSource.DataMember = "Shipments";
            this.shipmentsBindingSource.DataSource = this.mMSDataSet;
            // 
            // colid_MeterStatus
            // 
            this.colid_MeterStatus.Caption = "Статус";
            this.colid_MeterStatus.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colid_MeterStatus.FieldName = "id_MeterStatus";
            this.colid_MeterStatus.Name = "colid_MeterStatus";
            this.colid_MeterStatus.Visible = true;
            this.colid_MeterStatus.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MeterStatus", "Статус")});
            this.repositoryItemLookUpEdit2.DataSource = this.spr_MeterStatusBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "MeterStatus";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "id";
            // 
            // spr_MeterStatusBindingSource
            // 
            this.spr_MeterStatusBindingSource.DataMember = "spr_MeterStatus";
            this.spr_MeterStatusBindingSource.DataSource = this.mMSDataSet;
            // 
            // colSysDate
            // 
            this.colSysDate.Caption = "Дата";
            this.colSysDate.FieldName = "SysDate";
            this.colSysDate.Name = "colSysDate";
            this.colSysDate.Visible = true;
            this.colSysDate.VisibleIndex = 2;
            // 
            // colid_Sim
            // 
            this.colid_Sim.Caption = "№Сим";
            this.colid_Sim.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colid_Sim.FieldName = "id_Sim";
            this.colid_Sim.Name = "colid_Sim";
            this.colid_Sim.Visible = true;
            this.colid_Sim.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SimNo", "СимНомер"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ip", "IP")});
            this.repositoryItemLookUpEdit3.DataSource = this.simBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "SimNo";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "id";
            // 
            // simBindingSource
            // 
            this.simBindingSource.DataMember = "Sim";
            this.simBindingSource.DataSource = this.mMSDataSet;
            // 
            // colid_user
            // 
            this.colid_user.Caption = "Пользователь";
            this.colid_user.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.Visible = true;
            this.colid_user.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("username", "Пользователь"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("first_last_name", "ФИО"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_slujba", "Служба")});
            this.repositoryItemLookUpEdit4.DataSource = this.usersBindingSource;
            this.repositoryItemLookUpEdit4.DisplayMember = "first_last_name";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.ValueMember = "id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.mMSDataSet;
            // 
            // historyMeterTableAdapter
            // 
            this.historyMeterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessTableAdapter = null;
            this.tableAdapterManager.aktTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocScansTableAdapter = null;
            this.tableAdapterManager.HistoryMeterSimTableAdapter = null;
            this.tableAdapterManager.HistoryMeterTableAdapter = this.historyMeterTableAdapter;
            this.tableAdapterManager.InstalledMeters2TableAdapter = null;
            this.tableAdapterManager.InstalledMetersTableAdapter = null;
            this.tableAdapterManager.mat_aktTableAdapter = null;
            this.tableAdapterManager.mat_rabTableAdapter = null;
            this.tableAdapterManager.MaterialDocs2TableAdapter = null;
            this.tableAdapterManager.MaterialDocsTableAdapter = null;
          //  this.tableAdapterManager.PartMeterTableAdapter = null;
            this.tableAdapterManager.rab_akt_id_rabTableAdapter = null;
            this.tableAdapterManager.rab_aktTableAdapter = null;
            this.tableAdapterManager.ShipmentsTableAdapter = this.shipmentsTableAdapter;
            this.tableAdapterManager.SimTableAdapter = this.simTableAdapter;
            this.tableAdapterManager.spr_BillingTableAdapter = null;
            this.tableAdapterManager.spr_fioTableAdapter = null;
            this.tableAdapterManager.spr_Materials1TableAdapter = null;
            this.tableAdapterManager.spr_Materials2TableAdapter = null;
            this.tableAdapterManager.spr_MaterialsTableAdapter = null;
            this.tableAdapterManager.spr_matTableAdapter = null;
            this.tableAdapterManager.spr_MeterStatusTableAdapter = this.spr_MeterStatusTableAdapter;
            this.tableAdapterManager.spr_MeterTypeTableAdapter = null;
            this.tableAdapterManager.spr_PredefectsTableAdapter = null;
            this.tableAdapterManager.spr_rabTableAdapter = null;
            this.tableAdapterManager.spr_RegionBillingTableAdapter = null;
            this.tableAdapterManager.spr_ReturnReasonTableAdapter = null;
            this.tableAdapterManager.spr_SimStatusTableAdapter = null;
            this.tableAdapterManager.spr_SlujbaTableAdapter = null;
            this.tableAdapterManager.spr_vidTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = meters.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shipmentsTableAdapter
            // 
            this.shipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // simTableAdapter
            // 
            this.simTableAdapter.ClearBeforeFill = true;
            // 
            // spr_MeterStatusTableAdapter
            // 
            this.spr_MeterStatusTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // historyMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 502);
            this.Controls.Add(this.gridControl1);
            this.Name = "historyMeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История Счетчиков";
            this.Load += new System.EventHandler(this.historyMeter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyMeterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_MeterStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource historyMeterBindingSource;
        private MMSDataSetTableAdapters.HistoryMeterTableAdapter historyMeterTableAdapter;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Shipments;
        private DevExpress.XtraGrid.Columns.GridColumn colid_MeterStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSysDate;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Sim;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private MMSDataSetTableAdapters.ShipmentsTableAdapter shipmentsTableAdapter;
        private System.Windows.Forms.BindingSource shipmentsBindingSource;
        private MMSDataSetTableAdapters.SimTableAdapter simTableAdapter;
        private System.Windows.Forms.BindingSource simBindingSource;
        private MMSDataSetTableAdapters.spr_MeterStatusTableAdapter spr_MeterStatusTableAdapter;
        private System.Windows.Forms.BindingSource spr_MeterStatusBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MMSDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}