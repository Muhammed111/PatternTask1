using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternTask1
{
    
    public partial class Form1 : Form
    {
        Bitmap img;
        double p;
        const  double  pi = 3.141592653589793238;
        public Form1()
        {
            InitializeComponent();
        }

        public struct section
        {
            
            public int M, S, x;
        };
        public void PX(int m , int s , int x )
        {
            double res = Math.Sqrt(2*pi);
            res = 1 / res;
            res = res * s;
            int tmp1 = -(x - m) * (x - m);
            int tmp2 = 2 * s * s;
            tmp1 = tmp1 / tmp2;
            res = res * Math.Pow(tmp1, tmp1);
            p = res;
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(ofd.FileName);
                pictureBox1.Image = img;
            }
        }

        private void gen_Click(object sender, EventArgs e)
        {
            int w, h;
            w = Convert.ToInt32(width.Text);
            h = Convert.ToInt32(hight.Text);
            img = new Bitmap(w,h);
            Graphics gfx = Graphics.FromImage(img);


             section C1 , C2 , C3 , C4;

            C1.M = Convert.ToInt32(M1.Text);
            C1.S = Convert.ToInt32(S1.Text);
            C2.M = Convert.ToInt32(M2.Text);
            C2.S = Convert.ToInt32(S2.Text);
            C3.M = Convert.ToInt32(M3.Text);
            C3.S = Convert.ToInt32(S3.Text);
            C4.M = Convert.ToInt32(M4.Text);
            C4.S = Convert.ToInt32(S4.Text);

            Random rnd = new Random();
            C1.x = rnd.Next(1, 50);
            C2.x = rnd.Next(1, 100);
            C3.x = rnd.Next(1, 150);
            C4.x = rnd.Next(1, 250);

             PX(C1.M, C1.S, C1.x);
             int  p1 =Convert.ToInt32( p);
             PX(C2.M, C2.S, C2.x);
             int p2 = Convert.ToInt32(p);
             PX(C3.M, C3.S, C3.x);
             int p3 = Convert.ToInt32(p);
             PX(C4.M, C4.S, C4.x);
             int p4 = Convert.ToInt32(p);
             Color color = Color.FromArgb(Math.Abs(p1), 0, 0);
            SolidBrush brush = new SolidBrush(color);

            gfx.FillRectangle(brush , 0 , 0 , w/4 , h );

            color = Color.FromArgb(Math.Abs(p2), 0, 0);
            gfx.FillRectangle(brush,  w / 4, 0 , w/4 , h );

            color = Color.FromArgb(Math.Abs(p3), 0, 0);
            gfx.FillRectangle(brush, w / 2, 0 ,w/4 ,h);

            color = Color.FromArgb(Math.Abs(p4), 0, 0);
            gfx.FillRectangle(brush, w - (w/4)  , 0,w/4 ,h);


            
            
         //   gfx.FillRectangle(brush, w - (w / 4), 0, w / 4, h);

            pictureBox1.Image = img;

        }
    }
}
