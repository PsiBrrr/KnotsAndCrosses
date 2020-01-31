using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnotsAndCrosses
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(Size frmSize, FormStartPosition frmPostiion, String frmTitle, Boolean frmMaximizable)
        {
            InitializeComponent();
            Size = frmSize;
            StartPosition = frmPostiion;
            Text = frmTitle;
            MaximizeBox = frmMaximizable;
        }
        public frmMain(Int16 frmSizeX, Int16 frmSizeY, FormStartPosition frmPostiion, String frmTitle, Boolean frmMaximizable)
        {
            InitializeComponent();
            Size = new Size(frmSizeX, frmSizeY);
            StartPosition = frmPostiion;
            Text = frmTitle;
            MaximizeBox = frmMaximizable;
        }
    }
}
