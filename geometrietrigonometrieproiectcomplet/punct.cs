﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geometrietrigonometrieproiectcomplet
{
    public class punct : figura
    {
        
        public void drawPunct(Graphics gg, int ppx, int ppy, int dimx, int dimy)
        {
            gg.DrawEllipse(new Pen(Color.Red), ppx, ppy, dimx, dimy);
        }
    }
}
