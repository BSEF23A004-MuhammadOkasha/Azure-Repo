// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather
{
    /// <summary> Returned temperature values. </summary>
    public partial class WeatherValueYearMaxMinAvg
    {
        /// <summary> Initializes a new instance of <see cref="WeatherValueYearMaxMinAvg"/>. </summary>
        internal WeatherValueYearMaxMinAvg()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WeatherValueYearMaxMinAvg"/>. </summary>
        /// <param name="maximum"> Maximum temperature for the time period. </param>
        /// <param name="minimum"> Minimum temperature for the time period. </param>
        /// <param name="average"> Average temperature for the time period. </param>
        internal WeatherValueYearMaxMinAvg(WeatherValueYear maximum, WeatherValueYear minimum, WeatherValue average)
        {
            Maximum = maximum;
            Minimum = minimum;
            Average = average;
        }

        /// <summary> Maximum temperature for the time period. </summary>
        public WeatherValueYear Maximum { get; }
        /// <summary> Minimum temperature for the time period. </summary>
        public WeatherValueYear Minimum { get; }
        /// <summary> Average temperature for the time period. </summary>
        public WeatherValue Average { get; }
    }
}
