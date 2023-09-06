// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The representation of a single prompt completion as part of an overall chat completions request.
    /// Generally, `n` choices are generated per provided prompt with a default value of 1.
    /// Token limits and other settings may limit the number of choices generated.
    /// </summary>
    public partial class ChatChoice
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of ChatChoice. </summary>
        /// <param name="index"> The ordered index associated with this chat completions choice. </param>
        /// <param name="finishReason"> The reason that this chat completions choice completed its generated. </param>
        internal ChatChoice(int index, CompletionsFinishReason? finishReason)
        {
            Index = index;
            FinishReason = finishReason;
        }

        /// <summary> Initializes a new instance of ChatChoice. </summary>
        /// <param name="message"> The chat message for a given chat completions prompt. </param>
        /// <param name="index"> The ordered index associated with this chat completions choice. </param>
        /// <param name="finishReason"> The reason that this chat completions choice completed its generated. </param>
        /// <param name="internalStreamingDeltaMessage"> The delta message content for a streaming response. </param>
        /// <param name="contentFilterResults">
        /// Information about the content filtering category (hate, sexual, violence, self_harm), if it
        /// has been detected, as well as the severity level (very_low, low, medium, high-scale that
        /// determines the intensity and risk level of harmful content) and if it has been filtered or not.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatChoice(ChatMessage message, int index, CompletionsFinishReason? finishReason, ChatMessage internalStreamingDeltaMessage, ContentFilterResults contentFilterResults, Dictionary<string, BinaryData> rawData)
        {
            Message = message;
            Index = index;
            FinishReason = finishReason;
            InternalStreamingDeltaMessage = internalStreamingDeltaMessage;
            ContentFilterResults = contentFilterResults;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatChoice"/> for deserialization. </summary>
        internal ChatChoice()
        {
        }

        /// <summary> The chat message for a given chat completions prompt. </summary>
        public ChatMessage Message { get; }
        /// <summary> The ordered index associated with this chat completions choice. </summary>
        public int Index { get; }
        /// <summary> The reason that this chat completions choice completed its generated. </summary>
        public CompletionsFinishReason? FinishReason { get; }
        /// <summary>
        /// Information about the content filtering category (hate, sexual, violence, self_harm), if it
        /// has been detected, as well as the severity level (very_low, low, medium, high-scale that
        /// determines the intensity and risk level of harmful content) and if it has been filtered or not.
        /// </summary>
        public ContentFilterResults ContentFilterResults { get; }
    }
}
