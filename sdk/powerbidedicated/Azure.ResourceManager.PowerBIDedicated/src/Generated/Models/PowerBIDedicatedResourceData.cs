// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Represents an instance of an PowerBI Dedicated resource. </summary>
    public partial class PowerBIDedicatedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PowerBIDedicatedResourceData"/>. </summary>
        /// <param name="location"> Location of the PowerBI Dedicated resource. </param>
        public PowerBIDedicatedResourceData(AzureLocation location)
        {
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="PowerBIDedicatedResourceData"/>. </summary>
        /// <param name="id"> An identifier that represents the PowerBI Dedicated resource. </param>
        /// <param name="name"> The name of the PowerBI Dedicated resource. </param>
        /// <param name="resourceType"> The type of the PowerBI Dedicated resource. </param>
        /// <param name="location"> Location of the PowerBI Dedicated resource. </param>
        /// <param name="tags"> Key-value pairs of additional resource provisioning properties. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PowerBIDedicatedResourceData(string id, string name, string resourceType, AzureLocation location, IDictionary<string, string> tags, SystemData systemData, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            Location = location;
            Tags = tags;
            SystemData = systemData;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PowerBIDedicatedResourceData"/> for deserialization. </summary>
        internal PowerBIDedicatedResourceData()
        {
        }

        /// <summary> An identifier that represents the PowerBI Dedicated resource. </summary>
        public string Id { get; }
        /// <summary> The name of the PowerBI Dedicated resource. </summary>
        public string Name { get; }
        /// <summary> The type of the PowerBI Dedicated resource. </summary>
        public string ResourceType { get; }
        /// <summary> Location of the PowerBI Dedicated resource. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> Key-value pairs of additional resource provisioning properties. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; set; }
    }
}
