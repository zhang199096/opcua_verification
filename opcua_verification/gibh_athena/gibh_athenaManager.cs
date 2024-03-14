using Opc.Ua;
using Opc.Ua.Server;
using opcua_verification.TestNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UAModel.gh;

namespace opcua_verification.gibh_athena
{
    internal class gibh_athenaManager : CustomNodeManager2
    {
        public gibh_athenaManager(IServerInternal server, ApplicationConfiguration configuration)
        : base(server, configuration, UAModel.gh.Namespaces.gh)
        {
            SystemContext.NodeIdFactory = this;
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "UAModel.gh.PredefinedNodes.uanodes",
                typeof(gibh_athenaManager).GetTypeInfo().Assembly,
                true);
            return predefinedNodes;
        }
        #region INodeIdFactory Members
        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="node">The node.</param>
        /// <returns>The new NodeId.</returns>
        /// <remarks>
        /// This method is called by the NodeState.Create() method which initializes a Node from
        /// the type model. During initialization a number of child nodes are created and need to 
        /// have NodeIds assigned to them. This implementation constructs NodeIds by constructing
        /// strings. Other implementations could assign unique integers or Guids and save the new
        /// Node in a dictionary for later lookup.
        /// </remarks>

        #endregion
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(UAModel.gh.Objects.Athena, NamespaceIndexes[0]), typeof(BaseObjectState));
                //AreaState RootArea = (AreaState)FindPredefinedNode(new NodeId(SecCreateLib.Objects.mscInstance_SecProperty, NamespaceIndexes[0]), typeof(AreaState));
                Athena = new athena_instance(passiveNode, this, new mscTyoeState(passiveNode));
                //m_msc.Create(SystemContext, passiveNode);
                AddPredefinedNode(SystemContext, athena_instance.msc);
                Athena.InitDAMethodState();
                // m_msc.InitDAMethodState();
            }
        }

        private static athena_instance Athena;
    }
}
