// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MixedReality.Models
{
    /// <summary>
    /// Check Name Availability Response
    /// Serialized Name: CheckNameAvailabilityResponse
    /// </summary>
    public partial class CheckNameAvailabilityResponse
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityResponse. </summary>
        /// <param name="nameAvailable">
        /// if name Available
        /// Serialized Name: CheckNameAvailabilityResponse.nameAvailable
        /// </param>
        internal CheckNameAvailabilityResponse(bool nameAvailable)
        {
            NameAvailable = nameAvailable;
        }

        /// <summary> Initializes a new instance of CheckNameAvailabilityResponse. </summary>
        /// <param name="nameAvailable">
        /// if name Available
        /// Serialized Name: CheckNameAvailabilityResponse.nameAvailable
        /// </param>
        /// <param name="reason">
        /// Resource Name To Verify
        /// Serialized Name: CheckNameAvailabilityResponse.reason
        /// </param>
        /// <param name="message">
        /// detail message
        /// Serialized Name: CheckNameAvailabilityResponse.message
        /// </param>
        internal CheckNameAvailabilityResponse(bool nameAvailable, NameUnavailableReason? reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// if name Available
        /// Serialized Name: CheckNameAvailabilityResponse.nameAvailable
        /// </summary>
        public bool NameAvailable { get; }
        /// <summary>
        /// Resource Name To Verify
        /// Serialized Name: CheckNameAvailabilityResponse.reason
        /// </summary>
        public NameUnavailableReason? Reason { get; }
        /// <summary>
        /// detail message
        /// Serialized Name: CheckNameAvailabilityResponse.message
        /// </summary>
        public string Message { get; }
    }
}
