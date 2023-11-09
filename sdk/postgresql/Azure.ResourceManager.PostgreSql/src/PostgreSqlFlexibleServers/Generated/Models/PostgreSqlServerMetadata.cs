// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Database server metadata. </summary>
    public partial class PostgreSqlServerMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerMetadata"/>. </summary>
        internal PostgreSqlServerMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerMetadata"/>. </summary>
        /// <param name="location"> Location of database server. </param>
        /// <param name="version"> Version for database engine. </param>
        /// <param name="storageMb"> Storage size in MB for database server. </param>
        /// <param name="sku"> SKU for the database server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlServerMetadata(AzureLocation? location, string version, int? storageMb, ServerSku sku, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Version = version;
            StorageMb = storageMb;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Location of database server. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Version for database engine. </summary>
        public string Version { get; }
        /// <summary> Storage size in MB for database server. </summary>
        public int? StorageMb { get; }
        /// <summary> SKU for the database server. </summary>
        public ServerSku Sku { get; }
    }
}
