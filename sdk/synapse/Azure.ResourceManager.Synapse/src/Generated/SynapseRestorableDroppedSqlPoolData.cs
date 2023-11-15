// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseRestorableDroppedSqlPool data model.
    /// A restorable dropped Sql pool
    /// </summary>
    public partial class SynapseRestorableDroppedSqlPoolData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseRestorableDroppedSqlPoolData"/>. </summary>
        public SynapseRestorableDroppedSqlPoolData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseRestorableDroppedSqlPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="edition"> The edition of the database. </param>
        /// <param name="maxSizeBytes"> The max size in bytes of the database. </param>
        /// <param name="serviceLevelObjective"> The service level objective name of the database. </param>
        /// <param name="elasticPoolName"> The elastic pool name of the database. </param>
        /// <param name="createdOn"> The creation date of the database (ISO8601 format). </param>
        /// <param name="deletedOn"> The deletion date of the database (ISO8601 format). </param>
        /// <param name="earliestRestoreOn"> The earliest restore date of the database (ISO8601 format). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseRestorableDroppedSqlPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string databaseName, string edition, string maxSizeBytes, string serviceLevelObjective, string elasticPoolName, DateTimeOffset? createdOn, DateTimeOffset? deletedOn, DateTimeOffset? earliestRestoreOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            DatabaseName = databaseName;
            Edition = edition;
            MaxSizeBytes = maxSizeBytes;
            ServiceLevelObjective = serviceLevelObjective;
            ElasticPoolName = elasticPoolName;
            CreatedOn = createdOn;
            DeletedOn = deletedOn;
            EarliestRestoreOn = earliestRestoreOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The name of the database. </summary>
        public string DatabaseName { get; }
        /// <summary> The edition of the database. </summary>
        public string Edition { get; }
        /// <summary> The max size in bytes of the database. </summary>
        public string MaxSizeBytes { get; }
        /// <summary> The service level objective name of the database. </summary>
        public string ServiceLevelObjective { get; }
        /// <summary> The elastic pool name of the database. </summary>
        public string ElasticPoolName { get; }
        /// <summary> The creation date of the database (ISO8601 format). </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The deletion date of the database (ISO8601 format). </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The earliest restore date of the database (ISO8601 format). </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
    }
}
