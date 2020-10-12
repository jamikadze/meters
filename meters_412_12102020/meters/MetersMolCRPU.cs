using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace meters
{
    public partial class MetersMolCRPU : Form
    {
        int? id_MMOL, id_MMOL2;
        int? id_MOL, id_MOL2;
        int idShip,addishID;
        private byte[] file;
        private string path = "";
        public MetersMolCRPU()
        {
            InitializeComponent();
        }


        private void MetersMolCRPU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet4.View_reportCRPU' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'mMSDataSet4.Hms_ship' table. You can move, or remove it, as needed.
            //this.hms_shipTableAdapter.Fill(this.mMSDataSet4.Hms_ship);
            this.mETER_MOL_CRPUTableAdapter2.Fill_typedoc(this.mMSDataSet4.METER_MOL_CRPU, 1); 
            this.spr_Executor1TableAdapter.Fill_CRPUexec(this.mMSDataSet4.spr_Executor1);
            this.returnMeterReasonTableAdapter.Fill_Mode(this.mMSDataSet4.ReturnMeterReason, 3);
                
            this.spr_SlujbaTableAdapter3.Fill(this.mMSDataSet4.spr_Slujba);          
            this.spr_MeterTypeTableAdapter.Fill(this.mMSDataSet4.spr_MeterType);
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateEdit1.Text != "" && lookUpEdit1.Text != "" && lookUpEdit2.Text != "")
                {
                    DateTime? date = Convert.ToDateTime(dateEdit1.Text);
                    int? id_user = Globals.id_user;
                    int? id_current_doc = Globals.id_current_doc;
                    queriesTableAdapter1.insert_MeterMOLCRPU(date, id_MOL, id_MMOL, id_user, ref id_current_doc, 1, Globals.id_slujbi);
                    this.mETER_MOL_CRPUTableAdapter2.Fill_typedoc(this.mMSDataSet4.METER_MOL_CRPU, 1);  
                    BS_METER_MOL_CRPU.MoveLast();
                    dateEdit1.Text = "";
                    lookUpEdit1.EditValue = null;
                    lookUpEdit2.EditValue = null;
                   // Globals.Current_doc_CRPUissud = id_current_doc;
                    groupControl3.Visible = true;
                    groupBox1.Visible = false;
                    radioButton4.Checked = true;
                    textBox1.Focus();

                }
                else { MessageBox.Show("Не все поля заполнены"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.id_slujbi = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                this.spr_ExecutorTableAdapter2.FillBy_id_slujba(this.mMSDataSet4.spr_Executor, Globals.id_slujbi);
               
            }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MOL = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MMOL = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupBox1.Visible = true;
                textBox1.Visible = false;
                //radioButton4.Checked = false;
                //textEdit2.Focus();
            }
        }
        private void FindmeterINFO()
        {
            try
            {

                this.meterMOLdocs2_poiskTableAdapter.Fill_LastIssudMeter(this.mMSDataSet4.MeterMOLdocs2_poisk, Globals.znum, Globals.id_slujbi);

                if (this.mMSDataSet4.MeterMOLdocs2_poisk.Rows.Count != 0)
                {

                    foreach (DataRow tr in mMSDataSet4.MeterMOLdocs2_poisk.Rows)
                    {

                        //if ((tr[9].ToString().Equals("12") || tr[9].ToString().Equals("13")))
                        //{
                        if (Convert.ToInt32(((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["id_Meterstatus"]) == 12
                               || Convert.ToInt32(((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["id_Meterstatus"]) == 13)
                        {
                            MessageBox.Show("Cчетчик № " + Globals.znum + "нельзя вернуть.Оплочено(ввостановлено)! \nСообщите Серверэлектро МОЛ МС");
                            //return;
                            textBox1.Text = "";
                            textEdit2.Text = "";
                        }
                        if (Convert.ToInt32(((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["id_Meterstatus"]) == 4
                            || Convert.ToInt32(((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["id_Meterstatus"]) == 3
                            || Convert.ToInt32(((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["id_Meterstatus"]) == 6)
                        {
                            int f=this.hisMETsimTableAdapter.Fill_SerNo(this.mMSDataSet4.HisMETsim, Globals.znum);
                            if (f > 0)
                            {
                                TE_SimNumber.Text = ((DataRowView)BS_HisMETsim.Current).Row["SimNo1"].ToString();
                            }
                            
                            //lookUpEdit3.EditValue = ((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["MeterType"].ToString();
                            //Globals.id_meter_type = Convert.ToInt32(((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["id_Type"]);

                            TE_MODEM.Text = ((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["Seal_Modem"].ToString();
                            TE_GP.Text = ((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["Seal_GP"].ToString();
                            TE_CRPU.Text = ((DataRowView)BS_MeterMOLdocs2_poisk.Current).Row["Seal_CRPU"].ToString();
                            int? idrn = Convert.ToInt32(Globals.id_slujbi);
                            int k = this.allCallsp_findRN_CRPUTableAdapter.Fill(this.metersDataSet1.allCallsp_findRN_CRPU, idrn, Globals.znum);
                         
                            if (k > 0)
                            {
                                TE_custNumber.Text = ((DataRowView)BS_allCallsp_findRN_CRPU1.Current).Row["cspot"].ToString();
                                TE_cust_name.Text = ((DataRowView)BS_allCallsp_findRN_CRPU1.Current).Row["cspot2"].ToString();
                                string addres1 = ((DataRowView)BS_allCallsp_findRN_CRPU1.Current).Row["address1"].ToString();
                                string addres2 = ((DataRowView)BS_allCallsp_findRN_CRPU1.Current).Row["address2"].ToString();

                                TE_Adres.Text = addres1 + ";" + addres2;
                            }
                            else
                            {
                                int d = this.installedMeters2TableAdapter.FillSerialNO(this.mMSDataSet4.InstalledMeters2, Globals.znum);
                                if (d > 0)
                                {
                                    TE_custNumber.Text = ((DataRowView)BS_InstalledMeters2.Current).Row["CustomerCode"].ToString();
                                    TE_cust_name.Text = ((DataRowView)BS_InstalledMeters2.Current).Row["CustomerName"].ToString();
                                    string addres1 = ((DataRowView)BS_InstalledMeters2.Current).Row["Address"].ToString();
                                    string addres2 = ((DataRowView)BS_InstalledMeters2.Current).Row["Dom_kv"].ToString();

                                    TE_Adres.Text = addres1 + ";" + addres2;
                                }
                            }


                        }
                        else
                        {
                            MessageBox.Show("Cчетчик № " + Globals.znum + "нельзя вернуть. Возможно не было выдано или установлено! Возможно он уже возвращен в ЦРПУ, \nсмотрите последний статус");
                            //return;
                            textBox1.Text = "";
                            textEdit2.Text = "";
                        }
                            //queriesTableAdapter1.insert_one_meter_MeterMOLdocs2(Globals.id_doc_meter_mol_docs, id_shipments);
                            //this.shipmentsTableAdapter.UpdateStatus_returned(id_shipments);

                       // }
                       // else
                       // {
                       //     MessageBox.Show("Cчетчик № " + Globals.znum + "нельзя вернуть повторно. Возможно он уже возвращен в ЦРПУ, \nсмотрите последний статус");
                       //     return;
                       // }
                    }

                }
                else
                {
                    MessageBox.Show("Cчетчик №  " + Globals.znum + " нельзя вернуть! Он ни разу не выдавался(На складе) \nили не относится к данному району который возвращяет ПУ! \nСообщите Серверэлектро МОЛ МС");
                    //return;
                    textBox1.Text = "";
                    textEdit2.Text = "";
                }

            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox11_TextChanged(null, null);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
         (e.KeyChar != '9')

       )
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Globals.str = textBox1.Text;
            if (textBox1.Text.Length == 23 )

            {           
                Globals.wtr = Globals.str.Substring(0, 3);
                Globals.znum = Globals.str.Substring(15, 8);
            }
            if (textBox1.Text.Length == 24 )

            {           
                Globals.wtr = Globals.str.Substring(0, 4);
                Globals.znum = Globals.str.Substring(16, 8);
            }
            else
            {
                MessageBox.Show("Штрих код не совпадает!");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }

                this.spr_MeterTypeTableAdapter.FillByTYPE_meter(this.mMSDataSet4.spr_MeterType, Globals.wtr);
                if (BS_spr_MeterType.Count > 0)
                {
                    Globals.id_meter_type = Convert.ToInt32(((DataRowView)BS_spr_MeterType.Current).Row["id_Type"]);
                    lookUpEdit3.EditValue = Globals.id_meter_type;
                    
                    
                    this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet4.Shipments, Globals.znum, Globals.id_meter_type);
                    if (shipmentsBindingSource.Count > 0)
                    {
                        int id_shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                        Globals.idShipDeff = id_shipments;
                        FindmeterINFO();
                        TE_SimNumber.Focus();
                       
                    }
                    else { MessageBox.Show("Нет такого счетчика " + Globals.znum + " в Shipments");
                    textBox1.Text = "";
                    textBox1.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("Нет такого типа ПУ. Позвоните на 64-23, чтобы завели в справочник");
                }
            
            
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dateEdit1.Text = "";
            lookUpEdit1.EditValue = null;
            lookUpEdit2.EditValue = null;
            groupControl3.Visible = false;
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Проверье пожалуйста еще раз № ПУ, далее удалению из документа не подлежит! \nесли совпадает нажмите -ДА-", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 if (Globals.znum.Length > 0 && TE_Adres.Text != "" && TE_CRPU.Text != "" && TE_cust_name.Text != "" && TE_GP.Text != "" &&
                 TE_MODEM.Text != "" && TE_custNumber.Text != "" && TE_SimNumber.Text != "")
                 {

                     queriesTableAdapter1.insert_METER_MOL_CRPU2(Globals.idShipDeff, Globals.id_current_doc, TE_custNumber.Text.Trim(), TE_cust_name.Text.Trim(),
                         TE_Adres.Text.Trim(), CB_modem.Checked, Globals.SimIDdeff, CB_Tcover.Checked, CB_antenna.Checked, TE_CRPU.Text.Trim(), TE_MODEM.Text.Trim(),
                         TE_GP.Text.Trim(), TE_reading.Text.Trim(), file, CB_modemCover.Checked, path);

                 }
                 else 
                 {
                     MessageBox.Show("Не все поля заполнены!");
                     return;
                 }
             }
             bt_Cancel_Click(sender, e);
             this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, Globals.id_current_doc);
            // BS_METER_MOL_CRPU2.MoveLast();
             Globals.idDeff2 = 0;
             //Globals.iddeffect = 0;
             //Globals.id_current_doc = 0;
             Globals.docdeffetM = false;
             Globals.statusDEff = 0;
             Globals.SimIDdeff = 0;
             path = "";


             
        }

        private void textEdit2_Leave(object sender, EventArgs e)
        {
            this.shipmentsTableAdapter.FillBySERIALNO(this.mMSDataSet4.Shipments, textEdit2.Text.Trim());
            if (shipmentsBindingSource.Count > 0)
            {
                Globals.znum=textEdit2.Text.Trim();                     
                Globals.idShipDeff = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                Globals.idTypeM = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id_MeterType"]);
                lookUpEdit3.EditValue = Globals.idTypeM;
                Globals.id_meter_type = Globals.idTypeM;
                FindmeterINFO();
                TE_SimNumber.Focus();
                
                //lookUpEdit3.Focus();
            }
            else
            {
                MessageBox.Show("Нет такого счетчика " + textEdit2.Text.Trim() + " в Shipments");
                textEdit2.Text = "";
                return;
            }         
            
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.docdeffetM == true) 
                { MessageBox.Show("Документ закрыт!!! Нельзя добавить счетчик в данный документ № "+Globals.docdeffetM); }
                else
                {
                    groupControl3.Visible = true;
                    groupBox1.Visible = false;
                    radioButton4.Checked = true;
                    textBox1.Visible = true;
                          
                }
            }
            catch { }
        }

        private void BS_View_METER_MOLCRPU_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.iddeffect = Convert.ToInt32(((DataRowView)BS_METER_MOL_CRPU.Current).Row["ID_def"]);
                Globals.idDeff2=Convert.ToInt32(((DataRowView)BS_View_METER_MOLCRPU.Current).Row["ID_def2"]);
                idShip = Convert.ToInt32(((DataRowView)BS_View_METER_MOLCRPU.Current).Row["ID_Shipments"]); 
            }
            catch { }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            TE_Adres.Text = "";
            TE_CRPU.Text = "";
            TE_cust_name.Text = "";
            TE_GP.Text = "";
            TE_SimNumber.Text = "";
            TE_MODEM.Text = "";
            TE_custNumber.Text = "";
            textBox1.Text = "";
            textEdit2.Text = "";
            lookUpEdit3.EditValue = null;
            CB_antenna.Checked = false;
            CB_modem.Checked = false;
            CB_Tcover.Checked = false;
            CB_modemCover.Checked = false;
        }

        private void BT_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.SafeFileName;
                Stream filestream;
                filestream = ofd.OpenFile();
                file = new byte[filestream.Length];
                filestream.Read(file, 0, (int)filestream.Length);
                filestream.Close();
                MessageBox.Show("Файл сохранен!", "К сведению:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TE_SimNumber_Leave(object sender, EventArgs e)
        {
          int l=  this.simTableAdapter.FillBySIM(mMSDataSet4.Sim, TE_SimNumber.Text.Trim());
          if (l > 0)
              Globals.SimIDdeff = Convert.ToInt32(((DataRowView)BS_Sim.Current).Row["id"]);
          else
          {
              MessageBox.Show("Данный симкарта № " + TE_SimNumber.Text.Trim()+"  не найден в базе, обратитесь в ОИТ!");
              TE_SimNumber.Text = "";
              //TE_SimNumber.Focus();
          }

        }

        private void BS_METER_MOL_CRPU2_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.idDeff2 = Convert.ToInt32(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["ID_def2"]);
                //Globals.iddeffect = Convert.ToInt32(((DataRowView)BS_METER_MOL_CRPU.Current).Row["ID_def"]);
                // Globals.docdeffetM = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU.Current).Row["DOC_status"]);
               
                //if ((((DataRowView)BS_METER_MOL_CRPU.Current).Row["DOC_status"]) is DBNull)
                //{ Globals.docdeffetM = false; }
                //else
                //{
                //    Globals.docdeffetM = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU.Current).Row["DOC_status"]);
                //}
            }
            catch { }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                //radioButton4.Checked = true;
                groupBox1.Visible = false;
                textBox1.Visible = true;
                //radioButton4.Checked = false;
               
            }
        }

        private void BS_METER_MOL_CRPU_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.iddeffect = Convert.ToInt32(((DataRowView)BS_METER_MOL_CRPU.Current).Row["ID_def"]);
                Globals.id_slujbi = Convert.ToInt32(((DataRowView)BS_METER_MOL_CRPU.Current).Row["ID_slujba"]);
                Globals.id_current_doc = Globals.iddeffect;
                Globals.Current_doc_CRPUissud = Globals.iddeffect;
                // Globals.docdeffetM = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU.Current).Row["DOC_status"]);
                if ((((DataRowView)BS_METER_MOL_CRPU.Current).Row["DOC_status"]) is DBNull)
                { Globals.docdeffetM = false; }
                else
                {
                    Globals.docdeffetM = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU.Current).Row["DOC_status"]);
                }
            }
            catch { }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Вы действительно \nхотите закрыть дркумент \nи сформировать накладной на возврат В ЦРПУ???", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 if (Globals.docdeffetM == true)
                 {
                     DialogResult result1 = MessageBox.Show("Данный документ уже закрыт! хотите посмотреть акт прием-передачи?", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (result1 == DialogResult.Yes)
                     {
                         if (Globals.iddeffect != 0)
                         {
                             Form S = new ReturnMeters();
                             S.Show();
                         }
                         else 
                         {
                             MessageBox.Show("Выберите документ!");                         
                         }
                        
                     }

                 }
                 else
                 {
                     this.mETER_MOL_CRPUTableAdapter2.UpdateDocstatus(Globals.iddeffect);                     
                     Form S = new ReturnMeters();
                     S.Show();                 
                 }
                 
             }
             //this.mETER_MOL_CRPUTableAdapter2.Fill(this.mMSDataSet4.METER_MOL_CRPU);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit6.Text);
            DateTime d = Convert.ToDateTime(dateEdit5.Text);
            this.view_METER_MOLCRPUTableAdapter.Fill_date(mMSDataSet4.View_METER_MOLCRPU, s, d);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.view_METER_MOLCRPUTableAdapter.Fill(mMSDataSet4.View_METER_MOLCRPU);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.idDeff2 != 0)
                {
                    Form d = new deffectedList();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("Данные отсутствует или документ пустой! \nвы не можете поменять статус!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.id_meter_type = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");

            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.mETER_MOL_CRPU2TableAdapter2.FillBy_CountImport(this.mMSDataSet4.METER_MOL_CRPU2);
            textEdit1.Text = BS_METER_MOL_CRPU2.Count.ToString();
            //this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, 0);
            
            this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, Globals.id_current_doc);
            textEdit3.Text = BS_METER_MOL_CRPU2.Count.ToString();
            BS_METER_MOL_CRPU2.MoveLast();
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id4grid = Globals.id_current_doc;

            //SMMDataSet.zamenaDataTable zamdt = new SMMDataSet.zamenaDataTable();
            //zamdt = this.sMMDataSet.zamena;
            //this.zamenaTableAdapter.Fill_likeIDz(zamdt, id4grid);
            this.view_METER_MOLCRPUTableAdapter.Fill_ID_def2(mMSDataSet4.View_METER_MOLCRPU, Globals.idDeff2);
            //this.zamenaTableAdapter.Fill_PDFfile(this.sMMDataSet.zamena,id4grid);
            if (this.mMSDataSet4.View_METER_MOLCRPU.Rows[0]["FILE_deff_name"] == DBNull.Value)
                MessageBox.Show("Файл для этого ПУ отсутствует");
            else
            {
                byte[] b1 = (byte[])this.mMSDataSet4.View_METER_MOLCRPU.Rows[0]["FILE_deff"];
                string exens4grid = Convert.ToString(this.mMSDataSet4.View_METER_MOLCRPU.Rows[0]["FILE_deff_name"]);
                exens4grid = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName(); //.Replace(".tmp", exens4grid);
                filename = filename.Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            //this.zamenaTableAdapter.Fill(this.sMMDataSet.zamena);
            //Glob.id_correct_row = 0;
            id4grid = 0;
        }

        private void показатьФайлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id4grid = Globals.id_current_doc;            
            //this.view_METER_MOLCRPUTableAdapter.Fill_ID_def2(mMSDataSet4.View_METER_MOLCRPU, Globals.idDeff2);
            //if(Globals.idDeff2!=0)
            //{
            //    if (this.mMSDataSet4.View_METER_MOLCRPU.Rows[0]["FILE_deff_name"] == DBNull.Value)
            //        MessageBox.Show("Файл для данного ПУ отсутствует");
            //    else
            //    {
            //        byte[] b1 = (byte[])this.mMSDataSet4.View_METER_MOLCRPU.Rows[0]["FILE_deff"];
            //        string exens4grid = Convert.ToString(this.mMSDataSet4.View_METER_MOLCRPU.Rows[0]["FILE_deff_name"]);
            //        exens4grid = Path.GetExtension(exens4grid);
            //        string filename = System.IO.Path.GetTempFileName(); //.Replace(".tmp", exens4grid);
            //        filename = filename.Replace(".tmp", exens4grid);
            //        var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
            //        bw.Write(b1);
            //        bw.Close();
            //        Process.Start(filename);
            //    }         
            this.mETER_MOL_CRPU2TableAdapter2.Fill_ID_Deff2(this.mMSDataSet4.METER_MOL_CRPU2, Globals.idDeff2);
            if (this.mMSDataSet4.METER_MOL_CRPU2.Rows.Count != 0)
            {
                foreach (DataRow tr in mMSDataSet4.METER_MOL_CRPU2.Rows)
                {
                    string fname = tr["FILE_deff_name"].ToString();
                    if (fname.Length > 0)
                    {
                        byte[] b1 = (byte[])this.mMSDataSet4.METER_MOL_CRPU2.Rows[0]["FILE_deff"];
                        string exens4grid = Convert.ToString(this.mMSDataSet4.METER_MOL_CRPU2.Rows[0]["FILE_deff_name"]);
                        exens4grid = Path.GetExtension(exens4grid);
                        string filename = System.IO.Path.GetTempFileName(); //.Replace(".tmp", exens4grid);
                        filename = filename.Replace(".tmp", exens4grid);
                        var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                        bw.Write(b1);
                        bw.Close();
                        Process.Start(filename);
                    }
                    else
                    {
                        MessageBox.Show("Файл для данного ПУ отсутствует");
                    }
                    break;
                }
                id4grid = 0;
                path = "";
            }
            else
            {
                MessageBox.Show("Файл для данного ПУ отсутствует \nили документ пустой!");            
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                this.mETER_MOL_CRPU2TableAdapter2.FillBy_CountImport(this.mMSDataSet4.METER_MOL_CRPU2);
                textEdit1.Text = BS_METER_MOL_CRPU2.Count.ToString();
                this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, 0);
                this.mETER_MOL_CRPUTableAdapter2.Fill_typedoc(this.mMSDataSet4.METER_MOL_CRPU,1);
                Globals.idDeff2 = 0;
                Globals.iddeffect = 0;
                Globals.id_current_doc = 0;
                Globals.docdeffetM = false;
                Globals.statusDEff = 0;
                Globals.SimIDdeff = 0;
                path = ""; 
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                this.view_METER_MOLCRPUTableAdapter.Fill(this.mMSDataSet4.View_METER_MOLCRPU);
                this.mETER_MOL_CRPUTableAdapter2.Fill_typedoc(this.mMSDataSet4.METER_MOL_CRPU, 0);
                Globals.idDeff2 = 0;
                Globals.iddeffect = 0;
                Globals.id_current_doc = 0;
                Globals.docdeffetM = false;
                Globals.statusDEff = 0;
                Globals.SimIDdeff = 0;
                path = "";

            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
            {
                this.mETER_MOL_CRPUTableAdapter2.Fill_typedoc(this.mMSDataSet4.METER_MOL_CRPU, 0);
                this.returnMeterReasonTableAdapter.Fill_Mode(this.mMSDataSet4.ReturnMeterReason, 3);            

                this.mETER_MOL_CRPU2TableAdapter2.FillBy_countIssud(this.mMSDataSet4.METER_MOL_CRPU2);
                TE_countdocALL.Text = BS_METER_MOL_CRPU2.Count.ToString();
                this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, 0);
                Globals.idDeff2 = 0;
                Globals.iddeffect = 0;
                Globals.id_current_doc = 0;
                Globals.docdeffetM = false;
                Globals.statusDEff = 0;
                Globals.SimIDdeff = 0;
                path = "";
            }
        }

        private void BT_creatDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateEdit2.Text != "" && lookUpImportName.Text != "" && lookUpExportName.Text != "")
                {
                    DateTime? date1 = Convert.ToDateTime(dateEdit2.Text);
                    int? id_user2 = Globals.id_user;
                    int? id_current_doc2 = Globals.Current_doc_CRPUissud;
                    queriesTableAdapter1.insert_MeterMOLCRPU(date1, id_MOL2, id_MMOL2, id_user2, ref id_current_doc2, 0, Globals.id_slujbi);
                    this.mETER_MOL_CRPUTableAdapter2.Fill_typedoc(this.mMSDataSet4.METER_MOL_CRPU, 0);  
                    BS_METER_MOL_CRPU.MoveLast();
                    dateEdit2.Text = "";
                    lookUpImportName.EditValue = null;
                    lookUpExportName.EditValue = null;

                    groupControl6.Visible = true;
                    groupBox2.Visible = false;
                    radioButton4.Checked = true;
                    TB_shtrih.Focus();

                }
                else { MessageBox.Show("Не все поля заполнены"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void BT_creatNEWDoc_Click(object sender, EventArgs e)
        {
            dateEdit2.Text = "";
            lookUpImportName.EditValue = null;
            lookUpExportName.EditValue = null;
            groupControl6.Visible = false;
            lookUpRegion.EditValue = null;
            Globals.id_current_doc = 0;
        }

        private void BT_cancel2_Click(object sender, EventArgs e)
        {
           
            TB_CRPU.Text = "";            
            TB_GP.Text = "";
            TB_Simno.Text = "";
            TB_Modem.Text = "";
            TB_shtrih.Text = "";
            TE_serNo.Text = "";
            lookUpEdit5.EditValue = null;
            CB_Antenna2.Checked = false;
            CB_TermCover2.Checked = false;
            CB_Modem2.Checked = false;            
            CB_ModemCover2.Checked = false;
        }

        private void BT_insert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Проверье пожалуйста еще раз № ПУ, далее удалению из документа не подлежит! \nесли совпадает нажмите -ДА-", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Globals.znum.Length > 0 && TB_CRPU.Text != "" && TB_GP.Text != "" && TB_Modem.Text != "" && TB_Simno.Text != "")
                {
                    //int t1 = this.sealFindTableAdapter.Fill(mMSDataSet4.sealFind, TB_CRPU.Text.Trim(), 1);
                    int t1 = this.shipmentsTableAdapter.sealCRPU(mMSDataSet4.Shipments, TB_CRPU.Text.Trim());
                    if (t1 > 0)
                    {
                        
                        string sernocr = Convert.ToString(((DataRowView)shipmentsBindingSource.Current).Row["SerialNo"]);
                        if (Globals.znum != sernocr)
                        {
                            MessageBox.Show("№ ЦРПУ пломбы  " + TB_CRPU.Text.Trim() + "  уже стоит на другом ПУ " + sernocr + "!!!");
                            TE_CRPU.Focus();
                            return; 
                        }
                        
                    }
                    //int t2 = this.sealFindTableAdapter.Fill(mMSDataSet4.sealFind, TB_Modem.Text.Trim(), 2);
                    int t2 = this.shipmentsTableAdapter.sealMODEM(mMSDataSet4.Shipments, TB_Modem.Text.Trim());
                    if (t2 >0)
                    {
                        string sernomod = Convert.ToString(((DataRowView)shipmentsBindingSource.Current).Row["SerialNo"]);
                        if (Globals.znum != sernomod)
                        {
                            MessageBox.Show("№ Модем пломбы  " + TB_Modem.Text.Trim() + " уже стоит на другом ПУ " + sernomod + "!!!");
                            TB_Modem.Focus();
                            return;
                        }
                    }
                   //int t= this.hms_shipTableAdapter.Fill_SimNo(this.mMSDataSet4.Hms_ship, TB_Simno.Text.Trim());
                    if (addishID != 0)
                   {
                    //   Globals.SimIDdeff=Convert.ToInt32(((DataRowView)BS_Hms_ship.Current).Row["id_Sim"]);                           
                       queriesTableAdapter1.updateCancel_METER_MOL_CRPU2(Globals.idShipDeff);
                       queriesTableAdapter1.insert_METER_MOL_CRPU2_issud(Globals.idShipDeff, Globals.Current_doc_CRPUissud, CB_Modem2.Checked,
                           Globals.SimIDdeff, CB_TermCover2.Checked, CB_Antenna2.Checked, TB_CRPU.Text.Trim(), TB_Modem.Text.Trim(),
                           TB_GP.Text.Trim(), TB_Writing.Text.Trim(), CB_ModemCover2.Checked, addishID);
                   }
                   else
                   {
                       MessageBox.Show("Выберите причину ремонта!");
                       return;                 
                   }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!");
                    return;
                }
            }
            bt_Cancel_Click(sender, e);
            this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, Globals.id_current_doc);
            BS_METER_MOL_CRPU2.MoveLast();
            //Globals.idDeff2 = 0;
            //Globals.iddeffect = 0;
            //Globals.id_current_doc = 0;
            Globals.docdeffetM = false;
            Globals.statusDEff = 0;
            Globals.SimIDdeff = 0;
            Globals.znum = "";
            TB_Simno.Text = "";
            TE_serNo.Text = "";
            TB_shtrih.Text = "";
            path = "";
            addishID = 0;
        }

       

        private void TE_serNo_Leave(object sender, EventArgs e)
        {
            this.shipmentsTableAdapter.FillBySERIALNO(this.mMSDataSet4.Shipments, TE_serNo.Text.Trim());
            if (shipmentsBindingSource.Count > 0)
            {
                Globals.znum = TE_serNo.Text.Trim();
                Globals.idShipDeff = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                Globals.idTypeM = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id_MeterType"]);
                lookUpEdit8.EditValue = Globals.idTypeM;
                Globals.id_meter_type = Globals.idTypeM;
                               
                int kk = this.mETER_MOL_CRPU2TableAdapter2.Fill_id_ship(this.mMSDataSet4.METER_MOL_CRPU2, Globals.idShipDeff);
                if (kk > 0)
                {                    
                    TB_Writing.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["METER_READINGS"].ToString();
                    TB_GP.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["SEAL_GP"].ToString();
                    TB_Modem.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["SEAL_MODEM"].ToString();
                    TB_CRPU.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["SEAL_CRPU"].ToString();
                    CB_Modem2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["MODEM"]);
                    CB_ModemCover2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["MODEM_cover"]);
                    CB_TermCover2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["TERMINAL_cover"]);
                    CB_Antenna2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["ANTENNA"]);
                    this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, 0);
                }
                else
                {
                    MessageBox.Show("Вы не можете выдать данный ПУ  "+TE_serNo.Text.Trim()+" Причина: не было принята в ЦРПУ! \nПроверьте документ!");
                    return;
                }
                //FindmeterINFO();   
                int f = this.hisMETsimTableAdapter.Fill_SerNo(this.mMSDataSet4.HisMETsim, Globals.znum);
                if (f > 0)
                {
                    TB_Simno.Text = ((DataRowView)BS_HisMETsim.Current).Row["SimNo1"].ToString();
                    TB_Simno.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Нет такого счетчика " + TE_serNo.Text.Trim() + " в Shipments");
                TE_serNo.Text = "";
                return;
            }
            
        }

        private void TB_shtrih_TextChanged(object sender, EventArgs e)
        {

            Globals.str = TB_shtrih.Text;
            
            if (TB_shtrih.Text.Length == 23)
            {                
                Globals.wtr = Globals.str.Substring(0, 3);
                Globals.znum = Globals.str.Substring(15, 8);
            }
            if (TB_shtrih.Text.Length == 24)
            {                
                Globals.wtr = Globals.str.Substring(0, 4);
                Globals.znum = Globals.str.Substring(16, 8);
            }

            else
            {
                MessageBox.Show("Штрих код не совподает!");
                TB_shtrih.Text = "";
                TB_shtrih.Focus();
                return;
            }

                this.spr_MeterTypeTableAdapter.FillByTYPE_meter(this.mMSDataSet4.spr_MeterType, Globals.wtr);
                if (BS_spr_MeterType.Count > 0)
                {
                    Globals.id_meter_type = Convert.ToInt32(((DataRowView)BS_spr_MeterType.Current).Row["id_Type"]);
                    
                    this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet4.Shipments, Globals.znum, Globals.id_meter_type);
                    if (shipmentsBindingSource.Count > 0)
                    {
                        lookUpEdit8.EditValue = Globals.id_meter_type;                        
                        Globals.idShipDeff = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                
                        int kkk = this.mETER_MOL_CRPU2TableAdapter2.Fill_id_ship(this.mMSDataSet4.METER_MOL_CRPU2, Globals.idShipDeff);
                        if (kkk > 0)
                            {
                    
                                TB_Writing.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["METER_READINGS"].ToString();
                                TB_GP.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["SEAL_GP"].ToString();
                                TB_Modem.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["SEAL_MODEM"].ToString();
                                TB_CRPU.Text = ((DataRowView)BS_METER_MOL_CRPU2.Current).Row["SEAL_CRPU"].ToString();
                                CB_Modem2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["MODEM"]);
                                CB_ModemCover2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["MODEM_cover"]);
                                CB_TermCover2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["TERMINAL_cover"]);
                                CB_Antenna2.Checked = Convert.ToBoolean(((DataRowView)BS_METER_MOL_CRPU2.Current).Row["ANTENNA"]);
                                this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, 0);

                        //int kkk = this.view_METER_MOLCRPUTableAdapter.FillSerNo(this.mMSDataSet4.View_METER_MOLCRPU, Globals.znum.Trim());
                        //if (kkk > 0)
                        //{
                        //    TB_Writing.Text = ((DataRowView)BS_View_METER_MOLCRPU.Current).Row["METER_READINGS"].ToString();
                        //    TB_GP.Text = ((DataRowView)BS_View_METER_MOLCRPU.Current).Row["SEAL_GP"].ToString();
                        //    TB_Modem.Text = ((DataRowView)BS_View_METER_MOLCRPU.Current).Row["SEAL_MODEM"].ToString();
                        //    TB_CRPU.Text = ((DataRowView)BS_View_METER_MOLCRPU.Current).Row["SEAL_CRPU"].ToString();
                        //    CB_Modem2.Checked = Convert.ToBoolean(((DataRowView)BS_View_METER_MOLCRPU.Current).Row["MODEM"]);
                        //    CB_ModemCover2.Checked = Convert.ToBoolean(((DataRowView)BS_View_METER_MOLCRPU.Current).Row["MODEM_cover"]);
                        //    CB_TermCover2.Checked = Convert.ToBoolean(((DataRowView)BS_View_METER_MOLCRPU.Current).Row["TERMINAL_cover"]);
                        //    CB_Antenna2.Checked = Convert.ToBoolean(((DataRowView)BS_View_METER_MOLCRPU.Current).Row["ANTENNA"]);
                            }
                            else
                            {
                               MessageBox.Show("Вы не можете выдать анный ПУ  " + TB_shtrih.Text.Trim() + "Причина: не было принята в ЦРПУ! \nПроверьте документ!");
                               return;
                            }
                        
                        int f = this.hisMETsimTableAdapter.Fill_SerNo(this.mMSDataSet4.HisMETsim, Globals.znum);
                        if (f > 0)
                        {
                            TB_Simno.Text = ((DataRowView)BS_HisMETsim.Current).Row["SimNo1"].ToString();
                            TB_Simno.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого счетчика " + Globals.znum + " в Shipments");
                        TB_shtrih.Text = "";
                        TB_shtrih.Focus();
                    }
                                                    
            }
             

                else
                {
                    MessageBox.Show("Нет такого типа ПУ. Позвоните на 64-23, чтобы завели в справочник");
                }
           
            
        }

        private void TB_shtrih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TB_shtrih_TextChanged(null, null);
            }
        }

        private void TE_MODEM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BT_find_Click(object sender, EventArgs e)
        {
            this.hms_shipTableAdapter.FillByMeterNo(mMSDataSet4.Hms_ship, TE_meterNo.Text.Trim());
        }

        private void BT_findSeal_Click(object sender, EventArgs e)
        {
            string seal = '%' + TE_SealNo.Text.Trim();
            this.hms_shipTableAdapter.Fill_likeSeals(mMSDataSet4.Hms_ship, seal);
        }

        private void списатьПУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Списать данный ПУ?", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.shipmentsTableAdapter.UpdateWriteOFF(idShip);
                this.mETER_MOL_CRPU2TableAdapter2.Update_retREASON(15, Globals.idDeff2);

                MessageBox.Show("Отмечено!");
                this.view_METER_MOLCRPUTableAdapter.Fill(mMSDataSet4.View_METER_MOLCRPU);
                
            }
        }

        private void lookUpRegion_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.id_slujbi = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                this.spr_ExecutorTableAdapter2.FillBy_id_slujba(this.mMSDataSet4.spr_Executor, Globals.id_slujbi);

            }
        }

        private void gridControl4_DoubleClick(object sender, EventArgs e)
        {

            this.mETER_MOL_CRPU2TableAdapter2.FillBy_countIssud(this.mMSDataSet4.METER_MOL_CRPU2);
            TE_countdocALL.Text = BS_METER_MOL_CRPU2.Count.ToString();
            this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, Globals.Current_doc_CRPUissud);
            int docCount = BS_METER_MOL_CRPU2.Count;
            TE_countdoc.Text = docCount.ToString();
            BS_METER_MOL_CRPU2.MoveLast();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно \nхотите закрыть дркумент \nи сформировать накладной на выдачу для МОЛ???", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Globals.docdeffetM == true)
                {
                    DialogResult result1 = MessageBox.Show("Данный документ уже закрыт! хотите посмотреть акт прием-передачи?", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        if (Globals.iddeffect != 0)
                        {
                            Form S = new ReturnMeters();
                            S.Show();
                        }
                        else
                        {
                            MessageBox.Show("Выберите документ!");
                        }

                    }

                }
                else
                {
                    this.mETER_MOL_CRPUTableAdapter2.UpdateDocstatus(Globals.iddeffect);
                    Form S = new ReturnMeters();
                    S.Show();
                }

            }
        }

        private void добавитьПУВДанныйДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.docdeffetM == true)
                { MessageBox.Show("Документ закрыт!!! Нельзя добавить счетчик в данный документ № " + Globals.docdeffetM); }
                else
                {
                    groupControl6.Visible = true;
                    groupBox2.Visible = false;
                    radioButton2.Checked = true;
                    TB_shtrih.Visible = true;

                }
            }
            catch { }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Visible = true;
                TB_shtrih.Visible = false;                
                //radioButton4.Checked = false;
                //textEdit2.Focus();
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                //radioButton4.Checked = true;
                groupBox2.Visible = false;
                TB_shtrih.Visible = true;
                //radioButton4.Checked = false;

            }
        }

        private void lookUpImportName_Click(object sender, EventArgs e)
        {

        }

        private void lookUpImportName_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MOL2 = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void lookUpExportName_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MMOL2 = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void lookUpEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                addishID = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void TB_Simno_Leave(object sender, EventArgs e)
        {
            int ll = this.simTableAdapter.FillBySIM(mMSDataSet4.Sim, TB_Simno.Text.Trim());
            if (ll > 0)
                Globals.SimIDdeff = Convert.ToInt32(((DataRowView)BS_Sim.Current).Row["id"]);
            else            
            {
                MessageBox.Show("Данный симкарта № " + TB_Simno.Text.Trim() + "  не найден в базе, обратитесь в ОИТ!");
              TB_Simno.Text= "";                            
            }
        }

        private void gridControl4_Click(object sender, EventArgs e)
        {
           this.mETER_MOL_CRPU2TableAdapter2.Fill_id_DEFFECT2(this.mMSDataSet4.METER_MOL_CRPU2, Globals.Current_doc_CRPUissud);
            
           
          
            //this.mETER_MOL_CRPUTableAdapter2.fil
            //    (this.mMSDataSet4.METER_MOL_CRPU,Globals.iddeffect)
            //    this.mETER_MOL_CRPUTableAdapter2.Fill_typedoc(mms)
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.view_reportCRPUTableAdapter.Fill(this.mMSDataSet4.View_reportCRPU);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.TypeRep = 2;
            CRPUreports stl = new CRPUreports();
            stl.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            groupControl3.Visible = true;
            BT_savedoc.Visible = true;
            bt_Cancel.Visible = false;
            BT_ok.Visible = false;
        }

        private void BT_savedoc_Click(object sender, EventArgs e)
        {
            if (path != "" && Globals.idDeff2!=0)
            {
                this.mETER_MOL_CRPU2TableAdapter2.Update_fileDEFF(path, file, Globals.idDeff2);
                Globals.idDeff2 = 0;
                //Globals.iddeffect = 0;
                //Globals.id_current_doc = 0;
                Globals.docdeffetM = false;
                Globals.statusDEff = 0;
                Globals.SimIDdeff = 0;
                path = "";
                MessageBox.Show("Файл прикреплен!");
                groupControl3.Visible = false;
                BT_savedoc.Visible = false;
                bt_Cancel.Visible = true;
                BT_ok.Visible = true;

            }
            else {
                MessageBox.Show("Файл не выбран!");

            }

        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.TypeRep = 3;
            CRPUreports stl = new CRPUreports();
            stl.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.TypeRep = 4;
            CRPUreports stl = new CRPUreports();
            stl.Show();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            if (!gridControl7.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            gridControl7.ShowPrintPreview();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.TypeRep = 5;
            CRPUreports stl = new CRPUreports();
            stl.Show();
        }    
    }
}