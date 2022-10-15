
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DDF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Emergency
            // 
            this.comboBox_Emergency.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Emergency.FormattingEnabled = true;
            this.comboBox_Emergency.IntegralHeight = false;
            this.comboBox_Emergency.Items.AddRange(new object[] {
            "NO",
            "NC"});
            this.comboBox_Emergency.Location = new System.Drawing.Point(805, 64);
            this.comboBox_Emergency.Name = "comboBox_Emergency";
            this.comboBox_Emergency.Size = new System.Drawing.Size(105, 58);
            this.comboBox_Emergency.TabIndex = 139;
            this.comboBox_Emergency.Text = "NO";
            // 
            // comboBox_YAlarm
            // 
            this.comboBox_YAlarm.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_YAlarm.FormattingEnabled = true;
            this.comboBox_YAlarm.Items.AddRange(new object[] {
            "NC",
            "NO"});
            this.comboBox_YAlarm.Location = new System.Drawing.Point(280, 94);
            this.comboBox_YAlarm.Name = "comboBox_YAlarm";
            this.comboBox_YAlarm.Size = new System.Drawing.Size(105, 33);
            this.comboBox_YAlarm.TabIndex = 138;
            this.comboBox_YAlarm.Text = "NC";
            // 
            // comboBox_XAlarm
            // 
            this.comboBox_XAlarm.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_XAlarm.FormattingEnabled = true;
            this.comboBox_XAlarm.Items.AddRange(new object[] {
            "NC",
            "NO"});
            this.comboBox_XAlarm.Location = new System.Drawing.Point(280, 64);
            this.comboBox_XAlarm.Name = "comboBox_XAlarm";
            this.comboBox_XAlarm.Size = new System.Drawing.Size(105, 33);
            this.comboBox_XAlarm.TabIndex = 137;
            this.comboBox_XAlarm.Text = "NC";
            // 
            // comboBox_YServo
            // 
            this.comboBox_YServo.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_YServo.FormattingEnabled = true;
            this.comboBox_YServo.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBox_YServo.Location = new System.Drawing.Point(175, 94);
            this.comboBox_YServo.Name = "comboBox_YServo";
            this.comboBox_YServo.Size = new System.Drawing.Size(105, 33);
            this.comboBox_YServo.TabIndex = 136;
            this.comboBox_YServo.Text = "OFF";
            // 
            // comboBox_XServo
            // 
            this.comboBox_XServo.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_XServo.FormattingEnabled = true;
            this.comboBox_XServo.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBox_XServo.Location = new System.Drawing.Point(175, 64);
            this.comboBox_XServo.Name = "comboBox_XServo";
            this.comboBox_XServo.Size = new System.Drawing.Size(105, 33);
            this.comboBox_XServo.TabIndex = 135;
            this.comboBox_XServo.Text = "OFF";
            // 
            // textBox_YMax
            // 
            this.textBox_YMax.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YMax.Location = new System.Drawing.Point(700, 94);
            this.textBox_YMax.Multiline = true;
            this.textBox_YMax.Name = "textBox_YMax";
            this.textBox_YMax.Size = new System.Drawing.Size(105, 33);
            this.textBox_YMax.TabIndex = 134;
            this.textBox_YMax.Text = "16.667";
            this.textBox_YMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XMax
            // 
            this.textBox_XMax.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XMax.Location = new System.Drawing.Point(700, 64);
            this.textBox_XMax.Multiline = true;
            this.textBox_XMax.Name = "textBox_XMax";
            this.textBox_XMax.Size = new System.Drawing.Size(105, 31);
            this.textBox_XMax.TabIndex = 133;
            this.textBox_XMax.Text = "10.417";
            this.textBox_XMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YDec
            // 
            this.textBox_YDec.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YDec.Location = new System.Drawing.Point(595, 94);
            this.textBox_YDec.Multiline = true;
            this.textBox_YDec.Name = "textBox_YDec";
            this.textBox_YDec.Size = new System.Drawing.Size(105, 33);
            this.textBox_YDec.TabIndex = 132;
            this.textBox_YDec.Text = "10.445";
            this.textBox_YDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XDec
            // 
            this.textBox_XDec.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XDec.Location = new System.Drawing.Point(595, 64);
            this.textBox_XDec.Multiline = true;
            this.textBox_XDec.Name = "textBox_XDec";
            this.textBox_XDec.Size = new System.Drawing.Size(105, 31);
            this.textBox_XDec.TabIndex = 131;
            this.textBox_XDec.Text = "6.278";
            this.textBox_XDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YAcc
            // 
            this.textBox_YAcc.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YAcc.Location = new System.Drawing.Point(490, 94);
            this.textBox_YAcc.Multiline = true;
            this.textBox_YAcc.Name = "textBox_YAcc";
            this.textBox_YAcc.Size = new System.Drawing.Size(105, 33);
            this.textBox_YAcc.TabIndex = 130;
            this.textBox_YAcc.Text = "10.445";
            this.textBox_YAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XAcc
            // 
            this.textBox_XAcc.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XAcc.Location = new System.Drawing.Point(490, 64);
            this.textBox_XAcc.Multiline = true;
            this.textBox_XAcc.Name = "textBox_XAcc";
            this.textBox_XAcc.Size = new System.Drawing.Size(105, 31);
            this.textBox_XAcc.TabIndex = 129;
            this.textBox_XAcc.Text = "6.278";
            this.textBox_XAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YStartSpeed
            // 
            this.textBox_YStartSpeed.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YStartSpeed.Location = new System.Drawing.Point(385, 94);
            this.textBox_YStartSpeed.Multiline = true;
            this.textBox_YStartSpeed.Name = "textBox_YStartSpeed";
            this.textBox_YStartSpeed.Size = new System.Drawing.Size(105, 33);
            this.textBox_YStartSpeed.TabIndex = 128;
            this.textBox_YStartSpeed.Text = "1";
            this.textBox_YStartSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XStartSpeed
            // 
            this.textBox_XStartSpeed.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XStartSpeed.Location = new System.Drawing.Point(385, 64);
            this.textBox_XStartSpeed.Multiline = true;
            this.textBox_XStartSpeed.Name = "textBox_XStartSpeed";
            this.textBox_XStartSpeed.Size = new System.Drawing.Size(105, 31);
            this.textBox_XStartSpeed.TabIndex = 127;
            this.textBox_XStartSpeed.Text = "1";
            this.textBox_XStartSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YRatio
            // 
            this.textBox_YRatio.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_YRatio.Location = new System.Drawing.Point(70, 94);
            this.textBox_YRatio.Multiline = true;
            this.textBox_YRatio.Name = "textBox_YRatio";
            this.textBox_YRatio.Size = new System.Drawing.Size(105, 33);
            this.textBox_YRatio.TabIndex = 126;
            this.textBox_YRatio.Text = "0.0000358";
            this.textBox_YRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XRatio
            // 
            this.textBox_XRatio.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_XRatio.Location = new System.Drawing.Point(70, 64);
            this.textBox_XRatio.Multiline = true;
            this.textBox_XRatio.Name = "textBox_XRatio";
            this.textBox_XRatio.Size = new System.Drawing.Size(105, 31);
            this.textBox_XRatio.TabIndex = 125;
            this.textBox_XRatio.Text = "0.0000179";
            this.textBox_XRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SetUp
            // 
            this.button_SetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(246)))));
            this.button_SetUp.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_SetUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_SetUp.Location = new System.Drawing.Point(723, 289);
            this.button_SetUp.Name = "button_SetUp";
            this.button_SetUp.Size = new System.Drawing.Size(105, 39);
            this.button_SetUp.TabIndex = 114;
            this.button_SetUp.Text = "SetUp";
            this.button_SetUp.UseVisualStyleBackColor = false;
            this.button_SetUp.Click += new System.EventHandler(this.button_SetUp_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(700, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 32);
            this.label9.TabIndex = 113;
            this.label9.Text = "Max";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label10.Location = new System.Drawing.Point(595, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 32);
            this.label10.TabIndex = 112;
            this.label10.Text = "Dec";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 33);
            this.label2.TabIndex = 111;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(490, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 32);
            this.label8.TabIndex = 110;
            this.label8.Text = "Acc";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(385, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 109;
            this.label7.Text = "StartSpeed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(805, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 32);
            this.label6.TabIndex = 108;
            this.label6.Text = "Emergency";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(280, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 107;
            this.label5.Text = "Alarm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(175, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 106;
            this.label4.Text = "Servo_On";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(70, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 105;
            this.label3.Text = "UnitPerPulse";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 31);
            this.label1.TabIndex = 104;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(246)))));
            this.btn_close.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Location = new System.Drawing.Point(834, 289);
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_Emergency);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox_YAlarm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_XAlarm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_YServo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_XServo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_YMax);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_XMax);
            this.groupBox1.Controls.Add(this.textBox_XRatio);
            this.groupBox1.Controls.Add(this.textBox_YDec);
            this.groupBox1.Controls.Add(this.textBox_YRatio);
            this.groupBox1.Controls.Add(this.textBox_XDec);
            this.groupBox1.Controls.Add(this.textBox_XStartSpeed);
            this.groupBox1.Controls.Add(this.textBox_YAcc);
            this.groupBox1.Controls.Add(this.textBox_YStartSpeed);
            this.groupBox1.Controls.Add(this.textBox_XAcc);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 148);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X,Y SetUp";
            // 
            // MotionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(971, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DDF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.button_SetUp);
            this.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MotionControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotionControl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DDF;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}