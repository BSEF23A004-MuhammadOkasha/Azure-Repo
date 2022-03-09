// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the Routes to create. </summary>
    internal partial class RouteProperties : RouteUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of RouteProperties. </summary>
        public RouteProperties()
        {
        }

        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
    }
}
