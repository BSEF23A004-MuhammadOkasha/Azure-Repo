// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EndpointAccessDefaultAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EndpointAccessDefaultAction
    {
        /// <summary>
        /// Allow client access.
        /// </summary>
        [EnumMember(Value = "Allow")]
        Allow,
        /// <summary>
        /// Deny client access.
        /// </summary>
        [EnumMember(Value = "Deny")]
        Deny
    }
    internal static class EndpointAccessDefaultActionEnumExtension
    {
        internal static string ToSerializedValue(this EndpointAccessDefaultAction? value)
        {
            return value == null ? null : ((EndpointAccessDefaultAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EndpointAccessDefaultAction value)
        {
            switch( value )
            {
                case EndpointAccessDefaultAction.Allow:
                    return "Allow";
                case EndpointAccessDefaultAction.Deny:
                    return "Deny";
            }
            return null;
        }

        internal static EndpointAccessDefaultAction? ParseEndpointAccessDefaultAction(this string value)
        {
            switch( value )
            {
                case "Allow":
                    return EndpointAccessDefaultAction.Allow;
                case "Deny":
                    return EndpointAccessDefaultAction.Deny;
            }
            return null;
        }
    }
}
