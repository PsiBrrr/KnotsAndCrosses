using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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

            csWinItems winItems = new csWinItems();
            csEventHandlers evtEventHandler = new csEventHandlers();

            Boolean bMaximizable = false; //Allow Form to be Maximizable
            FormStartPosition fPosition = FormStartPosition.CenterScreen; //Form Starting Position
            FormBorderStyle fBorder = FormBorderStyle.FixedSingle; //Form Border Style
            Point pArraySize = new Point(3, 3); //Array for game buttons
            Point pIncrement = new Point(0, 0);
            Point pStartPosition = new Point(27, 27); //Start position for game buttons
            Size bButtonSize = new Size(96, 96);
            Size sFormSize = new Size(360, 360); //Form Size
            String sTitle = "Knots & Crosses"; //Form Title

            Button[,] bButton = new Button[pArraySize.X, pArraySize.Y]; //Button array for play area
            String[][] mMenuItems = new String[][] 
            {
                new String[] { "Menu", "New", "Score", "Exit" } //First item is the menu item, the rest are the drop down
            };


            ArrayList cControls = new ArrayList();
            csControls.AddMenuStrip(cControls, mMenuItems);
            csControls.AddButton(cControls, pArraySize, pIncrement, pStartPosition, bButtonSize);

            frmMain frmMain = new frmMain(sFormSize, fPosition, fBorder, sTitle, bMaximizable, cControls);
            Application.Run(frmMain);
        }


    }
}
