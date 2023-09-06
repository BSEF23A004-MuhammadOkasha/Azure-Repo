// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The list data source by workspace operation response. </summary>
    internal partial class DataSourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataSourceListResult"/>. </summary>
        internal DataSourceListResult()
        {
            Value = new ChangeTrackingList<OperationalInsightsDataSourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataSourceListResult"/>. </summary>
        /// <param name="value"> A list of datasources. </param>
        /// <param name="nextLink"> The link (url) to the next page of datasources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataSourceListResult(IReadOnlyList<OperationalInsightsDataSourceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of datasources. </summary>
        public IReadOnlyList<OperationalInsightsDataSourceData> Value { get; }
        /// <summary> The link (url) to the next page of datasources. </summary>
        public string NextLink { get; }
    }
}
