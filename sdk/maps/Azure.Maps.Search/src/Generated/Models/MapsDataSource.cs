// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> Optional section. Reference ids for use with the [Get Search Polygon](https://docs.microsoft.com/rest/api/maps/search/getsearchpolygon) API. </summary>
    public partial class MapsDataSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MapsDataSource"/>. </summary>
        internal MapsDataSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MapsDataSource"/>. </summary>
        /// <param name="geometry"> Information about the geometric shape of the result. Only present if type == Geography. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MapsDataSource(GeometryIdentifier geometry, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Geometry = geometry;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Information about the geometric shape of the result. Only present if type == Geography. </summary>
        public GeometryIdentifier Geometry { get; }
    }
}
