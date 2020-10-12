using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace meters
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
            Application.Run(new authentifacation());
            if (Globals.main_menu == 1)
            { Application.Run(new Main()); }
            //if (Globals.main_menu == 2)
            //{ Application.Run(new Main_operator()); }
            //if (Globals.main_menu == 3)
            //{ Application.Run(new Main_MMOL()); }
            //if (Globals.main_menu == 4)
            //{ Application.Run(new Main_CMOL()); }
            //if (Globals.main_menu == 5)
            //{ Application.Run(new Main_corrector()); }
        }
    }
}