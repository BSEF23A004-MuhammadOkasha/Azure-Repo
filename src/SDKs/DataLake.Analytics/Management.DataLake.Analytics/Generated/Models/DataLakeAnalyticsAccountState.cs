// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataLakeAnalyticsAccountState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataLakeAnalyticsAccountState
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Suspended")]
        Suspended
    }
    internal static class DataLakeAnalyticsAccountStateEnumExtension
    {
        internal static string ToSerializedValue(this DataLakeAnalyticsAccountState? value)
        {
            return value == null ? null : ((DataLakeAnalyticsAccountState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DataLakeAnalyticsAccountState value)
        {
            switch( value )
            {
                case DataLakeAnalyticsAccountState.Active:
                    return "Active";
                case DataLakeAnalyticsAccountState.Suspended:
                    return "Suspended";
            }
            return null;
        }

        internal static DataLakeAnalyticsAccountState? ParseDataLakeAnalyticsAccountState(this string value)
        {
            switch( value )
            {
                case "Active":
                    return DataLakeAnalyticsAccountState.Active;
                case "Suspended":
                    return DataLakeAnalyticsAccountState.Suspended;
            }
            return null;
        }
    }
}
