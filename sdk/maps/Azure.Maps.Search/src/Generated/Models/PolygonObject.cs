// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.GeoJson;

namespace Azure.Maps.Search.Models
{
    /// <summary> The Polygon. </summary>
    public partial class PolygonObject
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PolygonObject"/>. </summary>
        internal PolygonObject()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolygonObject"/>. </summary>
        /// <param name="providerId"> ID of the returned entity. </param>
        /// <param name="geometryData"> Geometry data in GeoJSON format. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946) for details. Present only if "error" is not present. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolygonObject(string providerId, GeoObject geometryData, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProviderId = providerId;
            GeometryData = geometryData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
