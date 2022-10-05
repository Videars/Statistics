namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            StartButton.Visible = false;
            this.timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            textBox1.Visible = true;
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                await Task.Delay(1000);
                progressBar1.Visible = false;
                textBox1.Visible = false;
                pictureBox1.Visible = true;
                this.timer1.Stop();
            }
        }
    }
}