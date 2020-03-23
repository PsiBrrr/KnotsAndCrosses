using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KnotsAndCrosses
{
    class csWinItems
    {
        public Label addLabel(Label lLabel, Point pLocation, Size sSize, String sText)
        {
            lLabel = new Label
            {
                Location = pLocation,
                Size = sSize,
                Text = sText
            };
            return lLabel;
        }
        public Label addLabel(Label lLabel, Point pLocation, Size sSize, String sText, Color cForeColor)
        {
            lLabel = new Label
            {
                Location = pLocation,
                Size = sSize,
                Text = sText,
                ForeColor = cForeColor
            };
            return lLabel;
        }
        public Button addButton(Button bButton, Point pLocation, Size sSize, int tTag, String sText, Color cBackColor, System.EventHandler click)
        {
            bButton = new Button
            {
                Location = pLocation,
                Size = sSize,
                Tag = tTag,
                Text = sText,
                BackColor = cBackColor
            };
            bButton.Click += click;
            return bButton;
        }
        public Button addButton(Button[,] bButton, int x, int y, Point pLocation, Size sSize, Point tTag, String sText, Color cBackColor, System.EventHandler click)
        {
            bButton[x, y] = new Button
            {
                Location = pLocation,
                Size = sSize,
                Tag = tTag,
                Text = sText,
                BackColor = cBackColor
            };
            bButton[x, y].Click += click;
            return bButton[x, y];
        }
        public MenuStrip addMenuStrip(String[][] mMenuItems, System.EventHandler click)
        {
            MenuStrip mMenuStrip = new MenuStrip();
            ToolStripMenuItem mStripItem;
            ToolStripMenuItem mStripSubItem;

            for(int i = 0; i < mMenuItems.Length; i++)
            {
                mStripItem = new ToolStripMenuItem(mMenuItems[i][0]);
                mMenuStrip.Items.Add(mStripItem);
                for (int j = 1; j < mMenuItems[i].Length; j++)
                {
                    mStripSubItem = new ToolStripMenuItem(mMenuItems[i][j], null, click);
                    mStripItem.DropDownItems.Add(mStripSubItem);
                }
            }

            return mMenuStrip;
        }
        public StatusStrip addStatusStrip()
        {
            StatusStrip sStatusStrip = new StatusStrip();
            ToolStripStatusLabel tToolStripStatusLabel = new ToolStripStatusLabel();

            sStatusStrip.Dock = DockStyle.Bottom;
            sStatusStrip.Items.Add(tToolStripStatusLabel);
            tToolStripStatusLabel.Text = "Start";

            return sStatusStrip;
        }
    }
}
