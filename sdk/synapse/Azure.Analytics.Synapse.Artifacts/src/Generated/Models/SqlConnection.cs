// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The connection used to execute the SQL script. </summary>
    public partial class SqlConnection
    {
        /// <summary> Initializes a new instance of SqlConnection. </summary>
        public SqlConnection()
        {
            AdditionalProperties = new Core.ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of SqlConnection. </summary>
        /// <param name="type"> The type of the connection. </param>
        /// <param name="name"> The identifier of the connection. </param>
        /// <param name="poolName"> The associated SQL pool name (supported by SQL pool v3). </param>
        /// <param name="databaseName"> The associated database name (supported by SQL pool v3). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SqlConnection(SqlConnectionType? type, string name, string poolName, string databaseName, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            Name = name;
            PoolName = poolName;
            DatabaseName = databaseName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The type of the connection. </summary>
        public SqlConnectionType? Type { get; set; }
        /// <summary> The identifier of the connection. </summary>
        public string Name { get; set; }
        /// <summary> The associated SQL pool name (supported by SQL pool v3). </summary>
        public string PoolName { get; set; }
        /// <summary> The associated database name (supported by SQL pool v3). </summary>
        public string DatabaseName { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
