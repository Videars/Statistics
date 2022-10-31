using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MoveAndZoomRect
{
    public partial class Form1 : Form
    {
        Bitmap b;
        Graphics g;
        EditableRectangle r;

        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);

            r = new EditableRectangle(pictureBox1.Width/2, pictureBox1.Height/2 - 100, 150, 200, pictureBox1, this);
            g.DrawRectangle(Pens.Lime, r.r);

            pictureBox1.Image = b;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            g.DrawRectangle(Pens.Lime, r.r);

            pictureBox1.Image = b;
        }
    }
}
