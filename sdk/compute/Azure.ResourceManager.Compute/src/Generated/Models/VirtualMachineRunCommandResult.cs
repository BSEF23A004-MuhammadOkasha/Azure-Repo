// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The VirtualMachineRunCommandResult. </summary>
    public partial class VirtualMachineRunCommandResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRunCommandResult"/>. </summary>
        internal VirtualMachineRunCommandResult()
        {
            Value = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRunCommandResult"/>. </summary>
        /// <param name="value"> Run command operation response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineRunCommandResult(IReadOnlyList<InstanceViewStatus> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Run command operation response. </summary>
        public IReadOnlyList<InstanceViewStatus> Value { get; }
    }
}
