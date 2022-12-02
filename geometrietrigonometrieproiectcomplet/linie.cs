using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geometrietrigonometrieproiectcomplet
{
    public class linie : figura
    {
        public punct punctulA;
        public punct punctulB;

        public void drawLinie(Graphics gg, int ppx, int ppy, int pcx, int pcy)
        {
            gg.DrawLine(new Pen(Color.Red), ppx, ppy, pcx, pcy);
        }
    }
}
