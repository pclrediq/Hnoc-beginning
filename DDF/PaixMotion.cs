using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF
{
    class PaixMotion
    {
        bool m_bIsOpen;
        short m_nDev_no;

        public const short GROUP = 0;
        public void AstekMotion()
        {
            m_bIsOpen = false;
            m_nDev_no = 11;
        }
        public bool Open(short dev_no)
        {
            m_nDev_no = dev_no;

            Close();
            NMC2.nmc_SetIPAddress(dev_no, 192, 168, 0);
            // 방화벽을 확인해 주십시요.
            if (NMC2.nmc_PingCheck(dev_no, 10) != 0)
            {
                //MessageBox.Show("Ping Check Error");
                return false;
            }
            if (NMC2.nmc_OpenDevice(m_nDev_no) == 0)
                m_bIsOpen = true;
            else
                m_bIsOpen = false;

            return m_bIsOpen;
        }

        public bool Close()
        {
            NMC2.nmc_CloseDevice(m_nDev_no);
            m_bIsOpen = false;

            return true;
        }
        public bool SetSpeedPPS(short nAxis, double dStart, double dAcc, double dDec, double dMax)
        {

            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetSpeed(m_nDev_no, nAxis, dStart, dAcc, dDec, dMax);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool RelMove(short nAxis, double fDist)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.NMC_UNKOWN;

            nRet = NMC2.nmc_RelMove(m_nDev_no, nAxis, fDist);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool AbsMove(short nAxis, double fDist)
        {

            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            int nRet;

            nRet = NMC2.nmc_AbsMove(m_nDev_no, nAxis, fDist);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool JogMove(short nAxis, short nDir)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_JogMove(m_nDev_no, nAxis, nDir);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool SlowStop(short nAxis)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_DecStop(m_nDev_no, nAxis);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool Stop(short nAxis)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SuddenStop(m_nDev_no, nAxis);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool RelMultiTwoMove(double[] fDist)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short[] nAxis = { 0, 1 };


            short nRet = NMC2.nmc_VarRelMove(m_nDev_no, 2, nAxis, fDist);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool RelMultiFourMove(double[] fDist)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short[] nAxis = { 0, 1, 2, 3 };


            short nRet = NMC2.nmc_VarRelMove(m_nDev_no, 4, nAxis, fDist);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool AbsMultiTwoMove(double[] fDist)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short[] nAxis = { 0, 1 };

            short nRet = NMC2.nmc_VarAbsMove(m_nDev_no, 2, nAxis, fDist);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool AbsMultiFourMove(double[] fDist)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short[] nAxis = { 0, 1, 2, 3 };

            short nRet = NMC2.nmc_VarAbsMove(m_nDev_no, 4, nAxis, fDist);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SyncTwoMove(double pulse1, double pulse2, short opt)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short nRet = NMC2.nmc_Interpolation2Axis(m_nDev_no, 0, pulse1, 1, pulse2, opt);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;
        }
        public bool SyncFourMove(double pulse1, double pulse2, double pulse3, double pulse4, short opt)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short nRet = NMC2.nmc_Interpolation4Axis(m_nDev_no, 0, pulse1, 1, pulse2, 2, pulse3, 3, pulse4, opt);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetCmd(short nAxis, double fValue)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetCmdPos(m_nDev_no, nAxis, fValue);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetEnc(short nAxis, double fValue)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetEncPos(m_nDev_no, nAxis, fValue);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        //  false - A 접점  ,   true  - B 접점
        public bool SetEmerLogic(short logic)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short nRet = NMC2.nmc_SetEmgLogic(m_nDev_no, 0, logic);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }
            return false;

        }
        //  false - A 접점  ,   true  - B 접점
        public bool SetPulseLogic(short nAxis, int logic)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short nRet = NMC2.nmc_SetPulseLogic(m_nDev_no, nAxis, (short)logic);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool ServoOn(short nAxis, int nOut)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            short nRet = NMC2.nmc_SetServoOn(m_nDev_no, nAxis, (short)nOut);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool GetBusy(short nAxis, out short nValue)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false)
                {
                    nValue = 0;
                    return false;
                }
            }
            short nRet = NMC2.nmc_GetBusyStatus(m_nDev_no, nAxis, out nValue);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }

        //  false - A 접점  ,   true  - B 접점
        public bool SetNearLogic(short nAxis, short logic)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetNearLogic(m_nDev_no, nAxis, logic);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetMinusLimitLogic(short nAxis, short logic)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetMinusLimitLogic(m_nDev_no, nAxis, logic);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetPlusLimitLogic(short nAxis, short logic)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetPlusLimitLogic(m_nDev_no, nAxis, logic);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetAlarmLogic(short nAxis, short logic)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetAlarmLogic(m_nDev_no, nAxis, logic);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetPulseMode(short nAxis, short nClock)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetPulseMode(m_nDev_no, nAxis, nClock);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }

        /*
        nENCMODE
        0 - 4
        1 - 2
        2 - 1체배
        */
        public bool SetEncCountMode(short nAxis, short nEncMode)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetEncoderCount(m_nDev_no, nAxis, nEncMode);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetEncInputMode(short nAxis, short nMode)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetEncoderDir(m_nDev_no, nAxis, nMode);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }

        //  false - A 접점  ,   true  - B 접점
        public bool SetZLogic(short nAxis, short logic)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetEncoderZLogic(m_nDev_no, nAxis, logic);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool HomeMove(short nAxis, int nHomeMode)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_HomeMove(m_nDev_no, nAxis, (short)nHomeMode, 0, 0, 0);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool SetHomeSpeed(short nAxis, double dHomeSpeed0, double dHomeSpeed1, double dHomeSpeed2)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_SetHomeSpeed(m_nDev_no, nAxis, (double) dHomeSpeed0, (double) dHomeSpeed1, (double) dHomeSpeed2);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public bool GetNmcStatus(ref NMC2.NMCAXESEXPR pNmcData)
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_GetAxesExpress(m_nDev_no, out pNmcData);

            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 0:
                    return true;
            }

            return false;

        }
        public void SetUnitPulse(short nAxis, double dRatio)
        {
            NMC2.nmc_SetUnitPerPulse(m_nDev_no, nAxis, dRatio);
        }
        public bool SaveToRom()
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_MotCfgSaveToROM(m_nDev_no, 0);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 1:
                    return false;
            }
            return true;

        }

        public bool EraseRom()
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_MotCfgSetDefaultROM(m_nDev_no, 0);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 1:
                    return false;
            }
            return true;

        }

        public bool ContTest()
        {
            short nRet;
            ulong nExeNo;

            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }

            nRet = NMC2.nmc_ContiSetNodeClear(m_nDev_no, GROUP);               // 노드 버퍼의 초기화
            if (nRet != NMC2.NMC_OK) return false;

            // 그룹0,삼각파형 방지X, 예외처리:종료, 연속 보간축 : 0축, 1축 (2축 연속 보간만 수행)
            //      최대 구동 속도 : 300,출력 포트:지정 안함,출력 pin mask:0,종료 시 출력 값:0
            nRet = NMC2.nmc_ContiSetMode(m_nDev_no, GROUP, 0, 0, 0, 1, -1, 300, 2, 0, 0);
            if (nRet != NMC2.NMC_OK) return false;

            //==================== 노드 등록 ====================
            // 1st 노드[직선] === 위치:(0,200), 시작:50, 가속:250, 감속: 0, 구동속도:100
            nRet = NMC2.nmc_ContiAddNodeLine2Axis(m_nDev_no, GROUP, 0, 200, 50, 250, 0, 100, -1);
            if (nRet != NMC2.NMC_OK) return false;

            // 2nd 노드[원호] === 중심위치:(100,200), 시작:100, 가속:750, 감속: 500, 구동속도:300, 회전각:-90
            nRet = NMC2.nmc_ContiAddNodeArc(m_nDev_no, GROUP, 100, 200, 100, 750, 500, 300, -90, -1);
            if (nRet != NMC2.NMC_OK) return false;

            // 3rd 노드[직선] === 위치:(300,300), 시작:200, 가속:250, 감속: 0, 구동속도:200
            nRet = NMC2.nmc_ContiAddNodeLine2Axis(m_nDev_no, GROUP, 300, 300, 200, 250, 0, 200, -1);
            if (nRet != NMC2.NMC_OK) return false;

            // 4th 노드[직선] === 위치:(300,100), 시작:200, 가속:750, 감속: 0, 구동속도:250
            nRet = NMC2.nmc_ContiAddNodeLine2Axis(m_nDev_no, GROUP, 300, 100, 200, 750, 0, 250, -1);
            if (nRet != NMC2.NMC_OK) return false;

            // 5th 노드[원호]=== 중심위치:(200,100), 시작:250, 가속:750, 감속: 0, 구동속도:150, 회전각:-90
            nRet = NMC2.nmc_ContiAddNodeArc(m_nDev_no, GROUP, 200, 100, 250, 750, 0, 150, -90, -1);
            if (nRet != NMC2.NMC_OK) return false;

            // 6th 노드[직선]=== 위치:(0,0), 시작:150, 가속:125, 감속: 375, 구동속도:200
            nRet = NMC2.nmc_ContiAddNodeLine2Axis(m_nDev_no, GROUP, 0, 0, 150, 125, 375, 200, -1);
            if (nRet != NMC2.NMC_OK) return false;

            // 노드 전송 종료
            nRet = NMC2.nmc_ContiSetCloseNode(m_nDev_no, GROUP);
            if (nRet != NMC2.NMC_OK) return false;

            // ==================== 연속 보간 실행 ====================
            // 연속보간 실행
            nRet = NMC2.nmc_ContiRunStop(m_nDev_no, GROUP, 1);
            if (nRet != NMC2.NMC_OK) return false;

            // =================== 보간이동 종료 대기 ==================
            NMC2.NMCCONTISTATUS NmcContiStatus;
            while (true)
            {
                /* 본 while구문의 내용은 사용하실 프로그램 내 주기적으로 실행 되는 곳에서 실행 하셔도 됩니다. 
                단, 노드 실행 속도 보다는 갱신 속도가 빨라야 연속 보간이 끊김없이 실행 됩니다. */
                nRet = NMC2.nmc_ContiGetStatus(m_nDev_no, out NmcContiStatus);

                // 그룹 0의 현재까지 실행한 노드의 수
                nExeNo = NmcContiStatus.uiContiExecutionNum[GROUP];

                if (NmcContiStatus.nContiRun[GROUP] == 0) break;     // 연속보간 이동 끝, while 구문 탈출
            }
            return true;
        }
        public bool LoadFromRom()
        {
            if (m_bIsOpen == false)
            {
                if (Open(m_nDev_no) == false) return false;
            }
            short nRet = NMC2.nmc_MotCfgLoadFromROM(m_nDev_no, 0);
            switch (nRet)
            {
                case NMC2.NMC_NOTCONNECT:
                    m_bIsOpen = false;
                    return false;
                case 1:
                    return false;

            }
            return true;

        }
        public int GetEnumList(short[] pnIp, out NMC2.NMCEQUIPLIST pNmcList)            // 2017.01.11 han
        {


            int nRet = NMC2.nmc_GetEnumList(pnIp, out pNmcList); // 2017.5.31 khd

            return nRet;

        }                                                                               // 2017.01.11 han

        public short GetParaLogic(short nAxis, out NMC2.NMCPARALOGIC pNmcParaLogic)     // 2017.01.16 han start
        {
            short nRet = NMC2.nmc_GetParaLogic(m_nDev_no, nAxis, out pNmcParaLogic);

            return nRet;
        }

        public short SetParaLogic(short nAxis, ref NMC2.NMCPARALOGIC pNmcParaLogic)
        {
            short nRet = NMC2.nmc_SetParaLogic(m_nDev_no, nAxis, ref pNmcParaLogic);

            return nRet;
        }
    }
}
