// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Real-time inventory of available ExpressRoute port bandwidths. </summary>
    public partial class ExpressRoutePortsLocationBandwidths
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRoutePortsLocationBandwidths"/>. </summary>
        public ExpressRoutePortsLocationBandwidths()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRoutePortsLocationBandwidths"/>. </summary>
        /// <param name="offerName"> Bandwidth descriptive name. </param>
        /// <param name="valueInGbps"> Bandwidth value in Gbps. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRoutePortsLocationBandwidths(string offerName, int? valueInGbps, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OfferName = offerName;
            ValueInGbps = valueInGbps;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Bandwidth descriptive name. </summary>
        public string OfferName { get; }
        /// <summary> Bandwidth value in Gbps. </summary>
        public int? ValueInGbps { get; }
    }
}
