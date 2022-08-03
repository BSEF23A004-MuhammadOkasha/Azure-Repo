// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The default value is regional. </summary>
    public enum BatchNodePlacementPolicyType
    {
        /// <summary> All nodes in the pool will be allocated in the same region. </summary>
        Regional,
        /// <summary> Nodes in the pool will be spread across different zones with best effort balancing. </summary>
        Zonal
    }
}
