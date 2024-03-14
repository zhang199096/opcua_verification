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

namespace UAModel.defaultsmodeler
{
    #region SensorTypeState Class
    #if (!OPCUA_EXCLUDE_SensorTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public SensorTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.defaultsmodeler.ObjectTypes.SensorType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vZnJlZW9wY3VhL2RlZmF1bHRzL21vZGVsZXL/////BGCAAgEAAAABABIAAABT" +
           "ZW5zb3JUeXBlSW5zdGFuY2UBAd4HAQHeB94HAAD/////BAAAADViiQoCAAAAAQAPAAAAU2FtcGxlQXJl" +
           "YVRlbXAxAQHfBwMAAAAADwAAAFNhbXBsZUFyZWFUZW1wMQAvAD/fBwAAAAv/////AQEB/////wAAAAA1" +
           "YokKAgAAAAEADwAAAFNhbXBsZUFyZWFUZW1wMgEB4AcDAAAAAA8AAABTYW1wbGVBcmVhVGVtcDIALwA/" +
           "4AcAAAAL/////wEBAf////8AAAAANWKJCgIAAAABAA8AAABTYW1wbGVBcmVhVGVtcDMBAeEHAwAAAAAP" +
           "AAAAU2FtcGxlQXJlYVRlbXAzAC8AP+EHAAAAC/////8BAQH/////AAAAADViiQoCAAAAAQAPAAAAU2Ft" +
           "cGxlQXJlYVRlbXA0AQHiBwMAAAAADwAAAFNhbXBsZUFyZWFUZW1wNAAvAD/iBwAAAAv/////AQEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> SampleAreaTemp1
        {
            get
            {
                return m_sampleAreaTemp1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleAreaTemp1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleAreaTemp1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> SampleAreaTemp2
        {
            get
            {
                return m_sampleAreaTemp2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleAreaTemp2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleAreaTemp2 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> SampleAreaTemp3
        {
            get
            {
                return m_sampleAreaTemp3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleAreaTemp3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleAreaTemp3 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> SampleAreaTemp4
        {
            get
            {
                return m_sampleAreaTemp4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleAreaTemp4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleAreaTemp4 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_sampleAreaTemp1 != null)
            {
                children.Add(m_sampleAreaTemp1);
            }

            if (m_sampleAreaTemp2 != null)
            {
                children.Add(m_sampleAreaTemp2);
            }

            if (m_sampleAreaTemp3 != null)
            {
                children.Add(m_sampleAreaTemp3);
            }

            if (m_sampleAreaTemp4 != null)
            {
                children.Add(m_sampleAreaTemp4);
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
                case UAModel.defaultsmodeler.BrowseNames.SampleAreaTemp1:
                {
                    if (createOrReplace)
                    {
                        if (SampleAreaTemp1 == null)
                        {
                            if (replacement == null)
                            {
                                SampleAreaTemp1 = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                SampleAreaTemp1 = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleAreaTemp1;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.SampleAreaTemp2:
                {
                    if (createOrReplace)
                    {
                        if (SampleAreaTemp2 == null)
                        {
                            if (replacement == null)
                            {
                                SampleAreaTemp2 = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                SampleAreaTemp2 = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleAreaTemp2;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.SampleAreaTemp3:
                {
                    if (createOrReplace)
                    {
                        if (SampleAreaTemp3 == null)
                        {
                            if (replacement == null)
                            {
                                SampleAreaTemp3 = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                SampleAreaTemp3 = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleAreaTemp3;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.SampleAreaTemp4:
                {
                    if (createOrReplace)
                    {
                        if (SampleAreaTemp4 == null)
                        {
                            if (replacement == null)
                            {
                                SampleAreaTemp4 = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                SampleAreaTemp4 = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleAreaTemp4;
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
        private BaseDataVariableState<double> m_sampleAreaTemp1;
        private BaseDataVariableState<double> m_sampleAreaTemp2;
        private BaseDataVariableState<double> m_sampleAreaTemp3;
        private BaseDataVariableState<double> m_sampleAreaTemp4;
        #endregion
    }
    #endif
    #endregion

    #region MechineAxisTypeState Class
    #if (!OPCUA_EXCLUDE_MechineAxisTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MechineAxisTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MechineAxisTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.defaultsmodeler.ObjectTypes.MechineAxisType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vZnJlZW9wY3VhL2RlZmF1bHRzL21vZGVsZXL/////BGCAAgEAAAABABcAAABN" +
           "ZWNoaW5lQXhpc1R5cGVJbnN0YW5jZQEB4wcBAeMH4wcAAP////8DAAAANWKJCgIAAAABAAwAAABsb2Nh" +
           "dGlvbkF4aXMBAeQHAwAAAAAMAAAAbG9jYXRpb25BeGlzAC8AP+QHAAAAB/////8BAQH/////AAAAADVi" +
           "iQoCAAAAAQANAAAATWFjaENvb3JkQXhpcwEB5QcDAAAAAA0AAABNYWNoQ29vcmRBeGlzAC8AP+UHAAAA" +
           "B/////8BAQH/////AAAAADViiQoCAAAAAQAMAAAAZmVlZFJhdGVBeGlzAQHmBwMAAAAADAAAAGZlZWRS" +
           "YXRlQXhpcwAvAD/mBwAAAAf/////AQEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<uint> locationAxis
        {
            get
            {
                return m_locationAxis;
            }

            set
            {
                if (!Object.ReferenceEquals(m_locationAxis, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_locationAxis = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> MachCoordAxis
        {
            get
            {
                return m_machCoordAxis;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machCoordAxis, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machCoordAxis = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> feedRateAxis
        {
            get
            {
                return m_feedRateAxis;
            }

            set
            {
                if (!Object.ReferenceEquals(m_feedRateAxis, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_feedRateAxis = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_locationAxis != null)
            {
                children.Add(m_locationAxis);
            }

            if (m_machCoordAxis != null)
            {
                children.Add(m_machCoordAxis);
            }

            if (m_feedRateAxis != null)
            {
                children.Add(m_feedRateAxis);
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
                case UAModel.defaultsmodeler.BrowseNames.locationAxis:
                {
                    if (createOrReplace)
                    {
                        if (locationAxis == null)
                        {
                            if (replacement == null)
                            {
                                locationAxis = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                locationAxis = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = locationAxis;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.MachCoordAxis:
                {
                    if (createOrReplace)
                    {
                        if (MachCoordAxis == null)
                        {
                            if (replacement == null)
                            {
                                MachCoordAxis = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                MachCoordAxis = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = MachCoordAxis;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.feedRateAxis:
                {
                    if (createOrReplace)
                    {
                        if (feedRateAxis == null)
                        {
                            if (replacement == null)
                            {
                                feedRateAxis = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                feedRateAxis = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = feedRateAxis;
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
        private BaseDataVariableState<uint> m_locationAxis;
        private BaseDataVariableState<uint> m_machCoordAxis;
        private BaseDataVariableState<uint> m_feedRateAxis;
        #endregion
    }
    #endif
    #endregion

    #region IOTypeState Class
    #if (!OPCUA_EXCLUDE_IOTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IOTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public IOTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.defaultsmodeler.ObjectTypes.IOType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vZnJlZW9wY3VhL2RlZmF1bHRzL21vZGVsZXL/////BGCAAgEAAAABAA4AAABJ" +
           "T1R5cGVJbnN0YW5jZQEB5wcBAecH5wcAAP////8FAAAANWKJCgIAAAABAA4AAABncGlvSW4xc2lnRmxh" +
           "ZwEB6AcDAAAAAA4AAABncGlvSW4xc2lnRmxhZwAvAD/oBwAAAAf/////AQEB/////wAAAAA1YokKAgAA" +
           "AAEADgAAAGdwaW9JbjJzaWdGbGFnAQHpBwMAAAAADgAAAGdwaW9JbjJzaWdGbGFnAC8AP+kHAAAAB///" +
           "//8BAQH/////AAAAADViiQoCAAAAAQAPAAAAZ3Bpb091dDFzaWdGbGFnAQHqBwMAAAAADwAAAGdwaW9P" +
           "dXQxc2lnRmxhZwAvAD/qBwAAAAf/////AQEB/////wAAAAA1YokKAgAAAAEADwAAAGdwaW9PdXQyc2ln" +
           "RmxhZwEB6wcDAAAAAA8AAABncGlvT3V0MnNpZ0ZsYWcALwA/6wcAAAAH/////wEBAf////8AAAAAJGGC" +
           "CgQAAAABAAYAAABSZWFkSU8BASEIAwAAAAAGAAAAUmVhZElPAC8BASEIIQgAAAEB/////wIAAAA1YIkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEiCAMAAAAADgAAAElucHV0QXJndW1lbnRzAC4ARCIIAAAB" +
           "ACgBAAAAAAEB/////wAAAAA1YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBIwgDAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMALgBEIwgAAAEAKAEAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<uint> gpioIn1sigFlag
        {
            get
            {
                return m_gpioIn1sigFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gpioIn1sigFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gpioIn1sigFlag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> gpioIn2sigFlag
        {
            get
            {
                return m_gpioIn2sigFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gpioIn2sigFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gpioIn2sigFlag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> gpioOut1sigFlag
        {
            get
            {
                return m_gpioOut1sigFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gpioOut1sigFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gpioOut1sigFlag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> gpioOut2sigFlag
        {
            get
            {
                return m_gpioOut2sigFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gpioOut2sigFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gpioOut2sigFlag = value;
            }
        }

        /// <remarks />
        public MethodState ReadIO
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
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_gpioIn1sigFlag != null)
            {
                children.Add(m_gpioIn1sigFlag);
            }

            if (m_gpioIn2sigFlag != null)
            {
                children.Add(m_gpioIn2sigFlag);
            }

            if (m_gpioOut1sigFlag != null)
            {
                children.Add(m_gpioOut1sigFlag);
            }

            if (m_gpioOut2sigFlag != null)
            {
                children.Add(m_gpioOut2sigFlag);
            }

            if (m_readIOMethod != null)
            {
                children.Add(m_readIOMethod);
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
                case UAModel.defaultsmodeler.BrowseNames.gpioIn1sigFlag:
                {
                    if (createOrReplace)
                    {
                        if (gpioIn1sigFlag == null)
                        {
                            if (replacement == null)
                            {
                                gpioIn1sigFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                gpioIn1sigFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = gpioIn1sigFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.gpioIn2sigFlag:
                {
                    if (createOrReplace)
                    {
                        if (gpioIn2sigFlag == null)
                        {
                            if (replacement == null)
                            {
                                gpioIn2sigFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                gpioIn2sigFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = gpioIn2sigFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.gpioOut1sigFlag:
                {
                    if (createOrReplace)
                    {
                        if (gpioOut1sigFlag == null)
                        {
                            if (replacement == null)
                            {
                                gpioOut1sigFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                gpioOut1sigFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = gpioOut1sigFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.gpioOut2sigFlag:
                {
                    if (createOrReplace)
                    {
                        if (gpioOut2sigFlag == null)
                        {
                            if (replacement == null)
                            {
                                gpioOut2sigFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                gpioOut2sigFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = gpioOut2sigFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.ReadIO:
                {
                    if (createOrReplace)
                    {
                        if (ReadIO == null)
                        {
                            if (replacement == null)
                            {
                                ReadIO = new MethodState(this);
                            }
                            else
                            {
                                ReadIO = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ReadIO;
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
        private BaseDataVariableState<uint> m_gpioIn1sigFlag;
        private BaseDataVariableState<uint> m_gpioIn2sigFlag;
        private BaseDataVariableState<uint> m_gpioOut1sigFlag;
        private BaseDataVariableState<uint> m_gpioOut2sigFlag;
        private MethodState m_readIOMethod;
        #endregion
    }
    #endif
    #endregion

    #region LimitInfoTypeState Class
    #if (!OPCUA_EXCLUDE_LimitInfoTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LimitInfoTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public LimitInfoTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.defaultsmodeler.ObjectTypes.LimitInfoType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vZnJlZW9wY3VhL2RlZmF1bHRzL21vZGVsZXL/////BGCAAgEAAAABABUAAABM" +
           "aW1pdEluZm9UeXBlSW5zdGFuY2UBAewHAQHsB+wHAAD/////BAAAADViiQoCAAAAAQARAAAAcG9zdEhh" +
           "cmRMaW1pdEZsYWcBAe0HAwAAAAARAAAAcG9zdEhhcmRMaW1pdEZsYWcALwA/7QcAAAAH/////wEBAf//" +
           "//8AAAAANWKJCgIAAAABABEAAABuZWd0SGFyZExpbWl0RmxhZwEB7gcDAAAAABEAAABuZWd0SGFyZExp" +
           "bWl0RmxhZwAvAD/uBwAAAAf/////AQEB/////wAAAAA1YokKAgAAAAEAEQAAAHBvc3RTb2Z0TGltaXRG" +
           "bGFnAQHvBwMAAAAAEQAAAHBvc3RTb2Z0TGltaXRGbGFnAC8AP+8HAAAAB/////8BAQH/////AAAAADVi" +
           "iQoCAAAAAQARAAAAbmVndFNvZnRMaW1pdEZsYWcBAfAHAwAAAAARAAAAbmVndFNvZnRMaW1pdEZsYWcA" +
           "LwA/8AcAAAAH/////wEBAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<uint> postHardLimitFlag
        {
            get
            {
                return m_postHardLimitFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_postHardLimitFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_postHardLimitFlag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> negtHardLimitFlag
        {
            get
            {
                return m_negtHardLimitFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_negtHardLimitFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_negtHardLimitFlag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> postSoftLimitFlag
        {
            get
            {
                return m_postSoftLimitFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_postSoftLimitFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_postSoftLimitFlag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> negtSoftLimitFlag
        {
            get
            {
                return m_negtSoftLimitFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_negtSoftLimitFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_negtSoftLimitFlag = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_postHardLimitFlag != null)
            {
                children.Add(m_postHardLimitFlag);
            }

            if (m_negtHardLimitFlag != null)
            {
                children.Add(m_negtHardLimitFlag);
            }

            if (m_postSoftLimitFlag != null)
            {
                children.Add(m_postSoftLimitFlag);
            }

            if (m_negtSoftLimitFlag != null)
            {
                children.Add(m_negtSoftLimitFlag);
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
                case UAModel.defaultsmodeler.BrowseNames.postHardLimitFlag:
                {
                    if (createOrReplace)
                    {
                        if (postHardLimitFlag == null)
                        {
                            if (replacement == null)
                            {
                                postHardLimitFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                postHardLimitFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = postHardLimitFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.negtHardLimitFlag:
                {
                    if (createOrReplace)
                    {
                        if (negtHardLimitFlag == null)
                        {
                            if (replacement == null)
                            {
                                negtHardLimitFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                negtHardLimitFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = negtHardLimitFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.postSoftLimitFlag:
                {
                    if (createOrReplace)
                    {
                        if (postSoftLimitFlag == null)
                        {
                            if (replacement == null)
                            {
                                postSoftLimitFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                postSoftLimitFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = postSoftLimitFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.negtSoftLimitFlag:
                {
                    if (createOrReplace)
                    {
                        if (negtSoftLimitFlag == null)
                        {
                            if (replacement == null)
                            {
                                negtSoftLimitFlag = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                negtSoftLimitFlag = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = negtSoftLimitFlag;
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
        private BaseDataVariableState<uint> m_postHardLimitFlag;
        private BaseDataVariableState<uint> m_negtHardLimitFlag;
        private BaseDataVariableState<uint> m_postSoftLimitFlag;
        private BaseDataVariableState<uint> m_negtSoftLimitFlag;
        #endregion
    }
    #endif
    #endregion

    #region RunStatusTypeState Class
    #if (!OPCUA_EXCLUDE_RunStatusTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RunStatusTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public RunStatusTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.defaultsmodeler.ObjectTypes.RunStatusType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vZnJlZW9wY3VhL2RlZmF1bHRzL21vZGVsZXL/////BGCAAgEAAAABABUAAABS" +
           "dW5TdGF0dXNUeXBlSW5zdGFuY2UBAfEHAQHxB/EHAAD/////BQAAADViiQoCAAAAAQAHAAAAUnVuTW9k" +
           "ZQEB8gcDAAAAAAcAAABSdW5Nb2RlAC8AP/IHAAAAB/////8BAQH/////AAAAADViiQoCAAAAAQAIAAAA" +
           "UnVuQ291bnQBAfMHAwAAAAAIAAAAUnVuQ291bnQALwA/8wcAAAAH/////wEBAf////8AAAAANWKJCgIA" +
           "AAABAAgAAABSY3ZDb3VudAEB9AcDAAAAAAgAAABSY3ZDb3VudAAvAD/0BwAAAAf/////AQEB/////wAA" +
           "AAA1YokKAgAAAAEADAAAAGhvbWVDbXBsRmxhZwEB9QcDAAAAAAwAAABob21lQ21wbEZsYWcALwA/9QcA" +
           "AAAP/////wEBAf////8AAAAANWKJCgIAAAABAAwAAABkc3BBbGFybUZsYWcBAfYHAwAAAAAMAAAAZHNw" +
           "QWxhcm1GbGFnAC8AP/YHAAAAD/////8BAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<uint> RunMode
        {
            get
            {
                return m_runMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runMode = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> RunCount
        {
            get
            {
                return m_runCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runCount = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> RcvCount
        {
            get
            {
                return m_rcvCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rcvCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rcvCount = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<byte[]> homeCmplFlag
        {
            get
            {
                return m_homeCmplFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_homeCmplFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_homeCmplFlag = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<byte[]> dspAlarmFlag
        {
            get
            {
                return m_dspAlarmFlag;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dspAlarmFlag, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dspAlarmFlag = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_runMode != null)
            {
                children.Add(m_runMode);
            }

            if (m_runCount != null)
            {
                children.Add(m_runCount);
            }

            if (m_rcvCount != null)
            {
                children.Add(m_rcvCount);
            }

            if (m_homeCmplFlag != null)
            {
                children.Add(m_homeCmplFlag);
            }

            if (m_dspAlarmFlag != null)
            {
                children.Add(m_dspAlarmFlag);
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
                case UAModel.defaultsmodeler.BrowseNames.RunMode:
                {
                    if (createOrReplace)
                    {
                        if (RunMode == null)
                        {
                            if (replacement == null)
                            {
                                RunMode = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                RunMode = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = RunMode;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.RunCount:
                {
                    if (createOrReplace)
                    {
                        if (RunCount == null)
                        {
                            if (replacement == null)
                            {
                                RunCount = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                RunCount = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = RunCount;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.RcvCount:
                {
                    if (createOrReplace)
                    {
                        if (RcvCount == null)
                        {
                            if (replacement == null)
                            {
                                RcvCount = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                RcvCount = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = RcvCount;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.homeCmplFlag:
                {
                    if (createOrReplace)
                    {
                        if (homeCmplFlag == null)
                        {
                            if (replacement == null)
                            {
                                homeCmplFlag = new BaseDataVariableState<byte[]>(this);
                            }
                            else
                            {
                                homeCmplFlag = (BaseDataVariableState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = homeCmplFlag;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.dspAlarmFlag:
                {
                    if (createOrReplace)
                    {
                        if (dspAlarmFlag == null)
                        {
                            if (replacement == null)
                            {
                                dspAlarmFlag = new BaseDataVariableState<byte[]>(this);
                            }
                            else
                            {
                                dspAlarmFlag = (BaseDataVariableState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = dspAlarmFlag;
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
        private BaseDataVariableState<uint> m_runMode;
        private BaseDataVariableState<uint> m_runCount;
        private BaseDataVariableState<uint> m_rcvCount;
        private BaseDataVariableState<byte[]> m_homeCmplFlag;
        private BaseDataVariableState<byte[]> m_dspAlarmFlag;
        #endregion
    }
    #endif
    #endregion

    #region ControlEventTypeState Class
    #if (!OPCUA_EXCLUDE_ControlEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControlEventTypeState : BaseEventState
    {
        #region Constructors
        /// <remarks />
        public ControlEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.defaultsmodeler.ObjectTypes.ControlEventType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler, namespaceUris);
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
           "AQAAACEAAABodHRwOi8vZnJlZW9wY3VhL2RlZmF1bHRzL21vZGVsZXL/////BGCAAgEAAAABABgAAABD" +
           "b250cm9sRXZlbnRUeXBlSW5zdGFuY2UBAfcHAQH3B/cHAAD/////CgAAABVgiQgCAAAAAAAHAAAARXZl" +
           "bnRJZAEBAAAALgBEAA//////AQH/////AAAAABVgiQgCAAAAAAAJAAAARXZlbnRUeXBlAQEAAAAuAEQA" +
           "Ef////8BAf////8AAAAAFWCJCAIAAAAAAAoAAABTb3VyY2VOb2RlAQEAAAAuAEQAEf////8BAf////8A" +
           "AAAAFWCJCAIAAAAAAAoAAABTb3VyY2VOYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAA" +
           "AAQAAABUaW1lAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAACwAAAFJlY2VpdmVUaW1l" +
           "AQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAE1lc3NhZ2UBAQAAAC4ARAAV////" +
           "/wEB/////wAAAAAVYIkIAgAAAAAACAAAAFNldmVyaXR5AQEAAAAuAEQABf////8BAf////8AAAAANWKJ" +
           "CgIAAAABAAsAAAB0ZW1wZXJhdHVyZQEB+AcDAAAAAAsAAAB0ZW1wZXJhdHVyZQAuAET4BwAAAAv/////" +
           "AQEB/////wAAAAA1YokKAgAAAAEADQAAAE1hY2hDb29yZEF4aXMBAfkHAwAAAAANAAAATWFjaENvb3Jk" +
           "QXhpcwAuAET5BwAAAAv/////AQEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<double> temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }

        /// <remarks />
        public PropertyState<double> MachCoordAxis
        {
            get
            {
                return m_machCoordAxis;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machCoordAxis, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machCoordAxis = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            if (m_machCoordAxis != null)
            {
                children.Add(m_machCoordAxis);
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
                case UAModel.defaultsmodeler.BrowseNames.temperature:
                {
                    if (createOrReplace)
                    {
                        if (temperature == null)
                        {
                            if (replacement == null)
                            {
                                temperature = new PropertyState<double>(this);
                            }
                            else
                            {
                                temperature = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = temperature;
                    break;
                }

                case UAModel.defaultsmodeler.BrowseNames.MachCoordAxis:
                {
                    if (createOrReplace)
                    {
                        if (MachCoordAxis == null)
                        {
                            if (replacement == null)
                            {
                                MachCoordAxis = new PropertyState<double>(this);
                            }
                            else
                            {
                                MachCoordAxis = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = MachCoordAxis;
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
        private PropertyState<double> m_temperature;
        private PropertyState<double> m_machCoordAxis;
        #endregion
    }
    #endif
    #endregion
}