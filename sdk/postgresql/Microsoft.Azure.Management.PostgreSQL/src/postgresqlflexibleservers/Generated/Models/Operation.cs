// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// REST API operation definition.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">The name of the operation being performed on
        /// this particular object.</param>
        /// <param name="display">The localized display information for this
        /// particular operation or action.</param>
        /// <param name="origin">The intended executor of the operation.
        /// Possible values include: 'NotSpecified', 'user', 'system'</param>
        /// <param name="properties">Additional descriptions for the
        /// operation.</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay), string origin = default(string), IDictionary<string, object> properties = default(IDictionary<string, object>))
        {
            Name = name;
            Display = display;
            Origin = origin;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the operation being performed on this particular
        /// object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the localized display information for this particular
        /// operation or action.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; private set; }

        /// <summary>
        /// Gets the intended executor of the operation. Possible values
        /// include: 'NotSpecified', 'user', 'system'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; private set; }

        /// <summary>
        /// Gets additional descriptions for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, object> Properties { get; private set; }

    }
}
