// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The details of the error.
    /// </summary>
    public partial class ErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        public ErrorDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        /// <param name="code">One of a server-defined set of error
        /// codes.</param>
        /// <param name="message">A human-readable representation of the
        /// error.</param>
        /// <param name="target">(Optional) The target of the error.</param>
        public ErrorDetails(string code = default(string), string message = default(string), string target = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets one of a server-defined set of error codes.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a human-readable representation of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets (Optional) The target of the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

    }
}
