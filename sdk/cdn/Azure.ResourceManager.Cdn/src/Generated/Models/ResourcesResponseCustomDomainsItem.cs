// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ResourcesResponseCustomDomainsItem. </summary>
    public partial class ResourcesResponseCustomDomainsItem : SubResource
    {
        /// <summary> Initializes a new instance of ResourcesResponseCustomDomainsItem. </summary>
        internal ResourcesResponseCustomDomainsItem()
        {
        }

        /// <summary> Initializes a new instance of ResourcesResponseCustomDomainsItem. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"></param>
        /// <param name="endpointId"></param>
        /// <param name="history"></param>
        internal ResourcesResponseCustomDomainsItem(string id, string name, string endpointId, bool? history) : base(id)
        {
            Name = name;
            EndpointId = endpointId;
            History = history;
        }

        public string Name { get; }
        public string EndpointId { get; }
        public bool? History { get; }
    }
}
