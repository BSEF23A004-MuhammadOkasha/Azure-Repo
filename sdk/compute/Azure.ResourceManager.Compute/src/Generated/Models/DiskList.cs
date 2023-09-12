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
    /// <summary> The List Disks operation response. </summary>
    internal partial class DiskList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskList"/>. </summary>
        /// <param name="value"> A list of disks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DiskList(IEnumerable<ManagedDiskData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DiskList"/>. </summary>
        /// <param name="value"> A list of disks. </param>
        /// <param name="nextLink"> The uri to fetch the next page of disks. Call ListNext() with this to fetch the next page of disks. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskList(IReadOnlyList<ManagedDiskData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskList"/> for deserialization. </summary>
        internal DiskList()
        {
        }

        /// <summary> A list of disks. </summary>
        public IReadOnlyList<ManagedDiskData> Value { get; }
        /// <summary> The uri to fetch the next page of disks. Call ListNext() with this to fetch the next page of disks. </summary>
        public string NextLink { get; }
    }
}
