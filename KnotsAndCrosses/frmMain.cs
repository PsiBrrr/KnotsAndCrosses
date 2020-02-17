using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KnotsAndCrosses
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(Size frmSize, FormStartPosition frmPostiion, FormBorderStyle frmBorderStyle, String frmTitle, Boolean frmMaximizable, ArrayList frmControls)
        {
            InitializeComponent();
            Size = frmSize;
            StartPosition = frmPostiion;
            Text = frmTitle;
            MaximizeBox = frmMaximizable;
            FormBorderStyle = frmBorderStyle;

            foreach(Control i in frmControls)
            {
                Controls.Add(i);
            }
        }

        //public void addControls<T>(T control) where T : Control
        //{
        //    Controls.Add(control);
        //}

    }
}
