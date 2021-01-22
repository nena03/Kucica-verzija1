using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kucica
{
    class Kucica
    {
        protected int x, y;
        protected int a = 100;
        public Kucica(int x, int y)
        {
            this.x = x;
            this.y = y;
          
        }
        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(Color.Black,15);
            SolidBrush cetkav = new SolidBrush(Color.Brown);
            SolidBrush cetkak = new SolidBrush(Color.Red);
            SolidBrush cetkaf = new SolidBrush(Color.Lime);
            Point point1 = new Point(x - a / 2, y + a / 2);
            Point point2 = new Point(x - a / 6, y + a / 2);
            Point point3 = new Point(x - a / 6, y);
            Point point4 = new Point(x + a / 6, y);
            Point point5 = new Point(x + a / 6, y + a / 2);
            Point point6 = new Point(x + a / 2, y + a / 2);
            Point point7 = new Point(x + a / 2, y - a / 2);
            Point point8 = new Point(x, y - a);
            Point point9 = new Point(x - a / 2, y - a / 2);
            Point[] krov = { point7, point8, point9 };
            Point[] fasada = { point1, point2, point3, point4, point5, point6, point7, point9 };
            Point[] vrata = { point2, point3, point4, point5 };
            g.DrawLine(olovka, point1, point6);
            g.DrawLine(olovka, point6, point7);
            g.DrawLine(olovka, point7, point8);
            g.DrawLine(olovka, point8, point9);
            g.DrawLine(olovka, point9, point1);
            g.DrawLine(olovka, point3, point4);
            g.DrawLine(olovka, point2, point3);
            g.DrawLine(olovka, point5, point4);
            g.FillPolygon(cetkak, krov);
            g.FillPolygon(cetkaf, fasada);
            g.FillPolygon(cetkav, vrata);
        }
    }
}
