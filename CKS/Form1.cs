using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CKS
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);

        bool isFirst = true;

        int curTime = 0;
        int alarmTime = 1;
        bool alarmEnabled = false;

        KeyEventArgs ipt_data;
        KeyEventArgs popupKey;

        public MainForm()
        {
            InitializeComponent();

            this.Load += TrayIcon_Load;

            TrayIcon.Visible = false;
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void TrayIcon_Load(object sender, EventArgs e)
        {
            TrayIcon.ContextMenuStrip = contextTrayIcon;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
                StreamReader Monsr = new StreamReader("Monday.txt"), Tuessr = new StreamReader("Tuesday.txt"),
                Wednessr = new StreamReader("Wednesday.txt"), Thurssr = new StreamReader("Thursday.txt"),
                Frisr = new StreamReader("Friday.txt"), Satursr = new StreamReader("Saturday.txt"),
                Sunsr = new StreamReader("Sunday.txt");

                MondayTask.Items.Clear(); TuesdayTask.Items.Clear(); WednesdayTask.Items.Clear();
                ThursdayTask.Items.Clear(); FridayTask.Items.Clear(); SaturdayTask.Items.Clear();
                SundayTask.Items.Clear();

                string line;
                while ((line = Monsr.ReadLine()) != null)
                    MondayTask.Items.Add(line);
                while ((line = Tuessr.ReadLine()) != null)
                    TuesdayTask.Items.Add(line);
                while ((line = Wednessr.ReadLine()) != null)
                    WednesdayTask.Items.Add(line);
                while ((line = Thurssr.ReadLine()) != null)
                    ThursdayTask.Items.Add(line);
                while ((line = Frisr.ReadLine()) != null)
                    FridayTask.Items.Add(line);
                while ((line = Satursr.ReadLine()) != null)
                    SaturdayTask.Items.Add(line);
                while ((line = Sunsr.ReadLine()) != null)
                    SundayTask.Items.Add(line);

                Monsr.Close(); Tuessr.Close(); Wednessr.Close(); Thurssr.Close(); Frisr.Close(); Satursr.Close();
                Sunsr.Close();

                if (!File.Exists("Mondayi.txt"))
                    goto NOFILE;

                DateTime CurT = System.DateTime.Today;

                if (CurT.DayOfWeek == DayOfWeek.Monday)
                {
                    this.TodayTask.Items.Clear();
                    this.TodayTapTask.Items.Clear();

                    this.TodayTask.Items.AddRange(this.MondayTask.Items);
                    this.TodayTapTask.Items.AddRange(this.MondayTask.Items);
                }
                else if (CurT.DayOfWeek == DayOfWeek.Tuesday)
                {
                    this.TodayTask.Items.Clear();
                    this.TodayTapTask.Items.Clear();

                    this.TodayTask.Items.AddRange(this.TuesdayTask.Items);
                    this.TodayTapTask.Items.AddRange(this.TuesdayTask.Items);
                }
                else if (CurT.DayOfWeek == DayOfWeek.Wednesday)
                {
                    this.TodayTask.Items.Clear();
                    this.TodayTapTask.Items.Clear();

                    this.TodayTask.Items.AddRange(this.WednesdayTask.Items);
                    this.TodayTapTask.Items.AddRange(this.WednesdayTask.Items);
                }
                else if (CurT.DayOfWeek == DayOfWeek.Thursday)
                {
                    this.TodayTask.Items.Clear();
                    this.TodayTapTask.Items.Clear();

                    this.TodayTask.Items.AddRange(this.ThursdayTask.Items);
                    this.TodayTapTask.Items.AddRange(this.ThursdayTask.Items);
                }
                else if (CurT.DayOfWeek == DayOfWeek.Friday)
                {
                    this.TodayTask.Items.Clear();
                    this.TodayTapTask.Items.Clear();

                    this.TodayTask.Items.AddRange(this.FridayTask.Items);
                    this.TodayTapTask.Items.AddRange(this.FridayTask.Items);
                }
                else if (CurT.DayOfWeek == DayOfWeek.Saturday)
                {
                    this.TodayTask.Items.Clear();
                    this.TodayTapTask.Items.Clear();

                    this.TodayTask.Items.AddRange(this.SaturdayTask.Items);
                    this.TodayTapTask.Items.AddRange(this.SaturdayTask.Items);
                }
                else if (CurT.DayOfWeek == DayOfWeek.Sunday)
                {
                    this.TodayTask.Items.Clear();
                    this.TodayTapTask.Items.Clear();

                    this.TodayTask.Items.AddRange(this.SundayTask.Items);
                    this.TodayTapTask.Items.AddRange(this.SundayTask.Items);
                }

                if (CurT.DayOfWeek == DayOfWeek.Monday)
                {
                    StreamReader Monsri = new StreamReader("Mondayi.txt");

                    int index = 0;

                    while ((line = Monsri.ReadLine()) != null)
                    {
                        TodayTapTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TodayTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        MondayTask.SetItemChecked(index++, line[0] == '1' ? true : false);
                    }
                    Monsri.Close();
                }
                else if (CurT.DayOfWeek == DayOfWeek.Tuesday)
                {
                    StreamReader Tuessri = new StreamReader("Tuesdayi.txt");

                    int index = 0;

                    while ((line = Tuessri.ReadLine()) != null)
                    {
                        TodayTapTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TodayTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TuesdayTask.SetItemChecked(index++, line[0] == '1' ? true : false);
                    }
                    Tuessri.Close();
                }
                else if (CurT.DayOfWeek == DayOfWeek.Wednesday)
                {
                    StreamReader Wednessri = new StreamReader("Wednesdayi.txt");

                    int index = 0;

                    while ((line = Wednessri.ReadLine()) != null)
                    {
                        TodayTapTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TodayTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        WednesdayTask.SetItemChecked(index++, line[0] == '1' ? true : false);
                    }
                    Wednessri.Close();
                }
                else if (CurT.DayOfWeek == DayOfWeek.Thursday)
                {
                    StreamReader Thurssri = new StreamReader("Thursdayi.txt");

                    int index = 0;

                    while ((line = Thurssri.ReadLine()) != null)
                    {
                        TodayTapTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TodayTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        ThursdayTask.SetItemChecked(index++, line[0] == '1' ? true : false);
                    }
                    Thurssri.Close();
                }
                else if (CurT.DayOfWeek == DayOfWeek.Friday)
                {
                    StreamReader Frisri = new StreamReader("Fridayi.txt");

                    int index = 0;

                    while ((line = Frisri.ReadLine()) != null)
                    {
                        TodayTapTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TodayTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        FridayTask.SetItemChecked(index++, line[0] == '1' ? true : false);
                    }
                    Frisri.Close();
                }
                else if (CurT.DayOfWeek == DayOfWeek.Saturday)
                {
                    StreamReader Satursri = new StreamReader("Saturdayi.txt");

                    int index = 0;

                    while ((line = Satursri.ReadLine()) != null)
                    {
                        TodayTapTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TodayTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        SaturdayTask.SetItemChecked(index++, line[0] == '1' ? true : false);
                    }
                    Satursri.Close();
                }
                else if (CurT.DayOfWeek == DayOfWeek.Sunday)
                {
                    StreamReader Sunsri = new StreamReader("Sundayi.txt");

                    int index = 0;

                    while ((line = Sunsri.ReadLine()) != null)
                    {
                        TodayTapTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        TodayTask.SetItemChecked(index, line[0] == '1' ? true : false);
                        SundayTask.SetItemChecked(index++, line[0] == '1' ? true : false);
                    }
                    Sunsri.Close();
                }
                goto YESFILE;
            }

        NOFILE:
            DateTime Curtime = System.DateTime.Today;

            if(Curtime.DayOfWeek == DayOfWeek.Monday)
            {
                this.TodayTask.Items.Clear();
                this.TodayTapTask.Items.Clear();

                this.TodayTask.Items.AddRange(this.MondayTask.Items);
                this.TodayTapTask.Items.AddRange(this.MondayTask.Items);
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Tuesday)
            {
                this.TodayTask.Items.Clear();
                this.TodayTapTask.Items.Clear();

                this.TodayTask.Items.AddRange(this.TuesdayTask.Items);
                this.TodayTapTask.Items.AddRange(this.TuesdayTask.Items);
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Wednesday)
            {
                this.TodayTask.Items.Clear();
                this.TodayTapTask.Items.Clear();

                this.TodayTask.Items.AddRange(this.WednesdayTask.Items);
                this.TodayTapTask.Items.AddRange(this.WednesdayTask.Items);
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Thursday)
            {
                this.TodayTask.Items.Clear();
                this.TodayTapTask.Items.Clear();

                this.TodayTask.Items.AddRange(this.ThursdayTask.Items);
                this.TodayTapTask.Items.AddRange(this.ThursdayTask.Items);
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Friday)
            {
                this.TodayTask.Items.Clear();
                this.TodayTapTask.Items.Clear();

                this.TodayTask.Items.AddRange(this.FridayTask.Items);
                this.TodayTapTask.Items.AddRange(this.FridayTask.Items);
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Saturday)
            {
                this.TodayTask.Items.Clear();
                this.TodayTapTask.Items.Clear();

                this.TodayTask.Items.AddRange(this.SaturdayTask.Items);
                this.TodayTapTask.Items.AddRange(this.SaturdayTask.Items);
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Sunday)
            {
                this.TodayTask.Items.Clear();
                this.TodayTapTask.Items.Clear();

                this.TodayTask.Items.AddRange(this.SundayTask.Items);
                this.TodayTapTask.Items.AddRange(this.SundayTask.Items);
            }

         YESFILE:
            StreamWriter Monsw = File.CreateText("Monday.txt"), Tuessw = File.CreateText("Tuesday.txt"),
                Wednessw = File.CreateText("Wednesday.txt"), Thurssw = File.CreateText("Thursday.txt"),
                Frisw = File.CreateText("Friday.txt"), Satursw = File.CreateText("Saturday.txt"),
                Sunsw = File.CreateText("Sunday.txt");
            int MonCount = MondayTask.Items.Count, TuesCount = TuesdayTask.Items.Count,
                    WednesCount = WednesdayTask.Items.Count, ThursCount = ThursdayTask.Items.Count,
                    FriCount = FridayTask.Items.Count, SaturCount = SaturdayTask.Items.Count,
                    SunCount = SundayTask.Items.Count;

            int i;
            for (i = 0; i < MonCount; i++)
                Monsw.WriteLine(MondayTask.Items[i]);
            for (i = 0; i < TuesCount; i++)
                Tuessw.WriteLine(TuesdayTask.Items[i]);
            for (i = 0; i < WednesCount; i++)
                Wednessw.WriteLine(WednesdayTask.Items[i]);
            for (i = 0; i < ThursCount; i++)
                Thurssw.WriteLine(ThursdayTask.Items[i]);
            for (i = 0; i < FriCount; i++)
                Frisw.WriteLine(FridayTask.Items[i]);
            for (i = 0; i < SaturCount; i++)
                Satursw.WriteLine(SaturdayTask.Items[i]);
            for (i = 0; i < SunCount; i++)
                Sunsw.WriteLine(SundayTask.Items[i]);

            Monsw.Close(); Tuessw.Close(); Wednessw.Close(); Thurssw.Close(); Frisw.Close(); Satursw.Close();
            Sunsw.Close();
        }

        private void TodayTapTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime Curtime = System.DateTime.Today;

            if (Curtime.DayOfWeek == DayOfWeek.Monday)
            {
                for (int index = 0; index < this.TodayTapTask.Items.Count; index++)
                {
                    this.MondayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                    this.TodayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                }
                this.MondayTask.Update();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Tuesday)
            {
                for (int index = 0; index < this.TodayTapTask.Items.Count; index++)
                {
                    this.TuesdayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                    this.TodayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                }
                this.TuesdayTask.Update();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Wednesday)
            {
                for (int index = 0; index < this.TodayTask.Items.Count; index++)
                {
                    this.WednesdayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                    this.TodayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                }
                this.WednesdayTask.Update();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Thursday)
            {
                for (int index = 0; index < this.TodayTask.Items.Count; index++)
                {
                    this.ThursdayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                    this.TodayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                }
                this.ThursdayTask.Update();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Friday)
            {
                for (int index = 0; index < this.TodayTask.Items.Count; index++)
                {
                    this.FridayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                    this.TodayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                }
                this.FridayTask.Update();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Saturday)
            {
                for (int index = 0; index < this.TodayTask.Items.Count; index++)
                {
                    this.SaturdayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                    this.TodayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                }
                this.SaturdayTask.Update();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Sunday)
            {
                for (int index = 0; index < this.TodayTask.Items.Count; index++)
                {
                    this.SundayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                    this.TodayTask.SetItemChecked(index, this.TodayTapTask.GetItemChecked(index));
                }
                this.SundayTask.Update();
            }

            StreamWriter Monswi = File.CreateText("Mondayi.txt"), Tuesswi = File.CreateText("Tuesdayi.txt"),
                Wednesswi = File.CreateText("Wednesdayi.txt"), Thursswi = File.CreateText("Thursdayi.txt"),
                Friswi = File.CreateText("Fridayi.txt"), Saturswi = File.CreateText("Saturdayi.txt"),
                Sunswi = File.CreateText("Sundayi.txt");
            int MonCount = MondayTask.Items.Count, TuesCount = TuesdayTask.Items.Count,
                    WednesCount = WednesdayTask.Items.Count, ThursCount = ThursdayTask.Items.Count,
                    FriCount = FridayTask.Items.Count, SaturCount = SaturdayTask.Items.Count,
                    SunCount = SundayTask.Items.Count;

            int i;
            for (i = 0; i < MonCount; i++)
                Monswi.WriteLine(MondayTask.GetItemChecked(i)==true? 1 : 0);
            for (i = 0; i < TuesCount; i++)
                Tuesswi.WriteLine(TuesdayTask.GetItemChecked(i) == true ? 1 : 0);
            for (i = 0; i < WednesCount; i++)
                Wednesswi.WriteLine(WednesdayTask.GetItemChecked(i) == true ? 1 : 0);
            for (i = 0; i < ThursCount; i++)
                Thursswi.WriteLine(ThursdayTask.GetItemChecked(i) == true ? 1 : 0);
            for (i = 0; i < FriCount; i++)
                Friswi.WriteLine(FridayTask.GetItemChecked(i) == true ? 1 : 0);
            for (i = 0; i < SaturCount; i++)
                Saturswi.WriteLine(SaturdayTask.GetItemChecked(i) == true ? 1 : 0);
            for (i = 0; i < SunCount; i++)
                Sunswi.WriteLine(SundayTask.GetItemChecked(i) == true ? 1 : 0);

            Monswi.Close(); Tuesswi.Close(); Wednesswi.Close(); Thursswi.Close(); Friswi.Close(); Saturswi.Close();
            Sunswi.Close();
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            MondayTask.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "월":
                    MondayTask.Items.Add(textBox2.Text);
                    break;
                case "화":
                    TuesdayTask.Items.Add(textBox2.Text);
                    break;
                case "수":
                    WednesdayTask.Items.Add(textBox2.Text);
                    break;
                case "목":
                    ThursdayTask.Items.Add(textBox2.Text);
                    break;
                case "금":
                    FridayTask.Items.Add(textBox2.Text);
                    break;
                case "토":
                    SaturdayTask.Items.Add(textBox2.Text);
                    break;
                case "일":
                    SundayTask.Items.Add(textBox2.Text);
                    break;
                default:
                    break;
            }
            textBox2.Clear();
            MainForm_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "월":
                    MondayTask.Items.Remove(textBox3.Text);
                    break;
                case "화":
                    TuesdayTask.Items.Remove(textBox3.Text);
                    break;
                case "수":
                    WednesdayTask.Items.Remove(textBox3.Text);
                    break;
                case "목":
                    ThursdayTask.Items.Remove(textBox3.Text);
                    break;
                case "금":
                    FridayTask.Items.Remove(textBox3.Text);
                    break;
                case "토":
                    SaturdayTask.Items.Remove(textBox3.Text);
                    break;
                case "일":
                    SundayTask.Items.Remove(textBox3.Text);
                    break;
                default:
                    break;
            }
            textBox3.Clear();
            MainForm_Load(sender, e);
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TrayIcon.Visible = false;
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrayIcon.Visible = false;
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                TrayIcon.Visible = true;
                this.ShowInTaskbar = true;
                this.Hide();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            curTime++;
            if (alarmEnabled && curTime % alarmTime == 0)
            {
                SystemSounds.Beep.Play();
                Form2 form2 = new Form2();
                form2.Visible = true;
                form2.WindowState = FormWindowState.Normal;
                form2.Show();
                form2.TopMost = true;
                form2.TopMost = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Timer.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "30분")
                alarmTime = 1800;
            else if (comboBox1.Text == "1시간")
                alarmTime = 3600;
            else if (comboBox1.Text == "2시간")
                alarmTime = 7200;
            else
                return;
            curTime = 0;
            alarmEnabled = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = e.KeyCode.ToString();
            ipt_data = e;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = e.KeyCode.ToString();
            ipt_data = e;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = ipt_data.KeyCode.ToString();
            textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = ipt_data.KeyCode.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            popupKey = ipt_data;
            RegisterHotKey((int)this.Handle, 0, 0x0, (int)popupKey.KeyCode);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey((int)this.Handle, 0);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == (int)0x312)
            {
                if (m.WParam == (IntPtr)0x0)
                {
                    Form2 form2 = new Form2();
                    form2.Visible = true;
                    form2.WindowState = FormWindowState.Normal;
                    form2.Show();
                    form2.TopMost = true;
                    form2.TopMost = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MondayTask.Items.Clear(); TuesdayTask.Items.Clear(); WednesdayTask.Items.Clear();
            ThursdayTask.Items.Clear(); FridayTask.Items.Clear(); SaturdayTask.Items.Clear();
            SundayTask.Items.Clear();
            StreamWriter Monsw = File.CreateText("Monday.txt"), Tuessw = File.CreateText("Tuesday.txt"),
                Wednessw = File.CreateText("Wednesday.txt"), Thurssw = File.CreateText("Thursday.txt"),
                Frisw = File.CreateText("Friday.txt"), Satursw = File.CreateText("Saturday.txt"),
                Sunsw = File.CreateText("Sunday.txt");
            Monsw.Close(); Tuessw.Close(); Wednessw.Close(); Thurssw.Close(); Frisw.Close(); Satursw.Close();
            Sunsw.Close();
            this.TodayTask.Items.Clear();
            this.TodayTapTask.Items.Clear();
        }
    }
}
