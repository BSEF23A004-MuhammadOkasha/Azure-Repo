// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The TextAnalyticsWarning. </summary>
    internal partial class TextAnalyticsWarning
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TextAnalyticsWarning"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Warning message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal TextAnalyticsWarning(WarningCodeValue code, string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="TextAnalyticsWarning"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Warning message. </param>
        /// <param name="targetRef"> A JSON pointer reference indicating the target object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAnalyticsWarning(WarningCodeValue code, string message, string targetRef, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            TargetRef = targetRef;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAnalyticsWarning"/> for deserialization. </summary>
        internal TextAnalyticsWarning()
        {
        }

        /// <summary> Error code. </summary>
        public WarningCodeValue Code { get; }
        /// <summary> Warning message. </summary>
        public string Message { get; }
        /// <summary> A JSON pointer reference indicating the target object. </summary>
        public string TargetRef { get; }
    }
}
