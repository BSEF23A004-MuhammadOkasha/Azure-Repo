// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The object that represents all properties related to capacity enforcement on an account. </summary>
    internal partial class CosmosDBAccountCapacity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountCapacity"/>. </summary>
        public CosmosDBAccountCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountCapacity"/>. </summary>
        /// <param name="totalThroughputLimit"> The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no limits on provisioning of throughput. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBAccountCapacity(int? totalThroughputLimit, Dictionary<string, BinaryData> rawData)
        {
            TotalThroughputLimit = totalThroughputLimit;
            _rawData = rawData;
        }

        /// <summary> The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no limits on provisioning of throughput. </summary>
        public int? TotalThroughputLimit { get; set; }
    }
}
