using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDF
{
    public partial class MotionControl : Form
    {
        public MotionControl()
        {
            InitializeComponent();
        }

        PaixMotion PaixMotion;

        public void textBox_XRatio_TextChanged(object sender, EventArgs e)
        {
            DDF_Form.xRatioChange = Convert.ToDouble(textBox_XRatio.Text);
        }

        public void textBox_YRatio_TextChanged(object sender, EventArgs e)
        {
            DDF_Form.yRatioChange = Convert.ToDouble(textBox_YRatio.Text);
           // PaixMotion.SetUnitPulse(1, Convert.ToDouble(textBox_YRatio.Text));
        }

        public void comboBox_XServo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.ServoOn(0, comboBox_XServo.SelectedIndex);
        }

        public void comboBox_YServo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.ServoOn(1, comboBox_YServo.SelectedIndex);
        }

        public void comboBox_XAlarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.SetAlarmLogic(0, comboBox_XAlarm.SelectedIndex == 0 ? (short)0 : (short)1);
        }

        public void comboBox_YAlarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.SetAlarmLogic(1, comboBox_YAlarm.SelectedIndex == 0 ? (short)0 : (short)1);
        }

        public void comboBox_Emergency_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.SetEmerLogic(comboBox_Emergency.SelectedIndex == 0 ? (short)0 : (short)1);
        }

        public EventHandler XsetupEventHandler;
        public EventHandler YsetupEventHandler;
        public void button_XSetUp_Click(object sender, EventArgs e)
        {
            DDF_Form.dxstart = Convert.ToDouble(textBox_XStartSpeed.Text);
            DDF_Form.dxacc = Convert.ToDouble(textBox_XAcc.Text);
            DDF_Form.dxmax = Convert.ToDouble(textBox_XMax.Text);
            DDF_Form.dxdec = Convert.ToDouble(textBox_XDec.Text);

            DDF_Form DDF = new DDF_Form();
            XsetupEventHandler += new EventHandler(DDF.XinitialChanged);
        }

        public void button_YSetUp_Click(object sender, EventArgs e)
        {
            DDF_Form.dystart = Convert.ToDouble(textBox_YStartSpeed.Text);
            DDF_Form.dyacc = Convert.ToDouble(textBox_YAcc.Text);
            DDF_Form.dymax = Convert.ToDouble(textBox_YMax.Text);
            DDF_Form.dydec = Convert.ToDouble(textBox_YDec.Text);

            DDF_Form DDF = new DDF_Form();
            YsetupEventHandler += new EventHandler(DDF.YinitialChanged);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
