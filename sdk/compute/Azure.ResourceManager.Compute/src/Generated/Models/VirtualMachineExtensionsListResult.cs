// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Extension operation response. </summary>
    internal partial class VirtualMachineExtensionsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionsListResult"/>. </summary>
        internal VirtualMachineExtensionsListResult()
        {
            Value = new ChangeTrackingList<VirtualMachineExtensionData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionsListResult"/>. </summary>
        /// <param name="value"> The list of extensions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineExtensionsListResult(IReadOnlyList<VirtualMachineExtensionData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of extensions. </summary>
        public IReadOnlyList<VirtualMachineExtensionData> Value { get; }
    }
}
