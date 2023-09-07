// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> HybridAKSStorageStatus defines the observed state of HybridAKSStorage. </summary>
    internal partial class StorageSpacesPropertiesStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageSpacesPropertiesStatus"/>. </summary>
        public StorageSpacesPropertiesStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSpacesPropertiesStatus"/>. </summary>
        /// <param name="provisioningStatus"> Contains Provisioning errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSpacesPropertiesStatus(StorageSpacesPropertiesStatusProvisioningStatus provisioningStatus, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningStatus = provisioningStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Contains Provisioning errors. </summary>
        public StorageSpacesPropertiesStatusProvisioningStatus ProvisioningStatus { get; set; }
    }
}
