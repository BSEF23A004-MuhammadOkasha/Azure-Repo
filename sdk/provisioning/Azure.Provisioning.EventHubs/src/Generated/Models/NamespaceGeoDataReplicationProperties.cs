// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// GeoDR Replication properties.
/// </summary>
public partial class NamespaceGeoDataReplicationProperties : ProvisioningConstruct
{
    /// <summary>
    /// The maximum acceptable lag for data replication operations from the
    /// primary replica to a quorum of secondary replicas.  When the lag
    /// exceeds the configured amount, operations on the primary replica will
    /// be failed. The allowed values are 0 and 5 minutes to 1 day.
    /// </summary>
    public BicepValue<int> MaxReplicationLagDurationInSeconds { get => _maxReplicationLagDurationInSeconds; set => _maxReplicationLagDurationInSeconds.Assign(value); }
    private readonly BicepValue<int> _maxReplicationLagDurationInSeconds;

    /// <summary>
    /// A list of regions where replicas of the namespace are maintained.
    /// </summary>
    public BicepList<NamespaceReplicaLocation> Locations { get => _locations; set => _locations.Assign(value); }
    private readonly BicepList<NamespaceReplicaLocation> _locations;

    /// <summary>
    /// Creates a new NamespaceGeoDataReplicationProperties.
    /// </summary>
    public NamespaceGeoDataReplicationProperties()
    {
        _maxReplicationLagDurationInSeconds = BicepValue<int>.DefineProperty(this, "MaxReplicationLagDurationInSeconds", ["maxReplicationLagDurationInSeconds"]);
        _locations = BicepList<NamespaceReplicaLocation>.DefineProperty(this, "Locations", ["locations"]);
    }
}
