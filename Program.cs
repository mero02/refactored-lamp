using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TurApp.Views;

namespace TurApp
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
            Application.Run( MainView.Instance); // uso de la unica instancia admitida en el sistema.
        }
    }
}
