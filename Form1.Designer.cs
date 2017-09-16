namespace WindowsFormsApplication3
{
    partial class Fuzzy_Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fuzzy_Control));
            this.FS_Bar = new System.Windows.Forms.TrackBar();
            this.RW_Bar = new System.Windows.Forms.TrackBar();
            this.DI_Bar = new System.Windows.Forms.TrackBar();
            this.CIF_Bar = new System.Windows.Forms.TrackBar();
            this.FS_Min = new System.Windows.Forms.Label();
            this.FS_Max = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RW_Min = new System.Windows.Forms.Label();
            this.RW_Max = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DI_Min = new System.Windows.Forms.Label();
            this.DI_Max = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CIF_Min = new System.Windows.Forms.Label();
            this.CIF_Max = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FSvalue_Box = new System.Windows.Forms.TextBox();
            this.RWvalue_Box = new System.Windows.Forms.TextBox();
            this.DIvalue_Box = new System.Windows.Forms.TextBox();
            this.CIFvalue_Box = new System.Windows.Forms.TextBox();
            this.FuzzySpeed_performance = new System.Windows.Forms.Label();
            this.SafeSpeed = new System.Windows.Forms.Label();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FS_Timer = new System.Windows.Forms.Timer(this.components);
            this.RW_Timer = new System.Windows.Forms.Timer(this.components);
            this.DI_Timer = new System.Windows.Forms.Timer(this.components);
            this.CIF_Timer = new System.Windows.Forms.Timer(this.components);
            this.current_Speed_label = new System.Windows.Forms.Label();
            this.tocdohientai = new System.Windows.Forms.Label();
            this.Command_Control = new System.Windows.Forms.Label();
            this.ChiThiDieuKhien = new System.Windows.Forms.Label();
            this.giatoc_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Gia_toc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SafeSpeed_Value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FS_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RW_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CIF_Bar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FS_Bar
            // 
            this.FS_Bar.Location = new System.Drawing.Point(362, 37);
            this.FS_Bar.Maximum = 1000;
            this.FS_Bar.Name = "FS_Bar";
            this.FS_Bar.Size = new System.Drawing.Size(237, 45);
            this.FS_Bar.TabIndex = 0;
            this.FS_Bar.TickFrequency = 200;
            this.FS_Bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // RW_Bar
            // 
            this.RW_Bar.LargeChange = 1;
            this.RW_Bar.Location = new System.Drawing.Point(362, 116);
            this.RW_Bar.Maximum = 8;
            this.RW_Bar.Minimum = 1;
            this.RW_Bar.Name = "RW_Bar";
            this.RW_Bar.Size = new System.Drawing.Size(237, 45);
            this.RW_Bar.TabIndex = 1;
            this.RW_Bar.Value = 1;
            this.RW_Bar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // DI_Bar
            // 
            this.DI_Bar.LargeChange = 10;
            this.DI_Bar.Location = new System.Drawing.Point(362, 201);
            this.DI_Bar.Maximum = 200;
            this.DI_Bar.Name = "DI_Bar";
            this.DI_Bar.Size = new System.Drawing.Size(237, 45);
            this.DI_Bar.TabIndex = 2;
            this.DI_Bar.TickFrequency = 25;
            this.DI_Bar.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // CIF_Bar
            // 
            this.CIF_Bar.LargeChange = 1;
            this.CIF_Bar.Location = new System.Drawing.Point(362, 286);
            this.CIF_Bar.Maximum = 20;
            this.CIF_Bar.Minimum = 1;
            this.CIF_Bar.Name = "CIF_Bar";
            this.CIF_Bar.Size = new System.Drawing.Size(237, 45);
            this.CIF_Bar.TabIndex = 3;
            this.CIF_Bar.Value = 1;
            this.CIF_Bar.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // FS_Min
            // 
            this.FS_Min.AutoSize = true;
            this.FS_Min.Location = new System.Drawing.Point(368, 69);
            this.FS_Min.Name = "FS_Min";
            this.FS_Min.Size = new System.Drawing.Size(13, 13);
            this.FS_Min.TabIndex = 4;
            this.FS_Min.Text = "0";
            // 
            // FS_Max
            // 
            this.FS_Max.AutoSize = true;
            this.FS_Max.Location = new System.Drawing.Point(568, 69);
            this.FS_Max.Name = "FS_Max";
            this.FS_Max.Size = new System.Drawing.Size(31, 13);
            this.FS_Max.TabIndex = 5;
            this.FS_Max.Text = "1000";
            this.FS_Max.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tầm nhìn xa (m)";
            // 
            // RW_Min
            // 
            this.RW_Min.AutoSize = true;
            this.RW_Min.Location = new System.Drawing.Point(368, 148);
            this.RW_Min.Name = "RW_Min";
            this.RW_Min.Size = new System.Drawing.Size(13, 13);
            this.RW_Min.TabIndex = 7;
            this.RW_Min.Text = "1";
            // 
            // RW_Max
            // 
            this.RW_Max.AutoSize = true;
            this.RW_Max.Location = new System.Drawing.Point(586, 148);
            this.RW_Max.Name = "RW_Max";
            this.RW_Max.Size = new System.Drawing.Size(13, 13);
            this.RW_Max.TabIndex = 8;
            this.RW_Max.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Độ rộng đường đi (làn xe)";
            // 
            // DI_Min
            // 
            this.DI_Min.AutoSize = true;
            this.DI_Min.Location = new System.Drawing.Point(371, 232);
            this.DI_Min.Name = "DI_Min";
            this.DI_Min.Size = new System.Drawing.Size(13, 13);
            this.DI_Min.TabIndex = 10;
            this.DI_Min.Text = "0";
            // 
            // DI_Max
            // 
            this.DI_Max.AutoSize = true;
            this.DI_Max.Location = new System.Drawing.Point(574, 233);
            this.DI_Max.Name = "DI_Max";
            this.DI_Max.Size = new System.Drawing.Size(25, 13);
            this.DI_Max.TabIndex = 11;
            this.DI_Max.Text = "200";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Khoảng cách tới giao lộ (m)";
            // 
            // CIF_Min
            // 
            this.CIF_Min.AutoSize = true;
            this.CIF_Min.Location = new System.Drawing.Point(368, 318);
            this.CIF_Min.Name = "CIF_Min";
            this.CIF_Min.Size = new System.Drawing.Size(13, 13);
            this.CIF_Min.TabIndex = 13;
            this.CIF_Min.Text = "1";
            // 
            // CIF_Max
            // 
            this.CIF_Max.AutoSize = true;
            this.CIF_Max.Location = new System.Drawing.Point(580, 318);
            this.CIF_Max.Name = "CIF_Max";
            this.CIF_Max.Size = new System.Drawing.Size(19, 13);
            this.CIF_Max.TabIndex = 14;
            this.CIF_Max.Text = "20";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(429, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Lượng xe trước mặt (xe)";
            // 
            // FSvalue_Box
            // 
            this.FSvalue_Box.Location = new System.Drawing.Point(624, 37);
            this.FSvalue_Box.Name = "FSvalue_Box";
            this.FSvalue_Box.Size = new System.Drawing.Size(72, 20);
            this.FSvalue_Box.TabIndex = 16;
            this.FSvalue_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RWvalue_Box
            // 
            this.RWvalue_Box.Location = new System.Drawing.Point(624, 116);
            this.RWvalue_Box.Name = "RWvalue_Box";
            this.RWvalue_Box.Size = new System.Drawing.Size(72, 20);
            this.RWvalue_Box.TabIndex = 17;
            this.RWvalue_Box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DIvalue_Box
            // 
            this.DIvalue_Box.Location = new System.Drawing.Point(624, 201);
            this.DIvalue_Box.Name = "DIvalue_Box";
            this.DIvalue_Box.Size = new System.Drawing.Size(72, 20);
            this.DIvalue_Box.TabIndex = 18;
            // 
            // CIFvalue_Box
            // 
            this.CIFvalue_Box.Location = new System.Drawing.Point(624, 286);
            this.CIFvalue_Box.Name = "CIFvalue_Box";
            this.CIFvalue_Box.Size = new System.Drawing.Size(72, 20);
            this.CIFvalue_Box.TabIndex = 19;
            this.CIFvalue_Box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FuzzySpeed_performance
            // 
            this.FuzzySpeed_performance.AutoSize = true;
            this.FuzzySpeed_performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuzzySpeed_performance.ForeColor = System.Drawing.Color.Green;
            this.FuzzySpeed_performance.Location = new System.Drawing.Point(6, 26);
            this.FuzzySpeed_performance.Name = "FuzzySpeed_performance";
            this.FuzzySpeed_performance.Size = new System.Drawing.Size(187, 13);
            this.FuzzySpeed_performance.TabIndex = 20;
            this.FuzzySpeed_performance.Text = "Speed = 0/Slow + 0/Medium + 0/Fast";
            // 
            // SafeSpeed
            // 
            this.SafeSpeed.AutoSize = true;
            this.SafeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SafeSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SafeSpeed.Location = new System.Drawing.Point(31, 248);
            this.SafeSpeed.Name = "SafeSpeed";
            this.SafeSpeed.Size = new System.Drawing.Size(92, 18);
            this.SafeSpeed.TabIndex = 21;
            this.SafeSpeed.Text = "Safe Speed :";
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge1.BaseArcColor = System.Drawing.Color.DimGray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(34, 21);
            this.aGauge1.MaxValue = 100F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Silver;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(209, 184);
            this.aGauge1.TabIndex = 23;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(374, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(515, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FS_Timer
            // 
            this.FS_Timer.Interval = 5000;
            this.FS_Timer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // RW_Timer
            // 
            this.RW_Timer.Interval = 5000;
            this.RW_Timer.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // DI_Timer
            // 
            this.DI_Timer.Interval = 5000;
            this.DI_Timer.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // CIF_Timer
            // 
            this.CIF_Timer.Interval = 5000;
            this.CIF_Timer.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // current_Speed_label
            // 
            this.current_Speed_label.AutoSize = true;
            this.current_Speed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_Speed_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.current_Speed_label.Location = new System.Drawing.Point(31, 213);
            this.current_Speed_label.Name = "current_Speed_label";
            this.current_Speed_label.Size = new System.Drawing.Size(58, 18);
            this.current_Speed_label.TabIndex = 26;
            this.current_Speed_label.Text = "Speed :";
            // 
            // tocdohientai
            // 
            this.tocdohientai.AutoSize = true;
            this.tocdohientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocdohientai.ForeColor = System.Drawing.Color.Red;
            this.tocdohientai.Location = new System.Drawing.Point(126, 213);
            this.tocdohientai.Name = "tocdohientai";
            this.tocdohientai.Size = new System.Drawing.Size(26, 18);
            this.tocdohientai.TabIndex = 27;
            this.tocdohientai.Text = "50";
            this.tocdohientai.Click += new System.EventHandler(this.tocdohientai_Click);
            // 
            // Command_Control
            // 
            this.Command_Control.AutoSize = true;
            this.Command_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command_Control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Command_Control.Location = new System.Drawing.Point(22, 30);
            this.Command_Control.Name = "Command_Control";
            this.Command_Control.Size = new System.Drawing.Size(107, 16);
            this.Command_Control.TabIndex = 28;
            this.Command_Control.Text = "Chỉ thị điều khiển";
            // 
            // ChiThiDieuKhien
            // 
            this.ChiThiDieuKhien.AutoSize = true;
            this.ChiThiDieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiThiDieuKhien.ForeColor = System.Drawing.Color.Red;
            this.ChiThiDieuKhien.Location = new System.Drawing.Point(140, 30);
            this.ChiThiDieuKhien.Name = "ChiThiDieuKhien";
            this.ChiThiDieuKhien.Size = new System.Drawing.Size(132, 16);
            this.ChiThiDieuKhien.TabIndex = 29;
            this.ChiThiDieuKhien.Text = "Giữ nguyên tốc độ";
            // 
            // giatoc_label
            // 
            this.giatoc_label.AutoSize = true;
            this.giatoc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giatoc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.giatoc_label.Location = new System.Drawing.Point(22, 52);
            this.giatoc_label.Name = "giatoc_label";
            this.giatoc_label.Size = new System.Drawing.Size(50, 16);
            this.giatoc_label.TabIndex = 30;
            this.giatoc_label.Text = "Gia tốc";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Gia_toc
            // 
            this.Gia_toc.AutoSize = true;
            this.Gia_toc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia_toc.ForeColor = System.Drawing.Color.Red;
            this.Gia_toc.Location = new System.Drawing.Point(140, 52);
            this.Gia_toc.Name = "Gia_toc";
            this.Gia_toc.Size = new System.Drawing.Size(16, 16);
            this.Gia_toc.TabIndex = 31;
            this.Gia_toc.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SafeSpeed_Value);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.aGauge1);
            this.groupBox1.Controls.Add(this.current_Speed_label);
            this.groupBox1.Controls.Add(this.tocdohientai);
            this.groupBox1.Controls.Add(this.SafeSpeed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 363);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.FuzzySpeed_performance);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 58);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Membership";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(192, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "(km/h)";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // SafeSpeed_Value
            // 
            this.SafeSpeed_Value.AutoSize = true;
            this.SafeSpeed_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SafeSpeed_Value.ForeColor = System.Drawing.Color.Red;
            this.SafeSpeed_Value.Location = new System.Drawing.Point(130, 248);
            this.SafeSpeed_Value.Name = "SafeSpeed_Value";
            this.SafeSpeed_Value.Size = new System.Drawing.Size(22, 18);
            this.SafeSpeed_Value.TabIndex = 29;
            this.SafeSpeed_Value.Text = "0 ";
            this.SafeSpeed_Value.Click += new System.EventHandler(this.SafeSpeed_Value_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(192, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "(km/h)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Command_Control);
            this.groupBox3.Controls.Add(this.ChiThiDieuKhien);
            this.groupBox3.Controls.Add(this.Gia_toc);
            this.groupBox3.Controls.Add(this.giatoc_label);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 90);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "(km/h2)";
            // 
            // Fuzzy_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CIFvalue_Box);
            this.Controls.Add(this.DIvalue_Box);
            this.Controls.Add(this.RWvalue_Box);
            this.Controls.Add(this.FSvalue_Box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CIF_Max);
            this.Controls.Add(this.CIF_Min);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DI_Max);
            this.Controls.Add(this.DI_Min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RW_Max);
            this.Controls.Add(this.RW_Min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FS_Max);
            this.Controls.Add(this.FS_Min);
            this.Controls.Add(this.CIF_Bar);
            this.Controls.Add(this.DI_Bar);
            this.Controls.Add(this.RW_Bar);
            this.Controls.Add(this.FS_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fuzzy_Control";
            this.Text = "Fuzzy Control";
            this.Load += new System.EventHandler(this.Comman_control1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FS_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RW_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CIF_Bar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RW_Bar;
        private System.Windows.Forms.TrackBar DI_Bar;
        private System.Windows.Forms.TrackBar CIF_Bar;
        private System.Windows.Forms.Label FS_Min;
        private System.Windows.Forms.Label FS_Max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RW_Min;
        private System.Windows.Forms.Label RW_Max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DI_Min;
        private System.Windows.Forms.Label DI_Max;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CIF_Min;
        private System.Windows.Forms.Label CIF_Max;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FSvalue_Box;
        private System.Windows.Forms.TextBox RWvalue_Box;
        private System.Windows.Forms.TextBox DIvalue_Box;
        private System.Windows.Forms.TextBox CIFvalue_Box;
        private System.Windows.Forms.Label FuzzySpeed_performance;
        private System.Windows.Forms.Label SafeSpeed;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.TrackBar FS_Bar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer FS_Timer;
        private System.Windows.Forms.Timer RW_Timer;
        private System.Windows.Forms.Timer DI_Timer;
        private System.Windows.Forms.Timer CIF_Timer;
        private System.Windows.Forms.Label current_Speed_label;
        private System.Windows.Forms.Label tocdohientai;
        private System.Windows.Forms.Label Command_Control;
        private System.Windows.Forms.Label ChiThiDieuKhien;
        private System.Windows.Forms.Label giatoc_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Gia_toc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SafeSpeed_Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}

