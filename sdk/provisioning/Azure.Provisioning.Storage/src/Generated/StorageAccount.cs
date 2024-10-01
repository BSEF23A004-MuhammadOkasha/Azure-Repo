// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Storage;

/// <summary>
/// StorageAccount.
/// </summary>
public partial class StorageAccount : Resource
{
    /// <summary>
    /// The name of the storage account within the specified resource group.
    /// Storage account names must be between 3 and 24 characters in length
    /// and use numbers and lower-case letters only.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Required. Indicates the type of storage account.
    /// </summary>
    public BicepValue<StorageKind> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<StorageKind> _kind;

    /// <summary>
    /// Required. Gets or sets the location of the resource. This will be one
    /// of the supported and registered Azure Geo Regions (e.g. West US, East
    /// US, Southeast Asia, etc.). The geo region of a resource cannot be
    /// changed once it is created, but if an identical geo region is
    /// specified on update, the request will succeed.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Required. Gets or sets the SKU name.
    /// </summary>
    public BicepValue<StorageSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<StorageSku> _sku;

    /// <summary>
    /// Required for storage accounts where kind = BlobStorage. The access tier
    /// is used for billing. The &apos;Premium&apos; access tier is the
    /// default value for premium block blobs storage account type and it
    /// cannot be changed for the premium block blobs storage account type.
    /// </summary>
    public BicepValue<StorageAccountAccessTier> AccessTier { get => _accessTier; set => _accessTier.Assign(value); }
    private readonly BicepValue<StorageAccountAccessTier> _accessTier;

    /// <summary>
    /// Allow or disallow public access to all blobs or containers in the
    /// storage account. The default interpretation is true for this property.
    /// </summary>
    public BicepValue<bool> AllowBlobPublicAccess { get => _allowBlobPublicAccess; set => _allowBlobPublicAccess.Assign(value); }
    private readonly BicepValue<bool> _allowBlobPublicAccess;

    /// <summary>
    /// Allow or disallow cross AAD tenant object replication. The default
    /// interpretation is true for this property.
    /// </summary>
    public BicepValue<bool> AllowCrossTenantReplication { get => _allowCrossTenantReplication; set => _allowCrossTenantReplication.Assign(value); }
    private readonly BicepValue<bool> _allowCrossTenantReplication;

    /// <summary>
    /// Restrict copy to and from Storage Accounts within an AAD tenant or with
    /// Private Links to the same VNet.
    /// </summary>
    public BicepValue<AllowedCopyScope> AllowedCopyScope { get => _allowedCopyScope; set => _allowedCopyScope.Assign(value); }
    private readonly BicepValue<AllowedCopyScope> _allowedCopyScope;

    /// <summary>
    /// Indicates whether the storage account permits requests to be authorized
    /// with the account access key via Shared Key. If false, then all
    /// requests, including shared access signatures, must be authorized with
    /// Azure Active Directory (Azure AD). The default value is null, which is
    /// equivalent to true.
    /// </summary>
    public BicepValue<bool> AllowSharedKeyAccess { get => _allowSharedKeyAccess; set => _allowSharedKeyAccess.Assign(value); }
    private readonly BicepValue<bool> _allowSharedKeyAccess;

    /// <summary>
    /// Provides the identity based authentication settings for Azure Files.
    /// </summary>
    public BicepValue<FilesIdentityBasedAuthentication> AzureFilesIdentityBasedAuthentication { get => _azureFilesIdentityBasedAuthentication; set => _azureFilesIdentityBasedAuthentication.Assign(value); }
    private readonly BicepValue<FilesIdentityBasedAuthentication> _azureFilesIdentityBasedAuthentication;

    /// <summary>
    /// User domain assigned to the storage account. Name is the CNAME source.
    /// Only one custom domain is supported per storage account at this time.
    /// To clear the existing custom domain, use an empty string for the
    /// custom domain name property.
    /// </summary>
    public BicepValue<StorageCustomDomain> CustomDomain { get => _customDomain; set => _customDomain.Assign(value); }
    private readonly BicepValue<StorageCustomDomain> _customDomain;

    /// <summary>
    /// Allows you to specify the type of endpoint. Set this to AzureDNSZone to
    /// create a large number of accounts in a single subscription, which
    /// creates accounts in an Azure DNS Zone and the endpoint URL will have
    /// an alphanumeric DNS Zone identifier.
    /// </summary>
    public BicepValue<StorageDnsEndpointType> DnsEndpointType { get => _dnsEndpointType; set => _dnsEndpointType.Assign(value); }
    private readonly BicepValue<StorageDnsEndpointType> _dnsEndpointType;

    /// <summary>
    /// Allows https traffic only to storage service if sets to true. The
    /// default value is true since API version 2019-04-01.
    /// </summary>
    public BicepValue<bool> EnableHttpsTrafficOnly { get => _enableHttpsTrafficOnly; set => _enableHttpsTrafficOnly.Assign(value); }
    private readonly BicepValue<bool> _enableHttpsTrafficOnly;

    /// <summary>
    /// Encryption settings to be used for server-side encryption for the
    /// storage account.
    /// </summary>
    public BicepValue<StorageAccountEncryption> Encryption { get => _encryption; set => _encryption.Assign(value); }
    private readonly BicepValue<StorageAccountEncryption> _encryption;

    /// <summary>
    /// Optional. Set the extended location of the resource. If not set, the
    /// storage account will be created in Azure main region. Otherwise it
    /// will be created in the specified extended location.
    /// </summary>
    public BicepValue<ExtendedAzureLocation> ExtendedLocation { get => _extendedLocation; set => _extendedLocation.Assign(value); }
    private readonly BicepValue<ExtendedAzureLocation> _extendedLocation;

    /// <summary>
    /// The identity of the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// The property is immutable and can only be set to true at the account
    /// creation time. When set to true, it enables object level immutability
    /// for all the new containers in the account by default.
    /// </summary>
    public BicepValue<ImmutableStorageAccount> ImmutableStorageWithVersioning { get => _immutableStorageWithVersioning; set => _immutableStorageWithVersioning.Assign(value); }
    private readonly BicepValue<ImmutableStorageAccount> _immutableStorageWithVersioning;

    /// <summary>
    /// A boolean flag which indicates whether the default authentication is
    /// OAuth or not. The default interpretation is false for this property.
    /// </summary>
    public BicepValue<bool> IsDefaultToOAuthAuthentication { get => _isDefaultToOAuthAuthentication; set => _isDefaultToOAuthAuthentication.Assign(value); }
    private readonly BicepValue<bool> _isDefaultToOAuthAuthentication;

    /// <summary>
    /// Account HierarchicalNamespace enabled if sets to true.
    /// </summary>
    public BicepValue<bool> IsHnsEnabled { get => _isHnsEnabled; set => _isHnsEnabled.Assign(value); }
    private readonly BicepValue<bool> _isHnsEnabled;

    /// <summary>
    /// Enables local users feature, if set to true.
    /// </summary>
    public BicepValue<bool> IsLocalUserEnabled { get => _isLocalUserEnabled; set => _isLocalUserEnabled.Assign(value); }
    private readonly BicepValue<bool> _isLocalUserEnabled;

    /// <summary>
    /// NFS 3.0 protocol support enabled if set to true.
    /// </summary>
    public BicepValue<bool> IsNfsV3Enabled { get => _isNfsV3Enabled; set => _isNfsV3Enabled.Assign(value); }
    private readonly BicepValue<bool> _isNfsV3Enabled;

    /// <summary>
    /// Enables Secure File Transfer Protocol, if set to true.
    /// </summary>
    public BicepValue<bool> IsSftpEnabled { get => _isSftpEnabled; set => _isSftpEnabled.Assign(value); }
    private readonly BicepValue<bool> _isSftpEnabled;

    /// <summary>
    /// The key expiration period in days.
    /// </summary>
    public BicepValue<int> KeyExpirationPeriodInDays { get => _keyExpirationPeriodInDays; set => _keyExpirationPeriodInDays.Assign(value); }
    private readonly BicepValue<int> _keyExpirationPeriodInDays;

    /// <summary>
    /// Allow large file shares if sets to Enabled. It cannot be disabled once
    /// it is enabled.
    /// </summary>
    public BicepValue<LargeFileSharesState> LargeFileSharesState { get => _largeFileSharesState; set => _largeFileSharesState.Assign(value); }
    private readonly BicepValue<LargeFileSharesState> _largeFileSharesState;

    /// <summary>
    /// Set the minimum TLS version to be permitted on requests to storage. The
    /// default interpretation is TLS 1.0 for this property.
    /// </summary>
    public BicepValue<StorageMinimumTlsVersion> MinimumTlsVersion { get => _minimumTlsVersion; set => _minimumTlsVersion.Assign(value); }
    private readonly BicepValue<StorageMinimumTlsVersion> _minimumTlsVersion;

    /// <summary>
    /// Network rule set.
    /// </summary>
    public BicepValue<StorageAccountNetworkRuleSet> NetworkRuleSet { get => _networkRuleSet; set => _networkRuleSet.Assign(value); }
    private readonly BicepValue<StorageAccountNetworkRuleSet> _networkRuleSet;

    /// <summary>
    /// Allow or disallow public network access to Storage Account. Value is
    /// optional but if passed in, must be &apos;Enabled&apos; or
    /// &apos;Disabled&apos;.
    /// </summary>
    public BicepValue<StoragePublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<StoragePublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// Maintains information about the network routing choice opted by the
    /// user for data transfer.
    /// </summary>
    public BicepValue<StorageRoutingPreference> RoutingPreference { get => _routingPreference; set => _routingPreference.Assign(value); }
    private readonly BicepValue<StorageRoutingPreference> _routingPreference;

    /// <summary>
    /// SasPolicy assigned to the storage account.
    /// </summary>
    public BicepValue<StorageAccountSasPolicy> SasPolicy { get => _sasPolicy; set => _sasPolicy.Assign(value); }
    private readonly BicepValue<StorageAccountSasPolicy> _sasPolicy;

    /// <summary>
    /// Gets or sets a list of key value pairs that describe the resource.
    /// These tags can be used for viewing and grouping this resource (across
    /// resource groups). A maximum of 15 tags can be provided for a resource.
    /// Each tag must have a key with a length no greater than 128 characters
    /// and a value with a length no greater than 256 characters.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Blob restore status.
    /// </summary>
    public BicepValue<BlobRestoreStatus> BlobRestoreStatus { get => _blobRestoreStatus; }
    private readonly BicepValue<BlobRestoreStatus> _blobRestoreStatus;

    /// <summary>
    /// Gets the creation date and time of the storage account in UTC.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Geo Replication Stats.
    /// </summary>
    public BicepValue<GeoReplicationStatistics> GeoReplicationStats { get => _geoReplicationStats; }
    private readonly BicepValue<GeoReplicationStatistics> _geoReplicationStats;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// If the failover is in progress, the value will be true, otherwise, it
    /// will be null.
    /// </summary>
    public BicepValue<bool> IsFailoverInProgress { get => _isFailoverInProgress; }
    private readonly BicepValue<bool> _isFailoverInProgress;

    /// <summary>
    /// Storage account keys creation time.
    /// </summary>
    public BicepValue<StorageAccountKeyCreationTime> KeyCreationTime { get => _keyCreationTime; }
    private readonly BicepValue<StorageAccountKeyCreationTime> _keyCreationTime;

    /// <summary>
    /// Gets the timestamp of the most recent instance of a failover to the
    /// secondary location. Only the most recent timestamp is retained. This
    /// element is not returned if there has never been a failover instance.
    /// Only available if the accountType is Standard_GRS or Standard_RAGRS.
    /// </summary>
    public BicepValue<DateTimeOffset> LastGeoFailoverOn { get => _lastGeoFailoverOn; }
    private readonly BicepValue<DateTimeOffset> _lastGeoFailoverOn;

    /// <summary>
    /// Gets the URLs that are used to perform a retrieval of a public blob,
    /// queue, or table object. Note that Standard_ZRS and Premium_LRS
    /// accounts only return the blob endpoint.
    /// </summary>
    public BicepValue<StorageAccountEndpoints> PrimaryEndpoints { get => _primaryEndpoints; }
    private readonly BicepValue<StorageAccountEndpoints> _primaryEndpoints;

    /// <summary>
    /// Gets the location of the primary data center for the storage account.
    /// </summary>
    public BicepValue<AzureLocation> PrimaryLocation { get => _primaryLocation; }
    private readonly BicepValue<AzureLocation> _primaryLocation;

    /// <summary>
    /// List of private endpoint connection associated with the specified
    /// storage account.
    /// </summary>
    public BicepList<StoragePrivateEndpointConnectionData> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<StoragePrivateEndpointConnectionData> _privateEndpointConnections;

    /// <summary>
    /// Gets the status of the storage account at the time the operation was
    /// called.
    /// </summary>
    public BicepValue<StorageProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<StorageProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the URLs that are used to perform a retrieval of a public blob,
    /// queue, or table object from the secondary location of the storage
    /// account. Only available if the SKU name is Standard_RAGRS.
    /// </summary>
    public BicepValue<StorageAccountEndpoints> SecondaryEndpoints { get => _secondaryEndpoints; }
    private readonly BicepValue<StorageAccountEndpoints> _secondaryEndpoints;

    /// <summary>
    /// Gets the location of the geo-replicated secondary for the storage
    /// account. Only available if the accountType is Standard_GRS or
    /// Standard_RAGRS.
    /// </summary>
    public BicepValue<AzureLocation> SecondaryLocation { get => _secondaryLocation; }
    private readonly BicepValue<AzureLocation> _secondaryLocation;

    /// <summary>
    /// Gets the status indicating whether the primary location of the storage
    /// account is available or unavailable.
    /// </summary>
    public BicepValue<StorageAccountStatus> StatusOfPrimary { get => _statusOfPrimary; }
    private readonly BicepValue<StorageAccountStatus> _statusOfPrimary;

    /// <summary>
    /// Gets the status indicating whether the secondary location of the
    /// storage account is available or unavailable. Only available if the SKU
    /// name is Standard_GRS or Standard_RAGRS.
    /// </summary>
    public BicepValue<StorageAccountStatus> StatusOfSecondary { get => _statusOfSecondary; }
    private readonly BicepValue<StorageAccountStatus> _statusOfSecondary;

    /// <summary>
    /// This property is readOnly and is set by server during asynchronous
    /// storage account sku conversion operations.
    /// </summary>
    public BicepValue<StorageAccountSkuConversionStatus> StorageAccountSkuConversionStatus { get => _storageAccountSkuConversionStatus; }
    private readonly BicepValue<StorageAccountSkuConversionStatus> _storageAccountSkuConversionStatus;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new StorageAccount.
    /// </summary>
    /// <param name="resourceName">Name of the StorageAccount.</param>
    /// <param name="resourceVersion">Version of the StorageAccount.</param>
    public StorageAccount(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Storage/storageAccounts", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _kind = BicepValue<StorageKind>.DefineProperty(this, "Kind", ["kind"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _sku = BicepValue<StorageSku>.DefineProperty(this, "Sku", ["sku"], isRequired: true);
        _accessTier = BicepValue<StorageAccountAccessTier>.DefineProperty(this, "AccessTier", ["properties", "accessTier"]);
        _allowBlobPublicAccess = BicepValue<bool>.DefineProperty(this, "AllowBlobPublicAccess", ["properties", "allowBlobPublicAccess"]);
        _allowCrossTenantReplication = BicepValue<bool>.DefineProperty(this, "AllowCrossTenantReplication", ["properties", "allowCrossTenantReplication"]);
        _allowedCopyScope = BicepValue<AllowedCopyScope>.DefineProperty(this, "AllowedCopyScope", ["properties", "allowedCopyScope"]);
        _allowSharedKeyAccess = BicepValue<bool>.DefineProperty(this, "AllowSharedKeyAccess", ["properties", "allowSharedKeyAccess"]);
        _azureFilesIdentityBasedAuthentication = BicepValue<FilesIdentityBasedAuthentication>.DefineProperty(this, "AzureFilesIdentityBasedAuthentication", ["properties", "azureFilesIdentityBasedAuthentication"]);
        _customDomain = BicepValue<StorageCustomDomain>.DefineProperty(this, "CustomDomain", ["properties", "customDomain"]);
        _dnsEndpointType = BicepValue<StorageDnsEndpointType>.DefineProperty(this, "DnsEndpointType", ["properties", "dnsEndpointType"]);
        _enableHttpsTrafficOnly = BicepValue<bool>.DefineProperty(this, "EnableHttpsTrafficOnly", ["properties", "supportsHttpsTrafficOnly"]);
        _encryption = BicepValue<StorageAccountEncryption>.DefineProperty(this, "Encryption", ["properties", "encryption"]);
        _extendedLocation = BicepValue<ExtendedAzureLocation>.DefineProperty(this, "ExtendedLocation", ["extendedLocation"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _immutableStorageWithVersioning = BicepValue<ImmutableStorageAccount>.DefineProperty(this, "ImmutableStorageWithVersioning", ["properties", "immutableStorageWithVersioning"]);
        _isDefaultToOAuthAuthentication = BicepValue<bool>.DefineProperty(this, "IsDefaultToOAuthAuthentication", ["properties", "defaultToOAuthAuthentication"]);
        _isHnsEnabled = BicepValue<bool>.DefineProperty(this, "IsHnsEnabled", ["properties", "isHnsEnabled"]);
        _isLocalUserEnabled = BicepValue<bool>.DefineProperty(this, "IsLocalUserEnabled", ["properties", "isLocalUserEnabled"]);
        _isNfsV3Enabled = BicepValue<bool>.DefineProperty(this, "IsNfsV3Enabled", ["properties", "isNfsV3Enabled"]);
        _isSftpEnabled = BicepValue<bool>.DefineProperty(this, "IsSftpEnabled", ["properties", "isSftpEnabled"]);
        _keyExpirationPeriodInDays = BicepValue<int>.DefineProperty(this, "KeyExpirationPeriodInDays", ["properties", "keyPolicy", "keyExpirationPeriodInDays"]);
        _largeFileSharesState = BicepValue<LargeFileSharesState>.DefineProperty(this, "LargeFileSharesState", ["properties", "largeFileSharesState"]);
        _minimumTlsVersion = BicepValue<StorageMinimumTlsVersion>.DefineProperty(this, "MinimumTlsVersion", ["properties", "minimumTlsVersion"]);
        _networkRuleSet = BicepValue<StorageAccountNetworkRuleSet>.DefineProperty(this, "NetworkRuleSet", ["properties", "networkAcls"]);
        _publicNetworkAccess = BicepValue<StoragePublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _routingPreference = BicepValue<StorageRoutingPreference>.DefineProperty(this, "RoutingPreference", ["properties", "routingPreference"]);
        _sasPolicy = BicepValue<StorageAccountSasPolicy>.DefineProperty(this, "SasPolicy", ["properties", "sasPolicy"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _blobRestoreStatus = BicepValue<BlobRestoreStatus>.DefineProperty(this, "BlobRestoreStatus", ["properties", "blobRestoreStatus"], isOutput: true);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "creationTime"], isOutput: true);
        _geoReplicationStats = BicepValue<GeoReplicationStatistics>.DefineProperty(this, "GeoReplicationStats", ["properties", "geoReplicationStats"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _isFailoverInProgress = BicepValue<bool>.DefineProperty(this, "IsFailoverInProgress", ["properties", "failoverInProgress"], isOutput: true);
        _keyCreationTime = BicepValue<StorageAccountKeyCreationTime>.DefineProperty(this, "KeyCreationTime", ["properties", "keyCreationTime"], isOutput: true);
        _lastGeoFailoverOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastGeoFailoverOn", ["properties", "lastGeoFailoverTime"], isOutput: true);
        _primaryEndpoints = BicepValue<StorageAccountEndpoints>.DefineProperty(this, "PrimaryEndpoints", ["properties", "primaryEndpoints"], isOutput: true);
        _primaryLocation = BicepValue<AzureLocation>.DefineProperty(this, "PrimaryLocation", ["properties", "primaryLocation"], isOutput: true);
        _privateEndpointConnections = BicepList<StoragePrivateEndpointConnectionData>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = BicepValue<StorageProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _secondaryEndpoints = BicepValue<StorageAccountEndpoints>.DefineProperty(this, "SecondaryEndpoints", ["properties", "secondaryEndpoints"], isOutput: true);
        _secondaryLocation = BicepValue<AzureLocation>.DefineProperty(this, "SecondaryLocation", ["properties", "secondaryLocation"], isOutput: true);
        _statusOfPrimary = BicepValue<StorageAccountStatus>.DefineProperty(this, "StatusOfPrimary", ["properties", "statusOfPrimary"], isOutput: true);
        _statusOfSecondary = BicepValue<StorageAccountStatus>.DefineProperty(this, "StatusOfSecondary", ["properties", "statusOfSecondary"], isOutput: true);
        _storageAccountSkuConversionStatus = BicepValue<StorageAccountSkuConversionStatus>.DefineProperty(this, "StorageAccountSkuConversionStatus", ["properties", "storageAccountSkuConversionStatus"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported StorageAccount resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-05-01.
        /// </summary>
        public static readonly string V2016_05_01 = "2016-05-01";

        /// <summary>
        /// 2016-01-01.
        /// </summary>
        public static readonly string V2016_01_01 = "2016-01-01";

        /// <summary>
        /// 2015-06-15.
        /// </summary>
        public static readonly string V2015_06_15 = "2015-06-15";
    }

    /// <summary>
    /// Creates a reference to an existing StorageAccount.
    /// </summary>
    /// <param name="resourceName">Name of the StorageAccount.</param>
    /// <param name="resourceVersion">Version of the StorageAccount.</param>
    /// <returns>The existing StorageAccount resource.</returns>
    public static StorageAccount FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this StorageAccount resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 24, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers);

    /// <summary>
    /// Get access keys for this StorageAccount resource.
    /// </summary>
    /// <returns>The keys for this StorageAccount resource.</returns>
    public BicepList<StorageAccountKey> GetKeys() =>
        BicepList<StorageAccountKey>.FromExpression(
            StorageAccountKey.FromExpression,
            new MemberExpression(new FunctionCallExpression(new MemberExpression(new IdentifierExpression(ResourceName), "listKeys")), "keys"));

    /// <summary>
    /// Assign a role to a user-assigned identity that grants access to this
    /// StorageAccount.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(StorageBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{ResourceName}_{identity.ResourceName}_{StorageBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Assign a role to a principal that grants access to this StorageAccount.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(StorageBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId) =>
        new($"{ResourceName}_{StorageBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
