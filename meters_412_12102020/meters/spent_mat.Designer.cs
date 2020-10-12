namespace meters
{
    partial class spent_mat
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
            this.ostatok_mat_operatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_Materials = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialSort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsum_vidocha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsum_spentmat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colostatok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameExecutor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Slujba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_poluch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ostatok_mat_operatorTableAdapter = new meters.MMSDataSetTableAdapters.ostatok_mat_operatorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostatok_mat_operatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.ostatok_mat_operatorBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(884, 507);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ostatok_mat_operatorBindingSource
            // 
            this.ostatok_mat_operatorBindingSource.DataMember = "ostatok_mat_operator";
            this.ostatok_mat_operatorBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_Materials,
            this.colMaterialSort,
            this.coled,
            this.colsum_vidocha,
            this.colsum_spentmat,
            this.colostatok,
            this.colkol,
            this.colNameExecutor,
            this.colid_Slujba,
            this.colid_poluch});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_Materials
            // 
            this.colid_Materials.FieldName = "id_Materials";
            this.colid_Materials.Name = "colid_Materials";
            // 
            // colMaterialSort
            // 
            this.colMaterialSort.Caption = "Материал";
            this.colMaterialSort.FieldName = "MaterialSort";
            this.colMaterialSort.Name = "colMaterialSort";
            this.colMaterialSort.Visible = true;
            this.colMaterialSort.VisibleIndex = 0;
            this.colMaterialSort.Width = 294;
            // 
            // coled
            // 
            this.coled.Caption = "Ед.изм.";
            this.coled.FieldName = "ed";
            this.coled.Name = "coled";
            this.coled.Visible = true;
            this.coled.VisibleIndex = 1;
            this.coled.Width = 49;
            // 
            // colsum_vidocha
            // 
            this.colsum_vidocha.Caption = "Выдано";
            this.colsum_vidocha.FieldName = "sum_vidocha";
            this.colsum_vidocha.Name = "colsum_vidocha";
            this.colsum_vidocha.Visible = true;
            this.colsum_vidocha.VisibleIndex = 2;
            this.colsum_vidocha.Width = 93;
            // 
            // colsum_spentmat
            // 
            this.colsum_spentmat.Caption = "Использованные";
            this.colsum_spentmat.FieldName = "sum_spentmat";
            this.colsum_spentmat.Name = "colsum_spentmat";
            this.colsum_spentmat.Visible = true;
            this.colsum_spentmat.VisibleIndex = 3;
            this.colsum_spentmat.Width = 95;
            // 
            // colostatok
            // 
            this.colostatok.Caption = "Остаток";
            this.colostatok.FieldName = "ostatok";
            this.colostatok.Name = "colostatok";
            this.colostatok.OptionsColumn.ReadOnly = true;
            this.colostatok.Visible = true;
            this.colostatok.VisibleIndex = 4;
            this.colostatok.Width = 79;
            // 
            // colkol
            // 
            this.colkol.Caption = "Кол-во";
            this.colkol.FieldName = "kol";
            this.colkol.Name = "colkol";
            this.colkol.Visible = true;
            this.colkol.VisibleIndex = 6;
            this.colkol.Width = 98;
            // 
            // colNameExecutor
            // 
            this.colNameExecutor.Caption = "ФИО";
            this.colNameExecutor.FieldName = "NameExecutor";
            this.colNameExecutor.Name = "colNameExecutor";
            this.colNameExecutor.Visible = true;
            this.colNameExecutor.VisibleIndex = 5;
            this.colNameExecutor.Width = 158;
            // 
            // colid_Slujba
            // 
            this.colid_Slujba.FieldName = "id_Slujba";
            this.colid_Slujba.Name = "colid_Slujba";
            // 
            // colid_poluch
            // 
            this.colid_poluch.FieldName = "id_poluch";
            this.colid_poluch.Name = "colid_poluch";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            this.tableAdapterManager.ImportRegionBillingTableAdapter = null;
            this.tableAdapterManager.InstalledMeters2ADDTableAdapter = null;
            this.tableAdapterManager.InstalledMeters2TableAdapter = null;
            this.tableAdapterManager.InstalledMetersADDTableAdapter = null;
            this.tableAdapterManager.InstalledMetersTableAdapter = null;
            this.tableAdapterManager.mat_aktTableAdapter = null;
            this.tableAdapterManager.mat_rabTableAdapter = null;
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
            this.tableAdapterManager.tempregionbillingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = meters.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 525);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Добавить";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ostatok_mat_operatorTableAdapter
            // 
            this.ostatok_mat_operatorTableAdapter.ClearBeforeFill = true;
            // 
            // spent_mat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 572);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "spent_mat";
            this.Text = "spent_mat";
            this.Load += new System.EventHandler(this.spent_mat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostatok_mat_operatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MMSDataSet mMSDataSet;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource ostatok_mat_operatorBindingSource;
        private MMSDataSetTableAdapters.ostatok_mat_operatorTableAdapter ostatok_mat_operatorTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Materials;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialSort;
        private DevExpress.XtraGrid.Columns.GridColumn coled;
        private DevExpress.XtraGrid.Columns.GridColumn colsum_vidocha;
        private DevExpress.XtraGrid.Columns.GridColumn colsum_spentmat;
        private DevExpress.XtraGrid.Columns.GridColumn colostatok;
        private DevExpress.XtraGrid.Columns.GridColumn colkol;
        private DevExpress.XtraGrid.Columns.GridColumn colNameExecutor;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Slujba;
        private DevExpress.XtraGrid.Columns.GridColumn colid_poluch;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}