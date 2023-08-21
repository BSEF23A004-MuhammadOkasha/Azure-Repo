// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing the BatchAccount data model.
    /// Contains information about an Azure Batch account.
    /// </summary>
    public partial class BatchAccountData : ResourceData
    {
        /// <summary> Initializes a new instance of BatchAccountData. </summary>
        public BatchAccountData()
        {
            PrivateEndpointConnections = new ChangeTrackingList<BatchPrivateEndpointConnectionData>();
            DedicatedCoreQuotaPerVmFamily = new ChangeTrackingList<BatchVmFamilyCoreQuota>();
            AllowedAuthenticationModes = new ChangeTrackingList<BatchAuthenticationMode>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of BatchAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The identity of the Batch account. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="accountEndpoint"> The account endpoint used to interact with the Batch service. </param>
        /// <param name="nodeManagementEndpoint"> The endpoint used by compute node to connect to the Batch node management service. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="poolAllocationMode"> The allocation mode for creating pools in the Batch account. </param>
        /// <param name="keyVaultReference"> Identifies the Azure key vault associated with a Batch account. </param>
        /// <param name="publicNetworkAccess"> If not specified, the default value is 'enabled'. </param>
        /// <param name="networkProfile"> The network profile only takes effect when publicNetworkAccess is enabled. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the Batch account. </param>
        /// <param name="autoStorage"> Contains information about the auto-storage account associated with a Batch account. </param>
        /// <param name="encryption"> Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead. </param>
        /// <param name="dedicatedCoreQuota"> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="lowPriorityCoreQuota"> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="dedicatedCoreQuotaPerVmFamily"> A list of the dedicated core quota per Virtual Machine family for the Batch account. For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="isDedicatedCoreQuotaPerVmFamilyEnforced"> If this flag is true, dedicated core quota is enforced via both the dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the account. If this flag is false, dedicated core quota is enforced only via the dedicatedCoreQuota property on the account and does not consider Virtual Machine family. </param>
        /// <param name="poolQuota"> The pool quota for the Batch account. </param>
        /// <param name="activeJobAndJobScheduleQuota"> The active job and job schedule quota for the Batch account. </param>
        /// <param name="allowedAuthenticationModes"> List of allowed authentication modes for the Batch account that can be used to authenticate with the data plane. This does not affect authentication with the control plane. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="tags"> The tags of the resource. </param>
        internal BatchAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, string accountEndpoint, string nodeManagementEndpoint, BatchProvisioningState? provisioningState, BatchAccountPoolAllocationMode? poolAllocationMode, BatchKeyVaultReference keyVaultReference, BatchPublicNetworkAccess? publicNetworkAccess, BatchNetworkProfile networkProfile, IReadOnlyList<BatchPrivateEndpointConnectionData> privateEndpointConnections, BatchAccountAutoStorageConfiguration autoStorage, BatchAccountEncryptionConfiguration encryption, int? dedicatedCoreQuota, int? lowPriorityCoreQuota, IReadOnlyList<BatchVmFamilyCoreQuota> dedicatedCoreQuotaPerVmFamily, bool? isDedicatedCoreQuotaPerVmFamilyEnforced, int? poolQuota, int? activeJobAndJobScheduleQuota, IReadOnlyList<BatchAuthenticationMode> allowedAuthenticationModes, AzureLocation? location, IDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            AccountEndpoint = accountEndpoint;
            NodeManagementEndpoint = nodeManagementEndpoint;
            ProvisioningState = provisioningState;
            PoolAllocationMode = poolAllocationMode;
            KeyVaultReference = keyVaultReference;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkProfile = networkProfile;
            PrivateEndpointConnections = privateEndpointConnections;
            AutoStorage = autoStorage;
            Encryption = encryption;
            DedicatedCoreQuota = dedicatedCoreQuota;
            LowPriorityCoreQuota = lowPriorityCoreQuota;
            DedicatedCoreQuotaPerVmFamily = dedicatedCoreQuotaPerVmFamily;
            IsDedicatedCoreQuotaPerVmFamilyEnforced = isDedicatedCoreQuotaPerVmFamilyEnforced;
            PoolQuota = poolQuota;
            ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
            AllowedAuthenticationModes = allowedAuthenticationModes;
            Location = location;
            Tags = tags;
        }

        /// <summary> The identity of the Batch account. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The account endpoint used to interact with the Batch service. </summary>
        public string AccountEndpoint { get; }
        /// <summary> The endpoint used by compute node to connect to the Batch node management service. </summary>
        public string NodeManagementEndpoint { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public BatchProvisioningState? ProvisioningState { get; }
        /// <summary> The allocation mode for creating pools in the Batch account. </summary>
        public BatchAccountPoolAllocationMode? PoolAllocationMode { get; }
        /// <summary> Identifies the Azure key vault associated with a Batch account. </summary>
        public BatchKeyVaultReference KeyVaultReference { get; }
        /// <summary> If not specified, the default value is 'enabled'. </summary>
        public BatchPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The network profile only takes effect when publicNetworkAccess is enabled. </summary>
        public BatchNetworkProfile NetworkProfile { get; set; }
        /// <summary> List of private endpoint connections associated with the Batch account. </summary>
        public IReadOnlyList<BatchPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Contains information about the auto-storage account associated with a Batch account. </summary>
        public BatchAccountAutoStorageConfiguration AutoStorage { get; }
        /// <summary> Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead. </summary>
        public BatchAccountEncryptionConfiguration Encryption { get; }
        /// <summary> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </summary>
        public int? DedicatedCoreQuota { get; }
        /// <summary> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </summary>
        public int? LowPriorityCoreQuota { get; }
        /// <summary> A list of the dedicated core quota per Virtual Machine family for the Batch account. For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </summary>
        public IReadOnlyList<BatchVmFamilyCoreQuota> DedicatedCoreQuotaPerVmFamily { get; }
        /// <summary> If this flag is true, dedicated core quota is enforced via both the dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the account. If this flag is false, dedicated core quota is enforced only via the dedicatedCoreQuota property on the account and does not consider Virtual Machine family. </summary>
        public bool? IsDedicatedCoreQuotaPerVmFamilyEnforced { get; }
        /// <summary> The pool quota for the Batch account. </summary>
        public int? PoolQuota { get; }
        /// <summary> The active job and job schedule quota for the Batch account. </summary>
        public int? ActiveJobAndJobScheduleQuota { get; }
        /// <summary> List of allowed authentication modes for the Batch account that can be used to authenticate with the data plane. This does not affect authentication with the control plane. </summary>
        public IReadOnlyList<BatchAuthenticationMode> AllowedAuthenticationModes { get; }
        /// <summary> The location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The tags of the resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
