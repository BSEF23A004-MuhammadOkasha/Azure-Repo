// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error details of the transfer eligibility validation
    /// </summary>
    public partial class ValidateSubscriptionTransferEligibilityError
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ValidateSubscriptionTransferEligibilityError class.
        /// </summary>
        public ValidateSubscriptionTransferEligibilityError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ValidateSubscriptionTransferEligibilityError class.
        /// </summary>
        /// <param name="code">Error code for the product transfer validation.
        /// Possible values include: 'InvalidSource', 'SubscriptionNotActive',
        /// 'InsufficienctPermissionOnSource',
        /// 'InsufficienctPermissionOnDestination',
        /// 'DestinationBillingProfilePastDue', 'SubscriptionTypeNotSupported',
        /// 'CrossBillingAccountNotAllowed',
        /// 'NotAvailableForDestinationMarket'</param>
        /// <param name="message">The error message.</param>
        /// <param name="details">Detailed error message explaining the
        /// error.</param>
        public ValidateSubscriptionTransferEligibilityError(string code = default(string), string message = default(string), string details = default(string))
        {
            Code = code;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code for the product transfer validation.
        /// Possible values include: 'InvalidSource', 'SubscriptionNotActive',
        /// 'InsufficienctPermissionOnSource',
        /// 'InsufficienctPermissionOnDestination',
        /// 'DestinationBillingProfilePastDue', 'SubscriptionTypeNotSupported',
        /// 'CrossBillingAccountNotAllowed', 'NotAvailableForDestinationMarket'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets detailed error message explaining the error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

    }
}
