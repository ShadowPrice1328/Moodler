using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moodler
{
    public partial class Form1 : Form
    {
        public string path = Properties.Settings.Default.path;
        public DateTime lastClicked = Properties.Settings.Default.lastClicked;
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(path) && lastClicked >= DateTime.Now.AddHours(-24))
            {
                Send.Enabled = false;
                Text += " (come back tomorrow!)";
            }

            FileCreate();
        }

        private void FileCreate()
        {
            textBox1.Text = path;

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
                    int rate = Convert.ToInt32(radioButton.Text);
                    string RawLine = DateTime.Now.ToString("MMMM")  + ",";

                    for (int i = DateTime.Now.Day; i < DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month); i++)
                    {
                        RawLine += i + ",";
                    }
                    RawLine += Environment.NewLine + "Rate" + "," + rate + ",";

                    if (!File.Exists(path)) File.WriteAllText(path, RawLine);
                    else
                    {
                        File.AppendAllText(path, rate + ",");                    
                    }

                    //List<string> lines = File.ReadLines(path).ToList();

                    Properties.Settings.Default.lastClicked = DateTime.Now;
                    Properties.Settings.Default.Save();

                    Send.Enabled = false;
                    Text += " (come back tomorrow!)";
                }
            }
        }
    }
}