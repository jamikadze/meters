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
using DevExpress.XtraReports.UI;

namespace meters
{
    public partial class Main_reports : DevExpress.XtraEditors.XtraForm
    {
        public Main_reports()
        {
            InitializeComponent();
        }

        private void Main_reports_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            install_count_po_executerc report = new install_count_po_executerc();
          
            ReportPrintTool printTool = new ReportPrintTool(report);
            
            printTool.ShowPreviewDialog();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            all_install_count_po_executers report = new all_install_count_po_executers();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           plan_grafik report = new plan_grafik();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form all = new All_installed_meters();
            all.Show();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form all = new for_Marat();
            all.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pr_meter_sim_oper report = new pr_meter_sim_oper();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }
        

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { pr_meter_sim report = new pr_meter_sim();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
           }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            po_vyd_1 report = new po_vyd_1();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            po_vyd_2 report = new po_vyd_2();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            po_vyd_3 report = new po_vyd_3();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            po_vyd_4 report = new po_vyd_4();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            po_vyd_5 report = new po_vyd_5();

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form all = new period();
            all.Show();
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            r_NotInstall noIns = new r_NotInstall();
            noIns.Show();
        }

     
        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            r_CountStatus cst = new r_CountStatus();
            cst.Show();
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            r_StatusList stl = new r_StatusList();
            stl.Show();
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            r_Parts pm = new r_Parts();
            pm.Show();
        }
    }
}