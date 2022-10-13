
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
            this.button_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Emergency
            // 
            this.comboBox_Emergency.Font = new System.Drawing.Font("굴림", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Emergency.FormattingEnabled = true;
            this.comboBox_Emergency.IntegralHeight = false;
            this.comboBox_Emergency.Items.AddRange(new object[] {
            "NO",
            "NC"});
            this.comboBox_Emergency.Location = new System.Drawing.Point(818, 205);
            this.comboBox_Emergency.Name = "comboBox_Emergency";
            this.comboBox_Emergency.Size = new System.Drawing.Size(105, 57);
            this.comboBox_Emergency.TabIndex = 139;
            this.comboBox_Emergency.Text = "NO";
            // 
            // comboBox_YAlarm
            // 
            this.comboBox_YAlarm.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_YAlarm.FormattingEnabled = true;
            this.comboBox_YAlarm.Items.AddRange(new object[] {
            "NC",
            "NO"});
            this.comboBox_YAlarm.Location = new System.Drawing.Point(293, 233);
            this.comboBox_YAlarm.Name = "comboBox_YAlarm";
            this.comboBox_YAlarm.Size = new System.Drawing.Size(105, 28);
            this.comboBox_YAlarm.TabIndex = 138;
            this.comboBox_YAlarm.Text = "NC";
            // 
            // comboBox_XAlarm
            // 
            this.comboBox_XAlarm.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_XAlarm.FormattingEnabled = true;
            this.comboBox_XAlarm.Items.AddRange(new object[] {
            "NC",
            "NO"});
            this.comboBox_XAlarm.Location = new System.Drawing.Point(293, 205);
            this.comboBox_XAlarm.Name = "comboBox_XAlarm";
            this.comboBox_XAlarm.Size = new System.Drawing.Size(105, 28);
            this.comboBox_XAlarm.TabIndex = 137;
            this.comboBox_XAlarm.Text = "NC";
            // 
            // comboBox_YServo
            // 
            this.comboBox_YServo.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_YServo.FormattingEnabled = true;
            this.comboBox_YServo.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBox_YServo.Location = new System.Drawing.Point(188, 233);
            this.comboBox_YServo.Name = "comboBox_YServo";
            this.comboBox_YServo.Size = new System.Drawing.Size(105, 28);
            this.comboBox_YServo.TabIndex = 136;
            this.comboBox_YServo.Text = "OFF";
            // 
            // comboBox_XServo
            // 
            this.comboBox_XServo.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_XServo.FormattingEnabled = true;
            this.comboBox_XServo.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBox_XServo.Location = new System.Drawing.Point(188, 205);
            this.comboBox_XServo.Name = "comboBox_XServo";
            this.comboBox_XServo.Size = new System.Drawing.Size(105, 28);
            this.comboBox_XServo.TabIndex = 135;
            this.comboBox_XServo.Text = "OFF";
            // 
            // textBox_YMax
            // 
            this.textBox_YMax.Location = new System.Drawing.Point(713, 234);
            this.textBox_YMax.Name = "textBox_YMax";
            this.textBox_YMax.Size = new System.Drawing.Size(105, 21);
            this.textBox_YMax.TabIndex = 134;
            this.textBox_YMax.Text = "16.667";
            this.textBox_YMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XMax
            // 
            this.textBox_XMax.Location = new System.Drawing.Point(713, 205);
            this.textBox_XMax.Name = "textBox_XMax";
            this.textBox_XMax.Size = new System.Drawing.Size(105, 21);
            this.textBox_XMax.TabIndex = 133;
            this.textBox_XMax.Text = "10.417";
            this.textBox_XMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YDec
            // 
            this.textBox_YDec.Location = new System.Drawing.Point(608, 234);
            this.textBox_YDec.Name = "textBox_YDec";
            this.textBox_YDec.Size = new System.Drawing.Size(105, 21);
            this.textBox_YDec.TabIndex = 132;
            this.textBox_YDec.Text = "10.445";
            this.textBox_YDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XDec
            // 
            this.textBox_XDec.Location = new System.Drawing.Point(608, 205);
            this.textBox_XDec.Name = "textBox_XDec";
            this.textBox_XDec.Size = new System.Drawing.Size(105, 21);
            this.textBox_XDec.TabIndex = 131;
            this.textBox_XDec.Text = "6.278";
            this.textBox_XDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YAcc
            // 
            this.textBox_YAcc.Location = new System.Drawing.Point(503, 234);
            this.textBox_YAcc.Name = "textBox_YAcc";
            this.textBox_YAcc.Size = new System.Drawing.Size(105, 21);
            this.textBox_YAcc.TabIndex = 130;
            this.textBox_YAcc.Text = "10.445";
            this.textBox_YAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XAcc
            // 
            this.textBox_XAcc.Location = new System.Drawing.Point(503, 205);
            this.textBox_XAcc.Name = "textBox_XAcc";
            this.textBox_XAcc.Size = new System.Drawing.Size(105, 21);
            this.textBox_XAcc.TabIndex = 129;
            this.textBox_XAcc.Text = "6.278";
            this.textBox_XAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YStartSpeed
            // 
            this.textBox_YStartSpeed.Location = new System.Drawing.Point(398, 234);
            this.textBox_YStartSpeed.Name = "textBox_YStartSpeed";
            this.textBox_YStartSpeed.Size = new System.Drawing.Size(105, 21);
            this.textBox_YStartSpeed.TabIndex = 128;
            this.textBox_YStartSpeed.Text = "1";
            this.textBox_YStartSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XStartSpeed
            // 
            this.textBox_XStartSpeed.Location = new System.Drawing.Point(398, 205);
            this.textBox_XStartSpeed.Name = "textBox_XStartSpeed";
            this.textBox_XStartSpeed.Size = new System.Drawing.Size(105, 21);
            this.textBox_XStartSpeed.TabIndex = 127;
            this.textBox_XStartSpeed.Text = "1";
            this.textBox_XStartSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YRatio
            // 
            this.textBox_YRatio.Location = new System.Drawing.Point(83, 234);
            this.textBox_YRatio.Name = "textBox_YRatio";
            this.textBox_YRatio.Size = new System.Drawing.Size(105, 21);
            this.textBox_YRatio.TabIndex = 126;
            this.textBox_YRatio.Text = "0.0000358";
            this.textBox_YRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_XRatio
            // 
            this.textBox_XRatio.Location = new System.Drawing.Point(83, 205);
            this.textBox_XRatio.Name = "textBox_XRatio";
            this.textBox_XRatio.Size = new System.Drawing.Size(105, 21);
            this.textBox_XRatio.TabIndex = 125;
            this.textBox_XRatio.Text = "0.0000179";
            this.textBox_XRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SetUp
            // 
            this.button_SetUp.BackColor = System.Drawing.SystemColors.Info;
            this.button_SetUp.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_SetUp.Location = new System.Drawing.Point(608, 342);
            this.button_SetUp.Name = "button_SetUp";
            this.button_SetUp.Size = new System.Drawing.Size(105, 29);
            this.button_SetUp.TabIndex = 114;
            this.button_SetUp.Text = "SetUp";
            this.button_SetUp.UseVisualStyleBackColor = false;
            this.button_SetUp.Click += new System.EventHandler(this.button_SetUp_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(713, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 30);
            this.label9.TabIndex = 113;
            this.label9.Text = "Max";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(608, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 30);
            this.label10.TabIndex = 112;
            this.label10.Text = "Dec";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(33, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 111;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(503, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 30);
            this.label8.TabIndex = 110;
            this.label8.Text = "Acc";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(398, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 109;
            this.label7.Text = "StartSpeed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(818, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 108;
            this.label6.Text = "Emergency";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(293, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 107;
            this.label5.Text = "Alarm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(188, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 30);
            this.label4.TabIndex = 106;
            this.label4.Text = "Servo_On";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(83, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 105;
            this.label3.Text = "UnitPerPulse";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.TabIndex = 104;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(767, 362);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(156, 58);
            this.btn_close.TabIndex = 151;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(53, 99);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(165, 29);
            this.button_Open.TabIndex = 152;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            // 
            // MotionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 481);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.comboBox_Emergency);
            this.Controls.Add(this.comboBox_YAlarm);
            this.Controls.Add(this.comboBox_XAlarm);
            this.Controls.Add(this.comboBox_YServo);
            this.Controls.Add(this.comboBox_XServo);
            this.Controls.Add(this.textBox_YMax);
            this.Controls.Add(this.textBox_XMax);
            this.Controls.Add(this.textBox_YDec);
            this.Controls.Add(this.textBox_XDec);
            this.Controls.Add(this.textBox_YAcc);
            this.Controls.Add(this.textBox_XAcc);
            this.Controls.Add(this.textBox_YStartSpeed);
            this.Controls.Add(this.textBox_XStartSpeed);
            this.Controls.Add(this.textBox_YRatio);
            this.Controls.Add(this.textBox_XRatio);
            this.Controls.Add(this.button_SetUp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MotionControl";
            this.Text = "MotionControl";
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
        private System.Windows.Forms.Button button_Open;
    }
}