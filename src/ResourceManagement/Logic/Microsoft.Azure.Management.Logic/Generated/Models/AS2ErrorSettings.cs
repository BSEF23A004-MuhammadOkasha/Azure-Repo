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
    /// The AS2 agreement error settings.
    /// </summary>
    public partial class AS2ErrorSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2ErrorSettings class.
        /// </summary>
        public AS2ErrorSettings() { }

        /// <summary>
        /// Initializes a new instance of the AS2ErrorSettings class.
        /// </summary>
        public AS2ErrorSettings(bool? suspendDuplicateMessage = default(bool?), bool? resendIfMdnNotReceived = default(bool?))
        {
            SuspendDuplicateMessage = suspendDuplicateMessage;
            ResendIfMdnNotReceived = resendIfMdnNotReceived;
        }

        /// <summary>
        /// Gets or sets the value indicating whether to suspend duplicate
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "suspendDuplicateMessage")]
        public bool? SuspendDuplicateMessage { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to resend message If MDN
        /// is not received.
        /// </summary>
        [JsonProperty(PropertyName = "resendIfMdnNotReceived")]
        public bool? ResendIfMdnNotReceived { get; set; }

    }
}
