// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> The incurred cost for a single short code. </summary>
    public partial class ShortCodeCost
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ShortCodeCost"/>. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="currencyCode"> The ISO 4217 currency code for the cost amount, e.g. USD. </param>
        /// <param name="billingFrequency"> The frequency with which the cost gets billed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="currencyCode"/> is null. </exception>
        public ShortCodeCost(double amount, string currencyCode, BillingFrequency billingFrequency)
        {
            Argument.AssertNotNull(currencyCode, nameof(currencyCode));

            Amount = amount;
            CurrencyCode = currencyCode;
            BillingFrequency = billingFrequency;
        }

        /// <summary> Initializes a new instance of <see cref="ShortCodeCost"/>. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="currencyCode"> The ISO 4217 currency code for the cost amount, e.g. USD. </param>
        /// <param name="billingFrequency"> The frequency with which the cost gets billed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ShortCodeCost(double amount, string currencyCode, BillingFrequency billingFrequency, Dictionary<string, BinaryData> rawData)
        {
            Amount = amount;
            CurrencyCode = currencyCode;
            BillingFrequency = billingFrequency;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ShortCodeCost"/> for deserialization. </summary>
        internal ShortCodeCost()
        {
        }

        /// <summary> The cost amount. </summary>
        public double Amount { get; set; }
        /// <summary> The ISO 4217 currency code for the cost amount, e.g. USD. </summary>
        public string CurrencyCode { get; set; }
        /// <summary> The frequency with which the cost gets billed. </summary>
        public BillingFrequency BillingFrequency { get; set; }
    }
}
