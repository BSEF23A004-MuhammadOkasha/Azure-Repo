// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The LanguageDetectionAnalysisInput. </summary>
    internal partial class LanguageDetectionAnalysisInput
    {
        /// <summary> Initializes a new instance of LanguageDetectionAnalysisInput. </summary>
        public LanguageDetectionAnalysisInput()
        {
            Documents = new Core.ChangeTrackingList<LanguageInput>();
        }

        /// <summary> Gets the documents. </summary>
        public IList<LanguageInput> Documents { get; }
    }
}
