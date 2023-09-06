// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volumes associated with snapshot policy. </summary>
    internal partial class SnapshotPolicyVolumeList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyVolumeList"/>. </summary>
        internal SnapshotPolicyVolumeList()
        {
            Value = new ChangeTrackingList<NetAppVolumeData>();
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyVolumeList"/>. </summary>
        /// <param name="value"> List of volumes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotPolicyVolumeList(IReadOnlyList<NetAppVolumeData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of volumes. </summary>
        public IReadOnlyList<NetAppVolumeData> Value { get; }
    }
}
