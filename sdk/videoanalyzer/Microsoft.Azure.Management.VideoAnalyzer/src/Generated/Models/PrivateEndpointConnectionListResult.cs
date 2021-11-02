// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of private endpoint connection associated with the specified
    /// storage account
    /// </summary>
    public partial class PrivateEndpointConnectionListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionListResult class.
        /// </summary>
        public PrivateEndpointConnectionListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionListResult class.
        /// </summary>
        /// <param name="value">Array of private endpoint connections</param>
        public PrivateEndpointConnectionListResult(IList<PrivateEndpointConnection> value = default(IList<PrivateEndpointConnection>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of private endpoint connections
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PrivateEndpointConnection> Value { get; set; }

    }
}
