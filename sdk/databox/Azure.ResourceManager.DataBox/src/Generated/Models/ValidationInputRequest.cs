// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary>
    /// Minimum fields that must be present in any type of validation request.
    /// Please note <see cref="ValidationInputRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CreateOrderLimitForSubscriptionValidationRequest"/>, <see cref="DataTransferDetailsValidationRequest"/>, <see cref="PreferencesValidationRequest"/>, <see cref="SkuAvailabilityValidationRequest"/>, <see cref="SubscriptionIsAllowedToCreateJobValidationRequest"/> and <see cref="ValidateAddress"/>.
    /// </summary>
    public partial class ValidationInputRequest
    {
        /// <summary> Initializes a new instance of ValidationInputRequest. </summary>
        public ValidationInputRequest()
        {
        }

        /// <summary> Identifies the type of validation request. </summary>
        internal ValidationInputDiscriminator ValidationType { get; set; }
    }
}
