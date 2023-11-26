// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownRecoveryVirtualNetworkCustomDetails. </summary>
    internal partial class UnknownRecoveryVirtualNetworkCustomDetails : RecoveryVirtualNetworkCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryVirtualNetworkCustomDetails"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRecoveryVirtualNetworkCustomDetails(string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceType, serializedAdditionalRawData)
        {
            ResourceType = resourceType ?? "Unknown";
        }
    }
}
