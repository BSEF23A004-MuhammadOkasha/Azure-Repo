// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.DigitalTwins.Core
{
    /// <summary> Error definition. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Service specific error code which serves as the substatus for the HTTP error code. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="details"> Internal error details. </param>
        /// <param name="innererror"> An object containing more specific information than the current object about the error. </param>
        internal Error(string code, string message, IReadOnlyList<Error> details, InnerError innererror)
        {
            Code = code;
            Message = message;
            Details = details;
            Innererror = innererror;
        }

        /// <summary> Service specific error code which serves as the substatus for the HTTP error code. </summary>
        public string Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> Internal error details. </summary>
        public IReadOnlyList<Error> Details { get; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public InnerError Innererror { get; }
    }
}
