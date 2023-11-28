// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL database resource object. </summary>
    public partial class CosmosDBSqlDatabaseResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB SQL database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public CosmosDBSqlDatabaseResourceInfo(string databaseName)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            DatabaseName = databaseName;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB SQL database. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        internal CosmosDBSqlDatabaseResourceInfo(string databaseName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode)
        {
            DatabaseName = databaseName;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
        }

        /// <summary> Name of the Cosmos DB SQL database. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public ResourceRestoreParameters RestoreParameters { get; set; }
        /// <summary> Enum to indicate the mode of resource creation. </summary>
        public CosmosDBAccountCreateMode? CreateMode { get; set; }
    }
}
