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
    /// <summary> The GeoJsonMultiLineStringData. </summary>
    internal partial class GeoJsonMultiLineStringData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiLineStringData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiLineString` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiLineStringData(IEnumerable<IList<IList<double>>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiLineStringData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiLineString` geometry. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoJsonMultiLineStringData(IList<IList<IList<double>>> coordinates, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Coordinates = coordinates;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiLineStringData"/> for deserialization. </summary>
        internal GeoJsonMultiLineStringData()
        {
        }

        /// <summary> Coordinates for the `GeoJson MultiLineString` geometry. </summary>
        public IList<IList<IList<double>>> Coordinates { get; }
    }
}
