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

namespace UAModel.eg
{
    #region AxisTypeState Class
    #if (!OPCUA_EXCLUDE_AxisTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AxisTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public AxisTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.eg.ObjectTypes.AxisType, UAModel.eg.Namespaces.eg, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRggAIBAAAAAQAQAAAAQXhp" +
           "c1R5cGVJbnN0YW5jZQEB7AMBAewD7AMAAP////8EAAAAFWCJCgIAAAABAAoAAABDb29yZHZhbHVlAQF8" +
           "FwAvAD98FwAAAAb/////AwP/////AAAAAARhggoEAAAAAQADAAAASm9nAQFcGwAvAQFcG1wbAAABAf//" +
           "//8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBfhcALgBEfhcAAJYDAAAAAQAqAQESAAAA" +
           "AwAAAHBvcwAH/////wAAAAAAAQAqAQEUAAAABQAAAHNwZWVkAAf/////AAAAAAABACoBARIAAAADAAAA" +
           "ZGlyAAf/////AAAAAAABACgBAQAAAAEAAAADAAAAAQH/////AAAAABVgiQoCAAAAAQAKAAAAbWFjaGl2" +
           "YWx1ZQEBexcALwA/excAAAAG/////wMD/////wAAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQF9FwAvAD99" +
           "FwAAAAb/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> Coordvalue
        {
            get
            {
                return m_coordvalue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coordvalue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coordvalue = value;
            }
        }

        /// <remarks />
        public JogMethodState Jog
        {
            get
            {
                return m_jogMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jogMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jogMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> machivalue
        {
            get
            {
                return m_machivalue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machivalue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machivalue = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Speed
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
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coordvalue != null)
            {
                children.Add(m_coordvalue);
            }

            if (m_jogMethod != null)
            {
                children.Add(m_jogMethod);
            }

            if (m_machivalue != null)
            {
                children.Add(m_machivalue);
            }

            if (m_speed != null)
            {
                children.Add(m_speed);
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
                case UAModel.eg.BrowseNames.Coordvalue:
                {
                    if (createOrReplace)
                    {
                        if (Coordvalue == null)
                        {
                            if (replacement == null)
                            {
                                Coordvalue = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Coordvalue = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Coordvalue;
                    break;
                }

                case UAModel.eg.BrowseNames.Jog:
                {
                    if (createOrReplace)
                    {
                        if (Jog == null)
                        {
                            if (replacement == null)
                            {
                                Jog = new JogMethodState(this);
                            }
                            else
                            {
                                Jog = (JogMethodState)replacement;
                            }
                        }
                    }

                    instance = Jog;
                    break;
                }

                case UAModel.eg.BrowseNames.machivalue:
                {
                    if (createOrReplace)
                    {
                        if (machivalue == null)
                        {
                            if (replacement == null)
                            {
                                machivalue = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                machivalue = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = machivalue;
                    break;
                }

                case UAModel.eg.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Speed = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Speed;
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
        private BaseDataVariableState<int> m_coordvalue;
        private JogMethodState m_jogMethod;
        private BaseDataVariableState<int> m_machivalue;
        private BaseDataVariableState<int> m_speed;
        #endregion
    }
    #endif
    #endregion

    #region TempControlEventState Class
    #if (!OPCUA_EXCLUDE_TempControlEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TempControlEventState : BaseEventState
    {
        #region Constructors
        /// <remarks />
        public TempControlEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.eg.ObjectTypes.TempControlEvent, UAModel.eg.Namespaces.eg, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRggAIBAAAAAQAYAAAAVGVt" +
           "cENvbnRyb2xFdmVudEluc3RhbmNlAQHwAwEB8APwAwAA/////woAAAAVYIkIAgAAAAAABwAAAEV2ZW50" +
           "SWQBAQAAAC4ARAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50VHlwZQEBAAAALgBEABH/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBEABH/////AQH/////AAAA" +
           "ABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAE" +
           "AAAAVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "AAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdlAQEAAAAuAEQAFf////8B" +
           "Af////8AAAAAFWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAKAAAAbWFjaGNvb3JkcwEB0xcALwA/0xcAAAAL/////wMD/////wAAAAAVYIkKAgAAAAEABAAA" +
           "AHRlbXABAdQXAC8AP9QXAAAAC/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> machcoords
        {
            get
            {
                return m_machcoords;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machcoords, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machcoords = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> temp
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
            if (m_machcoords != null)
            {
                children.Add(m_machcoords);
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
                case UAModel.eg.BrowseNames.machcoords:
                {
                    if (createOrReplace)
                    {
                        if (machcoords == null)
                        {
                            if (replacement == null)
                            {
                                machcoords = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                machcoords = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = machcoords;
                    break;
                }

                case UAModel.eg.BrowseNames.temp:
                {
                    if (createOrReplace)
                    {
                        if (temp == null)
                        {
                            if (replacement == null)
                            {
                                temp = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                temp = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = temp;
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
        private BaseDataVariableState<double> m_machcoords;
        private BaseDataVariableState<double> m_temp;
        #endregion
    }
    #endif
    #endregion

    #region IOState Class
    #if (!OPCUA_EXCLUDE_IOState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IOState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public IOState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.eg.ObjectTypes.IO, UAModel.eg.Namespaces.eg, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRggAIBAAAAAQAKAAAASU9J" +
           "bnN0YW5jZQEB6wMBAesD6wMAAP////8GAAAAFWCJCgIAAAABAAYAAABpbnB1dDEBAXQXAC8AP3QXAAAA" +
           "Bv////8DA/////8AAAAAFWCJCgIAAAABAAYAAABpbnB1dDIBAXUXAC8AP3UXAAAABv////8DA/////8A" +
           "AAAAFWCJCgIAAAABAAQAAABvdXQxAQF2FwAvAD92FwAAAAb/////AwP/////AAAAABVgiQoCAAAAAQAE" +
           "AAAAb3V0MgEBdxcALwA/dxcAAAAG/////wMD/////wAAAAAEYYIKBAAAAAEABgAAAFJlYWRJTwEBWhsA" +
           "LwEBWhtaGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXgXAC4ARHgXAACW" +
           "AQAAAAEAKgEBFAAAAAUAAABpbmRleAAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBeRcALgBEeRcAAJYBAAAAAQAqAQEXAAAACAAAAElu" +
           "X3ZhbHVlAAH/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAHAAAAV3Jp" +
           "dGVJTwEBWxsALwEBWxtbGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXoX" +
           "AC4ARHoXAACWAgAAAAEAKgEBFAAAAAUAAABpbmRleAAH/////wAAAAAAAQAqAQESAAAAAwAAAFNldAAH" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> input1
        {
            get
            {
                return m_input1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> input2
        {
            get
            {
                return m_input2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input2 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> out1
        {
            get
            {
                return m_out1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_out1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_out1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> out2
        {
            get
            {
                return m_out2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_out2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_out2 = value;
            }
        }

        /// <remarks />
        public ReadIOMethodState ReadIO
        {
            get
            {
                return m_readIOMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readIOMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readIOMethod = value;
            }
        }

        /// <remarks />
        public WriteIOMethodState WriteIO
        {
            get
            {
                return m_writeIOMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_writeIOMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_writeIOMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input1 != null)
            {
                children.Add(m_input1);
            }

            if (m_input2 != null)
            {
                children.Add(m_input2);
            }

            if (m_out1 != null)
            {
                children.Add(m_out1);
            }

            if (m_out2 != null)
            {
                children.Add(m_out2);
            }

            if (m_readIOMethod != null)
            {
                children.Add(m_readIOMethod);
            }

            if (m_writeIOMethod != null)
            {
                children.Add(m_writeIOMethod);
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
                case UAModel.eg.BrowseNames.input1:
                {
                    if (createOrReplace)
                    {
                        if (input1 == null)
                        {
                            if (replacement == null)
                            {
                                input1 = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                input1 = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = input1;
                    break;
                }

                case UAModel.eg.BrowseNames.input2:
                {
                    if (createOrReplace)
                    {
                        if (input2 == null)
                        {
                            if (replacement == null)
                            {
                                input2 = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                input2 = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = input2;
                    break;
                }

                case UAModel.eg.BrowseNames.out1:
                {
                    if (createOrReplace)
                    {
                        if (out1 == null)
                        {
                            if (replacement == null)
                            {
                                out1 = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                out1 = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = out1;
                    break;
                }

                case UAModel.eg.BrowseNames.out2:
                {
                    if (createOrReplace)
                    {
                        if (out2 == null)
                        {
                            if (replacement == null)
                            {
                                out2 = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                out2 = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = out2;
                    break;
                }

                case UAModel.eg.BrowseNames.ReadIO:
                {
                    if (createOrReplace)
                    {
                        if (ReadIO == null)
                        {
                            if (replacement == null)
                            {
                                ReadIO = new ReadIOMethodState(this);
                            }
                            else
                            {
                                ReadIO = (ReadIOMethodState)replacement;
                            }
                        }
                    }

                    instance = ReadIO;
                    break;
                }

                case UAModel.eg.BrowseNames.WriteIO:
                {
                    if (createOrReplace)
                    {
                        if (WriteIO == null)
                        {
                            if (replacement == null)
                            {
                                WriteIO = new WriteIOMethodState(this);
                            }
                            else
                            {
                                WriteIO = (WriteIOMethodState)replacement;
                            }
                        }
                    }

                    instance = WriteIO;
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
        private BaseDataVariableState<int> m_input1;
        private BaseDataVariableState<int> m_input2;
        private BaseDataVariableState<int> m_out1;
        private BaseDataVariableState<int> m_out2;
        private ReadIOMethodState m_readIOMethod;
        private WriteIOMethodState m_writeIOMethod;
        #endregion
    }
    #endif
    #endregion

    #region LaserState Class
    #if (!OPCUA_EXCLUDE_LaserState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LaserState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public LaserState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.eg.ObjectTypes.Laser, UAModel.eg.Namespaces.eg, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRggAIBAAAAAQANAAAATGFz" +
           "ZXJJbnN0YW5jZQEB7wMBAe8D7wMAAP////8DAAAABGGCCgQAAAABAAgAAABDdHJsb3BlbgEBdBsALwEB" +
           "dBt0GwAAAQH/////AAAAABVgiQoCAAAAAQAJAAAAaW50ZW5zaW9uAQHNFwAvAD/NFwAAAAv/////AwP/" +
           "////AAAAABVgiQoCAAAAAQADAAAAdm9sAQHOFwAvAD/OFwAAAAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Ctrlopen
        {
            get
            {
                return m_ctrlopenMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ctrlopenMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ctrlopenMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> intension
        {
            get
            {
                return m_intension;
            }

            set
            {
                if (!Object.ReferenceEquals(m_intension, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_intension = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> vol
        {
            get
            {
                return m_vol;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vol, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vol = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_ctrlopenMethod != null)
            {
                children.Add(m_ctrlopenMethod);
            }

            if (m_intension != null)
            {
                children.Add(m_intension);
            }

            if (m_vol != null)
            {
                children.Add(m_vol);
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
                case UAModel.eg.BrowseNames.Ctrlopen:
                {
                    if (createOrReplace)
                    {
                        if (Ctrlopen == null)
                        {
                            if (replacement == null)
                            {
                                Ctrlopen = new MethodState(this);
                            }
                            else
                            {
                                Ctrlopen = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Ctrlopen;
                    break;
                }

                case UAModel.eg.BrowseNames.intension:
                {
                    if (createOrReplace)
                    {
                        if (intension == null)
                        {
                            if (replacement == null)
                            {
                                intension = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                intension = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = intension;
                    break;
                }

                case UAModel.eg.BrowseNames.vol:
                {
                    if (createOrReplace)
                    {
                        if (vol == null)
                        {
                            if (replacement == null)
                            {
                                vol = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                vol = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = vol;
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
        private MethodState m_ctrlopenMethod;
        private BaseDataVariableState<double> m_intension;
        private BaseDataVariableState<double> m_vol;
        #endregion
    }
    #endif
    #endregion

    #region mschubState Class
    #if (!OPCUA_EXCLUDE_mschubState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class mschubState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public mschubState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.eg.ObjectTypes.mschub, UAModel.eg.Namespaces.eg, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRggAIBAAAAAQAOAAAAbXNj" +
           "aHViSW5zdGFuY2UBAe0DAQHtA+0DAAD/////CwAAAARggAoBAAAAAQAFAAAAQXhpc3gBAYkTAC8BAewD" +
           "iRMAAP////8EAAAAFWCJCgIAAAABAAoAAABDb29yZHZhbHVlAQF/FwAvAD9/FwAAAAb/////AwP/////" +
           "AAAAAARhggoEAAAAAQADAAAASm9nAQFdGwAvAQFcG10bAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBgBcALgBEgBcAAJYDAAAAAQAqAQESAAAAAwAAAHBvcwAH/////wAAAAAAAQAq" +
           "AQEUAAAABQAAAHNwZWVkAAf/////AAAAAAABACoBARIAAAADAAAAZGlyAAf/////AAAAAAABACgBAQAA" +
           "AAEAAAADAAAAAQH/////AAAAABVgiQoCAAAAAQAKAAAAbWFjaGl2YWx1ZQEBgRcALwA/gRcAAAAG////" +
           "/wMD/////wAAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQGCFwAvAD+CFwAAAAb/////AwP/////AAAAAARg" +
           "gAoBAAAAAQAFAAAAQXhpc3kBAYoTAC8BAewDihMAAP////8EAAAAFWCJCgIAAAABAAoAAABDb29yZHZh" +
           "bHVlAQGDFwAvAD+DFwAAAAb/////AwP/////AAAAAARhggoEAAAAAQADAAAASm9nAQFeGwAvAQFcG14b" +
           "AAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBhBcALgBEhBcAAJYDAAAAAQAq" +
           "AQESAAAAAwAAAHBvcwAH/////wAAAAAAAQAqAQEUAAAABQAAAHNwZWVkAAf/////AAAAAAABACoBARIA" +
           "AAADAAAAZGlyAAf/////AAAAAAABACgBAQAAAAEAAAADAAAAAQH/////AAAAABVgiQoCAAAAAQAKAAAA" +
           "bWFjaGl2YWx1ZQEBhRcALwA/hRcAAAAG/////wMD/////wAAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQGG" +
           "FwAvAD+GFwAAAAb/////AwP/////AAAAAARggAoBAAAAAQAFAAAAQXhpc3oBAYsTAC8BAewDixMAAP//" +
           "//8EAAAAFWCJCgIAAAABAAoAAABDb29yZHZhbHVlAQGHFwAvAD+HFwAAAAb/////AwP/////AAAAAARh" +
           "ggoEAAAAAQADAAAASm9nAQFfGwAvAQFcG18bAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBiBcALgBEiBcAAJYDAAAAAQAqAQESAAAAAwAAAHBvcwAH/////wAAAAAAAQAqAQEUAAAA" +
           "BQAAAHNwZWVkAAf/////AAAAAAABACoBARIAAAADAAAAZGlyAAf/////AAAAAAABACgBAQAAAAEAAAAD" +
           "AAAAAQH/////AAAAABVgiQoCAAAAAQAKAAAAbWFjaGl2YWx1ZQEBiRcALwA/iRcAAAAG/////wMD////" +
           "/wAAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQGKFwAvAD+KFwAAAAb/////AwP/////AAAAAARhggoEAAAA" +
           "AQAEAAAASW5pdAEBZBsALwEBZBtkGwAAAQH/////AAAAAARggAoBAAAAAQAGAAAASU91aW50AQGNEwAv" +
           "AQHrA40TAAD/////BgAAABVgiQoCAAAAAQAGAAAAaW5wdXQxAQGOFwAvAD+OFwAAAAb/////AwP/////" +
           "AAAAABVgiQoCAAAAAQAGAAAAaW5wdXQyAQGPFwAvAD+PFwAAAAb/////AwP/////AAAAABVgiQoCAAAA" +
           "AQAEAAAAb3V0MQEBkBcALwA/kBcAAAAG/////wMD/////wAAAAAVYIkKAgAAAAEABAAAAG91dDIBAZEX" +
           "AC8AP5EXAAAABv////8DA/////8AAAAABGGCCgQAAAABAAYAAABSZWFkSU8BAWEbAC8BAVobYRsAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGSFwAuAESSFwAAlgEAAAABACoBARQA" +
           "AAAFAAAAaW5kZXgAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAZMXAC4ARJMXAACWAQAAAAEAKgEBFwAAAAgAAABJbl92YWx1ZQAB////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEABwAAAFdyaXRlSU8BAWIbAC8B" +
           "AVsbYhsAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGUFwAuAESUFwAAlgIA" +
           "AAABACoBARQAAAAFAAAAaW5kZXgAB/////8AAAAAAAEAKgEBEgAAAAMAAABTZXQAB/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAIAAAABAf////8AAAAABGCACgEAAAABAAkAAABMYXNlclVpbnQBAZcTAC8BAe8DlxMA" +
           "AP////8DAAAABGGCCgQAAAABAAgAAABDdHJsb3BlbgEBdRsALwEBdBt1GwAAAQH/////AAAAABVgiQoC" +
           "AAAAAQAJAAAAaW50ZW5zaW9uAQHPFwAvAD/PFwAAAAv/////AwP/////AAAAABVgiQoCAAAAAQADAAAA" +
           "dm9sAQHQFwAvAD/QFwAAAAv/////AwP/////AAAAAARhggoEAAAAAQAFAAAAUmVzZXQBAWMbAC8BAWMb" +
           "YxsAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAFJ1bnNjcmlwdAEBZRsALwEBZRtlGwAAAQH/////AgAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZUXAC4ARJUXAACWAQAAAAEAKgEBEwAAAAQAAABw" +
           "YXRoAAf/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQGWFwAuAESWFwAAlgEAAAABACoBARQAAAAFAAAAaXNfb2sAAf////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAABAAUAAABSdW50bwEBbxsALwEBbxtvGwAAAQH/////" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbYXAC4ARLYXAACWBAAAAAEAKgEBEwAAAAQA" +
           "AABwb3N4AAf/////AAAAAAABACoBARMAAAAEAAAAcG9zeQAH/////wAAAAAAAQAqAQETAAAABAAAAHBv" +
           "c3oAB/////8AAAAAAAEAKgEBFAAAAAUAAABTcGVlZAAH/////wAAAAAAAQAoAQEAAAABAAAABAAAAAEB" +
           "/////wAAAAAEYIAKAQAAAAEABgAAAFNlbnNvcgEBjBMALwEB6gOMEwAA/////wMAAAAEYYIKBAAAAAEA" +
           "CQAAAGdldFNlbnNvcgEBYBsALwEBWRtgGwAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQGLFwAuAESLFwAAlgIAAAABACoBARMAAAAEAAAAdGVtcAAL/////wAAAAAAAQAqAQETAAAA" +
           "BAAAAGh1bWkAC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCgIAAAABAAQAAABI" +
           "dW1pAQGMFwAvAD+MFwAAAAv/////AwP/////AAAAABVgiQoCAAAAAQAEAAAAdGVtcAEBjRcALwA/jRcA" +
           "AAAL/////wMD/////wAAAAAEYIAKAQAAAAEABgAAAFN0YXR1cwEBlRMALwEB7gOVEwAA/////wgAAAAV" +
           "YIkKAgAAAAEADAAAAGRzcEFsYXJtZmxhZwEBvxcALwA/vxcAAAAG/////wMD/////wAAAAAVYIkKAgAA" +
           "AAEACAAAAEhvbWVmbGFnAQHAFwAvAD/AFwAAAAb/////AwP/////AAAAABVgiQoCAAAAAQAIAAAATGlt" +
           "aXROZWcBAcEXAC8AP8EXAAAABv////8DA/////8AAAAAFWCJCgIAAAABAAgAAABMaW1pdFBvcwEBwhcA" +
           "LwA/whcAAAAG/////wMD/////wAAAAAVYIkKAgAAAAEACQAAAFJlY3ZDb3VudAEBwxcALwA/wxcAAAAG" +
           "/////wMD/////wAAAAAVYIkKAgAAAAEACAAAAFJ1bmNvdW50AQHEFwAvAD/EFwAAAAb/////AwP/////" +
           "AAAAABVgiQoCAAAAAQAJAAAAUnVuc3RhdHVzAQHFFwAvAD/FFwAAAAb/////AwP/////AAAAAARhggoE" +
           "AAAAAQAHAAAAU2V0emVybwEBchsALwEBcRtyGwAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AxisTypeState Axisx
        {
            get
            {
                return m_axisx;
            }

            set
            {
                if (!Object.ReferenceEquals(m_axisx, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_axisx = value;
            }
        }

        /// <remarks />
        public AxisTypeState Axisy
        {
            get
            {
                return m_axisy;
            }

            set
            {
                if (!Object.ReferenceEquals(m_axisy, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_axisy = value;
            }
        }

        /// <remarks />
        public AxisTypeState Axisz
        {
            get
            {
                return m_axisz;
            }

            set
            {
                if (!Object.ReferenceEquals(m_axisz, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_axisz = value;
            }
        }

        /// <remarks />
        public MethodState Init
        {
            get
            {
                return m_initMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_initMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_initMethod = value;
            }
        }

        /// <remarks />
        public IOState IOuint
        {
            get
            {
                return m_iOuint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iOuint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iOuint = value;
            }
        }

        /// <remarks />
        public LaserState LaserUint
        {
            get
            {
                return m_laserUint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_laserUint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_laserUint = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }

        /// <remarks />
        public RunscriptMethodState Runscript
        {
            get
            {
                return m_runscriptMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runscriptMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runscriptMethod = value;
            }
        }

        /// <remarks />
        public RuntoMethodState Runto
        {
            get
            {
                return m_runtoMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runtoMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runtoMethod = value;
            }
        }

        /// <remarks />
        public SensorState Sensor
        {
            get
            {
                return m_sensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sensor = value;
            }
        }

        /// <remarks />
        public RunStatusState Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_axisx != null)
            {
                children.Add(m_axisx);
            }

            if (m_axisy != null)
            {
                children.Add(m_axisy);
            }

            if (m_axisz != null)
            {
                children.Add(m_axisz);
            }

            if (m_initMethod != null)
            {
                children.Add(m_initMethod);
            }

            if (m_iOuint != null)
            {
                children.Add(m_iOuint);
            }

            if (m_laserUint != null)
            {
                children.Add(m_laserUint);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_runscriptMethod != null)
            {
                children.Add(m_runscriptMethod);
            }

            if (m_runtoMethod != null)
            {
                children.Add(m_runtoMethod);
            }

            if (m_sensor != null)
            {
                children.Add(m_sensor);
            }

            if (m_status != null)
            {
                children.Add(m_status);
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
                case UAModel.eg.BrowseNames.Axisx:
                {
                    if (createOrReplace)
                    {
                        if (Axisx == null)
                        {
                            if (replacement == null)
                            {
                                Axisx = new AxisTypeState(this);
                            }
                            else
                            {
                                Axisx = (AxisTypeState)replacement;
                            }
                        }
                    }

                    instance = Axisx;
                    break;
                }

                case UAModel.eg.BrowseNames.Axisy:
                {
                    if (createOrReplace)
                    {
                        if (Axisy == null)
                        {
                            if (replacement == null)
                            {
                                Axisy = new AxisTypeState(this);
                            }
                            else
                            {
                                Axisy = (AxisTypeState)replacement;
                            }
                        }
                    }

                    instance = Axisy;
                    break;
                }

                case UAModel.eg.BrowseNames.Axisz:
                {
                    if (createOrReplace)
                    {
                        if (Axisz == null)
                        {
                            if (replacement == null)
                            {
                                Axisz = new AxisTypeState(this);
                            }
                            else
                            {
                                Axisz = (AxisTypeState)replacement;
                            }
                        }
                    }

                    instance = Axisz;
                    break;
                }

                case UAModel.eg.BrowseNames.Init:
                {
                    if (createOrReplace)
                    {
                        if (Init == null)
                        {
                            if (replacement == null)
                            {
                                Init = new MethodState(this);
                            }
                            else
                            {
                                Init = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Init;
                    break;
                }

                case UAModel.eg.BrowseNames.IOuint:
                {
                    if (createOrReplace)
                    {
                        if (IOuint == null)
                        {
                            if (replacement == null)
                            {
                                IOuint = new IOState(this);
                            }
                            else
                            {
                                IOuint = (IOState)replacement;
                            }
                        }
                    }

                    instance = IOuint;
                    break;
                }

                case UAModel.eg.BrowseNames.LaserUint:
                {
                    if (createOrReplace)
                    {
                        if (LaserUint == null)
                        {
                            if (replacement == null)
                            {
                                LaserUint = new LaserState(this);
                            }
                            else
                            {
                                LaserUint = (LaserState)replacement;
                            }
                        }
                    }

                    instance = LaserUint;
                    break;
                }

                case UAModel.eg.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }

                case UAModel.eg.BrowseNames.Runscript:
                {
                    if (createOrReplace)
                    {
                        if (Runscript == null)
                        {
                            if (replacement == null)
                            {
                                Runscript = new RunscriptMethodState(this);
                            }
                            else
                            {
                                Runscript = (RunscriptMethodState)replacement;
                            }
                        }
                    }

                    instance = Runscript;
                    break;
                }

                case UAModel.eg.BrowseNames.Runto:
                {
                    if (createOrReplace)
                    {
                        if (Runto == null)
                        {
                            if (replacement == null)
                            {
                                Runto = new RuntoMethodState(this);
                            }
                            else
                            {
                                Runto = (RuntoMethodState)replacement;
                            }
                        }
                    }

                    instance = Runto;
                    break;
                }

                case UAModel.eg.BrowseNames.Sensor:
                {
                    if (createOrReplace)
                    {
                        if (Sensor == null)
                        {
                            if (replacement == null)
                            {
                                Sensor = new SensorState(this);
                            }
                            else
                            {
                                Sensor = (SensorState)replacement;
                            }
                        }
                    }

                    instance = Sensor;
                    break;
                }

                case UAModel.eg.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new RunStatusState(this);
                            }
                            else
                            {
                                Status = (RunStatusState)replacement;
                            }
                        }
                    }

                    instance = Status;
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
        private AxisTypeState m_axisx;
        private AxisTypeState m_axisy;
        private AxisTypeState m_axisz;
        private MethodState m_initMethod;
        private IOState m_iOuint;
        private LaserState m_laserUint;
        private MethodState m_resetMethod;
        private RunscriptMethodState m_runscriptMethod;
        private RuntoMethodState m_runtoMethod;
        private SensorState m_sensor;
        private RunStatusState m_status;
        #endregion
    }
    #endif
    #endregion

    #region RunStatusState Class
    #if (!OPCUA_EXCLUDE_RunStatusState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RunStatusState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public RunStatusState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.eg.ObjectTypes.RunStatus, UAModel.eg.Namespaces.eg, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRggAIBAAAAAQARAAAAUnVu" +
           "U3RhdHVzSW5zdGFuY2UBAe4DAQHuA+4DAAD/////CAAAABVgiQoCAAAAAQAMAAAAZHNwQWxhcm1mbGFn" +
           "AQG+FwAvAD++FwAAAAb/////AwP/////AAAAABVgiQoCAAAAAQAIAAAASG9tZWZsYWcBAbsXAC8AP7sX" +
           "AAAABv////8DA/////8AAAAAFWCJCgIAAAABAAgAAABMaW1pdE5lZwEBvRcALwA/vRcAAAAG/////wMD" +
           "/////wAAAAAVYIkKAgAAAAEACAAAAExpbWl0UG9zAQG8FwAvAD+8FwAAAAb/////AwP/////AAAAABVg" +
           "iQoCAAAAAQAJAAAAUmVjdkNvdW50AQG6FwAvAD+6FwAAAAb/////AwP/////AAAAABVgiQoCAAAAAQAI" +
           "AAAAUnVuY291bnQBAbkXAC8AP7kXAAAABv////8DA/////8AAAAAFWCJCgIAAAABAAkAAABSdW5zdGF0" +
           "dXMBAbgXAC8AP7gXAAAABv////8DA/////8AAAAABGGCCgQAAAABAAcAAABTZXR6ZXJvAQFxGwAvAQFx" +
           "G3EbAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> dspAlarmflag
        {
            get
            {
                return m_dspAlarmflag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dspAlarmflag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dspAlarmflag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Homeflag
        {
            get
            {
                return m_homeflag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_homeflag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_homeflag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> LimitNeg
        {
            get
            {
                return m_limitNeg;
            }

            set
            {
                if (!Object.ReferenceEquals(m_limitNeg, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_limitNeg = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> LimitPos
        {
            get
            {
                return m_limitPos;
            }

            set
            {
                if (!Object.ReferenceEquals(m_limitPos, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_limitPos = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> RecvCount
        {
            get
            {
                return m_recvCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_recvCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_recvCount = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Runcount
        {
            get
            {
                return m_runcount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runcount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runcount = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Runstatus
        {
            get
            {
                return m_runstatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runstatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runstatus = value;
            }
        }

        /// <remarks />
        public MethodState Setzero
        {
            get
            {
                return m_setzeroMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setzeroMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setzeroMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_dspAlarmflag != null)
            {
                children.Add(m_dspAlarmflag);
            }

            if (m_homeflag != null)
            {
                children.Add(m_homeflag);
            }

            if (m_limitNeg != null)
            {
                children.Add(m_limitNeg);
            }

            if (m_limitPos != null)
            {
                children.Add(m_limitPos);
            }

            if (m_recvCount != null)
            {
                children.Add(m_recvCount);
            }

            if (m_runcount != null)
            {
                children.Add(m_runcount);
            }

            if (m_runstatus != null)
            {
                children.Add(m_runstatus);
            }

            if (m_setzeroMethod != null)
            {
                children.Add(m_setzeroMethod);
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
                case UAModel.eg.BrowseNames.dspAlarmflag:
                {
                    if (createOrReplace)
                    {
                        if (dspAlarmflag == null)
                        {
                            if (replacement == null)
                            {
                                dspAlarmflag = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                dspAlarmflag = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = dspAlarmflag;
                    break;
                }

                case UAModel.eg.BrowseNames.Homeflag:
                {
                    if (createOrReplace)
                    {
                        if (Homeflag == null)
                        {
                            if (replacement == null)
                            {
                                Homeflag = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Homeflag = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Homeflag;
                    break;
                }

                case UAModel.eg.BrowseNames.LimitNeg:
                {
                    if (createOrReplace)
                    {
                        if (LimitNeg == null)
                        {
                            if (replacement == null)
                            {
                                LimitNeg = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                LimitNeg = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = LimitNeg;
                    break;
                }

                case UAModel.eg.BrowseNames.LimitPos:
                {
                    if (createOrReplace)
                    {
                        if (LimitPos == null)
                        {
                            if (replacement == null)
                            {
                                LimitPos = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                LimitPos = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = LimitPos;
                    break;
                }

                case UAModel.eg.BrowseNames.RecvCount:
                {
                    if (createOrReplace)
                    {
                        if (RecvCount == null)
                        {
                            if (replacement == null)
                            {
                                RecvCount = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                RecvCount = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = RecvCount;
                    break;
                }

                case UAModel.eg.BrowseNames.Runcount:
                {
                    if (createOrReplace)
                    {
                        if (Runcount == null)
                        {
                            if (replacement == null)
                            {
                                Runcount = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Runcount = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Runcount;
                    break;
                }

                case UAModel.eg.BrowseNames.Runstatus:
                {
                    if (createOrReplace)
                    {
                        if (Runstatus == null)
                        {
                            if (replacement == null)
                            {
                                Runstatus = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Runstatus = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Runstatus;
                    break;
                }

                case UAModel.eg.BrowseNames.Setzero:
                {
                    if (createOrReplace)
                    {
                        if (Setzero == null)
                        {
                            if (replacement == null)
                            {
                                Setzero = new MethodState(this);
                            }
                            else
                            {
                                Setzero = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Setzero;
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
        private BaseDataVariableState<int> m_dspAlarmflag;
        private BaseDataVariableState<int> m_homeflag;
        private BaseDataVariableState<int> m_limitNeg;
        private BaseDataVariableState<int> m_limitPos;
        private BaseDataVariableState<int> m_recvCount;
        private BaseDataVariableState<int> m_runcount;
        private BaseDataVariableState<int> m_runstatus;
        private MethodState m_setzeroMethod;
        #endregion
    }
    #endif
    #endregion

    #region SensorState Class
    #if (!OPCUA_EXCLUDE_SensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public SensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.eg.ObjectTypes.Sensor, UAModel.eg.Namespaces.eg, namespaceUris);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRggAIBAAAAAQAOAAAAU2Vu" +
           "c29ySW5zdGFuY2UBAeoDAQHqA+oDAAD/////AwAAAARhggoEAAAAAQAJAAAAZ2V0U2Vuc29yAQFZGwAv" +
           "AQFZG1kbAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAXMXAC4ARHMXAACW" +
           "AgAAAAEAKgEBEwAAAAQAAAB0ZW1wAAv/////AAAAAAABACoBARMAAAAEAAAAaHVtaQAL/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAVYIkKAgAAAAEABAAAAEh1bWkBAXIXAC8AP3IXAAAAC///" +
           "//8DA/////8AAAAAFWCJCgIAAAABAAQAAAB0ZW1wAQFxFwAvAD9xFwAAAAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public getSensorMethodState getSensor
        {
            get
            {
                return m_getSensorMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getSensorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getSensorMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Humi
        {
            get
            {
                return m_humi;
            }

            set
            {
                if (!Object.ReferenceEquals(m_humi, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_humi = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> temp
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
            if (m_getSensorMethod != null)
            {
                children.Add(m_getSensorMethod);
            }

            if (m_humi != null)
            {
                children.Add(m_humi);
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
                case UAModel.eg.BrowseNames.getSensor:
                {
                    if (createOrReplace)
                    {
                        if (getSensor == null)
                        {
                            if (replacement == null)
                            {
                                getSensor = new getSensorMethodState(this);
                            }
                            else
                            {
                                getSensor = (getSensorMethodState)replacement;
                            }
                        }
                    }

                    instance = getSensor;
                    break;
                }

                case UAModel.eg.BrowseNames.Humi:
                {
                    if (createOrReplace)
                    {
                        if (Humi == null)
                        {
                            if (replacement == null)
                            {
                                Humi = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Humi = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Humi;
                    break;
                }

                case UAModel.eg.BrowseNames.temp:
                {
                    if (createOrReplace)
                    {
                        if (temp == null)
                        {
                            if (replacement == null)
                            {
                                temp = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                temp = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = temp;
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
        private getSensorMethodState m_getSensorMethod;
        private BaseDataVariableState<double> m_humi;
        private BaseDataVariableState<double> m_temp;
        #endregion
    }
    #endif
    #endregion

    #region JogMethodState Class
    #if (!OPCUA_EXCLUDE_JogMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class JogMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public JogMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new JogMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRhggAEAAAAAQANAAAASm9n" +
           "TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public JogMethodStateMethodCallHandler OnCall;
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

            uint pos = (uint)_inputArguments[0];
            uint speed = (uint)_inputArguments[1];
            uint dir = (uint)_inputArguments[2];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    pos,
                    speed,
                    dir);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult JogMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint pos,
        uint speed,
        uint dir);
    #endif
    #endregion

    #region ReadIOMethodState Class
    #if (!OPCUA_EXCLUDE_ReadIOMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReadIOMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ReadIOMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ReadIOMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRhggAEAAAAAQAQAAAAUmVh" +
           "ZElPTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ReadIOMethodStateMethodCallHandler OnCall;
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

            uint index = (uint)_inputArguments[0];

            bool in_value = (bool)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    index,
                    ref in_value);
            }

            _outputArguments[0] = in_value;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ReadIOMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint index,
        ref bool in_value);
    #endif
    #endregion

    #region WriteIOMethodState Class
    #if (!OPCUA_EXCLUDE_WriteIOMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WriteIOMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public WriteIOMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new WriteIOMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRhggAEAAAAAQARAAAAV3Jp" +
           "dGVJT01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public WriteIOMethodStateMethodCallHandler OnCall;
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

            uint index = (uint)_inputArguments[0];
            uint set = (uint)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    index,
                    set);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult WriteIOMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint index,
        uint set);
    #endif
    #endregion

    #region RunscriptMethodState Class
    #if (!OPCUA_EXCLUDE_RunscriptMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RunscriptMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RunscriptMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RunscriptMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRhggAEAAAAAQATAAAAUnVu" +
           "c2NyaXB0TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RunscriptMethodStateMethodCallHandler OnCall;
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

            uint path = (uint)_inputArguments[0];

            bool is_ok = (bool)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    path,
                    ref is_ok);
            }

            _outputArguments[0] = is_ok;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RunscriptMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint path,
        ref bool is_ok);
    #endif
    #endregion

    #region RuntoMethodState Class
    #if (!OPCUA_EXCLUDE_RuntoMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RuntoMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RuntoMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RuntoMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRhggAEAAAAAQAPAAAAUnVu" +
           "dG9NZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RuntoMethodStateMethodCallHandler OnCall;
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

            uint posx = (uint)_inputArguments[0];
            uint posy = (uint)_inputArguments[1];
            uint posz = (uint)_inputArguments[2];
            uint speed = (uint)_inputArguments[3];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    posx,
                    posy,
                    posz,
                    speed);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RuntoMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint posx,
        uint posy,
        uint posz,
        uint speed);
    #endif
    #endregion

    #region getSensorMethodState Class
    #if (!OPCUA_EXCLUDE_getSensorMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class getSensorMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public getSensorMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new getSensorMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8veW91cm9yZ2FuaXNhdGlvbi5vcmcvZWcv/////wRhggAEAAAAAQATAAAAZ2V0" +
           "U2Vuc29yTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public getSensorMethodStateMethodCallHandler OnCall;
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

            double temp = (double)_outputArguments[0];
            double humi = (double)_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref temp,
                    ref humi);
            }

            _outputArguments[0] = temp;
            _outputArguments[1] = humi;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult getSensorMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref double temp,
        ref double humi);
    #endif
    #endregion
}