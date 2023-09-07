// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The EdgePoliciesRequestContent. </summary>
    public partial class EdgePoliciesRequestContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EdgePoliciesRequestContent"/>. </summary>
        public EdgePoliciesRequestContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgePoliciesRequestContent"/>. </summary>
        /// <param name="deviceId"> Unique identifier of the edge device. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgePoliciesRequestContent(string deviceId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeviceId = deviceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique identifier of the edge device. </summary>
        public string DeviceId { get; set; }
    }
}
