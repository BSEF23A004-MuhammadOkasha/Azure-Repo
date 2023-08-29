// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConfidentialLedger;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Object that includes an array of Confidential Ledgers and a possible link for next set. </summary>
    internal partial class ConfidentialLedgerList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConfidentialLedgerList"/>. </summary>
        internal ConfidentialLedgerList()
        {
            Value = new ChangeTrackingList<ConfidentialLedgerData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfidentialLedgerList"/>. </summary>
        /// <param name="value"> List of Confidential Ledgers. </param>
        /// <param name="nextLink"> The URL the client should use to fetch the next page (per server side paging). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfidentialLedgerList(IReadOnlyList<ConfidentialLedgerData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Confidential Ledgers. </summary>
        public IReadOnlyList<ConfidentialLedgerData> Value { get; }
        /// <summary> The URL the client should use to fetch the next page (per server side paging). </summary>
        public string NextLink { get; }
    }
}
