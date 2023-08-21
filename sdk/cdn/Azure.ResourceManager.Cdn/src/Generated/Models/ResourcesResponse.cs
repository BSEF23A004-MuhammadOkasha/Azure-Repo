// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Resources Response. </summary>
    public partial class ResourcesResponse
    {
        /// <summary> Initializes a new instance of ResourcesResponse. </summary>
        internal ResourcesResponse()
        {
            Endpoints = new Core.ChangeTrackingList<ResourcesResponseEndpointsItem>();
            CustomDomains = new Core.ChangeTrackingList<ResourcesResponseCustomDomainsItem>();
        }

        /// <summary> Initializes a new instance of ResourcesResponse. </summary>
        /// <param name="endpoints"></param>
        /// <param name="customDomains"></param>
        internal ResourcesResponse(IReadOnlyList<ResourcesResponseEndpointsItem> endpoints, IReadOnlyList<ResourcesResponseCustomDomainsItem> customDomains)
        {
            Endpoints = endpoints;
            CustomDomains = customDomains;
        }

        /// <summary> Gets the endpoints. </summary>
        public IReadOnlyList<ResourcesResponseEndpointsItem> Endpoints { get; }
        /// <summary> Gets the custom domains. </summary>
        public IReadOnlyList<ResourcesResponseCustomDomainsItem> CustomDomains { get; }
    }
}
