// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A ExpressRouteResourceProvider object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteServiceProvider : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteServiceProvider
        /// class.
        /// </summary>
        public ExpressRouteServiceProvider()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteServiceProvider
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="peeringLocations">Get a list of peering
        /// locations.</param>
        /// <param name="bandwidthsOffered">Gets bandwidths offered.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// resource.</param>
        public ExpressRouteServiceProvider(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> peeringLocations = default(IList<string>), IList<ExpressRouteServiceProviderBandwidthsOffered> bandwidthsOffered = default(IList<ExpressRouteServiceProviderBandwidthsOffered>), string provisioningState = default(string))
            : base(id, name, type, location, tags)
        {
            PeeringLocations = peeringLocations;
            BandwidthsOffered = bandwidthsOffered;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets get a list of peering locations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringLocations")]
        public IList<string> PeeringLocations { get; set; }

        /// <summary>
        /// Gets bandwidths offered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bandwidthsOffered")]
        public IList<ExpressRouteServiceProviderBandwidthsOffered> BandwidthsOffered { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
