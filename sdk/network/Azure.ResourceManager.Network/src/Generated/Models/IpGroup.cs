// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The IpGroups resource information. </summary>
    public partial class IpGroup : Resource
    {
        /// <summary> Initializes a new instance of IpGroup. </summary>
        public IpGroup()
        {
            IpAddresses = new ChangeTrackingList<string>();
            Firewalls = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of IpGroup. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the IpGroups resource. </param>
        /// <param name="ipAddresses"> IpAddresses/IpAddressPrefixes in the IpGroups resource. </param>
        /// <param name="firewalls"> List of references to Azure resources that this IpGroups is associated with. </param>
        internal IpGroup(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, ProvisioningState? provisioningState, IList<string> ipAddresses, IReadOnlyList<SubResource> firewalls) : base(id, name, type, location, tags)
        {
            Etag = etag;
            ProvisioningState = provisioningState;
            IpAddresses = ipAddresses;
            Firewalls = firewalls;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The provisioning state of the IpGroups resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> IpAddresses/IpAddressPrefixes in the IpGroups resource. </summary>
        public IList<string> IpAddresses { get; }
        /// <summary> List of references to Azure resources that this IpGroups is associated with. </summary>
        public IReadOnlyList<SubResource> Firewalls { get; }
    }
}
