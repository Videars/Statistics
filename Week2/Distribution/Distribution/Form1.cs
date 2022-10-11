using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csv_parser;
using LINQtoCSV;

namespace Distribution
{
    public partial class Form1 : Form
    {
        int[] gender = new int[2];
        int[] height = new int[10];
        int[] weight = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private RichTextBox GetRichTextBox1()
        {
            return richTextBox1;
        }

        private static void ReadCsvFile(RichTextBox richTextBox1)
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };

            var csvContex = new CsvContext();
            var students = csvContex.Read<Student>("StudentsDataset.csv", csvFileDescription);
            var vc = new Form1();
            

            foreach (var student in students)
            {
                //richTextBox1.AppendText($"{student.Gender} | {student.Weight} | {student.Height} \n");
                
                //Gender
                if (student.Gender == "Male")
                    vc.gender[0]++;
                else
                    vc.gender[1]++;

                //Height
                for (int i = 1; i < vc.height.Length; i++)
                {
                    if (Int16.Parse(student.Height) >= 150 + (5 * (i-1)) && Int16.Parse(student.Height) < 150 + (5 * (i)))
                        vc.height[i]++;
                }


                //Weight
                for (int i = 1; i < vc.weight.Length; i++)
                {
                    if (Int16.Parse(student.Weight) >= 50 + (5 * (i - 1)) && Int16.Parse(student.Weight) < 50 + (5 * (i)))
                        vc.weight[i]++;
                }


            }

            richTextBox1.AppendText("GENDERS\n"+"Males:" + vc.gender[0].ToString() + "\nFemales:" + vc.gender[1].ToString() +"\n\n");
            
            richTextBox1.AppendText("HEIGHTS\n");
            for (int i = 1; i < vc.height.Length;  i++)
            {
                string left = (150 + (5 * (i - 1))).ToString();
                string right = (150 + (5 * (i))).ToString();
                richTextBox1.AppendText('<' + left + '-' + right + '>' + " | " + vc.height[i].ToString() + "\n");
            }

            richTextBox1.AppendText("\n\nWEIGHTS\n");
            for (int i = 1; i < vc.weight.Length; i++)
            {
                string left = (50 + (5 * (i - 1))).ToString();
                string right = (50 + (5 * (i))).ToString();
                richTextBox1.AppendText('<' + left + '-' + right + '>' + " | " + vc.weight[i].ToString() + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadCsvFile(GetRichTextBox1());
        }
    }
}
