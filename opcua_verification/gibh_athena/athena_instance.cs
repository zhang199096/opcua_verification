using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.TeamFoundation.Common.Internal.NativeMethods;
using UAModel.gh;
using Microsoft.TeamFoundation.Dashboards.WebApi;
using opcua_verification.services;
using CSharthiscpDemo.com.dobot.api;
using System.Security.Cryptography;
using CSharpTcpDemo.com.dobot.api;

namespace opcua_verification.gibh_athena
{
    internal class athena_instance
    {
        public athena_instance(NodeState parent, gibh_athenaManager nodeManager, mscTyoeState libState
         , IRobot robot )
        {
            m_nodeManager = nodeManager;
            // convert the untyped node to a typed node that can be manipulated within the server.
            msc = libState;
            this.robot = robot;
            msc.Create(nodeManager.SystemContext, parent);
            #region node Update
            m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);

            #endregion
        }

        public void InitDAMethodState()
        {
            #region add method
            #region msc
            msc.IF2451.StartCapture.OnCallMethod = new GenericMethodCalledEventHandler(OnIF2451StartCapture);
            msc.OpticalModel.IOUint.SetIO.OnCall = new SetIOMethodStateMethodCallHandler(SetIO);
            msc.OpticalModel.Jog.OnCall = new UAModel.gh.JogMethodStateMethodCallHandler(JogGo);
            msc.DualModel.Jog.OnCall = new UAModel.gh.JogMethodStateMethodCallHandler(JogGo);
            msc.Balser.StartCapture.OnCallMethod = new GenericMethodCalledEventHandler(OnBalserStartCapture);
            msc.Tecan.GotoAbs.OnCall = new GotoAbsMethodStateMethodCallHandler(TecanGotoAbs);
            msc.CR3.MoveL.OnCall = new MoveLMethodStateMethodCallHandler(MoveL);
            msc.CR3.MoveJ.OnCall = new MoveJMethodStateMethodCallHandler(MoveJ);
            msc.CR3.Connect.OnCall = new ConnectMethodStateMethodCallHandler(CR3Connnect);
            
            msc.CR3.MoveJ2.OnCall = new MoveJ2MethodStateMethodCallHandler(MoveJ2);
            msc.CR3.StartTrace.OnCall = new StartTraceMethodStateMethodCallHandler(StartTrace);
            #endregion

            #endregion
        }

        private ServiceResult MoveJ(ISystemContext _context, MethodState _method, NodeId _objectId, DesType des, double speed, ref int ret)
        {
            throw new NotImplementedException();
        }

        private ServiceResult StartTrace(ISystemContext _context, MethodState _method, NodeId _objectId, string path, int isconst, int cart, ref int ret)
        {
            robot.StartPath(path, isconst, cart);
            return ServiceResult.Good;
        }



        private ServiceResult MoveJ2(ISystemContext _context, MethodState _method, NodeId _objectId, ThreeDVector pos, ThreeDVector dir, float speed, ref int ret)
        {
            DescartesPoint descartesPoint = new DescartesPoint();
            descartesPoint.x = pos.X;
            descartesPoint.y = pos.Y;
            descartesPoint.z = pos.Z;
            descartesPoint.rx = dir.X;
            descartesPoint.ry = dir.Y;
            descartesPoint.rz = dir.Z;
            robot.MoveJ(descartesPoint);
            return ServiceResult.Good;
        }



        private ServiceResult CR3Connnect(ISystemContext _context, MethodState _method, NodeId _objectId, string ip, Vector port)
        {
            Console.WriteLine(ip + ":" + port.ToString());
            robot.connnect(ip, 29999, 30003, 30004);
           
            return ServiceResult.Good;

        }



        private ServiceResult MoveL(ISystemContext _context, MethodState _method, NodeId _objectId, Descartes des, double speed)
        {
            DescartesPoint descartesPoint = new DescartesPoint();
            descartesPoint.x = des.x;
            //robot.MoveL()
            return ServiceResult.Good;
        }

        private ServiceResult TecanGotoAbs(ISystemContext _context, MethodState _method, NodeId _objectId, uint abs, uint speed)
        {
            return ServiceResult.Good;
        }

        private ServiceResult OnBalserStartCapture(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        private ServiceResult JogGo(ISystemContext _context, MethodState _method, NodeId _objectId, uint index, uint dir, uint speed, uint distance)
        {
            return ServiceResult.Good;
        }

        private ServiceResult SetIO(ISystemContext _context, MethodState _method, NodeId _objectId, uint index, bool set)
        {
            return ServiceResult.Good;
        }

        private ServiceResult OnIF2451StartCapture(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }



        public void DoSimulation(object state)
        {
            UpdateValue(msc.OpticalModel.XUint.LocalAxis, 0.2 * (new Random()).Next(1, 20));
            UpdateValue(msc.OpticalModel.Yuint.LocalAxis, 0.2 * (new Random()).Next(1, 20));
            UpdateValue(msc.OpticalModel.ZUint.LocalAxis, 0.2 * (new Random()).Next(1, 20));
            UpdateValue(msc.DualModel.Yuint.LocalAxis, 0.2 * (new Random()).Next(1, 10));
            UpdateValue(msc.DualModel.Yuint.LocalAxis, 0.2 * (new Random()).Next(1, 10));
            UpdateValue(msc.DualModel.ZUint.LocalAxis, 0.2 * (new Random()).Next(1, 10));
            UpdateValue(msc.IF2451.Name, "hello IF2451");
            UpdateValue(msc.Tecan.Abs, 1);
            UpdateValue(msc.Balser.Name, "hello Balser");
            if (null != robot.mFeedback.feedbackData.ToolVectorActual && robot.mFeedback.feedbackData.ToolVectorActual.Length >= 6)
            {
                UpdateValue(msc.CR3.A1, robot.mFeedback.feedbackData.ToolVectorActual[0]);
                UpdateValue(msc.CR3.A2, robot.mFeedback.feedbackData.ToolVectorActual[1]);
                UpdateValue(msc.CR3.A3, robot.mFeedback.feedbackData.ToolVectorActual[2]);
                UpdateValue(msc.CR3.A4, robot.mFeedback.feedbackData.ToolVectorActual[3]);
                UpdateValue(msc.CR3.A5, robot.mFeedback.feedbackData.ToolVectorActual[4]);
                UpdateValue(msc.CR3.A6, robot.mFeedback.feedbackData.ToolVectorActual[5]);
            }
            UpdateValue(msc.CR3.IP,robot.mIp);    
        }
        void UpdateValue(BaseVariableState baseVariable, object value)
        {
            //var type =  baseVariable.Value.GetType();
            baseVariable.Value = value;
            baseVariable.Timestamp = DateTime.Now;
            // baseVariable.SetChildValue(SystemContext, new QualifiedName(mscHub.BrowseNames.temperature, NamespaceIndex), mschub.msc.HeatUints.temperature, false);
            baseVariable.ClearChangeMasks(m_nodeManager.SystemContext, false);
            //Server.ReportEvent(baseVariable);
            //baseVariable.ReportEvent(SystemContext);
        }
        public static mscTyoeState msc;
        private readonly IRobot robot;
        private gibh_athenaManager m_nodeManager;
        private System.Threading.Timer m_simulationTimer;
    }
}
