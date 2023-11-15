// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Summary object for route section. </summary>
    public partial class RouteLegSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouteLegSummary"/>. </summary>
        internal RouteLegSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouteLegSummary"/>. </summary>
        /// <param name="lengthInMeters"> Length In Meters property. </param>
        /// <param name="travelTimeInSeconds"> Estimated travel time in seconds property that includes the delay due to real-time traffic. Note that even when traffic=false travelTimeInSeconds still includes the delay due to traffic. If DepartAt is in the future, travel time is calculated using time-dependent historic traffic data. </param>
        /// <param name="trafficDelayInSeconds"> Estimated delay in seconds caused by the real-time incident(s) according to traffic information. For routes planned with departure time in the future, delays is always 0. To return additional travel times using different types of traffic information, parameter computeTravelTimeFor=all needs to be added. </param>
        /// <param name="departureTime"> The estimated departure time for the route or leg. </param>
        /// <param name="arrivalTime"> The estimated arrival time for the route or leg. </param>
        /// <param name="noTrafficTravelTimeInSeconds"> Estimated travel time calculated as if there are no delays on the route due to traffic conditions (e.g. congestion). Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="historicTrafficTravelTimeInSeconds"> Estimated travel time calculated using time-dependent historic traffic data. Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="liveTrafficIncidentsTravelTimeInSeconds"> Estimated travel time calculated using real-time speed data. Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="fuelConsumptionInLiters"> Estimated fuel consumption in liters using the Combustion Consumption Model. Included if vehicleEngineType is set to _combustion_ and constantSpeedConsumptionInLitersPerHundredkm is specified. The value will be non-negative. </param>
        /// <param name="batteryConsumptionInKwH"> Estimated electric energy consumption in kilowatt hours (kWh) using the Electric Consumption Model. Included if vehicleEngineType is set to electric and constantSpeedConsumptionInkWhPerHundredkm is specified. The value of batteryConsumptionInkWh includes the recuperated electric energy and can therefore be negative (which indicates gaining energy). If both maxChargeInkWh and currentChargeInkWh are specified, recuperation will be capped to ensure that the battery charge level never exceeds maxChargeInkWh. If neither maxChargeInkWh nor currentChargeInkWh are specified, unconstrained recuperation is assumed in the consumption calculation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteLegSummary(int? lengthInMeters, int? travelTimeInSeconds, int? trafficDelayInSeconds, DateTimeOffset? departureTime, DateTimeOffset? arrivalTime, int? noTrafficTravelTimeInSeconds, int? historicTrafficTravelTimeInSeconds, int? liveTrafficIncidentsTravelTimeInSeconds, double? fuelConsumptionInLiters, double? batteryConsumptionInKwH, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LengthInMeters = lengthInMeters;
            TravelTimeInSeconds = travelTimeInSeconds;
            TrafficDelayInSeconds = trafficDelayInSeconds;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            NoTrafficTravelTimeInSeconds = noTrafficTravelTimeInSeconds;
            HistoricTrafficTravelTimeInSeconds = historicTrafficTravelTimeInSeconds;
            LiveTrafficIncidentsTravelTimeInSeconds = liveTrafficIncidentsTravelTimeInSeconds;
            FuelConsumptionInLiters = fuelConsumptionInLiters;
            BatteryConsumptionInKwH = batteryConsumptionInKwH;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Length In Meters property. </summary>
        public int? LengthInMeters { get; }
        /// <summary> Estimated travel time in seconds property that includes the delay due to real-time traffic. Note that even when traffic=false travelTimeInSeconds still includes the delay due to traffic. If DepartAt is in the future, travel time is calculated using time-dependent historic traffic data. </summary>
        public int? TravelTimeInSeconds { get; }
        /// <summary> Estimated delay in seconds caused by the real-time incident(s) according to traffic information. For routes planned with departure time in the future, delays is always 0. To return additional travel times using different types of traffic information, parameter computeTravelTimeFor=all needs to be added. </summary>
        public int? TrafficDelayInSeconds { get; }
        /// <summary> The estimated departure time for the route or leg. </summary>
        public DateTimeOffset? DepartureTime { get; }
        /// <summary> The estimated arrival time for the route or leg. </summary>
        public DateTimeOffset? ArrivalTime { get; }
        /// <summary> Estimated travel time calculated as if there are no delays on the route due to traffic conditions (e.g. congestion). Included only if computeTravelTimeFor = all is used in the query. </summary>
        public int? NoTrafficTravelTimeInSeconds { get; }
        /// <summary> Estimated travel time calculated using time-dependent historic traffic data. Included only if computeTravelTimeFor = all is used in the query. </summary>
        public int? HistoricTrafficTravelTimeInSeconds { get; }
        /// <summary> Estimated travel time calculated using real-time speed data. Included only if computeTravelTimeFor = all is used in the query. </summary>
        public int? LiveTrafficIncidentsTravelTimeInSeconds { get; }
        /// <summary> Estimated fuel consumption in liters using the Combustion Consumption Model. Included if vehicleEngineType is set to _combustion_ and constantSpeedConsumptionInLitersPerHundredkm is specified. The value will be non-negative. </summary>
        public double? FuelConsumptionInLiters { get; }
        /// <summary> Estimated electric energy consumption in kilowatt hours (kWh) using the Electric Consumption Model. Included if vehicleEngineType is set to electric and constantSpeedConsumptionInkWhPerHundredkm is specified. The value of batteryConsumptionInkWh includes the recuperated electric energy and can therefore be negative (which indicates gaining energy). If both maxChargeInkWh and currentChargeInkWh are specified, recuperation will be capped to ensure that the battery charge level never exceeds maxChargeInkWh. If neither maxChargeInkWh nor currentChargeInkWh are specified, unconstrained recuperation is assumed in the consumption calculation. </summary>
        public double? BatteryConsumptionInKwH { get; }
    }
}
