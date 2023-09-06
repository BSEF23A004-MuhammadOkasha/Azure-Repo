// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Represents a collection of alert rule resources. </summary>
    internal partial class MetricAlertResourceCollection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MetricAlertResourceCollection"/>. </summary>
        internal MetricAlertResourceCollection()
        {
            Value = new ChangeTrackingList<MetricAlertData>();
        }

        /// <summary> Initializes a new instance of <see cref="MetricAlertResourceCollection"/>. </summary>
        /// <param name="value"> the values for the alert rule resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricAlertResourceCollection(IReadOnlyList<MetricAlertData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> the values for the alert rule resources. </summary>
        public IReadOnlyList<MetricAlertData> Value { get; }
    }
}
