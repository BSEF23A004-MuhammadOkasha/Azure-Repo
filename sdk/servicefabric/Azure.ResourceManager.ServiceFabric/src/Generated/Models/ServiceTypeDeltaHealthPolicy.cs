// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Represents the delta health policy used to evaluate the health of services belonging to a service type when upgrading the cluster.
    /// 
    /// Serialized Name: ServiceTypeDeltaHealthPolicy
    /// </summary>
    public partial class ServiceTypeDeltaHealthPolicy
    {
        /// <summary> Initializes a new instance of ServiceTypeDeltaHealthPolicy. </summary>
        public ServiceTypeDeltaHealthPolicy()
        {
        }

        /// <summary> Initializes a new instance of ServiceTypeDeltaHealthPolicy. </summary>
        /// <param name="maxPercentDeltaUnhealthyServices">
        /// The maximum allowed percentage of services health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the services at the beginning of upgrade and the state of the services at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.
        /// 
        /// Serialized Name: ServiceTypeDeltaHealthPolicy.maxPercentDeltaUnhealthyServices
        /// </param>
        internal ServiceTypeDeltaHealthPolicy(int? maxPercentDeltaUnhealthyServices)
        {
            MaxPercentDeltaUnhealthyServices = maxPercentDeltaUnhealthyServices;
        }

        /// <summary>
        /// The maximum allowed percentage of services health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the services at the beginning of upgrade and the state of the services at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.
        /// 
        /// Serialized Name: ServiceTypeDeltaHealthPolicy.maxPercentDeltaUnhealthyServices
        /// </summary>
        public int? MaxPercentDeltaUnhealthyServices { get; set; }
    }
}
