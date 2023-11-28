// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output of the task that collects user tables for the given list of databases. </summary>
    public partial class GetUserTablesMySqlTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="GetUserTablesMySqlTaskOutput"/>. </summary>
        internal GetUserTablesMySqlTaskOutput()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of <see cref="GetUserTablesMySqlTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="databasesToTables"> Mapping from database name to list of tables. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        internal GetUserTablesMySqlTaskOutput(string id, string databasesToTables, IReadOnlyList<ReportableException> validationErrors)
        {
            Id = id;
            DatabasesToTables = databasesToTables;
            ValidationErrors = validationErrors;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Mapping from database name to list of tables. </summary>
        public string DatabasesToTables { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
