using Microsoft.Win32;
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
        public DateTime lastClicked = Properties.Settings.Default.lastClicked;
        public bool reminder = Properties.Settings.Default.reminder; 

        public DateTime today = DateTime.Today.AddDays(0);
        public Form1()
        {
            InitializeComponent();
            if (reminder == true) Reminder.Checked = true;

            var yesterday = today.AddDays(-1).DayOfYear;

            if (File.Exists(path) && lastClicked.DayOfYear > yesterday && lastClicked.Year == today.Year)
            {
                Send.Enabled = false;
                Text += " (come back tomorrow!)";
            }

            SetPath();
        }

        private void SetPath()
        {
            textBox1.Text = path;

            if (!File.Exists(path))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog
                {
                    Description = "Select a folder where your mood will be located"
                };

                //Setting and memorizing the path to properties

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
                    string month = today.ToString("MMMM")  + ",";
                    string year = today.ToString("yyyy") + ",";
                    string days = "";
                    
                    // (Month) 1 2 3 4 5
                    // Rate    4 4 5 5 3

                    for (int i = today.Day; i <= DateTime.DaysInMonth(today.Year, today.Month); i++)
                    {
                        days += i + ",";
                    }
                    days += Environment.NewLine + "Rate" + "," + rate + ",";

                    if (!File.Exists(path))
                    {
                        File.WriteAllText(path, year + Environment.NewLine + Environment.NewLine);
                        File.AppendAllText(path, month + days);

                        File.SetAttributes(path, FileAttributes.ReadOnly);
                    }
                    else
                    {
                        List<string> lines = File.ReadLines(path).ToList();

                        string[] dates = lines[lines.Count - 2].Split(',');

                        int lastMonth = DateTime.ParseExact(dates[0], "MMMM", CultureInfo.CurrentCulture).Month;

                        int daysSkipped = today.Day - lastClicked.Day;

                        //Month transition
                        if (lastMonth != today.Month || lastClicked.Year != today.Year)
                        {   
                            //Year transition
                            if (lastClicked.Year != today.Year)
                            {
                                File.AppendAllText(path, Environment.NewLine + Environment.NewLine + today.Year);
                            }
                            File.AppendAllText(path, Environment.NewLine + Environment.NewLine + month + days);
                        }
                        else
                        {
                            if (daysSkipped >= 2)
                            {
                                for (int i = 0; i <= (daysSkipped - 2); i++)
                                {
                                    File.AppendAllText(path, " " + ",");
                                }
                            }
                            File.AppendAllText(path, rate + ",");
                        }
                    }
                    
                    //Memorizing today's click
                    Properties.Settings.Default.lastClicked = today;
                    Properties.Settings.Default.Save();

                    Send.Enabled = false;
                    Text += " (come back tomorrow!)";

                    return;
                }
            }
        }
        private void Reminder_Click(object sender, EventArgs e)
        {
            SetStartup();
        }
        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (Reminder.Checked)
            {
                rk.SetValue(Name, Application.ExecutablePath);
                reminder = true;
                MessageBox.Show("Reminder | ON!", " Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                rk.DeleteValue(Name, false);
                reminder = false;
                MessageBox.Show("Reminder | OFF!", " Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Properties.Settings.Default.reminder = reminder;
            Properties.Settings.Default.Save();

            reminder = Properties.Settings.Default.reminder;
        }
    }
}