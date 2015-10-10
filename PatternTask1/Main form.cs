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
            
            public int  x , RM ,RS, GM , GS , BM , BS;
        };


        public void PX(int m , int s , int x )  // calcuate P(x)
        {
            double res = Math.Sqrt(2*pi);
            res = 1 / res;
            res = res * s;
            int tmp1 = -(x - m) * (x - m);
            int tmp2 = 2 * s * s;
            tmp1 = tmp1 / tmp2;
            res = res * Math.Pow(tmp1, tmp1);
           //p = (res*s)+m;
            p =res ;
        }


        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)  // Load and Display Image
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(ofd.FileName);
                pictureBox1.Image = img;
            }
        }
        section C1, C2, C3, C4;
        public void read()
        {
            //Read Class 1 Data 
            C1.RM = Convert.ToInt32(R1M.Text);
            C1.RS = Convert.ToInt32(R1S.Text);
            C1.GM = Convert.ToInt32(G1M.Text);
            C1.GS = Convert.ToInt32(G1S.Text);
            C1.BM = Convert.ToInt32(B1M.Text);
            C1.BS = Convert.ToInt32(B1S.Text);

            //Read Class 2 Data 
            C2.RM = Convert.ToInt32(R2M.Text);
            C2.RS = Convert.ToInt32(R2S.Text);
            C2.GM = Convert.ToInt32(G2M.Text);
            C2.GS = Convert.ToInt32(G2S.Text);
            C2.BM = Convert.ToInt32(B2M.Text);
            C2.BS = Convert.ToInt32(B2S.Text);

            //Read Class 3 Data 
            C3.RM = Convert.ToInt32(R3M.Text);
            C3.RS = Convert.ToInt32(R3S.Text);
            C3.GM = Convert.ToInt32(G3M.Text);
            C3.GS = Convert.ToInt32(G3S.Text);
            C3.BM = Convert.ToInt32(B3M.Text);
            C3.BS = Convert.ToInt32(B3S.Text);

            //Read Class 4 Data 
            C4.RM = Convert.ToInt32(R4M.Text);
            C4.RS = Convert.ToInt32(R4S.Text);
            C4.GM = Convert.ToInt32(G4M.Text);
            C4.GS = Convert.ToInt32(G4S.Text);
            C4.BM = Convert.ToInt32(B4M.Text);
            C4.BS = Convert.ToInt32(B4S.Text);

        }

        public void drw()
        {

            int w , h ;
            w = Convert.ToInt32(width.Text);
            h = Convert.ToInt32(hight.Text);
            img = new Bitmap(w, h);
            Graphics gfx = Graphics.FromImage(img);

            // Create 4 Random Numbers 
            Random rnd = new Random();
            C1.x = rnd.Next(1, w);
            C2.x = rnd.Next(1, w);
            C3.x = rnd.Next(1, w);
            C4.x = rnd.Next(1, w);


            // Generate Random Red color value
            PX(C1.RM, C1.RS, C1.x);
            int R1 = Math.Abs(Convert.ToInt32(p));

            // Generate Random green color value
            PX(C1.GM, C1.GS, C1.x);
            int G1 = Math.Abs(Convert.ToInt32(p));

            // Generate Random Blue color value
            PX(C1.BM, C1.BS, C1.x);
            int B1 = Math.Abs(Convert.ToInt32(p));

            Color color = Color.FromArgb(R1, G1, B1);
            SolidBrush brush = new SolidBrush(color);
            gfx.FillRectangle(brush, 0, 0, w / 4, h);

            // Generate Random Red color value
            PX(C2.RM, C2.RS, C2.x);
            R1 = Math.Abs(Convert.ToInt32(p));

            // Generate Random green color value
            PX(C2.GM, C2.GS, C2.x);
            G1 = Math.Abs(Convert.ToInt32(p));
            // Generate Random Blue color value
            PX(C2.BM, C2.BS, C2.x);
            B1 = Math.Abs(Convert.ToInt32(p));
            color = Color.FromArgb(R1, G1, B1);
            brush = new SolidBrush(color);
            gfx.FillRectangle(brush, w / 4, 0, w / 4, h);

            // Generate Random Red color value
            PX(C3.RM, C3.RS, C3.x);
            R1 = Math.Abs(Convert.ToInt32(p));

            // Generate Random green color value
            PX(C3.GM, C3.GS, C3.x);
            G1 = Math.Abs(Convert.ToInt32(p));
            // Generate Random Blue color value
            PX(C3.BM, C3.BS, C3.x);
            B1 = Math.Abs(Convert.ToInt32(p));
            color = Color.FromArgb(R1, G1, B1);
            brush = new SolidBrush(color);
            gfx.FillRectangle(brush, w / 2, 0, w / 4, h);

            // Generate Random Red color value
            PX(C4.RM, C4.RS, C4.x);
            R1 = Math.Abs(Convert.ToInt32(p));

            // Generate Random green color value
            PX(C4.GM, C4.GS, C4.x);
            G1 = Math.Abs(Convert.ToInt32(p));

            // Generate Random Blue color value
            PX(C4.BM, C4.BS, C4.x);
            B1 = Math.Abs(Convert.ToInt32(p));
            color = Color.FromArgb(R1, G1, B1);
            brush = new SolidBrush(color);
            gfx.FillRectangle(brush, w - (w / 4), 0, w / 4, h);






            pictureBox1.Image = img;
        }

        private void gen_Click(object sender, EventArgs e)
        {
            

            read();
            drw();
          

        }
    }
}
