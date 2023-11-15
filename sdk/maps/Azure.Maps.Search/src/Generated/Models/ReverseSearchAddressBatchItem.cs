// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> An item returned from Search Address Reverse Batch service call. </summary>
    internal partial class ReverseSearchAddressBatchItem : BatchResultItem
    {
        /// <summary> Initializes a new instance of <see cref="ReverseSearchAddressBatchItem"/>. </summary>
        internal ReverseSearchAddressBatchItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReverseSearchAddressBatchItem"/>. </summary>
        /// <param name="statusCode"> HTTP request status code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="response"> The result of the query. SearchAddressReverseResponse if the query completed successfully, ErrorResponse otherwise. </param>
        internal ReverseSearchAddressBatchItem(int? statusCode, IDictionary<string, BinaryData> serializedAdditionalRawData, ReverseSearchAddressBatchItemResponse response) : base(statusCode, serializedAdditionalRawData)
        {
            Response = response;
        }

        /// <summary> The result of the query. SearchAddressReverseResponse if the query completed successfully, ErrorResponse otherwise. </summary>
        public ReverseSearchAddressBatchItemResponse Response { get; }
    }
}
