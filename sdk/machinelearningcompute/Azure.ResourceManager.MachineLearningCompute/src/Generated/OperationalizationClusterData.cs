// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningCompute
{
    /// <summary>
    /// A class representing the OperationalizationCluster data model.
    /// Instance of an Azure ML Operationalization Cluster resource.
    /// </summary>
    public partial class OperationalizationClusterData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalizationClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        public OperationalizationClusterData(AzureLocation location) : base(location)
        {
            ProvisioningErrors = new ChangeTrackingList<ErrorResponseWrapper>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationalizationClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of the cluster. </param>
        /// <param name="createdOn"> The date and time when the cluster was created. </param>
        /// <param name="modifiedOn"> The date and time when the cluster was last modified. </param>
        /// <param name="provisioningState"> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </param>
        /// <param name="provisioningErrors"> List of provisioning errors reported by the resource provider. </param>
        /// <param name="clusterType"> The cluster type. </param>
        /// <param name="storageAccount"> Storage Account properties. </param>
        /// <param name="containerRegistry"> Container Registry properties. </param>
        /// <param name="containerService"> Parameters for the Azure Container Service cluster. </param>
        /// <param name="appInsights"> AppInsights configuration. </param>
        /// <param name="globalServiceConfiguration"> Contains global configuration for the web services in the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalizationClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string description, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, OperationStatus? provisioningState, IReadOnlyList<ErrorResponseWrapper> provisioningErrors, ClusterType? clusterType, StorageAccountProperties storageAccount, ContainerRegistryProperties containerRegistry, AcsClusterProperties containerService, AppInsightsProperties appInsights, GlobalServiceConfiguration globalServiceConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Description = description;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            ProvisioningState = provisioningState;
            ProvisioningErrors = provisioningErrors;
            ClusterType = clusterType;
            StorageAccount = storageAccount;
            ContainerRegistry = containerRegistry;
            ContainerService = containerService;
            AppInsights = appInsights;
            GlobalServiceConfiguration = globalServiceConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationalizationClusterData"/> for deserialization. </summary>
        internal OperationalizationClusterData()
        {
        }

        /// <summary> The description of the cluster. </summary>
        public string Description { get; set; }
        /// <summary> The date and time when the cluster was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The date and time when the cluster was last modified. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </summary>
        public OperationStatus? ProvisioningState { get; }
        /// <summary> List of provisioning errors reported by the resource provider. </summary>
        public IReadOnlyList<ErrorResponseWrapper> ProvisioningErrors { get; }
        /// <summary> The cluster type. </summary>
        public ClusterType? ClusterType { get; set; }
        /// <summary> Storage Account properties. </summary>
        internal StorageAccountProperties StorageAccount { get; set; }
        /// <summary> ARM resource ID of the Azure Storage Account to store CLI specific files. If not provided one will be created. This cannot be changed once the cluster is created. </summary>
        public string StorageAccountResourceId
        {
            get => StorageAccount is null ? default : StorageAccount.ResourceId;
            set
            {
                if (StorageAccount is null)
                    StorageAccount = new StorageAccountProperties();
                StorageAccount.ResourceId = value;
            }
        }

        /// <summary> Container Registry properties. </summary>
        internal ContainerRegistryProperties ContainerRegistry { get; set; }
        /// <summary> ARM resource ID of the Azure Container Registry used to store Docker images for web services in the cluster. If not provided one will be created. This cannot be changed once the cluster is created. </summary>
        public string ContainerRegistryResourceId
        {
            get => ContainerRegistry is null ? default : ContainerRegistry.ResourceId;
            set
            {
                if (ContainerRegistry is null)
                    ContainerRegistry = new ContainerRegistryProperties();
                ContainerRegistry.ResourceId = value;
            }
        }

        /// <summary> Parameters for the Azure Container Service cluster. </summary>
        public AcsClusterProperties ContainerService { get; set; }
        /// <summary> AppInsights configuration. </summary>
        internal AppInsightsProperties AppInsights { get; set; }
        /// <summary> ARM resource ID of the App Insights. </summary>
        public string AppInsightsResourceId
        {
            get => AppInsights is null ? default : AppInsights.ResourceId;
            set
            {
                if (AppInsights is null)
                    AppInsights = new AppInsightsProperties();
                AppInsights.ResourceId = value;
            }
        }

        /// <summary> Contains global configuration for the web services in the cluster. </summary>
        public GlobalServiceConfiguration GlobalServiceConfiguration { get; set; }
    }
}
