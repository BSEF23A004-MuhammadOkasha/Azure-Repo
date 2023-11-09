// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> PeeringService provider. </summary>
    public partial class PeeringServiceProvider : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PeeringServiceProvider"/>. </summary>
        public PeeringServiceProvider()
        {
            PeeringLocations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PeeringServiceProvider"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serviceProviderName"> The name of the service provider. </param>
        /// <param name="peeringLocations"> The list of locations at which the service provider peers with Microsoft. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringServiceProvider(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string serviceProviderName, IList<string> peeringLocations, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ServiceProviderName = serviceProviderName;
            PeeringLocations = peeringLocations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the service provider. </summary>
        public string ServiceProviderName { get; set; }
        /// <summary> The list of locations at which the service provider peers with Microsoft. </summary>
        public IList<string> PeeringLocations { get; }
    }
}
