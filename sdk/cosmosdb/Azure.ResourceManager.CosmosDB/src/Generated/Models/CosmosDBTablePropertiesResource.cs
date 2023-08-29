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
    /// <summary> The CosmosDBTablePropertiesResource. </summary>
    public partial class CosmosDBTablePropertiesResource : CosmosDBTableResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBTablePropertiesResource"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public CosmosDBTablePropertiesResource(string tableName) : base(tableName)
        {
            Argument.AssertNotNull(tableName, nameof(tableName));
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBTablePropertiesResource"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB table. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBTablePropertiesResource(string tableName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, string rid, float? timestamp, ETag? etag, Dictionary<string, BinaryData> rawData) : base(tableName, restoreParameters, createMode, rawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBTablePropertiesResource"/> for deserialization. </summary>
        internal CosmosDBTablePropertiesResource()
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
