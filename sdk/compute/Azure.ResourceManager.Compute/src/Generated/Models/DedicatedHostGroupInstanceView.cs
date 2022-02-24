// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The DedicatedHostGroupInstanceView. </summary>
    internal partial class DedicatedHostGroupInstanceView
    {
        /// <summary> Initializes a new instance of DedicatedHostGroupInstanceView. </summary>
        internal DedicatedHostGroupInstanceView()
        {
            Hosts = new ChangeTrackingList<DedicatedHostInstanceViewWithName>();
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupInstanceView. </summary>
        /// <param name="hosts"> List of instance view of the dedicated hosts under the dedicated host group. </param>
        internal DedicatedHostGroupInstanceView(IReadOnlyList<DedicatedHostInstanceViewWithName> hosts)
        {
            Hosts = hosts;
        }

        /// <summary> List of instance view of the dedicated hosts under the dedicated host group. </summary>
        public IReadOnlyList<DedicatedHostInstanceViewWithName> Hosts { get; }
    }
}
