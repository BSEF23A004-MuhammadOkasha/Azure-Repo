// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing the MachineLearningWorkspace data model.
    /// An object that represents a machine learning workspace.
    /// </summary>
    public partial class MachineLearningWorkspaceData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MachineLearningWorkspaceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<MachineLearningPrivateEndpointConnectionData>();
            SharedPrivateLinkResources = new ChangeTrackingList<MachineLearningSharedPrivateLinkResource>();
            AssociatedWorkspaces = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="kind"></param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="workspaceId"> The immutable id associated with this workspace. </param>
        /// <param name="description"> The description of this workspace. </param>
        /// <param name="friendlyName"> The friendly name for this workspace. This name in mutable. </param>
        /// <param name="keyVault"> ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created. </param>
        /// <param name="applicationInsights"> ARM id of the application insights associated with this workspace. </param>
        /// <param name="containerRegistry"> ARM id of the container registry associated with this workspace. </param>
        /// <param name="storageAccount"> ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created. </param>
        /// <param name="discoveryUri"> Url for the discovery service to identify regional endpoints for machine learning experimentation services. </param>
        /// <param name="provisioningState"> The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning. </param>
        /// <param name="encryption"> The encryption settings of Azure ML workspace. </param>
        /// <param name="isHbiWorkspace"> The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service. </param>
        /// <param name="serviceProvisionedResourceGroup"> The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace. </param>
        /// <param name="privateLinkCount"> Count of private connections in the workspace. </param>
        /// <param name="imageBuildCompute"> The compute name for image build. </param>
        /// <param name="allowPublicAccessWhenBehindVnet"> The flag to indicate whether to allow public access when behind VNet. </param>
        /// <param name="publicNetworkAccessType"> Whether requests from Public Network are allowed. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections in the workspace. </param>
        /// <param name="serverlessComputeSettings"> Settings for serverless compute created in the workspace. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources in this workspace. </param>
        /// <param name="notebookInfo"> The notebook info of Azure ML workspace. </param>
        /// <param name="serviceManagedResourcesSettings"> The service managed resource settings. </param>
        /// <param name="primaryUserAssignedIdentity"> The user assigned identity resource id that represents the workspace identity. </param>
        /// <param name="tenantId"> The tenant id associated with this workspace. </param>
        /// <param name="isStorageHnsEnabled"> If the storage associated with the workspace has hierarchical namespace(HNS) enabled. </param>
        /// <param name="mlFlowTrackingUri"> The URI associated with this workspace that machine learning flow must point at to set up tracking. </param>
        /// <param name="isV1LegacyMode"> Enabling v1_legacy_mode may prevent you from using features provided by the v2 API. </param>
        /// <param name="managedNetwork"> Managed Network settings for a machine learning workspace. </param>
        /// <param name="featureStoreSettings"> Settings for feature store type workspace. </param>
        /// <param name="associatedWorkspaces"></param>
        /// <param name="enableDataIsolation"></param>
        /// <param name="hubResourceId"></param>
        /// <param name="workspaceHubConfig"> WorkspaceHub's configuration object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string kind, MachineLearningSku sku, string workspaceId, string description, string friendlyName, string keyVault, string applicationInsights, string containerRegistry, string storageAccount, Uri discoveryUri, MachineLearningProvisioningState? provisioningState, MachineLearningEncryptionSetting encryption, bool? isHbiWorkspace, string serviceProvisionedResourceGroup, int? privateLinkCount, string imageBuildCompute, bool? allowPublicAccessWhenBehindVnet, PublicNetworkAccess? publicNetworkAccessType, IReadOnlyList<MachineLearningPrivateEndpointConnectionData> privateEndpointConnections, ServerlessComputeSettings serverlessComputeSettings, IList<MachineLearningSharedPrivateLinkResource> sharedPrivateLinkResources, MachineLearningNotebookResourceInfo notebookInfo, ServiceManagedResourcesSettings serviceManagedResourcesSettings, string primaryUserAssignedIdentity, Guid? tenantId, bool? isStorageHnsEnabled, Uri mlFlowTrackingUri, bool? isV1LegacyMode, ManagedNetworkSettings managedNetwork, FeatureStoreSettings featureStoreSettings, IList<string> associatedWorkspaces, bool? enableDataIsolation, ResourceIdentifier hubResourceId, WorkspaceHubConfig workspaceHubConfig, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Kind = kind;
            Sku = sku;
            WorkspaceId = workspaceId;
            Description = description;
            FriendlyName = friendlyName;
            KeyVault = keyVault;
            ApplicationInsights = applicationInsights;
            ContainerRegistry = containerRegistry;
            StorageAccount = storageAccount;
            DiscoveryUri = discoveryUri;
            ProvisioningState = provisioningState;
            Encryption = encryption;
            IsHbiWorkspace = isHbiWorkspace;
            ServiceProvisionedResourceGroup = serviceProvisionedResourceGroup;
            PrivateLinkCount = privateLinkCount;
            ImageBuildCompute = imageBuildCompute;
            AllowPublicAccessWhenBehindVnet = allowPublicAccessWhenBehindVnet;
            PublicNetworkAccessType = publicNetworkAccessType;
            PrivateEndpointConnections = privateEndpointConnections;
            ServerlessComputeSettings = serverlessComputeSettings;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            NotebookInfo = notebookInfo;
            ServiceManagedResourcesSettings = serviceManagedResourcesSettings;
            PrimaryUserAssignedIdentity = primaryUserAssignedIdentity;
            TenantId = tenantId;
            IsStorageHnsEnabled = isStorageHnsEnabled;
            MlFlowTrackingUri = mlFlowTrackingUri;
            IsV1LegacyMode = isV1LegacyMode;
            ManagedNetwork = managedNetwork;
            FeatureStoreSettings = featureStoreSettings;
            AssociatedWorkspaces = associatedWorkspaces;
            EnableDataIsolation = enableDataIsolation;
            HubResourceId = hubResourceId;
            WorkspaceHubConfig = workspaceHubConfig;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceData"/> for deserialization. </summary>
        internal MachineLearningWorkspaceData()
        {
        }

        /// <summary> The identity of the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets or sets the kind. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
        /// <summary> The sku of the workspace. </summary>
        [WirePath("sku")]
        public MachineLearningSku Sku { get; set; }
        /// <summary> The immutable id associated with this workspace. </summary>
        [WirePath("properties.workspaceId")]
        public string WorkspaceId { get; }
        /// <summary> The description of this workspace. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> The friendly name for this workspace. This name in mutable. </summary>
        [WirePath("properties.friendlyName")]
        public string FriendlyName { get; set; }
        /// <summary> ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created. </summary>
        [WirePath("properties.keyVault")]
        public string KeyVault { get; set; }
        /// <summary> ARM id of the application insights associated with this workspace. </summary>
        [WirePath("properties.applicationInsights")]
        public string ApplicationInsights { get; set; }
        /// <summary> ARM id of the container registry associated with this workspace. </summary>
        [WirePath("properties.containerRegistry")]
        public string ContainerRegistry { get; set; }
        /// <summary> ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created. </summary>
        [WirePath("properties.storageAccount")]
        public string StorageAccount { get; set; }
        /// <summary> Url for the discovery service to identify regional endpoints for machine learning experimentation services. </summary>
        [WirePath("properties.discoveryUrl")]
        public Uri DiscoveryUri { get; set; }
        /// <summary> The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning. </summary>
        [WirePath("properties.provisioningState")]
        public MachineLearningProvisioningState? ProvisioningState { get; }
        /// <summary> The encryption settings of Azure ML workspace. </summary>
        [WirePath("properties.encryption")]
        public MachineLearningEncryptionSetting Encryption { get; set; }
        /// <summary> The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service. </summary>
        [WirePath("properties.hbiWorkspace")]
        public bool? IsHbiWorkspace { get; set; }
        /// <summary> The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace. </summary>
        [WirePath("properties.serviceProvisionedResourceGroup")]
        public string ServiceProvisionedResourceGroup { get; }
        /// <summary> Count of private connections in the workspace. </summary>
        [WirePath("properties.privateLinkCount")]
        public int? PrivateLinkCount { get; }
        /// <summary> The compute name for image build. </summary>
        [WirePath("properties.imageBuildCompute")]
        public string ImageBuildCompute { get; set; }
        /// <summary> The flag to indicate whether to allow public access when behind VNet. </summary>
        [WirePath("properties.allowPublicAccessWhenBehindVnet")]
        public bool? AllowPublicAccessWhenBehindVnet { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        [WirePath("properties.publicNetworkAccess")]
        public PublicNetworkAccess? PublicNetworkAccessType { get; set; }
        /// <summary> The list of private endpoint connections in the workspace. </summary>
        [WirePath("properties.privateEndpointConnections")]
        public IReadOnlyList<MachineLearningPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Settings for serverless compute created in the workspace. </summary>
        [WirePath("properties.serverlessComputeSettings")]
        public ServerlessComputeSettings ServerlessComputeSettings { get; set; }
        /// <summary> The list of shared private link resources in this workspace. </summary>
        [WirePath("properties.sharedPrivateLinkResources")]
        public IList<MachineLearningSharedPrivateLinkResource> SharedPrivateLinkResources { get; }
        /// <summary> The notebook info of Azure ML workspace. </summary>
        [WirePath("properties.notebookInfo")]
        public MachineLearningNotebookResourceInfo NotebookInfo { get; }
        /// <summary> The service managed resource settings. </summary>
        internal ServiceManagedResourcesSettings ServiceManagedResourcesSettings { get; set; }
        /// <summary> The throughput of the collections in cosmosdb database. </summary>
        [WirePath("properties.serviceManagedResourcesSettings.cosmosDb.collectionsThroughput")]
        public int? CosmosDbCollectionsThroughput
        {
            get => ServiceManagedResourcesSettings is null ? default : ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput;
            set
            {
                if (ServiceManagedResourcesSettings is null)
                    ServiceManagedResourcesSettings = new ServiceManagedResourcesSettings();
                ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput = value;
            }
        }

        /// <summary> The user assigned identity resource id that represents the workspace identity. </summary>
        [WirePath("properties.primaryUserAssignedIdentity")]
        public string PrimaryUserAssignedIdentity { get; set; }
        /// <summary> The tenant id associated with this workspace. </summary>
        [WirePath("properties.tenantId")]
        public Guid? TenantId { get; }
        /// <summary> If the storage associated with the workspace has hierarchical namespace(HNS) enabled. </summary>
        [WirePath("properties.storageHnsEnabled")]
        public bool? IsStorageHnsEnabled { get; }
        /// <summary> The URI associated with this workspace that machine learning flow must point at to set up tracking. </summary>
        [WirePath("properties.mlFlowTrackingUri")]
        public Uri MlFlowTrackingUri { get; }
        /// <summary> Enabling v1_legacy_mode may prevent you from using features provided by the v2 API. </summary>
        [WirePath("properties.v1LegacyMode")]
        public bool? IsV1LegacyMode { get; set; }
        /// <summary> Managed Network settings for a machine learning workspace. </summary>
        [WirePath("properties.managedNetwork")]
        public ManagedNetworkSettings ManagedNetwork { get; set; }
        /// <summary> Settings for feature store type workspace. </summary>
        [WirePath("properties.featureStoreSettings")]
        public FeatureStoreSettings FeatureStoreSettings { get; set; }
        /// <summary> Gets the associated workspaces. </summary>
        [WirePath("properties.associatedWorkspaces")]
        public IList<string> AssociatedWorkspaces { get; }
        /// <summary> Gets or sets the enable data isolation. </summary>
        [WirePath("properties.enableDataIsolation")]
        public bool? EnableDataIsolation { get; set; }
        /// <summary> Gets or sets the hub resource id. </summary>
        [WirePath("properties.hubResourceId")]
        public ResourceIdentifier HubResourceId { get; set; }
        /// <summary> WorkspaceHub's configuration object. </summary>
        [WirePath("properties.workspaceHubConfig")]
        public WorkspaceHubConfig WorkspaceHubConfig { get; set; }
    }
}
