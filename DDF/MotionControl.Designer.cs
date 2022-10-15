
namespace DDF
{
    partial class MotionControl
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
            this.comboBox_Emergency = new System.Windows.Forms.ComboBox();
            this.comboBox_YAlarm = new System.Windows.Forms.ComboBox();
            this.comboBox_XAlarm = new System.Windows.Forms.ComboBox();
            this.comboBox_YServo = new System.Windows.Forms.ComboBox();
            this.comboBox_XServo = new System.Windows.Forms.ComboBox();
            this.textBox_YMax = new System.Windows.Forms.TextBox();
            this.textBox_XMax = new System.Windows.Forms.TextBox();
            this.textBox_YDec = new System.Windows.Forms.TextBox();
            this.textBox_XDec = new System.Windows.Forms.TextBox();
            this.textBox_YAcc = new System.Windows.Forms.TextBox();
            this.textBox_XAcc = new System.Windows.Forms.TextBox();
            this.textBox_YStartSpeed = new System.Windows.Forms.TextBox();
            this.textBox_XStartSpeed = new System.Windows.Forms.TextBox();
            this.textBox_YRatio = new System.Windows.Forms.TextBox();
            this.textBox_XRatio = new System.Windows.Forms.TextBox();
            this.button_SetUp = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DDF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Emergency
            // 
            this.comboBox_Emergency.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Emergency.FormattingEnabled = true;
            this.comboBox_Emergency.IntegralHeight = false;
            this.comboBox_Emergency.Items.AddRange(new object[] {
            "NO",
            "NC"});
            this.comboBox_Emergency.Location = new System.Drawing.Point(153, 419);
            this.comboBox_Emergency.Name = "comboBox_Emergency";
            this.comboBox_Emergency.Size = new System.Drawing.Size(105, 28);
            this.comboBox_Emergency.TabIndex = 139;
            this.comboBox_Emergency.Text = "NO";
            // 
            // comboBox_YAlarm
            // 
            this.comboBox_YAlarm.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_YAlarm.FormattingEnabled = true;
            this.comboBox_YAlarm.Items.AddRange(new object[] {
            "NC",
            "NO"});
            this.comboBox_YAlarm.Location = new System.Drawing.Point(130, 210);
            this.comboBox_YAlarm.Name = "comboBox_YAlarm";
            this.comboBox_YAlarm.Size = new System.Drawing.Size(105, 28);
            this.comboBox_YAlarm.TabIndex = 138;
            this.comboBox_YAlarm.Text = "NC";
            // 
            // comboBox_XAlarm
            // 
            this.comboBox_XAlarm.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_XAlarm.FormattingEnabled = true;
            this.comboBox_XAlarm.Items.AddRange(new object[] {
            "NC",
            "NO"});
            this.comboBox_XAlarm.Location = new System.Drawing.Point(129, 214);
            this.comboBox_XAlarm.Name = "comboBox_XAlarm";
            this.comboBox_XAlarm.Size = new System.Drawing.Size(105, 28);
            this.comboBox_XAlarm.TabIndex = 137;
            this.comboBox_XAlarm.Text = "NC";
            // 
            // comboBox_YServo
            // 
            this.comboBox_YServo.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_YServo.FormattingEnabled = true;
            this.comboBox_YServo.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBox_YServo.Location = new System.Drawing.Point(130, 240);
            this.comboBox_YServo.Name = "comboBox_YServo";
            this.comboBox_YServo.Size = new System.Drawing.Size(105, 28);
            this.comboBox_YServo.TabIndex = 136;
            this.comboBox_YServo.Text = "OFF";
            // 
            // comboBox_XServo
            // 
            this.comboBox_XServo.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_XServo.FormattingEnabled = true;
            this.comboBox_XServo.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBox_XServo.Location = new System.Drawing.Point(129, 244);
            this.comboBox_XServo.Name = "comboBox_XServo";
            this.comboBox_XServo.Size = new System.Drawing.Size(105, 28);
            this.comboBox_XServo.TabIndex = 135;
            this.comboBox_XServo.Text = "OFF";
            // 
            // textBox_YMax
            // 
            this.textBox_YMax.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YMax.Location = new System.Drawing.Point(130, 172);
            this.textBox_YMax.Multiline = true;
            this.textBox_YMax.Name = "textBox_YMax";
            this.textBox_YMax.Size = new System.Drawing.Size(105, 27);
            this.textBox_YMax.TabIndex = 134;
            this.textBox_YMax.Text = "16.667";
            this.textBox_YMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XMax
            // 
            this.textBox_XMax.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XMax.Location = new System.Drawing.Point(129, 175);
            this.textBox_XMax.Multiline = true;
            this.textBox_XMax.Name = "textBox_XMax";
            this.textBox_XMax.Size = new System.Drawing.Size(105, 26);
            this.textBox_XMax.TabIndex = 133;
            this.textBox_XMax.Text = "10.417";
            this.textBox_XMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YDec
            // 
            this.textBox_YDec.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YDec.Location = new System.Drawing.Point(130, 139);
            this.textBox_YDec.Multiline = true;
            this.textBox_YDec.Name = "textBox_YDec";
            this.textBox_YDec.Size = new System.Drawing.Size(105, 27);
            this.textBox_YDec.TabIndex = 132;
            this.textBox_YDec.Text = "10.445";
            this.textBox_YDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XDec
            // 
            this.textBox_XDec.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XDec.Location = new System.Drawing.Point(129, 143);
            this.textBox_XDec.Multiline = true;
            this.textBox_XDec.Name = "textBox_XDec";
            this.textBox_XDec.Size = new System.Drawing.Size(105, 26);
            this.textBox_XDec.TabIndex = 131;
            this.textBox_XDec.Text = "6.278";
            this.textBox_XDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YAcc
            // 
            this.textBox_YAcc.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YAcc.Location = new System.Drawing.Point(130, 106);
            this.textBox_YAcc.Multiline = true;
            this.textBox_YAcc.Name = "textBox_YAcc";
            this.textBox_YAcc.Size = new System.Drawing.Size(105, 27);
            this.textBox_YAcc.TabIndex = 130;
            this.textBox_YAcc.Text = "10.445";
            this.textBox_YAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XAcc
            // 
            this.textBox_XAcc.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XAcc.Location = new System.Drawing.Point(129, 110);
            this.textBox_XAcc.Multiline = true;
            this.textBox_XAcc.Name = "textBox_XAcc";
            this.textBox_XAcc.Size = new System.Drawing.Size(105, 27);
            this.textBox_XAcc.TabIndex = 129;
            this.textBox_XAcc.Text = "6.278";
            this.textBox_XAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YStartSpeed
            // 
            this.textBox_YStartSpeed.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YStartSpeed.Location = new System.Drawing.Point(130, 73);
            this.textBox_YStartSpeed.Multiline = true;
            this.textBox_YStartSpeed.Name = "textBox_YStartSpeed";
            this.textBox_YStartSpeed.Size = new System.Drawing.Size(105, 27);
            this.textBox_YStartSpeed.TabIndex = 128;
            this.textBox_YStartSpeed.Text = "1";
            this.textBox_YStartSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XStartSpeed
            // 
            this.textBox_XStartSpeed.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XStartSpeed.Location = new System.Drawing.Point(129, 77);
            this.textBox_XStartSpeed.Multiline = true;
            this.textBox_XStartSpeed.Name = "textBox_XStartSpeed";
            this.textBox_XStartSpeed.Size = new System.Drawing.Size(105, 27);
            this.textBox_XStartSpeed.TabIndex = 127;
            this.textBox_XStartSpeed.Text = "1";
            this.textBox_XStartSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YRatio
            // 
            this.textBox_YRatio.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YRatio.Location = new System.Drawing.Point(130, 40);
            this.textBox_YRatio.Multiline = true;
            this.textBox_YRatio.Name = "textBox_YRatio";
            this.textBox_YRatio.Size = new System.Drawing.Size(105, 27);
            this.textBox_YRatio.TabIndex = 126;
            this.textBox_YRatio.Text = "0.0000358";
            this.textBox_YRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XRatio
            // 
            this.textBox_XRatio.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XRatio.Location = new System.Drawing.Point(129, 44);
            this.textBox_XRatio.Multiline = true;
            this.textBox_XRatio.Name = "textBox_XRatio";
            this.textBox_XRatio.Size = new System.Drawing.Size(105, 27);
            this.textBox_XRatio.TabIndex = 125;
            this.textBox_XRatio.Text = "0.0000179";
            this.textBox_XRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SetUp
            // 
            this.button_SetUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SetUp.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_SetUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SetUp.Location = new System.Drawing.Point(317, 414);
            this.button_SetUp.Name = "button_SetUp";
            this.button_SetUp.Size = new System.Drawing.Size(105, 39);
            this.button_SetUp.TabIndex = 114;
            this.button_SetUp.Text = "SetUp";
            this.button_SetUp.UseVisualStyleBackColor = false;
            this.button_SetUp.Click += new System.EventHandler(this.button_SetUp_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_close.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_close.Location = new System.Drawing.Point(430, 414);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(105, 39);
            this.btn_close.TabIndex = 151;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(18, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 30);
            this.label11.TabIndex = 152;
            this.label11.Text = "-Motion Control-";
            // 
            // DDF
            // 
            this.DDF.AutoSize = true;
            this.DDF.Font = new System.Drawing.Font("맑은 고딕", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DDF.Location = new System.Drawing.Point(12, 9);
            this.DDF.Name = "DDF";
            this.DDF.Size = new System.Drawing.Size(209, 45);
            this.DDF.TabIndex = 153;
            this.DDF.Text = "DDF Control";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox_YAlarm);
            this.groupBox1.Controls.Add(this.comboBox_YServo);
            this.groupBox1.Controls.Add(this.textBox_YMax);
            this.groupBox1.Controls.Add(this.textBox_YDec);
            this.groupBox1.Controls.Add(this.textBox_YRatio);
            this.groupBox1.Controls.Add(this.textBox_YAcc);
            this.groupBox1.Controls.Add(this.textBox_YStartSpeed);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 291);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screw Motor(Y)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.textBox_XMax);
            this.groupBox2.Controls.Add(this.textBox_XDec);
            this.groupBox2.Controls.Add(this.textBox_XAcc);
            this.groupBox2.Controls.Add(this.textBox_XStartSpeed);
            this.groupBox2.Controls.Add(this.textBox_XRatio);
            this.groupBox2.Controls.Add(this.comboBox_XServo);
            this.groupBox2.Controls.Add(this.comboBox_XAlarm);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(299, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 291);
            this.groupBox2.TabIndex = 155;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Piston Motor(X)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(18, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 140;
            this.label12.Text = "Unit Per Pulse";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(78, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 141;
            this.label13.Text = "Servo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(75, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 142;
            this.label14.Text = "Alarm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(44, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 143;
            this.label15.Text = "Accelation";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(29, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 20);
            this.label16.TabIndex = 144;
            this.label16.Text = "Deceleration";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(39, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 20);
            this.label17.TabIndex = 145;
            this.label17.Text = "Max Speed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(64, 422);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 20);
            this.label18.TabIndex = 146;
            this.label18.Text = "Emergency";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(37, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 146;
            this.label19.Text = "Start Speed";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(36, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 20);
            this.label20.TabIndex = 153;
            this.label20.Text = "Start Speed";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(38, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 20);
            this.label21.TabIndex = 152;
            this.label21.Text = "Max Speed";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(28, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 20);
            this.label22.TabIndex = 151;
            this.label22.Text = "Deceleration";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(43, 113);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 20);
            this.label23.TabIndex = 150;
            this.label23.Text = "Accelation";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(74, 217);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 20);
            this.label24.TabIndex = 149;
            this.label24.Text = "Alarm";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(77, 247);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 20);
            this.label25.TabIndex = 148;
            this.label25.Text = "Servo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(17, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 20);
            this.label26.TabIndex = 147;
            this.label26.Text = "Unit Per Pulse";
            // 
            // MotionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(582, 466);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DDF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.button_SetUp);
            this.Controls.Add(this.comboBox_Emergency);
            this.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MotionControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotionControl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Emergency;
        private System.Windows.Forms.ComboBox comboBox_YAlarm;
        private System.Windows.Forms.ComboBox comboBox_XAlarm;
        private System.Windows.Forms.ComboBox comboBox_YServo;
        private System.Windows.Forms.ComboBox comboBox_XServo;
        private System.Windows.Forms.TextBox textBox_YMax;
        private System.Windows.Forms.TextBox textBox_XMax;
        private System.Windows.Forms.TextBox textBox_YDec;
        private System.Windows.Forms.TextBox textBox_XDec;
        private System.Windows.Forms.TextBox textBox_YAcc;
        private System.Windows.Forms.TextBox textBox_XAcc;
        private System.Windows.Forms.TextBox textBox_YStartSpeed;
        private System.Windows.Forms.TextBox textBox_XStartSpeed;
        private System.Windows.Forms.TextBox textBox_YRatio;
        private System.Windows.Forms.TextBox textBox_XRatio;
        private System.Windows.Forms.Button button_SetUp;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DDF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}