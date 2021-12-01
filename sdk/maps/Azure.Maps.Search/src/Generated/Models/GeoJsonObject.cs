// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> A valid `GeoJSON` object. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3) for details. </summary>
    public partial class GeoJsonObject
    {
        /// <summary> Initializes a new instance of GeoJsonObject. </summary>
        public GeoJsonObject()
        {
        }

        /// <summary> Initializes a new instance of GeoJsonObject. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        internal GeoJsonObject(string type)
        {
            Type = type;
        }

        /// <summary> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </summary>
        internal string Type { get; set; }
    }
}
