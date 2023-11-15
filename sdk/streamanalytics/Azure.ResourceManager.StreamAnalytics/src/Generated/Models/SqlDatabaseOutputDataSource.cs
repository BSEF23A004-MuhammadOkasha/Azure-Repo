// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes an Azure SQL database output data source. </summary>
    public partial class SqlDatabaseOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of <see cref="SqlDatabaseOutputDataSource"/>. </summary>
        public SqlDatabaseOutputDataSource()
        {
            OutputDataSourceType = "Microsoft.Sql/Server/Database";
        }

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseOutputDataSource"/>. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="server"> The name of the SQL server containing the Azure SQL database. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="database"> The name of the Azure SQL database. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="user"> The user name that will be used to connect to the Azure SQL database. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="password"> The password that will be used to connect to the Azure SQL database. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="table"> The name of the table in the Azure SQL database. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="maxBatchCount"> Max Batch count for write to Sql database, the default value is 10,000. Optional on PUT requests. </param>
        /// <param name="maxWriterCount"> Max Writer count, currently only 1(single writer) and 0(based on query partition) are available. Optional on PUT requests. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        internal SqlDatabaseOutputDataSource(string outputDataSourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string server, string database, string user, string password, string table, int? maxBatchCount, int? maxWriterCount, StreamAnalyticsAuthenticationMode? authenticationMode) : base(outputDataSourceType, serializedAdditionalRawData)
        {
            Server = server;
            Database = database;
            User = user;
            Password = password;
            Table = table;
            MaxBatchCount = maxBatchCount;
            MaxWriterCount = maxWriterCount;
            AuthenticationMode = authenticationMode;
            OutputDataSourceType = outputDataSourceType ?? "Microsoft.Sql/Server/Database";
        }

        /// <summary> The name of the SQL server containing the Azure SQL database. Required on PUT (CreateOrReplace) requests. </summary>
        public string Server { get; set; }
        /// <summary> The name of the Azure SQL database. Required on PUT (CreateOrReplace) requests. </summary>
        public string Database { get; set; }
        /// <summary> The user name that will be used to connect to the Azure SQL database. Required on PUT (CreateOrReplace) requests. </summary>
        public string User { get; set; }
        /// <summary> The password that will be used to connect to the Azure SQL database. Required on PUT (CreateOrReplace) requests. </summary>
        public string Password { get; set; }
        /// <summary> The name of the table in the Azure SQL database. Required on PUT (CreateOrReplace) requests. </summary>
        public string Table { get; set; }
        /// <summary> Max Batch count for write to Sql database, the default value is 10,000. Optional on PUT requests. </summary>
        public int? MaxBatchCount { get; set; }
        /// <summary> Max Writer count, currently only 1(single writer) and 0(based on query partition) are available. Optional on PUT requests. </summary>
        public int? MaxWriterCount { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
    }
}
