// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.Weather
{
    /// <summary> Information about the air quality in a specific location at a specific time. </summary>
    public partial class AirQuality
    {
        /// <summary> Initializes a new instance of <see cref="AirQuality"/>. </summary>
        internal AirQuality()
        {
            Pollutants = new ChangeTrackingList<Pollutant>();
        }

        /// <summary> Initializes a new instance of <see cref="AirQuality"/>. </summary>
        /// <param name="timestamp"> Date and time of the current observation displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </param>
        /// <param name="index"> Air quality rating on a scale set by local regulating bodies. Scales can vary widely based on location. See [Wikipedia](https://en.wikipedia.org/wiki/Air_quality_index) for more information. </param>
        /// <param name="globalIndex"> Internationally normalized air quality rating on a scale from 0 to 300 and up, with higher numbers representing worse air quality. </param>
        /// <param name="dominantPollutant"> The pollutant with the highest concentration. </param>
        /// <param name="category"> One-word description of the air quality in the requested language. For example, "Excellent". </param>
        /// <param name="categoryColor"> A unique color corresponding to the category of this air quality result. </param>
        /// <param name="description"> A textual explanation of this air quality result in the requested language. </param>
        /// <param name="pollutants"> Information about individual pollutants. </param>
        internal AirQuality(DateTimeOffset? timestamp, float? index, float? globalIndex, DominantPollutant? dominantPollutant, string category, string categoryColor, string description, IReadOnlyList<Pollutant> pollutants)
        {
            Timestamp = timestamp;
            Index = index;
            GlobalIndex = globalIndex;
            DominantPollutant = dominantPollutant;
            Category = category;
            CategoryColor = categoryColor;
            Description = description;
            Pollutants = pollutants;
        }

        /// <summary> Date and time of the current observation displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Air quality rating on a scale set by local regulating bodies. Scales can vary widely based on location. See [Wikipedia](https://en.wikipedia.org/wiki/Air_quality_index) for more information. </summary>
        public float? Index { get; }
        /// <summary> Internationally normalized air quality rating on a scale from 0 to 300 and up, with higher numbers representing worse air quality. </summary>
        public float? GlobalIndex { get; }
        /// <summary> The pollutant with the highest concentration. </summary>
        public DominantPollutant? DominantPollutant { get; }
        /// <summary> One-word description of the air quality in the requested language. For example, "Excellent". </summary>
        public string Category { get; }
        /// <summary> A unique color corresponding to the category of this air quality result. </summary>
        public string CategoryColor { get; }
        /// <summary> A textual explanation of this air quality result in the requested language. </summary>
        public string Description { get; }
        /// <summary> Information about individual pollutants. </summary>
        public IReadOnlyList<Pollutant> Pollutants { get; }
    }
}
