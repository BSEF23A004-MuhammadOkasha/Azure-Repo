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

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// ContainerRegistryService.
/// </summary>
public partial class ContainerRegistryService : Resource
{
    /// <summary>
    /// The name of the container registry.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The SKU of the container registry.
    /// </summary>
    public BicepValue<ContainerRegistrySku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<ContainerRegistrySku> _sku;

    /// <summary>
    /// The encryption settings of container registry.
    /// </summary>
    public BicepValue<ContainerRegistryEncryption> Encryption { get => _encryption; set => _encryption.Assign(value); }
    private readonly BicepValue<ContainerRegistryEncryption> _encryption;

    /// <summary>
    /// The identity of the container registry.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// The value that indicates whether the admin user is enabled.
    /// </summary>
    public BicepValue<bool> IsAdminUserEnabled { get => _isAdminUserEnabled; set => _isAdminUserEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAdminUserEnabled;

    /// <summary>
    /// Enable a single data endpoint per region for serving data.
    /// </summary>
    public BicepValue<bool> IsDataEndpointEnabled { get => _isDataEndpointEnabled; set => _isDataEndpointEnabled.Assign(value); }
    private readonly BicepValue<bool> _isDataEndpointEnabled;

    /// <summary>
    /// Whether to allow trusted Azure services to access a network restricted
    /// registry.
    /// </summary>
    public BicepValue<ContainerRegistryNetworkRuleBypassOption> NetworkRuleBypassOptions { get => _networkRuleBypassOptions; set => _networkRuleBypassOptions.Assign(value); }
    private readonly BicepValue<ContainerRegistryNetworkRuleBypassOption> _networkRuleBypassOptions;

    /// <summary>
    /// The network rule set for a container registry.
    /// </summary>
    public BicepValue<ContainerRegistryNetworkRuleSet> NetworkRuleSet { get => _networkRuleSet; set => _networkRuleSet.Assign(value); }
    private readonly BicepValue<ContainerRegistryNetworkRuleSet> _networkRuleSet;

    /// <summary>
    /// The policies for a container registry.
    /// </summary>
    public BicepValue<ContainerRegistryPolicies> Policies { get => _policies; set => _policies.Assign(value); }
    private readonly BicepValue<ContainerRegistryPolicies> _policies;

    /// <summary>
    /// Whether or not public network access is allowed for the container
    /// registry.
    /// </summary>
    public BicepValue<ContainerRegistryPublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<ContainerRegistryPublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Whether or not zone redundancy is enabled for this container registry.
    /// </summary>
    public BicepValue<ContainerRegistryZoneRedundancy> ZoneRedundancy { get => _zoneRedundancy; set => _zoneRedundancy.Assign(value); }
    private readonly BicepValue<ContainerRegistryZoneRedundancy> _zoneRedundancy;

    /// <summary>
    /// The creation date of the container registry in ISO8601 format.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// List of host names that will serve data when dataEndpointEnabled is
    /// true.
    /// </summary>
    public BicepList<string> DataEndpointHostNames { get => _dataEndpointHostNames; }
    private readonly BicepList<string> _dataEndpointHostNames;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The URL that can be used to log into the container registry.
    /// </summary>
    public BicepValue<string> LoginServer { get => _loginServer; }
    private readonly BicepValue<string> _loginServer;

    /// <summary>
    /// List of private endpoint connections for a container registry.
    /// </summary>
    public BicepList<ContainerRegistryPrivateEndpointConnectionData> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<ContainerRegistryPrivateEndpointConnectionData> _privateEndpointConnections;

    /// <summary>
    /// The provisioning state of the container registry at the time the
    /// operation was called.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerRegistryProvisioningState> _provisioningState;

    /// <summary>
    /// The status of the container registry at the time the operation was
    /// called.
    /// </summary>
    public BicepValue<ContainerRegistryResourceStatus> Status { get => _status; }
    private readonly BicepValue<ContainerRegistryResourceStatus> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ContainerRegistryService.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerRegistryService.</param>
    /// <param name="resourceVersion">Version of the ContainerRegistryService.</param>
    public ContainerRegistryService(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.ContainerRegistry/registries", resourceVersion ?? "2023-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _sku = BicepValue<ContainerRegistrySku>.DefineProperty(this, "Sku", ["sku"], isRequired: true);
        _encryption = BicepValue<ContainerRegistryEncryption>.DefineProperty(this, "Encryption", ["properties", "encryption"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _isAdminUserEnabled = BicepValue<bool>.DefineProperty(this, "IsAdminUserEnabled", ["properties", "adminUserEnabled"]);
        _isDataEndpointEnabled = BicepValue<bool>.DefineProperty(this, "IsDataEndpointEnabled", ["properties", "dataEndpointEnabled"]);
        _networkRuleBypassOptions = BicepValue<ContainerRegistryNetworkRuleBypassOption>.DefineProperty(this, "NetworkRuleBypassOptions", ["properties", "networkRuleBypassOptions"]);
        _networkRuleSet = BicepValue<ContainerRegistryNetworkRuleSet>.DefineProperty(this, "NetworkRuleSet", ["properties", "networkRuleSet"]);
        _policies = BicepValue<ContainerRegistryPolicies>.DefineProperty(this, "Policies", ["properties", "policies"]);
        _publicNetworkAccess = BicepValue<ContainerRegistryPublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _zoneRedundancy = BicepValue<ContainerRegistryZoneRedundancy>.DefineProperty(this, "ZoneRedundancy", ["properties", "zoneRedundancy"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "creationDate"], isOutput: true);
        _dataEndpointHostNames = BicepList<string>.DefineProperty(this, "DataEndpointHostNames", ["properties", "dataEndpointHostNames"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _loginServer = BicepValue<string>.DefineProperty(this, "LoginServer", ["properties", "loginServer"], isOutput: true);
        _privateEndpointConnections = BicepList<ContainerRegistryPrivateEndpointConnectionData>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = BicepValue<ContainerRegistryProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _status = BicepValue<ContainerRegistryResourceStatus>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ContainerRegistryService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-11-01-preview.
        /// </summary>
        public static readonly string V2023_11_01_preview = "2023-11-01-preview";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2019-05-01.
        /// </summary>
        public static readonly string V2019_05_01 = "2019-05-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-03-01.
        /// </summary>
        public static readonly string V2017_03_01 = "2017-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryService.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerRegistryService.</param>
    /// <param name="resourceVersion">Version of the ContainerRegistryService.</param>
    /// <returns>The existing ContainerRegistryService resource.</returns>
    public static ContainerRegistryService FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerRegistryService resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 5, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers);

    /// <summary>
    /// Assign a role to a user-assigned identity that grants access to this
    /// ContainerRegistryService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(ContainerRegistryBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{ResourceName}_{identity.ResourceName}_{ContainerRegistryBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Assign a role to a principal that grants access to this
    /// ContainerRegistryService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(ContainerRegistryBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId) =>
        new($"{ResourceName}_{ContainerRegistryBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
