// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ErrorCode. </summary>
    internal partial class ErrorCode
    {
        /// <summary> Initializes a new instance of ErrorCode. </summary>
        internal ErrorCode()
        {
        }

        /// <summary> Initializes a new instance of ErrorCode. </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        internal ErrorCode(string message, string code)
        {
            Message = message;
            Code = code;
        }

        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
    }
}
