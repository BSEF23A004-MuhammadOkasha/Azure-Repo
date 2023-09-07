// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The Streaming Locators associated with this Asset. </summary>
    internal partial class ListStreamingLocatorsResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListStreamingLocatorsResponse"/>. </summary>
        internal ListStreamingLocatorsResponse()
        {
            StreamingLocators = new ChangeTrackingList<MediaAssetStreamingLocator>();
        }

        /// <summary> Initializes a new instance of <see cref="ListStreamingLocatorsResponse"/>. </summary>
        /// <param name="streamingLocators"> The list of Streaming Locators. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListStreamingLocatorsResponse(IReadOnlyList<MediaAssetStreamingLocator> streamingLocators, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StreamingLocators = streamingLocators;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of Streaming Locators. </summary>
        public IReadOnlyList<MediaAssetStreamingLocator> StreamingLocators { get; }
    }
}
