// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing an event hub data connection. </summary>
    public partial class EventHubDataConnection : DataConnectionData
    {
        /// <summary> Initializes a new instance of EventHubDataConnection. </summary>
        public EventHubDataConnection()
        {
            EventSystemProperties = new ChangeTrackingList<string>();
            Kind = DataConnectionKind.EventHub;
        }

        /// <summary> Initializes a new instance of EventHubDataConnection. </summary>
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
        /// <param name="managedIdentityResourceId"> Empty for non-managed identity based data connection. For system assigned identity, provide cluster resource Id.  For user assigned identity (UAI) provide the UAI resource Id. </param>
        /// <param name="managedIdentityObjectId"> The object ID of the managedIdentityResourceId. </param>
        /// <param name="databaseRouting"> Indication for database routing information from the data connection, by default only database routing information is allowed. </param>
        internal EventHubDataConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, DataConnectionKind kind, string eventHubResourceId, string consumerGroup, string tableName, string mappingRuleName, EventHubDataFormat? dataFormat, IList<string> eventSystemProperties, Compression? compression, ProvisioningState? provisioningState, string managedIdentityResourceId, string managedIdentityObjectId, DatabaseRouting? databaseRouting) : base(id, name, resourceType, systemData, location, kind)
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
            ManagedIdentityObjectId = managedIdentityObjectId;
            DatabaseRouting = databaseRouting;
            Kind = kind;
        }

        /// <summary> The resource ID of the event hub to be used to create a data connection. </summary>
        public string EventHubResourceId { get; set; }
        /// <summary> The event hub consumer group. </summary>
        public string ConsumerGroup { get; set; }
        /// <summary> The table where the data should be ingested. Optionally the table information can be added to each message. </summary>
        public string TableName { get; set; }
        /// <summary> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </summary>
        public string MappingRuleName { get; set; }
        /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
        public EventHubDataFormat? DataFormat { get; set; }
        /// <summary> System properties of the event hub. </summary>
        public IList<string> EventSystemProperties { get; }
        /// <summary> The event hub messages compression type. </summary>
        public Compression? Compression { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Empty for non-managed identity based data connection. For system assigned identity, provide cluster resource Id.  For user assigned identity (UAI) provide the UAI resource Id. </summary>
        public string ManagedIdentityResourceId { get; set; }
        /// <summary> The object ID of the managedIdentityResourceId. </summary>
        public string ManagedIdentityObjectId { get; }
        /// <summary> Indication for database routing information from the data connection, by default only database routing information is allowed. </summary>
        public DatabaseRouting? DatabaseRouting { get; set; }
    }
}
