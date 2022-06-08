// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteCircuitAuthorization data model. </summary>
    public partial class ExpressRouteCircuitAuthorizationData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitAuthorizationData"/>. </summary>
        public ExpressRouteCircuitAuthorizationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitAuthorizationData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="authorizationKey"> The authorization key. </param>
        /// <param name="authorizationUseStatus"> The authorization use status. </param>
        /// <param name="provisioningState"> The provisioning state of the authorization resource. </param>
        internal ExpressRouteCircuitAuthorizationData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, string authorizationKey, AuthorizationUseStatus? authorizationUseStatus, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            AuthorizationKey = authorizationKey;
            AuthorizationUseStatus = authorizationUseStatus;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> The authorization key. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> The authorization use status. </summary>
        public AuthorizationUseStatus? AuthorizationUseStatus { get; set; }
        /// <summary> The provisioning state of the authorization resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
