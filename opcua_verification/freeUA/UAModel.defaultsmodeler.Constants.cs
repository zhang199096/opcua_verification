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

namespace UAModel.defaultsmodeler
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint msc_IOUints_ReadIO = 2081;

        /// <remarks />
        public const uint IOType_ReadIO = 2081;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint msc = 2004;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint SensorType = 2014;

        /// <remarks />
        public const uint MechineAxisType = 2019;

        /// <remarks />
        public const uint IOType = 2023;

        /// <remarks />
        public const uint LimitInfoType = 2028;

        /// <remarks />
        public const uint RunStatusType = 2033;

        /// <remarks />
        public const uint ControlEventType = 2039;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint msc_HeatUints_SampleAreaTemp1 = 2043;

        /// <remarks />
        public const uint msc_HeatUints_SampleAreaTemp2 = 2044;

        /// <remarks />
        public const uint msc_HeatUints_SampleAreaTemp3 = 2045;

        /// <remarks />
        public const uint msc_HeatUints_SampleAreaTemp4 = 2046;

        /// <remarks />
        public const uint msc_XUints_locationAxis = 2048;

        /// <remarks />
        public const uint msc_XUints_MachCoordAxis = 2049;

        /// <remarks />
        public const uint msc_XUints_feedRateAxis = 2050;

        /// <remarks />
        public const uint msc_YUints_locationAxis = 2052;

        /// <remarks />
        public const uint msc_YUints_MachCoordAxis = 2053;

        /// <remarks />
        public const uint msc_YUints_feedRateAxis = 2054;

        /// <remarks />
        public const uint msc_ZUints_locationAxis = 2056;

        /// <remarks />
        public const uint msc_ZUints_MachCoordAxis = 2057;

        /// <remarks />
        public const uint msc_ZUints_feedRateAxis = 2058;

        /// <remarks />
        public const uint msc_AUints_locationAxis = 2060;

        /// <remarks />
        public const uint msc_AUints_MachCoordAxis = 2061;

        /// <remarks />
        public const uint msc_AUints_feedRateAxis = 2062;

        /// <remarks />
        public const uint msc_IOUints_gpioIn1sigFlag = 2064;

        /// <remarks />
        public const uint msc_IOUints_gpioIn2sigFlag = 2065;

        /// <remarks />
        public const uint msc_IOUints_gpioOut1sigFlag = 2066;

        /// <remarks />
        public const uint msc_IOUints_gpioOut2sigFlag = 2067;

        /// <remarks />
        public const uint msc_IOUints_ReadIO_InputArguments = 2082;

        /// <remarks />
        public const uint msc_IOUints_ReadIO_OutputArguments = 2083;

        /// <remarks />
        public const uint msc_LimitInfoUints_postHardLimitFlag = 2069;

        /// <remarks />
        public const uint msc_LimitInfoUints_negtHardLimitFlag = 2070;

        /// <remarks />
        public const uint msc_LimitInfoUints_postSoftLimitFlag = 2071;

        /// <remarks />
        public const uint msc_LimitInfoUints_negtSoftLimitFlag = 2072;

        /// <remarks />
        public const uint msc_RunStatusUints_RunMode = 2074;

        /// <remarks />
        public const uint msc_RunStatusUints_RunCount = 2075;

        /// <remarks />
        public const uint msc_RunStatusUints_RcvCount = 2076;

        /// <remarks />
        public const uint msc_RunStatusUints_homeCmplFlag = 2077;

        /// <remarks />
        public const uint msc_RunStatusUints_dspAlarmFlag = 2078;

        /// <remarks />
        public const uint msc_RunTo_InputArguments = 2002;

        /// <remarks />
        public const uint msc_GetStatus_OutputArguments = 2005;

        /// <remarks />
        public const uint msc_Jog_InputArguments = 2007;

        /// <remarks />
        public const uint msc_WriteIO_InputArguments = 2009;

        /// <remarks />
        public const uint msc_ReadIO_InputArguments = 2011;

        /// <remarks />
        public const uint msc_ReadIO_OutputArguments = 2012;

        /// <remarks />
        public const uint msc_RunScript_InputArguments = 2079;

        /// <remarks />
        public const uint msc_RunScript_OutputArguments = 2080;

        /// <remarks />
        public const uint SensorType_SampleAreaTemp1 = 2015;

        /// <remarks />
        public const uint SensorType_SampleAreaTemp2 = 2016;

        /// <remarks />
        public const uint SensorType_SampleAreaTemp3 = 2017;

        /// <remarks />
        public const uint SensorType_SampleAreaTemp4 = 2018;

        /// <remarks />
        public const uint MechineAxisType_locationAxis = 2020;

        /// <remarks />
        public const uint MechineAxisType_MachCoordAxis = 2021;

        /// <remarks />
        public const uint MechineAxisType_feedRateAxis = 2022;

        /// <remarks />
        public const uint IOType_gpioIn1sigFlag = 2024;

        /// <remarks />
        public const uint IOType_gpioIn2sigFlag = 2025;

        /// <remarks />
        public const uint IOType_gpioOut1sigFlag = 2026;

        /// <remarks />
        public const uint IOType_gpioOut2sigFlag = 2027;

        /// <remarks />
        public const uint IOType_ReadIO_InputArguments = 2082;

        /// <remarks />
        public const uint IOType_ReadIO_OutputArguments = 2083;

        /// <remarks />
        public const uint LimitInfoType_postHardLimitFlag = 2029;

        /// <remarks />
        public const uint LimitInfoType_negtHardLimitFlag = 2030;

        /// <remarks />
        public const uint LimitInfoType_postSoftLimitFlag = 2031;

        /// <remarks />
        public const uint LimitInfoType_negtSoftLimitFlag = 2032;

        /// <remarks />
        public const uint RunStatusType_RunMode = 2034;

        /// <remarks />
        public const uint RunStatusType_RunCount = 2035;

        /// <remarks />
        public const uint RunStatusType_RcvCount = 2036;

        /// <remarks />
        public const uint RunStatusType_homeCmplFlag = 2037;

        /// <remarks />
        public const uint RunStatusType_dspAlarmFlag = 2038;

        /// <remarks />
        public const uint ControlEventType_temperature = 2040;

        /// <remarks />
        public const uint ControlEventType_MachCoordAxis = 2041;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId msc_IOUints_ReadIO = new ExpandedNodeId(UAModel.defaultsmodeler.Methods.msc_IOUints_ReadIO, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType_ReadIO = new ExpandedNodeId(UAModel.defaultsmodeler.Methods.IOType_ReadIO, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId msc = new ExpandedNodeId(UAModel.defaultsmodeler.Objects.msc, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId SensorType = new ExpandedNodeId(UAModel.defaultsmodeler.ObjectTypes.SensorType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId MechineAxisType = new ExpandedNodeId(UAModel.defaultsmodeler.ObjectTypes.MechineAxisType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType = new ExpandedNodeId(UAModel.defaultsmodeler.ObjectTypes.IOType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId LimitInfoType = new ExpandedNodeId(UAModel.defaultsmodeler.ObjectTypes.LimitInfoType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatusType = new ExpandedNodeId(UAModel.defaultsmodeler.ObjectTypes.RunStatusType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId ControlEventType = new ExpandedNodeId(UAModel.defaultsmodeler.ObjectTypes.ControlEventType, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId msc_HeatUints_SampleAreaTemp1 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_HeatUints_SampleAreaTemp1, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_HeatUints_SampleAreaTemp2 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_HeatUints_SampleAreaTemp2, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_HeatUints_SampleAreaTemp3 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_HeatUints_SampleAreaTemp3, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_HeatUints_SampleAreaTemp4 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_HeatUints_SampleAreaTemp4, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_XUints_locationAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_XUints_locationAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_XUints_MachCoordAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_XUints_MachCoordAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_XUints_feedRateAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_XUints_feedRateAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_YUints_locationAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_YUints_locationAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_YUints_MachCoordAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_YUints_MachCoordAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_YUints_feedRateAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_YUints_feedRateAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_ZUints_locationAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_ZUints_locationAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_ZUints_MachCoordAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_ZUints_MachCoordAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_ZUints_feedRateAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_ZUints_feedRateAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_AUints_locationAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_AUints_locationAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_AUints_MachCoordAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_AUints_MachCoordAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_AUints_feedRateAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_AUints_feedRateAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOUints_gpioIn1sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_IOUints_gpioIn1sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOUints_gpioIn2sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_IOUints_gpioIn2sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOUints_gpioOut1sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_IOUints_gpioOut1sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOUints_gpioOut2sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_IOUints_gpioOut2sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOUints_ReadIO_InputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_IOUints_ReadIO_InputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_IOUints_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_IOUints_ReadIO_OutputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LimitInfoUints_postHardLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_LimitInfoUints_postHardLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LimitInfoUints_negtHardLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_LimitInfoUints_negtHardLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LimitInfoUints_postSoftLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_LimitInfoUints_postSoftLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_LimitInfoUints_negtSoftLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_LimitInfoUints_negtSoftLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunStatusUints_RunMode = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunStatusUints_RunMode, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunStatusUints_RunCount = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunStatusUints_RunCount, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunStatusUints_RcvCount = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunStatusUints_RcvCount, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunStatusUints_homeCmplFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunStatusUints_homeCmplFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunStatusUints_dspAlarmFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunStatusUints_dspAlarmFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunTo_InputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunTo_InputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_GetStatus_OutputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_GetStatus_OutputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_Jog_InputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_Jog_InputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_WriteIO_InputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_WriteIO_InputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_ReadIO_InputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_ReadIO_InputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_ReadIO_OutputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunScript_InputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunScript_InputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId msc_RunScript_OutputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.msc_RunScript_OutputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_SampleAreaTemp1 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.SensorType_SampleAreaTemp1, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_SampleAreaTemp2 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.SensorType_SampleAreaTemp2, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_SampleAreaTemp3 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.SensorType_SampleAreaTemp3, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId SensorType_SampleAreaTemp4 = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.SensorType_SampleAreaTemp4, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId MechineAxisType_locationAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.MechineAxisType_locationAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId MechineAxisType_MachCoordAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.MechineAxisType_MachCoordAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId MechineAxisType_feedRateAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.MechineAxisType_feedRateAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType_gpioIn1sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.IOType_gpioIn1sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType_gpioIn2sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.IOType_gpioIn2sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType_gpioOut1sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.IOType_gpioOut1sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType_gpioOut2sigFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.IOType_gpioOut2sigFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType_ReadIO_InputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.IOType_ReadIO_InputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId IOType_ReadIO_OutputArguments = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.IOType_ReadIO_OutputArguments, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId LimitInfoType_postHardLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.LimitInfoType_postHardLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId LimitInfoType_negtHardLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.LimitInfoType_negtHardLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId LimitInfoType_postSoftLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.LimitInfoType_postSoftLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId LimitInfoType_negtSoftLimitFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.LimitInfoType_negtSoftLimitFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatusType_RunMode = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.RunStatusType_RunMode, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatusType_RunCount = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.RunStatusType_RunCount, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatusType_RcvCount = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.RunStatusType_RcvCount, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatusType_homeCmplFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.RunStatusType_homeCmplFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId RunStatusType_dspAlarmFlag = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.RunStatusType_dspAlarmFlag, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId ControlEventType_temperature = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.ControlEventType_temperature, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);

        /// <remarks />
        public static readonly ExpandedNodeId ControlEventType_MachCoordAxis = new ExpandedNodeId(UAModel.defaultsmodeler.Variables.ControlEventType_MachCoordAxis, UAModel.defaultsmodeler.Namespaces.defaultsmodeler);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AUints = "AUints";

        /// <remarks />
        public const string ControlEventType = "ControlEventType";

        /// <remarks />
        public const string dspAlarmFlag = "dspAlarmFlag";

        /// <remarks />
        public const string feedRateAxis = "feedRateAxis";

        /// <remarks />
        public const string GetStatus = "GetStatus";

        /// <remarks />
        public const string gpioIn1sigFlag = "gpioIn1sigFlag";

        /// <remarks />
        public const string gpioIn2sigFlag = "gpioIn2sigFlag";

        /// <remarks />
        public const string gpioOut1sigFlag = "gpioOut1sigFlag";

        /// <remarks />
        public const string gpioOut2sigFlag = "gpioOut2sigFlag";

        /// <remarks />
        public const string HeatUints = "HeatUints";

        /// <remarks />
        public const string homeCmplFlag = "homeCmplFlag";

        /// <remarks />
        public const string IOType = "IOType";

        /// <remarks />
        public const string IOUints = "IOUints";

        /// <remarks />
        public const string Jog = "Jog";

        /// <remarks />
        public const string LimitInfoType = "LimitInfoType";

        /// <remarks />
        public const string LimitInfoUints = "LimitInfoUints";

        /// <remarks />
        public const string locationAxis = "locationAxis";

        /// <remarks />
        public const string MachCoordAxis = "MachCoordAxis";

        /// <remarks />
        public const string MechineAxisType = "MechineAxisType";

        /// <remarks />
        public const string msc = "msc";

        /// <remarks />
        public const string negtHardLimitFlag = "negtHardLimitFlag";

        /// <remarks />
        public const string negtSoftLimitFlag = "negtSoftLimitFlag";

        /// <remarks />
        public const string postHardLimitFlag = "postHardLimitFlag";

        /// <remarks />
        public const string postSoftLimitFlag = "postSoftLimitFlag";

        /// <remarks />
        public const string RcvCount = "RcvCount";

        /// <remarks />
        public const string ReadIO = "ReadIO";

        /// <remarks />
        public const string RunCount = "RunCount";

        /// <remarks />
        public const string RunMode = "RunMode";

        /// <remarks />
        public const string RunScript = "RunScript";

        /// <remarks />
        public const string RunStatusType = "RunStatusType";

        /// <remarks />
        public const string RunStatusUints = "RunStatusUints";

        /// <remarks />
        public const string RunTo = "RunTo";

        /// <remarks />
        public const string SampleAreaTemp1 = "SampleAreaTemp1";

        /// <remarks />
        public const string SampleAreaTemp2 = "SampleAreaTemp2";

        /// <remarks />
        public const string SampleAreaTemp3 = "SampleAreaTemp3";

        /// <remarks />
        public const string SampleAreaTemp4 = "SampleAreaTemp4";

        /// <remarks />
        public const string SensorType = "SensorType";

        /// <remarks />
        public const string temperature = "temperature";

        /// <remarks />
        public const string WriteIO = "WriteIO";

        /// <remarks />
        public const string XUints = "XUints";

        /// <remarks />
        public const string YUints = "YUints";

        /// <remarks />
        public const string ZUints = "ZUints";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the defaultsmodeler namespace (.NET code namespace is 'UAModel.defaultsmodeler').
        /// </summary>
        public const string defaultsmodeler = "http://freeopcua/defaults/modeler";

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