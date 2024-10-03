// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// ContainerServicePrivateEndpointConnection.
/// </summary>
public partial class ContainerServicePrivateEndpointConnection : Resource
{
    /// <summary>
    /// The name of the private endpoint connection.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// A collection of information about the state of the connection between
    /// service consumer and provider.
    /// </summary>
    public BicepValue<ContainerServicePrivateLinkServiceConnectionState> ConnectionState { get => _connectionState; set => _connectionState.Assign(value); }
    private readonly BicepValue<ContainerServicePrivateLinkServiceConnectionState> _connectionState;

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
    /// The current provisioning state.
    /// </summary>
    public BicepValue<ContainerServicePrivateEndpointConnectionProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerServicePrivateEndpointConnectionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerServiceManagedCluster.
    /// </summary>
    public ContainerServiceManagedCluster? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerServiceManagedCluster> _parent;

    /// <summary>
    /// Creates a new ContainerServicePrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerServicePrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the ContainerServicePrivateEndpointConnection.</param>
    public ContainerServicePrivateEndpointConnection(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.ContainerService/managedClusters/privateEndpointConnections", resourceVersion ?? "2024-08-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectionState = BicepValue<ContainerServicePrivateLinkServiceConnectionState>.DefineProperty(this, "ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<ContainerServicePrivateEndpointConnectionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerServiceManagedCluster>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerServicePrivateEndpointConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-02-preview.
        /// </summary>
        public static readonly string V2024_08_02_preview = "2024-08-02-preview";

        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2024-07-01.
        /// </summary>
        public static readonly string V2024_07_01 = "2024-07-01";

        /// <summary>
        /// 2024-06-01.
        /// </summary>
        public static readonly string V2024_06_01 = "2024-06-01";

        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2024-02-01.
        /// </summary>
        public static readonly string V2024_02_01 = "2024-02-01";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-11-01.
        /// </summary>
        public static readonly string V2023_11_01 = "2023-11-01";

        /// <summary>
        /// 2023-10-01.
        /// </summary>
        public static readonly string V2023_10_01 = "2023-10-01";

        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-06-01.
        /// </summary>
        public static readonly string V2023_06_01 = "2023-06-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-08-01.
        /// </summary>
        public static readonly string V2022_08_01 = "2022-08-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-04-01.
        /// </summary>
        public static readonly string V2022_04_01 = "2022-04-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2022-02-01.
        /// </summary>
        public static readonly string V2022_02_01 = "2022-02-01";

        /// <summary>
        /// 2022-01-01.
        /// </summary>
        public static readonly string V2022_01_01 = "2022-01-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-07-01.
        /// </summary>
        public static readonly string V2021_07_01 = "2021-07-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-11-01.
        /// </summary>
        public static readonly string V2020_11_01 = "2020-11-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-07-01.
        /// </summary>
        public static readonly string V2020_07_01 = "2020-07-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2020-02-01.
        /// </summary>
        public static readonly string V2020_02_01 = "2020-02-01";

        /// <summary>
        /// 2020-01-01.
        /// </summary>
        public static readonly string V2020_01_01 = "2020-01-01";

        /// <summary>
        /// 2019-11-01.
        /// </summary>
        public static readonly string V2019_11_01 = "2019-11-01";

        /// <summary>
        /// 2019-10-01.
        /// </summary>
        public static readonly string V2019_10_01 = "2019-10-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2019-02-01.
        /// </summary>
        public static readonly string V2019_02_01 = "2019-02-01";

        /// <summary>
        /// 2018-03-31.
        /// </summary>
        public static readonly string V2018_03_31 = "2018-03-31";

        /// <summary>
        /// 2017-08-31.
        /// </summary>
        public static readonly string V2017_08_31 = "2017-08-31";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ContainerServicePrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerServicePrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the ContainerServicePrivateEndpointConnection.</param>
    /// <returns>The existing ContainerServicePrivateEndpointConnection resource.</returns>
    public static ContainerServicePrivateEndpointConnection FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
