// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Routing rule of an application gateway. </summary>
    public partial class ApplicationGatewayRoutingRule : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRoutingRule"/>. </summary>
        public ApplicationGatewayRoutingRule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRoutingRule"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ruleType"> Rule type. </param>
        /// <param name="priority"> Priority of the routing rule. </param>
        /// <param name="backendAddressPool"> Backend address pool resource of the application gateway. </param>
        /// <param name="backendSettings"> Backend settings resource of the application gateway. </param>
        /// <param name="listener"> Listener resource of the application gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the request routing rule resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayRoutingRule(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, ApplicationGatewayRequestRoutingRuleType? ruleType, int? priority, WritableSubResource backendAddressPool, WritableSubResource backendSettings, WritableSubResource listener, NetworkProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
            ETag = etag;
            RuleType = ruleType;
            Priority = priority;
            BackendAddressPool = backendAddressPool;
            BackendSettings = backendSettings;
            Listener = listener;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Rule type. </summary>
        public ApplicationGatewayRequestRoutingRuleType? RuleType { get; set; }
        /// <summary> Priority of the routing rule. </summary>
        public int? Priority { get; set; }
        /// <summary> Backend address pool resource of the application gateway. </summary>
        internal WritableSubResource BackendAddressPool { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendAddressPoolId
        {
            get => BackendAddressPool is null ? default : BackendAddressPool.Id;
            set
            {
                if (BackendAddressPool is null)
                    BackendAddressPool = new WritableSubResource();
                BackendAddressPool.Id = value;
            }
        }

        /// <summary> Backend settings resource of the application gateway. </summary>
        internal WritableSubResource BackendSettings { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendSettingsId
        {
            get => BackendSettings is null ? default : BackendSettings.Id;
            set
            {
                if (BackendSettings is null)
                    BackendSettings = new WritableSubResource();
                BackendSettings.Id = value;
            }
        }

        /// <summary> Listener resource of the application gateway. </summary>
        internal WritableSubResource Listener { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ListenerId
        {
            get => Listener is null ? default : Listener.Id;
            set
            {
                if (Listener is null)
                    Listener = new WritableSubResource();
                Listener.Id = value;
            }
        }

        /// <summary> The provisioning state of the request routing rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
