// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Sql DW upsert option settings. </summary>
    public partial class SqlDWUpsertSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlDWUpsertSettings"/>. </summary>
        public SqlDWUpsertSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlDWUpsertSettings"/>. </summary>
        /// <param name="interimSchemaName"> Schema name for interim table. Type: string (or Expression with resultType string). </param>
        /// <param name="keys"> Key column names for unique row identification. Type: array of strings (or Expression with resultType array of strings). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlDWUpsertSettings(DataFactoryElement<string> interimSchemaName, DataFactoryElement<IList<string>> keys, Dictionary<string, BinaryData> rawData)
        {
            InterimSchemaName = interimSchemaName;
            Keys = keys;
            _rawData = rawData;
        }

        /// <summary> Schema name for interim table. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> InterimSchemaName { get; set; }
        /// <summary> Key column names for unique row identification. Type: array of strings (or Expression with resultType array of strings). </summary>
        public DataFactoryElement<IList<string>> Keys { get; set; }
    }
}
