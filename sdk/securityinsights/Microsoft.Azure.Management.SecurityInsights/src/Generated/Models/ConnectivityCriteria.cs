// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Setting for the connector check connectivity
    /// </summary>
    public partial class ConnectivityCriteria
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityCriteria class.
        /// </summary>
        public ConnectivityCriteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityCriteria class.
        /// </summary>
        /// <param name="type">type of connectivity. Possible values include:
        /// 'IsConnectedQuery'</param>
        /// <param name="value">Queries for checking connectivity</param>
        public ConnectivityCriteria(string type = default(string), IList<string> value = default(IList<string>))
        {
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of connectivity. Possible values include:
        /// 'IsConnectedQuery'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets queries for checking connectivity
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }

    }
}
