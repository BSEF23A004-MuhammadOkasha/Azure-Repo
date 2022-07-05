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
    /// <summary> A class representing the EventHubsSchemaGroup data model. </summary>
    public partial class EventHubsSchemaGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of EventHubsSchemaGroupData. </summary>
        public EventHubsSchemaGroupData()
        {
            GroupProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of EventHubsSchemaGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="updatedAtUtc"> Exact time the Schema Group was updated. </param>
        /// <param name="createdAtUtc"> Exact time the Schema Group was created. </param>
        /// <param name="eTag"> The ETag value. </param>
        /// <param name="groupProperties"> dictionary object for SchemaGroup group properties. </param>
        /// <param name="schemaCompatibility"></param>
        /// <param name="schemaType"></param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal EventHubsSchemaGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? updatedAtUtc, DateTimeOffset? createdAtUtc, Guid? eTag, IDictionary<string, string> groupProperties, SchemaCompatibility? schemaCompatibility, SchemaType? schemaType, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            UpdatedAtUtc = updatedAtUtc;
            CreatedAtUtc = createdAtUtc;
            ETag = eTag;
            GroupProperties = groupProperties;
            SchemaCompatibility = schemaCompatibility;
            SchemaType = schemaType;
            Location = location;
        }

        /// <summary> Exact time the Schema Group was updated. </summary>
        public DateTimeOffset? UpdatedAtUtc { get; }
        /// <summary> Exact time the Schema Group was created. </summary>
        public DateTimeOffset? CreatedAtUtc { get; }
        /// <summary> The ETag value. </summary>
        public Guid? ETag { get; }
        /// <summary> dictionary object for SchemaGroup group properties. </summary>
        public IDictionary<string, string> GroupProperties { get; }
        /// <summary> Gets or sets the schema compatibility. </summary>
        public SchemaCompatibility? SchemaCompatibility { get; set; }
        /// <summary> Gets or sets the schema type. </summary>
        public SchemaType? SchemaType { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
