using Microsoft.VisualBasic.FileIO;
using System.Net.Sockets;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DynamicChart
{
    public partial class Form1 : Form
    {
        EditableRectangle r;
        EditableRectangle r2;
        Bitmap b;
        Graphics g;
        List<Packet> packets = new List<Packet>();
        List<protocols> frequency = new List<protocols>();
        Dictionary<String, int> protocolDistribution;

        public Form1()
        {
            InitializeComponent();
            compute_distribution();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);

            r = new EditableRectangle(20, 20, pictureBox1.Width / 2, pictureBox1.Height / 2, pictureBox1, this);
            r2 = new EditableRectangle((pictureBox1.Width / 2) + 20, (pictureBox1.Height / 2) + 20, (pictureBox1.Width / 2) - 50 , (pictureBox1.Height / 2) - 50, pictureBox1, this);
            timer1.Start();
        }

        public class protocols
        {
            public string protocol { get; set; }
            public int count { get; set; }
        }

        private void compute_distribution()
        {
            using (var reader = new StreamReader(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\wireshark.csv"))
            {
                var line = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(',');

                    Packet packet = new Packet();

                    int i = 0;
                    while (i < 7)
                    {
                        values[i] = values[i].Replace("\"", "");
                        i++;
                    }
                    packet.Id = Convert.ToInt32(values[0].Replace("\"", ""));
                    packet.Time = Convert.ToDouble(values[1].Replace("\"", ""));
                    packet.Source = values[2];
                    packet.Destination = values[3];
                    packet.Protocol = values[4];
                    packet.Length = Convert.ToInt32(values[5].Replace("\"", ""));
                    packet.Info = values[6];

                    packets.Add(packet);


                    bool added = false;
                    foreach (Packet p in packets)
                    {
                        foreach (protocols q in frequency)
                        {
                            if (q.protocol == p.Protocol)
                            {
                                added = true;
                                break;
                            }
                            else
                            {
                                added = false;
                            }
                        }

                        if (added == false)
                        {
                            frequency.Add(new protocols() { protocol = p.Protocol, count = 1 });
                        }
                        else
                        {
                            foreach (protocols q in frequency)
                            {
                                if (q.protocol == p.Protocol)
                                {
                                    q.count++;
                                    break;
                                }
                            }
                        }
                        added = false;
                    }
                }
            }

            protocolDistribution = new Dictionary<string, int>();

            foreach (protocols p in frequency)
                if (!protocolDistribution.ContainsKey(p.protocol))
                    protocolDistribution.Add(p.protocol, p.count);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            if(checkBox1.Checked == false)
                drawHistogram_horizontal();
            else
                drawHistogram_vertical();
        }

        private void drawHistogram_horizontal()
        {

            g.FillRectangle(Brushes.Black, r.r);
            g.DrawRectangle(Pens.White, r.r);

            int maxvalue = protocolDistribution.Values.Max();

            int space_height = r.r.Bottom - r.r.Top - 20;
            int space_width = r.r.Right - r.r.Left - 20;

            int num_intervals = protocolDistribution.Keys.Count;
            int histrect_width = space_width / num_intervals;

            int start = r.r.X;

            foreach (KeyValuePair<String, int> k in protocolDistribution)
            {
                int rect_height = (int)(((double)k.Value / (double)maxvalue) * ((double)space_height));
                Rectangle hist_rect = new Rectangle(start, r.r.Bottom - rect_height, histrect_width, rect_height);

                g.FillRectangle(Brushes.Green, hist_rect);
                g.DrawRectangle(Pens.White, hist_rect);

                string text = k.Key;
                Rectangle stringPos = new Rectangle(start, r.r.Bottom + 20, histrect_width, histrect_width + 20);
                Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                Font goodFont = findFont(g, text, stringPos.Size, font1);

                g.DrawString(text, goodFont, Brushes.White, stringPos, stringFormat);

                start += histrect_width;
            }

            pictureBox1.Image = b;
        }

        private void drawHistogram_vertical()
        {

            g.FillRectangle(Brushes.Black, r2.r);
            g.DrawRectangle(Pens.White, r2.r);

            int maxvalue = protocolDistribution.Values.Max();

            int space_height = r2.r.Bottom - r2.r.Top - 20;
            int space_width = r2.r.Right - r2.r.Left - 20;

            int num_intervals = protocolDistribution.Keys.Count;
            int histrect_width = space_height / num_intervals;

            int start = r2.r.Y;

            foreach (KeyValuePair<String, int> k in protocolDistribution)
            {
                int rect_height = (int)(((double)k.Value / (double)maxvalue) * ((double)space_width));
                Rectangle hist_rect = new Rectangle(r2.r.Left, start, rect_height, histrect_width);

                g.FillRectangle(Brushes.Green, hist_rect);
                g.DrawRectangle(Pens.White, hist_rect);

                string text = k.Key;
                Rectangle stringPos = new Rectangle(r2.r.Left - (histrect_width * 7 + 10), start, histrect_width * 7, histrect_width);
                Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                Font goodFont = findFont(g, text, stringPos.Size, font1);

                g.DrawString(text, goodFont, Brushes.White, stringPos, stringFormat);

                start += histrect_width;
            }

            pictureBox1.Image = b;
        }

        private Font findFont(Graphics g, string myString, Size Room, Font PreferedFont)
        {
            SizeF RealSize = g.MeasureString(myString, PreferedFont);
            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;

            float ScaleRatio = (HeightScaleRatio < WidthScaleRatio) ? ScaleRatio = HeightScaleRatio : ScaleRatio = WidthScaleRatio;

            float ScaleFontSize = PreferedFont.Size * ScaleRatio;

            return new Font(PreferedFont.FontFamily, ScaleFontSize/3);
        }
    }
}