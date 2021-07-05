// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace KeyVaultManagementClient.Models
{
    /// <summary> List of private endpoint connections. </summary>
    internal partial class PrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        internal PrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> The list of private endpoint connections. </param>
        /// <param name="nextLink"> The URL to get the next set of private endpoint connections. </param>
        internal PrivateEndpointConnectionListResult(IReadOnlyList<PrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of private endpoint connections. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> Value { get; }
        /// <summary> The URL to get the next set of private endpoint connections. </summary>
        public string NextLink { get; }
    }
}
