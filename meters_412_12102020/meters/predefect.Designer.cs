namespace meters
{
    partial class predefect
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.queriesTableAdapter1 = new meters.MMSDataSetTableAdapters.QueriesTableAdapter();
            this.mmsDataSet1 = new meters.MMSDataSet();
            this.spr_PredefectsTableAdapter1 = new meters.MMSDataSetTableAdapters.spr_PredefectsTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.idColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.defectTypeColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.mmsDataSet2 = new meters.MMSDataSet();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.spr_PredefectsTableAdapter2 = new meters.MMSDataSetTableAdapters.spr_PredefectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mmsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(12, 391);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(162, 35);
            this.simpleButton3.TabIndex = 12;
            this.simpleButton3.Text = "Сменить статус \r\nнового ПУ";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(323, 390);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 35);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Отмена";
            // 
            // mmsDataSet1
            // 
            this.mmsDataSet1.DataSetName = "MMSDataSet";
            this.mmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spr_PredefectsTableAdapter1
            // 
            this.spr_PredefectsTableAdapter1.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.idColumn1,
            this.defectTypeColumn1});
            this.treeList1.DataMember = "spr_Predefects";
            this.treeList1.DataSource = this.mmsDataSet2;
            this.treeList1.KeyFieldName = "id";
            this.treeList1.Location = new System.Drawing.Point(10, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.ParentFieldName = "defectType";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemDateEdit1});
            this.treeList1.Size = new System.Drawing.Size(388, 363);
            this.treeList1.TabIndex = 13;
            this.treeList1.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeList1_BeforeCheckNode);
            this.treeList1.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            // 
            // idColumn1
            // 
            this.idColumn1.Caption = "treeListColumn1";
            this.idColumn1.FieldName = "id";
            this.idColumn1.Name = "idColumn1";
            this.idColumn1.Width = 91;
            // 
            // defectTypeColumn1
            // 
            this.defectTypeColumn1.Caption = "defectType";
            this.defectTypeColumn1.FieldName = "defectType";
            this.defectTypeColumn1.MinWidth = 32;
            this.defectTypeColumn1.Name = "defectTypeColumn1";
            this.defectTypeColumn1.Visible = true;
            this.defectTypeColumn1.VisibleIndex = 0;
            this.defectTypeColumn1.Width = 472;
            // 
            // mmsDataSet2
            // 
            this.mmsDataSet2.DataSetName = "MMSDataSet";
            this.mmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // spr_PredefectsTableAdapter2
            // 
            this.spr_PredefectsTableAdapter2.ClearBeforeFill = true;
            // 
            // predefect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 437);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Name = "predefect";
            this.Text = "predefect";
            this.Load += new System.EventHandler(this.predefect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mmsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private MMSDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private MMSDataSet mmsDataSet1;
        private MMSDataSetTableAdapters.spr_PredefectsTableAdapter spr_PredefectsTableAdapter1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private MMSDataSet mmsDataSet2;
        private MMSDataSetTableAdapters.spr_PredefectsTableAdapter spr_PredefectsTableAdapter2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn idColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn defectTypeColumn1;
    }
}