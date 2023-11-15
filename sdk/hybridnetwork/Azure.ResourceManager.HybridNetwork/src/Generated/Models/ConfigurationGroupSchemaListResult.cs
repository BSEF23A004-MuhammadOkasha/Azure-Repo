// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> A list of configuration group schema resources. </summary>
    internal partial class ConfigurationGroupSchemaListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConfigurationGroupSchemaListResult"/>. </summary>
        internal ConfigurationGroupSchemaListResult()
        {
            Value = new ChangeTrackingList<ConfigurationGroupSchemaData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationGroupSchemaListResult"/>. </summary>
        /// <param name="value"> A list of configuration group schema. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigurationGroupSchemaListResult(IReadOnlyList<ConfigurationGroupSchemaData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of configuration group schema. </summary>
        public IReadOnlyList<ConfigurationGroupSchemaData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
