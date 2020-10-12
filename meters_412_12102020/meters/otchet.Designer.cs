namespace meters
{
    partial class otchet
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mMSDataSet = new meters.MMSDataSet();
            this.os3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.os3TableAdapter = new meters.MMSDataSetTableAdapters.os3TableAdapter();
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.os3_aktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.os3_aktTableAdapter = new meters.MMSDataSetTableAdapters.os3_aktTableAdapter();
            this.spis_matBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spis_matTableAdapter = new meters.MMSDataSetTableAdapters.spis_matTableAdapter();
            this.mat_importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mat_importTableAdapter = new meters.MMSDataSetTableAdapters.mat_importTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.os3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.os3_aktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spis_matBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat_importBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 742);
            this.reportViewer1.TabIndex = 0;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // os3BindingSource
            // 
            this.os3BindingSource.DataMember = "os3";
            this.os3BindingSource.DataSource = this.mMSDataSet;
            // 
            // os3TableAdapter
            // 
            this.os3TableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MeterStatusruTableAdapter = null;
            this.tableAdapterManager.PartMeter_poiskTableAdapter = null;
            this.tableAdapterManager.POC_SNTableAdapter = null;
            this.tableAdapterManager.rab_akt_id_rabTableAdapter = null;
            this.tableAdapterManager.rab_aktTableAdapter = null;
            this.tableAdapterManager.ReturnDeffectMetersTableAdapter = null;
            this.tableAdapterManager.ReturnMeterReasonTableAdapter = null;
            this.tableAdapterManager.Shipments1TableAdapter = null;
            this.tableAdapterManager.ShipmentsTableAdapter = null;
            this.tableAdapterManager.Sim1_update_statusTableAdapter = null;
            this.tableAdapterManager.SimTableAdapter = null;
            this.tableAdapterManager.spentMAT2TableAdapter = null;
            this.tableAdapterManager.SpentMaterials_countTableAdapter = null;
            this.tableAdapterManager.SpentMaterialsTableAdapter = null;
            this.tableAdapterManager.spr_BillingTableAdapter = null;
            this.tableAdapterManager.spr_Executor1TableAdapter = null;
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
            // os3_aktBindingSource
            // 
            this.os3_aktBindingSource.DataMember = "os3_akt";
            this.os3_aktBindingSource.DataSource = this.mMSDataSet;
            // 
            // os3_aktTableAdapter
            // 
            this.os3_aktTableAdapter.ClearBeforeFill = true;
            // 
            // spis_matBindingSource
            // 
            this.spis_matBindingSource.DataMember = "spis_mat";
            this.spis_matBindingSource.DataSource = this.mMSDataSet;
            // 
            // spis_matTableAdapter
            // 
            this.spis_matTableAdapter.ClearBeforeFill = true;
            // 
            // mat_importBindingSource
            // 
            this.mat_importBindingSource.DataMember = "mat_import";
            this.mat_importBindingSource.DataSource = this.mMSDataSet;
            // 
            // mat_importTableAdapter
            // 
            this.mat_importTableAdapter.ClearBeforeFill = true;
            // 
            // otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(795, 742);
            this.Controls.Add(this.reportViewer1);
            this.Name = "otchet";
            this.Text = "otchet";
            this.Load += new System.EventHandler(this.otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.os3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.os3_aktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spis_matBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat_importBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource os3BindingSource;
        private MMSDataSetTableAdapters.os3TableAdapter os3TableAdapter;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource os3_aktBindingSource;
        private MMSDataSetTableAdapters.os3_aktTableAdapter os3_aktTableAdapter;
        private System.Windows.Forms.BindingSource spis_matBindingSource;
        private MMSDataSetTableAdapters.spis_matTableAdapter spis_matTableAdapter;
        private System.Windows.Forms.BindingSource mat_importBindingSource;
        private MMSDataSetTableAdapters.mat_importTableAdapter mat_importTableAdapter;
    }
}