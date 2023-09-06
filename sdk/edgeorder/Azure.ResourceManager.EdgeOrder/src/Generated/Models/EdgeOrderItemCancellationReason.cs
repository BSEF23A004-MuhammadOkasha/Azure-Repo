// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Reason for cancellation. </summary>
    public partial class EdgeOrderItemCancellationReason
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemCancellationReason"/>. </summary>
        /// <param name="reason"> Reason for cancellation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reason"/> is null. </exception>
        public EdgeOrderItemCancellationReason(string reason)
        {
            Argument.AssertNotNull(reason, nameof(reason));

            Reason = reason;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemCancellationReason"/>. </summary>
        /// <param name="reason"> Reason for cancellation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderItemCancellationReason(string reason, Dictionary<string, BinaryData> rawData)
        {
            Reason = reason;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemCancellationReason"/> for deserialization. </summary>
        internal EdgeOrderItemCancellationReason()
        {
        }

        /// <summary> Reason for cancellation. </summary>
        public string Reason { get; }
    }
}
