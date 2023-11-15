// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Contains details when the response code indicates an error. </summary>
    internal partial class ErrorContract
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ErrorContract"/>. </summary>
        internal ErrorContract()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorContract"/>. </summary>
        /// <param name="error"> The error details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorContract(ErrorResponse error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error details. </summary>
        public ErrorResponse Error { get; }
    }
}
