using CSharpTcpDemo.com.dobot.api;
using CSharthiscpDemo.com.dobot.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace opcua_verification.services
{
    public class CR3Driver : IRobot
    {
        public Feedback mFeedback { get => Feedback;  }
        private static Feedback Feedback = new Feedback();
        public  DobotMove mDobotMove { get => DobotMove;  }
        private static DobotMove DobotMove = new DobotMove();
        public Dashboard mDashboard { get => Dashboard;  }

        
        private static Dashboard Dashboard = new Dashboard();

        public string mIp { get => Ip;  }
        private string Ip = "";
        //DispatcherTimer mTimerReader = new DispatcherTimer();
        public bool connnect(string strIp, int iPortDashboard, int iPortMove, int iPortFeedback)
        {
            Ip = strIp;
            if (!mDashboard.Connect(strIp, iPortDashboard))
            {
               // PrintLog(string.Format("Connect {0}:{1} Fail!!", strIp, iPortDashboard));
                return false;
            }
            if (!mDobotMove.Connect(strIp, iPortMove))
            {
                //PrintLog(string.Format("Connect {0}:{1} Fail!!", strIp, iPortMove));
                return false;
            }
            if (!mFeedback.Connect(strIp, iPortFeedback))
            {
                //PrintLog(string.Format("Connect {0}:{1} Fail!!", strIp, iPortFeedback));
                return false;
            }
            //mTimerReader.Interval = TimeSpan.FromMilliseconds(300);//1s
            //mTimerReader.Tick += TimeoutEvent;
            //mTimerReader.Start();
            return true;
        }
        //private void TimeoutEvent(object sender, EventArgs e)
        //{
        //    if (!mFeedback.DataHasRead)
        //    {
        //        return;
        //    }
        //    mFeedback.DataHasRead = false;
        //    if (this.labDI.Dispatcher.CheckAccess())
        //    {
        //        this.labDI.Dispatcher.Invoke(new Action(() => {
        //            ShowDataResult();
        //        }));
        //    }
        //    else
        //    {
        //        ShowDataResult();
        //    }
        //}
        //private void ShowDataResult()
        //{
        //    this.labCurrentSpeedRatio.Content = string.Format("Current Speed Ratio:{0:F2}%", mFeedback.feedbackData.SpeedScaling);
        //    this.labRobotMode.Content = string.Format("Robot Mode:{0}", mFeedback.ConvertRobotMode());

        //    if (null != mFeedback.feedbackData.QActual && mFeedback.feedbackData.QActual.Length >= 6)
        //    {
        //        this.labJ1.Content = string.Format("J1:{0:F3}", mFeedback.feedbackData.QActual[0]);
        //        this.labJ2.Content = string.Format("J2:{0:F3}", mFeedback.feedbackData.QActual[1]);
        //        this.labJ3.Content = string.Format("J3:{0:F3}", mFeedback.feedbackData.QActual[2]);
        //        this.labJ4.Content = string.Format("J4:{0:F3}", mFeedback.feedbackData.QActual[3]);
        //        this.labJ5.Content = string.Format("J5:{0:F3}", mFeedback.feedbackData.QActual[4]);
        //        this.labJ6.Content = string.Format("J6:{0:F3}", mFeedback.feedbackData.QActual[5]);
        //    }

        //    if (null != mFeedback.feedbackData.ToolVectorActual && mFeedback.feedbackData.ToolVectorActual.Length >= 6)
        //    {
        //        this.labX.Content = string.Format("X:{0:F3}", mFeedback.feedbackData.ToolVectorActual[0]);
        //        this.labY.Content = string.Format("Y:{0:F3}", mFeedback.feedbackData.ToolVectorActual[1]);
        //        this.labZ.Content = string.Format("Z:{0:F3}", mFeedback.feedbackData.ToolVectorActual[2]);
        //        this.labRx.Content = string.Format("Rx:{0:F3}", mFeedback.feedbackData.ToolVectorActual[3]);
        //        this.labRy.Content = string.Format("Ry:{0:F3}", mFeedback.feedbackData.ToolVectorActual[4]);
        //        this.labRz.Content = string.Format("Rz:{0:F3}", mFeedback.feedbackData.ToolVectorActual[5]);
        //    }

        //    this.labDI.Content = "Digital Inputs:  " + Convert.ToString(mFeedback.feedbackData.DigitalInputs, 2).PadLeft(64, '0');
        //    this.labDO.Content = "Digital Outputs:" + Convert.ToString(mFeedback.feedbackData.DigitalOutputs, 2).PadLeft(64, '0');

        //    ParseWarn();
        //}
        public string MoveJ(DescartesPoint point)
        {
            return mDobotMove.MovJ(point);
        }

        public string MoveL(DescartesPoint point)
        {
            return mDobotMove.MovL(point);
        }

        public string StartPath(string path, int _const, int cart)
        {
            var pos = mDobotMove.GetPathStartPose(path);
            string ret = "";
           
            var getvalue =   Regex.Match(pos,@"\{(.*)\}",RegexOptions.Singleline).Groups[1].Value;
            var list = getvalue.Split(',');
            if (list.Length == 6)
            {
                var starpos = new JointPoint();
                starpos.j1 = double.Parse(list[0]);
                starpos.j2 = double.Parse(list[1]);
                starpos.j3 = double.Parse(list[2]);
                starpos.j4 = double.Parse(list[3]);
                starpos.j5 = double.Parse(list[4]);
                starpos.j6 = double.Parse(list[5]);
                if (starpos != null)
                {
                    ret =  mDobotMove.JointMovJ(starpos);
                    Console.WriteLine(ret);
                }
            }
            //var starpos = JsonConvert.DeserializeObject<DescartesPoint>(pos);
            ret = mDobotMove.StartPath(path, _const, cart);
            Console.WriteLine(ret);
            return ret;
        }
    }
}
