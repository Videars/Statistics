namespace Bernoulli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialize_graphics();
        }

        Bitmap b;
        Graphics g;
        EditableRectangle r1;
        EditableRectangle r2;
        Pen PenTrajectory;

        int tosses = 100;
        int trajectories = 1;
        int lambda = 1;

        double minX;
        double maxX;
        double minY;
        double maxY;

        List<List<RealPoint>> trajectorylist;
        List<RealPoint> lastpoints;

        List<int> interarrivals;

        Dictionary<Interval, int> lastpoints_distribution;
        Dictionary<Interval, int> interarrival_distribution;

        Random random = new Random();

        private void initialize_graphics()
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);

            r1 = new EditableRectangle(20, 20, b.Width - 700, b.Height - 200, pictureBox1, this);
            r2 = new EditableRectangle(b.Width - 400, 300, b.Width - 1000, b.Height - 400, pictureBox1, this);
            PenTrajectory = new Pen(Color.OrangeRed, 1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tosses = trackBar1.Value;
            label1.Text = "Number of tosses n - " + tosses.ToString();
            if (trackBar3.Value >= trackBar1.Value)
            {
                trackBar3.Value = trackBar1.Value;
                label3.Text = "Lambda parameter - " + tosses.ToString();
            }
            trackBar3.Maximum = tosses;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trajectories = trackBar2.Value;
            label2.Text = "Number of trajectories n - " + trajectories.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            lambda = trackBar3.Value;
            label3.Text = "Lambda parameter - " + lambda.ToString();
        }

        public int linearTransformX(double X, double minX, double maxX, int Left, int W)
        {
            return Left + (int)(W * ((X - minX) / (maxX - minX)));
        }

        public int linearTransformY(double Y, double minY, double maxY, int Top, int H)
        {
            return Top + (int)(H - H * ((Y - minY) / (maxY - minY)));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            minX = 0;
            maxX = (double)tosses;
            minY = 0;
            maxY = Math.Min((double)tosses, (double)6 * lambda);

            timer1.Start();
            double successProbability = (double)lambda / (double)tosses;

            lastpoints = new List<RealPoint>();

            trajectorylist = new List<List<RealPoint>>();

            interarrivals = new List<int>();

            for (int t = 0; t < trajectories; t++)
            {
                List<RealPoint> points = new List<RealPoint>();
                double Y = 0;

                int count_inter = 0;

                for (int X = 0; X < tosses; X++)
                {

                    if (random.NextDouble() < successProbability)
                    {
                        Y = Y + 1;
                        interarrivals.Add(count_inter);
                        count_inter = 0;
                    }
                    else
                    {
                        count_inter++;
                    }

                    RealPoint p = new RealPoint(X, Y);
                    points.Add(p);

                    if (X == tosses - 1)
                    {
                        lastpoints.Add(p);
                    }
                }
                trajectorylist.Add(points);
            }
            compute_lastpoints_distribution();
            compute_interarrival_disribution();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            drawLines();
            drawHistogram();
            draw_histogram_horizontal();
            pictureBox1.Image = b;
        }

        private void drawLines()
        {

            g.FillRectangle(Brushes.Black, r1.r);
            g.DrawRectangle(Pens.Black, r1.r);

            foreach (List<RealPoint> line in trajectorylist)
            {
                List<Point> graphline = new List<Point>();
                foreach (RealPoint rp in line)
                {
                    double X = rp.X;
                    double Y = rp.Y;

                    int xCord = linearTransformX(X, minX, maxX, r1.r.Left, r1.r.Width);
                    int yCord = linearTransformY(Y, minY, maxY, r1.r.Top, r1.r.Height);

                    Point p = new Point(xCord, yCord);
                    graphline.Add(p);
                }
                g.DrawLines(PenTrajectory, graphline.ToArray());
            }
        }

        private void drawHistogram()
        {
            int maxvalue = lastpoints_distribution.Values.Max();
            int space_height = (r1.r.Right - r1.r.Left) / 3;

            foreach (KeyValuePair<Interval, int> kv in lastpoints_distribution)
            {

                Interval i = kv.Key;
                int alt = kv.Value;

                int rect_height = (int)(((double)kv.Value / (double)maxvalue) * ((double)space_height));

                int down_mod = linearTransformY(i.down, minY, maxY, r1.r.Top, r1.r.Height);
                int up_mod = linearTransformY(i.up, minY, maxY, r1.r.Top, r1.r.Height);

                int size = Math.Abs(down_mod - up_mod);

                Rectangle histrect = new Rectangle(r1.r.Right, up_mod, rect_height, size);
                g.FillRectangle(Brushes.Green, histrect);
                g.DrawRectangle(Pens.Red, histrect);
            }
        }

        private void draw_histogram_horizontal()
        {
            g.FillRectangle(Brushes.Black, r2.r);
            g.DrawRectangle(Pens.Black, r2.r);

            int maxvalue;

            if (interarrival_distribution.Count != 0)
            {
                maxvalue = interarrival_distribution.Values.Max();
            }
            else
            {
                maxvalue = 0;
            }

            int space_height = r2.r.Bottom - r2.r.Top - 20;
            int space_width = r2.r.Right - r2.r.Left - 20;

            int num_intervals = interarrival_distribution.Keys.Count;
            int histrect_width;

            if (num_intervals != 0)
            {
                histrect_width = space_width / num_intervals;
            }
            else
            {
                histrect_width = 0;
            }

            int start = r2.r.X;

            foreach (KeyValuePair<Interval, int> k in interarrival_distribution)
            {
                int rect_height = (int)(((double)k.Value / (double)maxvalue) * ((double)space_height));
                Rectangle hist_rect = new Rectangle(start, r2.r.Bottom - rect_height, histrect_width, rect_height);

                g.FillRectangle(Brushes.Green, hist_rect);
                g.DrawRectangle(Pens.White, hist_rect);

                //scrittura chiavi

                Interval interval_k = k.Key;
                string text = interval_k.ToString();
                Rectangle stringPos = new Rectangle(start, r2.r.Bottom + 20, histrect_width, histrect_width + 20);
                Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                Font goodFont = findFont(g, text, stringPos.Size, font1);

                g.DrawString(text, goodFont, Brushes.White, stringPos, stringFormat);

                //fine scrittura chiavi

                start += histrect_width;
            }
        }

        private void compute_lastpoints_distribution()
        {
            lastpoints_distribution = new Dictionary<Interval, int>();

            int current = (int)Math.Floor(minY);
            int max = (int)Math.Ceiling(maxY);

            int size = (int)Math.Min(maxY / 6, 3);

            while (current < max)
            {
                Interval i = new Interval(current, current + size);
                current = current + size;

                lastpoints_distribution[i] = 0;
            }

            foreach (RealPoint p in lastpoints)
            {
                List<Interval> keys = lastpoints_distribution.Keys.ToList();
                bool p_inserted = false;
                foreach (Interval v in keys)
                {
                    if (p.Y >= v.down && p.Y <= v.up && !p_inserted)
                    {
                        p_inserted = true;
                        lastpoints_distribution[v]++;
                    }
                }
            }
        }

        private void compute_interarrival_disribution()
        {
            interarrival_distribution = new Dictionary<Interval, int>();
            int next = 0;
            int interval_size = 1;

            foreach (int inter in interarrivals)
            {
                bool inserted = false;

                List<Interval> keys = interarrival_distribution.Keys.ToList();
                foreach (Interval v in keys)
                {
                    if (inter >= v.down && inter < v.up)
                    {
                        inserted = true;
                        interarrival_distribution[v]++;
                    }
                }
                while (!inserted)
                {
                    Interval newint = new Interval(next, next + interval_size);
                    next = next + interval_size;
                    interarrival_distribution[newint] = 0;

                    if (inter >= newint.down && inter < newint.up)
                    {
                        interarrival_distribution[newint]++;
                        inserted = true;
                    }
                }
            }
        }

        private Font findFont(Graphics g, string myString, Size Room, Font PreferedFont)
        {
            SizeF RealSize = g.MeasureString(myString, PreferedFont);
            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;

            float ScaleRatio = (HeightScaleRatio < WidthScaleRatio) ? ScaleRatio = HeightScaleRatio : ScaleRatio = WidthScaleRatio;

            float ScaleFontSize = PreferedFont.Size * ScaleRatio;

            if (ScaleFontSize <= 0)
            {
                ScaleFontSize = 0.0000001f;
            }

            return new Font(PreferedFont.FontFamily, ScaleFontSize);
        }
    }
}