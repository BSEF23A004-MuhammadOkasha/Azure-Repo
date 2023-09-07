// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Profile for how to handle networking for Lab Plans. </summary>
    internal partial class LabPlanNetworkProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabPlanNetworkProfile"/>. </summary>
        public LabPlanNetworkProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabPlanNetworkProfile"/>. </summary>
        /// <param name="subnetId"> The external subnet resource id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabPlanNetworkProfile(ResourceIdentifier subnetId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubnetId = subnetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The external subnet resource id. </summary>
        public ResourceIdentifier SubnetId { get; set; }
    }
}
