// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownReplicationProviderSpecificSettings. </summary>
    internal partial class UnknownReplicationProviderSpecificSettings : ReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownReplicationProviderSpecificSettings"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownReplicationProviderSpecificSettings(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
