// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> PrivateLinkHub patch details. </summary>
    public partial class PrivateLinkHubPatch
    {
        /// <summary> Initializes a new instance of PrivateLinkHubPatch. </summary>
        public PrivateLinkHubPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
