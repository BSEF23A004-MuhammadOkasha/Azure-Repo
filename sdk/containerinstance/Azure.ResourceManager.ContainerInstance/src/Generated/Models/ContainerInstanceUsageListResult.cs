// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The response containing the usage data. </summary>
    internal partial class ContainerInstanceUsageListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceUsageListResult"/>. </summary>
        internal ContainerInstanceUsageListResult()
        {
            Value = new ChangeTrackingList<ContainerInstanceUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceUsageListResult"/>. </summary>
        /// <param name="value"> The usage data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerInstanceUsageListResult(IReadOnlyList<ContainerInstanceUsage> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The usage data. </summary>
        public IReadOnlyList<ContainerInstanceUsage> Value { get; }
    }
}
