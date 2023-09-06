// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Forward shipment details. </summary>
    public partial class ForwardShippingDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ForwardShippingDetails"/>. </summary>
        internal ForwardShippingDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ForwardShippingDetails"/>. </summary>
        /// <param name="carrierName"> Name of the carrier. </param>
        /// <param name="carrierDisplayName"> Carrier Name for display purpose. Not to be used for any processing. </param>
        /// <param name="trackingId"> TrackingId of the package. </param>
        /// <param name="trackingUri"> TrackingUrl of the package. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ForwardShippingDetails(string carrierName, string carrierDisplayName, string trackingId, Uri trackingUri, Dictionary<string, BinaryData> rawData)
        {
            CarrierName = carrierName;
            CarrierDisplayName = carrierDisplayName;
            TrackingId = trackingId;
            TrackingUri = trackingUri;
            _rawData = rawData;
        }

        /// <summary> Name of the carrier. </summary>
        public string CarrierName { get; }
        /// <summary> Carrier Name for display purpose. Not to be used for any processing. </summary>
        public string CarrierDisplayName { get; }
        /// <summary> TrackingId of the package. </summary>
        public string TrackingId { get; }
        /// <summary> TrackingUrl of the package. </summary>
        public Uri TrackingUri { get; }
    }
}
