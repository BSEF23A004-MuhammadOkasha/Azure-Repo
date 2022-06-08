// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the AzureWebCategory data model. </summary>
    public partial class AzureWebCategoryData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AzureWebCategoryData"/>. </summary>
        internal AzureWebCategoryData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureWebCategoryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="group"> The name of the group that the category belongs to. </param>
        internal AzureWebCategoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string group) : base(id, name, resourceType, systemData)
        {
            Etag = etag;
            Group = group;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> The name of the group that the category belongs to. </summary>
        public string Group { get; }
    }
}
