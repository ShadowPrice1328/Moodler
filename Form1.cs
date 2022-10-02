using System.Globalization;
using Microsoft.Win32.TaskScheduler;
using Newtonsoft.Json;

namespace Moodler
{
    public partial class Form1 : Form
    {
        public string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Moodler";

        public static DateTime today = DateTime.Today;
        public Form1()
        {
            InitializeComponent();
            SetPath();
            Validation();
        }
        private Properties ReadJson()
        {
            if(File.Exists(dataPath + "/props.json") && File.ReadAllText(dataPath + "/props.json") != "")
            {
                return JsonConvert.DeserializeObject<Properties>(File.ReadAllText(dataPath + "/props.json"));
            }
            else
            {
                return new Properties();
            }
        }
        private void SaveJson(Properties props)
        {
            if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);
            File.WriteAllText(dataPath + "/props.json", JsonConvert.SerializeObject(props));
        }
        private void Validation()
        {
            Properties props = ReadJson();

            //Setting flag
            foreach (Microsoft.Win32.TaskScheduler.Task task in TaskService.Instance.RootFolder.Tasks)
            {
                if (task.Name == "Moodler")
                {
                    if (!File.Exists(props.path))
                    {
                        DeleteTask(true);
                        return;
                    }
                    _hour.Visible = true;
                    _hour.Text = DateTime.ParseExact(task.NextRunTime.Hour.ToString(), "HH", CultureInfo.CurrentCulture).ToString("t");
                    break;
                }
            }
            var yesterday = today.AddDays(-1).DayOfYear;

            if (File.Exists(props.path) && props.lastClicked.DayOfYear > yesterday && props.lastClicked.Year == today.Year) //Disabling button
            {
                Send.Enabled = false;
                Text += " (come back tomorrow!)";
            }
        }
        private void SetPath()
        {
            Properties props = ReadJson();
            if (!File.Exists(props.path))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog
                {
                    UseDescriptionForTitle = true,
                    Description = "Select a folder where your mood will be located"
                };

                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    props.path = fbd.SelectedPath + "\\Mood.csv";
                    SaveJson(props);
                }
                else Environment.Exit(1);
            }

            textBox1.Text = props.path;
        }
        private void Send_Click(object sender, EventArgs e)
        {
            Properties props = ReadJson();
            List<RadioButton> radioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };

            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked == true)
                {
                    Record record = new Record(Convert.ToInt32(radioButton.Text), today.ToString("MMMM") + ",", today.ToString("yyyy") + ",");
                    
                    WriteRecord(record);

                    props.lastClicked = DateTime.Now;

                    SaveJson(props);

                    Send.Enabled = false;
                    Text += " (come back tomorrow!)";

                    return;
                }
            }
        }
        private void WriteRecord(Record record)
        {
            Properties props = ReadJson();
            for (int i = today.Day; i <= DateTime.DaysInMonth(today.Year, today.Month); i++)
            {
                record.days += i + ",";
            }
            record.days += Environment.NewLine + "Rate" + "," + record.rate + ",";

            if (!File.Exists(props.path))
            {
                File.WriteAllText(props.path, record.year + Environment.NewLine + Environment.NewLine);
                File.AppendAllText(props.path, record.month + record.days);
                File.SetAttributes(props.path, FileAttributes.ReadOnly);
            }
            else
            {
                File.SetAttributes(props.path, FileAttributes.Normal);

                List<string> lines = File.ReadLines(props.path).ToList();

                string[] dates = lines[lines.Count - 2].Split(',');

                int lastMonth = DateTime.ParseExact(dates[0], "MMMM", CultureInfo.CurrentCulture).Month;
                int daysSkipped = today.Day - props.lastClicked.Day;

                //Month transition
                if (lastMonth != today.Month || props.lastClicked.Year != today.Year)
                {
                    //Year transition
                    if (props.lastClicked.Year != today.Year)
                    {
                        File.AppendAllText(props.path, Environment.NewLine + Environment.NewLine + today.Year);
                    }
                    File.AppendAllText(props.path, Environment.NewLine + Environment.NewLine + record.month + record.days);
                }
                else //Simple skipping
                {
                    if (daysSkipped >= 2)
                    {
                        for (int i = 0; i <= (daysSkipped - 2); i++)
                        {
                            File.AppendAllText(props.path, " " + ",");
                        }
                    }
                    File.AppendAllText(props.path, record.rate + ",");
                }

                File.SetAttributes(props.path, FileAttributes.ReadOnly);
            }
        }
        private void SetTask(string hour)
        {
            TaskService.Instance.Execute(Application.ExecutablePath).Every(1).Days().Starting(hour).AsTask("Moodler");
            MessageBox.Show($"Reminder | ON! {hour} everyday", " Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _hour.Visible = true;
            _hour.Text = hour; 
        }
        protected void DeleteTask(bool silent = false)
        {
            foreach (Microsoft.Win32.TaskScheduler.Task task in TaskService.Instance.RootFolder.Tasks)
            {
                if (task.Name == "Moodler")
                {
                    TaskService.Instance.RootFolder.DeleteTask(task.Name);
                    if (silent == false) MessageBox.Show("Reminder | OFF!", " Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            public string days = "";
        }
        public struct Properties
        {
            public string path;
            public DateTime lastClicked;

            public Properties()
            {
                this.path = "";
                this.lastClicked = new DateTime();
            }
            public Properties(string path, DateTime lastClicked)
            {
                this.path = path;
                this.lastClicked = lastClicked;
            }
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