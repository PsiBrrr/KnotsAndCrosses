using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KnotsAndCrosses
{
    class csControls
    {
        private static Color bBackColor;
        private static Point pArrSize;
        private static Button[,] bButton;
        private static csWinItems winItems;
        private static csEventHandlers evtEventHandler;

        public static ArrayList AddButton(ArrayList cControls, Point pArraySize, Point pStartPosition, Size bButtonSize)
        {
            Point pIncrement = new Point(0, 0);

            bButton = new Button[pArraySize.X, pArraySize.Y];
            bBackColor = Color.LightGray;
            pArrSize = pArraySize;
            winItems = new csWinItems();
            evtEventHandler = new csEventHandlers();

            for (int y = 0; y < pArraySize.Y; y++)
            {
                for (int x = 0; x < pArraySize.X; x++)
                {
                    cControls.Add(winItems.addButton(bButton, x, y, new Point(pStartPosition.X + pIncrement.X, pStartPosition.Y + pIncrement.Y), bButtonSize, new Point(x, y), "", bBackColor, evtEventHandler.ButtonClick));

                    pIncrement.X += bButtonSize.Width;
                }
                pIncrement.X = 0;
                pIncrement.Y += bButtonSize.Height;
            }

            return cControls;
        }

        public static void ResetButton()
        {
            for (int y = 0; y < pArrSize.Y; y++)
            {
                for (int x = 0; x < pArrSize.X; x++)
                {
                    bButton[y, x].Enabled = true;
                    bButton[y, x].BackColor = bBackColor;
                }
            }
        }

        public static void DisableAllButton()
        {
            for (int y = 0; y < pArrSize.Y; y++)
            {
                for (int x = 0; x < pArrSize.X; x++)
                {
                    bButton[y, x].Enabled = false;
                }
            }
        }

        public static ArrayList AddMenuStrip(ArrayList cControls, String[][] mMenuItems)
        {
            winItems = new csWinItems();
            evtEventHandler = new csEventHandlers();

            cControls.Add(winItems.addMenuStrip(mMenuItems, evtEventHandler.MenuClick));

            return cControls;
        }
    }
}
