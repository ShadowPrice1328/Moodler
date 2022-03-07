using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Moodler
{
    public partial class Form1 : Form
    {
        public string path = Properties.Settings.Default.path;
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

                File.Create(path);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            List<RadioButton> radioButtons = new List<RadioButton>();
            radioButtons.AddRange(new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 });

            foreach(RadioButton radioButton in radioButtons)
            {
                if(radioButton.Checked == true)
                {
                    int mood = Convert.ToInt32(radioButton.Text);

                    //MessageBox.Show(mood.ToString());
                }
            }
        }
    }
}
