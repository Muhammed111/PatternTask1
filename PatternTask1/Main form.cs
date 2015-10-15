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
       
        public Form1()
        {
            InitializeComponent();
        }

        public struct section
        {
            
            public double  x , RM ,RS, GM , GS , BM , BS;
        };


      


        public double createMemberInNormalDistribution(double mean, double std_dev, Random r)
        {
            
            double U1, U2;
            U1 = r.NextDouble();
            U2 = r.NextDouble();
            double Z = Math.Sqrt(-2 * Math.Log(U1, Math.E)) * Math.Cos(2 * Math.PI * U2);
            double scaledZ = Z * std_dev + mean;
            return scaledZ;
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
        section[] sec = new section[4];


        public void red(ref section s, int Row_start)
        {
            // for (int i = Row_start; i <= Row_start + 2; i++)
            {
                int i = Row_start;
                s.RM = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                s.GM = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                s.BM = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                s.RS = Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[0].Value);
                s.GS = Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[1].Value);
                s.BS = Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[2].Value);


            }
        }

        public void read()
        {

            red(ref sec[0], 0);
            red(ref sec[1], 2);
            red(ref sec[2], 4);
            red(ref sec[3], 6);

        }


      
        public void drw()
        {

            int w , h ;
            w = Convert.ToInt32(width.Text);
            h = Convert.ToInt32(hight.Text);
            img = new Bitmap(w, h);
            Graphics gfx = Graphics.FromImage(img);

            drew(0, w / 4, h, sec[0]);
            drew(w/4, w / 2, h, sec[1]);
            drew(w / 2, w - (w / 4), h, sec[2]);
            drew(w - (w / 4), w , h, sec[3]);

          

            pictureBox1.Image = img;
        }



        public void drew (int st , int w , int h , section s )
        {
            
            
             double R1, G1, B1;
            Color color;
            for (int i = st; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Random rnd = new Random();
                    R1 = createMemberInNormalDistribution(s.RM, s.RS, rnd);

                    // Generate Random green color value

                    G1 = createMemberInNormalDistribution(s.GM, s.GS, rnd);
                    // Generate Random Blue color value

                    B1 = createMemberInNormalDistribution(s.BM, s.BS, rnd);
                    color = Color.FromArgb(Convert.ToInt32(R1), Convert.ToInt32(G1), Convert.ToInt32(B1));
                    //  SolidBrush brush = new SolidBrush(color);
                    img.SetPixel(i, j, color);
                }
            }

        }


        private void gen_Click(object sender, EventArgs e)
        {
            

            read();
            drw();
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
