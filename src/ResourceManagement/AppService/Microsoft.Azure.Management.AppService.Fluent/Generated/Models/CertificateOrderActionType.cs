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
    /// Defines values for CertificateOrderActionType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CertificateOrderActionType
    {
        [System.Runtime.Serialization.EnumMember(Value = "CertificateIssued")]
        CertificateIssued,
        [System.Runtime.Serialization.EnumMember(Value = "CertificateOrderCanceled")]
        CertificateOrderCanceled,
        [System.Runtime.Serialization.EnumMember(Value = "CertificateOrderCreated")]
        CertificateOrderCreated,
        [System.Runtime.Serialization.EnumMember(Value = "CertificateRevoked")]
        CertificateRevoked,
        [System.Runtime.Serialization.EnumMember(Value = "DomainValidationComplete")]
        DomainValidationComplete,
        [System.Runtime.Serialization.EnumMember(Value = "FraudDetected")]
        FraudDetected,
        [System.Runtime.Serialization.EnumMember(Value = "OrgNameChange")]
        OrgNameChange,
        [System.Runtime.Serialization.EnumMember(Value = "OrgValidationComplete")]
        OrgValidationComplete,
        [System.Runtime.Serialization.EnumMember(Value = "SanDrop")]
        SanDrop,
        [System.Runtime.Serialization.EnumMember(Value = "FraudCleared")]
        FraudCleared,
        [System.Runtime.Serialization.EnumMember(Value = "Unknown")]
        Unknown
    }
}
