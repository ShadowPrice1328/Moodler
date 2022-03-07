using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
