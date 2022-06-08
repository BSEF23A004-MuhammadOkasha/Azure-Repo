// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Private Link Configuration on an application gateway. </summary>
    public partial class ApplicationGatewayPrivateLinkConfiguration : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayPrivateLinkConfiguration"/>. </summary>
        public ApplicationGatewayPrivateLinkConfiguration()
        {
            IPConfigurations = new ChangeTrackingList<ApplicationGatewayPrivateLinkIPConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayPrivateLinkConfiguration"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ipConfigurations"> An array of application gateway private link ip configurations. </param>
        /// <param name="provisioningState"> The provisioning state of the application gateway private link configuration. </param>
        internal ApplicationGatewayPrivateLinkConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, IList<ApplicationGatewayPrivateLinkIPConfiguration> ipConfigurations, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            IPConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> An array of application gateway private link ip configurations. </summary>
        public IList<ApplicationGatewayPrivateLinkIPConfiguration> IPConfigurations { get; }
        /// <summary> The provisioning state of the application gateway private link configuration. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
