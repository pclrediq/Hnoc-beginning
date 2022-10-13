using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace DDF // 전체가 여기 안에 다 있음
{
    public partial class DDF_Form : Form
    {
        // 각종 변수 선언
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
        SerialPort serialport = new SerialPort();
        CRCTable CRCcal = new CRCTable();

        public static byte[] Sendbuff = new byte[10];
        public static byte[] Readbuff = new byte[10];
        static long value = 0;
        static long value_hi = 0;
        static long value_low = 0;
        static byte[] Data = new byte[2];

        public bool flag_ch1_set = false;
        public bool flag_ch2_set = false;
        public bool flag_ch3_set = false;
        public bool flag_ch4_set = false;
        public bool flag_disconnect = false;

        public int ch1_goal_value;
        public int ch2_goal_value;
        public int ch3_goal_value;
        public int ch4_goal_value;

        PaixMotion PaixMotion;
        Thread TdWatchSensor;
        Thread TdTempControl;

        DDF.NMC2.NMCAXESEXPR NmcData = new DDF.NMC2.NMCAXESEXPR(); // 모션 제어 라이브러리(8축의 현재 센서입력 상태, 위치값, 보간 정보 등을 확인하는 구조체)
        public DDF_Form() // Motion, Watch, Temp 스레드 선언
        {
            InitializeComponent();

            PaixMotion = new PaixMotion();
            TdWatchSensor = new Thread(new ThreadStart(watchSensor));
            TdTempControl = new Thread(new ThreadStart(tempControl));

            physicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
            if (physicalChannelComboBox.Items.Count > 0)
                physicalChannelComboBox.SelectedIndex = 0;
        }
        public void tempControl() // try catch문으로 오류 잡기?ㅋㅋㅋ
        {
            Console.WriteLine("bye");
            try
            {
                while (true)
                {
                    Console.WriteLine("위잉위잉");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(TdTempControl.ThreadState);
                    this.Invoke(new delegateUpdateTmpCtrl(updateTempCtrl));
                    
                }
            }
            catch (ThreadInterruptedException e) { e.ToString(); Console.WriteLine("catch"); }
            finally { Console.WriteLine("finally."); }
        }
        private void updateTempCtrl() // 온도 컨트롤
        {
            ///////////////////////////////////////////
            //               채널 1 루틴
            ///////////////////////////////////////////
            //                현재 온도
            ///////////////////////////////////////////

            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x04;
            Sendbuff[2] = 0x03;
            Sendbuff[3] = 0xE8;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0xB1;
            Sendbuff[7] = 0xBA;

            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);
            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x04 && Readbuff[2] == 0x02) // 수신 데이터가 정상일 경우
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /*textBox1.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                    Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/                            //오류 없는 지 확인한 코드일듯

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;                           // 계산한 온도 값
                textBox_Ch1_Current.Text = value + "'C";                // main form 화면의 Ch1_Current 텍스트에 출력
            }
            else // 수신 데이터의 오류 발생시
            {
                textBox_Ch1_Current.Text = "err";
                serialport.DiscardInBuffer();
            }

            ///////////////////////////////////////////
            //              Ch1 목표 온도
            ///////////////////////////////////////////
            
            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x03;
            Sendbuff[2] = 0x00;
            Sendbuff[3] = 0x00;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0x84;
            Sendbuff[7] = 0x0A;
            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);

            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x03)
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /* textBox2.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                     Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;                                   // 목표온도값 계산
                textBox_Ch1_Setted.Text = value + "'C";                         // 목표온도값 출력
            }
            else
            {
                textBox_Ch1_Setted.Text = "err";
                serialport.DiscardInBuffer();
            }



            ///////////////////////////////////////////
            //               채널 2 루틴
            ///////////////////////////////////////////
            //                현재 온도
            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x04;
            Sendbuff[2] = 0x03;
            Sendbuff[3] = 0xEE;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0x51;
            Sendbuff[7] = 0xBB;

            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);

            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x04 && Readbuff[2] == 0x02)
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /*                textBox13.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                                    Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;
                textBox_Ch2_Current.Text = value + "'C";
            }
            else
            {
                textBox_Ch2_Current.Text = "err";
                serialport.DiscardInBuffer();
            }

            ///////////////////////////////////////////
            //                목표 온도
            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x03;
            Sendbuff[2] = 0x03;
            Sendbuff[3] = 0xE8;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0x04;
            Sendbuff[7] = 0x7A;

            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);

            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x03)
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /*textBox5.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                    Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;
                textBox_Ch2_Setted.Text = value + "'C";
            }
            else
            {
                textBox_Ch2_Setted.Text = "err";
                serialport.DiscardInBuffer();
            }



            ///////////////////////////////////////////
            //               채널 3 루틴
            ///////////////////////////////////////////
            //                현재 온도
            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x04;
            Sendbuff[2] = 0x03;
            Sendbuff[3] = 0xF4;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0x70;
            Sendbuff[7] = 0x7C;

            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);

            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x04 && Readbuff[2] == 0x02)
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /*textBox6.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                    Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;
                textBox_Ch3_Current.Text = value + "'C";
            }
            else
            {
                textBox_Ch3_Current.Text = "err";
                serialport.DiscardInBuffer();
            }

            ///////////////////////////////////////////
            //                목표 온도
            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x03;
            Sendbuff[2] = 0x07;
            Sendbuff[3] = 0xD0;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0x84;
            Sendbuff[7] = 0x87;

            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);

            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x03)
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /*  textBox8.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                      Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;
                textBox_Ch3_Setted.Text = value + "'C";
            }
            else
            {
                textBox_Ch3_Setted.Text = "err";
                serialport.DiscardInBuffer();
            }


            ///////////////////////////////////////////
            //               채널 4 루틴
            ///////////////////////////////////////////
            //                현재 온도
            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x04;
            Sendbuff[2] = 0x03;
            Sendbuff[3] = 0xFA;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0x11;
            Sendbuff[7] = 0xBF;

            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);

            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x04 && Readbuff[2] == 0x02)
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /* textBox9.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                     Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;
                textBox_Ch4_Current.Text = value + "'C";
            }
            else
            {
                textBox_Ch4_Current.Text = "err";
                serialport.DiscardInBuffer();
            }

            ///////////////////////////////////////////
            //                목표 온도
            Sendbuff[0] = 0x01;
            Sendbuff[1] = 0x03;
            Sendbuff[2] = 0x0B;
            Sendbuff[3] = 0xB8;
            Sendbuff[4] = 0x00;
            Sendbuff[5] = 0x01;
            Sendbuff[6] = 0x06;
            Sendbuff[7] = 0x0B;

            fn_Send(Sendbuff, 0, 8);
            Thread.Sleep(20);

            Readbuff[0] = Convert.ToByte(serialport.ReadByte());
            Readbuff[1] = Convert.ToByte(serialport.ReadByte());
            Readbuff[2] = Convert.ToByte(serialport.ReadByte());

            if (Readbuff[0] == 0x01 && Readbuff[1] == 0x03)
            {
                Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                Readbuff[6] = Convert.ToByte(serialport.ReadByte());

                /*textBox11.Text = Convert.ToString(Readbuff[0]) + " " + Convert.ToString(Readbuff[1]) + " " + Convert.ToString(Readbuff[2]) + " " +
                    Convert.ToString(Readbuff[3]) + " " + Convert.ToString(Readbuff[4]) + " " + Convert.ToString(Readbuff[5]);*/

                Data[0] = Readbuff[3]; // 256의 자리
                Data[1] = Readbuff[4]; // 1~255의 자리
                value_hi = Data[0] * 256;
                value_low = Data[1];
                value = value_hi + value_low;
                textBox_Ch4_Setted.Text = value + "'C";
            }
            else
            {
                textBox_Ch4_Setted.Text = "err";
                serialport.DiscardInBuffer();
            }


            ///////////////////////////////////////////
            //               플래그 처리
            ///////////////////////////////////////////
            //               채널 1 처리
            ///////////////////////////////////////////
            
            if (flag_ch1_set == true)       // flag 값이 초기값(false)에서 목표값을 설정(클릭)한 뒤 true가 되었을때
            {
                ch1_goal_value = int.Parse(textBox_Ch1_Goal.Text);
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x00;
                Sendbuff[3] = 0x34;
                Sendbuff[4] = Convert.ToByte(ch1_goal_value / 256);
                Sendbuff[5] = Convert.ToByte(ch1_goal_value % 256);
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                Readbuff[0] = Convert.ToByte(serialport.ReadByte());
                Readbuff[1] = Convert.ToByte(serialport.ReadByte());
                Readbuff[2] = Convert.ToByte(serialport.ReadByte());
                if (Readbuff[0] == 0x01 && Readbuff[1] == 0x06)                 // 정상적으로 값을 처리
                {
                    Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[6] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[7] = Convert.ToByte(serialport.ReadByte());

                    flag_ch1_set = false;       // 원래 초기값으로 변경 (차후 목표값 다시 설정가능하기 위해)
                }
                else                                                            // 그 외 경우
                {
                    serialport.DiscardInBuffer();
                    flag_ch1_set = false;       // 원래 초기값으로 변경 (차후 목표값 다시 설정가능하기 위해)
                }
            }

            ///////////////////////////////////////////
            //               채널 2 처리
            if (flag_ch2_set == true)
            {
                ch2_goal_value = int.Parse(textBox_Ch2_Goal.Text);
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x04;
                Sendbuff[3] = 0x1C;
                Sendbuff[4] = Convert.ToByte(ch2_goal_value / 256);
                Sendbuff[5] = Convert.ToByte(ch2_goal_value % 256);
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                Readbuff[0] = Convert.ToByte(serialport.ReadByte());
                Readbuff[1] = Convert.ToByte(serialport.ReadByte());
                Readbuff[2] = Convert.ToByte(serialport.ReadByte());
                if (Readbuff[0] == 0x01 && Readbuff[1] == 0x06)
                {
                    Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[6] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[7] = Convert.ToByte(serialport.ReadByte());

                    flag_ch2_set = false;
                }
                else
                {
                    serialport.DiscardInBuffer();
                    flag_ch2_set = false;
                }
            }

            ///////////////////////////////////////////
            //               채널 3 처리
            if (flag_ch3_set == true)
            {
                ch3_goal_value = int.Parse(textBox_Ch3_Goal.Text);
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x08;
                Sendbuff[3] = 0x04;
                Sendbuff[4] = Convert.ToByte(ch3_goal_value / 256);
                Sendbuff[5] = Convert.ToByte(ch3_goal_value % 256);
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                Readbuff[0] = Convert.ToByte(serialport.ReadByte());
                Readbuff[1] = Convert.ToByte(serialport.ReadByte());
                Readbuff[2] = Convert.ToByte(serialport.ReadByte());
                if (Readbuff[0] == 0x01 && Readbuff[1] == 0x06)
                {
                    Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[6] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[7] = Convert.ToByte(serialport.ReadByte());

                    flag_ch3_set = false;
                }
                else
                {
                    serialport.DiscardInBuffer();
                    flag_ch3_set = false;
                }
            }

            ///////////////////////////////////////////
            //               채널 4 처리
            if (flag_ch4_set == true)
            {
                ch4_goal_value = int.Parse(textBox_Ch4_Goal.Text);
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x0B;
                Sendbuff[3] = 0xEC;
                Sendbuff[4] = Convert.ToByte(ch4_goal_value / 256);
                Sendbuff[5] = Convert.ToByte(ch4_goal_value % 256);
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                Readbuff[0] = Convert.ToByte(serialport.ReadByte());
                Readbuff[1] = Convert.ToByte(serialport.ReadByte());
                Readbuff[2] = Convert.ToByte(serialport.ReadByte());
                if (Readbuff[0] == 0x01 && Readbuff[1] == 0x06)
                {
                    Readbuff[3] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[4] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[5] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[6] = Convert.ToByte(serialport.ReadByte());
                    Readbuff[7] = Convert.ToByte(serialport.ReadByte());

                    flag_ch4_set = false;
                }
                else
                {
                    serialport.DiscardInBuffer();
                    flag_ch4_set = false;
                }
            }

            if (flag_disconnect == true)
            {
                ///////////////////////////////////////////
                //               채널 1 리셋
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x00;
                Sendbuff[3] = 0x34;
                Sendbuff[4] = 0x00;
                Sendbuff[5] = 0x00;
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                serialport.DiscardInBuffer();

                ///////////////////////////////////////////
                //               채널 2 리셋
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x04;
                Sendbuff[3] = 0x1C;
                Sendbuff[4] = 0x00;
                Sendbuff[5] = 0x00;
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                serialport.DiscardInBuffer();

                ///////////////////////////////////////////
                //               채널 3 리셋
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x08;
                Sendbuff[3] = 0x04;
                Sendbuff[4] = 0x00;
                Sendbuff[5] = 0x00;
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                serialport.DiscardInBuffer();

                ///////////////////////////////////////////
                //               채널 4 리셋
                Sendbuff[0] = 0x01;
                Sendbuff[1] = 0x06;
                Sendbuff[2] = 0x0B;
                Sendbuff[3] = 0xEC;
                Sendbuff[4] = 0x00;
                Sendbuff[5] = 0x00;
                Sendbuff[6] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[0];
                Sendbuff[7] = CRCcal.fn_makeCRC16_byte(Sendbuff, 6)[1];

                fn_Send(Sendbuff, 0, 8);
                Thread.Sleep(20);

                serialport.DiscardInBuffer();


                //sequence.Dispose();

                flag_disconnect = false;
            }
        }

        private delegate void delegateUpdateTmpCtrl();
        public void watchSensor()   // limitsensor 일 듯
        {
            //PaixMotion.NMC2.NMC_AXES_EXPR NmcData;
            try
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(10);
                    this.Invoke(new delegateUpdateCmdEnc(updateCmdEnc));
                    Console.WriteLine("threading!.");
                }
            }
            catch (ThreadInterruptedException ex) { ex.ToString(); }
            finally { Console.WriteLine("finally."); }
        }

        private delegate void delegateUpdateCmdEnc();
        private void updateCmdEnc() // motion controller(Paix)
        {
            if (PaixMotion.GetNmcStatus(ref NmcData) == false)
                return;

            label_XCmdVal.Text = NmcData.dCmd[0].ToString();
            label_YCmdVal.Text = NmcData.dCmd[1].ToString();

            label_XEncVal.Text = NmcData.dEnc[0].ToString();
            label_YEncVal.Text = NmcData.dEnc[1].ToString();

            panel_Emergency.BackColor = NmcData.nEmer[0] == 1 ? Color.Red : Color.DarkGray;
            panel_XBusy.BackColor = NmcData.nBusy[0] == 1 ? Color.Red : Color.DarkGray;
            panel_YBusy.BackColor = NmcData.nBusy[1] == 1 ? Color.Red : Color.DarkGray;

            panel_XNear.BackColor = NmcData.nNear[0] == 1 ? Color.Red : Color.DarkGray;
            panel_YNear.BackColor = NmcData.nNear[1] == 1 ? Color.Red : Color.DarkGray;

            panel_XMinusLimit.BackColor = NmcData.nMLimit[0] == 1 ? Color.Red : Color.DarkGray;
            panel_YMinusLimit.BackColor = NmcData.nMLimit[1] == 1 ? Color.Red : Color.DarkGray;

            panel_XPlusLimit.BackColor = NmcData.nPLimit[0] == 1 ? Color.Red : Color.DarkGray;
            panel_YPlusLimit.BackColor = NmcData.nPLimit[1] == 1 ? Color.Red : Color.DarkGray;

            panel_XAlarm.BackColor = NmcData.nAlarm[0] == 1 ? Color.Red : Color.DarkGray;
            panel_YAlarm.BackColor = NmcData.nAlarm[1] == 1 ? Color.Red : Color.DarkGray;


            panel_XEncZ.BackColor = NmcData.nEncZ[0] == 1 ? Color.Red : Color.DarkGray;
            panel_YEncZ.BackColor = NmcData.nEncZ[1] == 1 ? Color.Red : Color.DarkGray;
        }
        private void stop(short nAxis)
        {
            PaixMotion.Stop(nAxis);
        }
 
        public static double xRatioChange;
        public static double yRatioChange;
        public static double dxstart;
        public static double dxacc;
        public static double dxmax;
        public static double dxdec;
        public static double dystart;
        public static double dyacc;
        public static double dymax;
        public static double dydec;

        public void initialize(object sender, EventArgs e)
        {
            PaixMotion.SetUnitPulse(0, 0.0000179);
            PaixMotion.SetUnitPulse(1, 0.0000358);
            PaixMotion.SetSpeedPPS(0, 1, 6.728, 6.728, 10.417);
            PaixMotion.SetHomeSpeed(0, 10.417, 3.689, -3.091);
            PaixMotion.SetSpeedPPS(1, 1, 10.445, 10.445, 16.667);
            PaixMotion.SetHomeSpeed(1, 16.667, 6.222, -4.223);
        }

        public void XinitialChanged(object sender, EventArgs e)
        {
            PaixMotion.SetSpeedPPS(0, dxstart, dxacc, dxdec, dxmax);
            PaixMotion.SetHomeSpeed(0, dxmax, dxmax - dxdec, dxmax - dxdec * 2);
            MessageBox.Show("X SetUp Complete.");
        }

        public void YinitialChanged(object sender, EventArgs e)
        {
            PaixMotion.SetSpeedPPS(0, dystart, dyacc, dydec, dymax);
            PaixMotion.SetHomeSpeed(0, dymax, dymax - dydec, dymax - dydec * 2);
            MessageBox.Show("Y SetUp Complete.");
        }
        
        public void textBox_XRatio_TextChanged(object sender, EventArgs e)
        {
            PaixMotion.SetUnitPulse(0, xRatioChange);
        }

        private void textBox_YRatio_TextChanged(object sender, EventArgs e)
        {
            PaixMotion.SetUnitPulse(1, yRatioChange);
        }

        /*
        private void comboBox_XServo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.ServoOn(0, comboBox_XServo.SelectedIndex);
        }

        private void comboBox_YServo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.ServoOn(1, comboBox_YServo.SelectedIndex);
        }

        private void comboBox_XAlarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.SetAlarmLogic(0, comboBox_XAlarm.SelectedIndex == 0 ? (short)0 : (short)1);
        }

        private void comboBox_YAlarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.SetAlarmLogic(1, comboBox_YAlarm.SelectedIndex == 0 ? (short)0 : (short)1);
        }

        private void comboBox_Emergency_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaixMotion.SetEmerLogic(comboBox_Emergency.SelectedIndex == 0 ? (short)0 : (short)1);
        }

        private void button_XSetUp_Click(object sender, EventArgs e)
        {
            double dstart = Convert.ToDouble(textBox_XStartSpeed.Text);
            double dacc = Convert.ToDouble(textBox_XAcc.Text);
            double dmax = Convert.ToDouble(textBox_XMax.Text);
            double ddec = Convert.ToDouble(textBox_XDec.Text);

            PaixMotion.SetSpeedPPS(0, dstart, dacc, ddec, dmax);
            PaixMotion.SetHomeSpeed(0, dmax, dmax - ddec, dmax - ddec * 2);

            xsuConfirm xsu = new xsuConfirm();
            xsu.StartPosition = FormStartPosition.CenterScreen;
            xsu.Show();
        }

        private void button_YSetUp_Click(object sender, EventArgs e)
        {
            double dstart = Convert.ToDouble(textBox_YStartSpeed.Text);
            double dacc = Convert.ToDouble(textBox_YAcc.Text);
            double dmax = Convert.ToDouble(textBox_YMax.Text);
            double ddec = Convert.ToDouble(textBox_YDec.Text);

            PaixMotion.SetSpeedPPS(1, dstart, dacc, ddec, dmax);

            ysuConfirm ysu = new ysuConfirm();
            ysu.StartPosition = FormStartPosition.CenterScreen;
            ysu.Show();
        }
        */
        private void button_XJogLeft_MouseDown(object sender, MouseEventArgs e)
        {
            PaixMotion.JogMove(0, 0);
            if (panel_XPlusLimit.BackColor == Color.Red)
            {
                stop(0);
            }
        }

        private void button_XJogLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (!checkBox_JogCount.Checked)
            {
                stop(0);
            }
            else if (panel_XPlusLimit.BackColor == Color.Red)
            {
                stop(0);
            }
        }

        private void button_XJogRight_MouseDown(object sender, MouseEventArgs e)
        {
            PaixMotion.JogMove(0, 1);
            if (panel_XMinusLimit.BackColor == Color.Red)
            {
                stop(0);
            }
        }

        private void button_XJogRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (!checkBox_JogCount.Checked)
            {
                stop(0);
            }
            else if (panel_XMinusLimit.BackColor == Color.Red)
            {
                stop(0);
            }
        }

        private void button_YJogLeft_MouseDown(object sender, MouseEventArgs e)
        {
            PaixMotion.JogMove(1, 0);
        }

        private void button_YJogLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (!checkBox_JogCount.Checked)
            {
                stop(1);
            }
        }

        private void button_YJogRight_MouseDown(object sender, MouseEventArgs e)
        {
            PaixMotion.JogMove(1, 1);
        }

        private void button_YJogRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (!checkBox_JogCount.Checked)
            {
                stop(1);
            }
        }

        private void button_XStop_Click(object sender, EventArgs e)
        {
            stop(0);
        }

        private void button_YStop_Click(object sender, EventArgs e)
        {
            stop(1);
        }

        private void button_XHome_Click(object sender, EventArgs e)
        {
            PaixMotion.HomeMove(0, 1);
        }

        private void label_XCmdVal_Click(object sender, EventArgs e)
        {
            PaixMotion.SetCmd(0, 0);
        }

        private void label_YCmdVal_Click(object sender, EventArgs e)
        {
            PaixMotion.SetCmd(1, 0);
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            short devId = Convert.ToInt16(textBox_DevNo.Text);

            if (button_Open.Text == "Open" && PaixMotion.Open(devId))
            {
                switch (TdWatchSensor.ThreadState)
                {
                    case ThreadState.Stopped:
                        TdWatchSensor = new Thread(new ThreadStart(watchSensor));
                        break;
                    case ThreadState.Unstarted:
                        break;
                    default:
                        TdWatchSensor.Abort();
                        while (TdWatchSensor.ThreadState != ThreadState.Stopped) { }
                        break;
                }

                TdWatchSensor.Start();
                button_Open.Text = "Close";
            }
            else if (button_Open.Text == "Close" && PaixMotion.Close())
            {
                TdWatchSensor.Interrupt();
                TdWatchSensor.Join();

                while (TdWatchSensor.ThreadState != ThreadState.Stopped) { }

                button_Open.Text = "Open";
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("커넥트 외부");
            if (!serialport.IsOpen)
            {
                serialport.PortName = "COM3";
                serialport.BaudRate = 9600;
                serialport.DataBits = 8;
                serialport.StopBits = StopBits.One;
                serialport.Parity = Parity.None;
                serialport.DataReceived += new SerialDataReceivedEventHandler(serialport_DataReceived);

                serialport.Open();
                serialport.DiscardInBuffer();
                Console.WriteLine("커넥트 내부");
                //SetTimer();
                switch (TdTempControl.ThreadState)
                {
                    case ThreadState.Stopped:
                        TdTempControl = new Thread(new ThreadStart(tempControl));
                        break;
                    case ThreadState.Unstarted:
                        break;
                    default:
                        TdTempControl.Abort();
                        while (TdTempControl.ThreadState != ThreadState.Stopped) { }
                        break;
                }
                TdTempControl.Start();

                Console.WriteLine(TdTempControl.ThreadState);
                Console.WriteLine(serialport.IsOpen);

                button_Connect.Enabled = false;
                button_Disconnect.Enabled = true;
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            flag_disconnect = true;
            button_Disconnect.Enabled = false;
            textBox_Ch1_Current.Text = "";
            textBox_Ch2_Current.Text = "";
            textBox_Ch3_Current.Text = "";
            textBox_Ch4_Current.Text = "";
            textBox_Ch1_Setted.Text = "";
            textBox_Ch2_Setted.Text = "";
            textBox_Ch3_Setted.Text = "";
            textBox_Ch4_Setted.Text = "";
            // 수정 필요
            TdTempControl.Interrupt();
            TdTempControl.Join();
            while (TdTempControl.ThreadState != ThreadState.Stopped) { }
            serialport.Close();

            Console.WriteLine(serialport.IsOpen);
            Console.WriteLine("disconnect");
            button_Connect.Enabled = true;
        }

        public void fn_Send(byte[] buffer, int offset, int count)
        {
            if (button_Connect.Enabled == false)
            {
                //보낼데이터(버퍼값), 번지수, 데이터 개수)
                serialport.Write(buffer, offset, count);
            }
        }

        private void serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }

        private void MySerialReceived(object s, EventArgs e)
        {
            //int ReveiveData = serialport.ReadByte();
        }
        private void DDF_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            PaixMotion.Close();
            if (TdWatchSensor.IsAlive)
            {
                TdWatchSensor.Abort();
                //TdWatchSensor.Join();
            }
            if (TdTempControl.IsAlive)
            {
                TdTempControl.Abort();
                //TdWatchSensor.Join();
            }
        }

        private void button_Ch1_Set_Click(object sender, EventArgs e)
        {
            flag_ch1_set = true;
            Console.WriteLine(flag_ch1_set);
            Console.WriteLine("ch1 set");
        }

        private void button_Ch2_Set_Click(object sender, EventArgs e)
        {
            flag_ch2_set = true;
        }

        private void button_Ch3_Set_Click(object sender, EventArgs e)
        {
            flag_ch3_set = true;
        }

        private void button_Ch4_Set_Click(object sender, EventArgs e)
        {
            flag_ch4_set = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        } // DDF Form 닫기

        private void btn_openPC_Click(object sender, EventArgs e) // 압력(Daq) 컨트롤 Form 열기
        {
            DaqPressure daqpressure = new DaqPressure();
            daqpressure.Show();
        }

        private void btn_motioncontrol_Click(object sender, EventArgs e)
        {
            MotionControl motioncontrol = new MotionControl();
            motioncontrol.Show();
        }
    }
}
