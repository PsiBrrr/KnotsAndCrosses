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
        public void MenuClick(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mMenuItem = sender as ToolStripMenuItem;
            if (mMenuItem != null)
            {
                //MessageBox.Show(string.Concat("You have Clicked '", sender.ToString(), "' Menu"), "Menu Items Event", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                bButton.BackColor = Color.LightPink;
                //MessageBox.Show(string.Concat("You have Clicked '", index, "' Button"), "Menu Items Event", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
