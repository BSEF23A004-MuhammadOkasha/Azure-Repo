// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SQLSourceParameterPatch. </summary>
    internal partial class SQLSourceParameterPatch
    {
        /// <summary> Initializes a new instance of SQLSourceParameterPatch. </summary>
        /// <param name="query"> The script to query this database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="query"/> is null. </exception>
        public SQLSourceParameterPatch(string query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            Query = query;
        }

        /// <summary> The connection string of this database. </summary>
        public string ConnectionString { get; set; }
        /// <summary> The script to query this database. </summary>
        public string Query { get; }
    }
}
