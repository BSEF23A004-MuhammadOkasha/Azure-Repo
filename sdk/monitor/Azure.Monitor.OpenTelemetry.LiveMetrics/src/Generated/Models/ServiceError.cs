// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Optional http response body, whose existance carries additional error descriptions. </summary>
    internal partial class ServiceError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceError"/>. </summary>
        internal ServiceError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceError"/>. </summary>
        /// <param name="requestId"> A guid of the request that triggers the service error. </param>
        /// <param name="responseDateTime"> Service error response date time. </param>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="exception"> Message of the exception that triggers the error response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceError(string requestId, DateTimeOffset? responseDateTime, string code, string message, string exception, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RequestId = requestId;
            ResponseDateTime = responseDateTime;
            Code = code;
            Message = message;
            Exception = exception;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A guid of the request that triggers the service error. </summary>
        public string RequestId { get; }
        /// <summary> Service error response date time. </summary>
        public DateTimeOffset? ResponseDateTime { get; }
        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Message of the exception that triggers the error response. </summary>
        public string Exception { get; }
    }
}
