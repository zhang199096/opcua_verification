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

namespace UAModel.gh
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint IOtype_SetIO = 7000;

        /// <remarks />
        public const uint IOtype_ReadIO = 7001;

        /// <remarks />
        public const uint RunModelType_Jog = 7002;

        /// <remarks />
        public const uint RunModelType_SetZero = 7003;

        /// <remarks />
        public const uint RunModelType_Reset = 7004;

        /// <remarks />
        public const uint RunModelType_Goto = 7005;

        /// <remarks />
        public const uint RunModelType_RunScript = 7006;

        /// <remarks />
        public const uint MeanDistance_StartCapture = 7009;

        /// <remarks />
        public const uint MeanDistance_StopCapture = 7029;

        /// <remarks />
        public const uint MeanDistance_GetCurDistance = 7030;

        /// <remarks />
        public const uint CamType_StartCapture = 7007;

        /// <remarks />
        public const uint CamType_SetMode = 7008;

        /// <remarks />
        public const uint CamType_StopCapture = 7031;

        /// <remarks />
        public const uint CamType_SetExposure = 7032;

        /// <remarks />
        public const uint PumpType_GotoAbs = 7010;

        /// <remarks />
        public const uint PumpType_SetSpeed = 7023;

        /// <remarks />
        public const string IOtype_SetIOMethodType = "";

        /// <remarks />
        public const string IOtype_ReadIOMethodType = "";

        /// <remarks />
        public const string RunModelType_JogMethodType = "";

        /// <remarks />
        public const string RunModelType_GotoMethodType = "";

        /// <remarks />
        public const string RunModelType_RunScriptMethodType = "";

        /// <remarks />
        public const string CamType_SetModeMethodType = "";

        /// <remarks />
        public const string PumpType_GotoAbsMethodType = "";

        /// <remarks />
        public const string PumpType_SetSpeedMethodType = "";

        /// <remarks />
        public const string MeanDistance_GetCurDistanceMethodType = "";

        /// <remarks />
        public const string CamType_SetExposureMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint http___gibh_addDev_com = 5000;

        /// <remarks />
        public const uint RunModelType_XUint = 5002;

        /// <remarks />
        public const uint RunModelType_Yuint = 5003;

        /// <remarks />
        public const uint RunModelType_ZUint = 5004;

        /// <remarks />
        public const uint RunModelType_AUint = 5005;

        /// <remarks />
        public const uint RunModelType_IOUint = 5006;

        /// <remarks />
        public const uint mscTyoe_Balser = 5008;

        /// <remarks />
        public const uint mscTyoe_IF2451 = 5009;

        /// <remarks />
        public const uint mscTyoe_Tecan = 5010;

        /// <remarks />
        public const uint mscTyoe_OpticalModel = 5001;

        /// <remarks />
        public const uint mscTyoe_DualModel = 5007;

        /// <remarks />
        public const uint Athena = 5027;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint IOtype = 1000;

        /// <remarks />
        public const uint RunModelType = 1001;

        /// <remarks />
        public const uint AxisType = 1002;

        /// <remarks />
        public const uint MeanDistance = 1003;

        /// <remarks />
        public const uint CamType = 1004;

        /// <remarks />
        public const uint PumpType = 1005;

        /// <remarks />
        public const uint mscTyoe = 1006;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint http___gibh_addDev_com_NamespaceUri = 6002;

        /// <remarks />
        public const uint http___gibh_addDev_com_NamespaceVersion = 6003;

        /// <remarks />
        public const uint http___gibh_addDev_com_NamespacePublicationDate = 6001;

        /// <remarks />
        public const uint http___gibh_addDev_com_IsNamespaceSubset = 6000;

        /// <remarks />
        public const uint http___gibh_addDev_com_StaticNodeIdTypes = 6004;

        /// <remarks />
        public const uint http___gibh_addDev_com_StaticNumericNodeIdRange = 6005;

        /// <remarks />
        public const uint http___gibh_addDev_com_StaticStringNodeIdPattern = 6006;

        /// <remarks />
        public const uint IOtype_SetIO_InputArguments = 6009;

        /// <remarks />
        public const uint IOtype_SetIO_OutputArguments = 6010;

        /// <remarks />
        public const uint IOtype_SetIO_Set = 6011;

        /// <remarks />
        public const uint IOtype_ReadIO_InputArguments = 6012;

        /// <remarks />
        public const uint IOtype_ReadIO_OutputArguments = 6013;

        /// <remarks />
        public const uint IOtype_ReadIO_index = 6014;

        /// <remarks />
        public const uint IOtype_Input1States = 6008;

        /// <remarks />
        public const uint IOtype_Input2States = 6015;

        /// <remarks />
        public const uint RunModelType_Jog_InputArguments = 6018;

        /// <remarks />
        public const uint RunModelType_Jog_OutputArguments = 6019;

        /// <remarks />
        public const uint RunModelType_SetZero_InputArguments = 6020;

        /// <remarks />
        public const uint RunModelType_SetZero_OutputArguments = 6021;

        /// <remarks />
        public const uint RunModelType_Reset_InputArguments = 6022;

        /// <remarks />
        public const uint RunModelType_Reset_OutputArguments = 6023;

        /// <remarks />
        public const uint RunModelType_Goto_InputArguments = 6024;

        /// <remarks />
        public const uint RunModelType_Goto_OutputArguments = 6025;

        /// <remarks />
        public const uint RunModelType_RunScript_InputArguments = 6026;

        /// <remarks />
        public const uint RunModelType_RunScript_OutputArguments = 6027;

        /// <remarks />
        public const uint RunModelType_IOUint_SetIO_InputArguments = 6009;

        /// <remarks />
        public const uint RunModelType_IOUint_SetIO_OutputArguments = 6010;

        /// <remarks />
        public const uint RunModelType_IOUint_ReadIO_InputArguments = 6012;

        /// <remarks />
        public const uint RunModelType_IOUint_ReadIO_OutputArguments = 6013;

        /// <remarks />
        public const uint AxisType_MechineAxis = 6016;

        /// <remarks />
        public const uint AxisType_LocalAxis = 6017;

        /// <remarks />
        public const uint MeanDistance_Name = 6033;

        /// <remarks />
        public const uint MeanDistance_StartCapture_InputArguments = 6034;

        /// <remarks />
        public const uint MeanDistance_StartCapture_OutputArguments = 6035;

        /// <remarks />
        public const uint MeanDistance_StopCapture_InputArguments = 6086;

        /// <remarks />
        public const uint MeanDistance_StopCapture_OutputArguments = 6087;

        /// <remarks />
        public const uint MeanDistance_GetCurDistance_InputArguments = 6088;

        /// <remarks />
        public const uint MeanDistance_GetCurDistance_OutputArguments = 6089;

        /// <remarks />
        public const uint CamType_Name = 6028;

        /// <remarks />
        public const uint CamType_StartCapture_InputArguments = 6029;

        /// <remarks />
        public const uint CamType_StartCapture_OutputArguments = 6030;

        /// <remarks />
        public const uint CamType_SetMode_InputArguments = 6031;

        /// <remarks />
        public const uint CamType_SetMode_OutputArguments = 6032;

        /// <remarks />
        public const uint CamType_Mode = 6090;

        /// <remarks />
        public const uint CamType_exposure = 6091;

        /// <remarks />
        public const uint CamType_StopCapture_InputArguments = 6092;

        /// <remarks />
        public const uint CamType_StopCapture_OutputArguments = 6093;

        /// <remarks />
        public const uint CamType_SetExposure_InputArguments = 6094;

        /// <remarks />
        public const uint CamType_SetExposure_OutputArguments = 6095;

        /// <remarks />
        public const uint PumpType_Abs = 6036;

        /// <remarks />
        public const uint PumpType_GotoAbs_InputArguments = 6037;

        /// <remarks />
        public const uint PumpType_GotoAbs_OutputArguments = 6038;

        /// <remarks />
        public const uint PumpType_SetSpeed_InputArguments = 6071;

        /// <remarks />
        public const uint PumpType_SetSpeed_OutputArguments = 6072;

        /// <remarks />
        public const uint mscTyoe_Balser_StartCapture_InputArguments = 6029;

        /// <remarks />
        public const uint mscTyoe_Balser_StartCapture_OutputArguments = 6030;

        /// <remarks />
        public const uint mscTyoe_Balser_SetMode_InputArguments = 6031;

        /// <remarks />
        public const uint mscTyoe_Balser_SetMode_OutputArguments = 6032;

        /// <remarks />
        public const uint mscTyoe_Balser_StopCapture_InputArguments = 6092;

        /// <remarks />
        public const uint mscTyoe_Balser_StopCapture_OutputArguments = 6093;

        /// <remarks />
        public const uint mscTyoe_Balser_SetExposure_InputArguments = 6094;

        /// <remarks />
        public const uint mscTyoe_Balser_SetExposure_OutputArguments = 6095;

        /// <remarks />
        public const uint mscTyoe_IF2451_StartCapture_InputArguments = 6034;

        /// <remarks />
        public const uint mscTyoe_IF2451_StartCapture_OutputArguments = 6035;

        /// <remarks />
        public const uint mscTyoe_IF2451_StopCapture_InputArguments = 6086;

        /// <remarks />
        public const uint mscTyoe_IF2451_StopCapture_OutputArguments = 6087;

        /// <remarks />
        public const uint mscTyoe_IF2451_GetCurDistance_InputArguments = 6088;

        /// <remarks />
        public const uint mscTyoe_IF2451_GetCurDistance_OutputArguments = 6089;

        /// <remarks />
        public const uint mscTyoe_Tecan_GotoAbs_InputArguments = 6037;

        /// <remarks />
        public const uint mscTyoe_Tecan_GotoAbs_OutputArguments = 6038;

        /// <remarks />
        public const uint mscTyoe_Tecan_SetSpeed_InputArguments = 6071;

        /// <remarks />
        public const uint mscTyoe_Tecan_SetSpeed_OutputArguments = 6072;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_Jog_InputArguments = 6018;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_Jog_OutputArguments = 6019;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_SetZero_InputArguments = 6020;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_SetZero_OutputArguments = 6021;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_Reset_InputArguments = 6022;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_Reset_OutputArguments = 6023;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_Goto_InputArguments = 6024;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_Goto_OutputArguments = 6025;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_RunScript_InputArguments = 6026;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_RunScript_OutputArguments = 6027;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_IOUint_SetIO_InputArguments = 6009;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_IOUint_SetIO_OutputArguments = 6010;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_IOUint_ReadIO_InputArguments = 6012;

        /// <remarks />
        public const uint mscTyoe_OpticalModel_IOUint_ReadIO_OutputArguments = 6013;

        /// <remarks />
        public const uint mscTyoe_DualModel_Jog_InputArguments = 6018;

        /// <remarks />
        public const uint mscTyoe_DualModel_Jog_OutputArguments = 6019;

        /// <remarks />
        public const uint mscTyoe_DualModel_SetZero_InputArguments = 6020;

        /// <remarks />
        public const uint mscTyoe_DualModel_SetZero_OutputArguments = 6021;

        /// <remarks />
        public const uint mscTyoe_DualModel_Reset_InputArguments = 6022;

        /// <remarks />
        public const uint mscTyoe_DualModel_Reset_OutputArguments = 6023;

        /// <remarks />
        public const uint mscTyoe_DualModel_Goto_InputArguments = 6024;

        /// <remarks />
        public const uint mscTyoe_DualModel_Goto_OutputArguments = 6025;

        /// <remarks />
        public const uint mscTyoe_DualModel_RunScript_InputArguments = 6026;

        /// <remarks />
        public const uint mscTyoe_DualModel_RunScript_OutputArguments = 6027;

        /// <remarks />
        public const uint mscTyoe_DualModel_IOUint_SetIO_InputArguments = 6009;

        /// <remarks />
        public const uint mscTyoe_DualModel_IOUint_SetIO_OutputArguments = 6010;

        /// <remarks />
        public const uint mscTyoe_DualModel_IOUint_ReadIO_InputArguments = 6012;

        /// <remarks />
        public const uint mscTyoe_DualModel_IOUint_ReadIO_OutputArguments = 6013;

        /// <remarks />
        public const uint Athena_Balser_StartCapture_InputArguments = 6139;

        /// <remarks />
        public const uint Athena_Balser_StartCapture_OutputArguments = 6140;

        /// <remarks />
        public const uint Athena_Balser_SetMode_InputArguments = 6133;

        /// <remarks />
        public const uint Athena_Balser_SetMode_OutputArguments = 6134;

        /// <remarks />
        public const uint Athena_Balser_StopCapture_InputArguments = 6137;

        /// <remarks />
        public const uint Athena_Balser_StopCapture_OutputArguments = 6138;

        /// <remarks />
        public const uint Athena_Balser_SetExposure_InputArguments = 6135;

        /// <remarks />
        public const uint Athena_Balser_SetExposure_OutputArguments = 6136;

        /// <remarks />
        public const uint Athena_IF2451_StartCapture_InputArguments = 6154;

        /// <remarks />
        public const uint Athena_IF2451_StartCapture_OutputArguments = 6155;

        /// <remarks />
        public const uint Athena_IF2451_StopCapture_InputArguments = 6156;

        /// <remarks />
        public const uint Athena_IF2451_StopCapture_OutputArguments = 6157;

        /// <remarks />
        public const uint Athena_IF2451_GetCurDistance_InputArguments = 6152;

        /// <remarks />
        public const uint Athena_IF2451_GetCurDistance_OutputArguments = 6153;

        /// <remarks />
        public const uint Athena_Tecan_GotoAbs_InputArguments = 6169;

        /// <remarks />
        public const uint Athena_Tecan_GotoAbs_OutputArguments = 6170;

        /// <remarks />
        public const uint Athena_Tecan_SetSpeed_InputArguments = 6171;

        /// <remarks />
        public const uint Athena_Tecan_SetSpeed_OutputArguments = 6172;

        /// <remarks />
        public const uint Athena_OpticalModel_Jog_InputArguments = 6160;

        /// <remarks />
        public const uint Athena_OpticalModel_Jog_OutputArguments = 6161;

        /// <remarks />
        public const uint Athena_OpticalModel_SetZero_InputArguments = 6164;

        /// <remarks />
        public const uint Athena_OpticalModel_SetZero_OutputArguments = 6165;

        /// <remarks />
        public const uint Athena_OpticalModel_Reset_InputArguments = 6162;

        /// <remarks />
        public const uint Athena_OpticalModel_Reset_OutputArguments = 6163;

        /// <remarks />
        public const uint Athena_OpticalModel_Goto_InputArguments = 6158;

        /// <remarks />
        public const uint Athena_OpticalModel_Goto_OutputArguments = 6159;

        /// <remarks />
        public const uint Athena_OpticalModel_RunScript_InputArguments = 6166;

        /// <remarks />
        public const uint Athena_OpticalModel_RunScript_OutputArguments = 6167;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_SetIO_InputArguments = 6191;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_SetIO_OutputArguments = 6192;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_ReadIO_InputArguments = 6189;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_ReadIO_OutputArguments = 6190;

        /// <remarks />
        public const uint Athena_DualModel_Jog_InputArguments = 6143;

        /// <remarks />
        public const uint Athena_DualModel_Jog_OutputArguments = 6144;

        /// <remarks />
        public const uint Athena_DualModel_SetZero_InputArguments = 6149;

        /// <remarks />
        public const uint Athena_DualModel_SetZero_OutputArguments = 6150;

        /// <remarks />
        public const uint Athena_DualModel_Reset_InputArguments = 6147;

        /// <remarks />
        public const uint Athena_DualModel_Reset_OutputArguments = 6148;

        /// <remarks />
        public const uint Athena_DualModel_Goto_InputArguments = 6141;

        /// <remarks />
        public const uint Athena_DualModel_Goto_OutputArguments = 6142;

        /// <remarks />
        public const uint Athena_DualModel_RunScript_InputArguments = 6145;

        /// <remarks />
        public const uint Athena_DualModel_RunScript_OutputArguments = 6146;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_SetIO_InputArguments = 6177;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_SetIO_OutputArguments = 6178;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_ReadIO_InputArguments = 6175;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_ReadIO_OutputArguments = 6176;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId IOtype_SetIO = new ExpandedNodeId(UAModel.gh.Methods.IOtype_SetIO, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_ReadIO = new ExpandedNodeId(UAModel.gh.Methods.IOtype_ReadIO, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Jog = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_Jog, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_SetZero = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_SetZero, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Reset = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_Reset, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Goto = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_Goto, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_RunScript = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_RunScript, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_StartCapture = new ExpandedNodeId(UAModel.gh.Methods.MeanDistance_StartCapture, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_StopCapture = new ExpandedNodeId(UAModel.gh.Methods.MeanDistance_StopCapture, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_GetCurDistance = new ExpandedNodeId(UAModel.gh.Methods.MeanDistance_GetCurDistance, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_StartCapture = new ExpandedNodeId(UAModel.gh.Methods.CamType_StartCapture, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetMode = new ExpandedNodeId(UAModel.gh.Methods.CamType_SetMode, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_StopCapture = new ExpandedNodeId(UAModel.gh.Methods.CamType_StopCapture, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetExposure = new ExpandedNodeId(UAModel.gh.Methods.CamType_SetExposure, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_GotoAbs = new ExpandedNodeId(UAModel.gh.Methods.PumpType_GotoAbs, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_SetSpeed = new ExpandedNodeId(UAModel.gh.Methods.PumpType_SetSpeed, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_SetIOMethodType = new ExpandedNodeId(UAModel.gh.Methods.IOtype_SetIOMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_ReadIOMethodType = new ExpandedNodeId(UAModel.gh.Methods.IOtype_ReadIOMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_JogMethodType = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_JogMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_GotoMethodType = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_GotoMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_RunScriptMethodType = new ExpandedNodeId(UAModel.gh.Methods.RunModelType_RunScriptMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetModeMethodType = new ExpandedNodeId(UAModel.gh.Methods.CamType_SetModeMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_GotoAbsMethodType = new ExpandedNodeId(UAModel.gh.Methods.PumpType_GotoAbsMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_SetSpeedMethodType = new ExpandedNodeId(UAModel.gh.Methods.PumpType_SetSpeedMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_GetCurDistanceMethodType = new ExpandedNodeId(UAModel.gh.Methods.MeanDistance_GetCurDistanceMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetExposureMethodType = new ExpandedNodeId(UAModel.gh.Methods.CamType_SetExposureMethodType, UAModel.gh.Namespaces.gh);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com = new ExpandedNodeId(UAModel.gh.Objects.http___gibh_addDev_com, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_XUint = new ExpandedNodeId(UAModel.gh.Objects.RunModelType_XUint, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Yuint = new ExpandedNodeId(UAModel.gh.Objects.RunModelType_Yuint, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_ZUint = new ExpandedNodeId(UAModel.gh.Objects.RunModelType_ZUint, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_AUint = new ExpandedNodeId(UAModel.gh.Objects.RunModelType_AUint, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_IOUint = new ExpandedNodeId(UAModel.gh.Objects.RunModelType_IOUint, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser = new ExpandedNodeId(UAModel.gh.Objects.mscTyoe_Balser, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_IF2451 = new ExpandedNodeId(UAModel.gh.Objects.mscTyoe_IF2451, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Tecan = new ExpandedNodeId(UAModel.gh.Objects.mscTyoe_Tecan, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel = new ExpandedNodeId(UAModel.gh.Objects.mscTyoe_OpticalModel, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel = new ExpandedNodeId(UAModel.gh.Objects.mscTyoe_DualModel, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena = new ExpandedNodeId(UAModel.gh.Objects.Athena, UAModel.gh.Namespaces.gh);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId IOtype = new ExpandedNodeId(UAModel.gh.ObjectTypes.IOtype, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType = new ExpandedNodeId(UAModel.gh.ObjectTypes.RunModelType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId AxisType = new ExpandedNodeId(UAModel.gh.ObjectTypes.AxisType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance = new ExpandedNodeId(UAModel.gh.ObjectTypes.MeanDistance, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType = new ExpandedNodeId(UAModel.gh.ObjectTypes.CamType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType = new ExpandedNodeId(UAModel.gh.ObjectTypes.PumpType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe = new ExpandedNodeId(UAModel.gh.ObjectTypes.mscTyoe, UAModel.gh.Namespaces.gh);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com_NamespaceUri = new ExpandedNodeId(UAModel.gh.Variables.http___gibh_addDev_com_NamespaceUri, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com_NamespaceVersion = new ExpandedNodeId(UAModel.gh.Variables.http___gibh_addDev_com_NamespaceVersion, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com_NamespacePublicationDate = new ExpandedNodeId(UAModel.gh.Variables.http___gibh_addDev_com_NamespacePublicationDate, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com_IsNamespaceSubset = new ExpandedNodeId(UAModel.gh.Variables.http___gibh_addDev_com_IsNamespaceSubset, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com_StaticNodeIdTypes = new ExpandedNodeId(UAModel.gh.Variables.http___gibh_addDev_com_StaticNodeIdTypes, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com_StaticNumericNodeIdRange = new ExpandedNodeId(UAModel.gh.Variables.http___gibh_addDev_com_StaticNumericNodeIdRange, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId http___gibh_addDev_com_StaticStringNodeIdPattern = new ExpandedNodeId(UAModel.gh.Variables.http___gibh_addDev_com_StaticStringNodeIdPattern, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.IOtype_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.IOtype_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_SetIO_Set = new ExpandedNodeId(UAModel.gh.Variables.IOtype_SetIO_Set, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.IOtype_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.IOtype_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_ReadIO_index = new ExpandedNodeId(UAModel.gh.Variables.IOtype_ReadIO_index, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_Input1States = new ExpandedNodeId(UAModel.gh.Variables.IOtype_Input1States, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId IOtype_Input2States = new ExpandedNodeId(UAModel.gh.Variables.IOtype_Input2States, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Jog_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_Jog_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Jog_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_Jog_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_SetZero_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_SetZero_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_SetZero_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_SetZero_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Reset_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_Reset_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Reset_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_Reset_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Goto_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_Goto_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_Goto_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_Goto_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_RunScript_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_RunScript_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_RunScript_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_RunScript_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_IOUint_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_IOUint_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_IOUint_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_IOUint_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_IOUint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_IOUint_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId RunModelType_IOUint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.RunModelType_IOUint_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId AxisType_MechineAxis = new ExpandedNodeId(UAModel.gh.Variables.AxisType_MechineAxis, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId AxisType_LocalAxis = new ExpandedNodeId(UAModel.gh.Variables.AxisType_LocalAxis, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_Name = new ExpandedNodeId(UAModel.gh.Variables.MeanDistance_Name, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.MeanDistance_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.MeanDistance_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.MeanDistance_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.MeanDistance_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_GetCurDistance_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.MeanDistance_GetCurDistance_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId MeanDistance_GetCurDistance_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.MeanDistance_GetCurDistance_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_Name = new ExpandedNodeId(UAModel.gh.Variables.CamType_Name, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetMode_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_SetMode_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetMode_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_SetMode_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_Mode = new ExpandedNodeId(UAModel.gh.Variables.CamType_Mode, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_exposure = new ExpandedNodeId(UAModel.gh.Variables.CamType_exposure, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetExposure_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_SetExposure_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CamType_SetExposure_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.CamType_SetExposure_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_Abs = new ExpandedNodeId(UAModel.gh.Variables.PumpType_Abs, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_GotoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PumpType_GotoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_GotoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PumpType_GotoAbs_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PumpType_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PumpType_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_SetMode_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_SetMode_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_SetMode_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_SetMode_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_SetExposure_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_SetExposure_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Balser_SetExposure_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Balser_SetExposure_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_IF2451_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_IF2451_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_IF2451_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_IF2451_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_IF2451_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_IF2451_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_IF2451_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_IF2451_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_IF2451_GetCurDistance_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_IF2451_GetCurDistance_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_IF2451_GetCurDistance_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_IF2451_GetCurDistance_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Tecan_GotoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Tecan_GotoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Tecan_GotoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Tecan_GotoAbs_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Tecan_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Tecan_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_Tecan_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_Tecan_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_Jog_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_Jog_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_Jog_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_Jog_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_SetZero_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_SetZero_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_SetZero_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_SetZero_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_Reset_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_Reset_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_Reset_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_Reset_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_Goto_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_Goto_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_Goto_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_Goto_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_RunScript_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_RunScript_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_RunScript_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_RunScript_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_IOUint_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_IOUint_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_IOUint_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_IOUint_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_IOUint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_IOUint_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_OpticalModel_IOUint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_OpticalModel_IOUint_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_Jog_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_Jog_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_Jog_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_Jog_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_SetZero_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_SetZero_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_SetZero_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_SetZero_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_Reset_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_Reset_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_Reset_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_Reset_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_Goto_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_Goto_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_Goto_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_Goto_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_RunScript_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_RunScript_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_RunScript_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_RunScript_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_IOUint_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_IOUint_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_IOUint_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_IOUint_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_IOUint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_IOUint_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_DualModel_IOUint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_DualModel_IOUint_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_SetMode_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_SetMode_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_SetMode_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_SetMode_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_SetExposure_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_SetExposure_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Balser_SetExposure_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Balser_SetExposure_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_IF2451_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_IF2451_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_IF2451_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_IF2451_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_IF2451_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_IF2451_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_IF2451_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_IF2451_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_IF2451_GetCurDistance_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_IF2451_GetCurDistance_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_IF2451_GetCurDistance_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_IF2451_GetCurDistance_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Tecan_GotoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Tecan_GotoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Tecan_GotoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Tecan_GotoAbs_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Tecan_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Tecan_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_Tecan_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_Tecan_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_Jog_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_Jog_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_Jog_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_Jog_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_SetZero_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_SetZero_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_SetZero_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_SetZero_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_Reset_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_Reset_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_Reset_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_Reset_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_Goto_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_Goto_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_Goto_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_Goto_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_RunScript_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_RunScript_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_RunScript_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_RunScript_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_IOUint_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_IOUint_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_IOUint_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_IOUint_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_IOUint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_IOUint_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_OpticalModel_IOUint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_OpticalModel_IOUint_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_Jog_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_Jog_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_Jog_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_Jog_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_SetZero_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_SetZero_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_SetZero_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_SetZero_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_Reset_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_Reset_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_Reset_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_Reset_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_Goto_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_Goto_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_Goto_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_Goto_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_RunScript_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_RunScript_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_RunScript_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_RunScript_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_IOUint_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_IOUint_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_IOUint_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_IOUint_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_IOUint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_IOUint_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_DualModel_IOUint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_DualModel_IOUint_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Abs = "Abs";

        /// <remarks />
        public const string Athena = "Athena";

        /// <remarks />
        public const string AUint = "AUint";

        /// <remarks />
        public const string AxisType = "AxisType";

        /// <remarks />
        public const string Balser = "Balser";

        /// <remarks />
        public const string CamType = "CamType";

        /// <remarks />
        public const string DualModel = "DualModel";

        /// <remarks />
        public const string exposure = "exposure";

        /// <remarks />
        public const string GetCurDistance = "GetCurDistance";

        /// <remarks />
        public const string GetCurDistanceMethodType = "GetCurDistanceMethodType";

        /// <remarks />
        public const string Goto = "Goto";

        /// <remarks />
        public const string GotoAbs = "GotoAbs";

        /// <remarks />
        public const string GotoAbsMethodType = "GotoAbsMethodType";

        /// <remarks />
        public const string GotoMethodType = "GotoMethodType";

        /// <remarks />
        public const string http___gibh_addDev_com = "http://gib439_adddevice.org/gh/";

        /// <remarks />
        public const string IF2451 = "IF2451";

        /// <remarks />
        public const string Input1States = "Input1States";

        /// <remarks />
        public const string Input2States = "Input2States";

        /// <remarks />
        public const string IOtype = "IOtype";

        /// <remarks />
        public const string IOUint = "IOUint";

        /// <remarks />
        public const string Jog = "Jog";

        /// <remarks />
        public const string JogMethodType = "JogMethodType";

        /// <remarks />
        public const string LocalAxis = "LocalAxis";

        /// <remarks />
        public const string MeanDistance = "MeanDistance";

        /// <remarks />
        public const string MechineAxis = "MechineAxis";

        /// <remarks />
        public const string Mode = "Mode";

        /// <remarks />
        public const string mscTyoe = "mscTyoe";

        /// <remarks />
        public const string Name = "Name";

        /// <remarks />
        public const string OpticalModel = "OpticalModel";

        /// <remarks />
        public const string PumpType = "PumpType";

        /// <remarks />
        public const string ReadIO = "ReadIO";

        /// <remarks />
        public const string ReadIOMethodType = "ReadIOMethodType";

        /// <remarks />
        public const string Reset = "Reset";

        /// <remarks />
        public const string RunModelType = "RunModelType";

        /// <remarks />
        public const string RunScript = "RunScript";

        /// <remarks />
        public const string RunScriptMethodType = "RunScriptMethodType";

        /// <remarks />
        public const string SetExposure = "SetExposure";

        /// <remarks />
        public const string SetExposureMethodType = "SetExposureMethodType";

        /// <remarks />
        public const string SetIO = "SetIO";

        /// <remarks />
        public const string SetIOMethodType = "SetIOMethodType";

        /// <remarks />
        public const string SetMode = "SetMode";

        /// <remarks />
        public const string SetModeMethodType = "SetModeMethodType";

        /// <remarks />
        public const string SetSpeed = "SetSpeed";

        /// <remarks />
        public const string SetSpeedMethodType = "SetSpeedMethodType";

        /// <remarks />
        public const string SetZero = "SetZero";

        /// <remarks />
        public const string StartCapture = "StartCapture";

        /// <remarks />
        public const string StopCapture = "StopCapture";

        /// <remarks />
        public const string Tecan = "Tecan";

        /// <remarks />
        public const string XUint = "XUint";

        /// <remarks />
        public const string Yuint = "Yuint";

        /// <remarks />
        public const string ZUint = "ZUint";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the gh namespace (.NET code namespace is 'UAModel.gh').
        /// </summary>
        public const string gh = "http://gib439_adddevice.org/gh/";

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