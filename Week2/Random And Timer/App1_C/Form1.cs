namespace App1_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        Double somma = 0;
        int ticks = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            double d = r.NextDouble();
            somma += d;
            ticks++;
            double mediaora = somma/(double)ticks;

            this.richTextBox1.AppendText(d.ToString() + "  |  " + mediaora.ToString() + '\n');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            button2.Click -= button2_Click;
            button2.Click += new EventHandler(button3_Click);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            button2.Click -= button3_Click;
            button2.Click += new EventHandler(button2_Click);
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
