// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The IngestionStatus. </summary>
    public partial class DataFeedIngestionStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFeedIngestionStatus"/>. </summary>
        /// <param name="timestamp"> data slice timestamp. </param>
        /// <param name="status"> latest ingestion task status for this data slice. </param>
        /// <param name="message"> the trimmed message of last ingestion job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal DataFeedIngestionStatus(DateTimeOffset timestamp, IngestionStatusType status, string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Timestamp = timestamp;
            Status = status;
            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="DataFeedIngestionStatus"/>. </summary>
        /// <param name="timestamp"> data slice timestamp. </param>
        /// <param name="status"> latest ingestion task status for this data slice. </param>
        /// <param name="message"> the trimmed message of last ingestion job. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFeedIngestionStatus(DateTimeOffset timestamp, IngestionStatusType status, string message, Dictionary<string, BinaryData> rawData)
        {
            Timestamp = timestamp;
            Status = status;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFeedIngestionStatus"/> for deserialization. </summary>
        internal DataFeedIngestionStatus()
        {
        }
    }
}
