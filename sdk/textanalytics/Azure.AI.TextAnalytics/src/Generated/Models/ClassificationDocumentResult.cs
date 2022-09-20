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
    /// <summary> The ClassificationDocumentResult. </summary>
    internal partial class ClassificationDocumentResult : DocumentResult
    {
        /// <summary> Initializes a new instance of ClassificationDocumentResult. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="class"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="class"/> is null. </exception>
        public ClassificationDocumentResult(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<ClassificationResult> @class) : base(id, warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }
            if (@class == null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            Class = @class.ToList();
        }

        /// <summary> Initializes a new instance of ClassificationDocumentResult. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="class"></param>
        internal ClassificationDocumentResult(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<ClassificationResult> @class) : base(id, warnings, statistics)
        {
            Class = @class;
        }

        /// <summary> Gets the class. </summary>
        public IList<ClassificationResult> Class { get; }
    }
}
