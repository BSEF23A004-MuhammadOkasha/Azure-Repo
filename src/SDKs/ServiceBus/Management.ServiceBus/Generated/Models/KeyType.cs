// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for KeyType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeyType
    {
        [EnumMember(Value = "PrimaryKey")]
        PrimaryKey,
        [EnumMember(Value = "SecondaryKey")]
        SecondaryKey
    }
    internal static class KeyTypeEnumExtension
    {
        internal static string ToSerializedValue(this KeyType? value)  =>
            value == null ? null : ((KeyType)value).ToSerializedValue();

        internal static string ToSerializedValue(this KeyType value)
        {
            switch( value )
            {
                case KeyType.PrimaryKey:
                    return "PrimaryKey";
                case KeyType.SecondaryKey:
                    return "SecondaryKey";
            }
            return null;
        }

        internal static KeyType? ParseKeyType(this string value)
        {
            switch( value )
            {
                case "PrimaryKey":
                    return KeyType.PrimaryKey;
                case "SecondaryKey":
                    return KeyType.SecondaryKey;
            }
            return null;
        }
    }
}
