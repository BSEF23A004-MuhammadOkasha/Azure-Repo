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
    /// <summary> The DocumentLinkedEntities. </summary>
    public partial class DocumentLinkedEntities
    {
        /// <summary> Initializes a new instance of DocumentLinkedEntities. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="entities"> Recognized well known entities in the document. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="entities"/>, or <paramref name="warnings"/> is null. </exception>
        internal DocumentLinkedEntities(string id, IEnumerable<LinkedEntity> entities, IEnumerable<TextAnalyticsWarningInternal> warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }

            Id = id;
            Entities = entities.ToList();
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of DocumentLinkedEntities. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="entities"> Recognized well known entities in the document. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        internal DocumentLinkedEntities(string id, IReadOnlyList<LinkedEntity> entities, IReadOnlyList<TextAnalyticsWarningInternal> warnings, TextDocumentStatistics? statistics)
        {
            Id = id;
            Entities = entities;
            Warnings = warnings;
            Statistics = statistics;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Recognized well known entities in the document. </summary>
        public IReadOnlyList<LinkedEntity> Entities { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<TextAnalyticsWarningInternal> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public TextDocumentStatistics? Statistics { get; }
    }
}
