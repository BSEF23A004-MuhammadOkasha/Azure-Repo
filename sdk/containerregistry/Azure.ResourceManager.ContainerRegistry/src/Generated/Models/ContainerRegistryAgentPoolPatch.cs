// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating an agent pool. </summary>
    public partial class ContainerRegistryAgentPoolPatch
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryAgentPoolPatch"/>. </summary>
        public ContainerRegistryAgentPoolPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The ARM resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The count of agent machine. </summary>
        public int? Count { get; set; }
    }
}
