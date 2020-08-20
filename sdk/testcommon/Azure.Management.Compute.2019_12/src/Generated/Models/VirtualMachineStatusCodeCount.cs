// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> The status code and count of the virtual machine scale set instance view status summary. </summary>
    public partial class VirtualMachineStatusCodeCount
    {
        /// <summary> Initializes a new instance of VirtualMachineStatusCodeCount. </summary>
        internal VirtualMachineStatusCodeCount()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineStatusCodeCount. </summary>
        /// <param name="code"> The instance view status code. </param>
        /// <param name="count"> The number of instances having a particular status code. </param>
        internal VirtualMachineStatusCodeCount(string code, int? count)
        {
            Code = code;
            Count = count;
        }

        /// <summary> The instance view status code. </summary>
        public string Code { get; }
        /// <summary> The number of instances having a particular status code. </summary>
        public int? Count { get; }
    }
}
