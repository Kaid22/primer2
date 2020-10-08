using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int a = 50;
            int x = e.X;
            int y = e.Y;
            Point A = new Point(x - a / 2, y- a / 2);
            Point B = new Point(x + a / 2, y- a / 2);
            Point C = new Point(x + a / 2, y+ a / 2);
            Point D = new Point(x - a / 2, y+ a / 2);
            Graphics g = CreateGraphics();
            PointF[] arr = { A,B,C,D,A,D,B,C };
            g.DrawPolygon(Pens.Red, arr);
        }
    }
}
