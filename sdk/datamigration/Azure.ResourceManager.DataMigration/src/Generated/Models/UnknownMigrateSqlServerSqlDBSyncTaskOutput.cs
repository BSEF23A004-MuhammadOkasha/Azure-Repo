// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The UnknownMigrateSqlServerSqlDBSyncTaskOutput. </summary>
    internal partial class UnknownMigrateSqlServerSqlDBSyncTaskOutput : MigrateSqlServerSqlDBSyncTaskOutput
    {
        /// <summary> Initializes a new instance of UnknownMigrateSqlServerSqlDBSyncTaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        internal UnknownMigrateSqlServerSqlDBSyncTaskOutput(string id, string resultType) : base(id, resultType)
        {
            ResultType = resultType ?? "Unknown";
        }
    }
}
