// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// The SKU (tier) of a workspace.
/// </summary>
public partial class OperationalInsightsWorkspaceSku : ProvisionableConstruct
{
    /// <summary>
    /// The name of the SKU.
    /// </summary>
    public BicepValue<OperationalInsightsWorkspaceSkuName> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<OperationalInsightsWorkspaceSkuName> _name;

    /// <summary>
    /// The capacity reservation level in GB for this workspace, when
    /// CapacityReservation sku is selected.
    /// </summary>
    public BicepValue<OperationalInsightsWorkspaceCapacityReservationLevel> CapacityReservationLevel { get => _capacityReservationLevel; set => _capacityReservationLevel.Assign(value); }
    private readonly BicepValue<OperationalInsightsWorkspaceCapacityReservationLevel> _capacityReservationLevel;

    /// <summary>
    /// The last time when the sku was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> LastSkuUpdatedOn { get => _lastSkuUpdatedOn; }
    private readonly BicepValue<DateTimeOffset> _lastSkuUpdatedOn;

    /// <summary>
    /// Creates a new OperationalInsightsWorkspaceSku.
    /// </summary>
    public OperationalInsightsWorkspaceSku()
    {
        _name = BicepValue<OperationalInsightsWorkspaceSkuName>.DefineProperty(this, "Name", ["name"]);
        _capacityReservationLevel = BicepValue<OperationalInsightsWorkspaceCapacityReservationLevel>.DefineProperty(this, "CapacityReservationLevel", ["capacityReservationLevel"]);
        _lastSkuUpdatedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastSkuUpdatedOn", ["lastSkuUpdate"], isOutput: true);
    }
}
