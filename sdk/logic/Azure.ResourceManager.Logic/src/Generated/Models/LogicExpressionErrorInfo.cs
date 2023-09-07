// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The azure resource error info. </summary>
    public partial class LogicExpressionErrorInfo : LogicErrorInfo
    {
        /// <summary> Initializes a new instance of <see cref="LogicExpressionErrorInfo"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal LogicExpressionErrorInfo(string code, string message) : base(code)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Message = message;
            Details = new ChangeTrackingList<LogicExpressionErrorInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicExpressionErrorInfo"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> The error details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicExpressionErrorInfo(string code, string message, IReadOnlyList<LogicExpressionErrorInfo> details, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(code, serializedAdditionalRawData)
        {
            Message = message;
            Details = details;
        }

        /// <summary> Initializes a new instance of <see cref="LogicExpressionErrorInfo"/> for deserialization. </summary>
        internal LogicExpressionErrorInfo()
        {
        }

        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error details. </summary>
        public IReadOnlyList<LogicExpressionErrorInfo> Details { get; }
    }
}
