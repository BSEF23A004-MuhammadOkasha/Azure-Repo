// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureCosmosDBParameter. </summary>
    internal partial class AzureCosmosDBParameter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBParameter"/>. </summary>
        /// <param name="sqlQuery"> The statement to query this collection. </param>
        /// <param name="database"> A database name in this Azure CosmosDB. </param>
        /// <param name="collectionId"> A collection id in this database. </param>
        public AzureCosmosDBParameter(string sqlQuery, string database, string collectionId)
        {
            SqlQuery = sqlQuery;
            Database = database;
            CollectionId = collectionId;
        }

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBParameter"/>. </summary>
        /// <param name="connectionString"> The connection string of this Azure CosmosDB. </param>
        /// <param name="sqlQuery"> The statement to query this collection. </param>
        /// <param name="database"> A database name in this Azure CosmosDB. </param>
        /// <param name="collectionId"> A collection id in this database. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureCosmosDBParameter(string connectionString, string sqlQuery, string database, string collectionId, Dictionary<string, BinaryData> rawData)
        {
            ConnectionString = connectionString;
            SqlQuery = sqlQuery;
            Database = database;
            CollectionId = collectionId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBParameter"/> for deserialization. </summary>
        internal AzureCosmosDBParameter()
        {
        }

        /// <summary> The connection string of this Azure CosmosDB. </summary>
        public string ConnectionString { get; set; }
        /// <summary> The statement to query this collection. </summary>
        public string SqlQuery { get; set; }
        /// <summary> A database name in this Azure CosmosDB. </summary>
        public string Database { get; set; }
        /// <summary> A collection id in this database. </summary>
        public string CollectionId { get; set; }
    }
}
