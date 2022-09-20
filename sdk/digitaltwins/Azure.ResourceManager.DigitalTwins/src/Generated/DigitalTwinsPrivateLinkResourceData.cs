// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary> A class representing the DigitalTwinsPrivateLinkResource data model. </summary>
    public partial class DigitalTwinsPrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of DigitalTwinsPrivateLinkResourceData. </summary>
        /// <param name="properties"> The group information properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal DigitalTwinsPrivateLinkResourceData(DigitalTwinsPrivateLinkResourceProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DigitalTwinsPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The group information properties. </param>
        internal DigitalTwinsPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DigitalTwinsPrivateLinkResourceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> The group information properties. </summary>
        public DigitalTwinsPrivateLinkResourceProperties Properties { get; }
    }
}
