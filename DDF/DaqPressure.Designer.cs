
namespace DDF
{
    partial class DaqPressure
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
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_currentPressure = new System.Windows.Forms.Label();
            this.lbl_CheckValve = new System.Windows.Forms.Label();
            this.lbl_Piston = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.waveformGraph2 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.lbl_checkvlave2 = new System.Windows.Forms.Label();
            this.lbl_piston2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Analogin = new System.Windows.Forms.Button();
            this.btn_Analogout = new System.Windows.Forms.Button();
            this.txt_AnalogOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).BeginInit();
            this.SuspendLayout();
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(27, 68);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(368, 190);
            this.waveformGraph1.TabIndex = 0;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 21);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_currentPressure
            // 
            this.lbl_currentPressure.AutoSize = true;
            this.lbl_currentPressure.Location = new System.Drawing.Point(567, 333);
            this.lbl_currentPressure.Name = "lbl_currentPressure";
            this.lbl_currentPressure.Size = new System.Drawing.Size(57, 12);
            this.lbl_currentPressure.TabIndex = 2;
            this.lbl_currentPressure.Text = "현재 압력";
            // 
            // lbl_CheckValve
            // 
            this.lbl_CheckValve.AutoSize = true;
            this.lbl_CheckValve.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_CheckValve.Location = new System.Drawing.Point(436, 360);
            this.lbl_CheckValve.Name = "lbl_CheckValve";
            this.lbl_CheckValve.Size = new System.Drawing.Size(82, 15);
            this.lbl_CheckValve.TabIndex = 3;
            this.lbl_CheckValve.Text = "체크밸브부";
            // 
            // lbl_Piston
            // 
            this.lbl_Piston.AutoSize = true;
            this.lbl_Piston.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Piston.Location = new System.Drawing.Point(451, 396);
            this.lbl_Piston.Name = "lbl_Piston";
            this.lbl_Piston.Size = new System.Drawing.Size(67, 15);
            this.lbl_Piston.TabIndex = 4;
            this.lbl_Piston.Text = "피스톤부";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(535, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 21);
            this.textBox2.TabIndex = 5;
            // 
            // waveformGraph2
            // 
            this.waveformGraph2.Location = new System.Drawing.Point(408, 68);
            this.waveformGraph2.Name = "waveformGraph2";
            this.waveformGraph2.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.waveformGraph2.Size = new System.Drawing.Size(368, 190);
            this.waveformGraph2.TabIndex = 6;
            this.waveformGraph2.UseColorGenerator = true;
            this.waveformGraph2.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.waveformGraph2.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.XAxis = this.xAxis2;
            this.waveformPlot2.YAxis = this.yAxis2;
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.Font = new System.Drawing.Font("나눔고딕", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_pc.Location = new System.Drawing.Point(12, 9);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(219, 31);
            this.lbl_pc.TabIndex = 7;
            this.lbl_pc.Text = "Pressure Control";
            // 
            // lbl_checkvlave2
            // 
            this.lbl_checkvlave2.AutoSize = true;
            this.lbl_checkvlave2.Location = new System.Drawing.Point(171, 265);
            this.lbl_checkvlave2.Name = "lbl_checkvlave2";
            this.lbl_checkvlave2.Size = new System.Drawing.Size(72, 12);
            this.lbl_checkvlave2.TabIndex = 8;
            this.lbl_checkvlave2.Text = "CheckValve";
            // 
            // lbl_piston2
            // 
            this.lbl_piston2.AutoSize = true;
            this.lbl_piston2.Location = new System.Drawing.Point(586, 265);
            this.lbl_piston2.Name = "lbl_piston2";
            this.lbl_piston2.Size = new System.Drawing.Size(40, 12);
            this.lbl_piston2.TabIndex = 9;
            this.lbl_piston2.Text = "Piston";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(673, 357);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(89, 57);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Analogin
            // 
            this.btn_Analogin.Location = new System.Drawing.Point(106, 351);
            this.btn_Analogin.Name = "btn_Analogin";
            this.btn_Analogin.Size = new System.Drawing.Size(75, 23);
            this.btn_Analogin.TabIndex = 11;
            this.btn_Analogin.Text = "AnalogIn";
            this.btn_Analogin.UseVisualStyleBackColor = true;
            this.btn_Analogin.Click += new System.EventHandler(this.btn_Analogin_Click);
            // 
            // btn_Analogout
            // 
            this.btn_Analogout.Location = new System.Drawing.Point(106, 322);
            this.btn_Analogout.Name = "btn_Analogout";
            this.btn_Analogout.Size = new System.Drawing.Size(75, 23);
            this.btn_Analogout.TabIndex = 12;
            this.btn_Analogout.Text = "AnalogOut";
            this.btn_Analogout.UseVisualStyleBackColor = true;
            this.btn_Analogout.Click += new System.EventHandler(this.btn_Analogout_Click);
            // 
            // txt_AnalogOut
            // 
            this.txt_AnalogOut.Location = new System.Drawing.Point(205, 322);
            this.txt_AnalogOut.Name = "txt_AnalogOut";
            this.txt_AnalogOut.Size = new System.Drawing.Size(100, 21);
            this.txt_AnalogOut.TabIndex = 13;
            // 
            // DaqPressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_AnalogOut);
            this.Controls.Add(this.btn_Analogout);
            this.Controls.Add(this.btn_Analogin);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_piston2);
            this.Controls.Add(this.lbl_checkvlave2);
            this.Controls.Add(this.lbl_pc);
            this.Controls.Add(this.waveformGraph2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_Piston);
            this.Controls.Add(this.lbl_CheckValve);
            this.Controls.Add(this.lbl_currentPressure);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.waveformGraph1);
            this.Name = "DaqPressure";
            this.Text = "DaqPressure";
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_currentPressure;
        private System.Windows.Forms.Label lbl_CheckValve;
        private System.Windows.Forms.Label lbl_Piston;
        private System.Windows.Forms.TextBox textBox2;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph2;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.Label lbl_checkvlave2;
        private System.Windows.Forms.Label lbl_piston2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Analogin;
        private System.Windows.Forms.Button btn_Analogout;
        private System.Windows.Forms.TextBox txt_AnalogOut;
    }
}