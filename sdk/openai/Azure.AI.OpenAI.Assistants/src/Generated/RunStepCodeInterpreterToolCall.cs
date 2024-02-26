// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary>
    /// A record of a call to a code interpreter tool, issued by the model in evaluation of a defined tool, that
    /// represents inputs and outputs consumed and emitted by the code interpreter.
    /// </summary>
    public partial class RunStepCodeInterpreterToolCall : RunStepToolCall
    {
        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterToolCall"/>. </summary>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <param name="internalDetails"> The details of the tool call to the code interpreter tool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="internalDetails"/> is null. </exception>
        internal RunStepCodeInterpreterToolCall(string id, InternalCodeInterpreterToolCallDetails internalDetails) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (internalDetails == null)
            {
                throw new ArgumentNullException(nameof(internalDetails));
            }

            Type = "code_interpreter";
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterToolCall"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails"> The details of the tool call to the code interpreter tool. </param>
        internal RunStepCodeInterpreterToolCall(string type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalCodeInterpreterToolCallDetails internalDetails) : base(type, id, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterToolCall"/> for deserialization. </summary>
        internal RunStepCodeInterpreterToolCall()
        {
        }
    }
}
