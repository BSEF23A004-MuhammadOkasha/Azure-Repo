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
    /// Defines values for AutoStorageAuthenticationMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoStorageAuthenticationMode
    {
        /// <summary>
        /// The Batch service will authenticate requests to auto-storage using
        /// storage account keys.
        /// </summary>
        [EnumMember(Value = "StorageKeys")]
        StorageKeys,
        /// <summary>
        /// The Batch service will authenticate requests to auto-storage using
        /// the managed identity assigned to the Batch account.
        /// </summary>
        [EnumMember(Value = "BatchAccountManagedIdentity")]
        BatchAccountManagedIdentity
    }
    internal static class AutoStorageAuthenticationModeEnumExtension
    {
        internal static string ToSerializedValue(this AutoStorageAuthenticationMode? value)
        {
            return value == null ? null : ((AutoStorageAuthenticationMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutoStorageAuthenticationMode value)
        {
            switch( value )
            {
                case AutoStorageAuthenticationMode.StorageKeys:
                    return "StorageKeys";
                case AutoStorageAuthenticationMode.BatchAccountManagedIdentity:
                    return "BatchAccountManagedIdentity";
            }
            return null;
        }

        internal static AutoStorageAuthenticationMode? ParseAutoStorageAuthenticationMode(this string value)
        {
            switch( value )
            {
                case "StorageKeys":
                    return AutoStorageAuthenticationMode.StorageKeys;
                case "BatchAccountManagedIdentity":
                    return AutoStorageAuthenticationMode.BatchAccountManagedIdentity;
            }
            return null;
        }
    }
}
