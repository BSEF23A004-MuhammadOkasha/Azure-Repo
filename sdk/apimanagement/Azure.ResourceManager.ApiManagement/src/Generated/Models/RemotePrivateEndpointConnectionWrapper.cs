// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Remote Private Endpoint Connection resource. </summary>
    public partial class RemotePrivateEndpointConnectionWrapper
    {
        /// <summary> Initializes a new instance of RemotePrivateEndpointConnectionWrapper. </summary>
        public RemotePrivateEndpointConnectionWrapper()
        {
            GroupIds = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RemotePrivateEndpointConnectionWrapper. </summary>
        /// <param name="id"> Private Endpoint connection resource id. </param>
        /// <param name="name"> Private Endpoint Connection Name. </param>
        /// <param name="resourceType"> Private Endpoint Connection Resource Type. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="groupIds"> All the Group ids. </param>
        internal RemotePrivateEndpointConnectionWrapper(ResourceIdentifier id, string name, ResourceType? resourceType, SubResource privateEndpoint, ApiManagementPrivateLinkServiceConnectionState privateLinkServiceConnectionState, string provisioningState, IReadOnlyList<string> groupIds)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            GroupIds = groupIds;
        }

        /// <summary> Private Endpoint connection resource id. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Private Endpoint Connection Name. </summary>
        public string Name { get; set; }
        /// <summary> Private Endpoint Connection Resource Type. </summary>
        public ResourceType? ResourceType { get; set; }
        /// <summary> The resource of private end point. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public ApiManagementPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> All the Group ids. </summary>
        public IReadOnlyList<string> GroupIds { get; }
    }
}
