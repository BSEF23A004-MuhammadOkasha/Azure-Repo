// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary>
    /// Output for task that migrates SQL Server databases to Azure SQL Database Managed Instance.
    /// Please note <see cref="MigrateSqlServerSqlMITaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MigrateSqlServerSqlMITaskOutputAgentJobLevel"/>, <see cref="MigrateSqlServerSqlMITaskOutputDatabaseLevel"/>, <see cref="MigrateSqlServerSqlMITaskOutputError"/>, <see cref="MigrateSqlServerSqlMITaskOutputLoginLevel"/> and <see cref="MigrateSqlServerSqlMITaskOutputMigrationLevel"/>.
    /// </summary>
    public abstract partial class MigrateSqlServerSqlMITaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMITaskOutput"/>. </summary>
        protected MigrateSqlServerSqlMITaskOutput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMITaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        internal MigrateSqlServerSqlMITaskOutput(string id, string resultType)
        {
            Id = id;
            ResultType = resultType;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Result type. </summary>
        internal string ResultType { get; set; }
    }
}
