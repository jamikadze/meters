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
using DevExpress.XtraGrid;

namespace meters
{
    public partial class Add_materials : DevExpress.XtraEditors.XtraForm
    {
        int id_Shipments;
        int id_Kabel;
        int id_Shit;
        int id_Avtomat;
        int id_type_old_Meter;
        int id_Executor_Importer;
        object znach;
         int? id_meterTYPE;
        string type_Customer;
        string CustomerCoder = "";
        int? id_current_doc;
        int? id_installer2;
         string meter_kod;
         int custT;
        public Add_materials()
        {
            InitializeComponent();

            switch (Globals.id_slujbi)
            {
                case 15:// talas 
                    lookUpEdit7.Visible = true;
                    lookUpEdit2.Visible = false;
                   
                    break;
                case 16:// gorset
                    lookUpEdit7.Visible = true;
                    lookUpEdit2.Visible = false;
                    break;
                case 17:// manas
                    lookUpEdit7.Visible = true;
                    lookUpEdit2.Visible = false;
                    break;
                case 18: //bakaiata
                    lookUpEdit7.Visible = true;
                    lookUpEdit2.Visible = false;
                    break;
                case 19: //karabura
                    lookUpEdit7.Visible = true;
                    lookUpEdit2.Visible = false;
                    break;
            }
      
        }

        private void Add_materials_Load(object sender, EventArgs e)
        {
            if (Globals.doc_status == true)
            {
                xtraTabPage2.PageVisible = true;
                xtraTabPage1.PageVisible = false;
            }
            else
            {
                xtraTabPage2.PageVisible = false;
                xtraTabPage1.PageVisible = true;
            }   
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterTypeTalas' table. You can move, or remove it, as needed.
            this.spr_MeterTypeTalasTableAdapter.Fill(this.mMSDataSet.spr_MeterTypeTalas);
           // TODO: This line of code loads data into the 'mMSDataSet.spentMAT2' table. You can move, or remove it, as needed.
            //this.spentMAT2TableAdapter.Fill_idinst2(this.mMSDataSet.spentMAT2,Globals.id_installedMeters2);
            //this.spentM_inner2TableAdapter.Fill(this.mMSDataSet.spentM_inner2, Globals.id_installedMeters2);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_installer2' table. You can move, or remove it, as needed.
            this.spr_installer2TableAdapter.Fill(this.mMSDataSet.spr_installer2, Globals.id_slujbi);
            dateEdit1.EditValue = DateTime.Today;
            ostatok_mat_operatorTableAdapter.Fill(this.mMSDataSet.ostatok_mat_operator, Globals.id_slujbi); 

            // TODO: This line of code loads data into the 'mMSDataSet.spr_Materials' table. You can move, or remove it, as needed.
            this.spr_MaterialsTableAdapter.Fill(this.mMSDataSet.spr_Materials);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Executor' table. You can move, or remove it, as needed.
            textEdit1.Focus();

            
            
           
            radioButton2.Checked = true;
            //type_Customer="пром";
            textEdit1.Focus();
            textEdit2.Visible = false;
            labelControl2.Visible = false;
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MMOL' table. You can move, or remove it, as needed.
            this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
       
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Xenon' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterType' table. You can move, or remove it, as needed.
         
            this.spr_MeterTypeTableAdapter.Fill(this.mMSDataSet.spr_MeterType);
           // this.spr_AvtomatTableAdapter.Fill(this.mMSDataSet.spr_Avtomat);
            //this.spr_KabelTableAdapter.Fill(this.mMSDataSet.spr_Kabel);
            //this.spr_ShitTableAdapter.Fill(this.mMSDataSet.spr_Shit);
            this.new_meterTableAdapter.Fill(this.mMSDataSet.New_meter, Globals.id_slujbi);
            shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
            
           

            // TODO: This line of code loads data into the 'mMSDataSet.InstalledMeters2' table. You can move, or remove it, as needed.
            this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
            if (Globals.doc_status == true)
            {
                xtraTabPage2.PageVisible = true;
                xtraTabPage1.PageVisible = false;
            }
            else
            {
                xtraTabPage2.PageVisible = false;
                xtraTabPage1.PageVisible = true;
            }         
        }

        

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit myLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            //myLookup.ShowHeader = true;
            //myLookup.ShowFooter = false;
            //var rowHandle = advBandedGridView1.FocusedRowHandle;
            //string stat = advBandedGridView1.EditingValue.ToString();
            //if (stat == "пром")
            //{
                
            //    myLookup.DataSource = spr_XenonBindingSource;
            //    myLookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cspot"));
            //    myLookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("address1"));
            //    myLookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("address2"));
            //    myLookup.DisplayMember = "cspot";
            //    myLookup.ValueMember = "cspot";


            //    // Наконец установить объект LookUpEdit к колонке 
            //    colCustomerCode.ColumnEdit = myLookup;
            //    this.spr_XenonTableAdapter.Fill(this.mMSDataSet.spr_Xenon);
            //}
            //else
            //{
                
            //    myLookup.DataSource = spr_BillingBindingSource;
            //    myLookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cspot"));
            //    myLookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("address1"));
            //    myLookup.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("address2"));
            //    myLookup.DisplayMember = "cspot";
            //    myLookup.ValueMember = "cspot";


            //    // Наконец установить объект LookUpEdit к колонке 
            //    colCustomerCodeByt.ColumnEdit = myLookup;
            //    this.spr_BillingTableAdapter.Fill(this.mMSDataSet.spr_Billing);
            //}
            //advBandedGridView1.SetRowCellValue(rowHandle,"Type_Customer", stat);
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                type_Customer = "быт";
            textEdit1.Visible = true;
            labelControl1.Visible = true;
            textEdit1.Focus();
            textEdit2.Visible =false;
            labelControl2.Visible = false;
            Clear_all();
            }
            else
            {
                radioButton1.Checked = true;
                type_Customer = "пром";
            }

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                type_Customer = "пром";
                textEdit1.Visible = false;
                labelControl1.Visible = false;
                textEdit2.Visible = true;
                textEdit2.Focus();
                labelControl2.Visible = true;
                Clear_all();
            }
            else{
                radioButton2.Checked = true;
                type_Customer = "быт";
            }
        }

      

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
            string tpNo = "";
            string CustomerName = "";
            string Adres = "";
            string dom_kv = "";
            string oldMeter = "";
            string ttmeter = "";
            string meter_typid = "";
            if (radioButton2.Checked == true)
            {
                if (textEdit1.Text == "")
                {
                    MessageBox.Show("Заполните лицевой счет");
                    //textEdit1.Focus();
                    Clear_all();
                    return;
                }
                CustomerCoder = textEdit1.Text.Trim();
                type_Customer = "быт";
            }
            else
            {
                if (textEdit2.Text == "")
                {
                    MessageBox.Show("Заполните абонентский №");
                    //textEdit2.Focus();
                    Clear_all();
                    return;
                }
                CustomerCoder = textEdit2.Text.Trim();
                type_Customer = "пром";  
            }
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
                { id_install_doc =0; }
                else { 
                id_install_doc = (int)((DataRowView)view_InstalledMeters2BindingSource.Current).Row["id_Installed"];}
                this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                { name_doc = ""; }
                else { 
                name_doc = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["doc_name"];}
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                { DateInstall =DateTime.Today; }
                else { 
                DateInstall = (DateTime)((DataRowView)installedMetersDocBindingSource.Current).Row["DateInstall"];}
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                { first_last_name = ""; }
                else { first_last_name = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["first_last_name"]; }
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]=="")
                { name_slujba = ""; }
                else { name_slujba = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["name_slujba"]; }
                if (((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull || ((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                { NameExecutor = ""; }
                else { NameExecutor = (string)((DataRowView)installedMetersDocBindingSource.Current).Row["NameExecutor"]; }
                MessageBox.Show("Этот абонент: " + CustomerCoder + " уже заведен" + "\n" + "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" +  "Оператор: " + first_last_name);
                Clear_all();
            }
            else 
            {
                this.spr_RegionBillingTableAdapter.FillByFindAbon(this.mMSDataSet.spr_RegionBilling,CustomerCoder,Globals.id_slujbi);
                if(spr_RegionBillingBindingSource.Count>0)
                {
                    string custTYPE =((DataRowView)spr_RegionBillingBindingSource.Current).Row["customer_type"].ToString();

                    if (custTYPE =="1")
                    {
                        type_Customer = "быт";
                        custT = 1;
                    }
                    else
                    {
                        type_Customer = "пром";
                        custT = 0;
                    }

                    if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["cstation"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["cstation"]=="")
                    { tpNo = ""; }
                    else { 
                    tpNo = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["cstation"];
                    }
                    if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["cspot2"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["cspot2"] == "") { CustomerName = ""; }
                    else { 
                    CustomerName = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["cspot2"];}
                    if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["address1"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["address1"] == "")
                    { Adres = ""; }
                    else { 
                    Adres = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["address1"];}
                    if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["address2"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["address2"] == "")
                    { dom_kv = ""; }
                    else {
                    dom_kv = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["address2"]; }
                    if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter"] == "")
                    { oldMeter = ""; }
                    else { 
                    oldMeter = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter"]; }

                    if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["transformer_ratio"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["transformer_ratio"] == "")
                    { ttmeter = ""; }
                    else
                    {
                        ttmeter = ((DataRowView)spr_RegionBillingBindingSource.Current).Row["transformer_ratio"].ToString();
                    }

                    //if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter_type"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter_type"] == "")
                    //{ meter_typee = ""; }
                    //else
                    //{
                    //    meter_typee = (string)((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter_type"];
                    //}
                    if (((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter20"] is DBNull || ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter20"] == "")
                    { meter_kod = ""; }
                    else
                    {
                        meter_kod = ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter20"].ToString();

                        if (Globals.id_slujbi < 15 || Globals.id_slujbi > 19)
                            {
                            //meter_kod = ((DataRowView)spr_RegionBillingBindingSource.Current).Row["ccounter20"].ToString();
                            this.spr_MeterTypeTableAdapter.FillByIdType(this.mMSDataSet.spr_MeterType,
                                Convert.ToInt32(meter_kod));
                            if (this.sprMeterTypeBindingSource.Count > 0)
                            {
                                if (((DataRowView) sprMeterTypeBindingSource.Current).Row["id"] is DBNull ||
                                    ((DataRowView) sprMeterTypeBindingSource.Current).Row["id"] == "")
                                    //(((DataRowView)sprMeterTypeBindingSource.Current).Row["id_Type"] is DBNull ||
                                    //((DataRowView)sprMeterTypeBindingSource.Current).Row["id_Type"] == "")
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
                                    lookUpEdit7.EditValue = Convert.ToInt32(meter_typid);
                                }

                            }
                        }
                    }

                    TT.Text = ttmeter;
                    textEdit16.Text = CustomerName;
                    textEdit3.Text = Adres;
                    textEdit4.Text = dom_kv;
                    textEdit15.Text = tpNo;
                    textEdit10.Text = oldMeter;
                    
                    lookUpEdit1.Focus();
                }
                else 
                {
                    spr_BillingTableAdapter.FillByFindAbon(mMSDataSet.spr_Billing, CustomerCoder, Convert.ToString(Globals.id_slujbi));
                    if (spr_BillingBindingSource.Count > 0)
                    {
                        if (((DataRowView)spr_BillingBindingSource.Current).Row["cstation"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["cstation"] == "")
                        { tpNo = ""; }
                        else
                        {
                            tpNo = (string)((DataRowView)spr_BillingBindingSource.Current).Row["cstation"];
                        }
                        if (((DataRowView)spr_BillingBindingSource.Current).Row["cspot2"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["cspot2"] == "") { CustomerName = ""; }
                        else
                        {
                            CustomerName = (string)((DataRowView)spr_BillingBindingSource.Current).Row["cspot2"];
                        }
                        if (((DataRowView)spr_BillingBindingSource.Current).Row["address1"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["address1"] == "")
                        { Adres = ""; }
                        else
                        {
                            Adres = (string)((DataRowView)spr_BillingBindingSource.Current).Row["address1"];
                        }
                        if (((DataRowView)spr_BillingBindingSource.Current).Row["address2"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["address2"] == "")
                        { dom_kv = ""; }
                        else
                        {
                            dom_kv = (string)((DataRowView)spr_BillingBindingSource.Current).Row["address2"];
                        }
                        if (((DataRowView)spr_BillingBindingSource.Current).Row["ccounter"] is DBNull || ((DataRowView)spr_BillingBindingSource.Current).Row["ccounter"] == "")
                        { oldMeter = ""; }
                        else
                        {
                            oldMeter = (string)((DataRowView)spr_BillingBindingSource.Current).Row["ccounter"];
                        }
                        textEdit16.Text = CustomerName;
                        textEdit3.Text = Adres;
                        textEdit4.Text = dom_kv;
                        textEdit15.Text = tpNo;
                        textEdit10.Text = oldMeter;

                        lookUpEdit1.Focus();
                    }
                    else { MessageBox.Show("Такого: "+CustomerCoder+" Не существует!!! Ввод не возможен");
                    Clear_all();

                    }
                    
                
                }
            
            }
                   textEdit9.Text = "0";
                   textEdit11.Text = "0";
                   textEdit13.Text = "0";
                   textEdit17.Text = "0";
                   textEdit7.Text = "1";    
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton3_Click(null, null);
            }
            else
                if (e.KeyCode == Keys.Escape)
                {
                    radioButton1.Checked = true;
                   

                    //SendKeys.Send("{TAB}");
                }

        }


        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Visible = false;
                simpleButton3_Click(null, null);
            }
            else
                if (e.KeyCode == Keys.Escape)
                {
                    radioButton2.Checked =true;
                    

                    //SendKeys.Send("{TAB}");
                }

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
                 textEdit7.Text = "1";
                 textEdit9.Text = "0";
                 textEdit11.Text = "0";
                 textEdit12.Text = "";
                 textEdit13.Text = "0";
                 textEdit10.Text = "";
                 textEdit17.Text = "0";
                 lookUpEdit2.EditValue = null;
                 textEdit8.Text = "";
                 lookUpEdit3.EditValue = null;
                 textEdit14.Text = "";
                 lookUpEdit4.EditValue = null;
                 lookUpEdit5.EditValue = null;
                 textEdit16.Text = "";
                 lookUpEdit7.EditValue = null;

             }

             private void simpleButton2_Click(object sender, EventArgs e)
             {
                 Clear_all();
             }

             private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
             {

                 if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
                 {
                     id_Shipments = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Shipments");  
                     id_Executor_Importer = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Executor_Importer");
                     if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_GP") is DBNull )
                     { textEdit5.Text = ""; }
                     else { 
                     textEdit5.Text = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_GP");}
                     if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_CRPU") is DBNull )
                     { textEdit6.Text = ""; }
                     else
                     {
                         textEdit6.Text = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_CRPU");
                     }
                     if ((sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_Modem") is DBNull)
                     { textEdit12.Text = ""; }
                     else
                     {
                         textEdit12.Text = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Seal_Modem");
                     }
                     textEdit7.Focus();
                 }
             }

             private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
             {
                 if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
                 {//id_type_old_Meter = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");
                     znach = (object)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("zn");

                    object id_meterTYPE0 = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");
                     id_meterTYPE = Convert.ToInt32(id_meterTYPE0);
                     this.view_InstalledMeters2TableAdapter.FillByOldMeterNo(this.mMSDataSet.View_InstalledMeters2, textEdit10.Text, id_meterTYPE); //adiltai
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

                         MessageBox.Show("Этот счетчик " + textEdit10.Text + " уже заведен" + "\n" + "У абонента: " + customer + "\n" +"Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall + "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " + first_last_name);
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
                     id_Shit= (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                     simpleButton1.Focus();
                 }
             }

             private void simpleButton1_Click(object sender, EventArgs e)
             {



                 if (radioButton2.Checked == true)
                 {
                     if (textEdit1.Text == "")
                     {
                         MessageBox.Show("Заполните\nЛицевой счет");
                         textEdit1.Focus();
                         Clear_all();
                         return;
                     }
                 }
                 if (radioButton1.Checked == true)
                     {
                         if (textEdit2.Text == "")
                         {
                             MessageBox.Show("Заполните\nАбонентский №");
                             textEdit2.Focus();
                             Clear_all();
                             return;
                         }
                     }
                 
                 if (
                   
                       textEdit3.Text == "" ||
                     textEdit15.Text == "" ||
                     TT.Text == "" ||
                     lookUpEdit1.Text == "" ||
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
                    
                        textEdit17.Text == "" ||
                    lookUpEdit6.Text == "" ||
                     textEdit16.Text == "")
                     { MessageBox.Show("Заполните все поля"); }
                     else
                     {
                         try
                         {
                             this.queriesTableAdapter1.insert_InstalledMeters2(Globals.id_install_doc, id_Executor_Importer,
                                 Convert.ToInt32(textEdit15.Text), id_Shipments, textEdit7.Text,
                                 textEdit17.Text, textEdit5.Text, textEdit9.Text, textEdit6.Text, textEdit11.Text, textEdit12.Text,
                                 textEdit13.Text, type_Customer, CustomerCoder, textEdit16.Text, textEdit3.Text, textEdit4.Text,
                                 textEdit10.Text, textEdit8.Text, Convert.ToInt32(TT.Text), id_meterTYPE, Convert.ToDateTime(dateEdit1.Text), id_installer2, ref id_current_doc);
                             
                             
                             this.shipmentsTableAdapter.UpdateStatus_installed(id_Shipments);
                             this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
                             installedMeters2BindingSource.MoveLast();
                             Clear_all();
                             textEdit9.Text = "0";
                             textEdit11.Text = "0";
                             textEdit13.Text = "0";
                             textEdit17.Text = "0";
                             button1.Visible = true;
                         }
                         catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                     }
                
                 //else {
                 //    if (textEdit2.Text == "" ||
                 //          textEdit3.Text == "" ||
                 //        textEdit15.Text == "" ||
                 //        TT.Text==""||
                 //        lookUpEdit1.Text == "" ||
                 //        textEdit5.Text == "" ||
                 //        textEdit6.Text == "" ||
                 //        textEdit7.Text == "" ||
                 //        textEdit9.Text == "" ||
                 //        textEdit11.Text == "" ||
                 //        textEdit12.Text == "" ||
                 //        textEdit13.Text == "" ||
                 //        textEdit10.Text == "" ||
                 //        lookUpEdit2.Text == "" ||
                 //        textEdit8.Text == "" ||
                 //        textEdit17.Text == "" ||
                 //        lookUpEdit6.Text == "" ||
                 //         textEdit16.Text == "")
                 //    { MessageBox.Show("Заполните все поля"); }
                 //    else
                 //    {
                 //        try
                 //        {
                 //            this.queriesTableAdapter1.insert_InstalledMeters2(Globals.id_install_doc, id_Executor_Importer,
                 //                Convert.ToInt32(textEdit15.Text), id_Shipments, textEdit7.Text,
                 //                textEdit17.Text, textEdit5.Text, textEdit9.Text, textEdit6.Text, textEdit11.Text, textEdit12.Text,
                 //                textEdit13.Text, type_Customer, CustomerCoder, textEdit16.Text, textEdit3.Text, textEdit4.Text,
                 //                textEdit10.Text.Trim(), textEdit8.Text, id_type_old_Meter.ToString(), Convert.ToInt32(TT.Text), id_meterTYPE, Convert.ToDateTime(dateEdit1.Text), id_installer2);//, ref id_current_doc

                           
                             
                 //            this.shipmentsTableAdapter.UpdateStatus_installed(id_Shipments);
                 //            this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);
                 //            installedMeters2BindingSource.MoveLast();
                 //            Clear_all();
                 //          textEdit9.Text = "0";
                 //            textEdit11.Text = "0";
                 //            textEdit13.Text = "0";
                 //            textEdit17.Text = "0";
                         

                 //        }
                 //        catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                 //    }
                

                 this.new_meterTableAdapter.Fill(this.mMSDataSet.New_meter, Globals.id_slujbi);
             }

             private void simpleButton4_Click(object sender, EventArgs e)
             {

             }
             private void ShowGridPreview(GridControl grid)
             {
                 // Check whether the GridControl can be previewed.
                 if (!grid.IsPrintingAvailable)
                 {
                     MessageBox.Show("Не найдена библиотека 'DevExpress.XtraPrinting", "Ошибка");
                     return;
                 }

                 // Open the Preview window.
                 grid.ShowPrintPreview();
             }
             private void pictureEdit1_Click(object sender, EventArgs e)
             {
                 ShowGridPreview(gridControl2);
             }

             private void simpleButton5_Click(object sender, EventArgs e)
             {

                 DialogResult result = MessageBox.Show("Вы действительно \nхотите закрыть дркумент \n Документ закроется и будет доступен только для чтения", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes)
                 {
                     this.installedMetersTableAdapter.UpdateStatus(Globals.id_install_doc);
                     Globals.en_delegate_operator();
                     Close();
                 }

             }

             
             private void textEdit9_Leave(object sender, EventArgs e)
             {
                
                 string dd = textEdit9.Text;
                 if (dd != "0")
                 {
                     this.view_InstalledMeters2TableAdapter.FillBySeal_MCB(this.mMSDataSet.View_InstalledMeters2, dd);
                     if (view_InstalledMeters2BindingSource.Count > 0)
                     {
                         int id_install_doc;
                         string name_doc;
                         DateTime DateInstall;
                         string first_last_name;
                         string name_slujba;
                         string NameExecutor;
                         string customer;
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                         {
                             customer = "";
                         }
                         else
                         {
                             customer =
                                 (string) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                         }
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                         {
                             id_install_doc = 0;
                         }
                         else
                         {
                             id_install_doc =
                                 (int) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                         }
                         this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                         {
                             name_doc = "";
                         }
                         else
                         {
                             name_doc = (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                         {
                             DateInstall = DateTime.Today;
                         }
                         else
                         {
                             DateInstall =
                                 (DateTime) ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                         {
                             first_last_name = "";
                         }
                         else
                         {
                             first_last_name =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                         {
                             name_slujba = "";
                         }
                         else
                         {
                             name_slujba =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                         {
                             NameExecutor = "";
                         }
                         else
                         {
                             NameExecutor =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"];
                         }
                         MessageBox.Show("Эта пломба " + dd + " уже заведена" + "\n" + "У абонента: " + customer + "\n" +
                                         "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall +
                                         "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " +
                                         first_last_name);
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
                
                 string dd1 = textEdit11.Text;
                 if (dd1 != "0")
                 {
                     this.view_InstalledMeters2TableAdapter.FillBySeal_Box(this.mMSDataSet.View_InstalledMeters2, dd1);
                     if (view_InstalledMeters2BindingSource.Count > 0)
                     {
                         int id_install_doc;
                         string name_doc;
                         DateTime DateInstall;
                         string first_last_name;
                         string name_slujba;
                         string NameExecutor;
                         string customer;
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                         {
                             customer = "";
                         }
                         else
                         {
                             customer =
                                 (string) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                         }
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                         {
                             id_install_doc = 0;
                         }
                         else
                         {
                             id_install_doc =
                                 (int) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                         }
                         this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                         {
                             name_doc = "";
                         }
                         else
                         {
                             name_doc = (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                         {
                             DateInstall = DateTime.Today;
                         }
                         else
                         {
                             DateInstall =
                                 (DateTime) ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                         {
                             first_last_name = "";
                         }
                         else
                         {
                             first_last_name =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                         {
                             name_slujba = "";
                         }
                         else
                         {
                             name_slujba =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                         {
                             NameExecutor = "";
                         }
                         else
                         {
                             NameExecutor =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"];
                         }
                         MessageBox.Show("Эта пломба " + dd1 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" +
                                         "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall +
                                         "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " +
                                         first_last_name);
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
                 string dd2 = textEdit12.Text;
                 
                     this.view_InstalledMeters2TableAdapter.FillBySeal_Modem(this.mMSDataSet.View_InstalledMeters2, dd2);
                     if (view_InstalledMeters2BindingSource.Count > 0)
                     {
                         int id_install_doc;
                         string name_doc;
                         DateTime DateInstall;
                         string first_last_name;
                         string name_slujba;
                         string NameExecutor;
                         string customer;
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                         {
                             customer = "";
                         }
                         else
                         {
                             customer =
                                 (string) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                         }
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                         {
                             id_install_doc = 0;
                         }
                         else
                         {
                             id_install_doc =
                                 (int) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                         }
                         this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                         {
                             name_doc = "";
                         }
                         else
                         {
                             name_doc = (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                         {
                             DateInstall = DateTime.Today;
                         }
                         else
                         {
                             DateInstall =
                                 (DateTime) ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                         {
                             first_last_name = "";
                         }
                         else
                         {
                             first_last_name =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                         {
                             name_slujba = "";
                         }
                         else
                         {
                             name_slujba =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                         {
                             NameExecutor = "";
                         }
                         else
                         {
                             NameExecutor =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"];
                         }
                         MessageBox.Show("Эта пломба " + dd2 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" +
                                         "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall +
                                         "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " +
                                         first_last_name);
                         textEdit12.Text = "";
                         textEdit12.Focus();
                     }
                     else
                     {
                         textEdit13.Focus();
                     }
                 
             }

             private void textEdit13_Leave(object sender, EventArgs e)
             {
                 string dd3 = textEdit13.Text;
                 if (dd3 != "0")
                 {
                     this.view_InstalledMeters2TableAdapter.FillBySeal_CT(this.mMSDataSet.View_InstalledMeters2, dd3);
                     if (view_InstalledMeters2BindingSource.Count > 0)
                     {
                         int id_install_doc;
                         string name_doc;
                         DateTime DateInstall;
                         string first_last_name;
                         string name_slujba;
                         string NameExecutor;
                         string customer;
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                         {
                             customer = "";
                         }
                         else
                         {
                             customer =
                                 (string) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                         }
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                         {
                             id_install_doc = 0;
                         }
                         else
                         {
                             id_install_doc =
                                 (int) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                         }
                         this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                         {
                             name_doc = "";
                         }
                         else
                         {
                             name_doc = (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                         {
                             DateInstall = DateTime.Today;
                         }
                         else
                         {
                             DateInstall =
                                 (DateTime) ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                         {
                             first_last_name = "";
                         }
                         else
                         {
                             first_last_name =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                         {
                             name_slujba = "";
                         }
                         else
                         {
                             name_slujba =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                         {
                             NameExecutor = "";
                         }
                         else
                         {
                             NameExecutor =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"];
                         }
                         MessageBox.Show("Эта пломба " + dd3 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" +
                                         "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall +
                                         "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " +
                                         first_last_name);
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
                 string dd4 = textEdit17.Text;
                 if (dd4 != "0")
                 {
                     this.view_InstalledMeters2TableAdapter.FillBySeal_TermCover(this.mMSDataSet.View_InstalledMeters2,
                         dd4);
                     if (view_InstalledMeters2BindingSource.Count > 0)
                     {
                         int id_install_doc;
                         string name_doc;
                         DateTime DateInstall;
                         string first_last_name;
                         string name_slujba;
                         string NameExecutor;
                         string customer;
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"] == "")
                         {
                             customer = "";
                         }
                         else
                         {
                             customer =
                                 (string) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["CustomerCode"];
                         }
                         if (((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] is DBNull ||
                             ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"] == "")
                         {
                             id_install_doc = 0;
                         }
                         else
                         {
                             id_install_doc =
                                 (int) ((DataRowView) view_InstalledMeters2BindingSource.Current).Row["id_Installed"];
                         }
                         this.installedMetersDocTableAdapter.Fill(this.mMSDataSet.InstalledMetersDoc, id_install_doc);
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"] == "")
                         {
                             name_doc = "";
                         }
                         else
                         {
                             name_doc = (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["doc_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"] == "")
                         {
                             DateInstall = DateTime.Today;
                         }
                         else
                         {
                             DateInstall =
                                 (DateTime) ((DataRowView) installedMetersDocBindingSource.Current).Row["DateInstall"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"] == "")
                         {
                             first_last_name = "";
                         }
                         else
                         {
                             first_last_name =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["first_last_name"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"] == "")
                         {
                             name_slujba = "";
                         }
                         else
                         {
                             name_slujba =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["name_slujba"];
                         }
                         if (((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] is DBNull ||
                             ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"] == "")
                         {
                             NameExecutor = "";
                         }
                         else
                         {
                             NameExecutor =
                                 (string) ((DataRowView) installedMetersDocBindingSource.Current).Row["NameExecutor"];
                         }
                         MessageBox.Show("Эта пломба " + dd4 + " уже заведена" + "\n" + "У абонента: " + customer + "\n" +
                                         "Название документа: " + name_doc + "\n" + "Дата установки: " + DateInstall +
                                         "\n" + "Мастер: " + NameExecutor + " РЭС: " + name_slujba + "\n" + "Оператор: " +
                                         first_last_name);
                         textEdit17.Text = "";textEdit17.Focus();
                     }
                     else
                     {
                         textEdit10.Focus();
                     }
                 }
             }

             private void button1_Click(object sender, EventArgs e)
             {
                // if(Globals.id_doc_materials2>0)
                 //{ 
                 Globals.instMAT = 1;
                 Form spr_m = new spr_materialy();
                 spr_m.Show();
                // }
                // else
                // {
                //     MessageBox.Show("Выберите абонента для добавления материала!");
                // }
                 
             }

             private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
             {
                 simpleButton6_Click(sender,e);
             }

             private void installedMeters2BindingSource_CurrentItemChanged(object sender, EventArgs e)
             {
                 try
                 {


                     if (installedMeters2BindingSource.Count > 0)
                     {
                         Globals.id_installedMeters2  = Convert.ToInt32(((DataRowView)installedMeters2BindingSource.Current).Row["id"].ToString());
                         this.spentMaterialsTableAdapter.Fill(this.mMSDataSet.SpentMaterials, Globals.id_installedMeters2);
                         this.spentM_inner2TableAdapter.Fill(this.mMSDataSet.spentM_inner2, Globals.id_installedMeters2);
                     }

                 }
                 catch { }

             }

             private void simpleButton6_Click(object sender, EventArgs e)
             {
                 try
                 {
                     var rowHandle = gridView1.FocusedRowHandle;

                     if (gridView1.GetRowCellValue(rowHandle, "id_material").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "kol").ToString() == "")
                     {
                         MessageBox.Show("Введите все поля!!!");
                     }
                     else
                     {
                         int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                         int id_mat = (int)gridView1.GetRowCellValue(rowHandle, "id_material");
                         spentMaterials_countTableAdapter.Fill_count(this.mMSDataSet.SpentMaterials_count, id_mat, Globals.id_installedMeters2);
                        
                             if (gridView1.FocusedColumn == gridView1.Columns["kol"])
                             {
                                 if (id < 0)
                                 {
                                     if (spentMaterials_countBindingSource.Count == 0)
                                     {

                                     }
                                     else
                                     {
                                         MessageBox.Show("Такой материал есть!");

                                         this.spentMaterialsTableAdapter.Fill(this.mMSDataSet.SpentMaterials, Globals.id_installedMeters2);

                                     }

                                 }
                                 else
                                 {
                                     DialogResult result = MessageBox.Show("Чтобы поменять кол-во материала нужно удалить и занести заново! \nХотите удалить материал? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                     if (result == DialogResult.Yes)
                                     {
                                         queriesTableAdapter1.del_spent_mat(id);
                                         this.spentMaterialsTableAdapter.Fill(this.mMSDataSet.SpentMaterials, Globals.id_installedMeters2);
                                         this.ostatok_mat_operatorTableAdapter.Fill(this.mMSDataSet.ostatok_mat_operator, Globals.id_slujbi);

                                         return;
                                     }
                                 }
                             }

                             double kol = (double)gridView1.GetRowCellValue(rowHandle, "kol");
                             this.ostatok_mat_operator_idTableAdapter.Fill_id_mat(this.mMSDataSet.ostatok_mat_operator_id, Globals.id_slujbi, id_mat);
                             Globals.kol_akt = Convert.ToDouble(((DataRowView)ostatok_mat_operator_idBindingSource.Current).Row["ostatok"]);

                             if (kol > Globals.kol_akt)
                             {

                                 MessageBox.Show("Остаток данного материала равен " + Globals.kol_akt);
                                 this.spentMaterialsTableAdapter.Fill(this.mMSDataSet.SpentMaterials, Globals.id_installedMeters2);
                             }
                             else
                             {


                                 if (id < 0)
                                 {
                                     //MessageBox.Show("insert");
                                     queriesTableAdapter1.insert_spent_mat(Globals.id_installedMeters2, id_mat, kol);
                                     this.ostatok_mat_operatorTableAdapter.Fill(this.mMSDataSet.ostatok_mat_operator, Globals.id_slujbi);
                                 }
                                 else
                                 {

                                     queriesTableAdapter1.update_spent_mat(Globals.id_installedMeters2, id_mat, kol, id);
                                     this.ostatok_mat_operatorTableAdapter.Fill(this.mMSDataSet.ostatok_mat_operator, Globals.id_slujbi);
                                 }
                                 //DateTime date1 = Convert.ToDateTime("01.01." + comboBox1.Text);
                                 //DateTime date2 = Convert.ToDateTime("31.12." + comboBox1.Text);





                                 int ii = spentMaterialsBindingSource.Position;
                                 MessageBox.Show("Данные успешно сохранены");

                                 this.spentMaterialsTableAdapter.Fill(this.mMSDataSet.SpentMaterials, Globals.id_installedMeters2);
                                 spentMaterialsBindingSource.Position = ii;
                                 Globals.add = "update";
                             }

                         }

                        
                     }
                 catch { }
             }

             private void simpleButton7_Click(object sender, EventArgs e)
             {
                 try
                 {
                     DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить материал? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (result == DialogResult.Yes)
                     {
                         var rowHandle = gridView1.FocusedRowHandle;
                         int id = (int)gridView1.GetRowCellValue(rowHandle, "id");
                         queriesTableAdapter1.del_spent_mat(id);
                         this.spentMaterialsTableAdapter.Fill(this.mMSDataSet.SpentMaterials, Globals.id_installedMeters2);
                         this.ostatok_mat_operatorTableAdapter.Fill(this.mMSDataSet.ostatok_mat_operator, Globals.id_slujbi);
                     }
                     return;
                 }
                 catch { }
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 
             }

             private void repositoryItemLookUpEdit17_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
             {
                 gridView1.FocusedColumn = gridView1.Columns["kol"];
             }

             private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
             {
                // simpleButton1_Click(sender, e);
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
                 (e.KeyChar != '9')&&
                 (e.KeyChar != ',')//&&(e.KeyChar != '.')

                )
                        {
                                 e.KeyChar = Convert.ToChar(0);
                        }
              }

             private void toolStripMenuItem1_Click(object sender, EventArgs e)
             {
                 //if (Globals.id_doc_materials2 > 0)
                 //{
                     Globals.instMAT = 1;
                     Form spr_m = new spr_materialy();
                     spr_m.Show();
                 //}
                 //else
                 //{
                  //   MessageBox.Show("Выберите абонента для добавления материала!");
                 //}

             }

             private void lookUpEdit6_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
             {
                 if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
                 {
                     id_installer2 = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                 }
             }

             private void textEdit2_Leave(object sender, EventArgs e)
             {
                 
             }

             private void textEdit7_KeyDown(object sender, KeyEventArgs e)
             {
                 if (e.KeyCode == Keys.Enter)
                 {
                     SendKeys.Send("{TAB}");
                 }


                 //    
             }

             private void fillToolStripButton_Click(object sender, EventArgs e)
             {
                

             }

             private void fillToolStripButton1_Click(object sender, EventArgs e)
             {
                 
             }

             private void fillToolStripButton_Click_1(object sender, EventArgs e)
             {
                 
             }

             private void fillByToolStripButton_Click(object sender, EventArgs e)
             {
                
             }

             private void simpleButton4_Click_1(object sender, EventArgs e)
             {
               
                 var rowHandle = advBandedGridView1.FocusedRowHandle;


                 for (int i = 0; i <= advBandedGridView1.RowCount; i++)
                     {
                         var check = advBandedGridView1.GetRowCellValue(i, "Check");
                         if (Convert.ToString(check) != "")
                         {
                             if (Convert.ToBoolean(check) == true)
                             {
                                 int id = Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "id"));
                                 int id_ship = Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "id_NewMeter"));
                                 queriesTableAdapter1.delete_InstalledMeters2(id);
                                 shipmentsTableAdapter.UpdateStatus_issuedMOL(id_ship);
                                

                             }
                         }
                     }
                 this.installedMeters2TableAdapter.FillById_Installed(this.mMSDataSet.InstalledMeters2, Globals.id_install_doc);  
             }

             private void textEdit1_Leave(object sender, EventArgs e)
             {
                 button1.Visible = false;
                 simpleButton3_Click(null, null);
             }

             private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
             {

             }

             private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
             {

             }

             private void lookUpEdit7_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
             {
                 if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
                 {//id_type_old_Meter = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");
                     znach = (object)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("zn");

                     object id_meterTYPE0 = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");
                     id_meterTYPE = Convert.ToInt32(id_meterTYPE0);
                     this.view_InstalledMeters2TableAdapter.FillByOldMeterNo2(this.mMSDataSet.View_InstalledMeters2, textEdit10.Text, id_meterTYPE,Globals.id_slujbi); //adiltai
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
                         textEdit8.Properties.MaxLength = Convert.ToInt32(znach) + 3;
                         textEdit8.Focus();
                     }


                 }

             }

             private void textEdit16_Click(object sender, EventArgs e)
             {
                 button1.Visible = false;
                 simpleButton3_Click(null, null);
             }
    }
}