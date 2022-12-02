using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace geometrietrigonometrieproiectcomplet
{
    public partial class dotcontrol : UserControl
    {
        public dotcontrol()
        {
            InitializeComponent();
        }
        public int ismd = 0;

        private void dotcontrol_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void dotcontrol_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void dotcontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                this.Left = e.X;
                this.Top = e.Y;
            }
        }

        private void dotcontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
