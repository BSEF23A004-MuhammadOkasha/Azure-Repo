// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Virtual network subnet usage parameter. </summary>
    public partial class MySqlFlexibleServerVirtualNetworkSubnetUsageParameter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerVirtualNetworkSubnetUsageParameter"/>. </summary>
        public MySqlFlexibleServerVirtualNetworkSubnetUsageParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerVirtualNetworkSubnetUsageParameter"/>. </summary>
        /// <param name="virtualNetworkResourceId"> Virtual network resource id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerVirtualNetworkSubnetUsageParameter(ResourceIdentifier virtualNetworkResourceId, Dictionary<string, BinaryData> rawData)
        {
            VirtualNetworkResourceId = virtualNetworkResourceId;
            _rawData = rawData;
        }

        /// <summary> Virtual network resource id. </summary>
        public ResourceIdentifier VirtualNetworkResourceId { get; set; }
    }
}
