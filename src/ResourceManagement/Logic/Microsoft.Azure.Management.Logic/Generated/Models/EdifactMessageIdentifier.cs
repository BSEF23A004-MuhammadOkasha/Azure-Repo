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
    /// The Edifact message identifier.
    /// </summary>
    public partial class EdifactMessageIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the EdifactMessageIdentifier class.
        /// </summary>
        public EdifactMessageIdentifier() { }

        /// <summary>
        /// Initializes a new instance of the EdifactMessageIdentifier class.
        /// </summary>
        public EdifactMessageIdentifier(string messageId = default(string))
        {
            MessageId = messageId;
        }

        /// <summary>
        /// Gets or sets the message id on which this envelope settings has to
        /// be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

    }
}
