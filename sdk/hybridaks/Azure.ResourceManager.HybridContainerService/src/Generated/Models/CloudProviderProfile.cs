// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> CloudProviderProfile - The underlying cloud infra provider properties. </summary>
    public partial class CloudProviderProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudProviderProfile"/>. </summary>
        public CloudProviderProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudProviderProfile"/>. </summary>
        /// <param name="infraNetworkProfile"> InfraNetworkProfile - List of infra network profiles for the provisioned cluster. </param>
        /// <param name="infraStorageProfile"> InfraStorageProfile - List of infra storage profiles for the provisioned cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudProviderProfile(CloudProviderProfileInfraNetworkProfile infraNetworkProfile, CloudProviderProfileInfraStorageProfile infraStorageProfile, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InfraNetworkProfile = infraNetworkProfile;
            InfraStorageProfile = infraStorageProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> InfraNetworkProfile - List of infra network profiles for the provisioned cluster. </summary>
        internal CloudProviderProfileInfraNetworkProfile InfraNetworkProfile { get; set; }
        /// <summary> Array of references to azure resource corresponding to the new HybridAKSNetwork object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworkName}. </summary>
        public IList<string> InfraNetworkVnetSubnetIds
        {
            get
            {
                if (InfraNetworkProfile is null)
                    InfraNetworkProfile = new CloudProviderProfileInfraNetworkProfile();
                return InfraNetworkProfile.VnetSubnetIds;
            }
        }

        /// <summary> InfraStorageProfile - List of infra storage profiles for the provisioned cluster. </summary>
        internal CloudProviderProfileInfraStorageProfile InfraStorageProfile { get; set; }
        /// <summary> Reference to azure resource corresponding to the new HybridAKSStorage object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpaceName}. </summary>
        public IList<string> StorageSpaceIds
        {
            get
            {
                if (InfraStorageProfile is null)
                    InfraStorageProfile = new CloudProviderProfileInfraStorageProfile();
                return InfraStorageProfile.StorageSpaceIds;
            }
        }
    }
}
