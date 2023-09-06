// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The definition of a caller-specified function that chat completions may invoke in response to matching user input. </summary>
    public partial class FunctionDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of FunctionDefinition. </summary>
        /// <param name="name"> The name of the function to be called. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public FunctionDefinition(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of FunctionDefinition. </summary>
        /// <param name="name"> The name of the function to be called. </param>
        /// <param name="description">
        /// A description of what the function does. The model will use this description when selecting the function and
        /// interpreting its parameters.
        /// </param>
        /// <param name="parameters"> The parameters the functions accepts, described as a JSON Schema object. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionDefinition(string name, string description, BinaryData parameters, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Description = description;
            Parameters = parameters;
            _rawData = rawData;
        }
        /// <summary>
        /// A description of what the function does. The model will use this description when selecting the function and
        /// interpreting its parameters.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Parameters { get; set; }
    }
}
