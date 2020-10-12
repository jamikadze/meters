namespace meters
{
    partial class part_meter_add
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
            this.mMSDataSet = new meters.MMSDataSet();
            this.partMeterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partMeterTableAdapter = new meters.MMSDataSetTableAdapters.PartMeterTableAdapter();
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.partMeterGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.historyMeterSimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyMeterSimTableAdapter = new meters.MMSDataSetTableAdapters.HistoryMeterSimTableAdapter();
            this.queriesTableAdapter1 = new meters.MMSDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partMeterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partMeterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyMeterSimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partMeterBindingSource
            // 
            this.partMeterBindingSource.DataMember = "PartMeter";
            this.partMeterBindingSource.DataSource = this.mMSDataSet;
            // 
            // partMeterTableAdapter
            // 
            this.partMeterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessTableAdapter = null;
            this.tableAdapterManager.akt_schetTableAdapter = null;
            this.tableAdapterManager.aktTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocScansTableAdapter = null;
            this.tableAdapterManager.HistoryMeterSimTableAdapter = null;
            this.tableAdapterManager.HistoryMeterTableAdapter = null;
            this.tableAdapterManager.InstalledMeters2TableAdapter = null;
            this.tableAdapterManager.InstalledMetersTableAdapter = null;
            this.tableAdapterManager.mat_aktTableAdapter = null;
            this.tableAdapterManager.mat_rabTableAdapter = null;
            this.tableAdapterManager.MaterialDocs2TableAdapter = null;
            this.tableAdapterManager.MaterialDocsTableAdapter = null;
        //    this.tableAdapterManager.PartMeterTableAdapter = this.partMeterTableAdapter;
            this.tableAdapterManager.rab_akt_id_rabTableAdapter = null;
            this.tableAdapterManager.rab_aktTableAdapter = null;
            this.tableAdapterManager.ShipmentsTableAdapter = null;
            this.tableAdapterManager.SimTableAdapter = null;
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
            this.tableAdapterManager.spr_PredefectsTableAdapter = null;
            this.tableAdapterManager.spr_rabTableAdapter = null;
            this.tableAdapterManager.spr_RegionBillingTableAdapter = null;
            this.tableAdapterManager.spr_ReturnReasonTableAdapter = null;
            this.tableAdapterManager.spr_SimStatusTableAdapter = null;
            this.tableAdapterManager.spr_SlujbaTableAdapter = null;
            this.tableAdapterManager.spr_vidTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = meters.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partMeterGridControl
            // 
            this.partMeterGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.partMeterGridControl.DataSource = this.partMeterBindingSource;
            this.partMeterGridControl.Location = new System.Drawing.Point(12, 40);
            this.partMeterGridControl.MainView = this.gridView1;
            this.partMeterGridControl.Name = "partMeterGridControl";
            this.partMeterGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.partMeterGridControl.Size = new System.Drawing.Size(523, 231);
            this.partMeterGridControl.TabIndex = 1;
            this.partMeterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colPartNo,
            this.colQuantity,
            this.colchek,
            this.colStatus});
            this.gridView1.GridControl = this.partMeterGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colPartNo
            // 
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colchek
            // 
            this.colchek.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colchek.FieldName = "chek";
            this.colchek.Name = "colchek";
            this.colchek.Visible = true;
            this.colchek.VisibleIndex = 0;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // historyMeterSimBindingSource
            // 
            this.historyMeterSimBindingSource.DataMember = "HistoryMeterSim";
            this.historyMeterSimBindingSource.DataSource = this.mMSDataSet;
            // 
            // historyMeterSimTableAdapter
            // 
            this.historyMeterSimTableAdapter.ClearBeforeFill = true;
            // 
            // part_meter_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partMeterGridControl);
            this.Name = "part_meter_add";
            this.Text = "part_meter_add";
            this.Load += new System.EventHandler(this.part_meter_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partMeterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partMeterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyMeterSimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource partMeterBindingSource;
        private MMSDataSetTableAdapters.PartMeterTableAdapter partMeterTableAdapter;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl partMeterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colchek;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource historyMeterSimBindingSource;
        private MMSDataSetTableAdapters.HistoryMeterSimTableAdapter historyMeterSimTableAdapter;
        private MMSDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}