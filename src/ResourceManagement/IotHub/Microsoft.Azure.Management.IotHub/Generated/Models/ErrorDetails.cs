// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Error details.
    /// </summary>
    public partial class ErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        public ErrorDetails() { }

        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        public ErrorDetails(string code = default(string), string httpStatusCode = default(string), string message = default(string), string details = default(string))
        {
            Code = code;
            HttpStatusCode = httpStatusCode;
            Message = message;
            Details = details;
        }

        /// <summary>
        /// The error code.
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; private set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "HttpStatusCode")]
        public string HttpStatusCode { get; private set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; private set; }

        /// <summary>
        /// The error details.
        /// </summary>
        [JsonProperty(PropertyName = "Details")]
        public string Details { get; private set; }

    }
}
