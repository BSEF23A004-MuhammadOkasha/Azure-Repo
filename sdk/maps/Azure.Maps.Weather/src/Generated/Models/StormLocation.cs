// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.Weather
{
    /// <summary> Location for an individual Government-issued storm. </summary>
    public partial class StormLocation
    {
        /// <summary> Initializes a new instance of <see cref="StormLocation"/>. </summary>
        internal StormLocation()
        {
            WindRadiiSummary = new ChangeTrackingList<StormWindRadiiSummary>();
        }

        /// <summary> Initializes a new instance of <see cref="StormLocation"/>. </summary>
        /// <param name="timestamp"> Datetime the forecast is valid, displayed in ISO8601 format. </param>
        /// <param name="coordinates"> Coordinates of the storm. </param>
        /// <param name="maxWindGust"> Maximum wind gust speed associated with the storm. May be NULL. </param>
        /// <param name="sustainedWind"> Maximum sustained wind speed associated with the storm. May be NULL. </param>
        /// <param name="minimumPressure"> Minimum pressure associated with the storm. May be NULL. </param>
        /// <param name="movement"> The storm movement information. </param>
        /// <param name="status"> Storm status, in English. </param>
        /// <param name="isSubtropical"> True when the depression is classified as a subtropical cyclone. </param>
        /// <param name="hasTropicalPotential"> True when storm may develop into a Tropical System. </param>
        /// <param name="isPostTropical"> True when the storm is weakening away, and will no longer become a tropical system. </param>
        /// <param name="windRadiiSummary"> Displayed when details=true or radiiGeometry=true in the request. </param>
        internal StormLocation(string timestamp, LatLongPair coordinates, WeatherValue maxWindGust, WeatherValue sustainedWind, WeatherValue minimumPressure, WindDetails movement, string status, bool? isSubtropical, bool? hasTropicalPotential, bool? isPostTropical, IReadOnlyList<StormWindRadiiSummary> windRadiiSummary)
        {
            Timestamp = timestamp;
            Coordinates = coordinates;
            MaxWindGust = maxWindGust;
            SustainedWind = sustainedWind;
            MinimumPressure = minimumPressure;
            Movement = movement;
            Status = status;
            IsSubtropical = isSubtropical;
            HasTropicalPotential = hasTropicalPotential;
            IsPostTropical = isPostTropical;
            WindRadiiSummary = windRadiiSummary;
        }

        /// <summary> Datetime the forecast is valid, displayed in ISO8601 format. </summary>
        public string Timestamp { get; }
        /// <summary> Coordinates of the storm. </summary>
        public LatLongPair Coordinates { get; }
        /// <summary> Maximum wind gust speed associated with the storm. May be NULL. </summary>
        public WeatherValue MaxWindGust { get; }
        /// <summary> Maximum sustained wind speed associated with the storm. May be NULL. </summary>
        public WeatherValue SustainedWind { get; }
        /// <summary> Minimum pressure associated with the storm. May be NULL. </summary>
        public WeatherValue MinimumPressure { get; }
        /// <summary> The storm movement information. </summary>
        public WindDetails Movement { get; }
        /// <summary> Storm status, in English. </summary>
        public string Status { get; }
        /// <summary> True when the depression is classified as a subtropical cyclone. </summary>
        public bool? IsSubtropical { get; }
        /// <summary> True when storm may develop into a Tropical System. </summary>
        public bool? HasTropicalPotential { get; }
        /// <summary> True when the storm is weakening away, and will no longer become a tropical system. </summary>
        public bool? IsPostTropical { get; }
        /// <summary> Displayed when details=true or radiiGeometry=true in the request. </summary>
        public IReadOnlyList<StormWindRadiiSummary> WindRadiiSummary { get; }
    }
}
