using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kucica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int x, y,j,l;

       

        Kucica[] k = new Kucica[20];
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            y = ClientRectangle.Height/2-500;
            x= ClientRectangle.Width/2-50;
            
            
             timer1.Start();
             y += 80;
             x = r.Next(0, 400);

               
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();



        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            Kucica k = new Kucica(x,y);

            k.Crtaj(g);
            if (y < ClientRectangle.Height) 
            {
                y += 50;

            }
            else {Refresh();
                y = -50;
               
                
            }

        }

    }
}
