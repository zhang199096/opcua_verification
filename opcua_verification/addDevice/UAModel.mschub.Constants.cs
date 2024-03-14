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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace UAModel.mschub
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint AdddDevice_Centri_Start = 7003;

        /// <remarks />
        public const uint AdddDevice_Centri_Stop = 7004;

        /// <remarks />
        public const uint AdddDevice_pcr_SetTemp = 7010;

        /// <remarks />
        public const uint AdddDevice_pcr_Start = 7008;

        /// <remarks />
        public const uint AdddDevice_pcr_Stop = 7009;

        /// <remarks />
        public const uint Centri_Start = 7001;

        /// <remarks />
        public const uint Centri_Stop = 7002;

        /// <remarks />
        public const uint PCR_SetTemp = 7007;

        /// <remarks />
        public const uint PCR_Start = 7005;

        /// <remarks />
        public const uint PCR_Stop = 7006;

        /// <remarks />
        public const uint AddDevice_Centri_Start = 7011;

        /// <remarks />
        public const uint AddDevice_Centri_Stop = 7012;

        /// <remarks />
        public const uint AddDevice_pcr_SetTemp = 7013;

        /// <remarks />
        public const uint AddDevice_pcr_Start = 7014;

        /// <remarks />
        public const uint AddDevice_pcr_Stop = 7015;

        /// <remarks />
        public const string PCR_SetTempMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint AdddDevice_Centri = 5002;

        /// <remarks />
        public const uint AdddDevice_pcr = 5001;

        /// <remarks />
        public const uint AddDevice = 5004;

        /// <remarks />
        public const uint AddDevice_Centri = 5003;

        /// <remarks />
        public const uint AddDevice_pcr = 5006;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub_ = 5005;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint AdddDevice = 1004;

        /// <remarks />
        public const uint Centri = 1003;

        /// <remarks />
        public const uint PCR = 1002;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint AdddDevice_Centri_id = 6010;

        /// <remarks />
        public const uint AdddDevice_Centri_Speed = 6011;

        /// <remarks />
        public const uint AdddDevice_pcr_id = 6015;

        /// <remarks />
        public const uint AdddDevice_pcr_SetTemp_InputArguments = 6017;

        /// <remarks />
        public const uint AdddDevice_pcr_Temp = 6016;

        /// <remarks />
        public const uint Centri_id = 6008;

        /// <remarks />
        public const uint Centri_Speed = 6009;

        /// <remarks />
        public const uint PCR_id = 6012;

        /// <remarks />
        public const uint PCR_SetTemp_InputArguments = 6014;

        /// <remarks />
        public const uint PCR_Temp = 6013;

        /// <remarks />
        public const uint AddDevice_Centri_id = 6018;

        /// <remarks />
        public const uint AddDevice_Centri_Speed = 6019;

        /// <remarks />
        public const uint AddDevice_pcr_id = 6020;

        /// <remarks />
        public const uint AddDevice_pcr_SetTemp_InputArguments = 6021;

        /// <remarks />
        public const uint AddDevice_pcr_Temp = 6022;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub__NamespaceUri = 6003;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub__NamespaceVersion = 6004;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub__NamespacePublicationDate = 6002;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub__IsNamespaceSubset = 6001;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub__StaticNodeIdTypes = 6005;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub__StaticNumericNodeIdRange = 6006;

        /// <remarks />
        public const uint http___yourorganisation_org_mschub__StaticStringNodeIdPattern = 6007;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_Centri_Start = new ExpandedNodeId(UAModel.mschub.Methods.AdddDevice_Centri_Start, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_Centri_Stop = new ExpandedNodeId(UAModel.mschub.Methods.AdddDevice_Centri_Stop, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_pcr_SetTemp = new ExpandedNodeId(UAModel.mschub.Methods.AdddDevice_pcr_SetTemp, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_pcr_Start = new ExpandedNodeId(UAModel.mschub.Methods.AdddDevice_pcr_Start, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_pcr_Stop = new ExpandedNodeId(UAModel.mschub.Methods.AdddDevice_pcr_Stop, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId Centri_Start = new ExpandedNodeId(UAModel.mschub.Methods.Centri_Start, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId Centri_Stop = new ExpandedNodeId(UAModel.mschub.Methods.Centri_Stop, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR_SetTemp = new ExpandedNodeId(UAModel.mschub.Methods.PCR_SetTemp, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR_Start = new ExpandedNodeId(UAModel.mschub.Methods.PCR_Start, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR_Stop = new ExpandedNodeId(UAModel.mschub.Methods.PCR_Stop, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_Centri_Start = new ExpandedNodeId(UAModel.mschub.Methods.AddDevice_Centri_Start, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_Centri_Stop = new ExpandedNodeId(UAModel.mschub.Methods.AddDevice_Centri_Stop, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_pcr_SetTemp = new ExpandedNodeId(UAModel.mschub.Methods.AddDevice_pcr_SetTemp, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_pcr_Start = new ExpandedNodeId(UAModel.mschub.Methods.AddDevice_pcr_Start, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_pcr_Stop = new ExpandedNodeId(UAModel.mschub.Methods.AddDevice_pcr_Stop, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR_SetTempMethodType = new ExpandedNodeId(UAModel.mschub.Methods.PCR_SetTempMethodType, UAModel.mschub.Namespaces.mschub);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_Centri = new ExpandedNodeId(UAModel.mschub.Objects.AdddDevice_Centri, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_pcr = new ExpandedNodeId(UAModel.mschub.Objects.AdddDevice_pcr, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice = new ExpandedNodeId(UAModel.mschub.Objects.AddDevice, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_Centri = new ExpandedNodeId(UAModel.mschub.Objects.AddDevice_Centri, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_pcr = new ExpandedNodeId(UAModel.mschub.Objects.AddDevice_pcr, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub_ = new ExpandedNodeId(UAModel.mschub.Objects.http___yourorganisation_org_mschub_, UAModel.mschub.Namespaces.mschub);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice = new ExpandedNodeId(UAModel.mschub.ObjectTypes.AdddDevice, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId Centri = new ExpandedNodeId(UAModel.mschub.ObjectTypes.Centri, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR = new ExpandedNodeId(UAModel.mschub.ObjectTypes.PCR, UAModel.mschub.Namespaces.mschub);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_Centri_id = new ExpandedNodeId(UAModel.mschub.Variables.AdddDevice_Centri_id, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_Centri_Speed = new ExpandedNodeId(UAModel.mschub.Variables.AdddDevice_Centri_Speed, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_pcr_id = new ExpandedNodeId(UAModel.mschub.Variables.AdddDevice_pcr_id, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_pcr_SetTemp_InputArguments = new ExpandedNodeId(UAModel.mschub.Variables.AdddDevice_pcr_SetTemp_InputArguments, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AdddDevice_pcr_Temp = new ExpandedNodeId(UAModel.mschub.Variables.AdddDevice_pcr_Temp, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId Centri_id = new ExpandedNodeId(UAModel.mschub.Variables.Centri_id, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId Centri_Speed = new ExpandedNodeId(UAModel.mschub.Variables.Centri_Speed, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR_id = new ExpandedNodeId(UAModel.mschub.Variables.PCR_id, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR_SetTemp_InputArguments = new ExpandedNodeId(UAModel.mschub.Variables.PCR_SetTemp_InputArguments, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId PCR_Temp = new ExpandedNodeId(UAModel.mschub.Variables.PCR_Temp, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_Centri_id = new ExpandedNodeId(UAModel.mschub.Variables.AddDevice_Centri_id, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_Centri_Speed = new ExpandedNodeId(UAModel.mschub.Variables.AddDevice_Centri_Speed, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_pcr_id = new ExpandedNodeId(UAModel.mschub.Variables.AddDevice_pcr_id, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_pcr_SetTemp_InputArguments = new ExpandedNodeId(UAModel.mschub.Variables.AddDevice_pcr_SetTemp_InputArguments, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId AddDevice_pcr_Temp = new ExpandedNodeId(UAModel.mschub.Variables.AddDevice_pcr_Temp, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub__NamespaceUri = new ExpandedNodeId(UAModel.mschub.Variables.http___yourorganisation_org_mschub__NamespaceUri, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub__NamespaceVersion = new ExpandedNodeId(UAModel.mschub.Variables.http___yourorganisation_org_mschub__NamespaceVersion, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub__NamespacePublicationDate = new ExpandedNodeId(UAModel.mschub.Variables.http___yourorganisation_org_mschub__NamespacePublicationDate, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub__IsNamespaceSubset = new ExpandedNodeId(UAModel.mschub.Variables.http___yourorganisation_org_mschub__IsNamespaceSubset, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub__StaticNodeIdTypes = new ExpandedNodeId(UAModel.mschub.Variables.http___yourorganisation_org_mschub__StaticNodeIdTypes, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub__StaticNumericNodeIdRange = new ExpandedNodeId(UAModel.mschub.Variables.http___yourorganisation_org_mschub__StaticNumericNodeIdRange, UAModel.mschub.Namespaces.mschub);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_mschub__StaticStringNodeIdPattern = new ExpandedNodeId(UAModel.mschub.Variables.http___yourorganisation_org_mschub__StaticStringNodeIdPattern, UAModel.mschub.Namespaces.mschub);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AdddDevice = "AdddDevice";

        /// <remarks />
        public const string AddDevice = "AddDevice";

        /// <remarks />
        public const string Centri = "Centri";

        /// <remarks />
        public const string http___yourorganisation_org_mschub_ = "http://yourorganisation.org/mschub/";

        /// <remarks />
        public const string id = "id";

        /// <remarks />
        public const string pcr = "pcr";

        /// <remarks />
        public const string PCR = "PCR";

        /// <remarks />
        public const string SetTemp = "SetTemp";

        /// <remarks />
        public const string SetTempMethodType = "SetTempMethodType";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string Start = "Start";

        /// <remarks />
        public const string Stop = "Stop";

        /// <remarks />
        public const string Temp = "Temp";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the mschub namespace (.NET code namespace is 'UAModel.mschub').
        /// </summary>
        public const string mschub = "http://yourorganisation.org/mschub/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}