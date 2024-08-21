// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Maps.Common;

namespace Azure.Maps.Weather
{
    /// <summary> A valid `GeoJSON Feature` object type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.2) for details. </summary>
    public partial class GeoJsonFeature : GeoJsonObject
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonFeature"/>. </summary>
        /// <param name="geometry">
        /// A valid `GeoJSON` geometry object. The type must be one of the seven valid GeoJSON geometry types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon and GeometryCollection. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1) for details.
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="geometry"/> is null. </exception>
        internal GeoJsonFeature(GeoJsonGeometry geometry)
        {
            Argument.AssertNotNull(geometry, nameof(geometry));

            Geometry = geometry;
            Type = GeoJsonObjectType.GeoJsonFeature;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonFeature"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="geometry">
        /// A valid `GeoJSON` geometry object. The type must be one of the seven valid GeoJSON geometry types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon and GeometryCollection. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1) for details.
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </param>
        /// <param name="properties"> Properties can contain any additional metadata about the `Feature`. Value can be any JSON object or a JSON null value. </param>
        /// <param name="id"> Identifier for the feature. </param>
        /// <param name="featureType"> The type of the feature. The value depends on the data model the current feature is part of. Some data models may have an empty value. </param>
        internal GeoJsonFeature(GeoJsonObjectType type, GeoJsonGeometry geometry, object properties, string id, string featureType) : base(type)
        {
            Geometry = geometry;
            Properties = properties;
            Id = id;
            FeatureType = featureType;
            Type = type;
        }

        /// <summary>
        /// A valid `GeoJSON` geometry object. The type must be one of the seven valid GeoJSON geometry types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon and GeometryCollection. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1) for details.
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </summary>
        public GeoJsonGeometry Geometry { get; }
        /// <summary> Properties can contain any additional metadata about the `Feature`. Value can be any JSON object or a JSON null value. </summary>
        public object Properties { get; }
        /// <summary> Identifier for the feature. </summary>
        public string Id { get; }
        /// <summary> The type of the feature. The value depends on the data model the current feature is part of. Some data models may have an empty value. </summary>
        public string FeatureType { get; }
    }
}
