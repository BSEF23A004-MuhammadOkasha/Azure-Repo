// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The list of supported VM SKUs. </summary>
    public partial class VmSkuListResult : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VmSkuListResult"/>. </summary>
        internal VmSkuListResult()
        {
            VmSKUs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VmSkuListResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vmSKUs"> Supported VM SKUs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VmSkuListResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<string> vmSKUs, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            VmSKUs = vmSKUs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Supported VM SKUs. </summary>
        public IReadOnlyList<string> VmSKUs { get; }
    }
}
