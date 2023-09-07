// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Export Route Policy either IPv4 or IPv6. </summary>
    public partial class ExportRoutePolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExportRoutePolicy"/>. </summary>
        public ExportRoutePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExportRoutePolicy"/>. </summary>
        /// <param name="exportIPv4RoutePolicyId"> ARM resource ID of RoutePolicy. </param>
        /// <param name="exportIPv6RoutePolicyId"> ARM resource ID of RoutePolicy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportRoutePolicy(ResourceIdentifier exportIPv4RoutePolicyId, ResourceIdentifier exportIPv6RoutePolicyId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExportIPv4RoutePolicyId = exportIPv4RoutePolicyId;
            ExportIPv6RoutePolicyId = exportIPv6RoutePolicyId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ARM resource ID of RoutePolicy. </summary>
        public ResourceIdentifier ExportIPv4RoutePolicyId { get; set; }
        /// <summary> ARM resource ID of RoutePolicy. </summary>
        public ResourceIdentifier ExportIPv6RoutePolicyId { get; set; }
    }
}
