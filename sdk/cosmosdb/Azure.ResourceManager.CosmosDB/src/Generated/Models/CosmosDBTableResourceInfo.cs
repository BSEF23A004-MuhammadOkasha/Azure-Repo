// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB table resource object. </summary>
    public partial class CosmosDBTableResourceInfo
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBTableResourceInfo"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public CosmosDBTableResourceInfo(string tableName)
        {
            Argument.AssertNotNull(tableName, nameof(tableName));

            TableName = tableName;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBTableResourceInfo"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB table. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBTableResourceInfo(string tableName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, Dictionary<string, BinaryData> rawData)
        {
            TableName = tableName;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBTableResourceInfo"/> for deserialization. </summary>
        internal CosmosDBTableResourceInfo()
        {
        }

        /// <summary> Name of the Cosmos DB table. </summary>
        public string TableName { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public ResourceRestoreParameters RestoreParameters { get; set; }
        /// <summary> Enum to indicate the mode of resource creation. </summary>
        public CosmosDBAccountCreateMode? CreateMode { get; set; }
    }
}
