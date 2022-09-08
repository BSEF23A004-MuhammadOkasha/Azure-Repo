// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Tag filter information for the VM. </summary>
    public partial class TagSettingsProperties
    {
        /// <summary> Initializes a new instance of TagSettingsProperties. </summary>
        public TagSettingsProperties()
        {
            Tags = new ChangeTrackingDictionary<string, IList<string>>();
        }

        /// <summary> Initializes a new instance of TagSettingsProperties. </summary>
        /// <param name="tags"> Dictionary of tags with its list of values. </param>
        /// <param name="filterOperator"> Filter VMs by Any or All specified tags. </param>
        internal TagSettingsProperties(IDictionary<string, IList<string>> tags, TagOperator? filterOperator)
        {
            Tags = tags;
            FilterOperator = filterOperator;
        }

        /// <summary> Dictionary of tags with its list of values. </summary>
        public IDictionary<string, IList<string>> Tags { get; }
        /// <summary> Filter VMs by Any or All specified tags. </summary>
        public TagOperator? FilterOperator { get; set; }
    }
}
