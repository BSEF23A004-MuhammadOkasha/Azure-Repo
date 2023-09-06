// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureTableParameterPatch. </summary>
    internal partial class AzureTableParameterPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureTableParameterPatch"/>. </summary>
        public AzureTableParameterPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureTableParameterPatch"/>. </summary>
        /// <param name="connectionString"> The connection string of this Azure Table. </param>
        /// <param name="table"> A table name in this Azure Table. </param>
        /// <param name="query"> The statement to query this table. Please find syntax and details from Azure Table documents. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureTableParameterPatch(string connectionString, string table, string query, Dictionary<string, BinaryData> rawData)
        {
            ConnectionString = connectionString;
            Table = table;
            Query = query;
            _rawData = rawData;
        }

        /// <summary> The connection string of this Azure Table. </summary>
        public string ConnectionString { get; set; }
        /// <summary> A table name in this Azure Table. </summary>
        public string Table { get; set; }
        /// <summary> The statement to query this table. Please find syntax and details from Azure Table documents. </summary>
        public string Query { get; set; }
    }
}
