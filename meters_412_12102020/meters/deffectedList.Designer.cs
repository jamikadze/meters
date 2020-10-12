namespace meters
{
    partial class deffectedList
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
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.BS_returnMeterReason = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.BT_deff_return = new DevExpress.XtraEditors.SimpleButton();
            this.mMSDataSet1 = new meters.MMSDataSet();
            this.returnMeterReasonTableAdapter = new meters.MMSDataSetTableAdapters.ReturnMeterReasonTableAdapter();
            this.mETER_MOL_CRPU2TableAdapter = new meters.MMSDataSetTableAdapters.METER_MOL_CRPU2TableAdapter();
            this.BS_METER_MOL_CRPU2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_returnMeterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_METER_MOL_CRPU2)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(12, 21);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_reason", "name_reason", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("status", "status", 40, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("realation", "realation", 52, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEdit1.Properties.DataSource = this.BS_returnMeterReason;
            this.lookUpEdit1.Properties.DisplayMember = "name_reason";
            this.lookUpEdit1.Properties.NullText = "Выберите причину деффекта";
            this.lookUpEdit1.Properties.ValueMember = "id";
            this.lookUpEdit1.Size = new System.Drawing.Size(320, 20);
            this.lookUpEdit1.TabIndex = 0;
            this.lookUpEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lookUpEdit1_Closed);
            // 
            // BS_returnMeterReason
            // 
            this.BS_returnMeterReason.DataMember = "ReturnMeterReason";
            this.BS_returnMeterReason.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BT_deff_return
            // 
            this.BT_deff_return.Appearance.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this.BT_deff_return.Appearance.Options.UseFont = true;
            this.BT_deff_return.Location = new System.Drawing.Point(62, 75);
            this.BT_deff_return.Name = "BT_deff_return";
            this.BT_deff_return.Size = new System.Drawing.Size(217, 35);
            this.BT_deff_return.TabIndex = 2;
            this.BT_deff_return.Text = "Установить причину \r\nвозврата ПУ в ЦРПУ";
            this.BT_deff_return.Click += new System.EventHandler(this.BT_deff_return_Click);
            // 
            // mMSDataSet1
            // 
            this.mMSDataSet1.DataSetName = "MMSDataSet";
            this.mMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnMeterReasonTableAdapter
            // 
            this.returnMeterReasonTableAdapter.ClearBeforeFill = true;
            // 
            // mETER_MOL_CRPU2TableAdapter
            // 
            this.mETER_MOL_CRPU2TableAdapter.ClearBeforeFill = true;
            // 
            // BS_METER_MOL_CRPU2
            // 
            this.BS_METER_MOL_CRPU2.DataMember = "METER_MOL_CRPU2";
            this.BS_METER_MOL_CRPU2.DataSource = this.mMSDataSet1;
            // 
            // deffectedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(344, 127);
            this.Controls.Add(this.BT_deff_return);
            this.Controls.Add(this.lookUpEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "deffectedList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Причина возврата в ЦРПУ";
            this.Load += new System.EventHandler(this.deffectedList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_returnMeterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_METER_MOL_CRPU2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource BS_returnMeterReason;
        private MMSDataSet mMSDataSet;
        private MMSDataSetTableAdapters.ReturnMeterReasonTableAdapter returnMeterReasonTableAdapter;
        private DevExpress.XtraEditors.SimpleButton BT_deff_return;
        private System.Windows.Forms.BindingSource BS_METER_MOL_CRPU2;
        private MMSDataSet mMSDataSet1;
        private MMSDataSetTableAdapters.METER_MOL_CRPU2TableAdapter mETER_MOL_CRPU2TableAdapter;
    }
}