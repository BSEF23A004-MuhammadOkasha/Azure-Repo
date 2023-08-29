// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The failover policy for a given region of a database account. </summary>
    public partial class CosmosDBFailoverPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBFailoverPolicy"/>. </summary>
        public CosmosDBFailoverPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBFailoverPolicy"/>. </summary>
        /// <param name="id"> The unique identifier of the region in which the database account replicates to. Example: &lt;accountName&gt;-&lt;locationName&gt;. </param>
        /// <param name="locationName"> The name of the region in which the database account exists. </param>
        /// <param name="failoverPriority"> The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBFailoverPolicy(string id, AzureLocation? locationName, int? failoverPriority, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            LocationName = locationName;
            FailoverPriority = failoverPriority;
            _rawData = rawData;
        }

        /// <summary> The unique identifier of the region in which the database account replicates to. Example: &lt;accountName&gt;-&lt;locationName&gt;. </summary>
        public string Id { get; }
        /// <summary> The name of the region in which the database account exists. </summary>
        public AzureLocation? LocationName { get; set; }
        /// <summary> The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists. </summary>
        public int? FailoverPriority { get; set; }
    }
}
