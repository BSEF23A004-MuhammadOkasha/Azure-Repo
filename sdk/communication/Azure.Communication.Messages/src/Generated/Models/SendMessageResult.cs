// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> Result of the send message operation. </summary>
    public partial class SendMessageResult
    {
        /// <summary> Initializes a new instance of SendMessageResult. </summary>
        /// <param name="receipts"> Receipts of the send message operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receipts"/> is null. </exception>
        internal SendMessageResult(IEnumerable<MessageReceipt> receipts)
        {
            Argument.AssertNotNull(receipts, nameof(receipts));

            Receipts = receipts.ToList();
        }

        /// <summary> Initializes a new instance of SendMessageResult. </summary>
        /// <param name="receipts"> Receipts of the send message operation. </param>
        internal SendMessageResult(IReadOnlyList<MessageReceipt> receipts)
        {
            Receipts = receipts;
        }

        /// <summary> Receipts of the send message operation. </summary>
        public IReadOnlyList<MessageReceipt> Receipts { get; }
    }
}
