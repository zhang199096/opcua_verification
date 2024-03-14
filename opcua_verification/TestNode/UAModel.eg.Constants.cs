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

namespace UAModel.eg
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint AxisType_Jog = 7004;

        /// <remarks />
        public const uint IO_ReadIO = 7002;

        /// <remarks />
        public const uint IO_WriteIO = 7003;

        /// <remarks />
        public const uint Laser_Ctrlopen = 7028;

        /// <remarks />
        public const uint mschub_Axisx_Jog = 7005;

        /// <remarks />
        public const uint mschub_Axisy_Jog = 7006;

        /// <remarks />
        public const uint mschub_Axisz_Jog = 7007;

        /// <remarks />
        public const uint mschub_Init = 7012;

        /// <remarks />
        public const uint mschub_IOuint_ReadIO = 7009;

        /// <remarks />
        public const uint mschub_IOuint_WriteIO = 7010;

        /// <remarks />
        public const uint mschub_LaserUint_Ctrlopen = 7029;

        /// <remarks />
        public const uint mschub_Reset = 7011;

        /// <remarks />
        public const uint mschub_Runscript = 7013;

        /// <remarks />
        public const uint mschub_Runto = 7023;

        /// <remarks />
        public const uint mschub_Sensor_getSensor = 7008;

        /// <remarks />
        public const uint mschub_Status_Setzero = 7026;

        /// <remarks />
        public const uint RunStatus_Setzero = 7025;

        /// <remarks />
        public const uint Sensor_getSensor = 7001;

        /// <remarks />
        public const uint msc_Axisx_Jog = 7014;

        /// <remarks />
        public const uint msc_Axisy_Jog = 7015;

        /// <remarks />
        public const uint msc_Axisz_Jog = 7016;

        /// <remarks />
        public const uint msc_Init = 7017;

        /// <remarks />
        public const uint msc_IOuint_ReadIO = 7018;

        /// <remarks />
        public const uint msc_IOuint_WriteIO = 7019;

        /// <remarks />
        public const uint msc_LaserUint_Ctrlopen = 7030;

        /// <remarks />
        public const uint msc_Reset = 7020;

        /// <remarks />
        public const uint msc_Runscript = 7021;

        /// <remarks />
        public const uint msc_Runto = 7024;

        /// <remarks />
        public const uint msc_Sensor_getSensor = 7022;

        /// <remarks />
        public const uint msc_Status_Setzero = 7027;

        /// <remarks />
        public const string AxisType_JogMethodType = "";

        /// <remarks />
        public const string IO_ReadIOMethodType = "";

        /// <remarks />
        public const string IO_WriteIOMethodType = "";

        /// <remarks />
        public const string mschub_RunscriptMethodType = "";

        /// <remarks />
        public const string mschub_RuntoMethodType = "";

        /// <remarks />
        public const string Sensor_getSensorMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint mschub_Axisx = 5001;

        /// <remarks />
        public const uint mschub_Axisy = 5002;

        /// <remarks />
        public const uint mschub_Axisz = 5003;

        /// <remarks />
        public const uint mschub_IOuint = 5005;

        /// <remarks />
        public const uint mschub_LaserUint = 5015;

        /// <remarks />
        public const uint mschub_Sensor = 5004;

        /// <remarks />
        public const uint mschub_Status = 5013;

        /// <remarks />
        public const uint msc = 5008;

        /// <remarks />
        public const uint msc_Axisx = 5007;

        /// <remarks />
        public const uint msc_Axisy = 5009;

        /// <remarks />
        public const uint msc_Axisz = 5010;

        /// <remarks />
        public const uint msc_IOuint = 5011;

        /// <remarks />
        public const uint msc_LaserUint = 5016;

        /// <remarks />
        public const uint msc_Sensor = 5012;

        /// <remarks />
        public const uint msc_Status = 5014;

        /// <remarks />
        public const uint http___yourorganisation_org_eg_ = 5006;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint AxisType = 1004;

        /// <remarks />
        public const uint TempControlEvent = 1008;

        /// <remarks />
        public const uint IO = 1003;

        /// <remarks />
        public const uint Laser = 1007;

        /// <remarks />
        public const uint mschub = 1005;

        /// <remarks />
        public const uint RunStatus = 1006;

        /// <remarks />
        public const uint Sensor = 1002;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint AxisType_Coordvalue = 6012;

        /// <remarks />
        public const uint AxisType_Jog_InputArguments = 6014;

        /// <remarks />
        public const uint AxisType_machivalue = 6011;

        /// <remarks />
        public const uint AxisType_Speed = 6013;

        /// <remarks />
        public const uint TempControlEvent_machcoords = 6099;

        /// <remarks />
        public const uint TempControlEvent_temp = 6100;

        /// <remarks />
        public const uint IO_input1 = 6004;

        /// <remarks />
        public const uint IO_input2 = 6005;

        /// <remarks />
        public const uint IO_out1 = 6006;

        /// <remarks />
        public const uint IO_out2 = 6007;

        /// <remarks />
        public const uint IO_ReadIO_InputArguments = 6008;

        /// <remarks />
        public const uint IO_ReadIO_OutputArguments = 6009;

        /// <remarks />
        public const uint IO_WriteIO_InputArguments = 6010;

        /// <remarks />
        public const uint Laser_intension = 6093;

        /// <remarks />
        public const uint Laser_vol = 6094;

        /// <remarks />
        public const uint mschub_Axisx_Coordvalue = 6015;

        /// <remarks />
        public const uint mschub_Axisx_Jog_InputArguments = 6016;

        /// <remarks />
        public const uint mschub_Axisx_machivalue = 6017;

        /// <remarks />
        public const uint mschub_Axisx_Speed = 6018;

        /// <remarks />
        public const uint mschub_Axisy_Coordvalue = 6019;

        /// <remarks />
        public const uint mschub_Axisy_Jog_InputArguments = 6020;

        /// <remarks />
        public const uint mschub_Axisy_machivalue = 6021;

        /// <remarks />
        public const uint mschub_Axisy_Speed = 6022;

        /// <remarks />
        public const uint mschub_Axisz_Coordvalue = 6023;

        /// <remarks />
        public const uint mschub_Axisz_Jog_InputArguments = 6024;

        /// <remarks />
        public const uint mschub_Axisz_machivalue = 6025;

        /// <remarks />
        public const uint mschub_Axisz_Speed = 6026;

        /// <remarks />
        public const uint mschub_IOuint_input1 = 6030;

        /// <remarks />
        public const uint mschub_IOuint_input2 = 6031;

        /// <remarks />
        public const uint mschub_IOuint_out1 = 6032;

        /// <remarks />
        public const uint mschub_IOuint_out2 = 6033;

        /// <remarks />
        public const uint mschub_IOuint_ReadIO_InputArguments = 6034;

        /// <remarks />
        public const uint mschub_IOuint_ReadIO_OutputArguments = 6035;

        /// <remarks />
        public const uint mschub_IOuint_WriteIO_InputArguments = 6036;

        /// <remarks />
        public const uint mschub_LaserUint_intension = 6095;

        /// <remarks />
        public const uint mschub_LaserUint_vol = 6096;

        /// <remarks />
        public const uint mschub_Runscript_InputArguments = 6037;

        /// <remarks />
        public const uint mschub_Runscript_OutputArguments = 6038;

        /// <remarks />
        public const uint mschub_Runto_InputArguments = 6070;

        /// <remarks />
        public const uint mschub_Sensor_getSensor_OutputArguments = 6027;

        /// <remarks />
        public const uint mschub_Sensor_Humi = 6028;

        /// <remarks />
        public const uint mschub_Sensor_temp = 6029;

        /// <remarks />
        public const uint mschub_Status_dspAlarmflag = 6079;

        /// <remarks />
        public const uint mschub_Status_Homeflag = 6080;

        /// <remarks />
        public const uint mschub_Status_LimitNeg = 6081;

        /// <remarks />
        public const uint mschub_Status_LimitPos = 6082;

        /// <remarks />
        public const uint mschub_Status_RecvCount = 6083;

        /// <remarks />
        public const uint mschub_Status_Runcount = 6084;

        /// <remarks />
        public const uint mschub_Status_Runstatus = 6085;

        /// <remarks />
        public const uint RunStatus_dspAlarmflag = 6078;

        /// <remarks />
        public const uint RunStatus_Homeflag = 6075;

        /// <remarks />
        public const uint RunStatus_LimitNeg = 6077;

        /// <remarks />
        public const uint RunStatus_LimitPos = 6076;

        /// <remarks />
        public const uint RunStatus_RecvCount = 6074;

        /// <remarks />
        public const uint RunStatus_Runcount = 6073;

        /// <remarks />
        public const uint RunStatus_Runstatus = 6072;

        /// <remarks />
        public const uint Sensor_getSensor_OutputArguments = 6003;

        /// <remarks />
        public const uint Sensor_Humi = 6002;

        /// <remarks />
        public const uint Sensor_temp = 6001;

        /// <remarks />
        public const uint msc_Axisx_Coordvalue = 6046;

        /// <remarks />
        public const uint msc_Axisx_Jog_InputArguments = 6047;

        /// <remarks />
        public const uint msc_Axisx_machivalue = 6048;

        /// <remarks />
        public const uint msc_Axisx_Speed = 6049;

        /// <remarks />
        public const uint msc_Axisy_Coordvalue = 6050;

        /// <remarks />
        public const uint msc_Axisy_Jog_InputArguments = 6051;

        /// <remarks />
        public const uint msc_Axisy_machivalue = 6052;

        /// <remarks />
        public const uint msc_Axisy_Speed = 6053;

        /// <remarks />
        public const uint msc_Axisz_Coordvalue = 6054;

        /// <remarks />
        public const uint msc_Axisz_Jog_InputArguments = 6055;

        /// <remarks />
        public const uint msc_Axisz_machivalue = 6056;

        /// <remarks />
        public const uint msc_Axisz_Speed = 6057;

        /// <remarks />
        public const uint msc_IOuint_input1 = 6058;

        /// <remarks />
        public const uint msc_IOuint_input2 = 6059;

        /// <remarks />
        public const uint msc_IOuint_out1 = 6060;

        /// <remarks />
        public const uint msc_IOuint_out2 = 6061;

        /// <remarks />
        public const uint msc_IOuint_ReadIO_InputArguments = 6062;

        /// <remarks />
        public const uint msc_IOuint_ReadIO_OutputArguments = 6063;

        /// <remarks />
        public const uint msc_IOuint_WriteIO_InputArguments = 6064;

        /// <remarks />
        public const uint msc_LaserUint_intension = 6097;

        /// <remarks />
        public const uint msc_LaserUint_vol = 6098;

        /// <remarks />
        public const uint msc_Runscript_InputArguments = 6065;

        /// <remarks />
        public const uint msc_Runscript_OutputArguments = 6066;

        /// <remarks />
        public const uint msc_Runto_InputArguments = 6071;

        /// <remarks />
        public const uint msc_Sensor_getSensor_OutputArguments = 6067;

        /// <remarks />
        public const uint msc_Sensor_Humi = 6068;

        /// <remarks />
        public const uint msc_Sensor_temp = 6069;

        /// <remarks />
        public const uint msc_Status_dspAlarmflag = 6086;

        /// <remarks />
        public const uint msc_Status_Homeflag = 6087;

        /// <remarks />
        public const uint msc_Status_LimitNeg = 6088;

        /// <remarks />
        public const uint msc_Status_LimitPos = 6089;

        /// <remarks />
        public const uint msc_Status_RecvCount = 6090;

        /// <remarks />
        public const uint msc_Status_Runcount = 6091;

        /// <remarks />
        public const uint msc_Status_Runstatus = 6092;

        /// <remarks />
        public const uint http___yourorganisation_org_eg__NamespaceUri = 6041;

        /// <remarks />
        public const uint http___yourorganisation_org_eg__NamespaceVersion = 6042;

        /// <remarks />
        public const uint http___yourorganisation_org_eg__NamespacePublicationDate = 6040;

        /// <remarks />
        public const uint http___yourorganisation_org_eg__IsNamespaceSubset = 6039;

        /// <remarks />
        public const uint http___yourorganisation_org_eg__StaticNodeIdTypes = 6043;

        /// <remarks />
        public const uint http___yourorganisation_org_eg__StaticNumericNodeIdRange = 6044;

        /// <remarks />
        public const uint http___yourorganisation_org_eg__StaticStringNodeIdPattern = 6045;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AxisType_Jog = new ExpandedNodeId(UAModel.eg.Methods.AxisType_Jog, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_ReadIO = new ExpandedNodeId(UAModel.eg.Methods.IO_ReadIO, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_WriteIO = new ExpandedNodeId(UAModel.eg.Methods.IO_WriteIO, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Laser_Ctrlopen = new ExpandedNodeId(UAModel.eg.Methods.Laser_Ctrlopen, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisx_Jog = new ExpandedNodeId(UAModel.eg.Methods.mschub_Axisx_Jog, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisy_Jog = new ExpandedNodeId(UAModel.eg.Methods.mschub_Axisy_Jog, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisz_Jog = new ExpandedNodeId(UAModel.eg.Methods.mschub_Axisz_Jog, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Init = new ExpandedNodeId(UAModel.eg.Methods.mschub_Init, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_ReadIO = new ExpandedNodeId(UAModel.eg.Methods.mschub_IOuint_ReadIO, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_WriteIO = new ExpandedNodeId(UAModel.eg.Methods.mschub_IOuint_WriteIO, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_LaserUint_Ctrlopen = new ExpandedNodeId(UAModel.eg.Methods.mschub_LaserUint_Ctrlopen, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Reset = new ExpandedNodeId(UAModel.eg.Methods.mschub_Reset, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Runscript = new ExpandedNodeId(UAModel.eg.Methods.mschub_Runscript, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Runto = new ExpandedNodeId(UAModel.eg.Methods.mschub_Runto, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Sensor_getSensor = new ExpandedNodeId(UAModel.eg.Methods.mschub_Sensor_getSensor, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_Setzero = new ExpandedNodeId(UAModel.eg.Methods.mschub_Status_Setzero, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_Setzero = new ExpandedNodeId(UAModel.eg.Methods.RunStatus_Setzero, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Sensor_getSensor = new ExpandedNodeId(UAModel.eg.Methods.Sensor_getSensor, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisx_Jog = new ExpandedNodeId(UAModel.eg.Methods.msc_Axisx_Jog, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisy_Jog = new ExpandedNodeId(UAModel.eg.Methods.msc_Axisy_Jog, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisz_Jog = new ExpandedNodeId(UAModel.eg.Methods.msc_Axisz_Jog, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Init = new ExpandedNodeId(UAModel.eg.Methods.msc_Init, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_ReadIO = new ExpandedNodeId(UAModel.eg.Methods.msc_IOuint_ReadIO, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_WriteIO = new ExpandedNodeId(UAModel.eg.Methods.msc_IOuint_WriteIO, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LaserUint_Ctrlopen = new ExpandedNodeId(UAModel.eg.Methods.msc_LaserUint_Ctrlopen, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Reset = new ExpandedNodeId(UAModel.eg.Methods.msc_Reset, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Runscript = new ExpandedNodeId(UAModel.eg.Methods.msc_Runscript, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Runto = new ExpandedNodeId(UAModel.eg.Methods.msc_Runto, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Sensor_getSensor = new ExpandedNodeId(UAModel.eg.Methods.msc_Sensor_getSensor, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_Setzero = new ExpandedNodeId(UAModel.eg.Methods.msc_Status_Setzero, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId AxisType_JogMethodType = new ExpandedNodeId(UAModel.eg.Methods.AxisType_JogMethodType, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_ReadIOMethodType = new ExpandedNodeId(UAModel.eg.Methods.IO_ReadIOMethodType, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_WriteIOMethodType = new ExpandedNodeId(UAModel.eg.Methods.IO_WriteIOMethodType, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_RunscriptMethodType = new ExpandedNodeId(UAModel.eg.Methods.mschub_RunscriptMethodType, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_RuntoMethodType = new ExpandedNodeId(UAModel.eg.Methods.mschub_RuntoMethodType, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Sensor_getSensorMethodType = new ExpandedNodeId(UAModel.eg.Methods.Sensor_getSensorMethodType, UAModel.eg.Namespaces.eg);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisx = new ExpandedNodeId(UAModel.eg.Objects.mschub_Axisx, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisy = new ExpandedNodeId(UAModel.eg.Objects.mschub_Axisy, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisz = new ExpandedNodeId(UAModel.eg.Objects.mschub_Axisz, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint = new ExpandedNodeId(UAModel.eg.Objects.mschub_IOuint, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_LaserUint = new ExpandedNodeId(UAModel.eg.Objects.mschub_LaserUint, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Sensor = new ExpandedNodeId(UAModel.eg.Objects.mschub_Sensor, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status = new ExpandedNodeId(UAModel.eg.Objects.mschub_Status, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc = new ExpandedNodeId(UAModel.eg.Objects.msc, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisx = new ExpandedNodeId(UAModel.eg.Objects.msc_Axisx, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisy = new ExpandedNodeId(UAModel.eg.Objects.msc_Axisy, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisz = new ExpandedNodeId(UAModel.eg.Objects.msc_Axisz, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint = new ExpandedNodeId(UAModel.eg.Objects.msc_IOuint, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LaserUint = new ExpandedNodeId(UAModel.eg.Objects.msc_LaserUint, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Sensor = new ExpandedNodeId(UAModel.eg.Objects.msc_Sensor, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status = new ExpandedNodeId(UAModel.eg.Objects.msc_Status, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg_ = new ExpandedNodeId(UAModel.eg.Objects.http___yourorganisation_org_eg_, UAModel.eg.Namespaces.eg);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AxisType = new ExpandedNodeId(UAModel.eg.ObjectTypes.AxisType, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId TempControlEvent = new ExpandedNodeId(UAModel.eg.ObjectTypes.TempControlEvent, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO = new ExpandedNodeId(UAModel.eg.ObjectTypes.IO, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Laser = new ExpandedNodeId(UAModel.eg.ObjectTypes.Laser, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub = new ExpandedNodeId(UAModel.eg.ObjectTypes.mschub, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus = new ExpandedNodeId(UAModel.eg.ObjectTypes.RunStatus, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Sensor = new ExpandedNodeId(UAModel.eg.ObjectTypes.Sensor, UAModel.eg.Namespaces.eg);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AxisType_Coordvalue = new ExpandedNodeId(UAModel.eg.Variables.AxisType_Coordvalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId AxisType_Jog_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.AxisType_Jog_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId AxisType_machivalue = new ExpandedNodeId(UAModel.eg.Variables.AxisType_machivalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId AxisType_Speed = new ExpandedNodeId(UAModel.eg.Variables.AxisType_Speed, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId TempControlEvent_machcoords = new ExpandedNodeId(UAModel.eg.Variables.TempControlEvent_machcoords, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId TempControlEvent_temp = new ExpandedNodeId(UAModel.eg.Variables.TempControlEvent_temp, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_input1 = new ExpandedNodeId(UAModel.eg.Variables.IO_input1, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_input2 = new ExpandedNodeId(UAModel.eg.Variables.IO_input2, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_out1 = new ExpandedNodeId(UAModel.eg.Variables.IO_out1, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_out2 = new ExpandedNodeId(UAModel.eg.Variables.IO_out2, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_ReadIO_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.IO_ReadIO_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.IO_ReadIO_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId IO_WriteIO_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.IO_WriteIO_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Laser_intension = new ExpandedNodeId(UAModel.eg.Variables.Laser_intension, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Laser_vol = new ExpandedNodeId(UAModel.eg.Variables.Laser_vol, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisx_Coordvalue = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisx_Coordvalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisx_Jog_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisx_Jog_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisx_machivalue = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisx_machivalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisx_Speed = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisx_Speed, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisy_Coordvalue = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisy_Coordvalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisy_Jog_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisy_Jog_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisy_machivalue = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisy_machivalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisy_Speed = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisy_Speed, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisz_Coordvalue = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisz_Coordvalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisz_Jog_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisz_Jog_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisz_machivalue = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisz_machivalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Axisz_Speed = new ExpandedNodeId(UAModel.eg.Variables.mschub_Axisz_Speed, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_input1 = new ExpandedNodeId(UAModel.eg.Variables.mschub_IOuint_input1, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_input2 = new ExpandedNodeId(UAModel.eg.Variables.mschub_IOuint_input2, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_out1 = new ExpandedNodeId(UAModel.eg.Variables.mschub_IOuint_out1, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_out2 = new ExpandedNodeId(UAModel.eg.Variables.mschub_IOuint_out2, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_IOuint_ReadIO_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_IOuint_ReadIO_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_IOuint_WriteIO_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_IOuint_WriteIO_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_LaserUint_intension = new ExpandedNodeId(UAModel.eg.Variables.mschub_LaserUint_intension, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_LaserUint_vol = new ExpandedNodeId(UAModel.eg.Variables.mschub_LaserUint_vol, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Runscript_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_Runscript_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Runscript_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_Runscript_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Runto_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_Runto_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Sensor_getSensor_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.mschub_Sensor_getSensor_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Sensor_Humi = new ExpandedNodeId(UAModel.eg.Variables.mschub_Sensor_Humi, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Sensor_temp = new ExpandedNodeId(UAModel.eg.Variables.mschub_Sensor_temp, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_dspAlarmflag = new ExpandedNodeId(UAModel.eg.Variables.mschub_Status_dspAlarmflag, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_Homeflag = new ExpandedNodeId(UAModel.eg.Variables.mschub_Status_Homeflag, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_LimitNeg = new ExpandedNodeId(UAModel.eg.Variables.mschub_Status_LimitNeg, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_LimitPos = new ExpandedNodeId(UAModel.eg.Variables.mschub_Status_LimitPos, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_RecvCount = new ExpandedNodeId(UAModel.eg.Variables.mschub_Status_RecvCount, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_Runcount = new ExpandedNodeId(UAModel.eg.Variables.mschub_Status_Runcount, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId mschub_Status_Runstatus = new ExpandedNodeId(UAModel.eg.Variables.mschub_Status_Runstatus, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_dspAlarmflag = new ExpandedNodeId(UAModel.eg.Variables.RunStatus_dspAlarmflag, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_Homeflag = new ExpandedNodeId(UAModel.eg.Variables.RunStatus_Homeflag, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_LimitNeg = new ExpandedNodeId(UAModel.eg.Variables.RunStatus_LimitNeg, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_LimitPos = new ExpandedNodeId(UAModel.eg.Variables.RunStatus_LimitPos, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_RecvCount = new ExpandedNodeId(UAModel.eg.Variables.RunStatus_RecvCount, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_Runcount = new ExpandedNodeId(UAModel.eg.Variables.RunStatus_Runcount, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatus_Runstatus = new ExpandedNodeId(UAModel.eg.Variables.RunStatus_Runstatus, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Sensor_getSensor_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.Sensor_getSensor_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Sensor_Humi = new ExpandedNodeId(UAModel.eg.Variables.Sensor_Humi, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId Sensor_temp = new ExpandedNodeId(UAModel.eg.Variables.Sensor_temp, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisx_Coordvalue = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisx_Coordvalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisx_Jog_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisx_Jog_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisx_machivalue = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisx_machivalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisx_Speed = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisx_Speed, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisy_Coordvalue = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisy_Coordvalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisy_Jog_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisy_Jog_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisy_machivalue = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisy_machivalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisy_Speed = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisy_Speed, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisz_Coordvalue = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisz_Coordvalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisz_Jog_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisz_Jog_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisz_machivalue = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisz_machivalue, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Axisz_Speed = new ExpandedNodeId(UAModel.eg.Variables.msc_Axisz_Speed, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_input1 = new ExpandedNodeId(UAModel.eg.Variables.msc_IOuint_input1, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_input2 = new ExpandedNodeId(UAModel.eg.Variables.msc_IOuint_input2, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_out1 = new ExpandedNodeId(UAModel.eg.Variables.msc_IOuint_out1, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_out2 = new ExpandedNodeId(UAModel.eg.Variables.msc_IOuint_out2, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_ReadIO_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_IOuint_ReadIO_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_IOuint_ReadIO_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOuint_WriteIO_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_IOuint_WriteIO_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LaserUint_intension = new ExpandedNodeId(UAModel.eg.Variables.msc_LaserUint_intension, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LaserUint_vol = new ExpandedNodeId(UAModel.eg.Variables.msc_LaserUint_vol, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Runscript_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_Runscript_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Runscript_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_Runscript_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Runto_InputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_Runto_InputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Sensor_getSensor_OutputArguments = new ExpandedNodeId(UAModel.eg.Variables.msc_Sensor_getSensor_OutputArguments, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Sensor_Humi = new ExpandedNodeId(UAModel.eg.Variables.msc_Sensor_Humi, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Sensor_temp = new ExpandedNodeId(UAModel.eg.Variables.msc_Sensor_temp, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_dspAlarmflag = new ExpandedNodeId(UAModel.eg.Variables.msc_Status_dspAlarmflag, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_Homeflag = new ExpandedNodeId(UAModel.eg.Variables.msc_Status_Homeflag, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_LimitNeg = new ExpandedNodeId(UAModel.eg.Variables.msc_Status_LimitNeg, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_LimitPos = new ExpandedNodeId(UAModel.eg.Variables.msc_Status_LimitPos, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_RecvCount = new ExpandedNodeId(UAModel.eg.Variables.msc_Status_RecvCount, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_Runcount = new ExpandedNodeId(UAModel.eg.Variables.msc_Status_Runcount, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Status_Runstatus = new ExpandedNodeId(UAModel.eg.Variables.msc_Status_Runstatus, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg__NamespaceUri = new ExpandedNodeId(UAModel.eg.Variables.http___yourorganisation_org_eg__NamespaceUri, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg__NamespaceVersion = new ExpandedNodeId(UAModel.eg.Variables.http___yourorganisation_org_eg__NamespaceVersion, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg__NamespacePublicationDate = new ExpandedNodeId(UAModel.eg.Variables.http___yourorganisation_org_eg__NamespacePublicationDate, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg__IsNamespaceSubset = new ExpandedNodeId(UAModel.eg.Variables.http___yourorganisation_org_eg__IsNamespaceSubset, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg__StaticNodeIdTypes = new ExpandedNodeId(UAModel.eg.Variables.http___yourorganisation_org_eg__StaticNodeIdTypes, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg__StaticNumericNodeIdRange = new ExpandedNodeId(UAModel.eg.Variables.http___yourorganisation_org_eg__StaticNumericNodeIdRange, UAModel.eg.Namespaces.eg);

        /// <remarks />
        public static readonly ExpandedNodeId http___yourorganisation_org_eg__StaticStringNodeIdPattern = new ExpandedNodeId(UAModel.eg.Variables.http___yourorganisation_org_eg__StaticStringNodeIdPattern, UAModel.eg.Namespaces.eg);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AxisType = "AxisType";

        /// <remarks />
        public const string Axisx = "Axisx";

        /// <remarks />
        public const string Axisy = "Axisy";

        /// <remarks />
        public const string Axisz = "Axisz";

        /// <remarks />
        public const string Coordvalue = "Coordvalue";

        /// <remarks />
        public const string Ctrlopen = "Ctrlopen";

        /// <remarks />
        public const string dspAlarmflag = "dspAlarmflag";

        /// <remarks />
        public const string getSensor = "getSensor";

        /// <remarks />
        public const string getSensorMethodType = "getSensorMethodType";

        /// <remarks />
        public const string Homeflag = "Homeflag";

        /// <remarks />
        public const string http___yourorganisation_org_eg_ = "http://yourorganisation.org/eg/";

        /// <remarks />
        public const string Humi = "Humi";

        /// <remarks />
        public const string Init = "Init";

        /// <remarks />
        public const string input1 = "input1";

        /// <remarks />
        public const string input2 = "input2";

        /// <remarks />
        public const string intension = "intension";

        /// <remarks />
        public const string IO = "IO";

        /// <remarks />
        public const string IOuint = "IOuint";

        /// <remarks />
        public const string Jog = "Jog";

        /// <remarks />
        public const string JogMethodType = "JogMethodType";

        /// <remarks />
        public const string Laser = "Laser";

        /// <remarks />
        public const string LaserUint = "LaserUint";

        /// <remarks />
        public const string LimitNeg = "LimitNeg";

        /// <remarks />
        public const string LimitPos = "LimitPos";

        /// <remarks />
        public const string machcoords = "machcoords";

        /// <remarks />
        public const string machivalue = "machivalue";

        /// <remarks />
        public const string msc = "msc";

        /// <remarks />
        public const string mschub = "mschub";

        /// <remarks />
        public const string out1 = "out1";

        /// <remarks />
        public const string out2 = "out2";

        /// <remarks />
        public const string ReadIO = "ReadIO";

        /// <remarks />
        public const string ReadIOMethodType = "ReadIOMethodType";

        /// <remarks />
        public const string RecvCount = "RecvCount";

        /// <remarks />
        public const string Reset = "Reset";

        /// <remarks />
        public const string Runcount = "Runcount";

        /// <remarks />
        public const string Runscript = "Runscript";

        /// <remarks />
        public const string RunscriptMethodType = "RunscriptMethodType";

        /// <remarks />
        public const string Runstatus = "Runstatus";

        /// <remarks />
        public const string RunStatus = "RunStatus";

        /// <remarks />
        public const string Runto = "Runto";

        /// <remarks />
        public const string RuntoMethodType = "RuntoMethodType";

        /// <remarks />
        public const string Sensor = "Sensor";

        /// <remarks />
        public const string Setzero = "Setzero";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string Status = "Status";

        /// <remarks />
        public const string temp = "temp";

        /// <remarks />
        public const string TempControlEvent = "TempControlEvent";

        /// <remarks />
        public const string vol = "vol";

        /// <remarks />
        public const string WriteIO = "WriteIO";

        /// <remarks />
        public const string WriteIOMethodType = "WriteIOMethodType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the eg namespace (.NET code namespace is 'UAModel.eg').
        /// </summary>
        public const string eg = "http://yourorganisation.org/eg/";

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