// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration account AS2 one-way agreement. </summary>
    public partial class AS2OneWayAgreement
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AS2OneWayAgreement"/>. </summary>
        /// <param name="senderBusinessIdentity"> The sender business identity. </param>
        /// <param name="receiverBusinessIdentity"> The receiver business identity. </param>
        /// <param name="protocolSettings"> The AS2 protocol settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="senderBusinessIdentity"/>, <paramref name="receiverBusinessIdentity"/> or <paramref name="protocolSettings"/> is null. </exception>
        public AS2OneWayAgreement(IntegrationAccountBusinessIdentity senderBusinessIdentity, IntegrationAccountBusinessIdentity receiverBusinessIdentity, AS2ProtocolSettings protocolSettings)
        {
            Argument.AssertNotNull(senderBusinessIdentity, nameof(senderBusinessIdentity));
            Argument.AssertNotNull(receiverBusinessIdentity, nameof(receiverBusinessIdentity));
            Argument.AssertNotNull(protocolSettings, nameof(protocolSettings));

            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
        }

        /// <summary> Initializes a new instance of <see cref="AS2OneWayAgreement"/>. </summary>
        /// <param name="senderBusinessIdentity"> The sender business identity. </param>
        /// <param name="receiverBusinessIdentity"> The receiver business identity. </param>
        /// <param name="protocolSettings"> The AS2 protocol settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AS2OneWayAgreement(IntegrationAccountBusinessIdentity senderBusinessIdentity, IntegrationAccountBusinessIdentity receiverBusinessIdentity, AS2ProtocolSettings protocolSettings, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AS2OneWayAgreement"/> for deserialization. </summary>
        internal AS2OneWayAgreement()
        {
        }

        /// <summary> The sender business identity. </summary>
        public IntegrationAccountBusinessIdentity SenderBusinessIdentity { get; set; }
        /// <summary> The receiver business identity. </summary>
        public IntegrationAccountBusinessIdentity ReceiverBusinessIdentity { get; set; }
        /// <summary> The AS2 protocol settings. </summary>
        public AS2ProtocolSettings ProtocolSettings { get; set; }
    }
}
