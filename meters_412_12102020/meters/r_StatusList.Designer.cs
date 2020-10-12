﻿namespace meters
{
    partial class r_StatusList
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
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbManuf = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.partnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.partnoTableAdapter = new meters.MMSDataSetTableAdapters.partnoTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgv = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExport.Location = new System.Drawing.Point(1066, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 26);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Производитель";
            // 
            // cbManuf
            // 
            this.cbManuf.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbManuf.FormattingEnabled = true;
            this.cbManuf.Items.AddRange(new object[] {
            "Все",
            "Hexing",
            "Sanxing"});
            this.cbManuf.Location = new System.Drawing.Point(119, 17);
            this.cbManuf.Name = "cbManuf";
            this.cbManuf.Size = new System.Drawing.Size(189, 24);
            this.cbManuf.TabIndex = 17;
            this.cbManuf.SelectedIndexChanged += new System.EventHandler(this.cbManuf_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Все",
            "Не привязано(на складе)",
            "Проверено(на складе)",
            "Выдано(не установлено)",
            "Установлено",
            "Дефект до выдачи",
            "Привязано(Готов к выдаче)",
            "Возврат",
            "Дефект  после выдачи",
            "Отвязано",
            "Нет модема",
            "Утеряно(Оплачено мастером)"});
            this.cbStatus.Location = new System.Drawing.Point(396, 17);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 24);
            this.cbStatus.TabIndex = 17;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(341, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Статус";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOk.Location = new System.Drawing.Point(814, 15);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(71, 26);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(703, 19);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DataSource = this.partnoBindingSource;
            this.checkedComboBoxEdit1.Properties.DisplayMember = "Part";
            this.checkedComboBoxEdit1.Properties.ValueMember = "Part";
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(73, 20);
            this.checkedComboBoxEdit1.TabIndex = 23;
            this.checkedComboBoxEdit1.EditValueChanged += new System.EventHandler(this.checkedComboBoxEdit1_EditValueChanged);
            // 
            // partnoBindingSource
            // 
            this.partnoBindingSource.DataMember = "partno";
            this.partnoBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(615, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "№ партии";
            // 
            // partnoTableAdapter
            // 
            this.partnoTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(12, 53);
            this.gridControl1.MainView = this.dgv;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1148, 616);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv});
            // 
            // dgv
            // 
            this.dgv.GridControl = this.gridControl1;
            this.dgv.Name = "dgv";
            this.dgv.OptionsFind.AlwaysVisible = true;
            this.dgv.OptionsView.ShowAutoFilterRow = true;
            this.dgv.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.dgv.OptionsView.ShowFooter = true;
            this.dgv.OptionsView.ShowGroupPanel = false;
            // 
            // r_StatusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 675);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbManuf);
            this.Name = "r_StatusList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по статусам";
            this.Load += new System.EventHandler(this.r_StatusList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbManuf;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private System.Windows.Forms.Label label3;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource partnoBindingSource;
        private MMSDataSetTableAdapters.partnoTableAdapter partnoTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv;
    }
}