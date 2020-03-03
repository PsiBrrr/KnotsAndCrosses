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
        private static csWinItems winItems = new csWinItems();
        private static csEventHandlers evtEventHandler = new csEventHandlers();

        public static ArrayList AddButton(ArrayList cControls, Point pArraySize, Point pIncrement, Point pStartPosition, Size bButtonSize)
        {
            bButton = new Button[pArraySize.X, pArraySize.Y];
            bBackColor = Color.LightGray;
            pArrSize = pArraySize;

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
    }
}
