// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing the PostgreSqlDatabase data model.
    /// Represents a Database.
    /// </summary>
    public partial class PostgreSqlDatabaseData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlDatabaseData"/>. </summary>
        public PostgreSqlDatabaseData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlDatabaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="charset"> The charset of the database. </param>
        /// <param name="collation"> The collation of the database. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlDatabaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string charset, string collation, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Charset = charset;
            Collation = collation;
            _rawData = rawData;
        }

        /// <summary> The charset of the database. </summary>
        public string Charset { get; set; }
        /// <summary> The collation of the database. </summary>
        public string Collation { get; set; }
    }
}
