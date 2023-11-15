// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Property of an event that is either stored or computed. Properties are identified by both name and type. Different events can have properties with same name, but different type. </summary>
    public partial class TimeSeriesInsightsEventProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TimeSeriesInsightsEventProperty"/>. </summary>
        public TimeSeriesInsightsEventProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesInsightsEventProperty"/>. </summary>
        /// <param name="name"> The name of the property. </param>
        /// <param name="propertyValueType"> The type of the property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TimeSeriesInsightsEventProperty(string name, TimeSeriesPropertyType? propertyValueType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            PropertyValueType = propertyValueType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the property. </summary>
        public string Name { get; set; }
    }
}
