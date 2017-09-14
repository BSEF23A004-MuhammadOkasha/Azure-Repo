// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Analysis;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The gateway details.
    /// </summary>
    public partial class GatewayDetails
    {
        /// <summary>
        /// Initializes a new instance of the GatewayDetails class.
        /// </summary>
        public GatewayDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayDetails class.
        /// </summary>
        /// <param name="gatewayResourceId">Gateway resource to be associated
        /// with the server.</param>
        /// <param name="gatewayObjectId">Gateway object id from in the DMTS
        /// cluster for the gateway resource.</param>
        /// <param name="dmtsClusterUri">Uri of the DMTS cluster.</param>
        public GatewayDetails(string gatewayResourceId = default(string), string gatewayObjectId = default(string), string dmtsClusterUri = default(string))
        {
            GatewayResourceId = gatewayResourceId;
            GatewayObjectId = gatewayObjectId;
            DmtsClusterUri = dmtsClusterUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets gateway resource to be associated with the server.
        /// </summary>
        [JsonProperty(PropertyName = "gatewayResourceId")]
        public string GatewayResourceId { get; set; }

        /// <summary>
        /// Gets gateway object id from in the DMTS cluster for the gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "gatewayObjectId")]
        public string GatewayObjectId { get; private set; }

        /// <summary>
        /// Gets uri of the DMTS cluster.
        /// </summary>
        [JsonProperty(PropertyName = "dmtsClusterUri")]
        public string DmtsClusterUri { get; private set; }

    }
}
