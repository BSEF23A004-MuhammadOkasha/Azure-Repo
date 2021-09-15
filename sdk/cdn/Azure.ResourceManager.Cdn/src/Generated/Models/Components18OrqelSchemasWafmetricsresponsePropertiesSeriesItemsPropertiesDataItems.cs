// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems. </summary>
    public partial class Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems
    {
        /// <summary> Initializes a new instance of Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems. </summary>
        internal Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems()
        {
        }

        /// <summary> Initializes a new instance of Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems. </summary>
        /// <param name="dateTime"></param>
        /// <param name="value"></param>
        internal Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(DateTimeOffset? dateTime, float? value)
        {
            DateTime = dateTime;
            Value = value;
        }

        public DateTimeOffset? DateTime { get; }
        public float? Value { get; }
    }
}
