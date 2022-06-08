// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of configuration service resources and a possible link for next set. </summary>
    internal partial class ConfigurationServiceResourceList
    {
        /// <summary> Initializes a new instance of <see cref="ConfigurationServiceResourceList"/>. </summary>
        internal ConfigurationServiceResourceList()
        {
            Value = new ChangeTrackingList<ConfigurationServiceResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationServiceResourceList"/>. </summary>
        /// <param name="value"> Collection of configuration service resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal ConfigurationServiceResourceList(IReadOnlyList<ConfigurationServiceResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of configuration service resources. </summary>
        public IReadOnlyList<ConfigurationServiceResourceData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
