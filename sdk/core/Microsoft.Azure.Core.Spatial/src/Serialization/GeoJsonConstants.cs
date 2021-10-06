﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Core.Serialization
{
    internal static class GeoJsonConstants
    {
        public const string PointTypeName = "Point";
        public const string LineStringTypeName = "LineString";
        public const string PolygonTypeName = "Polygon";
        public const string MultiPointTypeName = "MultiPoint";
        public const string MultiLineStringTypeName = "MultiLineString";
        public const string MultiPolygonTypeName = "MultiPolygon";
        public const string GeometryCollectionTypeName = "GeometryCollection";
        public const string CoordinatesPropertyName = "coordinates";
        public const string TypePropertyName = "type";
        public const string GeometriesPropertyName = "geometries";
    }
}
