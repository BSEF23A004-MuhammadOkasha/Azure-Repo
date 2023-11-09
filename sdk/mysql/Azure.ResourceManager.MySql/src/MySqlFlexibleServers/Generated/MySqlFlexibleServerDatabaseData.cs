// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing the MySqlFlexibleServerDatabase data model.
    /// Represents a Database.
    /// </summary>
    public partial class MySqlFlexibleServerDatabaseData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerDatabaseData"/>. </summary>
        public MySqlFlexibleServerDatabaseData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerDatabaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="charset"> The charset of the database. </param>
        /// <param name="collation"> The collation of the database. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerDatabaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string charset, string collation, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Charset = charset;
            Collation = collation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The charset of the database. </summary>
        public string Charset { get; set; }
        /// <summary> The collation of the database. </summary>
        public string Collation { get; set; }
    }
}
