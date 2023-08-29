// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput. </summary>
    internal partial class UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput : MigrateOracleAzureDBPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput(string id, string resultType, Dictionary<string, BinaryData> rawData) : base(id, resultType, rawData)
        {
            ResultType = resultType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput"/> for deserialization. </summary>
        internal UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput()
        {
        }
    }
}
