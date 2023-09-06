// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DimensionGroupIdentity. </summary>
    public partial class DimensionKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DimensionKey"/>. </summary>
        /// <param name="dimension"> dimension specified for series group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DimensionKey(IDictionary<string, string> dimension, Dictionary<string, BinaryData> rawData)
        {
            Dimension = dimension;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DimensionKey"/> for deserialization. </summary>
        internal DimensionKey()
        {
        }
    }
}
