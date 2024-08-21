// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather
{
    /// <summary> Short summary of the weather along the route. </summary>
    public partial class WeatherAlongRouteSummary
    {
        /// <summary> Initializes a new instance of <see cref="WeatherAlongRouteSummary"/>. </summary>
        internal WeatherAlongRouteSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WeatherAlongRouteSummary"/>. </summary>
        /// <param name="iconCode"> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </param>
        /// <param name="hazards"> Description of the weather hazard affecting the trip. </param>
        internal WeatherAlongRouteSummary(IconCode? iconCode, WeatherHazards hazards)
        {
            IconCode = iconCode;
            Hazards = hazards;
        }

        /// <summary> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </summary>
        public IconCode? IconCode { get; }
        /// <summary> Description of the weather hazard affecting the trip. </summary>
        public WeatherHazards Hazards { get; }
    }
}
