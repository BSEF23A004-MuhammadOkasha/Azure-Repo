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
    /// <summary> Response for ListSecurityPartnerProviders API service call. </summary>
    internal partial class SecurityPartnerProviderListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityPartnerProviderListResult"/>. </summary>
        internal SecurityPartnerProviderListResult()
        {
            Value = new ChangeTrackingList<SecurityPartnerProviderData>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityPartnerProviderListResult"/>. </summary>
        /// <param name="value"> List of Security Partner Providers in a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityPartnerProviderListResult(IReadOnlyList<SecurityPartnerProviderData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Security Partner Providers in a resource group. </summary>
        public IReadOnlyList<SecurityPartnerProviderData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
