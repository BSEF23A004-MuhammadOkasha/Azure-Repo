// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the resource properties. </summary>
    internal partial class StorageProfileUpdate
    {
        /// <summary> Initializes a new instance of StorageProfileUpdate. </summary>
        public StorageProfileUpdate()
        {
            Disks = new Core.ChangeTrackingList<VirtualDiskUpdate>();
        }

        /// <summary> Gets or sets the list of virtual disks associated with the virtual machine. </summary>
        public IList<VirtualDiskUpdate> Disks { get; }
    }
}
