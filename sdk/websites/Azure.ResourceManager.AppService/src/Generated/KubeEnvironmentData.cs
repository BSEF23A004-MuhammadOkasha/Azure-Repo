// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the KubeEnvironment data model.
    /// A Kubernetes cluster specialized for web workloads by Azure App Service
    /// </summary>
    public partial class KubeEnvironmentData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KubeEnvironmentData"/>. </summary>
        /// <param name="location"> The location. </param>
        public KubeEnvironmentData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubeEnvironmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Extended Location. </param>
        /// <param name="provisioningState"> Provisioning state of the Kubernetes Environment. </param>
        /// <param name="deploymentErrors"> Any errors that occurred during deployment or deployment validation. </param>
        /// <param name="isInternalLoadBalancerEnabled"> Only visible within Vnet/Subnet. </param>
        /// <param name="defaultDomain"> Default Domain Name for the cluster. </param>
        /// <param name="staticIP"> Static IP of the KubeEnvironment. </param>
        /// <param name="arcConfiguration">
        /// Cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// </param>
        /// <param name="appLogsConfiguration">
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only "log-analytics" is
        /// supported
        /// </param>
        /// <param name="aksResourceId"></param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubeEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, KubeEnvironmentProvisioningState? provisioningState, string deploymentErrors, bool? isInternalLoadBalancerEnabled, string defaultDomain, string staticIP, ArcConfiguration arcConfiguration, AppLogsConfiguration appLogsConfiguration, ResourceIdentifier aksResourceId, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            ProvisioningState = provisioningState;
            DeploymentErrors = deploymentErrors;
            IsInternalLoadBalancerEnabled = isInternalLoadBalancerEnabled;
            DefaultDomain = defaultDomain;
            StaticIP = staticIP;
            ArcConfiguration = arcConfiguration;
            AppLogsConfiguration = appLogsConfiguration;
            AksResourceId = aksResourceId;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KubeEnvironmentData"/> for deserialization. </summary>
        internal KubeEnvironmentData()
        {
        }

        /// <summary> Extended Location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Provisioning state of the Kubernetes Environment. </summary>
        public KubeEnvironmentProvisioningState? ProvisioningState { get; }
        /// <summary> Any errors that occurred during deployment or deployment validation. </summary>
        public string DeploymentErrors { get; }
        /// <summary> Only visible within Vnet/Subnet. </summary>
        public bool? IsInternalLoadBalancerEnabled { get; set; }
        /// <summary> Default Domain Name for the cluster. </summary>
        public string DefaultDomain { get; }
        /// <summary> Static IP of the KubeEnvironment. </summary>
        public string StaticIP { get; set; }
        /// <summary>
        /// Cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// </summary>
        public ArcConfiguration ArcConfiguration { get; set; }
        /// <summary>
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only "log-analytics" is
        /// supported
        /// </summary>
        public AppLogsConfiguration AppLogsConfiguration { get; set; }
        /// <summary> Gets or sets the aks resource id. </summary>
        public ResourceIdentifier AksResourceId { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
