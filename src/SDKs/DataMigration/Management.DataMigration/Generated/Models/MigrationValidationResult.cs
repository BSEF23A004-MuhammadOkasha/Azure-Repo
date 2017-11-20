// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Migration Validation Result
    /// </summary>
    public partial class MigrationValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the MigrationValidationResult class.
        /// </summary>
        public MigrationValidationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationValidationResult class.
        /// </summary>
        /// <param name="id">Migration validation result identifier</param>
        /// <param name="migrationId">Migration Identifier</param>
        /// <param name="summaryResults">Validation summary results for each
        /// database</param>
        /// <param name="status">Current status of validation at the migration
        /// level. Status from the database validation result status will be
        /// aggregated here. Possible values include: 'Default', 'NotStarted',
        /// 'Initialized', 'InProgress', 'Completed', 'CompletedWithIssues',
        /// 'Failed', 'Stopped'</param>
        public MigrationValidationResult(string id = default(string), string migrationId = default(string), IDictionary<string, MigrationValidationDatabaseSummaryResult> summaryResults = default(IDictionary<string, MigrationValidationDatabaseSummaryResult>), ValidationStatus? status = default(ValidationStatus?))
        {
            Id = id;
            MigrationId = migrationId;
            SummaryResults = summaryResults;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets migration validation result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets migration Identifier
        /// </summary>
        [JsonProperty(PropertyName = "migrationId")]
        public string MigrationId { get; private set; }

        /// <summary>
        /// Gets or sets validation summary results for each database
        /// </summary>
        [JsonProperty(PropertyName = "summaryResults")]
        public IDictionary<string, MigrationValidationDatabaseSummaryResult> SummaryResults { get; set; }

        /// <summary>
        /// Gets current status of validation at the migration level. Status
        /// from the database validation result status will be aggregated here.
        /// Possible values include: 'Default', 'NotStarted', 'Initialized',
        /// 'InProgress', 'Completed', 'CompletedWithIssues', 'Failed',
        /// 'Stopped'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ValidationStatus? Status { get; private set; }

    }
}
