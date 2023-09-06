// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Currency field value. </summary>
    public readonly partial struct CurrencyValue
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private readonly Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CurrencyValue"/>. </summary>
        /// <param name="amount"> Currency amount. </param>
        /// <param name="symbol"> Currency symbol label, if any. </param>
        /// <param name="code"> Resolved currency code (ISO 4217), if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CurrencyValue(double amount, string symbol, string code, Dictionary<string, BinaryData> rawData)
        {
            Amount = amount;
            Symbol = symbol;
            Code = code;
            _rawData = rawData;
        }
    }
}
