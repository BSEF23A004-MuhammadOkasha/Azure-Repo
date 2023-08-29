// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes the input to the 'cancel' and 'restart' MongoDB migration commands. </summary>
    public partial class MongoDBCommandInput
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBCommandInput"/>. </summary>
        public MongoDBCommandInput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCommandInput"/>. </summary>
        /// <param name="objectName"> The qualified name of a database or collection to act upon, or null to act upon the entire migration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBCommandInput(string objectName, Dictionary<string, BinaryData> rawData)
        {
            ObjectName = objectName;
            _rawData = rawData;
        }

        /// <summary> The qualified name of a database or collection to act upon, or null to act upon the entire migration. </summary>
        public string ObjectName { get; set; }
    }
}
