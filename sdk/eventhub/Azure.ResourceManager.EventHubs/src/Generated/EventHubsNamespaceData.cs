// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing the EventHubsNamespace data model.
    /// Single Namespace item in List or Get Operation
    /// </summary>
    public partial class EventHubsNamespaceData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsNamespaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public EventHubsNamespaceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<EventHubsPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNamespaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of sku resource. </param>
        /// <param name="identity"> Properties of BYOK Identity description. </param>
        /// <param name="minimumTlsVersion"> The minimum TLS version for the cluster to support, e.g. '1.2'. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="status"> Status of the Namespace. </param>
        /// <param name="createdOn"> The time the Namespace was created. </param>
        /// <param name="updatedOn"> The time the Namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="clusterArmId"> Cluster ARM ID of the Namespace. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="isAutoInflateEnabled"> Value that indicates whether AutoInflate is enabled for eventhub namespace. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. </param>
        /// <param name="maximumThroughputUnits"> Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true). </param>
        /// <param name="kafkaEnabled"> Value that indicates whether Kafka is enabled for eventhub namespace. </param>
        /// <param name="zoneRedundant"> Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones. </param>
        /// <param name="encryption"> Properties of BYOK Encryption description. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Event Hubs namespace. </param>
        /// <param name="alternateName"> Alternate name specified when alias and namespace names are same. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNamespaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EventHubsSku sku, ManagedServiceIdentity identity, EventHubsTlsVersion? minimumTlsVersion, string provisioningState, string status, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string serviceBusEndpoint, ResourceIdentifier clusterArmId, string metricId, bool? isAutoInflateEnabled, EventHubsPublicNetworkAccess? publicNetworkAccess, int? maximumThroughputUnits, bool? kafkaEnabled, bool? zoneRedundant, EventHubsEncryption encryption, IList<EventHubsPrivateEndpointConnectionData> privateEndpointConnections, bool? disableLocalAuth, string alternateName, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            MinimumTlsVersion = minimumTlsVersion;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ServiceBusEndpoint = serviceBusEndpoint;
            ClusterArmId = clusterArmId;
            MetricId = metricId;
            IsAutoInflateEnabled = isAutoInflateEnabled;
            PublicNetworkAccess = publicNetworkAccess;
            MaximumThroughputUnits = maximumThroughputUnits;
            KafkaEnabled = kafkaEnabled;
            ZoneRedundant = zoneRedundant;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            DisableLocalAuth = disableLocalAuth;
            AlternateName = alternateName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNamespaceData"/> for deserialization. </summary>
        internal EventHubsNamespaceData()
        {
        }

        /// <summary> Properties of sku resource. </summary>
        public EventHubsSku Sku { get; set; }
        /// <summary> Properties of BYOK Identity description. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The minimum TLS version for the cluster to support, e.g. '1.2'. </summary>
        public EventHubsTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Provisioning state of the Namespace. </summary>
        public string ProvisioningState { get; }
        /// <summary> Status of the Namespace. </summary>
        public string Status { get; }
        /// <summary> The time the Namespace was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the Namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Cluster ARM ID of the Namespace. </summary>
        public ResourceIdentifier ClusterArmId { get; set; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> Value that indicates whether AutoInflate is enabled for eventhub namespace. </summary>
        public bool? IsAutoInflateEnabled { get; set; }
        /// <summary> This determines if traffic is allowed over public network. By default it is enabled. </summary>
        public EventHubsPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( '0' if AutoInflateEnabled = true). </summary>
        public int? MaximumThroughputUnits { get; set; }
        /// <summary> Value that indicates whether Kafka is enabled for eventhub namespace. </summary>
        public bool? KafkaEnabled { get; set; }
        /// <summary> Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> Properties of BYOK Encryption description. </summary>
        public EventHubsEncryption Encryption { get; set; }
        /// <summary> List of private endpoint connections. </summary>
        public IList<EventHubsPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> This property disables SAS authentication for the Event Hubs namespace. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Alternate name specified when alias and namespace names are same. </summary>
        public string AlternateName { get; set; }
    }
}
