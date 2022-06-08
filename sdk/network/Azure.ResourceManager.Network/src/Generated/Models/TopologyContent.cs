// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the representation of topology. </summary>
    public partial class TopologyContent
    {
        /// <summary> Initializes a new instance of <see cref="TopologyContent"/>. </summary>
        public TopologyContent()
        {
        }

        /// <summary> The name of the target resource group to perform topology on. </summary>
        public string TargetResourceGroupName { get; set; }
        /// <summary> The reference to the Virtual Network resource. </summary>
        internal WritableSubResource TargetVirtualNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier TargetVirtualNetworkId
        {
            get => TargetVirtualNetwork is null ? default : TargetVirtualNetwork.Id;
            set
            {
                if (TargetVirtualNetwork is null)
                    TargetVirtualNetwork = new WritableSubResource();
                TargetVirtualNetwork.Id = value;
            }
        }

        /// <summary> The reference to the Subnet resource. </summary>
        internal WritableSubResource TargetSubnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier TargetSubnetId
        {
            get => TargetSubnet is null ? default : TargetSubnet.Id;
            set
            {
                if (TargetSubnet is null)
                    TargetSubnet = new WritableSubResource();
                TargetSubnet.Id = value;
            }
        }
    }
}
