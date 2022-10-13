using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace DDF
{
    public partial class MotionControl : Form
    {
        public string[] NMCDesc = {
                                "NMC2_220S"
                                ,"NMC2_420S"
                                ,"NMC2_620S"
                                ,"NMC2_820S"
                                ,"NMC2_220_DIO32"
                                ,"NMC2_220_DIO64"
                                ,"NMC2_420_DIO32"
                                ,"NMC2_420_DIO64"
                                ,"NMC2_820_DIO32"
                                ,"NMC2_820_DIO64"
                                ,"NMC2_DIO32"
                                ,"NMC2_DIO64"
                                ,"NMC2_DIO96"
                                ,"NMC2_DIO128"
                                ,"NMC2_220"
                                ,"NMC2_420"
                                ,"NMC2_620"
                                ,"NMC2_820"
                                ,"NMC2_620_DIO32"
                                ,"NMC2_620_DIO64"
                                ,null
                                };

        PaixMotion PaixMotion;
        Thread TdWatchSensor;

        DDF.NMC2.NMCAXESEXPR NmcData = new DDF.NMC2.NMCAXESEXPR();

        public MotionControl()
        {
            InitializeComponent();
            PaixMotion = new PaixMotion();
            //TdWatchSensor = new Thread(new ThreadStart(watchSensor));

            //physicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
            //if (physicalChannelComboBox.Items.Count > 0)
            //    physicalChannelComboBox.SelectedIndex = 0;
        }


        public void textBox_XRatio_TextChanged(object sender, EventArgs e)
        {
            DDF_Form.xRatioChange = Convert.ToDouble(textBox_XRatio.Text);
            Console.WriteLine("복사완료");
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

        private void DDF_Form_Load(object sender, EventArgs e)
        {
            DDF_Form DDF = new DDF_Form();
            XsetupEventHandler += new EventHandler(DDF.XinitialChanged);
            YsetupEventHandler += new EventHandler(DDF.YinitialChanged);
        }
        public void button_XSetUp_Click(object sender, EventArgs e)
        {
            DDF_Form.dxstart = Convert.ToDouble(textBox_XStartSpeed.Text);
            DDF_Form.dxacc = Convert.ToDouble(textBox_XAcc.Text);
            DDF_Form.dxmax = Convert.ToDouble(textBox_XMax.Text);
            DDF_Form.dxdec = Convert.ToDouble(textBox_XDec.Text);

            Console.WriteLine("값 입력 완료" + DDF_Form.dxstart); // 복사되는 것 까지 확인완료
            
            XsetupEventHandler.Invoke(null, EventArgs.Empty);


            Console.WriteLine("메인 폼으로 복사완료");

            xsuConfirm xsu = new xsuConfirm();
            xsu.StartPosition = FormStartPosition.CenterScreen;
            xsu.Show();
        }

        public void button_YSetUp_Click(object sender, EventArgs e)
        {
            DDF_Form.dystart = Convert.ToDouble(textBox_YStartSpeed.Text);
            DDF_Form.dyacc = Convert.ToDouble(textBox_YAcc.Text);
            DDF_Form.dymax = Convert.ToDouble(textBox_YMax.Text);
            DDF_Form.dydec = Convert.ToDouble(textBox_YDec.Text);

            YsetupEventHandler.Invoke(null, EventArgs.Empty);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Console.WriteLine("Motion Control 팝업 종료");
        }
    }
}
