// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary>
    /// A valid `GeoJSON` geometry object. The type must be one of the seven valid GeoJSON geometry types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon and GeometryCollection. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1) for details.
    /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
    /// </summary>
    public partial class GeoJsonGeometry : GeoJsonObject
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometry"/>. </summary>
        internal GeoJsonGeometry()
        {
            Type = new GeoJsonObjectType("GeoJsonGeometry");
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometry"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="boundingBox"> Bounding box. Projection used - EPSG:3857. Please refer to [RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946#section-5) for details. </param>
        internal GeoJsonGeometry(GeoJsonObjectType type, IReadOnlyList<double> boundingBox) : base(type, boundingBox)
        {
            Type = type;
        }
    }
}
