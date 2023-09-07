// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Properties of the Streaming Locator. </summary>
    public partial class MediaAssetStreamingLocator
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaAssetStreamingLocator"/>. </summary>
        internal MediaAssetStreamingLocator()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaAssetStreamingLocator"/>. </summary>
        /// <param name="name"> Streaming Locator name. </param>
        /// <param name="assetName"> Asset Name. </param>
        /// <param name="createdOn"> The creation time of the Streaming Locator. </param>
        /// <param name="startOn"> The start time of the Streaming Locator. </param>
        /// <param name="endOn"> The end time of the Streaming Locator. </param>
        /// <param name="streamingLocatorId"> StreamingLocatorId of the Streaming Locator. </param>
        /// <param name="streamingPolicyName"> Name of the Streaming Policy used by this Streaming Locator. </param>
        /// <param name="defaultContentKeyPolicyName"> Name of the default ContentKeyPolicy used by this Streaming Locator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaAssetStreamingLocator(string name, string assetName, DateTimeOffset? createdOn, DateTimeOffset? startOn, DateTimeOffset? endOn, Guid? streamingLocatorId, string streamingPolicyName, string defaultContentKeyPolicyName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AssetName = assetName;
            CreatedOn = createdOn;
            StartOn = startOn;
            EndOn = endOn;
            StreamingLocatorId = streamingLocatorId;
            StreamingPolicyName = streamingPolicyName;
            DefaultContentKeyPolicyName = defaultContentKeyPolicyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Streaming Locator name. </summary>
        public string Name { get; }
        /// <summary> Asset Name. </summary>
        public string AssetName { get; }
        /// <summary> The creation time of the Streaming Locator. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The start time of the Streaming Locator. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the Streaming Locator. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> StreamingLocatorId of the Streaming Locator. </summary>
        public Guid? StreamingLocatorId { get; }
        /// <summary> Name of the Streaming Policy used by this Streaming Locator. </summary>
        public string StreamingPolicyName { get; }
        /// <summary> Name of the default ContentKeyPolicy used by this Streaming Locator. </summary>
        public string DefaultContentKeyPolicyName { get; }
    }
}
