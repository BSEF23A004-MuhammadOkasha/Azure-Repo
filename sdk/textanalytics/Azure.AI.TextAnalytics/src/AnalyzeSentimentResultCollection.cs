﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Collection of <see cref="AnalyzeSentimentResult"/> objects corresponding
    /// to a batch of documents, and information about the batch operation.
    /// </summary>
    public class AnalyzeSentimentResultCollection : ReadOnlyCollection<AnalyzeSentimentResult>
    {
        internal AnalyzeSentimentResultCollection(IList<AnalyzeSentimentResult> list, TextDocumentBatchStatistics statistics, string modelVersion) : base(list)
        {
            Statistics = statistics;
            ModelVersion = modelVersion;
        }

        /// <summary>
        /// Gets statistics about the documents and how it was processed
        /// by the service.  This property will have a value when IncludeStatistics in <see cref="AnalyzeSentimentOptions"/>
        /// is set to True in the client call.
        /// </summary>
        public TextDocumentBatchStatistics Statistics { get; }

        /// <summary>
        /// Gets the version of the Text Analytics model used by this operation
        /// on this batch of documents.
        /// </summary>
        public string ModelVersion { get; }
    }
}
