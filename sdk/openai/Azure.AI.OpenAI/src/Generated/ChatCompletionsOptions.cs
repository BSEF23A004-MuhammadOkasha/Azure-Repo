// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The configuration information for a chat completions request.
    /// Completions support a wide variety of tasks and generate text that continues from or "completes"
    /// provided prompt data.
    /// </summary>
    public partial class ChatCompletionsOptions
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsOptions"/>. </summary>
        /// <param name="messages">
        /// The collection of context messages associated with this chat completions request.
        /// Typical usage begins with a chat message for the System role that provides instructions for
        /// the behavior of the assistant, followed by alternating messages between the User and
        /// Assistant roles.
        /// </param>
        /// <param name="functions"> A list of functions the model may generate JSON inputs for. </param>
        /// <param name="functionCall">
        /// Controls how the model responds to function calls. "none" means the model does not call a function,
        /// and responds to the end-user. "auto" means the model can pick between an end-user or calling a function.
        ///  Specifying a particular function via `{"name": "my_function"}` forces the model to call that function.
        ///  "none" is the default when no functions are present. "auto" is the default if functions are present.
        /// </param>
        /// <param name="maxTokens"> The maximum number of tokens to generate. </param>
        /// <param name="temperature">
        /// The sampling temperature to use that controls the apparent creativity of generated completions.
        /// Higher values will make output more random while lower values will make results more focused
        /// and deterministic.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// </param>
        /// <param name="nucleusSamplingFactor">
        /// An alternative to sampling with temperature called nucleus sampling. This value causes the
        /// model to consider the results of tokens with the provided probability mass. As an example, a
        /// value of 0.15 will cause only the tokens comprising the top 15% of probability mass to be
        /// considered.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// </param>
        /// <param name="internalStringKeyedTokenSelectionBiases">
        /// A map between GPT token IDs and bias scores that influences the probability of specific tokens
        /// appearing in a completions response. Token IDs are computed via external tokenizer tools, while
        /// bias scores reside in the range of -100 to 100 with minimum and maximum values corresponding to
        /// a full ban or exclusive selection of a token, respectively. The exact behavior of a given bias
        /// score varies by model.
        /// </param>
        /// <param name="user">
        /// An identifier for the caller or end user of the operation. This may be used for tracking
        /// or rate-limiting purposes.
        /// </param>
        /// <param name="choiceCount">
        /// The number of chat completions choices that should be generated for a chat completions
        /// response.
        /// Because this setting can generate many completions, it may quickly consume your token quota.
        /// Use carefully and ensure reasonable settings for max_tokens and stop.
        /// </param>
        /// <param name="stopSequences"> A collection of textual sequences that will end completions generation. </param>
        /// <param name="presencePenalty">
        /// A value that influences the probability of generated tokens appearing based on their existing
        /// presence in generated text.
        /// Positive values will make tokens less likely to appear when they already exist and increase the
        /// model's likelihood to output new topics.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A value that influences the probability of generated tokens appearing based on their cumulative
        /// frequency in generated text.
        /// Positive values will make tokens less likely to appear as their frequency increases and
        /// decrease the likelihood of the model repeating the same statements verbatim.
        /// </param>
        /// <param name="internalShouldStreamResponse"> A value indicating whether chat completions should be streamed for this request. </param>
        /// <param name="deploymentName">
        /// The model name to provide as part of this completions request.
        /// Not applicable to Azure OpenAI, where deployment information should be included in the Azure
        /// resource URI that's connected to.
        /// </param>
        /// <param name="internalAzureExtensionsDataSources">
        ///   The configuration entries for Azure OpenAI chat extensions that use them.
        ///   This additional specification is only compatible with Azure OpenAI.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionsOptions(IList<ChatMessage> messages, IList<FunctionDefinition> functions, FunctionDefinition functionCall, int? maxTokens, float? temperature, float? nucleusSamplingFactor, IDictionary<string, int> internalStringKeyedTokenSelectionBiases, string user, int? choiceCount, IList<string> stopSequences, float? presencePenalty, float? frequencyPenalty, bool? internalShouldStreamResponse, string deploymentName, IList<AzureChatExtensionConfiguration> internalAzureExtensionsDataSources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Messages = messages;
            Functions = functions;
            FunctionCall = functionCall;
            MaxTokens = maxTokens;
            Temperature = temperature;
            NucleusSamplingFactor = nucleusSamplingFactor;
            InternalStringKeyedTokenSelectionBiases = internalStringKeyedTokenSelectionBiases;
            User = user;
            ChoiceCount = choiceCount;
            StopSequences = stopSequences;
            PresencePenalty = presencePenalty;
            FrequencyPenalty = frequencyPenalty;
            InternalShouldStreamResponse = internalShouldStreamResponse;
            DeploymentName = deploymentName;
            InternalAzureExtensionsDataSources = internalAzureExtensionsDataSources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The collection of context messages associated with this chat completions request.
        /// Typical usage begins with a chat message for the System role that provides instructions for
        /// the behavior of the assistant, followed by alternating messages between the User and
        /// Assistant roles.
        /// </summary>
        public IList<ChatMessage> Messages { get; }
    }
}
