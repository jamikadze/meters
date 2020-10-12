namespace meters
{
    partial class spr_rab
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
            this.mat_rabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mat_rabTableAdapter = new meters.MMSDataSetTableAdapters.mat_rabTableAdapter();
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.spr_Materials2TableAdapter = new meters.MMSDataSetTableAdapters.spr_Materials2TableAdapter();
            this.spr_rabTableAdapter = new meters.MMSDataSetTableAdapters.spr_rabTableAdapter();
            this.spr_rabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.coled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltr_zatr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkoef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colmat = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spr_Materials2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coled1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colkol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcena = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colb_schet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colid_rab = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colid_slujbi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colid1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.queriesTableAdapter1 = new meters.MMSDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat_rabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Materials2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mat_rabBindingSource
            // 
            this.mat_rabBindingSource.DataMember = "mat_rab";
            this.mat_rabBindingSource.DataSource = this.mMSDataSet;
            // 
            // mat_rabTableAdapter
            // 
            this.mat_rabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessTableAdapter = null;
            this.tableAdapterManager.akt_schet_countTableAdapter = null;
            this.tableAdapterManager.akt_schet_dostupTableAdapter = null;
            this.tableAdapterManager.akt_schetTableAdapter = null;
            this.tableAdapterManager.aktTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocScansTableAdapter = null;
            this.tableAdapterManager.HistoryMeterSimTableAdapter = null;
            this.tableAdapterManager.HistoryMeterTableAdapter = null;
            this.tableAdapterManager.ImportRegionBillingTableAdapter = null;
            this.tableAdapterManager.InstalledMeters2ADDTableAdapter = null;
            this.tableAdapterManager.InstalledMeters2TableAdapter = null;
            this.tableAdapterManager.InstalledMetersADDTableAdapter = null;
            this.tableAdapterManager.InstalledMetersTableAdapter = null;
            this.tableAdapterManager.mat_aktTableAdapter = null;
            this.tableAdapterManager.mat_rabTableAdapter = this.mat_rabTableAdapter;
            this.tableAdapterManager.MaterialDocs2TableAdapter = null;
            this.tableAdapterManager.MaterialDocsTableAdapter = null;
            this.tableAdapterManager.PartMeter_poiskTableAdapter = null;
            this.tableAdapterManager.POC_SNTableAdapter = null;
            this.tableAdapterManager.rab_akt_id_rabTableAdapter = null;
            this.tableAdapterManager.rab_aktTableAdapter = null;
            this.tableAdapterManager.ReturnDeffectMetersTableAdapter = null;
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
            this.tableAdapterManager.spr_Materials2TableAdapter = this.spr_Materials2TableAdapter;
            this.tableAdapterManager.spr_MaterialsTableAdapter = null;
            this.tableAdapterManager.spr_matTableAdapter = null;
            this.tableAdapterManager.spr_MeterStatusTableAdapter = null;
            this.tableAdapterManager.spr_MeterTypeTableAdapter = null;
            this.tableAdapterManager.spr_MeterTypeTalasTableAdapter = null;
            this.tableAdapterManager.spr_PredefectsTableAdapter = null;
            this.tableAdapterManager.spr_rabTableAdapter = this.spr_rabTableAdapter;
            this.tableAdapterManager.spr_RegionBillingTableAdapter = null;
            this.tableAdapterManager.spr_ReturnReasonTableAdapter = null;
            this.tableAdapterManager.spr_SealsTableAdapter = null;
            this.tableAdapterManager.spr_SimStatusTableAdapter = null;
            this.tableAdapterManager.spr_SlujbaTableAdapter = null;
            this.tableAdapterManager.spr_vidTableAdapter = null;
            this.tableAdapterManager.tempregionbillingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = meters.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spr_Materials2TableAdapter
            // 
            this.spr_Materials2TableAdapter.ClearBeforeFill = true;
            // 
            // spr_rabTableAdapter
            // 
            this.spr_rabTableAdapter.ClearBeforeFill = true;
            // 
            // spr_rabBindingSource
            // 
            this.spr_rabBindingSource.DataMember = "spr_rab";
            this.spr_rabBindingSource.DataSource = this.mMSDataSet;
            this.spr_rabBindingSource.CurrentItemChanged += new System.EventHandler(this.spr_rabBindingSource_CurrentItemChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.spr_rabBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(718, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkod,
            this.colrab,
            this.coled,
            this.coltr_zatr,
            this.colkoef,
            this.coldel,
            this.colid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colkod
            // 
            this.colkod.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colkod.AppearanceHeader.Options.UseFont = true;
            this.colkod.AppearanceHeader.Options.UseTextOptions = true;
            this.colkod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkod.Caption = "Код";
            this.colkod.FieldName = "kod";
            this.colkod.Name = "colkod";
            this.colkod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colkod.Visible = true;
            this.colkod.VisibleIndex = 0;
            this.colkod.Width = 109;
            // 
            // colrab
            // 
            this.colrab.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colrab.AppearanceHeader.Options.UseFont = true;
            this.colrab.AppearanceHeader.Options.UseTextOptions = true;
            this.colrab.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrab.Caption = "Наименование";
            this.colrab.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colrab.FieldName = "rab";
            this.colrab.Name = "colrab";
            this.colrab.Visible = true;
            this.colrab.VisibleIndex = 1;
            this.colrab.Width = 637;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // coled
            // 
            this.coled.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coled.AppearanceHeader.Options.UseFont = true;
            this.coled.AppearanceHeader.Options.UseTextOptions = true;
            this.coled.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled.Caption = "Ед";
            this.coled.FieldName = "ed";
            this.coled.Name = "coled";
            this.coled.Visible = true;
            this.coled.VisibleIndex = 2;
            this.coled.Width = 109;
            // 
            // coltr_zatr
            // 
            this.coltr_zatr.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltr_zatr.AppearanceHeader.Options.UseFont = true;
            this.coltr_zatr.AppearanceHeader.Options.UseTextOptions = true;
            this.coltr_zatr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltr_zatr.Caption = "Труд.затраты";
            this.coltr_zatr.FieldName = "tr_zatr";
            this.coltr_zatr.Name = "coltr_zatr";
            this.coltr_zatr.Visible = true;
            this.coltr_zatr.VisibleIndex = 3;
            this.coltr_zatr.Width = 109;
            // 
            // colkoef
            // 
            this.colkoef.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colkoef.AppearanceHeader.Options.UseFont = true;
            this.colkoef.AppearanceHeader.Options.UseTextOptions = true;
            this.colkoef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkoef.Caption = "Коэф.";
            this.colkoef.FieldName = "koef";
            this.colkoef.Name = "colkoef";
            this.colkoef.Visible = true;
            this.colkoef.VisibleIndex = 4;
            this.colkoef.Width = 112;
            // 
            // coldel
            // 
            this.coldel.FieldName = "del";
            this.coldel.Name = "coldel";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.mat_rabBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(12, 390);
            this.gridControl2.MainView = this.advBandedGridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl2.Size = new System.Drawing.Size(718, 229);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colmat,
            this.coled1,
            this.colkol,
            this.colcena,
            this.colb_schet,
            this.colid_rab,
            this.colid_slujbi,
            this.colid1});
            this.advBandedGridView1.GridControl = this.gridControl2;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.advBandedGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.advBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Материалы";
            this.gridBand1.Columns.Add(this.colmat);
            this.gridBand1.Columns.Add(this.coled1);
            this.gridBand1.Columns.Add(this.colkol);
            this.gridBand1.Columns.Add(this.colcena);
            this.gridBand1.Columns.Add(this.colb_schet);
            this.gridBand1.Columns.Add(this.colid_rab);
            this.gridBand1.Columns.Add(this.colid_slujbi);
            this.gridBand1.Columns.Add(this.colid1);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 700;
            // 
            // colmat
            // 
            this.colmat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmat.AppearanceHeader.Options.UseFont = true;
            this.colmat.AppearanceHeader.Options.UseTextOptions = true;
            this.colmat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmat.Caption = "Наименование";
            this.colmat.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colmat.FieldName = "mat";
            this.colmat.Name = "colmat";
            this.colmat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colmat.Visible = true;
            this.colmat.Width = 438;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaterialSort", "Наименование"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit", "Ед"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cena", "Цена")});
            this.repositoryItemLookUpEdit1.DataSource = this.spr_Materials2BindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "MaterialSort";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "id";
            this.repositoryItemLookUpEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repositoryItemLookUpEdit1_Closed);
            // 
            // spr_Materials2BindingSource
            // 
            this.spr_Materials2BindingSource.DataMember = "spr_Materials2";
            this.spr_Materials2BindingSource.DataSource = this.mMSDataSet;
            // 
            // coled1
            // 
            this.coled1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coled1.AppearanceHeader.Options.UseFont = true;
            this.coled1.AppearanceHeader.Options.UseTextOptions = true;
            this.coled1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coled1.Caption = "Ед";
            this.coled1.FieldName = "ed";
            this.coled1.Name = "coled1";
            this.coled1.Visible = true;
            this.coled1.Width = 87;
            // 
            // colkol
            // 
            this.colkol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colkol.AppearanceHeader.Options.UseFont = true;
            this.colkol.AppearanceHeader.Options.UseTextOptions = true;
            this.colkol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkol.Caption = "Кол-во";
            this.colkol.FieldName = "kol";
            this.colkol.Name = "colkol";
            this.colkol.Visible = true;
            this.colkol.Width = 87;
            // 
            // colcena
            // 
            this.colcena.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colcena.AppearanceHeader.Options.UseFont = true;
            this.colcena.AppearanceHeader.Options.UseTextOptions = true;
            this.colcena.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcena.Caption = "Цена";
            this.colcena.FieldName = "cena";
            this.colcena.Name = "colcena";
            this.colcena.Visible = true;
            this.colcena.Width = 88;
            // 
            // colb_schet
            // 
            this.colb_schet.FieldName = "b_schet";
            this.colb_schet.Name = "colb_schet";
            // 
            // colid_rab
            // 
            this.colid_rab.FieldName = "id_rab";
            this.colid_rab.Name = "colid_rab";
            // 
            // colid_slujbi
            // 
            this.colid_slujbi.FieldName = "id_slujbi";
            this.colid_slujbi.Name = "colid_slujbi";
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 358);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(109, 24);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Сохранить";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(125, 624);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 24);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Сохранить";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(12, 624);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(109, 24);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Удалить";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // spr_rab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(767, 658);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "spr_rab";
            this.Text = "Справочник работ";
            this.Load += new System.EventHandler(this.spr_rab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat_rabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_rabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Materials2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource mat_rabBindingSource;
        private MMSDataSetTableAdapters.mat_rabTableAdapter mat_rabTableAdapter;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MMSDataSetTableAdapters.spr_rabTableAdapter spr_rabTableAdapter;
        private System.Windows.Forms.BindingSource spr_rabBindingSource;
        private MMSDataSetTableAdapters.spr_Materials2TableAdapter spr_Materials2TableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colkod;
        private DevExpress.XtraGrid.Columns.GridColumn colrab;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coled;
        private DevExpress.XtraGrid.Columns.GridColumn coltr_zatr;
        private DevExpress.XtraGrid.Columns.GridColumn colkoef;
        private DevExpress.XtraGrid.Columns.GridColumn coldel;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colmat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coled1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colkol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcena;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colb_schet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid_rab;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid_slujbi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid1;
        private System.Windows.Forms.BindingSource spr_Materials2BindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private MMSDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}