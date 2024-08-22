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

namespace UAModel.gh
{
    #region IOtypeState Class
    #if (!OPCUA_EXCLUDE_IOtypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IOtypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public IOtypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.IOtype, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (SetIO != null)
            {
                SetIO.Initialize(context, SetIO_InitializationString);
            }

            if (ReadIO != null)
            {
                ReadIO.Initialize(context, ReadIO_InitializationString);
            }

            if (Input1States != null)
            {
                Input1States.Initialize(context, Input1States_InitializationString);
            }

            if (Input2States != null)
            {
                Input2States.Initialize(context, Input2States_InitializationString);
            }
        }

        #region Initialization String
        private const string SetIO_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAFAAAAU2V0" +
           "SU8BAVgbAC8BAVgbWBsAAAEB/////wMAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF5FwMA" +
           "AAAAPwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpJT3R5" +
           "cGUuMTpTZXRJTwAuAER5FwAAlgIAAAABACoBARQAAAAFAAAASW5kZXgAB/////8AAAAAAAEAKgEBEgAA" +
           "AAMAAABTZXQAAf////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAXoXAwAAAABBAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1" +
           "bWVudHMgb2YgbWV0aG9kIDE6SU90eXBlLjE6U2V0SU8ALgBEehcAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAAFWCJCgIAAAAAAAMAAABTZXQBAXsXAIEAP3sXAAAAAf////8BAf////8AAAAA";

        private const string ReadIO_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAGAAAAUmVh" +
           "ZElPAQFZGwAvAQFZG1kbAAABAf////8DAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBfBcD" +
           "AAAAAEAAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6SU90" +
           "eXBlLjE6UmVhZElPAC4ARHwXAACWAQAAAAEAKgEBFAAAAAUAAABpbmRleAAH/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAQAAAAEB/////wAAAAA3YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBfRcDAAAAAEIA" +
           "AAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpJT3R5cGUu" +
           "MTpSZWFkSU8ALgBEfRcAAJYBAAAAAQAqAQEXAAAACAAAAEdldFZhbHVlAAf/////AAAAAAABACgBAQAA" +
           "AAEAAAABAAAAAQH/////AAAAABVgiQoCAAAAAAAFAAAAaW5kZXgBAX4XAIEAP34XAAAAB/////8BAf//" +
           "//8AAAAA";

        private const string Input1States_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAMAAAASW5w" +
           "dXQxU3RhdGVzAQF4FwAvAD94FwAAAAf/////AwP/////AAAAAA==";

        private const string Input2States_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAMAAAASW5w" +
           "dXQyU3RhdGVzAQF/FwAvAD9/FwAAAAf/////AwP/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAOAAAASU90" +
           "eXBlSW5zdGFuY2UBAegDAQHoA+gDAAD/////BAAAAARhggoEAAAAAQAFAAAAU2V0SU8BAVgbAC8BAVgb" +
           "WBsAAAEB/////wMAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF5FwMAAAAAPwAAAHRoZSBk" +
           "ZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpJT3R5cGUuMTpTZXRJTwAu" +
           "AER5FwAAlgIAAAABACoBARQAAAAFAAAASW5kZXgAB/////8AAAAAAAEAKgEBEgAAAAMAAABTZXQAAf//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAXoXAwAAAABBAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0" +
           "aG9kIDE6SU90eXBlLjE6U2V0SU8ALgBEehcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIA" +
           "AAAAAAMAAABTZXQBAXsXAIEAP3sXAAAAAf////8BAf////8AAAAABGGCCgQAAAABAAYAAABSZWFkSU8B" +
           "AVkbAC8BAVkbWRsAAAEB/////wMAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF8FwMAAAAA" +
           "QAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpJT3R5cGUu" +
           "MTpSZWFkSU8ALgBEfBcAAJYBAAAAAQAqAQEUAAAABQAAAGluZGV4AAf/////AAAAAAABACgBAQAAAAEA" +
           "AAABAAAAAQH/////AAAAADdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQF9FwMAAAAAQgAAAHRo" +
           "ZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOklPdHlwZS4xOlJl" +
           "YWRJTwAuAER9FwAAlgEAAAABACoBARcAAAAIAAAAR2V0VmFsdWUAB/////8AAAAAAAEAKAEBAAAAAQAA" +
           "AAEAAAABAf////8AAAAAFWCJCgIAAAAAAAUAAABpbmRleAEBfhcAgQA/fhcAAAAH/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEADAAAAElucHV0MVN0YXRlcwEBeBcALwA/eBcAAAAH/////wMD/////wAAAAAVYIkK" +
           "AgAAAAEADAAAAElucHV0MlN0YXRlcwEBfxcALwA/fxcAAAAH/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SetIOMethodState SetIO
        {
            get
            {
                return m_setIOMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setIOMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setIOMethod = value;
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
        public BaseDataVariableState<uint> Input1States
        {
            get
            {
                return m_input1States;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input1States, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input1States = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Input2States
        {
            get
            {
                return m_input2States;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input2States, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input2States = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_setIOMethod != null)
            {
                children.Add(m_setIOMethod);
            }

            if (m_readIOMethod != null)
            {
                children.Add(m_readIOMethod);
            }

            if (m_input1States != null)
            {
                children.Add(m_input1States);
            }

            if (m_input2States != null)
            {
                children.Add(m_input2States);
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
                case UAModel.gh.BrowseNames.SetIO:
                {
                    if (createOrReplace)
                    {
                        if (SetIO == null)
                        {
                            if (replacement == null)
                            {
                                SetIO = new SetIOMethodState(this);
                            }
                            else
                            {
                                SetIO = (SetIOMethodState)replacement;
                            }
                        }
                    }

                    instance = SetIO;
                    break;
                }

                case UAModel.gh.BrowseNames.ReadIO:
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

                case UAModel.gh.BrowseNames.Input1States:
                {
                    if (createOrReplace)
                    {
                        if (Input1States == null)
                        {
                            if (replacement == null)
                            {
                                Input1States = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Input1States = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Input1States;
                    break;
                }

                case UAModel.gh.BrowseNames.Input2States:
                {
                    if (createOrReplace)
                    {
                        if (Input2States == null)
                        {
                            if (replacement == null)
                            {
                                Input2States = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Input2States = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Input2States;
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
        private SetIOMethodState m_setIOMethod;
        private ReadIOMethodState m_readIOMethod;
        private BaseDataVariableState<uint> m_input1States;
        private BaseDataVariableState<uint> m_input2States;
        #endregion
    }
    #endif
    #endregion

    #region RunModelTypeState Class
    #if (!OPCUA_EXCLUDE_RunModelTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RunModelTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public RunModelTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.RunModelType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Jog != null)
            {
                Jog.Initialize(context, Jog_InitializationString);
            }

            if (SetZero != null)
            {
                SetZero.Initialize(context, SetZero_InitializationString);
            }

            if (Reset != null)
            {
                Reset.Initialize(context, Reset_InitializationString);
            }

            if (XUint != null)
            {
                XUint.Initialize(context, XUint_InitializationString);
            }

            if (Yuint != null)
            {
                Yuint.Initialize(context, Yuint_InitializationString);
            }

            if (ZUint != null)
            {
                ZUint.Initialize(context, ZUint_InitializationString);
            }

            if (AUint != null)
            {
                AUint.Initialize(context, AUint_InitializationString);
            }

            if (Goto != null)
            {
                Goto.Initialize(context, Goto_InitializationString);
            }

            if (RunScript != null)
            {
                RunScript.Initialize(context, RunScript_InitializationString);
            }

            if (IOUint != null)
            {
                IOUint.Initialize(context, IOUint_InitializationString);
            }
        }

        #region Initialization String
        private const string Jog_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQADAAAASm9n" +
           "AQFaGwAvAQFaG1obAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBghcDAAAA" +
           "AD8AAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6QXhpc1R5" +
           "cGUuMTpKb2cALgBEghcAAJYEAAAAAQAqAQEUAAAABQAAAEluZGV4AAf/////AAAAAAABACoBARIAAAAD" +
           "AAAARGlyAAf/////AAAAAAABACoBARQAAAAFAAAAU3BlZWQAB/////8AAAAAAAEAKgEBFwAAAAgAAABk" +
           "aXN0YW5jZQAH/////wAAAAAAAQAoAQEAAAABAAAABAAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBgxcDAAAAAEEAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3Vt" +
           "ZW50cyBvZiBtZXRob2QgMTpBeGlzVHlwZS4xOkpvZwAuAESDFwAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAA=";

        private const string SetZero_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAHAAAAU2V0" +
           "WmVybwEBWxsALwEBWxtbGwAAAQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYQX" +
           "AwAAAABDAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOkF4" +
           "aXNUeXBlLjE6U2V0WmVybwAuAESEFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA3YIkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBhRcDAAAAAEUAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0" +
           "IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpBeGlzVHlwZS4xOlNldFplcm8ALgBEhRcAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAA";

        private const string Reset_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAFAAAAUmVz" +
           "ZXQBAVwbAC8BAVwbXBsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGGFwMA" +
           "AAAAQQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpBeGlz" +
           "VHlwZS4xOlJlc2V0AC4ARIYXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQGHFwMAAAAAQwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJn" +
           "dW1lbnRzIG9mIG1ldGhvZCAxOkF4aXNUeXBlLjE6UmVzZXQALgBEhxcAAAEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAA";

        private const string XUint_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAFAAAAWFVp" +
           "bnQBAYoTACMBAeoDihMAAP////8AAAAA";

        private const string Yuint_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAFAAAAWXVp" +
           "bnQBAYsTACMBAeoDixMAAP////8AAAAA";

        private const string ZUint_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAFAAAAWlVp" +
           "bnQBAYwTACMBAeoDjBMAAP////8AAAAA";

        private const string AUint_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAFAAAAQVVp" +
           "bnQBAY0TACMBAeoDjRMAAP////8AAAAA";

        private const string Goto_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAEAAAAR290" +
           "bwEBXRsALwEBXRtdGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYgXAwAA" +
           "AABEAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlJ1bk1v" +
           "ZGVsVHlwZS4xOkdvdG8ALgBEiBcAAJYDAAAAAQAqAQETAAAABAAAAEF4aXMAB/////8AAAAAAAEAKgEB" +
           "FAAAAAUAAABTcGVlZAAH/////wAAAAAAAQAqAQEVAAAABgAAAFRhcmdldAAH/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAwAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBiRcDAAAAAEYA" +
           "AAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpSdW5Nb2Rl" +
           "bFR5cGUuMTpHb3RvAC4ARIkXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string RunScript_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAJAAAAUnVu" +
           "U2NyaXB0AQFeGwAvAQFeG14bAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "ihcDAAAAAEkAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6" +
           "UnVuTW9kZWxUeXBlLjE6UnVuU2NyaXB0AC4ARIoXAACWAQAAAAEAKgEBFQAAAAQAAABQYXRoAQBNMv//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAYsXAwAAAABLAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0" +
           "aG9kIDE6UnVuTW9kZWxUeXBlLjE6UnVuU2NyaXB0AC4ARIsXAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAAA==";

        private const string IOUint_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAGAAAASU9V" +
           "aW50AQGOEwAjAQHoA44TAAD/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAUAAAAUnVu" +
           "TW9kZWxUeXBlSW5zdGFuY2UBAekDAQHpA+kDAAD/////CgAAAARhggoEAAAAAQADAAAASm9nAQFaGwAv" +
           "AQFaG1obAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBghcDAAAAAD8AAAB0" +
           "aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6QXhpc1R5cGUuMTpK" +
           "b2cALgBEghcAAJYEAAAAAQAqAQEUAAAABQAAAEluZGV4AAf/////AAAAAAABACoBARIAAAADAAAARGly" +
           "AAf/////AAAAAAABACoBARQAAAAFAAAAU3BlZWQAB/////8AAAAAAAEAKgEBFwAAAAgAAABkaXN0YW5j" +
           "ZQAH/////wAAAAAAAQAoAQEAAAABAAAABAAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBgxcDAAAAAEEAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBv" +
           "ZiBtZXRob2QgMTpBeGlzVHlwZS4xOkpvZwAuAESDFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAE" +
           "YYIKBAAAAAEABwAAAFNldFplcm8BAVsbAC8BAVsbWxsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQGEFwMAAAAAQwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVu" +
           "dCBvZiBtZXRob2QgMTpBeGlzVHlwZS4xOlNldFplcm8ALgBEhBcAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYUXAwAAAABFAAAAdGhlIGRlZmluaXRp" +
           "b24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6QXhpc1R5cGUuMTpTZXRaZXJvAC4A" +
           "RIUXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAFAAAAUmVzZXQBAVwbAC8BAVwb" +
           "XBsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGGFwMAAAAAQQAAAHRoZSBk" +
           "ZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpBeGlzVHlwZS4xOlJlc2V0" +
           "AC4ARIYXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQGHFwMAAAAAQwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1l" +
           "dGhvZCAxOkF4aXNUeXBlLjE6UmVzZXQALgBEhxcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGCA" +
           "CgEAAAABAAUAAABYVWludAEBihMAIwEB6gOKEwAA/////wAAAAAEYIAKAQAAAAEABQAAAFl1aW50AQGL" +
           "EwAjAQHqA4sTAAD/////AAAAAARggAoBAAAAAQAFAAAAWlVpbnQBAYwTACMBAeoDjBMAAP////8AAAAA" +
           "BGCACgEAAAABAAUAAABBVWludAEBjRMAIwEB6gONEwAA/////wAAAAAEYYIKBAAAAAEABAAAAEdvdG8B" +
           "AV0bAC8BAV0bXRsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGIFwMAAAAA" +
           "RAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpSdW5Nb2Rl" +
           "bFR5cGUuMTpHb3RvAC4ARIgXAACWAwAAAAEAKgEBEwAAAAQAAABBeGlzAAf/////AAAAAAABACoBARQA" +
           "AAAFAAAAU3BlZWQAB/////8AAAAAAAEAKgEBFQAAAAYAAABUYXJnZXQAB/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAMAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYkXAwAAAABGAAAA" +
           "dGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UnVuTW9kZWxU" +
           "eXBlLjE6R290bwAuAESJFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAFJ1" +
           "blNjcmlwdAEBXhsALwEBXhteGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AYoXAwAAAABJAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAx" +
           "OlJ1bk1vZGVsVHlwZS4xOlJ1blNjcmlwdAAuAESKFwAAlgEAAAABACoBARUAAAAEAAAAUGF0aAEATTL/" +
           "////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1l" +
           "bnRzAQGLFwMAAAAASwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1l" +
           "dGhvZCAxOlJ1bk1vZGVsVHlwZS4xOlJ1blNjcmlwdAAuAESLFwAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAAEYIAKAQAAAAEABgAAAElPVWludAEBjhMAIwEB6AOOEwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        public MethodState SetZero
        {
            get
            {
                return m_setZeroMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setZeroMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setZeroMethod = value;
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
        public AxisTypeState XUint
        {
            get
            {
                return m_xUint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_xUint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_xUint = value;
            }
        }

        /// <remarks />
        public AxisTypeState Yuint
        {
            get
            {
                return m_yuint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_yuint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_yuint = value;
            }
        }

        /// <remarks />
        public AxisTypeState ZUint
        {
            get
            {
                return m_zUint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_zUint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_zUint = value;
            }
        }

        /// <remarks />
        public AxisTypeState AUint
        {
            get
            {
                return m_aUint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_aUint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_aUint = value;
            }
        }

        /// <remarks />
        public GotoMethodState Goto
        {
            get
            {
                return m_gotoMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoMethod = value;
            }
        }

        /// <remarks />
        public RunScriptMethodState RunScript
        {
            get
            {
                return m_runScriptMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runScriptMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runScriptMethod = value;
            }
        }

        /// <remarks />
        public IOtypeState IOUint
        {
            get
            {
                return m_iOUint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iOUint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iOUint = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_jogMethod != null)
            {
                children.Add(m_jogMethod);
            }

            if (m_setZeroMethod != null)
            {
                children.Add(m_setZeroMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_xUint != null)
            {
                children.Add(m_xUint);
            }

            if (m_yuint != null)
            {
                children.Add(m_yuint);
            }

            if (m_zUint != null)
            {
                children.Add(m_zUint);
            }

            if (m_aUint != null)
            {
                children.Add(m_aUint);
            }

            if (m_gotoMethod != null)
            {
                children.Add(m_gotoMethod);
            }

            if (m_runScriptMethod != null)
            {
                children.Add(m_runScriptMethod);
            }

            if (m_iOUint != null)
            {
                children.Add(m_iOUint);
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
                case UAModel.gh.BrowseNames.Jog:
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

                case UAModel.gh.BrowseNames.SetZero:
                {
                    if (createOrReplace)
                    {
                        if (SetZero == null)
                        {
                            if (replacement == null)
                            {
                                SetZero = new MethodState(this);
                            }
                            else
                            {
                                SetZero = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SetZero;
                    break;
                }

                case UAModel.gh.BrowseNames.Reset:
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

                case UAModel.gh.BrowseNames.XUint:
                {
                    if (createOrReplace)
                    {
                        if (XUint == null)
                        {
                            if (replacement == null)
                            {
                                XUint = new AxisTypeState(this);
                            }
                            else
                            {
                                XUint = (AxisTypeState)replacement;
                            }
                        }
                    }

                    instance = XUint;
                    break;
                }

                case UAModel.gh.BrowseNames.Yuint:
                {
                    if (createOrReplace)
                    {
                        if (Yuint == null)
                        {
                            if (replacement == null)
                            {
                                Yuint = new AxisTypeState(this);
                            }
                            else
                            {
                                Yuint = (AxisTypeState)replacement;
                            }
                        }
                    }

                    instance = Yuint;
                    break;
                }

                case UAModel.gh.BrowseNames.ZUint:
                {
                    if (createOrReplace)
                    {
                        if (ZUint == null)
                        {
                            if (replacement == null)
                            {
                                ZUint = new AxisTypeState(this);
                            }
                            else
                            {
                                ZUint = (AxisTypeState)replacement;
                            }
                        }
                    }

                    instance = ZUint;
                    break;
                }

                case UAModel.gh.BrowseNames.AUint:
                {
                    if (createOrReplace)
                    {
                        if (AUint == null)
                        {
                            if (replacement == null)
                            {
                                AUint = new AxisTypeState(this);
                            }
                            else
                            {
                                AUint = (AxisTypeState)replacement;
                            }
                        }
                    }

                    instance = AUint;
                    break;
                }

                case UAModel.gh.BrowseNames.Goto:
                {
                    if (createOrReplace)
                    {
                        if (Goto == null)
                        {
                            if (replacement == null)
                            {
                                Goto = new GotoMethodState(this);
                            }
                            else
                            {
                                Goto = (GotoMethodState)replacement;
                            }
                        }
                    }

                    instance = Goto;
                    break;
                }

                case UAModel.gh.BrowseNames.RunScript:
                {
                    if (createOrReplace)
                    {
                        if (RunScript == null)
                        {
                            if (replacement == null)
                            {
                                RunScript = new RunScriptMethodState(this);
                            }
                            else
                            {
                                RunScript = (RunScriptMethodState)replacement;
                            }
                        }
                    }

                    instance = RunScript;
                    break;
                }

                case UAModel.gh.BrowseNames.IOUint:
                {
                    if (createOrReplace)
                    {
                        if (IOUint == null)
                        {
                            if (replacement == null)
                            {
                                IOUint = new IOtypeState(this);
                            }
                            else
                            {
                                IOUint = (IOtypeState)replacement;
                            }
                        }
                    }

                    instance = IOUint;
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
        private JogMethodState m_jogMethod;
        private MethodState m_setZeroMethod;
        private MethodState m_resetMethod;
        private AxisTypeState m_xUint;
        private AxisTypeState m_yuint;
        private AxisTypeState m_zUint;
        private AxisTypeState m_aUint;
        private GotoMethodState m_gotoMethod;
        private RunScriptMethodState m_runScriptMethod;
        private IOtypeState m_iOUint;
        #endregion
    }
    #endif
    #endregion

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
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.AxisType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (MechineAxis != null)
            {
                MechineAxis.Initialize(context, MechineAxis_InitializationString);
            }

            if (LocalAxis != null)
            {
                LocalAxis.Initialize(context, LocalAxis_InitializationString);
            }
        }

        #region Initialization String
        private const string MechineAxis_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xViiQoCAAAAAQALAAAATWVj" +
           "aGluZUF4aXMBAYAXAC8AP4AXAAAAB/////8DAwH/////AAAAAA==";

        private const string LocalAxis_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xViiQoCAAAAAQAJAAAATG9j" +
           "YWxBeGlzAQGBFwAvAD+BFwAAAAf/////AwMB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAQAAAAQXhp" +
           "c1R5cGVJbnN0YW5jZQEB6gMBAeoD6gMAAP////8CAAAAFWKJCgIAAAABAAsAAABNZWNoaW5lQXhpcwEB" +
           "gBcALwA/gBcAAAAH/////wMDAf////8AAAAAFWKJCgIAAAABAAkAAABMb2NhbEF4aXMBAYEXAC8AP4EX" +
           "AAAAB/////8DAwH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<uint> MechineAxis
        {
            get
            {
                return m_mechineAxis;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mechineAxis, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mechineAxis = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> LocalAxis
        {
            get
            {
                return m_localAxis;
            }

            set
            {
                if (!Object.ReferenceEquals(m_localAxis, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_localAxis = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mechineAxis != null)
            {
                children.Add(m_mechineAxis);
            }

            if (m_localAxis != null)
            {
                children.Add(m_localAxis);
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
                case UAModel.gh.BrowseNames.MechineAxis:
                {
                    if (createOrReplace)
                    {
                        if (MechineAxis == null)
                        {
                            if (replacement == null)
                            {
                                MechineAxis = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                MechineAxis = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = MechineAxis;
                    break;
                }

                case UAModel.gh.BrowseNames.LocalAxis:
                {
                    if (createOrReplace)
                    {
                        if (LocalAxis == null)
                        {
                            if (replacement == null)
                            {
                                LocalAxis = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                LocalAxis = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = LocalAxis;
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
        private BaseDataVariableState<uint> m_mechineAxis;
        private BaseDataVariableState<uint> m_localAxis;
        #endregion
    }
    #endif
    #endregion

    #region MeanDistanceState Class
    #if (!OPCUA_EXCLUDE_MeanDistanceState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MeanDistanceState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MeanDistanceState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.MeanDistance, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Name != null)
            {
                Name.Initialize(context, Name_InitializationString);
            }

            if (StartCapture != null)
            {
                StartCapture.Initialize(context, StartCapture_InitializationString);
            }

            if (StopCapture != null)
            {
                StopCapture.Initialize(context, StopCapture_InitializationString);
            }

            if (GetCurDistance != null)
            {
                GetCurDistance.Initialize(context, GetCurDistance_InitializationString);
            }
        }

        #region Initialization String
        private const string Name_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAATmFt" +
           "ZQEBkRcALwA/kRcAAAEATTL/////AwP/////AAAAAA==";

        private const string StartCapture_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAMAAAAU3Rh" +
           "cnRDYXB0dXJlAQFhGwAvAQFhG2EbAAABAf////8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBkhcDAAAAAEwAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9k" +
           "IDE6TWVhbkRpc3RhbmNlLjE6U3RhcnRDYXB0dXJlAC4ARJIXAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGTFwMAAAAATgAAAHRoZSBkZWZpbml0aW9u" +
           "IG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOk1lYW5EaXN0YW5jZS4xOlN0YXJ0Q2Fw" +
           "dHVyZQAuAESTFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string StopCapture_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQALAAAAU3Rv" +
           "cENhcHR1cmUBAXUbAC8BAXUbdRsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQHGFwMAAAAASwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2Qg" +
           "MTpNZWFuRGlzdGFuY2UuMTpTdG9wQ2FwdHVyZQAuAETGFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBxxcDAAAAAE0AAAB0aGUgZGVmaW5pdGlvbiBv" +
           "ZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpNZWFuRGlzdGFuY2UuMTpTdG9wQ2FwdHVy" +
           "ZQAuAETHFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string GetCurDistance_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAOAAAAR2V0" +
           "Q3VyRGlzdGFuY2UBAXYbAC8BAXYbdhsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQHIFwMAAAAATgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRo" +
           "b2QgMTpNZWFuRGlzdGFuY2UuMTpHZXRDdXJEaXN0YW5jZQAuAETIFwAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAA3YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEByRcDAAAAAFAAAAB0aGUgZGVmaW5p" +
           "dGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpNZWFuRGlzdGFuY2UuMTpHZXRD" +
           "dXJEaXN0YW5jZQAuAETJFwAAlgEAAAABACoBARcAAAAIAAAAQ3VyVmFsdWUAC/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAEAAAABAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAUAAAATWVh" +
           "bkRpc3RhbmNlSW5zdGFuY2UBAesDAQHrA+sDAAD/////BAAAABVgiQoCAAAAAQAEAAAATmFtZQEBkRcA" +
           "LwA/kRcAAAEATTL/////AwP/////AAAAAARhggoEAAAAAQAMAAAAU3RhcnRDYXB0dXJlAQFhGwAvAQFh" +
           "G2EbAAABAf////8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBkhcDAAAAAEwAAAB0aGUg" +
           "ZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6TWVhbkRpc3RhbmNlLjE6" +
           "U3RhcnRDYXB0dXJlAC4ARJIXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQGTFwMAAAAATgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJn" +
           "dW1lbnRzIG9mIG1ldGhvZCAxOk1lYW5EaXN0YW5jZS4xOlN0YXJ0Q2FwdHVyZQAuAESTFwAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACwAAAFN0b3BDYXB0dXJlAQF1GwAvAQF1G3UbAAAB" +
           "Af////8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBxhcDAAAAAEsAAAB0aGUgZGVmaW5p" +
           "dGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6TWVhbkRpc3RhbmNlLjE6U3RvcENh" +
           "cHR1cmUALgBExhcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAccXAwAAAABNAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMg" +
           "b2YgbWV0aG9kIDE6TWVhbkRpc3RhbmNlLjE6U3RvcENhcHR1cmUALgBExxcAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAABGGCCgQAAAABAA4AAABHZXRDdXJEaXN0YW5jZQEBdhsALwEBdht2GwAAAQH/////" +
           "AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcgXAwAAAABOAAAAdGhlIGRlZmluaXRpb24g" +
           "b2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOk1lYW5EaXN0YW5jZS4xOkdldEN1ckRpc3Rh" +
           "bmNlAC4ARMgXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADdgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQHJFwMAAAAAUAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9m" +
           "IG1ldGhvZCAxOk1lYW5EaXN0YW5jZS4xOkdldEN1ckRpc3RhbmNlAC4ARMkXAACWAQAAAAEAKgEBFwAA" +
           "AAgAAABDdXJWYWx1ZQAL/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public MethodState StartCapture
        {
            get
            {
                return m_startCaptureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startCaptureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startCaptureMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopCapture
        {
            get
            {
                return m_stopCaptureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopCaptureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopCaptureMethod = value;
            }
        }

        /// <remarks />
        public GetCurDistanceMethodState GetCurDistance
        {
            get
            {
                return m_getCurDistanceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getCurDistanceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getCurDistanceMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_startCaptureMethod != null)
            {
                children.Add(m_startCaptureMethod);
            }

            if (m_stopCaptureMethod != null)
            {
                children.Add(m_stopCaptureMethod);
            }

            if (m_getCurDistanceMethod != null)
            {
                children.Add(m_getCurDistanceMethod);
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
                case UAModel.gh.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Name = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case UAModel.gh.BrowseNames.StartCapture:
                {
                    if (createOrReplace)
                    {
                        if (StartCapture == null)
                        {
                            if (replacement == null)
                            {
                                StartCapture = new MethodState(this);
                            }
                            else
                            {
                                StartCapture = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartCapture;
                    break;
                }

                case UAModel.gh.BrowseNames.StopCapture:
                {
                    if (createOrReplace)
                    {
                        if (StopCapture == null)
                        {
                            if (replacement == null)
                            {
                                StopCapture = new MethodState(this);
                            }
                            else
                            {
                                StopCapture = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopCapture;
                    break;
                }

                case UAModel.gh.BrowseNames.GetCurDistance:
                {
                    if (createOrReplace)
                    {
                        if (GetCurDistance == null)
                        {
                            if (replacement == null)
                            {
                                GetCurDistance = new GetCurDistanceMethodState(this);
                            }
                            else
                            {
                                GetCurDistance = (GetCurDistanceMethodState)replacement;
                            }
                        }
                    }

                    instance = GetCurDistance;
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
        private BaseDataVariableState<string> m_name;
        private MethodState m_startCaptureMethod;
        private MethodState m_stopCaptureMethod;
        private GetCurDistanceMethodState m_getCurDistanceMethod;
        #endregion
    }
    #endif
    #endregion

    #region CamTypeState Class
    #if (!OPCUA_EXCLUDE_CamTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CamTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public CamTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.CamType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Name != null)
            {
                Name.Initialize(context, Name_InitializationString);
            }

            if (StartCapture != null)
            {
                StartCapture.Initialize(context, StartCapture_InitializationString);
            }

            if (SetMode != null)
            {
                SetMode.Initialize(context, SetMode_InitializationString);
            }

            if (Mode != null)
            {
                Mode.Initialize(context, Mode_InitializationString);
            }

            if (exposure != null)
            {
                exposure.Initialize(context, exposure_InitializationString);
            }

            if (StopCapture != null)
            {
                StopCapture.Initialize(context, StopCapture_InitializationString);
            }

            if (SetExposure != null)
            {
                SetExposure.Initialize(context, SetExposure_InitializationString);
            }
        }

        #region Initialization String
        private const string Name_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAATmFt" +
           "ZQEBjBcALwA/jBcAAAEATTL/////AwP/////AAAAAA==";

        private const string StartCapture_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAMAAAAU3Rh" +
           "cnRDYXB0dXJlAQFfGwAvAQFfG18bAAABAf////8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBjRcDAAAAAEcAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9k" +
           "IDE6Q2FtVHlwZS4xOlN0YXJ0Q2FwdHVyZQAuAESNFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA3" +
           "YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBjhcDAAAAAEkAAAB0aGUgZGVmaW5pdGlvbiBvZiB0" +
           "aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpDYW1UeXBlLjE6U3RhcnRDYXB0dXJlAC4ARI4X" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string SetMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAHAAAAU2V0" +
           "TW9kZQEBYBsALwEBYBtgGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8X" +
           "AwAAAABCAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOkNh" +
           "bVR5cGUuMTpTZXRNb2RlAC4ARI8XAACWAQAAAAEAKgEBEwAAAAQAAABtb2RlAAf/////AAAAAAABACgB" +
           "AQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGQFwMAAAAA" +
           "RAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOkNhbVR5" +
           "cGUuMTpTZXRNb2RlAC4ARJAXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string Mode_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAATW9k" +
           "ZQEByhcALwA/yhcAAAAH/////wMD/////wAAAAA=";

        private const string exposure_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAIAAAAZXhw" +
           "b3N1cmUBAcsXAC8AP8sXAAAAC/////8DA/////8AAAAA";

        private const string StopCapture_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQALAAAAU3Rv" +
           "cENhcHR1cmUBAXcbAC8BAXcbdxsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQHMFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2Qg" +
           "MTpDYW1UeXBlLjE6U3RvcENhcHR1cmUALgBEzBcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJ" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAc0XAwAAAABIAAAAdGhlIGRlZmluaXRpb24gb2YgdGhl" +
           "IG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6Q2FtVHlwZS4xOlN0b3BDYXB0dXJlAC4ARM0XAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string SetExposure_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQALAAAAU2V0" +
           "RXhwb3N1cmUBAXgbAC8BAXgbeBsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQHOFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2Qg" +
           "MTpDYW1UeXBlLjE6U2V0RXhwb3N1cmUALgBEzhcAAJYBAAAAAQAqAQEyAAAACAAAAEV4cG9zdXJlAAv/" +
           "////AAAAAAIXAAAAc2V0IGV4cG9zdXJlIGZvciBjYW1lcmEBACgBAQAAAAEAAAABAAAAAQH/////AAAA" +
           "ADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHPFwMAAAAASAAAAHRoZSBkZWZpbml0aW9uIG9m" +
           "IHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOkNhbVR5cGUuMTpTZXRFeHBvc3VyZQAuAETP" +
           "FwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAPAAAAQ2Ft" +
           "VHlwZUluc3RhbmNlAQHsAwEB7APsAwAA/////wcAAAAVYIkKAgAAAAEABAAAAE5hbWUBAYwXAC8AP4wX" +
           "AAABAE0y/////wMD/////wAAAAAEYYIKBAAAAAEADAAAAFN0YXJ0Q2FwdHVyZQEBXxsALwEBXxtfGwAA" +
           "AQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY0XAwAAAABHAAAAdGhlIGRlZmlu" +
           "aXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOkNhbVR5cGUuMTpTdGFydENhcHR1" +
           "cmUALgBEjRcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAY4XAwAAAABJAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2Yg" +
           "bWV0aG9kIDE6Q2FtVHlwZS4xOlN0YXJ0Q2FwdHVyZQAuAESOFwAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAEABwAAAFNldE1vZGUBAWAbAC8BAWAbYBsAAAEB/////wIAAAA3YKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQGPFwMAAAAAQgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBh" +
           "cmd1bWVudCBvZiBtZXRob2QgMTpDYW1UeXBlLjE6U2V0TW9kZQAuAESPFwAAlgEAAAABACoBARMAAAAE" +
           "AAAAbW9kZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBkBcDAAAAAEQAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3Vt" +
           "ZW50cyBvZiBtZXRob2QgMTpDYW1UeXBlLjE6U2V0TW9kZQAuAESQFwAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAVYIkKAgAAAAEABAAAAE1vZGUBAcoXAC8AP8oXAAAAB/////8DA/////8AAAAAFWCJCgIA" +
           "AAABAAgAAABleHBvc3VyZQEByxcALwA/yxcAAAAL/////wMD/////wAAAAAEYYIKBAAAAAEACwAAAFN0" +
           "b3BDYXB0dXJlAQF3GwAvAQF3G3cbAAABAf////8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBzBcDAAAAAEYAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9k" +
           "IDE6Q2FtVHlwZS4xOlN0b3BDYXB0dXJlAC4ARMwXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADdg" +
           "iQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHNFwMAAAAASAAAAHRoZSBkZWZpbml0aW9uIG9mIHRo" +
           "ZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOkNhbVR5cGUuMTpTdG9wQ2FwdHVyZQAuAETNFwAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEACwAAAFNldEV4cG9zdXJlAQF4GwAvAQF4" +
           "G3gbAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBzhcDAAAAAEYAAAB0aGUg" +
           "ZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6Q2FtVHlwZS4xOlNldEV4" +
           "cG9zdXJlAC4ARM4XAACWAQAAAAEAKgEBMgAAAAgAAABFeHBvc3VyZQAL/////wAAAAACFwAAAHNldCBl" +
           "eHBvc3VyZSBmb3IgY2FtZXJhAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBzxcDAAAAAEgAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3Vt" +
           "ZW50cyBvZiBtZXRob2QgMTpDYW1UeXBlLjE6U2V0RXhwb3N1cmUALgBEzxcAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public MethodState StartCapture
        {
            get
            {
                return m_startCaptureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startCaptureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startCaptureMethod = value;
            }
        }

        /// <remarks />
        public SetModeMethodState SetMode
        {
            get
            {
                return m_setModeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setModeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setModeMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Mode
        {
            get
            {
                return m_mode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mode = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> exposure
        {
            get
            {
                return m_exposure;
            }

            set
            {
                if (!Object.ReferenceEquals(m_exposure, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_exposure = value;
            }
        }

        /// <remarks />
        public MethodState StopCapture
        {
            get
            {
                return m_stopCaptureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopCaptureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopCaptureMethod = value;
            }
        }

        /// <remarks />
        public SetExposureMethodState SetExposure
        {
            get
            {
                return m_setExposureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setExposureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setExposureMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_startCaptureMethod != null)
            {
                children.Add(m_startCaptureMethod);
            }

            if (m_setModeMethod != null)
            {
                children.Add(m_setModeMethod);
            }

            if (m_mode != null)
            {
                children.Add(m_mode);
            }

            if (m_exposure != null)
            {
                children.Add(m_exposure);
            }

            if (m_stopCaptureMethod != null)
            {
                children.Add(m_stopCaptureMethod);
            }

            if (m_setExposureMethod != null)
            {
                children.Add(m_setExposureMethod);
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
                case UAModel.gh.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Name = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case UAModel.gh.BrowseNames.StartCapture:
                {
                    if (createOrReplace)
                    {
                        if (StartCapture == null)
                        {
                            if (replacement == null)
                            {
                                StartCapture = new MethodState(this);
                            }
                            else
                            {
                                StartCapture = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartCapture;
                    break;
                }

                case UAModel.gh.BrowseNames.SetMode:
                {
                    if (createOrReplace)
                    {
                        if (SetMode == null)
                        {
                            if (replacement == null)
                            {
                                SetMode = new SetModeMethodState(this);
                            }
                            else
                            {
                                SetMode = (SetModeMethodState)replacement;
                            }
                        }
                    }

                    instance = SetMode;
                    break;
                }

                case UAModel.gh.BrowseNames.Mode:
                {
                    if (createOrReplace)
                    {
                        if (Mode == null)
                        {
                            if (replacement == null)
                            {
                                Mode = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Mode = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Mode;
                    break;
                }

                case UAModel.gh.BrowseNames.exposure:
                {
                    if (createOrReplace)
                    {
                        if (exposure == null)
                        {
                            if (replacement == null)
                            {
                                exposure = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                exposure = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = exposure;
                    break;
                }

                case UAModel.gh.BrowseNames.StopCapture:
                {
                    if (createOrReplace)
                    {
                        if (StopCapture == null)
                        {
                            if (replacement == null)
                            {
                                StopCapture = new MethodState(this);
                            }
                            else
                            {
                                StopCapture = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopCapture;
                    break;
                }

                case UAModel.gh.BrowseNames.SetExposure:
                {
                    if (createOrReplace)
                    {
                        if (SetExposure == null)
                        {
                            if (replacement == null)
                            {
                                SetExposure = new SetExposureMethodState(this);
                            }
                            else
                            {
                                SetExposure = (SetExposureMethodState)replacement;
                            }
                        }
                    }

                    instance = SetExposure;
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
        private BaseDataVariableState<string> m_name;
        private MethodState m_startCaptureMethod;
        private SetModeMethodState m_setModeMethod;
        private BaseDataVariableState<uint> m_mode;
        private BaseDataVariableState<double> m_exposure;
        private MethodState m_stopCaptureMethod;
        private SetExposureMethodState m_setExposureMethod;
        #endregion
    }
    #endif
    #endregion

    #region PumpTypeState Class
    #if (!OPCUA_EXCLUDE_PumpTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PumpTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PumpTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.PumpType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Abs != null)
            {
                Abs.Initialize(context, Abs_InitializationString);
            }

            if (GotoAbs != null)
            {
                GotoAbs.Initialize(context, GotoAbs_InitializationString);
            }

            if (SetSpeed != null)
            {
                SetSpeed.Initialize(context, SetSpeed_InitializationString);
            }
        }

        #region Initialization String
        private const string Abs_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQADAAAAQWJz" +
           "AQGUFwAvAD+UFwAAAAf/////AwP/////AAAAAA==";

        private const string GotoAbs_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAHAAAAR290" +
           "b0FicwEBYhsALwEBYhtiGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZUX" +
           "AwAAAABDAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlB1" +
           "bXBUeXBlLjE6R290b0FicwAuAESVFwAAlgIAAAABACoBARIAAAADAAAAQWJzAAf/////AAAAAAABACoB" +
           "ARQAAAAFAAAAU3BlZWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAN2CJCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAZYXAwAAAABFAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1" +
           "dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UHVtcFR5cGUuMTpHb3RvQWJzAC4ARJYXAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAA==";

        private const string SetSpeed_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAIAAAAU2V0" +
           "U3BlZWQBAW8bAC8BAW8bbxsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG3" +
           "FwMAAAAARAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpQ" +
           "dW1wVHlwZS4xOlNldFNwZWVkAC4ARLcXAACWAgAAAAEAKgEBGQAAAAoAAABzdGFydFNwZWVkAAv/////" +
           "AAAAAAABACoBARcAAAAIAAAATWF4U3BlZWQAC/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8A" +
           "AAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAbgXAwAAAABGAAAAdGhlIGRlZmluaXRpb24g" +
           "b2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UHVtcFR5cGUuMTpTZXRTcGVlZAAuAES4" +
           "FwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAQAAAAUHVt" +
           "cFR5cGVJbnN0YW5jZQEB7QMBAe0D7QMAAP////8DAAAAFWCJCgIAAAABAAMAAABBYnMBAZQXAC8AP5QX" +
           "AAAAB/////8DA/////8AAAAABGGCCgQAAAABAAcAAABHb3RvQWJzAQFiGwAvAQFiG2IbAAABAf////8C" +
           "AAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBlRcDAAAAAEMAAAB0aGUgZGVmaW5pdGlvbiBv" +
           "ZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6UHVtcFR5cGUuMTpHb3RvQWJzAC4ARJUXAACW" +
           "AgAAAAEAKgEBEgAAAAMAAABBYnMAB/////8AAAAAAAEAKgEBFAAAAAUAAABTcGVlZAAH/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBlhcD" +
           "AAAAAEUAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQ" +
           "dW1wVHlwZS4xOkdvdG9BYnMALgBElhcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAB" +
           "AAgAAABTZXRTcGVlZAEBbxsALwEBbxtvGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAbcXAwAAAABEAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1l" +
           "dGhvZCAxOlB1bXBUeXBlLjE6U2V0U3BlZWQALgBEtxcAAJYCAAAAAQAqAQEZAAAACgAAAHN0YXJ0U3Bl" +
           "ZWQAC/////8AAAAAAAEAKgEBFwAAAAgAAABNYXhTcGVlZAAL/////wAAAAAAAQAoAQEAAAABAAAAAgAA" +
           "AAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBuBcDAAAAAEYAAAB0aGUgZGVm" +
           "aW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQdW1wVHlwZS4xOlNldFNw" +
           "ZWVkAC4ARLgXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<uint> Abs
        {
            get
            {
                return m_abs;
            }

            set
            {
                if (!Object.ReferenceEquals(m_abs, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_abs = value;
            }
        }

        /// <remarks />
        public GotoAbsMethodState GotoAbs
        {
            get
            {
                return m_gotoAbsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gotoAbsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gotoAbsMethod = value;
            }
        }

        /// <remarks />
        public SetSpeedMethodState SetSpeed
        {
            get
            {
                return m_setSpeedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setSpeedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setSpeedMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_abs != null)
            {
                children.Add(m_abs);
            }

            if (m_gotoAbsMethod != null)
            {
                children.Add(m_gotoAbsMethod);
            }

            if (m_setSpeedMethod != null)
            {
                children.Add(m_setSpeedMethod);
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
                case UAModel.gh.BrowseNames.Abs:
                {
                    if (createOrReplace)
                    {
                        if (Abs == null)
                        {
                            if (replacement == null)
                            {
                                Abs = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Abs = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Abs;
                    break;
                }

                case UAModel.gh.BrowseNames.GotoAbs:
                {
                    if (createOrReplace)
                    {
                        if (GotoAbs == null)
                        {
                            if (replacement == null)
                            {
                                GotoAbs = new GotoAbsMethodState(this);
                            }
                            else
                            {
                                GotoAbs = (GotoAbsMethodState)replacement;
                            }
                        }
                    }

                    instance = GotoAbs;
                    break;
                }

                case UAModel.gh.BrowseNames.SetSpeed:
                {
                    if (createOrReplace)
                    {
                        if (SetSpeed == null)
                        {
                            if (replacement == null)
                            {
                                SetSpeed = new SetSpeedMethodState(this);
                            }
                            else
                            {
                                SetSpeed = (SetSpeedMethodState)replacement;
                            }
                        }
                    }

                    instance = SetSpeed;
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
        private BaseDataVariableState<uint> m_abs;
        private GotoAbsMethodState m_gotoAbsMethod;
        private SetSpeedMethodState m_setSpeedMethod;
        #endregion
    }
    #endif
    #endregion

    #region mscTyoeState Class
    #if (!OPCUA_EXCLUDE_mscTyoeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class mscTyoeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public mscTyoeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.mscTyoe, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Balser != null)
            {
                Balser.Initialize(context, Balser_InitializationString);
            }

            if (IF2451 != null)
            {
                IF2451.Initialize(context, IF2451_InitializationString);
            }

            if (Tecan != null)
            {
                Tecan.Initialize(context, Tecan_InitializationString);
            }

            if (OpticalModel != null)
            {
                OpticalModel.Initialize(context, OpticalModel_InitializationString);
            }

            if (DualModel != null)
            {
                DualModel.Initialize(context, DualModel_InitializationString);
            }

            if (AutoPlungerp != null)
            {
                AutoPlungerp.Initialize(context, AutoPlungerp_InitializationString);
            }
        }

        #region Initialization String
        private const string Balser_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAGAAAAQmFs" +
           "c2VyAQGQEwAjAQHsA5ATAAD/////AAAAAA==";

        private const string IF2451_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAGAAAASUYy" +
           "NDUxAQGREwAjAQHrA5ETAAD/////AAAAAA==";

        private const string Tecan_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAFAAAAVGVj" +
           "YW4BAZITACMBAe0DkhMAAP////8AAAAA";

        private const string OpticalModel_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAMAAAAT3B0" +
           "aWNhbE1vZGVsAQGJEwAjAQHpA4kTAAD/////AAAAAA==";

        private const string DualModel_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAJAAAARHVh" +
           "bE1vZGVsAQGPEwAjAQHpA48TAAD/////AAAAAA==";

        private const string AutoPlungerp_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAMAAAAQXV0" +
           "b1BsdW5nZXJwAQGVEwAjAQH1A5UTAAD/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAPAAAAbXNj" +
           "VHlvZUluc3RhbmNlAQHuAwEB7gPuAwAA/////wYAAAAEYIAKAQAAAAEABgAAAEJhbHNlcgEBkBMAIwEB" +
           "7AOQEwAA/////wAAAAAEYIAKAQAAAAEABgAAAElGMjQ1MQEBkRMAIwEB6wOREwAA/////wAAAAAEYIAK" +
           "AQAAAAEABQAAAFRlY2FuAQGSEwAjAQHtA5ITAAD/////AAAAAARggAoBAAAAAQAMAAAAT3B0aWNhbE1v" +
           "ZGVsAQGJEwAjAQHpA4kTAAD/////AAAAAARggAoBAAAAAQAJAAAARHVhbE1vZGVsAQGPEwAjAQHpA48T" +
           "AAD/////AAAAAARggAoBAAAAAQAMAAAAQXV0b1BsdW5nZXJwAQGVEwAjAQH1A5UTAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CamTypeState Balser
        {
            get
            {
                return m_balser;
            }

            set
            {
                if (!Object.ReferenceEquals(m_balser, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_balser = value;
            }
        }

        /// <remarks />
        public MeanDistanceState IF2451
        {
            get
            {
                return m_iF2451;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iF2451, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iF2451 = value;
            }
        }

        /// <remarks />
        public PumpTypeState Tecan
        {
            get
            {
                return m_tecan;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tecan, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tecan = value;
            }
        }

        /// <remarks />
        public RunModelTypeState OpticalModel
        {
            get
            {
                return m_opticalModel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_opticalModel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_opticalModel = value;
            }
        }

        /// <remarks />
        public RunModelTypeState DualModel
        {
            get
            {
                return m_dualModel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dualModel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dualModel = value;
            }
        }

        /// <remarks />
        public PlungerpTypeState AutoPlungerp
        {
            get
            {
                return m_autoPlungerp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_autoPlungerp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_autoPlungerp = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_balser != null)
            {
                children.Add(m_balser);
            }

            if (m_iF2451 != null)
            {
                children.Add(m_iF2451);
            }

            if (m_tecan != null)
            {
                children.Add(m_tecan);
            }

            if (m_opticalModel != null)
            {
                children.Add(m_opticalModel);
            }

            if (m_dualModel != null)
            {
                children.Add(m_dualModel);
            }

            if (m_autoPlungerp != null)
            {
                children.Add(m_autoPlungerp);
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
                case UAModel.gh.BrowseNames.Balser:
                {
                    if (createOrReplace)
                    {
                        if (Balser == null)
                        {
                            if (replacement == null)
                            {
                                Balser = new CamTypeState(this);
                            }
                            else
                            {
                                Balser = (CamTypeState)replacement;
                            }
                        }
                    }

                    instance = Balser;
                    break;
                }

                case UAModel.gh.BrowseNames.IF2451:
                {
                    if (createOrReplace)
                    {
                        if (IF2451 == null)
                        {
                            if (replacement == null)
                            {
                                IF2451 = new MeanDistanceState(this);
                            }
                            else
                            {
                                IF2451 = (MeanDistanceState)replacement;
                            }
                        }
                    }

                    instance = IF2451;
                    break;
                }

                case UAModel.gh.BrowseNames.Tecan:
                {
                    if (createOrReplace)
                    {
                        if (Tecan == null)
                        {
                            if (replacement == null)
                            {
                                Tecan = new PumpTypeState(this);
                            }
                            else
                            {
                                Tecan = (PumpTypeState)replacement;
                            }
                        }
                    }

                    instance = Tecan;
                    break;
                }

                case UAModel.gh.BrowseNames.OpticalModel:
                {
                    if (createOrReplace)
                    {
                        if (OpticalModel == null)
                        {
                            if (replacement == null)
                            {
                                OpticalModel = new RunModelTypeState(this);
                            }
                            else
                            {
                                OpticalModel = (RunModelTypeState)replacement;
                            }
                        }
                    }

                    instance = OpticalModel;
                    break;
                }

                case UAModel.gh.BrowseNames.DualModel:
                {
                    if (createOrReplace)
                    {
                        if (DualModel == null)
                        {
                            if (replacement == null)
                            {
                                DualModel = new RunModelTypeState(this);
                            }
                            else
                            {
                                DualModel = (RunModelTypeState)replacement;
                            }
                        }
                    }

                    instance = DualModel;
                    break;
                }

                case UAModel.gh.BrowseNames.AutoPlungerp:
                {
                    if (createOrReplace)
                    {
                        if (AutoPlungerp == null)
                        {
                            if (replacement == null)
                            {
                                AutoPlungerp = new PlungerpTypeState(this);
                            }
                            else
                            {
                                AutoPlungerp = (PlungerpTypeState)replacement;
                            }
                        }
                    }

                    instance = AutoPlungerp;
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
        private CamTypeState m_balser;
        private MeanDistanceState m_iF2451;
        private PumpTypeState m_tecan;
        private RunModelTypeState m_opticalModel;
        private RunModelTypeState m_dualModel;
        private PlungerpTypeState m_autoPlungerp;
        #endregion
    }
    #endif
    #endregion

    #region CentrifugeTypeState Class
    #if (!OPCUA_EXCLUDE_CentrifugeTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CentrifugeTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public CentrifugeTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.CentrifugeType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Id != null)
            {
                Id.Initialize(context, Id_InitializationString);
            }

            if (Speed != null)
            {
                Speed.Initialize(context, Speed_InitializationString);
            }

            if (StartCentrifuge != null)
            {
                StartCentrifuge.Initialize(context, StartCentrifuge_InitializationString);
            }

            if (StopCentrifuge != null)
            {
                StopCentrifuge.Initialize(context, StopCentrifuge_InitializationString);
            }

            if (Status != null)
            {
                Status.Initialize(context, Status_InitializationString);
            }

            if (CtrlLid != null)
            {
                CtrlLid.Initialize(context, CtrlLid_InitializationString);
            }

            if (Mode != null)
            {
                Mode.Initialize(context, Mode_InitializationString);
            }
        }

        #region Initialization String
        private const string Id_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQACAAAASWQB" +
           "AZcXAC8AP5cXAAAABv////8DA/////8AAAAA";

        private const string Speed_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAFAAAAU3Bl" +
           "ZWQBAZgXAC8AP5gXAAAAC/////8DA/////8AAAAA";

        private const string StartCentrifuge_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAPAAAAU3Rh" +
           "cnRDZW50cmlmdWdlAQFjGwAvAQFjG2MbAAABAf////8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBmRcDAAAAAEcAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0" +
           "aG9kIDE6Q2VudHJpZnVnZVR5cGUuMTpTdGFydAAuAESZFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBmhcDAAAAAEkAAAB0aGUgZGVmaW5pdGlvbiBv" +
           "ZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpDZW50cmlmdWdlVHlwZS4xOlN0YXJ0AC4A" +
           "RJoXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string StopCentrifuge_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAOAAAAU3Rv" +
           "cENlbnRyaWZ1Z2UBAWQbAC8BAWQbZBsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQGbFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRo" +
           "b2QgMTpDZW50cmlmdWdlVHlwZS4xOlN0b3AALgBEmxcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "N2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZwXAwAAAABIAAAAdGhlIGRlZmluaXRpb24gb2Yg" +
           "dGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6Q2VudHJpZnVnZVR5cGUuMTpTdG9wAC4ARJwX" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string Status_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAGAAAAU3Rh" +
           "dHVzAQGdFwAvAD+dFwAAAAb/////AwP/////AAAAAA==";

        private const string CtrlLid_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAHAAAAQ3Ry" +
           "bExpZAEBfRsALwEBfRt9GwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAa8X" +
           "AwAAAABJAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOkNl" +
           "bnRyaWZ1Z2VUeXBlLjE6Q3RybExpZAAuAESvFwAAlgEAAAABACoBARUAAAAGAAAATGlkU2V0AAH/////" +
           "AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQG1FwMAAAAASwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhv" +
           "ZCAxOkNlbnRyaWZ1Z2VUeXBlLjE6Q3RybExpZAAuAES1FwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAA=";

        private const string Mode_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAATW9k" +
           "ZQEBuRcALwA/uRcAAAAF/////wMD/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAWAAAAQ2Vu" +
           "dHJpZnVnZVR5cGVJbnN0YW5jZQEB7wMBAe8D7wMAAP////8HAAAAFWCJCgIAAAABAAIAAABJZAEBlxcA" +
           "LwA/lxcAAAAG/////wMD/////wAAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQGYFwAvAD+YFwAAAAv/////" +
           "AwP/////AAAAAARhggoEAAAAAQAPAAAAU3RhcnRDZW50cmlmdWdlAQFjGwAvAQFjG2MbAAABAf////8C" +
           "AAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBmRcDAAAAAEcAAAB0aGUgZGVmaW5pdGlvbiBv" +
           "ZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6Q2VudHJpZnVnZVR5cGUuMTpTdGFydAAuAESZ" +
           "FwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "mhcDAAAAAEkAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2Qg" +
           "MTpDZW50cmlmdWdlVHlwZS4xOlN0YXJ0AC4ARJoXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARh" +
           "ggoEAAAAAQAOAAAAU3RvcENlbnRyaWZ1Z2UBAWQbAC8BAWQbZBsAAAEB/////wIAAAA3YIkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQGbFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBh" +
           "cmd1bWVudCBvZiBtZXRob2QgMTpDZW50cmlmdWdlVHlwZS4xOlN0b3AALgBEmxcAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZwXAwAAAABIAAAAdGhl" +
           "IGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6Q2VudHJpZnVnZVR5" +
           "cGUuMTpTdG9wAC4ARJwXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABVgiQoCAAAAAQAGAAAAU3Rh" +
           "dHVzAQGdFwAvAD+dFwAAAAb/////AwP/////AAAAAARhggoEAAAAAQAHAAAAQ3RybExpZAEBfRsALwEB" +
           "fRt9GwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAa8XAwAAAABJAAAAdGhl" +
           "IGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOkNlbnRyaWZ1Z2VUeXBl" +
           "LjE6Q3RybExpZAAuAESvFwAAlgEAAAABACoBARUAAAAGAAAATGlkU2V0AAH/////AAAAAAABACgBAQAA" +
           "AAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQG1FwMAAAAASwAA" +
           "AHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOkNlbnRyaWZ1" +
           "Z2VUeXBlLjE6Q3RybExpZAAuAES1FwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "BAAAAE1vZGUBAbkXAC8AP7kXAAAABf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> Id
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
        public MethodState StartCentrifuge
        {
            get
            {
                return m_startCentrifugeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startCentrifugeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startCentrifugeMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopCentrifuge
        {
            get
            {
                return m_stopCentrifugeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopCentrifugeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopCentrifugeMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<int> Status
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

        /// <remarks />
        public CtrlLidMethodState CtrlLid
        {
            get
            {
                return m_ctrlLidMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ctrlLidMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ctrlLidMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Mode
        {
            get
            {
                return m_mode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mode = value;
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

            if (m_startCentrifugeMethod != null)
            {
                children.Add(m_startCentrifugeMethod);
            }

            if (m_stopCentrifugeMethod != null)
            {
                children.Add(m_stopCentrifugeMethod);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_ctrlLidMethod != null)
            {
                children.Add(m_ctrlLidMethod);
            }

            if (m_mode != null)
            {
                children.Add(m_mode);
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
                case UAModel.gh.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case UAModel.gh.BrowseNames.Speed:
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

                case UAModel.gh.BrowseNames.StartCentrifuge:
                {
                    if (createOrReplace)
                    {
                        if (StartCentrifuge == null)
                        {
                            if (replacement == null)
                            {
                                StartCentrifuge = new MethodState(this);
                            }
                            else
                            {
                                StartCentrifuge = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartCentrifuge;
                    break;
                }

                case UAModel.gh.BrowseNames.StopCentrifuge:
                {
                    if (createOrReplace)
                    {
                        if (StopCentrifuge == null)
                        {
                            if (replacement == null)
                            {
                                StopCentrifuge = new MethodState(this);
                            }
                            else
                            {
                                StopCentrifuge = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopCentrifuge;
                    break;
                }

                case UAModel.gh.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case UAModel.gh.BrowseNames.CtrlLid:
                {
                    if (createOrReplace)
                    {
                        if (CtrlLid == null)
                        {
                            if (replacement == null)
                            {
                                CtrlLid = new CtrlLidMethodState(this);
                            }
                            else
                            {
                                CtrlLid = (CtrlLidMethodState)replacement;
                            }
                        }
                    }

                    instance = CtrlLid;
                    break;
                }

                case UAModel.gh.BrowseNames.Mode:
                {
                    if (createOrReplace)
                    {
                        if (Mode == null)
                        {
                            if (replacement == null)
                            {
                                Mode = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Mode = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Mode;
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
        private BaseDataVariableState<int> m_id;
        private BaseDataVariableState<double> m_speed;
        private MethodState m_startCentrifugeMethod;
        private MethodState m_stopCentrifugeMethod;
        private BaseDataVariableState<int> m_status;
        private CtrlLidMethodState m_ctrlLidMethod;
        private BaseDataVariableState<ushort> m_mode;
        #endregion
    }
    #endif
    #endregion

    #region PcrTypeState Class
    #if (!OPCUA_EXCLUDE_PcrTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PcrTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PcrTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.PcrType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Id != null)
            {
                Id.Initialize(context, Id_InitializationString);
            }

            if (SetTmep != null)
            {
                SetTmep.Initialize(context, SetTmep_InitializationString);
            }

            if (CurTemp != null)
            {
                CurTemp.Initialize(context, CurTemp_InitializationString);
            }

            if (Start != null)
            {
                Start.Initialize(context, Start_InitializationString);
            }

            if (Stop != null)
            {
                Stop.Initialize(context, Stop_InitializationString);
            }
        }

        #region Initialization String
        private const string Id_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQACAAAASWQB" +
           "AZ8XAC8AP58XAAAABv////8DA/////8AAAAA";

        private const string SetTmep_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAHAAAAU2V0" +
           "VG1lcAEBoBcALwA/oBcAAAAL/////wMD/////wAAAAA=";

        private const string CurTemp_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAHAAAAQ3Vy" +
           "VGVtcAEBoRcALwA/oRcAAAAL/////wMD/////wAAAAA=";

        private const string Start_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAFAAAAU3Rh" +
           "cnQBAWUbAC8BAWUbZRsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGiFwMA" +
           "AAAAQAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpQY3JU" +
           "eXBlLjE6U3RhcnQALgBEohcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAaMXAwAAAABCAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1" +
           "bWVudHMgb2YgbWV0aG9kIDE6UGNyVHlwZS4xOlN0YXJ0AC4ARKMXAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAA==";

        private const string Stop_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAEAAAAU3Rv" +
           "cAEBZhsALwEBZhtmGwAAAQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaQXAwAA" +
           "AAA/AAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlBjclR5" +
           "cGUuMTpTdG9wAC4ARKQXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQGlFwMAAAAAQQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1l" +
           "bnRzIG9mIG1ldGhvZCAxOlBjclR5cGUuMTpTdG9wAC4ARKUXAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAPAAAAUGNy" +
           "VHlwZUluc3RhbmNlAQHwAwEB8APwAwAA/////wUAAAAVYIkKAgAAAAEAAgAAAElkAQGfFwAvAD+fFwAA" +
           "AAb/////AwP/////AAAAABVgiQoCAAAAAQAHAAAAU2V0VG1lcAEBoBcALwA/oBcAAAAL/////wMD////" +
           "/wAAAAAVYIkKAgAAAAEABwAAAEN1clRlbXABAaEXAC8AP6EXAAAAC/////8DA/////8AAAAABGGCCgQA" +
           "AAABAAUAAABTdGFydAEBZRsALwEBZRtlGwAAAQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBAaIXAwAAAABAAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1l" +
           "dGhvZCAxOlBjclR5cGUuMTpTdGFydAAuAESiFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA3YIkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBoxcDAAAAAEIAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUg" +
           "b3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQY3JUeXBlLjE6U3RhcnQALgBEoxcAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAQAAABTdG9wAQFmGwAvAQFmG2YbAAABAf////8CAAAA" +
           "N2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpBcDAAAAAD8AAAB0aGUgZGVmaW5pdGlvbiBvZiB0" +
           "aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6UGNyVHlwZS4xOlN0b3AALgBEpBcAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaUXAwAAAABBAAAA" +
           "dGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UGNyVHlwZS4x" +
           "OlN0b3AALgBEpRcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> Id
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
        public BaseDataVariableState<double> SetTmep
        {
            get
            {
                return m_setTmep;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setTmep, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setTmep = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> CurTemp
        {
            get
            {
                return m_curTemp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_curTemp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_curTemp = value;
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

            if (m_setTmep != null)
            {
                children.Add(m_setTmep);
            }

            if (m_curTemp != null)
            {
                children.Add(m_curTemp);
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
                case UAModel.gh.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case UAModel.gh.BrowseNames.SetTmep:
                {
                    if (createOrReplace)
                    {
                        if (SetTmep == null)
                        {
                            if (replacement == null)
                            {
                                SetTmep = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                SetTmep = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = SetTmep;
                    break;
                }

                case UAModel.gh.BrowseNames.CurTemp:
                {
                    if (createOrReplace)
                    {
                        if (CurTemp == null)
                        {
                            if (replacement == null)
                            {
                                CurTemp = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CurTemp = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CurTemp;
                    break;
                }

                case UAModel.gh.BrowseNames.Start:
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

                case UAModel.gh.BrowseNames.Stop:
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
        private BaseDataVariableState<int> m_id;
        private BaseDataVariableState<double> m_setTmep;
        private BaseDataVariableState<double> m_curTemp;
        private MethodState m_startMethod;
        private MethodState m_stopMethod;
        #endregion
    }
    #endif
    #endregion

    #region PMTTypeState Class
    #if (!OPCUA_EXCLUDE_PMTTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PMTTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PMTTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.PMTType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Id != null)
            {
                Id.Initialize(context, Id_InitializationString);
            }

            if (StartCapture != null)
            {
                StartCapture.Initialize(context, StartCapture_InitializationString);
            }

            if (StopCapture != null)
            {
                StopCapture.Initialize(context, StopCapture_InitializationString);
            }

            if (GetPmtValue != null)
            {
                GetPmtValue.Initialize(context, GetPmtValue_InitializationString);
            }
        }

        #region Initialization String
        private const string Id_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQACAAAASWQB" +
           "AaYXAC8AP6YXAAAABv////8DA/////8AAAAA";

        private const string StartCapture_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAMAAAAU3Rh" +
           "cnRDYXB0dXJlAQFnGwAvAQFnG2cbAAABAf////8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBpxcDAAAAAEcAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9k" +
           "IDE6UE1UVHlwZS4xOlN0YXJ0Q2FwdHVyZQAuAESnFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA3" +
           "YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBqBcDAAAAAEkAAAB0aGUgZGVmaW5pdGlvbiBvZiB0" +
           "aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQTVRUeXBlLjE6U3RhcnRDYXB0dXJlAC4ARKgX" +
           "AAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string StopCapture_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQALAAAAU3Rv" +
           "cENhcHR1cmUBAWgbAC8BAWgbaBsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQGpFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2Qg" +
           "MTpQTVRUeXBlLjE6U3RvcENhcHR1cmUALgBEqRcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJ" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaoXAwAAAABIAAAAdGhlIGRlZmluaXRpb24gb2YgdGhl" +
           "IG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UE1UVHlwZS4xOlN0b3BDYXB0dXJlAC4ARKoXAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string GetPmtValue_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQALAAAAR2V0" +
           "UG10VmFsdWUBAWkbAC8BAWkbaRsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQGrFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2Qg" +
           "MTpQTVRUeXBlLjE6R2V0UG10VmFsdWUALgBEqxcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJ" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAawXAwAAAABIAAAAdGhlIGRlZmluaXRpb24gb2YgdGhl" +
           "IG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UE1UVHlwZS4xOkdldFBtdFZhbHVlAC4ARKwXAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAPAAAAUE1U" +
           "VHlwZUluc3RhbmNlAQHxAwEB8QPxAwAA/////wQAAAAVYIkKAgAAAAEAAgAAAElkAQGmFwAvAD+mFwAA" +
           "AAb/////AwP/////AAAAAARhggoEAAAAAQAMAAAAU3RhcnRDYXB0dXJlAQFnGwAvAQFnG2cbAAABAf//" +
           "//8CAAAAN2CJCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBpxcDAAAAAEcAAAB0aGUgZGVmaW5pdGlv" +
           "biBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6UE1UVHlwZS4xOlN0YXJ0Q2FwdHVyZQAu" +
           "AESnFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50" +
           "cwEBqBcDAAAAAEkAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRo" +
           "b2QgMTpQTVRUeXBlLjE6U3RhcnRDYXB0dXJlAC4ARKgXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQALAAAAU3RvcENhcHR1cmUBAWgbAC8BAWgbaBsAAAEB/////wIAAAA3YIkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQGpFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBh" +
           "cmd1bWVudCBvZiBtZXRob2QgMTpQTVRUeXBlLjE6U3RvcENhcHR1cmUALgBEqRcAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaoXAwAAAABIAAAAdGhl" +
           "IGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UE1UVHlwZS4xOlN0" +
           "b3BDYXB0dXJlAC4ARKoXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQALAAAAR2V0" +
           "UG10VmFsdWUBAWkbAC8BAWkbaRsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQGrFwMAAAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2Qg" +
           "MTpQTVRUeXBlLjE6R2V0UG10VmFsdWUALgBEqxcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJ" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAawXAwAAAABIAAAAdGhlIGRlZmluaXRpb24gb2YgdGhl" +
           "IG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UE1UVHlwZS4xOkdldFBtdFZhbHVlAC4ARKwXAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> Id
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
        public MethodState StartCapture
        {
            get
            {
                return m_startCaptureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startCaptureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startCaptureMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopCapture
        {
            get
            {
                return m_stopCaptureMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopCaptureMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopCaptureMethod = value;
            }
        }

        /// <remarks />
        public MethodState GetPmtValue
        {
            get
            {
                return m_getPmtValueMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getPmtValueMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getPmtValueMethod = value;
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

            if (m_startCaptureMethod != null)
            {
                children.Add(m_startCaptureMethod);
            }

            if (m_stopCaptureMethod != null)
            {
                children.Add(m_stopCaptureMethod);
            }

            if (m_getPmtValueMethod != null)
            {
                children.Add(m_getPmtValueMethod);
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
                case UAModel.gh.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case UAModel.gh.BrowseNames.StartCapture:
                {
                    if (createOrReplace)
                    {
                        if (StartCapture == null)
                        {
                            if (replacement == null)
                            {
                                StartCapture = new MethodState(this);
                            }
                            else
                            {
                                StartCapture = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartCapture;
                    break;
                }

                case UAModel.gh.BrowseNames.StopCapture:
                {
                    if (createOrReplace)
                    {
                        if (StopCapture == null)
                        {
                            if (replacement == null)
                            {
                                StopCapture = new MethodState(this);
                            }
                            else
                            {
                                StopCapture = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopCapture;
                    break;
                }

                case UAModel.gh.BrowseNames.GetPmtValue:
                {
                    if (createOrReplace)
                    {
                        if (GetPmtValue == null)
                        {
                            if (replacement == null)
                            {
                                GetPmtValue = new MethodState(this);
                            }
                            else
                            {
                                GetPmtValue = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GetPmtValue;
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
        private BaseDataVariableState<int> m_id;
        private MethodState m_startCaptureMethod;
        private MethodState m_stopCaptureMethod;
        private MethodState m_getPmtValueMethod;
        #endregion
    }
    #endif
    #endregion

    #region NAEBotTypeState Class
    #if (!OPCUA_EXCLUDE_NAEBotTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class NAEBotTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public NAEBotTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.NAEBotType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (centrifuge != null)
            {
                centrifuge.Initialize(context, centrifuge_InitializationString);
            }

            if (DualTip != null)
            {
                DualTip.Initialize(context, DualTip_InitializationString);
            }

            if (LinearModel != null)
            {
                LinearModel.Initialize(context, LinearModel_InitializationString);
            }

            if (PMT != null)
            {
                PMT.Initialize(context, PMT_InitializationString);
            }

            if (Oscillate != null)
            {
                Oscillate.Initialize(context, Oscillate_InitializationString);
            }

            if (VibrateHeat != null)
            {
                VibrateHeat.Initialize(context, VibrateHeat_InitializationString);
            }
        }

        #region Initialization String
        private const string centrifuge_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAKAAAAY2Vu" +
           "dHJpZnVnZQEBlBMAIwEB7wOUEwAA/////wAAAAA=";

        private const string DualTip_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAHAAAARHVh" +
           "bFRpcAEBlhMAIwEB7QOWEwAA/////wAAAAA=";

        private const string LinearModel_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQALAAAATGlu" +
           "ZWFyTW9kZWwBAZcTACMBAekDlxMAAP////8AAAAA";

        private const string PMT_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQADAAAAUE1U" +
           "AQGYEwAjAQHxA5gTAAD/////AAAAAA==";

        private const string Oscillate_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQAJAAAAT3Nj" +
           "aWxsYXRlAQGaEwAjAQHzA5oTAAD/////AAAAAA==";

        private const string VibrateHeat_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAoBAAAAAQALAAAAVmli" +
           "cmF0ZUhlYXQBAZsTACMBAfQDmxMAAP////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQASAAAATkFF" +
           "Qm90VHlwZUluc3RhbmNlAQHyAwEB8gPyAwAA/////wYAAAAEYIAKAQAAAAEACgAAAGNlbnRyaWZ1Z2UB" +
           "AZQTACMBAe8DlBMAAP////8AAAAABGCACgEAAAABAAcAAABEdWFsVGlwAQGWEwAjAQHtA5YTAAD/////" +
           "AAAAAARggAoBAAAAAQALAAAATGluZWFyTW9kZWwBAZcTACMBAekDlxMAAP////8AAAAABGCACgEAAAAB" +
           "AAMAAABQTVQBAZgTACMBAfEDmBMAAP////8AAAAABGCACgEAAAABAAkAAABPc2NpbGxhdGUBAZoTACMB" +
           "AfMDmhMAAP////8AAAAABGCACgEAAAABAAsAAABWaWJyYXRlSGVhdAEBmxMAIwEB9AObEwAA/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CentrifugeTypeState centrifuge
        {
            get
            {
                return m_centrifuge;
            }

            set
            {
                if (!Object.ReferenceEquals(m_centrifuge, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_centrifuge = value;
            }
        }

        /// <remarks />
        public PumpTypeState DualTip
        {
            get
            {
                return m_dualTip;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dualTip, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dualTip = value;
            }
        }

        /// <remarks />
        public RunModelTypeState LinearModel
        {
            get
            {
                return m_linearModel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_linearModel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_linearModel = value;
            }
        }

        /// <remarks />
        public PMTTypeState PMT
        {
            get
            {
                return m_pMT;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pMT, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pMT = value;
            }
        }

        /// <remarks />
        public OscillateTypeState Oscillate
        {
            get
            {
                return m_oscillate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_oscillate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_oscillate = value;
            }
        }

        /// <remarks />
        public VibrateAndHeatTypeState VibrateHeat
        {
            get
            {
                return m_vibrateHeat;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vibrateHeat, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vibrateHeat = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_centrifuge != null)
            {
                children.Add(m_centrifuge);
            }

            if (m_dualTip != null)
            {
                children.Add(m_dualTip);
            }

            if (m_linearModel != null)
            {
                children.Add(m_linearModel);
            }

            if (m_pMT != null)
            {
                children.Add(m_pMT);
            }

            if (m_oscillate != null)
            {
                children.Add(m_oscillate);
            }

            if (m_vibrateHeat != null)
            {
                children.Add(m_vibrateHeat);
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
                case UAModel.gh.BrowseNames.centrifuge:
                {
                    if (createOrReplace)
                    {
                        if (centrifuge == null)
                        {
                            if (replacement == null)
                            {
                                centrifuge = new CentrifugeTypeState(this);
                            }
                            else
                            {
                                centrifuge = (CentrifugeTypeState)replacement;
                            }
                        }
                    }

                    instance = centrifuge;
                    break;
                }

                case UAModel.gh.BrowseNames.DualTip:
                {
                    if (createOrReplace)
                    {
                        if (DualTip == null)
                        {
                            if (replacement == null)
                            {
                                DualTip = new PumpTypeState(this);
                            }
                            else
                            {
                                DualTip = (PumpTypeState)replacement;
                            }
                        }
                    }

                    instance = DualTip;
                    break;
                }

                case UAModel.gh.BrowseNames.LinearModel:
                {
                    if (createOrReplace)
                    {
                        if (LinearModel == null)
                        {
                            if (replacement == null)
                            {
                                LinearModel = new RunModelTypeState(this);
                            }
                            else
                            {
                                LinearModel = (RunModelTypeState)replacement;
                            }
                        }
                    }

                    instance = LinearModel;
                    break;
                }

                case UAModel.gh.BrowseNames.PMT:
                {
                    if (createOrReplace)
                    {
                        if (PMT == null)
                        {
                            if (replacement == null)
                            {
                                PMT = new PMTTypeState(this);
                            }
                            else
                            {
                                PMT = (PMTTypeState)replacement;
                            }
                        }
                    }

                    instance = PMT;
                    break;
                }

                case UAModel.gh.BrowseNames.Oscillate:
                {
                    if (createOrReplace)
                    {
                        if (Oscillate == null)
                        {
                            if (replacement == null)
                            {
                                Oscillate = new OscillateTypeState(this);
                            }
                            else
                            {
                                Oscillate = (OscillateTypeState)replacement;
                            }
                        }
                    }

                    instance = Oscillate;
                    break;
                }

                case UAModel.gh.BrowseNames.VibrateHeat:
                {
                    if (createOrReplace)
                    {
                        if (VibrateHeat == null)
                        {
                            if (replacement == null)
                            {
                                VibrateHeat = new VibrateAndHeatTypeState(this);
                            }
                            else
                            {
                                VibrateHeat = (VibrateAndHeatTypeState)replacement;
                            }
                        }
                    }

                    instance = VibrateHeat;
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
        private CentrifugeTypeState m_centrifuge;
        private PumpTypeState m_dualTip;
        private RunModelTypeState m_linearModel;
        private PMTTypeState m_pMT;
        private OscillateTypeState m_oscillate;
        private VibrateAndHeatTypeState m_vibrateHeat;
        #endregion
    }
    #endif
    #endregion

    #region OscillateTypeState Class
    #if (!OPCUA_EXCLUDE_OscillateTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OscillateTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public OscillateTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.OscillateType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Id != null)
            {
                Id.Initialize(context, Id_InitializationString);
            }

            if (moduleType != null)
            {
                moduleType.Initialize(context, moduleType_InitializationString);
            }

            if (Start != null)
            {
                Start.Initialize(context, Start_InitializationString);
            }

            if (Stop != null)
            {
                Stop.Initialize(context, Stop_InitializationString);
            }

            if (Status != null)
            {
                Status.Initialize(context, Status_InitializationString);
            }
        }

        #region Initialization String
        private const string Id_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQACAAAASWQB" +
           "Aa0XAC8AP60XAAAABv////8DA/////8AAAAA";

        private const string moduleType_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAKAAAAbW9k" +
           "dWxlVHlwZQEBrhcALwA/rhcAAAAG/////wMD/////wAAAAA=";

        private const string Start_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAFAAAAU3Rh" +
           "cnQBAWobAC8BAWobahsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGwFwMA" +
           "AAAARgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpPc2Np" +
           "bGxhdGVUeXBlLjE6U3RhcnQALgBEsBcAAJYCAAAAAQAqAQEZAAAACgAAAG1vZHVsZVR5cGUABv////8A" +
           "AAAAAAEAKgEBHAAAAA0AAABvc2NpbGxhdGVUaW1lAAb/////AAAAAAABACgBAQAAAAEAAAACAAAAAQH/" +
           "////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGxFwMAAAAASAAAAHRoZSBkZWZpbml0" +
           "aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOk9zY2lsbGF0ZVR5cGUuMTpTdGFy" +
           "dAAuAESxFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string Stop_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAEAAAAU3Rv" +
           "cAEBaxsALwEBaxtrGwAAAQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbIXAwAA" +
           "AABFAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOk9zY2ls" +
           "bGF0ZVR5cGUuMTpTdG9wAC4ARLIXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAADdgiQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQGzFwMAAAAARwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQg" +
           "YXJndW1lbnRzIG9mIG1ldGhvZCAxOk9zY2lsbGF0ZVR5cGUuMTpTdG9wAC4ARLMXAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAA==";

        private const string Status_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAGAAAAU3Rh" +
           "dHVzAQG/FwAvAD+/FwAAAAb/////AwP/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAVAAAAT3Nj" +
           "aWxsYXRlVHlwZUluc3RhbmNlAQHzAwEB8wPzAwAA/////wUAAAAVYIkKAgAAAAEAAgAAAElkAQGtFwAv" +
           "AD+tFwAAAAb/////AwP/////AAAAABVgiQoCAAAAAQAKAAAAbW9kdWxlVHlwZQEBrhcALwA/rhcAAAAG" +
           "/////wMD/////wAAAAAEYYIKBAAAAAEABQAAAFN0YXJ0AQFqGwAvAQFqG2obAAABAf////8CAAAAN2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBsBcDAAAAAEYAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUg" +
           "aW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6T3NjaWxsYXRlVHlwZS4xOlN0YXJ0AC4ARLAXAACWAgAA" +
           "AAEAKgEBGQAAAAoAAABtb2R1bGVUeXBlAAb/////AAAAAAABACoBARwAAAANAAAAb3NjaWxsYXRlVGlt" +
           "ZQAG/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEBsRcDAAAAAEgAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBv" +
           "ZiBtZXRob2QgMTpPc2NpbGxhdGVUeXBlLjE6U3RhcnQALgBEsRcAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAABGGCCgQAAAABAAQAAABTdG9wAQFrGwAvAQFrG2sbAAABAf////8CAAAAN2CJCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBshcDAAAAAEUAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJn" +
           "dW1lbnQgb2YgbWV0aG9kIDE6T3NjaWxsYXRlVHlwZS4xOlN0b3AALgBEshcAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAbMXAwAAAABHAAAAdGhlIGRl" +
           "ZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6T3NjaWxsYXRlVHlwZS4x" +
           "OlN0b3AALgBEsxcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAAYAAABTdGF0dXMB" +
           "Ab8XAC8AP78XAAAABv////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> Id
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
        public BaseDataVariableState<int> moduleType
        {
            get
            {
                return m_moduleType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_moduleType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_moduleType = value;
            }
        }

        /// <remarks />
        public StartMethodState Start
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
        public BaseDataVariableState<int> Status
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
            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_moduleType != null)
            {
                children.Add(m_moduleType);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
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
                case UAModel.gh.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case UAModel.gh.BrowseNames.moduleType:
                {
                    if (createOrReplace)
                    {
                        if (moduleType == null)
                        {
                            if (replacement == null)
                            {
                                moduleType = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                moduleType = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = moduleType;
                    break;
                }

                case UAModel.gh.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new StartMethodState(this);
                            }
                            else
                            {
                                Start = (StartMethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case UAModel.gh.BrowseNames.Stop:
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

                case UAModel.gh.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<int>)replacement;
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
        private BaseDataVariableState<int> m_id;
        private BaseDataVariableState<int> m_moduleType;
        private StartMethodState m_startMethod;
        private MethodState m_stopMethod;
        private BaseDataVariableState<int> m_status;
        #endregion
    }
    #endif
    #endregion

    #region VibrateAndHeatTypeState Class
    #if (!OPCUA_EXCLUDE_VibrateAndHeatTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VibrateAndHeatTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public VibrateAndHeatTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.VibrateAndHeatType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Id != null)
            {
                Id.Initialize(context, Id_InitializationString);
            }

            if (mode != null)
            {
                mode.Initialize(context, mode_InitializationString);
            }

            if (Start != null)
            {
                Start.Initialize(context, Start_InitializationString);
            }

            if (Stop != null)
            {
                Stop.Initialize(context, Stop_InitializationString);
            }

            if (Status != null)
            {
                Status.Initialize(context, Status_InitializationString);
            }

            if (Temp != null)
            {
                Temp.Initialize(context, Temp_InitializationString);
            }
        }

        #region Initialization String
        private const string Id_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQACAAAASWQB" +
           "AbQXAC8AP7QXAAAABv////8DA/////8AAAAA";

        private const string mode_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAAbW9k" +
           "ZQEBthcALwA/thcAAAAG/////wMD/////wAAAAA=";

        private const string Start_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAFAAAAU3Rh" +
           "cnQBAWwbAC8BAWwbbBsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG6FwMA" +
           "AAAASwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpWaWJy" +
           "YXRlQW5kSGVhdFR5cGUuMTpTdGFydAAuAES6FwAAlgMAAAABACoBARcAAAAIAAAAbG9jYXRpb24ABv//" +
           "//8AAAAAAAEAKgEBEwAAAAQAAABtb2RlAAb/////AAAAAAABACoBARUAAAAGAAAAb3BUaW1lAAb/////" +
           "AAAAAAABACgBAQAAAAEAAAADAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQG7FwMAAAAATQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhv" +
           "ZCAxOlZpYnJhdGVBbmRIZWF0VHlwZS4xOlN0YXJ0AC4ARLsXAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAAA==";

        private const string Stop_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAEAAAAU3Rv" +
           "cAEBbRsALwEBbRttGwAAAQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbwXAwAA" +
           "AABKAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlZpYnJh" +
           "dGVBbmRIZWF0VHlwZS4xOlN0b3AALgBEvBcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAb0XAwAAAABMAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91" +
           "dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6VmlicmF0ZUFuZEhlYXRUeXBlLjE6U3RvcAAuAES9FwAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string Status_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAGAAAAU3Rh" +
           "dHVzAQG+FwAvAD++FwAAAAb/////AwP/////AAAAAA==";

        private const string Temp_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAAVGVt" +
           "cAEBTRgALwA/TRgAAAAL/////wMD/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAaAAAAVmli" +
           "cmF0ZUFuZEhlYXRUeXBlSW5zdGFuY2UBAfQDAQH0A/QDAAD/////BgAAABVgiQoCAAAAAQACAAAASWQB" +
           "AbQXAC8AP7QXAAAABv////8DA/////8AAAAAFWCJCgIAAAABAAQAAABtb2RlAQG2FwAvAD+2FwAAAAb/" +
           "////AwP/////AAAAAARhggoEAAAAAQAFAAAAU3RhcnQBAWwbAC8BAWwbbBsAAAEB/////wIAAAA3YKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG6FwMAAAAASwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBp" +
           "bnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpWaWJyYXRlQW5kSGVhdFR5cGUuMTpTdGFydAAuAES6FwAA" +
           "lgMAAAABACoBARcAAAAIAAAAbG9jYXRpb24ABv////8AAAAAAAEAKgEBEwAAAAQAAABtb2RlAAb/////" +
           "AAAAAAABACoBARUAAAAGAAAAb3BUaW1lAAb/////AAAAAAABACgBAQAAAAEAAAADAAAAAQH/////AAAA" +
           "ADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQG7FwMAAAAATQAAAHRoZSBkZWZpbml0aW9uIG9m" +
           "IHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOlZpYnJhdGVBbmRIZWF0VHlwZS4xOlN0YXJ0" +
           "AC4ARLsXAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAEAAAAU3RvcAEBbRsALwEB" +
           "bRttGwAAAQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAbwXAwAAAABKAAAAdGhl" +
           "IGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlZpYnJhdGVBbmRIZWF0" +
           "VHlwZS4xOlN0b3AALgBEvBcAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAb0XAwAAAABMAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1" +
           "bWVudHMgb2YgbWV0aG9kIDE6VmlicmF0ZUFuZEhlYXRUeXBlLjE6U3RvcAAuAES9FwAAAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAEABgAAAFN0YXR1cwEBvhcALwA/vhcAAAAG/////wMD////" +
           "/wAAAAAVYIkKAgAAAAEABAAAAFRlbXABAU0YAC8AP00YAAAAC/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<int> Id
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
        public BaseDataVariableState<int> mode
        {
            get
            {
                return m_mode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mode = value;
            }
        }

        /// <remarks />
        public StartMethodState Start
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
        public BaseDataVariableState<int> Status
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

            if (m_mode != null)
            {
                children.Add(m_mode);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
            }

            if (m_status != null)
            {
                children.Add(m_status);
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
                case UAModel.gh.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case UAModel.gh.BrowseNames.mode:
                {
                    if (createOrReplace)
                    {
                        if (mode == null)
                        {
                            if (replacement == null)
                            {
                                mode = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                mode = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = mode;
                    break;
                }

                case UAModel.gh.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new StartMethodState(this);
                            }
                            else
                            {
                                Start = (StartMethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case UAModel.gh.BrowseNames.Stop:
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

                case UAModel.gh.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case UAModel.gh.BrowseNames.Temp:
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
        private BaseDataVariableState<int> m_id;
        private BaseDataVariableState<int> m_mode;
        private StartMethodState m_startMethod;
        private MethodState m_stopMethod;
        private BaseDataVariableState<int> m_status;
        private BaseDataVariableState<double> m_temp;
        #endregion
    }
    #endif
    #endregion

    #region PlungerpTypeState Class
    #if (!OPCUA_EXCLUDE_PlungerpTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PlungerpTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PlungerpTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.gh.ObjectTypes.PlungerpType, UAModel.gh.Namespaces.gh, namespaceUris);
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

            if (Id != null)
            {
                Id.Initialize(context, Id_InitializationString);
            }

            if (Acc != null)
            {
                Acc.Initialize(context, Acc_InitializationString);
            }

            if (Dec != null)
            {
                Dec.Initialize(context, Dec_InitializationString);
            }

            if (VStart != null)
            {
                VStart.Initialize(context, VStart_InitializationString);
            }

            if (VEnd != null)
            {
                VEnd.Initialize(context, VEnd_InitializationString);
            }

            if (VMax != null)
            {
                VMax.Initialize(context, VMax_InitializationString);
            }

            if (Pos != null)
            {
                Pos.Initialize(context, Pos_InitializationString);
            }

            if (Compensation != null)
            {
                Compensation.Initialize(context, Compensation_InitializationString);
            }

            if (SetSpeed != null)
            {
                SetSpeed.Initialize(context, SetSpeed_InitializationString);
            }

            if (SetStartSpeed != null)
            {
                SetStartSpeed.Initialize(context, SetStartSpeed_InitializationString);
            }

            if (SetSlope != null)
            {
                SetSlope.Initialize(context, SetSlope_InitializationString);
            }

            if (SetCompensation != null)
            {
                SetCompensation.Initialize(context, SetCompensation_InitializationString);
            }

            if (Status != null)
            {
                Status.Initialize(context, Status_InitializationString);
            }

            if (RelativePump != null)
            {
                RelativePump.Initialize(context, RelativePump_InitializationString);
            }

            if (RelativeDischarge != null)
            {
                RelativeDischarge.Initialize(context, RelativeDischarge_InitializationString);
            }

            if (CheckError != null)
            {
                CheckError.Initialize(context, CheckError_InitializationString);
            }

            if (EjectTip != null)
            {
                EjectTip.Initialize(context, EjectTip_InitializationString);
            }

            if (GoAbs != null)
            {
                GoAbs.Initialize(context, GoAbs_InitializationString);
            }
        }

        #region Initialization String
        private const string Id_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQACAAAASWQB" +
           "AZ4XAC8AP54XAAAABf////8DA/////8AAAAA";

        private const string Acc_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////zVgiQoCAAAAAQADAAAAQWNj" +
           "AQFPGAMAAAAADQAAAGFjY2VsZXJhdGlvbiAALwA/TxgAAAAH/////wMD/////wAAAAA=";

        private const string Dec_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////zVgiQoCAAAAAQADAAAARGVj" +
           "AQFQGAMAAAAADAAAAGRlY2VsZXJhdGlvbgAvAD9QGAAAAAf/////AwP/////AAAAAA==";

        private const string VStart_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAGAAAAVlN0" +
           "YXJ0AQFRGAAvAD9RGAAAAAv/////AwP/////AAAAAA==";

        private const string VEnd_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAAVkVu" +
           "ZAEBUhgALwA/UhgAAAAL/////wMD/////wAAAAA=";

        private const string VMax_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAEAAAAVk1h" +
           "eAEBUxgALwA/UxgAAAAL/////wMD/////wAAAAA=";

        private const string Pos_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQADAAAAUG9z" +
           "AQFUGAAvAD9UGAAAAAf/////AwP/////AAAAAA==";

        private const string Compensation_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAMAAAAQ29t" +
           "cGVuc2F0aW9uAQFVGAAvAD9VGAAAAAf/////AwP/////AAAAAA==";

        private const string SetSpeed_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAIAAAAU2V0" +
           "U3BlZWQBAZ4bAC8BAZ4bnhsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFW" +
           "GAMAAAAASAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpQ" +
           "bHVuZ2VycFR5cGUuMTpTZXRTcGVlZAAuAERWGAAAlgMAAAABACoBARUAAAAGAAAAVnN0YXJ0ABj/////" +
           "AAAAAAABACoBARMAAAAEAAAAVk1heAAY/////wAAAAAAAQAqAQETAAAABAAAAFZFbmQAGP////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAMAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVcY" +
           "AwAAAABKAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6" +
           "UGx1bmdlcnBUeXBlLjE6U2V0U3BlZWQALgBEVxgAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";

        private const string SetStartSpeed_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQANAAAAU2V0" +
           "U3RhcnRTcGVlZAEBnxsALwEBnxufGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAVgYAwAAAABNAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhv" +
           "ZCAxOlBsdW5nZXJwVHlwZS4xOlNldFN0YXJ0U3BlZWQALgBEWBgAAJYBAAAAAQAqAQEUAAAABQAAAFNw" +
           "ZWVkABj/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQFZGAMAAAAATwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRz" +
           "IG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlwZS4xOlNldFN0YXJ0U3BlZWQALgBEWRgAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAA";

        private const string SetSlope_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAIAAAAU2V0" +
           "U2xvcGUBAaAbAC8BAaAboBsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFa" +
           "GAMAAAAASAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpQ" +
           "bHVuZ2VycFR5cGUuMTpTZXRTbG9wZQAuAERaGAAAlgIAAAABACoBAREAAAACAAAATDEAGP////8AAAAA" +
           "AAEAKgEBEQAAAAIAAABMMgAY/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA3YIkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEBWxgDAAAAAEoAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0" +
           "cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQbHVuZ2VycFR5cGUuMTpTZXRTbG9wZQAuAERbGAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string SetCompensation_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAPAAAAU2V0" +
           "Q29tcGVuc2F0aW9uAQGhGwAvAQGhG6EbAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBXBgDAAAAAE8AAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0" +
           "aG9kIDE6UGx1bmdlcnBUeXBlLjE6U2V0Q29tcGVuc2F0aW9uAC4ARFwYAACWAQAAAAEAKgEBLwAAAAwA" +
           "AABDb21wZW5zYXRpb24AGP////8AAAAAAhAAAABDb21wZW5zYXRpb24gU2V0AQAoAQEAAAABAAAAAQAA" +
           "AAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBXRgDAAAAAFEAAAB0aGUgZGVm" +
           "aW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQbHVuZ2VycFR5cGUuMTpT" +
           "ZXRDb21wZW5zYXRpb24ALgBEXRgAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";

        private const string Status_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAGAAAAU3Rh" +
           "dHVzAQFeGAAvAD9eGAAAAAX/////AwP/////AAAAAA==";

        private const string RelativePump_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAMAAAAUmVs" +
           "YXRpdmVQdW1wAQGiGwAvAQGiG6IbAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBXxgDAAAAAEwAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9k" +
           "IDE6UGx1bmdlcnBUeXBlLjE6UmVsYXRpdmVQdW1wAC4ARF8YAACWAQAAAAEAKgEBIgAAAAUAAABTdGVw" +
           "cwAY/////wAAAAACCgAAAFB1bXAgU3RlcHMBACgBAQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQFgGAMAAAAATgAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRw" +
           "dXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlwZS4xOlJlbGF0aXZlUHVtcAAuAERgGAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string RelativeDischarge_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQARAAAAUmVs" +
           "YXRpdmVEaXNjaGFyZ2UBAaMbAC8BAaMboxsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQFhGAMAAAAAUQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBt" +
           "ZXRob2QgMTpQbHVuZ2VycFR5cGUuMTpSZWxhdGl2ZURpc2NoYXJnZQAuAERhGAAAlgEAAAABACoBARQA" +
           "AAAFAAAAU3RlcHMAGP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAN2CJCgIAAAAAAA8A" +
           "AABPdXRwdXRBcmd1bWVudHMBAWIYAwAAAABTAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBh" +
           "cmd1bWVudHMgb2YgbWV0aG9kIDE6UGx1bmdlcnBUeXBlLjE6UmVsYXRpdmVEaXNjaGFyZ2UALgBEYhgA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";

        private const string CheckError_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAKAAAAQ2hl" +
           "Y2tFcnJvcgEBpBsALwEBpBukGwAAAQH/////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AWMYAwAAAABKAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAx" +
           "OlBsdW5nZXJwVHlwZS4xOkNoZWNrRXJyb3IALgBEYxgAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "N2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAWQYAwAAAABMAAAAdGhlIGRlZmluaXRpb24gb2Yg" +
           "dGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UGx1bmdlcnBUeXBlLjE6Q2hlY2tFcnJvcgAu" +
           "AERkGAAAlgEAAAABACoBASUAAAAJAAAARXJyb3JDb2RlAAX/////AAAAAAIJAAAARXJyb3JDb2RlAQAo" +
           "AQEAAAABAAAAAQAAAAEB/////wAAAAA=";

        private const string EjectTip_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAIAAAARWpl" +
           "Y3RUaXABAaUbAC8BAaUbpRsAAAEB/////wIAAAA3YIkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFl" +
           "GAMAAAAASAAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpQ" +
           "bHVuZ2VycFR5cGUuMTpFamVjdFRpcAAuAERlGAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA3YIkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBZhgDAAAAAEoAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUg" +
           "b3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQbHVuZ2VycFR5cGUuMTpFamVjdFRpcAAuAERmGAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string GoAbs_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggoEAAAAAQAFAAAAR29B" +
           "YnMBAaYbAC8BAaYbphsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFnGAMA" +
           "AAAARQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpQbHVu" +
           "Z2VycFR5cGUuMTpHb0FicwAuAERnGAAAlgEAAAABACoBASQAAAADAAAAUG9zABj/////AAAAAAIOAAAA" +
           "UnVuIHRvIEFicyBwb3MBACgBAQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQFoGAMAAAAARwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRz" +
           "IG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlwZS4xOkdvQWJzAC4ARGgYAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAUAAAAUGx1" +
           "bmdlcnBUeXBlSW5zdGFuY2UBAfUDAQH1A/UDAAD/////EgAAABVgiQoCAAAAAQACAAAASWQBAZ4XAC8A" +
           "P54XAAAABf////8DA/////8AAAAANWCJCgIAAAABAAMAAABBY2MBAU8YAwAAAAANAAAAYWNjZWxlcmF0" +
           "aW9uIAAvAD9PGAAAAAf/////AwP/////AAAAADVgiQoCAAAAAQADAAAARGVjAQFQGAMAAAAADAAAAGRl" +
           "Y2VsZXJhdGlvbgAvAD9QGAAAAAf/////AwP/////AAAAABVgiQoCAAAAAQAGAAAAVlN0YXJ0AQFRGAAv" +
           "AD9RGAAAAAv/////AwP/////AAAAABVgiQoCAAAAAQAEAAAAVkVuZAEBUhgALwA/UhgAAAAL/////wMD" +
           "/////wAAAAAVYIkKAgAAAAEABAAAAFZNYXgBAVMYAC8AP1MYAAAAC/////8DA/////8AAAAAFWCJCgIA" +
           "AAABAAMAAABQb3MBAVQYAC8AP1QYAAAAB/////8DA/////8AAAAAFWCJCgIAAAABAAwAAABDb21wZW5z" +
           "YXRpb24BAVUYAC8AP1UYAAAAB/////8DA/////8AAAAABGGCCgQAAAABAAgAAABTZXRTcGVlZAEBnhsA" +
           "LwEBnhueGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVYYAwAAAABIAAAA" +
           "dGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlw" +
           "ZS4xOlNldFNwZWVkAC4ARFYYAACWAwAAAAEAKgEBFQAAAAYAAABWc3RhcnQAGP////8AAAAAAAEAKgEB" +
           "EwAAAAQAAABWTWF4ABj/////AAAAAAABACoBARMAAAAEAAAAVkVuZAAY/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAwAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBVxgDAAAAAEoAAAB0" +
           "aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpQbHVuZ2VycFR5" +
           "cGUuMTpTZXRTcGVlZAAuAERXGAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEADQAA" +
           "AFNldFN0YXJ0U3BlZWQBAZ8bAC8BAZ8bnxsAAAEB/////wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQFYGAMAAAAATQAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBt" +
           "ZXRob2QgMTpQbHVuZ2VycFR5cGUuMTpTZXRTdGFydFNwZWVkAC4ARFgYAACWAQAAAAEAKgEBFAAAAAUA" +
           "AABTcGVlZAAY/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBWRgDAAAAAE8AAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3Vt" +
           "ZW50cyBvZiBtZXRob2QgMTpQbHVuZ2VycFR5cGUuMTpTZXRTdGFydFNwZWVkAC4ARFkYAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAIAAAAU2V0U2xvcGUBAaAbAC8BAaAboBsAAAEB////" +
           "/wIAAAA3YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFaGAMAAAAASAAAAHRoZSBkZWZpbml0aW9u" +
           "IG9mIHRoZSBpbnB1dCBhcmd1bWVudCBvZiBtZXRob2QgMTpQbHVuZ2VycFR5cGUuMTpTZXRTbG9wZQAu" +
           "AERaGAAAlgIAAAABACoBAREAAAACAAAATDEAGP////8AAAAAAAEAKgEBEQAAAAIAAABMMgAY/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA3YIkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB" +
           "WxgDAAAAAEoAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0IGFyZ3VtZW50cyBvZiBtZXRob2Qg" +
           "MTpQbHVuZ2VycFR5cGUuMTpTZXRTbG9wZQAuAERbGAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAE" +
           "YYIKBAAAAAEADwAAAFNldENvbXBlbnNhdGlvbgEBoRsALwEBoRuhGwAAAQH/////AgAAADdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAVwYAwAAAABPAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0" +
           "IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlwZS4xOlNldENvbXBlbnNhdGlvbgAuAERcGAAA" +
           "lgEAAAABACoBAS8AAAAMAAAAQ29tcGVuc2F0aW9uABj/////AAAAAAIQAAAAQ29tcGVuc2F0aW9uIFNl" +
           "dAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAV0Y" +
           "AwAAAABRAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6" +
           "UGx1bmdlcnBUeXBlLjE6U2V0Q29tcGVuc2F0aW9uAC4ARF0YAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABVgiQoCAAAAAQAGAAAAU3RhdHVzAQFeGAAvAD9eGAAAAAX/////AwP/////AAAAAARhggoEAAAA" +
           "AQAMAAAAUmVsYXRpdmVQdW1wAQGiGwAvAQGiG6IbAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBXxgDAAAAAEwAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQg" +
           "b2YgbWV0aG9kIDE6UGx1bmdlcnBUeXBlLjE6UmVsYXRpdmVQdW1wAC4ARF8YAACWAQAAAAEAKgEBIgAA" +
           "AAUAAABTdGVwcwAY/////wAAAAACCgAAAFB1bXAgU3RlcHMBACgBAQAAAAEAAAABAAAAAQH/////AAAA" +
           "ADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFgGAMAAAAATgAAAHRoZSBkZWZpbml0aW9uIG9m" +
           "IHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlwZS4xOlJlbGF0aXZlUHVt" +
           "cAAuAERgGAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEQAAAFJlbGF0aXZlRGlz" +
           "Y2hhcmdlAQGjGwAvAQGjG6MbAAABAf////8CAAAAN2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "YRgDAAAAAFEAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1lbnQgb2YgbWV0aG9kIDE6" +
           "UGx1bmdlcnBUeXBlLjE6UmVsYXRpdmVEaXNjaGFyZ2UALgBEYRgAAJYBAAAAAQAqAQEUAAAABQAAAFN0" +
           "ZXBzABj/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQFiGAMAAAAAUwAAAHRoZSBkZWZpbml0aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRz" +
           "IG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlwZS4xOlJlbGF0aXZlRGlzY2hhcmdlAC4ARGIYAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAKAAAAQ2hlY2tFcnJvcgEBpBsALwEBpBukGwAAAQH/" +
           "////AgAAADdgiQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWMYAwAAAABKAAAAdGhlIGRlZmluaXRp" +
           "b24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlBsdW5nZXJwVHlwZS4xOkNoZWNrRXJy" +
           "b3IALgBEYxgAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAN2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAWQYAwAAAABMAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2Yg" +
           "bWV0aG9kIDE6UGx1bmdlcnBUeXBlLjE6Q2hlY2tFcnJvcgAuAERkGAAAlgEAAAABACoBASUAAAAJAAAA" +
           "RXJyb3JDb2RlAAX/////AAAAAAIJAAAARXJyb3JDb2RlAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAE" +
           "YYIKBAAAAAEACAAAAEVqZWN0VGlwAQGlGwAvAQGlG6UbAAABAf////8CAAAAN2CJCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBZRgDAAAAAEgAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgaW5wdXQgYXJndW1l" +
           "bnQgb2YgbWV0aG9kIDE6UGx1bmdlcnBUeXBlLjE6RWplY3RUaXAALgBEZRgAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAWYYAwAAAABKAAAAdGhlIGRl" +
           "ZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMgb2YgbWV0aG9kIDE6UGx1bmdlcnBUeXBlLjE6" +
           "RWplY3RUaXAALgBEZhgAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABAAUAAABHb0Fi" +
           "cwEBphsALwEBphumGwAAAQH/////AgAAADdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWcYAwAA" +
           "AABFAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIGlucHV0IGFyZ3VtZW50IG9mIG1ldGhvZCAxOlBsdW5n" +
           "ZXJwVHlwZS4xOkdvQWJzAC4ARGcYAACWAQAAAAEAKgEBJAAAAAMAAABQb3MAGP////8AAAAAAg4AAABS" +
           "dW4gdG8gQWJzIHBvcwEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAN2CJCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAWgYAwAAAABHAAAAdGhlIGRlZmluaXRpb24gb2YgdGhlIG91dHB1dCBhcmd1bWVudHMg" +
           "b2YgbWV0aG9kIDE6UGx1bmdlcnBUeXBlLjE6R29BYnMALgBEaBgAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> Id
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
        public BaseDataVariableState<uint> Acc
        {
            get
            {
                return m_acc;
            }

            set
            {
                if (!Object.ReferenceEquals(m_acc, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_acc = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Dec
        {
            get
            {
                return m_dec;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dec, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dec = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> VStart
        {
            get
            {
                return m_vStart;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vStart, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vStart = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> VEnd
        {
            get
            {
                return m_vEnd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vEnd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vEnd = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> VMax
        {
            get
            {
                return m_vMax;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vMax, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vMax = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Pos
        {
            get
            {
                return m_pos;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pos, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pos = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> Compensation
        {
            get
            {
                return m_compensation;
            }

            set
            {
                if (!Object.ReferenceEquals(m_compensation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_compensation = value;
            }
        }

        /// <remarks />
        public SetSpeedMethodState SetSpeed
        {
            get
            {
                return m_setSpeedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setSpeedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setSpeedMethod = value;
            }
        }

        /// <remarks />
        public SetStartSpeedMethodState SetStartSpeed
        {
            get
            {
                return m_setStartSpeedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setStartSpeedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setStartSpeedMethod = value;
            }
        }

        /// <remarks />
        public SetSlopeMethodState SetSlope
        {
            get
            {
                return m_setSlopeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setSlopeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setSlopeMethod = value;
            }
        }

        /// <remarks />
        public SetCompensationMethodState SetCompensation
        {
            get
            {
                return m_setCompensationMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setCompensationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setCompensationMethod = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ushort> Status
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

        /// <remarks />
        public RelativePumpMethodState RelativePump
        {
            get
            {
                return m_relativePumpMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_relativePumpMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_relativePumpMethod = value;
            }
        }

        /// <remarks />
        public RelativeDischargeMethodState RelativeDischarge
        {
            get
            {
                return m_relativeDischargeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_relativeDischargeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_relativeDischargeMethod = value;
            }
        }

        /// <remarks />
        public CheckErrorMethodState CheckError
        {
            get
            {
                return m_checkErrorMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_checkErrorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_checkErrorMethod = value;
            }
        }

        /// <remarks />
        public MethodState EjectTip
        {
            get
            {
                return m_ejectTipMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ejectTipMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ejectTipMethod = value;
            }
        }

        /// <remarks />
        public GoAbsMethodState GoAbs
        {
            get
            {
                return m_goAbsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_goAbsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goAbsMethod = value;
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

            if (m_acc != null)
            {
                children.Add(m_acc);
            }

            if (m_dec != null)
            {
                children.Add(m_dec);
            }

            if (m_vStart != null)
            {
                children.Add(m_vStart);
            }

            if (m_vEnd != null)
            {
                children.Add(m_vEnd);
            }

            if (m_vMax != null)
            {
                children.Add(m_vMax);
            }

            if (m_pos != null)
            {
                children.Add(m_pos);
            }

            if (m_compensation != null)
            {
                children.Add(m_compensation);
            }

            if (m_setSpeedMethod != null)
            {
                children.Add(m_setSpeedMethod);
            }

            if (m_setStartSpeedMethod != null)
            {
                children.Add(m_setStartSpeedMethod);
            }

            if (m_setSlopeMethod != null)
            {
                children.Add(m_setSlopeMethod);
            }

            if (m_setCompensationMethod != null)
            {
                children.Add(m_setCompensationMethod);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            if (m_relativePumpMethod != null)
            {
                children.Add(m_relativePumpMethod);
            }

            if (m_relativeDischargeMethod != null)
            {
                children.Add(m_relativeDischargeMethod);
            }

            if (m_checkErrorMethod != null)
            {
                children.Add(m_checkErrorMethod);
            }

            if (m_ejectTipMethod != null)
            {
                children.Add(m_ejectTipMethod);
            }

            if (m_goAbsMethod != null)
            {
                children.Add(m_goAbsMethod);
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
                case UAModel.gh.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case UAModel.gh.BrowseNames.Acc:
                {
                    if (createOrReplace)
                    {
                        if (Acc == null)
                        {
                            if (replacement == null)
                            {
                                Acc = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Acc = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Acc;
                    break;
                }

                case UAModel.gh.BrowseNames.Dec:
                {
                    if (createOrReplace)
                    {
                        if (Dec == null)
                        {
                            if (replacement == null)
                            {
                                Dec = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Dec = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Dec;
                    break;
                }

                case UAModel.gh.BrowseNames.VStart:
                {
                    if (createOrReplace)
                    {
                        if (VStart == null)
                        {
                            if (replacement == null)
                            {
                                VStart = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                VStart = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = VStart;
                    break;
                }

                case UAModel.gh.BrowseNames.VEnd:
                {
                    if (createOrReplace)
                    {
                        if (VEnd == null)
                        {
                            if (replacement == null)
                            {
                                VEnd = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                VEnd = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = VEnd;
                    break;
                }

                case UAModel.gh.BrowseNames.VMax:
                {
                    if (createOrReplace)
                    {
                        if (VMax == null)
                        {
                            if (replacement == null)
                            {
                                VMax = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                VMax = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = VMax;
                    break;
                }

                case UAModel.gh.BrowseNames.Pos:
                {
                    if (createOrReplace)
                    {
                        if (Pos == null)
                        {
                            if (replacement == null)
                            {
                                Pos = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Pos = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Pos;
                    break;
                }

                case UAModel.gh.BrowseNames.Compensation:
                {
                    if (createOrReplace)
                    {
                        if (Compensation == null)
                        {
                            if (replacement == null)
                            {
                                Compensation = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                Compensation = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = Compensation;
                    break;
                }

                case UAModel.gh.BrowseNames.SetSpeed:
                {
                    if (createOrReplace)
                    {
                        if (SetSpeed == null)
                        {
                            if (replacement == null)
                            {
                                SetSpeed = new SetSpeedMethodState(this);
                            }
                            else
                            {
                                SetSpeed = (SetSpeedMethodState)replacement;
                            }
                        }
                    }

                    instance = SetSpeed;
                    break;
                }

                case UAModel.gh.BrowseNames.SetStartSpeed:
                {
                    if (createOrReplace)
                    {
                        if (SetStartSpeed == null)
                        {
                            if (replacement == null)
                            {
                                SetStartSpeed = new SetStartSpeedMethodState(this);
                            }
                            else
                            {
                                SetStartSpeed = (SetStartSpeedMethodState)replacement;
                            }
                        }
                    }

                    instance = SetStartSpeed;
                    break;
                }

                case UAModel.gh.BrowseNames.SetSlope:
                {
                    if (createOrReplace)
                    {
                        if (SetSlope == null)
                        {
                            if (replacement == null)
                            {
                                SetSlope = new SetSlopeMethodState(this);
                            }
                            else
                            {
                                SetSlope = (SetSlopeMethodState)replacement;
                            }
                        }
                    }

                    instance = SetSlope;
                    break;
                }

                case UAModel.gh.BrowseNames.SetCompensation:
                {
                    if (createOrReplace)
                    {
                        if (SetCompensation == null)
                        {
                            if (replacement == null)
                            {
                                SetCompensation = new SetCompensationMethodState(this);
                            }
                            else
                            {
                                SetCompensation = (SetCompensationMethodState)replacement;
                            }
                        }
                    }

                    instance = SetCompensation;
                    break;
                }

                case UAModel.gh.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }

                case UAModel.gh.BrowseNames.RelativePump:
                {
                    if (createOrReplace)
                    {
                        if (RelativePump == null)
                        {
                            if (replacement == null)
                            {
                                RelativePump = new RelativePumpMethodState(this);
                            }
                            else
                            {
                                RelativePump = (RelativePumpMethodState)replacement;
                            }
                        }
                    }

                    instance = RelativePump;
                    break;
                }

                case UAModel.gh.BrowseNames.RelativeDischarge:
                {
                    if (createOrReplace)
                    {
                        if (RelativeDischarge == null)
                        {
                            if (replacement == null)
                            {
                                RelativeDischarge = new RelativeDischargeMethodState(this);
                            }
                            else
                            {
                                RelativeDischarge = (RelativeDischargeMethodState)replacement;
                            }
                        }
                    }

                    instance = RelativeDischarge;
                    break;
                }

                case UAModel.gh.BrowseNames.CheckError:
                {
                    if (createOrReplace)
                    {
                        if (CheckError == null)
                        {
                            if (replacement == null)
                            {
                                CheckError = new CheckErrorMethodState(this);
                            }
                            else
                            {
                                CheckError = (CheckErrorMethodState)replacement;
                            }
                        }
                    }

                    instance = CheckError;
                    break;
                }

                case UAModel.gh.BrowseNames.EjectTip:
                {
                    if (createOrReplace)
                    {
                        if (EjectTip == null)
                        {
                            if (replacement == null)
                            {
                                EjectTip = new MethodState(this);
                            }
                            else
                            {
                                EjectTip = (MethodState)replacement;
                            }
                        }
                    }

                    instance = EjectTip;
                    break;
                }

                case UAModel.gh.BrowseNames.GoAbs:
                {
                    if (createOrReplace)
                    {
                        if (GoAbs == null)
                        {
                            if (replacement == null)
                            {
                                GoAbs = new GoAbsMethodState(this);
                            }
                            else
                            {
                                GoAbs = (GoAbsMethodState)replacement;
                            }
                        }
                    }

                    instance = GoAbs;
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
        private BaseDataVariableState<uint> m_acc;
        private BaseDataVariableState<uint> m_dec;
        private BaseDataVariableState<double> m_vStart;
        private BaseDataVariableState<double> m_vEnd;
        private BaseDataVariableState<double> m_vMax;
        private BaseDataVariableState<uint> m_pos;
        private BaseDataVariableState<uint> m_compensation;
        private SetSpeedMethodState m_setSpeedMethod;
        private SetStartSpeedMethodState m_setStartSpeedMethod;
        private SetSlopeMethodState m_setSlopeMethod;
        private SetCompensationMethodState m_setCompensationMethod;
        private BaseDataVariableState<ushort> m_status;
        private RelativePumpMethodState m_relativePumpMethod;
        private RelativeDischargeMethodState m_relativeDischargeMethod;
        private CheckErrorMethodState m_checkErrorMethod;
        private MethodState m_ejectTipMethod;
        private GoAbsMethodState m_goAbsMethod;
        #endregion
    }
    #endif
    #endregion

    #region SetIOMethodState Class
    #if (!OPCUA_EXCLUDE_SetIOMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetIOMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetIOMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetIOMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAPAAAAU2V0" +
           "SU9NZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetIOMethodStateMethodCallHandler OnCall;
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
            bool set = (bool)_inputArguments[1];

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
    public delegate ServiceResult SetIOMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint index,
        bool set);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAQAAAAUmVh" +
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

            uint getValue = (uint)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    index,
                    ref getValue);
            }

            _outputArguments[0] = getValue;

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
        ref uint getValue);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQANAAAASm9n" +
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

            uint index = (uint)_inputArguments[0];
            uint dir = (uint)_inputArguments[1];
            uint speed = (uint)_inputArguments[2];
            uint distance = (uint)_inputArguments[3];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    index,
                    dir,
                    speed,
                    distance);
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
        uint index,
        uint dir,
        uint speed,
        uint distance);
    #endif
    #endregion

    #region GotoMethodState Class
    #if (!OPCUA_EXCLUDE_GotoMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GotoMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GotoMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GotoMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAOAAAAR290" +
           "b01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GotoMethodStateMethodCallHandler OnCall;
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

            uint axis = (uint)_inputArguments[0];
            uint speed = (uint)_inputArguments[1];
            uint target = (uint)_inputArguments[2];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    axis,
                    speed,
                    target);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GotoMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint axis,
        uint speed,
        uint target);
    #endif
    #endregion

    #region RunScriptMethodState Class
    #if (!OPCUA_EXCLUDE_RunScriptMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RunScriptMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RunScriptMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RunScriptMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQATAAAAUnVu" +
           "U2NyaXB0TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RunScriptMethodStateMethodCallHandler OnCall;
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

            string path = (string)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    path);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RunScriptMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string path);
    #endif
    #endregion

    #region SetModeMethodState Class
    #if (!OPCUA_EXCLUDE_SetModeMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetModeMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetModeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetModeMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQARAAAAU2V0" +
           "TW9kZU1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetModeMethodStateMethodCallHandler OnCall;
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

            uint mode = (uint)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    mode);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetModeMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint mode);
    #endif
    #endregion

    #region GotoAbsMethodState Class
    #if (!OPCUA_EXCLUDE_GotoAbsMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GotoAbsMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GotoAbsMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GotoAbsMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQARAAAAR290" +
           "b0Fic01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GotoAbsMethodStateMethodCallHandler OnCall;
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

            uint abs = (uint)_inputArguments[0];
            uint speed = (uint)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    abs,
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
    public delegate ServiceResult GotoAbsMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint abs,
        uint speed);
    #endif
    #endregion

    #region SetSpeedMethodState Class
    #if (!OPCUA_EXCLUDE_SetSpeedMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetSpeedMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetSpeedMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetSpeedMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQASAAAAU2V0" +
           "U3BlZWRNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetSpeedMethodStateMethodCallHandler OnCall;
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

            double startSpeed = (double)_inputArguments[0];
            double maxSpeed = (double)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    startSpeed,
                    maxSpeed);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetSpeedMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double startSpeed,
        double maxSpeed);
    #endif
    #endregion

    #region GetCurDistanceMethodState Class
    #if (!OPCUA_EXCLUDE_GetCurDistanceMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GetCurDistanceMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GetCurDistanceMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GetCurDistanceMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAYAAAAR2V0" +
           "Q3VyRGlzdGFuY2VNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GetCurDistanceMethodStateMethodCallHandler OnCall;
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

            double curValue = (double)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref curValue);
            }

            _outputArguments[0] = curValue;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GetCurDistanceMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref double curValue);
    #endif
    #endregion

    #region SetExposureMethodState Class
    #if (!OPCUA_EXCLUDE_SetExposureMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetExposureMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetExposureMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetExposureMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAVAAAAU2V0" +
           "RXhwb3N1cmVNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetExposureMethodStateMethodCallHandler OnCall;
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

            double exposure = (double)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    exposure);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetExposureMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double exposure);
    #endif
    #endregion

    #region StartMethodState Class
    #if (!OPCUA_EXCLUDE_StartMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public StartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new StartMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAPAAAAU3Rh" +
           "cnRNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public StartMethodStateMethodCallHandler OnCall;
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

            int moduleType = (int)_inputArguments[0];
            int oscillateTime = (int)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    moduleType,
                    oscillateTime);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult StartMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        int moduleType,
        int oscillateTime);
    #endif
    #endregion

    #region CtrlLidMethodState Class
    #if (!OPCUA_EXCLUDE_CtrlLidMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CtrlLidMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public CtrlLidMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new CtrlLidMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQARAAAAQ3Ry" +
           "bExpZE1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public CtrlLidMethodStateMethodCallHandler OnCall;
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

            bool lidSet = (bool)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    lidSet);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult CtrlLidMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        bool lidSet);
    #endif
    #endregion

    #region SetStartSpeedMethodState Class
    #if (!OPCUA_EXCLUDE_SetStartSpeedMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetStartSpeedMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetStartSpeedMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetStartSpeedMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAXAAAAU2V0" +
           "U3RhcnRTcGVlZE1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetStartSpeedMethodStateMethodCallHandler OnCall;
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

            object speed = (object)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
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
    public delegate ServiceResult SetStartSpeedMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        object speed);
    #endif
    #endregion

    #region SetSlopeMethodState Class
    #if (!OPCUA_EXCLUDE_SetSlopeMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetSlopeMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetSlopeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetSlopeMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQASAAAAU2V0" +
           "U2xvcGVNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetSlopeMethodStateMethodCallHandler OnCall;
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

            object l1 = (object)_inputArguments[0];
            object l2 = (object)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    l1,
                    l2);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetSlopeMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        object l1,
        object l2);
    #endif
    #endregion

    #region SetCompensationMethodState Class
    #if (!OPCUA_EXCLUDE_SetCompensationMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetCompensationMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetCompensationMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetCompensationMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAZAAAAU2V0" +
           "Q29tcGVuc2F0aW9uTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetCompensationMethodStateMethodCallHandler OnCall;
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

            object compensation = (object)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    compensation);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetCompensationMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        object compensation);
    #endif
    #endregion

    #region RelativePumpMethodState Class
    #if (!OPCUA_EXCLUDE_RelativePumpMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RelativePumpMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RelativePumpMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RelativePumpMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAWAAAAUmVs" +
           "YXRpdmVQdW1wTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RelativePumpMethodStateMethodCallHandler OnCall;
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

            object steps = (object)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    steps);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RelativePumpMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        object steps);
    #endif
    #endregion

    #region RelativeDischargeMethodState Class
    #if (!OPCUA_EXCLUDE_RelativeDischargeMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RelativeDischargeMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public RelativeDischargeMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new RelativeDischargeMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAbAAAAUmVs" +
           "YXRpdmVEaXNjaGFyZ2VNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public RelativeDischargeMethodStateMethodCallHandler OnCall;
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

            object steps = (object)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    steps);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult RelativeDischargeMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        object steps);
    #endif
    #endregion

    #region CheckErrorMethodState Class
    #if (!OPCUA_EXCLUDE_CheckErrorMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CheckErrorMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public CheckErrorMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new CheckErrorMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAUAAAAQ2hl" +
           "Y2tFcnJvck1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public CheckErrorMethodStateMethodCallHandler OnCall;
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

            ushort errorCode = (ushort)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref errorCode);
            }

            _outputArguments[0] = errorCode;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult CheckErrorMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref ushort errorCode);
    #endif
    #endregion

    #region GoAbsMethodState Class
    #if (!OPCUA_EXCLUDE_GoAbsMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GoAbsMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GoAbsMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GoAbsMethodState(parent);
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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRhggAEAAAAAQAPAAAAR29B" +
           "YnNNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GoAbsMethodStateMethodCallHandler OnCall;
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

            object pos = (object)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    pos);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GoAbsMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        object pos);
    #endif
    #endregion
}