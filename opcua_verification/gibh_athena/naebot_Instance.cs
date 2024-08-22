using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAModel.gh;

namespace opcua_verification.gibh_athena
{
    internal class naebot_Instance
    {
        public naebot_Instance(NodeState parent, gibh_athenaManager nodeManager, NAEBotTypeState libState
           )
        {
            m_nodeManager = nodeManager;
            // convert the untyped node to a typed node that can be manipulated within the server.
            nAEBot = libState;
            nAEBot.Create(nodeManager.SystemContext, parent);
            #region node Update
            m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);

            #endregion
        }

        public void InitDAMethodState()
        {
            #region add method
            #region msc
            nAEBot.VibrateHeat.Start.OnCall = new StartMethodStateMethodCallHandler(VibrateHeat_Start);
            nAEBot.LinearModel.IOUint.SetIO.OnCall = new SetIOMethodStateMethodCallHandler(SetIO);
            nAEBot.LinearModel.Jog.OnCall = new UAModel.gh.JogMethodStateMethodCallHandler(JogGo);
            nAEBot.LinearModel.Jog.OnCall = new UAModel.gh.JogMethodStateMethodCallHandler(JogGo);
            nAEBot.Oscillate.Start.OnCall = new StartMethodStateMethodCallHandler(Oscillate_Start);
            nAEBot.PMT.StartCapture.OnCallMethod = new GenericMethodCalledEventHandler(PMTStartCapture);
            #endregion

            #endregion
        }

        private ServiceResult VibrateHeat_Start(ISystemContext _context, MethodState _method, NodeId _objectId, int moduleType, int oscillateTime)
        {
            return ServiceResult.Good;
        }

        private ServiceResult Oscillate_Start(ISystemContext _context, MethodState _method, NodeId _objectId, int moduleType, int oscillateTime)
        {
            return ServiceResult.Good;
        }

        private ServiceResult PMTStartCapture(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
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
            UpdateValue(nAEBot.LinearModel.XUint.LocalAxis, 0.2 * (new Random()).Next(1, 20));
            UpdateValue(nAEBot.LinearModel.XUint.MechineAxis, 0.2 * (new Random()).Next(1, 20));
            UpdateValue(nAEBot.LinearModel.Yuint.LocalAxis, 0.2 * (new Random()).Next(1, 20));
            UpdateValue(nAEBot.LinearModel.ZUint.LocalAxis, 0.2 * (new Random()).Next(1, 20));
            UpdateValue(nAEBot.PMT.Id, 123);
            UpdateValue(nAEBot.VibrateHeat.mode, 123);
            UpdateValue(nAEBot.Oscillate.Id, 123);
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
        public static NAEBotTypeState nAEBot;
        private gibh_athenaManager m_nodeManager;
        private System.Threading.Timer m_simulationTimer;
    }
}
