// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Collection of Chat Transcripts resources. </summary>
    internal partial class ChatTranscriptsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChatTranscriptsListResult"/>. </summary>
        internal ChatTranscriptsListResult()
        {
            Value = new ChangeTrackingList<ChatTranscriptDetailData>();
        }

        /// <summary> Initializes a new instance of <see cref="ChatTranscriptsListResult"/>. </summary>
        /// <param name="value"> List of Chat Transcripts resources. </param>
        /// <param name="nextLink"> The URI to fetch the next page of Chat Transcripts resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatTranscriptsListResult(IReadOnlyList<ChatTranscriptDetailData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Chat Transcripts resources. </summary>
        public IReadOnlyList<ChatTranscriptDetailData> Value { get; }
        /// <summary> The URI to fetch the next page of Chat Transcripts resources. </summary>
        public string NextLink { get; }
    }
}
