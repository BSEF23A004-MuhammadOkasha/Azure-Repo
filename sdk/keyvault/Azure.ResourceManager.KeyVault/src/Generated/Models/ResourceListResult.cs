// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace KeyVaultManagementClient.Models
{
    /// <summary> List of vault resources. </summary>
    internal partial class ResourceListResult
    {
        /// <summary> Initializes a new instance of ResourceListResult. </summary>
        internal ResourceListResult()
        {
            Value = new ChangeTrackingList<Resource>();
        }

        /// <summary> Initializes a new instance of ResourceListResult. </summary>
        /// <param name="value"> The list of vault resources. </param>
        /// <param name="nextLink"> The URL to get the next set of vault resources. </param>
        internal ResourceListResult(IReadOnlyList<Resource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of vault resources. </summary>
        public IReadOnlyList<Resource> Value { get; }
        /// <summary> The URL to get the next set of vault resources. </summary>
        public string NextLink { get; }
    }
}
