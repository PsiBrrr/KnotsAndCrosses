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
        public Button addButton(Button bButton, Point pLocation, Size sSize, Int16 tTag, String sText, System.EventHandler click)
        {
            bButton = new Button
            {
                Location = pLocation,
                Size = sSize,
                Tag = tTag,
                Text = sText
            };
            bButton.Click += click;
            return bButton;
        }
        public Button addButton(Button bButton, Point pLocation, Size sSize, Int16 tTag, String sText, Color cBackColor, System.EventHandler click)
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
    }
}
