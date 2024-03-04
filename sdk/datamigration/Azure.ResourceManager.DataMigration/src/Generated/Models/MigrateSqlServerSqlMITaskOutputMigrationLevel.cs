// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlMITaskOutputMigrationLevel. </summary>
    public partial class MigrateSqlServerSqlMITaskOutputMigrationLevel : MigrateSqlServerSqlMITaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMITaskOutputMigrationLevel"/>. </summary>
        internal MigrateSqlServerSqlMITaskOutputMigrationLevel()
        {
            OrphanedUsersInfo = new ChangeTrackingList<OrphanedUserInfo>();
            ExceptionsAndWarnings = new ChangeTrackingList<ReportableException>();
            ResultType = "MigrationLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMITaskOutputMigrationLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="status"> Current status of migration. </param>
        /// <param name="state"> Current state of migration. </param>
        /// <param name="agentJobs"> Selected agent jobs as a map from name to id. </param>
        /// <param name="logins"> Selected logins as a map from name to id. </param>
        /// <param name="message"> Migration progress message. </param>
        /// <param name="serverRoleResults"> Map of server role migration results. </param>
        /// <param name="orphanedUsersInfo"> List of orphaned users. </param>
        /// <param name="databases"> Selected databases as a map from database name to database id. </param>
        /// <param name="sourceServerVersion"> Source server version. </param>
        /// <param name="sourceServerBrandVersion"> Source server brand version. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="exceptionsAndWarnings"> Migration exceptions and warnings. </param>
        internal MigrateSqlServerSqlMITaskOutputMigrationLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? startedOn, DateTimeOffset? endedOn, MigrationStatus? status, MigrationState? state, string agentJobs, string logins, string message, string serverRoleResults, IReadOnlyList<OrphanedUserInfo> orphanedUsersInfo, string databases, string sourceServerVersion, string sourceServerBrandVersion, string targetServerVersion, string targetServerBrandVersion, IReadOnlyList<ReportableException> exceptionsAndWarnings) : base(id, resultType, serializedAdditionalRawData)
        {
            StartedOn = startedOn;
            EndedOn = endedOn;
            Status = status;
            State = state;
            AgentJobs = agentJobs;
            Logins = logins;
            Message = message;
            ServerRoleResults = serverRoleResults;
            OrphanedUsersInfo = orphanedUsersInfo;
            Databases = databases;
            SourceServerVersion = sourceServerVersion;
            SourceServerBrandVersion = sourceServerBrandVersion;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            ResultType = resultType ?? "MigrationLevelOutput";
        }

        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Current status of migration. </summary>
        public MigrationStatus? Status { get; }
        /// <summary> Current state of migration. </summary>
        public MigrationState? State { get; }
        /// <summary> Selected agent jobs as a map from name to id. </summary>
        public string AgentJobs { get; }
        /// <summary> Selected logins as a map from name to id. </summary>
        public string Logins { get; }
        /// <summary> Migration progress message. </summary>
        public string Message { get; }
        /// <summary> Map of server role migration results. </summary>
        public string ServerRoleResults { get; }
        /// <summary> List of orphaned users. </summary>
        public IReadOnlyList<OrphanedUserInfo> OrphanedUsersInfo { get; }
        /// <summary> Selected databases as a map from database name to database id. </summary>
        public string Databases { get; }
        /// <summary> Source server version. </summary>
        public string SourceServerVersion { get; }
        /// <summary> Source server brand version. </summary>
        public string SourceServerBrandVersion { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Migration exceptions and warnings. </summary>
        public IReadOnlyList<ReportableException> ExceptionsAndWarnings { get; }
    }
}
