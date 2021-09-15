// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The MetricsResponseSeriesPropertiesItemsItem. </summary>
    public partial class MetricsResponseSeriesPropertiesItemsItem
    {
        /// <summary> Initializes a new instance of MetricsResponseSeriesPropertiesItemsItem. </summary>
        internal MetricsResponseSeriesPropertiesItemsItem()
        {
        }

        /// <summary> Initializes a new instance of MetricsResponseSeriesPropertiesItemsItem. </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        internal MetricsResponseSeriesPropertiesItemsItem(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; }
    }
}
