// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Common resource representation. </summary>
    public partial class NetworkWritableResourceData
    {
        /// <summary> Initializes a new instance of NetworkWritableResourceData. </summary>
        public NetworkWritableResourceData()
        {
        }

        /// <summary> Initializes a new instance of NetworkWritableResourceData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        internal NetworkWritableResourceData(ResourceIdentifier id, string name, ResourceType? resourceType)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Resource name. </summary>
        public string Name { get; set; }
        /// <summary> Resource type. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
