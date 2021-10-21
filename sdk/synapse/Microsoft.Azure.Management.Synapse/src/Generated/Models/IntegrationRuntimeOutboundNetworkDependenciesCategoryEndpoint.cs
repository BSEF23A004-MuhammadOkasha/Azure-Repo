// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure-SSIS integration runtime outbound network dependency endpoints
    /// for one category.
    /// </summary>
    public partial class IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint
        /// class.
        /// </summary>
        public IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint
        /// class.
        /// </summary>
        /// <param name="category">The category of outbound network
        /// dependency.</param>
        /// <param name="endpoints">The endpoints for outbound network
        /// dependency.</param>
        public IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(string category = default(string), IList<IntegrationRuntimeOutboundNetworkDependenciesEndpoint> endpoints = default(IList<IntegrationRuntimeOutboundNetworkDependenciesEndpoint>))
        {
            Category = category;
            Endpoints = endpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the category of outbound network dependency.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the endpoints for outbound network dependency.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<IntegrationRuntimeOutboundNetworkDependenciesEndpoint> Endpoints { get; set; }

    }
}
