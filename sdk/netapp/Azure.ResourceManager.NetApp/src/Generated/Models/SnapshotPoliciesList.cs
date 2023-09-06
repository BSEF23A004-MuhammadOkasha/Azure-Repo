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
    /// <summary> List of Snapshot Policies. </summary>
    internal partial class SnapshotPoliciesList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotPoliciesList"/>. </summary>
        internal SnapshotPoliciesList()
        {
            Value = new ChangeTrackingList<SnapshotPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPoliciesList"/>. </summary>
        /// <param name="value"> A list of snapshot policies. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotPoliciesList(IReadOnlyList<SnapshotPolicyData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> A list of snapshot policies. </summary>
        public IReadOnlyList<SnapshotPolicyData> Value { get; }
    }
}
