using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using graphiccontrol;

namespace geometrietrigonometrieproiectcomplet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int px = 0;
        int py = 0;
        int cx = 0;
        int cy = 0;
        desen desenul = new desen();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cx = px;
            cy = py;
            px = e.X;
            py = e.Y;
            
        }


        private void punctToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //canvas.g.DrawEllipse(new Pen(Color.Red), px, py, 5, 5);
            desenul.figuri.Add(new punct());
                int x = desenul.figuri.Count - 1;
                punct a = (punct)(desenul.figuri[x]) ;
               a.drawPunct(canvas.g, px, py, 5, 5);
            
        }

        private void linieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //canvas.g.DrawLine(new Pen(Color.Red), px, py, cx, cy);
            desenul.figuri.Add(new linie());
            int x = desenul.figuri.Count - 1;
            linie a = (linie)(desenul.figuri[x]);
            a.drawLinie(canvas.g, px, py, cx, cy);
        }

        private void unghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // canvas.g.DrawLine(new Pen(Color.Red), px, py, cx, cy);
           // canvas.g.DrawLine(new Pen(Color.Red), 20,20, cx, cy);
           // canvas.g.DrawLine(new Pen(Color.Red), px, py, 20,20);
            desenul.figuri.Add(new unghi());
            int x = desenul.figuri.Count - 1;
            unghi a = (unghi)(desenul.figuri[x]);
            a.drawUnghi(canvas.g, px, py, cx, cy, 20, 20);
        }

        private void triunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //canvas.g.DrawLine(new Pen(Color.Red), px, py, cx, cy);
            //canvas.g.DrawLine(new Pen(Color.Red), 20, 20, cx, cy);
            //canvas.g.DrawLine(new Pen(Color.Red), px, py, 20, 20);
            desenul.figuri.Add(new triunghi());
            int x = desenul.figuri.Count - 1;
            triunghi a = (triunghi)(desenul.figuri[x]);
            a.drawTriunghi(canvas.g, px, py, cx, cy, 20, 20);
        }

        private void patrulaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // canvas.g.DrawLine(new Pen(Color.Red), px, py, cx, cy);
           // canvas.g.DrawLine(new Pen(Color.Red), px, py, px, 20);
           // canvas.g.DrawLine(new Pen(Color.Red), px, 20, cy, 20);
           // canvas.g.DrawLine(new Pen(Color.Red), py, 20, cx, cy);
            desenul.figuri.Add(new patrulater());
            int x = desenul.figuri.Count - 1;
            patrulater a = (patrulater)(desenul.figuri[x]);
            a.drawPatrulater(canvas.g, px, py, cx, cy, 20, 20,30,40);
        }

        private void cercToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //canvas.g.DrawEllipse(new Pen(Color.Red), px, py, 50, 50);
            desenul.figuri.Add(new cerc());
            int x = desenul.figuri.Count - 1;
            cerc a = (cerc)(desenul.figuri[x]);
            a.drawCerc(canvas.g, px, py, 50, 50);
        }
    }
}
