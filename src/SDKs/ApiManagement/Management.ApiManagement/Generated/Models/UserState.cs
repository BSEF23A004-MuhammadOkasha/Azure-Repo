// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UserState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserState
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "blocked")]
        Blocked
    }
    internal static class UserStateEnumExtension
    {
        internal static string ToSerializedValue(this UserState? value)  =>
            value == null ? null : ((UserState)value).ToSerializedValue();

        internal static string ToSerializedValue(this UserState value)
        {
            switch( value )
            {
                case UserState.Active:
                    return "active";
                case UserState.Blocked:
                    return "blocked";
            }
            return null;
        }

        internal static UserState? ParseUserState(this string value)
        {
            switch( value )
            {
                case "active":
                    return UserState.Active;
                case "blocked":
                    return UserState.Blocked;
            }
            return null;
        }
    }
}
