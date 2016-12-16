// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{

    /// <summary>
    /// Defines values for OperationStatus.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = "InProgress")]
        InProgress,
        [System.Runtime.Serialization.EnumMember(Value = "Failed")]
        Failed,
        [System.Runtime.Serialization.EnumMember(Value = "Succeeded")]
        Succeeded,
        [System.Runtime.Serialization.EnumMember(Value = "TimedOut")]
        TimedOut,
        [System.Runtime.Serialization.EnumMember(Value = "Created")]
        Created
    }
}
