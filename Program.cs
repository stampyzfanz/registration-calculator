using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_calculator
{
    static class Program
    {
        static public Dictionary<string, Form> Forms { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Forms = new Dictionary<string, Form>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Forms["LandingPage"] = new LandingPage());
        }
    }
}
