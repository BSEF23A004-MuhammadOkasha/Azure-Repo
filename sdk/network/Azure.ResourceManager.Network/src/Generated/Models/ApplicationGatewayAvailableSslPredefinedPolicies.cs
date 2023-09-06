// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ApplicationGatewayAvailableSslOptions API service call. </summary>
    internal partial class ApplicationGatewayAvailableSslPredefinedPolicies
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayAvailableSslPredefinedPolicies"/>. </summary>
        internal ApplicationGatewayAvailableSslPredefinedPolicies()
        {
            Value = new ChangeTrackingList<ApplicationGatewaySslPredefinedPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayAvailableSslPredefinedPolicies"/>. </summary>
        /// <param name="value"> List of available Ssl predefined policy. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayAvailableSslPredefinedPolicies(IReadOnlyList<ApplicationGatewaySslPredefinedPolicy> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of available Ssl predefined policy. </summary>
        public IReadOnlyList<ApplicationGatewaySslPredefinedPolicy> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
