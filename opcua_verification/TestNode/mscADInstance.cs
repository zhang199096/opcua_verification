using Microsoft.Azure.Pipelines.WebApi;
using Microsoft.TeamFoundation.VersionControl.Client;
using Opc.Ua;
using opcua_verification.addDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAModel.eg;

namespace opcua_verification.TestNode
{
    public class mscADInstance
    {
        public mscADInstance(NodeState parent, VerificationNodeManager nodeManager, mschubState libState
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
            msc.Reset.OnCallMethod = new GenericMethodCalledEventHandler(OnReset);
            msc.Init.OnCallMethod = new GenericMethodCalledEventHandler(OnInit);
            msc.Runto.OnCallMethod = new GenericMethodCalledEventHandler(OnRunto);
            #endregion

            #endregion
        }
        public void DoSimulation(object state)
        {
            UpdateValue(msc.Axisx.Coordvalue, 0.2 * (new Random()).Next(1, 20));
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
        #region 重写方法
        private ServiceResult OnReset(ISystemContext context, MethodState method, IList<object> inputArguments,
IList<object> outputArguments)
        {

            return ServiceResult.Good;
        }

        private ServiceResult OnInit(ISystemContext context, MethodState method, IList<object> inputArguments,
IList<object> outputArguments)
        {

            return ServiceResult.Good;
        }
        private ServiceResult OnRunto(ISystemContext context, MethodState method, IList<object> inputArguments,
IList<object> outputArguments)
        {

            return ServiceResult.Good;
        }
        #endregion
        public static mschubState msc;
        private VerificationNodeManager m_nodeManager;
        private System.Threading.Timer m_simulationTimer;
    }
}
