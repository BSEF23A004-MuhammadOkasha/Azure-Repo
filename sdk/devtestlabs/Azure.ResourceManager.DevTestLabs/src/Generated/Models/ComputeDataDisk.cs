// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> A data disks attached to a virtual machine. </summary>
    public partial class ComputeDataDisk
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ComputeDataDisk"/>. </summary>
        internal ComputeDataDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeDataDisk"/>. </summary>
        /// <param name="name"> Gets data disk name. </param>
        /// <param name="diskUri"> When backed by a blob, the URI of underlying blob. </param>
        /// <param name="managedDiskId"> When backed by managed disk, this is the ID of the compute disk resource. </param>
        /// <param name="diskSizeGiB"> Gets data disk size in GiB. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeDataDisk(string name, Uri diskUri, string managedDiskId, int? diskSizeGiB, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            DiskUri = diskUri;
            ManagedDiskId = managedDiskId;
            DiskSizeGiB = diskSizeGiB;
            _rawData = rawData;
        }

        /// <summary> Gets data disk name. </summary>
        public string Name { get; }
        /// <summary> When backed by a blob, the URI of underlying blob. </summary>
        public Uri DiskUri { get; }
        /// <summary> When backed by managed disk, this is the ID of the compute disk resource. </summary>
        public string ManagedDiskId { get; }
        /// <summary> Gets data disk size in GiB. </summary>
        public int? DiskSizeGiB { get; }
    }
}
