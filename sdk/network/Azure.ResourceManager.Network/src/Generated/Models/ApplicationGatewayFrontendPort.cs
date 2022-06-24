// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Frontend port of an application gateway. </summary>
    public partial class ApplicationGatewayFrontendPort : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFrontendPort. </summary>
        public ApplicationGatewayFrontendPort()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayFrontendPort. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="port"> Frontend port. </param>
        /// <param name="provisioningState"> The provisioning state of the frontend port resource. </param>
        internal ApplicationGatewayFrontendPort(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, int? port, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = eTag;
            Port = port;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Frontend port. </summary>
        public int? Port { get; set; }
        /// <summary> The provisioning state of the frontend port resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
