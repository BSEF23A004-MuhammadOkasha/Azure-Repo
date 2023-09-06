// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A list of network manager security admin configurations. </summary>
    internal partial class SecurityAdminConfigurationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityAdminConfigurationListResult"/>. </summary>
        internal SecurityAdminConfigurationListResult()
        {
            Value = new ChangeTrackingList<SecurityAdminConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAdminConfigurationListResult"/>. </summary>
        /// <param name="value"> Gets a page of security admin configurations. </param>
        /// <param name="nextLink"> Gets the URL to get the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAdminConfigurationListResult(IReadOnlyList<SecurityAdminConfigurationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets a page of security admin configurations. </summary>
        public IReadOnlyList<SecurityAdminConfigurationData> Value { get; }
        /// <summary> Gets the URL to get the next page of results. </summary>
        public string NextLink { get; }
    }
}
