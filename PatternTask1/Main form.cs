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
            
            public double  x , RM ,RS, GM , GS , BM , BS;
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


        public double createMemberInNormalDistribution(double mean, double std_dev, Random r)
        {
            double u, v, S;

            do
            {
                u = 2.0 * r.NextDouble() - 1.0;
                v = 2.0 * r.NextDouble() - 1.0;
                S = u * u + v * v;
            }
            while (S >= 1.0);

            double fac = Math.Sqrt(-2.0 * Math.Log(S) / S);
            fac = u * fac;

            return mean + (fac * std_dev);
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
            C1.RM = Convert.ToDouble(R1M.Text);
            C1.RS = Convert.ToDouble(R1S.Text);
            C1.GM = Convert.ToDouble(G1M.Text);
            C1.GS = Convert.ToDouble(G1S.Text);
            C1.BM = Convert.ToDouble(B1M.Text);
            C1.BS = Convert.ToDouble(B1S.Text);

            //Read Class 2 Data 
            C2.RM = Convert.ToDouble(R2M.Text);
            C2.RS = Convert.ToDouble(R2S.Text);
            C2.GM = Convert.ToDouble(G2M.Text);
            C2.GS = Convert.ToDouble(G2S.Text);
            C2.BM = Convert.ToDouble(B2M.Text);
            C2.BS = Convert.ToDouble(B2S.Text);

            //Read Class 3 Data 
            C3.RM = Convert.ToDouble(R3M.Text);
            C3.RS = Convert.ToDouble(R3S.Text);
            C3.GM = Convert.ToDouble(G3M.Text);
            C3.GS = Convert.ToDouble(G3S.Text);
            C3.BM = Convert.ToDouble(B3M.Text);
            C3.BS = Convert.ToDouble(B3S.Text);

            //Read Class 4 Data 
            C4.RM = Convert.ToDouble(R4M.Text);
            C4.RS = Convert.ToDouble(R4S.Text);
            C4.GM = Convert.ToDouble(G4M.Text);
            C4.GS = Convert.ToDouble(G4S.Text);
            C4.BM = Convert.ToDouble(B4M.Text);
            C4.BS = Convert.ToDouble(B4S.Text);

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
           /*
            C1.x = rnd.Next(1, w);
            C2.x = rnd.Next(1, w);
            C3.x = rnd.Next(1, w);
            C4.x = rnd.Next(1, w);
            */

            // Generate Random Red color value
 
            double R1 = createMemberInNormalDistribution(C1.RM,C1.RS,rnd);
        
            // Generate Random green color value
         
            double G1 = createMemberInNormalDistribution(C1.GM, C1.GS, rnd);
            // Generate Random Blue color value
         
            double B1 = createMemberInNormalDistribution(C1.BM, C1.BS, rnd);
            Color color = Color.FromArgb(Convert.ToInt32(R1),Convert.ToInt32( G1), Convert.ToInt32(B1));
            SolidBrush brush = new SolidBrush(color);
            gfx.FillRectangle(brush, 0, 0, w / 4, h);

            // Generate Random Red color value
      

             R1 = createMemberInNormalDistribution(C2.RM, C2.RS, rnd);
            // Generate Random green color value
          
            G1 = createMemberInNormalDistribution(C2.GM, C2.GS, rnd);

            // Generate Random Blue color value
           

            B1 = createMemberInNormalDistribution(C2.BM, C2.BS, rnd);
            color = Color.FromArgb(Convert.ToInt32(R1), Convert.ToInt32(G1), Convert.ToInt32(B1));
            brush = new SolidBrush(color);
            gfx.FillRectangle(brush, w / 4, 0, w / 4, h);

            // Generate Random Red color value
         

            R1 = createMemberInNormalDistribution(C3.RM, C3.RS, rnd);

            // Generate Random green color value
           
            G1 = createMemberInNormalDistribution(C3.GM, C3.GS, rnd);
            // Generate Random Blue color value
          

            B1 = createMemberInNormalDistribution(C3.BM, C3.BS, rnd);
            color = Color.FromArgb(Convert.ToInt32(R1), Convert.ToInt32(G1), Convert.ToInt32(B1));
            brush = new SolidBrush(color);
            gfx.FillRectangle(brush, w / 2, 0, w / 4, h);

            // Generate Random Red color value
          

            R1 = createMemberInNormalDistribution(C4.RM, C4.RS, rnd);
            // Generate Random green color value
            

            G1 = createMemberInNormalDistribution(C4.GM, C4.GS, rnd);

            // Generate Random Blue color value
            
            B1 = createMemberInNormalDistribution(C4.BM, C4.BS, rnd);
            color = Color.FromArgb(Convert.ToInt32(R1), Convert.ToInt32(G1), Convert.ToInt32(B1));
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
