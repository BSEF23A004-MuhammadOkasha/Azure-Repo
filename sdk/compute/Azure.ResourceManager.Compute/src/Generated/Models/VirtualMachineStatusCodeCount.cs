// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The status code and count of the virtual machine scale set instance view status summary. </summary>
    public partial class VirtualMachineStatusCodeCount
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineStatusCodeCount"/>. </summary>
        internal VirtualMachineStatusCodeCount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineStatusCodeCount"/>. </summary>
        /// <param name="code"> The instance view status code. </param>
        /// <param name="count"> The number of instances having a particular status code. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineStatusCodeCount(string code, int? count, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Count = count;
            _rawData = rawData;
        }

        /// <summary> The instance view status code. </summary>
        public string Code { get; }
        /// <summary> The number of instances having a particular status code. </summary>
        public int? Count { get; }
    }
}
