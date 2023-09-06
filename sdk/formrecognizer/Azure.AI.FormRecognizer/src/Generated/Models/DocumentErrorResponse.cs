// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Error response object. </summary>
    internal partial class DocumentErrorResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DocumentErrorResponse"/>. </summary>
        /// <param name="error"> Error info. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal DocumentErrorResponse(Error error)
        {
            Argument.AssertNotNull(error, nameof(error));

            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentErrorResponse"/>. </summary>
        /// <param name="error"> Error info. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentErrorResponse(Error error, Dictionary<string, BinaryData> rawData)
        {
            Error = error;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentErrorResponse"/> for deserialization. </summary>
        internal DocumentErrorResponse()
        {
        }

        /// <summary> Error info. </summary>
        public Error Error { get; }
    }
}
