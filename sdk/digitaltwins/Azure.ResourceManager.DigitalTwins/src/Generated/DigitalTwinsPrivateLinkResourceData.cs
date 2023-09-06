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
    /// A class representing the DigitalTwinsPrivateLinkResource data model.
    /// The group information for creating a private endpoint on Digital Twin.
    /// </summary>
    public partial class DigitalTwinsPrivateLinkResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateLinkResourceData"/>. </summary>
        /// <param name="properties"> The group information properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal DigitalTwinsPrivateLinkResourceData(DigitalTwinsPrivateLinkResourceProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The group information properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DigitalTwinsPrivateLinkResourceProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateLinkResourceData"/> for deserialization. </summary>
        internal DigitalTwinsPrivateLinkResourceData()
        {
        }

        /// <summary> The group information properties. </summary>
        public DigitalTwinsPrivateLinkResourceProperties Properties { get; }
    }
}
