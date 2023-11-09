// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Constraints that determine the list of available Internet service providers. </summary>
    public partial class AvailableProvidersListContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailableProvidersListContent"/>. </summary>
        public AvailableProvidersListContent()
        {
            AzureLocations = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableProvidersListContent"/>. </summary>
        /// <param name="azureLocations"> A list of Azure regions. </param>
        /// <param name="country"> The country for available providers list. </param>
        /// <param name="state"> The state for available providers list. </param>
        /// <param name="city"> The city or town for available providers list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableProvidersListContent(IList<AzureLocation> azureLocations, string country, string state, string city, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureLocations = azureLocations;
            Country = country;
            State = state;
            City = city;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of Azure regions. </summary>
        public IList<AzureLocation> AzureLocations { get; }
        /// <summary> The country for available providers list. </summary>
        public string Country { get; set; }
        /// <summary> The state for available providers list. </summary>
        public string State { get; set; }
        /// <summary> The city or town for available providers list. </summary>
        public string City { get; set; }
    }
}
