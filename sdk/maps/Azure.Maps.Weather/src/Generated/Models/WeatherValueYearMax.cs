// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> Returned temperature values. </summary>
    public partial class WeatherValueYearMax
    {
        /// <summary> Initializes a new instance of <see cref="WeatherValueYearMax"/>. </summary>
        internal WeatherValueYearMax()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WeatherValueYearMax"/>. </summary>
        /// <param name="maximum"> Maximum temperature for the time period. </param>
        internal WeatherValueYearMax(WeatherValueYear maximum)
        {
            Maximum = maximum;
        }

        /// <summary> Maximum temperature for the time period. </summary>
        public WeatherValueYear Maximum { get; }
    }
}
