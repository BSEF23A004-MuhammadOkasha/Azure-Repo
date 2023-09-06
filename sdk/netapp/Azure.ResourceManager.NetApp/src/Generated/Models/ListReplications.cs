// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List Replications. </summary>
    internal partial class ListReplications
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListReplications"/>. </summary>
        internal ListReplications()
        {
            Value = new ChangeTrackingList<NetAppVolumeReplication>();
        }

        /// <summary> Initializes a new instance of <see cref="ListReplications"/>. </summary>
        /// <param name="value"> A list of replications. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListReplications(IReadOnlyList<NetAppVolumeReplication> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> A list of replications. </summary>
        public IReadOnlyList<NetAppVolumeReplication> Value { get; }
    }
}
