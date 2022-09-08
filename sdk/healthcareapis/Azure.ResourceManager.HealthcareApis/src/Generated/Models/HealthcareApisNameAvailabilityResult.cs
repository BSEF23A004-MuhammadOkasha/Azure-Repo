// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The properties indicating whether a given service name is available. </summary>
    public partial class HealthcareApisNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of HealthcareApisNameAvailabilityResult. </summary>
        internal HealthcareApisNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of HealthcareApisNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"> The value which indicates whether the provided name is available. </param>
        /// <param name="reason"> The reason for unavailability. </param>
        /// <param name="message"> The detailed reason message. </param>
        internal HealthcareApisNameAvailabilityResult(bool? isNameAvailable, HealthcareApisNameUnavailableReason? reason, string message)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> The value which indicates whether the provided name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason for unavailability. </summary>
        public HealthcareApisNameUnavailableReason? Reason { get; }
        /// <summary> The detailed reason message. </summary>
        public string Message { get; }
    }
}
