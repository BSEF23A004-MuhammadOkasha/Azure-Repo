// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Azure proxy only resource. This resource is not tracked by Azure Resource Manager. </summary>
    public partial class ProxyOnlyResource : ResourceData
    {
        /// <summary> Initializes a new instance of ProxyOnlyResource. </summary>
        public ProxyOnlyResource()
        {
        }

        /// <summary> Initializes a new instance of ProxyOnlyResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal ProxyOnlyResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
