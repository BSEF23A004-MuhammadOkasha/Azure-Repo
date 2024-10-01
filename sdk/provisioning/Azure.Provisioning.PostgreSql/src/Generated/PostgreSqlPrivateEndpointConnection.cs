// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlPrivateEndpointConnection.
/// </summary>
public partial class PostgreSqlPrivateEndpointConnection : Resource
{
    /// <summary>
    /// The System.String to use.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Connection state of the private endpoint connection.
    /// </summary>
    public BicepValue<PostgreSqlPrivateLinkServiceConnectionStateProperty> ConnectionState { get => _connectionState; set => _connectionState.Assign(value); }
    private readonly BicepValue<PostgreSqlPrivateLinkServiceConnectionStateProperty> _connectionState;

    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; set => _privateEndpointId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// State of the private endpoint connection.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlServer.
    /// </summary>
    public PostgreSqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<PostgreSqlServer> _parent;

    /// <summary>
    /// Creates a new PostgreSqlPrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the PostgreSqlPrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the PostgreSqlPrivateEndpointConnection.</param>
    public PostgreSqlPrivateEndpointConnection(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.DBforPostgreSQL/servers/privateEndpointConnections", resourceVersion ?? "2018-06-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectionState = BicepValue<PostgreSqlPrivateLinkServiceConnectionStateProperty>.DefineProperty(this, "ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<PostgreSqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlPrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2018-06-01-privatepreview.
        /// </summary>
        public static readonly string V2018_06_01_privatepreview = "2018-06-01-privatepreview";

        /// <summary>
        /// 2018-06-01.
        /// </summary>
        public static readonly string V2018_06_01 = "2018-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing PostgreSqlPrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the PostgreSqlPrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the PostgreSqlPrivateEndpointConnection.</param>
    /// <returns>The existing PostgreSqlPrivateEndpointConnection resource.</returns>
    public static PostgreSqlPrivateEndpointConnection FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
