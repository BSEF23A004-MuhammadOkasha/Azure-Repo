// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MongoDBParameterPatch. </summary>
    internal partial class MongoDBParameterPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBParameterPatch"/>. </summary>
        public MongoDBParameterPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBParameterPatch"/>. </summary>
        /// <param name="connectionString"> The connection string of this MongoDB. </param>
        /// <param name="database"> A database name in this MongoDB. </param>
        /// <param name="command"> The script to query this database. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBParameterPatch(string connectionString, string database, string command, Dictionary<string, BinaryData> rawData)
        {
            ConnectionString = connectionString;
            Database = database;
            Command = command;
            _rawData = rawData;
        }

        /// <summary> The connection string of this MongoDB. </summary>
        public string ConnectionString { get; set; }
        /// <summary> A database name in this MongoDB. </summary>
        public string Database { get; set; }
        /// <summary> The script to query this database. </summary>
        public string Command { get; set; }
    }
}
