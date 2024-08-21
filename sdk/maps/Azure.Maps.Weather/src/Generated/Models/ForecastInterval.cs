// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Maps.Weather
{
    /// <summary> The ForecastInterval. </summary>
    public partial class ForecastInterval
    {
        /// <summary> Initializes a new instance of <see cref="ForecastInterval"/>. </summary>
        internal ForecastInterval()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ForecastInterval"/>. </summary>
        /// <param name="startTime"> The date and time for the start of the interval in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </param>
        /// <param name="minute"> The first minute for the interval. </param>
        /// <param name="decibelRelativeToZ"> A unit that represents forecasted precipitation intensity. </param>
        /// <param name="shortDescription"> A short phrase describing precipitation condition for the interval. </param>
        /// <param name="threshold"> Key that specifies the threshold value. Along with precipitationType, can be used to determine the simplifiedColor. If dbz is zero, not present in the response. </param>
        /// <param name="color"> The full spectrum color that maps to the dBZ (decibel relative to Z). If dbz is zero, color is not present in the response. </param>
        /// <param name="simplifiedColor"> The band color that maps to the precipitation type and threshold. If dbz is zero, not present in the response. </param>
        /// <param name="precipitationType"> Specifies the type of precipitation ("Rain" "Snow" "Ice" or "Mix"). If dbz is zero, precipitationType is not present in the response. </param>
        /// <param name="iconCode"> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </param>
        /// <param name="cloudCover"> Percent representing cloud cover. </param>
        internal ForecastInterval(DateTimeOffset? startTime, int? minute, double? decibelRelativeToZ, string shortDescription, string threshold, ColorValue color, ColorValue simplifiedColor, PrecipitationType? precipitationType, IconCode? iconCode, int? cloudCover)
        {
            StartTime = startTime;
            Minute = minute;
            DecibelRelativeToZ = decibelRelativeToZ;
            ShortDescription = shortDescription;
            Threshold = threshold;
            Color = color;
            SimplifiedColor = simplifiedColor;
            PrecipitationType = precipitationType;
            IconCode = iconCode;
            CloudCover = cloudCover;
        }

        /// <summary> The date and time for the start of the interval in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The first minute for the interval. </summary>
        public int? Minute { get; }
        /// <summary> A unit that represents forecasted precipitation intensity. </summary>
        public double? DecibelRelativeToZ { get; }
        /// <summary> A short phrase describing precipitation condition for the interval. </summary>
        public string ShortDescription { get; }
        /// <summary> Key that specifies the threshold value. Along with precipitationType, can be used to determine the simplifiedColor. If dbz is zero, not present in the response. </summary>
        public string Threshold { get; }
        /// <summary> The full spectrum color that maps to the dBZ (decibel relative to Z). If dbz is zero, color is not present in the response. </summary>
        public ColorValue Color { get; }
        /// <summary> The band color that maps to the precipitation type and threshold. If dbz is zero, not present in the response. </summary>
        public ColorValue SimplifiedColor { get; }
        /// <summary> Specifies the type of precipitation ("Rain" "Snow" "Ice" or "Mix"). If dbz is zero, precipitationType is not present in the response. </summary>
        public PrecipitationType? PrecipitationType { get; }
        /// <summary> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </summary>
        public IconCode? IconCode { get; }
        /// <summary> Percent representing cloud cover. </summary>
        public int? CloudCover { get; }
    }
}
