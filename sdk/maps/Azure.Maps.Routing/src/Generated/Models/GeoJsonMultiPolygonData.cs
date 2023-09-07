// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> The GeoJsonMultiPolygonData. </summary>
    internal partial class GeoJsonMultiPolygonData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPolygonData"/>. </summary>
        /// <param name="coordinates"> Contains a list of valid `GeoJSON Polygon` objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiPolygonData(IEnumerable<IList<IList<IList<double>>>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPolygonData"/>. </summary>
        /// <param name="coordinates"> Contains a list of valid `GeoJSON Polygon` objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoJsonMultiPolygonData(IList<IList<IList<IList<double>>>> coordinates, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Coordinates = coordinates;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiPolygonData"/> for deserialization. </summary>
        internal GeoJsonMultiPolygonData()
        {
        }

        /// <summary> Contains a list of valid `GeoJSON Polygon` objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </summary>
        public IList<IList<IList<IList<double>>>> Coordinates { get; }
    }
}
