// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Event Types operation. </summary>
    internal partial class EventTypesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventTypesListResult"/>. </summary>
        internal EventTypesListResult()
        {
            Value = new ChangeTrackingList<EventTypeUnderTopic>();
        }

        /// <summary> Initializes a new instance of <see cref="EventTypesListResult"/>. </summary>
        /// <param name="value"> A collection of event types. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventTypesListResult(IReadOnlyList<EventTypeUnderTopic> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> A collection of event types. </summary>
        public IReadOnlyList<EventTypeUnderTopic> Value { get; }
    }
}
