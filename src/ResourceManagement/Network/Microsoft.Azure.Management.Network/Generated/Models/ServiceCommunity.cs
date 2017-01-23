// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A service community object.
    /// </summary>
    [JsonTransformation]
    public partial class ServiceCommunity : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceCommunity class.
        /// </summary>
        public ServiceCommunity() { }

        /// <summary>
        /// Initializes a new instance of the ServiceCommunity class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="state">For using certain microsoft service, customer
        /// needs to go through WARM room to get special permission. If the
        /// customer subscription is not allowed to use given service, the
        /// state will be disabled, otherwise it will be enabled. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="communities">Get a list of bgp communities.</param>
        public ServiceCommunity(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string state = default(string), IList<BGPCommunity> communities = default(IList<BGPCommunity>))
            : base(id, name, type, location, tags)
        {
            State = state;
            Communities = communities;
        }

        /// <summary>
        /// Gets for using certain microsoft service, customer needs to go
        /// through WARM room to get special permission. If the customer
        /// subscription is not allowed to use given service, the state will be
        /// disabled, otherwise it will be enabled. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; protected set; }

        /// <summary>
        /// Gets or sets get a list of bgp communities.
        /// </summary>
        [JsonProperty(PropertyName = "properties.communities")]
        public IList<BGPCommunity> Communities { get; set; }

    }
}

