using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnotsAndCrosses
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

            frmMain frmMain = new frmMain(new Size(360, 360), FormStartPosition.CenterScreen, "Knots & Crosses", false);

            Application.Run(frmMain);
        }
    }
}
