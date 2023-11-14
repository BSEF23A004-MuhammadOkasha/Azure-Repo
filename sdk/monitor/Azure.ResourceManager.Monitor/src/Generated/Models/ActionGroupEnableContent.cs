// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Describes a receiver that should be resubscribed. </summary>
    public partial class ActionGroupEnableContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ActionGroupEnableContent"/>. </summary>
        /// <param name="receiverName"> The name of the receiver to resubscribe. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiverName"/> is null. </exception>
        public ActionGroupEnableContent(string receiverName)
        {
            Argument.AssertNotNull(receiverName, nameof(receiverName));

            ReceiverName = receiverName;
        }

        /// <summary> Initializes a new instance of <see cref="ActionGroupEnableContent"/>. </summary>
        /// <param name="receiverName"> The name of the receiver to resubscribe. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ActionGroupEnableContent(string receiverName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReceiverName = receiverName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ActionGroupEnableContent"/> for deserialization. </summary>
        internal ActionGroupEnableContent()
        {
        }

        /// <summary> The name of the receiver to resubscribe. </summary>
        public string ReceiverName { get; }
    }
}
