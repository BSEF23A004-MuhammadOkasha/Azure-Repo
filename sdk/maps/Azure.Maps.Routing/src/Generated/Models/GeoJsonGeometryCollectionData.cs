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
    /// <summary> The GeoJsonGeometryCollectionData. </summary>
    internal partial class GeoJsonGeometryCollectionData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollectionData"/>. </summary>
        /// <param name="geometries">
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/>, <see cref="GeoJsonPolygon"/> and <see cref="GeoJsonMultiPoint"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="geometries"/> is null. </exception>
        public GeoJsonGeometryCollectionData(IEnumerable<GeoJsonGeometry> geometries)
        {
            Argument.AssertNotNull(geometries, nameof(geometries));

            Geometries = geometries.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollectionData"/>. </summary>
        /// <param name="geometries">
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/>, <see cref="GeoJsonPolygon"/> and <see cref="GeoJsonMultiPoint"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoJsonGeometryCollectionData(IList<GeoJsonGeometry> geometries, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Geometries = geometries;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollectionData"/> for deserialization. </summary>
        internal GeoJsonGeometryCollectionData()
        {
        }

        /// <summary>
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/>, <see cref="GeoJsonPolygon"/> and <see cref="GeoJsonMultiPoint"/>.
        /// </summary>
        public IList<GeoJsonGeometry> Geometries { get; }
    }
}
