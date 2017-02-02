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
    /// The AS2 agreement acknowledegment connection settings.
    /// </summary>
    public partial class AS2AcknowledgementConnectionSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AS2AcknowledgementConnectionSettings class.
        /// </summary>
        public AS2AcknowledgementConnectionSettings() { }

        /// <summary>
        /// Initializes a new instance of the
        /// AS2AcknowledgementConnectionSettings class.
        /// </summary>
        public AS2AcknowledgementConnectionSettings(bool? ignoreCertificateNameMismatch = default(bool?), bool? supportHttpStatusCodeContinue = default(bool?), bool? keepHttpConnectionAlive = default(bool?), bool? unfoldHttpHeaders = default(bool?))
        {
            IgnoreCertificateNameMismatch = ignoreCertificateNameMismatch;
            SupportHttpStatusCodeContinue = supportHttpStatusCodeContinue;
            KeepHttpConnectionAlive = keepHttpConnectionAlive;
            UnfoldHttpHeaders = unfoldHttpHeaders;
        }

        /// <summary>
        /// Gets or sets the value indicating whether to ignore mismatch in
        /// certificate name.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreCertificateNameMismatch")]
        public bool? IgnoreCertificateNameMismatch { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to support HTTP status
        /// code 'CONTINUE'.
        /// </summary>
        [JsonProperty(PropertyName = "supportHttpStatusCodeContinue")]
        public bool? SupportHttpStatusCodeContinue { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to keep the connection
        /// alive.
        /// </summary>
        [JsonProperty(PropertyName = "keepHttpConnectionAlive")]
        public bool? KeepHttpConnectionAlive { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to unfold the HTTP
        /// headers.
        /// </summary>
        [JsonProperty(PropertyName = "unfoldHttpHeaders")]
        public bool? UnfoldHttpHeaders { get; set; }

    }
}
