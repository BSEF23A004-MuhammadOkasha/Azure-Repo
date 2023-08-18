// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> List of blob inventory policies returned. </summary>
    internal partial class ListBlobInventoryPolicy
    {
        /// <summary> Initializes a new instance of ListBlobInventoryPolicy. </summary>
        internal ListBlobInventoryPolicy()
        {
            Value = new Core.ChangeTrackingList<BlobInventoryPolicyData>();
        }

        /// <summary> Initializes a new instance of ListBlobInventoryPolicy. </summary>
        /// <param name="value"> List of blob inventory policies. </param>
        internal ListBlobInventoryPolicy(IReadOnlyList<BlobInventoryPolicyData> value)
        {
            Value = value;
        }

        /// <summary> List of blob inventory policies. </summary>
        public IReadOnlyList<BlobInventoryPolicyData> Value { get; }
    }
}
