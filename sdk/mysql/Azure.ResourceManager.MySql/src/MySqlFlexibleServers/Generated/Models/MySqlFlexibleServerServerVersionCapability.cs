// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Server version capabilities. </summary>
    public partial class MySqlFlexibleServerServerVersionCapability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerServerVersionCapability"/>. </summary>
        internal MySqlFlexibleServerServerVersionCapability()
        {
            SupportedSkus = new ChangeTrackingList<MySqlFlexibleServerSkuCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerServerVersionCapability"/>. </summary>
        /// <param name="name"> server version. </param>
        /// <param name="supportedSkus"> A list of supported Skus. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerServerVersionCapability(string name, IReadOnlyList<MySqlFlexibleServerSkuCapability> supportedSkus, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            SupportedSkus = supportedSkus;
            _rawData = rawData;
        }

        /// <summary> server version. </summary>
        public string Name { get; }
        /// <summary> A list of supported Skus. </summary>
        public IReadOnlyList<MySqlFlexibleServerSkuCapability> SupportedSkus { get; }
    }
}
