﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnotsAndCrosses
{
    class csEventHandlers
    {
        csLogic gmLogic = new csLogic();
        int iPlayer = 1;

        public void MenuClick(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mMenuItem = sender as ToolStripMenuItem;
            if (mMenuItem != null)
            {
                //MessageBox.Show(string.Concat("You have Clicked '", sender.ToString(), "' Menu"), "Menu Items Event", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //if (mMenuItem.ToString() == "New")
                    //gmLogic.Logic();
                //else 
                if (mMenuItem.ToString() == "Exit")
                    Application.Exit();
            }

        }

        public void ButtonClick(object sender, System.EventArgs e)
        {
            Button bButton = sender as Button;
            if (bButton != null)
            {
                Point index = (Point)bButton.Tag;

                if (gmLogic.bMultiPlayer)
                {
                    gmLogic.Add(index, iPlayer);
                    if (gmLogic.ReturnState(index) == 1)
                    {
                        bButton.BackColor = Color.Green;
                        bButton.Enabled = false;
                    }
                    else if (gmLogic.ReturnState(index) == 2)
                    {
                        bButton.BackColor = Color.Red;
                        bButton.Enabled = false;
                    }

                    if (gmLogic.Logic(iPlayer))
                        MessageBox.Show(string.Concat("Player ", iPlayer, " has won!"), "Winner Winner", MessageBoxButtons.OK);

                    if (iPlayer == 1)
                        iPlayer = 2;
                    else
                        iPlayer = 1;
                }
            }
        }
    }
}
