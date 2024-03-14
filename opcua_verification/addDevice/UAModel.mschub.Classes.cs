/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace UAModel.mschub
{
    #region AdddDeviceState Class
    #if (!OPCUA_EXCLUDE_AdddDeviceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AdddDeviceState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public AdddDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.mschub.ObjectTypes.AdddDevice, UAModel.mschub.Namespaces.mschub, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvbXNjaHViL/////8EYIACAQAAAAEAEgAA" +
           "AEFkZGREZXZpY2VJbnN0YW5jZQEB7AMBAewD7AMAAP////8CAAAABGCACgEAAAABAAYAAABDZW50cmkB" +
           "AYoTAC8BAesDihMAAP////8EAAAAFWCJCgIAAAABAAIAAABpZAEBehcALwA/ehcAAAAF/////wMD////" +
           "/wAAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQF7FwAvAD97FwAAAAv/////AwP/////AAAAAARhggoEAAAA" +
           "AQAFAAAAU3RhcnQBAVsbAC8BAVkbWxsAAAEB/////wAAAAAEYYIKBAAAAAEABAAAAFN0b3ABAVwbAC8B" +
           "AVobXBsAAAEB/////wAAAAAEYIAKAQAAAAEAAwAAAHBjcgEBiRMALwEB6gOJEwAA/////wUAAAAVYIkK" +
           "AgAAAAEAAgAAAGlkAQF/FwAvAD9/FwAAAAX/////AwP/////AAAAAARhggoEAAAAAQAHAAAAU2V0VGVt" +
           "cAEBYhsALwEBXxtiGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYEXAC4A" +
           "RIEXAACWAQAAAAEAKgEBEwAAAAQAAAB0ZW1wAAv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////" +
           "AAAAAARhggoEAAAAAQAFAAAAU3RhcnQBAWAbAC8BAV0bYBsAAAEB/////wAAAAAEYYIKBAAAAAEABAAA" +
           "AFN0b3ABAWEbAC8BAV4bYRsAAAEB/////wAAAAAVYIkKAgAAAAEABAAAAFRlbXABAYAXAC8AP4AXAAAA" +
           "C/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CentriState Centri
        {
            get
            {
                return m_centri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_centri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_centri = value;
            }
        }

        /// <remarks />
        public PCRState pcr
        {
            get
            {
                return m_pcr;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pcr, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pcr = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_centri != null)
            {
                children.Add(m_centri);
            }

            if (m_pcr != null)
            {
                children.Add(m_pcr);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.mschub.BrowseNames.Centri:
                {
                    if (createOrReplace)
                    {
                        if (Centri == null)
                        {
                            if (replacement == null)
                            {
                                Centri = new CentriState(this);
                            }
                            else
                            {
                                Centri = (CentriState)replacement;
                            }
                        }
                    }

                    instance = Centri;
                    break;
                }

                case UAModel.mschub.BrowseNames.pcr:
                {
                    if (createOrReplace)
                    {
                        if (pcr == null)
                        {
                            if (replacement == null)
                            {
                                pcr = new PCRState(this);
                            }
                            else
                            {
                                pcr = (PCRState)replacement;
                            }
                        }
                    }

                    instance = pcr;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private CentriState m_centri;
        private PCRState m_pcr;
        #endregion
    }
    #endif
    #endregion

    #region CentriState Class
    #if (!OPCUA_EXCLUDE_CentriState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CentriState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public CentriState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.mschub.ObjectTypes.Centri, UAModel.mschub.Namespaces.mschub, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvbXNjaHViL/////8EYIACAQAAAAEADgAA" +
           "AENlbnRyaUluc3RhbmNlAQHrAwEB6wPrAwAA/////wQAAAAVYIkKAgAAAAEAAgAAAGlkAQF4FwAvAD94" +
           "FwAAAAX/////AwP/////AAAAABVgiQoCAAAAAQAFAAAAU3BlZWQBAXkXAC8AP3kXAAAAC/////8DA///" +
           "//8AAAAABGGCCgQAAAABAAUAAABTdGFydAEBWRsALwEBWRtZGwAAAQH/////AAAAAARhggoEAAAAAQAE" +
           "AAAAU3RvcAEBWhsALwEBWhtaGwAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> id
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!Object.ReferenceEquals(m_id, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_id = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }

        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public MethodState Stop
        {
            get
            {
                return m_stopMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.mschub.BrowseNames.id:
                {
                    if (createOrReplace)
                    {
                        if (id == null)
                        {
                            if (replacement == null)
                            {
                                id = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                id = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = id;
                    break;
                }

                case UAModel.mschub.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Speed = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }

                case UAModel.mschub.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case UAModel.mschub.BrowseNames.Stop:
                {
                    if (createOrReplace)
                    {
                        if (Stop == null)
                        {
                            if (replacement == null)
                            {
                                Stop = new MethodState(this);
                            }
                            else
                            {
                                Stop = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Stop;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<ushort> m_id;
        private BaseDataVariableState<double> m_speed;
        private MethodState m_startMethod;
        private MethodState m_stopMethod;
        #endregion
    }
    #endif
    #endregion

    #region PCRState Class
    #if (!OPCUA_EXCLUDE_PCRState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PCRState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PCRState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.mschub.ObjectTypes.PCR, UAModel.mschub.Namespaces.mschub, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvbXNjaHViL/////8EYIACAQAAAAEACwAA" +
           "AFBDUkluc3RhbmNlAQHqAwEB6gPqAwAA/////wUAAAAVYIkKAgAAAAEAAgAAAGlkAQF8FwAvAD98FwAA" +
           "AAX/////AwP/////AAAAAARhggoEAAAAAQAHAAAAU2V0VGVtcAEBXxsALwEBXxtfGwAAAQH/////AQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAX4XAC4ARH4XAACWAQAAAAEAKgEBEwAAAAQAAAB0" +
           "ZW1wAAv/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAFAAAAU3RhcnQB" +
           "AV0bAC8BAV0bXRsAAAEB/////wAAAAAEYYIKBAAAAAEABAAAAFN0b3ABAV4bAC8BAV4bXhsAAAEB////" +
           "/wAAAAAVYIkKAgAAAAEABAAAAFRlbXABAX0XAC8AP30XAAAAC/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> id
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!Object.ReferenceEquals(m_id, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_id = value;
            }
        }

        /// <remarks />
        public SetTempMethodState SetTemp
        {
            get
            {
                return m_setTempMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setTempMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setTempMethod = value;
            }
        }

        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public MethodState Stop
        {
            get
            {
                return m_stopMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Temp
        {
            get
            {
                return m_temp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temp = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_setTempMethod != null)
            {
                children.Add(m_setTempMethod);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
            }

            if (m_temp != null)
            {
                children.Add(m_temp);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.mschub.BrowseNames.id:
                {
                    if (createOrReplace)
                    {
                        if (id == null)
                        {
                            if (replacement == null)
                            {
                                id = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                id = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = id;
                    break;
                }

                case UAModel.mschub.BrowseNames.SetTemp:
                {
                    if (createOrReplace)
                    {
                        if (SetTemp == null)
                        {
                            if (replacement == null)
                            {
                                SetTemp = new SetTempMethodState(this);
                            }
                            else
                            {
                                SetTemp = (SetTempMethodState)replacement;
                            }
                        }
                    }

                    instance = SetTemp;
                    break;
                }

                case UAModel.mschub.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case UAModel.mschub.BrowseNames.Stop:
                {
                    if (createOrReplace)
                    {
                        if (Stop == null)
                        {
                            if (replacement == null)
                            {
                                Stop = new MethodState(this);
                            }
                            else
                            {
                                Stop = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Stop;
                    break;
                }

                case UAModel.mschub.BrowseNames.Temp:
                {
                    if (createOrReplace)
                    {
                        if (Temp == null)
                        {
                            if (replacement == null)
                            {
                                Temp = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Temp = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Temp;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<ushort> m_id;
        private SetTempMethodState m_setTempMethod;
        private MethodState m_startMethod;
        private MethodState m_stopMethod;
        private BaseDataVariableState<double> m_temp;
        #endregion
    }
    #endif
    #endregion

    #region SetTempMethodState Class
    #if (!OPCUA_EXCLUDE_SetTempMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetTempMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetTempMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetTempMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvbXNjaHViL/////8EYYIABAAAAAEAEQAA" +
           "AFNldFRlbXBNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetTempMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            double temp = (double)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    temp);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetTempMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double temp);
    #endif
    #endregion
}