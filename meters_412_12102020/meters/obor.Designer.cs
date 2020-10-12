namespace meters
{
    partial class obor
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colslujbi = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colid_old = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colvid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colid_res = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colid_zavis = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.mmsDataSet11 = new meters.MMSDataSet1();
            this.spr_resTableAdapter1 = new meters.MMSDataSet1TableAdapters.spr_resTableAdapter();
            this.mMSDataSet = new meters.MMSDataSet();
            this.spr_regionbilling_tpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spr_regionbilling_tpTableAdapter = new meters.MMSDataSetTableAdapters.spr_regionbilling_tpTableAdapter();
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colname_slujba1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnregion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colsubstation = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnfeader = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcstation = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcspot = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colcspot2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colccounter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colccounter20 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcustomer_type = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMCB_CT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colccounter_type = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltransformer_ratio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colid1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_regionbilling_tpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colslujbi,
            this.colid_old,
            this.colvid,
            this.colcode,
            this.colid_res,
            this.colid,
            this.colid_zavis});
            this.treeList1.DataMember = "spr_res";
            this.treeList1.DataSource = this.mmsDataSet11;
            this.treeList1.KeyFieldName = "id";
            this.treeList1.Location = new System.Drawing.Point(12, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "id_zavis";
            this.treeList1.Size = new System.Drawing.Size(317, 640);
            this.treeList1.TabIndex = 0;
            this.treeList1.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterFocusNode);
            this.treeList1.CustomFilterDisplayText += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.treeList1_CustomFilterDisplayText);
            // 
            // colslujbi
            // 
            this.colslujbi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colslujbi.AppearanceHeader.Options.UseFont = true;
            this.colslujbi.Caption = "Наименование";
            this.colslujbi.FieldName = "slujbi";
            this.colslujbi.Name = "colslujbi";
            this.colslujbi.Visible = true;
            this.colslujbi.VisibleIndex = 0;
            this.colslujbi.Width = 96;
            // 
            // colid_old
            // 
            this.colid_old.FieldName = "id_old";
            this.colid_old.Name = "colid_old";
            this.colid_old.Width = 96;
            // 
            // colvid
            // 
            this.colvid.FieldName = "vid";
            this.colvid.Name = "colvid";
            this.colvid.Width = 95;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Width = 95;
            // 
            // colid_res
            // 
            this.colid_res.FieldName = "id_res";
            this.colid_res.Name = "colid_res";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_zavis
            // 
            this.colid_zavis.FieldName = "id_zavis";
            this.colid_zavis.Name = "colid_zavis";
            // 
            // mmsDataSet11
            // 
            this.mmsDataSet11.DataSetName = "MMSDataSet1";
            this.mmsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spr_resTableAdapter1
            // 
            this.spr_resTableAdapter1.ClearBeforeFill = true;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spr_regionbilling_tpBindingSource
            // 
            this.spr_regionbilling_tpBindingSource.DataMember = "spr_regionbilling_tp";
            this.spr_regionbilling_tpBindingSource.DataSource = this.mMSDataSet;
            // 
            // spr_regionbilling_tpTableAdapter
            // 
            this.spr_regionbilling_tpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessTableAdapter = null;
            this.tableAdapterManager.akt_schet_countTableAdapter = null;
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
            this.tableAdapterManager.rab_akt_id_rabTableAdapter = null;
            this.tableAdapterManager.rab_aktTableAdapter = null;
            this.tableAdapterManager.Shipments1TableAdapter = null;
            this.tableAdapterManager.ShipmentsTableAdapter = null;
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.spr_regionbilling_tpBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(335, 12);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(1019, 640);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colcspot,
            this.colcspot2,
            this.coladdress1,
            this.coladdress2,
            this.colccounter,
            this.colccounter20,
            this.colcstation,
            this.colnregion,
            this.colcustomer_type,
            this.colMCB_CT,
            this.colccounter_type,
            this.coltransformer_ratio,
            this.colPM,
            this.colnfeader,
            this.colsubstation,
            this.colname_slujba1,
            this.colid1});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsEditForm.PopupEditFormWidth = 6000;
            this.advBandedGridView1.OptionsFind.AlwaysVisible = true;
            this.advBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcustomer_type, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "РЕГИОН";
            this.gridBand1.Columns.Add(this.colname_slujba1);
            this.gridBand1.Columns.Add(this.colnregion);
            this.gridBand1.Columns.Add(this.colsubstation);
            this.gridBand1.Columns.Add(this.colnfeader);
            this.gridBand1.Columns.Add(this.colcstation);
            this.gridBand1.Columns.Add(this.colcspot);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 474;
            // 
            // colname_slujba1
            // 
            this.colname_slujba1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colname_slujba1.AppearanceHeader.Options.UseFont = true;
            this.colname_slujba1.Caption = "Регион";
            this.colname_slujba1.FieldName = "name_slujba";
            this.colname_slujba1.Name = "colname_slujba1";
            this.colname_slujba1.Visible = true;
            this.colname_slujba1.Width = 83;
            // 
            // colnregion
            // 
            this.colnregion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colnregion.AppearanceHeader.Options.UseFont = true;
            this.colnregion.AppearanceHeader.Options.UseTextOptions = true;
            this.colnregion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnregion.Caption = "Регион";
            this.colnregion.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colnregion.FieldName = "nregion";
            this.colnregion.Name = "colnregion";
            this.colnregion.Width = 122;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "name_slujba";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "id";
            // 
            // colsubstation
            // 
            this.colsubstation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colsubstation.AppearanceHeader.Options.UseFont = true;
            this.colsubstation.AppearanceHeader.Options.UseTextOptions = true;
            this.colsubstation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsubstation.Caption = "ПС";
            this.colsubstation.FieldName = "substation";
            this.colsubstation.Name = "colsubstation";
            this.colsubstation.Visible = true;
            this.colsubstation.Width = 127;
            // 
            // colnfeader
            // 
            this.colnfeader.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colnfeader.AppearanceHeader.Options.UseFont = true;
            this.colnfeader.AppearanceHeader.Options.UseTextOptions = true;
            this.colnfeader.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnfeader.Caption = "Фидер";
            this.colnfeader.FieldName = "nfeader";
            this.colnfeader.Name = "colnfeader";
            this.colnfeader.Visible = true;
            this.colnfeader.Width = 62;
            // 
            // colcstation
            // 
            this.colcstation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colcstation.AppearanceHeader.Options.UseFont = true;
            this.colcstation.AppearanceHeader.Options.UseTextOptions = true;
            this.colcstation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcstation.Caption = "ТП";
            this.colcstation.FieldName = "cstation";
            this.colcstation.Name = "colcstation";
            this.colcstation.Visible = true;
            this.colcstation.Width = 68;
            // 
            // colcspot
            // 
            this.colcspot.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colcspot.AppearanceHeader.Options.UseFont = true;
            this.colcspot.AppearanceHeader.Options.UseTextOptions = true;
            this.colcspot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcspot.Caption = "№ ЛС\\Абон";
            this.colcspot.FieldName = "cspot";
            this.colcspot.Name = "colcspot";
            this.colcspot.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colcspot.Visible = true;
            this.colcspot.Width = 134;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "ДАННЫЕ Абонента";
            this.gridBand2.Columns.Add(this.colcspot2);
            this.gridBand2.Columns.Add(this.coladdress1);
            this.gridBand2.Columns.Add(this.coladdress2);
            this.gridBand2.Columns.Add(this.colccounter);
            this.gridBand2.Columns.Add(this.colccounter20);
            this.gridBand2.Columns.Add(this.colcustomer_type);
            this.gridBand2.Columns.Add(this.colMCB_CT);
            this.gridBand2.Columns.Add(this.colccounter_type);
            this.gridBand2.Columns.Add(this.coltransformer_ratio);
            this.gridBand2.Columns.Add(this.colPM);
            this.gridBand2.Columns.Add(this.colid1);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1033;
            // 
            // colcspot2
            // 
            this.colcspot2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colcspot2.AppearanceHeader.Options.UseFont = true;
            this.colcspot2.AppearanceHeader.Options.UseTextOptions = true;
            this.colcspot2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcspot2.Caption = "ФИО";
            this.colcspot2.FieldName = "cspot2";
            this.colcspot2.Name = "colcspot2";
            this.colcspot2.Visible = true;
            this.colcspot2.Width = 213;
            // 
            // coladdress1
            // 
            this.coladdress1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coladdress1.AppearanceHeader.Options.UseFont = true;
            this.coladdress1.AppearanceHeader.Options.UseTextOptions = true;
            this.coladdress1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coladdress1.Caption = "Адрес";
            this.coladdress1.FieldName = "address1";
            this.coladdress1.Name = "coladdress1";
            this.coladdress1.Visible = true;
            this.coladdress1.Width = 216;
            // 
            // coladdress2
            // 
            this.coladdress2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coladdress2.AppearanceHeader.Options.UseFont = true;
            this.coladdress2.AppearanceHeader.Options.UseTextOptions = true;
            this.coladdress2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coladdress2.Caption = "Дом\\кв";
            this.coladdress2.FieldName = "address2";
            this.coladdress2.Name = "coladdress2";
            this.coladdress2.Visible = true;
            this.coladdress2.Width = 94;
            // 
            // colccounter
            // 
            this.colccounter.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colccounter.AppearanceHeader.Options.UseFont = true;
            this.colccounter.AppearanceHeader.Options.UseTextOptions = true;
            this.colccounter.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colccounter.Caption = "№ Старого ПУ";
            this.colccounter.FieldName = "ccounter";
            this.colccounter.Name = "colccounter";
            this.colccounter.Visible = true;
            this.colccounter.Width = 118;
            // 
            // colccounter20
            // 
            this.colccounter20.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colccounter20.AppearanceHeader.Options.UseFont = true;
            this.colccounter20.AppearanceHeader.Options.UseTextOptions = true;
            this.colccounter20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colccounter20.Caption = "Код";
            this.colccounter20.FieldName = "ccounter20";
            this.colccounter20.Name = "colccounter20";
            // 
            // colcustomer_type
            // 
            this.colcustomer_type.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colcustomer_type.AppearanceHeader.Options.UseFont = true;
            this.colcustomer_type.AppearanceHeader.Options.UseTextOptions = true;
            this.colcustomer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcustomer_type.Caption = "Тип Абона";
            this.colcustomer_type.FieldName = "customer_type";
            this.colcustomer_type.Name = "colcustomer_type";
            this.colcustomer_type.Visible = true;
            this.colcustomer_type.Width = 86;
            // 
            // colMCB_CT
            // 
            this.colMCB_CT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMCB_CT.AppearanceHeader.Options.UseFont = true;
            this.colMCB_CT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMCB_CT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMCB_CT.Caption = "Автомат";
            this.colMCB_CT.FieldName = "MCB_CT";
            this.colMCB_CT.Name = "colMCB_CT";
            this.colMCB_CT.Visible = true;
            this.colMCB_CT.Width = 94;
            // 
            // colccounter_type
            // 
            this.colccounter_type.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colccounter_type.AppearanceHeader.Options.UseFont = true;
            this.colccounter_type.AppearanceHeader.Options.UseTextOptions = true;
            this.colccounter_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colccounter_type.Caption = "Тип ПУ";
            this.colccounter_type.FieldName = "ccounter_type";
            this.colccounter_type.Name = "colccounter_type";
            this.colccounter_type.Visible = true;
            this.colccounter_type.Width = 94;
            // 
            // coltransformer_ratio
            // 
            this.coltransformer_ratio.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltransformer_ratio.AppearanceHeader.Options.UseFont = true;
            this.coltransformer_ratio.AppearanceHeader.Options.UseTextOptions = true;
            this.coltransformer_ratio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltransformer_ratio.Caption = "ТТ";
            this.coltransformer_ratio.FieldName = "transformer_ratio";
            this.coltransformer_ratio.Name = "coltransformer_ratio";
            this.coltransformer_ratio.Visible = true;
            this.coltransformer_ratio.Width = 44;
            // 
            // colPM
            // 
            this.colPM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPM.AppearanceHeader.Options.UseFont = true;
            this.colPM.AppearanceHeader.Options.UseTextOptions = true;
            this.colPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPM.Caption = "Мощность";
            this.colPM.FieldName = "PM";
            this.colPM.Name = "colPM";
            this.colPM.Visible = true;
            this.colPM.Width = 74;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.ReadOnly = true;
            this.colid1.Width = 38;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "name_slujba";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "id";
            // 
            // obor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 664);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.treeList1);
            this.Name = "obor";
            this.Text = "obor";
            this.Load += new System.EventHandler(this.obor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_regionbilling_tpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colslujbi;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colid_old;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colvid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcode;
        private MMSDataSet1 mmsDataSet11;
        private MMSDataSet1TableAdapters.spr_resTableAdapter spr_resTableAdapter1;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource spr_regionbilling_tpBindingSource;
        private MMSDataSetTableAdapters.spr_regionbilling_tpTableAdapter spr_regionbilling_tpTableAdapter;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colname_slujba1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnregion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsubstation;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnfeader;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcstation;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcspot;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcspot2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colccounter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colccounter20;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcustomer_type;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMCB_CT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colccounter_type;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltransformer_ratio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colid_res;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colid_zavis;
    }
}