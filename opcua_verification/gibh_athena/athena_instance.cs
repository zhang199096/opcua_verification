using Opc.Ua.Server;
using Opc.Ua;
using opcua_verification.TestNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.TeamFoundation.Common.Internal.NativeMethods;
using UAModel.eg;
using UAModel.gh;

namespace opcua_verification.gibh_athena
{
    internal class athena_instance
    {
        public athena_instance(NodeState parent, gibh_athenaManager nodeManager, mscTyoeState libState
           )
        {
            m_nodeManager = nodeManager;
            // convert the untyped node to a typed node that can be manipulated within the server.
            msc = libState;
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
            #endregion

            #endregion
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
        private gibh_athenaManager m_nodeManager;
        private System.Threading.Timer m_simulationTimer;
    }
}
