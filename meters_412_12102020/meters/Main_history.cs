using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts.GLGraphics;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace meters
{
    public partial class Main_history : DevExpress.XtraEditors.XtraForm
    {
         string crpu2;
         string modem2;
        public Main_history()
        {
            InitializeComponent();
        }

        private void partMeterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          

        }

        private void Main_history_Load(object sender, EventArgs e)
        {

            //this.hms_shipTableAdapter.Fill(this.mMSDataSet.Hms_ship);
            // TODO: This line of code loads data into the 'mMSDataSet.InstalledMeters2' table. You can move, or remove it, as needed.
            this.installedMeters2TableAdapter.Fill(this.mMSDataSet.InstalledMeters2);
           
            // TODO: This line of code loads data into the 'mMSDataSet.MeterStatusru' table. You can move, or remove it, as needed.
            this.meterStatusruTableAdapter.Fill(this.mMSDataSet.MeterStatusru);
           
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);

            // TODO: This line of code loads data into the 'mMSDataSet.View_InstalledMeters2' table. You can move, or remove it, as needed.
            this.view_InstalledMeters2TableAdapter.Fill(this.mMSDataSet.View_InstalledMeters2);
             //TODO: This line of code loads data into the 'mMSDataSet.HistoryMeterSim' table. You can move, or remove it, as needed.
            this.historyMeterSimTableAdapter.Fill(this.mMSDataSet.HistoryMeterSim);
             //TODO: This line of code loads data into the 'mMSDataSet.spr_SimStatus' table. You can move, or remove it, as needed.
            this.spr_SimStatusTableAdapter.Fill(this.mMSDataSet.spr_SimStatus);
            // TODO: This line of code loads data into the 'mMSDataSet.Sim' table. You can move, or remove it, as needed.
            this.simTableAdapter.Fill(this.mMSDataSet.Sim);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MeterStatus' table. You can move, or remove it, as needed.
            
            this.spr_MeterStatusTableAdapter.Fill(this.mMSDataSet.spr_MeterStatus);
             //TODO: This line of code loads data into the 'mMSDataSet.spr_MeterType' table. You can move, or remove it, as needed.
            this.spr_MeterTypeTableAdapter.Fill(this.mMSDataSet.spr_MeterType);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            //shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);

         
            xtraTabPage1.PageVisible = true;
            xtraTabPage2.PageVisible = false;
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabControl1.SelectedTabPage = xtraTabPage1;

        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
             DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel tt = sender as DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel;


             if (tt.Buttons[0].Properties.Checked == true)
             {
                 tt.Buttons[1].Properties.Checked = false;
                 tt.Buttons[0].Properties.Checked = false;
                 tt.Buttons[2].Properties.Checked = false;
                 tt.Buttons[3].Properties.Checked = false;
                 tt.Buttons[4].Properties.Checked = false;
                 tt.Buttons[5].Properties.Checked = false;
                 


                 if (transitionManager1.IsTransition)
                 {
                     transitionManager1.EndTransition();
                 }

                 transitionManager1.StartTransition(xtraTabPage1);
                 try
                 {
                     xtraTabPage1.PageVisible = true;
                     xtraTabPage2.PageVisible = false;
                     xtraTabPage3.PageVisible = false;
                     xtraTabPage4.PageVisible = false;
                     xtraTabPage5.PageVisible = false;
                     xtraTabPage6.PageVisible = false;
                     xtraTabControl1.SelectedTabPage = xtraTabPage1;



                 }
                 finally
                 {
                     transitionManager1.EndTransition();
                 }
             }


             if (tt.Buttons[2].Properties.Checked == true)
             {
                 tt.Buttons[1].Properties.Checked = false;
                 tt.Buttons[0].Properties.Checked = false;
                 tt.Buttons[2].Properties.Checked = false;
                 tt.Buttons[3].Properties.Checked = false;
                 tt.Buttons[4].Properties.Checked = false;
                 tt.Buttons[5].Properties.Checked = false;



                 if (transitionManager1.IsTransition)
                 {
                     transitionManager1.EndTransition();
                 }

                 transitionManager1.StartTransition(xtraTabPage2);
                 try
                 {
                    
                     xtraTabPage1.PageVisible = false;
                     xtraTabPage2.PageVisible = true;
                     xtraTabPage3.PageVisible = false;
                     xtraTabPage4.PageVisible = false;
                     xtraTabPage5.PageVisible = false;
                     xtraTabPage6.PageVisible = false;
                     xtraTabControl1.SelectedTabPage = xtraTabPage2;
                     



                 }
                 finally
                 {
                     transitionManager1.EndTransition();
                 }
             }
                 if (tt.Buttons[3].Properties.Checked == true)
                 {
                     tt.Buttons[1].Properties.Checked = false;
                     tt.Buttons[0].Properties.Checked = false;
                     tt.Buttons[2].Properties.Checked = false;
                     tt.Buttons[3].Properties.Checked = false;
                     tt.Buttons[4].Properties.Checked = false;
                     tt.Buttons[5].Properties.Checked = false;



                 if (transitionManager1.IsTransition)
                {
                         transitionManager1.EndTransition();
                     }

                     transitionManager1.StartTransition(xtraTabPage3);
                     try
                     {
                         
                         xtraTabPage1.PageVisible = false;
                         xtraTabPage2.PageVisible = false;
                         xtraTabPage3.PageVisible = true;
                         xtraTabPage4.PageVisible = false;
                         xtraTabPage5.PageVisible = false;
                         xtraTabPage6.PageVisible = false;
                         xtraTabControl1.SelectedTabPage = xtraTabPage3;
                         



                     }
                     finally
                     {
                         transitionManager1.EndTransition();
                     }
                 }

                 if (tt.Buttons[4].Properties.Checked == true)
                 {
                     tt.Buttons[1].Properties.Checked = false;
                     tt.Buttons[0].Properties.Checked = false;
                     tt.Buttons[2].Properties.Checked = false;
                     tt.Buttons[3].Properties.Checked = false;
                     tt.Buttons[4].Properties.Checked = false;
                     tt.Buttons[5].Properties.Checked = false;



                     if (transitionManager1.IsTransition)
                     {
                         transitionManager1.EndTransition();
                     }

                     transitionManager1.StartTransition(xtraTabPage4);
                     try
                     {
                       
                         xtraTabPage1.PageVisible =false;
                         xtraTabPage2.PageVisible = false;
                         xtraTabPage3.PageVisible = false;
                         xtraTabPage4.PageVisible = true;
                         xtraTabPage5.PageVisible = false;
                         xtraTabPage6.PageVisible = false;
                         xtraTabControl1.SelectedTabPage = xtraTabPage4;



                     }
                     finally
                     {
                         transitionManager1.EndTransition();
                     }
                 }

                 if (tt.Buttons[5].Properties.Checked == true)
                 {
                     tt.Buttons[1].Properties.Checked = false;
                     tt.Buttons[0].Properties.Checked = false;
                     tt.Buttons[2].Properties.Checked = false;
                     tt.Buttons[3].Properties.Checked = false;
                     tt.Buttons[4].Properties.Checked = false;
                     tt.Buttons[5].Properties.Checked = false;



                     if (transitionManager1.IsTransition)
                     {
                         transitionManager1.EndTransition();
                     }

                     transitionManager1.StartTransition(xtraTabPage5);
                     try
                     {
                         
                         xtraTabPage1.PageVisible = false;
                         xtraTabPage2.PageVisible = false;
                         xtraTabPage3.PageVisible = false;
                         xtraTabPage4.PageVisible = false;
                         xtraTabPage5.PageVisible = true;
                         xtraTabPage6.PageVisible = false;
                         xtraTabControl1.SelectedTabPage = xtraTabPage5;
                         // TODO: This line of code loads data into the 'mMSDataSet.Import_AMI1' table. You can move, or remove it, as needed.
                        // this.import_AMI1TableAdapter.Fill(this.mMSDataSet.Import_AMI1);
                      
                         // TODO: This line of code loads data into the 'mMSDataSet.Plombi_net' table. You can move, or remove it, as needed.
                         this.plombi_netTableAdapter.Fill(this.mMSDataSet.Plombi_net);
                         // TODO: This line of code loads data into the 'mMSDataSet.spr_Seals' table. You can move, or remove it, as needed.
                         this.spr_SealsTableAdapter.Fill(this.mMSDataSet.spr_Seals);
                         shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);

                         tbmeter.Focus();


                     }
                     finally
                     {
                         transitionManager1.EndTransition();
                     }
                 }

                 if (tt.Buttons[1].Properties.Checked == true)
                 {
                     tt.Buttons[1].Properties.Checked = false;
                     tt.Buttons[0].Properties.Checked = false;
                     tt.Buttons[2].Properties.Checked = false;
                     tt.Buttons[3].Properties.Checked = false;
                     tt.Buttons[4].Properties.Checked = false;
                     tt.Buttons[5].Properties.Checked = false;



                     if (transitionManager1.IsTransition)
                     {
                         transitionManager1.EndTransition();
                     }

                     transitionManager1.StartTransition(xtraTabPage6);
                     try
                     {
                     
                         xtraTabPage1.PageVisible = false;
                         xtraTabPage2.PageVisible = false;
                         xtraTabPage3.PageVisible = false;
                         xtraTabPage4.PageVisible = false;
                         xtraTabPage5.PageVisible = false;
                         xtraTabPage6.PageVisible = true;
                         xtraTabControl1.SelectedTabPage = xtraTabPage6;
                         



                     }
                     finally
                     {
                         transitionManager1.EndTransition();
                     }
                 }
             }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_TextChanged(null, null);
            }
        }

        private void shipmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shipmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((textBox2.Text.Length == 23) || (textBox2.Text.Length == 24) ||  (textBox2.Text.Length == 9))
            {

                DialogResult result = MessageBox.Show("Вы действительно \nхотите сменить статус ПУ на predefected \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    Globals.str = textBox2.Text;

                    if (textBox2.Text.Length==24)
                    { 
                    Globals.wtr = Globals.str.Substring(0, 3);
                    Globals.znum = Globals.str.Substring(15, 8);
                    }
                    if (textBox2.Text.Length == 9)
                    {
                        Globals.znum = Globals.str.Substring(1, 8);
                        string wtrih = Globals.str.Substring(0, 4);


                        if (wtrih == "0007")
                        {
                            Globals.wtr = "020";
                        }
                        if (wtrih == "0008")
                        {
                            Globals.wtr = "021";
                        }
                        if (wtrih == "0009")
                        {
                            Globals.wtr = wtrih;
                        }
                       
                    }
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
            else { MessageBox.Show("Нехватает цифр в штрих-коде  " + textBox2.Text.Length +"  23 знака)"); textBox2.Text = ""; }
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1_TextChanged(null, null);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key_Press(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 12)
            {
                Globals.str_sim = textBox1.Text;

                Globals.number_sim = Globals.str_sim.Substring(3, 9);
            }
            else if (textBox1.Text.Length == 10)
            {
                Globals.str_sim = textBox1.Text;

                Globals.number_sim = Globals.str_sim.Substring(1, 9);
            }
            else
            {
                MessageBox.Show("Нехватает цифр в штрих-коде(должно быть 10 или 12 знаков )"); textBox1.Text = "";
                return;
            }
              

            

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
                    else
                    {
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

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ПросмотристорииtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form histor = new historyMeter();
            histor.Show();
        }

        private void privyazka_meters_with_sim3_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl3);
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

        private void btsaveseal_Click(object sender, EventArgs e)
        {
            string crp = tbcrpu.Text.Trim();
            this.sealFindTableAdapter.Fill(this.mMSDataSet.sealFind, crp, 1);
            if (sealFindBindingSource.Count > 0)
            {
                if (Globals.add2 == "update")
                {
                    this.sealCRPU_SHIPTableAdapter.Fill(this.mMSDataSet.sealCRPU_SHIP, crp, Globals.id_schet_hist);
                    if (this.sealCRPU_SHIPBindingSource.Count > 0)
                    {
                        MessageBox.Show(" № " + crp + " пломба ЦРПУ уже существует\nпосмотрите Справочник Shipments");
                        this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                        crpu2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_crpu"]);
                        modem2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_modem"]);
                        //tbcrpu.Text = crpu2;
                        //tbmodem.Text = modem2;
                        tbcrpu.Text = crpu2;
                        tbcrpu.Focus();
                        tbcrpu.SelectionStart = tbcrpu.Text.Length;
                        return;
                    }
                }
                else
                {
                    this.shipments1TableAdapter.Fill_crpu(this.mMSDataSet.Shipments1, crp);
                    if (this.shipments1BindingSource.Count > 0)
                    {
                        //MessageBox.Show(" № " + crp + " пломба ЦРПУ уже существует\nпосмотрите Справочник Shipments");
                        //this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                        //crpu2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_crpu"]);
                        //modem2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_modem"]);
                        ////tbcrpu.Text = crpu2;
                        ////tbmodem.Text = modem2;
                        //tbcrpu.Text = crpu2;
                        //tbcrpu.Focus();
                        //tbcrpu.SelectionStart = tbcrpu.Text.Length;
                        //return;

                    }



                }

            }

            else
            {
                MessageBox.Show("Нет такой № " + crp + " пломбы ЦРПУ");
                this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                crpu2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_crpu"]);
                modem2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_modem"]);
                //tbcrpu.Text = crpu2;
                //tbmodem.Text = modem2;
                tbcrpu.Text = crpu2;
                tbcrpu.Focus();
                tbcrpu.SelectionStart = tbcrpu.Text.Length;
                return;
            }


            string mmod = tbmodem.Text;
                this.sealFindTableAdapter.Fill(this.mMSDataSet.sealFind, mmod, 2);
                if (sealFindBindingSource.Count > 0)
                {
                    if (Globals.add2 == "update")
                    {
                        this.sealModem_SHIPTableAdapter.Fill(this.mMSDataSet.sealModem_SHIP, mmod, Globals.id_schet_hist);
                        if (this.sealCRPU_SHIPBindingSource.Count > 0)
                        {
                            MessageBox.Show(" № " + mmod +
                                            " пломба Модема уже существует\nпосмотрите Справочник Shipments");
                            this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                            crpu2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_crpu"]);
                            modem2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_modem"]);
                            // tbcrpu.Text = crpu2;
                            //tbmodem.Text = modem2;
                            tbmodem.Text = modem2;
                            tbmodem.Focus();
                            tbmodem.SelectionStart = tbmodem.Text.Length;
                            return;
                        }


                    }
                    else
                    {
                        this.shipments1TableAdapter.Fill_modem(this.mMSDataSet.Shipments1, mmod);
                        if (this.shipments1BindingSource.Count > 0)
                        {
                            MessageBox.Show(" № " + mmod +
                                            " пломба Модема уже существует\nпосмотрите Справочник Shipments");
                            this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                            crpu2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_crpu"]);
                            modem2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_modem"]);
                            // tbcrpu.Text = crpu2;
                            //tbmodem.Text = modem2;
                            tbmodem.Text = modem2;
                            tbmodem.Focus();
                            tbmodem.SelectionStart = tbmodem.Text.Length;
                            return;
                        }


                    }



                }
                else
                {
                    MessageBox.Show("Нет такой № " + mmod + " пломбы Модема");
                    this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                    crpu2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_crpu"]);
                    modem2 = Convert.ToString(((DataRowView) usersBindingSource.Current).Row["seal_modem"]);
                    // tbcrpu.Text = crpu2;
                    //tbmodem.Text = modem2;
                    tbmodem.Text = modem2;
                    tbmodem.Focus();
                    return;
                }







                if (Globals.add2 == "update")
                {
                    string crpu = tbcrpu.Text.Substring(0, 4);
                    string modem = tbmodem.Text.Substring(0, 4);
                    this.usersTableAdapter.UpdateSEAL(crpu, modem, Globals.id_user);
                    this.queriesTableAdapter1.update_shipSeal(tbcrpu.Text.Trim(), tbmodem.Text.Trim(),
                        Globals.id_schet_hist);


                    this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
                    tbmeter.Text = "";
                    tbcrpu.Text = crpu;
                    tbmodem.Text = modem;
                    tbmeter.Focus();
                    this.plombi_netTableAdapter.Fill(this.mMSDataSet.Plombi_net);
                    //    Globals.del_histiry_ship();
                    //MessageBox.Show("Данные сохранены!");
                }
                else
                {
                    string crpu = tbcrpu.Text.Substring(0, 4);
                    string modem = tbmodem.Text.Substring(0, 4);
                    this.usersTableAdapter.UpdateSEAL(crpu, modem, Globals.id_user);
                    this.queriesTableAdapter1.update_shipSeal(tbcrpu.Text.Trim(), tbmodem.Text.Trim(),
                        Globals.id_Shipments);

                    this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
                    tbmeter.Text = "";
                    tbcrpu.Text = crpu;
                    tbmodem.Text = modem;
                    tbmeter.Focus();
                    this.plombi_netTableAdapter.Fill(this.mMSDataSet.Plombi_net);
                    //      Globals.del_histiry_ship();
                    // MessageBox.Show("Данные сохранены!");



                }
                Globals.add2 = "insert";

            
        }

        private void tbmeter_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                tbforseal1_TextChanged(null, null);
            }
        }
        private void tbforseal1_TextChanged(object sender, EventArgs e)
        {

            if ((tbmeter.Text.Length == 24) || (tbmeter.Text.Length == 23) || (tbmeter.Text.Length == 9)|| (tbmeter.Text.Length == 12))
            {
                
                
                Globals.str2 = tbmeter.Text;
                Globals.wtr = Globals.str2.Substring(0, 3);
                if (tbmeter.Text.Length == 24)
                {
                    if (Globals.wtr == "077" || Globals.wtr == "078" || Globals.wtr == "069")
                    {
                        Globals.wtr = Globals.str2.Substring(0, 4);
                        Globals.znum = Globals.str2.Substring(16, 8);
                    }
                    else
                    Globals.znum = Globals.str2.Substring(15, 9);
                }
                else if (tbmeter.Text.Length == 23)
                {
                    Globals.znum = Globals.str2.Substring(15, 8);
                }
                 else if (tbmeter.Text.Length == 9)
                    {
                        Globals.znum = Globals.str2.Substring(1, 8);
                        string str6 = tbmeter.Text;
                        string wtr2 = str6.Substring(0, 4);

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
                else if (tbmeter.Text.Length == 12)
                {
                    Globals.wtr = Globals.str2.Substring(0, 4);
                    Globals.znum = Globals.str2.Substring(4, 8);

                }
                this.spr_MeterTypeTableAdapter.FillByTYPE_meter(this.mMSDataSet.spr_MeterType, Globals.wtr);
                if (spr_MeterTypeBindingSource.Count > 0)
                {
                    Globals.id_meter_type =
                        Convert.ToInt32(((DataRowView)spr_MeterTypeBindingSource.Current).Row["id_Type"]);
                    this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet.Shipments, Globals.znum,
                        Globals.id_meter_type);
                
                    if (shipmentsBindingSource.Count > 0)
                    {
                        Globals.id_Shipments = Convert.ToInt32(((DataRowView) shipmentsBindingSource.Current).Row["id"]);
                        string crpuu = ((DataRowView)shipmentsBindingSource.Current).Row["Seal_CRPU"].ToString();
                        if ((crpuu.Length==0) && (crpuu==""))
                        { 
                        this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                        crpu2 = Convert.ToString(((DataRowView)usersBindingSource.Current).Row["seal_crpu"]);
                        modem2 = Convert.ToString(((DataRowView)usersBindingSource.Current).Row["seal_modem"]);
                        tbcrpu.Text = crpu2;
                        tbmodem.Text = modem2;
                        tbcrpu.Focus();
                        tbcrpu.SelectionStart = tbcrpu.Text.Length;
                        }
                        else
                            {
                        tbcrpu.Text = crpuu;
                            this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                            modem2 = Convert.ToString(((DataRowView)usersBindingSource.Current).Row["seal_modem"]);
                        tbmodem.Text = modem2;
                        tbmodem.Focus();
                        tbmodem.SelectionStart = tbmodem.Text.Length;                        
                            }
                        this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet.Shipments, Globals.znum, Globals.id_meter_type);
                    }
                    else
                    {
                        MessageBox.Show("Нет такого счетчика " + Globals.znum + " в Shipments");
                        tbmeter.Text = "";
                        tbmeter.Focus();
                      
                    }
                }
                else
                {
                    MessageBox.Show("Нет такого типа счетчика, позвоните на 64-23 чтобы завели в справочник");
                    tbmeter.Text = "";
                    tbmeter.Focus();

                }
            }
            else if (tbmeter.Text.Length == 8)

            {
                this.shipmentsTableAdapter.FillBySERIALNO(this.mMSDataSet.Shipments, tbmeter.Text.Trim());

                if (shipmentsBindingSource.Count > 0)
                {
                    Globals.id_Shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                    string crpuu = ((DataRowView)shipmentsBindingSource.Current).Row["Seal_CRPU"].ToString();
                    if ((crpuu.Length == 0) && (crpuu == ""))
                    {
                        this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                        crpu2 = Convert.ToString(((DataRowView)usersBindingSource.Current).Row["seal_crpu"]);
                        modem2 = Convert.ToString(((DataRowView)usersBindingSource.Current).Row["seal_modem"]);
                        tbcrpu.Text = crpu2;
                        tbmodem.Text = modem2;
                        tbcrpu.Focus();
                        tbcrpu.SelectionStart = tbcrpu.Text.Length;
                    }
                    else
                    {
                        tbcrpu.Text = crpuu;
                        this.usersTableAdapter.Fill_id_user(this.mMSDataSet.Users, Globals.id_user);
                        modem2 = Convert.ToString(((DataRowView)usersBindingSource.Current).Row["seal_modem"]);
                        tbmodem.Text = modem2;
                        tbmodem.Focus();
                        tbmodem.SelectionStart = tbmodem.Text.Length;
                    }
                    this.shipmentsTableAdapter.FillBySERIALNO(this.mMSDataSet.Shipments, tbmeter.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Нет такого счетчика " + Globals.znum + " в Shipments");
                    tbmeter.Text = "";
                    tbmeter.Focus();

                }
 
            
            }
            else
            {
                MessageBox.Show("№ ПУ " + tbmeter.Text + " не существует в базе!"); tbmeter.Text = "";

            }
            
           }


        private void tbmeter_KeyPress(object sender, KeyPressEventArgs e)
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

        

        

        private void tbcrpu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbmodem.Focus();
                tbmodem.SelectionStart = tbmodem.Text.Length;
            }


            //    SendKeys.Send("{TAB}");
            //btsaveseal_Click(sender, e);
            //tbcrpu_Leave(null, null);
            
           

            


        }

        private void shipmentsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {


                if (shipmentsBindingSource.Count > 0)
                {
                    Globals.id_schet_hist = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"].ToString());
                   // tbmeter.Text = ((DataRowView)shipmentsBindingSource.Current).Row["SerialNo"].ToString();
                    Globals.crpu = ((DataRowView)shipmentsBindingSource.Current).Row["Seal_CRPU"].ToString();
                    Globals.modem = ((DataRowView)shipmentsBindingSource.Current).Row["Seal_Modem"].ToString();
                }

            }
            catch { }

        }

        private void РедактироватьMenuItem1_Click(object sender, EventArgs e)
        {
            tbcrpu.Text = Globals.crpu;
            tbmodem.Text = Globals.modem;
            Globals.add2 = "update";

        }

        private void gridControl5_Load(object sender, EventArgs e)
        {
            this.shipmentsTableAdapter.Fill_IDship(this.mMSDataSet.Shipments, Globals.id_ship);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            //string mmod = tbmodem.Text;
            //this.sealFindTableAdapter.Fill(this.mMSDataSet.sealFind, mmod, 2);
            //if (sealFindBindingSource.Count > 0)
            //{
            //    this.sealModem_SHIPTableAdapter.Fill(this.mMSDataSet.sealModem_SHIP, mmod);
            //    if (this.sealCRPU_SHIPBindingSource.Count > 0)
            //    {
            //        MessageBox.Show(" № " + mmod + " пломба Модема уже существует\nпосмотрите Справочник Shipments");
            //        tbmodem.Text = modem2; 
            //        tbmodem.Focus();
            //    }
            //    else
            //    {
            //        if (Globals.add2 == "update")
            //        {

            //            this.queriesTableAdapter1.update_shipSeal(tbcrpu.Text.Trim(), tbmodem.Text.Trim(), Globals.id_schet_hist);
            //            tbmeter.Text = "";
            //            tbcrpu.Text = crpu2;
            //            tbmodem.Text = modem2;

            //            this.shipmentsTableAdapter.Fill_IDship(this.mMSDataSet.Shipments,Globals.id_ship);
            //            tbmeter.Focus();
            //        }
            //        else
            //        {
            //            this.queriesTableAdapter1.update_shipSeal(tbcrpu.Text.Trim(), tbmodem.Text.Trim(), Globals.id_Shipments);
            //            tbmeter.Text = "";
            //            tbcrpu.Text = crpu2;
            //            tbmodem.Text = modem2;
            //            tbmeter.Focus();
            //            this.shipmentsTableAdapter.Fill_IDship(this.mMSDataSet.Shipments, Globals.id_ship);

            //        }
            //        Globals.add2 = "insert";


            //        // btsaveseal.BackColor = Color.Lavender;//    }

            //}
            //else
            //{
            //    MessageBox.Show("Нет такой № " + mmod + " пломбы Модема");
            //    tbmodem.Text =modem2;
            //    tbmodem.Focus();
            //}
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
           
        }

        

        private void tbcrpu_Enter(object sender, EventArgs e)
        {
           
                //string crp = tbcrpu.Text;
                //this.sealFindTableAdapter.Fill(this.mMSDataSet.sealFind, crp, 1);
                //if (sealFindBindingSource.Count > 0)
                //{
                //    this.sealCRPU_SHIPTableAdapter.Fill(this.mMSDataSet.sealCRPU_SHIP, crp);
                //    if (this.sealCRPU_SHIPBindingSource.Count > 0)
                //    {
                //        MessageBox.Show(" № " + crp + " пломба ЦРПУ уже существует\nпосмотрите Справочник Shipments");
                //        tbcrpu.Text = crpu2;
                //        tbcrpu.Focus();
                //        tbcrpu.SelectionStart = tbcrpu.Text.Length;


                //    }
                //    else
                //    {
                //        //tbmodem.Text = mode;
                //        tbmodem.Focus();
                //        tbmodem.SelectionStart = tbmodem.Text.Length;
                //    }

                //}
                //else
                //{
                //    MessageBox.Show("Нет такой № " + crp + " пломбы ЦРПУ");
                //    tbcrpu.Text = crpu2;
                //    tbcrpu.Focus();
                //    tbcrpu.SelectionStart = tbcrpu.Text.Length;
                //}
            
        }

        private void tbmodem_Enter(object sender, EventArgs e)
        {
            //btsaveseal_Click(sender, e);
                //string mmod = tbmodem.Text;
                //this.sealFindTableAdapter.Fill(this.mMSDataSet.sealFind, mmod, 2);
                //if (sealFindBindingSource.Count > 0)
                //{
                //    this.sealModem_SHIPTableAdapter.Fill(this.mMSDataSet.sealModem_SHIP, mmod);
                //    if (this.sealCRPU_SHIPBindingSource.Count > 0)
                //    {
                //        MessageBox.Show(" № " + mmod + " пломба Модема уже существует\nпосмотрите Справочник Shipments");
                //        tbmodem.Text = modem2;
                //        tbmodem.Focus();
                //        tbmodem.SelectionStart = tbmodem.Text.Length;
                //    }
                //    else
                //    {
                      
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Нет такой № " + mmod + " пломбы Модема");
                //    tbmodem.Text = modem2;
                //    tbmeter.Focus();
                //}



            
        }

        private void tbmodem_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

       

        private void tbmodem_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                btsaveseal_Click(sender, e);
            }
        }

        private void btrefresh1_Click(object sender, EventArgs e)
        {
            this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form spr_ship = new spr_ship();
            spr_ship.Show();
        }

        private void xtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage5)
            {
                //tbmeter.Focus();
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                this.hms_shipTableAdapter.Fill(this.mMSDataSet.Hms_ship);
            }
        }

      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit2.Text != "")
            {
                this.sim1_update_statusTableAdapter.Fill(this.mMSDataSet.Sim1_update_status, Convert.ToInt32(textEdit2.Text));
                if (sim1_update_statusBindingSource.Count > 0)
                {
                    sim1_update_statusTableAdapter.Update_sim_status (textEdit2.Text.Trim());
                    sim1_update_statusTableAdapter.Fill(this.mMSDataSet.Sim1_update_status, Convert.ToInt32(textEdit2.Text));

                }
                else
                {
                    MessageBox.Show("Такой Сим нет!");
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.ReturnDeffectMeters' table. You can move, or remove it, as needed.
            //this.returnDeffectMetersTableAdapter.Fill(this.mMSDataSet.ReturnDeffectMeters);
        }

        private void gridControl7_Click(object sender, EventArgs e)
        {

        }

        private void btNullstatus_Click(object sender, EventArgs e)
        {
            if (tbMeterNO.Text.Trim() != "")
            {
                this.hms_shipTableAdapter.FillByMeterNo(this.mMSDataSet.Hms_ship,tbMeterNO.Text.Trim());
                
                if (this.BS_hms_ship.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Вы действительно \nхотите сброить статус ПУ?\n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        int? idInstMeter2 = 0;
                        int? simid = Convert.ToInt32(((DataRowView)BS_hms_ship.Current).Row["idSim"]);
                        int? MeterId = Convert.ToInt32(((DataRowView)BS_hms_ship.Current).Row["id_ship"]);

                        this.installedMeters2TableAdapter.FillByIdMeter(this.mMSDataSet.InstalledMeters2, MeterId);
                        if (this.BS_InstalledMeters2.Count > 0)
                        {
                            idInstMeter2 = Convert.ToInt32(((DataRowView)BS_InstalledMeters2.Current).Row["id"]);
                        }
                        this.queriesTableAdapter1.ResetAllStatus(MeterId, simid, Globals.id_user, idInstMeter2);
                        this.hms_shipTableAdapter.FillByMeterNo(this.mMSDataSet.Hms_ship, tbMeterNO.Text.Trim());
                    }
                }
                else
                {
                    MessageBox.Show("tbMeterNO.Text.Trim() нет в базе!\n сброс ПУ не возможен!");
                }
            }
            else
            {
                MessageBox.Show(" Введите № ПУ или ввод возможно не корректный \nдосум");
            }
        }

        private void tbmeter_Leave(object sender, EventArgs e)
        {
            //tbforseal1_TextChanged(null, null);
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);
        }

      

      
        }
    }
