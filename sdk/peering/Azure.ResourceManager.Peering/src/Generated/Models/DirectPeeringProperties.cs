// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The properties that define a direct peering. </summary>
    public partial class DirectPeeringProperties
    {
        /// <summary> Initializes a new instance of DirectPeeringProperties. </summary>
        public DirectPeeringProperties()
        {
            Connections = new ChangeTrackingList<PeeringDirectConnection>();
        }

        /// <summary> Initializes a new instance of DirectPeeringProperties. </summary>
        /// <param name="connections"> The set of connections that constitute a direct peering. </param>
        /// <param name="useForPeeringService"> The flag that indicates whether or not the peering is used for peering service. </param>
        /// <param name="peerAsn"> The reference of the peer ASN. </param>
        /// <param name="directPeeringType"> The type of direct peering. </param>
        internal DirectPeeringProperties(IList<PeeringDirectConnection> connections, bool? useForPeeringService, WritableSubResource peerAsn, DirectPeeringType? directPeeringType)
        {
            Connections = connections;
            UseForPeeringService = useForPeeringService;
            PeerAsn = peerAsn;
            DirectPeeringType = directPeeringType;
        }

        /// <summary> The set of connections that constitute a direct peering. </summary>
        public IList<PeeringDirectConnection> Connections { get; }
        /// <summary> The flag that indicates whether or not the peering is used for peering service. </summary>
        public bool? UseForPeeringService { get; }
        /// <summary> The reference of the peer ASN. </summary>
        internal WritableSubResource PeerAsn { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PeerAsnId
        {
            get => PeerAsn is null ? default : PeerAsn.Id;
            set
            {
                if (PeerAsn is null)
                    PeerAsn = new WritableSubResource();
                PeerAsn.Id = value;
            }
        }

        /// <summary> The type of direct peering. </summary>
        public DirectPeeringType? DirectPeeringType { get; set; }
    }
}
