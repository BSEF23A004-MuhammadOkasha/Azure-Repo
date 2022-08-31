// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    /// <summary> A class representing the Cluster data model. </summary>
    public partial class ClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ClusterData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ClusterData(AzureLocation location, AzureSku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            Zones = new ChangeTrackingList<string>();
            TrustedExternalTenants = new ChangeTrackingList<TrustedExternalTenant>();
            AllowedIPRangeList = new ChangeTrackingList<string>();
            AcceptedAudiences = new ChangeTrackingList<AcceptedAudiences>();
            AllowedFqdnList = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<KustoPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the cluster. </param>
        /// <param name="zones"> The availability zones of the cluster. </param>
        /// <param name="identity"> The identity of the cluster, if configured. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="state"> The state of the resource. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="uri"> The cluster URI. </param>
        /// <param name="dataIngestionUri"> The cluster data ingestion URI. </param>
        /// <param name="stateReason"> The reason for the cluster&apos;s current state. </param>
        /// <param name="trustedExternalTenants"> The cluster&apos;s external tenants. </param>
        /// <param name="optimizedAutoscale"> Optimized auto scale definition. </param>
        /// <param name="enableDiskEncryption"> A boolean value that indicates if the cluster&apos;s disks are encrypted. </param>
        /// <param name="enableStreamingIngest"> A boolean value that indicates if the streaming ingest is enabled. </param>
        /// <param name="virtualNetworkConfiguration"> Virtual network definition. </param>
        /// <param name="keyVaultProperties"> KeyVault properties for the cluster encryption. </param>
        /// <param name="enablePurge"> A boolean value that indicates if the purge operations are enabled. </param>
        /// <param name="languageExtensions"> List of the cluster&apos;s language extensions. </param>
        /// <param name="enableDoubleEncryption"> A boolean value that indicates if double encryption is enabled. </param>
        /// <param name="publicNetworkAccess"> Public network access to the cluster is enabled by default. When disabled, only private endpoint connection to the cluster is allowed. </param>
        /// <param name="allowedIPRangeList"> The list of ips in the format of CIDR allowed to connect to the cluster. </param>
        /// <param name="engineType"> The engine type. </param>
        /// <param name="acceptedAudiences"> The cluster&apos;s accepted audiences. </param>
        /// <param name="enableAutoStop"> A boolean value that indicates if the cluster could be automatically stopped (due to lack of data or no activity for many days). </param>
        /// <param name="restrictOutboundNetworkAccess"> Whether or not to restrict outbound network access.  Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        /// <param name="allowedFqdnList"> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster. </param>
        /// <param name="publicIPType"> Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). </param>
        /// <param name="virtualClusterGraduationProperties"> Virtual Cluster graduation properties. </param>
        /// <param name="privateEndpointConnections"> A list of private endpoint connections. </param>
        internal ClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AzureSku sku, IList<string> zones, ManagedServiceIdentity identity, ETag? etag, State? state, ProvisioningState? provisioningState, Uri uri, Uri dataIngestionUri, string stateReason, IList<TrustedExternalTenant> trustedExternalTenants, OptimizedAutoscale optimizedAutoscale, bool? enableDiskEncryption, bool? enableStreamingIngest, VirtualNetworkConfiguration virtualNetworkConfiguration, Models.KeyVaultProperties keyVaultProperties, bool? enablePurge, LanguageExtensionsList languageExtensions, bool? enableDoubleEncryption, PublicNetworkAccess? publicNetworkAccess, IList<string> allowedIPRangeList, EngineType? engineType, IList<AcceptedAudiences> acceptedAudiences, bool? enableAutoStop, ClusterNetworkAccessFlag? restrictOutboundNetworkAccess, IList<string> allowedFqdnList, PublicIPType? publicIPType, string virtualClusterGraduationProperties, IReadOnlyList<KustoPrivateEndpointConnectionData> privateEndpointConnections) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Zones = zones;
            Identity = identity;
            ETag = etag;
            State = state;
            ProvisioningState = provisioningState;
            Uri = uri;
            DataIngestionUri = dataIngestionUri;
            StateReason = stateReason;
            TrustedExternalTenants = trustedExternalTenants;
            OptimizedAutoscale = optimizedAutoscale;
            EnableDiskEncryption = enableDiskEncryption;
            EnableStreamingIngest = enableStreamingIngest;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            KeyVaultProperties = keyVaultProperties;
            EnablePurge = enablePurge;
            LanguageExtensions = languageExtensions;
            EnableDoubleEncryption = enableDoubleEncryption;
            PublicNetworkAccess = publicNetworkAccess;
            AllowedIPRangeList = allowedIPRangeList;
            EngineType = engineType;
            AcceptedAudiences = acceptedAudiences;
            EnableAutoStop = enableAutoStop;
            RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
            AllowedFqdnList = allowedFqdnList;
            PublicIPType = publicIPType;
            VirtualClusterGraduationProperties = virtualClusterGraduationProperties;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> The SKU of the cluster. </summary>
        public AzureSku Sku { get; set; }
        /// <summary> The availability zones of the cluster. </summary>
        public IList<string> Zones { get; }
        /// <summary> The identity of the cluster, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The state of the resource. </summary>
        public State? State { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The cluster URI. </summary>
        public Uri Uri { get; }
        /// <summary> The cluster data ingestion URI. </summary>
        public Uri DataIngestionUri { get; }
        /// <summary> The reason for the cluster&apos;s current state. </summary>
        public string StateReason { get; }
        /// <summary> The cluster&apos;s external tenants. </summary>
        public IList<TrustedExternalTenant> TrustedExternalTenants { get; }
        /// <summary> Optimized auto scale definition. </summary>
        public OptimizedAutoscale OptimizedAutoscale { get; set; }
        /// <summary> A boolean value that indicates if the cluster&apos;s disks are encrypted. </summary>
        public bool? EnableDiskEncryption { get; set; }
        /// <summary> A boolean value that indicates if the streaming ingest is enabled. </summary>
        public bool? EnableStreamingIngest { get; set; }
        /// <summary> Virtual network definition. </summary>
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }
        /// <summary> KeyVault properties for the cluster encryption. </summary>
        public Models.KeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> A boolean value that indicates if the purge operations are enabled. </summary>
        public bool? EnablePurge { get; set; }
        /// <summary> List of the cluster&apos;s language extensions. </summary>
        internal LanguageExtensionsList LanguageExtensions { get; }
        /// <summary> The list of language extensions. </summary>
        public IList<LanguageExtension> LanguageExtensionsValue
        {
            get => LanguageExtensions?.Value;
        }

        /// <summary> A boolean value that indicates if double encryption is enabled. </summary>
        public bool? EnableDoubleEncryption { get; set; }
        /// <summary> Public network access to the cluster is enabled by default. When disabled, only private endpoint connection to the cluster is allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The list of ips in the format of CIDR allowed to connect to the cluster. </summary>
        public IList<string> AllowedIPRangeList { get; }
        /// <summary> The engine type. </summary>
        public EngineType? EngineType { get; set; }
        /// <summary> The cluster&apos;s accepted audiences. </summary>
        public IList<AcceptedAudiences> AcceptedAudiences { get; }
        /// <summary> A boolean value that indicates if the cluster could be automatically stopped (due to lack of data or no activity for many days). </summary>
        public bool? EnableAutoStop { get; set; }
        /// <summary> Whether or not to restrict outbound network access.  Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public ClusterNetworkAccessFlag? RestrictOutboundNetworkAccess { get; set; }
        /// <summary> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster. </summary>
        public IList<string> AllowedFqdnList { get; }
        /// <summary> Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). </summary>
        public PublicIPType? PublicIPType { get; set; }
        /// <summary> Virtual Cluster graduation properties. </summary>
        public string VirtualClusterGraduationProperties { get; set; }
        /// <summary> A list of private endpoint connections. </summary>
        public IReadOnlyList<KustoPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
