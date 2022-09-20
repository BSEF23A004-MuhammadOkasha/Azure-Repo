// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The tracking events definition. </summary>
    public partial class IntegrationAccountTrackingEventsContent
    {
        /// <summary> Initializes a new instance of IntegrationAccountTrackingEventsContent. </summary>
        /// <param name="sourceType"> The source type. </param>
        /// <param name="events"> The events. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceType"/> or <paramref name="events"/> is null. </exception>
        public IntegrationAccountTrackingEventsContent(string sourceType, IEnumerable<IntegrationAccountTrackingEvent> events)
        {
            if (sourceType == null)
            {
                throw new ArgumentNullException(nameof(sourceType));
            }
            if (events == null)
            {
                throw new ArgumentNullException(nameof(events));
            }

            SourceType = sourceType;
            Events = events.ToList();
        }

        /// <summary> The source type. </summary>
        public string SourceType { get; }
        /// <summary> The track events options. </summary>
        public IntegrationAccountTrackEventOperationOption? TrackEventsOptions { get; set; }
        /// <summary> The events. </summary>
        public IList<IntegrationAccountTrackingEvent> Events { get; }
    }
}
