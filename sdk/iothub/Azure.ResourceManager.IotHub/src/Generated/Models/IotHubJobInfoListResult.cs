// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The JSON-serialized array of JobResponse objects with a next link. </summary>
    internal partial class IotHubJobInfoListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubJobInfoListResult"/>. </summary>
        internal IotHubJobInfoListResult()
        {
            Value = new ChangeTrackingList<IotHubJobInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="IotHubJobInfoListResult"/>. </summary>
        /// <param name="value"> The array of JobResponse objects. </param>
        /// <param name="nextLink"> The next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubJobInfoListResult(IReadOnlyList<IotHubJobInfo> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The array of JobResponse objects. </summary>
        public IReadOnlyList<IotHubJobInfo> Value { get; }
        /// <summary> The next link. </summary>
        public string NextLink { get; }
    }
}
