// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> Exception details of the exception in a chain. </summary>
    internal partial class TelemetryExceptionDetails
    {
        /// <summary> Initializes a new instance of TelemetryExceptionDetails. </summary>
        /// <param name="message"> Exception message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public TelemetryExceptionDetails(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Message = message;
            ParsedStack = new ChangeTrackingList<StackFrame>();
        }

        /// <summary> In case exception is nested (outer exception contains inner one), the id and outerId properties are used to represent the nesting. </summary>
        public int? Id { get; set; }
        /// <summary> The value of outerId is a reference to an element in ExceptionDetails that represents the outer exception. </summary>
        public int? OuterId { get; set; }
        /// <summary> Exception type name. </summary>
        public string TypeName { get; set; }
        /// <summary> Exception message. </summary>
        public string Message { get; }
        /// <summary> Indicates if full exception stack is provided in the exception. The stack may be trimmed, such as in the case of a StackOverflow exception. </summary>
        public bool? HasFullStack { get; set; }
        /// <summary> Text describing the stack. Either stack or parsedStack should have a value. </summary>
        public string Stack { get; set; }
        /// <summary> List of stack frames. Either stack or parsedStack should have a value. </summary>
        public IList<StackFrame> ParsedStack { get; }
    }
}
