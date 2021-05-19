// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Iot.DeviceUpdate.Models
{
    /// <summary> An object containing more specific information than the current object about the error. </summary>
    public partial class InnerError
    {
        /// <summary> Initializes a new instance of InnerError. </summary>
        /// <param name="code"> A more specific error code than what was provided by the containing error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> is null. </exception>
        internal InnerError(string code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            Code = code;
        }

        /// <summary> Initializes a new instance of InnerError. </summary>
        /// <param name="code"> A more specific error code than what was provided by the containing error. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="errorDetail"> The internal error or exception message. </param>
        /// <param name="innerErrorValue"> An object containing more specific information than the current object about the error. </param>
        internal InnerError(string code, string message, string errorDetail, InnerError innerErrorValue)
        {
            Code = code;
            Message = message;
            ErrorDetail = errorDetail;
            InnerErrorValue = innerErrorValue;
        }

        /// <summary> A more specific error code than what was provided by the containing error. </summary>
        public string Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> The internal error or exception message. </summary>
        public string ErrorDetail { get; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public InnerError InnerErrorValue { get; }
    }
}
