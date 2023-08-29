// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedMongoDBDatabaseResourceInfo. </summary>
    public partial class ExtendedMongoDBDatabaseResourceInfo : MongoDBDatabaseResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedMongoDBDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB MongoDB database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public ExtendedMongoDBDatabaseResourceInfo(string databaseName) : base(databaseName)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedMongoDBDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB MongoDB database. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedMongoDBDatabaseResourceInfo(string databaseName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, string rid, float? timestamp, ETag? etag, Dictionary<string, BinaryData> rawData) : base(databaseName, restoreParameters, createMode, rawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedMongoDBDatabaseResourceInfo"/> for deserialization. </summary>
        internal ExtendedMongoDBDatabaseResourceInfo()
        {
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
