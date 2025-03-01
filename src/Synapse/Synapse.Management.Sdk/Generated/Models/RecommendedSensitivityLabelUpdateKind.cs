// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{

    /// <summary>
    /// Defines values for RecommendedSensitivityLabelUpdateKind.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecommendedSensitivityLabelUpdateKind
    {
        [System.Runtime.Serialization.EnumMember(Value = "enable")]
        Enable,
        [System.Runtime.Serialization.EnumMember(Value = "disable")]
        Disable
    }
    internal static class RecommendedSensitivityLabelUpdateKindEnumExtension
    {
        internal static string ToSerializedValue(this RecommendedSensitivityLabelUpdateKind? value)
        {
            return value == null ? null : ((RecommendedSensitivityLabelUpdateKind)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this RecommendedSensitivityLabelUpdateKind value)
        {
            switch( value )
            {
                case RecommendedSensitivityLabelUpdateKind.Enable:
                    return "enable";
                case RecommendedSensitivityLabelUpdateKind.Disable:
                    return "disable";
            }
            return null;
        }
        internal static RecommendedSensitivityLabelUpdateKind? ParseRecommendedSensitivityLabelUpdateKind(this string value)
        {
            switch( value )
            {
                case "enable":
                    return RecommendedSensitivityLabelUpdateKind.Enable;
                case "disable":
                    return RecommendedSensitivityLabelUpdateKind.Disable;
            }
            return null;
        }
    }
}