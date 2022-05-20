using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Moodler
{
    public partial class Form1 : Form
    {
        public string path = Properties.Settings.Default.path;
        public DateTime lastClicked = Properties.Settings.Default.lastClicked;
        public static DateTime today = DateTime.Today.AddDays(365);
        public Form1()
        {
            InitializeComponent();
            SetPath();
            Validation();
        }
        private void Validation()
        {
            foreach (Task task in TaskService.Instance.RootFolder.Tasks) //Setting flag
            {
                if (task.Name == "Moodler")
                {
                    _hour.Visible = true;
                    _hour.Text = DateTime.ParseExact(task.NextRunTime.Hour.ToString(), "HH", CultureInfo.CurrentCulture).ToString("t");
                    return;
                }
            }
            var yesterday = today.AddDays(-1).DayOfYear;

            if (File.Exists(path) && lastClicked.DayOfYear > yesterday && lastClicked.Year == today.Year) //Disabling button
            {
                Send.Enabled = false;
                Text += " (come back tomorrow!)";
            }
        }
        private void SetPath()
        {
            if (!File.Exists(path))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog
                {
                    Description = "Select a folder where your mood will be located"
                };

                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default.path = fbd.SelectedPath + "\\Mood.csv";
                    Properties.Settings.Default.Save();

                    path = Properties.Settings.Default.path; //Memorizing the path
                }
                else Environment.Exit(1);
            }

            textBox1.Text = path;
        }
        private void Send_Click(object sender, EventArgs e)
        {
            List<RadioButton> radioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };

            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked == true)
                {
                    Record record = new Record(Convert.ToInt32(radioButton.Text), today.ToString("MMMM") + ",", today.ToString("yyyy") + ",");
                    
                    WriteRecord(record);
                    
                    //Memorizing today's click
                    Properties.Settings.Default.lastClicked = today;
                    Properties.Settings.Default.Save();

                    Send.Enabled = false;
                    Text += " (come back tomorrow!)";

                    return;
                }
            }
        }
        private void WriteRecord(Record record)
        {
            for (int i = today.Day; i <= DateTime.DaysInMonth(today.Year, today.Month); i++)
            {
                record.days += i + ",";
            }
            record.days += Environment.NewLine + "Rate" + "," + record.rate + ",";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, record.year + Environment.NewLine + Environment.NewLine);
                File.AppendAllText(path, record.month + record.days);
            }
            else
            {
                File.SetAttributes(path, FileAttributes.Normal);
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
                    File.AppendAllText(path, Environment.NewLine + Environment.NewLine + record.month + record.days);
                }
                else //Simple skipping
                {
                    if (daysSkipped >= 2)
                    {
                        for (int i = 0; i <= (daysSkipped - 2); i++)
                        {
                            File.AppendAllText(path, " " + ",");
                        }
                    }
                    File.AppendAllText(path, record.rate + ",");
                }
            }

            File.SetAttributes(path, FileAttributes.ReadOnly);
        }
        private void SetTask(string hour)
        {
            TaskService.Instance.Execute(Assembly.GetEntryAssembly().Location).Every(1).Days().Starting(hour).AsTask("Moodler");
            MessageBox.Show($"Reminder | ON! {hour} everyday", " Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _hour.Visible = true;
            _hour.Text = hour; 
        }
        private void DeleteTask()
        {
            foreach (Task task in TaskService.Instance.RootFolder.Tasks)
            {
                if (task.Name == "Moodler")
                {
                    TaskService.Instance.RootFolder.DeleteTask(task.Name);
                    MessageBox.Show("Reminder | OFF!", " Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _hour.Text = "";
                    _hour.Visible = false;

                    return;
                }
            }
        }
        private class Record
        {
            public Record(int rate, string month, string year)
            {
                this.rate = rate;
                this.month = month;
                this.year = year;
            }
            public int rate;
            public string month;
            public string year;
            public string days;
        }

        private void remSet_Click(object sender, EventArgs e)
        {
            if (AM.Checked == true || PM.Checked == true)
            {
                if (AM.Checked == true) SetTask(hourChoice.Value + ":00am");
                else if (PM.Checked == true) SetTask(hourChoice.Value + ":00pm");
            }
        }

        private void remDelete_Click(object sender, EventArgs e)
        {
            DeleteTask();
        }
    }
}