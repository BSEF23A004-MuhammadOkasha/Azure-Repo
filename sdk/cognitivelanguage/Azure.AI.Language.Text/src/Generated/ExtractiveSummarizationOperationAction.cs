// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> An object representing the task definition for an Extractive Summarization task. </summary>
    public partial class ExtractiveSummarizationOperationAction : AnalyzeTextOperationAction
    {
        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationOperationAction"/>. </summary>
        public ExtractiveSummarizationOperationAction()
        {
            Kind = AnalyzeTextOperationActionKind.ExtractiveSummarization;
        }

        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationOperationAction"/>. </summary>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> The kind of task to perform. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="actionContent"> Parameters for the Extractive Summarization task. </param>
        internal ExtractiveSummarizationOperationAction(string name, AnalyzeTextOperationActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, ExtractiveSummarizationActionContent actionContent) : base(name, kind, serializedAdditionalRawData)
        {
            ActionContent = actionContent;
        }

        /// <summary> Parameters for the Extractive Summarization task. </summary>
        public ExtractiveSummarizationActionContent ActionContent { get; set; }
    }
}
