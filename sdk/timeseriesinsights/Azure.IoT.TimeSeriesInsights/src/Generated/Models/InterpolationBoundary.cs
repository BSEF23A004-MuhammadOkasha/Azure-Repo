// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> The time range to the left and right of the search span to be used for Interpolation. This is helpful in scenarios where the data points are missing close to the start or end of the input search span. Can be null. </summary>
    public partial class InterpolationBoundary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InterpolationBoundary"/>. </summary>
        public InterpolationBoundary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InterpolationBoundary"/>. </summary>
        /// <param name="span"> &lt;Need description here&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InterpolationBoundary(TimeSpan? span, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Span = span;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;Need description here&gt;. </summary>
        public TimeSpan? Span { get; set; }
    }
}
