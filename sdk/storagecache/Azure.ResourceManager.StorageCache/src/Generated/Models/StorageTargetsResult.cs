// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> A list of Storage Targets. </summary>
    internal partial class StorageTargetsResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageTargetsResult"/>. </summary>
        internal StorageTargetsResult()
        {
            Value = new ChangeTrackingList<StorageTargetData>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageTargetsResult"/>. </summary>
        /// <param name="nextLink"> The URI to fetch the next page of Storage Targets. </param>
        /// <param name="value"> The list of Storage Targets defined for the cache. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTargetsResult(string nextLink, IReadOnlyList<StorageTargetData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URI to fetch the next page of Storage Targets. </summary>
        public string NextLink { get; }
        /// <summary> The list of Storage Targets defined for the cache. </summary>
        public IReadOnlyList<StorageTargetData> Value { get; }
    }
}
