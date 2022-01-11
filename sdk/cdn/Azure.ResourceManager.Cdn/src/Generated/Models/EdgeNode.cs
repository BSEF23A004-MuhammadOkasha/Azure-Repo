// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Edgenode is a global Point of Presence (POP) location used to deliver CDN content to end users. </summary>
    public partial class EdgeNode : ProxyResource
    {
        /// <summary> Initializes a new instance of EdgeNode. </summary>
        public EdgeNode()
        {
            IpAddressGroups = new ChangeTrackingList<IpAddressGroup>();
        }

        /// <summary> Initializes a new instance of EdgeNode. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Read only system data. </param>
        /// <param name="ipAddressGroups"> List of ip address groups. </param>
        internal EdgeNode(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IList<IpAddressGroup> ipAddressGroups) : base(id, name, type, systemData)
        {
            IpAddressGroups = ipAddressGroups;
        }

        /// <summary> List of ip address groups. </summary>
        public IList<IpAddressGroup> IpAddressGroups { get; }
    }
}
