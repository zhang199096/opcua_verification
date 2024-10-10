using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CSharpTcpDemo.com.dobot.api
{
    public enum ErrorCode : int
    {
        OK = 1,
        ERROR = -2,
        TIMEOUT = -5,
        CONNECTERROR = -3,
        SENDFAIL = -4
    }
    public class Dashboard : DobotClient
    {
        protected override void OnConnected(Socket sock)
        {
            sock.SendTimeout = 5000;
            sock.ReceiveTimeout = 5000;
        }

        protected override void OnDisconnected()
        {
        }

        /// <summary>
        /// 复位，用于清除错误
        /// </summary>
        /// <returns>返回执行结果的描述信息</returns>
        public string ClearError()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "ClearError()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(5000);
        }

        /// <summary>
        /// 机器人上电
        /// </summary>
        /// <returns>返回执行结果的描述信息</returns>
        public string PowerOn()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "PowerOn()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(15000);
        }

        /// <summary>
        /// 急停
        /// </summary>
        /// <returns>返回执行结果的描述信息</returns>
        public string PowerOff()
        {
            return EmergencyStop();
        }

        /// <summary>
        /// 急停
        /// </summary>
        /// <returns>返回执行结果的描述信息</returns>
        public string EmergencyStop()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "EmergencyStop()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(15000);
        }

        /// <summary>
        /// 使能机器人
        /// </summary>
        /// <returns>返回执行结果的描述信息</returns>
        public string EnableRobot()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "EnableRobot()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(20000);
        }

        /// <summary>
        /// 下使能机器人
        /// </summary>
        /// <returns>返回执行结果的描述信息</returns>
        public string DisableRobot()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "DisableRobot()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(20000);
        }

        /// <summary>
        /// 机器人停止
        /// </summary>
        /// <returns>返回执行结果的描述信息</returns>
        public string ResetRobot()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "ResetRobot()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(20000);
        }

        /// <summary>
        /// 设置全局速度比例。
        /// </summary>
        /// <param name="ratio">运动速度比例，取值范围：1~100</param>
        /// <returns>返回执行结果的描述信息</returns>
        public string SpeedFactor(int ratio)
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = String.Format("SpeedFactor({0})", ratio);
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(5000);
        }

        /// <summary>
        /// 进入拖拽模式
        /// </summary>
        /// <returns></returns>
        public string StartDrag()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "StartDrag()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(20000);
        }

        /// <summary>
        /// 退出拖拽模式
        /// </summary>
        /// <returns></returns>
        public string StopDrag()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "StopDrag()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(20000);
        }

        /// <summary>
        /// 设置数字输出端口状态（队列指令）
        /// </summary>
        /// <param name="index">数字输出索引，取值范围：1~16或100~1000</param>
        /// <param name="status">数字输出端口状态，true：高电平；false：低电平</param>
        /// <returns>返回执行结果的描述信息</returns>
        public string DigitalOutputs(int index, bool status)
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = String.Format("DO({0},{1})", index, status ? 1 : 0);
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(5000);
        }

        /// <summary>
        /// 设置末端数字输出端口状态（队列指令）
        /// </summary>
        /// <param name="index">数字输出索引</param>
        /// <param name="status">数字输出端口状态，true：高电平；false：低电平</param>
        /// <returns>返回执行结果的描述信息</returns>
        public string ToolDO(int index, bool status)
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = String.Format("ToolDO({0},{1})", index, status ? 1 : 0);
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(5000);
        }

        public string ToolDI(int index, bool status,int timeout)
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = String.Format("ToolDI({0})", index);
            if (!SendData(str))
            {
                return str + ":send error";
            }
            return WaitReply(timeout);
        }
        public ErrorCode WaitDI(int index, bool status, int count)
        {
            while(count-- >0)
            {
                if (CheckDI(index, status, 5000) != ErrorCode.OK)
                    continue;
                else
                    return ErrorCode.OK;
            }
            return ErrorCode.TIMEOUT;
        }
        public ErrorCode CheckDI(int index, bool status, int timeout)
        {
            if (!IsConnected())
            {
                return ErrorCode.CONNECTERROR;
            }
            
            string str = String.Format("ToolDI({0})", index);
            if (!SendData(str))
            {
                return ErrorCode.SENDFAIL;
            }
            var recstr = WaitReply(timeout).ToCharArray();
            if(recstr[2]==1? true:false == status && recstr[0]==0x00)
            {
                return ErrorCode.OK;
            }
            else
            {
                return ErrorCode.ERROR;
            }
        }
        public string GetErrorID()
        {
            if (!IsConnected())
            {
                return "device does not connected!!!";
            }

            string str = "GetErrorID()";
            if (!SendData(str))
            {
                return str + ":send error";
            }

            return WaitReply(5000);
        }
    }
}
