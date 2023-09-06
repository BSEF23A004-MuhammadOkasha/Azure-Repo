// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The vm size property. </summary>
    public partial class HDInsightVmSizeProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightVmSizeProperty"/>. </summary>
        internal HDInsightVmSizeProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightVmSizeProperty"/>. </summary>
        /// <param name="name"> The vm size name. </param>
        /// <param name="cores"> The number of cores that the vm size has. </param>
        /// <param name="dataDiskStorageTier"> The data disk storage tier of the vm size. </param>
        /// <param name="label"> The label of the vm size. </param>
        /// <param name="maxDataDiskCount"> The max data disk count of the vm size. </param>
        /// <param name="memoryInMB"> The memory whose unit is MB of the vm size. </param>
        /// <param name="isSupportedByVirtualMachines"> This indicates this vm size is supported by virtual machines or not. </param>
        /// <param name="isSupportedByWebWorkerRoles"> The indicates this vm size is supported by web worker roles or not. </param>
        /// <param name="virtualMachineResourceDiskSizeInMB"> The virtual machine resource disk size whose unit is MB of the vm size. </param>
        /// <param name="webWorkerResourceDiskSizeInMB"> The web worker resource disk size whose unit is MB of the vm size. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightVmSizeProperty(string name, int? cores, string dataDiskStorageTier, string label, long? maxDataDiskCount, long? memoryInMB, bool? isSupportedByVirtualMachines, bool? isSupportedByWebWorkerRoles, long? virtualMachineResourceDiskSizeInMB, long? webWorkerResourceDiskSizeInMB, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Cores = cores;
            DataDiskStorageTier = dataDiskStorageTier;
            Label = label;
            MaxDataDiskCount = maxDataDiskCount;
            MemoryInMB = memoryInMB;
            IsSupportedByVirtualMachines = isSupportedByVirtualMachines;
            IsSupportedByWebWorkerRoles = isSupportedByWebWorkerRoles;
            VirtualMachineResourceDiskSizeInMB = virtualMachineResourceDiskSizeInMB;
            WebWorkerResourceDiskSizeInMB = webWorkerResourceDiskSizeInMB;
            _rawData = rawData;
        }

        /// <summary> The vm size name. </summary>
        public string Name { get; }
        /// <summary> The number of cores that the vm size has. </summary>
        public int? Cores { get; }
        /// <summary> The data disk storage tier of the vm size. </summary>
        public string DataDiskStorageTier { get; }
        /// <summary> The label of the vm size. </summary>
        public string Label { get; }
        /// <summary> The max data disk count of the vm size. </summary>
        public long? MaxDataDiskCount { get; }
        /// <summary> The memory whose unit is MB of the vm size. </summary>
        public long? MemoryInMB { get; }
        /// <summary> This indicates this vm size is supported by virtual machines or not. </summary>
        public bool? IsSupportedByVirtualMachines { get; }
        /// <summary> The indicates this vm size is supported by web worker roles or not. </summary>
        public bool? IsSupportedByWebWorkerRoles { get; }
        /// <summary> The virtual machine resource disk size whose unit is MB of the vm size. </summary>
        public long? VirtualMachineResourceDiskSizeInMB { get; }
        /// <summary> The web worker resource disk size whose unit is MB of the vm size. </summary>
        public long? WebWorkerResourceDiskSizeInMB { get; }
    }
}
