// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies a list of virtual machine instance IDs from the VM scale set. </summary>
    public partial class VirtualMachineScaleSetVmInstanceRequiredIds
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmInstanceRequiredIds"/>. </summary>
        /// <param name="instanceIds"> The virtual machine scale set instance ids. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceIds"/> is null. </exception>
        public VirtualMachineScaleSetVmInstanceRequiredIds(IEnumerable<string> instanceIds)
        {
            Argument.AssertNotNull(instanceIds, nameof(instanceIds));

            InstanceIds = instanceIds.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmInstanceRequiredIds"/>. </summary>
        /// <param name="instanceIds"> The virtual machine scale set instance ids. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetVmInstanceRequiredIds(IList<string> instanceIds, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceIds = instanceIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmInstanceRequiredIds"/> for deserialization. </summary>
        internal VirtualMachineScaleSetVmInstanceRequiredIds()
        {
        }

        /// <summary> The virtual machine scale set instance ids. </summary>
        public IList<string> InstanceIds { get; }
    }
}
