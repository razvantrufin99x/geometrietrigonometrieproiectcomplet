﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace geometrietrigonometrieproiectcomplet
{
    public class triunghi : figura
    {
        public linie liniaA;
        public linie liniaB;
        public linie liniaC;

        public void drawTriunghi(Graphics gg, int ppx, int ppy, int pcx, int pcy, int xx, int yy)
        {
            gg.DrawLine(new Pen(Color.Red), ppx, ppy, pcx, pcy);
            gg.DrawLine(new Pen(Color.Red), xx, yy, pcx, pcy);
            gg.DrawLine(new Pen(Color.Red), ppx, ppy, xx, yy);
        }
    }
}
