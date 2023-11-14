// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Server edition capabilities. </summary>
    public partial class MySqlFlexibleServerEditionCapability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerEditionCapability"/>. </summary>
        internal MySqlFlexibleServerEditionCapability()
        {
            SupportedStorageEditions = new ChangeTrackingList<MySqlFlexibleServerStorageEditionCapability>();
            SupportedServerVersions = new ChangeTrackingList<MySqlFlexibleServerServerVersionCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerEditionCapability"/>. </summary>
        /// <param name="name"> Server edition name. </param>
        /// <param name="supportedStorageEditions"> A list of supported storage editions. </param>
        /// <param name="supportedServerVersions"> A list of supported server versions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerEditionCapability(string name, IReadOnlyList<MySqlFlexibleServerStorageEditionCapability> supportedStorageEditions, IReadOnlyList<MySqlFlexibleServerServerVersionCapability> supportedServerVersions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SupportedStorageEditions = supportedStorageEditions;
            SupportedServerVersions = supportedServerVersions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Server edition name. </summary>
        public string Name { get; }
        /// <summary> A list of supported storage editions. </summary>
        public IReadOnlyList<MySqlFlexibleServerStorageEditionCapability> SupportedStorageEditions { get; }
        /// <summary> A list of supported server versions. </summary>
        public IReadOnlyList<MySqlFlexibleServerServerVersionCapability> SupportedServerVersions { get; }
    }
}
