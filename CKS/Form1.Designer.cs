
namespace CKS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DateTimePicker TodayView;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TaskTap = new System.Windows.Forms.TabControl();
            this.MainTap = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SundayTask = new System.Windows.Forms.CheckedListBox();
            this.SaturdayTask = new System.Windows.Forms.CheckedListBox();
            this.FridayTask = new System.Windows.Forms.CheckedListBox();
            this.ThursdayTask = new System.Windows.Forms.CheckedListBox();
            this.WednesdayTask = new System.Windows.Forms.CheckedListBox();
            this.TuesdayTask = new System.Windows.Forms.CheckedListBox();
            this.MondayTask = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TodayTask = new System.Windows.Forms.CheckedListBox();
            this.TodayTap = new System.Windows.Forms.TabPage();
            this.TodayTapGroup = new System.Windows.Forms.GroupBox();
            this.TodayTapTask = new System.Windows.Forms.CheckedListBox();
            this.ModfTap = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.contextTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            TodayView = new System.Windows.Forms.DateTimePicker();
            this.TaskTap.SuspendLayout();
            this.MainTap.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TodayTap.SuspendLayout();
            this.TodayTapGroup.SuspendLayout();
            this.ModfTap.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // TodayView
            // 
            TodayView.Checked = false;
            TodayView.Enabled = false;
            TodayView.Location = new System.Drawing.Point(645, 402);
            TodayView.Name = "TodayView";
            TodayView.Size = new System.Drawing.Size(161, 23);
            TodayView.TabIndex = 1;
            // 
            // TaskTap
            // 
            this.TaskTap.Controls.Add(this.MainTap);
            this.TaskTap.Controls.Add(this.TodayTap);
            this.TaskTap.Controls.Add(this.ModfTap);
            this.TaskTap.Location = new System.Drawing.Point(0, -1);
            this.TaskTap.Name = "TaskTap";
            this.TaskTap.SelectedIndex = 0;
            this.TaskTap.Size = new System.Drawing.Size(820, 458);
            this.TaskTap.TabIndex = 0;
            // 
            // MainTap
            // 
            this.MainTap.Controls.Add(this.button5);
            this.MainTap.Controls.Add(this.groupBox4);
            this.MainTap.Controls.Add(this.groupBox3);
            this.MainTap.Controls.Add(TodayView);
            this.MainTap.Controls.Add(this.groupBox2);
            this.MainTap.Controls.Add(this.groupBox1);
            this.MainTap.Location = new System.Drawing.Point(4, 24);
            this.MainTap.Name = "MainTap";
            this.MainTap.Padding = new System.Windows.Forms.Padding(3);
            this.MainTap.Size = new System.Drawing.Size(812, 430);
            this.MainTap.TabIndex = 0;
            this.MainTap.Text = "주요 일정";
            this.MainTap.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(718, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "일정\r\n초기화";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(186, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 226);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "일정 확인";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(124, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "일정 확인용 키";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 226);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "알림 설정";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 75);
            this.label15.TabIndex = 6;
            this.label15.Text = "저장을 누른 시점부터\r\n\r\n알람의 주기가 지날\r\n\r\n때마다 알람이 울립니다.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "알림 ON/OFF";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "알림 주기";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30분",
            "1시간",
            "2시간"});
            this.comboBox1.Location = new System.Drawing.Point(71, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SundayTask);
            this.groupBox2.Controls.Add(this.SaturdayTask);
            this.groupBox2.Controls.Add(this.FridayTask);
            this.groupBox2.Controls.Add(this.ThursdayTask);
            this.groupBox2.Controls.Add(this.WednesdayTask);
            this.groupBox2.Controls.Add(this.TuesdayTask);
            this.groupBox2.Controls.Add(this.MondayTask);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(186, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이번 주의 일정";
            // 
            // SundayTask
            // 
            this.SundayTask.Enabled = false;
            this.SundayTask.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SundayTask.FormattingEnabled = true;
            this.SundayTask.Location = new System.Drawing.Point(513, 37);
            this.SundayTask.Name = "SundayTask";
            this.SundayTask.Size = new System.Drawing.Size(80, 144);
            this.SundayTask.TabIndex = 1;
            // 
            // SaturdayTask
            // 
            this.SaturdayTask.Enabled = false;
            this.SaturdayTask.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaturdayTask.FormattingEnabled = true;
            this.SaturdayTask.Location = new System.Drawing.Point(430, 37);
            this.SaturdayTask.Name = "SaturdayTask";
            this.SaturdayTask.Size = new System.Drawing.Size(80, 144);
            this.SaturdayTask.TabIndex = 1;
            // 
            // FridayTask
            // 
            this.FridayTask.Enabled = false;
            this.FridayTask.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FridayTask.FormattingEnabled = true;
            this.FridayTask.Location = new System.Drawing.Point(347, 37);
            this.FridayTask.Name = "FridayTask";
            this.FridayTask.Size = new System.Drawing.Size(80, 144);
            this.FridayTask.TabIndex = 1;
            // 
            // ThursdayTask
            // 
            this.ThursdayTask.Enabled = false;
            this.ThursdayTask.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThursdayTask.FormattingEnabled = true;
            this.ThursdayTask.Location = new System.Drawing.Point(265, 37);
            this.ThursdayTask.Name = "ThursdayTask";
            this.ThursdayTask.Size = new System.Drawing.Size(80, 144);
            this.ThursdayTask.TabIndex = 1;
            // 
            // WednesdayTask
            // 
            this.WednesdayTask.Enabled = false;
            this.WednesdayTask.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WednesdayTask.FormattingEnabled = true;
            this.WednesdayTask.Location = new System.Drawing.Point(183, 37);
            this.WednesdayTask.Name = "WednesdayTask";
            this.WednesdayTask.Size = new System.Drawing.Size(80, 144);
            this.WednesdayTask.TabIndex = 1;
            // 
            // TuesdayTask
            // 
            this.TuesdayTask.Enabled = false;
            this.TuesdayTask.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TuesdayTask.FormattingEnabled = true;
            this.TuesdayTask.Items.AddRange(new object[] {
            ""});
            this.TuesdayTask.Location = new System.Drawing.Point(101, 37);
            this.TuesdayTask.Name = "TuesdayTask";
            this.TuesdayTask.Size = new System.Drawing.Size(80, 144);
            this.TuesdayTask.TabIndex = 1;
            // 
            // MondayTask
            // 
            this.MondayTask.Enabled = false;
            this.MondayTask.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MondayTask.FormattingEnabled = true;
            this.MondayTask.Location = new System.Drawing.Point(19, 37);
            this.MondayTask.Name = "MondayTask";
            this.MondayTask.Size = new System.Drawing.Size(80, 144);
            this.MondayTask.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "토";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "금";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "화";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "월";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TodayTask);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TODAY";
            // 
            // TodayTask
            // 
            this.TodayTask.CheckOnClick = true;
            this.TodayTask.Enabled = false;
            this.TodayTask.FormattingEnabled = true;
            this.TodayTask.Items.AddRange(new object[] {
            "Test01",
            "Test02",
            "Test03"});
            this.TodayTask.Location = new System.Drawing.Point(4, 17);
            this.TodayTask.Name = "TodayTask";
            this.TodayTask.Size = new System.Drawing.Size(170, 166);
            this.TodayTask.TabIndex = 0;
            // 
            // TodayTap
            // 
            this.TodayTap.Controls.Add(this.TodayTapGroup);
            this.TodayTap.Location = new System.Drawing.Point(4, 24);
            this.TodayTap.Name = "TodayTap";
            this.TodayTap.Padding = new System.Windows.Forms.Padding(3);
            this.TodayTap.Size = new System.Drawing.Size(812, 430);
            this.TodayTap.TabIndex = 1;
            this.TodayTap.Text = "오늘의 일과";
            this.TodayTap.UseVisualStyleBackColor = true;
            // 
            // TodayTapGroup
            // 
            this.TodayTapGroup.Controls.Add(this.TodayTapTask);
            this.TodayTapGroup.Location = new System.Drawing.Point(8, 6);
            this.TodayTapGroup.Name = "TodayTapGroup";
            this.TodayTapGroup.Size = new System.Drawing.Size(307, 190);
            this.TodayTapGroup.TabIndex = 1;
            this.TodayTapGroup.TabStop = false;
            this.TodayTapGroup.Text = "TODAY";
            // 
            // TodayTapTask
            // 
            this.TodayTapTask.CheckOnClick = true;
            this.TodayTapTask.FormattingEnabled = true;
            this.TodayTapTask.Items.AddRange(new object[] {
            "Test01",
            "Test02",
            "Test03"});
            this.TodayTapTask.Location = new System.Drawing.Point(4, 17);
            this.TodayTapTask.Name = "TodayTapTask";
            this.TodayTapTask.Size = new System.Drawing.Size(297, 166);
            this.TodayTapTask.TabIndex = 0;
            this.TodayTapTask.TabStop = false;
            this.TodayTapTask.SelectedIndexChanged += new System.EventHandler(this.TodayTapTask_SelectedIndexChanged);
            // 
            // ModfTap
            // 
            this.ModfTap.Controls.Add(this.groupBox5);
            this.ModfTap.Location = new System.Drawing.Point(4, 24);
            this.ModfTap.Name = "ModfTap";
            this.ModfTap.Size = new System.Drawing.Size(812, 430);
            this.ModfTap.TabIndex = 3;
            this.ModfTap.Text = "일정 관리 / 수정";
            this.ModfTap.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Location = new System.Drawing.Point(8, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 169);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "요일별 일과 설정";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(10, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 10);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "제거";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "추가";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button3_KeyUp);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 23);
            this.textBox3.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "내용";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "요일";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "내용";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "요일";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.comboBox3.Location = new System.Drawing.Point(48, 102);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(93, 23);
            this.comboBox3.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "요일";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.comboBox2.Location = new System.Drawing.Point(48, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // contextTrayIcon
            // 
            this.contextTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextTrayIcon.Name = "contextTrayIcon";
            this.contextTrayIcon.Size = new System.Drawing.Size(105, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "UnivTasker";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 460);
            this.Controls.Add(this.TaskTap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "UnivTasker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TaskTap.ResumeLayout(false);
            this.MainTap.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TodayTap.ResumeLayout(false);
            this.TodayTapGroup.ResumeLayout(false);
            this.ModfTap.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TaskTap;
        private System.Windows.Forms.TabPage MainTap;
        private System.Windows.Forms.TabPage TodayTap;
        private System.Windows.Forms.TabPage ModfTap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox TodayTask;
        private System.Windows.Forms.DateTimePicker TodayView;
        private System.Windows.Forms.CheckedListBox SundayTask;
        private System.Windows.Forms.CheckedListBox SaturdayTask;
        private System.Windows.Forms.CheckedListBox FridayTask;
        private System.Windows.Forms.CheckedListBox ThursdayTask;
        private System.Windows.Forms.CheckedListBox WednesdayTask;
        private System.Windows.Forms.CheckedListBox TuesdayTask;
        private System.Windows.Forms.CheckedListBox MondayTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox TodayTapGroup;
        private System.Windows.Forms.CheckedListBox TodayTapTask;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ContextMenuStrip contextTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
    }
}

