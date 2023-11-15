// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The key vault server error. </summary>
    internal partial class Error
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Error"/>. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Error"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="innerError"> The key vault server error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Error(string code, string message, Error innerError, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            InnerError = innerError;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The key vault server error. </summary>
        public Error InnerError { get; }
    }
}
