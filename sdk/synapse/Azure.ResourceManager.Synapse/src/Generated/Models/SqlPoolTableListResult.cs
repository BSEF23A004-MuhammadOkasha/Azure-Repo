// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of Sql pool tables. </summary>
    internal partial class SqlPoolTableListResult
    {
        /// <summary> Initializes a new instance of SqlPoolTableListResult. </summary>
        internal SqlPoolTableListResult()
        {
            Value = new Core.ChangeTrackingList<SynapseSqlPoolTableData>();
        }

        /// <summary> Initializes a new instance of SqlPoolTableListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SqlPoolTableListResult(IReadOnlyList<SynapseSqlPoolTableData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseSqlPoolTableData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
