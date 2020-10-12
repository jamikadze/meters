namespace meters
{
    partial class montaj
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
            this.bsmaterials = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.spr_MaterialsTableAdapter = new meters.MMSDataSetTableAdapters.spr_MaterialsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNametDoc = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.datalabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.namemasterlabel = new System.Windows.Forms.Label();
            this.tdoclabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cspotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cspot2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccounterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccounter20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nregionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCBCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccountertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transformerratioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsregion = new System.Windows.Forms.BindingSource(this.components);
            this.spr_RegionBillingTableAdapter = new meters.MMSDataSetTableAdapters.spr_RegionBillingTableAdapter();
            this.btpechat = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.btpoisktp = new System.Windows.Forms.Button();
            this.tbTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsmaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregion)).BeginInit();
            this.SuspendLayout();
            // 
            // bsmaterials
            // 
            this.bsmaterials.DataMember = "spr_Materials";
            this.bsmaterials.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spr_MaterialsTableAdapter
            // 
            this.spr_MaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "fioUser";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(161, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Мастер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(161, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Наименование";
            // 
            // textBoxNametDoc
            // 
            this.textBoxNametDoc.Location = new System.Drawing.Point(262, 47);
            this.textBoxNametDoc.Name = "textBoxNametDoc";
            this.textBoxNametDoc.Size = new System.Drawing.Size(185, 20);
            this.textBoxNametDoc.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(466, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "загрузить шаблон";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Список абонентов на установку ПУ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(566, 92);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 10;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(433, 381);
            this.dataGridView2.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(466, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datalabel
            // 
            this.datalabel.AutoSize = true;
            this.datalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datalabel.Location = new System.Drawing.Point(9, 38);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(41, 13);
            this.datalabel.TabIndex = 29;
            this.datalabel.Text = "Дата ";
            this.datalabel.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(466, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "сохр.как шаблон";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // namemasterlabel
            // 
            this.namemasterlabel.AutoSize = true;
            this.namemasterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namemasterlabel.Location = new System.Drawing.Point(161, 8);
            this.namemasterlabel.Name = "namemasterlabel";
            this.namemasterlabel.Size = new System.Drawing.Size(64, 13);
            this.namemasterlabel.TabIndex = 27;
            this.namemasterlabel.Text = "Инженер:";
            // 
            // tdoclabel
            // 
            this.tdoclabel.AutoSize = true;
            this.tdoclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tdoclabel.Location = new System.Drawing.Point(9, 8);
            this.tdoclabel.Name = "tdoclabel";
            this.tdoclabel.Size = new System.Drawing.Size(82, 13);
            this.tdoclabel.TabIndex = 26;
            this.tdoclabel.Text = "Документ №";
            this.tdoclabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Абоненты на установку ПУ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cspotDataGridViewTextBoxColumn,
            this.cspot2DataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.ccounterDataGridViewTextBoxColumn,
            this.ccounter20DataGridViewTextBoxColumn,
            this.cstationDataGridViewTextBoxColumn,
            this.nregionDataGridViewTextBoxColumn,
            this.customertypeDataGridViewTextBoxColumn,
            this.mCBCTDataGridViewTextBoxColumn,
            this.ccountertypeDataGridViewTextBoxColumn,
            this.transformerratioDataGridViewTextBoxColumn,
            this.pMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsregion;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(377, 381);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseDoubleClick);
            // 
            // cspotDataGridViewTextBoxColumn
            // 
            this.cspotDataGridViewTextBoxColumn.DataPropertyName = "cspot";
            this.cspotDataGridViewTextBoxColumn.HeaderText = "cspot";
            this.cspotDataGridViewTextBoxColumn.Name = "cspotDataGridViewTextBoxColumn";
            this.cspotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cspot2DataGridViewTextBoxColumn
            // 
            this.cspot2DataGridViewTextBoxColumn.DataPropertyName = "cspot2";
            this.cspot2DataGridViewTextBoxColumn.HeaderText = "cspot2";
            this.cspot2DataGridViewTextBoxColumn.Name = "cspot2DataGridViewTextBoxColumn";
            this.cspot2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            this.address1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccounterDataGridViewTextBoxColumn
            // 
            this.ccounterDataGridViewTextBoxColumn.DataPropertyName = "ccounter";
            this.ccounterDataGridViewTextBoxColumn.HeaderText = "ccounter";
            this.ccounterDataGridViewTextBoxColumn.Name = "ccounterDataGridViewTextBoxColumn";
            this.ccounterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccounter20DataGridViewTextBoxColumn
            // 
            this.ccounter20DataGridViewTextBoxColumn.DataPropertyName = "ccounter20";
            this.ccounter20DataGridViewTextBoxColumn.HeaderText = "ccounter20";
            this.ccounter20DataGridViewTextBoxColumn.Name = "ccounter20DataGridViewTextBoxColumn";
            this.ccounter20DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cstationDataGridViewTextBoxColumn
            // 
            this.cstationDataGridViewTextBoxColumn.DataPropertyName = "cstation";
            this.cstationDataGridViewTextBoxColumn.HeaderText = "cstation";
            this.cstationDataGridViewTextBoxColumn.Name = "cstationDataGridViewTextBoxColumn";
            this.cstationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nregionDataGridViewTextBoxColumn
            // 
            this.nregionDataGridViewTextBoxColumn.DataPropertyName = "nregion";
            this.nregionDataGridViewTextBoxColumn.HeaderText = "nregion";
            this.nregionDataGridViewTextBoxColumn.Name = "nregionDataGridViewTextBoxColumn";
            this.nregionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customertypeDataGridViewTextBoxColumn
            // 
            this.customertypeDataGridViewTextBoxColumn.DataPropertyName = "customer_type";
            this.customertypeDataGridViewTextBoxColumn.HeaderText = "customer_type";
            this.customertypeDataGridViewTextBoxColumn.Name = "customertypeDataGridViewTextBoxColumn";
            this.customertypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mCBCTDataGridViewTextBoxColumn
            // 
            this.mCBCTDataGridViewTextBoxColumn.DataPropertyName = "MCB_CT";
            this.mCBCTDataGridViewTextBoxColumn.HeaderText = "MCB_CT";
            this.mCBCTDataGridViewTextBoxColumn.Name = "mCBCTDataGridViewTextBoxColumn";
            this.mCBCTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccountertypeDataGridViewTextBoxColumn
            // 
            this.ccountertypeDataGridViewTextBoxColumn.DataPropertyName = "ccounter_type";
            this.ccountertypeDataGridViewTextBoxColumn.HeaderText = "ccounter_type";
            this.ccountertypeDataGridViewTextBoxColumn.Name = "ccountertypeDataGridViewTextBoxColumn";
            this.ccountertypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transformerratioDataGridViewTextBoxColumn
            // 
            this.transformerratioDataGridViewTextBoxColumn.DataPropertyName = "transformer_ratio";
            this.transformerratioDataGridViewTextBoxColumn.HeaderText = "transformer_ratio";
            this.transformerratioDataGridViewTextBoxColumn.Name = "transformerratioDataGridViewTextBoxColumn";
            this.transformerratioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pMDataGridViewTextBoxColumn
            // 
            this.pMDataGridViewTextBoxColumn.DataPropertyName = "PM";
            this.pMDataGridViewTextBoxColumn.HeaderText = "PM";
            this.pMDataGridViewTextBoxColumn.Name = "pMDataGridViewTextBoxColumn";
            this.pMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsregion
            // 
            this.bsregion.DataMember = "spr_RegionBilling";
            this.bsregion.DataSource = this.mMSDataSet;
            // 
            // spr_RegionBillingTableAdapter
            // 
            this.spr_RegionBillingTableAdapter.ClearBeforeFill = true;
            // 
            // btpechat
            // 
            this.btpechat.Location = new System.Drawing.Point(761, 491);
            this.btpechat.Name = "btpechat";
            this.btpechat.Size = new System.Drawing.Size(100, 23);
            this.btpechat.TabIndex = 39;
            this.btpechat.Text = "Печать";
            this.btpechat.UseVisualStyleBackColor = true;
            this.btpechat.Click += new System.EventHandler(this.button4_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(889, 491);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(100, 23);
            this.btclose.TabIndex = 39;
            this.btclose.Text = "Закрыть";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btpoisktp
            // 
            this.btpoisktp.Location = new System.Drawing.Point(262, 498);
            this.btpoisktp.Name = "btpoisktp";
            this.btpoisktp.Size = new System.Drawing.Size(75, 23);
            this.btpoisktp.TabIndex = 40;
            this.btpoisktp.Text = "Найти";
            this.btpoisktp.UseVisualStyleBackColor = true;
            this.btpoisktp.Click += new System.EventHandler(this.btpoisktp_Click);
            // 
            // tbTP
            // 
            this.tbTP.Location = new System.Drawing.Point(101, 501);
            this.tbTP.Name = "tbTP";
            this.tbTP.Size = new System.Drawing.Size(140, 20);
            this.tbTP.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Поиск по ТП";
            // 
            // montaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTP);
            this.Controls.Add(this.btpoisktp);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btpechat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNametDoc);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datalabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.namemasterlabel);
            this.Controls.Add(this.tdoclabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "montaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "montaj";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.montaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsmaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsmaterials;
        private MMSDataSet mMSDataSet;
        private MMSDataSetTableAdapters.spr_MaterialsTableAdapter spr_MaterialsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNametDoc;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label namemasterlabel;
        private System.Windows.Forms.Label tdoclabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsregion;
        private MMSDataSetTableAdapters.spr_RegionBillingTableAdapter spr_RegionBillingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cspotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cspot2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccounterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccounter20DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nregionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCBCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccountertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transformerratioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btpechat;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btpoisktp;
        private System.Windows.Forms.TextBox tbTP;
        private System.Windows.Forms.Label label5;

    }
}