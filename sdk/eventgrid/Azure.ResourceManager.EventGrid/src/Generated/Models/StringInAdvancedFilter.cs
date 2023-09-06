// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> StringIn Advanced Filter. </summary>
    public partial class StringInAdvancedFilter : AdvancedFilter
    {
        /// <summary> Initializes a new instance of <see cref="StringInAdvancedFilter"/>. </summary>
        public StringInAdvancedFilter()
        {
            Values = new ChangeTrackingList<string>();
            OperatorType = AdvancedFilterOperatorType.StringIn;
        }

        /// <summary> Initializes a new instance of <see cref="StringInAdvancedFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="values"> The set of filter values. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StringInAdvancedFilter(AdvancedFilterOperatorType operatorType, string key, IList<string> values, Dictionary<string, BinaryData> rawData) : base(operatorType, key, rawData)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        public IList<string> Values { get; }
    }
}
