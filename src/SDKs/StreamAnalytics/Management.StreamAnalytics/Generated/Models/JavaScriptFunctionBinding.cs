// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The binding to a JavaScript function.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.StreamAnalytics/JavascriptUdf")]
    [Rest.Serialization.JsonTransformation]
    public partial class JavaScriptFunctionBinding : FunctionBinding
    {
        /// <summary>
        /// Initializes a new instance of the JavaScriptFunctionBinding class.
        /// </summary>
        public JavaScriptFunctionBinding()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JavaScriptFunctionBinding class.
        /// </summary>
        /// <param name="script">The JavaScript code containing a single
        /// function definition. For example: 'function (x, y) { return x + y;
        /// }'</param>
        public JavaScriptFunctionBinding(string script = default(string))
        {
            Script = script;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the JavaScript code containing a single function
        /// definition. For example: 'function (x, y) { return x + y; }'
        /// </summary>
        [JsonProperty(PropertyName = "properties.script")]
        public string Script { get; set; }

    }
}
