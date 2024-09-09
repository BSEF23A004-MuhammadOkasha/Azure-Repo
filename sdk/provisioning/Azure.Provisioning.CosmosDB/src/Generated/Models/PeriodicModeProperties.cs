// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Configuration values for periodic mode backup.
/// </summary>
public partial class PeriodicModeProperties : ProvisioningConstruct
{
    /// <summary>
    /// An integer representing the interval in minutes between two backups.
    /// </summary>
    public BicepValue<int> BackupIntervalInMinutes { get => _backupIntervalInMinutes; set => _backupIntervalInMinutes.Assign(value); }
    private readonly BicepValue<int> _backupIntervalInMinutes;

    /// <summary>
    /// An integer representing the time (in hours) that each backup is
    /// retained.
    /// </summary>
    public BicepValue<int> BackupRetentionIntervalInHours { get => _backupRetentionIntervalInHours; set => _backupRetentionIntervalInHours.Assign(value); }
    private readonly BicepValue<int> _backupRetentionIntervalInHours;

    /// <summary>
    /// Enum to indicate type of backup residency.
    /// </summary>
    public BicepValue<CosmosDBBackupStorageRedundancy> BackupStorageRedundancy { get => _backupStorageRedundancy; set => _backupStorageRedundancy.Assign(value); }
    private readonly BicepValue<CosmosDBBackupStorageRedundancy> _backupStorageRedundancy;

    /// <summary>
    /// Creates a new PeriodicModeProperties.
    /// </summary>
    public PeriodicModeProperties()
    {
        _backupIntervalInMinutes = BicepValue<int>.DefineProperty(this, "BackupIntervalInMinutes", ["backupIntervalInMinutes"]);
        _backupRetentionIntervalInHours = BicepValue<int>.DefineProperty(this, "BackupRetentionIntervalInHours", ["backupRetentionIntervalInHours"]);
        _backupStorageRedundancy = BicepValue<CosmosDBBackupStorageRedundancy>.DefineProperty(this, "BackupStorageRedundancy", ["backupStorageRedundancy"]);
    }
}
