// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Represents the health policy used to evaluate the health of services belonging to a service type.
    /// 
    /// Serialized Name: ArmServiceTypeHealthPolicy
    /// </summary>
    public partial class ArmServiceTypeHealthPolicy
    {
        /// <summary> Initializes a new instance of ArmServiceTypeHealthPolicy. </summary>
        public ArmServiceTypeHealthPolicy()
        {
        }

        /// <summary> Initializes a new instance of ArmServiceTypeHealthPolicy. </summary>
        /// <param name="maxPercentUnhealthyServices">
        /// The maximum percentage of services allowed to be unhealthy before your application is considered in error.
        /// 
        /// Serialized Name: ArmServiceTypeHealthPolicy.maxPercentUnhealthyServices
        /// </param>
        /// <param name="maxPercentUnhealthyPartitionsPerService">
        /// The maximum percentage of partitions per service allowed to be unhealthy before your application is considered in error.
        /// 
        /// Serialized Name: ArmServiceTypeHealthPolicy.maxPercentUnhealthyPartitionsPerService
        /// </param>
        /// <param name="maxPercentUnhealthyReplicasPerPartition">
        /// The maximum percentage of replicas per partition allowed to be unhealthy before your application is considered in error.
        /// 
        /// Serialized Name: ArmServiceTypeHealthPolicy.maxPercentUnhealthyReplicasPerPartition
        /// </param>
        internal ArmServiceTypeHealthPolicy(int? maxPercentUnhealthyServices, int? maxPercentUnhealthyPartitionsPerService, int? maxPercentUnhealthyReplicasPerPartition)
        {
            MaxPercentUnhealthyServices = maxPercentUnhealthyServices;
            MaxPercentUnhealthyPartitionsPerService = maxPercentUnhealthyPartitionsPerService;
            MaxPercentUnhealthyReplicasPerPartition = maxPercentUnhealthyReplicasPerPartition;
        }

        /// <summary>
        /// The maximum percentage of services allowed to be unhealthy before your application is considered in error.
        /// 
        /// Serialized Name: ArmServiceTypeHealthPolicy.maxPercentUnhealthyServices
        /// </summary>
        public int? MaxPercentUnhealthyServices { get; set; }
        /// <summary>
        /// The maximum percentage of partitions per service allowed to be unhealthy before your application is considered in error.
        /// 
        /// Serialized Name: ArmServiceTypeHealthPolicy.maxPercentUnhealthyPartitionsPerService
        /// </summary>
        public int? MaxPercentUnhealthyPartitionsPerService { get; set; }
        /// <summary>
        /// The maximum percentage of replicas per partition allowed to be unhealthy before your application is considered in error.
        /// 
        /// Serialized Name: ArmServiceTypeHealthPolicy.maxPercentUnhealthyReplicasPerPartition
        /// </summary>
        public int? MaxPercentUnhealthyReplicasPerPartition { get; set; }
    }
}
