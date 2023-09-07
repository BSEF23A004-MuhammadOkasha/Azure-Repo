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
    /// A class representing the NetworkTapRule data model.
    /// The NetworkTapRule resource definition.
    /// </summary>
    public partial class NetworkTapRuleData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkTapRuleData"/>. </summary>
        /// <param name="location"> The location. </param>
        public NetworkTapRuleData(AzureLocation location) : base(location)
        {
            MatchConfigurations = new ChangeTrackingList<NetworkTapRuleMatchConfiguration>();
            DynamicMatchConfigurations = new ChangeTrackingList<CommonDynamicMatchConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="configurationType"> Input method to configure Network Tap Rule. </param>
        /// <param name="tapRulesUri"> Network Tap Rules file URL. </param>
        /// <param name="matchConfigurations"> List of match configurations. </param>
        /// <param name="dynamicMatchConfigurations"> List of dynamic match configurations. </param>
        /// <param name="networkTapId"> The ARM resource Id of the NetworkTap. </param>
        /// <param name="pollingIntervalInSeconds"> Polling interval in seconds. </param>
        /// <param name="lastSyncedOn"> The last sync timestamp. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkTapRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, NetworkFabricConfigurationType? configurationType, Uri tapRulesUri, IList<NetworkTapRuleMatchConfiguration> matchConfigurations, IList<CommonDynamicMatchConfiguration> dynamicMatchConfigurations, ResourceIdentifier networkTapId, PollingIntervalInSecond? pollingIntervalInSeconds, DateTimeOffset? lastSyncedOn, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            ConfigurationType = configurationType;
            TapRulesUri = tapRulesUri;
            MatchConfigurations = matchConfigurations;
            DynamicMatchConfigurations = dynamicMatchConfigurations;
            NetworkTapId = networkTapId;
            PollingIntervalInSeconds = pollingIntervalInSeconds;
            LastSyncedOn = lastSyncedOn;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapRuleData"/> for deserialization. </summary>
        internal NetworkTapRuleData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Input method to configure Network Tap Rule. </summary>
        public NetworkFabricConfigurationType? ConfigurationType { get; set; }
        /// <summary> Network Tap Rules file URL. </summary>
        public Uri TapRulesUri { get; set; }
        /// <summary> List of match configurations. </summary>
        public IList<NetworkTapRuleMatchConfiguration> MatchConfigurations { get; }
        /// <summary> List of dynamic match configurations. </summary>
        public IList<CommonDynamicMatchConfiguration> DynamicMatchConfigurations { get; }
        /// <summary> The ARM resource Id of the NetworkTap. </summary>
        public ResourceIdentifier NetworkTapId { get; }
        /// <summary> Polling interval in seconds. </summary>
        public PollingIntervalInSecond? PollingIntervalInSeconds { get; set; }
        /// <summary> The last sync timestamp. </summary>
        public DateTimeOffset? LastSyncedOn { get; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}
