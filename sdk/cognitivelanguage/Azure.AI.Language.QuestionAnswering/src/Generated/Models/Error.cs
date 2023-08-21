// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> The error object. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal Error(ErrorCode code, string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="target"> The target of the error. </param>
        /// <param name="details"> An array of details about specific errors that led to this reported error. </param>
        /// <param name="innererror"> An object containing more specific information than the current object about the error. </param>
        internal Error(ErrorCode code, string message, string target, IReadOnlyList<Error> details, InnerErrorModel innererror)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
        }

        /// <summary> One of a server-defined set of error codes. </summary>
        public ErrorCode Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> The target of the error. </summary>
        public string Target { get; }
        /// <summary> An array of details about specific errors that led to this reported error. </summary>
        public IReadOnlyList<Error> Details { get; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public InnerErrorModel Innererror { get; }
    }
}
