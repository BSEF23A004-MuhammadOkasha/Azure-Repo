// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Filter First Quality. </summary>
    internal partial class FirstQuality
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FirstQuality"/>. </summary>
        /// <param name="bitrate"> The first quality bitrate. </param>
        public FirstQuality(int bitrate)
        {
            Bitrate = bitrate;
        }

        /// <summary> Initializes a new instance of <see cref="FirstQuality"/>. </summary>
        /// <param name="bitrate"> The first quality bitrate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirstQuality(int bitrate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Bitrate = bitrate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FirstQuality"/> for deserialization. </summary>
        internal FirstQuality()
        {
        }

        /// <summary> The first quality bitrate. </summary>
        public int Bitrate { get; set; }
    }
}
