// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricInternetGatewayRule data model.
    /// The Internet Gateway Rule resource definition.
    /// </summary>
    public partial class NetworkFabricInternetGatewayRuleData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternetGatewayRuleData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="ruleProperties"> Rules for the InternetGateways. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleProperties"/> is null. </exception>
        public NetworkFabricInternetGatewayRuleData(AzureLocation location, InternetGatewayRules ruleProperties) : base(location)
        {
            Argument.AssertNotNull(ruleProperties, nameof(ruleProperties));

            RuleProperties = ruleProperties;
            InternetGatewayIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternetGatewayRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="ruleProperties"> Rules for the InternetGateways. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="internetGatewayIds"> List of Internet Gateway resource Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricInternetGatewayRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, InternetGatewayRules ruleProperties, NetworkFabricProvisioningState? provisioningState, IReadOnlyList<ResourceIdentifier> internetGatewayIds, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            RuleProperties = ruleProperties;
            ProvisioningState = provisioningState;
            InternetGatewayIds = internetGatewayIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternetGatewayRuleData"/> for deserialization. </summary>
        internal NetworkFabricInternetGatewayRuleData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Rules for the InternetGateways. </summary>
        public InternetGatewayRules RuleProperties { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> List of Internet Gateway resource Id. </summary>
        public IReadOnlyList<ResourceIdentifier> InternetGatewayIds { get; }
    }
}
