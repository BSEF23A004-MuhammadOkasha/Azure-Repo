// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Route sections contain additional information about parts of a route. Each section contains at least the elements `startPointIndex`, `endPointIndex`, and `sectionType`. </summary>
    public partial class RouteSection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouteSection"/>. </summary>
        internal RouteSection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouteSection"/>. </summary>
        /// <param name="startPointIndex"> Index of the first point (offset 0) in the route this section applies to. </param>
        /// <param name="endPointIndex"> Index of the last point (offset 0) in the route this section applies to. </param>
        /// <param name="sectionType"> Section types of the reported route response. </param>
        /// <param name="travelMode"> Travel mode for the calculated route. The value will be set to `other` if the requested mode of transport is not possible in this section. </param>
        /// <param name="simpleCategory"> Type of the incident. Can currently be JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See "tec" for detailed information. </param>
        /// <param name="effectiveSpeedInKmh"> Effective speed of the incident in km/h, averaged over its entire length. </param>
        /// <param name="delayInSeconds"> Delay in seconds caused by the incident. </param>
        /// <param name="delayMagnitude"> The magnitude of delay caused by the incident. These values correspond to the values of the response field ty of the [Get Traffic Incident Detail API](https://docs.microsoft.com/rest/api/maps/traffic/gettrafficincidentdetail). </param>
        /// <param name="tec"> Details of the traffic event, using definitions in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. Can contain effectCode and causes elements. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteSection(int? startPointIndex, int? endPointIndex, ResponseSectionType? sectionType, ResponseTravelMode? travelMode, TrafficIncidentCategory? simpleCategory, int? effectiveSpeedInKmh, int? delayInSeconds, DelayMagnitude? delayMagnitude, RouteSectionTec tec, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartPointIndex = startPointIndex;
            EndPointIndex = endPointIndex;
            SectionType = sectionType;
            TravelMode = travelMode;
            SimpleCategory = simpleCategory;
            EffectiveSpeedInKmh = effectiveSpeedInKmh;
            DelayInSeconds = delayInSeconds;
            DelayMagnitude = delayMagnitude;
            Tec = tec;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Index of the first point (offset 0) in the route this section applies to. </summary>
        public int? StartPointIndex { get; }
        /// <summary> Index of the last point (offset 0) in the route this section applies to. </summary>
        public int? EndPointIndex { get; }
        /// <summary> Section types of the reported route response. </summary>
        public ResponseSectionType? SectionType { get; }
        /// <summary> Travel mode for the calculated route. The value will be set to `other` if the requested mode of transport is not possible in this section. </summary>
        public ResponseTravelMode? TravelMode { get; }
        /// <summary> Type of the incident. Can currently be JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See "tec" for detailed information. </summary>
        public TrafficIncidentCategory? SimpleCategory { get; }
        /// <summary> Effective speed of the incident in km/h, averaged over its entire length. </summary>
        public int? EffectiveSpeedInKmh { get; }
        /// <summary> Delay in seconds caused by the incident. </summary>
        public int? DelayInSeconds { get; }
        /// <summary> The magnitude of delay caused by the incident. These values correspond to the values of the response field ty of the [Get Traffic Incident Detail API](https://docs.microsoft.com/rest/api/maps/traffic/gettrafficincidentdetail). </summary>
        public DelayMagnitude? DelayMagnitude { get; }
        /// <summary> Details of the traffic event, using definitions in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. Can contain effectCode and causes elements. </summary>
        public RouteSectionTec Tec { get; }
    }
}
