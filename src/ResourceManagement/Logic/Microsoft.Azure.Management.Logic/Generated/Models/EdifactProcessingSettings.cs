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
    /// The Edifact agreement protocol settings.
    /// </summary>
    public partial class EdifactProcessingSettings
    {
        /// <summary>
        /// Initializes a new instance of the EdifactProcessingSettings class.
        /// </summary>
        public EdifactProcessingSettings() { }

        /// <summary>
        /// Initializes a new instance of the EdifactProcessingSettings class.
        /// </summary>
        public EdifactProcessingSettings(bool? maskSecurityInfo = default(bool?), bool? preserveInterchange = default(bool?), bool? suspendInterchangeOnError = default(bool?), bool? createEmptyXmlTagsForTrailingSeparators = default(bool?), bool? useDotAsDecimalSeparator = default(bool?))
        {
            MaskSecurityInfo = maskSecurityInfo;
            PreserveInterchange = preserveInterchange;
            SuspendInterchangeOnError = suspendInterchangeOnError;
            CreateEmptyXmlTagsForTrailingSeparators = createEmptyXmlTagsForTrailingSeparators;
            UseDotAsDecimalSeparator = useDotAsDecimalSeparator;
        }

        /// <summary>
        /// Gets or sets the value indicating whether to mask security
        /// information.
        /// </summary>
        [JsonProperty(PropertyName = "maskSecurityInfo")]
        public bool? MaskSecurityInfo { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to preserve interchange.
        /// </summary>
        [JsonProperty(PropertyName = "preserveInterchange")]
        public bool? PreserveInterchange { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to suspend interchange
        /// on error.
        /// </summary>
        [JsonProperty(PropertyName = "suspendInterchangeOnError")]
        public bool? SuspendInterchangeOnError { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to create empty xml tags
        /// for trailing separators.
        /// </summary>
        [JsonProperty(PropertyName = "createEmptyXmlTagsForTrailingSeparators")]
        public bool? CreateEmptyXmlTagsForTrailingSeparators { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to use dot as decimal
        /// separator.
        /// </summary>
        [JsonProperty(PropertyName = "useDotAsDecimalSeparator")]
        public bool? UseDotAsDecimalSeparator { get; set; }

    }
}
