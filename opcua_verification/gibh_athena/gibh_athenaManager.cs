﻿using Opc.Ua;
using Opc.Ua.Server;
using opcua_verification.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                "gibh_athena/UAModel.gh.PredefinedNodes.uanodes",
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
                BaseObjectState AthenaNode = (BaseObjectState)FindPredefinedNode(new NodeId(UAModel.gh.Objects.Athena, NamespaceIndexes[0]), typeof(BaseObjectState));
                BaseObjectState NAEbotNode = (BaseObjectState)FindPredefinedNode(new NodeId(UAModel.gh.Objects.NAEbot, NamespaceIndexes[0]), typeof(BaseObjectState));
                //添加实体类
                Athena = new athena_instance(AthenaNode, this, new mscTyoeState(AthenaNode), new CR3Driver());
                naebot =  new naebot_Instance(NAEbotNode, this,new NAEBotTypeState(NAEbotNode));
                //添加实体节点
                AddPredefinedNode(SystemContext, athena_instance.msc);
                AddPredefinedNode(SystemContext, naebot_Instance.nAEBot);
                //初始化实体节点方法
                Athena.InitDAMethodState();
                naebot.InitDAMethodState();
            }
        }

        private static athena_instance Athena;
        private static naebot_Instance naebot;
    }
}
