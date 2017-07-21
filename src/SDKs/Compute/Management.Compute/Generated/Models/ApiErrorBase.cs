// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Api error base.
    /// </summary>
    public partial class ApiErrorBase
    {
        /// <summary>
        /// Initializes a new instance of the ApiErrorBase class.
        /// </summary>
        public ApiErrorBase()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiErrorBase class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="target">The target of the particular error.</param>
        /// <param name="message">The error message.</param>
        public ApiErrorBase(string code = default(string), string target = default(string), string message = default(string))
        {
            Code = code;
            Target = target;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the target of the particular error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
