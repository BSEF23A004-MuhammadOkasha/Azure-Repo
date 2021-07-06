// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class PhoneNumbersModelFactory
    {

        /// <summary> Initializes a new instance of PhoneNumberCost. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="isoCurrencySymbol"> The ISO 4217 currency code for the cost amount, e.g. USD. </param>
        /// <param name="billingFrequency"> The frequency with which the cost gets billed. </param>
        /// <returns> A new <see cref="PhoneNumbers.PhoneNumberCost"/> instance for mocking. </returns>
        public static PhoneNumberCost PhoneNumberCost(double amount = default, string isoCurrencySymbol = null, BillingFrequency billingFrequency = default)
        {
            return new PhoneNumberCost(amount, isoCurrencySymbol, billingFrequency);
        }
    }
}
