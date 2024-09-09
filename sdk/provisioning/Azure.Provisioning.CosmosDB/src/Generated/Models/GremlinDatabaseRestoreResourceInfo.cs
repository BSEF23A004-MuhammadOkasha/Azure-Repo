// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Specific Gremlin Databases to restore.
/// </summary>
public partial class GremlinDatabaseRestoreResourceInfo : ProvisioningConstruct
{
    /// <summary>
    /// The name of the gremlin database available for restore.
    /// </summary>
    public BicepValue<string> DatabaseName { get => _databaseName; set => _databaseName.Assign(value); }
    private readonly BicepValue<string> _databaseName;

    /// <summary>
    /// The names of the graphs available for restore.
    /// </summary>
    public BicepList<string> GraphNames { get => _graphNames; set => _graphNames.Assign(value); }
    private readonly BicepList<string> _graphNames;

    /// <summary>
    /// Creates a new GremlinDatabaseRestoreResourceInfo.
    /// </summary>
    public GremlinDatabaseRestoreResourceInfo()
    {
        _databaseName = BicepValue<string>.DefineProperty(this, "DatabaseName", ["databaseName"]);
        _graphNames = BicepList<string>.DefineProperty(this, "GraphNames", ["graphNames"]);
    }
}
