// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The name and arguments of a function that should be called, as generated by the model. </summary>
    public partial class FunctionCall
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of FunctionCall. </summary>
        /// <param name="name"> The name of the function to call. </param>
        /// <param name="arguments">
        /// The arguments to call the function with, as generated by the model in JSON format.
        /// Note that the model does not always generate valid JSON, and may hallucinate parameters
        /// not defined by your function schema. Validate the arguments in your code before calling
        /// your function.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionCall(string name, string arguments, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Arguments = arguments;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="FunctionCall"/> for deserialization. </summary>
        internal FunctionCall()
        {
        }

        /// <summary> The name of the function to call. </summary>
        public string Name { get; set; }
        /// <summary>
        /// The arguments to call the function with, as generated by the model in JSON format.
        /// Note that the model does not always generate valid JSON, and may hallucinate parameters
        /// not defined by your function schema. Validate the arguments in your code before calling
        /// your function.
        /// </summary>
        public string Arguments { get; set; }
    }
}
