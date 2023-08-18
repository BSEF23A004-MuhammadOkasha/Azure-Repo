// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Class representing an event hub data connection. </summary>
    public partial class SynapseEventHubDataConnection : SynapseDataConnectionData
    {
        /// <summary> Initializes a new instance of SynapseEventHubDataConnection. </summary>
        public SynapseEventHubDataConnection()
        {
            EventSystemProperties = new Core.ChangeTrackingList<string>();
            Kind = SynapseDataConnectionKind.EventHub;
        }

        /// <summary> Initializes a new instance of SynapseEventHubDataConnection. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the endpoint for the data connection. </param>
        /// <param name="eventHubResourceId"> The resource ID of the event hub to be used to create a data connection. </param>
        /// <param name="consumerGroup"> The event hub consumer group. </param>
        /// <param name="tableName"> The table where the data should be ingested. Optionally the table information can be added to each message. </param>
        /// <param name="mappingRuleName"> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </param>
        /// <param name="dataFormat"> The data format of the message. Optionally the data format can be added to each message. </param>
        /// <param name="eventSystemProperties"> System properties of the event hub. </param>
        /// <param name="compression"> The event hub messages compression type. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="managedIdentityResourceId"> The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub. </param>
        internal SynapseEventHubDataConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, SynapseDataConnectionKind kind, ResourceIdentifier eventHubResourceId, string consumerGroup, string tableName, string mappingRuleName, SynapseEventHubDataFormat? dataFormat, IList<string> eventSystemProperties, KustoPoolCompressionType? compression, ResourceProvisioningState? provisioningState, ResourceIdentifier managedIdentityResourceId) : base(id, name, resourceType, systemData, location, kind)
        {
            EventHubResourceId = eventHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            EventSystemProperties = eventSystemProperties;
            Compression = compression;
            ProvisioningState = provisioningState;
            ManagedIdentityResourceId = managedIdentityResourceId;
            Kind = kind;
        }

        /// <summary> The resource ID of the event hub to be used to create a data connection. </summary>
        public ResourceIdentifier EventHubResourceId { get; set; }
        /// <summary> The event hub consumer group. </summary>
        public string ConsumerGroup { get; set; }
        /// <summary> The table where the data should be ingested. Optionally the table information can be added to each message. </summary>
        public string TableName { get; set; }
        /// <summary> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </summary>
        public string MappingRuleName { get; set; }
        /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
        public SynapseEventHubDataFormat? DataFormat { get; set; }
        /// <summary> System properties of the event hub. </summary>
        public IList<string> EventSystemProperties { get; }
        /// <summary> The event hub messages compression type. </summary>
        public KustoPoolCompressionType? Compression { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub. </summary>
        public ResourceIdentifier ManagedIdentityResourceId { get; set; }
    }
}
