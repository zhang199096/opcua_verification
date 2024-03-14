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
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQALAAAATWVj" +
           "aGluZUF4aXMBAYAXAC8AP4AXAAAAB/////8DA/////8AAAAA";

        private const string LocalAxis_InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////xVgiQoCAAAAAQAJAAAATG9j" +
           "YWxBeGlzAQGBFwAvAD+BFwAAAAf/////AwP/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAQAAAAQXhp" +
           "c1R5cGVJbnN0YW5jZQEB6gMBAeoD6gMAAP////8CAAAAFWCJCgIAAAABAAsAAABNZWNoaW5lQXhpcwEB" +
           "gBcALwA/gBcAAAAH/////wMD/////wAAAAAVYIkKAgAAAAEACQAAAExvY2FsQXhpcwEBgRcALwA/gRcA" +
           "AAAH/////wMD/////wAAAAA=";
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
           "MTpDYW1UeXBlLjE6U2V0RXhwb3N1cmUALgBEzhcAAJYBAAAAAQAqAQE4AAAACAAAAEV4cG9zdXJlAAv/" +
           "////AAAAAAMCAAAAY24XAAAAc2V0IGV4cG9zdXJlIGZvciBjYW1lcmEBACgBAQAAAAEAAAABAAAAAQH/" +
           "////AAAAADdgiQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHPFwMAAAAASAAAAHRoZSBkZWZpbml0" +
           "aW9uIG9mIHRoZSBvdXRwdXQgYXJndW1lbnRzIG9mIG1ldGhvZCAxOkNhbVR5cGUuMTpTZXRFeHBvc3Vy" +
           "ZQAuAETPFwAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

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
           "cG9zdXJlAC4ARM4XAACWAQAAAAEAKgEBOAAAAAgAAABFeHBvc3VyZQAL/////wAAAAADAgAAAGNuFwAA" +
           "AHNldCBleHBvc3VyZSBmb3IgY2FtZXJhAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA3YIkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBzxcDAAAAAEgAAAB0aGUgZGVmaW5pdGlvbiBvZiB0aGUgb3V0cHV0" +
           "IGFyZ3VtZW50cyBvZiBtZXRob2QgMTpDYW1UeXBlLjE6U2V0RXhwb3N1cmUALgBEzxcAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAA";
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

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vZ2liNDM5X2FkZGRldmljZS5vcmcvZ2gv/////wRggAIBAAAAAQAPAAAAbXNj" +
           "VHlvZUluc3RhbmNlAQHuAwEB7gPuAwAA/////wUAAAAEYIAKAQAAAAEABgAAAEJhbHNlcgEBkBMAIwEB" +
           "7AOQEwAA/////wAAAAAEYIAKAQAAAAEABgAAAElGMjQ1MQEBkRMAIwEB6wOREwAA/////wAAAAAEYIAK" +
           "AQAAAAEABQAAAFRlY2FuAQGSEwAjAQHtA5ITAAD/////AAAAAARggAoBAAAAAQAMAAAAT3B0aWNhbE1v" +
           "ZGVsAQGJEwAjAQHpA4kTAAD/////AAAAAARggAoBAAAAAQAJAAAARHVhbE1vZGVsAQGPEwAjAQHpA48T" +
           "AAD/////AAAAAA==";
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
}