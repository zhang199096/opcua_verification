using CSharpTcpDemo.com.dobot.api;
using CSharthiscpDemo.com.dobot.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opcua_verification.services
{
    public interface IRobot
    {
        Feedback mFeedback{ get;  }
        DobotMove mDobotMove { get;  }
        CSharpTcpDemo.com.dobot.api.Dashboard mDashboard { get; }

        string mIp {  get; }
        bool connnect (string ip, int Dashboardport, int DobotMoveport, int Feedbackport);

        string MoveJ(DescartesPoint point);
        string MoveL(DescartesPoint point);

        string StartPath(string path,int _const,int cart);
    }
}
