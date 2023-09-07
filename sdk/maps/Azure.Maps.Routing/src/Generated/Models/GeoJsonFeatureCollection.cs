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
    /// <summary> A valid `GeoJSON FeatureCollection` object type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.3) for details. </summary>
    internal partial class GeoJsonFeatureCollection : GeoJsonObject
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonFeatureCollection"/>. </summary>
        /// <param name="features"> Contains a list of valid `GeoJSON Feature` objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="features"/> is null. </exception>
        public GeoJsonFeatureCollection(IEnumerable<GeoJsonFeature> features)
        {
            Argument.AssertNotNull(features, nameof(features));

            Features = features.ToList();
            Type = GeoJsonObjectType.GeoJsonFeatureCollection;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonFeatureCollection"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="features"> Contains a list of valid `GeoJSON Feature` objects. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoJsonFeatureCollection(GeoJsonObjectType type, IList<GeoJsonFeature> features, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
            Features = features;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonFeatureCollection"/> for deserialization. </summary>
        internal GeoJsonFeatureCollection()
        {
        }

        /// <summary> Contains a list of valid `GeoJSON Feature` objects. </summary>
        public IList<GeoJsonFeature> Features { get; }
    }
}
