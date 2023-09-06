// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VolumeList represents a list of volumes. </summary>
    internal partial class VolumeList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VolumeList"/>. </summary>
        internal VolumeList()
        {
            Value = new ChangeTrackingList<NetworkCloudVolumeData>();
        }

        /// <summary> Initializes a new instance of <see cref="VolumeList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of volumes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VolumeList(string nextLink, IReadOnlyList<NetworkCloudVolumeData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of volumes. </summary>
        public IReadOnlyList<NetworkCloudVolumeData> Value { get; }
    }
}
