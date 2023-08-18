// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of Sql pool schemas. </summary>
    internal partial class SqlPoolSchemaListResult
    {
        /// <summary> Initializes a new instance of SqlPoolSchemaListResult. </summary>
        internal SqlPoolSchemaListResult()
        {
            Value = new Core.ChangeTrackingList<SynapseSqlPoolSchemaData>();
        }

        /// <summary> Initializes a new instance of SqlPoolSchemaListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SqlPoolSchemaListResult(IReadOnlyList<SynapseSqlPoolSchemaData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseSqlPoolSchemaData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
