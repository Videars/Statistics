using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            this.g = Graphics.FromImage(b);
        }

        public int resizeX(double minX, double maxX, int W, double x)
        {
            return Convert.ToInt32((x-minX)*W/(maxX-minX));
        }

        public int resizeY(double minY, double maxY, int H, double y)
        {
            return Convert.ToInt32(H - (y-minY)*H/(maxY-minY));
        }

        public Bitmap b;
        public Graphics g;
        public Random r = new Random();
        public double successProb = 0.5;
        public int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Image = b;

            r = new Random();

            int trials = 1000;
            int toss = 0;
            int rfreq = 0;
            int nfreq = 0;

            Point[] points = new Point[trials];
            Point[] rpoints = new Point[trials];
            Point[] npoints = new Point[trials];

            for (int i = 0; i < trials; i++)
            {
                double uniform = r.NextDouble();
                if (uniform <= successProb)
                {
                    toss++;
                }
                rfreq = (int)(toss * trials / (i + 1));
                nfreq = (int)(toss * ((trials) ^ (1 / 2)) / ((i + 1) ^ (1 / 2)));

                Point p = new Point();
                Point rp = new Point();
                Point np = new Point();

                p.X = resizeX(0, trials, pictureBox1.Width, i);
                p.Y = resizeY(0, trials, pictureBox1.Height, toss);

                rp.X = resizeX(0, trials, pictureBox1.Width, i);
                rp.Y = resizeY(0, trials, pictureBox1.Height, rfreq);

                np.X = resizeX(0, trials, pictureBox1.Width, i);
                np.Y = resizeY(0, trials*successProb, pictureBox1.Height, nfreq);


                points[i] = p;
                rpoints[i] = rp;
                npoints[i] = np;
            }
            this.g.DrawLines(Pens.Lime, points);
            this.g.DrawLines(Pens.Red, rpoints);
            this.g.DrawLines(Pens.White, npoints);
            this.richTextBox1.AppendText($"{toss}\n");

            counter++;
            if ((counter % 10) == 0)
                this.timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.pictureBox1.Image = null;
            g.Clear(Color.Black);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            successProb = Convert.ToDouble(this.numericUpDown1.Value)/100;
        }
    }
}
