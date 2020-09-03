// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a private endpoint connection.
    /// </summary>
    public partial class PrivateEndpointConnectionProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionProperties class.
        /// </summary>
        public PrivateEndpointConnectionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionProperties class.
        /// </summary>
        /// <param name="privateEndpoint">Private endpoint which the connection
        /// belongs to.</param>
        /// <param name="privateLinkServiceConnectionState">Connection state of
        /// the private endpoint connection.</param>
        /// <param name="provisioningState">State of the private endpoint
        /// connection. Possible values include: 'Approving', 'Ready',
        /// 'Dropping', 'Failed', 'Rejecting'</param>
        public PrivateEndpointConnectionProperties(PrivateEndpointProperty privateEndpoint = default(PrivateEndpointProperty), PrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionStateProperty), PrivateEndpointProvisioningState? provisioningState = default(PrivateEndpointProvisioningState?))
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets private endpoint which the connection belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "privateEndpoint")]
        public PrivateEndpointProperty PrivateEndpoint { get; set; }

        /// <summary>
        /// Gets or sets connection state of the private endpoint connection.
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Gets state of the private endpoint connection. Possible values
        /// include: 'Approving', 'Ready', 'Dropping', 'Failed', 'Rejecting'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public PrivateEndpointProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PrivateLinkServiceConnectionState != null)
            {
                PrivateLinkServiceConnectionState.Validate();
            }
        }
    }
}
