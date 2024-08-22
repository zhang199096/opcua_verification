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
        public const uint CentrifugeType_StartCentrifuge = 7011;

        /// <remarks />
        public const uint CentrifugeType_StopCentrifuge = 7012;

        /// <remarks />
        public const uint CentrifugeType_CtrlLid = 7037;

        /// <remarks />
        public const uint PcrType_Start = 7013;

        /// <remarks />
        public const uint PcrType_Stop = 7014;

        /// <remarks />
        public const uint PMTType_StartCapture = 7015;

        /// <remarks />
        public const uint PMTType_StopCapture = 7016;

        /// <remarks />
        public const uint PMTType_GetPmtValue = 7017;

        /// <remarks />
        public const uint OscillateType_Start = 7018;

        /// <remarks />
        public const uint OscillateType_Stop = 7019;

        /// <remarks />
        public const uint VibrateAndHeatType_Start = 7020;

        /// <remarks />
        public const uint VibrateAndHeatType_Stop = 7021;

        /// <remarks />
        public const uint PlungerpType_SetSpeed = 7070;

        /// <remarks />
        public const uint PlungerpType_SetStartSpeed = 7071;

        /// <remarks />
        public const uint PlungerpType_SetSlope = 7072;

        /// <remarks />
        public const uint PlungerpType_SetCompensation = 7073;

        /// <remarks />
        public const uint PlungerpType_RelativePump = 7074;

        /// <remarks />
        public const uint PlungerpType_RelativeDischarge = 7075;

        /// <remarks />
        public const uint PlungerpType_CheckError = 7076;

        /// <remarks />
        public const uint PlungerpType_EjectTip = 7077;

        /// <remarks />
        public const uint PlungerpType_GoAbs = 7078;

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

        /// <remarks />
        public const string OscillateType_StartMethodType = "";

        /// <remarks />
        public const string CentrifugeType_CtrlLidMethodType = "";

        /// <remarks />
        public const string PlungerpType_SetStartSpeedMethodType = "";

        /// <remarks />
        public const string PlungerpType_SetSlopeMethodType = "";

        /// <remarks />
        public const string PlungerpType_SetCompensationMethodType = "";

        /// <remarks />
        public const string PlungerpType_RelativePumpMethodType = "";

        /// <remarks />
        public const string PlungerpType_RelativeDischargeMethodType = "";

        /// <remarks />
        public const string PlungerpType_CheckErrorMethodType = "";

        /// <remarks />
        public const string PlungerpType_GoAbsMethodType = "";
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
        public const uint mscTyoe_AutoPlungerp = 5013;

        /// <remarks />
        public const uint Athena = 5027;

        /// <remarks />
        public const uint NAEBotType_centrifuge = 5012;

        /// <remarks />
        public const uint NAEBotType_DualTip = 5014;

        /// <remarks />
        public const uint NAEBotType_LinearModel = 5015;

        /// <remarks />
        public const uint NAEBotType_PMT = 5016;

        /// <remarks />
        public const uint NAEBotType_Oscillate = 5018;

        /// <remarks />
        public const uint NAEBotType_VibrateHeat = 5019;

        /// <remarks />
        public const uint NAEbot = 5022;
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

        /// <remarks />
        public const uint CentrifugeType = 1007;

        /// <remarks />
        public const uint PcrType = 1008;

        /// <remarks />
        public const uint PMTType = 1009;

        /// <remarks />
        public const uint NAEBotType = 1010;

        /// <remarks />
        public const uint OscillateType = 1011;

        /// <remarks />
        public const uint VibrateAndHeatType = 1012;

        /// <remarks />
        public const uint PlungerpType = 1013;
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
        public const uint mscTyoe_AutoPlungerp_SetSpeed_InputArguments = 6230;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_SetSpeed_OutputArguments = 6231;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_SetStartSpeed_InputArguments = 6232;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_SetStartSpeed_OutputArguments = 6233;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_SetSlope_InputArguments = 6234;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_SetSlope_OutputArguments = 6235;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_SetCompensation_InputArguments = 6236;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_SetCompensation_OutputArguments = 6237;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_RelativePump_InputArguments = 6239;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_RelativePump_OutputArguments = 6240;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_RelativeDischarge_InputArguments = 6241;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_RelativeDischarge_OutputArguments = 6242;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_CheckError_InputArguments = 6243;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_CheckError_OutputArguments = 6244;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_EjectTip_InputArguments = 6245;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_EjectTip_OutputArguments = 6246;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_GoAbs_InputArguments = 6247;

        /// <remarks />
        public const uint mscTyoe_AutoPlungerp_GoAbs_OutputArguments = 6248;

        /// <remarks />
        public const uint Athena_Balser_StartCapture_InputArguments = 6212;

        /// <remarks />
        public const uint Athena_Balser_StartCapture_OutputArguments = 6213;

        /// <remarks />
        public const uint Athena_Balser_SetMode_InputArguments = 6210;

        /// <remarks />
        public const uint Athena_Balser_SetMode_OutputArguments = 6211;

        /// <remarks />
        public const uint Athena_Balser_StopCapture_InputArguments = 6214;

        /// <remarks />
        public const uint Athena_Balser_StopCapture_OutputArguments = 6215;

        /// <remarks />
        public const uint Athena_Balser_SetExposure_InputArguments = 6208;

        /// <remarks />
        public const uint Athena_Balser_SetExposure_OutputArguments = 6209;

        /// <remarks />
        public const uint Athena_IF2451_StartCapture_InputArguments = 6103;

        /// <remarks />
        public const uint Athena_IF2451_StartCapture_OutputArguments = 6104;

        /// <remarks />
        public const uint Athena_IF2451_StopCapture_InputArguments = 6105;

        /// <remarks />
        public const uint Athena_IF2451_StopCapture_OutputArguments = 6106;

        /// <remarks />
        public const uint Athena_IF2451_GetCurDistance_InputArguments = 6100;

        /// <remarks />
        public const uint Athena_IF2451_GetCurDistance_OutputArguments = 6101;

        /// <remarks />
        public const uint Athena_Tecan_GotoAbs_InputArguments = 6119;

        /// <remarks />
        public const uint Athena_Tecan_GotoAbs_OutputArguments = 6120;

        /// <remarks />
        public const uint Athena_Tecan_SetSpeed_InputArguments = 6122;

        /// <remarks />
        public const uint Athena_Tecan_SetSpeed_OutputArguments = 6123;

        /// <remarks />
        public const uint Athena_OpticalModel_Jog_InputArguments = 6113;

        /// <remarks />
        public const uint Athena_OpticalModel_Jog_OutputArguments = 6114;

        /// <remarks />
        public const uint Athena_OpticalModel_SetZero_InputArguments = 6117;

        /// <remarks />
        public const uint Athena_OpticalModel_SetZero_OutputArguments = 6118;

        /// <remarks />
        public const uint Athena_OpticalModel_Reset_InputArguments = 6109;

        /// <remarks />
        public const uint Athena_OpticalModel_Reset_OutputArguments = 6110;

        /// <remarks />
        public const uint Athena_OpticalModel_Goto_InputArguments = 6107;

        /// <remarks />
        public const uint Athena_OpticalModel_Goto_OutputArguments = 6108;

        /// <remarks />
        public const uint Athena_OpticalModel_RunScript_InputArguments = 6115;

        /// <remarks />
        public const uint Athena_OpticalModel_RunScript_OutputArguments = 6116;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_SetIO_InputArguments = 6138;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_SetIO_OutputArguments = 6139;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_ReadIO_InputArguments = 6136;

        /// <remarks />
        public const uint Athena_OpticalModel_IOUint_ReadIO_OutputArguments = 6137;

        /// <remarks />
        public const uint Athena_DualModel_Jog_InputArguments = 6082;

        /// <remarks />
        public const uint Athena_DualModel_Jog_OutputArguments = 6083;

        /// <remarks />
        public const uint Athena_DualModel_SetZero_InputArguments = 6096;

        /// <remarks />
        public const uint Athena_DualModel_SetZero_OutputArguments = 6097;

        /// <remarks />
        public const uint Athena_DualModel_Reset_InputArguments = 6084;

        /// <remarks />
        public const uint Athena_DualModel_Reset_OutputArguments = 6085;

        /// <remarks />
        public const uint Athena_DualModel_Goto_InputArguments = 6080;

        /// <remarks />
        public const uint Athena_DualModel_Goto_OutputArguments = 6081;

        /// <remarks />
        public const uint Athena_DualModel_RunScript_InputArguments = 6098;

        /// <remarks />
        public const uint Athena_DualModel_RunScript_OutputArguments = 6099;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_SetIO_InputArguments = 6150;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_SetIO_OutputArguments = 6151;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_ReadIO_InputArguments = 6147;

        /// <remarks />
        public const uint Athena_DualModel_IOUint_ReadIO_OutputArguments = 6148;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetSpeed_InputArguments = 6268;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetSpeed_OutputArguments = 6269;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetStartSpeed_InputArguments = 6270;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetStartSpeed_OutputArguments = 6271;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetSlope_InputArguments = 6264;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetSlope_OutputArguments = 6265;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetCompensation_InputArguments = 6266;

        /// <remarks />
        public const uint Athena_AutoPlungerp_SetCompensation_OutputArguments = 6267;

        /// <remarks />
        public const uint Athena_AutoPlungerp_RelativePump_InputArguments = 6262;

        /// <remarks />
        public const uint Athena_AutoPlungerp_RelativePump_OutputArguments = 6263;

        /// <remarks />
        public const uint Athena_AutoPlungerp_RelativeDischarge_InputArguments = 6260;

        /// <remarks />
        public const uint Athena_AutoPlungerp_RelativeDischarge_OutputArguments = 6261;

        /// <remarks />
        public const uint Athena_AutoPlungerp_CheckError_InputArguments = 6250;

        /// <remarks />
        public const uint Athena_AutoPlungerp_CheckError_OutputArguments = 6251;

        /// <remarks />
        public const uint Athena_AutoPlungerp_EjectTip_InputArguments = 6254;

        /// <remarks />
        public const uint Athena_AutoPlungerp_EjectTip_OutputArguments = 6255;

        /// <remarks />
        public const uint Athena_AutoPlungerp_GoAbs_InputArguments = 6256;

        /// <remarks />
        public const uint Athena_AutoPlungerp_GoAbs_OutputArguments = 6257;

        /// <remarks />
        public const uint CentrifugeType_Id = 6039;

        /// <remarks />
        public const uint CentrifugeType_Speed = 6040;

        /// <remarks />
        public const uint CentrifugeType_StartCentrifuge_InputArguments = 6041;

        /// <remarks />
        public const uint CentrifugeType_StartCentrifuge_OutputArguments = 6042;

        /// <remarks />
        public const uint CentrifugeType_StopCentrifuge_InputArguments = 6043;

        /// <remarks />
        public const uint CentrifugeType_StopCentrifuge_OutputArguments = 6044;

        /// <remarks />
        public const uint CentrifugeType_Status = 6045;

        /// <remarks />
        public const uint CentrifugeType_CtrlLid_InputArguments = 6063;

        /// <remarks />
        public const uint CentrifugeType_CtrlLid_OutputArguments = 6069;

        /// <remarks />
        public const uint CentrifugeType_Mode = 6073;

        /// <remarks />
        public const uint PcrType_Id = 6047;

        /// <remarks />
        public const uint PcrType_SetTmep = 6048;

        /// <remarks />
        public const uint PcrType_CurTemp = 6049;

        /// <remarks />
        public const uint PcrType_Start_InputArguments = 6050;

        /// <remarks />
        public const uint PcrType_Start_OutputArguments = 6051;

        /// <remarks />
        public const uint PcrType_Stop_InputArguments = 6052;

        /// <remarks />
        public const uint PcrType_Stop_OutputArguments = 6053;

        /// <remarks />
        public const uint PMTType_Id = 6054;

        /// <remarks />
        public const uint PMTType_StartCapture_InputArguments = 6055;

        /// <remarks />
        public const uint PMTType_StartCapture_OutputArguments = 6056;

        /// <remarks />
        public const uint PMTType_StopCapture_InputArguments = 6057;

        /// <remarks />
        public const uint PMTType_StopCapture_OutputArguments = 6058;

        /// <remarks />
        public const uint PMTType_GetPmtValue_InputArguments = 6059;

        /// <remarks />
        public const uint PMTType_GetPmtValue_OutputArguments = 6060;

        /// <remarks />
        public const uint NAEBotType_centrifuge_StartCentrifuge_InputArguments = 6041;

        /// <remarks />
        public const uint NAEBotType_centrifuge_StartCentrifuge_OutputArguments = 6042;

        /// <remarks />
        public const uint NAEBotType_centrifuge_StopCentrifuge_InputArguments = 6043;

        /// <remarks />
        public const uint NAEBotType_centrifuge_StopCentrifuge_OutputArguments = 6044;

        /// <remarks />
        public const uint NAEBotType_centrifuge_CtrlLid_InputArguments = 6063;

        /// <remarks />
        public const uint NAEBotType_centrifuge_CtrlLid_OutputArguments = 6069;

        /// <remarks />
        public const uint NAEBotType_DualTip_GotoAbs_InputArguments = 6037;

        /// <remarks />
        public const uint NAEBotType_DualTip_GotoAbs_OutputArguments = 6038;

        /// <remarks />
        public const uint NAEBotType_DualTip_SetSpeed_InputArguments = 6071;

        /// <remarks />
        public const uint NAEBotType_DualTip_SetSpeed_OutputArguments = 6072;

        /// <remarks />
        public const uint NAEBotType_LinearModel_Jog_InputArguments = 6018;

        /// <remarks />
        public const uint NAEBotType_LinearModel_Jog_OutputArguments = 6019;

        /// <remarks />
        public const uint NAEBotType_LinearModel_SetZero_InputArguments = 6020;

        /// <remarks />
        public const uint NAEBotType_LinearModel_SetZero_OutputArguments = 6021;

        /// <remarks />
        public const uint NAEBotType_LinearModel_Reset_InputArguments = 6022;

        /// <remarks />
        public const uint NAEBotType_LinearModel_Reset_OutputArguments = 6023;

        /// <remarks />
        public const uint NAEBotType_LinearModel_Goto_InputArguments = 6024;

        /// <remarks />
        public const uint NAEBotType_LinearModel_Goto_OutputArguments = 6025;

        /// <remarks />
        public const uint NAEBotType_LinearModel_RunScript_InputArguments = 6026;

        /// <remarks />
        public const uint NAEBotType_LinearModel_RunScript_OutputArguments = 6027;

        /// <remarks />
        public const uint NAEBotType_LinearModel_IOUint_SetIO_InputArguments = 6009;

        /// <remarks />
        public const uint NAEBotType_LinearModel_IOUint_SetIO_OutputArguments = 6010;

        /// <remarks />
        public const uint NAEBotType_LinearModel_IOUint_ReadIO_InputArguments = 6012;

        /// <remarks />
        public const uint NAEBotType_LinearModel_IOUint_ReadIO_OutputArguments = 6013;

        /// <remarks />
        public const uint NAEBotType_PMT_StartCapture_InputArguments = 6055;

        /// <remarks />
        public const uint NAEBotType_PMT_StartCapture_OutputArguments = 6056;

        /// <remarks />
        public const uint NAEBotType_PMT_StopCapture_InputArguments = 6057;

        /// <remarks />
        public const uint NAEBotType_PMT_StopCapture_OutputArguments = 6058;

        /// <remarks />
        public const uint NAEBotType_PMT_GetPmtValue_InputArguments = 6059;

        /// <remarks />
        public const uint NAEBotType_PMT_GetPmtValue_OutputArguments = 6060;

        /// <remarks />
        public const uint NAEBotType_Oscillate_Start_InputArguments = 6064;

        /// <remarks />
        public const uint NAEBotType_Oscillate_Start_OutputArguments = 6065;

        /// <remarks />
        public const uint NAEBotType_Oscillate_Stop_InputArguments = 6066;

        /// <remarks />
        public const uint NAEBotType_Oscillate_Stop_OutputArguments = 6067;

        /// <remarks />
        public const uint NAEBotType_VibrateHeat_Start_InputArguments = 6074;

        /// <remarks />
        public const uint NAEBotType_VibrateHeat_Start_OutputArguments = 6075;

        /// <remarks />
        public const uint NAEBotType_VibrateHeat_Stop_InputArguments = 6076;

        /// <remarks />
        public const uint NAEBotType_VibrateHeat_Stop_OutputArguments = 6077;

        /// <remarks />
        public const uint OscillateType_Id = 6061;

        /// <remarks />
        public const uint OscillateType_moduleType = 6062;

        /// <remarks />
        public const uint OscillateType_Start_InputArguments = 6064;

        /// <remarks />
        public const uint OscillateType_Start_OutputArguments = 6065;

        /// <remarks />
        public const uint OscillateType_Stop_InputArguments = 6066;

        /// <remarks />
        public const uint OscillateType_Stop_OutputArguments = 6067;

        /// <remarks />
        public const uint OscillateType_Status = 6079;

        /// <remarks />
        public const uint VibrateAndHeatType_Id = 6068;

        /// <remarks />
        public const uint VibrateAndHeatType_mode = 6070;

        /// <remarks />
        public const uint VibrateAndHeatType_Start_InputArguments = 6074;

        /// <remarks />
        public const uint VibrateAndHeatType_Start_OutputArguments = 6075;

        /// <remarks />
        public const uint VibrateAndHeatType_Stop_InputArguments = 6076;

        /// <remarks />
        public const uint VibrateAndHeatType_Stop_OutputArguments = 6077;

        /// <remarks />
        public const uint VibrateAndHeatType_Status = 6078;

        /// <remarks />
        public const uint VibrateAndHeatType_Temp = 6221;

        /// <remarks />
        public const uint NAEbot_centrifuge_StartCentrifuge_InputArguments = 6216;

        /// <remarks />
        public const uint NAEbot_centrifuge_StartCentrifuge_OutputArguments = 6217;

        /// <remarks />
        public const uint NAEbot_centrifuge_StopCentrifuge_InputArguments = 6219;

        /// <remarks />
        public const uint NAEbot_centrifuge_StopCentrifuge_OutputArguments = 6220;

        /// <remarks />
        public const uint NAEbot_centrifuge_CtrlLid_InputArguments = 6111;

        /// <remarks />
        public const uint NAEbot_centrifuge_CtrlLid_OutputArguments = 6112;

        /// <remarks />
        public const uint NAEbot_DualTip_GotoAbs_InputArguments = 6153;

        /// <remarks />
        public const uint NAEbot_DualTip_GotoAbs_OutputArguments = 6154;

        /// <remarks />
        public const uint NAEbot_DualTip_SetSpeed_InputArguments = 6155;

        /// <remarks />
        public const uint NAEbot_DualTip_SetSpeed_OutputArguments = 6156;

        /// <remarks />
        public const uint NAEbot_LinearModel_Jog_InputArguments = 6161;

        /// <remarks />
        public const uint NAEbot_LinearModel_Jog_OutputArguments = 6162;

        /// <remarks />
        public const uint NAEbot_LinearModel_SetZero_InputArguments = 6167;

        /// <remarks />
        public const uint NAEbot_LinearModel_SetZero_OutputArguments = 6168;

        /// <remarks />
        public const uint NAEbot_LinearModel_Reset_InputArguments = 6163;

        /// <remarks />
        public const uint NAEbot_LinearModel_Reset_OutputArguments = 6164;

        /// <remarks />
        public const uint NAEbot_LinearModel_Goto_InputArguments = 6157;

        /// <remarks />
        public const uint NAEbot_LinearModel_Goto_OutputArguments = 6158;

        /// <remarks />
        public const uint NAEbot_LinearModel_RunScript_InputArguments = 6165;

        /// <remarks />
        public const uint NAEbot_LinearModel_RunScript_OutputArguments = 6166;

        /// <remarks />
        public const uint NAEbot_LinearModel_IOUint_SetIO_InputArguments = 6196;

        /// <remarks />
        public const uint NAEbot_LinearModel_IOUint_SetIO_OutputArguments = 6197;

        /// <remarks />
        public const uint NAEbot_LinearModel_IOUint_ReadIO_InputArguments = 6194;

        /// <remarks />
        public const uint NAEbot_LinearModel_IOUint_ReadIO_OutputArguments = 6195;

        /// <remarks />
        public const uint NAEbot_PMT_StartCapture_InputArguments = 6179;

        /// <remarks />
        public const uint NAEbot_PMT_StartCapture_OutputArguments = 6180;

        /// <remarks />
        public const uint NAEbot_PMT_StopCapture_InputArguments = 6181;

        /// <remarks />
        public const uint NAEbot_PMT_StopCapture_OutputArguments = 6182;

        /// <remarks />
        public const uint NAEbot_PMT_GetPmtValue_InputArguments = 6176;

        /// <remarks />
        public const uint NAEbot_PMT_GetPmtValue_OutputArguments = 6177;

        /// <remarks />
        public const uint NAEbot_Oscillate_Start_InputArguments = 6171;

        /// <remarks />
        public const uint NAEbot_Oscillate_Start_OutputArguments = 6172;

        /// <remarks />
        public const uint NAEbot_Oscillate_Stop_InputArguments = 6173;

        /// <remarks />
        public const uint NAEbot_Oscillate_Stop_OutputArguments = 6174;

        /// <remarks />
        public const uint NAEbot_VibrateHeat_Start_InputArguments = 6185;

        /// <remarks />
        public const uint NAEbot_VibrateHeat_Start_OutputArguments = 6186;

        /// <remarks />
        public const uint NAEbot_VibrateHeat_Stop_InputArguments = 6188;

        /// <remarks />
        public const uint NAEbot_VibrateHeat_Stop_OutputArguments = 6189;

        /// <remarks />
        public const uint PlungerpType_Id = 6046;

        /// <remarks />
        public const uint PlungerpType_Acc = 6223;

        /// <remarks />
        public const uint PlungerpType_Dec = 6224;

        /// <remarks />
        public const uint PlungerpType_VStart = 6225;

        /// <remarks />
        public const uint PlungerpType_VEnd = 6226;

        /// <remarks />
        public const uint PlungerpType_VMax = 6227;

        /// <remarks />
        public const uint PlungerpType_Pos = 6228;

        /// <remarks />
        public const uint PlungerpType_Compensation = 6229;

        /// <remarks />
        public const uint PlungerpType_SetSpeed_InputArguments = 6230;

        /// <remarks />
        public const uint PlungerpType_SetSpeed_OutputArguments = 6231;

        /// <remarks />
        public const uint PlungerpType_SetStartSpeed_InputArguments = 6232;

        /// <remarks />
        public const uint PlungerpType_SetStartSpeed_OutputArguments = 6233;

        /// <remarks />
        public const uint PlungerpType_SetSlope_InputArguments = 6234;

        /// <remarks />
        public const uint PlungerpType_SetSlope_OutputArguments = 6235;

        /// <remarks />
        public const uint PlungerpType_SetCompensation_InputArguments = 6236;

        /// <remarks />
        public const uint PlungerpType_SetCompensation_OutputArguments = 6237;

        /// <remarks />
        public const uint PlungerpType_Status = 6238;

        /// <remarks />
        public const uint PlungerpType_RelativePump_InputArguments = 6239;

        /// <remarks />
        public const uint PlungerpType_RelativePump_OutputArguments = 6240;

        /// <remarks />
        public const uint PlungerpType_RelativeDischarge_InputArguments = 6241;

        /// <remarks />
        public const uint PlungerpType_RelativeDischarge_OutputArguments = 6242;

        /// <remarks />
        public const uint PlungerpType_CheckError_InputArguments = 6243;

        /// <remarks />
        public const uint PlungerpType_CheckError_OutputArguments = 6244;

        /// <remarks />
        public const uint PlungerpType_EjectTip_InputArguments = 6245;

        /// <remarks />
        public const uint PlungerpType_EjectTip_OutputArguments = 6246;

        /// <remarks />
        public const uint PlungerpType_GoAbs_InputArguments = 6247;

        /// <remarks />
        public const uint PlungerpType_GoAbs_OutputArguments = 6248;
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
        public static readonly ExpandedNodeId CentrifugeType_StartCentrifuge = new ExpandedNodeId(UAModel.gh.Methods.CentrifugeType_StartCentrifuge, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_StopCentrifuge = new ExpandedNodeId(UAModel.gh.Methods.CentrifugeType_StopCentrifuge, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_CtrlLid = new ExpandedNodeId(UAModel.gh.Methods.CentrifugeType_CtrlLid, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_Start = new ExpandedNodeId(UAModel.gh.Methods.PcrType_Start, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_Stop = new ExpandedNodeId(UAModel.gh.Methods.PcrType_Stop, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_StartCapture = new ExpandedNodeId(UAModel.gh.Methods.PMTType_StartCapture, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_StopCapture = new ExpandedNodeId(UAModel.gh.Methods.PMTType_StopCapture, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_GetPmtValue = new ExpandedNodeId(UAModel.gh.Methods.PMTType_GetPmtValue, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Start = new ExpandedNodeId(UAModel.gh.Methods.OscillateType_Start, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Stop = new ExpandedNodeId(UAModel.gh.Methods.OscillateType_Stop, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Start = new ExpandedNodeId(UAModel.gh.Methods.VibrateAndHeatType_Start, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Stop = new ExpandedNodeId(UAModel.gh.Methods.VibrateAndHeatType_Stop, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetSpeed = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_SetSpeed, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetStartSpeed = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_SetStartSpeed, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetSlope = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_SetSlope, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetCompensation = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_SetCompensation, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativePump = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_RelativePump, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativeDischarge = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_RelativeDischarge, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_CheckError = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_CheckError, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_EjectTip = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_EjectTip, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_GoAbs = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_GoAbs, UAModel.gh.Namespaces.gh);

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

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_StartMethodType = new ExpandedNodeId(UAModel.gh.Methods.OscillateType_StartMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_CtrlLidMethodType = new ExpandedNodeId(UAModel.gh.Methods.CentrifugeType_CtrlLidMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetStartSpeedMethodType = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_SetStartSpeedMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetSlopeMethodType = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_SetSlopeMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetCompensationMethodType = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_SetCompensationMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativePumpMethodType = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_RelativePumpMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativeDischargeMethodType = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_RelativeDischargeMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_CheckErrorMethodType = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_CheckErrorMethodType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_GoAbsMethodType = new ExpandedNodeId(UAModel.gh.Methods.PlungerpType_GoAbsMethodType, UAModel.gh.Namespaces.gh);
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
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp = new ExpandedNodeId(UAModel.gh.Objects.mscTyoe_AutoPlungerp, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena = new ExpandedNodeId(UAModel.gh.Objects.Athena, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_centrifuge = new ExpandedNodeId(UAModel.gh.Objects.NAEBotType_centrifuge, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_DualTip = new ExpandedNodeId(UAModel.gh.Objects.NAEBotType_DualTip, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel = new ExpandedNodeId(UAModel.gh.Objects.NAEBotType_LinearModel, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_PMT = new ExpandedNodeId(UAModel.gh.Objects.NAEBotType_PMT, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_Oscillate = new ExpandedNodeId(UAModel.gh.Objects.NAEBotType_Oscillate, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_VibrateHeat = new ExpandedNodeId(UAModel.gh.Objects.NAEBotType_VibrateHeat, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot = new ExpandedNodeId(UAModel.gh.Objects.NAEbot, UAModel.gh.Namespaces.gh);
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

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType = new ExpandedNodeId(UAModel.gh.ObjectTypes.CentrifugeType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType = new ExpandedNodeId(UAModel.gh.ObjectTypes.PcrType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType = new ExpandedNodeId(UAModel.gh.ObjectTypes.PMTType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType = new ExpandedNodeId(UAModel.gh.ObjectTypes.NAEBotType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType = new ExpandedNodeId(UAModel.gh.ObjectTypes.OscillateType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType = new ExpandedNodeId(UAModel.gh.ObjectTypes.VibrateAndHeatType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType = new ExpandedNodeId(UAModel.gh.ObjectTypes.PlungerpType, UAModel.gh.Namespaces.gh);
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
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetStartSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetStartSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetStartSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetStartSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetSlope_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetSlope_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetSlope_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetSlope_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetCompensation_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetCompensation_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_SetCompensation_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_SetCompensation_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_RelativePump_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_RelativePump_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_RelativePump_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_RelativePump_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_RelativeDischarge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_RelativeDischarge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_RelativeDischarge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_RelativeDischarge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_CheckError_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_CheckError_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_CheckError_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_CheckError_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_EjectTip_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_EjectTip_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_EjectTip_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_EjectTip_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_GoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_GoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId mscTyoe_AutoPlungerp_GoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.mscTyoe_AutoPlungerp_GoAbs_OutputArguments, UAModel.gh.Namespaces.gh);

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

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetStartSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetStartSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetStartSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetStartSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetSlope_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetSlope_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetSlope_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetSlope_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetCompensation_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetCompensation_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_SetCompensation_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_SetCompensation_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_RelativePump_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_RelativePump_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_RelativePump_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_RelativePump_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_RelativeDischarge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_RelativeDischarge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_RelativeDischarge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_RelativeDischarge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_CheckError_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_CheckError_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_CheckError_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_CheckError_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_EjectTip_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_EjectTip_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_EjectTip_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_EjectTip_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_GoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_GoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId Athena_AutoPlungerp_GoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.Athena_AutoPlungerp_GoAbs_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_Id = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_Id, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_Speed = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_Speed, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_StartCentrifuge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_StartCentrifuge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_StartCentrifuge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_StartCentrifuge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_StopCentrifuge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_StopCentrifuge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_StopCentrifuge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_StopCentrifuge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_Status = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_Status, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_CtrlLid_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_CtrlLid_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_CtrlLid_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_CtrlLid_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId CentrifugeType_Mode = new ExpandedNodeId(UAModel.gh.Variables.CentrifugeType_Mode, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_Id = new ExpandedNodeId(UAModel.gh.Variables.PcrType_Id, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_SetTmep = new ExpandedNodeId(UAModel.gh.Variables.PcrType_SetTmep, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_CurTemp = new ExpandedNodeId(UAModel.gh.Variables.PcrType_CurTemp, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_Start_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PcrType_Start_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_Start_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PcrType_Start_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_Stop_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PcrType_Stop_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PcrType_Stop_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PcrType_Stop_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_Id = new ExpandedNodeId(UAModel.gh.Variables.PMTType_Id, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PMTType_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PMTType_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PMTType_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PMTType_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_GetPmtValue_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PMTType_GetPmtValue_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PMTType_GetPmtValue_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PMTType_GetPmtValue_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_centrifuge_StartCentrifuge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_centrifuge_StartCentrifuge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_centrifuge_StartCentrifuge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_centrifuge_StartCentrifuge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_centrifuge_StopCentrifuge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_centrifuge_StopCentrifuge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_centrifuge_StopCentrifuge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_centrifuge_StopCentrifuge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_centrifuge_CtrlLid_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_centrifuge_CtrlLid_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_centrifuge_CtrlLid_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_centrifuge_CtrlLid_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_DualTip_GotoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_DualTip_GotoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_DualTip_GotoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_DualTip_GotoAbs_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_DualTip_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_DualTip_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_DualTip_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_DualTip_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_Jog_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_Jog_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_Jog_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_Jog_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_SetZero_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_SetZero_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_SetZero_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_SetZero_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_Reset_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_Reset_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_Reset_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_Reset_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_Goto_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_Goto_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_Goto_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_Goto_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_RunScript_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_RunScript_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_RunScript_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_RunScript_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_IOUint_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_IOUint_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_IOUint_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_IOUint_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_IOUint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_IOUint_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_LinearModel_IOUint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_LinearModel_IOUint_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_PMT_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_PMT_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_PMT_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_PMT_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_PMT_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_PMT_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_PMT_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_PMT_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_PMT_GetPmtValue_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_PMT_GetPmtValue_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_PMT_GetPmtValue_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_PMT_GetPmtValue_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_Oscillate_Start_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_Oscillate_Start_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_Oscillate_Start_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_Oscillate_Start_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_Oscillate_Stop_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_Oscillate_Stop_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_Oscillate_Stop_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_Oscillate_Stop_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_VibrateHeat_Start_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_VibrateHeat_Start_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_VibrateHeat_Start_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_VibrateHeat_Start_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_VibrateHeat_Stop_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_VibrateHeat_Stop_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEBotType_VibrateHeat_Stop_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEBotType_VibrateHeat_Stop_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Id = new ExpandedNodeId(UAModel.gh.Variables.OscillateType_Id, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_moduleType = new ExpandedNodeId(UAModel.gh.Variables.OscillateType_moduleType, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Start_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.OscillateType_Start_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Start_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.OscillateType_Start_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Stop_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.OscillateType_Stop_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Stop_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.OscillateType_Stop_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId OscillateType_Status = new ExpandedNodeId(UAModel.gh.Variables.OscillateType_Status, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Id = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_Id, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_mode = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_mode, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Start_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_Start_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Start_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_Start_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Stop_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_Stop_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Stop_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_Stop_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Status = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_Status, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId VibrateAndHeatType_Temp = new ExpandedNodeId(UAModel.gh.Variables.VibrateAndHeatType_Temp, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_centrifuge_StartCentrifuge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_centrifuge_StartCentrifuge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_centrifuge_StartCentrifuge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_centrifuge_StartCentrifuge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_centrifuge_StopCentrifuge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_centrifuge_StopCentrifuge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_centrifuge_StopCentrifuge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_centrifuge_StopCentrifuge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_centrifuge_CtrlLid_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_centrifuge_CtrlLid_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_centrifuge_CtrlLid_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_centrifuge_CtrlLid_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_DualTip_GotoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_DualTip_GotoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_DualTip_GotoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_DualTip_GotoAbs_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_DualTip_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_DualTip_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_DualTip_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_DualTip_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_Jog_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_Jog_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_Jog_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_Jog_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_SetZero_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_SetZero_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_SetZero_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_SetZero_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_Reset_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_Reset_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_Reset_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_Reset_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_Goto_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_Goto_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_Goto_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_Goto_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_RunScript_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_RunScript_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_RunScript_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_RunScript_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_IOUint_SetIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_IOUint_SetIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_IOUint_SetIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_IOUint_SetIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_IOUint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_IOUint_ReadIO_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_LinearModel_IOUint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_LinearModel_IOUint_ReadIO_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_PMT_StartCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_PMT_StartCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_PMT_StartCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_PMT_StartCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_PMT_StopCapture_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_PMT_StopCapture_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_PMT_StopCapture_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_PMT_StopCapture_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_PMT_GetPmtValue_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_PMT_GetPmtValue_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_PMT_GetPmtValue_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_PMT_GetPmtValue_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_Oscillate_Start_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_Oscillate_Start_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_Oscillate_Start_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_Oscillate_Start_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_Oscillate_Stop_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_Oscillate_Stop_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_Oscillate_Stop_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_Oscillate_Stop_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_VibrateHeat_Start_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_VibrateHeat_Start_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_VibrateHeat_Start_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_VibrateHeat_Start_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_VibrateHeat_Stop_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_VibrateHeat_Stop_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId NAEbot_VibrateHeat_Stop_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.NAEbot_VibrateHeat_Stop_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_Id = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_Id, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_Acc = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_Acc, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_Dec = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_Dec, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_VStart = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_VStart, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_VEnd = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_VEnd, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_VMax = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_VMax, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_Pos = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_Pos, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_Compensation = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_Compensation, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetStartSpeed_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetStartSpeed_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetStartSpeed_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetStartSpeed_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetSlope_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetSlope_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetSlope_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetSlope_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetCompensation_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetCompensation_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_SetCompensation_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_SetCompensation_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_Status = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_Status, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativePump_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_RelativePump_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativePump_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_RelativePump_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativeDischarge_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_RelativeDischarge_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_RelativeDischarge_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_RelativeDischarge_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_CheckError_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_CheckError_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_CheckError_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_CheckError_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_EjectTip_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_EjectTip_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_EjectTip_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_EjectTip_OutputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_GoAbs_InputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_GoAbs_InputArguments, UAModel.gh.Namespaces.gh);

        /// <remarks />
        public static readonly ExpandedNodeId PlungerpType_GoAbs_OutputArguments = new ExpandedNodeId(UAModel.gh.Variables.PlungerpType_GoAbs_OutputArguments, UAModel.gh.Namespaces.gh);
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
        public const string Acc = "Acc";

        /// <remarks />
        public const string Athena = "Athena";

        /// <remarks />
        public const string AUint = "AUint";

        /// <remarks />
        public const string AutoPlungerp = "AutoPlungerp";

        /// <remarks />
        public const string AxisType = "AxisType";

        /// <remarks />
        public const string Balser = "Balser";

        /// <remarks />
        public const string CamType = "CamType";

        /// <remarks />
        public const string centrifuge = "centrifuge";

        /// <remarks />
        public const string CentrifugeType = "CentrifugeType";

        /// <remarks />
        public const string CheckError = "CheckError";

        /// <remarks />
        public const string CheckErrorMethodType = "CheckErrorMethodType";

        /// <remarks />
        public const string Compensation = "Compensation";

        /// <remarks />
        public const string CtrlLid = "CtrlLid";

        /// <remarks />
        public const string CtrlLidMethodType = "CtrlLidMethodType";

        /// <remarks />
        public const string CurTemp = "CurTemp";

        /// <remarks />
        public const string Dec = "Dec";

        /// <remarks />
        public const string DualModel = "DualModel";

        /// <remarks />
        public const string DualTip = "DualTip";

        /// <remarks />
        public const string EjectTip = "EjectTip";

        /// <remarks />
        public const string exposure = "exposure";

        /// <remarks />
        public const string GetCurDistance = "GetCurDistance";

        /// <remarks />
        public const string GetCurDistanceMethodType = "GetCurDistanceMethodType";

        /// <remarks />
        public const string GetPmtValue = "GetPmtValue";

        /// <remarks />
        public const string GoAbs = "GoAbs";

        /// <remarks />
        public const string GoAbsMethodType = "GoAbsMethodType";

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
        public const string Id = "Id";

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
        public const string LinearModel = "LinearModel";

        /// <remarks />
        public const string LocalAxis = "LocalAxis";

        /// <remarks />
        public const string MeanDistance = "MeanDistance";

        /// <remarks />
        public const string MechineAxis = "MechineAxis";

        /// <remarks />
        public const string mode = "mode";

        /// <remarks />
        public const string Mode = "Mode";

        /// <remarks />
        public const string moduleType = "moduleType";

        /// <remarks />
        public const string mscTyoe = "mscTyoe";

        /// <remarks />
        public const string NAEbot = "NAEbot";

        /// <remarks />
        public const string NAEBotType = "NAEBotType";

        /// <remarks />
        public const string Name = "Name";

        /// <remarks />
        public const string OpticalModel = "OpticalModel";

        /// <remarks />
        public const string Oscillate = "Oscillate";

        /// <remarks />
        public const string OscillateType = "OscillateType";

        /// <remarks />
        public const string PcrType = "PcrType";

        /// <remarks />
        public const string PlungerpType = "PlungerpType";

        /// <remarks />
        public const string PMT = "PMT";

        /// <remarks />
        public const string PMTType = "PMTType";

        /// <remarks />
        public const string Pos = "Pos";

        /// <remarks />
        public const string PumpType = "PumpType";

        /// <remarks />
        public const string ReadIO = "ReadIO";

        /// <remarks />
        public const string ReadIOMethodType = "ReadIOMethodType";

        /// <remarks />
        public const string RelativeDischarge = "RelativeDischarge";

        /// <remarks />
        public const string RelativeDischargeMethodType = "RelativeDischargeMethodType";

        /// <remarks />
        public const string RelativePump = "RelativePump";

        /// <remarks />
        public const string RelativePumpMethodType = "RelativePumpMethodType";

        /// <remarks />
        public const string Reset = "Reset";

        /// <remarks />
        public const string RunModelType = "RunModelType";

        /// <remarks />
        public const string RunScript = "RunScript";

        /// <remarks />
        public const string RunScriptMethodType = "RunScriptMethodType";

        /// <remarks />
        public const string SetCompensation = "SetCompensation";

        /// <remarks />
        public const string SetCompensationMethodType = "SetCompensationMethodType";

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
        public const string SetSlope = "SetSlope";

        /// <remarks />
        public const string SetSlopeMethodType = "SetSlopeMethodType";

        /// <remarks />
        public const string SetSpeed = "SetSpeed";

        /// <remarks />
        public const string SetSpeedMethodType = "SetSpeedMethodType";

        /// <remarks />
        public const string SetStartSpeed = "SetStartSpeed";

        /// <remarks />
        public const string SetStartSpeedMethodType = "SetStartSpeedMethodType";

        /// <remarks />
        public const string SetTmep = "SetTmep";

        /// <remarks />
        public const string SetZero = "SetZero";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string Start = "Start";

        /// <remarks />
        public const string StartCapture = "StartCapture";

        /// <remarks />
        public const string StartCentrifuge = "StartCentrifuge";

        /// <remarks />
        public const string StartMethodType = "StartMethodType";

        /// <remarks />
        public const string Status = "Status";

        /// <remarks />
        public const string Stop = "Stop";

        /// <remarks />
        public const string StopCapture = "StopCapture";

        /// <remarks />
        public const string StopCentrifuge = "StopCentrifuge";

        /// <remarks />
        public const string Tecan = "Tecan";

        /// <remarks />
        public const string Temp = "Temp";

        /// <remarks />
        public const string VEnd = "VEnd";

        /// <remarks />
        public const string VibrateAndHeatType = "VibrateAndHeatType";

        /// <remarks />
        public const string VibrateHeat = "VibrateHeat";

        /// <remarks />
        public const string VMax = "VMax";

        /// <remarks />
        public const string VStart = "VStart";

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