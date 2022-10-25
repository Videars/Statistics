using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_tosses_graph
{
    public partial class Form1 : Form
    {

        Bitmap b;
        Graphics g;
        Random random = new Random();
        Pen PenTrajectory = new Pen(Color.Lime, 1);
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "0,5";
        }

        public int linearTransformX(double X, double minX, double maxX, int Left, int W)
        {
            return Left + (int)(W * ((X - minX) / (maxX - minX)));
        }

        public int linearTransformY(double Y, double minY, double maxY, int Top, int H)
        {
            return Top + (int)(H - H * ((Y - minY) / (maxY - minY)));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Number of trials: " + trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Number of trajectories: " + trackBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Color.Black);

            //trajectory generation ----------------------------------------------

            int TrialsCount = trackBar1.Value;
            double successProbability;
            Boolean success = Double.TryParse(comboBox1.Text, out successProbability);
            if (!success || (success & (successProbability > 1 || successProbability < 0))) successProbability = 0.5;
            int TrajectoryNumber = trackBar2.Value;

            double minX = 0;
            double maxX = (double)TrialsCount;
            double minY = 0;
            double maxY = (double)TrialsCount;

            Rectangle r = new Rectangle(20, 20, b.Width - 300, b.Height - 40);
            g.FillRectangle(Brushes.Black, r);
            g.DrawRectangle(Pens.White, r);

            List<Point> lastpoints = new List<Point>();

            for (int t = 0; t < TrajectoryNumber; t++)
            {
                List<Point> points = new List<Point>();
                double Y = 0;

                for (int X = 0; X < TrialsCount; X++)
                {
                    random.NextDouble();

                    if (random.NextDouble() < successProbability) Y = Y + 1;

                    int xCord = linearTransformX(X, minX, maxX, r.Left, r.Width);
                    int yCord = linearTransformY(Y, minY, maxY, r.Top, r.Height);

                    Point p = new Point(xCord, yCord);
                    points.Add(p);

                    if (X == TrialsCount - 1)
                    {
                        lastpoints.Add(p);
                    }
                }
                g.DrawLines(PenTrajectory, points.ToArray());
            }

            int min_y = lastpoints.Min(p => p.Y);
            int max_y = lastpoints.Max(p => p.Y);

            Rectangle r2 = new Rectangle(r.Right + 10, 20, 260, b.Height - 40);
            g.FillRectangle(Brushes.Black, r2);
            g.DrawRectangle(Pens.White, r2);

            if (TrajectoryNumber == 1)
            {
                foreach (Point p in lastpoints)
                {
                    Rectangle re = new Rectangle(r2.Left + 10, p.Y - 10, r2.Right - r2.Left - 20, 20);
                    g.FillRectangle(Brushes.Green, re);
                    g.DrawRectangle(Pens.White, re);
                }
            }
            else
            {
                int intervals_number = TrajectoryNumber / 2;
                if (intervals_number > 15)
                {
                    intervals_number = 15;
                }

                int span = max_y - min_y;
                int interval_size = (max_y - min_y) / intervals_number;

                while (min_y + interval_size * intervals_number < max_y + 1)
                {
                    intervals_number++;
                }

                int minimo = min_y;

                Dictionary<Interval, int> intervalli = new Dictionary<Interval, int>();

                for (int j = 0; j < intervals_number; j++)
                {
                    Interval intervallo = new Interval(minimo, minimo + interval_size);
                    minimo = minimo + interval_size;
                    intervalli[intervallo] = 0;
                }

                foreach (Point p in lastpoints)
                {
                    List<Interval> inter = intervalli.Keys.ToList();
                    int intY = (int)p.Y;

                    foreach (Interval i in inter)
                    {
                        if (intY >= i.down && intY < i.up)
                        {
                            intervalli[i]++;
                        }
                    }
                }

                List<Rectangle> chart = new List<Rectangle>();

                int dimdisp = r2.Right - r2.Left - 20;
                int maxValue = intervalli.Values.Max();

                foreach (var v in intervalli)
                {
                    double intensity = ((double)v.Value / (double)maxValue) * dimdisp;
                    Rectangle rect = new Rectangle(r2.Left + 10, v.Key.down, (int)intensity, interval_size);
                    chart.Add(rect);
                }

                foreach (Rectangle re in chart)
                {
                    g.FillRectangle(Brushes.Green, re);
                    g.DrawRectangle(Pens.White, re);
                }

            }

            pictureBox1.Image = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Color.Black);

            //trajectory generation ----------------------------------------------

            int TrialsCount = trackBar1.Value;
            double successProbability;
            Boolean success = Double.TryParse(comboBox1.Text, out successProbability);
            if (!success || (success & (successProbability > 1 || successProbability < 0))) successProbability = 0.5;
            int TrajectoryNumber = trackBar2.Value;

            double minX = 0;
            double maxX = (double)TrialsCount;
            double minY = 0;
            double maxY = 1;

            Rectangle r = new Rectangle(20, 20, b.Width - 300, b.Height - 40);
            g.FillRectangle(Brushes.Black, r);
            g.DrawRectangle(Pens.White, r);

            List<Point> lastpoints = new List<Point>();

            for (int t = 0; t < TrajectoryNumber; t++)
            {
                List<Point> points = new List<Point>();
                double Yt = 0;

                for (int X = 0; X < TrialsCount; X++)
                {
                    random.NextDouble();

                    if (random.NextDouble() < successProbability) Yt = Yt + 1;

                    double Y = Yt / (X + 1);

                    int xCord = linearTransformX(X, minX, maxX, r.Left, r.Width);
                    int yCord = linearTransformY(Y, minY, maxY, r.Top, r.Height);

                    Point p = new Point(xCord, yCord);
                    points.Add(p);

                    if (X == TrialsCount - 1)
                    {
                        lastpoints.Add(p);
                    }
                }
                g.DrawLines(PenTrajectory, points.ToArray());
            }

            int min_y = lastpoints.Min(p => p.Y);
            int max_y = lastpoints.Max(p => p.Y);

            Rectangle r2 = new Rectangle(r.Right + 10, 20, 260, b.Height - 40);
            g.FillRectangle(Brushes.Black, r2);
            g.DrawRectangle(Pens.White, r2);

            if (TrajectoryNumber == 1)
            {
                foreach (Point p in lastpoints)
                {
                    Rectangle re = new Rectangle(r2.Left + 10, p.Y - 10, r2.Right - r2.Left - 20, 20);
                    g.FillRectangle(Brushes.Green, re);
                    g.DrawRectangle(Pens.White, re);
                }
            }
            else
            {
                int intervals_number = TrajectoryNumber / 2;
                if (intervals_number > 15)
                {
                    intervals_number = 15;
                }

                int span = max_y - min_y;
                int interval_size = (max_y - min_y) / intervals_number;

                while (min_y + interval_size * intervals_number < max_y + 1)
                {
                    intervals_number++;
                }

                int minimo = min_y;

                Dictionary<Interval, int> intervalli = new Dictionary<Interval, int>();

                for (int j = 0; j < intervals_number; j++)
                {
                    Interval intervallo = new Interval(minimo, minimo + interval_size);
                    minimo = minimo + interval_size;
                    intervalli[intervallo] = 0;
                }

                foreach (Point p in lastpoints)
                {
                    List<Interval> inter = intervalli.Keys.ToList();
                    int intY = (int)p.Y;

                    foreach (Interval i in inter)
                    {
                        if (intY >= i.down && intY < i.up)
                        {
                            intervalli[i]++;
                        }
                    }
                }

                List<Rectangle> chart = new List<Rectangle>();

                int dimdisp = r2.Right - r2.Left - 20;
                int maxValue = intervalli.Values.Max();

                foreach (var v in intervalli)
                {
                    double intensity = ((double)v.Value / (double)maxValue) * dimdisp;
                    Rectangle rect = new Rectangle(r2.Left + 10, v.Key.down, (int)intensity, interval_size);
                    chart.Add(rect);
                }

                foreach (Rectangle re in chart)
                {
                    g.FillRectangle(Brushes.Green, re);
                    g.DrawRectangle(Pens.White, re);
                }

            }

            pictureBox1.Image = b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Color.Black);

            //trajectory generation ----------------------------------------------

            int TrialsCount = trackBar1.Value;
            double successProbability;
            Boolean success = Double.TryParse(comboBox1.Text, out successProbability);
            if (!success || (success & (successProbability > 1 || successProbability < 0))) successProbability = 0.5;
            int TrajectoryNumber = trackBar2.Value;

            double minX = 0;
            double maxX = (double)TrialsCount;
            double minY = 0;
            //double maxY = ((double)TrialsCount) * successProbability;
            double maxY = ((double)TrialsCount) / Math.Sqrt((double)TrialsCount);

            Rectangle r = new Rectangle(20, 20, b.Width - 300, b.Height - 40);
            g.FillRectangle(Brushes.Black, r);
            g.DrawRectangle(Pens.White, r);

            List<Point> lastpoints = new List<Point>();

            for (int t = 0; t < TrajectoryNumber; t++)
            {
                List<Point> points = new List<Point>();
                double Yt = 0;

                for (int X = 0; X < TrialsCount; X++)
                {
                    random.NextDouble();

                    if (random.NextDouble() < successProbability) Yt = Yt + 1;

                    double Y = Yt / Math.Sqrt(X + 1);
                    int xCord = linearTransformX(X, minX, maxX, r.Left, r.Width);
                    int yCord = linearTransformY(Y, minY, maxY, r.Top, r.Height);

                    Point p = new Point(xCord, yCord);
                    points.Add(p);

                    if (X == TrialsCount - 1)
                    {
                        lastpoints.Add(p);
                    }
                }
                g.DrawLines(PenTrajectory, points.ToArray());
            }

            int min_y = lastpoints.Min(p => p.Y);
            int max_y = lastpoints.Max(p => p.Y);

            Rectangle r2 = new Rectangle(r.Right + 10, 20, 260, b.Height - 40);
            g.FillRectangle(Brushes.Black, r2);
            g.DrawRectangle(Pens.White, r2);

            if (TrajectoryNumber == 1)
            {
                foreach (Point p in lastpoints)
                {
                    Rectangle re = new Rectangle(r2.Left + 10, p.Y - 10, r2.Right - r2.Left - 20, 20);
                    g.FillRectangle(Brushes.Green, re);
                    g.DrawRectangle(Pens.White, re);
                }
            }
            else
            {
                int intervals_number = TrajectoryNumber / 6;
                if (intervals_number > 15)
                    intervals_number = 15;
                else if (intervals_number <= 0)
                    intervals_number = 1;


                int span = max_y - min_y;
                int interval_size = (max_y - min_y) / intervals_number;

                while (min_y + interval_size * intervals_number < max_y + 1)
                {
                    intervals_number++;
                }

                int minimo = min_y;

                Dictionary<Interval, int> intervalli = new Dictionary<Interval, int>();

                for (int j = 0; j < intervals_number; j++)
                {
                    Interval intervallo = new Interval(minimo, minimo + interval_size);
                    minimo = minimo + interval_size;
                    intervalli[intervallo] = 0;
                }

                foreach (Point p in lastpoints)
                {
                    List<Interval> inter = intervalli.Keys.ToList();
                    int intY = (int)p.Y;

                    foreach (Interval i in inter)
                    {
                        if (intY >= i.down && intY < i.up)
                        {
                            intervalli[i]++;
                        }
                    }
                }

                List<Rectangle> chart = new List<Rectangle>();

                int dimdisp = r2.Right - r2.Left - 20;
                int maxValue = intervalli.Values.Max();

                foreach (var v in intervalli)
                {
                    double intensity = ((double)v.Value / (double)maxValue) * dimdisp;
                    Rectangle rect = new Rectangle(r2.Left + 10, v.Key.down, (int)intensity, interval_size);
                    chart.Add(rect);
                }

                foreach (Rectangle re in chart)
                {
                    g.FillRectangle(Brushes.Green, re);
                    g.DrawRectangle(Pens.White, re);
                }

            }

            pictureBox1.Image = b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Color.Black);

            //trajectory generation ----------------------------------------------

            int TrialsCount = trackBar1.Value;
            double successProbability;
            Boolean success = Double.TryParse(comboBox1.Text, out successProbability);
            if (!success || (success & (successProbability > 1 || successProbability < 0))) successProbability = 0.5;
            int TrajectoryNumber = trackBar2.Value;

            double minX = 0;
            double maxX = (double)TrialsCount;
            double minY = 0;
            double maxY_abs = ((double)TrialsCount);
            double maxY_rel = 1;
            double maxY_nor = ((double)TrialsCount) / (Math.Sqrt((double)TrialsCount));

            List<Point> lastpoints_abs = new List<Point>();
            List<Point> lastpoints_rel = new List<Point>();
            List<Point> lastpoints_nor = new List<Point>();

            for (int t = 0; t < TrajectoryNumber; t++)
            {
                List<Point> points_abs = new List<Point>();
                List<Point> points_rel = new List<Point>();
                List<Point> points_nor = new List<Point>();

                double Yt = 0;

                for (int X = 0; X < TrialsCount; X++)
                {
                    random.NextDouble();

                    if (random.NextDouble() < successProbability) Yt = Yt + 1;

                    double Y_rel = Yt / (X + 1);
                    double Y_nor = Yt / Math.Sqrt(X + 1);

                    int xCord_abs = linearTransformX(X, minX, maxX, 0, b.Width);
                    int yCord_abs = linearTransformY(Yt, minY, maxY_abs, 0, b.Height);

                    int xCord_rel = linearTransformX(X, minX, maxX, 0, b.Width);
                    int yCord_rel = linearTransformY(Y_rel, minY, maxY_rel, 0, b.Height);

                    int xCord_nor = linearTransformX(X, minX, maxX, 0, b.Width);
                    int yCord_nor = linearTransformY(Y_nor, minY, maxY_nor, 0, b.Height);

                    Point p_abs = new Point(xCord_abs, yCord_abs);
                    Point p_rel = new Point(xCord_rel, yCord_rel);
                    Point p_nor = new Point(xCord_nor, yCord_nor);

                    points_abs.Add(p_abs);
                    points_rel.Add(p_rel);
                    points_nor.Add(p_nor);

                    if (X == TrialsCount - 1)
                    {
                        lastpoints_abs.Add(p_abs);
                        lastpoints_rel.Add(p_rel);
                        lastpoints_nor.Add(p_nor);
                    }
                }
                g.DrawLines(Pens.Lime, points_abs.ToArray());
                g.DrawLines(Pens.Red, points_rel.ToArray());
                g.DrawLines(Pens.Cyan, points_nor.ToArray());
            }
            pictureBox1.Image = b;
        }
    }
}
