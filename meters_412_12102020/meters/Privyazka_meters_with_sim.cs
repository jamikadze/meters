using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace meters
{
    public partial class Privyazka_meters_with_sim : DevExpress.XtraEditors.XtraUserControl
    {
        public Privyazka_meters_with_sim()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (( textEdit2.Text != "") && ( textBox5.Text != "")  )
            {
                if (textEdit2.Text != "0")
                {
                    //-----данная логика работала только для сансинг и хексинг ПУ, далее решение было изменено, будем использовать для всех
                    //if (radioButton1.Checked == true) 
                    //{
                       
                    //    string text3 = textBox5.Text.Substring(0, 3);
                    //    if ((text3 == "160") || (text3 == "161" || text3 == "170" || text3 == "180"))
                    //    {

                    //        Globals.i_posishion = partMeterBindingSource.Position;
                    //        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    //        string namepart = Globals.name_user + "_" + date;
                    //        //textEdit1.Text = namepart.Trim();
                    //        string num_part = namepart;
                    //        int? kol = Convert.ToInt32(textEdit2.Text);
                    //        int? id_part_meter = 0;
                    //        queriesTableAdapter1.insert_PartMeter(num_part, kol, textBox5.Text, ref id_part_meter);
                    //        partMeterTableAdapter.Fill(mMSDataSet.PartMeter, Globals.name_user);
                    //        partMeterBindingSource.MoveLast();
                    //        textEdit1.Text = "";
                    //        textEdit2.Text = "4";
                    //        textBox5.Text = "";
                    //        groupBox1.Visible = true;
                    //        textBox3.Focus();
                    //        partMeterBindingSource.Position = Globals.i_posishion;

                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Выберите штрихКОД коробки"); textBox5.Text = ""; textBox5.Focus();
                    //    }
                    //}
                    //else
                    //{
                    //if(radioButton2.Checked == true)
                    //{
                    ////string text3 = textBox5.Text.Substring(0, 3);

                        
                    //    if (textBox5.TextLength<=6)
                    //    {

                    //        Globals.i_posishion = partMeterBindingSource.Position;
                    //        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    //        string namepart = Globals.name_user + "_" + date;
                    //        textEdit1.Text = namepart.Trim();
                    //        string num_part = namepart;
                    //        int? kol = Convert.ToInt32(textEdit2.Text);
                    //        int? id_part_meter = 0;
                    //        queriesTableAdapter1.insert_PartMeter(num_part, kol, textBox5.Text, ref id_part_meter);  //TrimStart('0')
                    //        partMeterTableAdapter.Fill(mMSDataSet.PartMeter, Globals.name_user);
                    //        partMeterBindingSource.MoveLast();
                    //        textEdit1.Text = "";
                    //        textEdit2.Text = "6";
                    //        textBox5.Text = "";
                    //        groupBox1.Visible = true;
                    //        textBox3.Focus();
                    //        partMeterBindingSource.Position = Globals.i_posishion;

                    //    }
                      
                    //    else
                    //    {
                    //        MessageBox.Show("Выберите штрихКОД коробки"); textBox5.Text = ""; textBox5.Focus();
                    //    }
                    //    }
                    //else
                    //{
                    //  MessageBox.Show("Выберите производителя!");
                    //    return;
                    //}
                    //}
                    Globals.i_posishion = partMeterBindingSource.Position;
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string namepart = Globals.name_user + "_" + date;
                    //textEdit1.Text = namepart.Trim();
                    string num_part = namepart;
                    int? kol = Convert.ToInt32(textEdit2.Text);
                    int? id_part_meter = 0;
                    queriesTableAdapter1.insert_PartMeter(num_part, kol, textBox5.Text, ref id_part_meter);
                    partMeterTableAdapter.Fill(mMSDataSet.PartMeter, Globals.name_user);
                    partMeterBindingSource.MoveLast();
                    textEdit1.Text = "";
                    //textEdit2.Text = 
                    textBox5.Text = "";
                    groupBox1.Visible = true;
                    textBox3.Focus();
                    partMeterBindingSource.Position = Globals.i_posishion;
                }
                else 
                    { 
                        MessageBox.Show("Количество счетчиков не должен быть 0");
                        textEdit2.Text = ""; 
                        textEdit2.Focus(); 
                    }
            }
            else 
            { 
                MessageBox.Show("Не все поля заполнены");
            }
        }

           

        private void Privyazka_meters_with_sim_Load(object sender, EventArgs e)
        {
            try
            {
                if (Globals.id_access != 1)
                {
                    partMeterTableAdapter.Fill(mMSDataSet.PartMeter, Globals.name_user);

                }
                else
                {
                    partMeterTableAdapter.FillBy_admin(mMSDataSet.PartMeter);
                }

                shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                simTableAdapter.Fill(mMSDataSet.Sim);
                usersTableAdapter.Fill(mMSDataSet.Users);
                textBox5.Focus();
               // radioButton2.Checked = true;

                Globals.del_histiry_ship = Privyazka_meters_with_sim_Load1;
                /////adiltai
            }
            catch { }
        }
        private void Privyazka_meters_with_sim_Load1()
        {

            partMeterTableAdapter.Fill(mMSDataSet.PartMeter, Globals.name_user);
            partMeterBindingSource.Position = Globals.i_posishion;
            this.hisMETsimTableAdapter.Fill(mMSDataSet.HisMETsim, Globals.id_Part_Meter);
            shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
            simTableAdapter.Fill(mMSDataSet.Sim);
            usersTableAdapter.Fill(mMSDataSet.Users);
            textBox5.Focus();
        }

        private void partMeterBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_Part_Meter = Convert.ToInt32(((DataRowView)partMeterBindingSource.Current).Row["id"]);
           //     Globals.i_posishion = partMeterBindingSource.Position;
                this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);
                this.hisMETsimTableAdapter.Fill(mMSDataSet.HisMETsim, Globals.id_Part_Meter);
                shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                simTableAdapter.Fill(mMSDataSet.Sim);
                Globals.Quantity = Convert.ToInt32(((DataRowView)partMeterBindingSource.Current).Row["Quantity"]);
                if((((DataRowView)partMeterBindingSource.Current).Row["Status"]) is DBNull)
                { Globals.Part_Meter_status = 0; }
                else {
                Globals.Part_Meter_status = Convert.ToInt32(((DataRowView)partMeterBindingSource.Current).Row["Status"]);}
               
              

            }
            catch { }
        }

      
        private void добавитьСчетчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.Part_Meter_status == 1) { MessageBox.Show("Документ закрыт!!! Нельзя добавить счетчик в партию"); }
            else 
            { groupBox1.Visible = true;

                
            if (Globals.Quantity < Globals.partQuantity)
            {
                 Globals.i_posishion= partMeterBindingSource.Position;
                queriesTableAdapter1.update_part_meter_kol(Globals.id_Part_Meter, Globals.Quantity);
                partMeterTableAdapter.Fill(mMSDataSet.PartMeter, Globals.name_user);
                partMeterBindingSource.Position = Globals.i_posishion;
            }
            
            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 10)
            {

                Globals.str_sim = textBox1.Text;
                Globals.number_sim = Globals.str_sim.Substring(1, 9);
                this.simTableAdapter.FillBySIM(mMSDataSet.Sim, Globals.number_sim);
                if (simBindingSource.Count > 0)
                {
                    Globals.id_sim = Convert.ToInt32(((DataRowView)simBindingSource.Current).Row["id"]);
                    this.historyMeterSimTableAdapter.FillByBindedToSim(mMSDataSet.HistoryMeterSim, Globals.id_sim);
                    if (historyMeterSimBindingSource.Count > 0)
                    {
                       
                        historyMeterSimTableAdapter.UpdateHistoryTypeunbinded(Globals.id_sim);
                        this.simTableAdapter.UpdateSIMStatusDefected(Globals.id_sim);
                        historyMeterSimTableAdapter.FillBySim(mMSDataSet.HistoryMeterSim, Globals.id_sim);
                        if (historyMeterSimBindingSource.Count > 0)
                        {
                            int id_ship = Convert.ToInt32(((DataRowView)historyMeterSimBindingSource.Current).Row["id_Shipments"]);
                            shipmentsTableAdapter.UpdateStatus_unbound(id_ship);
                        }
                        MessageBox.Show("Статус Sim-card " + Globals.number_sim + " успешно сменен на defected");
                    }
                    else {
                        this.simTableAdapter.UpdateSIMStatusDefected(Globals.id_sim);
                        MessageBox.Show("Статус Sim-card " + Globals.number_sim + " успешно сменен на defected");
                    }
                }
                else
                {
                    MessageBox.Show("Нет такой сим-карты " + Globals.number_sim + " в таблице SIM");
                }
                textBox1.Text = "";
                textBox1.Focus();
                this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);
                shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                simTableAdapter.Fill(mMSDataSet.Sim);
            }
            else { MessageBox.Show("Нехватает цифр в штрих-коде(должно быть10 знаков )"); textBox1.Text=""; }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
 
        {
            if (textBox2.Text.Length == 23)
            {

                DialogResult result = MessageBox.Show("Вы действительно \nхотите сменить статус ПУ на predefected \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    Globals.str = textBox2.Text;
                    Globals.wtr = Globals.str.Substring(0, 3);
                    Globals.znum = Globals.str.Substring(15, 8);
                    this.spr_MeterTypeTableAdapter.FillByTYPE_meter(this.mMSDataSet.spr_MeterType, Globals.wtr);
                    if (spr_MeterTypeBindingSource.Count > 0)
                    {
                        Globals.id_meter_type = Convert.ToInt32(((DataRowView)spr_MeterTypeBindingSource.Current).Row["id_Type"]);
                        this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet.Shipments, Globals.znum, Globals.id_meter_type);
                        if (shipmentsBindingSource.Count > 0)
                        {
                            Globals.id_Shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                            Globals.ship_stat = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id_MeterStatus"]);
                            if (Globals.ship_stat == 6) { MessageBox.Show("Этот счетчик " + Globals.znum + " уже проверен и привязан к СИМ-карте"); }
                            else
                            {
                                this.shipmentsTableAdapter.UpdateStatus_Predefected(Globals.id_Shipments);
                                MessageBox.Show("Статус счетчика: " + Globals.znum + " успешно сменен на predefected");
                            }

                        }
                        else
                        {

                            MessageBox.Show("Нет такого счетчика: " + Globals.znum + " в Shipments");


                        }
                    }

                    else
                    {

                        MessageBox.Show("Нет такого типа счетчика, позвоните на 64-23 чтобы завели в справочник");


                    }
                    textBox2.Text = null;

                }
            }
            else { MessageBox.Show("Нехватает цифр в штрих-коде(23 знака)"); textBox2.Text = ""; }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//serialno     
    {
        this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);
            int colpart = historyMeterSimBindingSource.Count;
            if (colpart<Globals.Quantity)
        {
            if ((textBox3.Text.Length == 9) || (textBox3.Text.Length == 23) || (textBox3.Text.Length == 24) || (textBox3.Text.Length == 12))
                {

                    Globals.str = textBox3.Text;
                    Globals.wtr = Globals.str.Substring(0, 3);
                  
                    if (textBox3.Text.Length == 24)
                    {
                        if (Globals.wtr == "077" || Globals.wtr == "078" || Globals.wtr == "069")
                        {
                            Globals.wtr = Globals.str.Substring(0, 4);
                            Globals.znum = Globals.str.Substring(16, 8);
                        }
                        else Globals.znum = Globals.str.Substring(15, 9);
                        }
                    else if (textBox3.Text.Length == 23)
                    {
                        Globals.znum = Globals.str.Substring(15, 8);
                    }
                    else if (textBox3.Text.Length == 9)
                    {
                        Globals.znum = Globals.str.Substring(1, 8);
                       string str5 = textBox3.Text;
                        string wtr2 = str5.Substring(0, 4);

                        if (wtr2=="0007")
                        {
                        Globals.wtr="020";
                        }
                        if (wtr2=="0008")
                        {
                        Globals.wtr="021";
                        }
                        if (wtr2 == "0009")
                        {
                        Globals.wtr=wtr2;
                        }

                    }
                    else if (textBox3.Text.Length == 12)
                    {
                        Globals.wtr = Globals.str.Substring(0, 4);
                        Globals.znum = Globals.str.Substring(4, 8);
 
                    }

                    this.spr_MeterTypeTableAdapter.FillByTYPE_meter(this.mMSDataSet.spr_MeterType, Globals.wtr);
                    if (spr_MeterTypeBindingSource.Count > 0)
                    {
                        Globals.id_meter_type =
                            Convert.ToInt32(((DataRowView) spr_MeterTypeBindingSource.Current).Row["id_Type"]);
                        this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet.Shipments, Globals.znum,
                            Globals.id_meter_type);
                        if (shipmentsBindingSource.Count > 0)
                        {
                            Globals.id_Shipments =
                                Convert.ToInt32(((DataRowView) shipmentsBindingSource.Current).Row["id"]);
                            Globals.id_Meter_Status =
                                Convert.ToInt32(((DataRowView) shipmentsBindingSource.Current).Row["id_MeterStatus"]);
                            if (Globals.id_Meter_Status == 5)
                            {
                                MessageBox.Show("У этого счетчика " + Globals.znum + " статус---predefected");
                                textBox3.Text = "";
                                textBox3.Focus();
                            }
                            else
                            {
                                historyMeterSimTableAdapter.FillByHisType(mMSDataSet.HistoryMeterSim,
                                    Globals.id_Shipments);
                                if (historyMeterSimBindingSource.Count > 0)
                                {


                                    textBox3.Text = "";
                                    this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim,
                                        Globals.id_Part_Meter);
                                    shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                                    simTableAdapter.Fill(mMSDataSet.Sim);
                                    MessageBox.Show("Этот счетчик " + Globals.znum + "уже привязан, ввод не возможен!!!");

                                    textBox3.Focus();
                                }
                                else
                                {
                                   
                                    if (cbTypeCon.SelectedIndex == 0)
                                    { textBox4.Focus();
                                    shipmentsTableAdapter.UpdateStatus_free(Globals.id_Shipments);
                                    shipmentsTableAdapter.Fill(mMSDataSet.Shipments); }
                                    else
                                    {
                                      
                                        this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);
                                        if (Globals.Quantity > historyMeterSimBindingSource.Count)
                                        {
                                            if (textBox3.Text != "")
                                            {
                                                if (Globals.id_Shipments != 0)
                                                {
                                                    this.shipmentsTableAdapter.UpdateStatus_bindedtoSim(Globals.id_Shipments);// status=6
                                                   
                                                    queriesTableAdapter1.insert_first_history_HistoryMeterSim(Globals.id_Shipments, 0, Globals.id_user, Globals.id_Part_Meter);

                                                    this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);
                                                    this.hisMETsimTableAdapter.Fill(mMSDataSet.HisMETsim, Globals.id_Part_Meter);
                                                    shipmentsTableAdapter.Fill(mMSDataSet.Shipments);                                                    
                                                    historyMeterSimBindingSource.MoveLast();
                                                    textBox3.Text = "";
                                                    textBox4.Text = "";

                                                    if (Globals.Quantity == historyMeterSimBindingSource.Count)
                                                    {
                                                        queriesTableAdapter1.update_status_part(1, Globals.id_Part_Meter);
                                                    }
                                                    else
                                                    {
                                                        queriesTableAdapter1.update_status_part(0, Globals.id_Part_Meter);
                                                    }
                                                    textBox3.Focus();

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Введите штрихкод счетчика!!!");
                                                    textBox3.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Без  счетчика(штрих кода) ввод не возможен!!!");
                                                textBox3.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Вы не можете вставить больше чем в партии");
                                            this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);

                                            queriesTableAdapter1.update_status_part(1, Globals.id_Part_Meter);

                                            shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                                            simTableAdapter.Fill(mMSDataSet.Sim);
                                            textBox3.Text = "";
                                            textBox4.Text = "";
                                            textBox3.Focus();
                                        }
                                    }

                                }
                            }




                        }
                        else
                        {
                            MessageBox.Show("Нет такого счетчика " + Globals.znum + " в Shipments");
                            textBox3.Text = "";
                            textBox3.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого типа счетчика, позвоните на 64-23 чтобы завели в справочник");
                        textBox3.Text = "";
                        textBox3.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Нехватает цифр в штрих-коде  "  +textBox3.Text.Length+"  24  знака");
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Вы не можете вставить больше чем в партии\n Max= "+Globals.Quantity);
                this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);

                queriesTableAdapter1.update_status_part(1, Globals.id_Part_Meter);

                shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                simTableAdapter.Fill(mMSDataSet.Sim);
                textBox3.Text = "";
                textBox4.Text = "";
                textBox3.Focus();
            }
    }

        private void textBox4_TextChanged(object sender, EventArgs e)// sim
        {
            if (textBox4.Text.Length == 12)
            
            {
                Globals.str_sim = textBox4.Text;

                Globals.number_sim = Globals.str_sim.Substring(3, 9);
            }
            else if (textBox4.Text.Length == 10)
            {
                Globals.str_sim = textBox4.Text;

                Globals.number_sim = Globals.str_sim.Substring(1, 9);
            }
            else

            {
                MessageBox.Show("Нехватает цифр в штрих-коде(должно быть 10 или 12 знаков )"); textBox4.Text="";
                return;
            }
                
            



            this.simTableAdapter.FillByStatus(mMSDataSet.Sim, Globals.number_sim);
                    if (simBindingSource.Count > 0)
                    {
                        Globals.id_sim = Convert.ToInt32(((DataRowView)simBindingSource.Current).Row["id"]);
                        this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);
                        if (Globals.Quantity>historyMeterSimBindingSource.Count )
                        {
                            if (textBox3.Text != "")
                            {
                                if (Globals.id_Shipments != 0)
                                {
                                    this.shipmentsTableAdapter.UpdateStatus_bindedtoSim(Globals.id_Shipments);
                                    this.simTableAdapter.UpdateSimStatus(Globals.id_sim);
                                    queriesTableAdapter1.insert_first_history_HistoryMeterSim(Globals.id_Shipments, Globals.id_sim, Globals.id_user, Globals.id_Part_Meter);

                                    this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);
                                    this.hisMETsimTableAdapter.Fill(mMSDataSet.HisMETsim, Globals.id_Part_Meter);
                                    shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                                    simTableAdapter.Fill(mMSDataSet.Sim);
                                    historyMeterSimBindingSource.MoveLast();
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    Globals.id_Shipments = 0;
                                    Globals.id_sim = 0;

                                    if (Globals.Quantity == historyMeterSimBindingSource.Count)
                                    {
                                        queriesTableAdapter1.update_status_part(1, Globals.id_Part_Meter);
                                    }
                                    else
                                    {
                                        queriesTableAdapter1.update_status_part(0, Globals.id_Part_Meter);
                                    }
                                    textBox3.Focus();

                                }
                                else 
                                {
                                    MessageBox.Show("Введите штрихкод счетчика!!!");
                                    textBox3.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Без  счетчика(штрих кода) ввод не возможен!!!");
                                textBox3.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вы не можете вставить больше чем в партии");
                            this.historyMeterSimTableAdapter.FillByid_PartNo(mMSDataSet.HistoryMeterSim, Globals.id_Part_Meter);

                            queriesTableAdapter1.update_status_part(1, Globals.id_Part_Meter);

                            shipmentsTableAdapter.Fill(mMSDataSet.Shipments);
                            simTableAdapter.Fill(mMSDataSet.Sim);
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox3.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эта СИМ-карта " + Globals.number_sim + " с дефектом или установлена или нет такой Сим-карты");
                        textBox4.Text = "";
                        textBox4.Focus();
                    }

                }
            

               

      

       

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
               textBox2_TextChanged(null, null);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBox1_TextChanged(null, null);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBox3_TextChanged(null, null);
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
    
    {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBox4_TextChanged(null, null);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);
        }

        private static void Key_Press(KeyPressEventArgs e)
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
        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);

        }

        private void textEdit1_Properties_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);
        }

        private void СменастатусаMenuItem1_Click(object sender, EventArgs e)
        {
            Form d = new predefect();
            d.Show();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void historyMeterSimBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.Quantity = Convert.ToInt32(((DataRowView)historyMeterSimBindingSource.Current).Row["Quantity"]);
             //   Globals.id_history_meter_ship = Convert.ToInt32(((DataRowView)historyMeterSimBindingSource.Current).Row["id"]);

                Globals.id_ship = Convert.ToInt32(((DataRowView)historyMeterSimBindingSource.Current).Row["id_Shipments"]);

             ////   Globals.id_sim2 = Convert.ToInt32(((DataRowView)historyMeterSimBindingSource.Current).Row["id_Sim"]); ;
              
            }
            catch { }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
         
        }

        private void удалить_партиюMenuItem1_Click(object sender, EventArgs e)
        {
            if (Globals.Quantity == 0)
            {
                DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить партию? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    queriesTableAdapter1.del_part_m(Globals.id_Part_Meter);
                    Globals.del_histiry_ship();
                }
                else
                {

                }
            }
            else
            {
                //MessageBox.Show("В данной партии есть счетчики!");
            }
        }

       

     
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5_TextChanged(null, null);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           this.partMeter_poiskTableAdapter.Fill(mMSDataSet.PartMeter_poisk, textBox5.Text);
           if (partMeter_poiskBindingSource.Count>0)
           {
               MessageBox.Show("Такая коробка есть!");
           }
           else { 
            simpleButton1_Click(sender,e);
           }

        }

        private void hisMETsimBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_history_meter_ship = Convert.ToInt32(((DataRowView)hisMETsimBindingSource.Current).Row["id"]);

                Globals.id_ship = Convert.ToInt32(((DataRowView)hisMETsimBindingSource.Current).Row["id_Shipments"]);
                Globals.id_sim2 = Convert.ToInt32(((DataRowView)hisMETsimBindingSource.Current).Row["id_Sim"]);
                
            }
            catch { }
        }

        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //GridView View = sender as GridView;
            //GridViewAppearances App = View.Appearance;

           
            //  //  string tip = "Переоформление";
            //    string crpu = View.GetRowCellDisplayText(e.RowHandle, View.Columns.ColumnByFieldName("Seal_CRPU"));
            //    string modem = View.GetRowCellDisplayText(e.RowHandle, View.Columns.ColumnByFieldName("Seal_Modem"));

            //    if (((crpu == "") || (modem == "")) || ((crpu == "") && (modem == "")) || ((crpu == "Z") || (modem == "Z6")) || ((crpu == "Z") && (modem == "Z6")))
            //    {
            //        e.Appearance.BackColor = Color.Yellow;
            //        e.Appearance.ForeColor = Color.Blue;
            //      //  App.FocusedRow.ForeColor = Color.Yellow;
            //    } 
                    }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                //radioButton2.Enabled = false;

                textEdit2.Text = "4";
                Globals.partQuantity = 4;
                
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                //radioButton1.Enabled = false;

                textEdit2.Text = "6";
                Globals.partQuantity = 6;
            }
            else
            { 
            
            }
           
        }

        private void cbTypeCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeCon.SelectedIndex == 0)
            { textBox4.Enabled = true; }
            else { textBox4.Enabled = false; }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textBox4_TextChanged(null, null);
            }
        }

       
    
        }
    }

