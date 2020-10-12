namespace meters
{
    partial class r_CountStatus
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
            this.rbyRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManufacturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_slujba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvydano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colust = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colne_ust = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcrpu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colopl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colspis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsgorel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cb = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.rbyStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStatus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManufacturer1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeterStatusru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.r_byRegionTableAdapter = new meters.MMSDataSetTableAdapters.r_byRegionTableAdapter();
            this.r_byStockTableAdapter = new meters.MMSDataSetTableAdapters.r_byStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbyRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbyStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.rbyRegionBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 20);
            this.gridControl1.MainView = this.gvMain;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemComboBox2});
            this.gridControl1.Size = new System.Drawing.Size(747, 551);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain,
            this.gridView1});
            // 
            // rbyRegionBindingSource
            // 
            this.rbyRegionBindingSource.DataMember = "r_byRegion";
            this.rbyRegionBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManufacturer,
            this.colname_slujba,
            this.colvydano,
            this.colust,
            this.colne_ust,
            this.colcrpu,
            this.colopl,
            this.colspis,
            this.colsgorel});
            this.gvMain.GridControl = this.gridControl1;
            this.gvMain.Name = "gvMain";
            this.gvMain.OptionsBehavior.Editable = false;
            this.gvMain.OptionsFind.AlwaysVisible = true;
            this.gvMain.OptionsSelection.MultiSelect = true;
            this.gvMain.OptionsView.ShowAutoFilterRow = true;
            this.gvMain.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gvMain.OptionsView.ShowFooter = true;
            this.gvMain.OptionsView.ShowGroupPanel = false;
            // 
            // colManufacturer
            // 
            this.colManufacturer.Caption = "Производитель";
            this.colManufacturer.FieldName = "Manufacturer";
            this.colManufacturer.Name = "colManufacturer";
            this.colManufacturer.Visible = true;
            this.colManufacturer.VisibleIndex = 0;
            this.colManufacturer.Width = 274;
            // 
            // colname_slujba
            // 
            this.colname_slujba.Caption = "РЭС";
            this.colname_slujba.FieldName = "name_slujba";
            this.colname_slujba.Name = "colname_slujba";
            this.colname_slujba.Visible = true;
            this.colname_slujba.VisibleIndex = 1;
            this.colname_slujba.Width = 354;
            // 
            // colvydano
            // 
            this.colvydano.Caption = "Выдано";
            this.colvydano.FieldName = "colvydano";
            this.colvydano.Name = "colvydano";
            this.colvydano.OptionsColumn.ReadOnly = true;
            this.colvydano.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colvydano.UnboundExpression = "[ne_ust] + [opl] + [sgorel] + [spis]+[ust]+[crpu]";
            this.colvydano.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colvydano.Visible = true;
            this.colvydano.VisibleIndex = 2;
            this.colvydano.Width = 177;
            // 
            // colust
            // 
            this.colust.Caption = "Установлено";
            this.colust.FieldName = "ust";
            this.colust.Name = "colust";
            this.colust.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colust.Visible = true;
            this.colust.VisibleIndex = 3;
            this.colust.Width = 145;
            // 
            // colne_ust
            // 
            this.colne_ust.Caption = "Не установлено";
            this.colne_ust.FieldName = "ne_ust";
            this.colne_ust.Name = "colne_ust";
            this.colne_ust.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colne_ust.Visible = true;
            this.colne_ust.VisibleIndex = 4;
            this.colne_ust.Width = 145;
            // 
            // colcrpu
            // 
            this.colcrpu.Caption = "ЦРПУ";
            this.colcrpu.FieldName = "crpu";
            this.colcrpu.Name = "colcrpu";
            this.colcrpu.OptionsColumn.ReadOnly = true;
            this.colcrpu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colcrpu.Visible = true;
            this.colcrpu.VisibleIndex = 5;
            this.colcrpu.Width = 93;
            // 
            // colopl
            // 
            this.colopl.Caption = "Оплачено";
            this.colopl.FieldName = "opl";
            this.colopl.Name = "colopl";
            this.colopl.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colopl.Visible = true;
            this.colopl.VisibleIndex = 6;
            this.colopl.Width = 145;
            // 
            // colspis
            // 
            this.colspis.Caption = "Списанные";
            this.colspis.FieldName = "spis";
            this.colspis.Name = "colspis";
            this.colspis.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colspis.Visible = true;
            this.colspis.VisibleIndex = 7;
            this.colspis.Width = 145;
            // 
            // colsgorel
            // 
            this.colsgorel.Caption = "Сгоревшие";
            this.colsgorel.FieldName = "sgorel";
            this.colsgorel.Name = "colsgorel";
            this.colsgorel.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colsgorel.Visible = true;
            this.colsgorel.VisibleIndex = 8;
            this.colsgorel.Width = 154;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("region", "Районы")});
            this.repositoryItemLookUpEdit1.DisplayMember = "region";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "region";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("note", "Примечания")});
            this.repositoryItemLookUpEdit2.DisplayMember = "note";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "note";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cb);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1232, 576);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Китайские ПУ";
            // 
            // cb
            // 
            this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "1-Sanxing(38905)",
            "2-Hexing(20000)",
            "3-Sanxing(20000)",
            "4-Sanxing(5000)",
            "5-HexingPLC(4130)"});
            this.cb.Location = new System.Drawing.Point(500, 34);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(162, 21);
            this.cb.TabIndex = 17;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPrint.Location = new System.Drawing.Point(668, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 27);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Печать";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.rbyStockBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(758, 20);
            this.gridControl2.MainView = this.gvStatus;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4,
            this.repositoryItemComboBox1});
            this.gridControl2.Size = new System.Drawing.Size(469, 551);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStatus,
            this.gridView3});
            // 
            // rbyStockBindingSource
            // 
            this.rbyStockBindingSource.DataMember = "r_byStock";
            this.rbyStockBindingSource.DataSource = this.mMSDataSet;
            // 
            // gvStatus
            // 
            this.gvStatus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManufacturer1,
            this.colMeterStatusru,
            this.colkol});
            this.gvStatus.GridControl = this.gridControl2;
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.OptionsBehavior.Editable = false;
            this.gvStatus.OptionsFind.AlwaysVisible = true;
            this.gvStatus.OptionsSelection.MultiSelect = true;
            this.gvStatus.OptionsView.ShowAutoFilterRow = true;
            this.gvStatus.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gvStatus.OptionsView.ShowFooter = true;
            this.gvStatus.OptionsView.ShowGroupPanel = false;
            // 
            // colManufacturer1
            // 
            this.colManufacturer1.Caption = "Производитель";
            this.colManufacturer1.FieldName = "Manufacturer";
            this.colManufacturer1.Name = "colManufacturer1";
            this.colManufacturer1.Visible = true;
            this.colManufacturer1.VisibleIndex = 0;
            this.colManufacturer1.Width = 141;
            // 
            // colMeterStatusru
            // 
            this.colMeterStatusru.Caption = "Статус";
            this.colMeterStatusru.FieldName = "MeterStatusru";
            this.colMeterStatusru.Name = "colMeterStatusru";
            this.colMeterStatusru.Visible = true;
            this.colMeterStatusru.VisibleIndex = 1;
            this.colMeterStatusru.Width = 241;
            // 
            // colkol
            // 
            this.colkol.Caption = "Количество";
            this.colkol.FieldName = "kol";
            this.colkol.Name = "colkol";
            this.colkol.OptionsColumn.ReadOnly = true;
            this.colkol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colkol.Visible = true;
            this.colkol.VisibleIndex = 2;
            this.colkol.Width = 102;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("region", "Районы")});
            this.repositoryItemLookUpEdit3.DisplayMember = "region";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "region";
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("note", "Примечания")});
            this.repositoryItemLookUpEdit4.DisplayMember = "note";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.NullText = "";
            this.repositoryItemLookUpEdit4.ValueMember = "note";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            // 
            // r_byRegionTableAdapter
            // 
            this.r_byRegionTableAdapter.ClearBeforeFill = true;
            // 
            // r_byStockTableAdapter
            // 
            this.r_byStockTableAdapter.ClearBeforeFill = true;
            // 
            // r_CountStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 576);
            this.Controls.Add(this.groupControl1);
            this.Name = "r_CountStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Количество ПУ по статусу";
            this.Load += new System.EventHandler(this.r_CountStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbyRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbyStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturer;
        private DevExpress.XtraGrid.Columns.GridColumn colname_slujba;
        private DevExpress.XtraGrid.Columns.GridColumn colvydano;
        private DevExpress.XtraGrid.Columns.GridColumn colcrpu;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturer1;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterStatusru;
        private DevExpress.XtraGrid.Columns.GridColumn colkol;        
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource rbyRegionBindingSource;
        private MMSDataSet mMSDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colust;
        private DevExpress.XtraGrid.Columns.GridColumn colne_ust;
        private DevExpress.XtraGrid.Columns.GridColumn colopl;
        private DevExpress.XtraGrid.Columns.GridColumn colspis;
        private DevExpress.XtraGrid.Columns.GridColumn colsgorel;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.BindingSource rbyStockBindingSource;
        private MMSDataSetTableAdapters.r_byRegionTableAdapter r_byRegionTableAdapter;
        private MMSDataSetTableAdapters.r_byStockTableAdapter r_byStockTableAdapter;

    }
}