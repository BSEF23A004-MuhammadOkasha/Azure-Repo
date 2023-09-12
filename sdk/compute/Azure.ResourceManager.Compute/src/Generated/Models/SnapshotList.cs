// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Snapshots operation response. </summary>
    internal partial class SnapshotList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotList"/>. </summary>
        /// <param name="value"> A list of snapshots. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SnapshotList(IEnumerable<SnapshotData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotList"/>. </summary>
        /// <param name="value"> A list of snapshots. </param>
        /// <param name="nextLink"> The uri to fetch the next page of snapshots. Call ListNext() with this to fetch the next page of snapshots. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotList(IReadOnlyList<SnapshotData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotList"/> for deserialization. </summary>
        internal SnapshotList()
        {
        }

        /// <summary> A list of snapshots. </summary>
        public IReadOnlyList<SnapshotData> Value { get; }
        /// <summary> The uri to fetch the next page of snapshots. Call ListNext() with this to fetch the next page of snapshots. </summary>
        public string NextLink { get; }
    }
}
