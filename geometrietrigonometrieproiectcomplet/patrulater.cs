using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geometrietrigonometrieproiectcomplet
{
    public class patrulater : figura
    {
        public linie liniaA;
        public linie liniaB;
        public linie liniaC;
        public linie liniaD;

        public void drawPatrulater(Graphics gg, int ppx, int ppy, int pcx, int pcy, int xx1, int yy1, int xx2, int yy2)
        {
            gg.DrawLine(new Pen(Color.Red), ppx, ppy, pcx, pcy);
            gg.DrawLine(new Pen(Color.Red), xx1, yy1, pcx, pcy);
            gg.DrawLine(new Pen(Color.Red), ppx, ppy, xx2, yy2);
        }

    }
}
