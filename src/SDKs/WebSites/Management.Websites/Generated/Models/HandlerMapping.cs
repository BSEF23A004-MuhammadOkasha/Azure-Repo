// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The IIS handler mappings used to define which handler processes HTTP
    /// requests with certain extension.
    /// For example, it is used to configure php-cgi.exe process to handle all
    /// HTTP requests with *.php extension.
    /// </summary>
    public partial class HandlerMapping
    {
        /// <summary>
        /// Initializes a new instance of the HandlerMapping class.
        /// </summary>
        public HandlerMapping()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HandlerMapping class.
        /// </summary>
        /// <param name="extension">Requests with this extension will be
        /// handled using the specified FastCGI application.</param>
        /// <param name="scriptProcessor">The absolute path to the FastCGI
        /// application.</param>
        /// <param name="arguments">Command-line arguments to be passed to the
        /// script processor.</param>
        public HandlerMapping(string extension = default(string), string scriptProcessor = default(string), string arguments = default(string))
        {
            Extension = extension;
            ScriptProcessor = scriptProcessor;
            Arguments = arguments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets requests with this extension will be handled using the
        /// specified FastCGI application.
        /// </summary>
        [JsonProperty(PropertyName = "extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the absolute path to the FastCGI application.
        /// </summary>
        [JsonProperty(PropertyName = "scriptProcessor")]
        public string ScriptProcessor { get; set; }

        /// <summary>
        /// Gets or sets command-line arguments to be passed to the script
        /// processor.
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public string Arguments { get; set; }

    }
}
