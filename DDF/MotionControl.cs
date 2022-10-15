﻿using System;
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
        DDF_Form ddF;
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

        DDF.NMC2.NMCAXESEXPR NmcData = new DDF.NMC2.NMCAXESEXPR();
        
        public MotionControl(DDF_Form _DDF)
        {
            InitializeComponent();
            PaixMotion = new PaixMotion();
            ddF = _DDF;
        }

        public void button_SetUp_Click(object sender, EventArgs e)
        { 
            DDF_Form.xRatioChange = Convert.ToDouble(textBox_XRatio.Text);
            DDF_Form.dxstart = Convert.ToDouble(textBox_XStartSpeed.Text);
            DDF_Form.dxacc = Convert.ToDouble(textBox_XAcc.Text);
            DDF_Form.dxmax = Convert.ToDouble(textBox_XMax.Text);
            DDF_Form.dxdec = Convert.ToDouble(textBox_XDec.Text);
            DDF_Form.xservo = Convert.ToInt32(comboBox_XServo.SelectedIndex);
            DDF_Form.xalarm = Convert.ToDouble(comboBox_XAlarm.SelectedIndex);

            DDF_Form.yRatioChange = Convert.ToDouble(textBox_YRatio.Text);
            DDF_Form.dystart = Convert.ToDouble(textBox_YStartSpeed.Text);
            DDF_Form.dyacc = Convert.ToDouble(textBox_YAcc.Text);
            DDF_Form.dymax = Convert.ToDouble(textBox_YMax.Text);
            DDF_Form.dydec = Convert.ToDouble(textBox_YDec.Text);
            DDF_Form.yservo = Convert.ToInt32(comboBox_YServo.SelectedIndex);
            DDF_Form.yalarm = Convert.ToDouble(comboBox_YAlarm.SelectedIndex);

            DDF_Form.emer = Convert.ToDouble(comboBox_Emergency.SelectedIndex);

            ddF.initialChanged();

            //Console.WriteLine("값 입력 완료" + DDF_Form.xRatioChange + DDF_Form.dxstart); // 복사되는 것 까지 확인완료
            //Console.WriteLine("메인 폼으로 복사완료");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Console.WriteLine("Motion Control 팝업 종료");
        }
    }
}
