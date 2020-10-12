namespace meters
{
    partial class authentifacation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authentifacation));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxPass = new DevExpress.XtraEditors.TextEdit();
            this.textBoxLogin = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.mMSDataSet = new meters.MMSDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new meters.MMSDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new meters.MMSDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(91, 109);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(92, 21);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "OK";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(35, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Пароль";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(4, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Пользователь";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPass.Location = new System.Drawing.Point(80, 83);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Properties.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(194, 20);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyDown);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.Location = new System.Drawing.Point(80, 53);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(194, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(189, 109);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 21);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Отмена";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(248, 32);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Такого пользователя не существует \r\n           или пароль не верен!";
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.mMSDataSet;
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
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // authentifacation
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 136);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.Name = "authentifacation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.authentifacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textBoxPass;
        private DevExpress.XtraEditors.TextEdit textBoxLogin;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MMSDataSet mMSDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MMSDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}