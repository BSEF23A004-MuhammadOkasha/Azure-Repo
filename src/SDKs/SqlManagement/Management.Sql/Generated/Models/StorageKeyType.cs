// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StorageKeyType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageKeyType
    {
        [EnumMember(Value = "StorageAccessKey")]
        StorageAccessKey,
        [EnumMember(Value = "SharedAccessKey")]
        SharedAccessKey
    }
    internal static class StorageKeyTypeEnumExtension
    {
        internal static string ToSerializedValue(this StorageKeyType? value )  =>
            value == null ? null : (( StorageKeyType )value).ToSerializedValue();

        internal static string ToSerializedValue(this StorageKeyType value )
        {
            switch( value )
            {
                case StorageKeyType.StorageAccessKey:
                    return "StorageAccessKey";
                case StorageKeyType.SharedAccessKey:
                    return "SharedAccessKey";
            }
            return null;
        }

        internal static StorageKeyType? ParseStorageKeyType( this string value )
        {
            switch( value )
            {
                case "StorageAccessKey":
                    return StorageKeyType.StorageAccessKey;
                case "SharedAccessKey":
                    return StorageKeyType.SharedAccessKey;            }
            return null;
        }
    }
}
