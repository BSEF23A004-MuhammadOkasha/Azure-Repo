// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The class to specify one track property condition. </summary>
    public partial class FilterTrackPropertyCondition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FilterTrackPropertyCondition"/>. </summary>
        /// <param name="property"> The track property type. </param>
        /// <param name="value"> The track property value. </param>
        /// <param name="operation"> The track property condition operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FilterTrackPropertyCondition(FilterTrackPropertyType property, string value, FilterTrackPropertyCompareOperation operation)
        {
            Argument.AssertNotNull(value, nameof(value));

            Property = property;
            Value = value;
            Operation = operation;
        }

        /// <summary> Initializes a new instance of <see cref="FilterTrackPropertyCondition"/>. </summary>
        /// <param name="property"> The track property type. </param>
        /// <param name="value"> The track property value. </param>
        /// <param name="operation"> The track property condition operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilterTrackPropertyCondition(FilterTrackPropertyType property, string value, FilterTrackPropertyCompareOperation operation, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Property = property;
            Value = value;
            Operation = operation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FilterTrackPropertyCondition"/> for deserialization. </summary>
        internal FilterTrackPropertyCondition()
        {
        }

        /// <summary> The track property type. </summary>
        public FilterTrackPropertyType Property { get; set; }
        /// <summary> The track property value. </summary>
        public string Value { get; set; }
        /// <summary> The track property condition operation. </summary>
        public FilterTrackPropertyCompareOperation Operation { get; set; }
    }
}
