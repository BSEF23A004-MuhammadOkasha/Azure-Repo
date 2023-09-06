// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> Class for CheckServiceProviderAvailabilityInput. </summary>
    public partial class CheckPeeringServiceProviderAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CheckPeeringServiceProviderAvailabilityContent"/>. </summary>
        public CheckPeeringServiceProviderAvailabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CheckPeeringServiceProviderAvailabilityContent"/>. </summary>
        /// <param name="peeringServiceLocation"> Gets or sets the peering service location. </param>
        /// <param name="peeringServiceProvider"> Gets or sets the peering service provider. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckPeeringServiceProviderAvailabilityContent(string peeringServiceLocation, string peeringServiceProvider, Dictionary<string, BinaryData> rawData)
        {
            PeeringServiceLocation = peeringServiceLocation;
            PeeringServiceProvider = peeringServiceProvider;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the peering service location. </summary>
        public string PeeringServiceLocation { get; set; }
        /// <summary> Gets or sets the peering service provider. </summary>
        public string PeeringServiceProvider { get; set; }
    }
}
