// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The X12 oneway agreement.
    /// </summary>
    public partial class X12OneWayAgreement
    {
        /// <summary>
        /// Initializes a new instance of the X12OneWayAgreement class.
        /// </summary>
        public X12OneWayAgreement() { }

        /// <summary>
        /// Initializes a new instance of the X12OneWayAgreement class.
        /// </summary>
        public X12OneWayAgreement(BusinessIdentity senderBusinessIdentity = default(BusinessIdentity), BusinessIdentity receiverBusinessIdentity = default(BusinessIdentity), X12ProtocolSettings protocolSettings = default(X12ProtocolSettings))
        {
            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
        }

        /// <summary>
        /// Gets or sets the sender business identity
        /// </summary>
        [JsonProperty(PropertyName = "senderBusinessIdentity")]
        public BusinessIdentity SenderBusinessIdentity { get; set; }

        /// <summary>
        /// Gets or sets the receiver business identity
        /// </summary>
        [JsonProperty(PropertyName = "receiverBusinessIdentity")]
        public BusinessIdentity ReceiverBusinessIdentity { get; set; }

        /// <summary>
        /// Gets or sets the X12 protocol settings.
        /// </summary>
        [JsonProperty(PropertyName = "protocolSettings")]
        public X12ProtocolSettings ProtocolSettings { get; set; }

    }
}
