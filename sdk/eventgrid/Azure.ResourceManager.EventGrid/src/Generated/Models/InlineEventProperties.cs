// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Additional information about every inline event. </summary>
    public partial class InlineEventProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="InlineEventProperties"/>. </summary>
        public InlineEventProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InlineEventProperties"/>. </summary>
        /// <param name="description"> The description for the inline event. </param>
        /// <param name="displayName"> The displayName for the inline event. </param>
        /// <param name="documentationUri"> The documentationUrl for the inline event. </param>
        /// <param name="dataSchemaUri"> The dataSchemaUrl for the inline event. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InlineEventProperties(string description, string displayName, Uri documentationUri, Uri dataSchemaUri, Dictionary<string, BinaryData> rawData)
        {
            Description = description;
            DisplayName = displayName;
            DocumentationUri = documentationUri;
            DataSchemaUri = dataSchemaUri;
            _rawData = rawData;
        }

        /// <summary> The description for the inline event. </summary>
        public string Description { get; set; }
        /// <summary> The displayName for the inline event. </summary>
        public string DisplayName { get; set; }
        /// <summary> The documentationUrl for the inline event. </summary>
        public Uri DocumentationUri { get; set; }
        /// <summary> The dataSchemaUrl for the inline event. </summary>
        public Uri DataSchemaUri { get; set; }
    }
}
