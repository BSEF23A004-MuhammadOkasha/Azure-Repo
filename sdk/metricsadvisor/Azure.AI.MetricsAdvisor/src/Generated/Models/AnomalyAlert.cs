// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AlertResult. </summary>
    public partial class AnomalyAlert
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnomalyAlert"/>. </summary>
        /// <param name="id"> alert id. </param>
        /// <param name="timestamp"> anomaly time. </param>
        /// <param name="createdOn"> created time. </param>
        /// <param name="lastModified"> modified time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal AnomalyAlert(string id, DateTimeOffset timestamp, DateTimeOffset createdOn, DateTimeOffset lastModified)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Timestamp = timestamp;
            CreatedOn = createdOn;
            LastModified = lastModified;
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyAlert"/>. </summary>
        /// <param name="id"> alert id. </param>
        /// <param name="timestamp"> anomaly time. </param>
        /// <param name="createdOn"> created time. </param>
        /// <param name="lastModified"> modified time. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnomalyAlert(string id, DateTimeOffset timestamp, DateTimeOffset createdOn, DateTimeOffset lastModified, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Timestamp = timestamp;
            CreatedOn = createdOn;
            LastModified = lastModified;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyAlert"/> for deserialization. </summary>
        internal AnomalyAlert()
        {
        }
    }
}
