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
    /// <summary> UrlPathMaps give a url path to the backend mapping information for PathBasedRouting. </summary>
    public partial class ApplicationGatewayUrlPathMap : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayUrlPathMap"/>. </summary>
        public ApplicationGatewayUrlPathMap()
        {
            PathRules = new ChangeTrackingList<ApplicationGatewayPathRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayUrlPathMap"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="defaultBackendAddressPool"> Default backend address pool resource of URL path map. </param>
        /// <param name="defaultBackendHttpSettings"> Default backend http settings resource of URL path map. </param>
        /// <param name="defaultRewriteRuleSet"> Default Rewrite rule set resource of URL path map. </param>
        /// <param name="defaultRedirectConfiguration"> Default redirect configuration resource of URL path map. </param>
        /// <param name="defaultLoadDistributionPolicy"> Default Load Distribution Policy resource of URL path map. </param>
        /// <param name="pathRules"> Path rule of URL path map resource. </param>
        /// <param name="provisioningState"> The provisioning state of the URL path map resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayUrlPathMap(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, WritableSubResource defaultBackendAddressPool, WritableSubResource defaultBackendHttpSettings, WritableSubResource defaultRewriteRuleSet, WritableSubResource defaultRedirectConfiguration, WritableSubResource defaultLoadDistributionPolicy, IList<ApplicationGatewayPathRule> pathRules, NetworkProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
            ETag = etag;
            DefaultBackendAddressPool = defaultBackendAddressPool;
            DefaultBackendHttpSettings = defaultBackendHttpSettings;
            DefaultRewriteRuleSet = defaultRewriteRuleSet;
            DefaultRedirectConfiguration = defaultRedirectConfiguration;
            DefaultLoadDistributionPolicy = defaultLoadDistributionPolicy;
            PathRules = pathRules;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Default backend address pool resource of URL path map. </summary>
        internal WritableSubResource DefaultBackendAddressPool { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultBackendAddressPoolId
        {
            get => DefaultBackendAddressPool is null ? default : DefaultBackendAddressPool.Id;
            set
            {
                if (DefaultBackendAddressPool is null)
                    DefaultBackendAddressPool = new WritableSubResource();
                DefaultBackendAddressPool.Id = value;
            }
        }

        /// <summary> Default backend http settings resource of URL path map. </summary>
        internal WritableSubResource DefaultBackendHttpSettings { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultBackendHttpSettingsId
        {
            get => DefaultBackendHttpSettings is null ? default : DefaultBackendHttpSettings.Id;
            set
            {
                if (DefaultBackendHttpSettings is null)
                    DefaultBackendHttpSettings = new WritableSubResource();
                DefaultBackendHttpSettings.Id = value;
            }
        }

        /// <summary> Default Rewrite rule set resource of URL path map. </summary>
        internal WritableSubResource DefaultRewriteRuleSet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultRewriteRuleSetId
        {
            get => DefaultRewriteRuleSet is null ? default : DefaultRewriteRuleSet.Id;
            set
            {
                if (DefaultRewriteRuleSet is null)
                    DefaultRewriteRuleSet = new WritableSubResource();
                DefaultRewriteRuleSet.Id = value;
            }
        }

        /// <summary> Default redirect configuration resource of URL path map. </summary>
        internal WritableSubResource DefaultRedirectConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultRedirectConfigurationId
        {
            get => DefaultRedirectConfiguration is null ? default : DefaultRedirectConfiguration.Id;
            set
            {
                if (DefaultRedirectConfiguration is null)
                    DefaultRedirectConfiguration = new WritableSubResource();
                DefaultRedirectConfiguration.Id = value;
            }
        }

        /// <summary> Default Load Distribution Policy resource of URL path map. </summary>
        internal WritableSubResource DefaultLoadDistributionPolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultLoadDistributionPolicyId
        {
            get => DefaultLoadDistributionPolicy is null ? default : DefaultLoadDistributionPolicy.Id;
            set
            {
                if (DefaultLoadDistributionPolicy is null)
                    DefaultLoadDistributionPolicy = new WritableSubResource();
                DefaultLoadDistributionPolicy.Id = value;
            }
        }

        /// <summary> Path rule of URL path map resource. </summary>
        public IList<ApplicationGatewayPathRule> PathRules { get; }
        /// <summary> The provisioning state of the URL path map resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
