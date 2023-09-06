// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MixedReality;

namespace Azure.ResourceManager.MixedReality.Models
{
    /// <summary> Result of the request to get resource collection. It contains a list of resources and a URL link to get the next set of results. </summary>
    internal partial class RemoteRenderingAccountListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemoteRenderingAccountListResult"/>. </summary>
        internal RemoteRenderingAccountListResult()
        {
            Value = new ChangeTrackingList<RemoteRenderingAccountData>();
        }

        /// <summary> Initializes a new instance of <see cref="RemoteRenderingAccountListResult"/>. </summary>
        /// <param name="value"> List of resources supported by the Resource Provider. </param>
        /// <param name="nextLink"> URL to get the next set of resource list results if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoteRenderingAccountListResult(IReadOnlyList<RemoteRenderingAccountData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of resources supported by the Resource Provider. </summary>
        public IReadOnlyList<RemoteRenderingAccountData> Value { get; }
        /// <summary> URL to get the next set of resource list results if there are any. </summary>
        public string NextLink { get; }
    }
}
