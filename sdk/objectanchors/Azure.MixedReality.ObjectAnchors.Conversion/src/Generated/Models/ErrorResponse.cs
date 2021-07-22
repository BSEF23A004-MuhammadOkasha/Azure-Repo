// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.MixedReality.ObjectAnchors.Conversion.Models
{
    /// <summary> The ErrorResponse. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"></param>
        internal ErrorResponse(Error error)
        {
            Error = error;
        }

        public Error Error { get; }
    }
}
