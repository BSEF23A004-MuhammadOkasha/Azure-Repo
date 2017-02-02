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
    /// The AS2 agreement mdn settings.
    /// </summary>
    public partial class AS2MdnSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2MdnSettings class.
        /// </summary>
        public AS2MdnSettings() { }

        /// <summary>
        /// Initializes a new instance of the AS2MdnSettings class.
        /// </summary>
        public AS2MdnSettings(bool? needMdn = default(bool?), bool? signMdn = default(bool?), bool? sendMdnAsynchronously = default(bool?), string receiptDeliveryUrl = default(string), string dispositionNotificationTo = default(string), bool? signOutboundMdnIfOptional = default(bool?), string mdnText = default(string), bool? sendInboundMdnToMessageBox = default(bool?), HashingAlgorithm? micHashingAlgorithm = default(HashingAlgorithm?))
        {
            NeedMdn = needMdn;
            SignMdn = signMdn;
            SendMdnAsynchronously = sendMdnAsynchronously;
            ReceiptDeliveryUrl = receiptDeliveryUrl;
            DispositionNotificationTo = dispositionNotificationTo;
            SignOutboundMdnIfOptional = signOutboundMdnIfOptional;
            MdnText = mdnText;
            SendInboundMdnToMessageBox = sendInboundMdnToMessageBox;
            MicHashingAlgorithm = micHashingAlgorithm;
        }

        /// <summary>
        /// Gets or sets the value indicating whether to send or request a MDN.
        /// </summary>
        [JsonProperty(PropertyName = "needMdn")]
        public bool? NeedMdn { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the MDN needs to be
        /// signed or not.
        /// </summary>
        [JsonProperty(PropertyName = "signMdn")]
        public bool? SignMdn { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to send the asynchronous
        /// MDN.
        /// </summary>
        [JsonProperty(PropertyName = "sendMdnAsynchronously")]
        public bool? SendMdnAsynchronously { get; set; }

        /// <summary>
        /// Gets or sets the receipt delivery URL.
        /// </summary>
        [JsonProperty(PropertyName = "receiptDeliveryUrl")]
        public string ReceiptDeliveryUrl { get; set; }

        /// <summary>
        /// Gets or sets the disposition notification to header value.
        /// </summary>
        [JsonProperty(PropertyName = "dispositionNotificationTo")]
        public string DispositionNotificationTo { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to sign the outbound MDN
        /// if optional.
        /// </summary>
        [JsonProperty(PropertyName = "signOutboundMdnIfOptional")]
        public bool? SignOutboundMdnIfOptional { get; set; }

        /// <summary>
        /// Gets or sets the MDN text.
        /// </summary>
        [JsonProperty(PropertyName = "mdnText")]
        public string MdnText { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to send inbound MDN to
        /// message box.
        /// </summary>
        [JsonProperty(PropertyName = "sendInboundMdnToMessageBox")]
        public bool? SendInboundMdnToMessageBox { get; set; }

        /// <summary>
        /// Gets or sets the signing or hashing algorithm. Possible values
        /// include: 'NotSpecified', 'None', 'MD5', 'SHA1', 'SHA2256',
        /// 'SHA2384', 'SHA2512'
        /// </summary>
        [JsonProperty(PropertyName = "micHashingAlgorithm")]
        public HashingAlgorithm? MicHashingAlgorithm { get; set; }

    }
}
