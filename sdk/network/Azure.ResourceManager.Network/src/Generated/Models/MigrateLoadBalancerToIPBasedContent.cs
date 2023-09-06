// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The request for a migrateToIpBased API. </summary>
    public partial class MigrateLoadBalancerToIPBasedContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MigrateLoadBalancerToIPBasedContent"/>. </summary>
        public MigrateLoadBalancerToIPBasedContent()
        {
            Pools = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateLoadBalancerToIPBasedContent"/>. </summary>
        /// <param name="pools"> A list of pool names that should be migrated from Nic based to IP based pool. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateLoadBalancerToIPBasedContent(IList<string> pools, Dictionary<string, BinaryData> rawData)
        {
            Pools = pools;
            _rawData = rawData;
        }

        /// <summary> A list of pool names that should be migrated from Nic based to IP based pool. </summary>
        public IList<string> Pools { get; }
    }
}
