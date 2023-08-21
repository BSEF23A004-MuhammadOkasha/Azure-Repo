// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Properties of the Spring Cloud Gateway Operator. </summary>
    public partial class AppPlatformGatewayOperatorProperties
    {
        /// <summary> Initializes a new instance of AppPlatformGatewayOperatorProperties. </summary>
        internal AppPlatformGatewayOperatorProperties()
        {
            Instances = new ChangeTrackingList<AppPlatformGatewayInstance>();
        }

        /// <summary> Initializes a new instance of AppPlatformGatewayOperatorProperties. </summary>
        /// <param name="resourceRequests"> The requested resource quantity for required CPU and Memory. </param>
        /// <param name="instances"> Collection of instances belong to Spring Cloud Gateway operator. </param>
        internal AppPlatformGatewayOperatorProperties(AppPlatformGatewayOperatorResourceRequirements resourceRequests, IReadOnlyList<AppPlatformGatewayInstance> instances)
        {
            ResourceRequests = resourceRequests;
            Instances = instances;
        }

        /// <summary> The requested resource quantity for required CPU and Memory. </summary>
        public AppPlatformGatewayOperatorResourceRequirements ResourceRequests { get; }
        /// <summary> Collection of instances belong to Spring Cloud Gateway operator. </summary>
        public IReadOnlyList<AppPlatformGatewayInstance> Instances { get; }
    }
}
