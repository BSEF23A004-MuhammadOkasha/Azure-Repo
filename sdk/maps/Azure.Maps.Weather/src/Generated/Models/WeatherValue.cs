// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather
{
    /// <summary> Specific value of a given unit related to weather. </summary>
    public partial class WeatherValue
    {
        /// <summary> Initializes a new instance of <see cref="WeatherValue"/>. </summary>
        internal WeatherValue()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WeatherValue"/>. </summary>
        /// <param name="value"> Rounded value. </param>
        /// <param name="unitLabel"> Type of unit for the returned value. </param>
        /// <param name="unitType"> Numeric ID value associated with the type of unit being displayed. Can be used for unit translation. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#unittype) for details. </param>
        internal WeatherValue(float? value, string unitLabel, UnitType? unitType)
        {
            Value = value;
            UnitLabel = unitLabel;
            UnitType = unitType;
        }

        /// <summary> Rounded value. </summary>
        public float? Value { get; }
        /// <summary> Type of unit for the returned value. </summary>
        public string UnitLabel { get; }
        /// <summary> Numeric ID value associated with the type of unit being displayed. Can be used for unit translation. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#unittype) for details. </summary>
        public UnitType? UnitType { get; }
    }
}
