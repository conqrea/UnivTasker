using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CKS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime Curtime = System.DateTime.Today;

            if (Curtime.DayOfWeek == DayOfWeek.Monday)
            {
                StreamReader DaySr = new StreamReader("Monday.txt");
                StreamReader DaySri = new StreamReader("Mondayi.txt");

                string line;
                while ((line = DaySr.ReadLine()) != null)
                    if(DaySri.ReadLine()[0]=='0')
                        TodayTask.Items.Add(line);

                DaySr.Close();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Tuesday)
            {
                StreamReader DaySr = new StreamReader("Tuesday.txt");
                StreamReader DaySri = new StreamReader("Tuesdayi.txt");

                string line;
                while ((line = DaySr.ReadLine()) != null)
                    if (DaySri.ReadLine()[0] == '0')
                        TodayTask.Items.Add(line);

                DaySr.Close();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Wednesday)
            {
                StreamReader DaySr = new StreamReader("Wednesday.txt");
                StreamReader DaySri = new StreamReader("Wednesdayi.txt");

                string line;
                while ((line = DaySr.ReadLine()) != null)
                    if (DaySri.ReadLine()[0] == '0')
                        TodayTask.Items.Add(line);

                DaySr.Close();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Thursday)
            {
                StreamReader DaySr = new StreamReader("Thursday.txt");
                StreamReader DaySri = new StreamReader("Thursdayi.txt");

                string line;
                while ((line = DaySr.ReadLine()) != null)
                    if (DaySri.ReadLine()[0] == '0')
                        TodayTask.Items.Add(line);

                DaySr.Close();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Friday)
            {
                StreamReader DaySr = new StreamReader("Friday.txt");
                StreamReader DaySri = new StreamReader("Fridayi.txt");

                string line;
                while ((line = DaySr.ReadLine()) != null)
                    if (DaySri.ReadLine()[0] == '0')
                        TodayTask.Items.Add(line);

                DaySr.Close();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Saturday)
            {
                StreamReader DaySr = new StreamReader("Saturday.txt");
                StreamReader DaySri = new StreamReader("Saturdayi.txt");

                string line;
                while ((line = DaySr.ReadLine()) != null)
                    if (DaySri.ReadLine()[0] == '0')
                        TodayTask.Items.Add(line);

                DaySr.Close();
            }
            else if (Curtime.DayOfWeek == DayOfWeek.Sunday)
            {
                StreamReader DaySr = new StreamReader("Sunday.txt");
                StreamReader DaySri = new StreamReader("Sundayi.txt");

                string line;
                while ((line = DaySr.ReadLine()) != null)
                    if (DaySri.ReadLine()[0] == '0')
                        TodayTask.Items.Add(line);

                DaySr.Close();
            }
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            if(!checkBox1.Checked)
                this.Close();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar1.Value/100;
        }
    }
}
