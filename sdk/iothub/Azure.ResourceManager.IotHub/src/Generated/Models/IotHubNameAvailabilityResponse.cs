// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties indicating whether a given IoT hub name is available. </summary>
    public partial class IotHubNameAvailabilityResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubNameAvailabilityResponse"/>. </summary>
        internal IotHubNameAvailabilityResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotHubNameAvailabilityResponse"/>. </summary>
        /// <param name="isNameAvailable"> The value which indicates whether the provided name is available. </param>
        /// <param name="reason"> The reason for unavailability. </param>
        /// <param name="message"> The detailed reason message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubNameAvailabilityResponse(bool? isNameAvailable, IotHubNameUnavailableReason? reason, string message, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The value which indicates whether the provided name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason for unavailability. </summary>
        public IotHubNameUnavailableReason? Reason { get; }
        /// <summary> The detailed reason message. </summary>
        public string Message { get; }
    }
}
