// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The list of payment method links. </summary>
    internal partial class PaymentMethodLinksListResult
    {
        /// <summary> Initializes a new instance of PaymentMethodLinksListResult. </summary>
        internal PaymentMethodLinksListResult()
        {
            Value = new ChangeTrackingList<BillingPaymentMethodLinkData>();
        }

        /// <summary> Initializes a new instance of PaymentMethodLinksListResult. </summary>
        /// <param name="value"> The list of payment method links. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal PaymentMethodLinksListResult(IReadOnlyList<BillingPaymentMethodLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of payment method links. </summary>
        public IReadOnlyList<BillingPaymentMethodLinkData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
