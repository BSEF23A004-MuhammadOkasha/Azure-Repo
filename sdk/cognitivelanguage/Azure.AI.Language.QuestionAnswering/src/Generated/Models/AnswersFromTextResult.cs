// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Represents the answer results. </summary>
    public partial class AnswersFromTextResult
    {
        /// <summary> Initializes a new instance of AnswersFromTextResult. </summary>
        internal AnswersFromTextResult()
        {
            Answers = new Core.ChangeTrackingList<TextAnswer>();
        }

        /// <summary> Initializes a new instance of AnswersFromTextResult. </summary>
        /// <param name="answers"> Represents the answer results. </param>
        internal AnswersFromTextResult(IReadOnlyList<TextAnswer> answers)
        {
            Answers = answers;
        }

        /// <summary> Represents the answer results. </summary>
        public IReadOnlyList<TextAnswer> Answers { get; }
    }
}
