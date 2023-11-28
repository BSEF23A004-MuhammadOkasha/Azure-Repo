// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of VirtualNetworks. </summary>
    internal partial class VMwareVirtualNetworkListResult
    {
        /// <summary> Initializes a new instance of <see cref="VMwareVirtualNetworkListResult"/>. </summary>
        /// <param name="value"> Array of VirtualNetworks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VMwareVirtualNetworkListResult(IEnumerable<VMwareVirtualNetworkData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VMwareVirtualNetworkListResult"/>. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of VirtualNetworks. </param>
        /// <param name="value"> Array of VirtualNetworks. </param>
        internal VMwareVirtualNetworkListResult(string nextLink, IReadOnlyList<VMwareVirtualNetworkData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Url to follow for getting next page of VirtualNetworks. </summary>
        public string NextLink { get; }
        /// <summary> Array of VirtualNetworks. </summary>
        public IReadOnlyList<VMwareVirtualNetworkData> Value { get; }
    }
}
