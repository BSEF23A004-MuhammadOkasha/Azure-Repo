// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The Update Resource model definition. </summary>
    public partial class ComputeResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="ComputeResourcePatch"/>. </summary>
        public ComputeResourcePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
