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

namespace meters
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            Form main_corrector = new Main_MMOL();
            main_corrector.Show();
          
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            Form main_corrector = new Main_corrector();
            main_corrector.Show();
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            Form main_CMOL = new Main_CMOL();
            main_CMOL.Show();
        }

        private void tileItem12_ItemClick(object sender, TileItemEventArgs e)
        {
            Form main_operator = new Main_operator();
            main_operator.Show();
        }

        private void tileItem13_ItemClick(object sender, TileItemEventArgs e)
        {
            Form main_spravochniki = new Main_spravochniki();
            main_spravochniki.Show();
        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {
            Form main_reports = new Main_reports();
            main_reports.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Slujba' table. You can move, or remove it, as needed.
          
            this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;  
            this.spr_SlujbaTableAdapter.FillByRES(this.mMSDataSet.spr_Slujba);

            
            
            if (Globals.id_access == 2) //operator
            {
                groupControl1.Visible = false;
                tileItem14.Visible = true;
                tileItem16.Visible = true;
                tileItem11.Visible = true;
                tileItem9.Visible = true;
                tileItem12.Visible = true;
                tileItem13.Visible = true;

                tileItem3.Visible = false;
                tileItem10.Visible = false;
                tileItem15.Visible = false;
                tileItem18.Visible = false;
                tileItem21.Visible = false;
                tileItem19.Visible = false;
               
            }

            if (Globals.id_access == 3) //bigmol
            {
                groupControl1.Visible = false;
                tileItem3.Visible = true;
                tileItem10.Visible = true;
                tileItem11.Visible = true;
                tileItem13.Visible = false;

                tileItem14.Visible = false;
                tileItem16.Visible = false;
                tileItem9.Visible = false;
                tileItem15.Visible = false;
                tileItem12.Visible = false;
                tileItem18.Visible = false;
                tileItem20.Visible = false;
                tileItem19.Visible = false;
            }

             if (Globals.id_access == 4)   //metrologmol
             {
                 groupControl1.Visible = false;
                tileItem11.Visible = true;
                tileItem13.Visible = false;

                tileItem14.Visible = false;
                tileItem16.Visible = false;
                tileItem9.Visible = false;
                tileItem15.Visible = false;
                tileItem12.Visible = false;
                tileItem10.Visible = false;
                tileItem3.Visible = false;
                tileItem18.Visible = false;
               tileItem20.Visible = false;
                tileItem19.Visible = false;

            }

             if (Globals.id_access == 5)// configurator
             {
                 groupControl1.Visible = false;
                tileItem15.Visible = true;
                tileItem13.Visible = false;

                tileItem14.Visible = false;
                tileItem16.Visible = false;
                tileItem9.Visible = false;
                tileItem11.Visible = false;
                tileItem12.Visible = false;
                tileItem10.Visible = true;
                tileItem3.Visible = false;
                tileItem18.Visible = false;
                tileItem20.Visible = false;
                tileItem19.Visible = false;
               
            }
             if (Globals.id_access == 6) //reader
             {
                 groupControl1.Visible = true;
                 tileItem15.Visible = false;
                 tileItem13.Visible = false;
                 tileItem17.Visible = false;
                 tileItem14.Visible = false;
                 tileItem16.Visible = true;
                 tileItem9.Visible = false;
                 tileItem11.Visible = true;
                 tileItem12.Visible = false;
                 tileItem10.Visible = false;
                 tileItem3.Visible = false;
                 tileItem18.Visible = false;
                 tileItem21.Visible = false;
             }
             if (Globals.id_access == 7) //Metrology Return Deffect Meter
             {
                 groupControl1.Visible = false;
                 tileItem15.Visible = false;
                 tileItem13.Visible = false;
                 tileItem17.Visible = false;
                 tileItem14.Visible = false;
                 tileItem16.Visible = false;
                 tileItem9.Visible = false;
                 tileItem11.Visible = false;
                 tileItem12.Visible = false;
                 tileItem10.Visible = false;
                 tileItem3.Visible = false;
                 tileItem18.Visible = false;
                 tileItem21.Visible = true;
                 tileItem20.Visible = false;
                 tileItem19.Visible = false;


             }
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
               Globals.id_slujbi = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void tileItem15_ItemClick(object sender, TileItemEventArgs e)
        {
            Form main_history = new Main_history();
            main_history.Show();
        }

        private void tileItem14_ItemClick(object sender, TileItemEventArgs e)
        {
            Form ust_list = new ust_list();
            ust_list.Show();
        }

        private void tileItem16_ItemClick(object sender, TileItemEventArgs e)
        {
            Form akt = new akt();
            akt.Show();
        }

        private void tileItem17_ItemClick(object sender, TileItemEventArgs e)
        {
            Form akt = new obor();
            akt.Show();
        }

        private void tileItem18_ItemClick(object sender, TileItemEventArgs e)
        {
            Form a = new admin();
            a.Show();
        }

        private void tileItem19_ItemClick(object sender, TileItemEventArgs e)
        {
            Form a = new Main_ADDmeters();
            a.Show();
        }

        private void tileItem20_ItemClick(object sender, TileItemEventArgs e)
        {
            Form f = new Import2Billing();
            f.Show();
        }

        private void tileItem21_ItemClick(object sender, TileItemEventArgs e)
        {
            //Form f = new ReturnDeffMet();
            Form f = new MetersMolCRPU();
            f.Show();
        }

        private void tileItem22_ItemClick(object sender, TileItemEventArgs e)
        {
            if (Globals.userId4SCM != 0)
            {
                Form f = new emc_Mainform();
                f.Show();
            }
        }
    }
}