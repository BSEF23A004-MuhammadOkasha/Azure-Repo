// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The DocumentLanguage. </summary>
    public partial class DocumentLanguage
    {
        /// <summary> Initializes a new instance of DocumentLanguage. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="detectedLanguage"> Detected Language. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="warnings"/> is null. </exception>
        internal DocumentLanguage(string id, DetectedLanguageInternal detectedLanguage, IEnumerable<TextAnalyticsWarningInternal> warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }

            Id = id;
            DetectedLanguage = detectedLanguage;
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of DocumentLanguage. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="detectedLanguage"> Detected Language. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        internal DocumentLanguage(string id, DetectedLanguageInternal detectedLanguage, IReadOnlyList<TextAnalyticsWarningInternal> warnings, TextDocumentStatistics? statistics)
        {
            Id = id;
            DetectedLanguage = detectedLanguage;
            Warnings = warnings;
            Statistics = statistics;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Detected Language. </summary>
        public DetectedLanguageInternal DetectedLanguage { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<TextAnalyticsWarningInternal> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public TextDocumentStatistics? Statistics { get; }
    }
}
