// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A class representing the DigitalTwinsPrivateEndpointConnection data model.
    /// The private endpoint connection of a Digital Twin.
    /// </summary>
    public partial class DigitalTwinsPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateEndpointConnectionData"/>. </summary>
        /// <param name="properties"> The connection properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DigitalTwinsPrivateEndpointConnectionData(DigitalTwinsPrivateEndpointConnectionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The connection properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DigitalTwinsPrivateEndpointConnectionProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateEndpointConnectionData"/> for deserialization. </summary>
        internal DigitalTwinsPrivateEndpointConnectionData()
        {
        }

        /// <summary> The connection properties. </summary>
        public DigitalTwinsPrivateEndpointConnectionProperties Properties { get; set; }
    }
}
