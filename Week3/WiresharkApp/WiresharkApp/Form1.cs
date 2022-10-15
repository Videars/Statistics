using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LINQtoCSV;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WiresharkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
        }

        private RichTextBox GetRichTextBox1()
        {
            return richTextBox1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        List<Packet> packets = new List<Packet>();

        int bc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            bc = 1;
            using (var reader = new StreamReader(@"C:\Users\Matt\source\repos\WiresharkApp\WiresharkApp\bin\Debug\wireshark.csv"))
            {
                var line = reader.ReadLine();
                var header = line.Split(',');
                foreach (var s in header)
                {
                    this.dataGridView1.Columns.Add(s.ToString(), s.ToString().Replace("\"", ""));
                }

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
                    dataGridView1.Rows.Add(values);
                    packet.Id = Convert.ToInt32(values[0].Replace("\"", ""));
                    packet.Time = Convert.ToDouble(values[1].Replace("\"", ""));
                    packet.Source = values[2];
                    packet.Destination = values[3];
                    packet.Protocol = values[4];
                    packet.Length = Convert.ToInt32(values[5].Replace("\"", ""));
                    packet.Info = values[6];

                    packets.Add(packet);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Rows.Add();
        }

        public class protocols
        {
            public string protocol { get; set; }
            public int count { get; set; }
        }

        List<protocols> frequency = new List<protocols>();
        int total = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (bc == 1)
            {
                this.button2.Enabled = false;
                this.richTextBox1.Clear();
                bool added = false;
                foreach (Packet p in packets)
                {
                    total++;
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
                        frequency.Add(new protocols() { protocol = p.Protocol, count = 1});
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
                this.richTextBox1.AppendText($"Total of {total} packets sniffed\n");
                foreach (protocols f in frequency)
                {
                    double perc;
                    perc = (f.count*100)/total;
                    this.richTextBox1.AppendText($"{f.protocol} -> freq: {f.count} -> {perc}% \n");
                }
            }
            else
                this.richTextBox1.AppendText("Error: Must parse the CSV first!\n");

        }
    }
}
