// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{

    /// <summary>
    /// Defines values for SchedulingErrorCategory.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SchedulingErrorCategory
    {
        [System.Runtime.Serialization.EnumMember(Value = "userError")]
        UserError,
        [System.Runtime.Serialization.EnumMember(Value = "serverError")]
        ServerError,
        [System.Runtime.Serialization.EnumMember(Value = "unmapped")]
        Unmapped
    }
}
