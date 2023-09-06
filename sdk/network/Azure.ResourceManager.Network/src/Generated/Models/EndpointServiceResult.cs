// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Endpoint service. </summary>
    public partial class EndpointServiceResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EndpointServiceResult"/>. </summary>
        internal EndpointServiceResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EndpointServiceResult"/>. </summary>
        /// <param name="name"> Name of the endpoint service. </param>
        /// <param name="resourceType"> Type of the endpoint service. </param>
        /// <param name="id"> Resource ID. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointServiceResult(string name, ResourceType? resourceType, ResourceIdentifier id, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            Id = id;
            _rawData = rawData;
        }

        /// <summary> Name of the endpoint service. </summary>
        public string Name { get; }
        /// <summary> Type of the endpoint service. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; }
    }
}
