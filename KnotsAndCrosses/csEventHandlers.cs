using System;
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
        private static int iPlayer = 1;
        private static Boolean bGameStatus = false;

        public void MenuClick(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mMenuItem = sender as ToolStripMenuItem;
            if (mMenuItem != null)
            {
                if (mMenuItem.ToString() == "New Player vs PC")
                {
                    csLogic.Reset();
                    csLogic.bMultiPlayer = false;
                    csControls.ResetButton();
                    bGameStatus = false;
                }
                else if (mMenuItem.ToString() == "New Player vs Player")
                {
                    csLogic.Reset();
                    csLogic.bMultiPlayer = true;
                    csControls.UpdateStatusStrip(String.Concat("Player " + csLogic.iCurrentPlayer.ToString() + " Start"));
                    csControls.ResetButton();
                    bGameStatus = false;
                }
                else if (mMenuItem.ToString() == "Exit")
                {
                    Application.Exit();
                }
            }
        }

        public void ButtonClick(object sender, System.EventArgs e)
        {
            Button bButton = sender as Button;
            if (bButton != null)
            {
                Point index = (Point)bButton.Tag;

                if (csLogic.bMultiPlayer)
                {
                    csLogic.Add(index);
                    if (csLogic.ReturnState(index) == 1)
                    {
                        bButton.BackColor = Color.Green;
                        bButton.Enabled = false;
                    }
                    else if (csLogic.ReturnState(index) == 2)
                    {
                        bButton.BackColor = Color.Red;
                        bButton.Enabled = false;
                    }

                    if (gmLogic.PlayerLogic())
                    {
                        MessageBox.Show(string.Concat("Player ", csLogic.iCurrentPlayer, " has won!"), "Winner Winner", MessageBoxButtons.OK);
                        csControls.UpdateStatusStrip(String.Concat("Player " + csLogic.iCurrentPlayer.ToString() + " has Won!"));
                        csControls.DisableAllButton();
                        bGameStatus = true;
                    }
                    else if (gmLogic.TieLogic())
                    {
                        MessageBox.Show("Both Players have tied!", "Tie Tie", MessageBoxButtons.OK);
                        csControls.UpdateStatusStrip(String.Concat("Tie Game!"));
                        csControls.DisableAllButton();
                        bGameStatus = true;
                    }

                    csLogic.UpdatePlayer();
                    if (!bGameStatus)
                        csControls.UpdateStatusStrip(String.Concat("Player " + csLogic.iCurrentPlayer.ToString() + "'s turn"));
                }
            }
        }
    }
}
