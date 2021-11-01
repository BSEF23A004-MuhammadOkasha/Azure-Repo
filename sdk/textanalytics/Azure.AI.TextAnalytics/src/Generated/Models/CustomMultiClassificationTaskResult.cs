// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The CustomMultiClassificationTaskResult. </summary>
    internal partial class CustomMultiClassificationTaskResult
    {
        /// <summary> Initializes a new instance of CustomMultiClassificationTaskResult. </summary>
        internal CustomMultiClassificationTaskResult()
        {
        }

        /// <summary> Initializes a new instance of CustomMultiClassificationTaskResult. </summary>
        /// <param name="results"></param>
        internal CustomMultiClassificationTaskResult(CustomMultiClassificationResult results)
        {
            Results = results;
        }

        public CustomMultiClassificationResult Results { get; }
    }
}
