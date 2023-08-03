// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class SearchArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="SearchArmClientMockingExtension"/> class for mocking. </summary>
        protected SearchArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SearchArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SearchArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal SearchArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="SearchServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SearchServiceResource.CreateResourceIdentifier" /> to create a <see cref="SearchServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SearchServiceResource" /> object. </returns>
        public virtual SearchServiceResource GetSearchServiceResource(ResourceIdentifier id)
        {
            SearchServiceResource.ValidateResourceId(id);
            return new SearchServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SearchPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SearchPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="SearchPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SearchPrivateEndpointConnectionResource" /> object. </returns>
        public virtual SearchPrivateEndpointConnectionResource GetSearchPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            SearchPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new SearchPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SharedSearchServicePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SharedSearchServicePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="SharedSearchServicePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedSearchServicePrivateLinkResource" /> object. </returns>
        public virtual SharedSearchServicePrivateLinkResource GetSharedSearchServicePrivateLinkResource(ResourceIdentifier id)
        {
            SharedSearchServicePrivateLinkResource.ValidateResourceId(id);
            return new SharedSearchServicePrivateLinkResource(Client, id);
        }
    }
}
