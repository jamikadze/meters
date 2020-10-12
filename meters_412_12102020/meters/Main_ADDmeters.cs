﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.OleDb;
using meters.Properties;
using DevExpress.XtraGrid.Views.Grid;

namespace meters
{
    public partial class Main_ADDmeters : Form
    {
        int? id_master;
        int? id_metrolog;
        int? id_current_doc;
        int? id_master2;
        public Main_ADDmeters()
        {
            InitializeComponent();
        }

        private void Main_ADDmeters_Load(object sender, EventArgs e)
        {
            comboBox1.Text = (DateTime.Today).Year.ToString();
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            this.count_counters_po_userADDTableAdapter.Fill(this.mMSDataSet.Count_counters_po_userADD, Globals.id_user);
            int i = Count_counters_po_userADDbindingSource.Count;
            this.spr_master2TableAdapter1.Fill(this.mMSDataSet.spr_master2, Globals.id_slujbi);
            this.for_import_into_BillingTableAdapter.Fill(this.mMSDataSet.For_import_into_Billing);
            this.installedMeters2ADDTableAdapter.Fill(this.mMSDataSet.InstalledMeters2ADD);
            this.installedMetersADDTableAdapter.FillBy_id_slujbi(this.mMSDataSet.InstalledMetersADD, Convert.ToDecimal(comboBox1.Text), Globals.id_slujbi);
            this.spr_MetrologTableAdapter1.Fill(this.mMSDataSet.spr_Metrolog, Globals.id_slujbi);
            this.spr_masterTableAdapter.Fill(this.mMSDataSet.spr_master, Globals.id_slujbi);

            textEdit1.Text = Globals.name_user;
            dateEdit1.EditValue = DateTime.Today;
           

            Delegate.RemoveAll(Globals.en_delegate_operator, Globals.en_delegate_operator);
            Globals.en_delegate_operator = visible_main1;

            //tbLocationFileImplrt.Text = "\\\\server\Obmen\ОИТ\ADILTAI\TESTimport";
            if (i == 0)
            { textEdit2.Text = ""; }
            else
            {
                if (((DataRowView)Count_counters_po_userADDbindingSource.Current).Row["kol"] is DBNull || ((DataRowView)Count_counters_po_userADDbindingSource.Current).Row["kol"].ToString() == "")
                {
                    textEdit2.Text = "";

                }
                else
                {
                    textEdit2.Text = Convert.ToString(((DataRowView)Count_counters_po_userADDbindingSource.Current).Row["kol"]);
                }
            }
        }


        private void visible_main1()
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
           
            this.spr_master2TableAdapter1.Fill(this.mMSDataSet.spr_master2, Globals.id_slujbi);
            this.for_import_into_BillingTableAdapter.Fill(this.mMSDataSet.For_import_into_Billing);
           // this.installedMeters2ADDTableAdapter.Fill(this.mMSDataSet.InstalledMeters2ADD);
            this.installedMetersADDTableAdapter.FillBy_id_slujbi(this.mMSDataSet.InstalledMetersADD, Convert.ToDecimal(comboBox1.Text), Globals.id_slujbi);
            this.spr_MetrologTableAdapter1.Fill(this.mMSDataSet.spr_Metrolog, Globals.id_slujbi);
            this.spr_masterTableAdapter.Fill(this.mMSDataSet.spr_master, Globals.id_slujbi);



            this.count_counters_po_userADDTableAdapter.Fill(this.mMSDataSet.Count_counters_po_userADD, Globals.id_user);
            int i = Count_counters_po_userADDbindingSource.Count;
            comboBox1.Text = "2017";
           
            textEdit1.Text = Globals.name_user;
            dateEdit1.EditValue = DateTime.Today;
            if (i == 0)
            { textEdit2.Text = ""; }
            else
            {
                if (((DataRowView)Count_counters_po_userADDbindingSource.Current).Row["kol"] is DBNull || ((DataRowView)Count_counters_po_userADDbindingSource.Current).Row["kol"].ToString() == "")
                {
                    textEdit2.Text = "";

                }
                else
                {
                    textEdit2.Text = Convert.ToString(((DataRowView)Count_counters_po_userADDbindingSource.Current).Row["kol"]);
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dateEdit1.Text != "" || textEdit3.Text != "" || textEdit1.Text != "" || lookUpEdit1.Text != "" || lookUpEdit2.Text != "" || lookUpEdit3.Text != "")
            {
                DateTime? date = Convert.ToDateTime(dateEdit1.Text);
                try
                {
                    queriesTableAdapter1.insert_InstalledMetersADD(textEdit3.Text, date, Globals.id_user, id_master, id_metrolog, ref id_current_doc, id_master2);
                    //queriesTableAdapter1.insert_InstalledMeters(textEdit3.Text, date, Globals.id_user, id_master, id_metrolog, ref id_current_doc, id_master2);
                    this.installedMetersADDTableAdapter.FillBy_id_slujbi(this.mMSDataSet.InstalledMetersADD, Convert.ToDecimal(comboBox1.Text), Globals.id_slujbi);
                   

                    dateEdit1.EditValue = null;
                    textEdit3.Text = "";

                    textEdit1.Text = "";
                    lookUpEdit1.EditValue = null;
                    lookUpEdit2.EditValue = null;
                    lookUpEdit3.EditValue = null;
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            }
            else { MessageBox.Show("Не все поля заполнены"); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dateEdit1.EditValue = null;
            textEdit3.Text = "";
            textEdit1.Text = "";

            lookUpEdit1.EditValue = null;
            lookUpEdit2.EditValue = null;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            if (meters.Properties.Settings.Default.PathImportFiles.Length == 0)
            {
                meters.Properties.Settings.Default.PathImportFiles = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                meters.Properties.Settings.Default.Save();
            }
            DateTime forFileName = DateTime.Now;
            string partDay = forFileName.Day.ToString().Length == 1 ? "0" + forFileName.Day.ToString() : forFileName.Day.ToString();
            string partMonth = forFileName.Month.ToString().Length == 1 ? "0" + forFileName.Month.ToString() : forFileName.Month.ToString();
            string partYear = forFileName.Year.ToString().Substring(2, 2);
            string f_name = "mms_" + "_" + Globals.name_slujbi.ToString().Trim().Replace(" ", "_");
            string partHours = forFileName.Hour.ToString().Length == 1 ? "0" + forFileName.Hour.ToString() : forFileName.Hour.ToString();
            string partMin = forFileName.Minute.ToString().Length == 1 ? "0" + forFileName.Minute.ToString() : forFileName.Minute.ToString();
            String filestr_new_file_import = f_name + partDay + partMonth + partYear + partHours + partMin + ".dbf";
            string filestr1 = tbLocationFileImplrt.Text;
            string str11 = tbLocationFileImplrt.Text + "\\" + filestr_new_file_import;
            if (File.Exists(str11))
            {
                DialogResult dr;
                dr = MessageBox.Show("Внимание\n\nфайл с таким именем существует\n\nУдалите существующий файл?", "Внимание", MessageBoxButtons.OK);
                return;
            }
            byte[] resf = meters.Properties.Resources.mms_;
            System.IO.File.WriteAllBytes(str11, resf);
            OleDbConnection con = new OleDbConnection(@"Provider=VFPOLEDB.1; Data Source=" + filestr1 + ";Collating Sequence=MACHINE");
            OleDbCommand command = new OleDbCommand("INSERT INTO " + Path.GetFileNameWithoutExtension(str11) +
                "(dchange, cchange1, nchange2, cchange3, cchange4, nchange5, cchange6, " +
                "nchange7, nchange8, nchange9, cchange10, cchange11, cchange12, cchange13, cchange14, cchange15, cchange16, cchange17, cchange18, cchange19) " +
                "VALUES" +
                "(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)",
                con);
            try
            {
                con.Open();
                this.for_import_into_BillingTableAdapter.FillByByt(this.mMSDataSet.For_import_into_Billing, Globals.id_user);
                bool byt_prom = false;
                if (for_import_into_BillingbindingSource.Count > 0)
                {
                    foreach (DataRowView dr in for_import_into_BillingbindingSource)
                    {
                        string prom_byt = (string)((DataRowView)for_import_into_BillingbindingSource.Current).Row["Type_Customer"];
                        int id_id = (int)((DataRowView)for_import_into_BillingbindingSource.Current).Row["id"];

                        if (prom_byt == "быт")
                        {
                            byt_prom = false;
                        }
                        else
                        {
                            byt_prom = true;
                        }
                        object dateInstall = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["DateInstall"];
                        object CustomerCode = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["CustomerCode"];
                        object OldReadings = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["OldReadings"];
                        object id_new_meter_type = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["id_MeterType"];
                        object new_meter_number = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["SerialNo"];
                        object seal_gp = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_GP"];
                        object seal_srpu = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_CRPU"];
                        object NewReadings = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["NewReadings"];
                        object tpNo = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["tpNo"];
                        object TT = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["TT"];
                        object id_old_type_meter = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["OldMeter_typeId"];
                        object id_installed_doc = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["id_Installed"];
                        object old_meter_number = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["OldMeterNo"];
                        object seal_term_cover = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_TermCover"];
                        object seal_mcb = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_MCB"];
                        object seal_box = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_Box"];
                        object metrolog = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["NameExecutor"];
                        object seal_CT = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_CT"];
                        object seal_modem = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_Modem"];

                        //this.installedMeters2TableAdapter.UpdateBillingCheck(id_id);
                        this.installedMeters2ADDTableAdapter.UpdateBillinCheck(id_id);
                        command.Parameters.AddWithValue("@dchange", Convert.ToDateTime(dateInstall));
                        command.Parameters.AddWithValue("@cchange1", Convert.ToString(CustomerCode));
                        command.Parameters.AddWithValue("@nchange2", Convert.ToDecimal(OldReadings));
                        command.Parameters.AddWithValue("@cchange3", Convert.ToString(id_new_meter_type));
                        command.Parameters.AddWithValue("@cchange4", Convert.ToString(new_meter_number));
                        //int iGp = Convert.ToInt32("20" + tdu.getStuffItem(12, nRec).ToString().Replace("/", ""));
                        command.Parameters.AddWithValue("@nchange5", Convert.ToInt32(seal_gp));
                        command.Parameters.AddWithValue("@cchange6", Convert.ToString(seal_srpu));
                        // int kl = Convert.ToInt32(tdu.getStuffItem(16, nRec));
                        command.Parameters.AddWithValue("@cchange7", Convert.ToDecimal(NewReadings));
                        command.Parameters.AddWithValue("@nchange8", Convert.ToInt32(tpNo));
                        command.Parameters.AddWithValue("@nchange9", Convert.ToInt32(TT));
                        command.Parameters.AddWithValue("@cchange10", Convert.ToString(id_old_type_meter));
                        command.Parameters.AddWithValue("@cchange11", Convert.ToString(id_installed_doc));
                        command.Parameters.AddWithValue("@cchange12", Convert.ToString(old_meter_number)); // 
                        command.Parameters.AddWithValue("@cchange13", Convert.ToString(seal_term_cover)); // 
                        command.Parameters.AddWithValue("@cchange14", Convert.ToString(seal_mcb)); // 
                        command.Parameters.AddWithValue("@cchange15", Convert.ToString(seal_box)); // 
                        command.Parameters.AddWithValue("@cchange16", Convert.ToString(metrolog)); // 
                        command.Parameters.AddWithValue("@cchange17", Convert.ToString(seal_CT)); // 
                        command.Parameters.AddWithValue("@cchange18", Convert.ToString(seal_modem)); // 
                        command.Parameters.AddWithValue("@cchange19", byt_prom); // 
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        for_import_into_BillingbindingSource.MoveNext();
                    }

                    MessageBox.Show("Импорт окончен!!! Ваш файл находится по пути: " + str11.ToString());
                    //tbLocationFileImplrt.Text = "";
                }
                else { MessageBox.Show("Нет ни одного абонента для импорта!!!"); }


            }
            catch (System.Exception ex)
            //catch (System.Exception)
            {
                //MessageBox.Show("Не могу создать файл импорта");
                MessageBox.Show(ex.ToString());
                if (File.Exists(filestr_new_file_import))
                {
                    con.Close();
                    File.Delete(filestr_new_file_import);
                }
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (meters.Properties.Settings.Default.PathImportFiles.Length == 0)
            {
                meters.Properties.Settings.Default.PathImportFiles = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                meters.Properties.Settings.Default.Save();
            }
            DateTime forFileName = DateTime.Now;
            string partDay = forFileName.Day.ToString().Length == 1 ? "0" + forFileName.Day.ToString() : forFileName.Day.ToString();
            string partMonth = forFileName.Month.ToString().Length == 1 ? "0" + forFileName.Month.ToString() : forFileName.Month.ToString();
            string partYear = forFileName.Year.ToString().Substring(2, 2);
            string f_name = "mmsprom_";
            string partHours = forFileName.Hour.ToString().Length == 1 ? "0" + forFileName.Hour.ToString() : forFileName.Hour.ToString();
            string partMin = forFileName.Minute.ToString().Length == 1 ? "0" + forFileName.Minute.ToString() : forFileName.Minute.ToString();
            String filestr_new_file_import = f_name + partDay + partMonth + partYear + partHours + partMin + ".dbf";
            string filestr1 = meters.Properties.Settings.Default.PathImportFiles;
            string str11 = filestr1 + "\\" + filestr_new_file_import;
            if (File.Exists(str11))
            {
                DialogResult dr;
                dr = MessageBox.Show("Внимание\n\nфайл с таким именем существует\n\nПодождите одну минуту?", "Внимание", MessageBoxButtons.OK);
                return;
            }
            byte[] resf = meters.Properties.Resources.mms_;
            System.IO.File.WriteAllBytes(str11, resf);
            OleDbConnection con = new OleDbConnection(@"Provider=VFPOLEDB.1;  Data Source=" + filestr1 + ";Collating Sequence=MACHINE");
            OleDbCommand command = new OleDbCommand("INSERT INTO " + Path.GetFileNameWithoutExtension(str11) +
                "(dchange, cchange1, nchange2, cchange3, cchange4, nchange5, cchange6, " +
                "nchange7, nchange8, nchange9, cchange10, cchange11, cchange12, cchange13, cchange14, cchange15, cchange16, cchange17, cchange18) " +
                "VALUES" +
                "(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)",
                con);
            try
            {
                con.Open();
                // this.for_import_into_BillingTableAdapter.FillByProm(this.mMSDataSet.For_import_into_Billing, Globals.id_user);
                if (for_import_into_BillingbindingSource.Count > 0)
                {
                    foreach (DataRowView dr in for_import_into_BillingbindingSource)
                    {
                        object dateInstall = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["DateInstall"];
                        object CustomerCode = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["CustomerCode"];
                        object OldReadings = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["OldReadings"];
                        object id_new_meter_type = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["id_MeterType"];
                        object new_meter_number = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["SerialNo"];
                        object seal_gp = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_GP"];
                        object seal_srpu = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_CRPU"];
                        object NewReadings = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["NewReadings"];
                        object tpNo = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["tpNo"];
                        object TT = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["TT"];
                        object id_old_type_meter = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["OldMeterType"];
                        object id_installed_doc = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["id_Installed"];
                        object old_meter_number = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["OldMeterNo"];
                        object seal_term_cover = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_TermCover"];
                        object seal_mcb = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_MCB"];
                        object seal_box = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_Box"];
                        object metrolog = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["NameExecutor"];
                        object seal_CT = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_CT"];
                        object seal_modem = ((DataRowView)for_import_into_BillingbindingSource.Current).Row["Seal_Modem"];


                        command.Parameters.AddWithValue("@dchange", Convert.ToDateTime(dateInstall));
                        command.Parameters.AddWithValue("@cchange1", Convert.ToString(CustomerCode));
                        command.Parameters.AddWithValue("@nchange2", Convert.ToInt32(OldReadings));
                        command.Parameters.AddWithValue("@cchange3", Convert.ToString(id_new_meter_type));
                        command.Parameters.AddWithValue("@cchange4", Convert.ToString(new_meter_number));
                        //int iGp = Convert.ToInt32("20" + tdu.getStuffItem(12, nRec).ToString().Replace("/", ""));
                        command.Parameters.AddWithValue("@nchange5", Convert.ToInt32(seal_gp));
                        command.Parameters.AddWithValue("@cchange6", Convert.ToString(seal_srpu));
                        // int kl = Convert.ToInt32(tdu.getStuffItem(16, nRec));
                        command.Parameters.AddWithValue("@cchange7", Convert.ToInt32(NewReadings));
                        command.Parameters.AddWithValue("@nchange8", Convert.ToInt32(tpNo));
                        command.Parameters.AddWithValue("@nchange9", Convert.ToInt32(TT));
                        command.Parameters.AddWithValue("@cchange10", Convert.ToString(id_old_type_meter));
                        command.Parameters.AddWithValue("@cchange11", Convert.ToString(id_installed_doc));
                        command.Parameters.AddWithValue("@cchange12", Convert.ToString(old_meter_number)); // 
                        command.Parameters.AddWithValue("@cchange13", Convert.ToString(seal_term_cover)); // 
                        command.Parameters.AddWithValue("@cchange14", Convert.ToString(seal_mcb)); // 
                        command.Parameters.AddWithValue("@cchange15", Convert.ToString(seal_box)); // 
                        command.Parameters.AddWithValue("@cchange16", Convert.ToString(metrolog)); // 
                        command.Parameters.AddWithValue("@cchange17", Convert.ToString(seal_CT)); // 
                        command.Parameters.AddWithValue("@cchange18", Convert.ToString(seal_modem)); // 
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        for_import_into_BillingbindingSource.MoveNext();
                    }

                    MessageBox.Show("Импорт окончен!!!");
                    tbLocationFileImplrt.Text = "";
                }
                else { MessageBox.Show("Нет ни одного абонента для импорта!!!"); }


            }
            catch (System.Exception ex)
            //catch (System.Exception)
            {
                //MessageBox.Show("Не могу создать файл импорта");
                MessageBox.Show(ex.ToString());
                if (File.Exists(filestr_new_file_import))
                {
                    con.Close();
                    File.Delete(filestr_new_file_import);
                }
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Только для отдаленных районов Талас обл., Кемин, Таш-Добо(АРЭС)");
            if (fbdi.ShowDialog() == DialogResult.OK)
            {
                meters.Properties.Settings.Default.PathImportFiles = fbdi.SelectedPath;
                meters.Properties.Settings.Default.Save();
                tbLocationFileImplrt.Text = fbdi.SelectedPath;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (Globals.doc_status == true)
            {
                MessageBox.Show("Этот документ уже закрыт!!!Открывается только для просмотра");
                Form add = new ADD_meters();
                add.Show();
            }
            else
            {
                Form add = new ADD_meters();
                add.Show();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //this.installedMetersTableAdapter.FillById_user(this.mMSDataSet.InstalledMeters, Globals.id_user, Convert.ToDecimal(comboBox1.Text)); }
                //this.installedMetersTableAdapter.FillBy_id_slujbi(this.mMSDataSet.InstalledMeters, Convert.ToDecimal(comboBox1.Text), Globals.id_slujbi);
                this.installedMetersADDTableAdapter.FillBy_id_slujbi(this.mMSDataSet.InstalledMetersADD, Convert.ToDecimal(comboBox1.Text), Globals.id_slujbi);
            }
            catch { }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_metrolog = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_master2 = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_master = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

       

       
    }
}
