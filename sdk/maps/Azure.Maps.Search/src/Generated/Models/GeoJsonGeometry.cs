// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> A valid `GeoJSON` geometry object. The type must be one of the seven valid GeoJSON geometry types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon and GeometryCollection. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1) for details. </summary>
    public partial class GeoJsonGeometry : GeoJsonObject
    {
        /// <summary> Initializes a new instance of GeoJsonGeometry. </summary>
        public GeoJsonGeometry()
        {
            Type = "GeoJsonGeometry";
        }

        /// <summary> Initializes a new instance of GeoJsonGeometry. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        internal GeoJsonGeometry(string type) : base(type)
        {
            Type = type ?? "GeoJsonGeometry";
        }
    }
}
