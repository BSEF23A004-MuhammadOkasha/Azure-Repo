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
    /// <summary> The list linked service operation response. </summary>
    internal partial class LinkedServiceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinkedServiceListResult"/>. </summary>
        internal LinkedServiceListResult()
        {
            Value = new ChangeTrackingList<OperationalInsightsLinkedServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="LinkedServiceListResult"/>. </summary>
        /// <param name="value"> The list of linked service instances. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkedServiceListResult(IReadOnlyList<OperationalInsightsLinkedServiceData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of linked service instances. </summary>
        public IReadOnlyList<OperationalInsightsLinkedServiceData> Value { get; }
    }
}
