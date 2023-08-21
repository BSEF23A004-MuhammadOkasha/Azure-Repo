// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityDevOps;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The AzureDevOpsConnectorListResponse. </summary>
    internal partial class AzureDevOpsConnectorListResponse
    {
        /// <summary> Initializes a new instance of AzureDevOpsConnectorListResponse. </summary>
        internal AzureDevOpsConnectorListResponse()
        {
            Value = new ChangeTrackingList<AzureDevOpsConnectorData>();
        }

        /// <summary> Initializes a new instance of AzureDevOpsConnectorListResponse. </summary>
        /// <param name="value"> Gets or sets list of resources. </param>
        /// <param name="nextLink"> Gets or sets next link to scroll over the results. </param>
        internal AzureDevOpsConnectorListResponse(IReadOnlyList<AzureDevOpsConnectorData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets list of resources. </summary>
        public IReadOnlyList<AzureDevOpsConnectorData> Value { get; }
        /// <summary> Gets or sets next link to scroll over the results. </summary>
        public string NextLink { get; }
    }
}
