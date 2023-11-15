// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> LoadBalancerProfile - Profile of the cluster load balancer. </summary>
    public partial class LoadBalancerProfile : NamedAgentPoolProfile
    {
        /// <summary> Initializes a new instance of <see cref="LoadBalancerProfile"/>. </summary>
        public LoadBalancerProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerProfile"/>. </summary>
        /// <param name="count"> Count - Number of agents to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1. </param>
        /// <param name="availabilityZones"> AvailabilityZones - The list of Availability zones to use for nodes. Datacenter racks modelled as zones. </param>
        /// <param name="maxCount"> The maximum number of nodes for auto-scaling. </param>
        /// <param name="maxPods"> The maximum number of pods that can run on a node. </param>
        /// <param name="minCount"> The minimum number of nodes for auto-scaling. </param>
        /// <param name="mode"> Mode - AgentPoolMode represents mode of an agent pool. Possible values include: 'System', 'LB', 'User'. Default is 'User'. </param>
        /// <param name="nodeLabels"> NodeLabels - Agent pool node labels to be persisted across all nodes in agent pool. </param>
        /// <param name="nodeTaints"> NodeTaints - Taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule. </param>
        /// <param name="osType"> OsType - OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux. Possible values include: 'Linux', 'Windows'. </param>
        /// <param name="nodeImageVersion"> The version of node image. </param>
        /// <param name="vmSize"> VmSize - The size of the agent pool VMs. </param>
        /// <param name="cloudProviderProfile"> The underlying cloud infra provider properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Unique name of the agent pool profile in the context of the subscription and resource group. </param>
        /// <param name="linuxProfile"> Profile for Linux VMs in the container service cluster. </param>
        internal LoadBalancerProfile(int? count, IList<string> availabilityZones, int? maxCount, int? maxPods, int? minCount, Mode? mode, IDictionary<string, string> nodeLabels, IList<string> nodeTaints, OSType? osType, string nodeImageVersion, string vmSize, CloudProviderProfile cloudProviderProfile, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, LinuxProfileProperties linuxProfile) : base(count, availabilityZones, maxCount, maxPods, minCount, mode, nodeLabels, nodeTaints, osType, nodeImageVersion, vmSize, cloudProviderProfile, serializedAdditionalRawData, name)
        {
            LinuxProfile = linuxProfile;
        }

        /// <summary> Profile for Linux VMs in the container service cluster. </summary>
        public LinuxProfileProperties LinuxProfile { get; set; }
    }
}
