// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> List of VirtualNetworks. </summary>
    internal partial class VirtualNetworkListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkListResult. </summary>
        internal VirtualNetworkListResult()
        {
            Value = new Core.ChangeTrackingList<ScVmmVirtualNetworkData>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkListResult. </summary>
        /// <param name="value"> List of VirtualNetworks. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal VirtualNetworkListResult(IReadOnlyList<ScVmmVirtualNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VirtualNetworks. </summary>
        public IReadOnlyList<ScVmmVirtualNetworkData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
