// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A person's age, given as a number (value) and a unit (e.g. years, months). </summary>
    public partial class AcceptedAge
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of AcceptedAge. </summary>
        /// <param name="unit"> Possible units for a person's age. </param>
        /// <param name="value"> The number of years/months/days that represents the person's age. </param>
        public AcceptedAge(AgeUnit unit, float value)
        {
            Unit = unit;
            Value = value;
        }

        /// <summary> Initializes a new instance of AcceptedAge. </summary>
        /// <param name="unit"> Possible units for a person's age. </param>
        /// <param name="value"> The number of years/months/days that represents the person's age. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcceptedAge(AgeUnit unit, float value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Unit = unit;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcceptedAge"/> for deserialization. </summary>
        internal AcceptedAge()
        {
        }

        /// <summary> Possible units for a person's age. </summary>
        public AgeUnit Unit { get; }
        /// <summary> The number of years/months/days that represents the person's age. </summary>
        public float Value { get; }
    }
}
