// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The IngestionStatusList. </summary>
    internal partial class IngestionStatusList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IngestionStatusList"/>. </summary>
        internal IngestionStatusList()
        {
            Value = new ChangeTrackingList<DataFeedIngestionStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="IngestionStatusList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IngestionStatusList(string nextLink, IReadOnlyList<DataFeedIngestionStatus> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<DataFeedIngestionStatus> Value { get; }
    }
}
