using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moodler
{
    public partial class Form1 : Form
    {
        public string path = Properties.Settings.Default.path;
        public string ExDate = Properties.Settings.Default.ExDate;
        public Form1()
        {
            FileCreate();
            InitializeComponent();

            textBox1.Text = path;
        }

        private void FileCreate()
        {
            if (!File.Exists(path))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog
                {
                    Description = "Select a folder where your mood will be located"
                };

                //Setting and memorizing the path

                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default.path = fbd.SelectedPath + "\\Mood.csv";
                    Properties.Settings.Default.Save();

                    path = Properties.Settings.Default.path;
                }
                else Environment.Exit(1);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            List<RadioButton> radioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };

            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked == true)
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    int rate = Convert.ToInt32(radioButton.Text);

                    string head = "Date" + "," + "Rate";
                    string RawLine = date + "," + rate + Environment.NewLine;

                    if (File.Exists(path))
                    {
                        List<string> lines = File.ReadLines(path).ToList();

                        //DELETE.FUCKING.DUPLICATES!!!

                        if (lines[lines.Count - 1].Contains(date))
                        {
                            lines.RemoveAt(lines.Count - 1);
                            lines.Add(RawLine);
                        }
                        else
                        {
                            lines.Add(RawLine);
                        }
                        File.WriteAllText(path, String.Join(Environment.NewLine, lines));
                    }
                    if (!File.Exists(path))
                    {
                        File.WriteAllText(path, head + Environment.NewLine + RawLine);
                    }
                }
            }
        }
    }
}
