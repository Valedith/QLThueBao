
using _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework
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
            MessageBoxManager.Yes = "Có";
            MessageBoxManager.No = "Không";
            MessageBoxManager.Register();
            Application.Run(new Login());
        }
    }
}
