using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace meters
{
    public partial class Main_corrector : DevExpress.XtraEditors.XtraForm
    {
        int id_Shipments=0;
        int? id_meter;
        int id_Kabel;
        int id_Shit;
        int id_Avtomat;
        int id_type_old_Meter;
        int id_Executor_Importer;
        object znach;
        string type_Customer;
        string CustomerCoder = "";
        int? id_current_doc;
        int id_correct;
        int? id_meterTYPE;
        int?  id_installer2;
        string meter_kod;
        int custT;
      
        public Main_corrector()
        {
            InitializeComponent();
        }
        private void Main_corrector_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mMSDataSet.spr_Slujba". При необходимости она может быть перемещена или удалена.
            this.spr_SlujbaTableAdapter.Fill(this.mMSDataSet.spr_Slujba);
            if (Globals.id_slujbi >15 || Globals.id_slujbi < 19)
            {
                this.spr_MeterTypeTalasTableAdapter.Fill(this.mMSDataSet.spr_MeterTypeTalas);
                repositoryItemLookUpEdit5.DataSource = spr_MeterTypeTalasBS;
                lookUpEdit2.Properties.DataSource = spr_MeterTypeTalasBS; 
            }
          
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterTypeTalas' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'mMSDataSet.spentMAT2' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'mMSDataSet.spr_installer2' table. You can move, or remove it, as needed.
            this.spr_installer2TableAdapter.Fill(this.mMSDataSet.spr_installer2, Globals.id_slujbi);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Executor' table. You can move, or remove it, as needed.
          //this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;
            // TODO: This line of code loads data into the 'mMSDataSet.View_InstalledMeters2' table. You can move, or remove it, as needed.
            this.view_InstalledMeters2TableAdapter.Fill(this.mMSDataSet.View_InstalledMeters2);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MMOL' table. You can move, or remove it, as needed.
              this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Shit' table. You can move, or remove it, as needed.
            this.spr_ShitTableAdapter.Fill(this.mMSDataSet.spr_Shit);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Avtomat' table. You can move, or remove it, as needed.
            this.spr_AvtomatTableAdapter.Fill(this.mMSDataSet.spr_Avtomat);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Kabel' table. You can move, or remove it, as needed.
            this.spr_KabelTableAdapter.Fill(this.mMSDataSet.spr_Kabel);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterType' table. You can move, or remove it, as needed.
            this.spr_MeterTypeTableAdapter.Fill(this.mMSDataSet.spr_MeterType);
            // TODO: This line of code loads data into the 'mMSDataSet.InstalledMeters2' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'mMSDataSet.spr_Metrolog' table. You can move, or remove it, as needed.
            this.spr_MetrologTableAdapter.Fill(this.mMSDataSet.spr_Metrolog, Globals.id_slujbi);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_master' table. You can move, or remove it, as needed.
            this.spr_masterTableAdapter.Fill(this.mMSDataSet.spr_master, Globals.id_slujbi);
            this.new_meterTableAdapter.Fill(this.mMSDataSet.New_meter, Globals.id_slujbi);
       
            shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            comboBox1.Text = (DateTime.Today).Year.ToString();
            // TODO: This line of code loads data into the 'mMSDataSet.InstalledMeters' table. You can move, or remove it, as needed.
            this.installedMetersTableAdapter.FillById_user(this.mMSDataSet.InstalledMeters, Globals.id_user, Convert.ToDecimal(comboBox1.Text));
           

            radioButton3.Checked = true;
            textEdit1.Visible = true;
            labelControl1.Visible = true;
            textEdit2.Visible = false;
            labelControl2.Visible = false;
            dateEdit1.EditValue = DateTime.Today;

        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["doc_status"])) == true)
                {
                    e.Appearance.BackColor = Color.Gainsboro;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {

                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }



        private void installedMetersBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_install_doc = Convert.ToInt32(((DataRowView)installedMetersBindingSource.Current).Row["id"]);


            }
            catch { }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
                {
                    this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
                }
                if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
                {
                    //this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
                    this.view_inst2ShipTableAdapter.Fill_id_slujba(this.mMSDataSet.View_inst2Ship, Globals.id_slujbi);
                }

            }
            catch { }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            { this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc); }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { this.installedMeters2TableAdapter.FillByAll_IdInstalled(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc); }
        }

        private void advBandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (View.GetRowCellValue(e.RowHandle, View.Columns["EditStatus"]) is DBNull)
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {

                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }

        private void корректироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear_all();
            //this.akt_schet_dostupTableAdapter.Fill_id_shipdostup(this.mMSDataSet1.akt_schet_dostup, Globals.id_NewMeter);
            //if (this.akt_schet_dostupbindingSource.Count > 0)
            //{
            //    MessageBox.Show("Данный абонент " + Globals.CustomerCode + " импортирован в Биллинг,\nи составлен АКТ,\nвы не можете корректировать!");
            //    return;
            //}

            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            textEdit2.Enabled = true;
            textEdit1.Enabled = true;
            lookUpEdit1.ReadOnly = true;

            lookUpEdit2.Properties.DataSource = spr_MeterTypeTalasBS;
            //shipmentsTableAdapter.UpdateStatus_issuedMOL(Globals.id_NewMeter);
            this.new_meterTableAdapter.Fill(this.mMSDataSet.New_meter, Globals.id_slujbi);
            id_correct=Globals.id_correct_row;
            if (Globals.EditStatus == false)
            {
                if (Globals.Type_Customer == "быт")
                {
                   // textEdit1.Properties.ReadOnly = true;
                    radioButton3.Checked = true;
                    textEdit1.Visible = true;
                    labelControl1.Visible = true;
                    textEdit2.Visible = false;
                    labelControl2.Visible = false;
                    textEdit1.Text = Globals.CustomerCode;
                    textEdit16.Text = Globals.CustomerName;
                    textEdit3.Text = Globals.Address;
                    textEdit4.Text = Globals.Dom_kv;
                    textEdit15.Text = Globals.tpNo.ToString();
                    TT.Text = Globals.TT.ToString();
                    lookUpEdit6.EditValue = Globals.id_NewMeter;
                    textEdit5.Text = Globals.Seal_GP;
                    textEdit6.Text = Globals.Seal_CRPU;
                    textEdit7.Text = Globals.NewReadings.ToString();
                    textEdit9.Text = Globals.Seal_MCB;
                    textEdit11.Text = Globals.Seal_Box;
                    textEdit12.Text = Globals.Seal_Modem;
                    textEdit13.Text = Globals.Seal_CT;
                    textEdit17.Text = Globals.Seal_TermCover;
                    textEdit10.Text = Globals.OldMeterNo;
                    
                    textEdit8.Text = Globals.OldReadings.ToString();
                    lookUpEdit3.EditValue = Globals.id_Cable;
                    textEdit14.Text = Globals.CableLength.ToString();
                    lookUpEdit4.EditValue = Globals.id_MCB;
                    lookUpEdit5.EditValue = Globals.id_Box;
                    lookUpEdit7.EditValue = Globals.id_installer2;
                    lookUpEdit2.EditValue = Convert.ToInt32(Globals.OldMeterType);


                }
                else
                {
                   // textEdit2.Properties.ReadOnly = true;
                    radioButton4.Checked = true;
                    radioButton3.Checked = false;
                    textEdit1.Visible = false;
                    labelControl1.Visible = false;
                    textEdit2.Visible = true;
                    labelControl2.Visible = true;
                    textEdit2.Text = Globals.CustomerCode;
                    textEdit16.Text = Globals.CustomerName;
                    textEdit3.Text = Globals.Address;
                    textEdit4.Text = Globals.Dom_kv;
                    textEdit15.Text = Globals.tpNo.ToString();
                    TT.Text = Globals.TT.ToString();
                    lookUpEdit6.EditValue = Globals.id_NewMeter;
                    textEdit5.Text = Globals.Seal_GP;
                    textEdit6.Text = Globals.Seal_CRPU;
                    textEdit7.Text = Globals.NewReadings.ToString();
                    textEdit9.Text = Globals.Seal_MCB;
                    textEdit11.Text = Globals.Seal_Box;
                    textEdit12.Text = Globals.Seal_Modem;
                    textEdit13.Text = Globals.Seal_CT;
                    textEdit17.Text = Globals.Seal_TermCover;
                    textEdit10.Text = Globals.OldMeterNo.ToString();
                    
                    textEdit8.Text = Globals.OldReadings.ToString();
                    lookUpEdit3.EditValue = Globals.id_Cable;
                    textEdit14.Text = Globals.CableLength.ToString();
                    lookUpEdit4.EditValue = Globals.id_MCB;
                    lookUpEdit5.EditValue = Globals.id_Box;
                    lookUpEdit7.EditValue = Globals.id_installer2;
                    lookUpEdit2.EditValue = Convert.ToInt32(Globals.OldMeterType);
                   
                }

            }
            else { MessageBox.Show("Не возможна корректировка записи!!! \n Запись аннулирована "); }
        }

        private void installedMeters2BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_correct_row = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id"]);
                Globals.id_Installed = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id_Installed"]);
                if (((DataRowView)installedMeters2BindingSource.Current).Row["id_Executor_Importer"] is DBNull)
                { Globals.id_Executor_Importer = 0; }
                else {
                    Globals.id_Executor_Importer = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id_Executor_Importer"]);
                }
                if (((DataRowView)installedMeters2BindingSource.Current).Row["installer2"] is DBNull)
                { Globals.id_installer2 = 0; }
                else
                {
                    Globals.id_installer2 = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["installer2"]);
                    
                }
                
                if (((DataRowView)installedMeters2BindingSource.Current).Row["tpNo"] is DBNull)
                { Globals.tpNo = 0; }
                else
                { 
                Globals.tpNo = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["tpNo"]);}
                
                
                
                
                if(((DataRowView)installedMeters2BindingSource.Current).Row["id_NewMeter"] is DBNull)
                { Globals.id_NewMeter = 0; }
                else { 
                Globals.id_NewMeter = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id_NewMeter"]);}
                if (((DataRowView)installedMeters2BindingSource.Current).Row["NewReadings"] is DBNull) { Globals.NewReadings = 0; }
                else{
                Globals.NewReadings = Convert.ToDecimal(((DataRowView)installedMeters2BindingSource.Current).Row["NewReadings"]);}
                Globals.Seal_TermCover = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Seal_TermCover"]);
                Globals.Seal_GP = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Seal_GP"]);
                Globals.Seal_MCB = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Seal_MCB"]);
                Globals.Seal_CRPU = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Seal_CRPU"]);
                Globals.Seal_Box = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Seal_Box"]);
                Globals.Seal_Modem = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Seal_Modem"]);
                Globals.Seal_CT = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Seal_CT"]);
                Globals.Type_Customer = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Type_Customer"]);
                if (((DataRowView)installedMeters2BindingSource.Current).Row["CustomerCode"] is DBNull)
                { Globals.CustomerCode = ""; }
                else { 
                Globals.CustomerCode = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["CustomerCode"]);}
                if (((DataRowView)installedMeters2BindingSource.Current).Row["CustomerName"] is DBNull)
                { Globals.CustomerName = ""; }
                else { 
                Globals.CustomerName = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["CustomerName"]);}
                if (((DataRowView)installedMeters2BindingSource.Current).Row["Address"] is DBNull)
                { Globals.Address = ""; }
                { 
                Globals.Address = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Address"]);}
                if (((DataRowView)installedMeters2BindingSource.Current).Row["Dom_kv"] is DBNull)
                { Globals.Dom_kv = ""; }
                { 
                Globals.Dom_kv = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["Dom_kv"]);}
                if (((DataRowView)installedMeters2BindingSource.Current).Row["OldMeterNo"] is DBNull)
                { Globals.OldMeterNo = ""; }
                else { 
                Globals.OldMeterNo = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["OldMeterNo"]);}
               
                if (((DataRowView)installedMeters2BindingSource.Current).Row["Date_installed"] is DBNull)
                { Globals.Date_installed = DateTime.Today; }
                else
                {
                    Globals.Date_installed = Convert.ToDateTime(((DataRowView)installedMeters2BindingSource.Current).Row["Date_installed"]);
                }

                if (((DataRowView)installedMeters2BindingSource.Current).Row["OldReadings"] is DBNull)
                { Globals.OldReadings = 0; }
                else { 
                Globals.OldReadings = Convert.ToDecimal(((DataRowView)installedMeters2BindingSource.Current).Row["OldReadings"]);}
                if (((DataRowView)installedMeters2BindingSource.Current).Row["OldMeter_typeId"] is DBNull)
                { Globals.OldMeterType = "0"; }
                else {
                    Globals.OldMeterType = Convert.ToString(((DataRowView)installedMeters2BindingSource.Current).Row["OldMeter_typeId"]);
                }
               // Globals.id_Cable = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id_Cable"]);
               // Globals.CableLength = Convert.ToDecimal(((DataRowView)installedMeters2BindingSource.Current).Row["CableLength"]);
               // Globals.id_MCB = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id_MCB"]);
               // Globals.id_Box = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id_Box"]);
                if (((DataRowView)installedMeters2BindingSource.Current).Row["EditStatus"] is DBNull)
                { Globals.EditStatus = false; }
                else
                {
                    Globals.EditStatus = Convert.ToBoolean(((DataRowView)installedMeters2BindingSource.Current).Row["EditStatus"]);
                }
                if ((((DataRowView)installedMeters2BindingSource.Current).Row["TT"]) is DBNull)
                { Globals.TT = 0; }
                else { 
                Globals.TT = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["TT"]);}

              /*  if(Globals.CustomerCode == "" )
                { 
                корректироватьToolStripMenuItem.Visible = false;
                убратьЛицсчетабонномерToolStripMenuItem.Visible = false;
                }
                if(Globals.id_NewMeter == 0)
                {
                    убратьЛицсчетабонномерToolStripMenuItem.Visible = false;
                    корректироватьлицсчетабонномерToolStripMenuItem.Visible = false;
                    
                }*/
            }
            catch { }

            try
            {


                if (installedMeters2BindingSource.Count > 0)
                {
                    Globals.id_installedMeters2 = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id"].ToString());
                    this.spentM_inner2TableAdapter.Fill(this.mMSDataSet.spentM_inner2, Globals.id_installedMeters2);
                }

            }
            catch { }

        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.Correct_counters = "new_counters";
                if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Shipments") != DBNull.Value
                    && (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Shipments") != null)
                {
                    id_Shipments = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Shipments");
                    
                    }
                else
                {
                    id_Shipments = 0; 
                }
               // if (Globals.id_NewMeter != id_Shipments)
                //{ shipmentsTableAdapter.UpdateStatus_issuedMOL(Globals.id_NewMeter); }
                if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Executor_Importer") != DBNull.Value
                    && (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Executor_Importer") != null)
                { id_Executor_Importer = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Executor_Importer"); }
                else
                {
                    id_Executor_Importer = 0; 
                }

                if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_GP") != DBNull.Value
                    && (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_GP") != null)
                { textEdit5.Text = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_GP"); }
                else
                {
                    textEdit5.Text = ""; 
                }
                if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_CRPU") != DBNull.Value
                    && (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_CRPU") != null)
                { textEdit6.Text = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_CRPU");}
                else
                {
                    textEdit6.Text = "";  
                }
                if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_Modem") != DBNull.Value
                    && (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_Modem") != null)
                { textEdit12.Text = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_Modem"); }
                else
                {
                    textEdit12.Text = ""; 
                }

                textEdit7.Focus();
            }
        }

        private void textEdit9_Leave(object sender, EventArgs e)
        {
            string ddd3 = textEdit9.Text;

            if (ddd3 != "0")
            {
                id_meter = id_Shipments;
                if (id_Shipments == 0)
                {
                    id_meter = Globals.id_NewMeter;
                }
                //this.view_InstalledMeters2TableAdapter.FillBySeal_MCB(this.mMSDataSet.View_InstalledMeters2, ddd3);
                this.view_InstalledMeters2TableAdapter.correct_Seal_MCB(this.mMSDataSet.View_InstalledMeters2,id_meter,ddd3);
                if (view_InstalledMeters2BindingSource.Count > 0)
                {
                    int id_install_doc;
                    string name_doc;
                    DateTime DateInstall;
                    string first_last_name;
                    string name_slujba;
                    string NameExecutor;
                    string customer;
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                    { customer = ""; }
                    else
                    {
                        customer = (string)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                    }
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                    { id_install_doc = 0; }
                    else
                    {
                        id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                    }
                    this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                    { name_doc = ""; }
                    else
                    {
                        name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                    { DateInstall = DateTime.Today; }
                    else
                    {
                        DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                    { first_last_name = ""; }
                    else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                    { name_slujba = ""; }
                    else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                    { NameExecutor = ""; }
                    else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                    MessageBox.Show("Эта пломба " + ddd3 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                    textEdit9.Text = "";
                    textEdit9.Focus();
                }
                else
                {
                    textEdit11.Focus();
                }
            }
        }

        private void textEdit11_Leave(object sender, EventArgs e)
        {
            string ddd4 = textEdit11.Text;

            if (ddd4 != "0")
            {

                id_meter = id_Shipments;
                if (id_Shipments == 0)
                {
                    id_meter = Globals.id_NewMeter;
                }
                //this.view_InstalledMeters2TableAdapter.FillBySeal_Box(this.mMSDataSet.View_InstalledMeters2, ddd4);
                this.view_InstalledMeters2TableAdapter.correct_Seal_box(this.mMSDataSet.View_InstalledMeters2,ddd4,id_meter);
                if (view_InstalledMeters2BindingSource.Count > 0)
                {
                    int id_install_doc;
                    string name_doc;
                    DateTime DateInstall;
                    string first_last_name;
                    string name_slujba;
                    string NameExecutor;
                    string customer;
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                    { customer = ""; }
                    else
                    {
                        customer = (string)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                    }
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                    { id_install_doc = 0; }
                    else
                    {
                        id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                    }
                    this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                    { name_doc = ""; }
                    else
                    {
                        name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                    { DateInstall = DateTime.Today; }
                    else
                    {
                        DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                    { first_last_name = ""; }
                    else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                    { name_slujba = ""; }
                    else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                    { NameExecutor = ""; }
                    else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                    MessageBox.Show("Эта пломба " + ddd4 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                    textEdit11.Text = "";
                    textEdit11.Focus();
                }
                else
                {
                    textEdit12.Focus();
                }
            }
        }

        private void textEdit12_Leave(object sender, EventArgs e)
        {
            
            string ddd2 = textEdit12.Text;

            if (ddd2 != "0")
            {
                id_meter=id_Shipments;
               if( id_Shipments==0)
               {
               id_meter=Globals.id_NewMeter;
               }
                
                //this.view_InstalledMeters2TableAdapter.FillBySeal_Modem(this.mMSDataSet.View_InstalledMeters2, ddd2);
                this.view_InstalledMeters2TableAdapter.correct_Seal_Modem(this.mMSDataSet.View_InstalledMeters2, id_meter, ddd2);
                if (view_InstalledMeters2BindingSource.Count > 0)
                {
                    int id_install_doc;
                    string name_doc;
                    DateTime DateInstall;
                    string first_last_name;
                    string name_slujba;
                    string NameExecutor;
                    string customer;
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                    { customer = ""; }
                    else
                    {
                        customer = (string)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                    }
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                    { id_install_doc = 0; }
                    else
                    {
                        id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                    }
                    this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                    { name_doc = ""; }
                    else
                    {
                        name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                    { DateInstall = DateTime.Today; }
                    else
                    {
                        DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                    { first_last_name = ""; }
                    else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                    { name_slujba = ""; }
                    else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                    { NameExecutor = ""; }
                    else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                    MessageBox.Show("Эта пломба " + ddd2 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                    textEdit12.Text = "";
                    textEdit12.Focus();
                }
                else
                {
                    textEdit13.Focus();
                }
            }
        }

        private void textEdit13_Leave(object sender, EventArgs e)
        {
            string ddd6 = textEdit13.Text;
           
            if (ddd6 != "0")
            {

                id_meter = id_Shipments;
                if (id_Shipments == 0)
                {
                    id_meter = Globals.id_NewMeter;
                }
            //this.view_InstalledMeters2TableAdapter.FillBySeal_CT(this.mMSDataSet.View_InstalledMeters2, ddd6);
            this.view_InstalledMeters2TableAdapter.correct_Seal_CT(this.mMSDataSet.View_InstalledMeters2,id_meter,ddd6);
            if (view_InstalledMeters2BindingSource.Count > 0)
            {
                int id_install_doc;
                string name_doc;
                DateTime DateInstall;
                string first_last_name;
                string name_slujba;
                string NameExecutor;
                string customer;
               
                if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                { customer = ""; }
                else
                {
                    customer = (string)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                }
                if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                { id_install_doc = 0; }
                else
                {
                    id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                }
                this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                { name_doc = ""; }
                else
                {
                    name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                }
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                { DateInstall = DateTime.Today; }
                else
                {
                    DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                }
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                { first_last_name = ""; }
                else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                { name_slujba = ""; }
                else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                { NameExecutor = ""; }
                else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                MessageBox.Show("Эта пломба " + ddd6 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                textEdit13.Text = "";
                textEdit13.Focus();
            }
            else
            {
                textEdit17.Focus();
            }
        }
        }

        private void textEdit17_Leave(object sender, EventArgs e)
        {
            string ddd5 = textEdit17.Text;

            if (ddd5 != "0")
            {
                id_meter = id_Shipments;
                if (id_Shipments == 0)
                {
                    id_meter = Globals.id_NewMeter;
                }
                //this.view_InstalledMeters2TableAdapter.FillBySeal_TermCover(this.mMSDataSet.View_InstalledMeters2, ddd5);
                this.view_InstalledMeters2TableAdapter.correct_Seal_TermCover(this.mMSDataSet.View_InstalledMeters2,id_meter,ddd5);
                if (view_InstalledMeters2BindingSource.Count > 0)
                {
                    int id_install_doc;
                    string name_doc;
                    DateTime DateInstall;
                    string first_last_name;
                    string name_slujba;
                    string NameExecutor;
                    string customer;
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                    { customer = ""; }
                    else
                    {
                        customer = (string)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                    }
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                    { id_install_doc = 0; }
                    else
                    {
                        id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                    }
                    this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                    { name_doc = ""; }
                    else
                    {
                        name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                    { DateInstall = DateTime.Today; }
                    else
                    {
                        DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                    { first_last_name = ""; }
                    else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                    { name_slujba = ""; }
                    else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                    { NameExecutor = ""; }
                    else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                    MessageBox.Show("Эта пломба " + ddd5 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                    textEdit17.Text = "";
                    textEdit17.Focus();
                }
                else
                {
                    textEdit10.Focus();
                }
            }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.correct_old_meter_type = "correct";
                id_type_old_Meter = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");
                object id_meterTYPE0 = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");
                id_meterTYPE = Convert.ToInt32(id_meterTYPE0);
                znach = (object)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("zn");
                this.view_InstalledMeters2TableAdapter.FillByOLD_meterNO2(this.mMSDataSet.View_InstalledMeters2, textEdit10.Text.Trim(), id_meterTYPE, textEdit1.Text);//adiltai
               // this.view_InstalledMeters2TableAdapter.FillByOldMeterNo(this.mMSDataSet.View_InstalledMeters2, textEdit10.Text.Trim(), id_meterTYPE); //adiltai
                if (view_InstalledMeters2BindingSource.Count > 0)
                {
                    int id_install_doc;
                    string name_doc;
                    DateTime DateInstall;
                    string first_last_name;
                    string name_slujba;
                    string NameExecutor;
                    string customer;
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                    { customer = ""; }
                    else
                    {
                        customer = (string)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                    }
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                    { id_install_doc = 0; }
                    else
                    {
                        id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                    }
                    this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                    { name_doc = ""; }
                    else
                    {
                        name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                    { DateInstall = DateTime.Today; }
                    else
                    {
                        DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                    { first_last_name = ""; }
                    else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                    { name_slujba = ""; }
                    else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                    { NameExecutor = ""; }
                    else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                    MessageBox.Show("Этот счетчик " + textEdit10.Text + " уже заведен" + "\n" + "У абонента: " + customer + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                    textEdit10.Text = "";
                    textEdit10.Focus();
                    lookUpEdit2.EditValue = null;
                }
                else
                {
                    textEdit8.Properties.MaxLength = Convert.ToInt32(znach)+3;
                    textEdit8.Focus();
                }
            }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_Kabel = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                textEdit14.Focus();
            }
        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_Avtomat = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                lookUpEdit5.Focus();
            }
        }

        private void lookUpEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_Shit = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                simpleButton1.Focus();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id_new_ship;
            int? old_meter_type;
            int id_exec_imp;
            if (radioButton3.Checked == true)
            {
                if (textEdit1.Text == "" ||
                  textEdit3.Text == "" ||
                textEdit15.Text == "" ||
                TT.Text == "" ||
                textEdit5.Text == "" ||
                textEdit6.Text == "" ||
                textEdit7.Text == "" ||
                textEdit9.Text == "" ||
                textEdit11.Text == "" ||
                textEdit12.Text == "" ||
                textEdit13.Text == "" ||
                textEdit10.Text == "" ||
                //lookUpEdit2.Text == "" ||
                  lookUpEdit7.Text == "" ||
                  //lookUpEdit1.Text == "" ||
                textEdit8.Text == "" ||
                textEdit17.Text == "" ||
                textEdit16.Text == "")
                { MessageBox.Show("Заполните все поля"); }
                else
                {
                    try
                    {
                        if (Globals.Correct_counters == "new_counters")
                        {
                            if (id_Shipments == 0)
                            {
                                id_new_ship = Globals.id_NewMeter;
                            }
                            else
                            {
                                id_new_ship = id_Shipments;
                                shipmentsTableAdapter.UpdateStatus_issuedMOL(Globals.id_NewMeter);
                            }
                            id_exec_imp = id_Executor_Importer;
                        }
                        else { id_new_ship = Globals.id_NewMeter;
                        id_exec_imp = Globals.id_Executor_Importer;
                        }
                        if (Globals.correct_old_meter_type == "correct")
                        { old_meter_type = id_meterTYPE; }
                        else { old_meter_type = Convert.ToInt32(Globals.OldMeterType); }
                        type_Customer = "быт";
                        CustomerCoder = textEdit1.Text;
                        this.queriesTableAdapter1.insert_InstalledMeters2(Globals.id_install_doc, id_exec_imp,
                            Convert.ToInt32(textEdit15.Text), id_new_ship, textEdit7.Text,
                            textEdit17.Text, textEdit5.Text, textEdit9.Text, textEdit6.Text, textEdit11.Text, textEdit12.Text,
                            textEdit13.Text, type_Customer, CustomerCoder, textEdit16.Text, textEdit3.Text, textEdit4.Text,
                           textEdit10.Text, textEdit8.Text, Convert.ToInt32(TT.Text), old_meter_type, Convert.ToDateTime(dateEdit1.Text),  Convert.ToInt32(lookUpEdit7.EditValue), ref id_current_doc);
                        this.spentMAT2TableAdapter.Update_id_installed_mat2(id_current_doc,id_correct );
                        this.spentMaterialsTableAdapter.Update_id_installde2_mater(id_current_doc,id_correct );
                        this.installedMeters2TableAdapter.UpdateEdit(id_current_doc, id_correct); //обновление id_EDit=id_current_doc and Edit status=null
                        this.shipmentsTableAdapter.UpdateStatus_installed(id_Shipments);
                        this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
                        installedMeters2BindingSource.MoveLast();
                        Clear_all();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                }
            }
            else
            {
                if (textEdit2.Text == "" ||
                      textEdit3.Text == "" ||
                    textEdit15.Text == "" ||
                    TT.Text == "" ||
                 
                    textEdit5.Text == "" ||
                    textEdit6.Text == "" ||
                    textEdit7.Text == "" ||
                    textEdit9.Text == "" ||
                    textEdit11.Text == "" ||
                    textEdit12.Text == "" ||
                    textEdit13.Text == "" ||
                    textEdit10.Text == "" ||
                    //lookUpEdit2.Text == "" ||
                    textEdit8.Text == "" ||
                    //lookUpEdit3.Text == "" ||
                    //textEdit14.Text == "" ||
                       textEdit17.Text == "" ||
                      //lookUpEdit1.Text == "" ||
                     lookUpEdit7.Text == "" ||
                    textEdit16.Text == "")
                { MessageBox.Show("Заполните все поля"); }
                else
                {
                    try
                    {
                        if (Globals.Correct_counters == "new_counters")
                        {
                            if (id_Shipments == 0)
                            {
                                id_new_ship = Globals.id_NewMeter;
                            }
                            else
                            {
                                id_new_ship = id_Shipments;
                                //id_exec_imp = id_Executor_Importer;
                                shipmentsTableAdapter.UpdateStatus_issuedMOL(Globals.id_NewMeter);
                            }

                            id_exec_imp = id_Executor_Importer;
                            
                        }
                        else { id_new_ship = Globals.id_NewMeter;
                        id_exec_imp = Globals.id_Executor_Importer;
                        }
                        if (Globals.correct_old_meter_type == "correct")
                        { old_meter_type = id_meterTYPE; }
                        else { old_meter_type = Convert.ToInt32(Globals.OldMeterType); }
                        type_Customer = "пром";
                        CustomerCoder = textEdit2.Text;
                        this.queriesTableAdapter1.insert_InstalledMeters2(Globals.id_install_doc, id_exec_imp, //Adiltai
                            Convert.ToInt32(textEdit15.Text), id_new_ship, textEdit7.Text,
                            textEdit17.Text, textEdit5.Text, textEdit9.Text, textEdit6.Text, textEdit11.Text, textEdit12.Text,
                            textEdit13.Text, type_Customer, CustomerCoder, textEdit16.Text, textEdit3.Text, textEdit4.Text,
                            textEdit10.Text, textEdit8.Text, Convert.ToInt32(TT.Text), old_meter_type, Convert.ToDateTime(dateEdit1.Text), Convert.ToInt32(lookUpEdit7.EditValue), ref id_current_doc);
                        this.spentMAT2TableAdapter.Update_id_installed_mat2(id_current_doc, id_correct);
                        this.spentMaterialsTableAdapter.Update_id_installde2_mater(id_current_doc, id_correct);
                        this.installedMeters2TableAdapter.UpdateEdit(id_current_doc, id_correct);
                        this.shipmentsTableAdapter.UpdateStatus_installed(id_Shipments);
                        this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
                        installedMeters2BindingSource.MoveLast();
                        Clear_all();

                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                }
            }
            new_meterTableAdapter.Fill(mMSDataSet.New_meter, Globals.id_slujbi);
       
                корректироватьToolStripMenuItem.Visible = true;
                   // убратьЛицсчетабонномерToolStripMenuItem.Visible = true;
                   // корректироватьлицсчетабонномерToolStripMenuItem.Visible = true;
                id_Shipments=0;
                Globals.Correct_counters = "";
                lookUpEdit1.ReadOnly = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.shipmentsTableAdapter.UpdateStatus_installed(Globals.id_NewMeter);
            Clear_all();
            id_Shipments = 0;
            Globals.Correct_counters = "";

        }
        private void Clear_all()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit15.Text = "";
            TT.Text = "";
            lookUpEdit1.EditValue = null;
            textEdit5.Text = "";
            textEdit6.Text = "";
            textEdit7.Text = "";
            textEdit9.Text = "";
            textEdit11.Text = "";
            textEdit12.Text = "";
            textEdit13.Text = "";
            textEdit10.Text = "";
            textEdit17.Text = "";
            lookUpEdit2.EditValue = null;
            textEdit8.Text = "";
           
            //lookUpEdit3.EditValue = null;
            //textEdit14.Text = "";
            //lookUpEdit4.EditValue = null;
            //lookUpEdit5.EditValue = null;
            textEdit16.Text = "";
            lookUpEdit6.EditValue = null;
            //radioButton3.Checked = false;
            //radioButton4.Checked=false;
            lookUpEdit7.EditValue = null;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string tpNo = "";
            string CustomerName = "";
            string Adres = "";
            string dom_kv = "";
            string oldMeter = "";
            if (radioButton3.Checked == true)
            {
                CustomerCoder = textEdit1.Text;
            }
            else { CustomerCoder = textEdit2.Text; }
           // this.view_InstalledMeters2TableAdapter.FillByCustomerCode(this.mMSDataSet.View_InstalledMeters2, CustomerCoder);
             this.view_InstalledMeters2TableAdapter.FillCustomercod_slujba(this.mMSDataSet.View_InstalledMeters2, CustomerCoder,Globals.id_slujbi);

             if (view_InstalledMeters2BindingSource.Count > 0)
             {
                 int id_install_doc;
                 string name_doc;
                 DateTime DateInstall;
                 string first_last_name;
                 string name_slujba;
                 string NameExecutor;
                 if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                 { id_install_doc = 0; }
                 else
                 {
                     id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                 }
                 this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                 if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                 { name_doc = ""; }
                 else
                 {
                     name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                 }
                 if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                 { DateInstall = DateTime.Today; }
                 else
                 {
                     DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                 }
                 if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                 { first_last_name = ""; }
                 else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                 if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                 { name_slujba = ""; }
                 else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                 if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                 { NameExecutor = ""; }
                 else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                 MessageBox.Show("Этот абонент: " + CustomerCoder + " уже заведен" + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                 Clear_all();
                 lookUpEdit6.EditValue = Globals.id_NewMeter;

             }
             else
             {
                 this.spr_RegionBillingTableAdapter.FillByFindAbon(this.mMSDataSet.spr_RegionBilling, CustomerCoder, Globals.id_slujbi);
                 if (spr_RegionBillingBindingSource.Count > 0)
                 {
                     if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["cstation"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["cstation"] == "")
                     { tpNo = ""; }
                     else
                     {
                         tpNo = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["cstation"];
                     }
                     if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["cspot2"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["cspot2"] == "") { CustomerName = ""; }
                     else
                     {
                         CustomerName = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["cspot2"];
                     }
                     if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["address1"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["address1"] == "")
                     { Adres = ""; }
                     else
                     {
                         Adres = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["address1"];
                     }
                     if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["address2"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["address2"] == "")
                     { dom_kv = ""; }
                     else
                     {
                         dom_kv = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["address2"];
                     }
                     if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter"] == "")
                     { oldMeter = ""; }
                     else
                     {
                         oldMeter = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter"];
                     }
                     textEdit16.Text = CustomerName;
                     textEdit3.Text = Adres;
                     textEdit4.Text = dom_kv;
                     textEdit15.Text = tpNo;
                     textEdit10.Text = oldMeter;
                     //lookUpEdit1.Focus();
                 }
                 else
                 //{
                 //    spr_BillingTableAdapter.FillByFindAbon(mMSDataSet.spr_Billing, CustomerCoder, Convert.ToString(Globals.id_slujbi));
                 //    if (spr_BillingBindingSource.Count > 0)
                 //    {
                 //        if (((DataRowView)spr_BillingBindingSource.Current).Row["cstation"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["cstation"] == "")
                 //        { tpNo = ""; }
                 //        else
                 //        {
                 //            tpNo = (string)((DataRowView)spr_BillingBindingSource.Current).Row["cstation"];
                 //        }
                 //        if (((DataRowView)spr_BillingBindingSource.Current).Row["cspot2"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["cspot2"] == "") { CustomerName = ""; }
                 //        else
                 //        {
                 //            CustomerName = (string)((DataRowView)spr_BillingBindingSource.Current).Row["cspot2"];
                 //        }
                 //        if (((DataRowView)spr_BillingBindingSource.Current).Row["address1"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["address1"] == "")
                 //        { Adres = ""; }
                 //        else
                 //        {
                 //            Adres = (string)((DataRowView)spr_BillingBindingSource.Current).Row["address1"];
                 //        }
                 //        if (((DataRowView)spr_BillingBindingSource.Current).Row["address2"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["address2"] == "")
                 //        { dom_kv = ""; }
                 //        else
                 //        {
                 //            dom_kv = (string)((DataRowView)spr_BillingBindingSource.Current).Row["address2"];
                 //        }
                 //        if (((DataRowView)spr_BillingBindingSource.Current).Row["ccounter"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["ccounter"] == "")
                 //        { oldMeter = ""; }
                 //        else
                 //        {
                 //            oldMeter = (string)((DataRowView)spr_BillingBindingSource.Current).Row["ccounter"];
                 //        }
                 //        textEdit16.Text = CustomerName;
                 //        textEdit3.Text = Adres;
                 //        textEdit4.Text = dom_kv;
                 //        textEdit15.Text = tpNo;
                 //        textEdit10.Text = oldMeter;
                 //        //lookUpEdit1.Focus();
                 //    }
                 //    else
                 {
                     MessageBox.Show("Такого: " + CustomerCoder + " Не существует!!! Ввод не возможен");
                     Clear_all();
                     lookUpEdit6.EditValue = Globals.id_NewMeter;
                 }

             }
                

            
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton4_Click(null, null);
            }
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton4_Click(null, null);
            }
        }

        private void убратьСчетчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //installedMeters2TableAdapter.UpdateSnyatShetchik(Globals.id_correct_row);
           // shipmentsTableAdapter.UpdateStatus_issuedMOL(Globals.id_NewMeter);
            //this.new_meterTableAdapter.Fill(this.mMSDataSet.New_meter, Globals.id_slujbi);
            //this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
        }

        private void корректироватьлицсчетабонномерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear_all();
            //this.akt_schet_dostupTableAdapter.Fill_id_shipdostup(this.mMSDataSet1.akt_schet_dostup, Globals.id_NewMeter);
            //if (this.akt_schet_dostupbindingSource.Count > 0)
            //{
            //    MessageBox.Show("Данный абонент " + Globals.CustomerCode + " импортирован в Биллинг,\nи составлен АКТ,\nвы не можете корректировать!");
            //    return;
            //}

            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            textEdit2.Enabled = false;
            textEdit1.Enabled = false;

            lookUpEdit2.Properties.DataSource = spr_MeterTypeTalasBS;
            //shipmentsTableAdapter.UpdateStatus_issuedMOL(Globals.id_NewMeter);
            this.new_meterTableAdapter.Fill(this.mMSDataSet.New_meter, Globals.id_slujbi);
            id_correct = Globals.id_correct_row;
            if (Globals.EditStatus == false)
            {
                if (Globals.Type_Customer == "быт")
                {
                    textEdit1.Properties.ReadOnly = true;
                  
                    radioButton3.Checked = true;
                    
                    textEdit1.Visible = true;
                    labelControl1.Visible = true;
                    textEdit2.Visible = false;
                    labelControl2.Visible = false;
                    textEdit1.Text = Globals.CustomerCode;
                    textEdit16.Text = Globals.CustomerName;
                    textEdit3.Text = Globals.Address;
                    textEdit4.Text = Globals.Dom_kv;
                    textEdit15.Text = Globals.tpNo.ToString();
                    TT.Text = Globals.TT.ToString();
                    lookUpEdit6.EditValue = Globals.id_NewMeter;
                    textEdit5.Text = Globals.Seal_GP;
                    textEdit6.Text = Globals.Seal_CRPU;
                    textEdit7.Text = Globals.NewReadings.ToString();
                    textEdit9.Text = Globals.Seal_MCB;
                    textEdit11.Text = Globals.Seal_Box;
                    textEdit12.Text = Globals.Seal_Modem;
                    textEdit13.Text = Globals.Seal_CT;
                    textEdit17.Text = Globals.Seal_TermCover;
                    textEdit10.Text = Globals.OldMeterNo;

                    textEdit8.Text = Globals.OldReadings.ToString();
                    lookUpEdit3.EditValue = Globals.id_Cable;
                    textEdit14.Text = Globals.CableLength.ToString();
                    lookUpEdit4.EditValue = Globals.id_MCB;
                    lookUpEdit5.EditValue = Globals.id_Box;
                    lookUpEdit7.EditValue = Globals.id_installer2;
                    lookUpEdit2.EditValue = Convert.ToInt32(Globals.OldMeterType);


                }
                else
                {
                     textEdit2.Properties.ReadOnly = true;
                     
                    radioButton4.Checked = true;
                    radioButton3.Checked = false;
                   // radioButton4.Enabled = false;
                    textEdit1.Visible = false;
                    labelControl1.Visible = false;
                    textEdit2.Visible = true;
                    labelControl2.Visible = true;
                    textEdit2.Text = Globals.CustomerCode;
                    textEdit16.Text = Globals.CustomerName;
                    textEdit3.Text = Globals.Address;
                    textEdit4.Text = Globals.Dom_kv;
                    textEdit15.Text = Globals.tpNo.ToString();
                    TT.Text = Globals.TT.ToString();
                    lookUpEdit6.EditValue = Globals.id_NewMeter;
                    textEdit5.Text = Globals.Seal_GP;
                    textEdit6.Text = Globals.Seal_CRPU;
                    textEdit7.Text = Globals.NewReadings.ToString();
                    textEdit9.Text = Globals.Seal_MCB;
                    textEdit11.Text = Globals.Seal_Box;
                    textEdit12.Text = Globals.Seal_Modem;
                    textEdit13.Text = Globals.Seal_CT;
                    textEdit17.Text = Globals.Seal_TermCover;
                    textEdit10.Text = Globals.OldMeterNo.ToString();

                    textEdit8.Text = Globals.OldReadings.ToString();
                    lookUpEdit3.EditValue = Globals.id_Cable;
                    textEdit14.Text = Globals.CableLength.ToString();
                    lookUpEdit4.EditValue = Globals.id_MCB;
                    lookUpEdit5.EditValue = Globals.id_Box;
                    lookUpEdit7.EditValue = Globals.id_installer2;
                    lookUpEdit2.EditValue = Convert.ToInt32(Globals.OldMeterType);

                }

            }
            else { MessageBox.Show("Не возможна корректировка записи!!! \n Запись аннулирована "); }
        }

        private void убратьЛицсчетабонномерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            installedMeters2TableAdapter.UpdateSnyatCustomerCode(Globals.id_correct_row);
            this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
        }

        private void textEdit2_Leave(object sender, EventArgs e)
        {
           
                simpleButton4_Click(null, null);
           
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
           
                simpleButton4_Click(null, null);
            
        }

        private void lookUpEdit7_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_installer2 = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void TT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               (e.KeyChar != '0') &&
               (e.KeyChar != '1') &&
               (e.KeyChar != '2') &&
               (e.KeyChar != '3') &&
               (e.KeyChar != '4') &&
               (e.KeyChar != '5') &&
               (e.KeyChar != '6') &&
               (e.KeyChar != '7') &&
               (e.KeyChar != '8') &&
                (e.KeyChar != '9') &&
                (e.KeyChar != ',')//&&(e.KeyChar != '.')

               )
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void textEdit9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textEdit6_Leave(object sender, EventArgs e)
        {
            string dd99= textEdit6.Text;

            if (dd99 != "0")
            {
                id_meter = id_Shipments;
                if (id_Shipments == 0)
                {
                    id_meter = Globals.id_NewMeter;
                }
                //this.view_InstalledMeters2TableAdapter.FillBySeal_TermCover(this.mMSDataSet.View_InstalledMeters2, ddd5);
                this.view_InstalledMeters2TableAdapter.correct_Seal_CRPU(this.mMSDataSet.View_InstalledMeters2, id_meter, dd99);
                if (view_InstalledMeters2BindingSource.Count > 0)
                {
                    int id_install_doc;
                    string name_doc;
                    DateTime DateInstall;
                    string first_last_name;
                    string name_slujba;
                    string NameExecutor;
                    string customer;
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                    { customer = ""; }
                    else
                    {
                        customer = (string)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                    }
                    if (((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull || ((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                    { id_install_doc = 0; }
                    else
                    {
                        id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                    }
                    this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                    { name_doc = ""; }
                    else
                    {
                        name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                    { DateInstall = DateTime.Today; }
                    else
                    {
                        DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];
                    }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                    { first_last_name = ""; }
                    else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                    { name_slujba = ""; }
                    else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                    if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                    { NameExecutor = ""; }
                    else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                    MessageBox.Show("Эта пломба " + dd99 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
                    textEdit6.Text = "";
                    textEdit6.Focus();
                    
                }
                else
                {
                    textEdit10.Focus();
                }
            }
        }

        private void textEdit5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textEdit10_Leave(object sender, EventArgs e)
        {
            string meter_typid = "";

            this.spr_RegionBillingTableAdapter.Fill_ccounter(this.mMSDataSet.spr_RegionBilling, textEdit10.Text.Trim(), Globals.id_slujbi);
            if (spr_RegionBillingBindingSource.Count > 0)
            {
                string custTYPE = ((DataRowView)spr_RegionBillingBindingSource.Current).Row["customer_type"].ToString();

                if (custTYPE == "1")
                {
                    type_Customer = "быт";
                    custT = 1;
                }
                else
                {
                    type_Customer = "пром";
                    custT = 0;
                }

                if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter20"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter20"] == "")
                { meter_kod = ""; }
                else
                {
                    meter_kod = ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter20"].ToString();

                    if (Globals.id_slujbi < 15 || Globals.id_slujbi > 19)
                    {
                        this.spr_MeterTypeTableAdapter.FillByIdType(this.mMSDataSet.spr_MeterType, Convert.ToInt32(meter_kod));
                        if (this.sprMeterTypeBindingSource.Count > 0)
                        {
                            if (((DataRowView)sprMeterTypeBindingSource.Current).Row["id"] is DBNull ||
                                ((DataRowView)sprMeterTypeBindingSource.Current).Row["id"] == "")
                            {
                                meter_typid = "";
                            }
                            else
                            {
                                meter_typid = ((DataRowView)sprMeterTypeBindingSource.Current).Row["id"].ToString();
                                lookUpEdit2.EditValue = Convert.ToInt32(meter_typid);
                            }

                        }
                    }
                    else
                    {
                        
                        this.spr_MeterTypeTalasTableAdapter.Fill_talasMETER_TYPE(this.mMSDataSet.spr_MeterTypeTalas, Convert.ToInt32(meter_kod), Globals.id_slujbi, custT);
                        if (this.sprMeterTypeBindingSource.Count > 0)
                        {
                            if (((DataRowView)spr_MeterTypeTalasBS.Current).Row["id"] is DBNull ||
                                ((DataRowView)spr_MeterTypeTalasBS.Current).Row["id"] == "")
                            {
                                meter_typid = "";
                            }
                            else
                            {
                                meter_typid = ((DataRowView)spr_MeterTypeTalasBS.Current).Row["id"].ToString();
                                lookUpEdit2.EditValue = Convert.ToInt32(meter_typid);
                            }

                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Нет такого счетчика: " + textEdit10.Text.Trim());
            
            }
        }
        private void textEdit10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textEdit10_Leave(sender, e);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.akt_schet_dostupTableAdapter.Fill_id_shipdostup(this.mMSDataSet1.akt_schet_dostup, Globals.id_NewMeter);
            if (this.akt_schet_dostupbindingSource.Count > 0)
            {
                MessageBox.Show("Данный абонент " + Globals.CustomerCode + " импортирован в Биллинг,\nи составлен АКТ,\nвы не можете добавить материал!");
                return;
            }
            Globals.instMAT = 1;
            Form spr_m = new spr_materialy();
            spr_m.Show();
        }

        private void fillBy_id_schetToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                this.installedMetersTableAdapter.FillById_user(this.mMSDataSet.InstalledMeters, Globals.id_user, Convert.ToDecimal(comboBox1.Text));
            }
            catch { }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                type_Customer = "быт";
                textEdit2.Visible = false;
                labelControl1.Visible = false;
                textEdit1.Visible = true;
                textEdit1.Focus();
                labelControl1.Visible = true;
                Clear_all();
                lookUpEdit6.EditValue = Globals.id_NewMeter;
            }
            else
            {
                radioButton4.Checked = true;
                type_Customer = "пром";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                type_Customer = "пром";
                textEdit1.Visible = false;
                labelControl1.Visible = false;
                textEdit2.Visible = true;
                textEdit2.Focus();
                labelControl2.Visible = true;
                Clear_all();
                lookUpEdit6.EditValue = Globals.id_NewMeter;

            }
            else
            {
                radioButton3.Checked = true;
                type_Customer = "быт";
            }
        }

        private void btfindMeter_Click(object sender, EventArgs e)
        {
            
        }

        //private void lookUpEditPU_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        //{
        //    if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
        //    {
        //        int? PU = Convert.ToInt32(lookUpEditPU.EditValue);
        //        int? idsl = Globals.id_slujbi;
        //        //this.view_InstalledMeters2TableAdapter.Fill_METER_NO_slujba(this.mMSDataSet.View_InstalledMeters2, PU, idsl);
        //        this.view_inst2ShipTableAdapter.Fill_MeterNo_SL(this.mMSDataSet.View_inst2Ship, idsl, PU);  
        //        //id_Shipments = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Shipments");
        //    }
        //}

        //private void lookUpEditLS_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        //{
        //    if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
        //    {
        //        string  ls = Convert.ToString(lookUpEditLS.EditValue);
        //        int? idsl = Globals.id_slujbi;
        //        //this.view_InstalledMeters2TableAdapter.Fill_CUST_slujba(this.mMSDataSet.View_InstalledMeters2, ls, idsl);
        //        this.view_inst2ShipTableAdapter.Fill_custCode_ls(this.mMSDataSet.View_inst2Ship, idsl, ls);
        //        //id_Shipments = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Shipments");
        //    }
        //}

        private void деактивироватьПУСнятьСАбонентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите Деактивировать данный ПУ?","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.queriesTableAdapter1.update_INST2(Globals.idNmet, Globals.idInst2);
                this.view_inst2ShipTableAdapter.Fill_id_slujba(this.mMSDataSet.View_inst2Ship,Globals.id_slujbi);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("ОТМЕНЕНО!!!");
            }
        }

        private void BS_View_inst2Ship_CurrentChanged(object sender, EventArgs e)
        {
            Globals.idInst2 = Convert.ToInt32(((DataRowView)BS_View_inst2Ship.Current).Row["id"]);
            Globals.idNmet = Convert.ToInt32(((DataRowView)BS_View_inst2Ship.Current).Row["id_NewMeter"]);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
    }
