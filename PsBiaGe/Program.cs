using Core.Controllers;
using DevExpress.UserSkins;
using PsChamp.GeneralForms;
using System;
using System.Windows.Forms;

namespace PsChamp
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

            BonusSkins.Register();

            SessionController.GetSessionSimpleDataLayer();
            SessionController.GetSessionThreadSafeDataLayer();

            Application.Run(new MainForm());
        }
    }
}
