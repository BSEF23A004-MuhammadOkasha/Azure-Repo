// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GetShareExpand.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetShareExpand
    {
        [EnumMember(Value = "stats")]
        Stats
    }
    internal static class GetShareExpandEnumExtension
    {
        internal static string ToSerializedValue(this GetShareExpand? value)
        {
            return value == null ? null : ((GetShareExpand)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GetShareExpand value)
        {
            switch( value )
            {
                case GetShareExpand.Stats:
                    return "stats";
            }
            return null;
        }

        internal static GetShareExpand? ParseGetShareExpand(this string value)
        {
            switch( value )
            {
                case "stats":
                    return GetShareExpand.Stats;
            }
            return null;
        }
    }
}
