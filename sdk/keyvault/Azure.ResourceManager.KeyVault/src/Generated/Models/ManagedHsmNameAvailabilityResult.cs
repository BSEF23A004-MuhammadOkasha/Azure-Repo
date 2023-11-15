// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The CheckMhsmNameAvailability operation response. </summary>
    public partial class ManagedHsmNameAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmNameAvailabilityResult"/>. </summary>
        internal ManagedHsmNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or is invalid and cannot be used. </param>
        /// <param name="reason"> The reason that a managed hsm name could not be used. The reason element is only returned if NameAvailable is false. </param>
        /// <param name="message"> An error message explaining the Reason value in more detail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedHsmNameAvailabilityResult(bool? isNameAvailable, ManagedHsmNameUnavailableReason? reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or is invalid and cannot be used. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason that a managed hsm name could not be used. The reason element is only returned if NameAvailable is false. </summary>
        public ManagedHsmNameUnavailableReason? Reason { get; }
        /// <summary> An error message explaining the Reason value in more detail. </summary>
        public string Message { get; }
    }
}
