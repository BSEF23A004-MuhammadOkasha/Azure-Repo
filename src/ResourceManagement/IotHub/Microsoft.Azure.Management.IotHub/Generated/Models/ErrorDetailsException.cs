// MIT

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Rest;
    using System;
    using System.Net.Http;
    using System.Runtime.Serialization;
#if !PORTABLE && !DNXCORE50
    using System.Security.Permissions;
#endif

    /// <summary>
    /// Exception thrown for an invalid response with ErrorDetails information.
    /// </summary>
#if !PORTABLE && !DNXCORE50
    [Serializable]
#endif
    public class ErrorDetailsException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ErrorDetails Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsException class.
        /// </summary>
        public ErrorDetailsException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorDetailsException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ErrorDetailsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if !PORTABLE && !DNXCORE50
        /// <summary>
        /// Initializes a new instance of the ErrorDetailsException class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected ErrorDetailsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Serializes content of the exception.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            info.AddValue("Request", Request);
            info.AddValue("Response", Response);
            info.AddValue("Body", Body);
        }
#endif
    }
}
