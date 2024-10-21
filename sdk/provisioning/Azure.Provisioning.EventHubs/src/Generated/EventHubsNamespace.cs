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

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsNamespace.
/// </summary>
public partial class EventHubsNamespace : ProvisionableResource
{
    /// <summary>
    /// The Namespace name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Alternate name specified when alias and namespace names are same.
    /// </summary>
    public BicepValue<string> AlternateName { get => _alternateName; set => _alternateName.Assign(value); }
    private readonly BicepValue<string> _alternateName;

    /// <summary>
    /// Cluster ARM ID of the Namespace.
    /// </summary>
    public BicepValue<ResourceIdentifier> ClusterArmId { get => _clusterArmId; set => _clusterArmId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _clusterArmId;

    /// <summary>
    /// This property disables SAS authentication for the Event Hubs namespace.
    /// </summary>
    public BicepValue<bool> DisableLocalAuth { get => _disableLocalAuth; set => _disableLocalAuth.Assign(value); }
    private readonly BicepValue<bool> _disableLocalAuth;

    /// <summary>
    /// Properties of BYOK Encryption description.
    /// </summary>
    public BicepValue<EventHubsEncryption> Encryption { get => _encryption; set => _encryption.Assign(value); }
    private readonly BicepValue<EventHubsEncryption> _encryption;

    /// <summary>
    /// Geo Data Replication settings for the namespace.
    /// </summary>
    public BicepValue<NamespaceGeoDataReplicationProperties> GeoDataReplication { get => _geoDataReplication; set => _geoDataReplication.Assign(value); }
    private readonly BicepValue<NamespaceGeoDataReplicationProperties> _geoDataReplication;

    /// <summary>
    /// Properties of BYOK Identity description.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Value that indicates whether AutoInflate is enabled for eventhub
    /// namespace.
    /// </summary>
    public BicepValue<bool> IsAutoInflateEnabled { get => _isAutoInflateEnabled; set => _isAutoInflateEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAutoInflateEnabled;

    /// <summary>
    /// Value that indicates whether Kafka is enabled for eventhub namespace.
    /// </summary>
    public BicepValue<bool> KafkaEnabled { get => _kafkaEnabled; set => _kafkaEnabled.Assign(value); }
    private readonly BicepValue<bool> _kafkaEnabled;

    /// <summary>
    /// Upper limit of throughput units when AutoInflate is enabled, value
    /// should be within 0 to 20 throughput units. ( &apos;0&apos; if
    /// AutoInflateEnabled = true).
    /// </summary>
    public BicepValue<int> MaximumThroughputUnits { get => _maximumThroughputUnits; set => _maximumThroughputUnits.Assign(value); }
    private readonly BicepValue<int> _maximumThroughputUnits;

    /// <summary>
    /// The minimum TLS version for the cluster to support, e.g.
    /// &apos;1.2&apos;.
    /// </summary>
    public BicepValue<EventHubsTlsVersion> MinimumTlsVersion { get => _minimumTlsVersion; set => _minimumTlsVersion.Assign(value); }
    private readonly BicepValue<EventHubsTlsVersion> _minimumTlsVersion;

    /// <summary>
    /// List of private endpoint connections.
    /// </summary>
    public BicepList<EventHubsPrivateEndpointConnectionData> PrivateEndpointConnections { get => _privateEndpointConnections; set => _privateEndpointConnections.Assign(value); }
    private readonly BicepList<EventHubsPrivateEndpointConnectionData> _privateEndpointConnections;

    /// <summary>
    /// This determines if traffic is allowed over public network. By default
    /// it is enabled.
    /// </summary>
    public BicepValue<EventHubsPublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<EventHubsPublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// Properties of sku resource.
    /// </summary>
    public BicepValue<EventHubsSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<EventHubsSku> _sku;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Enabling this property creates a Standard Event Hubs Namespace in
    /// regions supported availability zones.
    /// </summary>
    public BicepValue<bool> ZoneRedundant { get => _zoneRedundant; set => _zoneRedundant.Assign(value); }
    private readonly BicepValue<bool> _zoneRedundant;

    /// <summary>
    /// The time the Namespace was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Identifier for Azure Insights metrics.
    /// </summary>
    public BicepValue<string> MetricId { get => _metricId; }
    private readonly BicepValue<string> _metricId;

    /// <summary>
    /// Provisioning state of the Namespace.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// Endpoint you can use to perform Service Bus operations.
    /// </summary>
    public BicepValue<string> ServiceBusEndpoint { get => _serviceBusEndpoint; }
    private readonly BicepValue<string> _serviceBusEndpoint;

    /// <summary>
    /// Status of the Namespace.
    /// </summary>
    public BicepValue<string> Status { get => _status; }
    private readonly BicepValue<string> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The time the Namespace was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> UpdatedOn { get => _updatedOn; }
    private readonly BicepValue<DateTimeOffset> _updatedOn;

    /// <summary>
    /// Creates a new EventHubsNamespace.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsNamespace resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsNamespace.</param>
    public EventHubsNamespace(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventHub/namespaces", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _alternateName = BicepValue<string>.DefineProperty(this, "AlternateName", ["properties", "alternateName"]);
        _clusterArmId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ClusterArmId", ["properties", "clusterArmId"]);
        _disableLocalAuth = BicepValue<bool>.DefineProperty(this, "DisableLocalAuth", ["properties", "disableLocalAuth"]);
        _encryption = BicepValue<EventHubsEncryption>.DefineProperty(this, "Encryption", ["properties", "encryption"]);
        _geoDataReplication = BicepValue<NamespaceGeoDataReplicationProperties>.DefineProperty(this, "GeoDataReplication", ["properties", "geoDataReplication"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _isAutoInflateEnabled = BicepValue<bool>.DefineProperty(this, "IsAutoInflateEnabled", ["properties", "isAutoInflateEnabled"]);
        _kafkaEnabled = BicepValue<bool>.DefineProperty(this, "KafkaEnabled", ["properties", "kafkaEnabled"]);
        _maximumThroughputUnits = BicepValue<int>.DefineProperty(this, "MaximumThroughputUnits", ["properties", "maximumThroughputUnits"]);
        _minimumTlsVersion = BicepValue<EventHubsTlsVersion>.DefineProperty(this, "MinimumTlsVersion", ["properties", "minimumTlsVersion"]);
        _privateEndpointConnections = BicepList<EventHubsPrivateEndpointConnectionData>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"]);
        _publicNetworkAccess = BicepValue<EventHubsPublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _sku = BicepValue<EventHubsSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _zoneRedundant = BicepValue<bool>.DefineProperty(this, "ZoneRedundant", ["properties", "zoneRedundant"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdAt"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _metricId = BicepValue<string>.DefineProperty(this, "MetricId", ["properties", "metricId"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _serviceBusEndpoint = BicepValue<string>.DefineProperty(this, "ServiceBusEndpoint", ["properties", "serviceBusEndpoint"], isOutput: true);
        _status = BicepValue<string>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _updatedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "UpdatedOn", ["properties", "updatedAt"], isOutput: true);
    }

    /// <summary>
    /// Supported EventHubsNamespace resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2014-09-01.
        /// </summary>
        public static readonly string V2014_09_01 = "2014-09-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventHubsNamespace.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsNamespace resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsNamespace.</param>
    /// <returns>The existing EventHubsNamespace resource.</returns>
    public static EventHubsNamespace FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this EventHubsNamespace resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 256, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this EventHubsNamespace.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(EventHubsBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{EventHubsBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// EventHubsNamespace.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(EventHubsBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{EventHubsBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
